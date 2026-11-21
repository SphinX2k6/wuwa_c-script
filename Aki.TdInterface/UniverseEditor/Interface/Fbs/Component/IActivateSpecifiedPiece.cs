using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200535B RID: 21339
	public struct IActivateSpecifiedPiece : IFlatbufferObject
	{
		// Token: 0x170096A7 RID: 38567
		// (get) Token: 0x06021389 RID: 136073 RVA: 0x00495C31 File Offset: 0x00493E31
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602138A RID: 136074 RVA: 0x00495C3E File Offset: 0x00493E3E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602138B RID: 136075 RVA: 0x00495C48 File Offset: 0x00493E48
		public static IActivateSpecifiedPiece GetRootAsIActivateSpecifiedPiece(ByteBuffer _bb)
		{
			return IActivateSpecifiedPiece.GetRootAsIActivateSpecifiedPiece(_bb, default(IActivateSpecifiedPiece));
		}

		// Token: 0x0602138C RID: 136076 RVA: 0x00495C64 File Offset: 0x00493E64
		public static IActivateSpecifiedPiece GetRootAsIActivateSpecifiedPiece(ByteBuffer _bb, IActivateSpecifiedPiece obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602138D RID: 136077 RVA: 0x00495C81 File Offset: 0x00493E81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602138E RID: 136078 RVA: 0x00495C90 File Offset: 0x00493E90
		public IActivateSpecifiedPiece __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170096A8 RID: 38568
		// (get) Token: 0x0602138F RID: 136079 RVA: 0x00495CA0 File Offset: 0x00493EA0
		public EJigsawCompleteCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EJigsawCompleteCondition.ActivateAllCorrectPiece;
				}
				return (EJigsawCompleteCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021390 RID: 136080 RVA: 0x00495CDC File Offset: 0x00493EDC
		public IActivateSpecifiedPieceConfig? Config(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActivateSpecifiedPieceConfig?(default(IActivateSpecifiedPieceConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170096A9 RID: 38569
		// (get) Token: 0x06021391 RID: 136081 RVA: 0x00495D3C File Offset: 0x00493F3C
		public int ConfigLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06021392 RID: 136082 RVA: 0x00495D67 File Offset: 0x00493F67
		public static Offset<IActivateSpecifiedPiece> CreateIActivateSpecifiedPiece(FlatBufferBuilder builder, EJigsawCompleteCondition Type = EJigsawCompleteCondition.ActivateAllCorrectPiece, VectorOffset ConfigOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IActivateSpecifiedPiece.AddConfig(builder, ConfigOffset);
			IActivateSpecifiedPiece.AddType(builder, Type);
			return IActivateSpecifiedPiece.EndIActivateSpecifiedPiece(builder);
		}

		// Token: 0x06021393 RID: 136083 RVA: 0x00495D84 File Offset: 0x00493F84
		public static void StartIActivateSpecifiedPiece(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06021394 RID: 136084 RVA: 0x00495D8D File Offset: 0x00493F8D
		public static void AddType(FlatBufferBuilder builder, EJigsawCompleteCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021395 RID: 136085 RVA: 0x00495D98 File Offset: 0x00493F98
		public static void AddConfig(FlatBufferBuilder builder, VectorOffset configOffset)
		{
			builder.AddOffset(1, configOffset.Value, 0);
		}

		// Token: 0x06021396 RID: 136086 RVA: 0x00495DA8 File Offset: 0x00493FA8
		public static VectorOffset CreateConfigVector(FlatBufferBuilder builder, Offset<IActivateSpecifiedPieceConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021397 RID: 136087 RVA: 0x00495DE8 File Offset: 0x00493FE8
		public static VectorOffset CreateConfigVectorBlock(FlatBufferBuilder builder, Offset<IActivateSpecifiedPieceConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActivateSpecifiedPieceConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021398 RID: 136088 RVA: 0x00495E02 File Offset: 0x00494002
		public static VectorOffset CreateConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActivateSpecifiedPieceConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActivateSpecifiedPieceConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021399 RID: 136089 RVA: 0x00495E20 File Offset: 0x00494020
		public static VectorOffset CreateConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActivateSpecifiedPieceConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602139A RID: 136090 RVA: 0x00495E39 File Offset: 0x00494039
		public static void StartConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602139B RID: 136091 RVA: 0x00495E44 File Offset: 0x00494044
		public static Offset<IActivateSpecifiedPiece> EndIActivateSpecifiedPiece(FlatBufferBuilder builder)
		{
			return new Offset<IActivateSpecifiedPiece>(builder.EndTable());
		}

		// Token: 0x0602139C RID: 136092 RVA: 0x00495E54 File Offset: 0x00494054
		public IActivateSpecifiedPieceT UnPack()
		{
			IActivateSpecifiedPieceT activateSpecifiedPieceT = new IActivateSpecifiedPieceT();
			this.UnPackTo(activateSpecifiedPieceT);
			return activateSpecifiedPieceT;
		}

		// Token: 0x0602139D RID: 136093 RVA: 0x00495E70 File Offset: 0x00494070
		public void UnPackTo(IActivateSpecifiedPieceT _o)
		{
			_o.Type = this.Type;
			_o.Config = new List<IActivateSpecifiedPieceConfigT>();
			for (int i = 0; i < this.ConfigLength; i++)
			{
				_o.Config.Add((this.Config(i) != null) ? this.Config(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602139E RID: 136094 RVA: 0x00495EDC File Offset: 0x004940DC
		public static Offset<IActivateSpecifiedPiece> Pack(FlatBufferBuilder builder, IActivateSpecifiedPieceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActivateSpecifiedPiece>);
			}
			VectorOffset configOffset = default(VectorOffset);
			if (_o.Config != null)
			{
				Offset<IActivateSpecifiedPieceConfig>[] array = new Offset<IActivateSpecifiedPieceConfig>[_o.Config.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActivateSpecifiedPieceConfig.Pack(builder, _o.Config[i]);
				}
				configOffset = IActivateSpecifiedPiece.CreateConfigVector(builder, array);
			}
			return IActivateSpecifiedPiece.CreateIActivateSpecifiedPiece(builder, _o.Type, configOffset);
		}

		// Token: 0x0400E75F RID: 59231
		private Table __p;
	}
}
