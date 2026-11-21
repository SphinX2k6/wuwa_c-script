using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001123 RID: 4387
	public struct RoleBirthday : IFlatbufferObject
	{
		// Token: 0x1700327B RID: 12923
		// (get) Token: 0x0600CDA3 RID: 52643 RVA: 0x00313AC5 File Offset: 0x00311CC5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CDA4 RID: 52644 RVA: 0x00313AD2 File Offset: 0x00311CD2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CDA5 RID: 52645 RVA: 0x00313ADC File Offset: 0x00311CDC
		public static RoleBirthday GetRootAsRoleBirthday(ByteBuffer _bb)
		{
			return RoleBirthday.GetRootAsRoleBirthday(_bb, default(RoleBirthday));
		}

		// Token: 0x0600CDA6 RID: 52646 RVA: 0x00313AF8 File Offset: 0x00311CF8
		public static RoleBirthday GetRootAsRoleBirthday(ByteBuffer _bb, RoleBirthday obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CDA7 RID: 52647 RVA: 0x00313B15 File Offset: 0x00311D15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CDA8 RID: 52648 RVA: 0x00313B24 File Offset: 0x00311D24
		public RoleBirthday __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700327C RID: 12924
		// (get) Token: 0x0600CDA9 RID: 52649 RVA: 0x00313B34 File Offset: 0x00311D34
		public int RoleId
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

		// Token: 0x1700327D RID: 12925
		// (get) Token: 0x0600CDAA RID: 52650 RVA: 0x00313B70 File Offset: 0x00311D70
		public int Priority
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

		// Token: 0x1700327E RID: 12926
		// (get) Token: 0x0600CDAB RID: 52651 RVA: 0x00313BAC File Offset: 0x00311DAC
		public string CardTextKey
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

		// Token: 0x0600CDAC RID: 52652 RVA: 0x00313BE3 File Offset: 0x00311DE3
		public Span<byte> GetCardTextKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600CDAD RID: 52653 RVA: 0x00313BF2 File Offset: 0x00311DF2
		public byte[] GetCardTextKeyArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700327F RID: 12927
		// (get) Token: 0x0600CDAE RID: 52654 RVA: 0x00313C0C File Offset: 0x00311E0C
		public string VoiceEvent
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

		// Token: 0x0600CDAF RID: 52655 RVA: 0x00313C44 File Offset: 0x00311E44
		public Span<byte> GetVoiceEventBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600CDB0 RID: 52656 RVA: 0x00313C54 File Offset: 0x00311E54
		public byte[] GetVoiceEventArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003280 RID: 12928
		// (get) Token: 0x0600CDB1 RID: 52657 RVA: 0x00313C6C File Offset: 0x00311E6C
		public string SceneCameraId
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

		// Token: 0x0600CDB2 RID: 52658 RVA: 0x00313CA4 File Offset: 0x00311EA4
		public Span<byte> GetSceneCameraIdBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600CDB3 RID: 52659 RVA: 0x00313CB4 File Offset: 0x00311EB4
		public byte[] GetSceneCameraIdArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003281 RID: 12929
		// (get) Token: 0x0600CDB4 RID: 52660 RVA: 0x00313CCC File Offset: 0x00311ECC
		public string CardCameraId
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

		// Token: 0x0600CDB5 RID: 52661 RVA: 0x00313D04 File Offset: 0x00311F04
		public Span<byte> GetCardCameraIdBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600CDB6 RID: 52662 RVA: 0x00313D14 File Offset: 0x00311F14
		public byte[] GetCardCameraIdArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04005720 RID: 22304
		private Table __p;
	}
}
