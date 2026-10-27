using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000279 RID: 633
	[NullableContext(1)]
	[Nullable(0)]
	public class IConnectorPathAdvanceVasePlantVisual : IConnectorPathAdvanceVisual
	{
		// Token: 0x06000B9B RID: 2971 RVA: 0x0002E448 File Offset: 0x0002C648
		private IConnectorPathAdvanceVasePlantVisual_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IConnectorPathAdvanceVasePlantVisual 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IConnectorPathAdvanceVasePlantVisual_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IConnectorPathAdvanceVasePlantVisual_SetValue());
			}
			return result;
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x0002E480 File Offset: 0x0002C680
		public static IConnectorPathAdvanceVasePlantVisual Create([Nullable(2)] IConnectorPathAdvanceVasePlantVisual instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IConnectorPathAdvanceVasePlantVisual
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x0002E493 File Offset: 0x0002C693
		public static IConnectorPathAdvanceVasePlantVisual CreateFromSetValue([Nullable(2)] IConnectorPathAdvanceVasePlantVisual_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IConnectorPathAdvanceVasePlantVisual
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x0002E4A8 File Offset: 0x0002C6A8
		public new IConnectorPathAdvanceVasePlantVisual_SetValue ToSetValue()
		{
			return new IConnectorPathAdvanceVasePlantVisual_SetValue
			{
				Type = this.Type,
				ScatterWidth = this.ScatterWidth,
				ScatterDensity = this.ScatterDensity,
				Scale = this.Scale,
				SnapToSurface = this.SnapToSurface,
				PathRtList = this.PathRtList
			};
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000B9F RID: 2975 RVA: 0x0002E502 File Offset: 0x0002C702
		// (set) Token: 0x06000BA0 RID: 2976 RVA: 0x0002E52D File Offset: 0x0002C72D
		public override EConnectorPathAdvanceVisualType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EConnectorPathAdvanceVisualType.VasePlant;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000BA1 RID: 2977 RVA: 0x0002E53C File Offset: 0x0002C73C
		// (set) Token: 0x06000BA2 RID: 2978 RVA: 0x0002E576 File Offset: 0x0002C776
		public virtual float? ScatterWidth
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ScatterWidth;
				}
				IConnectorPathAdvanceVasePlantVisual_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ScatterWidth;
			}
			set
			{
				this.GetOrCreatePoco().ScatterWidth = value;
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000BA3 RID: 2979 RVA: 0x0002E584 File Offset: 0x0002C784
		// (set) Token: 0x06000BA4 RID: 2980 RVA: 0x0002E5BE File Offset: 0x0002C7BE
		public virtual float? ScatterDensity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ScatterDensity;
				}
				IConnectorPathAdvanceVasePlantVisual_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ScatterDensity;
			}
			set
			{
				this.GetOrCreatePoco().ScatterDensity = value;
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000BA5 RID: 2981 RVA: 0x0002E5CC File Offset: 0x0002C7CC
		// (set) Token: 0x06000BA6 RID: 2982 RVA: 0x0002E606 File Offset: 0x0002C806
		public virtual float? Scale
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Scale;
				}
				IConnectorPathAdvanceVasePlantVisual_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Scale;
			}
			set
			{
				this.GetOrCreatePoco().Scale = value;
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000BA7 RID: 2983 RVA: 0x0002E614 File Offset: 0x0002C814
		// (set) Token: 0x06000BA8 RID: 2984 RVA: 0x0002E64E File Offset: 0x0002C84E
		public virtual bool? SnapToSurface
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SnapToSurface;
				}
				IConnectorPathAdvanceVasePlantVisual_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SnapToSurface;
			}
			set
			{
				this.GetOrCreatePoco().SnapToSurface = value;
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000BA9 RID: 2985 RVA: 0x0002E65C File Offset: 0x0002C85C
		// (set) Token: 0x06000BAA RID: 2986 RVA: 0x0002E683 File Offset: 0x0002C883
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<string> PathRtList
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PathRtList;
				}
				IConnectorPathAdvanceVasePlantVisual_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PathRtList;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().PathRtList = value;
			}
		}

		// Token: 0x04000B28 RID: 2856
		[Nullable(2)]
		protected new IConnectorPathAdvanceVasePlantVisual FbInstance;

		// Token: 0x04000B29 RID: 2857
		[Nullable(2)]
		protected new IConnectorPathAdvanceVasePlantVisual_SetValue PocoInterface;
	}
}
