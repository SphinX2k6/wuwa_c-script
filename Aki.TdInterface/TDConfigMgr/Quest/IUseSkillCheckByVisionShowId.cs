using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001326 RID: 4902
	public class IUseSkillCheckByVisionShowId : IUseSkillCheckBase
	{
		// Token: 0x06006E61 RID: 28257 RVA: 0x00106680 File Offset: 0x00104880
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

		// Token: 0x06006E62 RID: 28258 RVA: 0x001066B8 File Offset: 0x001048B8
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

		// Token: 0x06006E63 RID: 28259 RVA: 0x001066CB File Offset: 0x001048CB
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

		// Token: 0x06006E64 RID: 28260 RVA: 0x001066DE File Offset: 0x001048DE
		public new IUseSkillCheckByVisionShowId_SetValue ToSetValue()
		{
			return new IUseSkillCheckByVisionShowId_SetValue
			{
				Type = this.Type,
				VisionId = this.VisionId
			};
		}

		// Token: 0x17002377 RID: 9079
		// (get) Token: 0x06006E65 RID: 28261 RVA: 0x001066FD File Offset: 0x001048FD
		// (set) Token: 0x06006E66 RID: 28262 RVA: 0x00106728 File Offset: 0x00104928
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

		// Token: 0x17002378 RID: 9080
		// (get) Token: 0x06006E67 RID: 28263 RVA: 0x00106736 File Offset: 0x00104936
		// (set) Token: 0x06006E68 RID: 28264 RVA: 0x00106761 File Offset: 0x00104961
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

		// Token: 0x040041D3 RID: 16851
		[Nullable(2)]
		protected new IUseSkillCheckByVisionShowId FbInstance;

		// Token: 0x040041D4 RID: 16852
		[Nullable(2)]
		protected new IUseSkillCheckByVisionShowId_SetValue PocoInterface;
	}
}
