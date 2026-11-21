using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Misc;

namespace CSharpScript.Game.Module.Map.Base
{
	// Token: 0x0200456C RID: 17772
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class MapComponent : IStaticVariableResetter
	{
		// Token: 0x17005A3A RID: 23098
		// (get) Token: 0x0602CC7A RID: 183418 RVA: 0x00C8A300 File Offset: 0x00C88500
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			0,
			1,
			1
		})]
		protected PropertyMap<OneOf<int, string>, OneOf<Vector2D, bool, int, string, float>> PropertyMap
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1,
				0,
				1,
				1
			})]
			get
			{
				PropertyMap<OneOf<int, string>, OneOf<Vector2D, bool, int, string, float>> result;
				if ((result = this.PropertyMapInternal) == null)
				{
					result = (this.PropertyMapInternal = new PropertyMap<OneOf<int, string>, OneOf<Vector2D, bool, int, string, float>>());
				}
				return result;
			}
		}

		// Token: 0x0602CC7B RID: 183419 RVA: 0x00C8A325 File Offset: 0x00C88525
		static MapComponent()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MapComponent.CreateStaticDefaultValue), new Action(MapComponent.ResetStaticDefaultValue));
		}

		// Token: 0x0602CC7C RID: 183420 RVA: 0x00C8A344 File Offset: 0x00C88544
		public static int GenComponentId()
		{
			MapComponent.IncId++;
			return MapComponent.IncId;
		}

		// Token: 0x17005A3B RID: 23099
		// (get) Token: 0x0602CC7D RID: 183421 RVA: 0x00C8A357 File Offset: 0x00C88557
		// (set) Token: 0x0602CC7E RID: 183422 RVA: 0x00C8A372 File Offset: 0x00C88572
		public int ComponentId
		{
			get
			{
				if (this.ComponentIdInternal == 0)
				{
					this.ComponentIdInternal = MapComponent.GenComponentId();
				}
				return this.ComponentIdInternal;
			}
			set
			{
				this.ComponentIdInternal = value;
			}
		}

		// Token: 0x17005A3C RID: 23100
		// (get) Token: 0x0602CC7F RID: 183423 RVA: 0x00C8A37B File Offset: 0x00C8857B
		// (set) Token: 0x0602CC80 RID: 183424 RVA: 0x00C8A383 File Offset: 0x00C88583
		[Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})]
		public OneOf<MapComponent, MapComponentContainer, MapEntity> Parent { [return: Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] get; [param: Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] set; }

		// Token: 0x0602CC81 RID: 183425 RVA: 0x00C8A38C File Offset: 0x00C8858C
		public MapComponent([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<MapComponent, MapComponentContainer, MapEntity> parent)
		{
			this.Parent = parent;
		}

		// Token: 0x17005A3D RID: 23101
		// (get) Token: 0x0602CC82 RID: 183426 RVA: 0x00C8A39C File Offset: 0x00C8859C
		public MapEntity ParentEntity
		{
			get
			{
				return this.Parent.AsT3;
			}
		}

		// Token: 0x17005A3E RID: 23102
		// (get) Token: 0x0602CC83 RID: 183427 RVA: 0x00C8A3B7 File Offset: 0x00C885B7
		// (set) Token: 0x0602CC84 RID: 183428 RVA: 0x00C8A3C8 File Offset: 0x00C885C8
		public bool Enable
		{
			get
			{
				return this.EnableState.Get(false);
			}
			set
			{
				this.EnableState.Set(value);
				if (!this.EnableState.IsDirty)
				{
					return;
				}
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

		// Token: 0x17005A3F RID: 23103
		// (get) Token: 0x0602CC85 RID: 183429 RVA: 0x00C8A414 File Offset: 0x00C88614
		// (set) Token: 0x0602CC86 RID: 183430 RVA: 0x00C8A422 File Offset: 0x00C88622
		private bool FirstEnable
		{
			get
			{
				return this.FirstEnableState.Get(true);
			}
			set
			{
				this.FirstEnableState.Set(value);
			}
		}

		// Token: 0x17005A40 RID: 23104
		// (get) Token: 0x0602CC87 RID: 183431 RVA: 0x00C8A430 File Offset: 0x00C88630
		// (set) Token: 0x0602CC88 RID: 183432 RVA: 0x00C8A43E File Offset: 0x00C8863E
		public bool EnableTick
		{
			get
			{
				return this.EnableTickState.Get(false);
			}
			private set
			{
				this.EnableTickState.Set(value);
			}
		}

		// Token: 0x0602CC89 RID: 183433 RVA: 0x00C8A44C File Offset: 0x00C8864C
		public void Remove()
		{
			this.OnRemove();
		}

		// Token: 0x0602CC8A RID: 183434 RVA: 0x00C8A454 File Offset: 0x00C88654
		protected virtual void OnRemove()
		{
		}

		// Token: 0x0602CC8B RID: 183435 RVA: 0x00C8A456 File Offset: 0x00C88656
		public void Add()
		{
			this.OnAdd();
		}

		// Token: 0x0602CC8C RID: 183436 RVA: 0x00C8A45E File Offset: 0x00C8865E
		protected virtual void OnAdd()
		{
		}

		// Token: 0x0602CC8D RID: 183437 RVA: 0x00C8A460 File Offset: 0x00C88660
		protected virtual void OnEnable()
		{
		}

		// Token: 0x0602CC8E RID: 183438 RVA: 0x00C8A462 File Offset: 0x00C88662
		protected virtual void OnStart()
		{
		}

		// Token: 0x0602CC8F RID: 183439 RVA: 0x00C8A464 File Offset: 0x00C88664
		protected virtual void OnDisable()
		{
		}

		// Token: 0x17005A41 RID: 23105
		// (get) Token: 0x0602CC90 RID: 183440
		public abstract EMapComponent ComponentType { get; }

		// Token: 0x0602CC91 RID: 183441 RVA: 0x00C8A466 File Offset: 0x00C88666
		public void Init()
		{
			this.OnInit();
		}

		// Token: 0x0602CC92 RID: 183442 RVA: 0x00C8A46E File Offset: 0x00C8866E
		protected virtual void OnInit()
		{
		}

		// Token: 0x0602CC93 RID: 183443 RVA: 0x00C8A470 File Offset: 0x00C88670
		public void Tick(float delta)
		{
			if (this.Enable && this.EnableTick)
			{
				this.OnTick(delta);
			}
		}

		// Token: 0x0602CC94 RID: 183444 RVA: 0x00C8A489 File Offset: 0x00C88689
		protected virtual void OnTick(float delta)
		{
		}

		// Token: 0x0602CC95 RID: 183445 RVA: 0x00C8A48B File Offset: 0x00C8868B
		public void Update()
		{
			if (this.Enable)
			{
				this.OnUpdate();
			}
		}

		// Token: 0x0602CC96 RID: 183446 RVA: 0x00C8A49B File Offset: 0x00C8869B
		protected virtual void OnUpdate()
		{
		}

		// Token: 0x0602CC97 RID: 183447 RVA: 0x00C8A49D File Offset: 0x00C8869D
		protected void LogInfo(ELogAuthor author, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs)
		{
			MapLogger.Info(author, message, pairs);
		}

		// Token: 0x0602CC98 RID: 183448 RVA: 0x00C8A4A7 File Offset: 0x00C886A7
		protected void LogWarn(ELogAuthor author, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs)
		{
			MapLogger.Warn(author, message, pairs);
		}

		// Token: 0x0602CC99 RID: 183449 RVA: 0x00C8A4B1 File Offset: 0x00C886B1
		protected void LogError(ELogAuthor author, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs)
		{
			MapLogger.Error(author, message, pairs);
		}

		// Token: 0x0602CC9A RID: 183450 RVA: 0x00C8A4BB File Offset: 0x00C886BB
		public static void CreateStaticDefaultValue()
		{
			MapComponent.IncId = 0;
		}

		// Token: 0x0602CC9B RID: 183451 RVA: 0x00C8A4C3 File Offset: 0x00C886C3
		public static void ResetStaticDefaultValue()
		{
			MapComponent.IncId = 0;
		}

		// Token: 0x04017FFF RID: 98303
		[Nullable(new byte[]
		{
			2,
			0,
			1,
			0,
			1,
			1
		})]
		private PropertyMap<OneOf<int, string>, OneOf<Vector2D, bool, int, string, float>> PropertyMapInternal;

		// Token: 0x04018000 RID: 98304
		private MapComponent.BooleanState EnableState;

		// Token: 0x04018001 RID: 98305
		private MapComponent.BooleanState FirstEnableState;

		// Token: 0x04018002 RID: 98306
		private MapComponent.BooleanState EnableTickState;

		// Token: 0x04018003 RID: 98307
		private static int IncId;

		// Token: 0x04018004 RID: 98308
		private int ComponentIdInternal;

		// Token: 0x0200A1B3 RID: 41395
		[NullableContext(0)]
		private struct BooleanState
		{
			// Token: 0x17007954 RID: 31060
			// (get) Token: 0x060457E3 RID: 284643 RVA: 0x014DFD93 File Offset: 0x014DDF93
			// (set) Token: 0x060457E4 RID: 284644 RVA: 0x014DFD9B File Offset: 0x014DDF9B
			public bool IsDirty { readonly get; private set; }

			// Token: 0x060457E5 RID: 284645 RVA: 0x014DFDA4 File Offset: 0x014DDFA4
			public bool Get(bool defaultValue)
			{
				if (!this.HasValue)
				{
					return defaultValue;
				}
				this.IsDirty = false;
				return this.Value;
			}

			// Token: 0x060457E6 RID: 284646 RVA: 0x014DFDBD File Offset: 0x014DDFBD
			public void Set(bool value)
			{
				if (this.HasValue && this.Value == value)
				{
					return;
				}
				this.HasValue = true;
				this.Value = value;
				this.IsDirty = true;
			}

			// Token: 0x04032309 RID: 205577
			private bool HasValue;

			// Token: 0x0403230A RID: 205578
			private bool Value;
		}
	}
}
