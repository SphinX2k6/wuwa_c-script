using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F4B RID: 3915
	public struct PlotAudio : IFlatbufferObject
	{
		// Token: 0x17002A89 RID: 10889
		// (get) Token: 0x0600B230 RID: 45616 RVA: 0x002C8FE0 File Offset: 0x002C71E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B231 RID: 45617 RVA: 0x002C8FED File Offset: 0x002C71ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B232 RID: 45618 RVA: 0x002C8FF4 File Offset: 0x002C71F4
		public static PlotAudio GetRootAsPlotAudio(ByteBuffer _bb)
		{
			return PlotAudio.GetRootAsPlotAudio(_bb, default(PlotAudio));
		}

		// Token: 0x0600B233 RID: 45619 RVA: 0x002C9010 File Offset: 0x002C7210
		public static PlotAudio GetRootAsPlotAudio(ByteBuffer _bb, PlotAudio obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B234 RID: 45620 RVA: 0x002C902D File Offset: 0x002C722D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B235 RID: 45621 RVA: 0x002C903C File Offset: 0x002C723C
		public PlotAudio __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002A8A RID: 10890
		// (get) Token: 0x0600B236 RID: 45622 RVA: 0x002C904C File Offset: 0x002C724C
		public string Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B237 RID: 45623 RVA: 0x002C9083 File Offset: 0x002C7283
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600B238 RID: 45624 RVA: 0x002C9092 File Offset: 0x002C7292
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A8B RID: 10891
		// (get) Token: 0x0600B239 RID: 45625 RVA: 0x002C90AC File Offset: 0x002C72AC
		public string ExternalSourceSetting
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

		// Token: 0x0600B23A RID: 45626 RVA: 0x002C90E3 File Offset: 0x002C72E3
		public Span<byte> GetExternalSourceSettingBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B23B RID: 45627 RVA: 0x002C90F2 File Offset: 0x002C72F2
		public byte[] GetExternalSourceSettingArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A8C RID: 10892
		// (get) Token: 0x0600B23C RID: 45628 RVA: 0x002C910C File Offset: 0x002C730C
		public string FileName
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

		// Token: 0x0600B23D RID: 45629 RVA: 0x002C9143 File Offset: 0x002C7343
		public Span<byte> GetFileNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B23E RID: 45630 RVA: 0x002C9152 File Offset: 0x002C7352
		public byte[] GetFileNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A8D RID: 10893
		// (get) Token: 0x0600B23F RID: 45631 RVA: 0x002C916C File Offset: 0x002C736C
		public bool GlobalLanguage
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002A8E RID: 10894
		// (get) Token: 0x0600B240 RID: 45632 RVA: 0x002C91AC File Offset: 0x002C73AC
		public bool CheckGenderEn
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002A8F RID: 10895
		// (get) Token: 0x0600B241 RID: 45633 RVA: 0x002C91EC File Offset: 0x002C73EC
		public bool CheckGenderJa
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002A90 RID: 10896
		// (get) Token: 0x0600B242 RID: 45634 RVA: 0x002C922C File Offset: 0x002C742C
		public bool CheckGenderKo
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002A91 RID: 10897
		// (get) Token: 0x0600B243 RID: 45635 RVA: 0x002C926C File Offset: 0x002C746C
		public bool CheckGenderZh
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002A92 RID: 10898
		// (get) Token: 0x0600B244 RID: 45636 RVA: 0x002C92AC File Offset: 0x002C74AC
		public bool GenLipSync
		{
			get
			{
				int num = this.__p.__offset(20);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002A93 RID: 10899
		// (get) Token: 0x0600B245 RID: 45637 RVA: 0x002C92EC File Offset: 0x002C74EC
		public int TailTime
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002A94 RID: 10900
		// (get) Token: 0x0600B246 RID: 45638 RVA: 0x002C932C File Offset: 0x002C752C
		public string VarParams
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

		// Token: 0x0600B247 RID: 45639 RVA: 0x002C9364 File Offset: 0x002C7564
		public Span<byte> GetVarParamsBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600B248 RID: 45640 RVA: 0x002C9374 File Offset: 0x002C7574
		public byte[] GetVarParamsArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x04005018 RID: 20504
		private Table __p;
	}
}
