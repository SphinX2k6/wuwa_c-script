using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041F3 RID: 16883
	public struct IDarkTideMechaAssemblyBossEvent : IFlatbufferObject
	{
		// Token: 0x170072FB RID: 29435
		// (get) Token: 0x060176E2 RID: 95970 RVA: 0x00359091 File Offset: 0x00357291
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060176E3 RID: 95971 RVA: 0x0035909E File Offset: 0x0035729E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060176E4 RID: 95972 RVA: 0x003590A8 File Offset: 0x003572A8
		public static IDarkTideMechaAssemblyBossEvent GetRootAsIDarkTideMechaAssemblyBossEvent(ByteBuffer _bb)
		{
			return IDarkTideMechaAssemblyBossEvent.GetRootAsIDarkTideMechaAssemblyBossEvent(_bb, default(IDarkTideMechaAssemblyBossEvent));
		}

		// Token: 0x060176E5 RID: 95973 RVA: 0x003590C4 File Offset: 0x003572C4
		public static IDarkTideMechaAssemblyBossEvent GetRootAsIDarkTideMechaAssemblyBossEvent(ByteBuffer _bb, IDarkTideMechaAssemblyBossEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060176E6 RID: 95974 RVA: 0x003590E1 File Offset: 0x003572E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060176E7 RID: 95975 RVA: 0x003590F0 File Offset: 0x003572F0
		public IDarkTideMechaAssemblyBossEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170072FC RID: 29436
		// (get) Token: 0x060176E8 RID: 95976 RVA: 0x00359100 File Offset: 0x00357300
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

		// Token: 0x060176E9 RID: 95977 RVA: 0x0035913C File Offset: 0x0035733C
		public static Offset<IDarkTideMechaAssemblyBossEvent> CreateIDarkTideMechaAssemblyBossEvent(FlatBufferBuilder builder, EDarkTideBossEventType Type = EDarkTideBossEventType.XinjilemuChase)
		{
			builder.StartTable(1);
			IDarkTideMechaAssemblyBossEvent.AddType(builder, Type);
			return IDarkTideMechaAssemblyBossEvent.EndIDarkTideMechaAssemblyBossEvent(builder);
		}

		// Token: 0x060176EA RID: 95978 RVA: 0x00359152 File Offset: 0x00357352
		public static void StartIDarkTideMechaAssemblyBossEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060176EB RID: 95979 RVA: 0x0035915B File Offset: 0x0035735B
		public static void AddType(FlatBufferBuilder builder, EDarkTideBossEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060176EC RID: 95980 RVA: 0x00359166 File Offset: 0x00357366
		public static Offset<IDarkTideMechaAssemblyBossEvent> EndIDarkTideMechaAssemblyBossEvent(FlatBufferBuilder builder)
		{
			return new Offset<IDarkTideMechaAssemblyBossEvent>(builder.EndTable());
		}

		// Token: 0x060176ED RID: 95981 RVA: 0x00359174 File Offset: 0x00357374
		public IDarkTideMechaAssemblyBossEventT UnPack()
		{
			IDarkTideMechaAssemblyBossEventT darkTideMechaAssemblyBossEventT = new IDarkTideMechaAssemblyBossEventT();
			this.UnPackTo(darkTideMechaAssemblyBossEventT);
			return darkTideMechaAssemblyBossEventT;
		}

		// Token: 0x060176EE RID: 95982 RVA: 0x0035918F File Offset: 0x0035738F
		public void UnPackTo(IDarkTideMechaAssemblyBossEventT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060176EF RID: 95983 RVA: 0x003591A0 File Offset: 0x003573A0
		public static Offset<IDarkTideMechaAssemblyBossEvent> Pack(FlatBufferBuilder builder, IDarkTideMechaAssemblyBossEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDarkTideMechaAssemblyBossEvent>);
			}
			return IDarkTideMechaAssemblyBossEvent.CreateIDarkTideMechaAssemblyBossEvent(builder, _o.Type);
		}

		// Token: 0x0400C0CD RID: 49357
		private Table __p;
	}
}
