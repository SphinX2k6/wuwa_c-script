using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001026 RID: 4134
	public struct PinballWeaponType : IFlatbufferObject
	{
		// Token: 0x17002A7C RID: 10876
		// (get) Token: 0x0600B70E RID: 46862 RVA: 0x002E2C27 File Offset: 0x002E0E27
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B70F RID: 46863 RVA: 0x002E2C34 File Offset: 0x002E0E34
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B710 RID: 46864 RVA: 0x002E2C3C File Offset: 0x002E0E3C
		public static PinballWeaponType GetRootAsPinballWeaponType(ByteBuffer _bb)
		{
			return PinballWeaponType.GetRootAsPinballWeaponType(_bb, default(PinballWeaponType));
		}

		// Token: 0x0600B711 RID: 46865 RVA: 0x002E2C58 File Offset: 0x002E0E58
		public static PinballWeaponType GetRootAsPinballWeaponType(ByteBuffer _bb, PinballWeaponType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B712 RID: 46866 RVA: 0x002E2C75 File Offset: 0x002E0E75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B713 RID: 46867 RVA: 0x002E2C84 File Offset: 0x002E0E84
		public PinballWeaponType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002A7D RID: 10877
		// (get) Token: 0x0600B714 RID: 46868 RVA: 0x002E2C94 File Offset: 0x002E0E94
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

		// Token: 0x17002A7E RID: 10878
		// (get) Token: 0x0600B715 RID: 46869 RVA: 0x002E2CD0 File Offset: 0x002E0ED0
		public string Name
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

		// Token: 0x0600B716 RID: 46870 RVA: 0x002E2D07 File Offset: 0x002E0F07
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B717 RID: 46871 RVA: 0x002E2D16 File Offset: 0x002E0F16
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A7F RID: 10879
		// (get) Token: 0x0600B718 RID: 46872 RVA: 0x002E2D30 File Offset: 0x002E0F30
		public string Icon
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

		// Token: 0x0600B719 RID: 46873 RVA: 0x002E2D67 File Offset: 0x002E0F67
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B71A RID: 46874 RVA: 0x002E2D76 File Offset: 0x002E0F76
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A80 RID: 10880
		// (get) Token: 0x0600B71B RID: 46875 RVA: 0x002E2D90 File Offset: 0x002E0F90
		public string Icon2
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

		// Token: 0x0600B71C RID: 46876 RVA: 0x002E2DC8 File Offset: 0x002E0FC8
		public Span<byte> GetIcon2Bytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B71D RID: 46877 RVA: 0x002E2DD8 File Offset: 0x002E0FD8
		public byte[] GetIcon2Array()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A81 RID: 10881
		// (get) Token: 0x0600B71E RID: 46878 RVA: 0x002E2DF0 File Offset: 0x002E0FF0
		public string Icon3
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

		// Token: 0x0600B71F RID: 46879 RVA: 0x002E2E28 File Offset: 0x002E1028
		public Span<byte> GetIcon3Bytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B720 RID: 46880 RVA: 0x002E2E38 File Offset: 0x002E1038
		public byte[] GetIcon3Array()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x040055F0 RID: 22000
		private Table __p;
	}
}
