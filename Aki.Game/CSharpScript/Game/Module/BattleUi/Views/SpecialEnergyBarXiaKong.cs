using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E08 RID: 24072
	public class SpecialEnergyBarXiaKong : SpecialEnergyBarBase
	{
		// Token: 0x0603D35F RID: 250719 RVA: 0x00EBEC84 File Offset: 0x00EBCE84
		protected unsafe override void OnRegisterComponent()
		{
			int num = 14;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603D360 RID: 250720 RVA: 0x00EBEE80 File Offset: 0x00EBD080
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
					string message = "夏空能量条读取幻影实体时异常";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("creatureDataId", entity);
					instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					this.SummonedList.Add(entity);
				}
				num++;
			}
		}

		// Token: 0x0603D361 RID: 250721 RVA: 0x00EBEF28 File Offset: 0x00EBD128
		protected override void AddEvents()
		{
			base.AddEvents();
			foreach (EntityHandle target in this.SummonedList)
			{
				EventSystem.Instance.AddWithTarget<int, bool>(target, EEventName.OnSetActorHidden, new Action<int, bool>(this.OnSummonedHidden));
			}
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1XiakongMd10011.逻辑.乐器.鼓"], new BaseTagComponent.TTagSwitchedCallback(this.OnTag1Change));
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1XiakongMd10011.逻辑.乐器.琴"], new BaseTagComponent.TTagSwitchedCallback(this.OnTag2Change));
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1XiakongMd10011.技能.大招"], new BaseTagComponent.TTagSwitchedCallback(this.OnUltraTagChange));
		}

		// Token: 0x0603D362 RID: 250722 RVA: 0x00EBEFFC File Offset: 0x00EBD1FC
		protected override void RemoveEvents()
		{
			base.RemoveEvents();
			foreach (EntityHandle target in this.SummonedList)
			{
				EventSystem.Instance.RemoveWithTarget<int, bool>(target, EEventName.OnSetActorHidden, new Action<int, bool>(this.OnSummonedHidden));
			}
		}

		// Token: 0x0603D363 RID: 250723 RVA: 0x00EBF06C File Offset: 0x00EBD26C
		private void OnSummonedHidden(int entityId, bool active)
		{
			this.UpdateSummonedEnableCount(false);
		}

		// Token: 0x0603D364 RID: 250724 RVA: 0x00EBF075 File Offset: 0x00EBD275
		private void OnTag1Change(int tagId, bool tagExist)
		{
			this.ExistTag1 = tagExist;
			this.UpdateSummonedEnableCount(false);
		}

		// Token: 0x0603D365 RID: 250725 RVA: 0x00EBF085 File Offset: 0x00EBD285
		private void OnTag2Change(int tagId, bool tagExist)
		{
			this.ExistTag2 = tagExist;
			this.UpdateSummonedEnableCount(false);
		}

		// Token: 0x0603D366 RID: 250726 RVA: 0x00EBF095 File Offset: 0x00EBD295
		private void OnUltraTagChange(int tagId, bool tagExist)
		{
			this.ExistUltraTag = tagExist;
			this.UpdateSummonedEnableCount(false);
		}

		// Token: 0x0603D367 RID: 250727 RVA: 0x00EBF0A8 File Offset: 0x00EBD2A8
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarXiaKong.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarXiaKong.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D368 RID: 250728 RVA: 0x00EBF0EC File Offset: 0x00EBD2EC
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarXiaKong.<InitBarItem>d__20 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarXiaKong.<InitBarItem>d__20>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D369 RID: 250729 RVA: 0x00EBF130 File Offset: 0x00EBD330
		protected override void OnStart()
		{
			base.InitTweenAnim(8);
			base.InitTweenAnim(9);
			base.InitTweenAnim(10);
			base.InitTweenAnim(11);
			base.InitTweenAnim(12);
			base.InitTweenAnim(13);
			this.OnBarPercentChanged();
			BaseTagComponent tagComponent = this.TagComponent;
			this.ExistTag1 = (tagComponent != null && tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1XiakongMd10011.逻辑.乐器.鼓"]));
			BaseTagComponent tagComponent2 = this.TagComponent;
			this.ExistTag2 = (tagComponent2 != null && tagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1XiakongMd10011.逻辑.乐器.琴"]));
			BaseTagComponent tagComponent3 = this.TagComponent;
			this.ExistUltraTag = (tagComponent3 != null && tagComponent3.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1XiakongMd10011.技能.大招"]));
			this.UpdateSummonedEnableCount(true);
		}

		// Token: 0x0603D36A RID: 250730 RVA: 0x00EBF1EE File Offset: 0x00EBD3EE
		protected override void OnBarPercentChanged()
		{
			this.SetState(this.GetKeyEnable() ? SpecialEnergyBarXiaKong.EState.Light : SpecialEnergyBarXiaKong.EState.Normal, false);
		}

		// Token: 0x0603D36B RID: 250731 RVA: 0x00EBF204 File Offset: 0x00EBD404
		private void SetState(SpecialEnergyBarXiaKong.EState state, bool isStart = false)
		{
			if (state == this.CurState && !isStart)
			{
				return;
			}
			this.CurState = state;
			SpecialEnergyBarXiaKong.EState curState = this.CurState;
			if (curState == SpecialEnergyBarXiaKong.EState.Normal)
			{
				base.StopTweenAnim(8);
				base.PlayTweenAnim(9);
				return;
			}
			if (curState != SpecialEnergyBarXiaKong.EState.Light)
			{
				return;
			}
			base.StopTweenAnim(9);
			base.PlayTweenAnim(8);
		}

		// Token: 0x0603D36C RID: 250732 RVA: 0x00EBF253 File Offset: 0x00EBD453
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarSlot barItemNormal = this.BarItemNormal;
			if (barItemNormal == null)
			{
				return;
			}
			barItemNormal.Tick(delta);
		}

		// Token: 0x0603D36D RID: 250733 RVA: 0x00EBF270 File Offset: 0x00EBD470
		private void UpdateSummonedEnableCount(bool isStart = false)
		{
			int num = 0;
			if (this.ExistUltraTag)
			{
				if (this.ExistTag1)
				{
					num++;
				}
				if (this.ExistTag2)
				{
					num++;
				}
			}
			else
			{
				foreach (EntityHandle entityHandle in this.SummonedList)
				{
					WorldEntity entity = entityHandle.Entity;
					BaseActorComponent baseActorComponent = (entity != null) ? entity.GetComponent<BaseActorComponent>() : null;
					if (baseActorComponent != null && baseActorComponent.DisableActorHandle.Empty)
					{
						num++;
					}
				}
				num = Math.Min(num, 2);
			}
			if (this.SummonedEnableCount == num && !isStart)
			{
				return;
			}
			if (num > this.SummonedEnableCount)
			{
				for (int i = this.SummonedEnableCount; i < num; i++)
				{
					if (i == 0)
					{
						base.StopTweenAnim(11);
						base.PlayTweenAnim(10);
					}
					else if (i == 1)
					{
						base.StopTweenAnim(13);
						base.PlayTweenAnim(12);
					}
				}
			}
			else
			{
				for (int j = this.SummonedEnableCount - 1; j >= num; j--)
				{
					if (j == 0)
					{
						base.StopTweenAnim(10);
						base.PlayTweenAnim(11);
					}
					else if (j == 1)
					{
						base.StopTweenAnim(12);
						base.PlayTweenAnim(13);
					}
				}
			}
			this.SummonedEnableCount = num;
		}

		// Token: 0x0401FEA1 RID: 130721
		private const int SUMMON_NUM = 3;

		// Token: 0x0401FEA2 RID: 130722
		private const int MAX_NUM = 2;

		// Token: 0x0401FEA3 RID: 130723
		[Nullable(2)]
		private SpecialEnergyBarSlot BarItemNormal;

		// Token: 0x0401FEA4 RID: 130724
		private SpecialEnergyBarXiaKong.EState CurState;

		// Token: 0x0401FEA5 RID: 130725
		[Nullable(1)]
		private readonly List<EntityHandle> SummonedList = new List<EntityHandle>();

		// Token: 0x0401FEA6 RID: 130726
		private int SummonedEnableCount;

		// Token: 0x0401FEA7 RID: 130727
		private bool ExistTag1;

		// Token: 0x0401FEA8 RID: 130728
		private bool ExistTag2;

		// Token: 0x0401FEA9 RID: 130729
		private bool ExistUltraTag;

		// Token: 0x0200C16C RID: 49516
		private enum EState
		{
			// Token: 0x0403A6ED RID: 239341
			Normal,
			// Token: 0x0403A6EE RID: 239342
			Light
		}

		// Token: 0x0200C16D RID: 49517
		private enum EChildType
		{
			// Token: 0x0403A6F0 RID: 239344
			SlotBarItemNormal,
			// Token: 0x0403A6F1 RID: 239345
			ItemMid1,
			// Token: 0x0403A6F2 RID: 239346
			ItemMid2,
			// Token: 0x0403A6F3 RID: 239347
			ItemLeft,
			// Token: 0x0403A6F4 RID: 239348
			ItemRight,
			// Token: 0x0403A6F5 RID: 239349
			ItemLight,
			// Token: 0x0403A6F6 RID: 239350
			ItemBgLeft,
			// Token: 0x0403A6F7 RID: 239351
			ItemBgRight,
			// Token: 0x0403A6F8 RID: 239352
			AniLightIn,
			// Token: 0x0403A6F9 RID: 239353
			AniLightOut,
			// Token: 0x0403A6FA RID: 239354
			AniLeftIn,
			// Token: 0x0403A6FB RID: 239355
			AniLeftOut,
			// Token: 0x0403A6FC RID: 239356
			AniRightIn,
			// Token: 0x0403A6FD RID: 239357
			AniRightOut
		}
	}
}
