using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x0200504A RID: 20554
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSpeedResultView : UiViewBase
	{
		// Token: 0x06033727 RID: 210727 RVA: 0x00E684FF File Offset: 0x00E666FF
		public SolarSpeedResultView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033728 RID: 210728 RVA: 0x00E68508 File Offset: 0x00E66708
		protected unsafe override void OnRegisterComponent()
		{
			this.Data = (this.OpenParam as ISolarSpeedResultViewData);
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033729 RID: 210729 RVA: 0x00E685E8 File Offset: 0x00E667E8
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSpeedResultView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSpeedResultView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603372A RID: 210730 RVA: 0x00E6862B File Offset: 0x00E6682B
		protected override void OnStart()
		{
			this.RoleLayout.SetActive(false);
			this.RefreshTitle();
		}

		// Token: 0x0603372B RID: 210731 RVA: 0x00E6863F File Offset: 0x00E6683F
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.HandleOnActivitySequenceEmitEvent));
			EventSystem.Instance.Add<int>(EEventName.ApplicationSent, new Action<int>(this.HandleApplicationSent));
		}

		// Token: 0x0603372C RID: 210732 RVA: 0x00E68679 File Offset: 0x00E66879
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.HandleOnActivitySequenceEmitEvent));
			EventSystem.Instance.Remove(EEventName.ApplicationSent, new Action<int>(this.HandleApplicationSent));
		}

		// Token: 0x0603372D RID: 210733 RVA: 0x00E686B3 File Offset: 0x00E668B3
		private SolarSpeedRolePanelBase BuildSolarSpeedRolePanel()
		{
			return this.Data.PanelType();
		}

		// Token: 0x0603372E RID: 210734 RVA: 0x00E686C5 File Offset: 0x00E668C5
		private void HandleOnClickConfirm(int _)
		{
			Action confirmClick = this.Data.ConfirmClick;
			if (confirmClick != null)
			{
				confirmClick();
			}
			UUIItem item = base.GetItem(3);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x0603372F RID: 210735 RVA: 0x00E686EF File Offset: 0x00E668EF
		private void HandleOnActivitySequenceEmitEvent(string passData)
		{
			this.HandleOnActivitySequenceEmitEventInternalAsync();
		}

		// Token: 0x06033730 RID: 210736 RVA: 0x00E686F8 File Offset: 0x00E668F8
		private void HandleApplicationSent(int playerId)
		{
			foreach (SolarSpeedRolePanelBase solarSpeedRolePanelBase in this.RoleLayout.GetLayoutItemList())
			{
				solarSpeedRolePanelBase.RefreshAddFriendByPlayerIdExternal(playerId);
			}
		}

		// Token: 0x06033731 RID: 210737 RVA: 0x00E68750 File Offset: 0x00E66950
		private UniTask HandleOnActivitySequenceEmitEventInternalAsync()
		{
			SolarSpeedResultView.<HandleOnActivitySequenceEmitEventInternalAsync>d__15 <HandleOnActivitySequenceEmitEventInternalAsync>d__;
			<HandleOnActivitySequenceEmitEventInternalAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandleOnActivitySequenceEmitEventInternalAsync>d__.<>4__this = this;
			<HandleOnActivitySequenceEmitEventInternalAsync>d__.<>1__state = -1;
			<HandleOnActivitySequenceEmitEventInternalAsync>d__.<>t__builder.Start<SolarSpeedResultView.<HandleOnActivitySequenceEmitEventInternalAsync>d__15>(ref <HandleOnActivitySequenceEmitEventInternalAsync>d__);
			return <HandleOnActivitySequenceEmitEventInternalAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033732 RID: 210738 RVA: 0x00E68793 File Offset: 0x00E66993
		private void RefreshTitle()
		{
			if (!StringUtils.IsEmpty(this.Data.TitleId))
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(4), this.Data.TitleId, Array.Empty<object>());
			}
		}

		// Token: 0x0401B53B RID: 111931
		private GenericLayout<SolarSpeedRolePanelBase, ISolarSpeedRolePanelData> RoleLayout;

		// Token: 0x0401B53C RID: 111932
		private ButtonItem ConfirmItem;

		// Token: 0x0401B53D RID: 111933
		private UUIInturnAnimController RolePlayer;

		// Token: 0x0401B53E RID: 111934
		private ISolarSpeedResultViewData Data;

		// Token: 0x0200AD05 RID: 44293
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x040357FE RID: 219134
			public const int RoleLayout = 0;

			// Token: 0x040357FF RID: 219135
			public const int RoleItem = 1;

			// Token: 0x04035800 RID: 219136
			public const int ConfirmItem = 2;

			// Token: 0x04035801 RID: 219137
			public const int ContentRoot = 3;

			// Token: 0x04035802 RID: 219138
			public const int TitleText = 4;
		}
	}
}
