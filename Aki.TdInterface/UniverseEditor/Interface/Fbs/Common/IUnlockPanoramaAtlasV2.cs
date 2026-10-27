using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E66 RID: 24166
	public struct IUnlockPanoramaAtlasV2 : IFlatbufferObject
	{
		// Token: 0x1700B4B0 RID: 46256
		// (get) Token: 0x0602962B RID: 169515 RVA: 0x005AC32E File Offset: 0x005AA52E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602962C RID: 169516 RVA: 0x005AC33B File Offset: 0x005AA53B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602962D RID: 169517 RVA: 0x005AC344 File Offset: 0x005AA544
		public static IUnlockPanoramaAtlasV2 GetRootAsIUnlockPanoramaAtlasV2(ByteBuffer _bb)
		{
			return IUnlockPanoramaAtlasV2.GetRootAsIUnlockPanoramaAtlasV2(_bb, default(IUnlockPanoramaAtlasV2));
		}

		// Token: 0x0602962E RID: 169518 RVA: 0x005AC360 File Offset: 0x005AA560
		public static IUnlockPanoramaAtlasV2 GetRootAsIUnlockPanoramaAtlasV2(ByteBuffer _bb, IUnlockPanoramaAtlasV2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602962F RID: 169519 RVA: 0x005AC37D File Offset: 0x005AA57D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029630 RID: 169520 RVA: 0x005AC38C File Offset: 0x005AA58C
		public IUnlockPanoramaAtlasV2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B4B1 RID: 46257
		// (get) Token: 0x06029631 RID: 169521 RVA: 0x005AC39C File Offset: 0x005AA59C
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

		// Token: 0x1700B4B2 RID: 46258
		// (get) Token: 0x06029632 RID: 169522 RVA: 0x005AC3D8 File Offset: 0x005AA5D8
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

		// Token: 0x06029633 RID: 169523 RVA: 0x005AC414 File Offset: 0x005AA614
		public static Offset<IUnlockPanoramaAtlasV2> CreateIUnlockPanoramaAtlasV2(FlatBufferBuilder builder, EUnlockAtlasSystemTypeV2 Type = EUnlockAtlasSystemTypeV2.GeographicalAtlas, int Id = 0)
		{
			builder.StartTable(2);
			IUnlockPanoramaAtlasV2.AddId(builder, Id);
			IUnlockPanoramaAtlasV2.AddType(builder, Type);
			return IUnlockPanoramaAtlasV2.EndIUnlockPanoramaAtlasV2(builder);
		}

		// Token: 0x06029634 RID: 169524 RVA: 0x005AC431 File Offset: 0x005AA631
		public static void StartIUnlockPanoramaAtlasV2(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06029635 RID: 169525 RVA: 0x005AC43A File Offset: 0x005AA63A
		public static void AddType(FlatBufferBuilder builder, EUnlockAtlasSystemTypeV2 type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029636 RID: 169526 RVA: 0x005AC445 File Offset: 0x005AA645
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06029637 RID: 169527 RVA: 0x005AC450 File Offset: 0x005AA650
		public static Offset<IUnlockPanoramaAtlasV2> EndIUnlockPanoramaAtlasV2(FlatBufferBuilder builder)
		{
			return new Offset<IUnlockPanoramaAtlasV2>(builder.EndTable());
		}

		// Token: 0x06029638 RID: 169528 RVA: 0x005AC460 File Offset: 0x005AA660
		public IUnlockPanoramaAtlasV2T UnPack()
		{
			IUnlockPanoramaAtlasV2T unlockPanoramaAtlasV2T = new IUnlockPanoramaAtlasV2T();
			this.UnPackTo(unlockPanoramaAtlasV2T);
			return unlockPanoramaAtlasV2T;
		}

		// Token: 0x06029639 RID: 169529 RVA: 0x005AC47B File Offset: 0x005AA67B
		public void UnPackTo(IUnlockPanoramaAtlasV2T _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0602963A RID: 169530 RVA: 0x005AC498 File Offset: 0x005AA698
		public static Offset<IUnlockPanoramaAtlasV2> Pack(FlatBufferBuilder builder, IUnlockPanoramaAtlasV2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnlockPanoramaAtlasV2>);
			}
			return IUnlockPanoramaAtlasV2.CreateIUnlockPanoramaAtlasV2(builder, _o.Type, _o.Id);
		}

		// Token: 0x0400F877 RID: 63607
		private Table __p;
	}
}
