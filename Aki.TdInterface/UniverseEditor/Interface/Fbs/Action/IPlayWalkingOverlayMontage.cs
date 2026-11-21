using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074C2 RID: 29890
	public struct IPlayWalkingOverlayMontage : IFlatbufferObject
	{
		// Token: 0x1700DBE8 RID: 56296
		// (get) Token: 0x06034641 RID: 214593 RVA: 0x0070E328 File Offset: 0x0070C528
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034642 RID: 214594 RVA: 0x0070E335 File Offset: 0x0070C535
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034643 RID: 214595 RVA: 0x0070E33C File Offset: 0x0070C53C
		public static IPlayWalkingOverlayMontage GetRootAsIPlayWalkingOverlayMontage(ByteBuffer _bb)
		{
			return IPlayWalkingOverlayMontage.GetRootAsIPlayWalkingOverlayMontage(_bb, default(IPlayWalkingOverlayMontage));
		}

		// Token: 0x06034644 RID: 214596 RVA: 0x0070E358 File Offset: 0x0070C558
		public static IPlayWalkingOverlayMontage GetRootAsIPlayWalkingOverlayMontage(ByteBuffer _bb, IPlayWalkingOverlayMontage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034645 RID: 214597 RVA: 0x0070E375 File Offset: 0x0070C575
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034646 RID: 214598 RVA: 0x0070E384 File Offset: 0x0070C584
		public IPlayWalkingOverlayMontage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DBE9 RID: 56297
		// (get) Token: 0x06034647 RID: 214599 RVA: 0x0070E394 File Offset: 0x0070C594
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

		// Token: 0x1700DBEA RID: 56298
		// (get) Token: 0x06034648 RID: 214600 RVA: 0x0070E3D0 File Offset: 0x0070C5D0
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

		// Token: 0x1700DBEB RID: 56299
		// (get) Token: 0x06034649 RID: 214601 RVA: 0x0070E40C File Offset: 0x0070C60C
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

		// Token: 0x1700DBEC RID: 56300
		// (get) Token: 0x0603464A RID: 214602 RVA: 0x0070E44C File Offset: 0x0070C64C
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

		// Token: 0x1700DBED RID: 56301
		// (get) Token: 0x0603464B RID: 214603 RVA: 0x0070E48C File Offset: 0x0070C68C
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

		// Token: 0x0603464C RID: 214604 RVA: 0x0070E4C9 File Offset: 0x0070C6C9
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

		// Token: 0x0603464D RID: 214605 RVA: 0x0070E4FD File Offset: 0x0070C6FD
		public static void StartIPlayWalkingOverlayMontage(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0603464E RID: 214606 RVA: 0x0070E506 File Offset: 0x0070C706
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x0603464F RID: 214607 RVA: 0x0070E511 File Offset: 0x0070C711
		public static void AddOverlapMontageId(FlatBufferBuilder builder, int overlapMontageId)
		{
			builder.AddInt(1, overlapMontageId, 0);
		}

		// Token: 0x06034650 RID: 214608 RVA: 0x0070E51C File Offset: 0x0070C71C
		public static void AddLoopDuration(FlatBufferBuilder builder, float loopDuration)
		{
			builder.AddFloat(2, loopDuration, 0.0);
		}

		// Token: 0x06034651 RID: 214609 RVA: 0x0070E52F File Offset: 0x0070C72F
		public static void AddRepeatTimes(FlatBufferBuilder builder, int repeatTimes)
		{
			builder.AddInt(3, repeatTimes, 0);
		}

		// Token: 0x06034652 RID: 214610 RVA: 0x0070E53A File Offset: 0x0070C73A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06034653 RID: 214611 RVA: 0x0070E545 File Offset: 0x0070C745
		public static Offset<IPlayWalkingOverlayMontage> EndIPlayWalkingOverlayMontage(FlatBufferBuilder builder)
		{
			return new Offset<IPlayWalkingOverlayMontage>(builder.EndTable());
		}

		// Token: 0x06034654 RID: 214612 RVA: 0x0070E554 File Offset: 0x0070C754
		public IPlayWalkingOverlayMontageT UnPack()
		{
			IPlayWalkingOverlayMontageT playWalkingOverlayMontageT = new IPlayWalkingOverlayMontageT();
			this.UnPackTo(playWalkingOverlayMontageT);
			return playWalkingOverlayMontageT;
		}

		// Token: 0x06034655 RID: 214613 RVA: 0x0070E56F File Offset: 0x0070C76F
		public void UnPackTo(IPlayWalkingOverlayMontageT _o)
		{
			_o.EntityId = this.EntityId;
			_o.OverlapMontageId = this.OverlapMontageId;
			_o.LoopDuration = this.LoopDuration;
			_o.RepeatTimes = this.RepeatTimes;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06034656 RID: 214614 RVA: 0x0070E5B0 File Offset: 0x0070C7B0
		public static Offset<IPlayWalkingOverlayMontage> Pack(FlatBufferBuilder builder, IPlayWalkingOverlayMontageT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayWalkingOverlayMontage>);
			}
			return IPlayWalkingOverlayMontage.CreateIPlayWalkingOverlayMontage(builder, _o.EntityId, _o.OverlapMontageId, _o.LoopDuration, _o.RepeatTimes, _o.NullMask);
		}

		// Token: 0x04012672 RID: 75378
		private Table __p;
	}
}
