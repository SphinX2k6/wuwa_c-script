using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042AA RID: 17066
	public struct IWordArtResourceType : IFlatbufferObject
	{
		// Token: 0x17007921 RID: 31009
		// (get) Token: 0x06019495 RID: 103573 RVA: 0x003A17B2 File Offset: 0x0039F9B2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019496 RID: 103574 RVA: 0x003A17BF File Offset: 0x0039F9BF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019497 RID: 103575 RVA: 0x003A17C8 File Offset: 0x0039F9C8
		public static IWordArtResourceType GetRootAsIWordArtResourceType(ByteBuffer _bb)
		{
			return IWordArtResourceType.GetRootAsIWordArtResourceType(_bb, default(IWordArtResourceType));
		}

		// Token: 0x06019498 RID: 103576 RVA: 0x003A17E4 File Offset: 0x0039F9E4
		public static IWordArtResourceType GetRootAsIWordArtResourceType(ByteBuffer _bb, IWordArtResourceType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019499 RID: 103577 RVA: 0x003A1801 File Offset: 0x0039FA01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601949A RID: 103578 RVA: 0x003A1810 File Offset: 0x0039FA10
		public IWordArtResourceType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007922 RID: 31010
		// (get) Token: 0x0601949B RID: 103579 RVA: 0x003A1820 File Offset: 0x0039FA20
		public EWordArtResourceType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWordArtResourceType.Default;
				}
				return (EWordArtResourceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601949C RID: 103580 RVA: 0x003A185C File Offset: 0x0039FA5C
		public static Offset<IWordArtResourceType> CreateIWordArtResourceType(FlatBufferBuilder builder, EWordArtResourceType Type = EWordArtResourceType.Default)
		{
			builder.StartTable(1);
			IWordArtResourceType.AddType(builder, Type);
			return IWordArtResourceType.EndIWordArtResourceType(builder);
		}

		// Token: 0x0601949D RID: 103581 RVA: 0x003A1872 File Offset: 0x0039FA72
		public static void StartIWordArtResourceType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601949E RID: 103582 RVA: 0x003A187B File Offset: 0x0039FA7B
		public static void AddType(FlatBufferBuilder builder, EWordArtResourceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601949F RID: 103583 RVA: 0x003A1886 File Offset: 0x0039FA86
		public static Offset<IWordArtResourceType> EndIWordArtResourceType(FlatBufferBuilder builder)
		{
			return new Offset<IWordArtResourceType>(builder.EndTable());
		}

		// Token: 0x060194A0 RID: 103584 RVA: 0x003A1894 File Offset: 0x0039FA94
		public IWordArtResourceTypeT UnPack()
		{
			IWordArtResourceTypeT wordArtResourceTypeT = new IWordArtResourceTypeT();
			this.UnPackTo(wordArtResourceTypeT);
			return wordArtResourceTypeT;
		}

		// Token: 0x060194A1 RID: 103585 RVA: 0x003A18AF File Offset: 0x0039FAAF
		public void UnPackTo(IWordArtResourceTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060194A2 RID: 103586 RVA: 0x003A18C0 File Offset: 0x0039FAC0
		public static Offset<IWordArtResourceType> Pack(FlatBufferBuilder builder, IWordArtResourceTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWordArtResourceType>);
			}
			return IWordArtResourceType.CreateIWordArtResourceType(builder, _o.Type);
		}

		// Token: 0x0400BF4E RID: 48974
		private Table __p;
	}
}
