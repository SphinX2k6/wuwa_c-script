using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012FC RID: 4860
	public class ITrackQuestBranchBoardConfig
	{
		// Token: 0x06006D8B RID: 28043 RVA: 0x00104F74 File Offset: 0x00103174
		private ITrackQuestBranchBoardConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITrackQuestBranchBoardConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITrackQuestBranchBoardConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITrackQuestBranchBoardConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06006D8C RID: 28044 RVA: 0x00104FAC File Offset: 0x001031AC
		public static ITrackQuestBranchBoardConfig Create([Nullable(2)] ITrackQuestBranchBoardConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrackQuestBranchBoardConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006D8D RID: 28045 RVA: 0x00104FBF File Offset: 0x001031BF
		public static ITrackQuestBranchBoardConfig CreateFromSetValue([Nullable(2)] ITrackQuestBranchBoardConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITrackQuestBranchBoardConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006D8E RID: 28046 RVA: 0x00104FD2 File Offset: 0x001031D2
		public ITrackQuestBranchBoardConfig_SetValue ToSetValue()
		{
			return new ITrackQuestBranchBoardConfig_SetValue
			{
				Id = this.Id,
				EnableAnimation = this.EnableAnimation
			};
		}

		// Token: 0x1700234B RID: 9035
		// (get) Token: 0x06006D8F RID: 28047 RVA: 0x00104FF1 File Offset: 0x001031F1
		// (set) Token: 0x06006D90 RID: 28048 RVA: 0x0010501C File Offset: 0x0010321C
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x1700234C RID: 9036
		// (get) Token: 0x06006D91 RID: 28049 RVA: 0x0010502C File Offset: 0x0010322C
		// (set) Token: 0x06006D92 RID: 28050 RVA: 0x00105066 File Offset: 0x00103266
		public virtual bool? EnableAnimation
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EnableAnimation;
				}
				ITrackQuestBranchBoardConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EnableAnimation;
			}
			set
			{
				this.GetOrCreatePoco().EnableAnimation = value;
			}
		}

		// Token: 0x04004175 RID: 16757
		[Nullable(2)]
		protected ITrackQuestBranchBoardConfig FbInstance;

		// Token: 0x04004176 RID: 16758
		[Nullable(2)]
		protected ITrackQuestBranchBoardConfig_SetValue PocoInterface;
	}
}
