using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075B2 RID: 30130
	public struct IReignsTriggerGuide : IFlatbufferObject
	{
		// Token: 0x1700DD8A RID: 56714
		// (get) Token: 0x06034DA0 RID: 216480 RVA: 0x0071AB8D File Offset: 0x00718D8D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034DA1 RID: 216481 RVA: 0x0071AB9A File Offset: 0x00718D9A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034DA2 RID: 216482 RVA: 0x0071ABA4 File Offset: 0x00718DA4
		public static IReignsTriggerGuide GetRootAsIReignsTriggerGuide(ByteBuffer _bb)
		{
			return IReignsTriggerGuide.GetRootAsIReignsTriggerGuide(_bb, default(IReignsTriggerGuide));
		}

		// Token: 0x06034DA3 RID: 216483 RVA: 0x0071ABC0 File Offset: 0x00718DC0
		public static IReignsTriggerGuide GetRootAsIReignsTriggerGuide(ByteBuffer _bb, IReignsTriggerGuide obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034DA4 RID: 216484 RVA: 0x0071ABDD File Offset: 0x00718DDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034DA5 RID: 216485 RVA: 0x0071ABEC File Offset: 0x00718DEC
		public IReignsTriggerGuide __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DD8B RID: 56715
		// (get) Token: 0x06034DA6 RID: 216486 RVA: 0x0071ABFC File Offset: 0x00718DFC
		public int GuideId
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

		// Token: 0x06034DA7 RID: 216487 RVA: 0x0071AC38 File Offset: 0x00718E38
		public static Offset<IReignsTriggerGuide> CreateIReignsTriggerGuide(FlatBufferBuilder builder, int GuideId = 0)
		{
			builder.StartTable(1);
			IReignsTriggerGuide.AddGuideId(builder, GuideId);
			return IReignsTriggerGuide.EndIReignsTriggerGuide(builder);
		}

		// Token: 0x06034DA8 RID: 216488 RVA: 0x0071AC4E File Offset: 0x00718E4E
		public static void StartIReignsTriggerGuide(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06034DA9 RID: 216489 RVA: 0x0071AC57 File Offset: 0x00718E57
		public static void AddGuideId(FlatBufferBuilder builder, int guideId)
		{
			builder.AddInt(0, guideId, 0);
		}

		// Token: 0x06034DAA RID: 216490 RVA: 0x0071AC62 File Offset: 0x00718E62
		public static Offset<IReignsTriggerGuide> EndIReignsTriggerGuide(FlatBufferBuilder builder)
		{
			return new Offset<IReignsTriggerGuide>(builder.EndTable());
		}

		// Token: 0x06034DAB RID: 216491 RVA: 0x0071AC70 File Offset: 0x00718E70
		public IReignsTriggerGuideT UnPack()
		{
			IReignsTriggerGuideT reignsTriggerGuideT = new IReignsTriggerGuideT();
			this.UnPackTo(reignsTriggerGuideT);
			return reignsTriggerGuideT;
		}

		// Token: 0x06034DAC RID: 216492 RVA: 0x0071AC8B File Offset: 0x00718E8B
		public void UnPackTo(IReignsTriggerGuideT _o)
		{
			_o.GuideId = this.GuideId;
		}

		// Token: 0x06034DAD RID: 216493 RVA: 0x0071AC9C File Offset: 0x00718E9C
		public static Offset<IReignsTriggerGuide> Pack(FlatBufferBuilder builder, IReignsTriggerGuideT _o)
		{
			if (_o == null)
			{
				return default(Offset<IReignsTriggerGuide>);
			}
			return IReignsTriggerGuide.CreateIReignsTriggerGuide(builder, _o.GuideId);
		}

		// Token: 0x04012799 RID: 75673
		private Table __p;
	}
}
