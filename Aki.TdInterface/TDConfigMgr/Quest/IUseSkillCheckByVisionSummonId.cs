using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001328 RID: 4904
	public class IUseSkillCheckByVisionSummonId : IUseSkillCheckBase
	{
		// Token: 0x06006E6B RID: 28267 RVA: 0x00106780 File Offset: 0x00104980
		private IUseSkillCheckByVisionSummonId_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IUseSkillCheckByVisionSummonId 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IUseSkillCheckByVisionSummonId_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IUseSkillCheckByVisionSummonId_SetValue());
			}
			return result;
		}

		// Token: 0x06006E6C RID: 28268 RVA: 0x001067B8 File Offset: 0x001049B8
		public static IUseSkillCheckByVisionSummonId Create([Nullable(2)] IUseSkillCheckByVisionSummonId instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUseSkillCheckByVisionSummonId
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006E6D RID: 28269 RVA: 0x001067CB File Offset: 0x001049CB
		public static IUseSkillCheckByVisionSummonId CreateFromSetValue([Nullable(2)] IUseSkillCheckByVisionSummonId_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IUseSkillCheckByVisionSummonId
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006E6E RID: 28270 RVA: 0x001067DE File Offset: 0x001049DE
		public new IUseSkillCheckByVisionSummonId_SetValue ToSetValue()
		{
			return new IUseSkillCheckByVisionSummonId_SetValue
			{
				Type = this.Type,
				VisionId = this.VisionId
			};
		}

		// Token: 0x17002379 RID: 9081
		// (get) Token: 0x06006E6F RID: 28271 RVA: 0x001067FD File Offset: 0x001049FD
		// (set) Token: 0x06006E70 RID: 28272 RVA: 0x00106828 File Offset: 0x00104A28
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

		// Token: 0x1700237A RID: 9082
		// (get) Token: 0x06006E71 RID: 28273 RVA: 0x00106836 File Offset: 0x00104A36
		// (set) Token: 0x06006E72 RID: 28274 RVA: 0x00106861 File Offset: 0x00104A61
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

		// Token: 0x040041D7 RID: 16855
		[Nullable(2)]
		protected new IUseSkillCheckByVisionSummonId FbInstance;

		// Token: 0x040041D8 RID: 16856
		[Nullable(2)]
		protected new IUseSkillCheckByVisionSummonId_SetValue PocoInterface;
	}
}
