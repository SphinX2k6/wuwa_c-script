using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EBF RID: 7871
	[NullableContext(2)]
	[Nullable(0)]
	public class IOptionLockTip
	{
		// Token: 0x0600A783 RID: 42883 RVA: 0x0017D118 File Offset: 0x0017B318
		[NullableContext(0)]
		private IOptionLockTip_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IOptionLockTip 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IOptionLockTip_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IOptionLockTip_SetValue());
			}
			return result;
		}

		// Token: 0x0600A784 RID: 42884 RVA: 0x0017D150 File Offset: 0x0017B350
		[NullableContext(0)]
		public static IOptionLockTip Create([Nullable(2)] IOptionLockTip instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOptionLockTip
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A785 RID: 42885 RVA: 0x0017D163 File Offset: 0x0017B363
		[NullableContext(0)]
		public static IOptionLockTip CreateFromSetValue([Nullable(2)] IOptionLockTip_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IOptionLockTip
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A786 RID: 42886 RVA: 0x0017D178 File Offset: 0x0017B378
		[NullableContext(0)]
		public IOptionLockTip_SetValue ToSetValue()
		{
			return new IOptionLockTip_SetValue
			{
				TidAppendText = this.TidAppendText,
				TidHintText = this.TidHintText,
				AppendTextId = this.AppendTextId,
				HintTextId = this.HintTextId,
				EdTidAppendText = this.EdTidAppendText,
				EdTidHintText = this.EdTidHintText
			};
		}

		// Token: 0x170033B1 RID: 13233
		// (get) Token: 0x0600A787 RID: 42887 RVA: 0x0017D1D2 File Offset: 0x0017B3D2
		// (set) Token: 0x0600A788 RID: 42888 RVA: 0x0017D1F9 File Offset: 0x0017B3F9
		public virtual string TidAppendText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidAppendText;
				}
				IOptionLockTip_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TidAppendText;
			}
			set
			{
				this.GetOrCreatePoco().TidAppendText = value;
			}
		}

		// Token: 0x170033B2 RID: 13234
		// (get) Token: 0x0600A789 RID: 42889 RVA: 0x0017D207 File Offset: 0x0017B407
		// (set) Token: 0x0600A78A RID: 42890 RVA: 0x0017D22E File Offset: 0x0017B42E
		public virtual string TidHintText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidHintText;
				}
				IOptionLockTip_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TidHintText;
			}
			set
			{
				this.GetOrCreatePoco().TidHintText = value;
			}
		}

		// Token: 0x170033B3 RID: 13235
		// (get) Token: 0x0600A78B RID: 42891 RVA: 0x0017D23C File Offset: 0x0017B43C
		// (set) Token: 0x0600A78C RID: 42892 RVA: 0x0017D276 File Offset: 0x0017B476
		public virtual int? AppendTextId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AppendTextId;
				}
				IOptionLockTip_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AppendTextId;
			}
			set
			{
				this.GetOrCreatePoco().AppendTextId = value;
			}
		}

		// Token: 0x170033B4 RID: 13236
		// (get) Token: 0x0600A78D RID: 42893 RVA: 0x0017D284 File Offset: 0x0017B484
		// (set) Token: 0x0600A78E RID: 42894 RVA: 0x0017D2BE File Offset: 0x0017B4BE
		public virtual int? HintTextId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HintTextId;
				}
				IOptionLockTip_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HintTextId;
			}
			set
			{
				this.GetOrCreatePoco().HintTextId = value;
			}
		}

		// Token: 0x170033B5 RID: 13237
		// (get) Token: 0x0600A78F RID: 42895 RVA: 0x0017D2CC File Offset: 0x0017B4CC
		// (set) Token: 0x0600A790 RID: 42896 RVA: 0x0017D2E3 File Offset: 0x0017B4E3
		public virtual string EdTidAppendText
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidAppendText;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdTidAppendText = value;
			}
		}

		// Token: 0x170033B6 RID: 13238
		// (get) Token: 0x0600A791 RID: 42897 RVA: 0x0017D2F1 File Offset: 0x0017B4F1
		// (set) Token: 0x0600A792 RID: 42898 RVA: 0x0017D308 File Offset: 0x0017B508
		public virtual string EdTidHintText
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidHintText;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdTidHintText = value;
			}
		}

		// Token: 0x040064DA RID: 25818
		protected IOptionLockTip FbInstance;

		// Token: 0x040064DB RID: 25819
		protected IOptionLockTip_SetValue PocoInterface;
	}
}
