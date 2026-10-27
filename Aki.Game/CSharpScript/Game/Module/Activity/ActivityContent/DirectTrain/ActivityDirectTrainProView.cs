using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain.MainActivity;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain
{
	// Token: 0x02006743 RID: 26435
	public class ActivityDirectTrainProView : UiViewBase
	{
		// Token: 0x06041FB2 RID: 270258 RVA: 0x010014E8 File Offset: 0x00FFF6E8
		[NullableContext(1)]
		public ActivityDirectTrainProView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06041FB3 RID: 270259 RVA: 0x010014F4 File Offset: 0x00FFF6F4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06041FB4 RID: 270260 RVA: 0x01001580 File Offset: 0x00FFF780
		protected override UniTask OnBeforeStartAsync()
		{
			ActivityDirectTrainProView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityDirectTrainProView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06041FB5 RID: 270261 RVA: 0x010015C3 File Offset: 0x00FFF7C3
		protected override void OnStart()
		{
			this.RefreshList();
			UUIInturnAnimController animController = this.AnimController;
			if (animController == null)
			{
				return;
			}
			animController.Play("Start", -1, false);
		}

		// Token: 0x06041FB6 RID: 270262 RVA: 0x010015E2 File Offset: 0x00FFF7E2
		protected override void OnBeforeShow()
		{
			this.RefreshList();
		}

		// Token: 0x06041FB7 RID: 270263 RVA: 0x010015EC File Offset: 0x00FFF7EC
		private void RefreshList()
		{
			if (this.ItemLayout == null)
			{
				return;
			}
			DirectTrainModel instance = DirectTrainModel.Instance;
			if (instance == null)
			{
				return;
			}
			IReadOnlyDictionary<int, IDirectTrainSubActivityCache> allProSubActivityCaches = instance.GetAllProSubActivityCaches();
			IReadOnlyList<DirectTrainSubActivityViewModel> source = instance.BuildSubActivityViewModels(instance.GetProSubActivityIds(), allProSubActivityCaches, instance.GetProMainActivityId());
			this.ItemLayout.RefreshByData(source.ToList<DirectTrainSubActivityViewModel>(), null, false);
		}

		// Token: 0x06041FB8 RID: 270264 RVA: 0x0100163A File Offset: 0x00FFF83A
		[NullableContext(1)]
		private DirectTrainSubActivityItem CreateSubActivityItem()
		{
			return new DirectTrainSubActivityItem();
		}

		// Token: 0x06041FB9 RID: 270265 RVA: 0x01001644 File Offset: 0x00FFF844
		private void OnClickHelp()
		{
			int proMainActivityHelpId = DirectTrainModel.Instance.GetProMainActivityHelpId();
			if (proMainActivityHelpId <= 0)
			{
				return;
			}
			HelpController.Instance.OpenHelpById(proMainActivityHelpId);
		}

		// Token: 0x06041FBA RID: 270266 RVA: 0x0100166C File Offset: 0x00FFF86C
		private void OnCloseView()
		{
			base.CloseMe(null);
		}

		// Token: 0x040225F4 RID: 140788
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x040225F5 RID: 140789
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DirectTrainSubActivityItem, DirectTrainSubActivityViewModel> ItemLayout;

		// Token: 0x040225F6 RID: 140790
		[Nullable(2)]
		private UUIInturnAnimController AnimController;

		// Token: 0x0200C8BA RID: 51386
		private enum EProComponents
		{
			// Token: 0x0403C9A7 RID: 248231
			ItemCaption,
			// Token: 0x0403C9A8 RID: 248232
			Content,
			// Token: 0x0403C9A9 RID: 248233
			SubItemPrefab
		}
	}
}
