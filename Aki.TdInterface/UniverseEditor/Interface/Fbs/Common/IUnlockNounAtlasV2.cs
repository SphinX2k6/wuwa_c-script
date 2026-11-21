using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064A3 RID: 25763
	public struct IUnlockNounAtlasV2 : IFlatbufferObject
	{
		// Token: 0x1700BE14 RID: 48660
		// (get) Token: 0x0602BCB1 RID: 179377 RVA: 0x005F4FD6 File Offset: 0x005F31D6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BCB2 RID: 179378 RVA: 0x005F4FE3 File Offset: 0x005F31E3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BCB3 RID: 179379 RVA: 0x005F4FEC File Offset: 0x005F31EC
		public static IUnlockNounAtlasV2 GetRootAsIUnlockNounAtlasV2(ByteBuffer _bb)
		{
			return IUnlockNounAtlasV2.GetRootAsIUnlockNounAtlasV2(_bb, default(IUnlockNounAtlasV2));
		}

		// Token: 0x0602BCB4 RID: 179380 RVA: 0x005F5008 File Offset: 0x005F3208
		public static IUnlockNounAtlasV2 GetRootAsIUnlockNounAtlasV2(ByteBuffer _bb, IUnlockNounAtlasV2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BCB5 RID: 179381 RVA: 0x005F5025 File Offset: 0x005F3225
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BCB6 RID: 179382 RVA: 0x005F5034 File Offset: 0x005F3234
		public IUnlockNounAtlasV2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE15 RID: 48661
		// (get) Token: 0x0602BCB7 RID: 179383 RVA: 0x005F5044 File Offset: 0x005F3244
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

		// Token: 0x1700BE16 RID: 48662
		// (get) Token: 0x0602BCB8 RID: 179384 RVA: 0x005F5080 File Offset: 0x005F3280
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

		// Token: 0x0602BCB9 RID: 179385 RVA: 0x005F50BC File Offset: 0x005F32BC
		public static Offset<IUnlockNounAtlasV2> CreateIUnlockNounAtlasV2(FlatBufferBuilder builder, EUnlockAtlasSystemTypeV2 Type = EUnlockAtlasSystemTypeV2.GeographicalAtlas, int Id = 0)
		{
			builder.StartTable(2);
			IUnlockNounAtlasV2.AddId(builder, Id);
			IUnlockNounAtlasV2.AddType(builder, Type);
			return IUnlockNounAtlasV2.EndIUnlockNounAtlasV2(builder);
		}

		// Token: 0x0602BCBA RID: 179386 RVA: 0x005F50D9 File Offset: 0x005F32D9
		public static void StartIUnlockNounAtlasV2(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602BCBB RID: 179387 RVA: 0x005F50E2 File Offset: 0x005F32E2
		public static void AddType(FlatBufferBuilder builder, EUnlockAtlasSystemTypeV2 type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BCBC RID: 179388 RVA: 0x005F50ED File Offset: 0x005F32ED
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0602BCBD RID: 179389 RVA: 0x005F50F8 File Offset: 0x005F32F8
		public static Offset<IUnlockNounAtlasV2> EndIUnlockNounAtlasV2(FlatBufferBuilder builder)
		{
			return new Offset<IUnlockNounAtlasV2>(builder.EndTable());
		}

		// Token: 0x0602BCBE RID: 179390 RVA: 0x005F5108 File Offset: 0x005F3308
		public IUnlockNounAtlasV2T UnPack()
		{
			IUnlockNounAtlasV2T unlockNounAtlasV2T = new IUnlockNounAtlasV2T();
			this.UnPackTo(unlockNounAtlasV2T);
			return unlockNounAtlasV2T;
		}

		// Token: 0x0602BCBF RID: 179391 RVA: 0x005F5123 File Offset: 0x005F3323
		public void UnPackTo(IUnlockNounAtlasV2T _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0602BCC0 RID: 179392 RVA: 0x005F5140 File Offset: 0x005F3340
		public static Offset<IUnlockNounAtlasV2> Pack(FlatBufferBuilder builder, IUnlockNounAtlasV2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnlockNounAtlasV2>);
			}
			return IUnlockNounAtlasV2.CreateIUnlockNounAtlasV2(builder, _o.Type, _o.Id);
		}

		// Token: 0x040105D1 RID: 67025
		private Table __p;
	}
}
