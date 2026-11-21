using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ABC RID: 27324
	public struct ICollectSunSpirit : IFlatbufferObject
	{
		// Token: 0x1700C8AE RID: 51374
		// (get) Token: 0x0602EE6D RID: 192109 RVA: 0x00663BE6 File Offset: 0x00661DE6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EE6E RID: 192110 RVA: 0x00663BF3 File Offset: 0x00661DF3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EE6F RID: 192111 RVA: 0x00663BFC File Offset: 0x00661DFC
		public static ICollectSunSpirit GetRootAsICollectSunSpirit(ByteBuffer _bb)
		{
			return ICollectSunSpirit.GetRootAsICollectSunSpirit(_bb, default(ICollectSunSpirit));
		}

		// Token: 0x0602EE70 RID: 192112 RVA: 0x00663C18 File Offset: 0x00661E18
		public static ICollectSunSpirit GetRootAsICollectSunSpirit(ByteBuffer _bb, ICollectSunSpirit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EE71 RID: 192113 RVA: 0x00663C35 File Offset: 0x00661E35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EE72 RID: 192114 RVA: 0x00663C44 File Offset: 0x00661E44
		public ICollectSunSpirit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602EE73 RID: 192115 RVA: 0x00663C54 File Offset: 0x00661E54
		public static void StartICollectSunSpirit(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602EE74 RID: 192116 RVA: 0x00663C5D File Offset: 0x00661E5D
		public static Offset<ICollectSunSpirit> EndICollectSunSpirit(FlatBufferBuilder builder)
		{
			return new Offset<ICollectSunSpirit>(builder.EndTable());
		}

		// Token: 0x0602EE75 RID: 192117 RVA: 0x00663C6C File Offset: 0x00661E6C
		public ICollectSunSpiritT UnPack()
		{
			ICollectSunSpiritT collectSunSpiritT = new ICollectSunSpiritT();
			this.UnPackTo(collectSunSpiritT);
			return collectSunSpiritT;
		}

		// Token: 0x0602EE76 RID: 192118 RVA: 0x00663C87 File Offset: 0x00661E87
		public void UnPackTo(ICollectSunSpiritT _o)
		{
		}

		// Token: 0x0602EE77 RID: 192119 RVA: 0x00663C8C File Offset: 0x00661E8C
		public static Offset<ICollectSunSpirit> Pack(FlatBufferBuilder builder, ICollectSunSpiritT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICollectSunSpirit>);
			}
			ICollectSunSpirit.StartICollectSunSpirit(builder);
			return ICollectSunSpirit.EndICollectSunSpirit(builder);
		}

		// Token: 0x0401185F RID: 71775
		private Table __p;
	}
}
