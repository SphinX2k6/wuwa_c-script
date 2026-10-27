using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain.MainActivity
{
	// Token: 0x02006751 RID: 26449
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DirectTrainSubActivityItem : GridProxyAbstract<DirectTrainSubActivityViewModel>
	{
		// Token: 0x0604202E RID: 270382 RVA: 0x01003354 File Offset: 0x01001554
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
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
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnItemClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0604202F RID: 270383 RVA: 0x010034C0 File Offset: 0x010016C0
		public override void Refresh(DirectTrainSubActivityViewModel data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.RefreshState();
		}

		// Token: 0x06042030 RID: 270384 RVA: 0x010034CF File Offset: 0x010016CF
		protected override void OnStart()
		{
			EventSystem.Instance.Add<int>(EEventName.ActivityDirectTrainRedDotUpdate, new Action<int>(this.OnRedDotUpdate));
		}

		// Token: 0x06042031 RID: 270385 RVA: 0x010034ED File Offset: 0x010016ED
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove<int>(EEventName.ActivityDirectTrainRedDotUpdate, new Action<int>(this.OnRedDotUpdate));
		}

		// Token: 0x06042032 RID: 270386 RVA: 0x0100350B File Offset: 0x0100170B
		private void OnRedDotUpdate(int _)
		{
			this.RefreshRedDot();
		}

		// Token: 0x06042033 RID: 270387 RVA: 0x01003513 File Offset: 0x01001713
		public override object GetKey(DirectTrainSubActivityViewModel data, int displayIndex)
		{
			return data.SubActivityId;
		}

		// Token: 0x06042034 RID: 270388 RVA: 0x01003520 File Offset: 0x01001720
		private void RefreshState()
		{
			if (this.Data == null)
			{
				return;
			}
			bool isFinish = this.Data.IsFinish;
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(!isFinish);
			}
			UUIItem item2 = base.GetItem(6);
			if (item2 != null)
			{
				item2.SetUIActive(isFinish);
			}
			this.RefreshRedDot();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), this.Data.VersionTitle, Array.Empty<object>());
			UUIText text = base.GetText(4);
			if (text != null)
			{
				text.SetText(this.Data.Name, true);
			}
			UUIItem item3 = base.GetItem(2);
			if (item3 != null)
			{
				item3.SetUIActive(this.Data.ShowRecommend);
			}
			UUITexture texture = base.GetTexture(1);
			if (texture != null && !string.IsNullOrEmpty(this.Data.EntryPicPath))
			{
				texture.SetUIActive(false);
				base.SetTextureByPath(this.Data.EntryPicPath, texture, null, delegate(bool _)
				{
					texture.SetUIActive(true);
				});
			}
		}

		// Token: 0x06042035 RID: 270389 RVA: 0x01003634 File Offset: 0x01001834
		private void RefreshRedDot()
		{
			if (this.Data == null)
			{
				return;
			}
			DirectTrainModel instance = DirectTrainModel.Instance;
			bool uiactive = instance != null && instance.IsSubActivityRedDotOn(this.Data.SubActivityId);
			UUIItem item = base.GetItem(7);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(uiactive);
		}

		// Token: 0x06042036 RID: 270390 RVA: 0x0100367C File Offset: 0x0100187C
		private void OnItemClick()
		{
			if (this.Data == null)
			{
				return;
			}
			this.Data.ReportOpenModule();
			DirectTrainModel instance = DirectTrainModel.Instance;
			if (instance != null)
			{
				instance.MarkSubActivityAsRead(this.Data.SubActivityId);
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.Data.MainActivityId);
			UiManager.Instance.OpenView(EUiViewName.DirectTrainDetailView, this.Data, null);
		}

		// Token: 0x0402261D RID: 140829
		[Nullable(2)]
		private DirectTrainSubActivityViewModel Data;

		// Token: 0x0200C8CB RID: 51403
		[NullableContext(0)]
		private enum EPlotArriveItemComponents
		{
			// Token: 0x0403C9F0 RID: 248304
			ItemSelf,
			// Token: 0x0403C9F1 RID: 248305
			TexPic,
			// Token: 0x0403C9F2 RID: 248306
			ItemRecommend,
			// Token: 0x0403C9F3 RID: 248307
			TxtTitle,
			// Token: 0x0403C9F4 RID: 248308
			TxtName,
			// Token: 0x0403C9F5 RID: 248309
			ItemNotFinish,
			// Token: 0x0403C9F6 RID: 248310
			ItemFinished,
			// Token: 0x0403C9F7 RID: 248311
			RedDotItem
		}
	}
}
