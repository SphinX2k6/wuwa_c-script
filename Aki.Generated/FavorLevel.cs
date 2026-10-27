using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C60 RID: 3168
	public struct FavorLevel : IFlatbufferObject
	{
		// Token: 0x17001066 RID: 4198
		// (get) Token: 0x06006CE0 RID: 27872 RVA: 0x0022B8DC File Offset: 0x00229ADC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006CE1 RID: 27873 RVA: 0x0022B8E9 File Offset: 0x00229AE9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006CE2 RID: 27874 RVA: 0x0022B8F0 File Offset: 0x00229AF0
		public static FavorLevel GetRootAsFavorLevel(ByteBuffer _bb)
		{
			return FavorLevel.GetRootAsFavorLevel(_bb, default(FavorLevel));
		}

		// Token: 0x06006CE3 RID: 27875 RVA: 0x0022B90C File Offset: 0x00229B0C
		public static FavorLevel GetRootAsFavorLevel(ByteBuffer _bb, FavorLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006CE4 RID: 27876 RVA: 0x0022B929 File Offset: 0x00229B29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006CE5 RID: 27877 RVA: 0x0022B938 File Offset: 0x00229B38
		public FavorLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001067 RID: 4199
		// (get) Token: 0x06006CE6 RID: 27878 RVA: 0x0022B948 File Offset: 0x00229B48
		public int Level
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

		// Token: 0x17001068 RID: 4200
		// (get) Token: 0x06006CE7 RID: 27879 RVA: 0x0022B984 File Offset: 0x00229B84
		public int LevelUpExp
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

		// Token: 0x04004CAB RID: 19627
		private Table __p;
	}
}
