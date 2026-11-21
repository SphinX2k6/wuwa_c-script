using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E7D RID: 7805
	public class INpcNewSplineMoveTarget : INewSplineMoveTarget
	{
		// Token: 0x0600A5E1 RID: 42465 RVA: 0x0017A1A4 File Offset: 0x001783A4
		private INpcNewSplineMoveTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcNewSplineMoveTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcNewSplineMoveTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcNewSplineMoveTarget_SetValue());
			}
			return result;
		}

		// Token: 0x0600A5E2 RID: 42466 RVA: 0x0017A1DC File Offset: 0x001783DC
		public static INpcNewSplineMoveTarget Create([Nullable(2)] INpcNewSplineMoveTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcNewSplineMoveTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A5E3 RID: 42467 RVA: 0x0017A1EF File Offset: 0x001783EF
		public static INpcNewSplineMoveTarget CreateFromSetValue([Nullable(2)] INpcNewSplineMoveTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcNewSplineMoveTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A5E4 RID: 42468 RVA: 0x0017A202 File Offset: 0x00178402
		public new INpcNewSplineMoveTarget_SetValue ToSetValue()
		{
			return new INpcNewSplineMoveTarget_SetValue
			{
				Type = this.Type,
				NpcId = this.NpcId
			};
		}

		// Token: 0x17003343 RID: 13123
		// (get) Token: 0x0600A5E5 RID: 42469 RVA: 0x0017A221 File Offset: 0x00178421
		// (set) Token: 0x0600A5E6 RID: 42470 RVA: 0x0017A24C File Offset: 0x0017844C
		public override ENewSplineMoveTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENewSplineMoveTargetType.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003344 RID: 13124
		// (get) Token: 0x0600A5E7 RID: 42471 RVA: 0x0017A25A File Offset: 0x0017845A
		// (set) Token: 0x0600A5E8 RID: 42472 RVA: 0x0017A285 File Offset: 0x00178485
		public virtual int NpcId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.NpcId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.NpcId;
			}
			set
			{
				this.GetOrCreatePoco().NpcId = value;
			}
		}

		// Token: 0x0400641C RID: 25628
		[Nullable(2)]
		protected new INpcNewSplineMoveTarget FbInstance;

		// Token: 0x0400641D RID: 25629
		[Nullable(2)]
		protected new INpcNewSplineMoveTarget_SetValue PocoInterface;
	}
}
