using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F15 RID: 20245
	public class ICheckHoldingHandsCharacterType_UnionUnion
	{
		// Token: 0x1700908F RID: 37007
		// (get) Token: 0x0601F73D RID: 128829 RVA: 0x00461195 File Offset: 0x0045F395
		// (set) Token: 0x0601F73E RID: 128830 RVA: 0x0046119D File Offset: 0x0045F39D
		public ICheckHoldingHandsCharacterType_Union Type { get; set; }

		// Token: 0x17009090 RID: 37008
		// (get) Token: 0x0601F73F RID: 128831 RVA: 0x004611A6 File Offset: 0x0045F3A6
		// (set) Token: 0x0601F740 RID: 128832 RVA: 0x004611AE File Offset: 0x0045F3AE
		public object Value { get; set; }

		// Token: 0x0601F741 RID: 128833 RVA: 0x004611B7 File Offset: 0x0045F3B7
		public ICheckHoldingHandsCharacterType_UnionUnion()
		{
			this.Type = ICheckHoldingHandsCharacterType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601F742 RID: 128834 RVA: 0x004611CD File Offset: 0x0045F3CD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601F743 RID: 128835 RVA: 0x004611DF File Offset: 0x0045F3DF
		public ICheckHoldingHandsCharacterTypeT AsICheckHoldingHandsCharacterType()
		{
			return this.As<ICheckHoldingHandsCharacterTypeT>();
		}

		// Token: 0x0601F744 RID: 128836 RVA: 0x004611E7 File Offset: 0x0045F3E7
		public static ICheckHoldingHandsCharacterType_UnionUnion FromICheckHoldingHandsCharacterType(ICheckHoldingHandsCharacterTypeT _icheckholdinghandscharactertype)
		{
			return new ICheckHoldingHandsCharacterType_UnionUnion
			{
				Type = ICheckHoldingHandsCharacterType_Union.ICheckHoldingHandsCharacterType,
				Value = _icheckholdinghandscharactertype
			};
		}

		// Token: 0x0601F745 RID: 128837 RVA: 0x004611FC File Offset: 0x0045F3FC
		public ICheckIsPlayerHoldingHandsT AsICheckIsPlayerHoldingHands()
		{
			return this.As<ICheckIsPlayerHoldingHandsT>();
		}

		// Token: 0x0601F746 RID: 128838 RVA: 0x00461204 File Offset: 0x0045F404
		public static ICheckHoldingHandsCharacterType_UnionUnion FromICheckIsPlayerHoldingHands(ICheckIsPlayerHoldingHandsT _icheckisplayerholdinghands)
		{
			return new ICheckHoldingHandsCharacterType_UnionUnion
			{
				Type = ICheckHoldingHandsCharacterType_Union.ICheckIsPlayerHoldingHands,
				Value = _icheckisplayerholdinghands
			};
		}

		// Token: 0x0601F747 RID: 128839 RVA: 0x00461219 File Offset: 0x0045F419
		public ICheckIsEntityHoldingHandsT AsICheckIsEntityHoldingHands()
		{
			return this.As<ICheckIsEntityHoldingHandsT>();
		}

		// Token: 0x0601F748 RID: 128840 RVA: 0x00461221 File Offset: 0x0045F421
		public static ICheckHoldingHandsCharacterType_UnionUnion FromICheckIsEntityHoldingHands(ICheckIsEntityHoldingHandsT _icheckisentityholdinghands)
		{
			return new ICheckHoldingHandsCharacterType_UnionUnion
			{
				Type = ICheckHoldingHandsCharacterType_Union.ICheckIsEntityHoldingHands,
				Value = _icheckisentityholdinghands
			};
		}

		// Token: 0x0601F749 RID: 128841 RVA: 0x00461238 File Offset: 0x0045F438
		public static int Pack(FlatBufferBuilder builder, ICheckHoldingHandsCharacterType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ICheckHoldingHandsCharacterType_Union.ICheckHoldingHandsCharacterType:
				return ICheckHoldingHandsCharacterType.Pack(builder, _o.AsICheckHoldingHandsCharacterType()).Value;
			case ICheckHoldingHandsCharacterType_Union.ICheckIsPlayerHoldingHands:
				return ICheckIsPlayerHoldingHands.Pack(builder, _o.AsICheckIsPlayerHoldingHands()).Value;
			case ICheckHoldingHandsCharacterType_Union.ICheckIsEntityHoldingHands:
				return ICheckIsEntityHoldingHands.Pack(builder, _o.AsICheckIsEntityHoldingHands()).Value;
			default:
				return 0;
			}
		}
	}
}
