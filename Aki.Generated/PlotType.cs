using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F4F RID: 3919
	public struct PlotType : IFlatbufferObject
	{
		// Token: 0x17002AA1 RID: 10913
		// (get) Token: 0x0600B273 RID: 45683 RVA: 0x002C9831 File Offset: 0x002C7A31
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B274 RID: 45684 RVA: 0x002C983E File Offset: 0x002C7A3E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B275 RID: 45685 RVA: 0x002C9848 File Offset: 0x002C7A48
		public static PlotType GetRootAsPlotType(ByteBuffer _bb)
		{
			return PlotType.GetRootAsPlotType(_bb, default(PlotType));
		}

		// Token: 0x0600B276 RID: 45686 RVA: 0x002C9864 File Offset: 0x002C7A64
		public static PlotType GetRootAsPlotType(ByteBuffer _bb, PlotType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B277 RID: 45687 RVA: 0x002C9881 File Offset: 0x002C7A81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B278 RID: 45688 RVA: 0x002C9890 File Offset: 0x002C7A90
		public PlotType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002AA2 RID: 10914
		// (get) Token: 0x0600B279 RID: 45689 RVA: 0x002C98A0 File Offset: 0x002C7AA0
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

		// Token: 0x17002AA3 RID: 10915
		// (get) Token: 0x0600B27A RID: 45690 RVA: 0x002C98DC File Offset: 0x002C7ADC
		public string TypeDescription
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

		// Token: 0x0600B27B RID: 45691 RVA: 0x002C9913 File Offset: 0x002C7B13
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B27C RID: 45692 RVA: 0x002C9922 File Offset: 0x002C7B22
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AA4 RID: 10916
		// (get) Token: 0x0600B27D RID: 45693 RVA: 0x002C993C File Offset: 0x002C7B3C
		public int Type
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

		// Token: 0x0400501C RID: 20508
		private Table __p;
	}
}
