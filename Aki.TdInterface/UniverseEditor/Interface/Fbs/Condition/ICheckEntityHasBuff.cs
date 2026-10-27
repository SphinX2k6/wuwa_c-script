using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A03 RID: 18947
	public struct ICheckEntityHasBuff : IFlatbufferObject
	{
		// Token: 0x17008919 RID: 35097
		// (get) Token: 0x0601D9FE RID: 121342 RVA: 0x0042B676 File Offset: 0x00429876
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D9FF RID: 121343 RVA: 0x0042B683 File Offset: 0x00429883
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DA00 RID: 121344 RVA: 0x0042B68C File Offset: 0x0042988C
		public static ICheckEntityHasBuff GetRootAsICheckEntityHasBuff(ByteBuffer _bb)
		{
			return ICheckEntityHasBuff.GetRootAsICheckEntityHasBuff(_bb, default(ICheckEntityHasBuff));
		}

		// Token: 0x0601DA01 RID: 121345 RVA: 0x0042B6A8 File Offset: 0x004298A8
		public static ICheckEntityHasBuff GetRootAsICheckEntityHasBuff(ByteBuffer _bb, ICheckEntityHasBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DA02 RID: 121346 RVA: 0x0042B6C5 File Offset: 0x004298C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DA03 RID: 121347 RVA: 0x0042B6D4 File Offset: 0x004298D4
		public ICheckEntityHasBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700891A RID: 35098
		// (get) Token: 0x0601DA04 RID: 121348 RVA: 0x0042B6E4 File Offset: 0x004298E4
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

		// Token: 0x1700891B RID: 35099
		// (get) Token: 0x0601DA05 RID: 121349 RVA: 0x0042B720 File Offset: 0x00429920
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

		// Token: 0x1700891C RID: 35100
		// (get) Token: 0x0601DA06 RID: 121350 RVA: 0x0042B780 File Offset: 0x00429980
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

		// Token: 0x1700891D RID: 35101
		// (get) Token: 0x0601DA07 RID: 121351 RVA: 0x0042B7C0 File Offset: 0x004299C0
		public bool HasBuff
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601DA08 RID: 121352 RVA: 0x0042B800 File Offset: 0x00429A00
		public static Offset<ICheckEntityHasBuff> CreateICheckEntityHasBuff(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, Offset<IMonsterBuffContainer> TargetOffset = default(Offset<IMonsterBuffContainer>), long BuffId = 0L, bool HasBuff = false)
		{
			builder.StartTable(4);
			ICheckEntityHasBuff.AddBuffId(builder, BuffId);
			ICheckEntityHasBuff.AddTarget(builder, TargetOffset);
			ICheckEntityHasBuff.AddHasBuff(builder, HasBuff);
			ICheckEntityHasBuff.AddType(builder, Type);
			return ICheckEntityHasBuff.EndICheckEntityHasBuff(builder);
		}

		// Token: 0x0601DA09 RID: 121353 RVA: 0x0042B82C File Offset: 0x00429A2C
		public static void StartICheckEntityHasBuff(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601DA0A RID: 121354 RVA: 0x0042B835 File Offset: 0x00429A35
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DA0B RID: 121355 RVA: 0x0042B840 File Offset: 0x00429A40
		public static void AddTarget(FlatBufferBuilder builder, Offset<IMonsterBuffContainer> targetOffset)
		{
			builder.AddOffset(1, targetOffset.Value, 0);
		}

		// Token: 0x0601DA0C RID: 121356 RVA: 0x0042B850 File Offset: 0x00429A50
		public static void AddBuffId(FlatBufferBuilder builder, long buffId)
		{
			builder.AddLong(2, buffId, 0L);
		}

		// Token: 0x0601DA0D RID: 121357 RVA: 0x0042B85C File Offset: 0x00429A5C
		public static void AddHasBuff(FlatBufferBuilder builder, bool hasBuff)
		{
			builder.AddBool(3, hasBuff, false);
		}

		// Token: 0x0601DA0E RID: 121358 RVA: 0x0042B867 File Offset: 0x00429A67
		public static Offset<ICheckEntityHasBuff> EndICheckEntityHasBuff(FlatBufferBuilder builder)
		{
			return new Offset<ICheckEntityHasBuff>(builder.EndTable());
		}

		// Token: 0x0601DA0F RID: 121359 RVA: 0x0042B874 File Offset: 0x00429A74
		public ICheckEntityHasBuffT UnPack()
		{
			ICheckEntityHasBuffT checkEntityHasBuffT = new ICheckEntityHasBuffT();
			this.UnPackTo(checkEntityHasBuffT);
			return checkEntityHasBuffT;
		}

		// Token: 0x0601DA10 RID: 121360 RVA: 0x0042B890 File Offset: 0x00429A90
		public void UnPackTo(ICheckEntityHasBuffT _o)
		{
			_o.Type = this.Type;
			_o.Target = ((this.Target != null) ? this.Target.Value.UnPack() : null);
			_o.BuffId = this.BuffId;
			_o.HasBuff = this.HasBuff;
		}

		// Token: 0x0601DA11 RID: 121361 RVA: 0x0042B8F0 File Offset: 0x00429AF0
		public static Offset<ICheckEntityHasBuff> Pack(FlatBufferBuilder builder, ICheckEntityHasBuffT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckEntityHasBuff>);
			}
			Offset<IMonsterBuffContainer> targetOffset = (_o.Target == null) ? default(Offset<IMonsterBuffContainer>) : IMonsterBuffContainer.Pack(builder, _o.Target);
			return ICheckEntityHasBuff.CreateICheckEntityHasBuff(builder, _o.Type, targetOffset, _o.BuffId, _o.HasBuff);
		}

		// Token: 0x0400D245 RID: 53829
		private Table __p;
	}
}
