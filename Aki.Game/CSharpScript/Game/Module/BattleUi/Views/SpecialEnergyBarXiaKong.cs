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
	// Token: 0x02004DED RID: 19949
	public class SpecialEnergyBarXiaKong : SpecialEnergyBarBase
	{
		// Token: 0x060322EE RID: 205550 RVA: 0x00E101E4 File Offset: 0x00E0E3E4
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

		// Token: 0x060322EF RID: 205551 RVA: 0x00E103E0 File Offset: 0x00E0E5E0
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

		// Token: 0x060322F0 RID: 205552 RVA: 0x00E10488 File Offset: 0x00E0E688
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

		// Token: 0x060322F1 RID: 205553 RVA: 0x00E1055C File Offset: 0x00E0E75C
		protected override void RemoveEvents()
		{
			base.RemoveEvents();
			foreach (EntityHandle target in this.SummonedList)
			{
				EventSystem.Instance.RemoveWithTarget<int, bool>(target, EEventName.OnSetActorHidden, new Action<int, bool>(this.OnSummonedHidden));
			}
		}

		// Token: 0x060322F2 RID: 205554 RVA: 0x00E105CC File Offset: 0x00E0E7CC
		private void OnSummonedHidden(int entityId, bool active)
		{
			this.UpdateSummonedEnableCount(false);
		}

		// Token: 0x060322F3 RID: 205555 RVA: 0x00E105D5 File Offset: 0x00E0E7D5
		private void OnTag1Change(int tagId, bool tagExist)
		{
			this.ExistTag1 = tagExist;
			this.UpdateSummonedEnableCount(false);
		}

		// Token: 0x060322F4 RID: 205556 RVA: 0x00E105E5 File Offset: 0x00E0E7E5
		private void OnTag2Change(int tagId, bool tagExist)
		{
			this.ExistTag2 = tagExist;
			this.UpdateSummonedEnableCount(false);
		}

		// Token: 0x060322F5 RID: 205557 RVA: 0x00E105F5 File Offset: 0x00E0E7F5
		private void OnUltraTagChange(int tagId, bool tagExist)
		{
			this.ExistUltraTag = tagExist;
			this.UpdateSummonedEnableCount(false);
		}

		// Token: 0x060322F6 RID: 205558 RVA: 0x00E10608 File Offset: 0x00E0E808
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarXiaKong.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarXiaKong.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060322F7 RID: 205559 RVA: 0x00E1064C File Offset: 0x00E0E84C
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarXiaKong.<InitBarItem>d__20 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarXiaKong.<InitBarItem>d__20>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x060322F8 RID: 205560 RVA: 0x00E10690 File Offset: 0x00E0E890
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

		// Token: 0x060322F9 RID: 205561 RVA: 0x00E1074E File Offset: 0x00E0E94E
		protected override void OnBarPercentChanged()
		{
			this.SetState(this.GetKeyEnable() ? SpecialEnergyBarXiaKong.EState.Light : SpecialEnergyBarXiaKong.EState.Normal, false);
		}

		// Token: 0x060322FA RID: 205562 RVA: 0x00E10764 File Offset: 0x00E0E964
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

		// Token: 0x060322FB RID: 205563 RVA: 0x00E107B3 File Offset: 0x00E0E9B3
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

		// Token: 0x060322FC RID: 205564 RVA: 0x00E107D0 File Offset: 0x00E0E9D0
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

		// Token: 0x0401A968 RID: 108904
		private const int SUMMON_NUM = 3;

		// Token: 0x0401A969 RID: 108905
		private const int MAX_NUM = 2;

		// Token: 0x0401A96A RID: 108906
		[Nullable(2)]
		private SpecialEnergyBarSlot BarItemNormal;

		// Token: 0x0401A96B RID: 108907
		private SpecialEnergyBarXiaKong.EState CurState;

		// Token: 0x0401A96C RID: 108908
		[Nullable(1)]
		private readonly List<EntityHandle> SummonedList = new List<EntityHandle>();

		// Token: 0x0401A96D RID: 108909
		private int SummonedEnableCount;

		// Token: 0x0401A96E RID: 108910
		private bool ExistTag1;

		// Token: 0x0401A96F RID: 108911
		private bool ExistTag2;

		// Token: 0x0401A970 RID: 108912
		private bool ExistUltraTag;

		// Token: 0x0200AB7B RID: 43899
		private enum EState
		{
			// Token: 0x040350DF RID: 217311
			Normal,
			// Token: 0x040350E0 RID: 217312
			Light
		}

		// Token: 0x0200AB7C RID: 43900
		private enum EChildType
		{
			// Token: 0x040350E2 RID: 217314
			SlotBarItemNormal,
			// Token: 0x040350E3 RID: 217315
			ItemMid1,
			// Token: 0x040350E4 RID: 217316
			ItemMid2,
			// Token: 0x040350E5 RID: 217317
			ItemLeft,
			// Token: 0x040350E6 RID: 217318
			ItemRight,
			// Token: 0x040350E7 RID: 217319
			ItemLight,
			// Token: 0x040350E8 RID: 217320
			ItemBgLeft,
			// Token: 0x040350E9 RID: 217321
			ItemBgRight,
			// Token: 0x040350EA RID: 217322
			AniLightIn,
			// Token: 0x040350EB RID: 217323
			AniLightOut,
			// Token: 0x040350EC RID: 217324
			AniLeftIn,
			// Token: 0x040350ED RID: 217325
			AniLeftOut,
			// Token: 0x040350EE RID: 217326
			AniRightIn,
			// Token: 0x040350EF RID: 217327
			AniRightOut
		}
	}
}
