using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006634 RID: 26164
	public class IElementalBoxTargetPosTypeBase_UnionUnion
	{
		// Token: 0x1700C25F RID: 49759
		// (get) Token: 0x0602D6F1 RID: 186097 RVA: 0x00639529 File Offset: 0x00637729
		// (set) Token: 0x0602D6F2 RID: 186098 RVA: 0x00639531 File Offset: 0x00637731
		public IElementalBoxTargetPosTypeBase_Union Type { get; set; }

		// Token: 0x1700C260 RID: 49760
		// (get) Token: 0x0602D6F3 RID: 186099 RVA: 0x0063953A File Offset: 0x0063773A
		// (set) Token: 0x0602D6F4 RID: 186100 RVA: 0x00639542 File Offset: 0x00637742
		public object Value { get; set; }

		// Token: 0x0602D6F5 RID: 186101 RVA: 0x0063954B File Offset: 0x0063774B
		public IElementalBoxTargetPosTypeBase_UnionUnion()
		{
			this.Type = IElementalBoxTargetPosTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602D6F6 RID: 186102 RVA: 0x00639561 File Offset: 0x00637761
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602D6F7 RID: 186103 RVA: 0x00639573 File Offset: 0x00637773
		public IElementalBoxTargetPosTypeBaseT AsIElementalBoxTargetPosTypeBase()
		{
			return this.As<IElementalBoxTargetPosTypeBaseT>();
		}

		// Token: 0x0602D6F8 RID: 186104 RVA: 0x0063957B File Offset: 0x0063777B
		public static IElementalBoxTargetPosTypeBase_UnionUnion FromIElementalBoxTargetPosTypeBase(IElementalBoxTargetPosTypeBaseT _ielementalboxtargetpostypebase)
		{
			return new IElementalBoxTargetPosTypeBase_UnionUnion
			{
				Type = IElementalBoxTargetPosTypeBase_Union.IElementalBoxTargetPosTypeBase,
				Value = _ielementalboxtargetpostypebase
			};
		}

		// Token: 0x0602D6F9 RID: 186105 RVA: 0x00639590 File Offset: 0x00637790
		public IElementalBoxTargetPrefabPosT AsIElementalBoxTargetPrefabPos()
		{
			return this.As<IElementalBoxTargetPrefabPosT>();
		}

		// Token: 0x0602D6FA RID: 186106 RVA: 0x00639598 File Offset: 0x00637798
		public static IElementalBoxTargetPosTypeBase_UnionUnion FromIElementalBoxTargetPrefabPos(IElementalBoxTargetPrefabPosT _ielementalboxtargetprefabpos)
		{
			return new IElementalBoxTargetPosTypeBase_UnionUnion
			{
				Type = IElementalBoxTargetPosTypeBase_Union.IElementalBoxTargetPrefabPos,
				Value = _ielementalboxtargetprefabpos
			};
		}

		// Token: 0x0602D6FB RID: 186107 RVA: 0x006395AD File Offset: 0x006377AD
		public IElementalBoxTargetRelativePosT AsIElementalBoxTargetRelativePos()
		{
			return this.As<IElementalBoxTargetRelativePosT>();
		}

		// Token: 0x0602D6FC RID: 186108 RVA: 0x006395B5 File Offset: 0x006377B5
		public static IElementalBoxTargetPosTypeBase_UnionUnion FromIElementalBoxTargetRelativePos(IElementalBoxTargetRelativePosT _ielementalboxtargetrelativepos)
		{
			return new IElementalBoxTargetPosTypeBase_UnionUnion
			{
				Type = IElementalBoxTargetPosTypeBase_Union.IElementalBoxTargetRelativePos,
				Value = _ielementalboxtargetrelativepos
			};
		}

		// Token: 0x0602D6FD RID: 186109 RVA: 0x006395CC File Offset: 0x006377CC
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
