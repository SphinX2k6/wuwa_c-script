using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D77 RID: 3447
	public struct InteractAudioMaterial : IFlatbufferObject
	{
		// Token: 0x170019CF RID: 6607
		// (get) Token: 0x060085D3 RID: 34259 RVA: 0x00264C3D File Offset: 0x00262E3D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060085D4 RID: 34260 RVA: 0x00264C4A File Offset: 0x00262E4A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060085D5 RID: 34261 RVA: 0x00264C54 File Offset: 0x00262E54
		public static InteractAudioMaterial GetRootAsInteractAudioMaterial(ByteBuffer _bb)
		{
			return InteractAudioMaterial.GetRootAsInteractAudioMaterial(_bb, default(InteractAudioMaterial));
		}

		// Token: 0x060085D6 RID: 34262 RVA: 0x00264C70 File Offset: 0x00262E70
		public static InteractAudioMaterial GetRootAsInteractAudioMaterial(ByteBuffer _bb, InteractAudioMaterial obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060085D7 RID: 34263 RVA: 0x00264C8D File Offset: 0x00262E8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060085D8 RID: 34264 RVA: 0x00264C9C File Offset: 0x00262E9C
		public InteractAudioMaterial __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170019D0 RID: 6608
		// (get) Token: 0x060085D9 RID: 34265 RVA: 0x00264CAC File Offset: 0x00262EAC
		public string CollisionMaterial
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

		// Token: 0x060085DA RID: 34266 RVA: 0x00264CE3 File Offset: 0x00262EE3
		public Span<byte> GetCollisionMaterialBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060085DB RID: 34267 RVA: 0x00264CF2 File Offset: 0x00262EF2
		public byte[] GetCollisionMaterialArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x170019D1 RID: 6609
		// (get) Token: 0x060085DC RID: 34268 RVA: 0x00264D0C File Offset: 0x00262F0C
		public bool IsActiveImpacter
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170019D2 RID: 6610
		// (get) Token: 0x060085DD RID: 34269 RVA: 0x00264D4C File Offset: 0x00262F4C
		public string AudioEvent
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

		// Token: 0x060085DE RID: 34270 RVA: 0x00264D83 File Offset: 0x00262F83
		public Span<byte> GetAudioEventBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060085DF RID: 34271 RVA: 0x00264D92 File Offset: 0x00262F92
		public byte[] GetAudioEventArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170019D3 RID: 6611
		// (get) Token: 0x060085E0 RID: 34272 RVA: 0x00264DAC File Offset: 0x00262FAC
		public float ImpactMass
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170019D4 RID: 6612
		// (get) Token: 0x060085E1 RID: 34273 RVA: 0x00264DF0 File Offset: 0x00262FF0
		public float Maxforce
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170019D5 RID: 6613
		// (get) Token: 0x060085E2 RID: 34274 RVA: 0x00264E34 File Offset: 0x00263034
		public float MinimumPosteventForce
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170019D6 RID: 6614
		// (get) Token: 0x060085E3 RID: 34275 RVA: 0x00264E78 File Offset: 0x00263078
		public float MinimumTimeBetweenAkevent
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004DFF RID: 19967
		private Table __p;
	}
}
