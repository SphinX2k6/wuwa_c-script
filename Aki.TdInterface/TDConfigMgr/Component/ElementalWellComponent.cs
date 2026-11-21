using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020000DA RID: 218
	public class ElementalWellComponent : IComponentBase
	{
		// Token: 0x060003A4 RID: 932 RVA: 0x0001CDE0 File Offset: 0x0001AFE0
		private ElementalWellComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ElementalWellComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ElementalWellComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ElementalWellComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0001CE18 File Offset: 0x0001B018
		public static ElementalWellComponent Create([Nullable(2)] ElementalWellComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ElementalWellComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0001CE2B File Offset: 0x0001B02B
		public static ElementalWellComponent CreateFromSetValue([Nullable(2)] ElementalWellComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ElementalWellComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0001CE40 File Offset: 0x0001B040
		public new ElementalWellComponent_SetValue ToSetValue()
		{
			return new ElementalWellComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				WellType = this.WellType,
				StreamingRenderConfig = this.StreamingRenderConfig,
				StreamWaitConfig = this.StreamWaitConfig,
				StreamingFinishedToState = this.StreamingFinishedToState,
				LeaveRangeToState = this.LeaveRangeToState,
				PrefabBindPointKey = this.PrefabBindPointKey
			};
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x0001CEB4 File Offset: 0x0001B0B4
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x0001CEEE File Offset: 0x0001B0EE
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				ElementalWellComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060003AA RID: 938 RVA: 0x0001CEFC File Offset: 0x0001B0FC
		// (set) Token: 0x060003AB RID: 939 RVA: 0x0001CF26 File Offset: 0x0001B126
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060003AC RID: 940 RVA: 0x0001CF34 File Offset: 0x0001B134
		// (set) Token: 0x060003AD RID: 941 RVA: 0x0001CF5F File Offset: 0x0001B15F
		public virtual EElementalWellEntryType WellType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.WellType;
				}
				if (this.PocoInterface == null)
				{
					return EElementalWellEntryType.Entry;
				}
				return this.PocoInterface.WellType;
			}
			set
			{
				this.GetOrCreatePoco().WellType = value;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060003AE RID: 942 RVA: 0x0001CF70 File Offset: 0x0001B170
		// (set) Token: 0x060003AF RID: 943 RVA: 0x0001CFD1 File Offset: 0x0001B1D1
		public virtual IWellStreamingRenderConfig StreamingRenderConfig
		{
			get
			{
				if (this._StreamingRenderConfigInited)
				{
					return this._StreamingRenderConfigCache;
				}
				this._StreamingRenderConfigInited = true;
				if (this.FbInstance != null)
				{
					this._StreamingRenderConfigCache = IWellStreamingRenderConfig.Create(this.FbInstance.StreamingRenderConfig);
				}
				else
				{
					ElementalWellComponent_SetValue pocoInterface = this.PocoInterface;
					this._StreamingRenderConfigCache = ((pocoInterface != null) ? pocoInterface.StreamingRenderConfig : null);
				}
				return this._StreamingRenderConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().StreamingRenderConfig = value;
				this._StreamingRenderConfigInited = false;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x0001CFE8 File Offset: 0x0001B1E8
		// (set) Token: 0x060003B1 RID: 945 RVA: 0x0001D049 File Offset: 0x0001B249
		public virtual IStreamingWaitConfig StreamWaitConfig
		{
			get
			{
				if (this._StreamWaitConfigInited)
				{
					return this._StreamWaitConfigCache;
				}
				this._StreamWaitConfigInited = true;
				if (this.FbInstance != null)
				{
					this._StreamWaitConfigCache = IStreamingWaitConfig.Create(this.FbInstance.StreamWaitConfig);
				}
				else
				{
					ElementalWellComponent_SetValue pocoInterface = this.PocoInterface;
					this._StreamWaitConfigCache = ((pocoInterface != null) ? pocoInterface.StreamWaitConfig : null);
				}
				return this._StreamWaitConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().StreamWaitConfig = value;
				this._StreamWaitConfigInited = false;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x0001D05E File Offset: 0x0001B25E
		// (set) Token: 0x060003B3 RID: 947 RVA: 0x0001D085 File Offset: 0x0001B285
		[Nullable(2)]
		public virtual string StreamingFinishedToState
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StreamingFinishedToState;
				}
				ElementalWellComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StreamingFinishedToState;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().StreamingFinishedToState = value;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x0001D093 File Offset: 0x0001B293
		// (set) Token: 0x060003B5 RID: 949 RVA: 0x0001D0BA File Offset: 0x0001B2BA
		[Nullable(2)]
		public virtual string LeaveRangeToState
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LeaveRangeToState;
				}
				ElementalWellComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LeaveRangeToState;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().LeaveRangeToState = value;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x0001D0C8 File Offset: 0x0001B2C8
		// (set) Token: 0x060003B7 RID: 951 RVA: 0x0001D0EF File Offset: 0x0001B2EF
		[Nullable(2)]
		public virtual string PrefabBindPointKey
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PrefabBindPointKey;
				}
				ElementalWellComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PrefabBindPointKey;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().PrefabBindPointKey = value;
			}
		}

		// Token: 0x040004BD RID: 1213
		[Nullable(2)]
		protected new ElementalWellComponent FbInstance;

		// Token: 0x040004BE RID: 1214
		[Nullable(2)]
		protected new ElementalWellComponent_SetValue PocoInterface;

		// Token: 0x040004BF RID: 1215
		private IWellStreamingRenderConfig _StreamingRenderConfigCache;

		// Token: 0x040004C0 RID: 1216
		private bool _StreamingRenderConfigInited;

		// Token: 0x040004C1 RID: 1217
		private IStreamingWaitConfig _StreamWaitConfigCache;

		// Token: 0x040004C2 RID: 1218
		private bool _StreamWaitConfigInited;
	}
}
