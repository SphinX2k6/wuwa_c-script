using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064A6 RID: 25766
	public struct IUnlockPanoramaAtlasV2 : IFlatbufferObject
	{
		// Token: 0x1700BE19 RID: 48665
		// (get) Token: 0x0602BCC7 RID: 179399 RVA: 0x005F51D6 File Offset: 0x005F33D6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BCC8 RID: 179400 RVA: 0x005F51E3 File Offset: 0x005F33E3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BCC9 RID: 179401 RVA: 0x005F51EC File Offset: 0x005F33EC
		public static IUnlockPanoramaAtlasV2 GetRootAsIUnlockPanoramaAtlasV2(ByteBuffer _bb)
		{
			return IUnlockPanoramaAtlasV2.GetRootAsIUnlockPanoramaAtlasV2(_bb, default(IUnlockPanoramaAtlasV2));
		}

		// Token: 0x0602BCCA RID: 179402 RVA: 0x005F5208 File Offset: 0x005F3408
		public static IUnlockPanoramaAtlasV2 GetRootAsIUnlockPanoramaAtlasV2(ByteBuffer _bb, IUnlockPanoramaAtlasV2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BCCB RID: 179403 RVA: 0x005F5225 File Offset: 0x005F3425
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BCCC RID: 179404 RVA: 0x005F5234 File Offset: 0x005F3434
		public IUnlockPanoramaAtlasV2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE1A RID: 48666
		// (get) Token: 0x0602BCCD RID: 179405 RVA: 0x005F5244 File Offset: 0x005F3444
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

		// Token: 0x1700BE1B RID: 48667
		// (get) Token: 0x0602BCCE RID: 179406 RVA: 0x005F5280 File Offset: 0x005F3480
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

		// Token: 0x0602BCCF RID: 179407 RVA: 0x005F52BC File Offset: 0x005F34BC
		public static Offset<IUnlockPanoramaAtlasV2> CreateIUnlockPanoramaAtlasV2(FlatBufferBuilder builder, EUnlockAtlasSystemTypeV2 Type = EUnlockAtlasSystemTypeV2.GeographicalAtlas, int Id = 0)
		{
			builder.StartTable(2);
			IUnlockPanoramaAtlasV2.AddId(builder, Id);
			IUnlockPanoramaAtlasV2.AddType(builder, Type);
			return IUnlockPanoramaAtlasV2.EndIUnlockPanoramaAtlasV2(builder);
		}

		// Token: 0x0602BCD0 RID: 179408 RVA: 0x005F52D9 File Offset: 0x005F34D9
		public static void StartIUnlockPanoramaAtlasV2(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602BCD1 RID: 179409 RVA: 0x005F52E2 File Offset: 0x005F34E2
		public static void AddType(FlatBufferBuilder builder, EUnlockAtlasSystemTypeV2 type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BCD2 RID: 179410 RVA: 0x005F52ED File Offset: 0x005F34ED
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0602BCD3 RID: 179411 RVA: 0x005F52F8 File Offset: 0x005F34F8
		public static Offset<IUnlockPanoramaAtlasV2> EndIUnlockPanoramaAtlasV2(FlatBufferBuilder builder)
		{
			return new Offset<IUnlockPanoramaAtlasV2>(builder.EndTable());
		}

		// Token: 0x0602BCD4 RID: 179412 RVA: 0x005F5308 File Offset: 0x005F3508
		public IUnlockPanoramaAtlasV2T UnPack()
		{
			IUnlockPanoramaAtlasV2T unlockPanoramaAtlasV2T = new IUnlockPanoramaAtlasV2T();
			this.UnPackTo(unlockPanoramaAtlasV2T);
			return unlockPanoramaAtlasV2T;
		}

		// Token: 0x0602BCD5 RID: 179413 RVA: 0x005F5323 File Offset: 0x005F3523
		public void UnPackTo(IUnlockPanoramaAtlasV2T _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0602BCD6 RID: 179414 RVA: 0x005F5340 File Offset: 0x005F3540
		public static Offset<IUnlockPanoramaAtlasV2> Pack(FlatBufferBuilder builder, IUnlockPanoramaAtlasV2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnlockPanoramaAtlasV2>);
			}
			return IUnlockPanoramaAtlasV2.CreateIUnlockPanoramaAtlasV2(builder, _o.Type, _o.Id);
		}

		// Token: 0x040105D4 RID: 67028
		private Table __p;
	}
}
