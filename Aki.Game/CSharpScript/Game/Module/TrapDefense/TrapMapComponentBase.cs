using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A36 RID: 18998
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class TrapMapComponentBase
	{
		// Token: 0x06031530 RID: 202032 RVA: 0x00B71204 File Offset: 0x00B6F404
		public TrapMapComponentBase(TrapMapEntity parent)
		{
			this.Parent = parent;
		}

		// Token: 0x17007A34 RID: 31284
		// (get) Token: 0x06031531 RID: 202033 RVA: 0x00B71213 File Offset: 0x00B6F413
		public TrapMapEntity Parent { get; }

		// Token: 0x06031532 RID: 202034 RVA: 0x00B7121B File Offset: 0x00B6F41B
		public static int GenComponentId()
		{
			TrapMapComponentBase.IncId++;
			return TrapMapComponentBase.IncId;
		}

		// Token: 0x17007A35 RID: 31285
		// (get) Token: 0x06031533 RID: 202035 RVA: 0x00B7122E File Offset: 0x00B6F42E
		// (set) Token: 0x06031534 RID: 202036 RVA: 0x00B71249 File Offset: 0x00B6F449
		public int ComponentId
		{
			get
			{
				if (this.ComponentIdInternal == 0)
				{
					this.ComponentIdInternal = TrapMapComponentBase.GenComponentId();
				}
				return this.ComponentIdInternal;
			}
			set
			{
				this.ComponentIdInternal = value;
			}
		}

		// Token: 0x17007A36 RID: 31286
		// (get) Token: 0x06031535 RID: 202037 RVA: 0x00B71252 File Offset: 0x00B6F452
		// (set) Token: 0x06031536 RID: 202038 RVA: 0x00B7125A File Offset: 0x00B6F45A
		public bool Enable
		{
			get
			{
				return this.EnableInner;
			}
			set
			{
				this.EnableInner = value;
				if (value)
				{
					if (this.FirstEnable)
					{
						this.FirstEnable = false;
						this.OnStart();
					}
					this.OnEnable();
					return;
				}
				this.OnDisable();
			}
		}

		// Token: 0x17007A37 RID: 31287
		// (get) Token: 0x06031537 RID: 202039 RVA: 0x00B71288 File Offset: 0x00B6F488
		// (set) Token: 0x06031538 RID: 202040 RVA: 0x00B71290 File Offset: 0x00B6F490
		public bool EnableTick
		{
			get
			{
				return this.EnableTickInner;
			}
			set
			{
				this.EnableTickInner = value;
			}
		}

		// Token: 0x06031539 RID: 202041 RVA: 0x00B71299 File Offset: 0x00B6F499
		public void Init()
		{
			this.FirstEnable = true;
			this.OnInit();
		}

		// Token: 0x0603153A RID: 202042 RVA: 0x00B712A8 File Offset: 0x00B6F4A8
		public void Add()
		{
			this.OnAdd();
		}

		// Token: 0x0603153B RID: 202043 RVA: 0x00B712B0 File Offset: 0x00B6F4B0
		public void Remove()
		{
			this.OnRemove();
		}

		// Token: 0x17007A38 RID: 31288
		// (get) Token: 0x0603153C RID: 202044
		public abstract ETrapDefenseMapComponent ComponentType { get; }

		// Token: 0x0603153D RID: 202045 RVA: 0x00B712B8 File Offset: 0x00B6F4B8
		public void Tick(float delta)
		{
			if (this.Enable && this.EnableTick)
			{
				this.OnTick(delta);
			}
		}

		// Token: 0x0603153E RID: 202046 RVA: 0x00B712D1 File Offset: 0x00B6F4D1
		protected virtual void OnAdd()
		{
		}

		// Token: 0x0603153F RID: 202047 RVA: 0x00B712D3 File Offset: 0x00B6F4D3
		protected virtual void OnStart()
		{
		}

		// Token: 0x06031540 RID: 202048 RVA: 0x00B712D5 File Offset: 0x00B6F4D5
		protected virtual void OnEnable()
		{
		}

		// Token: 0x06031541 RID: 202049 RVA: 0x00B712D7 File Offset: 0x00B6F4D7
		protected virtual void OnTick(float delta)
		{
		}

		// Token: 0x06031542 RID: 202050 RVA: 0x00B712D9 File Offset: 0x00B6F4D9
		protected virtual void OnDisable()
		{
		}

		// Token: 0x06031543 RID: 202051 RVA: 0x00B712DB File Offset: 0x00B6F4DB
		protected virtual void OnRemove()
		{
		}

		// Token: 0x06031544 RID: 202052 RVA: 0x00B712DD File Offset: 0x00B6F4DD
		protected virtual void OnInit()
		{
		}

		// Token: 0x0401A5C2 RID: 107970
		[StaticVariableRuleIgnore]
		private static int IncId;

		// Token: 0x0401A5C3 RID: 107971
		private bool EnableInner;

		// Token: 0x0401A5C4 RID: 107972
		private bool FirstEnable;

		// Token: 0x0401A5C5 RID: 107973
		private bool EnableTickInner;

		// Token: 0x0401A5C7 RID: 107975
		private int ComponentIdInternal;
	}
}
