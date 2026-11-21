using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DEA RID: 19946
	public class SpecialEnergyBarThunder : SpecialEnergyBarBase
	{
		// Token: 0x060322C5 RID: 205509 RVA: 0x00E0F8DC File Offset: 0x00E0DADC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
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
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060322C6 RID: 205510 RVA: 0x00E0FA0B File Offset: 0x00E0DC0B
		protected override void OnInitData()
		{
			this.OverloadConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(130901);
		}

		// Token: 0x060322C7 RID: 205511 RVA: 0x00E0FA27 File Offset: 0x00E0DC27
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarThunder.OverloadTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnOverloadTagChanged));
		}

		// Token: 0x060322C8 RID: 205512 RVA: 0x00E0FA48 File Offset: 0x00E0DC48
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarThunder.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarThunder.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060322C9 RID: 205513 RVA: 0x00E0FA8C File Offset: 0x00E0DC8C
		private UniTask InitBarItem()
		{
			SpecialEnergyBarThunder.<InitBarItem>d__13 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarThunder.<InitBarItem>d__13>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x060322CA RID: 205514 RVA: 0x00E0FAD0 File Offset: 0x00E0DCD0
		private UniTask InitOverloadBarItem()
		{
			SpecialEnergyBarThunder.<InitOverloadBarItem>d__14 <InitOverloadBarItem>d__;
			<InitOverloadBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitOverloadBarItem>d__.<>4__this = this;
			<InitOverloadBarItem>d__.<>1__state = -1;
			<InitOverloadBarItem>d__.<>t__builder.Start<SpecialEnergyBarThunder.<InitOverloadBarItem>d__14>(ref <InitOverloadBarItem>d__);
			return <InitOverloadBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x060322CB RID: 205515 RVA: 0x00E0FB13 File Offset: 0x00E0DD13
		protected override void OnStart()
		{
			base.InitTweenAnim(5);
			base.InitTweenAnim(6);
			base.InitTweenAnim(7);
			this.RefreshState(true);
			this.RefreshFullState(true);
		}

		// Token: 0x060322CC RID: 205516 RVA: 0x00E0FB38 File Offset: 0x00E0DD38
		protected override void OnBarPercentChanged()
		{
			this.RefreshFullState(false);
		}

		// Token: 0x060322CD RID: 205517 RVA: 0x00E0FB41 File Offset: 0x00E0DD41
		protected override void OnKeyEnableChanged()
		{
			this.RefreshFullState(false);
		}

		// Token: 0x060322CE RID: 205518 RVA: 0x00E0FB4A File Offset: 0x00E0DD4A
		private void OnOverloadTagChanged(int tagId, bool tagExist)
		{
			this.SetState(tagExist ? SpecialEnergyBarThunder.EState.Overload : SpecialEnergyBarThunder.EState.Normal, false);
		}

		// Token: 0x060322CF RID: 205519 RVA: 0x00E0FB5C File Offset: 0x00E0DD5C
		private void RefreshState(bool isStart = false)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			this.SetState((tagComponent != null && tagComponent.HasTag(SpecialEnergyBarThunder.OverloadTagId)) ? SpecialEnergyBarThunder.EState.Overload : SpecialEnergyBarThunder.EState.Normal, isStart);
		}

		// Token: 0x060322D0 RID: 205520 RVA: 0x00E0FB90 File Offset: 0x00E0DD90
		private void SetState(SpecialEnergyBarThunder.EState state, bool isStart = false)
		{
			if (this.CurState == state && !isStart)
			{
				return;
			}
			this.CurState = state;
			bool flag = this.CurState == SpecialEnergyBarThunder.EState.Overload;
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(!flag);
			}
			UUIItem item2 = base.GetItem(3);
			if (item2 != null)
			{
				item2.SetUIActive(flag);
			}
			UUIItem item3 = base.GetItem(2);
			if (item3 != null)
			{
				item3.SetUIActive(!flag);
			}
			UUIItem item4 = base.GetItem(4);
			if (item4 != null)
			{
				item4.SetUIActive(flag);
			}
			if (!isStart)
			{
				if (flag)
				{
					base.StopTweenAnim(7);
					base.PlayTweenAnim(6);
				}
				else
				{
					base.StopTweenAnim(6);
					base.PlayTweenAnim(7);
				}
				SpecialEnergyBarThunderOverload overloadBarItem = this.OverloadBarItem;
				if (overloadBarItem != null)
				{
					overloadBarItem.OnChangeVisibleByTagChange(flag);
				}
			}
			this.RefreshFullState(true);
		}

		// Token: 0x060322D1 RID: 205521 RVA: 0x00E0FC4C File Offset: 0x00E0DE4C
		private void RefreshFullState(bool isStart = false)
		{
			if (this.CurState == SpecialEnergyBarThunder.EState.Overload)
			{
				if (this.IsFull || isStart)
				{
					this.IsFull = false;
					this.SetNormalBgUseChangeColor(false);
					base.StopTweenAnim(5);
				}
				return;
			}
			bool keyEnable = this.GetKeyEnable();
			if (this.IsFull == keyEnable && !isStart)
			{
				return;
			}
			this.IsFull = keyEnable;
			this.SetNormalBgUseChangeColor(keyEnable);
			if (keyEnable)
			{
				base.PlayTweenAnim(5);
				return;
			}
			base.StopTweenAnim(5);
		}

		// Token: 0x060322D2 RID: 205522 RVA: 0x00E0FCB8 File Offset: 0x00E0DEB8
		private void SetNormalBgUseChangeColor(bool useChangeColor)
		{
			UUITexture texture = base.GetTexture(1);
			if (texture != null)
			{
				UUIItem uuiitem = texture;
				FColor? fcolor = new FColor?(texture.changeColor);
				uuiitem.SetChangeColor(useChangeColor, fcolor);
			}
		}

		// Token: 0x060322D3 RID: 205523 RVA: 0x00E0FCE5 File Offset: 0x00E0DEE5
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarSlot barItem = this.BarItem;
			if (barItem != null)
			{
				barItem.Tick(delta);
			}
			SpecialEnergyBarThunderOverload overloadBarItem = this.OverloadBarItem;
			if (overloadBarItem == null)
			{
				return;
			}
			overloadBarItem.Tick(delta);
		}

		// Token: 0x0401A95C RID: 108892
		private const int OVERLOAD_CONFIG_ID = 130901;

		// Token: 0x0401A95D RID: 108893
		[StaticVariableRuleIgnore]
		private static readonly int OverloadTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1ThunderNanzhuMd10011.逻辑.E技能派生"];

		// Token: 0x0401A95E RID: 108894
		[Nullable(2)]
		private SpecialEnergyBarInfo OverloadConfig;

		// Token: 0x0401A95F RID: 108895
		[Nullable(2)]
		private SpecialEnergyBarSlot BarItem;

		// Token: 0x0401A960 RID: 108896
		[Nullable(2)]
		private SpecialEnergyBarThunderOverload OverloadBarItem;

		// Token: 0x0401A961 RID: 108897
		private bool IsFull;

		// Token: 0x0401A962 RID: 108898
		private SpecialEnergyBarThunder.EState CurState;

		// Token: 0x0200AB71 RID: 43889
		private enum EChildType
		{
			// Token: 0x040350AD RID: 217261
			StateItemA,
			// Token: 0x040350AE RID: 217262
			BgTexture,
			// Token: 0x040350AF RID: 217263
			SlotBarItem,
			// Token: 0x040350B0 RID: 217264
			StateItemB,
			// Token: 0x040350B1 RID: 217265
			OverloadSlotBarItem,
			// Token: 0x040350B2 RID: 217266
			AniAmax,
			// Token: 0x040350B3 RID: 217267
			AniAtoB,
			// Token: 0x040350B4 RID: 217268
			AniBtoA
		}

		// Token: 0x0200AB72 RID: 43890
		private enum EState
		{
			// Token: 0x040350B6 RID: 217270
			Normal,
			// Token: 0x040350B7 RID: 217271
			Overload
		}
	}
}
