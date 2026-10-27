using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200402E RID: 16430
	public struct IQuestScheduleNone : IFlatbufferObject
	{
		// Token: 0x1700739A RID: 29594
		// (get) Token: 0x06017C3A RID: 97338 RVA: 0x0036DC72 File Offset: 0x0036BE72
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017C3B RID: 97339 RVA: 0x0036DC7F File Offset: 0x0036BE7F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017C3C RID: 97340 RVA: 0x0036DC88 File Offset: 0x0036BE88
		public static IQuestScheduleNone GetRootAsIQuestScheduleNone(ByteBuffer _bb)
		{
			return IQuestScheduleNone.GetRootAsIQuestScheduleNone(_bb, default(IQuestScheduleNone));
		}

		// Token: 0x06017C3D RID: 97341 RVA: 0x0036DCA4 File Offset: 0x0036BEA4
		public static IQuestScheduleNone GetRootAsIQuestScheduleNone(ByteBuffer _bb, IQuestScheduleNone obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017C3E RID: 97342 RVA: 0x0036DCC1 File Offset: 0x0036BEC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017C3F RID: 97343 RVA: 0x0036DCD0 File Offset: 0x0036BED0
		public IQuestScheduleNone __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700739B RID: 29595
		// (get) Token: 0x06017C40 RID: 97344 RVA: 0x0036DCE0 File Offset: 0x0036BEE0
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

		// Token: 0x06017C41 RID: 97345 RVA: 0x0036DD1C File Offset: 0x0036BF1C
		public static Offset<IQuestScheduleNone> CreateIQuestScheduleNone(FlatBufferBuilder builder, EQuestScheduleType Type = EQuestScheduleType.None)
		{
			builder.StartTable(1);
			IQuestScheduleNone.AddType(builder, Type);
			return IQuestScheduleNone.EndIQuestScheduleNone(builder);
		}

		// Token: 0x06017C42 RID: 97346 RVA: 0x0036DD32 File Offset: 0x0036BF32
		public static void StartIQuestScheduleNone(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06017C43 RID: 97347 RVA: 0x0036DD3B File Offset: 0x0036BF3B
		public static void AddType(FlatBufferBuilder builder, EQuestScheduleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017C44 RID: 97348 RVA: 0x0036DD46 File Offset: 0x0036BF46
		public static Offset<IQuestScheduleNone> EndIQuestScheduleNone(FlatBufferBuilder builder)
		{
			return new Offset<IQuestScheduleNone>(builder.EndTable());
		}

		// Token: 0x06017C45 RID: 97349 RVA: 0x0036DD54 File Offset: 0x0036BF54
		public IQuestScheduleNoneT UnPack()
		{
			IQuestScheduleNoneT questScheduleNoneT = new IQuestScheduleNoneT();
			this.UnPackTo(questScheduleNoneT);
			return questScheduleNoneT;
		}

		// Token: 0x06017C46 RID: 97350 RVA: 0x0036DD6F File Offset: 0x0036BF6F
		public void UnPackTo(IQuestScheduleNoneT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06017C47 RID: 97351 RVA: 0x0036DD80 File Offset: 0x0036BF80
		public static Offset<IQuestScheduleNone> Pack(FlatBufferBuilder builder, IQuestScheduleNoneT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestScheduleNone>);
			}
			return IQuestScheduleNone.CreateIQuestScheduleNone(builder, _o.Type);
		}

		// Token: 0x0400BB5D RID: 47965
		private Table __p;
	}
}
