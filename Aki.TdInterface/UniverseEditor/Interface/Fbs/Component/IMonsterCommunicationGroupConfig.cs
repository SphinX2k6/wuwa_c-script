using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200556F RID: 21871
	public struct IMonsterCommunicationGroupConfig : IFlatbufferObject
	{
		// Token: 0x1700A190 RID: 41360
		// (get) Token: 0x060242DD RID: 148189 RVA: 0x004FF23A File Offset: 0x004FD43A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060242DE RID: 148190 RVA: 0x004FF247 File Offset: 0x004FD447
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060242DF RID: 148191 RVA: 0x004FF250 File Offset: 0x004FD450
		public static IMonsterCommunicationGroupConfig GetRootAsIMonsterCommunicationGroupConfig(ByteBuffer _bb)
		{
			return IMonsterCommunicationGroupConfig.GetRootAsIMonsterCommunicationGroupConfig(_bb, default(IMonsterCommunicationGroupConfig));
		}

		// Token: 0x060242E0 RID: 148192 RVA: 0x004FF26C File Offset: 0x004FD46C
		public static IMonsterCommunicationGroupConfig GetRootAsIMonsterCommunicationGroupConfig(ByteBuffer _bb, IMonsterCommunicationGroupConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060242E1 RID: 148193 RVA: 0x004FF289 File Offset: 0x004FD489
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060242E2 RID: 148194 RVA: 0x004FF298 File Offset: 0x004FD498
		public IMonsterCommunicationGroupConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A191 RID: 41361
		// (get) Token: 0x060242E3 RID: 148195 RVA: 0x004FF2A8 File Offset: 0x004FD4A8
		public int GroupId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060242E4 RID: 148196 RVA: 0x004FF2E4 File Offset: 0x004FD4E4
		public static Offset<IMonsterCommunicationGroupConfig> CreateIMonsterCommunicationGroupConfig(FlatBufferBuilder builder, int GroupId = 0)
		{
			builder.StartTable(1);
			IMonsterCommunicationGroupConfig.AddGroupId(builder, GroupId);
			return IMonsterCommunicationGroupConfig.EndIMonsterCommunicationGroupConfig(builder);
		}

		// Token: 0x060242E5 RID: 148197 RVA: 0x004FF2FA File Offset: 0x004FD4FA
		public static void StartIMonsterCommunicationGroupConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060242E6 RID: 148198 RVA: 0x004FF303 File Offset: 0x004FD503
		public static void AddGroupId(FlatBufferBuilder builder, int groupId)
		{
			builder.AddInt(0, groupId, 0);
		}

		// Token: 0x060242E7 RID: 148199 RVA: 0x004FF30E File Offset: 0x004FD50E
		public static Offset<IMonsterCommunicationGroupConfig> EndIMonsterCommunicationGroupConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterCommunicationGroupConfig>(builder.EndTable());
		}

		// Token: 0x060242E8 RID: 148200 RVA: 0x004FF31C File Offset: 0x004FD51C
		public IMonsterCommunicationGroupConfigT UnPack()
		{
			IMonsterCommunicationGroupConfigT monsterCommunicationGroupConfigT = new IMonsterCommunicationGroupConfigT();
			this.UnPackTo(monsterCommunicationGroupConfigT);
			return monsterCommunicationGroupConfigT;
		}

		// Token: 0x060242E9 RID: 148201 RVA: 0x004FF337 File Offset: 0x004FD537
		public void UnPackTo(IMonsterCommunicationGroupConfigT _o)
		{
			_o.GroupId = this.GroupId;
		}

		// Token: 0x060242EA RID: 148202 RVA: 0x004FF348 File Offset: 0x004FD548
		public static Offset<IMonsterCommunicationGroupConfig> Pack(FlatBufferBuilder builder, IMonsterCommunicationGroupConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterCommunicationGroupConfig>);
			}
			return IMonsterCommunicationGroupConfig.CreateIMonsterCommunicationGroupConfig(builder, _o.GroupId);
		}

		// Token: 0x0400E892 RID: 59538
		private Table __p;
	}
}
