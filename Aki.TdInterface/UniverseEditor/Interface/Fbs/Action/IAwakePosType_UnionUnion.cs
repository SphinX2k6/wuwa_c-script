using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061D4 RID: 25044
	public class IAwakePosType_UnionUnion
	{
		// Token: 0x1700BABC RID: 47804
		// (get) Token: 0x0602B298 RID: 176792 RVA: 0x005F314D File Offset: 0x005F134D
		// (set) Token: 0x0602B299 RID: 176793 RVA: 0x005F3155 File Offset: 0x005F1355
		public IAwakePosType_Union Type { get; set; }

		// Token: 0x1700BABD RID: 47805
		// (get) Token: 0x0602B29A RID: 176794 RVA: 0x005F315E File Offset: 0x005F135E
		// (set) Token: 0x0602B29B RID: 176795 RVA: 0x005F3166 File Offset: 0x005F1366
		public object Value { get; set; }

		// Token: 0x0602B29C RID: 176796 RVA: 0x005F316F File Offset: 0x005F136F
		public IAwakePosType_UnionUnion()
		{
			this.Type = IAwakePosType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602B29D RID: 176797 RVA: 0x005F3185 File Offset: 0x005F1385
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B29E RID: 176798 RVA: 0x005F3197 File Offset: 0x005F1397
		public IAwakePosTypeT AsIAwakePosType()
		{
			return this.As<IAwakePosTypeT>();
		}

		// Token: 0x0602B29F RID: 176799 RVA: 0x005F319F File Offset: 0x005F139F
		public static IAwakePosType_UnionUnion FromIAwakePosType(IAwakePosTypeT _iawakepostype)
		{
			return new IAwakePosType_UnionUnion
			{
				Type = IAwakePosType_Union.IAwakePosType,
				Value = _iawakepostype
			};
		}

		// Token: 0x0602B2A0 RID: 176800 RVA: 0x005F31B4 File Offset: 0x005F13B4
		public IAwakeWithTransformVarT AsIAwakeWithTransformVar()
		{
			return this.As<IAwakeWithTransformVarT>();
		}

		// Token: 0x0602B2A1 RID: 176801 RVA: 0x005F31BC File Offset: 0x005F13BC
		public static IAwakePosType_UnionUnion FromIAwakeWithTransformVar(IAwakeWithTransformVarT _iawakewithtransformvar)
		{
			return new IAwakePosType_UnionUnion
			{
				Type = IAwakePosType_Union.IAwakeWithTransformVar,
				Value = _iawakewithtransformvar
			};
		}

		// Token: 0x0602B2A2 RID: 176802 RVA: 0x005F31D4 File Offset: 0x005F13D4
		public static int Pack(FlatBufferBuilder builder, IAwakePosType_UnionUnion _o)
		{
			IAwakePosType_Union type = _o.Type;
			if (type == IAwakePosType_Union.IAwakePosType)
			{
				return IAwakePosType.Pack(builder, _o.AsIAwakePosType()).Value;
			}
			if (type != IAwakePosType_Union.IAwakeWithTransformVar)
			{
				return 0;
			}
			return IAwakeWithTransformVar.Pack(builder, _o.AsIAwakeWithTransformVar()).Value;
		}
	}
}
