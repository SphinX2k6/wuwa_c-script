using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F48 RID: 3912
	public struct PlayerTitle : IFlatbufferObject
	{
		// Token: 0x17002A64 RID: 10852
		// (get) Token: 0x0600B1D0 RID: 45520 RVA: 0x002C8378 File Offset: 0x002C6578
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B1D1 RID: 45521 RVA: 0x002C8385 File Offset: 0x002C6585
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B1D2 RID: 45522 RVA: 0x002C838C File Offset: 0x002C658C
		public static PlayerTitle GetRootAsPlayerTitle(ByteBuffer _bb)
		{
			return PlayerTitle.GetRootAsPlayerTitle(_bb, default(PlayerTitle));
		}

		// Token: 0x0600B1D3 RID: 45523 RVA: 0x002C83A8 File Offset: 0x002C65A8
		public static PlayerTitle GetRootAsPlayerTitle(ByteBuffer _bb, PlayerTitle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B1D4 RID: 45524 RVA: 0x002C83C5 File Offset: 0x002C65C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B1D5 RID: 45525 RVA: 0x002C83D4 File Offset: 0x002C65D4
		public PlayerTitle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002A65 RID: 10853
		// (get) Token: 0x0600B1D6 RID: 45526 RVA: 0x002C83E4 File Offset: 0x002C65E4
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

		// Token: 0x17002A66 RID: 10854
		// (get) Token: 0x0600B1D7 RID: 45527 RVA: 0x002C8420 File Offset: 0x002C6620
		public int TitleType
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

		// Token: 0x17002A67 RID: 10855
		// (get) Token: 0x0600B1D8 RID: 45528 RVA: 0x002C845C File Offset: 0x002C665C
		public int LimitTimeId
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

		// Token: 0x17002A68 RID: 10856
		// (get) Token: 0x0600B1D9 RID: 45529 RVA: 0x002C8498 File Offset: 0x002C6698
		public int TitleStyle
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

		// Token: 0x17002A69 RID: 10857
		// (get) Token: 0x0600B1DA RID: 45530 RVA: 0x002C84D8 File Offset: 0x002C66D8
		public string TitleName
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

		// Token: 0x0600B1DB RID: 45531 RVA: 0x002C8510 File Offset: 0x002C6710
		public Span<byte> GetTitleNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B1DC RID: 45532 RVA: 0x002C8520 File Offset: 0x002C6720
		public byte[] GetTitleNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A6A RID: 10858
		// (get) Token: 0x0600B1DD RID: 45533 RVA: 0x002C8538 File Offset: 0x002C6738
		public int TitleQuality
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

		// Token: 0x17002A6B RID: 10859
		// (get) Token: 0x0600B1DE RID: 45534 RVA: 0x002C8578 File Offset: 0x002C6778
		public string TitleIcon
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

		// Token: 0x0600B1DF RID: 45535 RVA: 0x002C85B0 File Offset: 0x002C67B0
		public Span<byte> GetTitleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B1E0 RID: 45536 RVA: 0x002C85C0 File Offset: 0x002C67C0
		public byte[] GetTitleIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A6C RID: 10860
		// (get) Token: 0x0600B1E1 RID: 45537 RVA: 0x002C85D8 File Offset: 0x002C67D8
		public string RoleHeadIcon
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

		// Token: 0x0600B1E2 RID: 45538 RVA: 0x002C8610 File Offset: 0x002C6810
		public Span<byte> GetRoleHeadIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600B1E3 RID: 45539 RVA: 0x002C8620 File Offset: 0x002C6820
		public byte[] GetRoleHeadIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A6D RID: 10861
		// (get) Token: 0x0600B1E4 RID: 45540 RVA: 0x002C8638 File Offset: 0x002C6838
		public string FemaleRoleHeadIcon
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

		// Token: 0x0600B1E5 RID: 45541 RVA: 0x002C8670 File Offset: 0x002C6870
		public Span<byte> GetFemaleRoleHeadIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600B1E6 RID: 45542 RVA: 0x002C8680 File Offset: 0x002C6880
		public byte[] GetFemaleRoleHeadIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A6E RID: 10862
		// (get) Token: 0x0600B1E7 RID: 45543 RVA: 0x002C8698 File Offset: 0x002C6898
		public string DecorateLeftIcon
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

		// Token: 0x0600B1E8 RID: 45544 RVA: 0x002C86D0 File Offset: 0x002C68D0
		public Span<byte> GetDecorateLeftIconBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600B1E9 RID: 45545 RVA: 0x002C86E0 File Offset: 0x002C68E0
		public byte[] GetDecorateLeftIconArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A6F RID: 10863
		// (get) Token: 0x0600B1EA RID: 45546 RVA: 0x002C86F8 File Offset: 0x002C68F8
		public string DecorateRightIcon
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

		// Token: 0x0600B1EB RID: 45547 RVA: 0x002C8730 File Offset: 0x002C6930
		public Span<byte> GetDecorateRightIconBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600B1EC RID: 45548 RVA: 0x002C8740 File Offset: 0x002C6940
		public byte[] GetDecorateRightIconArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A70 RID: 10864
		// (get) Token: 0x0600B1ED RID: 45549 RVA: 0x002C8758 File Offset: 0x002C6958
		public string DecorateLeftNiagara
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B1EE RID: 45550 RVA: 0x002C8790 File Offset: 0x002C6990
		public Span<byte> GetDecorateLeftNiagaraBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600B1EF RID: 45551 RVA: 0x002C87A0 File Offset: 0x002C69A0
		public byte[] GetDecorateLeftNiagaraArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A71 RID: 10865
		// (get) Token: 0x0600B1F0 RID: 45552 RVA: 0x002C87B8 File Offset: 0x002C69B8
		public string DecorateRightNiagara
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B1F1 RID: 45553 RVA: 0x002C87F0 File Offset: 0x002C69F0
		public Span<byte> GetDecorateRightNiagaraBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600B1F2 RID: 45554 RVA: 0x002C8800 File Offset: 0x002C6A00
		public byte[] GetDecorateRightNiagaraArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A72 RID: 10866
		// (get) Token: 0x0600B1F3 RID: 45555 RVA: 0x002C8818 File Offset: 0x002C6A18
		public string DecorateBgNiagara
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B1F4 RID: 45556 RVA: 0x002C8850 File Offset: 0x002C6A50
		public Span<byte> GetDecorateBgNiagaraBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600B1F5 RID: 45557 RVA: 0x002C8860 File Offset: 0x002C6A60
		public byte[] GetDecorateBgNiagaraArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A73 RID: 10867
		// (get) Token: 0x0600B1F6 RID: 45558 RVA: 0x002C8878 File Offset: 0x002C6A78
		public string TitleBgIcon
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B1F7 RID: 45559 RVA: 0x002C88B0 File Offset: 0x002C6AB0
		public Span<byte> GetTitleBgIconBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600B1F8 RID: 45560 RVA: 0x002C88C0 File Offset: 0x002C6AC0
		public byte[] GetTitleBgIconArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A74 RID: 10868
		// (get) Token: 0x0600B1F9 RID: 45561 RVA: 0x002C88D8 File Offset: 0x002C6AD8
		public string StarTitleIcon
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B1FA RID: 45562 RVA: 0x002C8910 File Offset: 0x002C6B10
		public Span<byte> GetStarTitleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600B1FB RID: 45563 RVA: 0x002C8920 File Offset: 0x002C6B20
		public byte[] GetStarTitleIconArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A75 RID: 10869
		// (get) Token: 0x0600B1FC RID: 45564 RVA: 0x002C8938 File Offset: 0x002C6B38
		public string StarTitleBgIcon
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B1FD RID: 45565 RVA: 0x002C8970 File Offset: 0x002C6B70
		public Span<byte> GetStarTitleBgIconBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600B1FE RID: 45566 RVA: 0x002C8980 File Offset: 0x002C6B80
		public byte[] GetStarTitleBgIconArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A76 RID: 10870
		// (get) Token: 0x0600B1FF RID: 45567 RVA: 0x002C8998 File Offset: 0x002C6B98
		public string SelectedIcon
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B200 RID: 45568 RVA: 0x002C89D0 File Offset: 0x002C6BD0
		public Span<byte> GetSelectedIconBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600B201 RID: 45569 RVA: 0x002C89E0 File Offset: 0x002C6BE0
		public byte[] GetSelectedIconArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A77 RID: 10871
		// (get) Token: 0x0600B202 RID: 45570 RVA: 0x002C89F8 File Offset: 0x002C6BF8
		public string Description
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B203 RID: 45571 RVA: 0x002C8A30 File Offset: 0x002C6C30
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600B204 RID: 45572 RVA: 0x002C8A40 File Offset: 0x002C6C40
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A78 RID: 10872
		// (get) Token: 0x0600B205 RID: 45573 RVA: 0x002C8A58 File Offset: 0x002C6C58
		public int ActivityId
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002A79 RID: 10873
		// (get) Token: 0x0600B206 RID: 45574 RVA: 0x002C8A98 File Offset: 0x002C6C98
		public string HonorDescription
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B207 RID: 45575 RVA: 0x002C8AD0 File Offset: 0x002C6CD0
		public Span<byte> GetHonorDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0600B208 RID: 45576 RVA: 0x002C8AE0 File Offset: 0x002C6CE0
		public byte[] GetHonorDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A7A RID: 10874
		// (get) Token: 0x0600B209 RID: 45577 RVA: 0x002C8AF8 File Offset: 0x002C6CF8
		public string SeasonId
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B20A RID: 45578 RVA: 0x002C8B30 File Offset: 0x002C6D30
		public Span<byte> GetSeasonIdBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0600B20B RID: 45579 RVA: 0x002C8B40 File Offset: 0x002C6D40
		public byte[] GetSeasonIdArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A7B RID: 10875
		// (get) Token: 0x0600B20C RID: 45580 RVA: 0x002C8B58 File Offset: 0x002C6D58
		public string SeasonName
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B20D RID: 45581 RVA: 0x002C8B90 File Offset: 0x002C6D90
		public Span<byte> GetSeasonNameBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x0600B20E RID: 45582 RVA: 0x002C8BA0 File Offset: 0x002C6DA0
		public byte[] GetSeasonNameArray()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A7C RID: 10876
		// (get) Token: 0x0600B20F RID: 45583 RVA: 0x002C8BB8 File Offset: 0x002C6DB8
		public string ActvityName
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B210 RID: 45584 RVA: 0x002C8BF0 File Offset: 0x002C6DF0
		public Span<byte> GetActvityNameBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x0600B211 RID: 45585 RVA: 0x002C8C00 File Offset: 0x002C6E00
		public byte[] GetActvityNameArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A7D RID: 10877
		// (get) Token: 0x0600B212 RID: 45586 RVA: 0x002C8C18 File Offset: 0x002C6E18
		public bool IsShowProgress
		{
			get
			{
				int num = this.__p.__offset(52);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002A7E RID: 10878
		// (get) Token: 0x0600B213 RID: 45587 RVA: 0x002C8C58 File Offset: 0x002C6E58
		public string ItemAccess
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B214 RID: 45588 RVA: 0x002C8C90 File Offset: 0x002C6E90
		public Span<byte> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<byte>(54, 1);
		}

		// Token: 0x0600B215 RID: 45589 RVA: 0x002C8CA0 File Offset: 0x002C6EA0
		public byte[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<byte>(54) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A7F RID: 10879
		// (get) Token: 0x0600B216 RID: 45590 RVA: 0x002C8CB8 File Offset: 0x002C6EB8
		public int SortIndex
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002A80 RID: 10880
		// (get) Token: 0x0600B217 RID: 45591 RVA: 0x002C8CF8 File Offset: 0x002C6EF8
		public string IconInTitleInfo
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B218 RID: 45592 RVA: 0x002C8D30 File Offset: 0x002C6F30
		public Span<byte> GetIconInTitleInfoBytes()
		{
			return this.__p.__vector_as_span<byte>(58, 1);
		}

		// Token: 0x0600B219 RID: 45593 RVA: 0x002C8D40 File Offset: 0x002C6F40
		public byte[] GetIconInTitleInfoArray()
		{
			return this.__p.__vector_as_array<byte>(58) ?? Array.Empty<byte>();
		}

		// Token: 0x04005015 RID: 20501
		private Table __p;
	}
}
