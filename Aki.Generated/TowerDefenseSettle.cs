using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001275 RID: 4725
	public struct TowerDefenseSettle : IFlatbufferObject
	{
		// Token: 0x17003E58 RID: 15960
		// (get) Token: 0x0600EDA0 RID: 60832 RVA: 0x0035C339 File Offset: 0x0035A539
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EDA1 RID: 60833 RVA: 0x0035C346 File Offset: 0x0035A546
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EDA2 RID: 60834 RVA: 0x0035C350 File Offset: 0x0035A550
		public static TowerDefenseSettle GetRootAsTowerDefenseSettle(ByteBuffer _bb)
		{
			return TowerDefenseSettle.GetRootAsTowerDefenseSettle(_bb, default(TowerDefenseSettle));
		}

		// Token: 0x0600EDA3 RID: 60835 RVA: 0x0035C36C File Offset: 0x0035A56C
		public static TowerDefenseSettle GetRootAsTowerDefenseSettle(ByteBuffer _bb, TowerDefenseSettle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EDA4 RID: 60836 RVA: 0x0035C389 File Offset: 0x0035A589
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EDA5 RID: 60837 RVA: 0x0035C398 File Offset: 0x0035A598
		public TowerDefenseSettle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E59 RID: 15961
		// (get) Token: 0x0600EDA6 RID: 60838 RVA: 0x0035C3A8 File Offset: 0x0035A5A8
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

		// Token: 0x17003E5A RID: 15962
		// (get) Token: 0x0600EDA7 RID: 60839 RVA: 0x0035C3E4 File Offset: 0x0035A5E4
		public bool IsTotalRatio
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003E5B RID: 15963
		// (get) Token: 0x0600EDA8 RID: 60840 RVA: 0x0035C424 File Offset: 0x0035A624
		public string BaseTitle
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

		// Token: 0x0600EDA9 RID: 60841 RVA: 0x0035C45B File Offset: 0x0035A65B
		public Span<byte> GetBaseTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600EDAA RID: 60842 RVA: 0x0035C46A File Offset: 0x0035A66A
		public byte[] GetBaseTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E5C RID: 15964
		// (get) Token: 0x0600EDAB RID: 60843 RVA: 0x0035C484 File Offset: 0x0035A684
		public string Title
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EDAC RID: 60844 RVA: 0x0035C4BC File Offset: 0x0035A6BC
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600EDAD RID: 60845 RVA: 0x0035C4CC File Offset: 0x0035A6CC
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040058C3 RID: 22723
		private Table __p;
	}
}
