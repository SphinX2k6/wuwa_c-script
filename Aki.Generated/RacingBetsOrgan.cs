using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001075 RID: 4213
	public struct RacingBetsOrgan : IFlatbufferObject
	{
		// Token: 0x17002D39 RID: 11577
		// (get) Token: 0x0600BEB8 RID: 48824 RVA: 0x002F2A6D File Offset: 0x002F0C6D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BEB9 RID: 48825 RVA: 0x002F2A7A File Offset: 0x002F0C7A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BEBA RID: 48826 RVA: 0x002F2A84 File Offset: 0x002F0C84
		public static RacingBetsOrgan GetRootAsRacingBetsOrgan(ByteBuffer _bb)
		{
			return RacingBetsOrgan.GetRootAsRacingBetsOrgan(_bb, default(RacingBetsOrgan));
		}

		// Token: 0x0600BEBB RID: 48827 RVA: 0x002F2AA0 File Offset: 0x002F0CA0
		public static RacingBetsOrgan GetRootAsRacingBetsOrgan(ByteBuffer _bb, RacingBetsOrgan obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BEBC RID: 48828 RVA: 0x002F2ABD File Offset: 0x002F0CBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BEBD RID: 48829 RVA: 0x002F2ACC File Offset: 0x002F0CCC
		public RacingBetsOrgan __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D3A RID: 11578
		// (get) Token: 0x0600BEBE RID: 48830 RVA: 0x002F2ADC File Offset: 0x002F0CDC
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

		// Token: 0x17002D3B RID: 11579
		// (get) Token: 0x0600BEBF RID: 48831 RVA: 0x002F2B18 File Offset: 0x002F0D18
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

		// Token: 0x0600BEC0 RID: 48832 RVA: 0x002F2B4F File Offset: 0x002F0D4F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600BEC1 RID: 48833 RVA: 0x002F2B5E File Offset: 0x002F0D5E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002D3C RID: 11580
		// (get) Token: 0x0600BEC2 RID: 48834 RVA: 0x002F2B78 File Offset: 0x002F0D78
		public string Description
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

		// Token: 0x0600BEC3 RID: 48835 RVA: 0x002F2BAF File Offset: 0x002F0DAF
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600BEC4 RID: 48836 RVA: 0x002F2BBE File Offset: 0x002F0DBE
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002D3D RID: 11581
		// (get) Token: 0x0600BEC5 RID: 48837 RVA: 0x002F2BD8 File Offset: 0x002F0DD8
		public string ActivateDesc
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

		// Token: 0x0600BEC6 RID: 48838 RVA: 0x002F2C10 File Offset: 0x002F0E10
		public Span<byte> GetActivateDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600BEC7 RID: 48839 RVA: 0x002F2C20 File Offset: 0x002F0E20
		public byte[] GetActivateDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002D3E RID: 11582
		// (get) Token: 0x0600BEC8 RID: 48840 RVA: 0x002F2C38 File Offset: 0x002F0E38
		public string IconPath
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

		// Token: 0x0600BEC9 RID: 48841 RVA: 0x002F2C70 File Offset: 0x002F0E70
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600BECA RID: 48842 RVA: 0x002F2C80 File Offset: 0x002F0E80
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002D3F RID: 11583
		// (get) Token: 0x0600BECB RID: 48843 RVA: 0x002F2C98 File Offset: 0x002F0E98
		public string DefaultSceneEffectPath
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

		// Token: 0x0600BECC RID: 48844 RVA: 0x002F2CD0 File Offset: 0x002F0ED0
		public Span<byte> GetDefaultSceneEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600BECD RID: 48845 RVA: 0x002F2CE0 File Offset: 0x002F0EE0
		public byte[] GetDefaultSceneEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002D40 RID: 11584
		// (get) Token: 0x0600BECE RID: 48846 RVA: 0x002F2CF8 File Offset: 0x002F0EF8
		public string DynamicSceneEffectPath
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

		// Token: 0x0600BECF RID: 48847 RVA: 0x002F2D30 File Offset: 0x002F0F30
		public Span<byte> GetDynamicSceneEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600BED0 RID: 48848 RVA: 0x002F2D40 File Offset: 0x002F0F40
		public byte[] GetDynamicSceneEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002D41 RID: 11585
		// (get) Token: 0x0600BED1 RID: 48849 RVA: 0x002F2D58 File Offset: 0x002F0F58
		public string ActiveSceneEffectPath
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

		// Token: 0x0600BED2 RID: 48850 RVA: 0x002F2D90 File Offset: 0x002F0F90
		public Span<byte> GetActiveSceneEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600BED3 RID: 48851 RVA: 0x002F2DA0 File Offset: 0x002F0FA0
		public byte[] GetActiveSceneEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x04005644 RID: 22084
		private Table __p;
	}
}
