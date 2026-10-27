using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E34 RID: 28212
	public struct IReignsTriggerGuide : IFlatbufferObject
	{
		// Token: 0x1700D23B RID: 53819
		// (get) Token: 0x06031D8A RID: 204170 RVA: 0x006BF205 File Offset: 0x006BD405
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031D8B RID: 204171 RVA: 0x006BF212 File Offset: 0x006BD412
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031D8C RID: 204172 RVA: 0x006BF21C File Offset: 0x006BD41C
		public static IReignsTriggerGuide GetRootAsIReignsTriggerGuide(ByteBuffer _bb)
		{
			return IReignsTriggerGuide.GetRootAsIReignsTriggerGuide(_bb, default(IReignsTriggerGuide));
		}

		// Token: 0x06031D8D RID: 204173 RVA: 0x006BF238 File Offset: 0x006BD438
		public static IReignsTriggerGuide GetRootAsIReignsTriggerGuide(ByteBuffer _bb, IReignsTriggerGuide obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031D8E RID: 204174 RVA: 0x006BF255 File Offset: 0x006BD455
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031D8F RID: 204175 RVA: 0x006BF264 File Offset: 0x006BD464
		public IReignsTriggerGuide __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D23C RID: 53820
		// (get) Token: 0x06031D90 RID: 204176 RVA: 0x006BF274 File Offset: 0x006BD474
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

		// Token: 0x06031D91 RID: 204177 RVA: 0x006BF2B0 File Offset: 0x006BD4B0
		public static Offset<IReignsTriggerGuide> CreateIReignsTriggerGuide(FlatBufferBuilder builder, int GuideId = 0)
		{
			builder.StartTable(1);
			IReignsTriggerGuide.AddGuideId(builder, GuideId);
			return IReignsTriggerGuide.EndIReignsTriggerGuide(builder);
		}

		// Token: 0x06031D92 RID: 204178 RVA: 0x006BF2C6 File Offset: 0x006BD4C6
		public static void StartIReignsTriggerGuide(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031D93 RID: 204179 RVA: 0x006BF2CF File Offset: 0x006BD4CF
		public static void AddGuideId(FlatBufferBuilder builder, int guideId)
		{
			builder.AddInt(0, guideId, 0);
		}

		// Token: 0x06031D94 RID: 204180 RVA: 0x006BF2DA File Offset: 0x006BD4DA
		public static Offset<IReignsTriggerGuide> EndIReignsTriggerGuide(FlatBufferBuilder builder)
		{
			return new Offset<IReignsTriggerGuide>(builder.EndTable());
		}

		// Token: 0x06031D95 RID: 204181 RVA: 0x006BF2E8 File Offset: 0x006BD4E8
		public IReignsTriggerGuideT UnPack()
		{
			IReignsTriggerGuideT reignsTriggerGuideT = new IReignsTriggerGuideT();
			this.UnPackTo(reignsTriggerGuideT);
			return reignsTriggerGuideT;
		}

		// Token: 0x06031D96 RID: 204182 RVA: 0x006BF303 File Offset: 0x006BD503
		public void UnPackTo(IReignsTriggerGuideT _o)
		{
			_o.GuideId = this.GuideId;
		}

		// Token: 0x06031D97 RID: 204183 RVA: 0x006BF314 File Offset: 0x006BD514
		public static Offset<IReignsTriggerGuide> Pack(FlatBufferBuilder builder, IReignsTriggerGuideT _o)
		{
			if (_o == null)
			{
				return default(Offset<IReignsTriggerGuide>);
			}
			return IReignsTriggerGuide.CreateIReignsTriggerGuide(builder, _o.GuideId);
		}

		// Token: 0x04011819 RID: 71705
		private Table __p;
	}
}
