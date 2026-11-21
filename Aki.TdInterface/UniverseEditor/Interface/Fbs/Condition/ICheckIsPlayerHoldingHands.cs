using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F62 RID: 20322
	public struct ICheckIsPlayerHoldingHands : IFlatbufferObject
	{
		// Token: 0x1700913C RID: 37180
		// (get) Token: 0x0601F9FB RID: 129531 RVA: 0x00465DF6 File Offset: 0x00463FF6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F9FC RID: 129532 RVA: 0x00465E03 File Offset: 0x00464003
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F9FD RID: 129533 RVA: 0x00465E0C File Offset: 0x0046400C
		public static ICheckIsPlayerHoldingHands GetRootAsICheckIsPlayerHoldingHands(ByteBuffer _bb)
		{
			return ICheckIsPlayerHoldingHands.GetRootAsICheckIsPlayerHoldingHands(_bb, default(ICheckIsPlayerHoldingHands));
		}

		// Token: 0x0601F9FE RID: 129534 RVA: 0x00465E28 File Offset: 0x00464028
		public static ICheckIsPlayerHoldingHands GetRootAsICheckIsPlayerHoldingHands(ByteBuffer _bb, ICheckIsPlayerHoldingHands obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F9FF RID: 129535 RVA: 0x00465E45 File Offset: 0x00464045
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FA00 RID: 129536 RVA: 0x00465E54 File Offset: 0x00464054
		public ICheckIsPlayerHoldingHands __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700913D RID: 37181
		// (get) Token: 0x0601FA01 RID: 129537 RVA: 0x00465E64 File Offset: 0x00464064
		public ECheckHoldingHandsCharacter Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckHoldingHandsCharacter.Player;
				}
				return (ECheckHoldingHandsCharacter)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601FA02 RID: 129538 RVA: 0x00465EA0 File Offset: 0x004640A0
		public static Offset<ICheckIsPlayerHoldingHands> CreateICheckIsPlayerHoldingHands(FlatBufferBuilder builder, ECheckHoldingHandsCharacter Type = ECheckHoldingHandsCharacter.Player)
		{
			builder.StartTable(1);
			ICheckIsPlayerHoldingHands.AddType(builder, Type);
			return ICheckIsPlayerHoldingHands.EndICheckIsPlayerHoldingHands(builder);
		}

		// Token: 0x0601FA03 RID: 129539 RVA: 0x00465EB6 File Offset: 0x004640B6
		public static void StartICheckIsPlayerHoldingHands(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601FA04 RID: 129540 RVA: 0x00465EBF File Offset: 0x004640BF
		public static void AddType(FlatBufferBuilder builder, ECheckHoldingHandsCharacter type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FA05 RID: 129541 RVA: 0x00465ECA File Offset: 0x004640CA
		public static Offset<ICheckIsPlayerHoldingHands> EndICheckIsPlayerHoldingHands(FlatBufferBuilder builder)
		{
			return new Offset<ICheckIsPlayerHoldingHands>(builder.EndTable());
		}

		// Token: 0x0601FA06 RID: 129542 RVA: 0x00465ED8 File Offset: 0x004640D8
		public ICheckIsPlayerHoldingHandsT UnPack()
		{
			ICheckIsPlayerHoldingHandsT checkIsPlayerHoldingHandsT = new ICheckIsPlayerHoldingHandsT();
			this.UnPackTo(checkIsPlayerHoldingHandsT);
			return checkIsPlayerHoldingHandsT;
		}

		// Token: 0x0601FA07 RID: 129543 RVA: 0x00465EF3 File Offset: 0x004640F3
		public void UnPackTo(ICheckIsPlayerHoldingHandsT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601FA08 RID: 129544 RVA: 0x00465F04 File Offset: 0x00464104
		public static Offset<ICheckIsPlayerHoldingHands> Pack(FlatBufferBuilder builder, ICheckIsPlayerHoldingHandsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckIsPlayerHoldingHands>);
			}
			return ICheckIsPlayerHoldingHands.CreateICheckIsPlayerHoldingHands(builder, _o.Type);
		}

		// Token: 0x0400DDE8 RID: 56808
		private Table __p;
	}
}
