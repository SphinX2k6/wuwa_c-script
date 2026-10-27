using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058FD RID: 22781
	public struct ISequenceTrackControl : IFlatbufferObject
	{
		// Token: 0x1700AAC0 RID: 43712
		// (get) Token: 0x060267E8 RID: 157672 RVA: 0x0054DD73 File Offset: 0x0054BF73
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060267E9 RID: 157673 RVA: 0x0054DD80 File Offset: 0x0054BF80
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060267EA RID: 157674 RVA: 0x0054DD88 File Offset: 0x0054BF88
		public static ISequenceTrackControl GetRootAsISequenceTrackControl(ByteBuffer _bb)
		{
			return ISequenceTrackControl.GetRootAsISequenceTrackControl(_bb, default(ISequenceTrackControl));
		}

		// Token: 0x060267EB RID: 157675 RVA: 0x0054DDA4 File Offset: 0x0054BFA4
		public static ISequenceTrackControl GetRootAsISequenceTrackControl(ByteBuffer _bb, ISequenceTrackControl obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060267EC RID: 157676 RVA: 0x0054DDC1 File Offset: 0x0054BFC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060267ED RID: 157677 RVA: 0x0054DDD0 File Offset: 0x0054BFD0
		public ISequenceTrackControl __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AAC1 RID: 43713
		// (get) Token: 0x060267EE RID: 157678 RVA: 0x0054DDE0 File Offset: 0x0054BFE0
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

		// Token: 0x1700AAC2 RID: 43714
		// (get) Token: 0x060267EF RID: 157679 RVA: 0x0054DE1C File Offset: 0x0054C01C
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

		// Token: 0x060267F0 RID: 157680 RVA: 0x0054DE53 File Offset: 0x0054C053
		public Span<byte> GetSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060267F1 RID: 157681 RVA: 0x0054DE62 File Offset: 0x0054C062
		public byte[] GetSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060267F2 RID: 157682 RVA: 0x0054DE70 File Offset: 0x0054C070
		public ISequenceTrackControlPoint? ControlPoints(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new ISequenceTrackControlPoint?(default(ISequenceTrackControlPoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AAC3 RID: 43715
		// (get) Token: 0x060267F3 RID: 157683 RVA: 0x0054DED0 File Offset: 0x0054C0D0
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

		// Token: 0x060267F4 RID: 157684 RVA: 0x0054DEFB File Offset: 0x0054C0FB
		public static Offset<ISequenceTrackControl> CreateISequenceTrackControl(FlatBufferBuilder builder, ETrackControlMode Type = ETrackControlMode.Sequence, StringOffset SequenceOffset = default(StringOffset), VectorOffset ControlPointsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ISequenceTrackControl.AddControlPoints(builder, ControlPointsOffset);
			ISequenceTrackControl.AddSequence(builder, SequenceOffset);
			ISequenceTrackControl.AddType(builder, Type);
			return ISequenceTrackControl.EndISequenceTrackControl(builder);
		}

		// Token: 0x060267F5 RID: 157685 RVA: 0x0054DF1F File Offset: 0x0054C11F
		public static void StartISequenceTrackControl(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060267F6 RID: 157686 RVA: 0x0054DF28 File Offset: 0x0054C128
		public static void AddType(FlatBufferBuilder builder, ETrackControlMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060267F7 RID: 157687 RVA: 0x0054DF33 File Offset: 0x0054C133
		public static void AddSequence(FlatBufferBuilder builder, StringOffset sequenceOffset)
		{
			builder.AddOffset(1, sequenceOffset.Value, 0);
		}

		// Token: 0x060267F8 RID: 157688 RVA: 0x0054DF43 File Offset: 0x0054C143
		public static void AddControlPoints(FlatBufferBuilder builder, VectorOffset controlPointsOffset)
		{
			builder.AddOffset(2, controlPointsOffset.Value, 0);
		}

		// Token: 0x060267F9 RID: 157689 RVA: 0x0054DF54 File Offset: 0x0054C154
		public static VectorOffset CreateControlPointsVector(FlatBufferBuilder builder, Offset<ISequenceTrackControlPoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060267FA RID: 157690 RVA: 0x0054DF94 File Offset: 0x0054C194
		public static VectorOffset CreateControlPointsVectorBlock(FlatBufferBuilder builder, Offset<ISequenceTrackControlPoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISequenceTrackControlPoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x060267FB RID: 157691 RVA: 0x0054DFAE File Offset: 0x0054C1AE
		public static VectorOffset CreateControlPointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISequenceTrackControlPoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISequenceTrackControlPoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x060267FC RID: 157692 RVA: 0x0054DFCC File Offset: 0x0054C1CC
		public static VectorOffset CreateControlPointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISequenceTrackControlPoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060267FD RID: 157693 RVA: 0x0054DFE5 File Offset: 0x0054C1E5
		public static void StartControlPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060267FE RID: 157694 RVA: 0x0054DFF0 File Offset: 0x0054C1F0
		public static Offset<ISequenceTrackControl> EndISequenceTrackControl(FlatBufferBuilder builder)
		{
			return new Offset<ISequenceTrackControl>(builder.EndTable());
		}

		// Token: 0x060267FF RID: 157695 RVA: 0x0054E000 File Offset: 0x0054C200
		public ISequenceTrackControlT UnPack()
		{
			ISequenceTrackControlT sequenceTrackControlT = new ISequenceTrackControlT();
			this.UnPackTo(sequenceTrackControlT);
			return sequenceTrackControlT;
		}

		// Token: 0x06026800 RID: 157696 RVA: 0x0054E01C File Offset: 0x0054C21C
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

		// Token: 0x06026801 RID: 157697 RVA: 0x0054E094 File Offset: 0x0054C294
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

		// Token: 0x0400EE9C RID: 61084
		private Table __p;
	}
}
