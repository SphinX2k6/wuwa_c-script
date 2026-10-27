using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E4A RID: 20042
	public struct IActivateSpecifiedPiece : IFlatbufferObject
	{
		// Token: 0x17008F6E RID: 36718
		// (get) Token: 0x0601F73E RID: 128830 RVA: 0x00461C19 File Offset: 0x0045FE19
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F73F RID: 128831 RVA: 0x00461C26 File Offset: 0x0045FE26
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F740 RID: 128832 RVA: 0x00461C30 File Offset: 0x0045FE30
		public static IActivateSpecifiedPiece GetRootAsIActivateSpecifiedPiece(ByteBuffer _bb)
		{
			return IActivateSpecifiedPiece.GetRootAsIActivateSpecifiedPiece(_bb, default(IActivateSpecifiedPiece));
		}

		// Token: 0x0601F741 RID: 128833 RVA: 0x00461C4C File Offset: 0x0045FE4C
		public static IActivateSpecifiedPiece GetRootAsIActivateSpecifiedPiece(ByteBuffer _bb, IActivateSpecifiedPiece obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F742 RID: 128834 RVA: 0x00461C69 File Offset: 0x0045FE69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F743 RID: 128835 RVA: 0x00461C78 File Offset: 0x0045FE78
		public IActivateSpecifiedPiece __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F6F RID: 36719
		// (get) Token: 0x0601F744 RID: 128836 RVA: 0x00461C88 File Offset: 0x0045FE88
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

		// Token: 0x0601F745 RID: 128837 RVA: 0x00461CC4 File Offset: 0x0045FEC4
		public IActivateSpecifiedPieceConfig? Config(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActivateSpecifiedPieceConfig?(default(IActivateSpecifiedPieceConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008F70 RID: 36720
		// (get) Token: 0x0601F746 RID: 128838 RVA: 0x00461D24 File Offset: 0x0045FF24
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

		// Token: 0x0601F747 RID: 128839 RVA: 0x00461D4F File Offset: 0x0045FF4F
		public static Offset<IActivateSpecifiedPiece> CreateIActivateSpecifiedPiece(FlatBufferBuilder builder, EJigsawCompleteCondition Type = EJigsawCompleteCondition.ActivateAllCorrectPiece, VectorOffset ConfigOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IActivateSpecifiedPiece.AddConfig(builder, ConfigOffset);
			IActivateSpecifiedPiece.AddType(builder, Type);
			return IActivateSpecifiedPiece.EndIActivateSpecifiedPiece(builder);
		}

		// Token: 0x0601F748 RID: 128840 RVA: 0x00461D6C File Offset: 0x0045FF6C
		public static void StartIActivateSpecifiedPiece(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F749 RID: 128841 RVA: 0x00461D75 File Offset: 0x0045FF75
		public static void AddType(FlatBufferBuilder builder, EJigsawCompleteCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F74A RID: 128842 RVA: 0x00461D80 File Offset: 0x0045FF80
		public static void AddConfig(FlatBufferBuilder builder, VectorOffset configOffset)
		{
			builder.AddOffset(1, configOffset.Value, 0);
		}

		// Token: 0x0601F74B RID: 128843 RVA: 0x00461D90 File Offset: 0x0045FF90
		public static VectorOffset CreateConfigVector(FlatBufferBuilder builder, Offset<IActivateSpecifiedPieceConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601F74C RID: 128844 RVA: 0x00461DD0 File Offset: 0x0045FFD0
		public static VectorOffset CreateConfigVectorBlock(FlatBufferBuilder builder, Offset<IActivateSpecifiedPieceConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActivateSpecifiedPieceConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F74D RID: 128845 RVA: 0x00461DEA File Offset: 0x0045FFEA
		public static VectorOffset CreateConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActivateSpecifiedPieceConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActivateSpecifiedPieceConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F74E RID: 128846 RVA: 0x00461E08 File Offset: 0x00460008
		public static VectorOffset CreateConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActivateSpecifiedPieceConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601F74F RID: 128847 RVA: 0x00461E21 File Offset: 0x00460021
		public static void StartConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601F750 RID: 128848 RVA: 0x00461E2C File Offset: 0x0046002C
		public static Offset<IActivateSpecifiedPiece> EndIActivateSpecifiedPiece(FlatBufferBuilder builder)
		{
			return new Offset<IActivateSpecifiedPiece>(builder.EndTable());
		}

		// Token: 0x0601F751 RID: 128849 RVA: 0x00461E3C File Offset: 0x0046003C
		public IActivateSpecifiedPieceT UnPack()
		{
			IActivateSpecifiedPieceT activateSpecifiedPieceT = new IActivateSpecifiedPieceT();
			this.UnPackTo(activateSpecifiedPieceT);
			return activateSpecifiedPieceT;
		}

		// Token: 0x0601F752 RID: 128850 RVA: 0x00461E58 File Offset: 0x00460058
		public void UnPackTo(IActivateSpecifiedPieceT _o)
		{
			_o.Type = this.Type;
			_o.Config = new List<IActivateSpecifiedPieceConfigT>();
			for (int i = 0; i < this.ConfigLength; i++)
			{
				_o.Config.Add((this.Config(i) != null) ? this.Config(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601F753 RID: 128851 RVA: 0x00461EC4 File Offset: 0x004600C4
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

		// Token: 0x0400DBE5 RID: 56293
		private Table __p;
	}
}
