using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200758B RID: 30091
	public struct IRecordDungeonEvent : IFlatbufferObject
	{
		// Token: 0x1700DD4F RID: 56655
		// (get) Token: 0x06034C82 RID: 216194 RVA: 0x00718EF6 File Offset: 0x007170F6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034C83 RID: 216195 RVA: 0x00718F03 File Offset: 0x00717103
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034C84 RID: 216196 RVA: 0x00718F0C File Offset: 0x0071710C
		public static IRecordDungeonEvent GetRootAsIRecordDungeonEvent(ByteBuffer _bb)
		{
			return IRecordDungeonEvent.GetRootAsIRecordDungeonEvent(_bb, default(IRecordDungeonEvent));
		}

		// Token: 0x06034C85 RID: 216197 RVA: 0x00718F28 File Offset: 0x00717128
		public static IRecordDungeonEvent GetRootAsIRecordDungeonEvent(ByteBuffer _bb, IRecordDungeonEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034C86 RID: 216198 RVA: 0x00718F45 File Offset: 0x00717145
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034C87 RID: 216199 RVA: 0x00718F54 File Offset: 0x00717154
		public IRecordDungeonEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DD50 RID: 56656
		// (get) Token: 0x06034C88 RID: 216200 RVA: 0x00718F64 File Offset: 0x00717164
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

		// Token: 0x06034C89 RID: 216201 RVA: 0x00718FC1 File Offset: 0x007171C1
		public static Offset<IRecordDungeonEvent> CreateIRecordDungeonEvent(FlatBufferBuilder builder, Offset<IRecordTimeStampType> EventConfigOffset = default(Offset<IRecordTimeStampType>))
		{
			builder.StartTable(1);
			IRecordDungeonEvent.AddEventConfig(builder, EventConfigOffset);
			return IRecordDungeonEvent.EndIRecordDungeonEvent(builder);
		}

		// Token: 0x06034C8A RID: 216202 RVA: 0x00718FD7 File Offset: 0x007171D7
		public static void StartIRecordDungeonEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06034C8B RID: 216203 RVA: 0x00718FE0 File Offset: 0x007171E0
		public static void AddEventConfig(FlatBufferBuilder builder, Offset<IRecordTimeStampType> eventConfigOffset)
		{
			builder.AddOffset(0, eventConfigOffset.Value, 0);
		}

		// Token: 0x06034C8C RID: 216204 RVA: 0x00718FF0 File Offset: 0x007171F0
		public static Offset<IRecordDungeonEvent> EndIRecordDungeonEvent(FlatBufferBuilder builder)
		{
			return new Offset<IRecordDungeonEvent>(builder.EndTable());
		}

		// Token: 0x06034C8D RID: 216205 RVA: 0x00719000 File Offset: 0x00717200
		public IRecordDungeonEventT UnPack()
		{
			IRecordDungeonEventT recordDungeonEventT = new IRecordDungeonEventT();
			this.UnPackTo(recordDungeonEventT);
			return recordDungeonEventT;
		}

		// Token: 0x06034C8E RID: 216206 RVA: 0x0071901C File Offset: 0x0071721C
		public void UnPackTo(IRecordDungeonEventT _o)
		{
			_o.EventConfig = ((this.EventConfig != null) ? this.EventConfig.Value.UnPack() : null);
		}

		// Token: 0x06034C8F RID: 216207 RVA: 0x00719058 File Offset: 0x00717258
		public static Offset<IRecordDungeonEvent> Pack(FlatBufferBuilder builder, IRecordDungeonEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRecordDungeonEvent>);
			}
			Offset<IRecordTimeStampType> eventConfigOffset = (_o.EventConfig == null) ? default(Offset<IRecordTimeStampType>) : IRecordTimeStampType.Pack(builder, _o.EventConfig);
			return IRecordDungeonEvent.CreateIRecordDungeonEvent(builder, eventConfigOffset);
		}

		// Token: 0x04012775 RID: 75637
		private Table __p;
	}
}
