using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001271 RID: 4721
	public struct TowerDefencePhantom : IFlatbufferObject
	{
		// Token: 0x17003E39 RID: 15929
		// (get) Token: 0x0600ED5A RID: 60762 RVA: 0x0035B96C File Offset: 0x00359B6C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600ED5B RID: 60763 RVA: 0x0035B979 File Offset: 0x00359B79
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600ED5C RID: 60764 RVA: 0x0035B980 File Offset: 0x00359B80
		public static TowerDefencePhantom GetRootAsTowerDefencePhantom(ByteBuffer _bb)
		{
			return TowerDefencePhantom.GetRootAsTowerDefencePhantom(_bb, default(TowerDefencePhantom));
		}

		// Token: 0x0600ED5D RID: 60765 RVA: 0x0035B99C File Offset: 0x00359B9C
		public static TowerDefencePhantom GetRootAsTowerDefencePhantom(ByteBuffer _bb, TowerDefencePhantom obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600ED5E RID: 60766 RVA: 0x0035B9B9 File Offset: 0x00359BB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600ED5F RID: 60767 RVA: 0x0035B9C8 File Offset: 0x00359BC8
		public TowerDefencePhantom __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E3A RID: 15930
		// (get) Token: 0x0600ED60 RID: 60768 RVA: 0x0035B9D8 File Offset: 0x00359BD8
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

		// Token: 0x17003E3B RID: 15931
		// (get) Token: 0x0600ED61 RID: 60769 RVA: 0x0035BA14 File Offset: 0x00359C14
		public int PhantomItemId
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

		// Token: 0x17003E3C RID: 15932
		// (get) Token: 0x0600ED62 RID: 60770 RVA: 0x0035BA50 File Offset: 0x00359C50
		public string PhantomName
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

		// Token: 0x0600ED63 RID: 60771 RVA: 0x0035BA87 File Offset: 0x00359C87
		public Span<byte> GetPhantomNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600ED64 RID: 60772 RVA: 0x0035BA96 File Offset: 0x00359C96
		public byte[] GetPhantomNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E3D RID: 15933
		// (get) Token: 0x0600ED65 RID: 60773 RVA: 0x0035BAB0 File Offset: 0x00359CB0
		public string TypeTextId
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

		// Token: 0x0600ED66 RID: 60774 RVA: 0x0035BAE8 File Offset: 0x00359CE8
		public Span<byte> GetTypeTextIdBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600ED67 RID: 60775 RVA: 0x0035BAF8 File Offset: 0x00359CF8
		public byte[] GetTypeTextIdArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E3E RID: 15934
		// (get) Token: 0x0600ED68 RID: 60776 RVA: 0x0035BB10 File Offset: 0x00359D10
		public string TypeIcon
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600ED69 RID: 60777 RVA: 0x0035BB48 File Offset: 0x00359D48
		public Span<byte> GetTypeIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600ED6A RID: 60778 RVA: 0x0035BB58 File Offset: 0x00359D58
		public byte[] GetTypeIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E3F RID: 15935
		// (get) Token: 0x0600ED6B RID: 60779 RVA: 0x0035BB70 File Offset: 0x00359D70
		public string MarkHex
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600ED6C RID: 60780 RVA: 0x0035BBA8 File Offset: 0x00359DA8
		public Span<byte> GetMarkHexBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600ED6D RID: 60781 RVA: 0x0035BBB8 File Offset: 0x00359DB8
		public byte[] GetMarkHexArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E40 RID: 15936
		// (get) Token: 0x0600ED6E RID: 60782 RVA: 0x0035BBD0 File Offset: 0x00359DD0
		public int SkillGroup
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003E41 RID: 15937
		// (get) Token: 0x0600ED6F RID: 60783 RVA: 0x0035BC10 File Offset: 0x00359E10
		public int BuffApplyPlan
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003E42 RID: 15938
		// (get) Token: 0x0600ED70 RID: 60784 RVA: 0x0035BC50 File Offset: 0x00359E50
		public int ActivityId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003E43 RID: 15939
		// (get) Token: 0x0600ED71 RID: 60785 RVA: 0x0035BC90 File Offset: 0x00359E90
		public bool IsSurvivalType
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x040058BF RID: 22719
		private Table __p;
	}
}
