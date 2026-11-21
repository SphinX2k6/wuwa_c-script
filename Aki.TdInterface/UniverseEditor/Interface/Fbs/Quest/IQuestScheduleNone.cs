using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200446F RID: 17519
	public struct IQuestScheduleNone : IFlatbufferObject
	{
		// Token: 0x1700799C RID: 31132
		// (get) Token: 0x060192D3 RID: 103123 RVA: 0x00397A66 File Offset: 0x00395C66
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060192D4 RID: 103124 RVA: 0x00397A73 File Offset: 0x00395C73
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060192D5 RID: 103125 RVA: 0x00397A7C File Offset: 0x00395C7C
		public static IQuestScheduleNone GetRootAsIQuestScheduleNone(ByteBuffer _bb)
		{
			return IQuestScheduleNone.GetRootAsIQuestScheduleNone(_bb, default(IQuestScheduleNone));
		}

		// Token: 0x060192D6 RID: 103126 RVA: 0x00397A98 File Offset: 0x00395C98
		public static IQuestScheduleNone GetRootAsIQuestScheduleNone(ByteBuffer _bb, IQuestScheduleNone obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060192D7 RID: 103127 RVA: 0x00397AB5 File Offset: 0x00395CB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060192D8 RID: 103128 RVA: 0x00397AC4 File Offset: 0x00395CC4
		public IQuestScheduleNone __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700799D RID: 31133
		// (get) Token: 0x060192D9 RID: 103129 RVA: 0x00397AD4 File Offset: 0x00395CD4
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

		// Token: 0x060192DA RID: 103130 RVA: 0x00397B10 File Offset: 0x00395D10
		public static Offset<IQuestScheduleNone> CreateIQuestScheduleNone(FlatBufferBuilder builder, EQuestScheduleType Type = EQuestScheduleType.None)
		{
			builder.StartTable(1);
			IQuestScheduleNone.AddType(builder, Type);
			return IQuestScheduleNone.EndIQuestScheduleNone(builder);
		}

		// Token: 0x060192DB RID: 103131 RVA: 0x00397B26 File Offset: 0x00395D26
		public static void StartIQuestScheduleNone(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060192DC RID: 103132 RVA: 0x00397B2F File Offset: 0x00395D2F
		public static void AddType(FlatBufferBuilder builder, EQuestScheduleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060192DD RID: 103133 RVA: 0x00397B3A File Offset: 0x00395D3A
		public static Offset<IQuestScheduleNone> EndIQuestScheduleNone(FlatBufferBuilder builder)
		{
			return new Offset<IQuestScheduleNone>(builder.EndTable());
		}

		// Token: 0x060192DE RID: 103134 RVA: 0x00397B48 File Offset: 0x00395D48
		public IQuestScheduleNoneT UnPack()
		{
			IQuestScheduleNoneT questScheduleNoneT = new IQuestScheduleNoneT();
			this.UnPackTo(questScheduleNoneT);
			return questScheduleNoneT;
		}

		// Token: 0x060192DF RID: 103135 RVA: 0x00397B63 File Offset: 0x00395D63
		public void UnPackTo(IQuestScheduleNoneT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060192E0 RID: 103136 RVA: 0x00397B74 File Offset: 0x00395D74
		public static Offset<IQuestScheduleNone> Pack(FlatBufferBuilder builder, IQuestScheduleNoneT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestScheduleNone>);
			}
			return IQuestScheduleNone.CreateIQuestScheduleNone(builder, _o.Type);
		}

		// Token: 0x0400C544 RID: 50500
		private Table __p;
	}
}
