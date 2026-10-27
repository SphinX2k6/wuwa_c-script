using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006288 RID: 25224
	public class ICameraLockTargetBase_UnionUnion
	{
		// Token: 0x1700BC1B RID: 48155
		// (get) Token: 0x0602B8E1 RID: 178401 RVA: 0x005FF1B1 File Offset: 0x005FD3B1
		// (set) Token: 0x0602B8E2 RID: 178402 RVA: 0x005FF1B9 File Offset: 0x005FD3B9
		public ICameraLockTargetBase_Union Type { get; set; }

		// Token: 0x1700BC1C RID: 48156
		// (get) Token: 0x0602B8E3 RID: 178403 RVA: 0x005FF1C2 File Offset: 0x005FD3C2
		// (set) Token: 0x0602B8E4 RID: 178404 RVA: 0x005FF1CA File Offset: 0x005FD3CA
		public object Value { get; set; }

		// Token: 0x0602B8E5 RID: 178405 RVA: 0x005FF1D3 File Offset: 0x005FD3D3
		public ICameraLockTargetBase_UnionUnion()
		{
			this.Type = ICameraLockTargetBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602B8E6 RID: 178406 RVA: 0x005FF1E9 File Offset: 0x005FD3E9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B8E7 RID: 178407 RVA: 0x005FF1FB File Offset: 0x005FD3FB
		public ICameraLockTargetBaseT AsICameraLockTargetBase()
		{
			return this.As<ICameraLockTargetBaseT>();
		}

		// Token: 0x0602B8E8 RID: 178408 RVA: 0x005FF203 File Offset: 0x005FD403
		public static ICameraLockTargetBase_UnionUnion FromICameraLockTargetBase(ICameraLockTargetBaseT _icameralocktargetbase)
		{
			return new ICameraLockTargetBase_UnionUnion
			{
				Type = ICameraLockTargetBase_Union.ICameraLockTargetBase,
				Value = _icameralocktargetbase
			};
		}

		// Token: 0x0602B8E9 RID: 178409 RVA: 0x005FF218 File Offset: 0x005FD418
		public ICameraLockTargetPositionT AsICameraLockTargetPosition()
		{
			return this.As<ICameraLockTargetPositionT>();
		}

		// Token: 0x0602B8EA RID: 178410 RVA: 0x005FF220 File Offset: 0x005FD420
		public static ICameraLockTargetBase_UnionUnion FromICameraLockTargetPosition(ICameraLockTargetPositionT _icameralocktargetposition)
		{
			return new ICameraLockTargetBase_UnionUnion
			{
				Type = ICameraLockTargetBase_Union.ICameraLockTargetPosition,
				Value = _icameralocktargetposition
			};
		}

		// Token: 0x0602B8EB RID: 178411 RVA: 0x005FF238 File Offset: 0x005FD438
		public static int Pack(FlatBufferBuilder builder, ICameraLockTargetBase_UnionUnion _o)
		{
			ICameraLockTargetBase_Union type = _o.Type;
			if (type == ICameraLockTargetBase_Union.ICameraLockTargetBase)
			{
				return ICameraLockTargetBase.Pack(builder, _o.AsICameraLockTargetBase()).Value;
			}
			if (type != ICameraLockTargetBase_Union.ICameraLockTargetPosition)
			{
				return 0;
			}
			return ICameraLockTargetPosition.Pack(builder, _o.AsICameraLockTargetPosition()).Value;
		}
	}
}
