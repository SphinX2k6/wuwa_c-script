using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DCA RID: 32202
	public struct IVisualNovelPlayScreenEffectCustom : IFlatbufferObject
	{
		// Token: 0x1700F13B RID: 61755
		// (get) Token: 0x0603A30B RID: 238347 RVA: 0x007D804A File Offset: 0x007D624A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A30C RID: 238348 RVA: 0x007D8057 File Offset: 0x007D6257
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A30D RID: 238349 RVA: 0x007D8060 File Offset: 0x007D6260
		public static IVisualNovelPlayScreenEffectCustom GetRootAsIVisualNovelPlayScreenEffectCustom(ByteBuffer _bb)
		{
			return IVisualNovelPlayScreenEffectCustom.GetRootAsIVisualNovelPlayScreenEffectCustom(_bb, default(IVisualNovelPlayScreenEffectCustom));
		}

		// Token: 0x0603A30E RID: 238350 RVA: 0x007D807C File Offset: 0x007D627C
		public static IVisualNovelPlayScreenEffectCustom GetRootAsIVisualNovelPlayScreenEffectCustom(ByteBuffer _bb, IVisualNovelPlayScreenEffectCustom obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A30F RID: 238351 RVA: 0x007D8099 File Offset: 0x007D6299
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A310 RID: 238352 RVA: 0x007D80A8 File Offset: 0x007D62A8
		public IVisualNovelPlayScreenEffectCustom __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F13C RID: 61756
		// (get) Token: 0x0603A311 RID: 238353 RVA: 0x007D80B8 File Offset: 0x007D62B8
		public EVisualNovelScreenEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelScreenEffectType.OneShot;
				}
				return (EVisualNovelScreenEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700F13D RID: 61757
		// (get) Token: 0x0603A312 RID: 238354 RVA: 0x007D80F4 File Offset: 0x007D62F4
		public EVisualNovelScreenEffectCustomType CustomType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EVisualNovelScreenEffectCustomType.BurstEye;
				}
				return (EVisualNovelScreenEffectCustomType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603A313 RID: 238355 RVA: 0x007D8130 File Offset: 0x007D6330
		public static Offset<IVisualNovelPlayScreenEffectCustom> CreateIVisualNovelPlayScreenEffectCustom(FlatBufferBuilder builder, EVisualNovelScreenEffectType Type = EVisualNovelScreenEffectType.OneShot, EVisualNovelScreenEffectCustomType CustomType = EVisualNovelScreenEffectCustomType.BurstEye)
		{
			builder.StartTable(2);
			IVisualNovelPlayScreenEffectCustom.AddCustomType(builder, CustomType);
			IVisualNovelPlayScreenEffectCustom.AddType(builder, Type);
			return IVisualNovelPlayScreenEffectCustom.EndIVisualNovelPlayScreenEffectCustom(builder);
		}

		// Token: 0x0603A314 RID: 238356 RVA: 0x007D814D File Offset: 0x007D634D
		public static void StartIVisualNovelPlayScreenEffectCustom(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603A315 RID: 238357 RVA: 0x007D8156 File Offset: 0x007D6356
		public static void AddType(FlatBufferBuilder builder, EVisualNovelScreenEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603A316 RID: 238358 RVA: 0x007D8161 File Offset: 0x007D6361
		public static void AddCustomType(FlatBufferBuilder builder, EVisualNovelScreenEffectCustomType customType)
		{
			builder.AddByte(1, (byte)customType, 0);
		}

		// Token: 0x0603A317 RID: 238359 RVA: 0x007D816C File Offset: 0x007D636C
		public static Offset<IVisualNovelPlayScreenEffectCustom> EndIVisualNovelPlayScreenEffectCustom(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPlayScreenEffectCustom>(builder.EndTable());
		}

		// Token: 0x0603A318 RID: 238360 RVA: 0x007D817C File Offset: 0x007D637C
		public IVisualNovelPlayScreenEffectCustomT UnPack()
		{
			IVisualNovelPlayScreenEffectCustomT visualNovelPlayScreenEffectCustomT = new IVisualNovelPlayScreenEffectCustomT();
			this.UnPackTo(visualNovelPlayScreenEffectCustomT);
			return visualNovelPlayScreenEffectCustomT;
		}

		// Token: 0x0603A319 RID: 238361 RVA: 0x007D8197 File Offset: 0x007D6397
		public void UnPackTo(IVisualNovelPlayScreenEffectCustomT _o)
		{
			_o.Type = this.Type;
			_o.CustomType = this.CustomType;
		}

		// Token: 0x0603A31A RID: 238362 RVA: 0x007D81B4 File Offset: 0x007D63B4
		public static Offset<IVisualNovelPlayScreenEffectCustom> Pack(FlatBufferBuilder builder, IVisualNovelPlayScreenEffectCustomT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelPlayScreenEffectCustom>);
			}
			return IVisualNovelPlayScreenEffectCustom.CreateIVisualNovelPlayScreenEffectCustom(builder, _o.Type, _o.CustomType);
		}

		// Token: 0x04013560 RID: 79200
		private Table __p;
	}
}
