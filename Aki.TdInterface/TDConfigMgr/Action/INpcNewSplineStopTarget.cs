using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C7A RID: 7290
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcNewSplineStopTarget : INewSplineStopTarget
	{
		// Token: 0x06009C51 RID: 40017 RVA: 0x001668B0 File Offset: 0x00164AB0
		private INpcNewSplineStopTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcNewSplineStopTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcNewSplineStopTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcNewSplineStopTarget_SetValue());
			}
			return result;
		}

		// Token: 0x06009C52 RID: 40018 RVA: 0x001668E8 File Offset: 0x00164AE8
		public static INpcNewSplineStopTarget Create([Nullable(2)] INpcNewSplineStopTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcNewSplineStopTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009C53 RID: 40019 RVA: 0x001668FB File Offset: 0x00164AFB
		public static INpcNewSplineStopTarget CreateFromSetValue([Nullable(2)] INpcNewSplineStopTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcNewSplineStopTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009C54 RID: 40020 RVA: 0x0016690E File Offset: 0x00164B0E
		public new INpcNewSplineStopTarget_SetValue ToSetValue()
		{
			return new INpcNewSplineStopTarget_SetValue
			{
				Type = this.Type,
				NpcId = this.NpcId
			};
		}

		// Token: 0x170030C8 RID: 12488
		// (get) Token: 0x06009C55 RID: 40021 RVA: 0x0016692D File Offset: 0x00164B2D
		// (set) Token: 0x06009C56 RID: 40022 RVA: 0x00166958 File Offset: 0x00164B58
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

		// Token: 0x170030C9 RID: 12489
		// (get) Token: 0x06009C57 RID: 40023 RVA: 0x00166966 File Offset: 0x00164B66
		// (set) Token: 0x06009C58 RID: 40024 RVA: 0x00166991 File Offset: 0x00164B91
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

		// Token: 0x04005ECD RID: 24269
		[Nullable(2)]
		protected new INpcNewSplineStopTarget FbInstance;

		// Token: 0x04005ECE RID: 24270
		[Nullable(2)]
		protected new INpcNewSplineStopTarget_SetValue PocoInterface;
	}
}
