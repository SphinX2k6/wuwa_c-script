using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C8D RID: 27789
	public struct IPerformerAiSplineMove : IFlatbufferObject
	{
		// Token: 0x1700CEEF RID: 52975
		// (get) Token: 0x06030F79 RID: 200569 RVA: 0x006A5F00 File Offset: 0x006A4100
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030F7A RID: 200570 RVA: 0x006A5F0D File Offset: 0x006A410D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030F7B RID: 200571 RVA: 0x006A5F14 File Offset: 0x006A4114
		public static IPerformerAiSplineMove GetRootAsIPerformerAiSplineMove(ByteBuffer _bb)
		{
			return IPerformerAiSplineMove.GetRootAsIPerformerAiSplineMove(_bb, default(IPerformerAiSplineMove));
		}

		// Token: 0x06030F7C RID: 200572 RVA: 0x006A5F30 File Offset: 0x006A4130
		public static IPerformerAiSplineMove GetRootAsIPerformerAiSplineMove(ByteBuffer _bb, IPerformerAiSplineMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030F7D RID: 200573 RVA: 0x006A5F4D File Offset: 0x006A414D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030F7E RID: 200574 RVA: 0x006A5F5C File Offset: 0x006A415C
		public IPerformerAiSplineMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CEF0 RID: 52976
		// (get) Token: 0x06030F7F RID: 200575 RVA: 0x006A5F6C File Offset: 0x006A416C
		public int SplineEntityId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CEF1 RID: 52977
		// (get) Token: 0x06030F80 RID: 200576 RVA: 0x006A5FA8 File Offset: 0x006A41A8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030F81 RID: 200577 RVA: 0x006A5FE4 File Offset: 0x006A41E4
		public static Offset<IPerformerAiSplineMove> CreateIPerformerAiSplineMove(FlatBufferBuilder builder, int SplineEntityId = 0, byte NullMask = 0)
		{
			builder.StartTable(2);
			IPerformerAiSplineMove.AddSplineEntityId(builder, SplineEntityId);
			IPerformerAiSplineMove.AddNullMask(builder, NullMask);
			return IPerformerAiSplineMove.EndIPerformerAiSplineMove(builder);
		}

		// Token: 0x06030F82 RID: 200578 RVA: 0x006A6001 File Offset: 0x006A4201
		public static void StartIPerformerAiSplineMove(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030F83 RID: 200579 RVA: 0x006A600A File Offset: 0x006A420A
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(0, splineEntityId, 0);
		}

		// Token: 0x06030F84 RID: 200580 RVA: 0x006A6015 File Offset: 0x006A4215
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x06030F85 RID: 200581 RVA: 0x006A6020 File Offset: 0x006A4220
		public static Offset<IPerformerAiSplineMove> EndIPerformerAiSplineMove(FlatBufferBuilder builder)
		{
			return new Offset<IPerformerAiSplineMove>(builder.EndTable());
		}

		// Token: 0x06030F86 RID: 200582 RVA: 0x006A6030 File Offset: 0x006A4230
		public IPerformerAiSplineMoveT UnPack()
		{
			IPerformerAiSplineMoveT performerAiSplineMoveT = new IPerformerAiSplineMoveT();
			this.UnPackTo(performerAiSplineMoveT);
			return performerAiSplineMoveT;
		}

		// Token: 0x06030F87 RID: 200583 RVA: 0x006A604B File Offset: 0x006A424B
		public void UnPackTo(IPerformerAiSplineMoveT _o)
		{
			_o.SplineEntityId = this.SplineEntityId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06030F88 RID: 200584 RVA: 0x006A6068 File Offset: 0x006A4268
		public static Offset<IPerformerAiSplineMove> Pack(FlatBufferBuilder builder, IPerformerAiSplineMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformerAiSplineMove>);
			}
			return IPerformerAiSplineMove.CreateIPerformerAiSplineMove(builder, _o.SplineEntityId, _o.NullMask);
		}

		// Token: 0x040115E1 RID: 71137
		private Table __p;
	}
}
