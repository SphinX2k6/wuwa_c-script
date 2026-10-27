using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D3D RID: 3389
	public struct HonamiStoryLoadingPerform : IFlatbufferObject
	{
		// Token: 0x170017CF RID: 6095
		// (get) Token: 0x0600803D RID: 32829 RVA: 0x00258189 File Offset: 0x00256389
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600803E RID: 32830 RVA: 0x00258196 File Offset: 0x00256396
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600803F RID: 32831 RVA: 0x002581A0 File Offset: 0x002563A0
		public static HonamiStoryLoadingPerform GetRootAsHonamiStoryLoadingPerform(ByteBuffer _bb)
		{
			return HonamiStoryLoadingPerform.GetRootAsHonamiStoryLoadingPerform(_bb, default(HonamiStoryLoadingPerform));
		}

		// Token: 0x06008040 RID: 32832 RVA: 0x002581BC File Offset: 0x002563BC
		public static HonamiStoryLoadingPerform GetRootAsHonamiStoryLoadingPerform(ByteBuffer _bb, HonamiStoryLoadingPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008041 RID: 32833 RVA: 0x002581D9 File Offset: 0x002563D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008042 RID: 32834 RVA: 0x002581E8 File Offset: 0x002563E8
		public HonamiStoryLoadingPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170017D0 RID: 6096
		// (get) Token: 0x06008043 RID: 32835 RVA: 0x002581F8 File Offset: 0x002563F8
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

		// Token: 0x170017D1 RID: 6097
		// (get) Token: 0x06008044 RID: 32836 RVA: 0x00258234 File Offset: 0x00256434
		public int Timing
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

		// Token: 0x170017D2 RID: 6098
		// (get) Token: 0x06008045 RID: 32837 RVA: 0x00258270 File Offset: 0x00256470
		public int MainBTId
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

		// Token: 0x170017D3 RID: 6099
		// (get) Token: 0x06008046 RID: 32838 RVA: 0x002582AC File Offset: 0x002564AC
		public int PerformType
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

		// Token: 0x170017D4 RID: 6100
		// (get) Token: 0x06008047 RID: 32839 RVA: 0x002582EC File Offset: 0x002564EC
		public string Title
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

		// Token: 0x06008048 RID: 32840 RVA: 0x00258324 File Offset: 0x00256524
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008049 RID: 32841 RVA: 0x00258334 File Offset: 0x00256534
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170017D5 RID: 6101
		// (get) Token: 0x0600804A RID: 32842 RVA: 0x0025834C File Offset: 0x0025654C
		public string Tips
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

		// Token: 0x0600804B RID: 32843 RVA: 0x00258384 File Offset: 0x00256584
		public Span<byte> GetTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600804C RID: 32844 RVA: 0x00258394 File Offset: 0x00256594
		public byte[] GetTipsArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170017D6 RID: 6102
		// (get) Token: 0x0600804D RID: 32845 RVA: 0x002583AC File Offset: 0x002565AC
		public string StartAudioEvent
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

		// Token: 0x0600804E RID: 32846 RVA: 0x002583E4 File Offset: 0x002565E4
		public Span<byte> GetStartAudioEventBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600804F RID: 32847 RVA: 0x002583F4 File Offset: 0x002565F4
		public byte[] GetStartAudioEventArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170017D7 RID: 6103
		// (get) Token: 0x06008050 RID: 32848 RVA: 0x0025840C File Offset: 0x0025660C
		public string EndAudioEvent
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

		// Token: 0x06008051 RID: 32849 RVA: 0x00258444 File Offset: 0x00256644
		public Span<byte> GetEndAudioEventBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06008052 RID: 32850 RVA: 0x00258454 File Offset: 0x00256654
		public byte[] GetEndAudioEventArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x04004DB8 RID: 19896
		private Table __p;
	}
}
