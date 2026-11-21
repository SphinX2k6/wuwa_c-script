using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F0D RID: 24333
	public struct ISequenceTrackControlPoint : IFlatbufferObject
	{
		// Token: 0x1700B3FB RID: 46075
		// (get) Token: 0x06028D74 RID: 167284 RVA: 0x00594E53 File Offset: 0x00593053
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028D75 RID: 167285 RVA: 0x00594E60 File Offset: 0x00593060
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028D76 RID: 167286 RVA: 0x00594E68 File Offset: 0x00593068
		public static ISequenceTrackControlPoint GetRootAsISequenceTrackControlPoint(ByteBuffer _bb)
		{
			return ISequenceTrackControlPoint.GetRootAsISequenceTrackControlPoint(_bb, default(ISequenceTrackControlPoint));
		}

		// Token: 0x06028D77 RID: 167287 RVA: 0x00594E84 File Offset: 0x00593084
		public static ISequenceTrackControlPoint GetRootAsISequenceTrackControlPoint(ByteBuffer _bb, ISequenceTrackControlPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028D78 RID: 167288 RVA: 0x00594EA1 File Offset: 0x005930A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028D79 RID: 167289 RVA: 0x00594EB0 File Offset: 0x005930B0
		public ISequenceTrackControlPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B3FC RID: 46076
		// (get) Token: 0x06028D7A RID: 167290 RVA: 0x00594EC0 File Offset: 0x005930C0
		public string Mark
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028D7B RID: 167291 RVA: 0x00594EF7 File Offset: 0x005930F7
		public Span<byte> GetMarkBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06028D7C RID: 167292 RVA: 0x00594F06 File Offset: 0x00593106
		public byte[] GetMarkArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06028D7D RID: 167293 RVA: 0x00594F14 File Offset: 0x00593114
		public static Offset<ISequenceTrackControlPoint> CreateISequenceTrackControlPoint(FlatBufferBuilder builder, StringOffset MarkOffset = default(StringOffset))
		{
			builder.StartTable(1);
			ISequenceTrackControlPoint.AddMark(builder, MarkOffset);
			return ISequenceTrackControlPoint.EndISequenceTrackControlPoint(builder);
		}

		// Token: 0x06028D7E RID: 167294 RVA: 0x00594F2A File Offset: 0x0059312A
		public static void StartISequenceTrackControlPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06028D7F RID: 167295 RVA: 0x00594F33 File Offset: 0x00593133
		public static void AddMark(FlatBufferBuilder builder, StringOffset markOffset)
		{
			builder.AddOffset(0, markOffset.Value, 0);
		}

		// Token: 0x06028D80 RID: 167296 RVA: 0x00594F43 File Offset: 0x00593143
		public static Offset<ISequenceTrackControlPoint> EndISequenceTrackControlPoint(FlatBufferBuilder builder)
		{
			return new Offset<ISequenceTrackControlPoint>(builder.EndTable());
		}

		// Token: 0x06028D81 RID: 167297 RVA: 0x00594F50 File Offset: 0x00593150
		public ISequenceTrackControlPointT UnPack()
		{
			ISequenceTrackControlPointT sequenceTrackControlPointT = new ISequenceTrackControlPointT();
			this.UnPackTo(sequenceTrackControlPointT);
			return sequenceTrackControlPointT;
		}

		// Token: 0x06028D82 RID: 167298 RVA: 0x00594F6B File Offset: 0x0059316B
		public void UnPackTo(ISequenceTrackControlPointT _o)
		{
			_o.Mark = this.Mark;
		}

		// Token: 0x06028D83 RID: 167299 RVA: 0x00594F7C File Offset: 0x0059317C
		public static Offset<ISequenceTrackControlPoint> Pack(FlatBufferBuilder builder, ISequenceTrackControlPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISequenceTrackControlPoint>);
			}
			StringOffset markOffset = (_o.Mark == null) ? default(StringOffset) : builder.CreateString(_o.Mark);
			return ISequenceTrackControlPoint.CreateISequenceTrackControlPoint(builder, markOffset);
		}

		// Token: 0x0400FB95 RID: 64405
		private Table __p;
	}
}
