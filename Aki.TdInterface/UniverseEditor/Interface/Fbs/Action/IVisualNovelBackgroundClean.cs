using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D55 RID: 32085
	public struct IVisualNovelBackgroundClean : IFlatbufferObject
	{
		// Token: 0x1700F015 RID: 61461
		// (get) Token: 0x06039EB0 RID: 237232 RVA: 0x007CFB7C File Offset: 0x007CDD7C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039EB1 RID: 237233 RVA: 0x007CFB89 File Offset: 0x007CDD89
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039EB2 RID: 237234 RVA: 0x007CFB90 File Offset: 0x007CDD90
		public static IVisualNovelBackgroundClean GetRootAsIVisualNovelBackgroundClean(ByteBuffer _bb)
		{
			return IVisualNovelBackgroundClean.GetRootAsIVisualNovelBackgroundClean(_bb, default(IVisualNovelBackgroundClean));
		}

		// Token: 0x06039EB3 RID: 237235 RVA: 0x007CFBAC File Offset: 0x007CDDAC
		public static IVisualNovelBackgroundClean GetRootAsIVisualNovelBackgroundClean(ByteBuffer _bb, IVisualNovelBackgroundClean obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039EB4 RID: 237236 RVA: 0x007CFBC9 File Offset: 0x007CDDC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039EB5 RID: 237237 RVA: 0x007CFBD8 File Offset: 0x007CDDD8
		public IVisualNovelBackgroundClean __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F016 RID: 61462
		// (get) Token: 0x06039EB6 RID: 237238 RVA: 0x007CFBE8 File Offset: 0x007CDDE8
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

		// Token: 0x06039EB7 RID: 237239 RVA: 0x007CFC24 File Offset: 0x007CDE24
		public static Offset<IVisualNovelBackgroundClean> CreateIVisualNovelBackgroundClean(FlatBufferBuilder builder, EVisualNovelBackgroundType Type = EVisualNovelBackgroundType.Load)
		{
			builder.StartTable(1);
			IVisualNovelBackgroundClean.AddType(builder, Type);
			return IVisualNovelBackgroundClean.EndIVisualNovelBackgroundClean(builder);
		}

		// Token: 0x06039EB8 RID: 237240 RVA: 0x007CFC3A File Offset: 0x007CDE3A
		public static void StartIVisualNovelBackgroundClean(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06039EB9 RID: 237241 RVA: 0x007CFC43 File Offset: 0x007CDE43
		public static void AddType(FlatBufferBuilder builder, EVisualNovelBackgroundType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039EBA RID: 237242 RVA: 0x007CFC4E File Offset: 0x007CDE4E
		public static Offset<IVisualNovelBackgroundClean> EndIVisualNovelBackgroundClean(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelBackgroundClean>(builder.EndTable());
		}

		// Token: 0x06039EBB RID: 237243 RVA: 0x007CFC5C File Offset: 0x007CDE5C
		public IVisualNovelBackgroundCleanT UnPack()
		{
			IVisualNovelBackgroundCleanT visualNovelBackgroundCleanT = new IVisualNovelBackgroundCleanT();
			this.UnPackTo(visualNovelBackgroundCleanT);
			return visualNovelBackgroundCleanT;
		}

		// Token: 0x06039EBC RID: 237244 RVA: 0x007CFC77 File Offset: 0x007CDE77
		public void UnPackTo(IVisualNovelBackgroundCleanT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06039EBD RID: 237245 RVA: 0x007CFC88 File Offset: 0x007CDE88
		public static Offset<IVisualNovelBackgroundClean> Pack(FlatBufferBuilder builder, IVisualNovelBackgroundCleanT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelBackgroundClean>);
			}
			return IVisualNovelBackgroundClean.CreateIVisualNovelBackgroundClean(builder, _o.Type);
		}

		// Token: 0x0401348D RID: 78989
		private Table __p;
	}
}
