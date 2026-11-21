using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200131E RID: 4894
	public class IUseSkillCheckBase
	{
		// Token: 0x06006E3B RID: 28219 RVA: 0x001062C4 File Offset: 0x001044C4
		private IUseSkillCheckBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IUseSkillCheckBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IUseSkillCheckBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IUseSkillCheckBase_SetValue());
			}
			return result;
		}

		// Token: 0x06006E3C RID: 28220 RVA: 0x001062FC File Offset: 0x001044FC
		public static IUseSkillCheckBase Create([Nullable(2)] IUseSkillCheckBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUseSkillCheckBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006E3D RID: 28221 RVA: 0x0010630F File Offset: 0x0010450F
		public static IUseSkillCheckBase CreateFromSetValue([Nullable(2)] IUseSkillCheckBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IUseSkillCheckBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006E3E RID: 28222 RVA: 0x00106322 File Offset: 0x00104522
		public IUseSkillCheckBase_SetValue ToSetValue()
		{
			return new IUseSkillCheckBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002370 RID: 9072
		// (get) Token: 0x06006E3F RID: 28223 RVA: 0x00106335 File Offset: 0x00104535
		// (set) Token: 0x06006E40 RID: 28224 RVA: 0x00106360 File Offset: 0x00104560
		public virtual EUseSkillCheckType Type
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

		// Token: 0x040041C4 RID: 16836
		[Nullable(2)]
		protected IUseSkillCheckBase FbInstance;

		// Token: 0x040041C5 RID: 16837
		[Nullable(2)]
		protected IUseSkillCheckBase_SetValue PocoInterface;
	}
}
