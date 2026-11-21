using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003569 RID: 13673
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class UiTabViewBase : UiPanelBase
	{
		// Token: 0x06022CE6 RID: 142566 RVA: 0x009E39C4 File Offset: 0x009E1BC4
		public void SetTabViewName(EUiTabViewName tabViewName)
		{
			this.TabViewName = new EUiTabViewName?(tabViewName);
		}

		// Token: 0x06022CE7 RID: 142567 RVA: 0x009E39D2 File Offset: 0x009E1BD2
		protected override void OnBeforeShowImplement()
		{
			if (this.TickId == -1)
			{
				this.TickId = TickSystem.Instance.Add(new Action<float>(this.TickHandler), "TabViewTick", ETickingGroup.TG_PrePhysics, true, 0, false).Id;
			}
			this.AddEventListener();
		}

		// Token: 0x06022CE8 RID: 142568 RVA: 0x009E3A10 File Offset: 0x009E1C10
		protected override void OnAfterHideImplement()
		{
			if (this.TickId != -1)
			{
				TickSystem.Instance.Remove(this.TickId);
				this.TickId = -1;
			}
			EventSystem.Instance.Emit<EUiTabViewName>(EEventName.CloseTabView, this.TabViewName.Value);
			this.RemoveEventListener();
		}

		// Token: 0x06022CE9 RID: 142569 RVA: 0x009E3A5C File Offset: 0x009E1C5C
		protected virtual void AddEventListener()
		{
		}

		// Token: 0x06022CEA RID: 142570 RVA: 0x009E3A5E File Offset: 0x009E1C5E
		protected virtual void RemoveEventListener()
		{
		}

		// Token: 0x06022CEB RID: 142571 RVA: 0x009E3A60 File Offset: 0x009E1C60
		protected override void OnBeforeCreateImplement()
		{
			this.UiViewSequence = new UiBehaviorLevelSequence(this);
			base.AddUiBehavior(this.UiViewSequence);
		}

		// Token: 0x06022CEC RID: 142572 RVA: 0x009E3A7C File Offset: 0x009E1C7C
		protected override void OnStartImplement()
		{
			this.InitBehavior();
			this.OnInitBehaviour();
			foreach (TOperation toperation in this.OperationList)
			{
				toperation();
			}
			this.OperationList.Clear();
			this.BeginBehavior();
		}

		// Token: 0x06022CED RID: 142573 RVA: 0x009E3AEC File Offset: 0x009E1CEC
		private void TickHandler(float deltaTime)
		{
			this.OnTickUiTabViewBase(deltaTime);
		}

		// Token: 0x06022CEE RID: 142574 RVA: 0x009E3AF8 File Offset: 0x009E1CF8
		public T AddUiTabViewBehavior<[Nullable(0)] T>() where T : UiTabViewBehavior, new()
		{
			Type typeFromHandle = typeof(T);
			UiTabViewBehavior uiTabViewBehavior;
			if (!this.TabBehaviorMap.TryGetValue(typeFromHandle, out uiTabViewBehavior))
			{
				uiTabViewBehavior = Activator.CreateInstance<T>();
				this.TabBehaviorMap[typeFromHandle] = uiTabViewBehavior;
			}
			else
			{
				Log.Instance.Error(ELogModule.UiTabModule, ELogAuthor.XXJ, "功能模块添加重复,查看是否重复添加", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return (T)((object)uiTabViewBehavior);
		}

		// Token: 0x06022CEF RID: 142575 RVA: 0x009E3B5C File Offset: 0x009E1D5C
		public T GetTabBehavior<[Nullable(0)] T>() where T : UiTabViewBehavior
		{
			Type typeFromHandle = typeof(T);
			UiTabViewBehavior uiTabViewBehavior;
			if (this.TabBehaviorMap.TryGetValue(typeFromHandle, out uiTabViewBehavior))
			{
				return (T)((object)uiTabViewBehavior);
			}
			return default(T);
		}

		// Token: 0x06022CF0 RID: 142576 RVA: 0x009E3B94 File Offset: 0x009E1D94
		protected override void OnAfterShowImplement()
		{
			EventSystem.Instance.Emit<EUiTabViewName?, UiTabViewBase>(EEventName.OpenTabView, this.TabViewName, this);
		}

		// Token: 0x06022CF1 RID: 142577 RVA: 0x009E3BAC File Offset: 0x009E1DAC
		private void InitBehavior()
		{
			foreach (UiTabViewBehavior uiTabViewBehavior in this.TabBehaviorMap.Values)
			{
				uiTabViewBehavior.Init();
			}
		}

		// Token: 0x06022CF2 RID: 142578 RVA: 0x009E3C04 File Offset: 0x009E1E04
		private void BeginBehavior()
		{
			foreach (UiTabViewBehavior uiTabViewBehavior in this.TabBehaviorMap.Values)
			{
				uiTabViewBehavior.Begin();
			}
		}

		// Token: 0x06022CF3 RID: 142579 RVA: 0x009E3C5C File Offset: 0x009E1E5C
		private void ShowBehaviorFromView()
		{
			foreach (UiTabViewBehavior uiTabViewBehavior in this.TabBehaviorMap.Values)
			{
				uiTabViewBehavior.ShowFromView();
			}
		}

		// Token: 0x06022CF4 RID: 142580 RVA: 0x009E3CB4 File Offset: 0x009E1EB4
		private void ShowBehaviorFromToggle()
		{
			foreach (UiTabViewBehavior uiTabViewBehavior in this.TabBehaviorMap.Values)
			{
				uiTabViewBehavior.ShowFromToggle();
			}
		}

		// Token: 0x06022CF5 RID: 142581 RVA: 0x009E3D0C File Offset: 0x009E1F0C
		private void HideBehavior()
		{
			foreach (UiTabViewBehavior uiTabViewBehavior in this.TabBehaviorMap.Values)
			{
				uiTabViewBehavior.Hide();
			}
		}

		// Token: 0x06022CF6 RID: 142582 RVA: 0x009E3D64 File Offset: 0x009E1F64
		private void DestroyBehavior()
		{
			foreach (UiTabViewBehavior uiTabViewBehavior in this.TabBehaviorMap.Values)
			{
				uiTabViewBehavior.Destroy();
			}
		}

		// Token: 0x06022CF7 RID: 142583 RVA: 0x009E3DBC File Offset: 0x009E1FBC
		protected virtual void OnInitBehaviour()
		{
		}

		// Token: 0x06022CF8 RID: 142584 RVA: 0x009E3DBE File Offset: 0x009E1FBE
		protected virtual void OnHideUiTabViewBase(bool fromToggle)
		{
		}

		// Token: 0x06022CF9 RID: 142585 RVA: 0x009E3DC0 File Offset: 0x009E1FC0
		protected virtual void OnTickUiTabViewBase(float deltaTime)
		{
		}

		// Token: 0x06022CFA RID: 142586 RVA: 0x009E3DC2 File Offset: 0x009E1FC2
		protected virtual void OnShowUiTabViewFromToggle()
		{
		}

		// Token: 0x06022CFB RID: 142587 RVA: 0x009E3DC4 File Offset: 0x009E1FC4
		protected virtual void OnShowUiTabViewFromView()
		{
		}

		// Token: 0x06022CFC RID: 142588 RVA: 0x009E3DC6 File Offset: 0x009E1FC6
		public void ShowUiTabViewFromToggle()
		{
			base.Show(null);
			this.OnShowUiTabViewFromToggle();
			this.ShowBehaviorFromToggle();
			this.IsFirstShow = false;
		}

		// Token: 0x06022CFD RID: 142589 RVA: 0x009E3DE2 File Offset: 0x009E1FE2
		public void ShowUiTabViewFromView()
		{
			base.Show(null);
			this.OnShowUiTabViewFromView();
			this.ShowBehaviorFromView();
			this.IsFirstShow = false;
		}

		// Token: 0x06022CFE RID: 142590 RVA: 0x009E3DFE File Offset: 0x009E1FFE
		public void HideUiTabView(bool fromToggle)
		{
			base.Hide(null);
			this.OnHideUiTabViewBase(fromToggle);
			this.HideBehavior();
		}

		// Token: 0x06022CFF RID: 142591 RVA: 0x009E3E14 File Offset: 0x009E2014
		protected override void OnBeforeDestroyImplement()
		{
			this.DestroyBehavior();
		}

		// Token: 0x06022D00 RID: 142592 RVA: 0x009E3E1C File Offset: 0x009E201C
		public void SetParams(object param)
		{
			this.Params = param;
		}

		// Token: 0x06022D01 RID: 142593 RVA: 0x009E3E25 File Offset: 0x009E2025
		public void SetExtraParams(object extraParams)
		{
			this.ExtraParams = extraParams;
		}

		// Token: 0x06022D02 RID: 142594 RVA: 0x009E3E30 File Offset: 0x009E2030
		public string GetViewName()
		{
			EUiTabViewName? tabViewName = this.TabViewName;
			if (tabViewName == null)
			{
				return null;
			}
			return tabViewName.GetValueOrDefault();
		}

		// Token: 0x06022D03 RID: 142595 RVA: 0x009E3E5B File Offset: 0x009E205B
		public void CancelAsyncLoad()
		{
			base.ClearUiPrefabLoadModule();
		}

		// Token: 0x040133ED RID: 78829
		private int TickId = -1;

		// Token: 0x040133EE RID: 78830
		protected bool IsFirstShow = true;

		// Token: 0x040133EF RID: 78831
		[Nullable(2)]
		protected object Params;

		// Token: 0x040133F0 RID: 78832
		private readonly Dictionary<Type, UiTabViewBehavior> TabBehaviorMap = new Dictionary<Type, UiTabViewBehavior>();

		// Token: 0x040133F1 RID: 78833
		protected List<TOperation> OperationList = new List<TOperation>();

		// Token: 0x040133F2 RID: 78834
		[Nullable(2)]
		protected object ExtraParams;

		// Token: 0x040133F3 RID: 78835
		[Nullable(2)]
		public UiBehaviorLevelSequence UiViewSequence;

		// Token: 0x040133F4 RID: 78836
		private EUiTabViewName? TabViewName;
	}
}
