using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064A0 RID: 25760
	public struct IUnlockGeographicalAtlasV2 : IFlatbufferObject
	{
		// Token: 0x1700BE0F RID: 48655
		// (get) Token: 0x0602BC9B RID: 179355 RVA: 0x005F4DD8 File Offset: 0x005F2FD8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BC9C RID: 179356 RVA: 0x005F4DE5 File Offset: 0x005F2FE5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BC9D RID: 179357 RVA: 0x005F4DEC File Offset: 0x005F2FEC
		public static IUnlockGeographicalAtlasV2 GetRootAsIUnlockGeographicalAtlasV2(ByteBuffer _bb)
		{
			return IUnlockGeographicalAtlasV2.GetRootAsIUnlockGeographicalAtlasV2(_bb, default(IUnlockGeographicalAtlasV2));
		}

		// Token: 0x0602BC9E RID: 179358 RVA: 0x005F4E08 File Offset: 0x005F3008
		public static IUnlockGeographicalAtlasV2 GetRootAsIUnlockGeographicalAtlasV2(ByteBuffer _bb, IUnlockGeographicalAtlasV2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BC9F RID: 179359 RVA: 0x005F4E25 File Offset: 0x005F3025
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BCA0 RID: 179360 RVA: 0x005F4E34 File Offset: 0x005F3034
		public IUnlockGeographicalAtlasV2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE10 RID: 48656
		// (get) Token: 0x0602BCA1 RID: 179361 RVA: 0x005F4E44 File Offset: 0x005F3044
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

		// Token: 0x1700BE11 RID: 48657
		// (get) Token: 0x0602BCA2 RID: 179362 RVA: 0x005F4E80 File Offset: 0x005F3080
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

		// Token: 0x0602BCA3 RID: 179363 RVA: 0x005F4EBC File Offset: 0x005F30BC
		public static Offset<IUnlockGeographicalAtlasV2> CreateIUnlockGeographicalAtlasV2(FlatBufferBuilder builder, EUnlockAtlasSystemTypeV2 Type = EUnlockAtlasSystemTypeV2.GeographicalAtlas, int Id = 0)
		{
			builder.StartTable(2);
			IUnlockGeographicalAtlasV2.AddId(builder, Id);
			IUnlockGeographicalAtlasV2.AddType(builder, Type);
			return IUnlockGeographicalAtlasV2.EndIUnlockGeographicalAtlasV2(builder);
		}

		// Token: 0x0602BCA4 RID: 179364 RVA: 0x005F4ED9 File Offset: 0x005F30D9
		public static void StartIUnlockGeographicalAtlasV2(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602BCA5 RID: 179365 RVA: 0x005F4EE2 File Offset: 0x005F30E2
		public static void AddType(FlatBufferBuilder builder, EUnlockAtlasSystemTypeV2 type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BCA6 RID: 179366 RVA: 0x005F4EED File Offset: 0x005F30ED
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0602BCA7 RID: 179367 RVA: 0x005F4EF8 File Offset: 0x005F30F8
		public static Offset<IUnlockGeographicalAtlasV2> EndIUnlockGeographicalAtlasV2(FlatBufferBuilder builder)
		{
			return new Offset<IUnlockGeographicalAtlasV2>(builder.EndTable());
		}

		// Token: 0x0602BCA8 RID: 179368 RVA: 0x005F4F08 File Offset: 0x005F3108
		public IUnlockGeographicalAtlasV2T UnPack()
		{
			IUnlockGeographicalAtlasV2T unlockGeographicalAtlasV2T = new IUnlockGeographicalAtlasV2T();
			this.UnPackTo(unlockGeographicalAtlasV2T);
			return unlockGeographicalAtlasV2T;
		}

		// Token: 0x0602BCA9 RID: 179369 RVA: 0x005F4F23 File Offset: 0x005F3123
		public void UnPackTo(IUnlockGeographicalAtlasV2T _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0602BCAA RID: 179370 RVA: 0x005F4F40 File Offset: 0x005F3140
		public static Offset<IUnlockGeographicalAtlasV2> Pack(FlatBufferBuilder builder, IUnlockGeographicalAtlasV2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnlockGeographicalAtlasV2>);
			}
			return IUnlockGeographicalAtlasV2.CreateIUnlockGeographicalAtlasV2(builder, _o.Type, _o.Id);
		}

		// Token: 0x040105CE RID: 67022
		private Table __p;
	}
}
