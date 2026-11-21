using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DC0 RID: 3520
	public struct Gacha : IFlatbufferObject
	{
		// Token: 0x170014ED RID: 5357
		// (get) Token: 0x06007DF4 RID: 32244 RVA: 0x00264220 File Offset: 0x00262420
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007DF5 RID: 32245 RVA: 0x0026422D File Offset: 0x0026242D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007DF6 RID: 32246 RVA: 0x00264234 File Offset: 0x00262434
		public static Gacha GetRootAsGacha(ByteBuffer _bb)
		{
			return Gacha.GetRootAsGacha(_bb, default(Gacha));
		}

		// Token: 0x06007DF7 RID: 32247 RVA: 0x00264250 File Offset: 0x00262450
		public static Gacha GetRootAsGacha(ByteBuffer _bb, Gacha obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007DF8 RID: 32248 RVA: 0x0026426D File Offset: 0x0026246D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007DF9 RID: 32249 RVA: 0x0026427C File Offset: 0x0026247C
		public Gacha __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170014EE RID: 5358
		// (get) Token: 0x06007DFA RID: 32250 RVA: 0x0026428C File Offset: 0x0026248C
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

		// Token: 0x170014EF RID: 5359
		// (get) Token: 0x06007DFB RID: 32251 RVA: 0x002642C8 File Offset: 0x002624C8
		public int RuleGroupId
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

		// Token: 0x170014F0 RID: 5360
		// (get) Token: 0x06007DFC RID: 32252 RVA: 0x00264304 File Offset: 0x00262504
		public int Sort
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 10;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005331 RID: 21297
		private Table __p;
	}
}
