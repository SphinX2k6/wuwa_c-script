using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E63 RID: 24163
	public struct IUnlockNounAtlasV2 : IFlatbufferObject
	{
		// Token: 0x1700B4AB RID: 46251
		// (get) Token: 0x06029615 RID: 169493 RVA: 0x005AC12E File Offset: 0x005AA32E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029616 RID: 169494 RVA: 0x005AC13B File Offset: 0x005AA33B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029617 RID: 169495 RVA: 0x005AC144 File Offset: 0x005AA344
		public static IUnlockNounAtlasV2 GetRootAsIUnlockNounAtlasV2(ByteBuffer _bb)
		{
			return IUnlockNounAtlasV2.GetRootAsIUnlockNounAtlasV2(_bb, default(IUnlockNounAtlasV2));
		}

		// Token: 0x06029618 RID: 169496 RVA: 0x005AC160 File Offset: 0x005AA360
		public static IUnlockNounAtlasV2 GetRootAsIUnlockNounAtlasV2(ByteBuffer _bb, IUnlockNounAtlasV2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029619 RID: 169497 RVA: 0x005AC17D File Offset: 0x005AA37D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602961A RID: 169498 RVA: 0x005AC18C File Offset: 0x005AA38C
		public IUnlockNounAtlasV2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B4AC RID: 46252
		// (get) Token: 0x0602961B RID: 169499 RVA: 0x005AC19C File Offset: 0x005AA39C
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

		// Token: 0x1700B4AD RID: 46253
		// (get) Token: 0x0602961C RID: 169500 RVA: 0x005AC1D8 File Offset: 0x005AA3D8
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

		// Token: 0x0602961D RID: 169501 RVA: 0x005AC214 File Offset: 0x005AA414
		public static Offset<IUnlockNounAtlasV2> CreateIUnlockNounAtlasV2(FlatBufferBuilder builder, EUnlockAtlasSystemTypeV2 Type = EUnlockAtlasSystemTypeV2.GeographicalAtlas, int Id = 0)
		{
			builder.StartTable(2);
			IUnlockNounAtlasV2.AddId(builder, Id);
			IUnlockNounAtlasV2.AddType(builder, Type);
			return IUnlockNounAtlasV2.EndIUnlockNounAtlasV2(builder);
		}

		// Token: 0x0602961E RID: 169502 RVA: 0x005AC231 File Offset: 0x005AA431
		public static void StartIUnlockNounAtlasV2(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602961F RID: 169503 RVA: 0x005AC23A File Offset: 0x005AA43A
		public static void AddType(FlatBufferBuilder builder, EUnlockAtlasSystemTypeV2 type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029620 RID: 169504 RVA: 0x005AC245 File Offset: 0x005AA445
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06029621 RID: 169505 RVA: 0x005AC250 File Offset: 0x005AA450
		public static Offset<IUnlockNounAtlasV2> EndIUnlockNounAtlasV2(FlatBufferBuilder builder)
		{
			return new Offset<IUnlockNounAtlasV2>(builder.EndTable());
		}

		// Token: 0x06029622 RID: 169506 RVA: 0x005AC260 File Offset: 0x005AA460
		public IUnlockNounAtlasV2T UnPack()
		{
			IUnlockNounAtlasV2T unlockNounAtlasV2T = new IUnlockNounAtlasV2T();
			this.UnPackTo(unlockNounAtlasV2T);
			return unlockNounAtlasV2T;
		}

		// Token: 0x06029623 RID: 169507 RVA: 0x005AC27B File Offset: 0x005AA47B
		public void UnPackTo(IUnlockNounAtlasV2T _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x06029624 RID: 169508 RVA: 0x005AC298 File Offset: 0x005AA498
		public static Offset<IUnlockNounAtlasV2> Pack(FlatBufferBuilder builder, IUnlockNounAtlasV2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnlockNounAtlasV2>);
			}
			return IUnlockNounAtlasV2.CreateIUnlockNounAtlasV2(builder, _o.Type, _o.Id);
		}

		// Token: 0x0400F874 RID: 63604
		private Table __p;
	}
}
