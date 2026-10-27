using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CDD RID: 3293
	public struct GachaAccumulate : IFlatbufferObject
	{
		// Token: 0x17001494 RID: 5268
		// (get) Token: 0x060077F2 RID: 30706 RVA: 0x002457C5 File Offset: 0x002439C5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060077F3 RID: 30707 RVA: 0x002457D2 File Offset: 0x002439D2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060077F4 RID: 30708 RVA: 0x002457DC File Offset: 0x002439DC
		public static GachaAccumulate GetRootAsGachaAccumulate(ByteBuffer _bb)
		{
			return GachaAccumulate.GetRootAsGachaAccumulate(_bb, default(GachaAccumulate));
		}

		// Token: 0x060077F5 RID: 30709 RVA: 0x002457F8 File Offset: 0x002439F8
		public static GachaAccumulate GetRootAsGachaAccumulate(ByteBuffer _bb, GachaAccumulate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060077F6 RID: 30710 RVA: 0x00245815 File Offset: 0x00243A15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060077F7 RID: 30711 RVA: 0x00245824 File Offset: 0x00243A24
		public GachaAccumulate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001495 RID: 5269
		// (get) Token: 0x060077F8 RID: 30712 RVA: 0x00245834 File Offset: 0x00243A34
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

		// Token: 0x17001496 RID: 5270
		// (get) Token: 0x060077F9 RID: 30713 RVA: 0x00245870 File Offset: 0x00243A70
		public string TipsPrefabPath
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060077FA RID: 30714 RVA: 0x002458A7 File Offset: 0x00243AA7
		public Span<byte> GetTipsPrefabPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060077FB RID: 30715 RVA: 0x002458B6 File Offset: 0x00243AB6
		public byte[] GetTipsPrefabPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001497 RID: 5271
		// (get) Token: 0x060077FC RID: 30716 RVA: 0x002458D0 File Offset: 0x00243AD0
		public string GachaAccumulatePrefabPath
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060077FD RID: 30717 RVA: 0x00245907 File Offset: 0x00243B07
		public Span<byte> GetGachaAccumulatePrefabPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060077FE RID: 30718 RVA: 0x00245916 File Offset: 0x00243B16
		public byte[] GetGachaAccumulatePrefabPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001498 RID: 5272
		// (get) Token: 0x060077FF RID: 30719 RVA: 0x00245930 File Offset: 0x00243B30
		public int ShowType
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

		// Token: 0x17001499 RID: 5273
		// (get) Token: 0x06007800 RID: 30720 RVA: 0x00245970 File Offset: 0x00243B70
		public int HelpId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004D4E RID: 19790
		private Table __p;
	}
}
