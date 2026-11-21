using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074B0 RID: 29872
	public struct IPlayRegisteredMontage : IFlatbufferObject
	{
		// Token: 0x1700DB96 RID: 56214
		// (get) Token: 0x0603453F RID: 214335 RVA: 0x0070C374 File Offset: 0x0070A574
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034540 RID: 214336 RVA: 0x0070C381 File Offset: 0x0070A581
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034541 RID: 214337 RVA: 0x0070C388 File Offset: 0x0070A588
		public static IPlayRegisteredMontage GetRootAsIPlayRegisteredMontage(ByteBuffer _bb)
		{
			return IPlayRegisteredMontage.GetRootAsIPlayRegisteredMontage(_bb, default(IPlayRegisteredMontage));
		}

		// Token: 0x06034542 RID: 214338 RVA: 0x0070C3A4 File Offset: 0x0070A5A4
		public static IPlayRegisteredMontage GetRootAsIPlayRegisteredMontage(ByteBuffer _bb, IPlayRegisteredMontage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034543 RID: 214339 RVA: 0x0070C3C1 File Offset: 0x0070A5C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034544 RID: 214340 RVA: 0x0070C3D0 File Offset: 0x0070A5D0
		public IPlayRegisteredMontage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DB97 RID: 56215
		// (get) Token: 0x06034545 RID: 214341 RVA: 0x0070C3E0 File Offset: 0x0070A5E0
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

		// Token: 0x1700DB98 RID: 56216
		// (get) Token: 0x06034546 RID: 214342 RVA: 0x0070C41C File Offset: 0x0070A61C
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

		// Token: 0x1700DB99 RID: 56217
		// (get) Token: 0x06034547 RID: 214343 RVA: 0x0070C458 File Offset: 0x0070A658
		public bool IsOverlayMontage
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DB9A RID: 56218
		// (get) Token: 0x06034548 RID: 214344 RVA: 0x0070C498 File Offset: 0x0070A698
		public bool IsAbpMontage
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DB9B RID: 56219
		// (get) Token: 0x06034549 RID: 214345 RVA: 0x0070C4D8 File Offset: 0x0070A6D8
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

		// Token: 0x1700DB9C RID: 56220
		// (get) Token: 0x0603454A RID: 214346 RVA: 0x0070C518 File Offset: 0x0070A718
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

		// Token: 0x1700DB9D RID: 56221
		// (get) Token: 0x0603454B RID: 214347 RVA: 0x0070C55C File Offset: 0x0070A75C
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

		// Token: 0x1700DB9E RID: 56222
		// (get) Token: 0x0603454C RID: 214348 RVA: 0x0070C59C File Offset: 0x0070A79C
		public bool KeepMontageWhenEnd
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DB9F RID: 56223
		// (get) Token: 0x0603454D RID: 214349 RVA: 0x0070C5DC File Offset: 0x0070A7DC
		public bool KeepMontageAfterFlow
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DBA0 RID: 56224
		// (get) Token: 0x0603454E RID: 214350 RVA: 0x0070C61C File Offset: 0x0070A81C
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

		// Token: 0x0603454F RID: 214351 RVA: 0x0070C65C File Offset: 0x0070A85C
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

		// Token: 0x06034550 RID: 214352 RVA: 0x0070C6C4 File Offset: 0x0070A8C4
		public static void StartIPlayRegisteredMontage(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x06034551 RID: 214353 RVA: 0x0070C6CE File Offset: 0x0070A8CE
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06034552 RID: 214354 RVA: 0x0070C6D9 File Offset: 0x0070A8D9
		public static void AddMontageId(FlatBufferBuilder builder, int montageId)
		{
			builder.AddInt(1, montageId, 0);
		}

		// Token: 0x06034553 RID: 214355 RVA: 0x0070C6E4 File Offset: 0x0070A8E4
		public static void AddIsOverlayMontage(FlatBufferBuilder builder, bool isOverlayMontage)
		{
			builder.AddBool(2, isOverlayMontage, false);
		}

		// Token: 0x06034554 RID: 214356 RVA: 0x0070C6EF File Offset: 0x0070A8EF
		public static void AddIsAbpMontage(FlatBufferBuilder builder, bool isAbpMontage)
		{
			builder.AddBool(3, isAbpMontage, false);
		}

		// Token: 0x06034555 RID: 214357 RVA: 0x0070C6FA File Offset: 0x0070A8FA
		public static void AddFaceExpressionId(FlatBufferBuilder builder, int faceExpressionId)
		{
			builder.AddInt(4, faceExpressionId, 0);
		}

		// Token: 0x06034556 RID: 214358 RVA: 0x0070C705 File Offset: 0x0070A905
		public static void AddLoopDuration(FlatBufferBuilder builder, float loopDuration)
		{
			builder.AddFloat(5, loopDuration, 0.0);
		}

		// Token: 0x06034557 RID: 214359 RVA: 0x0070C718 File Offset: 0x0070A918
		public static void AddRepeatTimes(FlatBufferBuilder builder, int repeatTimes)
		{
			builder.AddInt(6, repeatTimes, 0);
		}

		// Token: 0x06034558 RID: 214360 RVA: 0x0070C723 File Offset: 0x0070A923
		public static void AddKeepMontageWhenEnd(FlatBufferBuilder builder, bool keepMontageWhenEnd)
		{
			builder.AddBool(7, keepMontageWhenEnd, false);
		}

		// Token: 0x06034559 RID: 214361 RVA: 0x0070C72E File Offset: 0x0070A92E
		public static void AddKeepMontageAfterFlow(FlatBufferBuilder builder, bool keepMontageAfterFlow)
		{
			builder.AddBool(8, keepMontageAfterFlow, false);
		}

		// Token: 0x0603455A RID: 214362 RVA: 0x0070C739 File Offset: 0x0070A939
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x0603455B RID: 214363 RVA: 0x0070C745 File Offset: 0x0070A945
		public static Offset<IPlayRegisteredMontage> EndIPlayRegisteredMontage(FlatBufferBuilder builder)
		{
			return new Offset<IPlayRegisteredMontage>(builder.EndTable());
		}

		// Token: 0x0603455C RID: 214364 RVA: 0x0070C754 File Offset: 0x0070A954
		public IPlayRegisteredMontageT UnPack()
		{
			IPlayRegisteredMontageT playRegisteredMontageT = new IPlayRegisteredMontageT();
			this.UnPackTo(playRegisteredMontageT);
			return playRegisteredMontageT;
		}

		// Token: 0x0603455D RID: 214365 RVA: 0x0070C770 File Offset: 0x0070A970
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

		// Token: 0x0603455E RID: 214366 RVA: 0x0070C7F8 File Offset: 0x0070A9F8
		public static Offset<IPlayRegisteredMontage> Pack(FlatBufferBuilder builder, IPlayRegisteredMontageT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayRegisteredMontage>);
			}
			return IPlayRegisteredMontage.CreateIPlayRegisteredMontage(builder, _o.EntityId, _o.MontageId, _o.IsOverlayMontage, _o.IsAbpMontage, _o.FaceExpressionId, _o.LoopDuration, _o.RepeatTimes, _o.KeepMontageWhenEnd, _o.KeepMontageAfterFlow, _o.NullMask);
		}

		// Token: 0x04012646 RID: 75334
		private Table __p;
	}
}
