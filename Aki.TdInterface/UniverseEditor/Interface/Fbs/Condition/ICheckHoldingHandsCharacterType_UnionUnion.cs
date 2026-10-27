using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A4F RID: 19023
	public class ICheckHoldingHandsCharacterType_UnionUnion
	{
		// Token: 0x170089B3 RID: 35251
		// (get) Token: 0x0601DC9A RID: 122010 RVA: 0x00430009 File Offset: 0x0042E209
		// (set) Token: 0x0601DC9B RID: 122011 RVA: 0x00430011 File Offset: 0x0042E211
		public ICheckHoldingHandsCharacterType_Union Type { get; set; }

		// Token: 0x170089B4 RID: 35252
		// (get) Token: 0x0601DC9C RID: 122012 RVA: 0x0043001A File Offset: 0x0042E21A
		// (set) Token: 0x0601DC9D RID: 122013 RVA: 0x00430022 File Offset: 0x0042E222
		public object Value { get; set; }

		// Token: 0x0601DC9E RID: 122014 RVA: 0x0043002B File Offset: 0x0042E22B
		public ICheckHoldingHandsCharacterType_UnionUnion()
		{
			this.Type = ICheckHoldingHandsCharacterType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601DC9F RID: 122015 RVA: 0x00430041 File Offset: 0x0042E241
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601DCA0 RID: 122016 RVA: 0x00430053 File Offset: 0x0042E253
		public ICheckHoldingHandsCharacterTypeT AsICheckHoldingHandsCharacterType()
		{
			return this.As<ICheckHoldingHandsCharacterTypeT>();
		}

		// Token: 0x0601DCA1 RID: 122017 RVA: 0x0043005B File Offset: 0x0042E25B
		public static ICheckHoldingHandsCharacterType_UnionUnion FromICheckHoldingHandsCharacterType(ICheckHoldingHandsCharacterTypeT _icheckholdinghandscharactertype)
		{
			return new ICheckHoldingHandsCharacterType_UnionUnion
			{
				Type = ICheckHoldingHandsCharacterType_Union.ICheckHoldingHandsCharacterType,
				Value = _icheckholdinghandscharactertype
			};
		}

		// Token: 0x0601DCA2 RID: 122018 RVA: 0x00430070 File Offset: 0x0042E270
		public ICheckIsPlayerHoldingHandsT AsICheckIsPlayerHoldingHands()
		{
			return this.As<ICheckIsPlayerHoldingHandsT>();
		}

		// Token: 0x0601DCA3 RID: 122019 RVA: 0x00430078 File Offset: 0x0042E278
		public static ICheckHoldingHandsCharacterType_UnionUnion FromICheckIsPlayerHoldingHands(ICheckIsPlayerHoldingHandsT _icheckisplayerholdinghands)
		{
			return new ICheckHoldingHandsCharacterType_UnionUnion
			{
				Type = ICheckHoldingHandsCharacterType_Union.ICheckIsPlayerHoldingHands,
				Value = _icheckisplayerholdinghands
			};
		}

		// Token: 0x0601DCA4 RID: 122020 RVA: 0x0043008D File Offset: 0x0042E28D
		public ICheckIsEntityHoldingHandsT AsICheckIsEntityHoldingHands()
		{
			return this.As<ICheckIsEntityHoldingHandsT>();
		}

		// Token: 0x0601DCA5 RID: 122021 RVA: 0x00430095 File Offset: 0x0042E295
		public static ICheckHoldingHandsCharacterType_UnionUnion FromICheckIsEntityHoldingHands(ICheckIsEntityHoldingHandsT _icheckisentityholdinghands)
		{
			return new ICheckHoldingHandsCharacterType_UnionUnion
			{
				Type = ICheckHoldingHandsCharacterType_Union.ICheckIsEntityHoldingHands,
				Value = _icheckisentityholdinghands
			};
		}

		// Token: 0x0601DCA6 RID: 122022 RVA: 0x004300AC File Offset: 0x0042E2AC
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
