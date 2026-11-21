using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C45 RID: 23621
	public struct IOnMoveWithSplineEndAttachTiming : IFlatbufferObject
	{
		// Token: 0x1700AD80 RID: 44416
		// (get) Token: 0x06027285 RID: 160389 RVA: 0x0055D71F File Offset: 0x0055B91F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027286 RID: 160390 RVA: 0x0055D72C File Offset: 0x0055B92C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027287 RID: 160391 RVA: 0x0055D734 File Offset: 0x0055B934
		public static IOnMoveWithSplineEndAttachTiming GetRootAsIOnMoveWithSplineEndAttachTiming(ByteBuffer _bb)
		{
			return IOnMoveWithSplineEndAttachTiming.GetRootAsIOnMoveWithSplineEndAttachTiming(_bb, default(IOnMoveWithSplineEndAttachTiming));
		}

		// Token: 0x06027288 RID: 160392 RVA: 0x0055D750 File Offset: 0x0055B950
		public static IOnMoveWithSplineEndAttachTiming GetRootAsIOnMoveWithSplineEndAttachTiming(ByteBuffer _bb, IOnMoveWithSplineEndAttachTiming obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027289 RID: 160393 RVA: 0x0055D76D File Offset: 0x0055B96D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602728A RID: 160394 RVA: 0x0055D77C File Offset: 0x0055B97C
		public IOnMoveWithSplineEndAttachTiming __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AD81 RID: 44417
		// (get) Token: 0x0602728B RID: 160395 RVA: 0x0055D78C File Offset: 0x0055B98C
		public EAttachTimingType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAttachTimingType.Default;
				}
				return (EAttachTimingType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AD82 RID: 44418
		// (get) Token: 0x0602728C RID: 160396 RVA: 0x0055D7C8 File Offset: 0x0055B9C8
		public int SplineEntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602728D RID: 160397 RVA: 0x0055D804 File Offset: 0x0055BA04
		public static Offset<IOnMoveWithSplineEndAttachTiming> CreateIOnMoveWithSplineEndAttachTiming(FlatBufferBuilder builder, EAttachTimingType Type = EAttachTimingType.Default, int SplineEntityId = 0)
		{
			builder.StartTable(2);
			IOnMoveWithSplineEndAttachTiming.AddSplineEntityId(builder, SplineEntityId);
			IOnMoveWithSplineEndAttachTiming.AddType(builder, Type);
			return IOnMoveWithSplineEndAttachTiming.EndIOnMoveWithSplineEndAttachTiming(builder);
		}

		// Token: 0x0602728E RID: 160398 RVA: 0x0055D821 File Offset: 0x0055BA21
		public static void StartIOnMoveWithSplineEndAttachTiming(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602728F RID: 160399 RVA: 0x0055D82A File Offset: 0x0055BA2A
		public static void AddType(FlatBufferBuilder builder, EAttachTimingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027290 RID: 160400 RVA: 0x0055D835 File Offset: 0x0055BA35
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(1, splineEntityId, 0);
		}

		// Token: 0x06027291 RID: 160401 RVA: 0x0055D840 File Offset: 0x0055BA40
		public static Offset<IOnMoveWithSplineEndAttachTiming> EndIOnMoveWithSplineEndAttachTiming(FlatBufferBuilder builder)
		{
			return new Offset<IOnMoveWithSplineEndAttachTiming>(builder.EndTable());
		}

		// Token: 0x06027292 RID: 160402 RVA: 0x0055D850 File Offset: 0x0055BA50
		public IOnMoveWithSplineEndAttachTimingT UnPack()
		{
			IOnMoveWithSplineEndAttachTimingT onMoveWithSplineEndAttachTimingT = new IOnMoveWithSplineEndAttachTimingT();
			this.UnPackTo(onMoveWithSplineEndAttachTimingT);
			return onMoveWithSplineEndAttachTimingT;
		}

		// Token: 0x06027293 RID: 160403 RVA: 0x0055D86B File Offset: 0x0055BA6B
		public void UnPackTo(IOnMoveWithSplineEndAttachTimingT _o)
		{
			_o.Type = this.Type;
			_o.SplineEntityId = this.SplineEntityId;
		}

		// Token: 0x06027294 RID: 160404 RVA: 0x0055D888 File Offset: 0x0055BA88
		public static Offset<IOnMoveWithSplineEndAttachTiming> Pack(FlatBufferBuilder builder, IOnMoveWithSplineEndAttachTimingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOnMoveWithSplineEndAttachTiming>);
			}
			return IOnMoveWithSplineEndAttachTiming.CreateIOnMoveWithSplineEndAttachTiming(builder, _o.Type, _o.SplineEntityId);
		}

		// Token: 0x0400F731 RID: 63281
		private Table __p;
	}
}
