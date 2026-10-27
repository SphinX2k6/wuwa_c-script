using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011D0 RID: 4560
	public struct IntVector2D : IFlatbufferObject
	{
		// Token: 0x17003EF7 RID: 16119
		// (get) Token: 0x0600EAB2 RID: 60082 RVA: 0x003488E0 File Offset: 0x00346AE0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EAB3 RID: 60083 RVA: 0x003488ED File Offset: 0x00346AED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EAB4 RID: 60084 RVA: 0x003488F4 File Offset: 0x00346AF4
		public static IntVector2D GetRootAsIntVector2D(ByteBuffer _bb)
		{
			return IntVector2D.GetRootAsIntVector2D(_bb, default(IntVector2D));
		}

		// Token: 0x0600EAB5 RID: 60085 RVA: 0x00348910 File Offset: 0x00346B10
		public static IntVector2D GetRootAsIntVector2D(ByteBuffer _bb, IntVector2D obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EAB6 RID: 60086 RVA: 0x0034892D File Offset: 0x00346B2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EAB7 RID: 60087 RVA: 0x0034893C File Offset: 0x00346B3C
		public IntVector2D __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003EF8 RID: 16120
		// (get) Token: 0x0600EAB8 RID: 60088 RVA: 0x0034894C File Offset: 0x00346B4C
		public int X
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

		// Token: 0x17003EF9 RID: 16121
		// (get) Token: 0x0600EAB9 RID: 60089 RVA: 0x00348988 File Offset: 0x00346B88
		public int Y
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

		// Token: 0x0400533E RID: 21310
		private Table __p;
	}
}
