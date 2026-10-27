using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001820 RID: 6176
	[NullableContext(1)]
	[Nullable(0)]
	public class IBubbleRangeCylinderConfig
	{
		// Token: 0x0600848B RID: 33931 RVA: 0x0013BB08 File Offset: 0x00139D08
		private IBubbleRangeCylinderConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBubbleRangeCylinderConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBubbleRangeCylinderConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBubbleRangeCylinderConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600848C RID: 33932 RVA: 0x0013BB40 File Offset: 0x00139D40
		public static IBubbleRangeCylinderConfig Create([Nullable(2)] IBubbleRangeCylinderConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBubbleRangeCylinderConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600848D RID: 33933 RVA: 0x0013BB53 File Offset: 0x00139D53
		public static IBubbleRangeCylinderConfig CreateFromSetValue([Nullable(2)] IBubbleRangeCylinderConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBubbleRangeCylinderConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600848E RID: 33934 RVA: 0x0013BB66 File Offset: 0x00139D66
		public IBubbleRangeCylinderConfig_SetValue ToSetValue()
		{
			return new IBubbleRangeCylinderConfig_SetValue
			{
				InnerConfig = this.InnerConfig,
				OuterConfig = this.OuterConfig
			};
		}

		// Token: 0x17002B6A RID: 11114
		// (get) Token: 0x0600848F RID: 33935 RVA: 0x0013BB88 File Offset: 0x00139D88
		// (set) Token: 0x06008490 RID: 33936 RVA: 0x0013BBE9 File Offset: 0x00139DE9
		public virtual IBubbleCylinderConfig InnerConfig
		{
			get
			{
				if (this._InnerConfigInited)
				{
					return this._InnerConfigCache;
				}
				this._InnerConfigInited = true;
				if (this.FbInstance != null)
				{
					this._InnerConfigCache = IBubbleCylinderConfig.Create(this.FbInstance.InnerConfig);
				}
				else
				{
					IBubbleRangeCylinderConfig_SetValue pocoInterface = this.PocoInterface;
					this._InnerConfigCache = ((pocoInterface != null) ? pocoInterface.InnerConfig : null);
				}
				return this._InnerConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().InnerConfig = value;
				this._InnerConfigInited = false;
			}
		}

		// Token: 0x17002B6B RID: 11115
		// (get) Token: 0x06008491 RID: 33937 RVA: 0x0013BC00 File Offset: 0x00139E00
		// (set) Token: 0x06008492 RID: 33938 RVA: 0x0013BC61 File Offset: 0x00139E61
		public virtual IBubbleCylinderConfig OuterConfig
		{
			get
			{
				if (this._OuterConfigInited)
				{
					return this._OuterConfigCache;
				}
				this._OuterConfigInited = true;
				if (this.FbInstance != null)
				{
					this._OuterConfigCache = IBubbleCylinderConfig.Create(this.FbInstance.OuterConfig);
				}
				else
				{
					IBubbleRangeCylinderConfig_SetValue pocoInterface = this.PocoInterface;
					this._OuterConfigCache = ((pocoInterface != null) ? pocoInterface.OuterConfig : null);
				}
				return this._OuterConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().OuterConfig = value;
				this._OuterConfigInited = false;
			}
		}

		// Token: 0x040053DD RID: 21469
		[Nullable(2)]
		protected IBubbleRangeCylinderConfig FbInstance;

		// Token: 0x040053DE RID: 21470
		[Nullable(2)]
		protected IBubbleRangeCylinderConfig_SetValue PocoInterface;

		// Token: 0x040053DF RID: 21471
		private IBubbleCylinderConfig _InnerConfigCache;

		// Token: 0x040053E0 RID: 21472
		private bool _InnerConfigInited;

		// Token: 0x040053E1 RID: 21473
		private IBubbleCylinderConfig _OuterConfigCache;

		// Token: 0x040053E2 RID: 21474
		private bool _OuterConfigInited;
	}
}
