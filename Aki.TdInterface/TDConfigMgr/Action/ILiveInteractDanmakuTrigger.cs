using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D59 RID: 7513
	public class ILiveInteractDanmakuTrigger
	{
		// Token: 0x06009F89 RID: 40841 RVA: 0x0016E4D8 File Offset: 0x0016C6D8
		private ILiveInteractDanmakuTrigger_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILiveInteractDanmakuTrigger 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILiveInteractDanmakuTrigger_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILiveInteractDanmakuTrigger_SetValue());
			}
			return result;
		}

		// Token: 0x06009F8A RID: 40842 RVA: 0x0016E510 File Offset: 0x0016C710
		public static ILiveInteractDanmakuTrigger Create([Nullable(2)] ILiveInteractDanmakuTrigger instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveInteractDanmakuTrigger
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009F8B RID: 40843 RVA: 0x0016E523 File Offset: 0x0016C723
		public static ILiveInteractDanmakuTrigger CreateFromSetValue([Nullable(2)] ILiveInteractDanmakuTrigger_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILiveInteractDanmakuTrigger
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009F8C RID: 40844 RVA: 0x0016E536 File Offset: 0x0016C736
		public ILiveInteractDanmakuTrigger_SetValue ToSetValue()
		{
			return new ILiveInteractDanmakuTrigger_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170031CD RID: 12749
		// (get) Token: 0x06009F8D RID: 40845 RVA: 0x0016E549 File Offset: 0x0016C749
		// (set) Token: 0x06009F8E RID: 40846 RVA: 0x0016E574 File Offset: 0x0016C774
		public virtual ELiveInteractDanmakuTriggerType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELiveInteractDanmakuTriggerType.SkillGenre;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006118 RID: 24856
		[Nullable(2)]
		protected ILiveInteractDanmakuTrigger FbInstance;

		// Token: 0x04006119 RID: 24857
		[Nullable(2)]
		protected ILiveInteractDanmakuTrigger_SetValue PocoInterface;
	}
}
