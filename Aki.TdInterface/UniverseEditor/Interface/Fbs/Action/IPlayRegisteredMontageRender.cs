using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D38 RID: 27960
	public struct IPlayRegisteredMontageRender : IFlatbufferObject
	{
		// Token: 0x1700D063 RID: 53347
		// (get) Token: 0x06031579 RID: 202105 RVA: 0x006B133D File Offset: 0x006AF53D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603157A RID: 202106 RVA: 0x006B134A File Offset: 0x006AF54A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603157B RID: 202107 RVA: 0x006B1354 File Offset: 0x006AF554
		public static IPlayRegisteredMontageRender GetRootAsIPlayRegisteredMontageRender(ByteBuffer _bb)
		{
			return IPlayRegisteredMontageRender.GetRootAsIPlayRegisteredMontageRender(_bb, default(IPlayRegisteredMontageRender));
		}

		// Token: 0x0603157C RID: 202108 RVA: 0x006B1370 File Offset: 0x006AF570
		public static IPlayRegisteredMontageRender GetRootAsIPlayRegisteredMontageRender(ByteBuffer _bb, IPlayRegisteredMontageRender obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603157D RID: 202109 RVA: 0x006B138D File Offset: 0x006AF58D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603157E RID: 202110 RVA: 0x006B139C File Offset: 0x006AF59C
		public IPlayRegisteredMontageRender __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D064 RID: 53348
		// (get) Token: 0x0603157F RID: 202111 RVA: 0x006B13AC File Offset: 0x006AF5AC
		public int EntityId
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

		// Token: 0x1700D065 RID: 53349
		// (get) Token: 0x06031580 RID: 202112 RVA: 0x006B13E8 File Offset: 0x006AF5E8
		public bool IsOverlayMontage
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D066 RID: 53350
		// (get) Token: 0x06031581 RID: 202113 RVA: 0x006B1428 File Offset: 0x006AF628
		public IMontageId? MontageId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IMontageId?(default(IMontageId).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D067 RID: 53351
		// (get) Token: 0x06031582 RID: 202114 RVA: 0x006B1488 File Offset: 0x006AF688
		public int FaceExpressionId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D068 RID: 53352
		// (get) Token: 0x06031583 RID: 202115 RVA: 0x006B14C8 File Offset: 0x006AF6C8
		public float LoopDuration
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D069 RID: 53353
		// (get) Token: 0x06031584 RID: 202116 RVA: 0x006B150C File Offset: 0x006AF70C
		public int RepeatTimes
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D06A RID: 53354
		// (get) Token: 0x06031585 RID: 202117 RVA: 0x006B154C File Offset: 0x006AF74C
		public bool KeepMontageWhenEnd
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D06B RID: 53355
		// (get) Token: 0x06031586 RID: 202118 RVA: 0x006B158C File Offset: 0x006AF78C
		public bool KeepMontageAfterFlow
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D06C RID: 53356
		// (get) Token: 0x06031587 RID: 202119 RVA: 0x006B15CC File Offset: 0x006AF7CC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031588 RID: 202120 RVA: 0x006B160C File Offset: 0x006AF80C
		public static Offset<IPlayRegisteredMontageRender> CreateIPlayRegisteredMontageRender(FlatBufferBuilder builder, int EntityId = 0, bool IsOverlayMontage = false, Offset<IMontageId> MontageIdOffset = default(Offset<IMontageId>), int FaceExpressionId = 0, float LoopDuration = 0f, int RepeatTimes = 0, bool KeepMontageWhenEnd = false, bool KeepMontageAfterFlow = false, byte NullMask = 0)
		{
			builder.StartTable(9);
			IPlayRegisteredMontageRender.AddRepeatTimes(builder, RepeatTimes);
			IPlayRegisteredMontageRender.AddLoopDuration(builder, LoopDuration);
			IPlayRegisteredMontageRender.AddFaceExpressionId(builder, FaceExpressionId);
			IPlayRegisteredMontageRender.AddMontageId(builder, MontageIdOffset);
			IPlayRegisteredMontageRender.AddEntityId(builder, EntityId);
			IPlayRegisteredMontageRender.AddNullMask(builder, NullMask);
			IPlayRegisteredMontageRender.AddKeepMontageAfterFlow(builder, KeepMontageAfterFlow);
			IPlayRegisteredMontageRender.AddKeepMontageWhenEnd(builder, KeepMontageWhenEnd);
			IPlayRegisteredMontageRender.AddIsOverlayMontage(builder, IsOverlayMontage);
			return IPlayRegisteredMontageRender.EndIPlayRegisteredMontageRender(builder);
		}

		// Token: 0x06031589 RID: 202121 RVA: 0x006B166C File Offset: 0x006AF86C
		public static void StartIPlayRegisteredMontageRender(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0603158A RID: 202122 RVA: 0x006B1676 File Offset: 0x006AF876
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x0603158B RID: 202123 RVA: 0x006B1681 File Offset: 0x006AF881
		public static void AddIsOverlayMontage(FlatBufferBuilder builder, bool isOverlayMontage)
		{
			builder.AddBool(1, isOverlayMontage, false);
		}

		// Token: 0x0603158C RID: 202124 RVA: 0x006B168C File Offset: 0x006AF88C
		public static void AddMontageId(FlatBufferBuilder builder, Offset<IMontageId> montageIdOffset)
		{
			builder.AddOffset(2, montageIdOffset.Value, 0);
		}

		// Token: 0x0603158D RID: 202125 RVA: 0x006B169C File Offset: 0x006AF89C
		public static void AddFaceExpressionId(FlatBufferBuilder builder, int faceExpressionId)
		{
			builder.AddInt(3, faceExpressionId, 0);
		}

		// Token: 0x0603158E RID: 202126 RVA: 0x006B16A7 File Offset: 0x006AF8A7
		public static void AddLoopDuration(FlatBufferBuilder builder, float loopDuration)
		{
			builder.AddFloat(4, loopDuration, 0.0);
		}

		// Token: 0x0603158F RID: 202127 RVA: 0x006B16BA File Offset: 0x006AF8BA
		public static void AddRepeatTimes(FlatBufferBuilder builder, int repeatTimes)
		{
			builder.AddInt(5, repeatTimes, 0);
		}

		// Token: 0x06031590 RID: 202128 RVA: 0x006B16C5 File Offset: 0x006AF8C5
		public static void AddKeepMontageWhenEnd(FlatBufferBuilder builder, bool keepMontageWhenEnd)
		{
			builder.AddBool(6, keepMontageWhenEnd, false);
		}

		// Token: 0x06031591 RID: 202129 RVA: 0x006B16D0 File Offset: 0x006AF8D0
		public static void AddKeepMontageAfterFlow(FlatBufferBuilder builder, bool keepMontageAfterFlow)
		{
			builder.AddBool(7, keepMontageAfterFlow, false);
		}

		// Token: 0x06031592 RID: 202130 RVA: 0x006B16DB File Offset: 0x006AF8DB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06031593 RID: 202131 RVA: 0x006B16E6 File Offset: 0x006AF8E6
		public static Offset<IPlayRegisteredMontageRender> EndIPlayRegisteredMontageRender(FlatBufferBuilder builder)
		{
			return new Offset<IPlayRegisteredMontageRender>(builder.EndTable());
		}

		// Token: 0x06031594 RID: 202132 RVA: 0x006B16F4 File Offset: 0x006AF8F4
		public IPlayRegisteredMontageRenderT UnPack()
		{
			IPlayRegisteredMontageRenderT playRegisteredMontageRenderT = new IPlayRegisteredMontageRenderT();
			this.UnPackTo(playRegisteredMontageRenderT);
			return playRegisteredMontageRenderT;
		}

		// Token: 0x06031595 RID: 202133 RVA: 0x006B1710 File Offset: 0x006AF910
		public void UnPackTo(IPlayRegisteredMontageRenderT _o)
		{
			_o.EntityId = this.EntityId;
			_o.IsOverlayMontage = this.IsOverlayMontage;
			_o.MontageId = ((this.MontageId != null) ? this.MontageId.Value.UnPack() : null);
			_o.FaceExpressionId = this.FaceExpressionId;
			_o.LoopDuration = this.LoopDuration;
			_o.RepeatTimes = this.RepeatTimes;
			_o.KeepMontageWhenEnd = this.KeepMontageWhenEnd;
			_o.KeepMontageAfterFlow = this.KeepMontageAfterFlow;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06031596 RID: 202134 RVA: 0x006B17AC File Offset: 0x006AF9AC
		public static Offset<IPlayRegisteredMontageRender> Pack(FlatBufferBuilder builder, IPlayRegisteredMontageRenderT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayRegisteredMontageRender>);
			}
			Offset<IMontageId> montageIdOffset = (_o.MontageId == null) ? default(Offset<IMontageId>) : IMontageId.Pack(builder, _o.MontageId);
			return IPlayRegisteredMontageRender.CreateIPlayRegisteredMontageRender(builder, _o.EntityId, _o.IsOverlayMontage, montageIdOffset, _o.FaceExpressionId, _o.LoopDuration, _o.RepeatTimes, _o.KeepMontageWhenEnd, _o.KeepMontageAfterFlow, _o.NullMask);
		}

		// Token: 0x040116D5 RID: 71381
		private Table __p;
	}
}
