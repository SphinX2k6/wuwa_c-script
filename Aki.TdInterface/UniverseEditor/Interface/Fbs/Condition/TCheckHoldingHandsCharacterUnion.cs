using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005230 RID: 21040
	public class TCheckHoldingHandsCharacterUnion
	{
		// Token: 0x17009676 RID: 38518
		// (get) Token: 0x06021231 RID: 135729 RVA: 0x0049361C File Offset: 0x0049181C
		// (set) Token: 0x06021232 RID: 135730 RVA: 0x00493624 File Offset: 0x00491824
		public TCheckHoldingHandsCharacter Type { get; set; }

		// Token: 0x17009677 RID: 38519
		// (get) Token: 0x06021233 RID: 135731 RVA: 0x0049362D File Offset: 0x0049182D
		// (set) Token: 0x06021234 RID: 135732 RVA: 0x00493635 File Offset: 0x00491835
		public object Value { get; set; }

		// Token: 0x06021235 RID: 135733 RVA: 0x0049363E File Offset: 0x0049183E
		public TCheckHoldingHandsCharacterUnion()
		{
			this.Type = TCheckHoldingHandsCharacter.NONE;
			this.Value = null;
		}

		// Token: 0x06021236 RID: 135734 RVA: 0x00493654 File Offset: 0x00491854
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06021237 RID: 135735 RVA: 0x00493666 File Offset: 0x00491866
		public ICheckIsEntityHoldingHandsT AsICheckIsEntityHoldingHands()
		{
			return this.As<ICheckIsEntityHoldingHandsT>();
		}

		// Token: 0x06021238 RID: 135736 RVA: 0x0049366E File Offset: 0x0049186E
		public static TCheckHoldingHandsCharacterUnion FromICheckIsEntityHoldingHands(ICheckIsEntityHoldingHandsT _icheckisentityholdinghands)
		{
			return new TCheckHoldingHandsCharacterUnion
			{
				Type = TCheckHoldingHandsCharacter.ICheckIsEntityHoldingHands,
				Value = _icheckisentityholdinghands
			};
		}

		// Token: 0x06021239 RID: 135737 RVA: 0x00493683 File Offset: 0x00491883
		public ICheckIsPlayerHoldingHandsT AsICheckIsPlayerHoldingHands()
		{
			return this.As<ICheckIsPlayerHoldingHandsT>();
		}

		// Token: 0x0602123A RID: 135738 RVA: 0x0049368B File Offset: 0x0049188B
		public static TCheckHoldingHandsCharacterUnion FromICheckIsPlayerHoldingHands(ICheckIsPlayerHoldingHandsT _icheckisplayerholdinghands)
		{
			return new TCheckHoldingHandsCharacterUnion
			{
				Type = TCheckHoldingHandsCharacter.ICheckIsPlayerHoldingHands,
				Value = _icheckisplayerholdinghands
			};
		}

		// Token: 0x0602123B RID: 135739 RVA: 0x004936A0 File Offset: 0x004918A0
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
