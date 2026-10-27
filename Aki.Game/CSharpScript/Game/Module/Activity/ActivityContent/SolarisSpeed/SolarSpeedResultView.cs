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
	// Token: 0x020060CC RID: 24780
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSpeedResultView : UiViewBase
	{
		// Token: 0x0603EA63 RID: 256611 RVA: 0x00F2172F File Offset: 0x00F1F92F
		public SolarSpeedResultView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603EA64 RID: 256612 RVA: 0x00F21738 File Offset: 0x00F1F938
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

		// Token: 0x0603EA65 RID: 256613 RVA: 0x00F21818 File Offset: 0x00F1FA18
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSpeedResultView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSpeedResultView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603EA66 RID: 256614 RVA: 0x00F2185B File Offset: 0x00F1FA5B
		protected override void OnStart()
		{
			this.RoleLayout.SetActive(false);
			this.RefreshTitle();
		}

		// Token: 0x0603EA67 RID: 256615 RVA: 0x00F2186F File Offset: 0x00F1FA6F
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.HandleOnActivitySequenceEmitEvent));
			EventSystem.Instance.Add<int>(EEventName.ApplicationSent, new Action<int>(this.HandleApplicationSent));
		}

		// Token: 0x0603EA68 RID: 256616 RVA: 0x00F218A9 File Offset: 0x00F1FAA9
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.HandleOnActivitySequenceEmitEvent));
			EventSystem.Instance.Remove(EEventName.ApplicationSent, new Action<int>(this.HandleApplicationSent));
		}

		// Token: 0x0603EA69 RID: 256617 RVA: 0x00F218E3 File Offset: 0x00F1FAE3
		private SolarSpeedRolePanelBase BuildSolarSpeedRolePanel()
		{
			return this.Data.PanelType();
		}

		// Token: 0x0603EA6A RID: 256618 RVA: 0x00F218F5 File Offset: 0x00F1FAF5
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

		// Token: 0x0603EA6B RID: 256619 RVA: 0x00F2191F File Offset: 0x00F1FB1F
		private void HandleOnActivitySequenceEmitEvent(string passData)
		{
			this.HandleOnActivitySequenceEmitEventInternalAsync();
		}

		// Token: 0x0603EA6C RID: 256620 RVA: 0x00F21928 File Offset: 0x00F1FB28
		private void HandleApplicationSent(int playerId)
		{
			foreach (SolarSpeedRolePanelBase solarSpeedRolePanelBase in this.RoleLayout.GetLayoutItemList())
			{
				solarSpeedRolePanelBase.RefreshAddFriendByPlayerIdExternal(playerId);
			}
		}

		// Token: 0x0603EA6D RID: 256621 RVA: 0x00F21980 File Offset: 0x00F1FB80
		private UniTask HandleOnActivitySequenceEmitEventInternalAsync()
		{
			SolarSpeedResultView.<HandleOnActivitySequenceEmitEventInternalAsync>d__15 <HandleOnActivitySequenceEmitEventInternalAsync>d__;
			<HandleOnActivitySequenceEmitEventInternalAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandleOnActivitySequenceEmitEventInternalAsync>d__.<>4__this = this;
			<HandleOnActivitySequenceEmitEventInternalAsync>d__.<>1__state = -1;
			<HandleOnActivitySequenceEmitEventInternalAsync>d__.<>t__builder.Start<SolarSpeedResultView.<HandleOnActivitySequenceEmitEventInternalAsync>d__15>(ref <HandleOnActivitySequenceEmitEventInternalAsync>d__);
			return <HandleOnActivitySequenceEmitEventInternalAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603EA6E RID: 256622 RVA: 0x00F219C3 File Offset: 0x00F1FBC3
		private void RefreshTitle()
		{
			if (!StringUtils.IsEmpty(this.Data.TitleId))
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(4), this.Data.TitleId, Array.Empty<object>());
			}
		}

		// Token: 0x04020C0E RID: 134158
		private GenericLayout<SolarSpeedRolePanelBase, ISolarSpeedRolePanelData> RoleLayout;

		// Token: 0x04020C0F RID: 134159
		private ButtonItem ConfirmItem;

		// Token: 0x04020C10 RID: 134160
		private UUIInturnAnimController RolePlayer;

		// Token: 0x04020C11 RID: 134161
		private ISolarSpeedResultViewData Data;

		// Token: 0x0200C31A RID: 49946
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403AE96 RID: 241302
			public const int RoleLayout = 0;

			// Token: 0x0403AE97 RID: 241303
			public const int RoleItem = 1;

			// Token: 0x0403AE98 RID: 241304
			public const int ConfirmItem = 2;

			// Token: 0x0403AE99 RID: 241305
			public const int ContentRoot = 3;

			// Token: 0x0403AE9A RID: 241306
			public const int TitleText = 4;
		}
	}
}
