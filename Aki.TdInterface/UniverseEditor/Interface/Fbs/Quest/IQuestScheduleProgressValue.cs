using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004031 RID: 16433
	public struct IQuestScheduleProgressValue : IFlatbufferObject
	{
		// Token: 0x1700739D RID: 29597
		// (get) Token: 0x06017C4C RID: 97356 RVA: 0x0036DDE9 File Offset: 0x0036BFE9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017C4D RID: 97357 RVA: 0x0036DDF6 File Offset: 0x0036BFF6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017C4E RID: 97358 RVA: 0x0036DE00 File Offset: 0x0036C000
		public static IQuestScheduleProgressValue GetRootAsIQuestScheduleProgressValue(ByteBuffer _bb)
		{
			return IQuestScheduleProgressValue.GetRootAsIQuestScheduleProgressValue(_bb, default(IQuestScheduleProgressValue));
		}

		// Token: 0x06017C4F RID: 97359 RVA: 0x0036DE1C File Offset: 0x0036C01C
		public static IQuestScheduleProgressValue GetRootAsIQuestScheduleProgressValue(ByteBuffer _bb, IQuestScheduleProgressValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017C50 RID: 97360 RVA: 0x0036DE39 File Offset: 0x0036C039
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017C51 RID: 97361 RVA: 0x0036DE48 File Offset: 0x0036C048
		public IQuestScheduleProgressValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700739E RID: 29598
		// (get) Token: 0x06017C52 RID: 97362 RVA: 0x0036DE58 File Offset: 0x0036C058
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

		// Token: 0x1700739F RID: 29599
		// (get) Token: 0x06017C53 RID: 97363 RVA: 0x0036DE94 File Offset: 0x0036C094
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

		// Token: 0x06017C54 RID: 97364 RVA: 0x0036DED0 File Offset: 0x0036C0D0
		public static Offset<IQuestScheduleProgressValue> CreateIQuestScheduleProgressValue(FlatBufferBuilder builder, EQuestScheduleType Type = EQuestScheduleType.None, int TargetProgressEntity = 0)
		{
			builder.StartTable(2);
			IQuestScheduleProgressValue.AddTargetProgressEntity(builder, TargetProgressEntity);
			IQuestScheduleProgressValue.AddType(builder, Type);
			return IQuestScheduleProgressValue.EndIQuestScheduleProgressValue(builder);
		}

		// Token: 0x06017C55 RID: 97365 RVA: 0x0036DEED File Offset: 0x0036C0ED
		public static void StartIQuestScheduleProgressValue(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06017C56 RID: 97366 RVA: 0x0036DEF6 File Offset: 0x0036C0F6
		public static void AddType(FlatBufferBuilder builder, EQuestScheduleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017C57 RID: 97367 RVA: 0x0036DF01 File Offset: 0x0036C101
		public static void AddTargetProgressEntity(FlatBufferBuilder builder, int targetProgressEntity)
		{
			builder.AddInt(1, targetProgressEntity, 0);
		}

		// Token: 0x06017C58 RID: 97368 RVA: 0x0036DF0C File Offset: 0x0036C10C
		public static Offset<IQuestScheduleProgressValue> EndIQuestScheduleProgressValue(FlatBufferBuilder builder)
		{
			return new Offset<IQuestScheduleProgressValue>(builder.EndTable());
		}

		// Token: 0x06017C59 RID: 97369 RVA: 0x0036DF1C File Offset: 0x0036C11C
		public IQuestScheduleProgressValueT UnPack()
		{
			IQuestScheduleProgressValueT questScheduleProgressValueT = new IQuestScheduleProgressValueT();
			this.UnPackTo(questScheduleProgressValueT);
			return questScheduleProgressValueT;
		}

		// Token: 0x06017C5A RID: 97370 RVA: 0x0036DF37 File Offset: 0x0036C137
		public void UnPackTo(IQuestScheduleProgressValueT _o)
		{
			_o.Type = this.Type;
			_o.TargetProgressEntity = this.TargetProgressEntity;
		}

		// Token: 0x06017C5B RID: 97371 RVA: 0x0036DF54 File Offset: 0x0036C154
		public static Offset<IQuestScheduleProgressValue> Pack(FlatBufferBuilder builder, IQuestScheduleProgressValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestScheduleProgressValue>);
			}
			return IQuestScheduleProgressValue.CreateIQuestScheduleProgressValue(builder, _o.Type, _o.TargetProgressEntity);
		}

		// Token: 0x0400BB5F RID: 47967
		private Table __p;
	}
}
