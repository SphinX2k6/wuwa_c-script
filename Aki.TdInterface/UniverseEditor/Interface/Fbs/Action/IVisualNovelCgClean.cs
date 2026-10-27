using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200756B RID: 30059
	public struct IVisualNovelCgClean : IFlatbufferObject
	{
		// Token: 0x1700E3F8 RID: 58360
		// (get) Token: 0x06036AE4 RID: 223972 RVA: 0x0076CF4E File Offset: 0x0076B14E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036AE5 RID: 223973 RVA: 0x0076CF5B File Offset: 0x0076B15B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036AE6 RID: 223974 RVA: 0x0076CF64 File Offset: 0x0076B164
		public static IVisualNovelCgClean GetRootAsIVisualNovelCgClean(ByteBuffer _bb)
		{
			return IVisualNovelCgClean.GetRootAsIVisualNovelCgClean(_bb, default(IVisualNovelCgClean));
		}

		// Token: 0x06036AE7 RID: 223975 RVA: 0x0076CF80 File Offset: 0x0076B180
		public static IVisualNovelCgClean GetRootAsIVisualNovelCgClean(ByteBuffer _bb, IVisualNovelCgClean obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036AE8 RID: 223976 RVA: 0x0076CF9D File Offset: 0x0076B19D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036AE9 RID: 223977 RVA: 0x0076CFAC File Offset: 0x0076B1AC
		public IVisualNovelCgClean __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E3F9 RID: 58361
		// (get) Token: 0x06036AEA RID: 223978 RVA: 0x0076CFBC File Offset: 0x0076B1BC
		public EVisualNovelCgType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelCgType.LoadSpine;
				}
				return (EVisualNovelCgType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036AEB RID: 223979 RVA: 0x0076CFF8 File Offset: 0x0076B1F8
		public static Offset<IVisualNovelCgClean> CreateIVisualNovelCgClean(FlatBufferBuilder builder, EVisualNovelCgType Type = EVisualNovelCgType.LoadSpine)
		{
			builder.StartTable(1);
			IVisualNovelCgClean.AddType(builder, Type);
			return IVisualNovelCgClean.EndIVisualNovelCgClean(builder);
		}

		// Token: 0x06036AEC RID: 223980 RVA: 0x0076D00E File Offset: 0x0076B20E
		public static void StartIVisualNovelCgClean(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036AED RID: 223981 RVA: 0x0076D017 File Offset: 0x0076B217
		public static void AddType(FlatBufferBuilder builder, EVisualNovelCgType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036AEE RID: 223982 RVA: 0x0076D022 File Offset: 0x0076B222
		public static Offset<IVisualNovelCgClean> EndIVisualNovelCgClean(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelCgClean>(builder.EndTable());
		}

		// Token: 0x06036AEF RID: 223983 RVA: 0x0076D030 File Offset: 0x0076B230
		public IVisualNovelCgCleanT UnPack()
		{
			IVisualNovelCgCleanT visualNovelCgCleanT = new IVisualNovelCgCleanT();
			this.UnPackTo(visualNovelCgCleanT);
			return visualNovelCgCleanT;
		}

		// Token: 0x06036AF0 RID: 223984 RVA: 0x0076D04B File Offset: 0x0076B24B
		public void UnPackTo(IVisualNovelCgCleanT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036AF1 RID: 223985 RVA: 0x0076D05C File Offset: 0x0076B25C
		public static Offset<IVisualNovelCgClean> Pack(FlatBufferBuilder builder, IVisualNovelCgCleanT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelCgClean>);
			}
			return IVisualNovelCgClean.CreateIVisualNovelCgClean(builder, _o.Type);
		}

		// Token: 0x0401246B RID: 74859
		private Table __p;
	}
}
