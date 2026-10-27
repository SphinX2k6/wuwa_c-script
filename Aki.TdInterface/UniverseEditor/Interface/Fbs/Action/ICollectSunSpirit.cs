using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006454 RID: 25684
	public struct ICollectSunSpirit : IFlatbufferObject
	{
		// Token: 0x1700BF2C RID: 48940
		// (get) Token: 0x0602C728 RID: 182056 RVA: 0x00618B1A File Offset: 0x00616D1A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C729 RID: 182057 RVA: 0x00618B27 File Offset: 0x00616D27
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C72A RID: 182058 RVA: 0x00618B30 File Offset: 0x00616D30
		public static ICollectSunSpirit GetRootAsICollectSunSpirit(ByteBuffer _bb)
		{
			return ICollectSunSpirit.GetRootAsICollectSunSpirit(_bb, default(ICollectSunSpirit));
		}

		// Token: 0x0602C72B RID: 182059 RVA: 0x00618B4C File Offset: 0x00616D4C
		public static ICollectSunSpirit GetRootAsICollectSunSpirit(ByteBuffer _bb, ICollectSunSpirit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C72C RID: 182060 RVA: 0x00618B69 File Offset: 0x00616D69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C72D RID: 182061 RVA: 0x00618B78 File Offset: 0x00616D78
		public ICollectSunSpirit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602C72E RID: 182062 RVA: 0x00618B88 File Offset: 0x00616D88
		public static void StartICollectSunSpirit(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602C72F RID: 182063 RVA: 0x00618B91 File Offset: 0x00616D91
		public static Offset<ICollectSunSpirit> EndICollectSunSpirit(FlatBufferBuilder builder)
		{
			return new Offset<ICollectSunSpirit>(builder.EndTable());
		}

		// Token: 0x0602C730 RID: 182064 RVA: 0x00618BA0 File Offset: 0x00616DA0
		public ICollectSunSpiritT UnPack()
		{
			ICollectSunSpiritT collectSunSpiritT = new ICollectSunSpiritT();
			this.UnPackTo(collectSunSpiritT);
			return collectSunSpiritT;
		}

		// Token: 0x0602C731 RID: 182065 RVA: 0x00618BBB File Offset: 0x00616DBB
		public void UnPackTo(ICollectSunSpiritT _o)
		{
		}

		// Token: 0x0602C732 RID: 182066 RVA: 0x00618BC0 File Offset: 0x00616DC0
		public static Offset<ICollectSunSpirit> Pack(FlatBufferBuilder builder, ICollectSunSpiritT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICollectSunSpirit>);
			}
			ICollectSunSpirit.StartICollectSunSpirit(builder);
			return ICollectSunSpirit.EndICollectSunSpirit(builder);
		}

		// Token: 0x04010A54 RID: 68180
		private Table __p;
	}
}
