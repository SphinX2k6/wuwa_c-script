using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D31 RID: 23857
	public struct IPhantomExhibitConfig : IFlatbufferObject
	{
		// Token: 0x1700AF67 RID: 44903
		// (get) Token: 0x06027A8E RID: 162446 RVA: 0x0056CFF3 File Offset: 0x0056B1F3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027A8F RID: 162447 RVA: 0x0056D000 File Offset: 0x0056B200
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027A90 RID: 162448 RVA: 0x0056D008 File Offset: 0x0056B208
		public static IPhantomExhibitConfig GetRootAsIPhantomExhibitConfig(ByteBuffer _bb)
		{
			return IPhantomExhibitConfig.GetRootAsIPhantomExhibitConfig(_bb, default(IPhantomExhibitConfig));
		}

		// Token: 0x06027A91 RID: 162449 RVA: 0x0056D024 File Offset: 0x0056B224
		public static IPhantomExhibitConfig GetRootAsIPhantomExhibitConfig(ByteBuffer _bb, IPhantomExhibitConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027A92 RID: 162450 RVA: 0x0056D041 File Offset: 0x0056B241
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027A93 RID: 162451 RVA: 0x0056D050 File Offset: 0x0056B250
		public IPhantomExhibitConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AF68 RID: 44904
		// (get) Token: 0x06027A94 RID: 162452 RVA: 0x0056D060 File Offset: 0x0056B260
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

		// Token: 0x1700AF69 RID: 44905
		// (get) Token: 0x06027A95 RID: 162453 RVA: 0x0056D09C File Offset: 0x0056B29C
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

		// Token: 0x1700AF6A RID: 44906
		// (get) Token: 0x06027A96 RID: 162454 RVA: 0x0056D0D8 File Offset: 0x0056B2D8
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

		// Token: 0x1700AF6B RID: 44907
		// (get) Token: 0x06027A97 RID: 162455 RVA: 0x0056D138 File Offset: 0x0056B338
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

		// Token: 0x06027A98 RID: 162456 RVA: 0x0056D196 File Offset: 0x0056B396
		public static Offset<IPhantomExhibitConfig> CreateIPhantomExhibitConfig(FlatBufferBuilder builder, EExhibitItemType Type = EExhibitItemType.Phantom, EPhantomExhibitSizeType PhantomSize = EPhantomExhibitSizeType.Small, Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>), Offset<IExhibitEffect> ActiveEffectOffset = default(Offset<IExhibitEffect>))
		{
			builder.StartTable(4);
			IPhantomExhibitConfig.AddActiveEffect(builder, ActiveEffectOffset);
			IPhantomExhibitConfig.AddOffset(builder, OffsetOffset);
			IPhantomExhibitConfig.AddPhantomSize(builder, PhantomSize);
			IPhantomExhibitConfig.AddType(builder, Type);
			return IPhantomExhibitConfig.EndIPhantomExhibitConfig(builder);
		}

		// Token: 0x06027A99 RID: 162457 RVA: 0x0056D1C2 File Offset: 0x0056B3C2
		public static void StartIPhantomExhibitConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06027A9A RID: 162458 RVA: 0x0056D1CB File Offset: 0x0056B3CB
		public static void AddType(FlatBufferBuilder builder, EExhibitItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027A9B RID: 162459 RVA: 0x0056D1D6 File Offset: 0x0056B3D6
		public static void AddPhantomSize(FlatBufferBuilder builder, EPhantomExhibitSizeType phantomSize)
		{
			builder.AddByte(1, (byte)phantomSize, 0);
		}

		// Token: 0x06027A9C RID: 162460 RVA: 0x0056D1E1 File Offset: 0x0056B3E1
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(2, offsetOffset.Value, 0);
		}

		// Token: 0x06027A9D RID: 162461 RVA: 0x0056D1F1 File Offset: 0x0056B3F1
		public static void AddActiveEffect(FlatBufferBuilder builder, Offset<IExhibitEffect> activeEffectOffset)
		{
			builder.AddOffset(3, activeEffectOffset.Value, 0);
		}

		// Token: 0x06027A9E RID: 162462 RVA: 0x0056D201 File Offset: 0x0056B401
		public static Offset<IPhantomExhibitConfig> EndIPhantomExhibitConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPhantomExhibitConfig>(builder.EndTable());
		}

		// Token: 0x06027A9F RID: 162463 RVA: 0x0056D210 File Offset: 0x0056B410
		public IPhantomExhibitConfigT UnPack()
		{
			IPhantomExhibitConfigT phantomExhibitConfigT = new IPhantomExhibitConfigT();
			this.UnPackTo(phantomExhibitConfigT);
			return phantomExhibitConfigT;
		}

		// Token: 0x06027AA0 RID: 162464 RVA: 0x0056D22C File Offset: 0x0056B42C
		public void UnPackTo(IPhantomExhibitConfigT _o)
		{
			_o.Type = this.Type;
			_o.PhantomSize = this.PhantomSize;
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
			_o.ActiveEffect = ((this.ActiveEffect != null) ? this.ActiveEffect.Value.UnPack() : null);
		}

		// Token: 0x06027AA1 RID: 162465 RVA: 0x0056D2B0 File Offset: 0x0056B4B0
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

		// Token: 0x0400F88E RID: 63630
		private Table __p;
	}
}
