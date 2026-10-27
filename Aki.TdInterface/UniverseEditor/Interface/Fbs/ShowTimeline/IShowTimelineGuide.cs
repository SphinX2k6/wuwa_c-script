using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BBC RID: 15292
	public struct IShowTimelineGuide : IFlatbufferObject
	{
		// Token: 0x170068E4 RID: 26852
		// (get) Token: 0x06014FD7 RID: 85975 RVA: 0x0030B4A2 File Offset: 0x003096A2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014FD8 RID: 85976 RVA: 0x0030B4AF File Offset: 0x003096AF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014FD9 RID: 85977 RVA: 0x0030B4B8 File Offset: 0x003096B8
		public static IShowTimelineGuide GetRootAsIShowTimelineGuide(ByteBuffer _bb)
		{
			return IShowTimelineGuide.GetRootAsIShowTimelineGuide(_bb, default(IShowTimelineGuide));
		}

		// Token: 0x06014FDA RID: 85978 RVA: 0x0030B4D4 File Offset: 0x003096D4
		public static IShowTimelineGuide GetRootAsIShowTimelineGuide(ByteBuffer _bb, IShowTimelineGuide obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014FDB RID: 85979 RVA: 0x0030B4F1 File Offset: 0x003096F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014FDC RID: 85980 RVA: 0x0030B500 File Offset: 0x00309700
		public IShowTimelineGuide __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170068E5 RID: 26853
		// (get) Token: 0x06014FDD RID: 85981 RVA: 0x0030B510 File Offset: 0x00309710
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

		// Token: 0x170068E6 RID: 26854
		// (get) Token: 0x06014FDE RID: 85982 RVA: 0x0030B54C File Offset: 0x0030974C
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

		// Token: 0x06014FDF RID: 85983 RVA: 0x0030B588 File Offset: 0x00309788
		public static Offset<IShowTimelineGuide> CreateIShowTimelineGuide(FlatBufferBuilder builder, EShowTimelineType Type = EShowTimelineType.Checkpoint, int GuideStepId = 0)
		{
			builder.StartTable(2);
			IShowTimelineGuide.AddGuideStepId(builder, GuideStepId);
			IShowTimelineGuide.AddType(builder, Type);
			return IShowTimelineGuide.EndIShowTimelineGuide(builder);
		}

		// Token: 0x06014FE0 RID: 85984 RVA: 0x0030B5A5 File Offset: 0x003097A5
		public static void StartIShowTimelineGuide(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06014FE1 RID: 85985 RVA: 0x0030B5AE File Offset: 0x003097AE
		public static void AddType(FlatBufferBuilder builder, EShowTimelineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014FE2 RID: 85986 RVA: 0x0030B5B9 File Offset: 0x003097B9
		public static void AddGuideStepId(FlatBufferBuilder builder, int guideStepId)
		{
			builder.AddInt(1, guideStepId, 0);
		}

		// Token: 0x06014FE3 RID: 85987 RVA: 0x0030B5C4 File Offset: 0x003097C4
		public static Offset<IShowTimelineGuide> EndIShowTimelineGuide(FlatBufferBuilder builder)
		{
			return new Offset<IShowTimelineGuide>(builder.EndTable());
		}

		// Token: 0x06014FE4 RID: 85988 RVA: 0x0030B5D4 File Offset: 0x003097D4
		public IShowTimelineGuideT UnPack()
		{
			IShowTimelineGuideT showTimelineGuideT = new IShowTimelineGuideT();
			this.UnPackTo(showTimelineGuideT);
			return showTimelineGuideT;
		}

		// Token: 0x06014FE5 RID: 85989 RVA: 0x0030B5EF File Offset: 0x003097EF
		public void UnPackTo(IShowTimelineGuideT _o)
		{
			_o.Type = this.Type;
			_o.GuideStepId = this.GuideStepId;
		}

		// Token: 0x06014FE6 RID: 85990 RVA: 0x0030B60C File Offset: 0x0030980C
		public static Offset<IShowTimelineGuide> Pack(FlatBufferBuilder builder, IShowTimelineGuideT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTimelineGuide>);
			}
			return IShowTimelineGuide.CreateIShowTimelineGuide(builder, _o.Type, _o.GuideStepId);
		}

		// Token: 0x0400B144 RID: 45380
		private Table __p;
	}
}
