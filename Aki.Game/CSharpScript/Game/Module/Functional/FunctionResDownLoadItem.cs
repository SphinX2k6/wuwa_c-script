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
	// Token: 0x020049F8 RID: 18936
	public class FunctionResDownLoadItem : UiPanelBase
	{
		// Token: 0x0602F76B RID: 194411 RVA: 0x00D3CC08 File Offset: 0x00D3AE08
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

		// Token: 0x0602F76C RID: 194412 RVA: 0x00D3CCAE File Offset: 0x00D3AEAE
		protected override void OnStart()
		{
			this.AddEventListeners();
		}

		// Token: 0x0602F76D RID: 194413 RVA: 0x00D3CCB6 File Offset: 0x00D3AEB6
		protected override void OnBeforeDestroy()
		{
			this.RemoveEventListeners();
			if (this.TimerHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x0602F76E RID: 194414 RVA: 0x00D3CCDE File Offset: 0x00D3AEDE
		private void AddEventListeners()
		{
			EventSystem.Instance.Add(EEventName.OnRefreshSubPackDownLoadState, new Action(this.ResDownLoadStateRefresh));
		}

		// Token: 0x0602F76F RID: 194415 RVA: 0x00D3CCFC File Offset: 0x00D3AEFC
		private void RemoveEventListeners()
		{
			EventSystem.Instance.Remove(EEventName.OnRefreshSubPackDownLoadState, new Action(this.ResDownLoadStateRefresh));
		}

		// Token: 0x0602F770 RID: 194416 RVA: 0x00D3CD1C File Offset: 0x00D3AF1C
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

		// Token: 0x0602F771 RID: 194417 RVA: 0x00D3CD6C File Offset: 0x00D3AF6C
		private void ResDownLoadStateRefresh()
		{
			this.Update();
		}

		// Token: 0x0602F772 RID: 194418 RVA: 0x00D3CD74 File Offset: 0x00D3AF74
		public void Update()
		{
			this.Refresh();
		}

		// Token: 0x0602F773 RID: 194419 RVA: 0x00D3CD7C File Offset: 0x00D3AF7C
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

		// Token: 0x0602F774 RID: 194420 RVA: 0x00D3CDE8 File Offset: 0x00D3AFE8
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

		// Token: 0x0602F775 RID: 194421 RVA: 0x00D3CE4A File Offset: 0x00D3B04A
		public void EndShow()
		{
			if (this.TimerHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x04019246 RID: 102982
		[Nullable(2)]
		private TimerHandle TimerHandle;

		// Token: 0x0200A69A RID: 42650
		private class EComponentDefine
		{
			// Token: 0x04033804 RID: 210948
			public const int DownLoadBarTexture = 0;

			// Token: 0x04033805 RID: 210949
			public const int DownLoadBtn = 1;
		}
	}
}
