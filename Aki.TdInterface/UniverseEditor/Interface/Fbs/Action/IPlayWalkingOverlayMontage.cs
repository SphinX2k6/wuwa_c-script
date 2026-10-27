using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D47 RID: 27975
	public struct IPlayWalkingOverlayMontage : IFlatbufferObject
	{
		// Token: 0x1700D0A0 RID: 53408
		// (get) Token: 0x06031645 RID: 202309 RVA: 0x006B2C40 File Offset: 0x006B0E40
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031646 RID: 202310 RVA: 0x006B2C4D File Offset: 0x006B0E4D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031647 RID: 202311 RVA: 0x006B2C54 File Offset: 0x006B0E54
		public static IPlayWalkingOverlayMontage GetRootAsIPlayWalkingOverlayMontage(ByteBuffer _bb)
		{
			return IPlayWalkingOverlayMontage.GetRootAsIPlayWalkingOverlayMontage(_bb, default(IPlayWalkingOverlayMontage));
		}

		// Token: 0x06031648 RID: 202312 RVA: 0x006B2C70 File Offset: 0x006B0E70
		public static IPlayWalkingOverlayMontage GetRootAsIPlayWalkingOverlayMontage(ByteBuffer _bb, IPlayWalkingOverlayMontage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031649 RID: 202313 RVA: 0x006B2C8D File Offset: 0x006B0E8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603164A RID: 202314 RVA: 0x006B2C9C File Offset: 0x006B0E9C
		public IPlayWalkingOverlayMontage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D0A1 RID: 53409
		// (get) Token: 0x0603164B RID: 202315 RVA: 0x006B2CAC File Offset: 0x006B0EAC
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

		// Token: 0x1700D0A2 RID: 53410
		// (get) Token: 0x0603164C RID: 202316 RVA: 0x006B2CE8 File Offset: 0x006B0EE8
		public int OverlapMontageId
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

		// Token: 0x1700D0A3 RID: 53411
		// (get) Token: 0x0603164D RID: 202317 RVA: 0x006B2D24 File Offset: 0x006B0F24
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

		// Token: 0x1700D0A4 RID: 53412
		// (get) Token: 0x0603164E RID: 202318 RVA: 0x006B2D64 File Offset: 0x006B0F64
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

		// Token: 0x1700D0A5 RID: 53413
		// (get) Token: 0x0603164F RID: 202319 RVA: 0x006B2DA4 File Offset: 0x006B0FA4
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

		// Token: 0x06031650 RID: 202320 RVA: 0x006B2DE1 File Offset: 0x006B0FE1
		public static Offset<IPlayWalkingOverlayMontage> CreateIPlayWalkingOverlayMontage(FlatBufferBuilder builder, int EntityId = 0, int OverlapMontageId = 0, float LoopDuration = 0f, int RepeatTimes = 0, byte NullMask = 0)
		{
			builder.StartTable(5);
			IPlayWalkingOverlayMontage.AddRepeatTimes(builder, RepeatTimes);
			IPlayWalkingOverlayMontage.AddLoopDuration(builder, LoopDuration);
			IPlayWalkingOverlayMontage.AddOverlapMontageId(builder, OverlapMontageId);
			IPlayWalkingOverlayMontage.AddEntityId(builder, EntityId);
			IPlayWalkingOverlayMontage.AddNullMask(builder, NullMask);
			return IPlayWalkingOverlayMontage.EndIPlayWalkingOverlayMontage(builder);
		}

		// Token: 0x06031651 RID: 202321 RVA: 0x006B2E15 File Offset: 0x006B1015
		public static void StartIPlayWalkingOverlayMontage(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06031652 RID: 202322 RVA: 0x006B2E1E File Offset: 0x006B101E
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06031653 RID: 202323 RVA: 0x006B2E29 File Offset: 0x006B1029
		public static void AddOverlapMontageId(FlatBufferBuilder builder, int overlapMontageId)
		{
			builder.AddInt(1, overlapMontageId, 0);
		}

		// Token: 0x06031654 RID: 202324 RVA: 0x006B2E34 File Offset: 0x006B1034
		public static void AddLoopDuration(FlatBufferBuilder builder, float loopDuration)
		{
			builder.AddFloat(2, loopDuration, 0.0);
		}

		// Token: 0x06031655 RID: 202325 RVA: 0x006B2E47 File Offset: 0x006B1047
		public static void AddRepeatTimes(FlatBufferBuilder builder, int repeatTimes)
		{
			builder.AddInt(3, repeatTimes, 0);
		}

		// Token: 0x06031656 RID: 202326 RVA: 0x006B2E52 File Offset: 0x006B1052
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06031657 RID: 202327 RVA: 0x006B2E5D File Offset: 0x006B105D
		public static Offset<IPlayWalkingOverlayMontage> EndIPlayWalkingOverlayMontage(FlatBufferBuilder builder)
		{
			return new Offset<IPlayWalkingOverlayMontage>(builder.EndTable());
		}

		// Token: 0x06031658 RID: 202328 RVA: 0x006B2E6C File Offset: 0x006B106C
		public IPlayWalkingOverlayMontageT UnPack()
		{
			IPlayWalkingOverlayMontageT playWalkingOverlayMontageT = new IPlayWalkingOverlayMontageT();
			this.UnPackTo(playWalkingOverlayMontageT);
			return playWalkingOverlayMontageT;
		}

		// Token: 0x06031659 RID: 202329 RVA: 0x006B2E87 File Offset: 0x006B1087
		public void UnPackTo(IPlayWalkingOverlayMontageT _o)
		{
			_o.EntityId = this.EntityId;
			_o.OverlapMontageId = this.OverlapMontageId;
			_o.LoopDuration = this.LoopDuration;
			_o.RepeatTimes = this.RepeatTimes;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603165A RID: 202330 RVA: 0x006B2EC8 File Offset: 0x006B10C8
		public static Offset<IPlayWalkingOverlayMontage> Pack(FlatBufferBuilder builder, IPlayWalkingOverlayMontageT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayWalkingOverlayMontage>);
			}
			return IPlayWalkingOverlayMontage.CreateIPlayWalkingOverlayMontage(builder, _o.EntityId, _o.OverlapMontageId, _o.LoopDuration, _o.RepeatTimes, _o.NullMask);
		}

		// Token: 0x040116F6 RID: 71414
		private Table __p;
	}
}
