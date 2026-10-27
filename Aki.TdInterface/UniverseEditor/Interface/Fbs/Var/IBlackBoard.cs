using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A09 RID: 14857
	public struct IBlackBoard : IFlatbufferObject
	{
		// Token: 0x170065CE RID: 26062
		// (get) Token: 0x0601411B RID: 82203 RVA: 0x002F049D File Offset: 0x002EE69D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601411C RID: 82204 RVA: 0x002F04AA File Offset: 0x002EE6AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601411D RID: 82205 RVA: 0x002F04B4 File Offset: 0x002EE6B4
		public static IBlackBoard GetRootAsIBlackBoard(ByteBuffer _bb)
		{
			return IBlackBoard.GetRootAsIBlackBoard(_bb, default(IBlackBoard));
		}

		// Token: 0x0601411E RID: 82206 RVA: 0x002F04D0 File Offset: 0x002EE6D0
		public static IBlackBoard GetRootAsIBlackBoard(ByteBuffer _bb, IBlackBoard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601411F RID: 82207 RVA: 0x002F04ED File Offset: 0x002EE6ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014120 RID: 82208 RVA: 0x002F04FC File Offset: 0x002EE6FC
		public IBlackBoard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170065CF RID: 26063
		// (get) Token: 0x06014121 RID: 82209 RVA: 0x002F050C File Offset: 0x002EE70C
		public EBlackBoardType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBlackBoardType.Boolean;
				}
				return (EBlackBoardType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170065D0 RID: 26064
		// (get) Token: 0x06014122 RID: 82210 RVA: 0x002F0548 File Offset: 0x002EE748
		public string Key
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014123 RID: 82211 RVA: 0x002F057F File Offset: 0x002EE77F
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06014124 RID: 82212 RVA: 0x002F058E File Offset: 0x002EE78E
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06014125 RID: 82213 RVA: 0x002F059C File Offset: 0x002EE79C
		public static Offset<IBlackBoard> CreateIBlackBoard(FlatBufferBuilder builder, EBlackBoardType Type = EBlackBoardType.Boolean, StringOffset KeyOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IBlackBoard.AddKey(builder, KeyOffset);
			IBlackBoard.AddType(builder, Type);
			return IBlackBoard.EndIBlackBoard(builder);
		}

		// Token: 0x06014126 RID: 82214 RVA: 0x002F05B9 File Offset: 0x002EE7B9
		public static void StartIBlackBoard(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06014127 RID: 82215 RVA: 0x002F05C2 File Offset: 0x002EE7C2
		public static void AddType(FlatBufferBuilder builder, EBlackBoardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014128 RID: 82216 RVA: 0x002F05CD File Offset: 0x002EE7CD
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(1, keyOffset.Value, 0);
		}

		// Token: 0x06014129 RID: 82217 RVA: 0x002F05DD File Offset: 0x002EE7DD
		public static Offset<IBlackBoard> EndIBlackBoard(FlatBufferBuilder builder)
		{
			return new Offset<IBlackBoard>(builder.EndTable());
		}

		// Token: 0x0601412A RID: 82218 RVA: 0x002F05EC File Offset: 0x002EE7EC
		public IBlackBoardT UnPack()
		{
			IBlackBoardT blackBoardT = new IBlackBoardT();
			this.UnPackTo(blackBoardT);
			return blackBoardT;
		}

		// Token: 0x0601412B RID: 82219 RVA: 0x002F0607 File Offset: 0x002EE807
		public void UnPackTo(IBlackBoardT _o)
		{
			_o.Type = this.Type;
			_o.Key = this.Key;
		}

		// Token: 0x0601412C RID: 82220 RVA: 0x002F0624 File Offset: 0x002EE824
		public static Offset<IBlackBoard> Pack(FlatBufferBuilder builder, IBlackBoardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBlackBoard>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			return IBlackBoard.CreateIBlackBoard(builder, _o.Type, keyOffset);
		}

		// Token: 0x0400AE71 RID: 44657
		private Table __p;
	}
}
