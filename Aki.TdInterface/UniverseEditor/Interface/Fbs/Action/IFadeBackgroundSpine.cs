using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DFD RID: 28157
	public struct IFadeBackgroundSpine : IFlatbufferObject
	{
		// Token: 0x1700CE5B RID: 52827
		// (get) Token: 0x060309B9 RID: 199097 RVA: 0x00699636 File Offset: 0x00697836
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060309BA RID: 199098 RVA: 0x00699643 File Offset: 0x00697843
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060309BB RID: 199099 RVA: 0x0069964C File Offset: 0x0069784C
		public static IFadeBackgroundSpine GetRootAsIFadeBackgroundSpine(ByteBuffer _bb)
		{
			return IFadeBackgroundSpine.GetRootAsIFadeBackgroundSpine(_bb, default(IFadeBackgroundSpine));
		}

		// Token: 0x060309BC RID: 199100 RVA: 0x00699668 File Offset: 0x00697868
		public static IFadeBackgroundSpine GetRootAsIFadeBackgroundSpine(ByteBuffer _bb, IFadeBackgroundSpine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060309BD RID: 199101 RVA: 0x00699685 File Offset: 0x00697885
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060309BE RID: 199102 RVA: 0x00699694 File Offset: 0x00697894
		public IFadeBackgroundSpine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CE5C RID: 52828
		// (get) Token: 0x060309BF RID: 199103 RVA: 0x006996A4 File Offset: 0x006978A4
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

		// Token: 0x1700CE5D RID: 52829
		// (get) Token: 0x060309C0 RID: 199104 RVA: 0x006996E0 File Offset: 0x006978E0
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

		// Token: 0x1700CE5E RID: 52830
		// (get) Token: 0x060309C1 RID: 199105 RVA: 0x0069971C File Offset: 0x0069791C
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

		// Token: 0x1700CE5F RID: 52831
		// (get) Token: 0x060309C2 RID: 199106 RVA: 0x0069977C File Offset: 0x0069797C
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

		// Token: 0x060309C3 RID: 199107 RVA: 0x006997DA File Offset: 0x006979DA
		public static Offset<IFadeBackgroundSpine> CreateIFadeBackgroundSpine(FlatBufferBuilder builder, EFadeBackgroundType Type = EFadeBackgroundType.Spine, int SpineId = 0, Offset<IFadeBackgroundFadeInEffect> FadeInEffectOffset = default(Offset<IFadeBackgroundFadeInEffect>), Offset<IFadeBackgroundFadeOutEffect> FadeOutEffectOffset = default(Offset<IFadeBackgroundFadeOutEffect>))
		{
			builder.StartTable(4);
			IFadeBackgroundSpine.AddFadeOutEffect(builder, FadeOutEffectOffset);
			IFadeBackgroundSpine.AddFadeInEffect(builder, FadeInEffectOffset);
			IFadeBackgroundSpine.AddSpineId(builder, SpineId);
			IFadeBackgroundSpine.AddType(builder, Type);
			return IFadeBackgroundSpine.EndIFadeBackgroundSpine(builder);
		}

		// Token: 0x060309C4 RID: 199108 RVA: 0x00699806 File Offset: 0x00697A06
		public static void StartIFadeBackgroundSpine(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060309C5 RID: 199109 RVA: 0x0069980F File Offset: 0x00697A0F
		public static void AddType(FlatBufferBuilder builder, EFadeBackgroundType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060309C6 RID: 199110 RVA: 0x0069981A File Offset: 0x00697A1A
		public static void AddSpineId(FlatBufferBuilder builder, int spineId)
		{
			builder.AddInt(1, spineId, 0);
		}

		// Token: 0x060309C7 RID: 199111 RVA: 0x00699825 File Offset: 0x00697A25
		public static void AddFadeInEffect(FlatBufferBuilder builder, Offset<IFadeBackgroundFadeInEffect> fadeInEffectOffset)
		{
			builder.AddOffset(2, fadeInEffectOffset.Value, 0);
		}

		// Token: 0x060309C8 RID: 199112 RVA: 0x00699835 File Offset: 0x00697A35
		public static void AddFadeOutEffect(FlatBufferBuilder builder, Offset<IFadeBackgroundFadeOutEffect> fadeOutEffectOffset)
		{
			builder.AddOffset(3, fadeOutEffectOffset.Value, 0);
		}

		// Token: 0x060309C9 RID: 199113 RVA: 0x00699845 File Offset: 0x00697A45
		public static Offset<IFadeBackgroundSpine> EndIFadeBackgroundSpine(FlatBufferBuilder builder)
		{
			return new Offset<IFadeBackgroundSpine>(builder.EndTable());
		}

		// Token: 0x060309CA RID: 199114 RVA: 0x00699854 File Offset: 0x00697A54
		public IFadeBackgroundSpineT UnPack()
		{
			IFadeBackgroundSpineT fadeBackgroundSpineT = new IFadeBackgroundSpineT();
			this.UnPackTo(fadeBackgroundSpineT);
			return fadeBackgroundSpineT;
		}

		// Token: 0x060309CB RID: 199115 RVA: 0x00699870 File Offset: 0x00697A70
		public void UnPackTo(IFadeBackgroundSpineT _o)
		{
			_o.Type = this.Type;
			_o.SpineId = this.SpineId;
			_o.FadeInEffect = ((this.FadeInEffect != null) ? this.FadeInEffect.Value.UnPack() : null);
			_o.FadeOutEffect = ((this.FadeOutEffect != null) ? this.FadeOutEffect.Value.UnPack() : null);
		}

		// Token: 0x060309CC RID: 199116 RVA: 0x006998F4 File Offset: 0x00697AF4
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

		// Token: 0x04011CAD RID: 72877
		private Table __p;
	}
}
