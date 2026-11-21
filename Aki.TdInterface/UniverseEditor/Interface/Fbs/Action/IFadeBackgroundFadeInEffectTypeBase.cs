using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DE5 RID: 28133
	public struct IFadeBackgroundFadeInEffectTypeBase : IFlatbufferObject
	{
		// Token: 0x1700CE35 RID: 52789
		// (get) Token: 0x06030909 RID: 198921 RVA: 0x0069836D File Offset: 0x0069656D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603090A RID: 198922 RVA: 0x0069837A File Offset: 0x0069657A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603090B RID: 198923 RVA: 0x00698384 File Offset: 0x00696584
		public static IFadeBackgroundFadeInEffectTypeBase GetRootAsIFadeBackgroundFadeInEffectTypeBase(ByteBuffer _bb)
		{
			return IFadeBackgroundFadeInEffectTypeBase.GetRootAsIFadeBackgroundFadeInEffectTypeBase(_bb, default(IFadeBackgroundFadeInEffectTypeBase));
		}

		// Token: 0x0603090C RID: 198924 RVA: 0x006983A0 File Offset: 0x006965A0
		public static IFadeBackgroundFadeInEffectTypeBase GetRootAsIFadeBackgroundFadeInEffectTypeBase(ByteBuffer _bb, IFadeBackgroundFadeInEffectTypeBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603090D RID: 198925 RVA: 0x006983BD File Offset: 0x006965BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603090E RID: 198926 RVA: 0x006983CC File Offset: 0x006965CC
		public IFadeBackgroundFadeInEffectTypeBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CE36 RID: 52790
		// (get) Token: 0x0603090F RID: 198927 RVA: 0x006983DC File Offset: 0x006965DC
		public EFadeBackgroundFadeInEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFadeBackgroundFadeInEffectType.Black;
				}
				return (EFadeBackgroundFadeInEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030910 RID: 198928 RVA: 0x00698418 File Offset: 0x00696618
		public static Offset<IFadeBackgroundFadeInEffectTypeBase> CreateIFadeBackgroundFadeInEffectTypeBase(FlatBufferBuilder builder, EFadeBackgroundFadeInEffectType Type = EFadeBackgroundFadeInEffectType.Black)
		{
			builder.StartTable(1);
			IFadeBackgroundFadeInEffectTypeBase.AddType(builder, Type);
			return IFadeBackgroundFadeInEffectTypeBase.EndIFadeBackgroundFadeInEffectTypeBase(builder);
		}

		// Token: 0x06030911 RID: 198929 RVA: 0x0069842E File Offset: 0x0069662E
		public static void StartIFadeBackgroundFadeInEffectTypeBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06030912 RID: 198930 RVA: 0x00698437 File Offset: 0x00696637
		public static void AddType(FlatBufferBuilder builder, EFadeBackgroundFadeInEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030913 RID: 198931 RVA: 0x00698442 File Offset: 0x00696642
		public static Offset<IFadeBackgroundFadeInEffectTypeBase> EndIFadeBackgroundFadeInEffectTypeBase(FlatBufferBuilder builder)
		{
			return new Offset<IFadeBackgroundFadeInEffectTypeBase>(builder.EndTable());
		}

		// Token: 0x06030914 RID: 198932 RVA: 0x00698450 File Offset: 0x00696650
		public IFadeBackgroundFadeInEffectTypeBaseT UnPack()
		{
			IFadeBackgroundFadeInEffectTypeBaseT fadeBackgroundFadeInEffectTypeBaseT = new IFadeBackgroundFadeInEffectTypeBaseT();
			this.UnPackTo(fadeBackgroundFadeInEffectTypeBaseT);
			return fadeBackgroundFadeInEffectTypeBaseT;
		}

		// Token: 0x06030915 RID: 198933 RVA: 0x0069846B File Offset: 0x0069666B
		public void UnPackTo(IFadeBackgroundFadeInEffectTypeBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06030916 RID: 198934 RVA: 0x0069847C File Offset: 0x0069667C
		public static Offset<IFadeBackgroundFadeInEffectTypeBase> Pack(FlatBufferBuilder builder, IFadeBackgroundFadeInEffectTypeBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFadeBackgroundFadeInEffectTypeBase>);
			}
			return IFadeBackgroundFadeInEffectTypeBase.CreateIFadeBackgroundFadeInEffectTypeBase(builder, _o.Type);
		}

		// Token: 0x04011C8B RID: 72843
		private Table __p;
	}
}
