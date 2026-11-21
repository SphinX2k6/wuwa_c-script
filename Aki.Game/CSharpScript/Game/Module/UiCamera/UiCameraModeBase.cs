using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x0200399B RID: 14747
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class UiCameraModeBase
	{
		// Token: 0x17004D86 RID: 19846
		// (get) Token: 0x06025FB2 RID: 155570 RVA: 0x00AA8E5C File Offset: 0x00AA705C
		// (set) Token: 0x06025FB3 RID: 155571 RVA: 0x00AA8E64 File Offset: 0x00AA7064
		private protected UiCamera Owner { protected get; private set; }

		// Token: 0x17004D87 RID: 19847
		// (get) Token: 0x06025FB4 RID: 155572 RVA: 0x00AA8E6D File Offset: 0x00AA706D
		// (set) Token: 0x06025FB5 RID: 155573 RVA: 0x00AA8E75 File Offset: 0x00AA7075
		public bool IsEntered { get; private set; }

		// Token: 0x06025FB6 RID: 155574 RVA: 0x00AA8E7E File Offset: 0x00AA707E
		internal void Initialize(UiCamera owner)
		{
			this.Owner = owner;
			this.RegisterComponents();
			this.OnInitialize();
		}

		// Token: 0x06025FB7 RID: 155575 RVA: 0x00AA8E94 File Offset: 0x00AA7094
		public void Enter()
		{
			if (this.IsEntered)
			{
				return;
			}
			this.IsEntered = true;
			foreach (UiCameraComponent uiCameraComponent in this.ComponentOrder)
			{
				uiCameraComponent.EnterMode();
			}
			this.OnEnter();
		}

		// Token: 0x06025FB8 RID: 155576 RVA: 0x00AA8EFC File Offset: 0x00AA70FC
		public void Exit()
		{
			if (!this.IsEntered)
			{
				return;
			}
			this.OnExit();
			for (int i = this.ComponentOrder.Count - 1; i >= 0; i--)
			{
				this.ComponentOrder[i].ExitMode();
			}
			this.IsEntered = false;
		}

		// Token: 0x06025FB9 RID: 155577 RVA: 0x00AA8F48 File Offset: 0x00AA7148
		public void Tick(float deltaTime)
		{
			this.OnTick(deltaTime);
			foreach (UiCameraComponent uiCameraComponent in this.ComponentOrder)
			{
				uiCameraComponent.Tick(deltaTime);
			}
		}

		// Token: 0x06025FBA RID: 155578 RVA: 0x00AA8FA0 File Offset: 0x00AA71A0
		public void Apply(UiCameraHandleData data)
		{
			this.LastAppliedData = data;
			this.OnApply(data);
			foreach (UiCameraComponent uiCameraComponent in this.ComponentOrder)
			{
				uiCameraComponent.Apply(data);
			}
		}

		// Token: 0x06025FBB RID: 155579 RVA: 0x00AA9000 File Offset: 0x00AA7200
		public T GetComponent<[Nullable(0)] T>() where T : UiCameraComponent
		{
			UiCameraComponent uiCameraComponent;
			if (this.Components.TryGetValue(typeof(T), out uiCameraComponent))
			{
				return (T)((object)uiCameraComponent);
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(42, 2);
			defaultInterpolatedStringHandler.AppendLiteral("UiCamera component ");
			defaultInterpolatedStringHandler.AppendFormatted(typeof(T).Name);
			defaultInterpolatedStringHandler.AppendLiteral(" is not registered in ");
			defaultInterpolatedStringHandler.AppendFormatted(base.GetType().Name);
			defaultInterpolatedStringHandler.AppendLiteral(".");
			throw new InvalidOperationException(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x06025FBC RID: 155580 RVA: 0x00AA9090 File Offset: 0x00AA7290
		[NullableContext(0)]
		[return: Nullable(2)]
		public T TryGetComponent<T>() where T : UiCameraComponent
		{
			UiCameraComponent uiCameraComponent;
			if (!this.Components.TryGetValue(typeof(T), out uiCameraComponent))
			{
				return default(T);
			}
			return uiCameraComponent as T;
		}

		// Token: 0x06025FBD RID: 155581 RVA: 0x00AA90CB File Offset: 0x00AA72CB
		[NullableContext(2)]
		public UiCameraHandleData TryGetLastAppliedData()
		{
			return this.LastAppliedData;
		}

		// Token: 0x06025FBE RID: 155582 RVA: 0x00AA90D4 File Offset: 0x00AA72D4
		public void Clear()
		{
			this.Exit();
			foreach (UiCameraComponent uiCameraComponent in this.ComponentOrder)
			{
				uiCameraComponent.Clear();
			}
			this.Components.Clear();
			this.ComponentOrder.Clear();
			this.LastAppliedData = null;
			this.OnClear();
		}

		// Token: 0x06025FBF RID: 155583 RVA: 0x00AA9150 File Offset: 0x00AA7350
		protected void RegisterComponent(UiCameraComponent component)
		{
			component.Initialize(this.Owner, this);
			this.Components.Add(component.GetType(), component);
			this.ComponentOrder.Add(component);
		}

		// Token: 0x06025FC0 RID: 155584
		protected abstract void RegisterComponents();

		// Token: 0x06025FC1 RID: 155585 RVA: 0x00AA917D File Offset: 0x00AA737D
		protected virtual void OnInitialize()
		{
		}

		// Token: 0x06025FC2 RID: 155586 RVA: 0x00AA917F File Offset: 0x00AA737F
		protected virtual void OnEnter()
		{
		}

		// Token: 0x06025FC3 RID: 155587 RVA: 0x00AA9181 File Offset: 0x00AA7381
		protected virtual void OnExit()
		{
		}

		// Token: 0x06025FC4 RID: 155588 RVA: 0x00AA9183 File Offset: 0x00AA7383
		protected virtual void OnTick(float deltaTime)
		{
		}

		// Token: 0x06025FC5 RID: 155589 RVA: 0x00AA9185 File Offset: 0x00AA7385
		protected virtual void OnApply(UiCameraHandleData data)
		{
		}

		// Token: 0x06025FC6 RID: 155590 RVA: 0x00AA9187 File Offset: 0x00AA7387
		protected virtual void OnClear()
		{
		}

		// Token: 0x04014E1F RID: 85535
		private readonly Dictionary<Type, UiCameraComponent> Components = new Dictionary<Type, UiCameraComponent>();

		// Token: 0x04014E20 RID: 85536
		private readonly List<UiCameraComponent> ComponentOrder = new List<UiCameraComponent>();

		// Token: 0x04014E21 RID: 85537
		[Nullable(2)]
		private UiCameraHandleData LastAppliedData;
	}
}
