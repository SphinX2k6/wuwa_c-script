using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RecallQuest.Model;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Functional
{
	// Token: 0x02005A1C RID: 23068
	public class FunctionResDownLoadItem : UiPanelBase
	{
		// Token: 0x0603A822 RID: 239650 RVA: 0x00DEC678 File Offset: 0x00DEA878
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnDownLoadBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603A823 RID: 239651 RVA: 0x00DEC71E File Offset: 0x00DEA91E
		protected override void OnStart()
		{
			this.AddEventListeners();
		}

		// Token: 0x0603A824 RID: 239652 RVA: 0x00DEC726 File Offset: 0x00DEA926
		protected override void OnBeforeDestroy()
		{
			this.RemoveEventListeners();
			if (this.TimerHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x0603A825 RID: 239653 RVA: 0x00DEC74E File Offset: 0x00DEA94E
		private void AddEventListeners()
		{
			EventSystem.Instance.Add(EEventName.OnRefreshSubPackDownLoadState, new Action(this.ResDownLoadStateRefresh));
		}

		// Token: 0x0603A826 RID: 239654 RVA: 0x00DEC76C File Offset: 0x00DEA96C
		private void RemoveEventListeners()
		{
			EventSystem.Instance.Remove(EEventName.OnRefreshSubPackDownLoadState, new Action(this.ResDownLoadStateRefresh));
		}

		// Token: 0x0603A827 RID: 239655 RVA: 0x00DEC78C File Offset: 0x00DEA98C
		private void OnDownLoadBtnClick()
		{
			if (RecallQuestModel.Instance.IsInRecallInstance())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Download_BanDownloadSystem", Array.Empty<object>());
				return;
			}
			if (!UiManager.Instance.IsViewOpen(EUiViewName.SubPackageDownLoadView))
			{
				UiManager.Instance.OpenView(EUiViewName.SubPackageDownLoadView, null, null);
			}
		}

		// Token: 0x0603A828 RID: 239656 RVA: 0x00DEC7DC File Offset: 0x00DEA9DC
		private void ResDownLoadStateRefresh()
		{
			this.Update();
		}

		// Token: 0x0603A829 RID: 239657 RVA: 0x00DEC7E4 File Offset: 0x00DEA9E4
		public void Update()
		{
			this.Refresh();
		}

		// Token: 0x0603A82A RID: 239658 RVA: 0x00DEC7EC File Offset: 0x00DEA9EC
		public void Refresh()
		{
			UUITexture texture = base.GetTexture(0);
			ValueTuple<float, ESubPackageDownLoadState> valueTuple = SubPackageDownLoadModel.Instance.DownLoadPercentage();
			texture.SetFillAmount(valueTuple.Item1);
			FColor? fcolor;
			if (valueTuple.Item2 == ESubPackageDownLoadState.DownLoading)
			{
				UUIItem texture2 = base.GetTexture(0);
				bool bUseChangeColor = false;
				fcolor = new FColor?(texture.changeColor);
				texture2.SetChangeColor(bUseChangeColor, fcolor);
				return;
			}
			UUIItem texture3 = base.GetTexture(0);
			bool bUseChangeColor2 = true;
			fcolor = new FColor?(texture.changeColor);
			texture3.SetChangeColor(bUseChangeColor2, fcolor);
		}

		// Token: 0x0603A82B RID: 239659 RVA: 0x00DEC858 File Offset: 0x00DEAA58
		public void StartShow()
		{
			this.Update();
			if (this.TimerHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
			this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float delta)
			{
				this.Update();
			}, (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
		}

		// Token: 0x0603A82C RID: 239660 RVA: 0x00DEC8BA File Offset: 0x00DEAABA
		public void EndShow()
		{
			if (this.TimerHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x0401E79F RID: 124831
		[Nullable(2)]
		private TimerHandle TimerHandle;

		// Token: 0x0200BC91 RID: 48273
		private class EComponentDefine
		{
			// Token: 0x04038E39 RID: 233017
			public const int DownLoadBarTexture = 0;

			// Token: 0x04038E3A RID: 233018
			public const int DownLoadBtn = 1;
		}
	}
}
