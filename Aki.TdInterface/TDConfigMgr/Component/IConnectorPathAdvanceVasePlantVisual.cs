using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002BC RID: 700
	public class IConnectorPathAdvanceVasePlantVisual : IConnectorPathAdvanceVisual
	{
		// Token: 0x06000CB5 RID: 3253 RVA: 0x00031138 File Offset: 0x0002F338
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

		// Token: 0x06000CB6 RID: 3254 RVA: 0x00031170 File Offset: 0x0002F370
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

		// Token: 0x06000CB7 RID: 3255 RVA: 0x00031183 File Offset: 0x0002F383
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

		// Token: 0x06000CB8 RID: 3256 RVA: 0x00031198 File Offset: 0x0002F398
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

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x000311F2 File Offset: 0x0002F3F2
		// (set) Token: 0x06000CBA RID: 3258 RVA: 0x0003121D File Offset: 0x0002F41D
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

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000CBB RID: 3259 RVA: 0x0003122C File Offset: 0x0002F42C
		// (set) Token: 0x06000CBC RID: 3260 RVA: 0x00031266 File Offset: 0x0002F466
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

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000CBD RID: 3261 RVA: 0x00031274 File Offset: 0x0002F474
		// (set) Token: 0x06000CBE RID: 3262 RVA: 0x000312AE File Offset: 0x0002F4AE
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

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000CBF RID: 3263 RVA: 0x000312BC File Offset: 0x0002F4BC
		// (set) Token: 0x06000CC0 RID: 3264 RVA: 0x000312F6 File Offset: 0x0002F4F6
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

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000CC1 RID: 3265 RVA: 0x00031304 File Offset: 0x0002F504
		// (set) Token: 0x06000CC2 RID: 3266 RVA: 0x0003133E File Offset: 0x0002F53E
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

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000CC3 RID: 3267 RVA: 0x0003134C File Offset: 0x0002F54C
		// (set) Token: 0x06000CC4 RID: 3268 RVA: 0x00031373 File Offset: 0x0002F573
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<string> PathRtList
		{
			[return: Nullable(new byte[]
			{
				2,
				0
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
				0
			})]
			set
			{
				this.GetOrCreatePoco().PathRtList = value;
			}
		}

		// Token: 0x04000C09 RID: 3081
		[Nullable(2)]
		protected new IConnectorPathAdvanceVasePlantVisual FbInstance;

		// Token: 0x04000C0A RID: 3082
		[Nullable(2)]
		protected new IConnectorPathAdvanceVasePlantVisual_SetValue PocoInterface;
	}
}
