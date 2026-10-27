using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020000D2 RID: 210
	[NullableContext(1)]
	[Nullable(0)]
	public class ElementalWellComponent : IComponentBase
	{
		// Token: 0x060003A0 RID: 928 RVA: 0x0001C46C File Offset: 0x0001A66C
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

		// Token: 0x060003A1 RID: 929 RVA: 0x0001C4A4 File Offset: 0x0001A6A4
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

		// Token: 0x060003A2 RID: 930 RVA: 0x0001C4B7 File Offset: 0x0001A6B7
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

		// Token: 0x060003A3 RID: 931 RVA: 0x0001C4CC File Offset: 0x0001A6CC
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

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x0001C540 File Offset: 0x0001A740
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x0001C57A File Offset: 0x0001A77A
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

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x0001C588 File Offset: 0x0001A788
		// (set) Token: 0x060003A7 RID: 935 RVA: 0x0001C5B2 File Offset: 0x0001A7B2
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

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x0001C5C0 File Offset: 0x0001A7C0
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x0001C5EB File Offset: 0x0001A7EB
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

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060003AA RID: 938 RVA: 0x0001C5FC File Offset: 0x0001A7FC
		// (set) Token: 0x060003AB RID: 939 RVA: 0x0001C65D File Offset: 0x0001A85D
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

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060003AC RID: 940 RVA: 0x0001C674 File Offset: 0x0001A874
		// (set) Token: 0x060003AD RID: 941 RVA: 0x0001C6D5 File Offset: 0x0001A8D5
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

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060003AE RID: 942 RVA: 0x0001C6EA File Offset: 0x0001A8EA
		// (set) Token: 0x060003AF RID: 943 RVA: 0x0001C711 File Offset: 0x0001A911
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

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x0001C71F File Offset: 0x0001A91F
		// (set) Token: 0x060003B1 RID: 945 RVA: 0x0001C746 File Offset: 0x0001A946
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

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x0001C754 File Offset: 0x0001A954
		// (set) Token: 0x060003B3 RID: 947 RVA: 0x0001C77B File Offset: 0x0001A97B
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

		// Token: 0x04000499 RID: 1177
		[Nullable(2)]
		protected new ElementalWellComponent FbInstance;

		// Token: 0x0400049A RID: 1178
		[Nullable(2)]
		protected new ElementalWellComponent_SetValue PocoInterface;

		// Token: 0x0400049B RID: 1179
		private IWellStreamingRenderConfig _StreamingRenderConfigCache;

		// Token: 0x0400049C RID: 1180
		private bool _StreamingRenderConfigInited;

		// Token: 0x0400049D RID: 1181
		private IStreamingWaitConfig _StreamWaitConfigCache;

		// Token: 0x0400049E RID: 1182
		private bool _StreamWaitConfigInited;
	}
}
