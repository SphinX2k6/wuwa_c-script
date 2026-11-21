using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BD2 RID: 3026
	public struct AiWanderRadiusConfig : IFlatbufferObject
	{
		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06004CB1 RID: 19633 RVA: 0x001F4A28 File Offset: 0x001F2C28
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004CB2 RID: 19634 RVA: 0x001F4A35 File Offset: 0x001F2C35
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004CB3 RID: 19635 RVA: 0x001F4A3C File Offset: 0x001F2C3C
		public static AiWanderRadiusConfig GetRootAsAiWanderRadiusConfig(ByteBuffer _bb)
		{
			return AiWanderRadiusConfig.GetRootAsAiWanderRadiusConfig(_bb, default(AiWanderRadiusConfig));
		}

		// Token: 0x06004CB4 RID: 19636 RVA: 0x001F4A58 File Offset: 0x001F2C58
		public static AiWanderRadiusConfig GetRootAsAiWanderRadiusConfig(ByteBuffer _bb, AiWanderRadiusConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004CB5 RID: 19637 RVA: 0x001F4A75 File Offset: 0x001F2C75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004CB6 RID: 19638 RVA: 0x001F4A84 File Offset: 0x001F2C84
		public AiWanderRadiusConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06004CB7 RID: 19639 RVA: 0x001F4A94 File Offset: 0x001F2C94
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

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06004CB8 RID: 19640 RVA: 0x001F4AD0 File Offset: 0x001F2CD0
		public float RandomRadius
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 600f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06004CB9 RID: 19641 RVA: 0x001F4B10 File Offset: 0x001F2D10
		public float MinWanderDistance
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 400f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040050B3 RID: 20659
		private Table __p;
	}
}
