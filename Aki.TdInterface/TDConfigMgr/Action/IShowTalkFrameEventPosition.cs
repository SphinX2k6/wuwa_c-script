using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200209B RID: 8347
	public class IShowTalkFrameEventPosition
	{
		// Token: 0x0600B14B RID: 45387 RVA: 0x0018EC14 File Offset: 0x0018CE14
		private IShowTalkFrameEventPosition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IShowTalkFrameEventPosition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IShowTalkFrameEventPosition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IShowTalkFrameEventPosition_SetValue());
			}
			return result;
		}

		// Token: 0x0600B14C RID: 45388 RVA: 0x0018EC4C File Offset: 0x0018CE4C
		public static IShowTalkFrameEventPosition Create([Nullable(2)] IShowTalkFrameEventPosition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowTalkFrameEventPosition
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B14D RID: 45389 RVA: 0x0018EC5F File Offset: 0x0018CE5F
		public static IShowTalkFrameEventPosition CreateFromSetValue([Nullable(2)] IShowTalkFrameEventPosition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IShowTalkFrameEventPosition
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B14E RID: 45390 RVA: 0x0018EC72 File Offset: 0x0018CE72
		public IShowTalkFrameEventPosition_SetValue ToSetValue()
		{
			return new IShowTalkFrameEventPosition_SetValue
			{
				TalkItemId = this.TalkItemId,
				Offset = this.Offset
			};
		}

		// Token: 0x170035CB RID: 13771
		// (get) Token: 0x0600B14F RID: 45391 RVA: 0x0018EC91 File Offset: 0x0018CE91
		// (set) Token: 0x0600B150 RID: 45392 RVA: 0x0018ECBC File Offset: 0x0018CEBC
		public virtual int TalkItemId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TalkItemId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TalkItemId;
			}
			set
			{
				this.GetOrCreatePoco().TalkItemId = value;
			}
		}

		// Token: 0x170035CC RID: 13772
		// (get) Token: 0x0600B151 RID: 45393 RVA: 0x0018ECCA File Offset: 0x0018CECA
		// (set) Token: 0x0600B152 RID: 45394 RVA: 0x0018ECF5 File Offset: 0x0018CEF5
		public virtual int Offset
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Offset;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Offset;
			}
			set
			{
				this.GetOrCreatePoco().Offset = value;
			}
		}

		// Token: 0x04006964 RID: 26980
		[Nullable(2)]
		protected IShowTalkFrameEventPosition FbInstance;

		// Token: 0x04006965 RID: 26981
		[Nullable(2)]
		protected IShowTalkFrameEventPosition_SetValue PocoInterface;
	}
}
