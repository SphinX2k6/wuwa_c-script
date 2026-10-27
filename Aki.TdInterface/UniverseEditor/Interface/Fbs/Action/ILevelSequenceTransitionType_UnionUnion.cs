using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069F4 RID: 27124
	public class ILevelSequenceTransitionType_UnionUnion
	{
		// Token: 0x1700C93A RID: 51514
		// (get) Token: 0x0602F73D RID: 194365 RVA: 0x006767E4 File Offset: 0x006749E4
		// (set) Token: 0x0602F73E RID: 194366 RVA: 0x006767EC File Offset: 0x006749EC
		public ILevelSequenceTransitionType_Union Type { get; set; }

		// Token: 0x1700C93B RID: 51515
		// (get) Token: 0x0602F73F RID: 194367 RVA: 0x006767F5 File Offset: 0x006749F5
		// (set) Token: 0x0602F740 RID: 194368 RVA: 0x006767FD File Offset: 0x006749FD
		public object Value { get; set; }

		// Token: 0x0602F741 RID: 194369 RVA: 0x00676806 File Offset: 0x00674A06
		public ILevelSequenceTransitionType_UnionUnion()
		{
			this.Type = ILevelSequenceTransitionType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602F742 RID: 194370 RVA: 0x0067681C File Offset: 0x00674A1C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602F743 RID: 194371 RVA: 0x0067682E File Offset: 0x00674A2E
		public ILevelSequenceTransitionTypeT AsILevelSequenceTransitionType()
		{
			return this.As<ILevelSequenceTransitionTypeT>();
		}

		// Token: 0x0602F744 RID: 194372 RVA: 0x00676836 File Offset: 0x00674A36
		public static ILevelSequenceTransitionType_UnionUnion FromILevelSequenceTransitionType(ILevelSequenceTransitionTypeT _ilevelsequencetransitiontype)
		{
			return new ILevelSequenceTransitionType_UnionUnion
			{
				Type = ILevelSequenceTransitionType_Union.ILevelSequenceTransitionType,
				Value = _ilevelsequencetransitiontype
			};
		}

		// Token: 0x0602F745 RID: 194373 RVA: 0x0067684B File Offset: 0x00674A4B
		public ICameraTransitionT AsICameraTransition()
		{
			return this.As<ICameraTransitionT>();
		}

		// Token: 0x0602F746 RID: 194374 RVA: 0x00676853 File Offset: 0x00674A53
		public static ILevelSequenceTransitionType_UnionUnion FromICameraTransition(ICameraTransitionT _icameratransition)
		{
			return new ILevelSequenceTransitionType_UnionUnion
			{
				Type = ILevelSequenceTransitionType_Union.ICameraTransition,
				Value = _icameratransition
			};
		}

		// Token: 0x0602F747 RID: 194375 RVA: 0x00676868 File Offset: 0x00674A68
		public IMaskTransitionT AsIMaskTransition()
		{
			return this.As<IMaskTransitionT>();
		}

		// Token: 0x0602F748 RID: 194376 RVA: 0x00676870 File Offset: 0x00674A70
		public static ILevelSequenceTransitionType_UnionUnion FromIMaskTransition(IMaskTransitionT _imasktransition)
		{
			return new ILevelSequenceTransitionType_UnionUnion
			{
				Type = ILevelSequenceTransitionType_Union.IMaskTransition,
				Value = _imasktransition
			};
		}

		// Token: 0x0602F749 RID: 194377 RVA: 0x00676888 File Offset: 0x00674A88
		public static int Pack(FlatBufferBuilder builder, ILevelSequenceTransitionType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ILevelSequenceTransitionType_Union.ILevelSequenceTransitionType:
				return ILevelSequenceTransitionType.Pack(builder, _o.AsILevelSequenceTransitionType()).Value;
			case ILevelSequenceTransitionType_Union.ICameraTransition:
				return ICameraTransition.Pack(builder, _o.AsICameraTransition()).Value;
			case ILevelSequenceTransitionType_Union.IMaskTransition:
				return IMaskTransition.Pack(builder, _o.AsIMaskTransition()).Value;
			default:
				return 0;
			}
		}
	}
}
