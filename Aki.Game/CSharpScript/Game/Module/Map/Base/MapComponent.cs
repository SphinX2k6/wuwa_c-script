using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Misc;

namespace CSharpScript.Game.Module.Map.Base
{
	// Token: 0x02005596 RID: 21910
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class MapComponent : IStaticVariableResetter
	{
		// Token: 0x17008673 RID: 34419
		// (get) Token: 0x06037D7C RID: 228732 RVA: 0x00D3C5B8 File Offset: 0x00D3A7B8
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

		// Token: 0x06037D7D RID: 228733 RVA: 0x00D3C5DD File Offset: 0x00D3A7DD
		static MapComponent()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MapComponent.CreateStaticDefaultValue), new Action(MapComponent.ResetStaticDefaultValue));
		}

		// Token: 0x06037D7E RID: 228734 RVA: 0x00D3C5FC File Offset: 0x00D3A7FC
		public static int GenComponentId()
		{
			MapComponent.IncId++;
			return MapComponent.IncId;
		}

		// Token: 0x17008674 RID: 34420
		// (get) Token: 0x06037D7F RID: 228735 RVA: 0x00D3C60F File Offset: 0x00D3A80F
		// (set) Token: 0x06037D80 RID: 228736 RVA: 0x00D3C62A File Offset: 0x00D3A82A
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

		// Token: 0x17008675 RID: 34421
		// (get) Token: 0x06037D81 RID: 228737 RVA: 0x00D3C633 File Offset: 0x00D3A833
		// (set) Token: 0x06037D82 RID: 228738 RVA: 0x00D3C63B File Offset: 0x00D3A83B
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

		// Token: 0x06037D83 RID: 228739 RVA: 0x00D3C644 File Offset: 0x00D3A844
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

		// Token: 0x17008676 RID: 34422
		// (get) Token: 0x06037D84 RID: 228740 RVA: 0x00D3C654 File Offset: 0x00D3A854
		public MapEntity ParentEntity
		{
			get
			{
				return this.Parent.AsT3;
			}
		}

		// Token: 0x17008677 RID: 34423
		// (get) Token: 0x06037D85 RID: 228741 RVA: 0x00D3C66F File Offset: 0x00D3A86F
		// (set) Token: 0x06037D86 RID: 228742 RVA: 0x00D3C680 File Offset: 0x00D3A880
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

		// Token: 0x17008678 RID: 34424
		// (get) Token: 0x06037D87 RID: 228743 RVA: 0x00D3C6CC File Offset: 0x00D3A8CC
		// (set) Token: 0x06037D88 RID: 228744 RVA: 0x00D3C6DA File Offset: 0x00D3A8DA
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

		// Token: 0x17008679 RID: 34425
		// (get) Token: 0x06037D89 RID: 228745 RVA: 0x00D3C6E8 File Offset: 0x00D3A8E8
		// (set) Token: 0x06037D8A RID: 228746 RVA: 0x00D3C6F6 File Offset: 0x00D3A8F6
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

		// Token: 0x06037D8B RID: 228747 RVA: 0x00D3C704 File Offset: 0x00D3A904
		public void Remove()
		{
			this.OnRemove();
		}

		// Token: 0x06037D8C RID: 228748 RVA: 0x00D3C70C File Offset: 0x00D3A90C
		protected virtual void OnRemove()
		{
		}

		// Token: 0x06037D8D RID: 228749 RVA: 0x00D3C70E File Offset: 0x00D3A90E
		public void Add()
		{
			this.OnAdd();
		}

		// Token: 0x06037D8E RID: 228750 RVA: 0x00D3C716 File Offset: 0x00D3A916
		protected virtual void OnAdd()
		{
		}

		// Token: 0x06037D8F RID: 228751 RVA: 0x00D3C718 File Offset: 0x00D3A918
		protected virtual void OnEnable()
		{
		}

		// Token: 0x06037D90 RID: 228752 RVA: 0x00D3C71A File Offset: 0x00D3A91A
		protected virtual void OnStart()
		{
		}

		// Token: 0x06037D91 RID: 228753 RVA: 0x00D3C71C File Offset: 0x00D3A91C
		protected virtual void OnDisable()
		{
		}

		// Token: 0x1700867A RID: 34426
		// (get) Token: 0x06037D92 RID: 228754
		public abstract EMapComponent ComponentType { get; }

		// Token: 0x06037D93 RID: 228755 RVA: 0x00D3C71E File Offset: 0x00D3A91E
		public void Init()
		{
			this.OnInit();
		}

		// Token: 0x06037D94 RID: 228756 RVA: 0x00D3C726 File Offset: 0x00D3A926
		protected virtual void OnInit()
		{
		}

		// Token: 0x06037D95 RID: 228757 RVA: 0x00D3C728 File Offset: 0x00D3A928
		public void Tick(float delta)
		{
			if (this.Enable && this.EnableTick)
			{
				this.OnTick(delta);
			}
		}

		// Token: 0x06037D96 RID: 228758 RVA: 0x00D3C741 File Offset: 0x00D3A941
		protected virtual void OnTick(float delta)
		{
		}

		// Token: 0x06037D97 RID: 228759 RVA: 0x00D3C743 File Offset: 0x00D3A943
		public void Update()
		{
			if (this.Enable)
			{
				this.OnUpdate();
			}
		}

		// Token: 0x06037D98 RID: 228760 RVA: 0x00D3C753 File Offset: 0x00D3A953
		protected virtual void OnUpdate()
		{
		}

		// Token: 0x06037D99 RID: 228761 RVA: 0x00D3C755 File Offset: 0x00D3A955
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

		// Token: 0x06037D9A RID: 228762 RVA: 0x00D3C75F File Offset: 0x00D3A95F
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

		// Token: 0x06037D9B RID: 228763 RVA: 0x00D3C769 File Offset: 0x00D3A969
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

		// Token: 0x06037D9C RID: 228764 RVA: 0x00D3C773 File Offset: 0x00D3A973
		public static void CreateStaticDefaultValue()
		{
			MapComponent.IncId = 0;
		}

		// Token: 0x06037D9D RID: 228765 RVA: 0x00D3C77B File Offset: 0x00D3A97B
		public static void ResetStaticDefaultValue()
		{
			MapComponent.IncId = 0;
		}

		// Token: 0x0401D574 RID: 120180
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

		// Token: 0x0401D575 RID: 120181
		private MapComponent.BooleanState EnableState;

		// Token: 0x0401D576 RID: 120182
		private MapComponent.BooleanState FirstEnableState;

		// Token: 0x0401D577 RID: 120183
		private MapComponent.BooleanState EnableTickState;

		// Token: 0x0401D578 RID: 120184
		private static int IncId;

		// Token: 0x0401D579 RID: 120185
		private int ComponentIdInternal;

		// Token: 0x0200B788 RID: 46984
		[NullableContext(0)]
		private struct BooleanState
		{
			// Token: 0x1700A1B7 RID: 41399
			// (get) Token: 0x0604F209 RID: 324105 RVA: 0x0152632F File Offset: 0x0152452F
			// (set) Token: 0x0604F20A RID: 324106 RVA: 0x01526337 File Offset: 0x01524537
			public bool IsDirty { readonly get; private set; }

			// Token: 0x0604F20B RID: 324107 RVA: 0x01526340 File Offset: 0x01524540
			public bool Get(bool defaultValue)
			{
				if (!this.HasValue)
				{
					return defaultValue;
				}
				this.IsDirty = false;
				return this.Value;
			}

			// Token: 0x0604F20C RID: 324108 RVA: 0x01526359 File Offset: 0x01524559
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

			// Token: 0x040378DF RID: 227551
			private bool HasValue;

			// Token: 0x040378E0 RID: 227552
			private bool Value;
		}
	}
}
