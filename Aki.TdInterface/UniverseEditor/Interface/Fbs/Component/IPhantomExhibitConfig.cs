using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200572A RID: 22314
	public struct IPhantomExhibitConfig : IFlatbufferObject
	{
		// Token: 0x1700A643 RID: 42563
		// (get) Token: 0x0602556E RID: 152942 RVA: 0x00526E68 File Offset: 0x00525068
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602556F RID: 152943 RVA: 0x00526E75 File Offset: 0x00525075
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025570 RID: 152944 RVA: 0x00526E7C File Offset: 0x0052507C
		public static IPhantomExhibitConfig GetRootAsIPhantomExhibitConfig(ByteBuffer _bb)
		{
			return IPhantomExhibitConfig.GetRootAsIPhantomExhibitConfig(_bb, default(IPhantomExhibitConfig));
		}

		// Token: 0x06025571 RID: 152945 RVA: 0x00526E98 File Offset: 0x00525098
		public static IPhantomExhibitConfig GetRootAsIPhantomExhibitConfig(ByteBuffer _bb, IPhantomExhibitConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025572 RID: 152946 RVA: 0x00526EB5 File Offset: 0x005250B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025573 RID: 152947 RVA: 0x00526EC4 File Offset: 0x005250C4
		public IPhantomExhibitConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A644 RID: 42564
		// (get) Token: 0x06025574 RID: 152948 RVA: 0x00526ED4 File Offset: 0x005250D4
		public EExhibitItemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExhibitItemType.Phantom;
				}
				return (EExhibitItemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A645 RID: 42565
		// (get) Token: 0x06025575 RID: 152949 RVA: 0x00526F10 File Offset: 0x00525110
		public EPhantomExhibitSizeType PhantomSize
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EPhantomExhibitSizeType.Small;
				}
				return (EPhantomExhibitSizeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A646 RID: 42566
		// (get) Token: 0x06025576 RID: 152950 RVA: 0x00526F4C File Offset: 0x0052514C
		public IVectorInfo? Offset
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A647 RID: 42567
		// (get) Token: 0x06025577 RID: 152951 RVA: 0x00526FAC File Offset: 0x005251AC
		public IExhibitEffect? ActiveEffect
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IExhibitEffect?(default(IExhibitEffect).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06025578 RID: 152952 RVA: 0x0052700A File Offset: 0x0052520A
		public static Offset<IPhantomExhibitConfig> CreateIPhantomExhibitConfig(FlatBufferBuilder builder, EExhibitItemType Type = EExhibitItemType.Phantom, EPhantomExhibitSizeType PhantomSize = EPhantomExhibitSizeType.Small, Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>), Offset<IExhibitEffect> ActiveEffectOffset = default(Offset<IExhibitEffect>))
		{
			builder.StartTable(4);
			IPhantomExhibitConfig.AddActiveEffect(builder, ActiveEffectOffset);
			IPhantomExhibitConfig.AddOffset(builder, OffsetOffset);
			IPhantomExhibitConfig.AddPhantomSize(builder, PhantomSize);
			IPhantomExhibitConfig.AddType(builder, Type);
			return IPhantomExhibitConfig.EndIPhantomExhibitConfig(builder);
		}

		// Token: 0x06025579 RID: 152953 RVA: 0x00527036 File Offset: 0x00525236
		public static void StartIPhantomExhibitConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602557A RID: 152954 RVA: 0x0052703F File Offset: 0x0052523F
		public static void AddType(FlatBufferBuilder builder, EExhibitItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602557B RID: 152955 RVA: 0x0052704A File Offset: 0x0052524A
		public static void AddPhantomSize(FlatBufferBuilder builder, EPhantomExhibitSizeType phantomSize)
		{
			builder.AddByte(1, (byte)phantomSize, 0);
		}

		// Token: 0x0602557C RID: 152956 RVA: 0x00527055 File Offset: 0x00525255
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(2, offsetOffset.Value, 0);
		}

		// Token: 0x0602557D RID: 152957 RVA: 0x00527065 File Offset: 0x00525265
		public static void AddActiveEffect(FlatBufferBuilder builder, Offset<IExhibitEffect> activeEffectOffset)
		{
			builder.AddOffset(3, activeEffectOffset.Value, 0);
		}

		// Token: 0x0602557E RID: 152958 RVA: 0x00527075 File Offset: 0x00525275
		public static Offset<IPhantomExhibitConfig> EndIPhantomExhibitConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPhantomExhibitConfig>(builder.EndTable());
		}

		// Token: 0x0602557F RID: 152959 RVA: 0x00527084 File Offset: 0x00525284
		public IPhantomExhibitConfigT UnPack()
		{
			IPhantomExhibitConfigT phantomExhibitConfigT = new IPhantomExhibitConfigT();
			this.UnPackTo(phantomExhibitConfigT);
			return phantomExhibitConfigT;
		}

		// Token: 0x06025580 RID: 152960 RVA: 0x005270A0 File Offset: 0x005252A0
		public void UnPackTo(IPhantomExhibitConfigT _o)
		{
			_o.Type = this.Type;
			_o.PhantomSize = this.PhantomSize;
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
			_o.ActiveEffect = ((this.ActiveEffect != null) ? this.ActiveEffect.Value.UnPack() : null);
		}

		// Token: 0x06025581 RID: 152961 RVA: 0x00527124 File Offset: 0x00525324
		public static Offset<IPhantomExhibitConfig> Pack(FlatBufferBuilder builder, IPhantomExhibitConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhantomExhibitConfig>);
			}
			Offset<IVectorInfo> offsetOffset = (_o.Offset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Offset);
			Offset<IExhibitEffect> activeEffectOffset = (_o.ActiveEffect == null) ? default(Offset<IExhibitEffect>) : IExhibitEffect.Pack(builder, _o.ActiveEffect);
			return IPhantomExhibitConfig.CreateIPhantomExhibitConfig(builder, _o.Type, _o.PhantomSize, offsetOffset, activeEffectOffset);
		}

		// Token: 0x0400EBA3 RID: 60323
		private Table __p;
	}
}
