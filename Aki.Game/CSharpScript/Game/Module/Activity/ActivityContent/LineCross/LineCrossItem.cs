using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.LineCross
{
	// Token: 0x02006565 RID: 25957
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class LineCrossItem : GridProxyAbstract<ItemData>
	{
		// Token: 0x060410C0 RID: 266432 RVA: 0x00FC3B40 File Offset: 0x00FC1D40
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060410C1 RID: 266433 RVA: 0x00FC3CF0 File Offset: 0x00FC1EF0
		protected override UniTask OnBeforeStartAsync()
		{
			LineCrossItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<LineCrossItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060410C2 RID: 266434 RVA: 0x00FC3D34 File Offset: 0x00FC1F34
		private void OnClickBtn()
		{
			int id = this.CurrentData.Data.Id;
			int groupId = this.CurrentData.GroupId;
			if (!LineCrossModel.Instance.GetGroupUnlockState(id, groupId))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("LineCross_Challenge_LockTime", Array.Empty<object>());
				return;
			}
			LineCrossDetailViewModel lineCrossDetailViewModel = new LineCrossDetailViewModel();
			lineCrossDetailViewModel.GroupId = groupId;
			lineCrossDetailViewModel.LineCrossActivityData = this.CurrentData.Data;
			lineCrossDetailViewModel.GridIndex = base.GridIndex;
			UiManager.Instance.OpenView(EUiViewName.LineCrossDetailView, lineCrossDetailViewModel, null);
		}

		// Token: 0x060410C3 RID: 266435 RVA: 0x00FC3DBC File Offset: 0x00FC1FBC
		public override void Refresh(ItemData data, bool isSelected, int gridIndex)
		{
			this.CurrentData = data;
			ELineCrossGroupState groupState = LineCrossModel.Instance.GetGroupState(data.Data.Id, data.GroupId);
			bool ifHiddenGroup = LineCrossModel.Instance.GetIfHiddenGroup(data.Data.Id, data.GroupId);
			switch (groupState)
			{
			case ELineCrossGroupState.Normal:
				this.RefreshNormal();
				break;
			case ELineCrossGroupState.Passed:
				this.RefreshClear();
				break;
			case ELineCrossGroupState.Lock:
				this.RefreshLock();
				break;
			default:
				this.RefreshNormal();
				break;
			}
			this.RefreshNameText(data.GroupId);
			this.RefreshProgressText(groupState, data);
			this.RefreshLevelIndexText(gridIndex);
			this.RefreshLockSprite(groupState == ELineCrossGroupState.Lock);
			this.RefreshRedDot(data.GroupId);
			this.RefreshClawItem(ifHiddenGroup, groupState);
		}

		// Token: 0x060410C4 RID: 266436 RVA: 0x00FC3E73 File Offset: 0x00FC2073
		private void RefreshClawItem(bool ifHidden, ELineCrossGroupState state)
		{
			LineCrossClawItem clawItem = this.ClawItem;
			if (clawItem == null)
			{
				return;
			}
			clawItem.Refresh(ifHidden, state);
		}

		// Token: 0x060410C5 RID: 266437 RVA: 0x00FC3E87 File Offset: 0x00FC2087
		private void RefreshRedDot(int groupId)
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.LineCrossGroupRedDot, base.GetItem(9), groupId);
			RedDotController.Instance.BindRedDot(ERedDotName.LineCrossGroupRedDot, base.GetItem(9), null, groupId);
		}

		// Token: 0x060410C6 RID: 266438 RVA: 0x00FC3EBC File Offset: 0x00FC20BC
		private void RefreshLevelIndexText(int gridIndex)
		{
			base.GetText(6).SetText((gridIndex + 1).ToString(), true);
		}

		// Token: 0x060410C7 RID: 266439 RVA: 0x00FC3EE1 File Offset: 0x00FC20E1
		private void RefreshLockSprite(bool isLock)
		{
			base.GetSprite(7).SetUIActive(isLock);
		}

		// Token: 0x060410C8 RID: 266440 RVA: 0x00FC3EF0 File Offset: 0x00FC20F0
		private void RefreshProgressText(ELineCrossGroupState state, ItemData data)
		{
			string newText;
			switch (state)
			{
			case ELineCrossGroupState.Normal:
				newText = LineCrossModel.Instance.GetGroupRewardProgress(data.Data.Id, data.GroupId);
				break;
			case ELineCrossGroupState.Passed:
				newText = (ConfigMultiTextLang.GetLocalTextNew("LineCrossPass", null) ?? "");
				break;
			case ELineCrossGroupState.Lock:
				newText = LineCrossModel.Instance.GetLockDescription(data.Data.Id, data.GroupId);
				break;
			default:
				newText = (ConfigMultiTextLang.GetLocalTextNew("LineCrossPass", null) ?? "");
				break;
			}
			base.GetText(5).SetText(newText, true);
		}

		// Token: 0x060410C9 RID: 266441 RVA: 0x00FC3F90 File Offset: 0x00FC2190
		private void RefreshNameText(int groupId)
		{
			string name = LineCrossConfig.Instance.GetLineCrossGroupByGroupId(groupId).Value.Name;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), name, Array.Empty<object>());
		}

		// Token: 0x060410CA RID: 266442 RVA: 0x00FC3FD0 File Offset: 0x00FC21D0
		private void RefreshNormal()
		{
			base.GetTexture(1).SetColor(FColor.FromHex("3c187d"));
			base.GetSprite(3).SetColor(FColor.FromHex("a591b7"));
			base.GetText(5).SetColor(FColor.FromHex("ffffff"));
			base.GetSprite(8).SetColor(FColor.FromHex("ffffff"));
		}

		// Token: 0x060410CB RID: 266443 RVA: 0x00FC4038 File Offset: 0x00FC2238
		private void RefreshClear()
		{
			base.GetTexture(1).SetColor(FColor.FromHex("1a5e45"));
			base.GetSprite(3).SetColor(FColor.FromHex("84c991"));
			base.GetText(5).SetColor(FColor.FromHex("93de9e"));
			base.GetSprite(8).SetColor(FColor.FromHex("00ffc4"));
		}

		// Token: 0x060410CC RID: 266444 RVA: 0x00FC40A0 File Offset: 0x00FC22A0
		private void RefreshLock()
		{
			base.GetTexture(1).SetColor(FColor.FromHex("881e32"));
			base.GetSprite(3).SetColor(FColor.FromHex("5c4949"));
			base.GetText(5).SetColor(FColor.FromHex("ff4141"));
			base.GetSprite(8).SetColor(FColor.FromHex("ff4e4e"));
		}

		// Token: 0x04021E7F RID: 138879
		[Nullable(2)]
		protected ItemData CurrentData;

		// Token: 0x04021E80 RID: 138880
		[Nullable(2)]
		private LineCrossClawItem ClawItem;

		// Token: 0x0200C75D RID: 51037
		[NullableContext(0)]
		private class EItemComponent
		{
			// Token: 0x0403C3B6 RID: 246710
			public const int Button = 0;

			// Token: 0x0403C3B7 RID: 246711
			public const int CircleTexture = 1;

			// Token: 0x0403C3B8 RID: 246712
			public const int ClawItem = 2;

			// Token: 0x0403C3B9 RID: 246713
			public const int SpriteLevelDesc = 3;

			// Token: 0x0403C3BA RID: 246714
			public const int NameText = 4;

			// Token: 0x0403C3BB RID: 246715
			public const int ProgressText = 5;

			// Token: 0x0403C3BC RID: 246716
			public const int LevelIndexText = 6;

			// Token: 0x0403C3BD RID: 246717
			public const int LockSprite = 7;

			// Token: 0x0403C3BE RID: 246718
			public const int ProgressDescSprite = 8;

			// Token: 0x0403C3BF RID: 246719
			public const int RedDot = 9;
		}
	}
}
