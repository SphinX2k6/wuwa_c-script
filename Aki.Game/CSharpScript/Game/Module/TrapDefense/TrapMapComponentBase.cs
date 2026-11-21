using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039DE RID: 14814
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class TrapMapComponentBase
	{
		// Token: 0x060262C0 RID: 156352 RVA: 0x00AB5178 File Offset: 0x00AB3378
		public TrapMapComponentBase(TrapMapEntity parent)
		{
			this.Parent = parent;
		}

		// Token: 0x17004DE1 RID: 19937
		// (get) Token: 0x060262C1 RID: 156353 RVA: 0x00AB5187 File Offset: 0x00AB3387
		public TrapMapEntity Parent { get; }

		// Token: 0x060262C2 RID: 156354 RVA: 0x00AB518F File Offset: 0x00AB338F
		public static int GenComponentId()
		{
			TrapMapComponentBase.IncId++;
			return TrapMapComponentBase.IncId;
		}

		// Token: 0x17004DE2 RID: 19938
		// (get) Token: 0x060262C3 RID: 156355 RVA: 0x00AB51A2 File Offset: 0x00AB33A2
		// (set) Token: 0x060262C4 RID: 156356 RVA: 0x00AB51BD File Offset: 0x00AB33BD
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

		// Token: 0x17004DE3 RID: 19939
		// (get) Token: 0x060262C5 RID: 156357 RVA: 0x00AB51C6 File Offset: 0x00AB33C6
		// (set) Token: 0x060262C6 RID: 156358 RVA: 0x00AB51CE File Offset: 0x00AB33CE
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

		// Token: 0x17004DE4 RID: 19940
		// (get) Token: 0x060262C7 RID: 156359 RVA: 0x00AB51FC File Offset: 0x00AB33FC
		// (set) Token: 0x060262C8 RID: 156360 RVA: 0x00AB5204 File Offset: 0x00AB3404
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

		// Token: 0x060262C9 RID: 156361 RVA: 0x00AB520D File Offset: 0x00AB340D
		public void Init()
		{
			this.FirstEnable = true;
			this.OnInit();
		}

		// Token: 0x060262CA RID: 156362 RVA: 0x00AB521C File Offset: 0x00AB341C
		public void Add()
		{
			this.OnAdd();
		}

		// Token: 0x060262CB RID: 156363 RVA: 0x00AB5224 File Offset: 0x00AB3424
		public void Remove()
		{
			this.OnRemove();
		}

		// Token: 0x17004DE5 RID: 19941
		// (get) Token: 0x060262CC RID: 156364
		public abstract ETrapDefenseMapComponent ComponentType { get; }

		// Token: 0x060262CD RID: 156365 RVA: 0x00AB522C File Offset: 0x00AB342C
		public void Tick(float delta)
		{
			if (this.Enable && this.EnableTick)
			{
				this.OnTick(delta);
			}
		}

		// Token: 0x060262CE RID: 156366 RVA: 0x00AB5245 File Offset: 0x00AB3445
		protected virtual void OnAdd()
		{
		}

		// Token: 0x060262CF RID: 156367 RVA: 0x00AB5247 File Offset: 0x00AB3447
		protected virtual void OnStart()
		{
		}

		// Token: 0x060262D0 RID: 156368 RVA: 0x00AB5249 File Offset: 0x00AB3449
		protected virtual void OnEnable()
		{
		}

		// Token: 0x060262D1 RID: 156369 RVA: 0x00AB524B File Offset: 0x00AB344B
		protected virtual void OnTick(float delta)
		{
		}

		// Token: 0x060262D2 RID: 156370 RVA: 0x00AB524D File Offset: 0x00AB344D
		protected virtual void OnDisable()
		{
		}

		// Token: 0x060262D3 RID: 156371 RVA: 0x00AB524F File Offset: 0x00AB344F
		protected virtual void OnRemove()
		{
		}

		// Token: 0x060262D4 RID: 156372 RVA: 0x00AB5251 File Offset: 0x00AB3451
		protected virtual void OnInit()
		{
		}

		// Token: 0x04014F14 RID: 85780
		[StaticVariableRuleIgnore]
		private static int IncId;

		// Token: 0x04014F15 RID: 85781
		private bool EnableInner;

		// Token: 0x04014F16 RID: 85782
		private bool FirstEnable;

		// Token: 0x04014F17 RID: 85783
		private bool EnableTickInner;

		// Token: 0x04014F19 RID: 85785
		private int ComponentIdInternal;
	}
}
