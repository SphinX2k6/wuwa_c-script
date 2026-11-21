using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068F9 RID: 26873
	public class ICameraLockTargetBase_UnionUnion
	{
		// Token: 0x1700C5A3 RID: 50595
		// (get) Token: 0x0602E042 RID: 188482 RVA: 0x00649FB9 File Offset: 0x006481B9
		// (set) Token: 0x0602E043 RID: 188483 RVA: 0x00649FC1 File Offset: 0x006481C1
		public ICameraLockTargetBase_Union Type { get; set; }

		// Token: 0x1700C5A4 RID: 50596
		// (get) Token: 0x0602E044 RID: 188484 RVA: 0x00649FCA File Offset: 0x006481CA
		// (set) Token: 0x0602E045 RID: 188485 RVA: 0x00649FD2 File Offset: 0x006481D2
		public object Value { get; set; }

		// Token: 0x0602E046 RID: 188486 RVA: 0x00649FDB File Offset: 0x006481DB
		public ICameraLockTargetBase_UnionUnion()
		{
			this.Type = ICameraLockTargetBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602E047 RID: 188487 RVA: 0x00649FF1 File Offset: 0x006481F1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602E048 RID: 188488 RVA: 0x0064A003 File Offset: 0x00648203
		public ICameraLockTargetBaseT AsICameraLockTargetBase()
		{
			return this.As<ICameraLockTargetBaseT>();
		}

		// Token: 0x0602E049 RID: 188489 RVA: 0x0064A00B File Offset: 0x0064820B
		public static ICameraLockTargetBase_UnionUnion FromICameraLockTargetBase(ICameraLockTargetBaseT _icameralocktargetbase)
		{
			return new ICameraLockTargetBase_UnionUnion
			{
				Type = ICameraLockTargetBase_Union.ICameraLockTargetBase,
				Value = _icameralocktargetbase
			};
		}

		// Token: 0x0602E04A RID: 188490 RVA: 0x0064A020 File Offset: 0x00648220
		public ICameraLockTargetPositionT AsICameraLockTargetPosition()
		{
			return this.As<ICameraLockTargetPositionT>();
		}

		// Token: 0x0602E04B RID: 188491 RVA: 0x0064A028 File Offset: 0x00648228
		public static ICameraLockTargetBase_UnionUnion FromICameraLockTargetPosition(ICameraLockTargetPositionT _icameralocktargetposition)
		{
			return new ICameraLockTargetBase_UnionUnion
			{
				Type = ICameraLockTargetBase_Union.ICameraLockTargetPosition,
				Value = _icameralocktargetposition
			};
		}

		// Token: 0x0602E04C RID: 188492 RVA: 0x0064A040 File Offset: 0x00648240
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
