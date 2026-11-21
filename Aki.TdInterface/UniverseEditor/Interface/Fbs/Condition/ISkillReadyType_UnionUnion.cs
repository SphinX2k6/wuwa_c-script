using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051C4 RID: 20932
	public class ISkillReadyType_UnionUnion
	{
		// Token: 0x170095E5 RID: 38373
		// (get) Token: 0x06020F3D RID: 134973 RVA: 0x0048E89D File Offset: 0x0048CA9D
		// (set) Token: 0x06020F3E RID: 134974 RVA: 0x0048E8A5 File Offset: 0x0048CAA5
		public ISkillReadyType_Union Type { get; set; }

		// Token: 0x170095E6 RID: 38374
		// (get) Token: 0x06020F3F RID: 134975 RVA: 0x0048E8AE File Offset: 0x0048CAAE
		// (set) Token: 0x06020F40 RID: 134976 RVA: 0x0048E8B6 File Offset: 0x0048CAB6
		public object Value { get; set; }

		// Token: 0x06020F41 RID: 134977 RVA: 0x0048E8BF File Offset: 0x0048CABF
		public ISkillReadyType_UnionUnion()
		{
			this.Type = ISkillReadyType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06020F42 RID: 134978 RVA: 0x0048E8D5 File Offset: 0x0048CAD5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06020F43 RID: 134979 RVA: 0x0048E8E7 File Offset: 0x0048CAE7
		public ISkillReadyTypeT AsISkillReadyType()
		{
			return this.As<ISkillReadyTypeT>();
		}

		// Token: 0x06020F44 RID: 134980 RVA: 0x0048E8EF File Offset: 0x0048CAEF
		public static ISkillReadyType_UnionUnion FromISkillReadyType(ISkillReadyTypeT _iskillreadytype)
		{
			return new ISkillReadyType_UnionUnion
			{
				Type = ISkillReadyType_Union.ISkillReadyType,
				Value = _iskillreadytype
			};
		}

		// Token: 0x06020F45 RID: 134981 RVA: 0x0048E904 File Offset: 0x0048CB04
		public IUltimateSkillReadyT AsIUltimateSkillReady()
		{
			return this.As<IUltimateSkillReadyT>();
		}

		// Token: 0x06020F46 RID: 134982 RVA: 0x0048E90C File Offset: 0x0048CB0C
		public static ISkillReadyType_UnionUnion FromIUltimateSkillReady(IUltimateSkillReadyT _iultimateskillready)
		{
			return new ISkillReadyType_UnionUnion
			{
				Type = ISkillReadyType_Union.IUltimateSkillReady,
				Value = _iultimateskillready
			};
		}

		// Token: 0x06020F47 RID: 134983 RVA: 0x0048E921 File Offset: 0x0048CB21
		public IESkillReadyT AsIESkillReady()
		{
			return this.As<IESkillReadyT>();
		}

		// Token: 0x06020F48 RID: 134984 RVA: 0x0048E929 File Offset: 0x0048CB29
		public static ISkillReadyType_UnionUnion FromIESkillReady(IESkillReadyT _ieskillready)
		{
			return new ISkillReadyType_UnionUnion
			{
				Type = ISkillReadyType_Union.IESkillReady,
				Value = _ieskillready
			};
		}

		// Token: 0x06020F49 RID: 134985 RVA: 0x0048E93E File Offset: 0x0048CB3E
		public IVisionSkillReadyT AsIVisionSkillReady()
		{
			return this.As<IVisionSkillReadyT>();
		}

		// Token: 0x06020F4A RID: 134986 RVA: 0x0048E946 File Offset: 0x0048CB46
		public static ISkillReadyType_UnionUnion FromIVisionSkillReady(IVisionSkillReadyT _ivisionskillready)
		{
			return new ISkillReadyType_UnionUnion
			{
				Type = ISkillReadyType_Union.IVisionSkillReady,
				Value = _ivisionskillready
			};
		}

		// Token: 0x06020F4B RID: 134987 RVA: 0x0048E95C File Offset: 0x0048CB5C
		public static int Pack(FlatBufferBuilder builder, ISkillReadyType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISkillReadyType_Union.ISkillReadyType:
				return ISkillReadyType.Pack(builder, _o.AsISkillReadyType()).Value;
			case ISkillReadyType_Union.IUltimateSkillReady:
				return IUltimateSkillReady.Pack(builder, _o.AsIUltimateSkillReady()).Value;
			case ISkillReadyType_Union.IESkillReady:
				return IESkillReady.Pack(builder, _o.AsIESkillReady()).Value;
			case ISkillReadyType_Union.IVisionSkillReady:
				return IVisionSkillReady.Pack(builder, _o.AsIVisionSkillReady()).Value;
			default:
				return 0;
			}
		}
	}
}
