using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B0D RID: 23309
	public struct IMonsterCommunicationGroupConfig : IFlatbufferObject
	{
		// Token: 0x1700AA13 RID: 43539
		// (get) Token: 0x060264CA RID: 156874 RVA: 0x0053F135 File Offset: 0x0053D335
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060264CB RID: 156875 RVA: 0x0053F142 File Offset: 0x0053D342
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060264CC RID: 156876 RVA: 0x0053F14C File Offset: 0x0053D34C
		public static IMonsterCommunicationGroupConfig GetRootAsIMonsterCommunicationGroupConfig(ByteBuffer _bb)
		{
			return IMonsterCommunicationGroupConfig.GetRootAsIMonsterCommunicationGroupConfig(_bb, default(IMonsterCommunicationGroupConfig));
		}

		// Token: 0x060264CD RID: 156877 RVA: 0x0053F168 File Offset: 0x0053D368
		public static IMonsterCommunicationGroupConfig GetRootAsIMonsterCommunicationGroupConfig(ByteBuffer _bb, IMonsterCommunicationGroupConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060264CE RID: 156878 RVA: 0x0053F185 File Offset: 0x0053D385
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060264CF RID: 156879 RVA: 0x0053F194 File Offset: 0x0053D394
		public IMonsterCommunicationGroupConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA14 RID: 43540
		// (get) Token: 0x060264D0 RID: 156880 RVA: 0x0053F1A4 File Offset: 0x0053D3A4
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

		// Token: 0x060264D1 RID: 156881 RVA: 0x0053F1E0 File Offset: 0x0053D3E0
		public static Offset<IMonsterCommunicationGroupConfig> CreateIMonsterCommunicationGroupConfig(FlatBufferBuilder builder, int GroupId = 0)
		{
			builder.StartTable(1);
			IMonsterCommunicationGroupConfig.AddGroupId(builder, GroupId);
			return IMonsterCommunicationGroupConfig.EndIMonsterCommunicationGroupConfig(builder);
		}

		// Token: 0x060264D2 RID: 156882 RVA: 0x0053F1F6 File Offset: 0x0053D3F6
		public static void StartIMonsterCommunicationGroupConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060264D3 RID: 156883 RVA: 0x0053F1FF File Offset: 0x0053D3FF
		public static void AddGroupId(FlatBufferBuilder builder, int groupId)
		{
			builder.AddInt(0, groupId, 0);
		}

		// Token: 0x060264D4 RID: 156884 RVA: 0x0053F20A File Offset: 0x0053D40A
		public static Offset<IMonsterCommunicationGroupConfig> EndIMonsterCommunicationGroupConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterCommunicationGroupConfig>(builder.EndTable());
		}

		// Token: 0x060264D5 RID: 156885 RVA: 0x0053F218 File Offset: 0x0053D418
		public IMonsterCommunicationGroupConfigT UnPack()
		{
			IMonsterCommunicationGroupConfigT monsterCommunicationGroupConfigT = new IMonsterCommunicationGroupConfigT();
			this.UnPackTo(monsterCommunicationGroupConfigT);
			return monsterCommunicationGroupConfigT;
		}

		// Token: 0x060264D6 RID: 156886 RVA: 0x0053F233 File Offset: 0x0053D433
		public void UnPackTo(IMonsterCommunicationGroupConfigT _o)
		{
			_o.GroupId = this.GroupId;
		}

		// Token: 0x060264D7 RID: 156887 RVA: 0x0053F244 File Offset: 0x0053D444
		public static Offset<IMonsterCommunicationGroupConfig> Pack(FlatBufferBuilder builder, IMonsterCommunicationGroupConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterCommunicationGroupConfig>);
			}
			return IMonsterCommunicationGroupConfig.CreateIMonsterCommunicationGroupConfig(builder, _o.GroupId);
		}

		// Token: 0x0400F4F2 RID: 62706
		private Table __p;
	}
}
