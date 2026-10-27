using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011B1 RID: 4529
	public struct ConfigPropValue : IFlatbufferObject
	{
		// Token: 0x17003EAF RID: 16047
		// (get) Token: 0x0600E9CB RID: 59851 RVA: 0x00346DA9 File Offset: 0x00344FA9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E9CC RID: 59852 RVA: 0x00346DB6 File Offset: 0x00344FB6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E9CD RID: 59853 RVA: 0x00346DC0 File Offset: 0x00344FC0
		public static ConfigPropValue GetRootAsConfigPropValue(ByteBuffer _bb)
		{
			return ConfigPropValue.GetRootAsConfigPropValue(_bb, default(ConfigPropValue));
		}

		// Token: 0x0600E9CE RID: 59854 RVA: 0x00346DDC File Offset: 0x00344FDC
		public static ConfigPropValue GetRootAsConfigPropValue(ByteBuffer _bb, ConfigPropValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E9CF RID: 59855 RVA: 0x00346DF9 File Offset: 0x00344FF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E9D0 RID: 59856 RVA: 0x00346E08 File Offset: 0x00345008
		public ConfigPropValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003EB0 RID: 16048
		// (get) Token: 0x0600E9D1 RID: 59857 RVA: 0x00346E18 File Offset: 0x00345018
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

		// Token: 0x17003EB1 RID: 16049
		// (get) Token: 0x0600E9D2 RID: 59858 RVA: 0x00346E54 File Offset: 0x00345054
		public float Value
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003EB2 RID: 16050
		// (get) Token: 0x0600E9D3 RID: 59859 RVA: 0x00346E94 File Offset: 0x00345094
		public bool IsRatio
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x040052FE RID: 21246
		private Table __p;
	}
}
