using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060FA RID: 24826
	public struct ITriggerRangeStartCondition : IFlatbufferObject
	{
		// Token: 0x1700B8D1 RID: 47313
		// (get) Token: 0x0602A140 RID: 172352 RVA: 0x005BE81C File Offset: 0x005BCA1C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A141 RID: 172353 RVA: 0x005BE829 File Offset: 0x005BCA29
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A142 RID: 172354 RVA: 0x005BE830 File Offset: 0x005BCA30
		public static ITriggerRangeStartCondition GetRootAsITriggerRangeStartCondition(ByteBuffer _bb)
		{
			return ITriggerRangeStartCondition.GetRootAsITriggerRangeStartCondition(_bb, default(ITriggerRangeStartCondition));
		}

		// Token: 0x0602A143 RID: 172355 RVA: 0x005BE84C File Offset: 0x005BCA4C
		public static ITriggerRangeStartCondition GetRootAsITriggerRangeStartCondition(ByteBuffer _bb, ITriggerRangeStartCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A144 RID: 172356 RVA: 0x005BE869 File Offset: 0x005BCA69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A145 RID: 172357 RVA: 0x005BE878 File Offset: 0x005BCA78
		public ITriggerRangeStartCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B8D2 RID: 47314
		// (get) Token: 0x0602A146 RID: 172358 RVA: 0x005BE888 File Offset: 0x005BCA88
		public ESpawnMonsterStartCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpawnMonsterStartCondition.Immediate;
				}
				return (ESpawnMonsterStartCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B8D3 RID: 47315
		// (get) Token: 0x0602A147 RID: 172359 RVA: 0x005BE8C4 File Offset: 0x005BCAC4
		public int Range
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

		// Token: 0x0602A148 RID: 172360 RVA: 0x005BE900 File Offset: 0x005BCB00
		public static Offset<ITriggerRangeStartCondition> CreateITriggerRangeStartCondition(FlatBufferBuilder builder, ESpawnMonsterStartCondition Type = ESpawnMonsterStartCondition.Immediate, int Range = 0)
		{
			builder.StartTable(2);
			ITriggerRangeStartCondition.AddRange(builder, Range);
			ITriggerRangeStartCondition.AddType(builder, Type);
			return ITriggerRangeStartCondition.EndITriggerRangeStartCondition(builder);
		}

		// Token: 0x0602A149 RID: 172361 RVA: 0x005BE91D File Offset: 0x005BCB1D
		public static void StartITriggerRangeStartCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602A14A RID: 172362 RVA: 0x005BE926 File Offset: 0x005BCB26
		public static void AddType(FlatBufferBuilder builder, ESpawnMonsterStartCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A14B RID: 172363 RVA: 0x005BE931 File Offset: 0x005BCB31
		public static void AddRange(FlatBufferBuilder builder, int range)
		{
			builder.AddInt(1, range, 0);
		}

		// Token: 0x0602A14C RID: 172364 RVA: 0x005BE93C File Offset: 0x005BCB3C
		public static Offset<ITriggerRangeStartCondition> EndITriggerRangeStartCondition(FlatBufferBuilder builder)
		{
			return new Offset<ITriggerRangeStartCondition>(builder.EndTable());
		}

		// Token: 0x0602A14D RID: 172365 RVA: 0x005BE94C File Offset: 0x005BCB4C
		public ITriggerRangeStartConditionT UnPack()
		{
			ITriggerRangeStartConditionT triggerRangeStartConditionT = new ITriggerRangeStartConditionT();
			this.UnPackTo(triggerRangeStartConditionT);
			return triggerRangeStartConditionT;
		}

		// Token: 0x0602A14E RID: 172366 RVA: 0x005BE967 File Offset: 0x005BCB67
		public void UnPackTo(ITriggerRangeStartConditionT _o)
		{
			_o.Type = this.Type;
			_o.Range = this.Range;
		}

		// Token: 0x0602A14F RID: 172367 RVA: 0x005BE984 File Offset: 0x005BCB84
		public static Offset<ITriggerRangeStartCondition> Pack(FlatBufferBuilder builder, ITriggerRangeStartConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITriggerRangeStartCondition>);
			}
			return ITriggerRangeStartCondition.CreateITriggerRangeStartCondition(builder, _o.Type, _o.Range);
		}

		// Token: 0x0400FEDE RID: 65246
		private Table __p;
	}
}
