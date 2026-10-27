using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011C0 RID: 4544
	[NullableContext(1)]
	[Nullable(0)]
	public class ITrackQuestBranchBoardConfig
	{
		// Token: 0x0600674A RID: 26442 RVA: 0x000F7668 File Offset: 0x000F5868
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

		// Token: 0x0600674B RID: 26443 RVA: 0x000F76A0 File Offset: 0x000F58A0
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

		// Token: 0x0600674C RID: 26444 RVA: 0x000F76B3 File Offset: 0x000F58B3
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

		// Token: 0x0600674D RID: 26445 RVA: 0x000F76C6 File Offset: 0x000F58C6
		public ITrackQuestBranchBoardConfig_SetValue ToSetValue()
		{
			return new ITrackQuestBranchBoardConfig_SetValue
			{
				Id = this.Id,
				EnableAnimation = this.EnableAnimation
			};
		}

		// Token: 0x1700218A RID: 8586
		// (get) Token: 0x0600674E RID: 26446 RVA: 0x000F76E5 File Offset: 0x000F58E5
		// (set) Token: 0x0600674F RID: 26447 RVA: 0x000F7710 File Offset: 0x000F5910
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

		// Token: 0x1700218B RID: 8587
		// (get) Token: 0x06006750 RID: 26448 RVA: 0x000F7720 File Offset: 0x000F5920
		// (set) Token: 0x06006751 RID: 26449 RVA: 0x000F775A File Offset: 0x000F595A
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

		// Token: 0x04003E07 RID: 15879
		[Nullable(2)]
		protected ITrackQuestBranchBoardConfig FbInstance;

		// Token: 0x04003E08 RID: 15880
		[Nullable(2)]
		protected ITrackQuestBranchBoardConfig_SetValue PocoInterface;
	}
}
