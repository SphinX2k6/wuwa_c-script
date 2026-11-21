using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073F4 RID: 29684
	public struct IPerformerAiSplineMove : IFlatbufferObject
	{
		// Token: 0x1700DA0A RID: 55818
		// (get) Token: 0x06033ED4 RID: 212692 RVA: 0x00700400 File Offset: 0x006FE600
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033ED5 RID: 212693 RVA: 0x0070040D File Offset: 0x006FE60D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033ED6 RID: 212694 RVA: 0x00700414 File Offset: 0x006FE614
		public static IPerformerAiSplineMove GetRootAsIPerformerAiSplineMove(ByteBuffer _bb)
		{
			return IPerformerAiSplineMove.GetRootAsIPerformerAiSplineMove(_bb, default(IPerformerAiSplineMove));
		}

		// Token: 0x06033ED7 RID: 212695 RVA: 0x00700430 File Offset: 0x006FE630
		public static IPerformerAiSplineMove GetRootAsIPerformerAiSplineMove(ByteBuffer _bb, IPerformerAiSplineMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033ED8 RID: 212696 RVA: 0x0070044D File Offset: 0x006FE64D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033ED9 RID: 212697 RVA: 0x0070045C File Offset: 0x006FE65C
		public IPerformerAiSplineMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DA0B RID: 55819
		// (get) Token: 0x06033EDA RID: 212698 RVA: 0x0070046C File Offset: 0x006FE66C
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

		// Token: 0x1700DA0C RID: 55820
		// (get) Token: 0x06033EDB RID: 212699 RVA: 0x007004A8 File Offset: 0x006FE6A8
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

		// Token: 0x06033EDC RID: 212700 RVA: 0x007004E4 File Offset: 0x006FE6E4
		public static Offset<IPerformerAiSplineMove> CreateIPerformerAiSplineMove(FlatBufferBuilder builder, int SplineEntityId = 0, byte NullMask = 0)
		{
			builder.StartTable(2);
			IPerformerAiSplineMove.AddSplineEntityId(builder, SplineEntityId);
			IPerformerAiSplineMove.AddNullMask(builder, NullMask);
			return IPerformerAiSplineMove.EndIPerformerAiSplineMove(builder);
		}

		// Token: 0x06033EDD RID: 212701 RVA: 0x00700501 File Offset: 0x006FE701
		public static void StartIPerformerAiSplineMove(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033EDE RID: 212702 RVA: 0x0070050A File Offset: 0x006FE70A
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(0, splineEntityId, 0);
		}

		// Token: 0x06033EDF RID: 212703 RVA: 0x00700515 File Offset: 0x006FE715
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x06033EE0 RID: 212704 RVA: 0x00700520 File Offset: 0x006FE720
		public static Offset<IPerformerAiSplineMove> EndIPerformerAiSplineMove(FlatBufferBuilder builder)
		{
			return new Offset<IPerformerAiSplineMove>(builder.EndTable());
		}

		// Token: 0x06033EE1 RID: 212705 RVA: 0x00700530 File Offset: 0x006FE730
		public IPerformerAiSplineMoveT UnPack()
		{
			IPerformerAiSplineMoveT performerAiSplineMoveT = new IPerformerAiSplineMoveT();
			this.UnPackTo(performerAiSplineMoveT);
			return performerAiSplineMoveT;
		}

		// Token: 0x06033EE2 RID: 212706 RVA: 0x0070054B File Offset: 0x006FE74B
		public void UnPackTo(IPerformerAiSplineMoveT _o)
		{
			_o.SplineEntityId = this.SplineEntityId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06033EE3 RID: 212707 RVA: 0x00700568 File Offset: 0x006FE768
		public static Offset<IPerformerAiSplineMove> Pack(FlatBufferBuilder builder, IPerformerAiSplineMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformerAiSplineMove>);
			}
			return IPerformerAiSplineMove.CreateIPerformerAiSplineMove(builder, _o.SplineEntityId, _o.NullMask);
		}

		// Token: 0x04012539 RID: 75065
		private Table __p;
	}
}
