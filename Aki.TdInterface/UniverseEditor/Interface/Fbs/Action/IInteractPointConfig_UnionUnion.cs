using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069A0 RID: 27040
	public class IInteractPointConfig_UnionUnion
	{
		// Token: 0x1700C89E RID: 51358
		// (get) Token: 0x0602F3EF RID: 193519 RVA: 0x0066FA19 File Offset: 0x0066DC19
		// (set) Token: 0x0602F3F0 RID: 193520 RVA: 0x0066FA21 File Offset: 0x0066DC21
		public IInteractPointConfig_Union Type { get; set; }

		// Token: 0x1700C89F RID: 51359
		// (get) Token: 0x0602F3F1 RID: 193521 RVA: 0x0066FA2A File Offset: 0x0066DC2A
		// (set) Token: 0x0602F3F2 RID: 193522 RVA: 0x0066FA32 File Offset: 0x0066DC32
		public object Value { get; set; }

		// Token: 0x0602F3F3 RID: 193523 RVA: 0x0066FA3B File Offset: 0x0066DC3B
		public IInteractPointConfig_UnionUnion()
		{
			this.Type = IInteractPointConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602F3F4 RID: 193524 RVA: 0x0066FA51 File Offset: 0x0066DC51
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602F3F5 RID: 193525 RVA: 0x0066FA63 File Offset: 0x0066DC63
		public IInteractPointConfigT AsIInteractPointConfig()
		{
			return this.As<IInteractPointConfigT>();
		}

		// Token: 0x0602F3F6 RID: 193526 RVA: 0x0066FA6B File Offset: 0x0066DC6B
		public static IInteractPointConfig_UnionUnion FromIInteractPointConfig(IInteractPointConfigT _iinteractpointconfig)
		{
			return new IInteractPointConfig_UnionUnion
			{
				Type = IInteractPointConfig_Union.IInteractPointConfig,
				Value = _iinteractpointconfig
			};
		}

		// Token: 0x0602F3F7 RID: 193527 RVA: 0x0066FA80 File Offset: 0x0066DC80
		public ISequenceUnlockPointsT AsISequenceUnlockPoints()
		{
			return this.As<ISequenceUnlockPointsT>();
		}

		// Token: 0x0602F3F8 RID: 193528 RVA: 0x0066FA88 File Offset: 0x0066DC88
		public static IInteractPointConfig_UnionUnion FromISequenceUnlockPoints(ISequenceUnlockPointsT _isequenceunlockpoints)
		{
			return new IInteractPointConfig_UnionUnion
			{
				Type = IInteractPointConfig_Union.ISequenceUnlockPoints,
				Value = _isequenceunlockpoints
			};
		}

		// Token: 0x0602F3F9 RID: 193529 RVA: 0x0066FAA0 File Offset: 0x0066DCA0
		public static int Pack(FlatBufferBuilder builder, IInteractPointConfig_UnionUnion _o)
		{
			IInteractPointConfig_Union type = _o.Type;
			if (type == IInteractPointConfig_Union.IInteractPointConfig)
			{
				return IInteractPointConfig.Pack(builder, _o.AsIInteractPointConfig()).Value;
			}
			if (type != IInteractPointConfig_Union.ISequenceUnlockPoints)
			{
				return 0;
			}
			return ISequenceUnlockPoints.Pack(builder, _o.AsISequenceUnlockPoints()).Value;
		}
	}
}
