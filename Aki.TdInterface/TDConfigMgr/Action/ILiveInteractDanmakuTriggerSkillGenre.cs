using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D5D RID: 7517
	public class ILiveInteractDanmakuTriggerSkillGenre : ILiveInteractDanmakuTrigger
	{
		// Token: 0x06009F9D RID: 40861 RVA: 0x0016E6D8 File Offset: 0x0016C8D8
		private ILiveInteractDanmakuTriggerSkillGenre_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILiveInteractDanmakuTriggerSkillGenre 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILiveInteractDanmakuTriggerSkillGenre_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILiveInteractDanmakuTriggerSkillGenre_SetValue());
			}
			return result;
		}

		// Token: 0x06009F9E RID: 40862 RVA: 0x0016E710 File Offset: 0x0016C910
		public static ILiveInteractDanmakuTriggerSkillGenre Create([Nullable(2)] ILiveInteractDanmakuTriggerSkillGenre instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveInteractDanmakuTriggerSkillGenre
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009F9F RID: 40863 RVA: 0x0016E723 File Offset: 0x0016C923
		public static ILiveInteractDanmakuTriggerSkillGenre CreateFromSetValue([Nullable(2)] ILiveInteractDanmakuTriggerSkillGenre_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILiveInteractDanmakuTriggerSkillGenre
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009FA0 RID: 40864 RVA: 0x0016E736 File Offset: 0x0016C936
		public new ILiveInteractDanmakuTriggerSkillGenre_SetValue ToSetValue()
		{
			return new ILiveInteractDanmakuTriggerSkillGenre_SetValue
			{
				Type = this.Type,
				SkillGenre = this.SkillGenre
			};
		}

		// Token: 0x170031D1 RID: 12753
		// (get) Token: 0x06009FA1 RID: 40865 RVA: 0x0016E755 File Offset: 0x0016C955
		// (set) Token: 0x06009FA2 RID: 40866 RVA: 0x0016E780 File Offset: 0x0016C980
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

		// Token: 0x170031D2 RID: 12754
		// (get) Token: 0x06009FA3 RID: 40867 RVA: 0x0016E78E File Offset: 0x0016C98E
		// (set) Token: 0x06009FA4 RID: 40868 RVA: 0x0016E7B9 File Offset: 0x0016C9B9
		public virtual int SkillGenre
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SkillGenre;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SkillGenre;
			}
			set
			{
				this.GetOrCreatePoco().SkillGenre = value;
			}
		}

		// Token: 0x04006120 RID: 24864
		[Nullable(2)]
		protected new ILiveInteractDanmakuTriggerSkillGenre FbInstance;

		// Token: 0x04006121 RID: 24865
		[Nullable(2)]
		protected new ILiveInteractDanmakuTriggerSkillGenre_SetValue PocoInterface;
	}
}
