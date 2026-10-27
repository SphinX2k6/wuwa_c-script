using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D35 RID: 27957
	public struct IPlayRegisteredMontage : IFlatbufferObject
	{
		// Token: 0x1700D04E RID: 53326
		// (get) Token: 0x06031543 RID: 202051 RVA: 0x006B0C8C File Offset: 0x006AEE8C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031544 RID: 202052 RVA: 0x006B0C99 File Offset: 0x006AEE99
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031545 RID: 202053 RVA: 0x006B0CA0 File Offset: 0x006AEEA0
		public static IPlayRegisteredMontage GetRootAsIPlayRegisteredMontage(ByteBuffer _bb)
		{
			return IPlayRegisteredMontage.GetRootAsIPlayRegisteredMontage(_bb, default(IPlayRegisteredMontage));
		}

		// Token: 0x06031546 RID: 202054 RVA: 0x006B0CBC File Offset: 0x006AEEBC
		public static IPlayRegisteredMontage GetRootAsIPlayRegisteredMontage(ByteBuffer _bb, IPlayRegisteredMontage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031547 RID: 202055 RVA: 0x006B0CD9 File Offset: 0x006AEED9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031548 RID: 202056 RVA: 0x006B0CE8 File Offset: 0x006AEEE8
		public IPlayRegisteredMontage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D04F RID: 53327
		// (get) Token: 0x06031549 RID: 202057 RVA: 0x006B0CF8 File Offset: 0x006AEEF8
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

		// Token: 0x1700D050 RID: 53328
		// (get) Token: 0x0603154A RID: 202058 RVA: 0x006B0D34 File Offset: 0x006AEF34
		public int MontageId
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

		// Token: 0x1700D051 RID: 53329
		// (get) Token: 0x0603154B RID: 202059 RVA: 0x006B0D70 File Offset: 0x006AEF70
		public bool IsOverlayMontage
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D052 RID: 53330
		// (get) Token: 0x0603154C RID: 202060 RVA: 0x006B0DB0 File Offset: 0x006AEFB0
		public bool IsAbpMontage
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D053 RID: 53331
		// (get) Token: 0x0603154D RID: 202061 RVA: 0x006B0DF0 File Offset: 0x006AEFF0
		public int FaceExpressionId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D054 RID: 53332
		// (get) Token: 0x0603154E RID: 202062 RVA: 0x006B0E30 File Offset: 0x006AF030
		public float LoopDuration
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D055 RID: 53333
		// (get) Token: 0x0603154F RID: 202063 RVA: 0x006B0E74 File Offset: 0x006AF074
		public int RepeatTimes
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D056 RID: 53334
		// (get) Token: 0x06031550 RID: 202064 RVA: 0x006B0EB4 File Offset: 0x006AF0B4
		public bool KeepMontageWhenEnd
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D057 RID: 53335
		// (get) Token: 0x06031551 RID: 202065 RVA: 0x006B0EF4 File Offset: 0x006AF0F4
		public bool KeepMontageAfterFlow
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D058 RID: 53336
		// (get) Token: 0x06031552 RID: 202066 RVA: 0x006B0F34 File Offset: 0x006AF134
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031553 RID: 202067 RVA: 0x006B0F74 File Offset: 0x006AF174
		public static Offset<IPlayRegisteredMontage> CreateIPlayRegisteredMontage(FlatBufferBuilder builder, int EntityId = 0, int MontageId = 0, bool IsOverlayMontage = false, bool IsAbpMontage = false, int FaceExpressionId = 0, float LoopDuration = 0f, int RepeatTimes = 0, bool KeepMontageWhenEnd = false, bool KeepMontageAfterFlow = false, byte NullMask = 0)
		{
			builder.StartTable(10);
			IPlayRegisteredMontage.AddRepeatTimes(builder, RepeatTimes);
			IPlayRegisteredMontage.AddLoopDuration(builder, LoopDuration);
			IPlayRegisteredMontage.AddFaceExpressionId(builder, FaceExpressionId);
			IPlayRegisteredMontage.AddMontageId(builder, MontageId);
			IPlayRegisteredMontage.AddEntityId(builder, EntityId);
			IPlayRegisteredMontage.AddNullMask(builder, NullMask);
			IPlayRegisteredMontage.AddKeepMontageAfterFlow(builder, KeepMontageAfterFlow);
			IPlayRegisteredMontage.AddKeepMontageWhenEnd(builder, KeepMontageWhenEnd);
			IPlayRegisteredMontage.AddIsAbpMontage(builder, IsAbpMontage);
			IPlayRegisteredMontage.AddIsOverlayMontage(builder, IsOverlayMontage);
			return IPlayRegisteredMontage.EndIPlayRegisteredMontage(builder);
		}

		// Token: 0x06031554 RID: 202068 RVA: 0x006B0FDC File Offset: 0x006AF1DC
		public static void StartIPlayRegisteredMontage(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x06031555 RID: 202069 RVA: 0x006B0FE6 File Offset: 0x006AF1E6
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06031556 RID: 202070 RVA: 0x006B0FF1 File Offset: 0x006AF1F1
		public static void AddMontageId(FlatBufferBuilder builder, int montageId)
		{
			builder.AddInt(1, montageId, 0);
		}

		// Token: 0x06031557 RID: 202071 RVA: 0x006B0FFC File Offset: 0x006AF1FC
		public static void AddIsOverlayMontage(FlatBufferBuilder builder, bool isOverlayMontage)
		{
			builder.AddBool(2, isOverlayMontage, false);
		}

		// Token: 0x06031558 RID: 202072 RVA: 0x006B1007 File Offset: 0x006AF207
		public static void AddIsAbpMontage(FlatBufferBuilder builder, bool isAbpMontage)
		{
			builder.AddBool(3, isAbpMontage, false);
		}

		// Token: 0x06031559 RID: 202073 RVA: 0x006B1012 File Offset: 0x006AF212
		public static void AddFaceExpressionId(FlatBufferBuilder builder, int faceExpressionId)
		{
			builder.AddInt(4, faceExpressionId, 0);
		}

		// Token: 0x0603155A RID: 202074 RVA: 0x006B101D File Offset: 0x006AF21D
		public static void AddLoopDuration(FlatBufferBuilder builder, float loopDuration)
		{
			builder.AddFloat(5, loopDuration, 0.0);
		}

		// Token: 0x0603155B RID: 202075 RVA: 0x006B1030 File Offset: 0x006AF230
		public static void AddRepeatTimes(FlatBufferBuilder builder, int repeatTimes)
		{
			builder.AddInt(6, repeatTimes, 0);
		}

		// Token: 0x0603155C RID: 202076 RVA: 0x006B103B File Offset: 0x006AF23B
		public static void AddKeepMontageWhenEnd(FlatBufferBuilder builder, bool keepMontageWhenEnd)
		{
			builder.AddBool(7, keepMontageWhenEnd, false);
		}

		// Token: 0x0603155D RID: 202077 RVA: 0x006B1046 File Offset: 0x006AF246
		public static void AddKeepMontageAfterFlow(FlatBufferBuilder builder, bool keepMontageAfterFlow)
		{
			builder.AddBool(8, keepMontageAfterFlow, false);
		}

		// Token: 0x0603155E RID: 202078 RVA: 0x006B1051 File Offset: 0x006AF251
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x0603155F RID: 202079 RVA: 0x006B105D File Offset: 0x006AF25D
		public static Offset<IPlayRegisteredMontage> EndIPlayRegisteredMontage(FlatBufferBuilder builder)
		{
			return new Offset<IPlayRegisteredMontage>(builder.EndTable());
		}

		// Token: 0x06031560 RID: 202080 RVA: 0x006B106C File Offset: 0x006AF26C
		public IPlayRegisteredMontageT UnPack()
		{
			IPlayRegisteredMontageT playRegisteredMontageT = new IPlayRegisteredMontageT();
			this.UnPackTo(playRegisteredMontageT);
			return playRegisteredMontageT;
		}

		// Token: 0x06031561 RID: 202081 RVA: 0x006B1088 File Offset: 0x006AF288
		public void UnPackTo(IPlayRegisteredMontageT _o)
		{
			_o.EntityId = this.EntityId;
			_o.MontageId = this.MontageId;
			_o.IsOverlayMontage = this.IsOverlayMontage;
			_o.IsAbpMontage = this.IsAbpMontage;
			_o.FaceExpressionId = this.FaceExpressionId;
			_o.LoopDuration = this.LoopDuration;
			_o.RepeatTimes = this.RepeatTimes;
			_o.KeepMontageWhenEnd = this.KeepMontageWhenEnd;
			_o.KeepMontageAfterFlow = this.KeepMontageAfterFlow;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06031562 RID: 202082 RVA: 0x006B1110 File Offset: 0x006AF310
		public static Offset<IPlayRegisteredMontage> Pack(FlatBufferBuilder builder, IPlayRegisteredMontageT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayRegisteredMontage>);
			}
			return IPlayRegisteredMontage.CreateIPlayRegisteredMontage(builder, _o.EntityId, _o.MontageId, _o.IsOverlayMontage, _o.IsAbpMontage, _o.FaceExpressionId, _o.LoopDuration, _o.RepeatTimes, _o.KeepMontageWhenEnd, _o.KeepMontageAfterFlow, _o.NullMask);
		}

		// Token: 0x040116CA RID: 71370
		private Table __p;
	}
}
