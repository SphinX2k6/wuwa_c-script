using System;
using System.Collections.Generic;
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
	// Token: 0x02005693 RID: 22163
	public class ActivityDirectTrainProView : UiViewBase
	{
		// Token: 0x06036AFE RID: 223998 RVA: 0x00F42898 File Offset: 0x00F40A98
		[NullableContext(1)]
		public ActivityDirectTrainProView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06036AFF RID: 223999 RVA: 0x00F428A4 File Offset: 0x00F40AA4
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

		// Token: 0x06036B00 RID: 224000 RVA: 0x00F42930 File Offset: 0x00F40B30
		protected override UniTask OnBeforeStartAsync()
		{
			ActivityDirectTrainProView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityDirectTrainProView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036B01 RID: 224001 RVA: 0x00F42973 File Offset: 0x00F40B73
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

		// Token: 0x06036B02 RID: 224002 RVA: 0x00F42992 File Offset: 0x00F40B92
		protected override void OnBeforeShow()
		{
			this.RefreshList();
		}

		// Token: 0x06036B03 RID: 224003 RVA: 0x00F4299C File Offset: 0x00F40B9C
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
			IReadOnlyList<DirectTrainSubActivityViewModel> data = instance.BuildSubActivityViewModels(instance.GetProSubActivityIds(), allProSubActivityCaches, instance.GetProMainActivityId());
			this.ItemLayout.RefreshByData(data, null, false);
		}

		// Token: 0x06036B04 RID: 224004 RVA: 0x00F429E5 File Offset: 0x00F40BE5
		[NullableContext(1)]
		private DirectTrainSubActivityItem CreateSubActivityItem()
		{
			return new DirectTrainSubActivityItem();
		}

		// Token: 0x06036B05 RID: 224005 RVA: 0x00F429EC File Offset: 0x00F40BEC
		private void OnClickHelp()
		{
			int proMainActivityHelpId = DirectTrainModel.Instance.GetProMainActivityHelpId();
			if (proMainActivityHelpId <= 0)
			{
				return;
			}
			HelpController.Instance.OpenHelpById(proMainActivityHelpId);
		}

		// Token: 0x06036B06 RID: 224006 RVA: 0x00F42A14 File Offset: 0x00F40C14
		private void OnCloseView()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401CE4D RID: 118349
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401CE4E RID: 118350
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DirectTrainSubActivityItem, DirectTrainSubActivityViewModel> ItemLayout;

		// Token: 0x0401CE4F RID: 118351
		[Nullable(2)]
		private UUIInturnAnimController AnimController;

		// Token: 0x0200B289 RID: 45705
		private enum EProComponents
		{
			// Token: 0x040372A1 RID: 225953
			ItemCaption,
			// Token: 0x040372A2 RID: 225954
			Content,
			// Token: 0x040372A3 RID: 225955
			SubItemPrefab
		}
	}
}
