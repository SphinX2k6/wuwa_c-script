using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073C2 RID: 29634
	public class IOverrideLookAtType_UnionUnion
	{
		// Token: 0x1700D9B2 RID: 55730
		// (get) Token: 0x06033D54 RID: 212308 RVA: 0x006FDBFD File Offset: 0x006FBDFD
		// (set) Token: 0x06033D55 RID: 212309 RVA: 0x006FDC05 File Offset: 0x006FBE05
		public IOverrideLookAtType_Union Type { get; set; }

		// Token: 0x1700D9B3 RID: 55731
		// (get) Token: 0x06033D56 RID: 212310 RVA: 0x006FDC0E File Offset: 0x006FBE0E
		// (set) Token: 0x06033D57 RID: 212311 RVA: 0x006FDC16 File Offset: 0x006FBE16
		public object Value { get; set; }

		// Token: 0x06033D58 RID: 212312 RVA: 0x006FDC1F File Offset: 0x006FBE1F
		public IOverrideLookAtType_UnionUnion()
		{
			this.Type = IOverrideLookAtType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06033D59 RID: 212313 RVA: 0x006FDC35 File Offset: 0x006FBE35
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06033D5A RID: 212314 RVA: 0x006FDC47 File Offset: 0x006FBE47
		public IOverrideLookAtTypeT AsIOverrideLookAtType()
		{
			return this.As<IOverrideLookAtTypeT>();
		}

		// Token: 0x06033D5B RID: 212315 RVA: 0x006FDC4F File Offset: 0x006FBE4F
		public static IOverrideLookAtType_UnionUnion FromIOverrideLookAtType(IOverrideLookAtTypeT _ioverridelookattype)
		{
			return new IOverrideLookAtType_UnionUnion
			{
				Type = IOverrideLookAtType_Union.IOverrideLookAtType,
				Value = _ioverridelookattype
			};
		}

		// Token: 0x06033D5C RID: 212316 RVA: 0x006FDC64 File Offset: 0x006FBE64
		public ICheckFlowLookAtT AsICheckFlowLookAt()
		{
			return this.As<ICheckFlowLookAtT>();
		}

		// Token: 0x06033D5D RID: 212317 RVA: 0x006FDC6C File Offset: 0x006FBE6C
		public static IOverrideLookAtType_UnionUnion FromICheckFlowLookAt(ICheckFlowLookAtT _icheckflowlookat)
		{
			return new IOverrideLookAtType_UnionUnion
			{
				Type = IOverrideLookAtType_Union.ICheckFlowLookAt,
				Value = _icheckflowlookat
			};
		}

		// Token: 0x06033D5E RID: 212318 RVA: 0x006FDC84 File Offset: 0x006FBE84
		public static int Pack(FlatBufferBuilder builder, IOverrideLookAtType_UnionUnion _o)
		{
			IOverrideLookAtType_Union type = _o.Type;
			if (type == IOverrideLookAtType_Union.IOverrideLookAtType)
			{
				return IOverrideLookAtType.Pack(builder, _o.AsIOverrideLookAtType()).Value;
			}
			if (type != IOverrideLookAtType_Union.ICheckFlowLookAt)
			{
				return 0;
			}
			return ICheckFlowLookAt.Pack(builder, _o.AsICheckFlowLookAt()).Value;
		}
	}
}
