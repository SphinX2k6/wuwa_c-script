using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A1D RID: 23069
	public struct IItemFoundationType : IFlatbufferObject
	{
		// Token: 0x1700A7B3 RID: 42931
		// (get) Token: 0x06025AFE RID: 154366 RVA: 0x0052AA60 File Offset: 0x00528C60
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025AFF RID: 154367 RVA: 0x0052AA6D File Offset: 0x00528C6D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025B00 RID: 154368 RVA: 0x0052AA74 File Offset: 0x00528C74
		public static IItemFoundationType GetRootAsIItemFoundationType(ByteBuffer _bb)
		{
			return IItemFoundationType.GetRootAsIItemFoundationType(_bb, default(IItemFoundationType));
		}

		// Token: 0x06025B01 RID: 154369 RVA: 0x0052AA90 File Offset: 0x00528C90
		public static IItemFoundationType GetRootAsIItemFoundationType(ByteBuffer _bb, IItemFoundationType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025B02 RID: 154370 RVA: 0x0052AAAD File Offset: 0x00528CAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025B03 RID: 154371 RVA: 0x0052AABC File Offset: 0x00528CBC
		public IItemFoundationType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A7B4 RID: 42932
		// (get) Token: 0x06025B04 RID: 154372 RVA: 0x0052AACC File Offset: 0x00528CCC
		public EItemFoundation Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EItemFoundation.CategoryMatching;
				}
				return (EItemFoundation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025B05 RID: 154373 RVA: 0x0052AB08 File Offset: 0x00528D08
		public static Offset<IItemFoundationType> CreateIItemFoundationType(FlatBufferBuilder builder, EItemFoundation Type = EItemFoundation.CategoryMatching)
		{
			builder.StartTable(1);
			IItemFoundationType.AddType(builder, Type);
			return IItemFoundationType.EndIItemFoundationType(builder);
		}

		// Token: 0x06025B06 RID: 154374 RVA: 0x0052AB1E File Offset: 0x00528D1E
		public static void StartIItemFoundationType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06025B07 RID: 154375 RVA: 0x0052AB27 File Offset: 0x00528D27
		public static void AddType(FlatBufferBuilder builder, EItemFoundation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025B08 RID: 154376 RVA: 0x0052AB32 File Offset: 0x00528D32
		public static Offset<IItemFoundationType> EndIItemFoundationType(FlatBufferBuilder builder)
		{
			return new Offset<IItemFoundationType>(builder.EndTable());
		}

		// Token: 0x06025B09 RID: 154377 RVA: 0x0052AB40 File Offset: 0x00528D40
		public IItemFoundationTypeT UnPack()
		{
			IItemFoundationTypeT itemFoundationTypeT = new IItemFoundationTypeT();
			this.UnPackTo(itemFoundationTypeT);
			return itemFoundationTypeT;
		}

		// Token: 0x06025B0A RID: 154378 RVA: 0x0052AB5B File Offset: 0x00528D5B
		public void UnPackTo(IItemFoundationTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06025B0B RID: 154379 RVA: 0x0052AB6C File Offset: 0x00528D6C
		public static Offset<IItemFoundationType> Pack(FlatBufferBuilder builder, IItemFoundationTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IItemFoundationType>);
			}
			return IItemFoundationType.CreateIItemFoundationType(builder, _o.Type);
		}

		// Token: 0x0400F35E RID: 62302
		private Table __p;
	}
}
