using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DE8 RID: 7656
	[NullableContext(1)]
	[Nullable(0)]
	public class ISceneNewItemSplineStopTarget : INewSplineStopTarget
	{
		// Token: 0x0600A3E1 RID: 41953 RVA: 0x00173EB0 File Offset: 0x001720B0
		private ISceneNewItemSplineStopTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneNewItemSplineStopTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneNewItemSplineStopTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneNewItemSplineStopTarget_SetValue());
			}
			return result;
		}

		// Token: 0x0600A3E2 RID: 41954 RVA: 0x00173EE8 File Offset: 0x001720E8
		public static ISceneNewItemSplineStopTarget Create([Nullable(2)] ISceneNewItemSplineStopTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneNewItemSplineStopTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A3E3 RID: 41955 RVA: 0x00173EFB File Offset: 0x001720FB
		public static ISceneNewItemSplineStopTarget CreateFromSetValue([Nullable(2)] ISceneNewItemSplineStopTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneNewItemSplineStopTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A3E4 RID: 41956 RVA: 0x00173F0E File Offset: 0x0017210E
		public new ISceneNewItemSplineStopTarget_SetValue ToSetValue()
		{
			return new ISceneNewItemSplineStopTarget_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId
			};
		}

		// Token: 0x1700326B RID: 12907
		// (get) Token: 0x0600A3E5 RID: 41957 RVA: 0x00173F2D File Offset: 0x0017212D
		// (set) Token: 0x0600A3E6 RID: 41958 RVA: 0x00173F58 File Offset: 0x00172158
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

		// Token: 0x1700326C RID: 12908
		// (get) Token: 0x0600A3E7 RID: 41959 RVA: 0x00173F66 File Offset: 0x00172166
		// (set) Token: 0x0600A3E8 RID: 41960 RVA: 0x00173F91 File Offset: 0x00172191
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x04006234 RID: 25140
		[Nullable(2)]
		protected new ISceneNewItemSplineStopTarget FbInstance;

		// Token: 0x04006235 RID: 25141
		[Nullable(2)]
		protected new ISceneNewItemSplineStopTarget_SetValue PocoInterface;
	}
}
