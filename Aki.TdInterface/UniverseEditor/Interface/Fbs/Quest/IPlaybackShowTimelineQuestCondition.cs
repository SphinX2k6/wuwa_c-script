using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043DF RID: 17375
	public struct IPlaybackShowTimelineQuestCondition : IFlatbufferObject
	{
		// Token: 0x170077B1 RID: 30641
		// (get) Token: 0x06018AD3 RID: 101075 RVA: 0x00384B27 File Offset: 0x00382D27
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018AD4 RID: 101076 RVA: 0x00384B34 File Offset: 0x00382D34
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018AD5 RID: 101077 RVA: 0x00384B3C File Offset: 0x00382D3C
		public static IPlaybackShowTimelineQuestCondition GetRootAsIPlaybackShowTimelineQuestCondition(ByteBuffer _bb)
		{
			return IPlaybackShowTimelineQuestCondition.GetRootAsIPlaybackShowTimelineQuestCondition(_bb, default(IPlaybackShowTimelineQuestCondition));
		}

		// Token: 0x06018AD6 RID: 101078 RVA: 0x00384B58 File Offset: 0x00382D58
		public static IPlaybackShowTimelineQuestCondition GetRootAsIPlaybackShowTimelineQuestCondition(ByteBuffer _bb, IPlaybackShowTimelineQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018AD7 RID: 101079 RVA: 0x00384B75 File Offset: 0x00382D75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018AD8 RID: 101080 RVA: 0x00384B84 File Offset: 0x00382D84
		public IPlaybackShowTimelineQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170077B2 RID: 30642
		// (get) Token: 0x06018AD9 RID: 101081 RVA: 0x00384B94 File Offset: 0x00382D94
		public EChildQuest Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChildQuest.DoInteract;
				}
				return (EChildQuest)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170077B3 RID: 30643
		// (get) Token: 0x06018ADA RID: 101082 RVA: 0x00384BD0 File Offset: 0x00382DD0
		public IConditionGroup? PreConditions
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170077B4 RID: 30644
		// (get) Token: 0x06018ADB RID: 101083 RVA: 0x00384C30 File Offset: 0x00382E30
		public string ShowTimelineFileName
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018ADC RID: 101084 RVA: 0x00384C67 File Offset: 0x00382E67
		public Span<byte> GetShowTimelineFileNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06018ADD RID: 101085 RVA: 0x00384C76 File Offset: 0x00382E76
		public byte[] GetShowTimelineFileNameArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06018ADE RID: 101086 RVA: 0x00384C84 File Offset: 0x00382E84
		public static Offset<IPlaybackShowTimelineQuestCondition> CreateIPlaybackShowTimelineQuestCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), StringOffset ShowTimelineFileNameOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IPlaybackShowTimelineQuestCondition.AddShowTimelineFileName(builder, ShowTimelineFileNameOffset);
			IPlaybackShowTimelineQuestCondition.AddPreConditions(builder, PreConditionsOffset);
			IPlaybackShowTimelineQuestCondition.AddType(builder, Type);
			return IPlaybackShowTimelineQuestCondition.EndIPlaybackShowTimelineQuestCondition(builder);
		}

		// Token: 0x06018ADF RID: 101087 RVA: 0x00384CA8 File Offset: 0x00382EA8
		public static void StartIPlaybackShowTimelineQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06018AE0 RID: 101088 RVA: 0x00384CB1 File Offset: 0x00382EB1
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018AE1 RID: 101089 RVA: 0x00384CBC File Offset: 0x00382EBC
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06018AE2 RID: 101090 RVA: 0x00384CCC File Offset: 0x00382ECC
		public static void AddShowTimelineFileName(FlatBufferBuilder builder, StringOffset showTimelineFileNameOffset)
		{
			builder.AddOffset(2, showTimelineFileNameOffset.Value, 0);
		}

		// Token: 0x06018AE3 RID: 101091 RVA: 0x00384CDC File Offset: 0x00382EDC
		public static Offset<IPlaybackShowTimelineQuestCondition> EndIPlaybackShowTimelineQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<IPlaybackShowTimelineQuestCondition>(builder.EndTable());
		}

		// Token: 0x06018AE4 RID: 101092 RVA: 0x00384CEC File Offset: 0x00382EEC
		public IPlaybackShowTimelineQuestConditionT UnPack()
		{
			IPlaybackShowTimelineQuestConditionT playbackShowTimelineQuestConditionT = new IPlaybackShowTimelineQuestConditionT();
			this.UnPackTo(playbackShowTimelineQuestConditionT);
			return playbackShowTimelineQuestConditionT;
		}

		// Token: 0x06018AE5 RID: 101093 RVA: 0x00384D08 File Offset: 0x00382F08
		public void UnPackTo(IPlaybackShowTimelineQuestConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.ShowTimelineFileName = this.ShowTimelineFileName;
		}

		// Token: 0x06018AE6 RID: 101094 RVA: 0x00384D5C File Offset: 0x00382F5C
		public static Offset<IPlaybackShowTimelineQuestCondition> Pack(FlatBufferBuilder builder, IPlaybackShowTimelineQuestConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlaybackShowTimelineQuestCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			StringOffset showTimelineFileNameOffset = (_o.ShowTimelineFileName == null) ? default(StringOffset) : builder.CreateString(_o.ShowTimelineFileName);
			return IPlaybackShowTimelineQuestCondition.CreateIPlaybackShowTimelineQuestCondition(builder, _o.Type, preConditionsOffset, showTimelineFileNameOffset);
		}

		// Token: 0x0400C3E9 RID: 50153
		private Table __p;
	}
}
