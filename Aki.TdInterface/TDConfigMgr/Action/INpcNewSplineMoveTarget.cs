using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C78 RID: 7288
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcNewSplineMoveTarget : INewSplineMoveTarget
	{
		// Token: 0x06009C47 RID: 40007 RVA: 0x001667B0 File Offset: 0x001649B0
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

		// Token: 0x06009C48 RID: 40008 RVA: 0x001667E8 File Offset: 0x001649E8
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

		// Token: 0x06009C49 RID: 40009 RVA: 0x001667FB File Offset: 0x001649FB
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

		// Token: 0x06009C4A RID: 40010 RVA: 0x0016680E File Offset: 0x00164A0E
		public new INpcNewSplineMoveTarget_SetValue ToSetValue()
		{
			return new INpcNewSplineMoveTarget_SetValue
			{
				Type = this.Type,
				NpcId = this.NpcId
			};
		}

		// Token: 0x170030C6 RID: 12486
		// (get) Token: 0x06009C4B RID: 40011 RVA: 0x0016682D File Offset: 0x00164A2D
		// (set) Token: 0x06009C4C RID: 40012 RVA: 0x00166858 File Offset: 0x00164A58
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

		// Token: 0x170030C7 RID: 12487
		// (get) Token: 0x06009C4D RID: 40013 RVA: 0x00166866 File Offset: 0x00164A66
		// (set) Token: 0x06009C4E RID: 40014 RVA: 0x00166891 File Offset: 0x00164A91
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

		// Token: 0x04005EC9 RID: 24265
		[Nullable(2)]
		protected new INpcNewSplineMoveTarget FbInstance;

		// Token: 0x04005ECA RID: 24266
		[Nullable(2)]
		protected new INpcNewSplineMoveTarget_SetValue PocoInterface;
	}
}
