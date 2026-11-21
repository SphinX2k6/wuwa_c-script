using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F0A RID: 24330
	public struct ISequenceTrackControl : IFlatbufferObject
	{
		// Token: 0x1700B3F4 RID: 46068
		// (get) Token: 0x06028D52 RID: 167250 RVA: 0x005949DF File Offset: 0x00592BDF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028D53 RID: 167251 RVA: 0x005949EC File Offset: 0x00592BEC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028D54 RID: 167252 RVA: 0x005949F4 File Offset: 0x00592BF4
		public static ISequenceTrackControl GetRootAsISequenceTrackControl(ByteBuffer _bb)
		{
			return ISequenceTrackControl.GetRootAsISequenceTrackControl(_bb, default(ISequenceTrackControl));
		}

		// Token: 0x06028D55 RID: 167253 RVA: 0x00594A10 File Offset: 0x00592C10
		public static ISequenceTrackControl GetRootAsISequenceTrackControl(ByteBuffer _bb, ISequenceTrackControl obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028D56 RID: 167254 RVA: 0x00594A2D File Offset: 0x00592C2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028D57 RID: 167255 RVA: 0x00594A3C File Offset: 0x00592C3C
		public ISequenceTrackControl __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B3F5 RID: 46069
		// (get) Token: 0x06028D58 RID: 167256 RVA: 0x00594A4C File Offset: 0x00592C4C
		public ETrackControlMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrackControlMode.Sequence;
				}
				return (ETrackControlMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B3F6 RID: 46070
		// (get) Token: 0x06028D59 RID: 167257 RVA: 0x00594A88 File Offset: 0x00592C88
		public string Sequence
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

		// Token: 0x06028D5A RID: 167258 RVA: 0x00594ABF File Offset: 0x00592CBF
		public Span<byte> GetSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06028D5B RID: 167259 RVA: 0x00594ACE File Offset: 0x00592CCE
		public byte[] GetSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06028D5C RID: 167260 RVA: 0x00594ADC File Offset: 0x00592CDC
		public ISequenceTrackControlPoint? ControlPoints(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new ISequenceTrackControlPoint?(default(ISequenceTrackControlPoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B3F7 RID: 46071
		// (get) Token: 0x06028D5D RID: 167261 RVA: 0x00594B3C File Offset: 0x00592D3C
		public int ControlPointsLength
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

		// Token: 0x06028D5E RID: 167262 RVA: 0x00594B67 File Offset: 0x00592D67
		public static Offset<ISequenceTrackControl> CreateISequenceTrackControl(FlatBufferBuilder builder, ETrackControlMode Type = ETrackControlMode.Sequence, StringOffset SequenceOffset = default(StringOffset), VectorOffset ControlPointsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ISequenceTrackControl.AddControlPoints(builder, ControlPointsOffset);
			ISequenceTrackControl.AddSequence(builder, SequenceOffset);
			ISequenceTrackControl.AddType(builder, Type);
			return ISequenceTrackControl.EndISequenceTrackControl(builder);
		}

		// Token: 0x06028D5F RID: 167263 RVA: 0x00594B8B File Offset: 0x00592D8B
		public static void StartISequenceTrackControl(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06028D60 RID: 167264 RVA: 0x00594B94 File Offset: 0x00592D94
		public static void AddType(FlatBufferBuilder builder, ETrackControlMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028D61 RID: 167265 RVA: 0x00594B9F File Offset: 0x00592D9F
		public static void AddSequence(FlatBufferBuilder builder, StringOffset sequenceOffset)
		{
			builder.AddOffset(1, sequenceOffset.Value, 0);
		}

		// Token: 0x06028D62 RID: 167266 RVA: 0x00594BAF File Offset: 0x00592DAF
		public static void AddControlPoints(FlatBufferBuilder builder, VectorOffset controlPointsOffset)
		{
			builder.AddOffset(2, controlPointsOffset.Value, 0);
		}

		// Token: 0x06028D63 RID: 167267 RVA: 0x00594BC0 File Offset: 0x00592DC0
		public static VectorOffset CreateControlPointsVector(FlatBufferBuilder builder, Offset<ISequenceTrackControlPoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06028D64 RID: 167268 RVA: 0x00594C00 File Offset: 0x00592E00
		public static VectorOffset CreateControlPointsVectorBlock(FlatBufferBuilder builder, Offset<ISequenceTrackControlPoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISequenceTrackControlPoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028D65 RID: 167269 RVA: 0x00594C1A File Offset: 0x00592E1A
		public static VectorOffset CreateControlPointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISequenceTrackControlPoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISequenceTrackControlPoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028D66 RID: 167270 RVA: 0x00594C38 File Offset: 0x00592E38
		public static VectorOffset CreateControlPointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISequenceTrackControlPoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028D67 RID: 167271 RVA: 0x00594C51 File Offset: 0x00592E51
		public static void StartControlPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028D68 RID: 167272 RVA: 0x00594C5C File Offset: 0x00592E5C
		public static Offset<ISequenceTrackControl> EndISequenceTrackControl(FlatBufferBuilder builder)
		{
			return new Offset<ISequenceTrackControl>(builder.EndTable());
		}

		// Token: 0x06028D69 RID: 167273 RVA: 0x00594C6C File Offset: 0x00592E6C
		public ISequenceTrackControlT UnPack()
		{
			ISequenceTrackControlT sequenceTrackControlT = new ISequenceTrackControlT();
			this.UnPackTo(sequenceTrackControlT);
			return sequenceTrackControlT;
		}

		// Token: 0x06028D6A RID: 167274 RVA: 0x00594C88 File Offset: 0x00592E88
		public void UnPackTo(ISequenceTrackControlT _o)
		{
			_o.Type = this.Type;
			_o.Sequence = this.Sequence;
			_o.ControlPoints = new List<ISequenceTrackControlPointT>();
			for (int i = 0; i < this.ControlPointsLength; i++)
			{
				_o.ControlPoints.Add((this.ControlPoints(i) != null) ? this.ControlPoints(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06028D6B RID: 167275 RVA: 0x00594D00 File Offset: 0x00592F00
		public static Offset<ISequenceTrackControl> Pack(FlatBufferBuilder builder, ISequenceTrackControlT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISequenceTrackControl>);
			}
			StringOffset sequenceOffset = (_o.Sequence == null) ? default(StringOffset) : builder.CreateString(_o.Sequence);
			VectorOffset controlPointsOffset = default(VectorOffset);
			if (_o.ControlPoints != null)
			{
				Offset<ISequenceTrackControlPoint>[] array = new Offset<ISequenceTrackControlPoint>[_o.ControlPoints.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISequenceTrackControlPoint.Pack(builder, _o.ControlPoints[i]);
				}
				controlPointsOffset = ISequenceTrackControl.CreateControlPointsVector(builder, array);
			}
			return ISequenceTrackControl.CreateISequenceTrackControl(builder, _o.Type, sequenceOffset, controlPointsOffset);
		}

		// Token: 0x0400FB91 RID: 64401
		private Table __p;
	}
}
