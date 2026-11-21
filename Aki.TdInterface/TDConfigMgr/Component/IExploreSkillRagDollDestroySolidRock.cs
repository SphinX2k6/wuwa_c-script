using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003A7 RID: 935
	public class IExploreSkillRagDollDestroySolidRock : IExploreSkillInteractType
	{
		// Token: 0x06001263 RID: 4707 RVA: 0x0003D964 File Offset: 0x0003BB64
		private IExploreSkillRagDollDestroySolidRock_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IExploreSkillRagDollDestroySolidRock 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IExploreSkillRagDollDestroySolidRock_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IExploreSkillRagDollDestroySolidRock_SetValue());
			}
			return result;
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x0003D99C File Offset: 0x0003BB9C
		public static IExploreSkillRagDollDestroySolidRock Create([Nullable(2)] IExploreSkillRagDollDestroySolidRock instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExploreSkillRagDollDestroySolidRock
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x0003D9AF File Offset: 0x0003BBAF
		public static IExploreSkillRagDollDestroySolidRock CreateFromSetValue([Nullable(2)] IExploreSkillRagDollDestroySolidRock_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IExploreSkillRagDollDestroySolidRock
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x0003D9C2 File Offset: 0x0003BBC2
		public new IExploreSkillRagDollDestroySolidRock_SetValue ToSetValue()
		{
			return new IExploreSkillRagDollDestroySolidRock_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06001267 RID: 4711 RVA: 0x0003D9D5 File Offset: 0x0003BBD5
		// (set) Token: 0x06001268 RID: 4712 RVA: 0x0003DA00 File Offset: 0x0003BC00
		public override EExploreSkillInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EExploreSkillInteractType.PullGiant;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000F2A RID: 3882
		[Nullable(2)]
		protected new IExploreSkillRagDollDestroySolidRock FbInstance;

		// Token: 0x04000F2B RID: 3883
		[Nullable(2)]
		protected new IExploreSkillRagDollDestroySolidRock_SetValue PocoInterface;
	}
}
