using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070A4 RID: 28836
	public class ILevelSequenceTransitionType_UnionUnion
	{
		// Token: 0x1700D33A RID: 54074
		// (get) Token: 0x060320FD RID: 205053 RVA: 0x006C6B3C File Offset: 0x006C4D3C
		// (set) Token: 0x060320FE RID: 205054 RVA: 0x006C6B44 File Offset: 0x006C4D44
		public ILevelSequenceTransitionType_Union Type { get; set; }

		// Token: 0x1700D33B RID: 54075
		// (get) Token: 0x060320FF RID: 205055 RVA: 0x006C6B4D File Offset: 0x006C4D4D
		// (set) Token: 0x06032100 RID: 205056 RVA: 0x006C6B55 File Offset: 0x006C4D55
		public object Value { get; set; }

		// Token: 0x06032101 RID: 205057 RVA: 0x006C6B5E File Offset: 0x006C4D5E
		public ILevelSequenceTransitionType_UnionUnion()
		{
			this.Type = ILevelSequenceTransitionType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06032102 RID: 205058 RVA: 0x006C6B74 File Offset: 0x006C4D74
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06032103 RID: 205059 RVA: 0x006C6B86 File Offset: 0x006C4D86
		public ILevelSequenceTransitionTypeT AsILevelSequenceTransitionType()
		{
			return this.As<ILevelSequenceTransitionTypeT>();
		}

		// Token: 0x06032104 RID: 205060 RVA: 0x006C6B8E File Offset: 0x006C4D8E
		public static ILevelSequenceTransitionType_UnionUnion FromILevelSequenceTransitionType(ILevelSequenceTransitionTypeT _ilevelsequencetransitiontype)
		{
			return new ILevelSequenceTransitionType_UnionUnion
			{
				Type = ILevelSequenceTransitionType_Union.ILevelSequenceTransitionType,
				Value = _ilevelsequencetransitiontype
			};
		}

		// Token: 0x06032105 RID: 205061 RVA: 0x006C6BA3 File Offset: 0x006C4DA3
		public ICameraTransitionT AsICameraTransition()
		{
			return this.As<ICameraTransitionT>();
		}

		// Token: 0x06032106 RID: 205062 RVA: 0x006C6BAB File Offset: 0x006C4DAB
		public static ILevelSequenceTransitionType_UnionUnion FromICameraTransition(ICameraTransitionT _icameratransition)
		{
			return new ILevelSequenceTransitionType_UnionUnion
			{
				Type = ILevelSequenceTransitionType_Union.ICameraTransition,
				Value = _icameratransition
			};
		}

		// Token: 0x06032107 RID: 205063 RVA: 0x006C6BC0 File Offset: 0x006C4DC0
		public IMaskTransitionT AsIMaskTransition()
		{
			return this.As<IMaskTransitionT>();
		}

		// Token: 0x06032108 RID: 205064 RVA: 0x006C6BC8 File Offset: 0x006C4DC8
		public static ILevelSequenceTransitionType_UnionUnion FromIMaskTransition(IMaskTransitionT _imasktransition)
		{
			return new ILevelSequenceTransitionType_UnionUnion
			{
				Type = ILevelSequenceTransitionType_Union.IMaskTransition,
				Value = _imasktransition
			};
		}

		// Token: 0x06032109 RID: 205065 RVA: 0x006C6BE0 File Offset: 0x006C4DE0
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
