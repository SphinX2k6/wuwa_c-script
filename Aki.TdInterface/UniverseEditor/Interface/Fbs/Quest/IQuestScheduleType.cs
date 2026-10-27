using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004043 RID: 16451
	public struct IQuestScheduleType : IFlatbufferObject
	{
		// Token: 0x170073CD RID: 29645
		// (get) Token: 0x06017D16 RID: 97558 RVA: 0x0036FB0D File Offset: 0x0036DD0D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017D17 RID: 97559 RVA: 0x0036FB1A File Offset: 0x0036DD1A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017D18 RID: 97560 RVA: 0x0036FB24 File Offset: 0x0036DD24
		public static IQuestScheduleType GetRootAsIQuestScheduleType(ByteBuffer _bb)
		{
			return IQuestScheduleType.GetRootAsIQuestScheduleType(_bb, default(IQuestScheduleType));
		}

		// Token: 0x06017D19 RID: 97561 RVA: 0x0036FB40 File Offset: 0x0036DD40
		public static IQuestScheduleType GetRootAsIQuestScheduleType(ByteBuffer _bb, IQuestScheduleType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017D1A RID: 97562 RVA: 0x0036FB5D File Offset: 0x0036DD5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017D1B RID: 97563 RVA: 0x0036FB6C File Offset: 0x0036DD6C
		public IQuestScheduleType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170073CE RID: 29646
		// (get) Token: 0x06017D1C RID: 97564 RVA: 0x0036FB7C File Offset: 0x0036DD7C
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

		// Token: 0x06017D1D RID: 97565 RVA: 0x0036FBB8 File Offset: 0x0036DDB8
		public static Offset<IQuestScheduleType> CreateIQuestScheduleType(FlatBufferBuilder builder, EQuestScheduleType Type = EQuestScheduleType.None)
		{
			builder.StartTable(1);
			IQuestScheduleType.AddType(builder, Type);
			return IQuestScheduleType.EndIQuestScheduleType(builder);
		}

		// Token: 0x06017D1E RID: 97566 RVA: 0x0036FBCE File Offset: 0x0036DDCE
		public static void StartIQuestScheduleType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06017D1F RID: 97567 RVA: 0x0036FBD7 File Offset: 0x0036DDD7
		public static void AddType(FlatBufferBuilder builder, EQuestScheduleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017D20 RID: 97568 RVA: 0x0036FBE2 File Offset: 0x0036DDE2
		public static Offset<IQuestScheduleType> EndIQuestScheduleType(FlatBufferBuilder builder)
		{
			return new Offset<IQuestScheduleType>(builder.EndTable());
		}

		// Token: 0x06017D21 RID: 97569 RVA: 0x0036FBF0 File Offset: 0x0036DDF0
		public IQuestScheduleTypeT UnPack()
		{
			IQuestScheduleTypeT questScheduleTypeT = new IQuestScheduleTypeT();
			this.UnPackTo(questScheduleTypeT);
			return questScheduleTypeT;
		}

		// Token: 0x06017D22 RID: 97570 RVA: 0x0036FC0B File Offset: 0x0036DE0B
		public void UnPackTo(IQuestScheduleTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06017D23 RID: 97571 RVA: 0x0036FC1C File Offset: 0x0036DE1C
		public static Offset<IQuestScheduleType> Pack(FlatBufferBuilder builder, IQuestScheduleTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestScheduleType>);
			}
			return IQuestScheduleType.CreateIQuestScheduleType(builder, _o.Type);
		}

		// Token: 0x0400BB7A RID: 47994
		private Table __p;
	}
}
