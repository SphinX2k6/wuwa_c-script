using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E5C RID: 3676
	public struct InteractAudioMaterial : IFlatbufferObject
	{
		// Token: 0x17001A33 RID: 6707
		// (get) Token: 0x06008BEE RID: 35822 RVA: 0x00282F0D File Offset: 0x0028110D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008BEF RID: 35823 RVA: 0x00282F1A File Offset: 0x0028111A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008BF0 RID: 35824 RVA: 0x00282F24 File Offset: 0x00281124
		public static InteractAudioMaterial GetRootAsInteractAudioMaterial(ByteBuffer _bb)
		{
			return InteractAudioMaterial.GetRootAsInteractAudioMaterial(_bb, default(InteractAudioMaterial));
		}

		// Token: 0x06008BF1 RID: 35825 RVA: 0x00282F40 File Offset: 0x00281140
		public static InteractAudioMaterial GetRootAsInteractAudioMaterial(ByteBuffer _bb, InteractAudioMaterial obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008BF2 RID: 35826 RVA: 0x00282F5D File Offset: 0x0028115D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008BF3 RID: 35827 RVA: 0x00282F6C File Offset: 0x0028116C
		public InteractAudioMaterial __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001A34 RID: 6708
		// (get) Token: 0x06008BF4 RID: 35828 RVA: 0x00282F7C File Offset: 0x0028117C
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

		// Token: 0x06008BF5 RID: 35829 RVA: 0x00282FB3 File Offset: 0x002811B3
		public Span<byte> GetCollisionMaterialBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06008BF6 RID: 35830 RVA: 0x00282FC2 File Offset: 0x002811C2
		public byte[] GetCollisionMaterialArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A35 RID: 6709
		// (get) Token: 0x06008BF7 RID: 35831 RVA: 0x00282FDC File Offset: 0x002811DC
		public bool IsActiveImpacter
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001A36 RID: 6710
		// (get) Token: 0x06008BF8 RID: 35832 RVA: 0x0028301C File Offset: 0x0028121C
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

		// Token: 0x06008BF9 RID: 35833 RVA: 0x00283053 File Offset: 0x00281253
		public Span<byte> GetAudioEventBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008BFA RID: 35834 RVA: 0x00283062 File Offset: 0x00281262
		public byte[] GetAudioEventArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A37 RID: 6711
		// (get) Token: 0x06008BFB RID: 35835 RVA: 0x0028307C File Offset: 0x0028127C
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

		// Token: 0x17001A38 RID: 6712
		// (get) Token: 0x06008BFC RID: 35836 RVA: 0x002830C0 File Offset: 0x002812C0
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

		// Token: 0x17001A39 RID: 6713
		// (get) Token: 0x06008BFD RID: 35837 RVA: 0x00283104 File Offset: 0x00281304
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

		// Token: 0x17001A3A RID: 6714
		// (get) Token: 0x06008BFE RID: 35838 RVA: 0x00283148 File Offset: 0x00281348
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

		// Token: 0x040053E4 RID: 21476
		private Table __p;
	}
}
