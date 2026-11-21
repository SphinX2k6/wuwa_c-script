using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064A9 RID: 25769
	public struct IUnlockPlotPhotoAtlasV2 : IFlatbufferObject
	{
		// Token: 0x1700BE1E RID: 48670
		// (get) Token: 0x0602BCDD RID: 179421 RVA: 0x005F53D6 File Offset: 0x005F35D6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BCDE RID: 179422 RVA: 0x005F53E3 File Offset: 0x005F35E3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BCDF RID: 179423 RVA: 0x005F53EC File Offset: 0x005F35EC
		public static IUnlockPlotPhotoAtlasV2 GetRootAsIUnlockPlotPhotoAtlasV2(ByteBuffer _bb)
		{
			return IUnlockPlotPhotoAtlasV2.GetRootAsIUnlockPlotPhotoAtlasV2(_bb, default(IUnlockPlotPhotoAtlasV2));
		}

		// Token: 0x0602BCE0 RID: 179424 RVA: 0x005F5408 File Offset: 0x005F3608
		public static IUnlockPlotPhotoAtlasV2 GetRootAsIUnlockPlotPhotoAtlasV2(ByteBuffer _bb, IUnlockPlotPhotoAtlasV2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BCE1 RID: 179425 RVA: 0x005F5425 File Offset: 0x005F3625
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BCE2 RID: 179426 RVA: 0x005F5434 File Offset: 0x005F3634
		public IUnlockPlotPhotoAtlasV2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE1F RID: 48671
		// (get) Token: 0x0602BCE3 RID: 179427 RVA: 0x005F5444 File Offset: 0x005F3644
		public EUnlockAtlasSystemTypeV2 Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EUnlockAtlasSystemTypeV2.GeographicalAtlas;
				}
				return (EUnlockAtlasSystemTypeV2)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BE20 RID: 48672
		// (get) Token: 0x0602BCE4 RID: 179428 RVA: 0x005F5480 File Offset: 0x005F3680
		public int Id
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

		// Token: 0x0602BCE5 RID: 179429 RVA: 0x005F54BC File Offset: 0x005F36BC
		public static Offset<IUnlockPlotPhotoAtlasV2> CreateIUnlockPlotPhotoAtlasV2(FlatBufferBuilder builder, EUnlockAtlasSystemTypeV2 Type = EUnlockAtlasSystemTypeV2.GeographicalAtlas, int Id = 0)
		{
			builder.StartTable(2);
			IUnlockPlotPhotoAtlasV2.AddId(builder, Id);
			IUnlockPlotPhotoAtlasV2.AddType(builder, Type);
			return IUnlockPlotPhotoAtlasV2.EndIUnlockPlotPhotoAtlasV2(builder);
		}

		// Token: 0x0602BCE6 RID: 179430 RVA: 0x005F54D9 File Offset: 0x005F36D9
		public static void StartIUnlockPlotPhotoAtlasV2(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602BCE7 RID: 179431 RVA: 0x005F54E2 File Offset: 0x005F36E2
		public static void AddType(FlatBufferBuilder builder, EUnlockAtlasSystemTypeV2 type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BCE8 RID: 179432 RVA: 0x005F54ED File Offset: 0x005F36ED
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0602BCE9 RID: 179433 RVA: 0x005F54F8 File Offset: 0x005F36F8
		public static Offset<IUnlockPlotPhotoAtlasV2> EndIUnlockPlotPhotoAtlasV2(FlatBufferBuilder builder)
		{
			return new Offset<IUnlockPlotPhotoAtlasV2>(builder.EndTable());
		}

		// Token: 0x0602BCEA RID: 179434 RVA: 0x005F5508 File Offset: 0x005F3708
		public IUnlockPlotPhotoAtlasV2T UnPack()
		{
			IUnlockPlotPhotoAtlasV2T unlockPlotPhotoAtlasV2T = new IUnlockPlotPhotoAtlasV2T();
			this.UnPackTo(unlockPlotPhotoAtlasV2T);
			return unlockPlotPhotoAtlasV2T;
		}

		// Token: 0x0602BCEB RID: 179435 RVA: 0x005F5523 File Offset: 0x005F3723
		public void UnPackTo(IUnlockPlotPhotoAtlasV2T _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0602BCEC RID: 179436 RVA: 0x005F5540 File Offset: 0x005F3740
		public static Offset<IUnlockPlotPhotoAtlasV2> Pack(FlatBufferBuilder builder, IUnlockPlotPhotoAtlasV2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnlockPlotPhotoAtlasV2>);
			}
			return IUnlockPlotPhotoAtlasV2.CreateIUnlockPlotPhotoAtlasV2(builder, _o.Type, _o.Id);
		}

		// Token: 0x040105D7 RID: 67031
		private Table __p;
	}
}
