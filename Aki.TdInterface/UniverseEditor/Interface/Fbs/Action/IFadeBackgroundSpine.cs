using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200677D RID: 26493
	public struct IFadeBackgroundSpine : IFlatbufferObject
	{
		// Token: 0x1700C4A5 RID: 50341
		// (get) Token: 0x0602E173 RID: 188787 RVA: 0x0064BEF2 File Offset: 0x0064A0F2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E174 RID: 188788 RVA: 0x0064BEFF File Offset: 0x0064A0FF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E175 RID: 188789 RVA: 0x0064BF08 File Offset: 0x0064A108
		public static IFadeBackgroundSpine GetRootAsIFadeBackgroundSpine(ByteBuffer _bb)
		{
			return IFadeBackgroundSpine.GetRootAsIFadeBackgroundSpine(_bb, default(IFadeBackgroundSpine));
		}

		// Token: 0x0602E176 RID: 188790 RVA: 0x0064BF24 File Offset: 0x0064A124
		public static IFadeBackgroundSpine GetRootAsIFadeBackgroundSpine(ByteBuffer _bb, IFadeBackgroundSpine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E177 RID: 188791 RVA: 0x0064BF41 File Offset: 0x0064A141
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E178 RID: 188792 RVA: 0x0064BF50 File Offset: 0x0064A150
		public IFadeBackgroundSpine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C4A6 RID: 50342
		// (get) Token: 0x0602E179 RID: 188793 RVA: 0x0064BF60 File Offset: 0x0064A160
		public EFadeBackgroundType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFadeBackgroundType.Spine;
				}
				return (EFadeBackgroundType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C4A7 RID: 50343
		// (get) Token: 0x0602E17A RID: 188794 RVA: 0x0064BF9C File Offset: 0x0064A19C
		public int SpineId
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

		// Token: 0x1700C4A8 RID: 50344
		// (get) Token: 0x0602E17B RID: 188795 RVA: 0x0064BFD8 File Offset: 0x0064A1D8
		public IFadeBackgroundFadeInEffect? FadeInEffect
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IFadeBackgroundFadeInEffect?(default(IFadeBackgroundFadeInEffect).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C4A9 RID: 50345
		// (get) Token: 0x0602E17C RID: 188796 RVA: 0x0064C038 File Offset: 0x0064A238
		public IFadeBackgroundFadeOutEffect? FadeOutEffect
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IFadeBackgroundFadeOutEffect?(default(IFadeBackgroundFadeOutEffect).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602E17D RID: 188797 RVA: 0x0064C096 File Offset: 0x0064A296
		public static Offset<IFadeBackgroundSpine> CreateIFadeBackgroundSpine(FlatBufferBuilder builder, EFadeBackgroundType Type = EFadeBackgroundType.Spine, int SpineId = 0, Offset<IFadeBackgroundFadeInEffect> FadeInEffectOffset = default(Offset<IFadeBackgroundFadeInEffect>), Offset<IFadeBackgroundFadeOutEffect> FadeOutEffectOffset = default(Offset<IFadeBackgroundFadeOutEffect>))
		{
			builder.StartTable(4);
			IFadeBackgroundSpine.AddFadeOutEffect(builder, FadeOutEffectOffset);
			IFadeBackgroundSpine.AddFadeInEffect(builder, FadeInEffectOffset);
			IFadeBackgroundSpine.AddSpineId(builder, SpineId);
			IFadeBackgroundSpine.AddType(builder, Type);
			return IFadeBackgroundSpine.EndIFadeBackgroundSpine(builder);
		}

		// Token: 0x0602E17E RID: 188798 RVA: 0x0064C0C2 File Offset: 0x0064A2C2
		public static void StartIFadeBackgroundSpine(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602E17F RID: 188799 RVA: 0x0064C0CB File Offset: 0x0064A2CB
		public static void AddType(FlatBufferBuilder builder, EFadeBackgroundType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E180 RID: 188800 RVA: 0x0064C0D6 File Offset: 0x0064A2D6
		public static void AddSpineId(FlatBufferBuilder builder, int spineId)
		{
			builder.AddInt(1, spineId, 0);
		}

		// Token: 0x0602E181 RID: 188801 RVA: 0x0064C0E1 File Offset: 0x0064A2E1
		public static void AddFadeInEffect(FlatBufferBuilder builder, Offset<IFadeBackgroundFadeInEffect> fadeInEffectOffset)
		{
			builder.AddOffset(2, fadeInEffectOffset.Value, 0);
		}

		// Token: 0x0602E182 RID: 188802 RVA: 0x0064C0F1 File Offset: 0x0064A2F1
		public static void AddFadeOutEffect(FlatBufferBuilder builder, Offset<IFadeBackgroundFadeOutEffect> fadeOutEffectOffset)
		{
			builder.AddOffset(3, fadeOutEffectOffset.Value, 0);
		}

		// Token: 0x0602E183 RID: 188803 RVA: 0x0064C101 File Offset: 0x0064A301
		public static Offset<IFadeBackgroundSpine> EndIFadeBackgroundSpine(FlatBufferBuilder builder)
		{
			return new Offset<IFadeBackgroundSpine>(builder.EndTable());
		}

		// Token: 0x0602E184 RID: 188804 RVA: 0x0064C110 File Offset: 0x0064A310
		public IFadeBackgroundSpineT UnPack()
		{
			IFadeBackgroundSpineT fadeBackgroundSpineT = new IFadeBackgroundSpineT();
			this.UnPackTo(fadeBackgroundSpineT);
			return fadeBackgroundSpineT;
		}

		// Token: 0x0602E185 RID: 188805 RVA: 0x0064C12C File Offset: 0x0064A32C
		public void UnPackTo(IFadeBackgroundSpineT _o)
		{
			_o.Type = this.Type;
			_o.SpineId = this.SpineId;
			_o.FadeInEffect = ((this.FadeInEffect != null) ? this.FadeInEffect.Value.UnPack() : null);
			_o.FadeOutEffect = ((this.FadeOutEffect != null) ? this.FadeOutEffect.Value.UnPack() : null);
		}

		// Token: 0x0602E186 RID: 188806 RVA: 0x0064C1B0 File Offset: 0x0064A3B0
		public static Offset<IFadeBackgroundSpine> Pack(FlatBufferBuilder builder, IFadeBackgroundSpineT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFadeBackgroundSpine>);
			}
			Offset<IFadeBackgroundFadeInEffect> fadeInEffectOffset = (_o.FadeInEffect == null) ? default(Offset<IFadeBackgroundFadeInEffect>) : IFadeBackgroundFadeInEffect.Pack(builder, _o.FadeInEffect);
			Offset<IFadeBackgroundFadeOutEffect> fadeOutEffectOffset = (_o.FadeOutEffect == null) ? default(Offset<IFadeBackgroundFadeOutEffect>) : IFadeBackgroundFadeOutEffect.Pack(builder, _o.FadeOutEffect);
			return IFadeBackgroundSpine.CreateIFadeBackgroundSpine(builder, _o.Type, _o.SpineId, fadeInEffectOffset, fadeOutEffectOffset);
		}

		// Token: 0x04010E7B RID: 69243
		private Table __p;
	}
}
