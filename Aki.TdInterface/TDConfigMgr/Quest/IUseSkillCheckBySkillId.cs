using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011E8 RID: 4584
	[NullableContext(1)]
	[Nullable(0)]
	public class IUseSkillCheckBySkillId : IUseSkillCheckBase
	{
		// Token: 0x06006816 RID: 26646 RVA: 0x000F8C74 File Offset: 0x000F6E74
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

		// Token: 0x06006817 RID: 26647 RVA: 0x000F8CAC File Offset: 0x000F6EAC
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

		// Token: 0x06006818 RID: 26648 RVA: 0x000F8CBF File Offset: 0x000F6EBF
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

		// Token: 0x06006819 RID: 26649 RVA: 0x000F8CD2 File Offset: 0x000F6ED2
		public new IUseSkillCheckBySkillId_SetValue ToSetValue()
		{
			return new IUseSkillCheckBySkillId_SetValue
			{
				Type = this.Type,
				SkillId = this.SkillId
			};
		}

		// Token: 0x170021B4 RID: 8628
		// (get) Token: 0x0600681A RID: 26650 RVA: 0x000F8CF1 File Offset: 0x000F6EF1
		// (set) Token: 0x0600681B RID: 26651 RVA: 0x000F8D1C File Offset: 0x000F6F1C
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

		// Token: 0x170021B5 RID: 8629
		// (get) Token: 0x0600681C RID: 26652 RVA: 0x000F8D2A File Offset: 0x000F6F2A
		// (set) Token: 0x0600681D RID: 26653 RVA: 0x000F8D55 File Offset: 0x000F6F55
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

		// Token: 0x04003E61 RID: 15969
		[Nullable(2)]
		protected new IUseSkillCheckBySkillId FbInstance;

		// Token: 0x04003E62 RID: 15970
		[Nullable(2)]
		protected new IUseSkillCheckBySkillId_SetValue PocoInterface;
	}
}
