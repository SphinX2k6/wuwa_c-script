using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012E6 RID: 4838
	public class ITrackAreaText
	{
		// Token: 0x06006CF3 RID: 27891 RVA: 0x001039AC File Offset: 0x00101BAC
		private ITrackAreaText_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITrackAreaText 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITrackAreaText_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITrackAreaText_SetValue());
			}
			return result;
		}

		// Token: 0x06006CF4 RID: 27892 RVA: 0x001039E4 File Offset: 0x00101BE4
		public static ITrackAreaText Create([Nullable(2)] ITrackAreaText instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrackAreaText
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006CF5 RID: 27893 RVA: 0x001039F7 File Offset: 0x00101BF7
		public static ITrackAreaText CreateFromSetValue([Nullable(2)] ITrackAreaText_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITrackAreaText
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006CF6 RID: 27894 RVA: 0x00103A0A File Offset: 0x00101C0A
		public ITrackAreaText_SetValue ToSetValue()
		{
			return new ITrackAreaText_SetValue
			{
				Show = this.Show,
				Tid = this.Tid,
				EdTid = this.EdTid
			};
		}

		// Token: 0x17002320 RID: 8992
		// (get) Token: 0x06006CF7 RID: 27895 RVA: 0x00103A35 File Offset: 0x00101C35
		// (set) Token: 0x06006CF8 RID: 27896 RVA: 0x00103A60 File Offset: 0x00101C60
		public virtual bool Show
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Show;
				}
				return this.PocoInterface != null && this.PocoInterface.Show;
			}
			set
			{
				this.GetOrCreatePoco().Show = value;
			}
		}

		// Token: 0x17002321 RID: 8993
		// (get) Token: 0x06006CF9 RID: 27897 RVA: 0x00103A6E File Offset: 0x00101C6E
		// (set) Token: 0x06006CFA RID: 27898 RVA: 0x00103A99 File Offset: 0x00101C99
		public virtual string Tid
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Tid;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Tid;
			}
			set
			{
				this.GetOrCreatePoco().Tid = value;
			}
		}

		// Token: 0x17002322 RID: 8994
		// (get) Token: 0x06006CFB RID: 27899 RVA: 0x00103AA7 File Offset: 0x00101CA7
		// (set) Token: 0x06006CFC RID: 27900 RVA: 0x00103ABE File Offset: 0x00101CBE
		[Nullable(2)]
		public virtual string EdTid
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTid;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdTid = value;
			}
		}

		// Token: 0x0400410E RID: 16654
		[Nullable(2)]
		protected ITrackAreaText FbInstance;

		// Token: 0x0400410F RID: 16655
		[Nullable(2)]
		protected ITrackAreaText_SetValue PocoInterface;
	}
}
