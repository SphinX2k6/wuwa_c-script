using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001182 RID: 4482
	public struct UiDynamicTab : IFlatbufferObject
	{
		// Token: 0x17003D26 RID: 15654
		// (get) Token: 0x0600E610 RID: 58896 RVA: 0x0033E4CE File Offset: 0x0033C6CE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E611 RID: 58897 RVA: 0x0033E4DB File Offset: 0x0033C6DB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E612 RID: 58898 RVA: 0x0033E4E4 File Offset: 0x0033C6E4
		public static UiDynamicTab GetRootAsUiDynamicTab(ByteBuffer _bb)
		{
			return UiDynamicTab.GetRootAsUiDynamicTab(_bb, default(UiDynamicTab));
		}

		// Token: 0x0600E613 RID: 58899 RVA: 0x0033E500 File Offset: 0x0033C700
		public static UiDynamicTab GetRootAsUiDynamicTab(ByteBuffer _bb, UiDynamicTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E614 RID: 58900 RVA: 0x0033E51D File Offset: 0x0033C71D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E615 RID: 58901 RVA: 0x0033E52C File Offset: 0x0033C72C
		public UiDynamicTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003D27 RID: 15655
		// (get) Token: 0x0600E616 RID: 58902 RVA: 0x0033E53C File Offset: 0x0033C73C
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

		// Token: 0x17003D28 RID: 15656
		// (get) Token: 0x0600E617 RID: 58903 RVA: 0x0033E578 File Offset: 0x0033C778
		public string ParentViewName
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

		// Token: 0x0600E618 RID: 58904 RVA: 0x0033E5AF File Offset: 0x0033C7AF
		public Span<byte> GetParentViewNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E619 RID: 58905 RVA: 0x0033E5BE File Offset: 0x0033C7BE
		public byte[] GetParentViewNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D29 RID: 15657
		// (get) Token: 0x0600E61A RID: 58906 RVA: 0x0033E5D8 File Offset: 0x0033C7D8
		public string ChildViewName
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

		// Token: 0x0600E61B RID: 58907 RVA: 0x0033E60F File Offset: 0x0033C80F
		public Span<byte> GetChildViewNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E61C RID: 58908 RVA: 0x0033E61E File Offset: 0x0033C81E
		public byte[] GetChildViewNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D2A RID: 15658
		// (get) Token: 0x0600E61D RID: 58909 RVA: 0x0033E638 File Offset: 0x0033C838
		public string TabName
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

		// Token: 0x0600E61E RID: 58910 RVA: 0x0033E670 File Offset: 0x0033C870
		public Span<byte> GetTabNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E61F RID: 58911 RVA: 0x0033E680 File Offset: 0x0033C880
		public byte[] GetTabNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D2B RID: 15659
		// (get) Token: 0x0600E620 RID: 58912 RVA: 0x0033E698 File Offset: 0x0033C898
		public int TabIndex
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

		// Token: 0x17003D2C RID: 15660
		// (get) Token: 0x0600E621 RID: 58913 RVA: 0x0033E6D8 File Offset: 0x0033C8D8
		public int FunctionId
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

		// Token: 0x17003D2D RID: 15661
		// (get) Token: 0x0600E622 RID: 58914 RVA: 0x0033E718 File Offset: 0x0033C918
		public string UiCameraSettingsName
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

		// Token: 0x0600E623 RID: 58915 RVA: 0x0033E750 File Offset: 0x0033C950
		public Span<byte> GetUiCameraSettingsNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600E624 RID: 58916 RVA: 0x0033E760 File Offset: 0x0033C960
		public byte[] GetUiCameraSettingsNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D2E RID: 15662
		// (get) Token: 0x0600E625 RID: 58917 RVA: 0x0033E778 File Offset: 0x0033C978
		public string UiCameraBlendName
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

		// Token: 0x0600E626 RID: 58918 RVA: 0x0033E7B0 File Offset: 0x0033C9B0
		public Span<byte> GetUiCameraBlendNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600E627 RID: 58919 RVA: 0x0033E7C0 File Offset: 0x0033C9C0
		public byte[] GetUiCameraBlendNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D2F RID: 15663
		// (get) Token: 0x0600E628 RID: 58920 RVA: 0x0033E7D8 File Offset: 0x0033C9D8
		public string BackViewBlendName
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

		// Token: 0x0600E629 RID: 58921 RVA: 0x0033E810 File Offset: 0x0033CA10
		public Span<byte> GetBackViewBlendNameBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600E62A RID: 58922 RVA: 0x0033E820 File Offset: 0x0033CA20
		public byte[] GetBackViewBlendNameArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D30 RID: 15664
		// (get) Token: 0x0600E62B RID: 58923 RVA: 0x0033E838 File Offset: 0x0033CA38
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E62C RID: 58924 RVA: 0x0033E870 File Offset: 0x0033CA70
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600E62D RID: 58925 RVA: 0x0033E880 File Offset: 0x0033CA80
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D31 RID: 15665
		// (get) Token: 0x0600E62E RID: 58926 RVA: 0x0033E898 File Offset: 0x0033CA98
		public string LightSequence
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E62F RID: 58927 RVA: 0x0033E8D0 File Offset: 0x0033CAD0
		public Span<byte> GetLightSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600E630 RID: 58928 RVA: 0x0033E8E0 File Offset: 0x0033CAE0
		public byte[] GetLightSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x040052CB RID: 21195
		private Table __p;
	}
}
