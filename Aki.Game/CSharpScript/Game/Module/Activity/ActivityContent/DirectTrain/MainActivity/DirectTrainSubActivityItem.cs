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
	// Token: 0x020056A1 RID: 22177
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DirectTrainSubActivityItem : GridProxyAbstract<DirectTrainSubActivityViewModel>
	{
		// Token: 0x06036B80 RID: 224128 RVA: 0x00F44790 File Offset: 0x00F42990
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

		// Token: 0x06036B81 RID: 224129 RVA: 0x00F448FC File Offset: 0x00F42AFC
		public override void Refresh(DirectTrainSubActivityViewModel data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.RefreshState();
		}

		// Token: 0x06036B82 RID: 224130 RVA: 0x00F4490B File Offset: 0x00F42B0B
		protected override void OnStart()
		{
			EventSystem.Instance.Add<int>(EEventName.ActivityDirectTrainRedDotUpdate, new Action<int>(this.OnRedDotUpdate));
		}

		// Token: 0x06036B83 RID: 224131 RVA: 0x00F44929 File Offset: 0x00F42B29
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove<int>(EEventName.ActivityDirectTrainRedDotUpdate, new Action<int>(this.OnRedDotUpdate));
		}

		// Token: 0x06036B84 RID: 224132 RVA: 0x00F44947 File Offset: 0x00F42B47
		private void OnRedDotUpdate(int _)
		{
			this.RefreshRedDot();
		}

		// Token: 0x06036B85 RID: 224133 RVA: 0x00F4494F File Offset: 0x00F42B4F
		public override object GetKey(DirectTrainSubActivityViewModel data, int displayIndex)
		{
			return data.SubActivityId;
		}

		// Token: 0x06036B86 RID: 224134 RVA: 0x00F4495C File Offset: 0x00F42B5C
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

		// Token: 0x06036B87 RID: 224135 RVA: 0x00F44A70 File Offset: 0x00F42C70
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

		// Token: 0x06036B88 RID: 224136 RVA: 0x00F44AB8 File Offset: 0x00F42CB8
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

		// Token: 0x0401CE76 RID: 118390
		[Nullable(2)]
		private DirectTrainSubActivityViewModel Data;

		// Token: 0x0200B29A RID: 45722
		[NullableContext(0)]
		private enum EPlotArriveItemComponents
		{
			// Token: 0x040372EA RID: 226026
			ItemSelf,
			// Token: 0x040372EB RID: 226027
			TexPic,
			// Token: 0x040372EC RID: 226028
			ItemRecommend,
			// Token: 0x040372ED RID: 226029
			TxtTitle,
			// Token: 0x040372EE RID: 226030
			TxtName,
			// Token: 0x040372EF RID: 226031
			ItemNotFinish,
			// Token: 0x040372F0 RID: 226032
			ItemFinished,
			// Token: 0x040372F1 RID: 226033
			RedDotItem
		}
	}
}
