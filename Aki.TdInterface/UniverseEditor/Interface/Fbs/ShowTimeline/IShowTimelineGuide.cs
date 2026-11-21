using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FC4 RID: 16324
	public struct IShowTimelineGuide : IFlatbufferObject
	{
		// Token: 0x17006E87 RID: 28295
		// (get) Token: 0x060164AF RID: 91311 RVA: 0x00331CFE File Offset: 0x0032FEFE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060164B0 RID: 91312 RVA: 0x00331D0B File Offset: 0x0032FF0B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060164B1 RID: 91313 RVA: 0x00331D14 File Offset: 0x0032FF14
		public static IShowTimelineGuide GetRootAsIShowTimelineGuide(ByteBuffer _bb)
		{
			return IShowTimelineGuide.GetRootAsIShowTimelineGuide(_bb, default(IShowTimelineGuide));
		}

		// Token: 0x060164B2 RID: 91314 RVA: 0x00331D30 File Offset: 0x0032FF30
		public static IShowTimelineGuide GetRootAsIShowTimelineGuide(ByteBuffer _bb, IShowTimelineGuide obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060164B3 RID: 91315 RVA: 0x00331D4D File Offset: 0x0032FF4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060164B4 RID: 91316 RVA: 0x00331D5C File Offset: 0x0032FF5C
		public IShowTimelineGuide __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006E88 RID: 28296
		// (get) Token: 0x060164B5 RID: 91317 RVA: 0x00331D6C File Offset: 0x0032FF6C
		public EShowTimelineType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EShowTimelineType.Checkpoint;
				}
				return (EShowTimelineType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006E89 RID: 28297
		// (get) Token: 0x060164B6 RID: 91318 RVA: 0x00331DA8 File Offset: 0x0032FFA8
		public int GuideStepId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060164B7 RID: 91319 RVA: 0x00331DE4 File Offset: 0x0032FFE4
		public static Offset<IShowTimelineGuide> CreateIShowTimelineGuide(FlatBufferBuilder builder, EShowTimelineType Type = EShowTimelineType.Checkpoint, int GuideStepId = 0)
		{
			builder.StartTable(2);
			IShowTimelineGuide.AddGuideStepId(builder, GuideStepId);
			IShowTimelineGuide.AddType(builder, Type);
			return IShowTimelineGuide.EndIShowTimelineGuide(builder);
		}

		// Token: 0x060164B8 RID: 91320 RVA: 0x00331E01 File Offset: 0x00330001
		public static void StartIShowTimelineGuide(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060164B9 RID: 91321 RVA: 0x00331E0A File Offset: 0x0033000A
		public static void AddType(FlatBufferBuilder builder, EShowTimelineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060164BA RID: 91322 RVA: 0x00331E15 File Offset: 0x00330015
		public static void AddGuideStepId(FlatBufferBuilder builder, int guideStepId)
		{
			builder.AddInt(1, guideStepId, 0);
		}

		// Token: 0x060164BB RID: 91323 RVA: 0x00331E20 File Offset: 0x00330020
		public static Offset<IShowTimelineGuide> EndIShowTimelineGuide(FlatBufferBuilder builder)
		{
			return new Offset<IShowTimelineGuide>(builder.EndTable());
		}

		// Token: 0x060164BC RID: 91324 RVA: 0x00331E30 File Offset: 0x00330030
		public IShowTimelineGuideT UnPack()
		{
			IShowTimelineGuideT showTimelineGuideT = new IShowTimelineGuideT();
			this.UnPackTo(showTimelineGuideT);
			return showTimelineGuideT;
		}

		// Token: 0x060164BD RID: 91325 RVA: 0x00331E4B File Offset: 0x0033004B
		public void UnPackTo(IShowTimelineGuideT _o)
		{
			_o.Type = this.Type;
			_o.GuideStepId = this.GuideStepId;
		}

		// Token: 0x060164BE RID: 91326 RVA: 0x00331E68 File Offset: 0x00330068
		public static Offset<IShowTimelineGuide> Pack(FlatBufferBuilder builder, IShowTimelineGuideT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTimelineGuide>);
			}
			return IShowTimelineGuide.CreateIShowTimelineGuide(builder, _o.Type, _o.GuideStepId);
		}

		// Token: 0x0400BAC3 RID: 47811
		private Table __p;
	}
}
