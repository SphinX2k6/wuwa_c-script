using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200231C RID: 8988
	public class JumpTalk : ActionParams
	{
		// Token: 0x0600C3C8 RID: 50120 RVA: 0x001C18C4 File Offset: 0x001BFAC4
		private JumpTalk_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("JumpTalk 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			JumpTalk_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new JumpTalk_SetValue());
			}
			return result;
		}

		// Token: 0x0600C3C9 RID: 50121 RVA: 0x001C18FC File Offset: 0x001BFAFC
		public static JumpTalk Create([Nullable(2)] JumpTalk instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new JumpTalk
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C3CA RID: 50122 RVA: 0x001C190F File Offset: 0x001BFB0F
		public static JumpTalk CreateFromSetValue([Nullable(2)] JumpTalk_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new JumpTalk
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C3CB RID: 50123 RVA: 0x001C1922 File Offset: 0x001BFB22
		public JumpTalk_SetValue ToSetValue()
		{
			return new JumpTalk_SetValue
			{
				TalkId = this.TalkId
			};
		}

		// Token: 0x17003B4A RID: 15178
		// (get) Token: 0x0600C3CC RID: 50124 RVA: 0x001C1935 File Offset: 0x001BFB35
		// (set) Token: 0x0600C3CD RID: 50125 RVA: 0x001C1960 File Offset: 0x001BFB60
		public virtual int TalkId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TalkId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TalkId;
			}
			set
			{
				this.GetOrCreatePoco().TalkId = value;
			}
		}

		// Token: 0x040074A9 RID: 29865
		[Nullable(2)]
		protected new JumpTalk FbInstance;

		// Token: 0x040074AA RID: 29866
		[Nullable(2)]
		protected JumpTalk_SetValue PocoInterface;
	}
}
