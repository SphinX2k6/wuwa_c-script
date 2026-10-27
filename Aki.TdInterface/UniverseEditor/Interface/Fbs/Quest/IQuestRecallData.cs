using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200400D RID: 16397
	public struct IQuestRecallData : IFlatbufferObject
	{
		// Token: 0x17007336 RID: 29494
		// (get) Token: 0x06017A9E RID: 96926 RVA: 0x00369CD8 File Offset: 0x00367ED8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017A9F RID: 96927 RVA: 0x00369CE5 File Offset: 0x00367EE5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017AA0 RID: 96928 RVA: 0x00369CEC File Offset: 0x00367EEC
		public static IQuestRecallData GetRootAsIQuestRecallData(ByteBuffer _bb)
		{
			return IQuestRecallData.GetRootAsIQuestRecallData(_bb, default(IQuestRecallData));
		}

		// Token: 0x06017AA1 RID: 96929 RVA: 0x00369D08 File Offset: 0x00367F08
		public static IQuestRecallData GetRootAsIQuestRecallData(ByteBuffer _bb, IQuestRecallData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017AA2 RID: 96930 RVA: 0x00369D25 File Offset: 0x00367F25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017AA3 RID: 96931 RVA: 0x00369D34 File Offset: 0x00367F34
		public IQuestRecallData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007337 RID: 29495
		// (get) Token: 0x06017AA4 RID: 96932 RVA: 0x00369D44 File Offset: 0x00367F44
		public ERecallDataType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERecallDataType.LevelPlay;
				}
				return (ERecallDataType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007338 RID: 29496
		// (get) Token: 0x06017AA5 RID: 96933 RVA: 0x00369D80 File Offset: 0x00367F80
		public int Id
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

		// Token: 0x17007339 RID: 29497
		// (get) Token: 0x06017AA6 RID: 96934 RVA: 0x00369DBC File Offset: 0x00367FBC
		public IQuestRecallConfig? RecallConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IQuestRecallConfig?(default(IQuestRecallConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06017AA7 RID: 96935 RVA: 0x00369E19 File Offset: 0x00368019
		public static Offset<IQuestRecallData> CreateIQuestRecallData(FlatBufferBuilder builder, ERecallDataType Type = ERecallDataType.LevelPlay, int Id = 0, Offset<IQuestRecallConfig> RecallConfigOffset = default(Offset<IQuestRecallConfig>))
		{
			builder.StartTable(3);
			IQuestRecallData.AddRecallConfig(builder, RecallConfigOffset);
			IQuestRecallData.AddId(builder, Id);
			IQuestRecallData.AddType(builder, Type);
			return IQuestRecallData.EndIQuestRecallData(builder);
		}

		// Token: 0x06017AA8 RID: 96936 RVA: 0x00369E3D File Offset: 0x0036803D
		public static void StartIQuestRecallData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06017AA9 RID: 96937 RVA: 0x00369E46 File Offset: 0x00368046
		public static void AddType(FlatBufferBuilder builder, ERecallDataType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017AAA RID: 96938 RVA: 0x00369E51 File Offset: 0x00368051
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06017AAB RID: 96939 RVA: 0x00369E5C File Offset: 0x0036805C
		public static void AddRecallConfig(FlatBufferBuilder builder, Offset<IQuestRecallConfig> recallConfigOffset)
		{
			builder.AddOffset(2, recallConfigOffset.Value, 0);
		}

		// Token: 0x06017AAC RID: 96940 RVA: 0x00369E6C File Offset: 0x0036806C
		public static Offset<IQuestRecallData> EndIQuestRecallData(FlatBufferBuilder builder)
		{
			return new Offset<IQuestRecallData>(builder.EndTable());
		}

		// Token: 0x06017AAD RID: 96941 RVA: 0x00369E7C File Offset: 0x0036807C
		public IQuestRecallDataT UnPack()
		{
			IQuestRecallDataT questRecallDataT = new IQuestRecallDataT();
			this.UnPackTo(questRecallDataT);
			return questRecallDataT;
		}

		// Token: 0x06017AAE RID: 96942 RVA: 0x00369E98 File Offset: 0x00368098
		public void UnPackTo(IQuestRecallDataT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.RecallConfig = ((this.RecallConfig != null) ? this.RecallConfig.Value.UnPack() : null);
		}

		// Token: 0x06017AAF RID: 96943 RVA: 0x00369EEC File Offset: 0x003680EC
		public static Offset<IQuestRecallData> Pack(FlatBufferBuilder builder, IQuestRecallDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestRecallData>);
			}
			Offset<IQuestRecallConfig> recallConfigOffset = (_o.RecallConfig == null) ? default(Offset<IQuestRecallConfig>) : IQuestRecallConfig.Pack(builder, _o.RecallConfig);
			return IQuestRecallData.CreateIQuestRecallData(builder, _o.Type, _o.Id, recallConfigOffset);
		}

		// Token: 0x0400BB27 RID: 47911
		private Table __p;
	}
}
