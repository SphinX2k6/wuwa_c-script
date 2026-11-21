using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041F6 RID: 16886
	public struct IDarkTideModule : IFlatbufferObject
	{
		// Token: 0x170072FE RID: 29438
		// (get) Token: 0x060176F4 RID: 95988 RVA: 0x00359209 File Offset: 0x00357409
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060176F5 RID: 95989 RVA: 0x00359216 File Offset: 0x00357416
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060176F6 RID: 95990 RVA: 0x00359220 File Offset: 0x00357420
		public static IDarkTideModule GetRootAsIDarkTideModule(ByteBuffer _bb)
		{
			return IDarkTideModule.GetRootAsIDarkTideModule(_bb, default(IDarkTideModule));
		}

		// Token: 0x060176F7 RID: 95991 RVA: 0x0035923C File Offset: 0x0035743C
		public static IDarkTideModule GetRootAsIDarkTideModule(ByteBuffer _bb, IDarkTideModule obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060176F8 RID: 95992 RVA: 0x00359259 File Offset: 0x00357459
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060176F9 RID: 95993 RVA: 0x00359268 File Offset: 0x00357468
		public IDarkTideModule __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170072FF RID: 29439
		// (get) Token: 0x060176FA RID: 95994 RVA: 0x00359278 File Offset: 0x00357478
		public EDarkTideModuleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDarkTideModuleType.BossEvent;
				}
				return (EDarkTideModuleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060176FB RID: 95995 RVA: 0x003592B4 File Offset: 0x003574B4
		public static Offset<IDarkTideModule> CreateIDarkTideModule(FlatBufferBuilder builder, EDarkTideModuleType Type = EDarkTideModuleType.BossEvent)
		{
			builder.StartTable(1);
			IDarkTideModule.AddType(builder, Type);
			return IDarkTideModule.EndIDarkTideModule(builder);
		}

		// Token: 0x060176FC RID: 95996 RVA: 0x003592CA File Offset: 0x003574CA
		public static void StartIDarkTideModule(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060176FD RID: 95997 RVA: 0x003592D3 File Offset: 0x003574D3
		public static void AddType(FlatBufferBuilder builder, EDarkTideModuleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060176FE RID: 95998 RVA: 0x003592DE File Offset: 0x003574DE
		public static Offset<IDarkTideModule> EndIDarkTideModule(FlatBufferBuilder builder)
		{
			return new Offset<IDarkTideModule>(builder.EndTable());
		}

		// Token: 0x060176FF RID: 95999 RVA: 0x003592EC File Offset: 0x003574EC
		public IDarkTideModuleT UnPack()
		{
			IDarkTideModuleT darkTideModuleT = new IDarkTideModuleT();
			this.UnPackTo(darkTideModuleT);
			return darkTideModuleT;
		}

		// Token: 0x06017700 RID: 96000 RVA: 0x00359307 File Offset: 0x00357507
		public void UnPackTo(IDarkTideModuleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06017701 RID: 96001 RVA: 0x00359318 File Offset: 0x00357518
		public static Offset<IDarkTideModule> Pack(FlatBufferBuilder builder, IDarkTideModuleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDarkTideModule>);
			}
			return IDarkTideModule.CreateIDarkTideModule(builder, _o.Type);
		}

		// Token: 0x0400C0CF RID: 49359
		private Table __p;
	}
}
