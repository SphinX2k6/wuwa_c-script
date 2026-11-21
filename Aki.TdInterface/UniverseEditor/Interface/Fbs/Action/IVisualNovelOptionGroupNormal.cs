using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D8B RID: 32139
	public struct IVisualNovelOptionGroupNormal : IFlatbufferObject
	{
		// Token: 0x1700F066 RID: 61542
		// (get) Token: 0x0603A030 RID: 237616 RVA: 0x007D2029 File Offset: 0x007D0229
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A031 RID: 237617 RVA: 0x007D2036 File Offset: 0x007D0236
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A032 RID: 237618 RVA: 0x007D2040 File Offset: 0x007D0240
		public static IVisualNovelOptionGroupNormal GetRootAsIVisualNovelOptionGroupNormal(ByteBuffer _bb)
		{
			return IVisualNovelOptionGroupNormal.GetRootAsIVisualNovelOptionGroupNormal(_bb, default(IVisualNovelOptionGroupNormal));
		}

		// Token: 0x0603A033 RID: 237619 RVA: 0x007D205C File Offset: 0x007D025C
		public static IVisualNovelOptionGroupNormal GetRootAsIVisualNovelOptionGroupNormal(ByteBuffer _bb, IVisualNovelOptionGroupNormal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A034 RID: 237620 RVA: 0x007D2079 File Offset: 0x007D0279
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A035 RID: 237621 RVA: 0x007D2088 File Offset: 0x007D0288
		public IVisualNovelOptionGroupNormal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F067 RID: 61543
		// (get) Token: 0x0603A036 RID: 237622 RVA: 0x007D2098 File Offset: 0x007D0298
		public EVisualNovelOptionGroupType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelOptionGroupType.Normal;
				}
				return (EVisualNovelOptionGroupType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603A037 RID: 237623 RVA: 0x007D20D4 File Offset: 0x007D02D4
		public static Offset<IVisualNovelOptionGroupNormal> CreateIVisualNovelOptionGroupNormal(FlatBufferBuilder builder, EVisualNovelOptionGroupType Type = EVisualNovelOptionGroupType.Normal)
		{
			builder.StartTable(1);
			IVisualNovelOptionGroupNormal.AddType(builder, Type);
			return IVisualNovelOptionGroupNormal.EndIVisualNovelOptionGroupNormal(builder);
		}

		// Token: 0x0603A038 RID: 237624 RVA: 0x007D20EA File Offset: 0x007D02EA
		public static void StartIVisualNovelOptionGroupNormal(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603A039 RID: 237625 RVA: 0x007D20F3 File Offset: 0x007D02F3
		public static void AddType(FlatBufferBuilder builder, EVisualNovelOptionGroupType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A03A RID: 237626 RVA: 0x007D20FE File Offset: 0x007D02FE
		public static Offset<IVisualNovelOptionGroupNormal> EndIVisualNovelOptionGroupNormal(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelOptionGroupNormal>(builder.EndTable());
		}

		// Token: 0x0603A03B RID: 237627 RVA: 0x007D210C File Offset: 0x007D030C
		public IVisualNovelOptionGroupNormalT UnPack()
		{
			IVisualNovelOptionGroupNormalT visualNovelOptionGroupNormalT = new IVisualNovelOptionGroupNormalT();
			this.UnPackTo(visualNovelOptionGroupNormalT);
			return visualNovelOptionGroupNormalT;
		}

		// Token: 0x0603A03C RID: 237628 RVA: 0x007D2127 File Offset: 0x007D0327
		public void UnPackTo(IVisualNovelOptionGroupNormalT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603A03D RID: 237629 RVA: 0x007D2138 File Offset: 0x007D0338
		public static Offset<IVisualNovelOptionGroupNormal> Pack(FlatBufferBuilder builder, IVisualNovelOptionGroupNormalT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelOptionGroupNormal>);
			}
			return IVisualNovelOptionGroupNormal.CreateIVisualNovelOptionGroupNormal(builder, _o.Type);
		}

		// Token: 0x040134D1 RID: 79057
		private Table __p;
	}
}
