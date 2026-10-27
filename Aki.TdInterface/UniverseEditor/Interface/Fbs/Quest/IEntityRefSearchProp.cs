using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E0C RID: 15884
	public struct IEntityRefSearchProp : IFlatbufferObject
	{
		// Token: 0x17006DC7 RID: 28103
		// (get) Token: 0x0601639A RID: 91034 RVA: 0x003357AC File Offset: 0x003339AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601639B RID: 91035 RVA: 0x003357B9 File Offset: 0x003339B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601639C RID: 91036 RVA: 0x003357C0 File Offset: 0x003339C0
		public static IEntityRefSearchProp GetRootAsIEntityRefSearchProp(ByteBuffer _bb)
		{
			return IEntityRefSearchProp.GetRootAsIEntityRefSearchProp(_bb, default(IEntityRefSearchProp));
		}

		// Token: 0x0601639D RID: 91037 RVA: 0x003357DC File Offset: 0x003339DC
		public static IEntityRefSearchProp GetRootAsIEntityRefSearchProp(ByteBuffer _bb, IEntityRefSearchProp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601639E RID: 91038 RVA: 0x003357F9 File Offset: 0x003339F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601639F RID: 91039 RVA: 0x00335808 File Offset: 0x00333A08
		public IEntityRefSearchProp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006DC8 RID: 28104
		// (get) Token: 0x060163A0 RID: 91040 RVA: 0x00335818 File Offset: 0x00333A18
		public string SearchText
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060163A1 RID: 91041 RVA: 0x0033584F File Offset: 0x00333A4F
		public Span<byte> GetSearchTextBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060163A2 RID: 91042 RVA: 0x0033585E File Offset: 0x00333A5E
		public byte[] GetSearchTextArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17006DC9 RID: 28105
		// (get) Token: 0x060163A3 RID: 91043 RVA: 0x0033586C File Offset: 0x00333A6C
		public int ResultCount
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

		// Token: 0x17006DCA RID: 28106
		// (get) Token: 0x060163A4 RID: 91044 RVA: 0x003358A8 File Offset: 0x00333AA8
		public int ResultIndex
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006DCB RID: 28107
		// (get) Token: 0x060163A5 RID: 91045 RVA: 0x003358E4 File Offset: 0x00333AE4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060163A6 RID: 91046 RVA: 0x00335921 File Offset: 0x00333B21
		public static Offset<IEntityRefSearchProp> CreateIEntityRefSearchProp(FlatBufferBuilder builder, StringOffset SearchTextOffset = default(StringOffset), int ResultCount = 0, int ResultIndex = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IEntityRefSearchProp.AddResultIndex(builder, ResultIndex);
			IEntityRefSearchProp.AddResultCount(builder, ResultCount);
			IEntityRefSearchProp.AddSearchText(builder, SearchTextOffset);
			IEntityRefSearchProp.AddNullMask(builder, NullMask);
			return IEntityRefSearchProp.EndIEntityRefSearchProp(builder);
		}

		// Token: 0x060163A7 RID: 91047 RVA: 0x0033594D File Offset: 0x00333B4D
		public static void StartIEntityRefSearchProp(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060163A8 RID: 91048 RVA: 0x00335956 File Offset: 0x00333B56
		public static void AddSearchText(FlatBufferBuilder builder, StringOffset searchTextOffset)
		{
			builder.AddOffset(0, searchTextOffset.Value, 0);
		}

		// Token: 0x060163A9 RID: 91049 RVA: 0x00335966 File Offset: 0x00333B66
		public static void AddResultCount(FlatBufferBuilder builder, int resultCount)
		{
			builder.AddInt(1, resultCount, 0);
		}

		// Token: 0x060163AA RID: 91050 RVA: 0x00335971 File Offset: 0x00333B71
		public static void AddResultIndex(FlatBufferBuilder builder, int resultIndex)
		{
			builder.AddInt(2, resultIndex, 0);
		}

		// Token: 0x060163AB RID: 91051 RVA: 0x0033597C File Offset: 0x00333B7C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060163AC RID: 91052 RVA: 0x00335987 File Offset: 0x00333B87
		public static Offset<IEntityRefSearchProp> EndIEntityRefSearchProp(FlatBufferBuilder builder)
		{
			return new Offset<IEntityRefSearchProp>(builder.EndTable());
		}

		// Token: 0x060163AD RID: 91053 RVA: 0x00335994 File Offset: 0x00333B94
		public IEntityRefSearchPropT UnPack()
		{
			IEntityRefSearchPropT entityRefSearchPropT = new IEntityRefSearchPropT();
			this.UnPackTo(entityRefSearchPropT);
			return entityRefSearchPropT;
		}

		// Token: 0x060163AE RID: 91054 RVA: 0x003359AF File Offset: 0x00333BAF
		public void UnPackTo(IEntityRefSearchPropT _o)
		{
			_o.SearchText = this.SearchText;
			_o.ResultCount = this.ResultCount;
			_o.ResultIndex = this.ResultIndex;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060163AF RID: 91055 RVA: 0x003359E4 File Offset: 0x00333BE4
		public static Offset<IEntityRefSearchProp> Pack(FlatBufferBuilder builder, IEntityRefSearchPropT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityRefSearchProp>);
			}
			StringOffset searchTextOffset = (_o.SearchText == null) ? default(StringOffset) : builder.CreateString(_o.SearchText);
			return IEntityRefSearchProp.CreateIEntityRefSearchProp(builder, searchTextOffset, _o.ResultCount, _o.ResultIndex, _o.NullMask);
		}

		// Token: 0x0400B77E RID: 46974
		private Table __p;
	}
}
