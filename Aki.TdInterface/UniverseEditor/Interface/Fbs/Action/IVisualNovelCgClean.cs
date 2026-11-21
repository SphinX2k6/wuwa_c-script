using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D61 RID: 32097
	public struct IVisualNovelCgClean : IFlatbufferObject
	{
		// Token: 0x1700F022 RID: 61474
		// (get) Token: 0x06039EFA RID: 237306 RVA: 0x007D01F6 File Offset: 0x007CE3F6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039EFB RID: 237307 RVA: 0x007D0203 File Offset: 0x007CE403
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039EFC RID: 237308 RVA: 0x007D020C File Offset: 0x007CE40C
		public static IVisualNovelCgClean GetRootAsIVisualNovelCgClean(ByteBuffer _bb)
		{
			return IVisualNovelCgClean.GetRootAsIVisualNovelCgClean(_bb, default(IVisualNovelCgClean));
		}

		// Token: 0x06039EFD RID: 237309 RVA: 0x007D0228 File Offset: 0x007CE428
		public static IVisualNovelCgClean GetRootAsIVisualNovelCgClean(ByteBuffer _bb, IVisualNovelCgClean obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039EFE RID: 237310 RVA: 0x007D0245 File Offset: 0x007CE445
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039EFF RID: 237311 RVA: 0x007D0254 File Offset: 0x007CE454
		public IVisualNovelCgClean __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F023 RID: 61475
		// (get) Token: 0x06039F00 RID: 237312 RVA: 0x007D0264 File Offset: 0x007CE464
		public EVisualNovelCgType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelCgType.LoadPrefab;
				}
				return (EVisualNovelCgType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039F01 RID: 237313 RVA: 0x007D02A0 File Offset: 0x007CE4A0
		public static Offset<IVisualNovelCgClean> CreateIVisualNovelCgClean(FlatBufferBuilder builder, EVisualNovelCgType Type = EVisualNovelCgType.LoadPrefab)
		{
			builder.StartTable(1);
			IVisualNovelCgClean.AddType(builder, Type);
			return IVisualNovelCgClean.EndIVisualNovelCgClean(builder);
		}

		// Token: 0x06039F02 RID: 237314 RVA: 0x007D02B6 File Offset: 0x007CE4B6
		public static void StartIVisualNovelCgClean(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06039F03 RID: 237315 RVA: 0x007D02BF File Offset: 0x007CE4BF
		public static void AddType(FlatBufferBuilder builder, EVisualNovelCgType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039F04 RID: 237316 RVA: 0x007D02CA File Offset: 0x007CE4CA
		public static Offset<IVisualNovelCgClean> EndIVisualNovelCgClean(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelCgClean>(builder.EndTable());
		}

		// Token: 0x06039F05 RID: 237317 RVA: 0x007D02D8 File Offset: 0x007CE4D8
		public IVisualNovelCgCleanT UnPack()
		{
			IVisualNovelCgCleanT visualNovelCgCleanT = new IVisualNovelCgCleanT();
			this.UnPackTo(visualNovelCgCleanT);
			return visualNovelCgCleanT;
		}

		// Token: 0x06039F06 RID: 237318 RVA: 0x007D02F3 File Offset: 0x007CE4F3
		public void UnPackTo(IVisualNovelCgCleanT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06039F07 RID: 237319 RVA: 0x007D0304 File Offset: 0x007CE504
		public static Offset<IVisualNovelCgClean> Pack(FlatBufferBuilder builder, IVisualNovelCgCleanT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelCgClean>);
			}
			return IVisualNovelCgClean.CreateIVisualNovelCgClean(builder, _o.Type);
		}

		// Token: 0x0401349C RID: 79004
		private Table __p;
	}
}
