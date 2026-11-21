using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F72 RID: 3954
	public struct NewTowerMedal : IFlatbufferObject
	{
		// Token: 0x170023B5 RID: 9141
		// (get) Token: 0x0600A56C RID: 42348 RVA: 0x002BB704 File Offset: 0x002B9904
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A56D RID: 42349 RVA: 0x002BB711 File Offset: 0x002B9911
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A56E RID: 42350 RVA: 0x002BB718 File Offset: 0x002B9918
		public static NewTowerMedal GetRootAsNewTowerMedal(ByteBuffer _bb)
		{
			return NewTowerMedal.GetRootAsNewTowerMedal(_bb, default(NewTowerMedal));
		}

		// Token: 0x0600A56F RID: 42351 RVA: 0x002BB734 File Offset: 0x002B9934
		public static NewTowerMedal GetRootAsNewTowerMedal(ByteBuffer _bb, NewTowerMedal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A570 RID: 42352 RVA: 0x002BB751 File Offset: 0x002B9951
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A571 RID: 42353 RVA: 0x002BB760 File Offset: 0x002B9960
		public NewTowerMedal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170023B6 RID: 9142
		// (get) Token: 0x0600A572 RID: 42354 RVA: 0x002BB770 File Offset: 0x002B9970
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

		// Token: 0x170023B7 RID: 9143
		// (get) Token: 0x0600A573 RID: 42355 RVA: 0x002BB7AC File Offset: 0x002B99AC
		public int SeasonId
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

		// Token: 0x170023B8 RID: 9144
		// (get) Token: 0x0600A574 RID: 42356 RVA: 0x002BB7E8 File Offset: 0x002B99E8
		public int GroupId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170023B9 RID: 9145
		// (get) Token: 0x0600A575 RID: 42357 RVA: 0x002BB824 File Offset: 0x002B9A24
		public string Name
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

		// Token: 0x0600A576 RID: 42358 RVA: 0x002BB85C File Offset: 0x002B9A5C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A577 RID: 42359 RVA: 0x002BB86C File Offset: 0x002B9A6C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170023BA RID: 9146
		// (get) Token: 0x0600A578 RID: 42360 RVA: 0x002BB884 File Offset: 0x002B9A84
		public int CycleId
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

		// Token: 0x170023BB RID: 9147
		// (get) Token: 0x0600A579 RID: 42361 RVA: 0x002BB8C4 File Offset: 0x002B9AC4
		public int Target
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170023BC RID: 9148
		// (get) Token: 0x0600A57A RID: 42362 RVA: 0x002BB904 File Offset: 0x002B9B04
		public string Background
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A57B RID: 42363 RVA: 0x002BB93C File Offset: 0x002B9B3C
		public Span<byte> GetBackgroundBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A57C RID: 42364 RVA: 0x002BB94C File Offset: 0x002B9B4C
		public byte[] GetBackgroundArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170023BD RID: 9149
		// (get) Token: 0x0600A57D RID: 42365 RVA: 0x002BB964 File Offset: 0x002B9B64
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A57E RID: 42366 RVA: 0x002BB99C File Offset: 0x002B9B9C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600A57F RID: 42367 RVA: 0x002BB9AC File Offset: 0x002B9BAC
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170023BE RID: 9150
		// (get) Token: 0x0600A580 RID: 42368 RVA: 0x002BB9C4 File Offset: 0x002B9BC4
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A581 RID: 42369 RVA: 0x002BB9FC File Offset: 0x002B9BFC
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600A582 RID: 42370 RVA: 0x002BBA0C File Offset: 0x002B9C0C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x04005521 RID: 21793
		private Table __p;
	}
}
