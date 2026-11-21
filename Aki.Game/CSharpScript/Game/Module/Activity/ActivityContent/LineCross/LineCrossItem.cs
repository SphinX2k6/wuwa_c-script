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
	// Token: 0x020054E3 RID: 21731
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class LineCrossItem : GridProxyAbstract<ItemData>
	{
		// Token: 0x06035D85 RID: 220549 RVA: 0x00F0AB24 File Offset: 0x00F08D24
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

		// Token: 0x06035D86 RID: 220550 RVA: 0x00F0ACD4 File Offset: 0x00F08ED4
		protected override UniTask OnBeforeStartAsync()
		{
			LineCrossItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<LineCrossItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035D87 RID: 220551 RVA: 0x00F0AD18 File Offset: 0x00F08F18
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

		// Token: 0x06035D88 RID: 220552 RVA: 0x00F0ADA0 File Offset: 0x00F08FA0
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

		// Token: 0x06035D89 RID: 220553 RVA: 0x00F0AE57 File Offset: 0x00F09057
		private void RefreshClawItem(bool ifHidden, ELineCrossGroupState state)
		{
			LineCrossClawItem clawItem = this.ClawItem;
			if (clawItem == null)
			{
				return;
			}
			clawItem.Refresh(ifHidden, state);
		}

		// Token: 0x06035D8A RID: 220554 RVA: 0x00F0AE6B File Offset: 0x00F0906B
		private void RefreshRedDot(int groupId)
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.LineCrossGroupRedDot, base.GetItem(9), groupId);
			RedDotController.Instance.BindRedDot(ERedDotName.LineCrossGroupRedDot, base.GetItem(9), null, groupId);
		}

		// Token: 0x06035D8B RID: 220555 RVA: 0x00F0AEA0 File Offset: 0x00F090A0
		private void RefreshLevelIndexText(int gridIndex)
		{
			base.GetText(6).SetText((gridIndex + 1).ToString(), true);
		}

		// Token: 0x06035D8C RID: 220556 RVA: 0x00F0AEC5 File Offset: 0x00F090C5
		private void RefreshLockSprite(bool isLock)
		{
			base.GetSprite(7).SetUIActive(isLock);
		}

		// Token: 0x06035D8D RID: 220557 RVA: 0x00F0AED4 File Offset: 0x00F090D4
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

		// Token: 0x06035D8E RID: 220558 RVA: 0x00F0AF74 File Offset: 0x00F09174
		private void RefreshNameText(int groupId)
		{
			string name = LineCrossConfig.Instance.GetLineCrossGroupByGroupId(groupId).Value.Name;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), name, Array.Empty<object>());
		}

		// Token: 0x06035D8F RID: 220559 RVA: 0x00F0AFB4 File Offset: 0x00F091B4
		private void RefreshNormal()
		{
			base.GetTexture(1).SetColor(FColor.FromHex("3c187d"));
			base.GetSprite(3).SetColor(FColor.FromHex("a591b7"));
			base.GetText(5).SetColor(FColor.FromHex("ffffff"));
			base.GetSprite(8).SetColor(FColor.FromHex("ffffff"));
		}

		// Token: 0x06035D90 RID: 220560 RVA: 0x00F0B01C File Offset: 0x00F0921C
		private void RefreshClear()
		{
			base.GetTexture(1).SetColor(FColor.FromHex("1a5e45"));
			base.GetSprite(3).SetColor(FColor.FromHex("84c991"));
			base.GetText(5).SetColor(FColor.FromHex("93de9e"));
			base.GetSprite(8).SetColor(FColor.FromHex("00ffc4"));
		}

		// Token: 0x06035D91 RID: 220561 RVA: 0x00F0B084 File Offset: 0x00F09284
		private void RefreshLock()
		{
			base.GetTexture(1).SetColor(FColor.FromHex("881e32"));
			base.GetSprite(3).SetColor(FColor.FromHex("5c4949"));
			base.GetText(5).SetColor(FColor.FromHex("ff4141"));
			base.GetSprite(8).SetColor(FColor.FromHex("ff4e4e"));
		}

		// Token: 0x0401C7B0 RID: 116656
		[Nullable(2)]
		protected ItemData CurrentData;

		// Token: 0x0401C7B1 RID: 116657
		[Nullable(2)]
		private LineCrossClawItem ClawItem;

		// Token: 0x0200B142 RID: 45378
		[NullableContext(0)]
		private class EItemComponent
		{
			// Token: 0x04036D08 RID: 224520
			public const int Button = 0;

			// Token: 0x04036D09 RID: 224521
			public const int CircleTexture = 1;

			// Token: 0x04036D0A RID: 224522
			public const int ClawItem = 2;

			// Token: 0x04036D0B RID: 224523
			public const int SpriteLevelDesc = 3;

			// Token: 0x04036D0C RID: 224524
			public const int NameText = 4;

			// Token: 0x04036D0D RID: 224525
			public const int ProgressText = 5;

			// Token: 0x04036D0E RID: 224526
			public const int LevelIndexText = 6;

			// Token: 0x04036D0F RID: 224527
			public const int LockSprite = 7;

			// Token: 0x04036D10 RID: 224528
			public const int ProgressDescSprite = 8;

			// Token: 0x04036D11 RID: 224529
			public const int RedDot = 9;
		}
	}
}
