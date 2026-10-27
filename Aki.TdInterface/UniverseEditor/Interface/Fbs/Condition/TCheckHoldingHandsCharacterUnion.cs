using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D34 RID: 19764
	public class TCheckHoldingHandsCharacterUnion
	{
		// Token: 0x17008F3D RID: 36669
		// (get) Token: 0x0601F5EA RID: 128490 RVA: 0x0045F68C File Offset: 0x0045D88C
		// (set) Token: 0x0601F5EB RID: 128491 RVA: 0x0045F694 File Offset: 0x0045D894
		public TCheckHoldingHandsCharacter Type { get; set; }

		// Token: 0x17008F3E RID: 36670
		// (get) Token: 0x0601F5EC RID: 128492 RVA: 0x0045F69D File Offset: 0x0045D89D
		// (set) Token: 0x0601F5ED RID: 128493 RVA: 0x0045F6A5 File Offset: 0x0045D8A5
		public object Value { get; set; }

		// Token: 0x0601F5EE RID: 128494 RVA: 0x0045F6AE File Offset: 0x0045D8AE
		public TCheckHoldingHandsCharacterUnion()
		{
			this.Type = TCheckHoldingHandsCharacter.NONE;
			this.Value = null;
		}

		// Token: 0x0601F5EF RID: 128495 RVA: 0x0045F6C4 File Offset: 0x0045D8C4
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601F5F0 RID: 128496 RVA: 0x0045F6D6 File Offset: 0x0045D8D6
		public ICheckIsEntityHoldingHandsT AsICheckIsEntityHoldingHands()
		{
			return this.As<ICheckIsEntityHoldingHandsT>();
		}

		// Token: 0x0601F5F1 RID: 128497 RVA: 0x0045F6DE File Offset: 0x0045D8DE
		public static TCheckHoldingHandsCharacterUnion FromICheckIsEntityHoldingHands(ICheckIsEntityHoldingHandsT _icheckisentityholdinghands)
		{
			return new TCheckHoldingHandsCharacterUnion
			{
				Type = TCheckHoldingHandsCharacter.ICheckIsEntityHoldingHands,
				Value = _icheckisentityholdinghands
			};
		}

		// Token: 0x0601F5F2 RID: 128498 RVA: 0x0045F6F3 File Offset: 0x0045D8F3
		public ICheckIsPlayerHoldingHandsT AsICheckIsPlayerHoldingHands()
		{
			return this.As<ICheckIsPlayerHoldingHandsT>();
		}

		// Token: 0x0601F5F3 RID: 128499 RVA: 0x0045F6FB File Offset: 0x0045D8FB
		public static TCheckHoldingHandsCharacterUnion FromICheckIsPlayerHoldingHands(ICheckIsPlayerHoldingHandsT _icheckisplayerholdinghands)
		{
			return new TCheckHoldingHandsCharacterUnion
			{
				Type = TCheckHoldingHandsCharacter.ICheckIsPlayerHoldingHands,
				Value = _icheckisplayerholdinghands
			};
		}

		// Token: 0x0601F5F4 RID: 128500 RVA: 0x0045F710 File Offset: 0x0045D910
		public static int Pack(FlatBufferBuilder builder, TCheckHoldingHandsCharacterUnion _o)
		{
			TCheckHoldingHandsCharacter type = _o.Type;
			if (type == TCheckHoldingHandsCharacter.ICheckIsEntityHoldingHands)
			{
				return ICheckIsEntityHoldingHands.Pack(builder, _o.AsICheckIsEntityHoldingHands()).Value;
			}
			if (type != TCheckHoldingHandsCharacter.ICheckIsPlayerHoldingHands)
			{
				return 0;
			}
			return ICheckIsPlayerHoldingHands.Pack(builder, _o.AsICheckIsPlayerHoldingHands()).Value;
		}
	}
}
