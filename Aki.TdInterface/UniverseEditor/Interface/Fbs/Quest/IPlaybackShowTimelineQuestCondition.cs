using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F9E RID: 16286
	public struct IPlaybackShowTimelineQuestCondition : IFlatbufferObject
	{
		// Token: 0x170071B3 RID: 29107
		// (get) Token: 0x06017444 RID: 95300 RVA: 0x0035AF0F File Offset: 0x0035910F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017445 RID: 95301 RVA: 0x0035AF1C File Offset: 0x0035911C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017446 RID: 95302 RVA: 0x0035AF24 File Offset: 0x00359124
		public static IPlaybackShowTimelineQuestCondition GetRootAsIPlaybackShowTimelineQuestCondition(ByteBuffer _bb)
		{
			return IPlaybackShowTimelineQuestCondition.GetRootAsIPlaybackShowTimelineQuestCondition(_bb, default(IPlaybackShowTimelineQuestCondition));
		}

		// Token: 0x06017447 RID: 95303 RVA: 0x0035AF40 File Offset: 0x00359140
		public static IPlaybackShowTimelineQuestCondition GetRootAsIPlaybackShowTimelineQuestCondition(ByteBuffer _bb, IPlaybackShowTimelineQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017448 RID: 95304 RVA: 0x0035AF5D File Offset: 0x0035915D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017449 RID: 95305 RVA: 0x0035AF6C File Offset: 0x0035916C
		public IPlaybackShowTimelineQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170071B4 RID: 29108
		// (get) Token: 0x0601744A RID: 95306 RVA: 0x0035AF7C File Offset: 0x0035917C
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

		// Token: 0x170071B5 RID: 29109
		// (get) Token: 0x0601744B RID: 95307 RVA: 0x0035AFB8 File Offset: 0x003591B8
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

		// Token: 0x170071B6 RID: 29110
		// (get) Token: 0x0601744C RID: 95308 RVA: 0x0035B018 File Offset: 0x00359218
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

		// Token: 0x0601744D RID: 95309 RVA: 0x0035B04F File Offset: 0x0035924F
		public Span<byte> GetShowTimelineFileNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601744E RID: 95310 RVA: 0x0035B05E File Offset: 0x0035925E
		public byte[] GetShowTimelineFileNameArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0601744F RID: 95311 RVA: 0x0035B06C File Offset: 0x0035926C
		public static Offset<IPlaybackShowTimelineQuestCondition> CreateIPlaybackShowTimelineQuestCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), StringOffset ShowTimelineFileNameOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IPlaybackShowTimelineQuestCondition.AddShowTimelineFileName(builder, ShowTimelineFileNameOffset);
			IPlaybackShowTimelineQuestCondition.AddPreConditions(builder, PreConditionsOffset);
			IPlaybackShowTimelineQuestCondition.AddType(builder, Type);
			return IPlaybackShowTimelineQuestCondition.EndIPlaybackShowTimelineQuestCondition(builder);
		}

		// Token: 0x06017450 RID: 95312 RVA: 0x0035B090 File Offset: 0x00359290
		public static void StartIPlaybackShowTimelineQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06017451 RID: 95313 RVA: 0x0035B099 File Offset: 0x00359299
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017452 RID: 95314 RVA: 0x0035B0A4 File Offset: 0x003592A4
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06017453 RID: 95315 RVA: 0x0035B0B4 File Offset: 0x003592B4
		public static void AddShowTimelineFileName(FlatBufferBuilder builder, StringOffset showTimelineFileNameOffset)
		{
			builder.AddOffset(2, showTimelineFileNameOffset.Value, 0);
		}

		// Token: 0x06017454 RID: 95316 RVA: 0x0035B0C4 File Offset: 0x003592C4
		public static Offset<IPlaybackShowTimelineQuestCondition> EndIPlaybackShowTimelineQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<IPlaybackShowTimelineQuestCondition>(builder.EndTable());
		}

		// Token: 0x06017455 RID: 95317 RVA: 0x0035B0D4 File Offset: 0x003592D4
		public IPlaybackShowTimelineQuestConditionT UnPack()
		{
			IPlaybackShowTimelineQuestConditionT playbackShowTimelineQuestConditionT = new IPlaybackShowTimelineQuestConditionT();
			this.UnPackTo(playbackShowTimelineQuestConditionT);
			return playbackShowTimelineQuestConditionT;
		}

		// Token: 0x06017456 RID: 95318 RVA: 0x0035B0F0 File Offset: 0x003592F0
		public void UnPackTo(IPlaybackShowTimelineQuestConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.ShowTimelineFileName = this.ShowTimelineFileName;
		}

		// Token: 0x06017457 RID: 95319 RVA: 0x0035B144 File Offset: 0x00359344
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

		// Token: 0x0400BA04 RID: 47620
		private Table __p;
	}
}
