using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200649A RID: 25754
	public struct IUnlockAtlasSystemTypeV2 : IFlatbufferObject
	{
		// Token: 0x1700BE0A RID: 48650
		// (get) Token: 0x0602BC77 RID: 179319 RVA: 0x005F4A98 File Offset: 0x005F2C98
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BC78 RID: 179320 RVA: 0x005F4AA5 File Offset: 0x005F2CA5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BC79 RID: 179321 RVA: 0x005F4AAC File Offset: 0x005F2CAC
		public static IUnlockAtlasSystemTypeV2 GetRootAsIUnlockAtlasSystemTypeV2(ByteBuffer _bb)
		{
			return IUnlockAtlasSystemTypeV2.GetRootAsIUnlockAtlasSystemTypeV2(_bb, default(IUnlockAtlasSystemTypeV2));
		}

		// Token: 0x0602BC7A RID: 179322 RVA: 0x005F4AC8 File Offset: 0x005F2CC8
		public static IUnlockAtlasSystemTypeV2 GetRootAsIUnlockAtlasSystemTypeV2(ByteBuffer _bb, IUnlockAtlasSystemTypeV2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BC7B RID: 179323 RVA: 0x005F4AE5 File Offset: 0x005F2CE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BC7C RID: 179324 RVA: 0x005F4AF4 File Offset: 0x005F2CF4
		public IUnlockAtlasSystemTypeV2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE0B RID: 48651
		// (get) Token: 0x0602BC7D RID: 179325 RVA: 0x005F4B04 File Offset: 0x005F2D04
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

		// Token: 0x0602BC7E RID: 179326 RVA: 0x005F4B40 File Offset: 0x005F2D40
		public static Offset<IUnlockAtlasSystemTypeV2> CreateIUnlockAtlasSystemTypeV2(FlatBufferBuilder builder, EUnlockAtlasSystemTypeV2 Type = EUnlockAtlasSystemTypeV2.GeographicalAtlas)
		{
			builder.StartTable(1);
			IUnlockAtlasSystemTypeV2.AddType(builder, Type);
			return IUnlockAtlasSystemTypeV2.EndIUnlockAtlasSystemTypeV2(builder);
		}

		// Token: 0x0602BC7F RID: 179327 RVA: 0x005F4B56 File Offset: 0x005F2D56
		public static void StartIUnlockAtlasSystemTypeV2(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602BC80 RID: 179328 RVA: 0x005F4B5F File Offset: 0x005F2D5F
		public static void AddType(FlatBufferBuilder builder, EUnlockAtlasSystemTypeV2 type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BC81 RID: 179329 RVA: 0x005F4B6A File Offset: 0x005F2D6A
		public static Offset<IUnlockAtlasSystemTypeV2> EndIUnlockAtlasSystemTypeV2(FlatBufferBuilder builder)
		{
			return new Offset<IUnlockAtlasSystemTypeV2>(builder.EndTable());
		}

		// Token: 0x0602BC82 RID: 179330 RVA: 0x005F4B78 File Offset: 0x005F2D78
		public IUnlockAtlasSystemTypeV2T UnPack()
		{
			IUnlockAtlasSystemTypeV2T unlockAtlasSystemTypeV2T = new IUnlockAtlasSystemTypeV2T();
			this.UnPackTo(unlockAtlasSystemTypeV2T);
			return unlockAtlasSystemTypeV2T;
		}

		// Token: 0x0602BC83 RID: 179331 RVA: 0x005F4B93 File Offset: 0x005F2D93
		public void UnPackTo(IUnlockAtlasSystemTypeV2T _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602BC84 RID: 179332 RVA: 0x005F4BA4 File Offset: 0x005F2DA4
		public static Offset<IUnlockAtlasSystemTypeV2> Pack(FlatBufferBuilder builder, IUnlockAtlasSystemTypeV2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnlockAtlasSystemTypeV2>);
			}
			return IUnlockAtlasSystemTypeV2.CreateIUnlockAtlasSystemTypeV2(builder, _o.Type);
		}

		// Token: 0x040105C3 RID: 67011
		private Table __p;
	}
}
