using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003F8 RID: 1016
	[NullableContext(1)]
	[Nullable(0)]
	public class IGroupAiMonsterMemberActionTagAttach
	{
		// Token: 0x06001475 RID: 5237 RVA: 0x00041554 File Offset: 0x0003F754
		private IGroupAiMonsterMemberActionTagAttach_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGroupAiMonsterMemberActionTagAttach 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGroupAiMonsterMemberActionTagAttach_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGroupAiMonsterMemberActionTagAttach_SetValue());
			}
			return result;
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x0004158C File Offset: 0x0003F78C
		public static IGroupAiMonsterMemberActionTagAttach Create([Nullable(2)] IGroupAiMonsterMemberActionTagAttach instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGroupAiMonsterMemberActionTagAttach
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x0004159F File Offset: 0x0003F79F
		public static IGroupAiMonsterMemberActionTagAttach CreateFromSetValue([Nullable(2)] IGroupAiMonsterMemberActionTagAttach_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGroupAiMonsterMemberActionTagAttach
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x000415B2 File Offset: 0x0003F7B2
		public IGroupAiMonsterMemberActionTagAttach_SetValue ToSetValue()
		{
			return new IGroupAiMonsterMemberActionTagAttach_SetValue
			{
				ActionTag = this.ActionTag,
				AttachEntityId = this.AttachEntityId
			};
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06001479 RID: 5241 RVA: 0x000415D1 File Offset: 0x0003F7D1
		// (set) Token: 0x0600147A RID: 5242 RVA: 0x000415FC File Offset: 0x0003F7FC
		public virtual string ActionTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ActionTag;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ActionTag;
			}
			set
			{
				this.GetOrCreatePoco().ActionTag = value;
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x0600147B RID: 5243 RVA: 0x0004160C File Offset: 0x0003F80C
		// (set) Token: 0x0600147C RID: 5244 RVA: 0x00041646 File Offset: 0x0003F846
		public virtual int? AttachEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AttachEntityId;
				}
				IGroupAiMonsterMemberActionTagAttach_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AttachEntityId;
			}
			set
			{
				this.GetOrCreatePoco().AttachEntityId = value;
			}
		}

		// Token: 0x04001015 RID: 4117
		[Nullable(2)]
		protected IGroupAiMonsterMemberActionTagAttach FbInstance;

		// Token: 0x04001016 RID: 4118
		[Nullable(2)]
		protected IGroupAiMonsterMemberActionTagAttach_SetValue PocoInterface;
	}
}
