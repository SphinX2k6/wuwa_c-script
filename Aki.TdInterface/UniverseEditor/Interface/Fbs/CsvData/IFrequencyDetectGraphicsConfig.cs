using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D82 RID: 19842
	public struct IFrequencyDetectGraphicsConfig : IFlatbufferObject
	{
		// Token: 0x17008DF7 RID: 36343
		// (get) Token: 0x0601EC25 RID: 125989 RVA: 0x0044D164 File Offset: 0x0044B364
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EC26 RID: 125990 RVA: 0x0044D171 File Offset: 0x0044B371
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EC27 RID: 125991 RVA: 0x0044D178 File Offset: 0x0044B378
		public static IFrequencyDetectGraphicsConfig GetRootAsIFrequencyDetectGraphicsConfig(ByteBuffer _bb)
		{
			return IFrequencyDetectGraphicsConfig.GetRootAsIFrequencyDetectGraphicsConfig(_bb, default(IFrequencyDetectGraphicsConfig));
		}

		// Token: 0x0601EC28 RID: 125992 RVA: 0x0044D194 File Offset: 0x0044B394
		public static IFrequencyDetectGraphicsConfig GetRootAsIFrequencyDetectGraphicsConfig(ByteBuffer _bb, IFrequencyDetectGraphicsConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EC29 RID: 125993 RVA: 0x0044D1B1 File Offset: 0x0044B3B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EC2A RID: 125994 RVA: 0x0044D1C0 File Offset: 0x0044B3C0
		public IFrequencyDetectGraphicsConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008DF8 RID: 36344
		// (get) Token: 0x0601EC2B RID: 125995 RVA: 0x0044D1D0 File Offset: 0x0044B3D0
		public IFrequencyDetectGraphicsConfig_Canvas? Canvas
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IFrequencyDetectGraphicsConfig_Canvas?(default(IFrequencyDetectGraphicsConfig_Canvas).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601EC2C RID: 125996 RVA: 0x0044D230 File Offset: 0x0044B430
		public IFrequencyDetectGraphicsLine? Lines(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IFrequencyDetectGraphicsLine?(default(IFrequencyDetectGraphicsLine).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008DF9 RID: 36345
		// (get) Token: 0x0601EC2D RID: 125997 RVA: 0x0044D290 File Offset: 0x0044B490
		public int LinesLength
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

		// Token: 0x0601EC2E RID: 125998 RVA: 0x0044D2BB File Offset: 0x0044B4BB
		public static Offset<IFrequencyDetectGraphicsConfig> CreateIFrequencyDetectGraphicsConfig(FlatBufferBuilder builder, Offset<IFrequencyDetectGraphicsConfig_Canvas> CanvasOffset = default(Offset<IFrequencyDetectGraphicsConfig_Canvas>), VectorOffset LinesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IFrequencyDetectGraphicsConfig.AddLines(builder, LinesOffset);
			IFrequencyDetectGraphicsConfig.AddCanvas(builder, CanvasOffset);
			return IFrequencyDetectGraphicsConfig.EndIFrequencyDetectGraphicsConfig(builder);
		}

		// Token: 0x0601EC2F RID: 125999 RVA: 0x0044D2D8 File Offset: 0x0044B4D8
		public static void StartIFrequencyDetectGraphicsConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601EC30 RID: 126000 RVA: 0x0044D2E1 File Offset: 0x0044B4E1
		public static void AddCanvas(FlatBufferBuilder builder, Offset<IFrequencyDetectGraphicsConfig_Canvas> canvasOffset)
		{
			builder.AddOffset(0, canvasOffset.Value, 0);
		}

		// Token: 0x0601EC31 RID: 126001 RVA: 0x0044D2F1 File Offset: 0x0044B4F1
		public static void AddLines(FlatBufferBuilder builder, VectorOffset linesOffset)
		{
			builder.AddOffset(1, linesOffset.Value, 0);
		}

		// Token: 0x0601EC32 RID: 126002 RVA: 0x0044D304 File Offset: 0x0044B504
		public static VectorOffset CreateLinesVector(FlatBufferBuilder builder, Offset<IFrequencyDetectGraphicsLine>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601EC33 RID: 126003 RVA: 0x0044D344 File Offset: 0x0044B544
		public static VectorOffset CreateLinesVectorBlock(FlatBufferBuilder builder, Offset<IFrequencyDetectGraphicsLine>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFrequencyDetectGraphicsLine>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601EC34 RID: 126004 RVA: 0x0044D35E File Offset: 0x0044B55E
		public static VectorOffset CreateLinesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFrequencyDetectGraphicsLine>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFrequencyDetectGraphicsLine>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601EC35 RID: 126005 RVA: 0x0044D37C File Offset: 0x0044B57C
		public static VectorOffset CreateLinesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFrequencyDetectGraphicsLine>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601EC36 RID: 126006 RVA: 0x0044D395 File Offset: 0x0044B595
		public static void StartLinesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601EC37 RID: 126007 RVA: 0x0044D3A0 File Offset: 0x0044B5A0
		public static Offset<IFrequencyDetectGraphicsConfig> EndIFrequencyDetectGraphicsConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFrequencyDetectGraphicsConfig>(builder.EndTable());
		}

		// Token: 0x0601EC38 RID: 126008 RVA: 0x0044D3B0 File Offset: 0x0044B5B0
		public IFrequencyDetectGraphicsConfigT UnPack()
		{
			IFrequencyDetectGraphicsConfigT frequencyDetectGraphicsConfigT = new IFrequencyDetectGraphicsConfigT();
			this.UnPackTo(frequencyDetectGraphicsConfigT);
			return frequencyDetectGraphicsConfigT;
		}

		// Token: 0x0601EC39 RID: 126009 RVA: 0x0044D3CC File Offset: 0x0044B5CC
		public void UnPackTo(IFrequencyDetectGraphicsConfigT _o)
		{
			_o.Canvas = ((this.Canvas != null) ? this.Canvas.Value.UnPack() : null);
			_o.Lines = new List<IFrequencyDetectGraphicsLineT>();
			for (int i = 0; i < this.LinesLength; i++)
			{
				_o.Lines.Add((this.Lines(i) != null) ? this.Lines(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601EC3A RID: 126010 RVA: 0x0044D45C File Offset: 0x0044B65C
		public static Offset<IFrequencyDetectGraphicsConfig> Pack(FlatBufferBuilder builder, IFrequencyDetectGraphicsConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFrequencyDetectGraphicsConfig>);
			}
			Offset<IFrequencyDetectGraphicsConfig_Canvas> canvasOffset = (_o.Canvas == null) ? default(Offset<IFrequencyDetectGraphicsConfig_Canvas>) : IFrequencyDetectGraphicsConfig_Canvas.Pack(builder, _o.Canvas);
			VectorOffset linesOffset = default(VectorOffset);
			if (_o.Lines != null)
			{
				Offset<IFrequencyDetectGraphicsLine>[] array = new Offset<IFrequencyDetectGraphicsLine>[_o.Lines.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IFrequencyDetectGraphicsLine.Pack(builder, _o.Lines[i]);
				}
				linesOffset = IFrequencyDetectGraphicsConfig.CreateLinesVector(builder, array);
			}
			return IFrequencyDetectGraphicsConfig.CreateIFrequencyDetectGraphicsConfig(builder, canvasOffset, linesOffset);
		}

		// Token: 0x0400D9D6 RID: 55766
		private Table __p;
	}
}
