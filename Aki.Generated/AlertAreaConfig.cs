using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BD5 RID: 3029
	public struct AlertAreaConfig : IFlatbufferObject
	{
		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06004CF4 RID: 19700 RVA: 0x001F53B5 File Offset: 0x001F35B5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004CF5 RID: 19701 RVA: 0x001F53C2 File Offset: 0x001F35C2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004CF6 RID: 19702 RVA: 0x001F53CC File Offset: 0x001F35CC
		public static AlertAreaConfig GetRootAsAlertAreaConfig(ByteBuffer _bb)
		{
			return AlertAreaConfig.GetRootAsAlertAreaConfig(_bb, default(AlertAreaConfig));
		}

		// Token: 0x06004CF7 RID: 19703 RVA: 0x001F53E8 File Offset: 0x001F35E8
		public static AlertAreaConfig GetRootAsAlertAreaConfig(ByteBuffer _bb, AlertAreaConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004CF8 RID: 19704 RVA: 0x001F5405 File Offset: 0x001F3605
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004CF9 RID: 19705 RVA: 0x001F5414 File Offset: 0x001F3614
		public AlertAreaConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06004CFA RID: 19706 RVA: 0x001F5424 File Offset: 0x001F3624
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

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06004CFB RID: 19707 RVA: 0x001F5460 File Offset: 0x001F3660
		public string Description
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

		// Token: 0x06004CFC RID: 19708 RVA: 0x001F5497 File Offset: 0x001F3697
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004CFD RID: 19709 RVA: 0x001F54A6 File Offset: 0x001F36A6
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06004CFE RID: 19710 RVA: 0x001F54C0 File Offset: 0x001F36C0
		public int CreatorId
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

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06004CFF RID: 19711 RVA: 0x001F54FC File Offset: 0x001F36FC
		public float MinValue
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06004D00 RID: 19712 RVA: 0x001F5540 File Offset: 0x001F3740
		public float MaxValue
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 100f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040050B6 RID: 20662
		private Table __p;
	}
}
