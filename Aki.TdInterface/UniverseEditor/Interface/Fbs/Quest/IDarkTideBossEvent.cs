using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041E1 RID: 16865
	public struct IDarkTideBossEvent : IFlatbufferObject
	{
		// Token: 0x170072E8 RID: 29416
		// (get) Token: 0x06017666 RID: 95846 RVA: 0x0035837D File Offset: 0x0035657D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017667 RID: 95847 RVA: 0x0035838A File Offset: 0x0035658A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017668 RID: 95848 RVA: 0x00358394 File Offset: 0x00356594
		public static IDarkTideBossEvent GetRootAsIDarkTideBossEvent(ByteBuffer _bb)
		{
			return IDarkTideBossEvent.GetRootAsIDarkTideBossEvent(_bb, default(IDarkTideBossEvent));
		}

		// Token: 0x06017669 RID: 95849 RVA: 0x003583B0 File Offset: 0x003565B0
		public static IDarkTideBossEvent GetRootAsIDarkTideBossEvent(ByteBuffer _bb, IDarkTideBossEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601766A RID: 95850 RVA: 0x003583CD File Offset: 0x003565CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601766B RID: 95851 RVA: 0x003583DC File Offset: 0x003565DC
		public IDarkTideBossEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170072E9 RID: 29417
		// (get) Token: 0x0601766C RID: 95852 RVA: 0x003583EC File Offset: 0x003565EC
		public EDarkTideBossEventType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDarkTideBossEventType.XinjilemuChase;
				}
				return (EDarkTideBossEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601766D RID: 95853 RVA: 0x00358428 File Offset: 0x00356628
		public static Offset<IDarkTideBossEvent> CreateIDarkTideBossEvent(FlatBufferBuilder builder, EDarkTideBossEventType Type = EDarkTideBossEventType.XinjilemuChase)
		{
			builder.StartTable(1);
			IDarkTideBossEvent.AddType(builder, Type);
			return IDarkTideBossEvent.EndIDarkTideBossEvent(builder);
		}

		// Token: 0x0601766E RID: 95854 RVA: 0x0035843E File Offset: 0x0035663E
		public static void StartIDarkTideBossEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601766F RID: 95855 RVA: 0x00358447 File Offset: 0x00356647
		public static void AddType(FlatBufferBuilder builder, EDarkTideBossEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017670 RID: 95856 RVA: 0x00358452 File Offset: 0x00356652
		public static Offset<IDarkTideBossEvent> EndIDarkTideBossEvent(FlatBufferBuilder builder)
		{
			return new Offset<IDarkTideBossEvent>(builder.EndTable());
		}

		// Token: 0x06017671 RID: 95857 RVA: 0x00358460 File Offset: 0x00356660
		public IDarkTideBossEventT UnPack()
		{
			IDarkTideBossEventT darkTideBossEventT = new IDarkTideBossEventT();
			this.UnPackTo(darkTideBossEventT);
			return darkTideBossEventT;
		}

		// Token: 0x06017672 RID: 95858 RVA: 0x0035847B File Offset: 0x0035667B
		public void UnPackTo(IDarkTideBossEventT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06017673 RID: 95859 RVA: 0x0035848C File Offset: 0x0035668C
		public static Offset<IDarkTideBossEvent> Pack(FlatBufferBuilder builder, IDarkTideBossEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDarkTideBossEvent>);
			}
			return IDarkTideBossEvent.CreateIDarkTideBossEvent(builder, _o.Type);
		}

		// Token: 0x0400C0B7 RID: 49335
		private Table __p;
	}
}
