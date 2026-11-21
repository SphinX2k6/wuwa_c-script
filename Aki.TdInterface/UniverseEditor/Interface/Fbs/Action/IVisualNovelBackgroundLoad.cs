using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D58 RID: 32088
	public struct IVisualNovelBackgroundLoad : IFlatbufferObject
	{
		// Token: 0x1700F018 RID: 61464
		// (get) Token: 0x06039EC2 RID: 237250 RVA: 0x007CFCF1 File Offset: 0x007CDEF1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039EC3 RID: 237251 RVA: 0x007CFCFE File Offset: 0x007CDEFE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039EC4 RID: 237252 RVA: 0x007CFD08 File Offset: 0x007CDF08
		public static IVisualNovelBackgroundLoad GetRootAsIVisualNovelBackgroundLoad(ByteBuffer _bb)
		{
			return IVisualNovelBackgroundLoad.GetRootAsIVisualNovelBackgroundLoad(_bb, default(IVisualNovelBackgroundLoad));
		}

		// Token: 0x06039EC5 RID: 237253 RVA: 0x007CFD24 File Offset: 0x007CDF24
		public static IVisualNovelBackgroundLoad GetRootAsIVisualNovelBackgroundLoad(ByteBuffer _bb, IVisualNovelBackgroundLoad obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039EC6 RID: 237254 RVA: 0x007CFD41 File Offset: 0x007CDF41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039EC7 RID: 237255 RVA: 0x007CFD50 File Offset: 0x007CDF50
		public IVisualNovelBackgroundLoad __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F019 RID: 61465
		// (get) Token: 0x06039EC8 RID: 237256 RVA: 0x007CFD60 File Offset: 0x007CDF60
		public EVisualNovelBackgroundType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelBackgroundType.Load;
				}
				return (EVisualNovelBackgroundType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700F01A RID: 61466
		// (get) Token: 0x06039EC9 RID: 237257 RVA: 0x007CFD9C File Offset: 0x007CDF9C
		public int BackgroundId
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

		// Token: 0x06039ECA RID: 237258 RVA: 0x007CFDD8 File Offset: 0x007CDFD8
		public static Offset<IVisualNovelBackgroundLoad> CreateIVisualNovelBackgroundLoad(FlatBufferBuilder builder, EVisualNovelBackgroundType Type = EVisualNovelBackgroundType.Load, int BackgroundId = 0)
		{
			builder.StartTable(2);
			IVisualNovelBackgroundLoad.AddBackgroundId(builder, BackgroundId);
			IVisualNovelBackgroundLoad.AddType(builder, Type);
			return IVisualNovelBackgroundLoad.EndIVisualNovelBackgroundLoad(builder);
		}

		// Token: 0x06039ECB RID: 237259 RVA: 0x007CFDF5 File Offset: 0x007CDFF5
		public static void StartIVisualNovelBackgroundLoad(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06039ECC RID: 237260 RVA: 0x007CFDFE File Offset: 0x007CDFFE
		public static void AddType(FlatBufferBuilder builder, EVisualNovelBackgroundType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039ECD RID: 237261 RVA: 0x007CFE09 File Offset: 0x007CE009
		public static void AddBackgroundId(FlatBufferBuilder builder, int backgroundId)
		{
			builder.AddInt(1, backgroundId, 0);
		}

		// Token: 0x06039ECE RID: 237262 RVA: 0x007CFE14 File Offset: 0x007CE014
		public static Offset<IVisualNovelBackgroundLoad> EndIVisualNovelBackgroundLoad(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelBackgroundLoad>(builder.EndTable());
		}

		// Token: 0x06039ECF RID: 237263 RVA: 0x007CFE24 File Offset: 0x007CE024
		public IVisualNovelBackgroundLoadT UnPack()
		{
			IVisualNovelBackgroundLoadT visualNovelBackgroundLoadT = new IVisualNovelBackgroundLoadT();
			this.UnPackTo(visualNovelBackgroundLoadT);
			return visualNovelBackgroundLoadT;
		}

		// Token: 0x06039ED0 RID: 237264 RVA: 0x007CFE3F File Offset: 0x007CE03F
		public void UnPackTo(IVisualNovelBackgroundLoadT _o)
		{
			_o.Type = this.Type;
			_o.BackgroundId = this.BackgroundId;
		}

		// Token: 0x06039ED1 RID: 237265 RVA: 0x007CFE5C File Offset: 0x007CE05C
		public static Offset<IVisualNovelBackgroundLoad> Pack(FlatBufferBuilder builder, IVisualNovelBackgroundLoadT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelBackgroundLoad>);
			}
			return IVisualNovelBackgroundLoad.CreateIVisualNovelBackgroundLoad(builder, _o.Type, _o.BackgroundId);
		}

		// Token: 0x0401348F RID: 78991
		private Table __p;
	}
}
