using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200035E RID: 862
	[NullableContext(1)]
	[Nullable(0)]
	public class IExploreSkillRagDollDestroySolidRock : IExploreSkillInteractType
	{
		// Token: 0x0600111F RID: 4383 RVA: 0x0003A680 File Offset: 0x00038880
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

		// Token: 0x06001120 RID: 4384 RVA: 0x0003A6B8 File Offset: 0x000388B8
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

		// Token: 0x06001121 RID: 4385 RVA: 0x0003A6CB File Offset: 0x000388CB
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

		// Token: 0x06001122 RID: 4386 RVA: 0x0003A6DE File Offset: 0x000388DE
		public new IExploreSkillRagDollDestroySolidRock_SetValue ToSetValue()
		{
			return new IExploreSkillRagDollDestroySolidRock_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06001123 RID: 4387 RVA: 0x0003A6F1 File Offset: 0x000388F1
		// (set) Token: 0x06001124 RID: 4388 RVA: 0x0003A71C File Offset: 0x0003891C
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

		// Token: 0x04000E33 RID: 3635
		[Nullable(2)]
		protected new IExploreSkillRagDollDestroySolidRock FbInstance;

		// Token: 0x04000E34 RID: 3636
		[Nullable(2)]
		protected new IExploreSkillRagDollDestroySolidRock_SetValue PocoInterface;
	}
}
