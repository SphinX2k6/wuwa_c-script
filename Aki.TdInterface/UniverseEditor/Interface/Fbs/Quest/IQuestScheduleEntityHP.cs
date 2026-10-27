using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004022 RID: 16418
	public struct IQuestScheduleEntityHP : IFlatbufferObject
	{
		// Token: 0x17007378 RID: 29560
		// (get) Token: 0x06017B99 RID: 97177 RVA: 0x0036C15F File Offset: 0x0036A35F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017B9A RID: 97178 RVA: 0x0036C16C File Offset: 0x0036A36C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017B9B RID: 97179 RVA: 0x0036C174 File Offset: 0x0036A374
		public static IQuestScheduleEntityHP GetRootAsIQuestScheduleEntityHP(ByteBuffer _bb)
		{
			return IQuestScheduleEntityHP.GetRootAsIQuestScheduleEntityHP(_bb, default(IQuestScheduleEntityHP));
		}

		// Token: 0x06017B9C RID: 97180 RVA: 0x0036C190 File Offset: 0x0036A390
		public static IQuestScheduleEntityHP GetRootAsIQuestScheduleEntityHP(ByteBuffer _bb, IQuestScheduleEntityHP obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017B9D RID: 97181 RVA: 0x0036C1AD File Offset: 0x0036A3AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017B9E RID: 97182 RVA: 0x0036C1BC File Offset: 0x0036A3BC
		public IQuestScheduleEntityHP __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007379 RID: 29561
		// (get) Token: 0x06017B9F RID: 97183 RVA: 0x0036C1CC File Offset: 0x0036A3CC
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

		// Token: 0x1700737A RID: 29562
		// (get) Token: 0x06017BA0 RID: 97184 RVA: 0x0036C208 File Offset: 0x0036A408
		public int EntityId
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

		// Token: 0x06017BA1 RID: 97185 RVA: 0x0036C244 File Offset: 0x0036A444
		public static Offset<IQuestScheduleEntityHP> CreateIQuestScheduleEntityHP(FlatBufferBuilder builder, EQuestScheduleType Type = EQuestScheduleType.None, int EntityId = 0)
		{
			builder.StartTable(2);
			IQuestScheduleEntityHP.AddEntityId(builder, EntityId);
			IQuestScheduleEntityHP.AddType(builder, Type);
			return IQuestScheduleEntityHP.EndIQuestScheduleEntityHP(builder);
		}

		// Token: 0x06017BA2 RID: 97186 RVA: 0x0036C261 File Offset: 0x0036A461
		public static void StartIQuestScheduleEntityHP(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06017BA3 RID: 97187 RVA: 0x0036C26A File Offset: 0x0036A46A
		public static void AddType(FlatBufferBuilder builder, EQuestScheduleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017BA4 RID: 97188 RVA: 0x0036C275 File Offset: 0x0036A475
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x06017BA5 RID: 97189 RVA: 0x0036C280 File Offset: 0x0036A480
		public static Offset<IQuestScheduleEntityHP> EndIQuestScheduleEntityHP(FlatBufferBuilder builder)
		{
			return new Offset<IQuestScheduleEntityHP>(builder.EndTable());
		}

		// Token: 0x06017BA6 RID: 97190 RVA: 0x0036C290 File Offset: 0x0036A490
		public IQuestScheduleEntityHPT UnPack()
		{
			IQuestScheduleEntityHPT questScheduleEntityHPT = new IQuestScheduleEntityHPT();
			this.UnPackTo(questScheduleEntityHPT);
			return questScheduleEntityHPT;
		}

		// Token: 0x06017BA7 RID: 97191 RVA: 0x0036C2AB File Offset: 0x0036A4AB
		public void UnPackTo(IQuestScheduleEntityHPT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x06017BA8 RID: 97192 RVA: 0x0036C2C8 File Offset: 0x0036A4C8
		public static Offset<IQuestScheduleEntityHP> Pack(FlatBufferBuilder builder, IQuestScheduleEntityHPT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestScheduleEntityHP>);
			}
			return IQuestScheduleEntityHP.CreateIQuestScheduleEntityHP(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x0400BB4B RID: 47947
		private Table __p;
	}
}
