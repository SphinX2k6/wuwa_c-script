using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003A5 RID: 933
	public class IExploreSkillRagDollCrushingRock : IExploreSkillInteractType
	{
		// Token: 0x0600125B RID: 4699 RVA: 0x0003D8A8 File Offset: 0x0003BAA8
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

		// Token: 0x0600125C RID: 4700 RVA: 0x0003D8E0 File Offset: 0x0003BAE0
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

		// Token: 0x0600125D RID: 4701 RVA: 0x0003D8F3 File Offset: 0x0003BAF3
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

		// Token: 0x0600125E RID: 4702 RVA: 0x0003D906 File Offset: 0x0003BB06
		public new IExploreSkillRagDollCrushingRock_SetValue ToSetValue()
		{
			return new IExploreSkillRagDollCrushingRock_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x0600125F RID: 4703 RVA: 0x0003D919 File Offset: 0x0003BB19
		// (set) Token: 0x06001260 RID: 4704 RVA: 0x0003D944 File Offset: 0x0003BB44
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

		// Token: 0x04000F27 RID: 3879
		[Nullable(2)]
		protected new IExploreSkillRagDollCrushingRock FbInstance;

		// Token: 0x04000F28 RID: 3880
		[Nullable(2)]
		protected new IExploreSkillRagDollCrushingRock_SetValue PocoInterface;
	}
}
