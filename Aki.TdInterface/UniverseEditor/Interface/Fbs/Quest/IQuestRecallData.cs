using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200444E RID: 17486
	public struct IQuestRecallData : IFlatbufferObject
	{
		// Token: 0x17007938 RID: 31032
		// (get) Token: 0x06019137 RID: 102711 RVA: 0x00393ACC File Offset: 0x00391CCC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019138 RID: 102712 RVA: 0x00393AD9 File Offset: 0x00391CD9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019139 RID: 102713 RVA: 0x00393AE0 File Offset: 0x00391CE0
		public static IQuestRecallData GetRootAsIQuestRecallData(ByteBuffer _bb)
		{
			return IQuestRecallData.GetRootAsIQuestRecallData(_bb, default(IQuestRecallData));
		}

		// Token: 0x0601913A RID: 102714 RVA: 0x00393AFC File Offset: 0x00391CFC
		public static IQuestRecallData GetRootAsIQuestRecallData(ByteBuffer _bb, IQuestRecallData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601913B RID: 102715 RVA: 0x00393B19 File Offset: 0x00391D19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601913C RID: 102716 RVA: 0x00393B28 File Offset: 0x00391D28
		public IQuestRecallData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007939 RID: 31033
		// (get) Token: 0x0601913D RID: 102717 RVA: 0x00393B38 File Offset: 0x00391D38
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

		// Token: 0x1700793A RID: 31034
		// (get) Token: 0x0601913E RID: 102718 RVA: 0x00393B74 File Offset: 0x00391D74
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

		// Token: 0x1700793B RID: 31035
		// (get) Token: 0x0601913F RID: 102719 RVA: 0x00393BB0 File Offset: 0x00391DB0
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

		// Token: 0x06019140 RID: 102720 RVA: 0x00393C0D File Offset: 0x00391E0D
		public static Offset<IQuestRecallData> CreateIQuestRecallData(FlatBufferBuilder builder, ERecallDataType Type = ERecallDataType.LevelPlay, int Id = 0, Offset<IQuestRecallConfig> RecallConfigOffset = default(Offset<IQuestRecallConfig>))
		{
			builder.StartTable(3);
			IQuestRecallData.AddRecallConfig(builder, RecallConfigOffset);
			IQuestRecallData.AddId(builder, Id);
			IQuestRecallData.AddType(builder, Type);
			return IQuestRecallData.EndIQuestRecallData(builder);
		}

		// Token: 0x06019141 RID: 102721 RVA: 0x00393C31 File Offset: 0x00391E31
		public static void StartIQuestRecallData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06019142 RID: 102722 RVA: 0x00393C3A File Offset: 0x00391E3A
		public static void AddType(FlatBufferBuilder builder, ERecallDataType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019143 RID: 102723 RVA: 0x00393C45 File Offset: 0x00391E45
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06019144 RID: 102724 RVA: 0x00393C50 File Offset: 0x00391E50
		public static void AddRecallConfig(FlatBufferBuilder builder, Offset<IQuestRecallConfig> recallConfigOffset)
		{
			builder.AddOffset(2, recallConfigOffset.Value, 0);
		}

		// Token: 0x06019145 RID: 102725 RVA: 0x00393C60 File Offset: 0x00391E60
		public static Offset<IQuestRecallData> EndIQuestRecallData(FlatBufferBuilder builder)
		{
			return new Offset<IQuestRecallData>(builder.EndTable());
		}

		// Token: 0x06019146 RID: 102726 RVA: 0x00393C70 File Offset: 0x00391E70
		public IQuestRecallDataT UnPack()
		{
			IQuestRecallDataT questRecallDataT = new IQuestRecallDataT();
			this.UnPackTo(questRecallDataT);
			return questRecallDataT;
		}

		// Token: 0x06019147 RID: 102727 RVA: 0x00393C8C File Offset: 0x00391E8C
		public void UnPackTo(IQuestRecallDataT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.RecallConfig = ((this.RecallConfig != null) ? this.RecallConfig.Value.UnPack() : null);
		}

		// Token: 0x06019148 RID: 102728 RVA: 0x00393CE0 File Offset: 0x00391EE0
		public static Offset<IQuestRecallData> Pack(FlatBufferBuilder builder, IQuestRecallDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestRecallData>);
			}
			Offset<IQuestRecallConfig> recallConfigOffset = (_o.RecallConfig == null) ? default(Offset<IQuestRecallConfig>) : IQuestRecallConfig.Pack(builder, _o.RecallConfig);
			return IQuestRecallData.CreateIQuestRecallData(builder, _o.Type, _o.Id, recallConfigOffset);
		}

		// Token: 0x0400C50E RID: 50446
		private Table __p;
	}
}
