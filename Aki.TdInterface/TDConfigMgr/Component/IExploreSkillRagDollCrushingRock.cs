using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200035C RID: 860
	[NullableContext(1)]
	[Nullable(0)]
	public class IExploreSkillRagDollCrushingRock : IExploreSkillInteractType
	{
		// Token: 0x06001117 RID: 4375 RVA: 0x0003A5C4 File Offset: 0x000387C4
		private IExploreSkillRagDollCrushingRock_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IExploreSkillRagDollCrushingRock 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IExploreSkillRagDollCrushingRock_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IExploreSkillRagDollCrushingRock_SetValue());
			}
			return result;
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x0003A5FC File Offset: 0x000387FC
		public static IExploreSkillRagDollCrushingRock Create([Nullable(2)] IExploreSkillRagDollCrushingRock instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExploreSkillRagDollCrushingRock
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x0003A60F File Offset: 0x0003880F
		public static IExploreSkillRagDollCrushingRock CreateFromSetValue([Nullable(2)] IExploreSkillRagDollCrushingRock_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IExploreSkillRagDollCrushingRock
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x0003A622 File Offset: 0x00038822
		public new IExploreSkillRagDollCrushingRock_SetValue ToSetValue()
		{
			return new IExploreSkillRagDollCrushingRock_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x0600111B RID: 4379 RVA: 0x0003A635 File Offset: 0x00038835
		// (set) Token: 0x0600111C RID: 4380 RVA: 0x0003A660 File Offset: 0x00038860
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

		// Token: 0x04000E30 RID: 3632
		[Nullable(2)]
		protected new IExploreSkillRagDollCrushingRock FbInstance;

		// Token: 0x04000E31 RID: 3633
		[Nullable(2)]
		protected new IExploreSkillRagDollCrushingRock_SetValue PocoInterface;
	}
}
