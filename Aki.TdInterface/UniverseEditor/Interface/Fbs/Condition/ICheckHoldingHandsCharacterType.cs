using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F11 RID: 20241
	public struct ICheckHoldingHandsCharacterType : IFlatbufferObject
	{
		// Token: 0x1700908C RID: 37004
		// (get) Token: 0x0601F72B RID: 128811 RVA: 0x0046101D File Offset: 0x0045F21D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F72C RID: 128812 RVA: 0x0046102A File Offset: 0x0045F22A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F72D RID: 128813 RVA: 0x00461034 File Offset: 0x0045F234
		public static ICheckHoldingHandsCharacterType GetRootAsICheckHoldingHandsCharacterType(ByteBuffer _bb)
		{
			return ICheckHoldingHandsCharacterType.GetRootAsICheckHoldingHandsCharacterType(_bb, default(ICheckHoldingHandsCharacterType));
		}

		// Token: 0x0601F72E RID: 128814 RVA: 0x00461050 File Offset: 0x0045F250
		public static ICheckHoldingHandsCharacterType GetRootAsICheckHoldingHandsCharacterType(ByteBuffer _bb, ICheckHoldingHandsCharacterType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F72F RID: 128815 RVA: 0x0046106D File Offset: 0x0045F26D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F730 RID: 128816 RVA: 0x0046107C File Offset: 0x0045F27C
		public ICheckHoldingHandsCharacterType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700908D RID: 37005
		// (get) Token: 0x0601F731 RID: 128817 RVA: 0x0046108C File Offset: 0x0045F28C
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

		// Token: 0x0601F732 RID: 128818 RVA: 0x004610C8 File Offset: 0x0045F2C8
		public static Offset<ICheckHoldingHandsCharacterType> CreateICheckHoldingHandsCharacterType(FlatBufferBuilder builder, ECheckHoldingHandsCharacter Type = ECheckHoldingHandsCharacter.Player)
		{
			builder.StartTable(1);
			ICheckHoldingHandsCharacterType.AddType(builder, Type);
			return ICheckHoldingHandsCharacterType.EndICheckHoldingHandsCharacterType(builder);
		}

		// Token: 0x0601F733 RID: 128819 RVA: 0x004610DE File Offset: 0x0045F2DE
		public static void StartICheckHoldingHandsCharacterType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601F734 RID: 128820 RVA: 0x004610E7 File Offset: 0x0045F2E7
		public static void AddType(FlatBufferBuilder builder, ECheckHoldingHandsCharacter type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F735 RID: 128821 RVA: 0x004610F2 File Offset: 0x0045F2F2
		public static Offset<ICheckHoldingHandsCharacterType> EndICheckHoldingHandsCharacterType(FlatBufferBuilder builder)
		{
			return new Offset<ICheckHoldingHandsCharacterType>(builder.EndTable());
		}

		// Token: 0x0601F736 RID: 128822 RVA: 0x00461100 File Offset: 0x0045F300
		public ICheckHoldingHandsCharacterTypeT UnPack()
		{
			ICheckHoldingHandsCharacterTypeT checkHoldingHandsCharacterTypeT = new ICheckHoldingHandsCharacterTypeT();
			this.UnPackTo(checkHoldingHandsCharacterTypeT);
			return checkHoldingHandsCharacterTypeT;
		}

		// Token: 0x0601F737 RID: 128823 RVA: 0x0046111B File Offset: 0x0045F31B
		public void UnPackTo(ICheckHoldingHandsCharacterTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601F738 RID: 128824 RVA: 0x0046112C File Offset: 0x0045F32C
		public static Offset<ICheckHoldingHandsCharacterType> Pack(FlatBufferBuilder builder, ICheckHoldingHandsCharacterTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckHoldingHandsCharacterType>);
			}
			return ICheckHoldingHandsCharacterType.CreateICheckHoldingHandsCharacterType(builder, _o.Type);
		}

		// Token: 0x0400DD7D RID: 56701
		private Table __p;
	}
}
