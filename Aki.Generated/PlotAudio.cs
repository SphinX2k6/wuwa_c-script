using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001030 RID: 4144
	public struct PlotAudio : IFlatbufferObject
	{
		// Token: 0x17002AEF RID: 10991
		// (get) Token: 0x0600B851 RID: 47185 RVA: 0x002E5848 File Offset: 0x002E3A48
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B852 RID: 47186 RVA: 0x002E5855 File Offset: 0x002E3A55
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B853 RID: 47187 RVA: 0x002E585C File Offset: 0x002E3A5C
		public static PlotAudio GetRootAsPlotAudio(ByteBuffer _bb)
		{
			return PlotAudio.GetRootAsPlotAudio(_bb, default(PlotAudio));
		}

		// Token: 0x0600B854 RID: 47188 RVA: 0x002E5878 File Offset: 0x002E3A78
		public static PlotAudio GetRootAsPlotAudio(ByteBuffer _bb, PlotAudio obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B855 RID: 47189 RVA: 0x002E5895 File Offset: 0x002E3A95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B856 RID: 47190 RVA: 0x002E58A4 File Offset: 0x002E3AA4
		public PlotAudio __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002AF0 RID: 10992
		// (get) Token: 0x0600B857 RID: 47191 RVA: 0x002E58B4 File Offset: 0x002E3AB4
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

		// Token: 0x0600B858 RID: 47192 RVA: 0x002E58EB File Offset: 0x002E3AEB
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600B859 RID: 47193 RVA: 0x002E58FA File Offset: 0x002E3AFA
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AF1 RID: 10993
		// (get) Token: 0x0600B85A RID: 47194 RVA: 0x002E5914 File Offset: 0x002E3B14
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

		// Token: 0x0600B85B RID: 47195 RVA: 0x002E594B File Offset: 0x002E3B4B
		public Span<byte> GetExternalSourceSettingBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B85C RID: 47196 RVA: 0x002E595A File Offset: 0x002E3B5A
		public byte[] GetExternalSourceSettingArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AF2 RID: 10994
		// (get) Token: 0x0600B85D RID: 47197 RVA: 0x002E5974 File Offset: 0x002E3B74
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

		// Token: 0x0600B85E RID: 47198 RVA: 0x002E59AB File Offset: 0x002E3BAB
		public Span<byte> GetFileNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B85F RID: 47199 RVA: 0x002E59BA File Offset: 0x002E3BBA
		public byte[] GetFileNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AF3 RID: 10995
		// (get) Token: 0x0600B860 RID: 47200 RVA: 0x002E59D4 File Offset: 0x002E3BD4
		public bool GlobalLanguage
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002AF4 RID: 10996
		// (get) Token: 0x0600B861 RID: 47201 RVA: 0x002E5A14 File Offset: 0x002E3C14
		public bool CheckGenderEn
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002AF5 RID: 10997
		// (get) Token: 0x0600B862 RID: 47202 RVA: 0x002E5A54 File Offset: 0x002E3C54
		public bool CheckGenderJa
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002AF6 RID: 10998
		// (get) Token: 0x0600B863 RID: 47203 RVA: 0x002E5A94 File Offset: 0x002E3C94
		public bool CheckGenderKo
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002AF7 RID: 10999
		// (get) Token: 0x0600B864 RID: 47204 RVA: 0x002E5AD4 File Offset: 0x002E3CD4
		public bool CheckGenderZh
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002AF8 RID: 11000
		// (get) Token: 0x0600B865 RID: 47205 RVA: 0x002E5B14 File Offset: 0x002E3D14
		public bool GenLipSync
		{
			get
			{
				int num = this.__p.__offset(20);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002AF9 RID: 11001
		// (get) Token: 0x0600B866 RID: 47206 RVA: 0x002E5B54 File Offset: 0x002E3D54
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

		// Token: 0x17002AFA RID: 11002
		// (get) Token: 0x0600B867 RID: 47207 RVA: 0x002E5B94 File Offset: 0x002E3D94
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

		// Token: 0x0600B868 RID: 47208 RVA: 0x002E5BCC File Offset: 0x002E3DCC
		public Span<byte> GetVarParamsBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600B869 RID: 47209 RVA: 0x002E5BDC File Offset: 0x002E3DDC
		public byte[] GetVarParamsArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x040055FD RID: 22013
		private Table __p;
	}
}
