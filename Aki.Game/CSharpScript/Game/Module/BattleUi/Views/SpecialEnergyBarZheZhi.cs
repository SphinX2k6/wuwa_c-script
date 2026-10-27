using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E17 RID: 24087
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarZheZhi : SpecialEnergyBarSlot
	{
		// Token: 0x0603D410 RID: 250896 RVA: 0x00EC2E50 File Offset: 0x00EC1050
		protected override UniTask InitSlotItem(UUIItem slotItem)
		{
			SpecialEnergyBarZheZhi.<InitSlotItem>d__4 <InitSlotItem>d__;
			<InitSlotItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitSlotItem>d__.<>4__this = this;
			<InitSlotItem>d__.slotItem = slotItem;
			<InitSlotItem>d__.<>1__state = -1;
			<InitSlotItem>d__.<>t__builder.Start<SpecialEnergyBarZheZhi.<InitSlotItem>d__4>(ref <InitSlotItem>d__);
			return <InitSlotItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D411 RID: 250897 RVA: 0x00EC2E9C File Offset: 0x00EC109C
		protected override void OnInitData()
		{
			base.OnInitData();
			BattleUiRoleData roleData = this.RoleData;
			CreatureDataComponent creatureDataComponent = (roleData != null) ? roleData.CreatureDataComponent : null;
			if (creatureDataComponent == null)
			{
				return;
			}
			IList<long> customServerEntityIds = creatureDataComponent.CustomServerEntityIds;
			int num = 0;
			while (num < 3 && num <= customServerEntityIds.Count - 1)
			{
				EntityHandle entity = CreatureModel.Instance.GetEntity(customServerEntityIds[num]);
				if (entity == null || !entity.IsInit)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Battle;
					ELogAuthor author = ELogAuthor.CFT;
					string message = "折枝能量条读取伴生物实体时异常";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("creatureDataId", customServerEntityIds[num]);
					instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					this.SummonedList.Add(entity);
				}
				num++;
			}
		}

		// Token: 0x0603D412 RID: 250898 RVA: 0x00EC2F4C File Offset: 0x00EC114C
		protected override void AddEvents()
		{
			base.AddEvents();
			foreach (EntityHandle entityHandle in this.SummonedList)
			{
				WorldEntity entity = entityHandle.Entity;
				BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
				if (baseTagComponent != null)
				{
					ITagTask tagTask = baseTagComponent.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["角色.R2T1ZhezhiMd10011.状态.飞鹤可触发"]), new BaseTagComponent.TTagSwitchedCallback(this.OnSummonedTagChange), null);
					if (tagTask != null)
					{
						this.TagTaskList.Add(tagTask);
					}
				}
			}
		}

		// Token: 0x0603D413 RID: 250899 RVA: 0x00EC2FEC File Offset: 0x00EC11EC
		private void OnSummonedTagChange(int tagId, bool bTagExists)
		{
			this.UpdateSummonedEnableCount();
			this.RefreshBarPercent(false);
		}

		// Token: 0x0603D414 RID: 250900 RVA: 0x00EC2FFC File Offset: 0x00EC11FC
		private void UpdateSummonedEnableCount()
		{
			this.SummonedEnableCount = 0;
			foreach (EntityHandle entityHandle in this.SummonedList)
			{
				WorldEntity entity = entityHandle.Entity;
				BaseTagComponent baseTagComponent = (entity != null) ? entity.GetComponent<BaseTagComponent>() : null;
				if (baseTagComponent != null && baseTagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1ZhezhiMd10011.状态.飞鹤可触发"]))
				{
					this.SummonedEnableCount++;
				}
			}
		}

		// Token: 0x0603D415 RID: 250901 RVA: 0x00EC308C File Offset: 0x00EC128C
		protected override void OnStart()
		{
			for (int i = 0; i < this.SlotItemList.Count; i++)
			{
				(this.SlotItemList[i] as SpecialEnergyBarZheZhiSlotItem).SetEffectItemNiagaraParam("Color_Offset", SpecialEnergyBarZheZhi.ExtraEnergyEffectParams[i]);
			}
			this.UpdateSummonedEnableCount();
			base.OnStart();
		}

		// Token: 0x0603D416 RID: 250902 RVA: 0x00EC30E0 File Offset: 0x00EC12E0
		protected override void RefreshBarPercent(bool isStart = false)
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			bool keyEnable = this.GetKeyEnable();
			for (int i = 0; i < this.SlotItemList.Count; i++)
			{
				SpecialEnergyBarZheZhiSlotItem specialEnergyBarZheZhiSlotItem = this.SlotItemList[i] as SpecialEnergyBarZheZhiSlotItem;
				if (i < this.SummonedEnableCount)
				{
					specialEnergyBarZheZhiSlotItem.UpdatePercent(0f, false, true);
					specialEnergyBarZheZhiSlotItem.SetEffectItemVisible(true);
				}
				else
				{
					specialEnergyBarZheZhiSlotItem.UpdatePercent(curPercent * (float)this.SlotNum - (float)(i - this.SummonedEnableCount), keyEnable, true);
					specialEnergyBarZheZhiSlotItem.SetEffectItemVisible(false);
				}
			}
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.RefreshKeyEnable(keyEnable, isStart);
		}

		// Token: 0x0401FF18 RID: 130840
		private const int SUMMON_NUM = 3;

		// Token: 0x0401FF19 RID: 130841
		[StaticVariableRuleIgnore]
		private static readonly float[] ExtraEnergyEffectParams = new float[]
		{
			0.1f,
			0.3f,
			0.6f
		};

		// Token: 0x0401FF1A RID: 130842
		private readonly List<EntityHandle> SummonedList = new List<EntityHandle>();

		// Token: 0x0401FF1B RID: 130843
		private int SummonedEnableCount;
	}
}
