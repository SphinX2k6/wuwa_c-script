using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074B3 RID: 29875
	public struct IPlayRegisteredMontageRender : IFlatbufferObject
	{
		// Token: 0x1700DBAB RID: 56235
		// (get) Token: 0x06034575 RID: 214389 RVA: 0x0070CA25 File Offset: 0x0070AC25
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034576 RID: 214390 RVA: 0x0070CA32 File Offset: 0x0070AC32
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034577 RID: 214391 RVA: 0x0070CA3C File Offset: 0x0070AC3C
		public static IPlayRegisteredMontageRender GetRootAsIPlayRegisteredMontageRender(ByteBuffer _bb)
		{
			return IPlayRegisteredMontageRender.GetRootAsIPlayRegisteredMontageRender(_bb, default(IPlayRegisteredMontageRender));
		}

		// Token: 0x06034578 RID: 214392 RVA: 0x0070CA58 File Offset: 0x0070AC58
		public static IPlayRegisteredMontageRender GetRootAsIPlayRegisteredMontageRender(ByteBuffer _bb, IPlayRegisteredMontageRender obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034579 RID: 214393 RVA: 0x0070CA75 File Offset: 0x0070AC75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603457A RID: 214394 RVA: 0x0070CA84 File Offset: 0x0070AC84
		public IPlayRegisteredMontageRender __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DBAC RID: 56236
		// (get) Token: 0x0603457B RID: 214395 RVA: 0x0070CA94 File Offset: 0x0070AC94
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

		// Token: 0x1700DBAD RID: 56237
		// (get) Token: 0x0603457C RID: 214396 RVA: 0x0070CAD0 File Offset: 0x0070ACD0
		public bool IsOverlayMontage
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DBAE RID: 56238
		// (get) Token: 0x0603457D RID: 214397 RVA: 0x0070CB10 File Offset: 0x0070AD10
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

		// Token: 0x1700DBAF RID: 56239
		// (get) Token: 0x0603457E RID: 214398 RVA: 0x0070CB70 File Offset: 0x0070AD70
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

		// Token: 0x1700DBB0 RID: 56240
		// (get) Token: 0x0603457F RID: 214399 RVA: 0x0070CBB0 File Offset: 0x0070ADB0
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

		// Token: 0x1700DBB1 RID: 56241
		// (get) Token: 0x06034580 RID: 214400 RVA: 0x0070CBF4 File Offset: 0x0070ADF4
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

		// Token: 0x1700DBB2 RID: 56242
		// (get) Token: 0x06034581 RID: 214401 RVA: 0x0070CC34 File Offset: 0x0070AE34
		public bool KeepMontageWhenEnd
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DBB3 RID: 56243
		// (get) Token: 0x06034582 RID: 214402 RVA: 0x0070CC74 File Offset: 0x0070AE74
		public bool KeepMontageAfterFlow
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DBB4 RID: 56244
		// (get) Token: 0x06034583 RID: 214403 RVA: 0x0070CCB4 File Offset: 0x0070AEB4
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

		// Token: 0x06034584 RID: 214404 RVA: 0x0070CCF4 File Offset: 0x0070AEF4
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

		// Token: 0x06034585 RID: 214405 RVA: 0x0070CD54 File Offset: 0x0070AF54
		public static void StartIPlayRegisteredMontageRender(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06034586 RID: 214406 RVA: 0x0070CD5E File Offset: 0x0070AF5E
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06034587 RID: 214407 RVA: 0x0070CD69 File Offset: 0x0070AF69
		public static void AddIsOverlayMontage(FlatBufferBuilder builder, bool isOverlayMontage)
		{
			builder.AddBool(1, isOverlayMontage, false);
		}

		// Token: 0x06034588 RID: 214408 RVA: 0x0070CD74 File Offset: 0x0070AF74
		public static void AddMontageId(FlatBufferBuilder builder, Offset<IMontageId> montageIdOffset)
		{
			builder.AddOffset(2, montageIdOffset.Value, 0);
		}

		// Token: 0x06034589 RID: 214409 RVA: 0x0070CD84 File Offset: 0x0070AF84
		public static void AddFaceExpressionId(FlatBufferBuilder builder, int faceExpressionId)
		{
			builder.AddInt(3, faceExpressionId, 0);
		}

		// Token: 0x0603458A RID: 214410 RVA: 0x0070CD8F File Offset: 0x0070AF8F
		public static void AddLoopDuration(FlatBufferBuilder builder, float loopDuration)
		{
			builder.AddFloat(4, loopDuration, 0.0);
		}

		// Token: 0x0603458B RID: 214411 RVA: 0x0070CDA2 File Offset: 0x0070AFA2
		public static void AddRepeatTimes(FlatBufferBuilder builder, int repeatTimes)
		{
			builder.AddInt(5, repeatTimes, 0);
		}

		// Token: 0x0603458C RID: 214412 RVA: 0x0070CDAD File Offset: 0x0070AFAD
		public static void AddKeepMontageWhenEnd(FlatBufferBuilder builder, bool keepMontageWhenEnd)
		{
			builder.AddBool(6, keepMontageWhenEnd, false);
		}

		// Token: 0x0603458D RID: 214413 RVA: 0x0070CDB8 File Offset: 0x0070AFB8
		public static void AddKeepMontageAfterFlow(FlatBufferBuilder builder, bool keepMontageAfterFlow)
		{
			builder.AddBool(7, keepMontageAfterFlow, false);
		}

		// Token: 0x0603458E RID: 214414 RVA: 0x0070CDC3 File Offset: 0x0070AFC3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x0603458F RID: 214415 RVA: 0x0070CDCE File Offset: 0x0070AFCE
		public static Offset<IPlayRegisteredMontageRender> EndIPlayRegisteredMontageRender(FlatBufferBuilder builder)
		{
			return new Offset<IPlayRegisteredMontageRender>(builder.EndTable());
		}

		// Token: 0x06034590 RID: 214416 RVA: 0x0070CDDC File Offset: 0x0070AFDC
		public IPlayRegisteredMontageRenderT UnPack()
		{
			IPlayRegisteredMontageRenderT playRegisteredMontageRenderT = new IPlayRegisteredMontageRenderT();
			this.UnPackTo(playRegisteredMontageRenderT);
			return playRegisteredMontageRenderT;
		}

		// Token: 0x06034591 RID: 214417 RVA: 0x0070CDF8 File Offset: 0x0070AFF8
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

		// Token: 0x06034592 RID: 214418 RVA: 0x0070CE94 File Offset: 0x0070B094
		public static Offset<IPlayRegisteredMontageRender> Pack(FlatBufferBuilder builder, IPlayRegisteredMontageRenderT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayRegisteredMontageRender>);
			}
			Offset<IMontageId> montageIdOffset = (_o.MontageId == null) ? default(Offset<IMontageId>) : IMontageId.Pack(builder, _o.MontageId);
			return IPlayRegisteredMontageRender.CreateIPlayRegisteredMontageRender(builder, _o.EntityId, _o.IsOverlayMontage, montageIdOffset, _o.FaceExpressionId, _o.LoopDuration, _o.RepeatTimes, _o.KeepMontageWhenEnd, _o.KeepMontageAfterFlow, _o.NullMask);
		}

		// Token: 0x04012651 RID: 75345
		private Table __p;
	}
}
