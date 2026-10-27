using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004658 RID: 18008
	[NullableContext(1)]
	[Nullable(0)]
	public class FloatViewQueue
	{
		// Token: 0x0602E7C4 RID: 190404 RVA: 0x00ABCD60 File Offset: 0x00ABAF60
		public void Push(UiViewBase view, int priority, bool onlyShowInMain)
		{
			this.WaitViewList.Add(new FloatViewQueue.UiViewBaseWrapper
			{
				ViewBase = view,
				Priority = priority,
				OnlyShowInMain = onlyShowInMain
			});
			this.WaitViewList = (from v in this.WaitViewList
			orderby v.Priority descending
			select v).ToList<IUiViewBase>();
		}

		// Token: 0x0602E7C5 RID: 190405 RVA: 0x00ABCDC8 File Offset: 0x00ABAFC8
		public IUiViewBase Pop(bool inMainView)
		{
			for (int i = 0; i < this.WaitViewList.Count; i++)
			{
				IUiViewBase uiViewBase = this.WaitViewList[i];
				if (!uiViewBase.OnlyShowInMain || inMainView)
				{
					this.DeleteView(uiViewBase);
					return uiViewBase;
				}
			}
			return null;
		}

		// Token: 0x0602E7C6 RID: 190406 RVA: 0x00ABCE10 File Offset: 0x00ABB010
		private bool DeleteView(IUiViewBase view)
		{
			int num = this.WaitViewList.IndexOf(view);
			if (num < 0)
			{
				return false;
			}
			this.WaitViewList.RemoveAt(num);
			return true;
		}

		// Token: 0x0602E7C7 RID: 190407 RVA: 0x00ABCE40 File Offset: 0x00ABB040
		public bool Delete(EUiViewName name, int? viewId = null)
		{
			for (int i = 0; i < this.WaitViewList.Count; i++)
			{
				IUiViewBase uiViewBase = this.WaitViewList[i];
				if (!(uiViewBase.ViewBase.ViewInfo.Name != name) && (viewId == null || uiViewBase.ViewBase.GetViewId() == viewId.Value))
				{
					this.DeleteView(uiViewBase);
					UiManager.Instance.RemoveView(uiViewBase.ViewBase.GetViewId());
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602E7C8 RID: 190408 RVA: 0x00ABCEC8 File Offset: 0x00ABB0C8
		public bool Has(EUiViewName name)
		{
			for (int i = 0; i < this.WaitViewList.Count; i++)
			{
				if (this.WaitViewList[i].ViewBase.ViewInfo.Name == name)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602E7C9 RID: 190409 RVA: 0x00ABCF14 File Offset: 0x00ABB114
		public void Clear()
		{
			for (int i = this.WaitViewList.Count - 1; i >= 0; i--)
			{
				UiViewBase viewBase = this.WaitViewList[i].ViewBase;
				if (!viewBase.ViewInfo.IsPermanent)
				{
					this.WaitViewList.RemoveAt(i);
					UiManager.Instance.RemoveView(viewBase.GetViewId());
				}
			}
		}

		// Token: 0x17007604 RID: 30212
		// (get) Token: 0x0602E7CA RID: 190410 RVA: 0x00ABCF74 File Offset: 0x00ABB174
		public int Size
		{
			get
			{
				return this.WaitViewList.Count;
			}
		}

		// Token: 0x04018E32 RID: 101938
		private List<IUiViewBase> WaitViewList = new List<IUiViewBase>();

		// Token: 0x0200A8BB RID: 43195
		[Nullable(0)]
		private class UiViewBaseWrapper : IUiViewBase
		{
			// Token: 0x1700A146 RID: 41286
			// (get) Token: 0x0604D514 RID: 316692 RVA: 0x0144D97E File Offset: 0x0144BB7E
			// (set) Token: 0x0604D515 RID: 316693 RVA: 0x0144D986 File Offset: 0x0144BB86
			public UiViewBase ViewBase { get; set; }

			// Token: 0x1700A147 RID: 41287
			// (get) Token: 0x0604D516 RID: 316694 RVA: 0x0144D98F File Offset: 0x0144BB8F
			// (set) Token: 0x0604D517 RID: 316695 RVA: 0x0144D997 File Offset: 0x0144BB97
			public int Priority { get; set; }

			// Token: 0x1700A148 RID: 41288
			// (get) Token: 0x0604D518 RID: 316696 RVA: 0x0144D9A0 File Offset: 0x0144BBA0
			// (set) Token: 0x0604D519 RID: 316697 RVA: 0x0144D9A8 File Offset: 0x0144BBA8
			public bool OnlyShowInMain { get; set; }
		}
	}
}
