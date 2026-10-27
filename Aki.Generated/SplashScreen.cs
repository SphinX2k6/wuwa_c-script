using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010E3 RID: 4323
	public struct SplashScreen : IFlatbufferObject
	{
		// Token: 0x170037E8 RID: 14312
		// (get) Token: 0x0600D825 RID: 55333 RVA: 0x0031E7EC File Offset: 0x0031C9EC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D826 RID: 55334 RVA: 0x0031E7F9 File Offset: 0x0031C9F9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D827 RID: 55335 RVA: 0x0031E800 File Offset: 0x0031CA00
		public static SplashScreen GetRootAsSplashScreen(ByteBuffer _bb)
		{
			return SplashScreen.GetRootAsSplashScreen(_bb, default(SplashScreen));
		}

		// Token: 0x0600D828 RID: 55336 RVA: 0x0031E81C File Offset: 0x0031CA1C
		public static SplashScreen GetRootAsSplashScreen(ByteBuffer _bb, SplashScreen obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D829 RID: 55337 RVA: 0x0031E839 File Offset: 0x0031CA39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D82A RID: 55338 RVA: 0x0031E848 File Offset: 0x0031CA48
		public SplashScreen __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170037E9 RID: 14313
		// (get) Token: 0x0600D82B RID: 55339 RVA: 0x0031E858 File Offset: 0x0031CA58
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170037EA RID: 14314
		// (get) Token: 0x0600D82C RID: 55340 RVA: 0x0031E894 File Offset: 0x0031CA94
		public int Type
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

		// Token: 0x170037EB RID: 14315
		// (get) Token: 0x0600D82D RID: 55341 RVA: 0x0031E8D0 File Offset: 0x0031CAD0
		public bool InLongTaskQueue
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170037EC RID: 14316
		// (get) Token: 0x0600D82E RID: 55342 RVA: 0x0031E910 File Offset: 0x0031CB10
		public int Priority
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005216 RID: 21014
		private Table __p;
	}
}
