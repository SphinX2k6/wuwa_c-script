using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003E3 RID: 995
	public class IFixedStreamingSource : IStreamingSourceConfigBase
	{
		// Token: 0x060013A3 RID: 5027 RVA: 0x0003FEF4 File Offset: 0x0003E0F4
		private IFixedStreamingSource_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFixedStreamingSource 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFixedStreamingSource_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFixedStreamingSource_SetValue());
			}
			return result;
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x0003FF2C File Offset: 0x0003E12C
		public static IFixedStreamingSource Create([Nullable(2)] IFixedStreamingSource instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFixedStreamingSource
			{
				FbInstance = instance
			};
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x0003FF3F File Offset: 0x0003E13F
		public static IFixedStreamingSource CreateFromSetValue([Nullable(2)] IFixedStreamingSource_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFixedStreamingSource
			{
				PocoInterface = value
			};
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x0003FF52 File Offset: 0x0003E152
		public new IFixedStreamingSource_SetValue ToSetValue()
		{
			return new IFixedStreamingSource_SetValue
			{
				Type = this.Type,
				StreamingSourceConfig = this.StreamingSourceConfig
			};
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x060013A7 RID: 5031 RVA: 0x0003FF71 File Offset: 0x0003E171
		// (set) Token: 0x060013A8 RID: 5032 RVA: 0x0003FF9C File Offset: 0x0003E19C
		public override EStreamingSourceMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EStreamingSourceMode.Fixed;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x060013A9 RID: 5033 RVA: 0x0003FFAC File Offset: 0x0003E1AC
		// (set) Token: 0x060013AA RID: 5034 RVA: 0x0004000D File Offset: 0x0003E20D
		public virtual IStreamingSourceConfig StreamingSourceConfig
		{
			get
			{
				if (this._StreamingSourceConfigInited)
				{
					return this._StreamingSourceConfigCache;
				}
				this._StreamingSourceConfigInited = true;
				if (this.FbInstance != null)
				{
					this._StreamingSourceConfigCache = IStreamingSourceConfig.Create(this.FbInstance.StreamingSourceConfig);
				}
				else
				{
					IFixedStreamingSource_SetValue pocoInterface = this.PocoInterface;
					this._StreamingSourceConfigCache = ((pocoInterface != null) ? pocoInterface.StreamingSourceConfig : null);
				}
				return this._StreamingSourceConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().StreamingSourceConfig = value;
				this._StreamingSourceConfigInited = false;
			}
		}

		// Token: 0x04000FC8 RID: 4040
		[Nullable(2)]
		protected new IFixedStreamingSource FbInstance;

		// Token: 0x04000FC9 RID: 4041
		[Nullable(2)]
		protected new IFixedStreamingSource_SetValue PocoInterface;

		// Token: 0x04000FCA RID: 4042
		private IStreamingSourceConfig _StreamingSourceConfigCache;

		// Token: 0x04000FCB RID: 4043
		private bool _StreamingSourceConfigInited;
	}
}
