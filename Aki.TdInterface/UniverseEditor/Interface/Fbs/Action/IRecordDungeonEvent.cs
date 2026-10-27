using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E10 RID: 28176
	public struct IRecordDungeonEvent : IFlatbufferObject
	{
		// Token: 0x1700D207 RID: 53767
		// (get) Token: 0x06031C86 RID: 203910 RVA: 0x006BD80E File Offset: 0x006BBA0E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031C87 RID: 203911 RVA: 0x006BD81B File Offset: 0x006BBA1B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031C88 RID: 203912 RVA: 0x006BD824 File Offset: 0x006BBA24
		public static IRecordDungeonEvent GetRootAsIRecordDungeonEvent(ByteBuffer _bb)
		{
			return IRecordDungeonEvent.GetRootAsIRecordDungeonEvent(_bb, default(IRecordDungeonEvent));
		}

		// Token: 0x06031C89 RID: 203913 RVA: 0x006BD840 File Offset: 0x006BBA40
		public static IRecordDungeonEvent GetRootAsIRecordDungeonEvent(ByteBuffer _bb, IRecordDungeonEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031C8A RID: 203914 RVA: 0x006BD85D File Offset: 0x006BBA5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031C8B RID: 203915 RVA: 0x006BD86C File Offset: 0x006BBA6C
		public IRecordDungeonEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D208 RID: 53768
		// (get) Token: 0x06031C8C RID: 203916 RVA: 0x006BD87C File Offset: 0x006BBA7C
		public IRecordTimeStampType? EventConfig
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IRecordTimeStampType?(default(IRecordTimeStampType).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06031C8D RID: 203917 RVA: 0x006BD8D9 File Offset: 0x006BBAD9
		public static Offset<IRecordDungeonEvent> CreateIRecordDungeonEvent(FlatBufferBuilder builder, Offset<IRecordTimeStampType> EventConfigOffset = default(Offset<IRecordTimeStampType>))
		{
			builder.StartTable(1);
			IRecordDungeonEvent.AddEventConfig(builder, EventConfigOffset);
			return IRecordDungeonEvent.EndIRecordDungeonEvent(builder);
		}

		// Token: 0x06031C8E RID: 203918 RVA: 0x006BD8EF File Offset: 0x006BBAEF
		public static void StartIRecordDungeonEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031C8F RID: 203919 RVA: 0x006BD8F8 File Offset: 0x006BBAF8
		public static void AddEventConfig(FlatBufferBuilder builder, Offset<IRecordTimeStampType> eventConfigOffset)
		{
			builder.AddOffset(0, eventConfigOffset.Value, 0);
		}

		// Token: 0x06031C90 RID: 203920 RVA: 0x006BD908 File Offset: 0x006BBB08
		public static Offset<IRecordDungeonEvent> EndIRecordDungeonEvent(FlatBufferBuilder builder)
		{
			return new Offset<IRecordDungeonEvent>(builder.EndTable());
		}

		// Token: 0x06031C91 RID: 203921 RVA: 0x006BD918 File Offset: 0x006BBB18
		public IRecordDungeonEventT UnPack()
		{
			IRecordDungeonEventT recordDungeonEventT = new IRecordDungeonEventT();
			this.UnPackTo(recordDungeonEventT);
			return recordDungeonEventT;
		}

		// Token: 0x06031C92 RID: 203922 RVA: 0x006BD934 File Offset: 0x006BBB34
		public void UnPackTo(IRecordDungeonEventT _o)
		{
			_o.EventConfig = ((this.EventConfig != null) ? this.EventConfig.Value.UnPack() : null);
		}

		// Token: 0x06031C93 RID: 203923 RVA: 0x006BD970 File Offset: 0x006BBB70
		public static Offset<IRecordDungeonEvent> Pack(FlatBufferBuilder builder, IRecordDungeonEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRecordDungeonEvent>);
			}
			Offset<IRecordTimeStampType> eventConfigOffset = (_o.EventConfig == null) ? default(Offset<IRecordTimeStampType>) : IRecordTimeStampType.Pack(builder, _o.EventConfig);
			return IRecordDungeonEvent.CreateIRecordDungeonEvent(builder, eventConfigOffset);
		}

		// Token: 0x040117F9 RID: 71673
		private Table __p;
	}
}
