using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AF8 RID: 2808
	public struct AiWanderRadiusConfig : IFlatbufferObject
	{
		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x0600476A RID: 18282 RVA: 0x001D50E4 File Offset: 0x001D32E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600476B RID: 18283 RVA: 0x001D50F1 File Offset: 0x001D32F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600476C RID: 18284 RVA: 0x001D50F8 File Offset: 0x001D32F8
		public static AiWanderRadiusConfig GetRootAsAiWanderRadiusConfig(ByteBuffer _bb)
		{
			return AiWanderRadiusConfig.GetRootAsAiWanderRadiusConfig(_bb, default(AiWanderRadiusConfig));
		}

		// Token: 0x0600476D RID: 18285 RVA: 0x001D5114 File Offset: 0x001D3314
		public static AiWanderRadiusConfig GetRootAsAiWanderRadiusConfig(ByteBuffer _bb, AiWanderRadiusConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600476E RID: 18286 RVA: 0x001D5131 File Offset: 0x001D3331
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600476F RID: 18287 RVA: 0x001D5140 File Offset: 0x001D3340
		public AiWanderRadiusConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06004770 RID: 18288 RVA: 0x001D5150 File Offset: 0x001D3350
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

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06004771 RID: 18289 RVA: 0x001D518C File Offset: 0x001D338C
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

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06004772 RID: 18290 RVA: 0x001D51CC File Offset: 0x001D33CC
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

		// Token: 0x04004AD9 RID: 19161
		private Table __p;
	}
}
