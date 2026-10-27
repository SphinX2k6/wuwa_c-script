using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E50 RID: 20048
	public struct IActiveRenjuPiece : IFlatbufferObject
	{
		// Token: 0x17008F78 RID: 36728
		// (get) Token: 0x0601F772 RID: 128882 RVA: 0x0046228C File Offset: 0x0046048C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F773 RID: 128883 RVA: 0x00462299 File Offset: 0x00460499
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F774 RID: 128884 RVA: 0x004622A0 File Offset: 0x004604A0
		public static IActiveRenjuPiece GetRootAsIActiveRenjuPiece(ByteBuffer _bb)
		{
			return IActiveRenjuPiece.GetRootAsIActiveRenjuPiece(_bb, default(IActiveRenjuPiece));
		}

		// Token: 0x0601F775 RID: 128885 RVA: 0x004622BC File Offset: 0x004604BC
		public static IActiveRenjuPiece GetRootAsIActiveRenjuPiece(ByteBuffer _bb, IActiveRenjuPiece obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F776 RID: 128886 RVA: 0x004622D9 File Offset: 0x004604D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F777 RID: 128887 RVA: 0x004622E8 File Offset: 0x004604E8
		public IActiveRenjuPiece __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F79 RID: 36729
		// (get) Token: 0x0601F778 RID: 128888 RVA: 0x004622F8 File Offset: 0x004604F8
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

		// Token: 0x0601F779 RID: 128889 RVA: 0x00462334 File Offset: 0x00460534
		public IRenjuConfig? RenjuConfig(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IRenjuConfig?(default(IRenjuConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008F7A RID: 36730
		// (get) Token: 0x0601F77A RID: 128890 RVA: 0x00462394 File Offset: 0x00460594
		public int RenjuConfigLength
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

		// Token: 0x0601F77B RID: 128891 RVA: 0x004623C0 File Offset: 0x004605C0
		public IJigsawItemMatchedConfig? ExitMatchedConfig(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IJigsawItemMatchedConfig?(default(IJigsawItemMatchedConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008F7B RID: 36731
		// (get) Token: 0x0601F77C RID: 128892 RVA: 0x00462420 File Offset: 0x00460620
		public int ExitMatchedConfigLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17008F7C RID: 36732
		// (get) Token: 0x0601F77D RID: 128893 RVA: 0x0046244C File Offset: 0x0046064C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F77E RID: 128894 RVA: 0x00462489 File Offset: 0x00460689
		public static Offset<IActiveRenjuPiece> CreateIActiveRenjuPiece(FlatBufferBuilder builder, EJigsawCompleteCondition Type = EJigsawCompleteCondition.ActivateAllCorrectPiece, VectorOffset RenjuConfigOffset = default(VectorOffset), VectorOffset ExitMatchedConfigOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IActiveRenjuPiece.AddExitMatchedConfig(builder, ExitMatchedConfigOffset);
			IActiveRenjuPiece.AddRenjuConfig(builder, RenjuConfigOffset);
			IActiveRenjuPiece.AddNullMask(builder, NullMask);
			IActiveRenjuPiece.AddType(builder, Type);
			return IActiveRenjuPiece.EndIActiveRenjuPiece(builder);
		}

		// Token: 0x0601F77F RID: 128895 RVA: 0x004624B5 File Offset: 0x004606B5
		public static void StartIActiveRenjuPiece(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601F780 RID: 128896 RVA: 0x004624BE File Offset: 0x004606BE
		public static void AddType(FlatBufferBuilder builder, EJigsawCompleteCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F781 RID: 128897 RVA: 0x004624C9 File Offset: 0x004606C9
		public static void AddRenjuConfig(FlatBufferBuilder builder, VectorOffset renjuConfigOffset)
		{
			builder.AddOffset(1, renjuConfigOffset.Value, 0);
		}

		// Token: 0x0601F782 RID: 128898 RVA: 0x004624DC File Offset: 0x004606DC
		public static VectorOffset CreateRenjuConfigVector(FlatBufferBuilder builder, Offset<IRenjuConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601F783 RID: 128899 RVA: 0x0046251C File Offset: 0x0046071C
		public static VectorOffset CreateRenjuConfigVectorBlock(FlatBufferBuilder builder, Offset<IRenjuConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IRenjuConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F784 RID: 128900 RVA: 0x00462536 File Offset: 0x00460736
		public static VectorOffset CreateRenjuConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IRenjuConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IRenjuConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F785 RID: 128901 RVA: 0x00462554 File Offset: 0x00460754
		public static VectorOffset CreateRenjuConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IRenjuConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601F786 RID: 128902 RVA: 0x0046256D File Offset: 0x0046076D
		public static void StartRenjuConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601F787 RID: 128903 RVA: 0x00462578 File Offset: 0x00460778
		public static void AddExitMatchedConfig(FlatBufferBuilder builder, VectorOffset exitMatchedConfigOffset)
		{
			builder.AddOffset(2, exitMatchedConfigOffset.Value, 0);
		}

		// Token: 0x0601F788 RID: 128904 RVA: 0x00462588 File Offset: 0x00460788
		public static VectorOffset CreateExitMatchedConfigVector(FlatBufferBuilder builder, Offset<IJigsawItemMatchedConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601F789 RID: 128905 RVA: 0x004625C8 File Offset: 0x004607C8
		public static VectorOffset CreateExitMatchedConfigVectorBlock(FlatBufferBuilder builder, Offset<IJigsawItemMatchedConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IJigsawItemMatchedConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F78A RID: 128906 RVA: 0x004625E2 File Offset: 0x004607E2
		public static VectorOffset CreateExitMatchedConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IJigsawItemMatchedConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IJigsawItemMatchedConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601F78B RID: 128907 RVA: 0x00462600 File Offset: 0x00460800
		public static VectorOffset CreateExitMatchedConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IJigsawItemMatchedConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601F78C RID: 128908 RVA: 0x00462619 File Offset: 0x00460819
		public static void StartExitMatchedConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601F78D RID: 128909 RVA: 0x00462624 File Offset: 0x00460824
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601F78E RID: 128910 RVA: 0x0046262F File Offset: 0x0046082F
		public static Offset<IActiveRenjuPiece> EndIActiveRenjuPiece(FlatBufferBuilder builder)
		{
			return new Offset<IActiveRenjuPiece>(builder.EndTable());
		}

		// Token: 0x0601F78F RID: 128911 RVA: 0x0046263C File Offset: 0x0046083C
		public IActiveRenjuPieceT UnPack()
		{
			IActiveRenjuPieceT activeRenjuPieceT = new IActiveRenjuPieceT();
			this.UnPackTo(activeRenjuPieceT);
			return activeRenjuPieceT;
		}

		// Token: 0x0601F790 RID: 128912 RVA: 0x00462658 File Offset: 0x00460858
		public void UnPackTo(IActiveRenjuPieceT _o)
		{
			_o.Type = this.Type;
			_o.RenjuConfig = new List<IRenjuConfigT>();
			for (int i = 0; i < this.RenjuConfigLength; i++)
			{
				_o.RenjuConfig.Add((this.RenjuConfig(i) != null) ? this.RenjuConfig(i).Value.UnPack() : null);
			}
			_o.ExitMatchedConfig = new List<IJigsawItemMatchedConfigT>();
			for (int j = 0; j < this.ExitMatchedConfigLength; j++)
			{
				_o.ExitMatchedConfig.Add((this.ExitMatchedConfig(j) != null) ? this.ExitMatchedConfig(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601F791 RID: 128913 RVA: 0x00462724 File Offset: 0x00460924
		public static Offset<IActiveRenjuPiece> Pack(FlatBufferBuilder builder, IActiveRenjuPieceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActiveRenjuPiece>);
			}
			VectorOffset renjuConfigOffset = default(VectorOffset);
			if (_o.RenjuConfig != null)
			{
				Offset<IRenjuConfig>[] array = new Offset<IRenjuConfig>[_o.RenjuConfig.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IRenjuConfig.Pack(builder, _o.RenjuConfig[i]);
				}
				renjuConfigOffset = IActiveRenjuPiece.CreateRenjuConfigVector(builder, array);
			}
			VectorOffset exitMatchedConfigOffset = default(VectorOffset);
			if (_o.ExitMatchedConfig != null)
			{
				Offset<IJigsawItemMatchedConfig>[] array2 = new Offset<IJigsawItemMatchedConfig>[_o.ExitMatchedConfig.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IJigsawItemMatchedConfig.Pack(builder, _o.ExitMatchedConfig[j]);
				}
				exitMatchedConfigOffset = IActiveRenjuPiece.CreateExitMatchedConfigVector(builder, array2);
			}
			return IActiveRenjuPiece.CreateIActiveRenjuPiece(builder, _o.Type, renjuConfigOffset, exitMatchedConfigOffset, _o.NullMask);
		}

		// Token: 0x0400DBEB RID: 56299
		private Table __p;
	}
}
