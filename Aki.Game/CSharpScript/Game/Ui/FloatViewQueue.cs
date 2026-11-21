using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003589 RID: 13705
	[NullableContext(1)]
	[Nullable(0)]
	public class FloatViewQueue
	{
		// Token: 0x06022F0E RID: 143118 RVA: 0x009EA390 File Offset: 0x009E8590
		public void Push(UiViewBase view, int priority, bool onlyShowInMain)
		{
			int num = this.WaitViewList.Count;
			while (num > 0 && this.WaitViewList[num - 1].Priority < priority)
			{
				num--;
			}
			this.WaitViewList.Insert(num, new FloatViewQueue.UiViewBaseWrapper
			{
				ViewBase = view,
				Priority = priority,
				OnlyShowInMain = onlyShowInMain
			});
		}

		// Token: 0x06022F0F RID: 143119 RVA: 0x009EA3F0 File Offset: 0x009E85F0
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

		// Token: 0x06022F10 RID: 143120 RVA: 0x009EA438 File Offset: 0x009E8638
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

		// Token: 0x06022F11 RID: 143121 RVA: 0x009EA468 File Offset: 0x009E8668
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

		// Token: 0x06022F12 RID: 143122 RVA: 0x009EA4F0 File Offset: 0x009E86F0
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

		// Token: 0x06022F13 RID: 143123 RVA: 0x009EA53C File Offset: 0x009E873C
		public void Clear(List<UiViewBase> droppedViews)
		{
			for (int i = this.WaitViewList.Count - 1; i >= 0; i--)
			{
				UiViewBase viewBase = this.WaitViewList[i].ViewBase;
				if (!viewBase.ViewInfo.IsPermanent)
				{
					this.WaitViewList.RemoveAt(i);
					UiManager.Instance.RemoveView(viewBase.GetViewId());
					droppedViews.Add(viewBase);
				}
			}
		}

		// Token: 0x170048C0 RID: 18624
		// (get) Token: 0x06022F14 RID: 143124 RVA: 0x009EA5A3 File Offset: 0x009E87A3
		public int Size
		{
			get
			{
				return this.WaitViewList.Count;
			}
		}

		// Token: 0x0401348B RID: 78987
		private List<IUiViewBase> WaitViewList = new List<IUiViewBase>();

		// Token: 0x02009277 RID: 37495
		[Nullable(0)]
		private class UiViewBaseWrapper : IUiViewBase
		{
			// Token: 0x170078DC RID: 30940
			// (get) Token: 0x06043A44 RID: 277060 RVA: 0x013FBD72 File Offset: 0x013F9F72
			// (set) Token: 0x06043A45 RID: 277061 RVA: 0x013FBD7A File Offset: 0x013F9F7A
			public UiViewBase ViewBase { get; set; }

			// Token: 0x170078DD RID: 30941
			// (get) Token: 0x06043A46 RID: 277062 RVA: 0x013FBD83 File Offset: 0x013F9F83
			// (set) Token: 0x06043A47 RID: 277063 RVA: 0x013FBD8B File Offset: 0x013F9F8B
			public int Priority { get; set; }

			// Token: 0x170078DE RID: 30942
			// (get) Token: 0x06043A48 RID: 277064 RVA: 0x013FBD94 File Offset: 0x013F9F94
			// (set) Token: 0x06043A49 RID: 277065 RVA: 0x013FBD9C File Offset: 0x013F9F9C
			public bool OnlyShowInMain { get; set; }
		}
	}
}
