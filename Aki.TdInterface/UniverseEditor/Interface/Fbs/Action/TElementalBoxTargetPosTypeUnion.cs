using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EBC RID: 32444
	public class TElementalBoxTargetPosTypeUnion
	{
		// Token: 0x1700F24B RID: 62027
		// (get) Token: 0x0603A903 RID: 239875 RVA: 0x007E1894 File Offset: 0x007DFA94
		// (set) Token: 0x0603A904 RID: 239876 RVA: 0x007E189C File Offset: 0x007DFA9C
		public TElementalBoxTargetPosType Type { get; set; }

		// Token: 0x1700F24C RID: 62028
		// (get) Token: 0x0603A905 RID: 239877 RVA: 0x007E18A5 File Offset: 0x007DFAA5
		// (set) Token: 0x0603A906 RID: 239878 RVA: 0x007E18AD File Offset: 0x007DFAAD
		public object Value { get; set; }

		// Token: 0x0603A907 RID: 239879 RVA: 0x007E18B6 File Offset: 0x007DFAB6
		public TElementalBoxTargetPosTypeUnion()
		{
			this.Type = TElementalBoxTargetPosType.NONE;
			this.Value = null;
		}

		// Token: 0x0603A908 RID: 239880 RVA: 0x007E18CC File Offset: 0x007DFACC
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A909 RID: 239881 RVA: 0x007E18DE File Offset: 0x007DFADE
		public IElementalBoxTargetPrefabPosT AsIElementalBoxTargetPrefabPos()
		{
			return this.As<IElementalBoxTargetPrefabPosT>();
		}

		// Token: 0x0603A90A RID: 239882 RVA: 0x007E18E6 File Offset: 0x007DFAE6
		public static TElementalBoxTargetPosTypeUnion FromIElementalBoxTargetPrefabPos(IElementalBoxTargetPrefabPosT _ielementalboxtargetprefabpos)
		{
			return new TElementalBoxTargetPosTypeUnion
			{
				Type = TElementalBoxTargetPosType.IElementalBoxTargetPrefabPos,
				Value = _ielementalboxtargetprefabpos
			};
		}

		// Token: 0x0603A90B RID: 239883 RVA: 0x007E18FB File Offset: 0x007DFAFB
		public IElementalBoxTargetRelativePosT AsIElementalBoxTargetRelativePos()
		{
			return this.As<IElementalBoxTargetRelativePosT>();
		}

		// Token: 0x0603A90C RID: 239884 RVA: 0x007E1903 File Offset: 0x007DFB03
		public static TElementalBoxTargetPosTypeUnion FromIElementalBoxTargetRelativePos(IElementalBoxTargetRelativePosT _ielementalboxtargetrelativepos)
		{
			return new TElementalBoxTargetPosTypeUnion
			{
				Type = TElementalBoxTargetPosType.IElementalBoxTargetRelativePos,
				Value = _ielementalboxtargetrelativepos
			};
		}

		// Token: 0x0603A90D RID: 239885 RVA: 0x007E1918 File Offset: 0x007DFB18
		public static int Pack(FlatBufferBuilder builder, TElementalBoxTargetPosTypeUnion _o)
		{
			TElementalBoxTargetPosType type = _o.Type;
			if (type == TElementalBoxTargetPosType.IElementalBoxTargetPrefabPos)
			{
				return IElementalBoxTargetPrefabPos.Pack(builder, _o.AsIElementalBoxTargetPrefabPos()).Value;
			}
			if (type != TElementalBoxTargetPosType.IElementalBoxTargetRelativePos)
			{
				return 0;
			}
			return IElementalBoxTargetRelativePos.Pack(builder, _o.AsIElementalBoxTargetRelativePos()).Value;
		}
	}
}
