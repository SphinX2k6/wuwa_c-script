using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011E2 RID: 4578
	[NullableContext(1)]
	[Nullable(0)]
	public class IUseSkillCheckBase
	{
		// Token: 0x060067FA RID: 26618 RVA: 0x000F89B8 File Offset: 0x000F6BB8
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

		// Token: 0x060067FB RID: 26619 RVA: 0x000F89F0 File Offset: 0x000F6BF0
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

		// Token: 0x060067FC RID: 26620 RVA: 0x000F8A03 File Offset: 0x000F6C03
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

		// Token: 0x060067FD RID: 26621 RVA: 0x000F8A16 File Offset: 0x000F6C16
		public IUseSkillCheckBase_SetValue ToSetValue()
		{
			return new IUseSkillCheckBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170021AF RID: 8623
		// (get) Token: 0x060067FE RID: 26622 RVA: 0x000F8A29 File Offset: 0x000F6C29
		// (set) Token: 0x060067FF RID: 26623 RVA: 0x000F8A54 File Offset: 0x000F6C54
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

		// Token: 0x04003E56 RID: 15958
		[Nullable(2)]
		protected IUseSkillCheckBase FbInstance;

		// Token: 0x04003E57 RID: 15959
		[Nullable(2)]
		protected IUseSkillCheckBase_SetValue PocoInterface;
	}
}
