using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CA5 RID: 27813
	public class IElementalBoxTargetPosTypeBase_UnionUnion
	{
		// Token: 0x1700CBFD RID: 52221
		// (get) Token: 0x0602FEC2 RID: 196290 RVA: 0x00686091 File Offset: 0x00684291
		// (set) Token: 0x0602FEC3 RID: 196291 RVA: 0x00686099 File Offset: 0x00684299
		public IElementalBoxTargetPosTypeBase_Union Type { get; set; }

		// Token: 0x1700CBFE RID: 52222
		// (get) Token: 0x0602FEC4 RID: 196292 RVA: 0x006860A2 File Offset: 0x006842A2
		// (set) Token: 0x0602FEC5 RID: 196293 RVA: 0x006860AA File Offset: 0x006842AA
		public object Value { get; set; }

		// Token: 0x0602FEC6 RID: 196294 RVA: 0x006860B3 File Offset: 0x006842B3
		public IElementalBoxTargetPosTypeBase_UnionUnion()
		{
			this.Type = IElementalBoxTargetPosTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602FEC7 RID: 196295 RVA: 0x006860C9 File Offset: 0x006842C9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602FEC8 RID: 196296 RVA: 0x006860DB File Offset: 0x006842DB
		public IElementalBoxTargetPosTypeBaseT AsIElementalBoxTargetPosTypeBase()
		{
			return this.As<IElementalBoxTargetPosTypeBaseT>();
		}

		// Token: 0x0602FEC9 RID: 196297 RVA: 0x006860E3 File Offset: 0x006842E3
		public static IElementalBoxTargetPosTypeBase_UnionUnion FromIElementalBoxTargetPosTypeBase(IElementalBoxTargetPosTypeBaseT _ielementalboxtargetpostypebase)
		{
			return new IElementalBoxTargetPosTypeBase_UnionUnion
			{
				Type = IElementalBoxTargetPosTypeBase_Union.IElementalBoxTargetPosTypeBase,
				Value = _ielementalboxtargetpostypebase
			};
		}

		// Token: 0x0602FECA RID: 196298 RVA: 0x006860F8 File Offset: 0x006842F8
		public IElementalBoxTargetPrefabPosT AsIElementalBoxTargetPrefabPos()
		{
			return this.As<IElementalBoxTargetPrefabPosT>();
		}

		// Token: 0x0602FECB RID: 196299 RVA: 0x00686100 File Offset: 0x00684300
		public static IElementalBoxTargetPosTypeBase_UnionUnion FromIElementalBoxTargetPrefabPos(IElementalBoxTargetPrefabPosT _ielementalboxtargetprefabpos)
		{
			return new IElementalBoxTargetPosTypeBase_UnionUnion
			{
				Type = IElementalBoxTargetPosTypeBase_Union.IElementalBoxTargetPrefabPos,
				Value = _ielementalboxtargetprefabpos
			};
		}

		// Token: 0x0602FECC RID: 196300 RVA: 0x00686115 File Offset: 0x00684315
		public IElementalBoxTargetRelativePosT AsIElementalBoxTargetRelativePos()
		{
			return this.As<IElementalBoxTargetRelativePosT>();
		}

		// Token: 0x0602FECD RID: 196301 RVA: 0x0068611D File Offset: 0x0068431D
		public static IElementalBoxTargetPosTypeBase_UnionUnion FromIElementalBoxTargetRelativePos(IElementalBoxTargetRelativePosT _ielementalboxtargetrelativepos)
		{
			return new IElementalBoxTargetPosTypeBase_UnionUnion
			{
				Type = IElementalBoxTargetPosTypeBase_Union.IElementalBoxTargetRelativePos,
				Value = _ielementalboxtargetrelativepos
			};
		}

		// Token: 0x0602FECE RID: 196302 RVA: 0x00686134 File Offset: 0x00684334
		public static int Pack(FlatBufferBuilder builder, IElementalBoxTargetPosTypeBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IElementalBoxTargetPosTypeBase_Union.IElementalBoxTargetPosTypeBase:
				return IElementalBoxTargetPosTypeBase.Pack(builder, _o.AsIElementalBoxTargetPosTypeBase()).Value;
			case IElementalBoxTargetPosTypeBase_Union.IElementalBoxTargetPrefabPos:
				return IElementalBoxTargetPrefabPos.Pack(builder, _o.AsIElementalBoxTargetPrefabPos()).Value;
			case IElementalBoxTargetPosTypeBase_Union.IElementalBoxTargetRelativePos:
				return IElementalBoxTargetRelativePos.Pack(builder, _o.AsIElementalBoxTargetRelativePos()).Value;
			default:
				return 0;
			}
		}
	}
}
