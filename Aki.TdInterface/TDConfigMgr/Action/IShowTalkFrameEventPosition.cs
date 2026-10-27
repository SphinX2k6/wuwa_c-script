using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E66 RID: 7782
	[NullableContext(1)]
	[Nullable(0)]
	public class IShowTalkFrameEventPosition
	{
		// Token: 0x0600A693 RID: 42643 RVA: 0x00178F14 File Offset: 0x00177114
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

		// Token: 0x0600A694 RID: 42644 RVA: 0x00178F4C File Offset: 0x0017714C
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

		// Token: 0x0600A695 RID: 42645 RVA: 0x00178F5F File Offset: 0x0017715F
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

		// Token: 0x0600A696 RID: 42646 RVA: 0x00178F72 File Offset: 0x00177172
		public IShowTalkFrameEventPosition_SetValue ToSetValue()
		{
			return new IShowTalkFrameEventPosition_SetValue
			{
				TalkItemId = this.TalkItemId,
				Offset = this.Offset
			};
		}

		// Token: 0x17003307 RID: 13063
		// (get) Token: 0x0600A697 RID: 42647 RVA: 0x00178F91 File Offset: 0x00177191
		// (set) Token: 0x0600A698 RID: 42648 RVA: 0x00178FBC File Offset: 0x001771BC
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

		// Token: 0x17003308 RID: 13064
		// (get) Token: 0x0600A699 RID: 42649 RVA: 0x00178FCA File Offset: 0x001771CA
		// (set) Token: 0x0600A69A RID: 42650 RVA: 0x00178FF5 File Offset: 0x001771F5
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

		// Token: 0x04006380 RID: 25472
		[Nullable(2)]
		protected IShowTalkFrameEventPosition FbInstance;

		// Token: 0x04006381 RID: 25473
		[Nullable(2)]
		protected IShowTalkFrameEventPosition_SetValue PocoInterface;
	}
}
