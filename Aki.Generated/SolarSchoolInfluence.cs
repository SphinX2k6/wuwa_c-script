using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011EB RID: 4587
	public struct SolarSchoolInfluence : IFlatbufferObject
	{
		// Token: 0x170039A2 RID: 14754
		// (get) Token: 0x0600E191 RID: 57745 RVA: 0x003413D4 File Offset: 0x0033F5D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E192 RID: 57746 RVA: 0x003413E1 File Offset: 0x0033F5E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E193 RID: 57747 RVA: 0x003413E8 File Offset: 0x0033F5E8
		public static SolarSchoolInfluence GetRootAsSolarSchoolInfluence(ByteBuffer _bb)
		{
			return SolarSchoolInfluence.GetRootAsSolarSchoolInfluence(_bb, default(SolarSchoolInfluence));
		}

		// Token: 0x0600E194 RID: 57748 RVA: 0x00341404 File Offset: 0x0033F604
		public static SolarSchoolInfluence GetRootAsSolarSchoolInfluence(ByteBuffer _bb, SolarSchoolInfluence obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E195 RID: 57749 RVA: 0x00341421 File Offset: 0x0033F621
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E196 RID: 57750 RVA: 0x00341430 File Offset: 0x0033F630
		public SolarSchoolInfluence __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170039A3 RID: 14755
		// (get) Token: 0x0600E197 RID: 57751 RVA: 0x00341440 File Offset: 0x0033F640
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

		// Token: 0x170039A4 RID: 14756
		// (get) Token: 0x0600E198 RID: 57752 RVA: 0x0034147C File Offset: 0x0033F67C
		public string Color
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

		// Token: 0x0600E199 RID: 57753 RVA: 0x003414B3 File Offset: 0x0033F6B3
		public Span<byte> GetColorBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E19A RID: 57754 RVA: 0x003414C2 File Offset: 0x0033F6C2
		public byte[] GetColorArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170039A5 RID: 14757
		// (get) Token: 0x0600E19B RID: 57755 RVA: 0x003414DC File Offset: 0x0033F6DC
		public string Desc
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

		// Token: 0x0600E19C RID: 57756 RVA: 0x00341513 File Offset: 0x0033F713
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E19D RID: 57757 RVA: 0x00341522 File Offset: 0x0033F722
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170039A6 RID: 14758
		// (get) Token: 0x0600E19E RID: 57758 RVA: 0x0034153C File Offset: 0x0033F73C
		public int ActivityId
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

		// Token: 0x170039A7 RID: 14759
		// (get) Token: 0x0600E19F RID: 57759 RVA: 0x0034157C File Offset: 0x0033F77C
		public string Icon
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

		// Token: 0x0600E1A0 RID: 57760 RVA: 0x003415B4 File Offset: 0x0033F7B4
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600E1A1 RID: 57761 RVA: 0x003415C4 File Offset: 0x0033F7C4
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04005828 RID: 22568
		private Table __p;
	}
}
