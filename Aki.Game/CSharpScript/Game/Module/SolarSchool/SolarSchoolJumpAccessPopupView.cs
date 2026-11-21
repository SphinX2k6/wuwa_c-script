using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059CD RID: 22989
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolJumpAccessPopupView : UiViewBase
	{
		// Token: 0x06038A8C RID: 232076 RVA: 0x00FDB5B4 File Offset: 0x00FD97B4
		public SolarSchoolJumpAccessPopupView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038A8D RID: 232077 RVA: 0x00FDB5C0 File Offset: 0x00FD97C0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038A8E RID: 232078 RVA: 0x00FDB66C File Offset: 0x00FD986C
		protected override void OnStart()
		{
			this.Param = (this.OpenParam as SolarSchoolJumpAccessPopupParam);
			UUILoopScrollViewComponent loopScrollViewComponent = base.GetLoopScrollViewComponent(2);
			UUIItem item = base.GetItem(3);
			this.AccessLayout = new LoopScrollView<SolarSchoolJumpAccessItem, SolarSchoolJumpAccessItemData>(loopScrollViewComponent, item.GetOwner() as AUIBaseActor, new Func<SolarSchoolJumpAccessItem>(this.CreateAccessItem), false);
		}

		// Token: 0x06038A8F RID: 232079 RVA: 0x00FDB6BE File Offset: 0x00FD98BE
		private SolarSchoolJumpAccessItem CreateAccessItem()
		{
			return new SolarSchoolJumpAccessItem
			{
				ClickCallback = new Action<SolarSchoolJumpAccessItemData>(this.OnAccessClick)
			};
		}

		// Token: 0x06038A90 RID: 232080 RVA: 0x00FDB6D7 File Offset: 0x00FD98D7
		private void OnAccessClick(SolarSchoolJumpAccessItemData data)
		{
			Action onJump = data.OnJump;
			if (onJump != null)
			{
				onJump();
			}
			this.CloseSelf();
		}

		// Token: 0x06038A91 RID: 232081 RVA: 0x00FDB6F0 File Offset: 0x00FD98F0
		protected override void OnBeforeShow()
		{
			if (this.Param == null)
			{
				return;
			}
			LoopScrollView<SolarSchoolJumpAccessItem, SolarSchoolJumpAccessItemData> accessLayout = this.AccessLayout;
			if (accessLayout != null)
			{
				accessLayout.RefreshByData(this.Param.DataList, false, null, false);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), this.Param.TitleId, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), this.Param.TipsId, Array.Empty<object>());
		}

		// Token: 0x06038A92 RID: 232082 RVA: 0x00FDB768 File Offset: 0x00FD9968
		protected override void OnBeforeDestroy()
		{
			this.AccessLayout = null;
			SolarSchoolJumpAccessPopupParam param = this.Param;
			this.Param = null;
			if (param == null)
			{
				return;
			}
			Action closeCallback = param.CloseCallback;
			param.CloseCallback = null;
			try
			{
				if (closeCallback != null)
				{
					closeCallback();
				}
			}
			catch (Exception item)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[SolarSchool] 途径跳转弹窗关闭回调异常";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("exception", item);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x0401DD4C RID: 122188
		[Nullable(2)]
		private SolarSchoolJumpAccessPopupParam Param;

		// Token: 0x0401DD4D RID: 122189
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<SolarSchoolJumpAccessItem, SolarSchoolJumpAccessItemData> AccessLayout;

		// Token: 0x0200B586 RID: 46470
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04038214 RID: 229908
			public const int TxtTitle = 0;

			// Token: 0x04038215 RID: 229909
			public const int TxtTips = 1;

			// Token: 0x04038216 RID: 229910
			public const int AccessLayout = 2;

			// Token: 0x04038217 RID: 229911
			public const int AccessItem = 3;
		}
	}
}
