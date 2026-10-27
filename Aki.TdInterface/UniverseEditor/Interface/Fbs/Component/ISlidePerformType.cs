using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200592F RID: 22831
	public struct ISlidePerformType : IFlatbufferObject
	{
		// Token: 0x1700AB58 RID: 43864
		// (get) Token: 0x06026A04 RID: 158212 RVA: 0x00552086 File Offset: 0x00550286
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026A05 RID: 158213 RVA: 0x00552093 File Offset: 0x00550293
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026A06 RID: 158214 RVA: 0x0055209C File Offset: 0x0055029C
		public static ISlidePerformType GetRootAsISlidePerformType(ByteBuffer _bb)
		{
			return ISlidePerformType.GetRootAsISlidePerformType(_bb, default(ISlidePerformType));
		}

		// Token: 0x06026A07 RID: 158215 RVA: 0x005520B8 File Offset: 0x005502B8
		public static ISlidePerformType GetRootAsISlidePerformType(ByteBuffer _bb, ISlidePerformType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026A08 RID: 158216 RVA: 0x005520D5 File Offset: 0x005502D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026A09 RID: 158217 RVA: 0x005520E4 File Offset: 0x005502E4
		public ISlidePerformType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AB59 RID: 43865
		// (get) Token: 0x06026A0A RID: 158218 RVA: 0x005520F4 File Offset: 0x005502F4
		public ESlidePerformType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESlidePerformType.SlopeSlide;
				}
				return (ESlidePerformType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026A0B RID: 158219 RVA: 0x00552130 File Offset: 0x00550330
		public static Offset<ISlidePerformType> CreateISlidePerformType(FlatBufferBuilder builder, ESlidePerformType Type = ESlidePerformType.SlopeSlide)
		{
			builder.StartTable(1);
			ISlidePerformType.AddType(builder, Type);
			return ISlidePerformType.EndISlidePerformType(builder);
		}

		// Token: 0x06026A0C RID: 158220 RVA: 0x00552146 File Offset: 0x00550346
		public static void StartISlidePerformType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06026A0D RID: 158221 RVA: 0x0055214F File Offset: 0x0055034F
		public static void AddType(FlatBufferBuilder builder, ESlidePerformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026A0E RID: 158222 RVA: 0x0055215A File Offset: 0x0055035A
		public static Offset<ISlidePerformType> EndISlidePerformType(FlatBufferBuilder builder)
		{
			return new Offset<ISlidePerformType>(builder.EndTable());
		}

		// Token: 0x06026A0F RID: 158223 RVA: 0x00552168 File Offset: 0x00550368
		public ISlidePerformTypeT UnPack()
		{
			ISlidePerformTypeT slidePerformTypeT = new ISlidePerformTypeT();
			this.UnPackTo(slidePerformTypeT);
			return slidePerformTypeT;
		}

		// Token: 0x06026A10 RID: 158224 RVA: 0x00552183 File Offset: 0x00550383
		public void UnPackTo(ISlidePerformTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06026A11 RID: 158225 RVA: 0x00552194 File Offset: 0x00550394
		public static Offset<ISlidePerformType> Pack(FlatBufferBuilder builder, ISlidePerformTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISlidePerformType>);
			}
			return ISlidePerformType.CreateISlidePerformType(builder, _o.Type);
		}

		// Token: 0x0400EEF6 RID: 61174
		private Table __p;
	}
}
