using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011EC RID: 4588
	[NullableContext(1)]
	[Nullable(0)]
	public class IUseSkillCheckByVisionSummonId : IUseSkillCheckBase
	{
		// Token: 0x0600682A RID: 26666 RVA: 0x000F8E74 File Offset: 0x000F7074
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

		// Token: 0x0600682B RID: 26667 RVA: 0x000F8EAC File Offset: 0x000F70AC
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

		// Token: 0x0600682C RID: 26668 RVA: 0x000F8EBF File Offset: 0x000F70BF
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

		// Token: 0x0600682D RID: 26669 RVA: 0x000F8ED2 File Offset: 0x000F70D2
		public new IUseSkillCheckByVisionSummonId_SetValue ToSetValue()
		{
			return new IUseSkillCheckByVisionSummonId_SetValue
			{
				Type = this.Type,
				VisionId = this.VisionId
			};
		}

		// Token: 0x170021B8 RID: 8632
		// (get) Token: 0x0600682E RID: 26670 RVA: 0x000F8EF1 File Offset: 0x000F70F1
		// (set) Token: 0x0600682F RID: 26671 RVA: 0x000F8F1C File Offset: 0x000F711C
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

		// Token: 0x170021B9 RID: 8633
		// (get) Token: 0x06006830 RID: 26672 RVA: 0x000F8F2A File Offset: 0x000F712A
		// (set) Token: 0x06006831 RID: 26673 RVA: 0x000F8F55 File Offset: 0x000F7155
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

		// Token: 0x04003E69 RID: 15977
		[Nullable(2)]
		protected new IUseSkillCheckByVisionSummonId FbInstance;

		// Token: 0x04003E6A RID: 15978
		[Nullable(2)]
		protected new IUseSkillCheckByVisionSummonId_SetValue PocoInterface;
	}
}
