using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000451 RID: 1105
	public class IGroupAiMonsterMemberActionTagAttach
	{
		// Token: 0x0600160F RID: 5647 RVA: 0x0004529C File Offset: 0x0004349C
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

		// Token: 0x06001610 RID: 5648 RVA: 0x000452D4 File Offset: 0x000434D4
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

		// Token: 0x06001611 RID: 5649 RVA: 0x000452E7 File Offset: 0x000434E7
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

		// Token: 0x06001612 RID: 5650 RVA: 0x000452FA File Offset: 0x000434FA
		public IGroupAiMonsterMemberActionTagAttach_SetValue ToSetValue()
		{
			return new IGroupAiMonsterMemberActionTagAttach_SetValue
			{
				ActionTag = this.ActionTag,
				AttachEntityId = this.AttachEntityId
			};
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06001613 RID: 5651 RVA: 0x00045319 File Offset: 0x00043519
		// (set) Token: 0x06001614 RID: 5652 RVA: 0x00045344 File Offset: 0x00043544
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

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06001615 RID: 5653 RVA: 0x00045354 File Offset: 0x00043554
		// (set) Token: 0x06001616 RID: 5654 RVA: 0x0004538E File Offset: 0x0004358E
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

		// Token: 0x04001137 RID: 4407
		[Nullable(2)]
		protected IGroupAiMonsterMemberActionTagAttach FbInstance;

		// Token: 0x04001138 RID: 4408
		[Nullable(2)]
		protected IGroupAiMonsterMemberActionTagAttach_SetValue PocoInterface;
	}
}
