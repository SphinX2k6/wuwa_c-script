using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006452 RID: 25682
	public class ICollectibleMarkerType_UnionUnion
	{
		// Token: 0x1700BF2A RID: 48938
		// (get) Token: 0x0602C71C RID: 182044 RVA: 0x00618A1D File Offset: 0x00616C1D
		// (set) Token: 0x0602C71D RID: 182045 RVA: 0x00618A25 File Offset: 0x00616C25
		public ICollectibleMarkerType_Union Type { get; set; }

		// Token: 0x1700BF2B RID: 48939
		// (get) Token: 0x0602C71E RID: 182046 RVA: 0x00618A2E File Offset: 0x00616C2E
		// (set) Token: 0x0602C71F RID: 182047 RVA: 0x00618A36 File Offset: 0x00616C36
		public object Value { get; set; }

		// Token: 0x0602C720 RID: 182048 RVA: 0x00618A3F File Offset: 0x00616C3F
		public ICollectibleMarkerType_UnionUnion()
		{
			this.Type = ICollectibleMarkerType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602C721 RID: 182049 RVA: 0x00618A55 File Offset: 0x00616C55
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602C722 RID: 182050 RVA: 0x00618A67 File Offset: 0x00616C67
		public ICollectibleMarkerTypeT AsICollectibleMarkerType()
		{
			return this.As<ICollectibleMarkerTypeT>();
		}

		// Token: 0x0602C723 RID: 182051 RVA: 0x00618A6F File Offset: 0x00616C6F
		public static ICollectibleMarkerType_UnionUnion FromICollectibleMarkerType(ICollectibleMarkerTypeT _icollectiblemarkertype)
		{
			return new ICollectibleMarkerType_UnionUnion
			{
				Type = ICollectibleMarkerType_Union.ICollectibleMarkerType,
				Value = _icollectiblemarkertype
			};
		}

		// Token: 0x0602C724 RID: 182052 RVA: 0x00618A84 File Offset: 0x00616C84
		public IPlaceholderCollectibleMarkerTypeT AsIPlaceholderCollectibleMarkerType()
		{
			return this.As<IPlaceholderCollectibleMarkerTypeT>();
		}

		// Token: 0x0602C725 RID: 182053 RVA: 0x00618A8C File Offset: 0x00616C8C
		public static ICollectibleMarkerType_UnionUnion FromIPlaceholderCollectibleMarkerType(IPlaceholderCollectibleMarkerTypeT _iplaceholdercollectiblemarkertype)
		{
			return new ICollectibleMarkerType_UnionUnion
			{
				Type = ICollectibleMarkerType_Union.IPlaceholderCollectibleMarkerType,
				Value = _iplaceholdercollectiblemarkertype
			};
		}

		// Token: 0x0602C726 RID: 182054 RVA: 0x00618AA4 File Offset: 0x00616CA4
		public static int Pack(FlatBufferBuilder builder, ICollectibleMarkerType_UnionUnion _o)
		{
			ICollectibleMarkerType_Union type = _o.Type;
			if (type == ICollectibleMarkerType_Union.ICollectibleMarkerType)
			{
				return ICollectibleMarkerType.Pack(builder, _o.AsICollectibleMarkerType()).Value;
			}
			if (type != ICollectibleMarkerType_Union.IPlaceholderCollectibleMarkerType)
			{
				return 0;
			}
			return IPlaceholderCollectibleMarkerType.Pack(builder, _o.AsIPlaceholderCollectibleMarkerType()).Value;
		}
	}
}
