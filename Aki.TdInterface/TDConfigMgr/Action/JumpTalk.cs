using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020C7 RID: 8391
	[NullableContext(1)]
	[Nullable(0)]
	public class JumpTalk : ActionParams
	{
		// Token: 0x0600B870 RID: 47216 RVA: 0x001AAC7C File Offset: 0x001A8E7C
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

		// Token: 0x0600B871 RID: 47217 RVA: 0x001AACB4 File Offset: 0x001A8EB4
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

		// Token: 0x0600B872 RID: 47218 RVA: 0x001AACC7 File Offset: 0x001A8EC7
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

		// Token: 0x0600B873 RID: 47219 RVA: 0x001AACDA File Offset: 0x001A8EDA
		public JumpTalk_SetValue ToSetValue()
		{
			return new JumpTalk_SetValue
			{
				TalkId = this.TalkId
			};
		}

		// Token: 0x17003866 RID: 14438
		// (get) Token: 0x0600B874 RID: 47220 RVA: 0x001AACED File Offset: 0x001A8EED
		// (set) Token: 0x0600B875 RID: 47221 RVA: 0x001AAD18 File Offset: 0x001A8F18
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

		// Token: 0x04006E8B RID: 28299
		[Nullable(2)]
		protected new JumpTalk FbInstance;

		// Token: 0x04006E8C RID: 28300
		[Nullable(2)]
		protected JumpTalk_SetValue PocoInterface;
	}
}
