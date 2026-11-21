using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005361 RID: 21345
	public struct IActiveRenjuPiece : IFlatbufferObject
	{
		// Token: 0x170096B1 RID: 38577
		// (get) Token: 0x060213BD RID: 136125 RVA: 0x004962A4 File Offset: 0x004944A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060213BE RID: 136126 RVA: 0x004962B1 File Offset: 0x004944B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060213BF RID: 136127 RVA: 0x004962B8 File Offset: 0x004944B8
		public static IActiveRenjuPiece GetRootAsIActiveRenjuPiece(ByteBuffer _bb)
		{
			return IActiveRenjuPiece.GetRootAsIActiveRenjuPiece(_bb, default(IActiveRenjuPiece));
		}

		// Token: 0x060213C0 RID: 136128 RVA: 0x004962D4 File Offset: 0x004944D4
		public static IActiveRenjuPiece GetRootAsIActiveRenjuPiece(ByteBuffer _bb, IActiveRenjuPiece obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060213C1 RID: 136129 RVA: 0x004962F1 File Offset: 0x004944F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060213C2 RID: 136130 RVA: 0x00496300 File Offset: 0x00494500
		public IActiveRenjuPiece __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170096B2 RID: 38578
		// (get) Token: 0x060213C3 RID: 136131 RVA: 0x00496310 File Offset: 0x00494510
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

		// Token: 0x060213C4 RID: 136132 RVA: 0x0049634C File Offset: 0x0049454C
		public IRenjuConfig? RenjuConfig(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IRenjuConfig?(default(IRenjuConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170096B3 RID: 38579
		// (get) Token: 0x060213C5 RID: 136133 RVA: 0x004963AC File Offset: 0x004945AC
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

		// Token: 0x060213C6 RID: 136134 RVA: 0x004963D8 File Offset: 0x004945D8
		public IJigsawItemMatchedConfig? ExitMatchedConfig(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IJigsawItemMatchedConfig?(default(IJigsawItemMatchedConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170096B4 RID: 38580
		// (get) Token: 0x060213C7 RID: 136135 RVA: 0x00496438 File Offset: 0x00494638
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

		// Token: 0x170096B5 RID: 38581
		// (get) Token: 0x060213C8 RID: 136136 RVA: 0x00496464 File Offset: 0x00494664
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

		// Token: 0x060213C9 RID: 136137 RVA: 0x004964A1 File Offset: 0x004946A1
		public static Offset<IActiveRenjuPiece> CreateIActiveRenjuPiece(FlatBufferBuilder builder, EJigsawCompleteCondition Type = EJigsawCompleteCondition.ActivateAllCorrectPiece, VectorOffset RenjuConfigOffset = default(VectorOffset), VectorOffset ExitMatchedConfigOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IActiveRenjuPiece.AddExitMatchedConfig(builder, ExitMatchedConfigOffset);
			IActiveRenjuPiece.AddRenjuConfig(builder, RenjuConfigOffset);
			IActiveRenjuPiece.AddNullMask(builder, NullMask);
			IActiveRenjuPiece.AddType(builder, Type);
			return IActiveRenjuPiece.EndIActiveRenjuPiece(builder);
		}

		// Token: 0x060213CA RID: 136138 RVA: 0x004964CD File Offset: 0x004946CD
		public static void StartIActiveRenjuPiece(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060213CB RID: 136139 RVA: 0x004964D6 File Offset: 0x004946D6
		public static void AddType(FlatBufferBuilder builder, EJigsawCompleteCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060213CC RID: 136140 RVA: 0x004964E1 File Offset: 0x004946E1
		public static void AddRenjuConfig(FlatBufferBuilder builder, VectorOffset renjuConfigOffset)
		{
			builder.AddOffset(1, renjuConfigOffset.Value, 0);
		}

		// Token: 0x060213CD RID: 136141 RVA: 0x004964F4 File Offset: 0x004946F4
		public static VectorOffset CreateRenjuConfigVector(FlatBufferBuilder builder, Offset<IRenjuConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060213CE RID: 136142 RVA: 0x00496534 File Offset: 0x00494734
		public static VectorOffset CreateRenjuConfigVectorBlock(FlatBufferBuilder builder, Offset<IRenjuConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IRenjuConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060213CF RID: 136143 RVA: 0x0049654E File Offset: 0x0049474E
		public static VectorOffset CreateRenjuConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IRenjuConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IRenjuConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060213D0 RID: 136144 RVA: 0x0049656C File Offset: 0x0049476C
		public static VectorOffset CreateRenjuConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IRenjuConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060213D1 RID: 136145 RVA: 0x00496585 File Offset: 0x00494785
		public static void StartRenjuConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060213D2 RID: 136146 RVA: 0x00496590 File Offset: 0x00494790
		public static void AddExitMatchedConfig(FlatBufferBuilder builder, VectorOffset exitMatchedConfigOffset)
		{
			builder.AddOffset(2, exitMatchedConfigOffset.Value, 0);
		}

		// Token: 0x060213D3 RID: 136147 RVA: 0x004965A0 File Offset: 0x004947A0
		public static VectorOffset CreateExitMatchedConfigVector(FlatBufferBuilder builder, Offset<IJigsawItemMatchedConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060213D4 RID: 136148 RVA: 0x004965E0 File Offset: 0x004947E0
		public static VectorOffset CreateExitMatchedConfigVectorBlock(FlatBufferBuilder builder, Offset<IJigsawItemMatchedConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IJigsawItemMatchedConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060213D5 RID: 136149 RVA: 0x004965FA File Offset: 0x004947FA
		public static VectorOffset CreateExitMatchedConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IJigsawItemMatchedConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IJigsawItemMatchedConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060213D6 RID: 136150 RVA: 0x00496618 File Offset: 0x00494818
		public static VectorOffset CreateExitMatchedConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IJigsawItemMatchedConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060213D7 RID: 136151 RVA: 0x00496631 File Offset: 0x00494831
		public static void StartExitMatchedConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060213D8 RID: 136152 RVA: 0x0049663C File Offset: 0x0049483C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060213D9 RID: 136153 RVA: 0x00496647 File Offset: 0x00494847
		public static Offset<IActiveRenjuPiece> EndIActiveRenjuPiece(FlatBufferBuilder builder)
		{
			return new Offset<IActiveRenjuPiece>(builder.EndTable());
		}

		// Token: 0x060213DA RID: 136154 RVA: 0x00496654 File Offset: 0x00494854
		public IActiveRenjuPieceT UnPack()
		{
			IActiveRenjuPieceT activeRenjuPieceT = new IActiveRenjuPieceT();
			this.UnPackTo(activeRenjuPieceT);
			return activeRenjuPieceT;
		}

		// Token: 0x060213DB RID: 136155 RVA: 0x00496670 File Offset: 0x00494870
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

		// Token: 0x060213DC RID: 136156 RVA: 0x0049673C File Offset: 0x0049493C
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

		// Token: 0x0400E765 RID: 59237
		private Table __p;
	}
}
