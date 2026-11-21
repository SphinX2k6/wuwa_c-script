using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001324 RID: 4900
	public class IUseSkillCheckBySkillId : IUseSkillCheckBase
	{
		// Token: 0x06006E57 RID: 28247 RVA: 0x00106580 File Offset: 0x00104780
		private IUseSkillCheckBySkillId_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IUseSkillCheckBySkillId 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IUseSkillCheckBySkillId_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IUseSkillCheckBySkillId_SetValue());
			}
			return result;
		}

		// Token: 0x06006E58 RID: 28248 RVA: 0x001065B8 File Offset: 0x001047B8
		public static IUseSkillCheckBySkillId Create([Nullable(2)] IUseSkillCheckBySkillId instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUseSkillCheckBySkillId
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006E59 RID: 28249 RVA: 0x001065CB File Offset: 0x001047CB
		public static IUseSkillCheckBySkillId CreateFromSetValue([Nullable(2)] IUseSkillCheckBySkillId_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IUseSkillCheckBySkillId
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006E5A RID: 28250 RVA: 0x001065DE File Offset: 0x001047DE
		public new IUseSkillCheckBySkillId_SetValue ToSetValue()
		{
			return new IUseSkillCheckBySkillId_SetValue
			{
				Type = this.Type,
				SkillId = this.SkillId
			};
		}

		// Token: 0x17002375 RID: 9077
		// (get) Token: 0x06006E5B RID: 28251 RVA: 0x001065FD File Offset: 0x001047FD
		// (set) Token: 0x06006E5C RID: 28252 RVA: 0x00106628 File Offset: 0x00104828
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

		// Token: 0x17002376 RID: 9078
		// (get) Token: 0x06006E5D RID: 28253 RVA: 0x00106636 File Offset: 0x00104836
		// (set) Token: 0x06006E5E RID: 28254 RVA: 0x00106661 File Offset: 0x00104861
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

		// Token: 0x040041CF RID: 16847
		[Nullable(2)]
		protected new IUseSkillCheckBySkillId FbInstance;

		// Token: 0x040041D0 RID: 16848
		[Nullable(2)]
		protected new IUseSkillCheckBySkillId_SetValue PocoInterface;
	}
}
