using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E5A RID: 24154
	public struct IUnlockAtlasSystemTypeV2 : IFlatbufferObject
	{
		// Token: 0x1700B4A1 RID: 46241
		// (get) Token: 0x060295DB RID: 169435 RVA: 0x005ABBF0 File Offset: 0x005A9DF0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060295DC RID: 169436 RVA: 0x005ABBFD File Offset: 0x005A9DFD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060295DD RID: 169437 RVA: 0x005ABC04 File Offset: 0x005A9E04
		public static IUnlockAtlasSystemTypeV2 GetRootAsIUnlockAtlasSystemTypeV2(ByteBuffer _bb)
		{
			return IUnlockAtlasSystemTypeV2.GetRootAsIUnlockAtlasSystemTypeV2(_bb, default(IUnlockAtlasSystemTypeV2));
		}

		// Token: 0x060295DE RID: 169438 RVA: 0x005ABC20 File Offset: 0x005A9E20
		public static IUnlockAtlasSystemTypeV2 GetRootAsIUnlockAtlasSystemTypeV2(ByteBuffer _bb, IUnlockAtlasSystemTypeV2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060295DF RID: 169439 RVA: 0x005ABC3D File Offset: 0x005A9E3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060295E0 RID: 169440 RVA: 0x005ABC4C File Offset: 0x005A9E4C
		public IUnlockAtlasSystemTypeV2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B4A2 RID: 46242
		// (get) Token: 0x060295E1 RID: 169441 RVA: 0x005ABC5C File Offset: 0x005A9E5C
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

		// Token: 0x060295E2 RID: 169442 RVA: 0x005ABC98 File Offset: 0x005A9E98
		public static Offset<IUnlockAtlasSystemTypeV2> CreateIUnlockAtlasSystemTypeV2(FlatBufferBuilder builder, EUnlockAtlasSystemTypeV2 Type = EUnlockAtlasSystemTypeV2.GeographicalAtlas)
		{
			builder.StartTable(1);
			IUnlockAtlasSystemTypeV2.AddType(builder, Type);
			return IUnlockAtlasSystemTypeV2.EndIUnlockAtlasSystemTypeV2(builder);
		}

		// Token: 0x060295E3 RID: 169443 RVA: 0x005ABCAE File Offset: 0x005A9EAE
		public static void StartIUnlockAtlasSystemTypeV2(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060295E4 RID: 169444 RVA: 0x005ABCB7 File Offset: 0x005A9EB7
		public static void AddType(FlatBufferBuilder builder, EUnlockAtlasSystemTypeV2 type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060295E5 RID: 169445 RVA: 0x005ABCC2 File Offset: 0x005A9EC2
		public static Offset<IUnlockAtlasSystemTypeV2> EndIUnlockAtlasSystemTypeV2(FlatBufferBuilder builder)
		{
			return new Offset<IUnlockAtlasSystemTypeV2>(builder.EndTable());
		}

		// Token: 0x060295E6 RID: 169446 RVA: 0x005ABCD0 File Offset: 0x005A9ED0
		public IUnlockAtlasSystemTypeV2T UnPack()
		{
			IUnlockAtlasSystemTypeV2T unlockAtlasSystemTypeV2T = new IUnlockAtlasSystemTypeV2T();
			this.UnPackTo(unlockAtlasSystemTypeV2T);
			return unlockAtlasSystemTypeV2T;
		}

		// Token: 0x060295E7 RID: 169447 RVA: 0x005ABCEB File Offset: 0x005A9EEB
		public void UnPackTo(IUnlockAtlasSystemTypeV2T _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060295E8 RID: 169448 RVA: 0x005ABCFC File Offset: 0x005A9EFC
		public static Offset<IUnlockAtlasSystemTypeV2> Pack(FlatBufferBuilder builder, IUnlockAtlasSystemTypeV2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnlockAtlasSystemTypeV2>);
			}
			return IUnlockAtlasSystemTypeV2.CreateIUnlockAtlasSystemTypeV2(builder, _o.Type);
		}

		// Token: 0x0400F866 RID: 63590
		private Table __p;
	}
}
