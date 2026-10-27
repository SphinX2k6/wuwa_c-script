using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A4B RID: 19019
	public struct ICheckHoldingHandsCharacterType : IFlatbufferObject
	{
		// Token: 0x170089B0 RID: 35248
		// (get) Token: 0x0601DC88 RID: 121992 RVA: 0x0042FE91 File Offset: 0x0042E091
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DC89 RID: 121993 RVA: 0x0042FE9E File Offset: 0x0042E09E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DC8A RID: 121994 RVA: 0x0042FEA8 File Offset: 0x0042E0A8
		public static ICheckHoldingHandsCharacterType GetRootAsICheckHoldingHandsCharacterType(ByteBuffer _bb)
		{
			return ICheckHoldingHandsCharacterType.GetRootAsICheckHoldingHandsCharacterType(_bb, default(ICheckHoldingHandsCharacterType));
		}

		// Token: 0x0601DC8B RID: 121995 RVA: 0x0042FEC4 File Offset: 0x0042E0C4
		public static ICheckHoldingHandsCharacterType GetRootAsICheckHoldingHandsCharacterType(ByteBuffer _bb, ICheckHoldingHandsCharacterType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DC8C RID: 121996 RVA: 0x0042FEE1 File Offset: 0x0042E0E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DC8D RID: 121997 RVA: 0x0042FEF0 File Offset: 0x0042E0F0
		public ICheckHoldingHandsCharacterType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170089B1 RID: 35249
		// (get) Token: 0x0601DC8E RID: 121998 RVA: 0x0042FF00 File Offset: 0x0042E100
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

		// Token: 0x0601DC8F RID: 121999 RVA: 0x0042FF3C File Offset: 0x0042E13C
		public static Offset<ICheckHoldingHandsCharacterType> CreateICheckHoldingHandsCharacterType(FlatBufferBuilder builder, ECheckHoldingHandsCharacter Type = ECheckHoldingHandsCharacter.Player)
		{
			builder.StartTable(1);
			ICheckHoldingHandsCharacterType.AddType(builder, Type);
			return ICheckHoldingHandsCharacterType.EndICheckHoldingHandsCharacterType(builder);
		}

		// Token: 0x0601DC90 RID: 122000 RVA: 0x0042FF52 File Offset: 0x0042E152
		public static void StartICheckHoldingHandsCharacterType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601DC91 RID: 122001 RVA: 0x0042FF5B File Offset: 0x0042E15B
		public static void AddType(FlatBufferBuilder builder, ECheckHoldingHandsCharacter type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DC92 RID: 122002 RVA: 0x0042FF66 File Offset: 0x0042E166
		public static Offset<ICheckHoldingHandsCharacterType> EndICheckHoldingHandsCharacterType(FlatBufferBuilder builder)
		{
			return new Offset<ICheckHoldingHandsCharacterType>(builder.EndTable());
		}

		// Token: 0x0601DC93 RID: 122003 RVA: 0x0042FF74 File Offset: 0x0042E174
		public ICheckHoldingHandsCharacterTypeT UnPack()
		{
			ICheckHoldingHandsCharacterTypeT checkHoldingHandsCharacterTypeT = new ICheckHoldingHandsCharacterTypeT();
			this.UnPackTo(checkHoldingHandsCharacterTypeT);
			return checkHoldingHandsCharacterTypeT;
		}

		// Token: 0x0601DC94 RID: 122004 RVA: 0x0042FF8F File Offset: 0x0042E18F
		public void UnPackTo(ICheckHoldingHandsCharacterTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601DC95 RID: 122005 RVA: 0x0042FFA0 File Offset: 0x0042E1A0
		public static Offset<ICheckHoldingHandsCharacterType> Pack(FlatBufferBuilder builder, ICheckHoldingHandsCharacterTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckHoldingHandsCharacterType>);
			}
			return ICheckHoldingHandsCharacterType.CreateICheckHoldingHandsCharacterType(builder, _o.Type);
		}

		// Token: 0x0400D2A2 RID: 53922
		private Table __p;
	}
}
