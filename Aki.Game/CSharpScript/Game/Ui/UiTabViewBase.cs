using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004638 RID: 17976
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class UiTabViewBase : UiPanelBase
	{
		// Token: 0x0602E59C RID: 189852 RVA: 0x00AB6387 File Offset: 0x00AB4587
		public void SetTabViewName(EUiTabViewName tabViewName)
		{
			this.TabViewName = new EUiTabViewName?(tabViewName);
		}

		// Token: 0x0602E59D RID: 189853 RVA: 0x00AB6395 File Offset: 0x00AB4595
		protected override void OnBeforeShowImplement()
		{
			if (this.TickId == -1)
			{
				this.TickId = TickSystem.Instance.Add(new Action<float>(this.TickHandler), "TabViewTick", ETickingGroup.TG_PrePhysics, true, 0, false).Id;
			}
			this.AddEventListener();
		}

		// Token: 0x0602E59E RID: 189854 RVA: 0x00AB63D0 File Offset: 0x00AB45D0
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

		// Token: 0x0602E59F RID: 189855 RVA: 0x00AB641C File Offset: 0x00AB461C
		protected virtual void AddEventListener()
		{
		}

		// Token: 0x0602E5A0 RID: 189856 RVA: 0x00AB641E File Offset: 0x00AB461E
		protected virtual void RemoveEventListener()
		{
		}

		// Token: 0x0602E5A1 RID: 189857 RVA: 0x00AB6420 File Offset: 0x00AB4620
		protected override void OnBeforeCreateImplement()
		{
			this.UiViewSequence = new UiBehaviorLevelSequence(this);
			base.AddUiBehavior(this.UiViewSequence);
		}

		// Token: 0x0602E5A2 RID: 189858 RVA: 0x00AB643C File Offset: 0x00AB463C
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

		// Token: 0x0602E5A3 RID: 189859 RVA: 0x00AB64AC File Offset: 0x00AB46AC
		private void TickHandler(float deltaTime)
		{
			this.OnTickUiTabViewBase(deltaTime);
		}

		// Token: 0x0602E5A4 RID: 189860 RVA: 0x00AB64B8 File Offset: 0x00AB46B8
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

		// Token: 0x0602E5A5 RID: 189861 RVA: 0x00AB651C File Offset: 0x00AB471C
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

		// Token: 0x0602E5A6 RID: 189862 RVA: 0x00AB6554 File Offset: 0x00AB4754
		protected override void OnAfterShowImplement()
		{
			EventSystem.Instance.Emit<EUiTabViewName?, UiTabViewBase>(EEventName.OpenTabView, this.TabViewName, this);
		}

		// Token: 0x0602E5A7 RID: 189863 RVA: 0x00AB656C File Offset: 0x00AB476C
		private void InitBehavior()
		{
			foreach (UiTabViewBehavior uiTabViewBehavior in this.TabBehaviorMap.Values)
			{
				uiTabViewBehavior.Init();
			}
		}

		// Token: 0x0602E5A8 RID: 189864 RVA: 0x00AB65C4 File Offset: 0x00AB47C4
		private void BeginBehavior()
		{
			foreach (UiTabViewBehavior uiTabViewBehavior in this.TabBehaviorMap.Values)
			{
				uiTabViewBehavior.Begin();
			}
		}

		// Token: 0x0602E5A9 RID: 189865 RVA: 0x00AB661C File Offset: 0x00AB481C
		private void ShowBehaviorFromView()
		{
			foreach (UiTabViewBehavior uiTabViewBehavior in this.TabBehaviorMap.Values)
			{
				uiTabViewBehavior.ShowFromView();
			}
		}

		// Token: 0x0602E5AA RID: 189866 RVA: 0x00AB6674 File Offset: 0x00AB4874
		private void ShowBehaviorFromToggle()
		{
			foreach (UiTabViewBehavior uiTabViewBehavior in this.TabBehaviorMap.Values)
			{
				uiTabViewBehavior.ShowFromToggle();
			}
		}

		// Token: 0x0602E5AB RID: 189867 RVA: 0x00AB66CC File Offset: 0x00AB48CC
		private void HideBehavior()
		{
			foreach (UiTabViewBehavior uiTabViewBehavior in this.TabBehaviorMap.Values)
			{
				uiTabViewBehavior.Hide();
			}
		}

		// Token: 0x0602E5AC RID: 189868 RVA: 0x00AB6724 File Offset: 0x00AB4924
		private void DestroyBehavior()
		{
			foreach (UiTabViewBehavior uiTabViewBehavior in this.TabBehaviorMap.Values)
			{
				uiTabViewBehavior.Destroy();
			}
		}

		// Token: 0x0602E5AD RID: 189869 RVA: 0x00AB677C File Offset: 0x00AB497C
		protected virtual void OnInitBehaviour()
		{
		}

		// Token: 0x0602E5AE RID: 189870 RVA: 0x00AB677E File Offset: 0x00AB497E
		protected virtual void OnHideUiTabViewBase(bool fromToggle)
		{
		}

		// Token: 0x0602E5AF RID: 189871 RVA: 0x00AB6780 File Offset: 0x00AB4980
		protected virtual void OnTickUiTabViewBase(float deltaTime)
		{
		}

		// Token: 0x0602E5B0 RID: 189872 RVA: 0x00AB6782 File Offset: 0x00AB4982
		protected virtual void OnShowUiTabViewFromToggle()
		{
		}

		// Token: 0x0602E5B1 RID: 189873 RVA: 0x00AB6784 File Offset: 0x00AB4984
		protected virtual void OnShowUiTabViewFromView()
		{
		}

		// Token: 0x0602E5B2 RID: 189874 RVA: 0x00AB6786 File Offset: 0x00AB4986
		public void ShowUiTabViewFromToggle()
		{
			base.Show(null);
			this.OnShowUiTabViewFromToggle();
			this.ShowBehaviorFromToggle();
			this.IsFirstShow = false;
		}

		// Token: 0x0602E5B3 RID: 189875 RVA: 0x00AB67A2 File Offset: 0x00AB49A2
		public void ShowUiTabViewFromView()
		{
			base.Show(null);
			this.OnShowUiTabViewFromView();
			this.ShowBehaviorFromView();
			this.IsFirstShow = false;
		}

		// Token: 0x0602E5B4 RID: 189876 RVA: 0x00AB67BE File Offset: 0x00AB49BE
		public void HideUiTabView(bool fromToggle)
		{
			base.Hide(null);
			this.OnHideUiTabViewBase(fromToggle);
			this.HideBehavior();
		}

		// Token: 0x0602E5B5 RID: 189877 RVA: 0x00AB67D4 File Offset: 0x00AB49D4
		protected override void OnBeforeDestroyImplement()
		{
			this.DestroyBehavior();
		}

		// Token: 0x0602E5B6 RID: 189878 RVA: 0x00AB67DC File Offset: 0x00AB49DC
		public void SetParams(object param)
		{
			this.Params = param;
		}

		// Token: 0x0602E5B7 RID: 189879 RVA: 0x00AB67E5 File Offset: 0x00AB49E5
		public void SetExtraParams(object extraParams)
		{
			this.ExtraParams = extraParams;
		}

		// Token: 0x0602E5B8 RID: 189880 RVA: 0x00AB67F0 File Offset: 0x00AB49F0
		public string GetViewName()
		{
			EUiTabViewName? tabViewName = this.TabViewName;
			if (tabViewName == null)
			{
				return null;
			}
			return tabViewName.GetValueOrDefault();
		}

		// Token: 0x0602E5B9 RID: 189881 RVA: 0x00AB681B File Offset: 0x00AB4A1B
		public void CancelAsyncLoad()
		{
			base.ClearUiPrefabLoadModule();
		}

		// Token: 0x04018D94 RID: 101780
		private int TickId = -1;

		// Token: 0x04018D95 RID: 101781
		protected bool IsFirstShow = true;

		// Token: 0x04018D96 RID: 101782
		[Nullable(2)]
		protected object Params;

		// Token: 0x04018D97 RID: 101783
		private readonly Dictionary<Type, UiTabViewBehavior> TabBehaviorMap = new Dictionary<Type, UiTabViewBehavior>();

		// Token: 0x04018D98 RID: 101784
		protected List<TOperation> OperationList = new List<TOperation>();

		// Token: 0x04018D99 RID: 101785
		[Nullable(2)]
		protected object ExtraParams;

		// Token: 0x04018D9A RID: 101786
		[Nullable(2)]
		public UiBehaviorLevelSequence UiViewSequence;

		// Token: 0x04018D9B RID: 101787
		private EUiTabViewName? TabViewName;
	}
}
