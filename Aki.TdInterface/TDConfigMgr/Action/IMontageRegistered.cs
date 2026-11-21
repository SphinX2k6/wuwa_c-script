using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DF9 RID: 7673
	public class IMontageRegistered : IMontageConfig
	{
		// Token: 0x0600A309 RID: 41737 RVA: 0x00174FA0 File Offset: 0x001731A0
		private IMontageRegistered_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMontageRegistered 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMontageRegistered_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMontageRegistered_SetValue());
			}
			return result;
		}

		// Token: 0x0600A30A RID: 41738 RVA: 0x00174FD8 File Offset: 0x001731D8
		public static IMontageRegistered Create([Nullable(2)] IMontageRegistered instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMontageRegistered
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A30B RID: 41739 RVA: 0x00174FEB File Offset: 0x001731EB
		public static IMontageRegistered CreateFromSetValue([Nullable(2)] IMontageRegistered_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMontageRegistered
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A30C RID: 41740 RVA: 0x00174FFE File Offset: 0x001731FE
		public new IMontageRegistered_SetValue ToSetValue()
		{
			return new IMontageRegistered_SetValue
			{
				Type = this.Type,
				MontageId = this.MontageId
			};
		}

		// Token: 0x1700329D RID: 12957
		// (get) Token: 0x0600A30D RID: 41741 RVA: 0x0017501D File Offset: 0x0017321D
		// (set) Token: 0x0600A30E RID: 41742 RVA: 0x00175048 File Offset: 0x00173248
		public override EMontageConfigType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMontageConfigType.Asset;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700329E RID: 12958
		// (get) Token: 0x0600A30F RID: 41743 RVA: 0x00175058 File Offset: 0x00173258
		// (set) Token: 0x0600A310 RID: 41744 RVA: 0x001750B9 File Offset: 0x001732B9
		public virtual IMontageId MontageId
		{
			get
			{
				if (this._MontageIdInited)
				{
					return this._MontageIdCache;
				}
				this._MontageIdInited = true;
				if (this.FbInstance != null)
				{
					this._MontageIdCache = IMontageId.Create(this.FbInstance.MontageId);
				}
				else
				{
					IMontageRegistered_SetValue pocoInterface = this.PocoInterface;
					this._MontageIdCache = ((pocoInterface != null) ? pocoInterface.MontageId : null);
				}
				return this._MontageIdCache;
			}
			set
			{
				this.GetOrCreatePoco().MontageId = value;
				this._MontageIdInited = false;
			}
		}

		// Token: 0x040062CA RID: 25290
		[Nullable(2)]
		protected new IMontageRegistered FbInstance;

		// Token: 0x040062CB RID: 25291
		[Nullable(2)]
		protected new IMontageRegistered_SetValue PocoInterface;

		// Token: 0x040062CC RID: 25292
		private IMontageId _MontageIdCache;

		// Token: 0x040062CD RID: 25293
		private bool _MontageIdInited;
	}
}
