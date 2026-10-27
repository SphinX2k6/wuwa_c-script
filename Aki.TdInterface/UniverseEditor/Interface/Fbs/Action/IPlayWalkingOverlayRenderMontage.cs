using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D4A RID: 27978
	public struct IPlayWalkingOverlayRenderMontage : IFlatbufferObject
	{
		// Token: 0x1700D0AB RID: 53419
		// (get) Token: 0x06031667 RID: 202343 RVA: 0x006B2FF8 File Offset: 0x006B11F8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031668 RID: 202344 RVA: 0x006B3005 File Offset: 0x006B1205
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031669 RID: 202345 RVA: 0x006B300C File Offset: 0x006B120C
		public static IPlayWalkingOverlayRenderMontage GetRootAsIPlayWalkingOverlayRenderMontage(ByteBuffer _bb)
		{
			return IPlayWalkingOverlayRenderMontage.GetRootAsIPlayWalkingOverlayRenderMontage(_bb, default(IPlayWalkingOverlayRenderMontage));
		}

		// Token: 0x0603166A RID: 202346 RVA: 0x006B3028 File Offset: 0x006B1228
		public static IPlayWalkingOverlayRenderMontage GetRootAsIPlayWalkingOverlayRenderMontage(ByteBuffer _bb, IPlayWalkingOverlayRenderMontage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603166B RID: 202347 RVA: 0x006B3045 File Offset: 0x006B1245
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603166C RID: 202348 RVA: 0x006B3054 File Offset: 0x006B1254
		public IPlayWalkingOverlayRenderMontage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D0AC RID: 53420
		// (get) Token: 0x0603166D RID: 202349 RVA: 0x006B3064 File Offset: 0x006B1264
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

		// Token: 0x1700D0AD RID: 53421
		// (get) Token: 0x0603166E RID: 202350 RVA: 0x006B30A0 File Offset: 0x006B12A0
		public IMontageId? OverlapMontageId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IMontageId?(default(IMontageId).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D0AE RID: 53422
		// (get) Token: 0x0603166F RID: 202351 RVA: 0x006B3100 File Offset: 0x006B1300
		public float LoopDuration
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D0AF RID: 53423
		// (get) Token: 0x06031670 RID: 202352 RVA: 0x006B3140 File Offset: 0x006B1340
		public int RepeatTimes
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

		// Token: 0x1700D0B0 RID: 53424
		// (get) Token: 0x06031671 RID: 202353 RVA: 0x006B3180 File Offset: 0x006B1380
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031672 RID: 202354 RVA: 0x006B31BD File Offset: 0x006B13BD
		public static Offset<IPlayWalkingOverlayRenderMontage> CreateIPlayWalkingOverlayRenderMontage(FlatBufferBuilder builder, int EntityId = 0, Offset<IMontageId> OverlapMontageIdOffset = default(Offset<IMontageId>), float LoopDuration = 0f, int RepeatTimes = 0, byte NullMask = 0)
		{
			builder.StartTable(5);
			IPlayWalkingOverlayRenderMontage.AddRepeatTimes(builder, RepeatTimes);
			IPlayWalkingOverlayRenderMontage.AddLoopDuration(builder, LoopDuration);
			IPlayWalkingOverlayRenderMontage.AddOverlapMontageId(builder, OverlapMontageIdOffset);
			IPlayWalkingOverlayRenderMontage.AddEntityId(builder, EntityId);
			IPlayWalkingOverlayRenderMontage.AddNullMask(builder, NullMask);
			return IPlayWalkingOverlayRenderMontage.EndIPlayWalkingOverlayRenderMontage(builder);
		}

		// Token: 0x06031673 RID: 202355 RVA: 0x006B31F1 File Offset: 0x006B13F1
		public static void StartIPlayWalkingOverlayRenderMontage(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06031674 RID: 202356 RVA: 0x006B31FA File Offset: 0x006B13FA
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06031675 RID: 202357 RVA: 0x006B3205 File Offset: 0x006B1405
		public static void AddOverlapMontageId(FlatBufferBuilder builder, Offset<IMontageId> overlapMontageIdOffset)
		{
			builder.AddOffset(1, overlapMontageIdOffset.Value, 0);
		}

		// Token: 0x06031676 RID: 202358 RVA: 0x006B3215 File Offset: 0x006B1415
		public static void AddLoopDuration(FlatBufferBuilder builder, float loopDuration)
		{
			builder.AddFloat(2, loopDuration, 0.0);
		}

		// Token: 0x06031677 RID: 202359 RVA: 0x006B3228 File Offset: 0x006B1428
		public static void AddRepeatTimes(FlatBufferBuilder builder, int repeatTimes)
		{
			builder.AddInt(3, repeatTimes, 0);
		}

		// Token: 0x06031678 RID: 202360 RVA: 0x006B3233 File Offset: 0x006B1433
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06031679 RID: 202361 RVA: 0x006B323E File Offset: 0x006B143E
		public static Offset<IPlayWalkingOverlayRenderMontage> EndIPlayWalkingOverlayRenderMontage(FlatBufferBuilder builder)
		{
			return new Offset<IPlayWalkingOverlayRenderMontage>(builder.EndTable());
		}

		// Token: 0x0603167A RID: 202362 RVA: 0x006B324C File Offset: 0x006B144C
		public IPlayWalkingOverlayRenderMontageT UnPack()
		{
			IPlayWalkingOverlayRenderMontageT playWalkingOverlayRenderMontageT = new IPlayWalkingOverlayRenderMontageT();
			this.UnPackTo(playWalkingOverlayRenderMontageT);
			return playWalkingOverlayRenderMontageT;
		}

		// Token: 0x0603167B RID: 202363 RVA: 0x006B3268 File Offset: 0x006B1468
		public void UnPackTo(IPlayWalkingOverlayRenderMontageT _o)
		{
			_o.EntityId = this.EntityId;
			_o.OverlapMontageId = ((this.OverlapMontageId != null) ? this.OverlapMontageId.Value.UnPack() : null);
			_o.LoopDuration = this.LoopDuration;
			_o.RepeatTimes = this.RepeatTimes;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603167C RID: 202364 RVA: 0x006B32D4 File Offset: 0x006B14D4
		public static Offset<IPlayWalkingOverlayRenderMontage> Pack(FlatBufferBuilder builder, IPlayWalkingOverlayRenderMontageT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayWalkingOverlayRenderMontage>);
			}
			Offset<IMontageId> overlapMontageIdOffset = (_o.OverlapMontageId == null) ? default(Offset<IMontageId>) : IMontageId.Pack(builder, _o.OverlapMontageId);
			return IPlayWalkingOverlayRenderMontage.CreateIPlayWalkingOverlayRenderMontage(builder, _o.EntityId, overlapMontageIdOffset, _o.LoopDuration, _o.RepeatTimes, _o.NullMask);
		}

		// Token: 0x040116FC RID: 71420
		private Table __p;
	}
}
