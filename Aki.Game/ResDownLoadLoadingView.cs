using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ResManager;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Launcher.Update;
using UnrealEngine;

// Token: 0x0200275C RID: 10076
public class ResDownLoadLoadingView : UiViewBase
{
	// Token: 0x06014AA7 RID: 84647 RVA: 0x0053A310 File Offset: 0x00538510
	[NullableContext(1)]
	public ResDownLoadLoadingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014AA8 RID: 84648 RVA: 0x0053A31C File Offset: 0x0053851C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06014AA9 RID: 84649 RVA: 0x0053A3A6 File Offset: 0x005385A6
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<EVideoDownloadStatus>(EEventName.ResDownLoadStateRefresh, new Action<EVideoDownloadStatus>(this.ResDownLoadStateRefresh));
	}

	// Token: 0x06014AAA RID: 84650 RVA: 0x0053A3C4 File Offset: 0x005385C4
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.ResDownLoadStateRefresh, new Action<EVideoDownloadStatus>(this.ResDownLoadStateRefresh));
	}

	// Token: 0x06014AAB RID: 84651 RVA: 0x0053A3E4 File Offset: 0x005385E4
	protected override void OnStart()
	{
		ResourceManagerController.Instance.ChangeHttpTickFrequency();
		this.RefreshView();
		this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
		{
			this.RefreshView();
		}, (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
	}

	// Token: 0x06014AAC RID: 84652 RVA: 0x0053A430 File Offset: 0x00538630
	private void DownloadFinish()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "DownLoadText_Downing", Array.Empty<object>());
		float num = (float)this.MaxSize / (float)this.MaxSize;
		string str = HotFixManager.ByteConverter(0L) + "/s ";
		string str2 = string.Concat(new string[]
		{
			"(",
			HotFixManager.ByteConverter(this.MaxSize),
			"/",
			HotFixManager.ByteConverter(this.MaxSize),
			") "
		});
		base.GetTexture(0).SetFillAmount(num);
		string str3 = (num * 100f).ToString("F2").TrimEnd('0').TrimEnd('.') + "%";
		base.GetText(2).SetText(str + str2 + str3, true);
	}

	// Token: 0x06014AAD RID: 84653 RVA: 0x0053A52C File Offset: 0x0053872C
	private void RefreshView()
	{
		ValueTuple<long, long, long, long> downLoadProgress = VideoUpdateManager.Instance.GetVideoUpdater(EVideoResSizeType.LoginPrepare).GetDownLoadProgress();
		this.MaxSize = downLoadProgress.Item3;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "DownLoadText_Downing", Array.Empty<object>());
		float num = (float)downLoadProgress.Item2 / (float)downLoadProgress.Item3;
		string str = HotFixManager.ByteConverter(downLoadProgress.Item4) + "/s ";
		string str2 = string.Concat(new string[]
		{
			"(",
			HotFixManager.ByteConverter(downLoadProgress.Item2),
			"/",
			HotFixManager.ByteConverter(downLoadProgress.Item3),
			") "
		});
		base.GetTexture(0).SetFillAmount(num);
		string str3 = (num * 100f).ToString("F2").TrimEnd('0').TrimEnd('.') + "%";
		base.GetText(2).SetText(str + str2 + str3, true);
	}

	// Token: 0x06014AAE RID: 84654 RVA: 0x0053A62C File Offset: 0x0053882C
	private void ResDownLoadStateRefresh(EVideoDownloadStatus state)
	{
		if (state == EVideoDownloadStatus.Done)
		{
			this.DownloadFinish();
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ResDownLoadDoneConfirm);
			confirmBoxDataNew.IsEscViewTriggerCallBack = true;
			confirmBoxDataNew.FunctionMap.Add(0, delegate
			{
				base.CloseMe(null);
				QuestResourceModel.Instance.UserClicked();
			});
			confirmBoxDataNew.FunctionMap.Add(1, delegate
			{
				base.CloseMe(null);
				QuestResourceModel.Instance.UserClicked();
			});
			ConfirmBoxController.Instance.ShowNetWorkConfirmBoxView(confirmBoxDataNew, null);
		}
	}

	// Token: 0x06014AAF RID: 84655 RVA: 0x0053A691 File Offset: 0x00538891
	protected override void OnBeforeDestroy()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
		ResourceManagerController.Instance.RestoreHttpTickFrequency();
	}

	// Token: 0x04009B57 RID: 39767
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x04009B58 RID: 39768
	private long MaxSize;

	// Token: 0x02008DC2 RID: 36290
	private enum EComponentDefine
	{
		// Token: 0x0402E01C RID: 188444
		BarTexture,
		// Token: 0x0402E01D RID: 188445
		ProgressText,
		// Token: 0x0402E01E RID: 188446
		SpeedText
	}
}
