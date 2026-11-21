using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EC3 RID: 20163
	public struct ICheckEntityHasBuff : IFlatbufferObject
	{
		// Token: 0x17008FE9 RID: 36841
		// (get) Token: 0x0601F471 RID: 128113 RVA: 0x0045C2E2 File Offset: 0x0045A4E2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F472 RID: 128114 RVA: 0x0045C2EF File Offset: 0x0045A4EF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F473 RID: 128115 RVA: 0x0045C2F8 File Offset: 0x0045A4F8
		public static ICheckEntityHasBuff GetRootAsICheckEntityHasBuff(ByteBuffer _bb)
		{
			return ICheckEntityHasBuff.GetRootAsICheckEntityHasBuff(_bb, default(ICheckEntityHasBuff));
		}

		// Token: 0x0601F474 RID: 128116 RVA: 0x0045C314 File Offset: 0x0045A514
		public static ICheckEntityHasBuff GetRootAsICheckEntityHasBuff(ByteBuffer _bb, ICheckEntityHasBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F475 RID: 128117 RVA: 0x0045C331 File Offset: 0x0045A531
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F476 RID: 128118 RVA: 0x0045C340 File Offset: 0x0045A540
		public ICheckEntityHasBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008FEA RID: 36842
		// (get) Token: 0x0601F477 RID: 128119 RVA: 0x0045C350 File Offset: 0x0045A550
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008FEB RID: 36843
		// (get) Token: 0x0601F478 RID: 128120 RVA: 0x0045C38C File Offset: 0x0045A58C
		public IMonsterBuffContainer? Target
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IMonsterBuffContainer?(default(IMonsterBuffContainer).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17008FEC RID: 36844
		// (get) Token: 0x0601F479 RID: 128121 RVA: 0x0045C3EC File Offset: 0x0045A5EC
		public long BuffId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0L;
				}
				return this.__p.bb.GetLong(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008FED RID: 36845
		// (get) Token: 0x0601F47A RID: 128122 RVA: 0x0045C42C File Offset: 0x0045A62C
		public bool HasBuff
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601F47B RID: 128123 RVA: 0x0045C46C File Offset: 0x0045A66C
		public static Offset<ICheckEntityHasBuff> CreateICheckEntityHasBuff(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, Offset<IMonsterBuffContainer> TargetOffset = default(Offset<IMonsterBuffContainer>), long BuffId = 0L, bool HasBuff = false)
		{
			builder.StartTable(4);
			ICheckEntityHasBuff.AddBuffId(builder, BuffId);
			ICheckEntityHasBuff.AddTarget(builder, TargetOffset);
			ICheckEntityHasBuff.AddHasBuff(builder, HasBuff);
			ICheckEntityHasBuff.AddType(builder, Type);
			return ICheckEntityHasBuff.EndICheckEntityHasBuff(builder);
		}

		// Token: 0x0601F47C RID: 128124 RVA: 0x0045C498 File Offset: 0x0045A698
		public static void StartICheckEntityHasBuff(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601F47D RID: 128125 RVA: 0x0045C4A1 File Offset: 0x0045A6A1
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F47E RID: 128126 RVA: 0x0045C4AC File Offset: 0x0045A6AC
		public static void AddTarget(FlatBufferBuilder builder, Offset<IMonsterBuffContainer> targetOffset)
		{
			builder.AddOffset(1, targetOffset.Value, 0);
		}

		// Token: 0x0601F47F RID: 128127 RVA: 0x0045C4BC File Offset: 0x0045A6BC
		public static void AddBuffId(FlatBufferBuilder builder, long buffId)
		{
			builder.AddLong(2, buffId, 0L);
		}

		// Token: 0x0601F480 RID: 128128 RVA: 0x0045C4C8 File Offset: 0x0045A6C8
		public static void AddHasBuff(FlatBufferBuilder builder, bool hasBuff)
		{
			builder.AddBool(3, hasBuff, false);
		}

		// Token: 0x0601F481 RID: 128129 RVA: 0x0045C4D3 File Offset: 0x0045A6D3
		public static Offset<ICheckEntityHasBuff> EndICheckEntityHasBuff(FlatBufferBuilder builder)
		{
			return new Offset<ICheckEntityHasBuff>(builder.EndTable());
		}

		// Token: 0x0601F482 RID: 128130 RVA: 0x0045C4E0 File Offset: 0x0045A6E0
		public ICheckEntityHasBuffT UnPack()
		{
			ICheckEntityHasBuffT checkEntityHasBuffT = new ICheckEntityHasBuffT();
			this.UnPackTo(checkEntityHasBuffT);
			return checkEntityHasBuffT;
		}

		// Token: 0x0601F483 RID: 128131 RVA: 0x0045C4FC File Offset: 0x0045A6FC
		public void UnPackTo(ICheckEntityHasBuffT _o)
		{
			_o.Type = this.Type;
			_o.Target = ((this.Target != null) ? this.Target.Value.UnPack() : null);
			_o.BuffId = this.BuffId;
			_o.HasBuff = this.HasBuff;
		}

		// Token: 0x0601F484 RID: 128132 RVA: 0x0045C55C File Offset: 0x0045A75C
		public static Offset<ICheckEntityHasBuff> Pack(FlatBufferBuilder builder, ICheckEntityHasBuffT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckEntityHasBuff>);
			}
			Offset<IMonsterBuffContainer> targetOffset = (_o.Target == null) ? default(Offset<IMonsterBuffContainer>) : IMonsterBuffContainer.Pack(builder, _o.Target);
			return ICheckEntityHasBuff.CreateICheckEntityHasBuff(builder, _o.Type, targetOffset, _o.BuffId, _o.HasBuff);
		}

		// Token: 0x0400DD19 RID: 56601
		private Table __p;
	}
}
