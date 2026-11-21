using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012E7 RID: 4839
	public struct ConfigPropValue : IFlatbufferObject
	{
		// Token: 0x17004214 RID: 16916
		// (get) Token: 0x0600F73C RID: 63292 RVA: 0x00371A35 File Offset: 0x0036FC35
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F73D RID: 63293 RVA: 0x00371A42 File Offset: 0x0036FC42
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F73E RID: 63294 RVA: 0x00371A4C File Offset: 0x0036FC4C
		public static ConfigPropValue GetRootAsConfigPropValue(ByteBuffer _bb)
		{
			return ConfigPropValue.GetRootAsConfigPropValue(_bb, default(ConfigPropValue));
		}

		// Token: 0x0600F73F RID: 63295 RVA: 0x00371A68 File Offset: 0x0036FC68
		public static ConfigPropValue GetRootAsConfigPropValue(ByteBuffer _bb, ConfigPropValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F740 RID: 63296 RVA: 0x00371A85 File Offset: 0x0036FC85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F741 RID: 63297 RVA: 0x00371A94 File Offset: 0x0036FC94
		public ConfigPropValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004215 RID: 16917
		// (get) Token: 0x0600F742 RID: 63298 RVA: 0x00371AA4 File Offset: 0x0036FCA4
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

		// Token: 0x17004216 RID: 16918
		// (get) Token: 0x0600F743 RID: 63299 RVA: 0x00371AE0 File Offset: 0x0036FCE0
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

		// Token: 0x17004217 RID: 16919
		// (get) Token: 0x0600F744 RID: 63300 RVA: 0x00371B20 File Offset: 0x0036FD20
		public bool IsRatio
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04005941 RID: 22849
		private Table __p;
	}
}
