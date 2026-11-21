using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004472 RID: 17522
	public struct IQuestScheduleProgressValue : IFlatbufferObject
	{
		// Token: 0x1700799F RID: 31135
		// (get) Token: 0x060192E5 RID: 103141 RVA: 0x00397BDD File Offset: 0x00395DDD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060192E6 RID: 103142 RVA: 0x00397BEA File Offset: 0x00395DEA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060192E7 RID: 103143 RVA: 0x00397BF4 File Offset: 0x00395DF4
		public static IQuestScheduleProgressValue GetRootAsIQuestScheduleProgressValue(ByteBuffer _bb)
		{
			return IQuestScheduleProgressValue.GetRootAsIQuestScheduleProgressValue(_bb, default(IQuestScheduleProgressValue));
		}

		// Token: 0x060192E8 RID: 103144 RVA: 0x00397C10 File Offset: 0x00395E10
		public static IQuestScheduleProgressValue GetRootAsIQuestScheduleProgressValue(ByteBuffer _bb, IQuestScheduleProgressValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060192E9 RID: 103145 RVA: 0x00397C2D File Offset: 0x00395E2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060192EA RID: 103146 RVA: 0x00397C3C File Offset: 0x00395E3C
		public IQuestScheduleProgressValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170079A0 RID: 31136
		// (get) Token: 0x060192EB RID: 103147 RVA: 0x00397C4C File Offset: 0x00395E4C
		public EQuestScheduleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EQuestScheduleType.None;
				}
				return (EQuestScheduleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170079A1 RID: 31137
		// (get) Token: 0x060192EC RID: 103148 RVA: 0x00397C88 File Offset: 0x00395E88
		public int TargetProgressEntity
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

		// Token: 0x060192ED RID: 103149 RVA: 0x00397CC4 File Offset: 0x00395EC4
		public static Offset<IQuestScheduleProgressValue> CreateIQuestScheduleProgressValue(FlatBufferBuilder builder, EQuestScheduleType Type = EQuestScheduleType.None, int TargetProgressEntity = 0)
		{
			builder.StartTable(2);
			IQuestScheduleProgressValue.AddTargetProgressEntity(builder, TargetProgressEntity);
			IQuestScheduleProgressValue.AddType(builder, Type);
			return IQuestScheduleProgressValue.EndIQuestScheduleProgressValue(builder);
		}

		// Token: 0x060192EE RID: 103150 RVA: 0x00397CE1 File Offset: 0x00395EE1
		public static void StartIQuestScheduleProgressValue(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060192EF RID: 103151 RVA: 0x00397CEA File Offset: 0x00395EEA
		public static void AddType(FlatBufferBuilder builder, EQuestScheduleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060192F0 RID: 103152 RVA: 0x00397CF5 File Offset: 0x00395EF5
		public static void AddTargetProgressEntity(FlatBufferBuilder builder, int targetProgressEntity)
		{
			builder.AddInt(1, targetProgressEntity, 0);
		}

		// Token: 0x060192F1 RID: 103153 RVA: 0x00397D00 File Offset: 0x00395F00
		public static Offset<IQuestScheduleProgressValue> EndIQuestScheduleProgressValue(FlatBufferBuilder builder)
		{
			return new Offset<IQuestScheduleProgressValue>(builder.EndTable());
		}

		// Token: 0x060192F2 RID: 103154 RVA: 0x00397D10 File Offset: 0x00395F10
		public IQuestScheduleProgressValueT UnPack()
		{
			IQuestScheduleProgressValueT questScheduleProgressValueT = new IQuestScheduleProgressValueT();
			this.UnPackTo(questScheduleProgressValueT);
			return questScheduleProgressValueT;
		}

		// Token: 0x060192F3 RID: 103155 RVA: 0x00397D2B File Offset: 0x00395F2B
		public void UnPackTo(IQuestScheduleProgressValueT _o)
		{
			_o.Type = this.Type;
			_o.TargetProgressEntity = this.TargetProgressEntity;
		}

		// Token: 0x060192F4 RID: 103156 RVA: 0x00397D48 File Offset: 0x00395F48
		public static Offset<IQuestScheduleProgressValue> Pack(FlatBufferBuilder builder, IQuestScheduleProgressValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestScheduleProgressValue>);
			}
			return IQuestScheduleProgressValue.CreateIQuestScheduleProgressValue(builder, _o.Type, _o.TargetProgressEntity);
		}

		// Token: 0x0400C546 RID: 50502
		private Table __p;
	}
}
