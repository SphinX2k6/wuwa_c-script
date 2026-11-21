using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D5F RID: 7519
	public class ILiveInteractDanmakuTriggerSkillId : ILiveInteractDanmakuTrigger
	{
		// Token: 0x06009FA7 RID: 40871 RVA: 0x0016E7D8 File Offset: 0x0016C9D8
		private ILiveInteractDanmakuTriggerSkillId_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILiveInteractDanmakuTriggerSkillId 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILiveInteractDanmakuTriggerSkillId_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILiveInteractDanmakuTriggerSkillId_SetValue());
			}
			return result;
		}

		// Token: 0x06009FA8 RID: 40872 RVA: 0x0016E810 File Offset: 0x0016CA10
		public static ILiveInteractDanmakuTriggerSkillId Create([Nullable(2)] ILiveInteractDanmakuTriggerSkillId instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveInteractDanmakuTriggerSkillId
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009FA9 RID: 40873 RVA: 0x0016E823 File Offset: 0x0016CA23
		public static ILiveInteractDanmakuTriggerSkillId CreateFromSetValue([Nullable(2)] ILiveInteractDanmakuTriggerSkillId_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILiveInteractDanmakuTriggerSkillId
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009FAA RID: 40874 RVA: 0x0016E836 File Offset: 0x0016CA36
		public new ILiveInteractDanmakuTriggerSkillId_SetValue ToSetValue()
		{
			return new ILiveInteractDanmakuTriggerSkillId_SetValue
			{
				Type = this.Type,
				SkillId = this.SkillId
			};
		}

		// Token: 0x170031D3 RID: 12755
		// (get) Token: 0x06009FAB RID: 40875 RVA: 0x0016E855 File Offset: 0x0016CA55
		// (set) Token: 0x06009FAC RID: 40876 RVA: 0x0016E880 File Offset: 0x0016CA80
		public override ELiveInteractDanmakuTriggerType Type
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

		// Token: 0x170031D4 RID: 12756
		// (get) Token: 0x06009FAD RID: 40877 RVA: 0x0016E88E File Offset: 0x0016CA8E
		// (set) Token: 0x06009FAE RID: 40878 RVA: 0x0016E8B9 File Offset: 0x0016CAB9
		public virtual int SkillId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SkillId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SkillId;
			}
			set
			{
				this.GetOrCreatePoco().SkillId = value;
			}
		}

		// Token: 0x04006124 RID: 24868
		[Nullable(2)]
		protected new ILiveInteractDanmakuTriggerSkillId FbInstance;

		// Token: 0x04006125 RID: 24869
		[Nullable(2)]
		protected new ILiveInteractDanmakuTriggerSkillId_SetValue PocoInterface;
	}
}
