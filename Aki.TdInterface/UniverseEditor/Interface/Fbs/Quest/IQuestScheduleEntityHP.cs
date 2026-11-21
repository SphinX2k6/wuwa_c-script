using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004463 RID: 17507
	public struct IQuestScheduleEntityHP : IFlatbufferObject
	{
		// Token: 0x1700797A RID: 31098
		// (get) Token: 0x06019232 RID: 102962 RVA: 0x00395F53 File Offset: 0x00394153
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019233 RID: 102963 RVA: 0x00395F60 File Offset: 0x00394160
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019234 RID: 102964 RVA: 0x00395F68 File Offset: 0x00394168
		public static IQuestScheduleEntityHP GetRootAsIQuestScheduleEntityHP(ByteBuffer _bb)
		{
			return IQuestScheduleEntityHP.GetRootAsIQuestScheduleEntityHP(_bb, default(IQuestScheduleEntityHP));
		}

		// Token: 0x06019235 RID: 102965 RVA: 0x00395F84 File Offset: 0x00394184
		public static IQuestScheduleEntityHP GetRootAsIQuestScheduleEntityHP(ByteBuffer _bb, IQuestScheduleEntityHP obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019236 RID: 102966 RVA: 0x00395FA1 File Offset: 0x003941A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019237 RID: 102967 RVA: 0x00395FB0 File Offset: 0x003941B0
		public IQuestScheduleEntityHP __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700797B RID: 31099
		// (get) Token: 0x06019238 RID: 102968 RVA: 0x00395FC0 File Offset: 0x003941C0
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

		// Token: 0x1700797C RID: 31100
		// (get) Token: 0x06019239 RID: 102969 RVA: 0x00395FFC File Offset: 0x003941FC
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

		// Token: 0x0601923A RID: 102970 RVA: 0x00396038 File Offset: 0x00394238
		public static Offset<IQuestScheduleEntityHP> CreateIQuestScheduleEntityHP(FlatBufferBuilder builder, EQuestScheduleType Type = EQuestScheduleType.None, int EntityId = 0)
		{
			builder.StartTable(2);
			IQuestScheduleEntityHP.AddEntityId(builder, EntityId);
			IQuestScheduleEntityHP.AddType(builder, Type);
			return IQuestScheduleEntityHP.EndIQuestScheduleEntityHP(builder);
		}

		// Token: 0x0601923B RID: 102971 RVA: 0x00396055 File Offset: 0x00394255
		public static void StartIQuestScheduleEntityHP(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601923C RID: 102972 RVA: 0x0039605E File Offset: 0x0039425E
		public static void AddType(FlatBufferBuilder builder, EQuestScheduleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601923D RID: 102973 RVA: 0x00396069 File Offset: 0x00394269
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0601923E RID: 102974 RVA: 0x00396074 File Offset: 0x00394274
		public static Offset<IQuestScheduleEntityHP> EndIQuestScheduleEntityHP(FlatBufferBuilder builder)
		{
			return new Offset<IQuestScheduleEntityHP>(builder.EndTable());
		}

		// Token: 0x0601923F RID: 102975 RVA: 0x00396084 File Offset: 0x00394284
		public IQuestScheduleEntityHPT UnPack()
		{
			IQuestScheduleEntityHPT questScheduleEntityHPT = new IQuestScheduleEntityHPT();
			this.UnPackTo(questScheduleEntityHPT);
			return questScheduleEntityHPT;
		}

		// Token: 0x06019240 RID: 102976 RVA: 0x0039609F File Offset: 0x0039429F
		public void UnPackTo(IQuestScheduleEntityHPT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x06019241 RID: 102977 RVA: 0x003960BC File Offset: 0x003942BC
		public static Offset<IQuestScheduleEntityHP> Pack(FlatBufferBuilder builder, IQuestScheduleEntityHPT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestScheduleEntityHP>);
			}
			return IQuestScheduleEntityHP.CreateIQuestScheduleEntityHP(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x0400C532 RID: 50482
		private Table __p;
	}
}
