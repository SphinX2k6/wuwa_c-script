using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E6B RID: 32363
	public class TChangeElementalBoxStateTargetUnion
	{
		// Token: 0x1700F20F RID: 61967
		// (get) Token: 0x0603A73D RID: 239421 RVA: 0x007DE960 File Offset: 0x007DCB60
		// (set) Token: 0x0603A73E RID: 239422 RVA: 0x007DE968 File Offset: 0x007DCB68
		public TChangeElementalBoxStateTarget Type { get; set; }

		// Token: 0x1700F210 RID: 61968
		// (get) Token: 0x0603A73F RID: 239423 RVA: 0x007DE971 File Offset: 0x007DCB71
		// (set) Token: 0x0603A740 RID: 239424 RVA: 0x007DE979 File Offset: 0x007DCB79
		public object Value { get; set; }

		// Token: 0x0603A741 RID: 239425 RVA: 0x007DE982 File Offset: 0x007DCB82
		public TChangeElementalBoxStateTargetUnion()
		{
			this.Type = TChangeElementalBoxStateTarget.NONE;
			this.Value = null;
		}

		// Token: 0x0603A742 RID: 239426 RVA: 0x007DE998 File Offset: 0x007DCB98
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A743 RID: 239427 RVA: 0x007DE9AA File Offset: 0x007DCBAA
		public IChangeElementalBoxStatePlayerTargetT AsIChangeElementalBoxStatePlayerTarget()
		{
			return this.As<IChangeElementalBoxStatePlayerTargetT>();
		}

		// Token: 0x0603A744 RID: 239428 RVA: 0x007DE9B2 File Offset: 0x007DCBB2
		public static TChangeElementalBoxStateTargetUnion FromIChangeElementalBoxStatePlayerTarget(IChangeElementalBoxStatePlayerTargetT _ichangeelementalboxstateplayertarget)
		{
			return new TChangeElementalBoxStateTargetUnion
			{
				Type = TChangeElementalBoxStateTarget.IChangeElementalBoxStatePlayerTarget,
				Value = _ichangeelementalboxstateplayertarget
			};
		}

		// Token: 0x0603A745 RID: 239429 RVA: 0x007DE9C7 File Offset: 0x007DCBC7
		public IChangeElementalBoxStateTargetBoxIdT AsIChangeElementalBoxStateTargetBoxId()
		{
			return this.As<IChangeElementalBoxStateTargetBoxIdT>();
		}

		// Token: 0x0603A746 RID: 239430 RVA: 0x007DE9CF File Offset: 0x007DCBCF
		public static TChangeElementalBoxStateTargetUnion FromIChangeElementalBoxStateTargetBoxId(IChangeElementalBoxStateTargetBoxIdT _ichangeelementalboxstatetargetboxid)
		{
			return new TChangeElementalBoxStateTargetUnion
			{
				Type = TChangeElementalBoxStateTarget.IChangeElementalBoxStateTargetBoxId,
				Value = _ichangeelementalboxstatetargetboxid
			};
		}

		// Token: 0x0603A747 RID: 239431 RVA: 0x007DE9E4 File Offset: 0x007DCBE4
		public static int Pack(FlatBufferBuilder builder, TChangeElementalBoxStateTargetUnion _o)
		{
			TChangeElementalBoxStateTarget type = _o.Type;
			if (type == TChangeElementalBoxStateTarget.IChangeElementalBoxStatePlayerTarget)
			{
				return IChangeElementalBoxStatePlayerTarget.Pack(builder, _o.AsIChangeElementalBoxStatePlayerTarget()).Value;
			}
			if (type != TChangeElementalBoxStateTarget.IChangeElementalBoxStateTargetBoxId)
			{
				return 0;
			}
			return IChangeElementalBoxStateTargetBoxId.Pack(builder, _o.AsIChangeElementalBoxStateTargetBoxId()).Value;
		}
	}
}
