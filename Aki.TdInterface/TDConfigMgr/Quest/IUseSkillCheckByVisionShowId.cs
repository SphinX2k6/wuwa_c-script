using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011EA RID: 4586
	[NullableContext(1)]
	[Nullable(0)]
	public class IUseSkillCheckByVisionShowId : IUseSkillCheckBase
	{
		// Token: 0x06006820 RID: 26656 RVA: 0x000F8D74 File Offset: 0x000F6F74
		private IUseSkillCheckByVisionShowId_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IUseSkillCheckByVisionShowId 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IUseSkillCheckByVisionShowId_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IUseSkillCheckByVisionShowId_SetValue());
			}
			return result;
		}

		// Token: 0x06006821 RID: 26657 RVA: 0x000F8DAC File Offset: 0x000F6FAC
		public static IUseSkillCheckByVisionShowId Create([Nullable(2)] IUseSkillCheckByVisionShowId instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUseSkillCheckByVisionShowId
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006822 RID: 26658 RVA: 0x000F8DBF File Offset: 0x000F6FBF
		public static IUseSkillCheckByVisionShowId CreateFromSetValue([Nullable(2)] IUseSkillCheckByVisionShowId_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IUseSkillCheckByVisionShowId
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006823 RID: 26659 RVA: 0x000F8DD2 File Offset: 0x000F6FD2
		public new IUseSkillCheckByVisionShowId_SetValue ToSetValue()
		{
			return new IUseSkillCheckByVisionShowId_SetValue
			{
				Type = this.Type,
				VisionId = this.VisionId
			};
		}

		// Token: 0x170021B6 RID: 8630
		// (get) Token: 0x06006824 RID: 26660 RVA: 0x000F8DF1 File Offset: 0x000F6FF1
		// (set) Token: 0x06006825 RID: 26661 RVA: 0x000F8E1C File Offset: 0x000F701C
		public override EUseSkillCheckType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EUseSkillCheckType.CheckSkillGenre;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170021B7 RID: 8631
		// (get) Token: 0x06006826 RID: 26662 RVA: 0x000F8E2A File Offset: 0x000F702A
		// (set) Token: 0x06006827 RID: 26663 RVA: 0x000F8E55 File Offset: 0x000F7055
		public virtual int VisionId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.VisionId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.VisionId;
			}
			set
			{
				this.GetOrCreatePoco().VisionId = value;
			}
		}

		// Token: 0x04003E65 RID: 15973
		[Nullable(2)]
		protected new IUseSkillCheckByVisionShowId FbInstance;

		// Token: 0x04003E66 RID: 15974
		[Nullable(2)]
		protected new IUseSkillCheckByVisionShowId_SetValue PocoInterface;
	}
}
