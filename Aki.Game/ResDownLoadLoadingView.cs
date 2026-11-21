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

// Token: 0x02001C47 RID: 7239
public class ResDownLoadLoadingView : UiViewBase
{
	// Token: 0x06011F8A RID: 73610 RVA: 0x005491A4 File Offset: 0x005473A4
	[NullableContext(1)]
	public ResDownLoadLoadingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011F8B RID: 73611 RVA: 0x005491B0 File Offset: 0x005473B0
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

	// Token: 0x06011F8C RID: 73612 RVA: 0x0054923A File Offset: 0x0054743A
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<EVideoDownloadStatus>(EEventName.ResDownLoadStateRefresh, new Action<EVideoDownloadStatus>(this.ResDownLoadStateRefresh));
	}

	// Token: 0x06011F8D RID: 73613 RVA: 0x00549258 File Offset: 0x00547458
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.ResDownLoadStateRefresh, new Action<EVideoDownloadStatus>(this.ResDownLoadStateRefresh));
	}

	// Token: 0x06011F8E RID: 73614 RVA: 0x00549278 File Offset: 0x00547478
	protected override void OnStart()
	{
		ResourceManagerController.Instance.ChangeHttpTickFrequency();
		this.RefreshView();
		this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
		{
			this.RefreshView();
		}, (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
	}

	// Token: 0x06011F8F RID: 73615 RVA: 0x005492C4 File Offset: 0x005474C4
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

	// Token: 0x06011F90 RID: 73616 RVA: 0x005493C0 File Offset: 0x005475C0
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

	// Token: 0x06011F91 RID: 73617 RVA: 0x005494C0 File Offset: 0x005476C0
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

	// Token: 0x06011F92 RID: 73618 RVA: 0x00549525 File Offset: 0x00547725
	protected override void OnBeforeDestroy()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
		ResourceManagerController.Instance.RestoreHttpTickFrequency();
	}

	// Token: 0x04009CB0 RID: 40112
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x04009CB1 RID: 40113
	private long MaxSize;

	// Token: 0x02007F4B RID: 32587
	private enum EComponentDefine
	{
		// Token: 0x04029333 RID: 168755
		BarTexture,
		// Token: 0x04029334 RID: 168756
		ProgressText,
		// Token: 0x04029335 RID: 168757
		SpeedText
	}
}
