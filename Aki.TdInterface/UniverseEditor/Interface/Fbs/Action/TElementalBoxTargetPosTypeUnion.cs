using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076B1 RID: 30385
	public class TElementalBoxTargetPosTypeUnion
	{
		// Token: 0x1700E60F RID: 58895
		// (get) Token: 0x06037460 RID: 226400 RVA: 0x0077D740 File Offset: 0x0077B940
		// (set) Token: 0x06037461 RID: 226401 RVA: 0x0077D748 File Offset: 0x0077B948
		public TElementalBoxTargetPosType Type { get; set; }

		// Token: 0x1700E610 RID: 58896
		// (get) Token: 0x06037462 RID: 226402 RVA: 0x0077D751 File Offset: 0x0077B951
		// (set) Token: 0x06037463 RID: 226403 RVA: 0x0077D759 File Offset: 0x0077B959
		public object Value { get; set; }

		// Token: 0x06037464 RID: 226404 RVA: 0x0077D762 File Offset: 0x0077B962
		public TElementalBoxTargetPosTypeUnion()
		{
			this.Type = TElementalBoxTargetPosType.NONE;
			this.Value = null;
		}

		// Token: 0x06037465 RID: 226405 RVA: 0x0077D778 File Offset: 0x0077B978
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037466 RID: 226406 RVA: 0x0077D78A File Offset: 0x0077B98A
		public IElementalBoxTargetPrefabPosT AsIElementalBoxTargetPrefabPos()
		{
			return this.As<IElementalBoxTargetPrefabPosT>();
		}

		// Token: 0x06037467 RID: 226407 RVA: 0x0077D792 File Offset: 0x0077B992
		public static TElementalBoxTargetPosTypeUnion FromIElementalBoxTargetPrefabPos(IElementalBoxTargetPrefabPosT _ielementalboxtargetprefabpos)
		{
			return new TElementalBoxTargetPosTypeUnion
			{
				Type = TElementalBoxTargetPosType.IElementalBoxTargetPrefabPos,
				Value = _ielementalboxtargetprefabpos
			};
		}

		// Token: 0x06037468 RID: 226408 RVA: 0x0077D7A7 File Offset: 0x0077B9A7
		public IElementalBoxTargetRelativePosT AsIElementalBoxTargetRelativePos()
		{
			return this.As<IElementalBoxTargetRelativePosT>();
		}

		// Token: 0x06037469 RID: 226409 RVA: 0x0077D7AF File Offset: 0x0077B9AF
		public static TElementalBoxTargetPosTypeUnion FromIElementalBoxTargetRelativePos(IElementalBoxTargetRelativePosT _ielementalboxtargetrelativepos)
		{
			return new TElementalBoxTargetPosTypeUnion
			{
				Type = TElementalBoxTargetPosType.IElementalBoxTargetRelativePos,
				Value = _ielementalboxtargetrelativepos
			};
		}

		// Token: 0x0603746A RID: 226410 RVA: 0x0077D7C4 File Offset: 0x0077B9C4
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
