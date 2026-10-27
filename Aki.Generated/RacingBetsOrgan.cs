using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F8E RID: 3982
	public struct RacingBetsOrgan : IFlatbufferObject
	{
		// Token: 0x17002CC1 RID: 11457
		// (get) Token: 0x0600B87B RID: 47227 RVA: 0x002D61BD File Offset: 0x002D43BD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B87C RID: 47228 RVA: 0x002D61CA File Offset: 0x002D43CA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B87D RID: 47229 RVA: 0x002D61D4 File Offset: 0x002D43D4
		public static RacingBetsOrgan GetRootAsRacingBetsOrgan(ByteBuffer _bb)
		{
			return RacingBetsOrgan.GetRootAsRacingBetsOrgan(_bb, default(RacingBetsOrgan));
		}

		// Token: 0x0600B87E RID: 47230 RVA: 0x002D61F0 File Offset: 0x002D43F0
		public static RacingBetsOrgan GetRootAsRacingBetsOrgan(ByteBuffer _bb, RacingBetsOrgan obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B87F RID: 47231 RVA: 0x002D620D File Offset: 0x002D440D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B880 RID: 47232 RVA: 0x002D621C File Offset: 0x002D441C
		public RacingBetsOrgan __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002CC2 RID: 11458
		// (get) Token: 0x0600B881 RID: 47233 RVA: 0x002D622C File Offset: 0x002D442C
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

		// Token: 0x17002CC3 RID: 11459
		// (get) Token: 0x0600B882 RID: 47234 RVA: 0x002D6268 File Offset: 0x002D4468
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

		// Token: 0x0600B883 RID: 47235 RVA: 0x002D629F File Offset: 0x002D449F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B884 RID: 47236 RVA: 0x002D62AE File Offset: 0x002D44AE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002CC4 RID: 11460
		// (get) Token: 0x0600B885 RID: 47237 RVA: 0x002D62C8 File Offset: 0x002D44C8
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

		// Token: 0x0600B886 RID: 47238 RVA: 0x002D62FF File Offset: 0x002D44FF
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B887 RID: 47239 RVA: 0x002D630E File Offset: 0x002D450E
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002CC5 RID: 11461
		// (get) Token: 0x0600B888 RID: 47240 RVA: 0x002D6328 File Offset: 0x002D4528
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

		// Token: 0x0600B889 RID: 47241 RVA: 0x002D6360 File Offset: 0x002D4560
		public Span<byte> GetActivateDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B88A RID: 47242 RVA: 0x002D6370 File Offset: 0x002D4570
		public byte[] GetActivateDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002CC6 RID: 11462
		// (get) Token: 0x0600B88B RID: 47243 RVA: 0x002D6388 File Offset: 0x002D4588
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

		// Token: 0x0600B88C RID: 47244 RVA: 0x002D63C0 File Offset: 0x002D45C0
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B88D RID: 47245 RVA: 0x002D63D0 File Offset: 0x002D45D0
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002CC7 RID: 11463
		// (get) Token: 0x0600B88E RID: 47246 RVA: 0x002D63E8 File Offset: 0x002D45E8
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

		// Token: 0x0600B88F RID: 47247 RVA: 0x002D6420 File Offset: 0x002D4620
		public Span<byte> GetDefaultSceneEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B890 RID: 47248 RVA: 0x002D6430 File Offset: 0x002D4630
		public byte[] GetDefaultSceneEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002CC8 RID: 11464
		// (get) Token: 0x0600B891 RID: 47249 RVA: 0x002D6448 File Offset: 0x002D4648
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

		// Token: 0x0600B892 RID: 47250 RVA: 0x002D6480 File Offset: 0x002D4680
		public Span<byte> GetDynamicSceneEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B893 RID: 47251 RVA: 0x002D6490 File Offset: 0x002D4690
		public byte[] GetDynamicSceneEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002CC9 RID: 11465
		// (get) Token: 0x0600B894 RID: 47252 RVA: 0x002D64A8 File Offset: 0x002D46A8
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

		// Token: 0x0600B895 RID: 47253 RVA: 0x002D64E0 File Offset: 0x002D46E0
		public Span<byte> GetActiveSceneEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600B896 RID: 47254 RVA: 0x002D64F0 File Offset: 0x002D46F0
		public byte[] GetActiveSceneEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0400505D RID: 20573
		private Table __p;
	}
}
