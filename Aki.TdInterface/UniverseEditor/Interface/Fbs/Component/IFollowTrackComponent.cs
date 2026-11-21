using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005814 RID: 22548
	public struct IFollowTrackComponent : IFlatbufferObject
	{
		// Token: 0x1700A334 RID: 41780
		// (get) Token: 0x060247B2 RID: 149426 RVA: 0x005033E9 File Offset: 0x005015E9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060247B3 RID: 149427 RVA: 0x005033F6 File Offset: 0x005015F6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060247B4 RID: 149428 RVA: 0x00503400 File Offset: 0x00501600
		public static IFollowTrackComponent GetRootAsIFollowTrackComponent(ByteBuffer _bb)
		{
			return IFollowTrackComponent.GetRootAsIFollowTrackComponent(_bb, default(IFollowTrackComponent));
		}

		// Token: 0x060247B5 RID: 149429 RVA: 0x0050341C File Offset: 0x0050161C
		public static IFollowTrackComponent GetRootAsIFollowTrackComponent(ByteBuffer _bb, IFollowTrackComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060247B6 RID: 149430 RVA: 0x00503439 File Offset: 0x00501639
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060247B7 RID: 149431 RVA: 0x00503448 File Offset: 0x00501648
		public IFollowTrackComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A335 RID: 41781
		// (get) Token: 0x060247B8 RID: 149432 RVA: 0x00503458 File Offset: 0x00501658
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A336 RID: 41782
		// (get) Token: 0x060247B9 RID: 149433 RVA: 0x00503498 File Offset: 0x00501698
		public float Range
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A337 RID: 41783
		// (get) Token: 0x060247BA RID: 149434 RVA: 0x005034D8 File Offset: 0x005016D8
		public int SplineEntityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A338 RID: 41784
		// (get) Token: 0x060247BB RID: 149435 RVA: 0x00503514 File Offset: 0x00501714
		public TFollowTrackEndOption EndTypeType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TFollowTrackEndOption.NONE;
				}
				return (TFollowTrackEndOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060247BC RID: 149436 RVA: 0x00503554 File Offset: 0x00501754
		public TTable? EndType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060247BD RID: 149437 RVA: 0x0050359C File Offset: 0x0050179C
		public IFollowTrackToFoundation EndTypeAsIFollowTrackToFoundation()
		{
			return this.EndType<IFollowTrackToFoundation>().Value;
		}

		// Token: 0x060247BE RID: 149438 RVA: 0x005035B8 File Offset: 0x005017B8
		public IFollowTrackToSplineDestination EndTypeAsIFollowTrackToSplineDestination()
		{
			return this.EndType<IFollowTrackToSplineDestination>().Value;
		}

		// Token: 0x060247BF RID: 149439 RVA: 0x005035D4 File Offset: 0x005017D4
		public IFollowTrackToStart EndTypeAsIFollowTrackToStart()
		{
			return this.EndType<IFollowTrackToStart>().Value;
		}

		// Token: 0x1700A339 RID: 41785
		// (get) Token: 0x060247C0 RID: 149440 RVA: 0x005035F0 File Offset: 0x005017F0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060247C1 RID: 149441 RVA: 0x0050362D File Offset: 0x0050182D
		public static Offset<IFollowTrackComponent> CreateIFollowTrackComponent(FlatBufferBuilder builder, bool Disabled = false, float Range = 0f, int SplineEntityId = 0, TFollowTrackEndOption EndType_type = TFollowTrackEndOption.NONE, int EndTypeOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(6);
			IFollowTrackComponent.AddEndType(builder, EndTypeOffset);
			IFollowTrackComponent.AddSplineEntityId(builder, SplineEntityId);
			IFollowTrackComponent.AddRange(builder, Range);
			IFollowTrackComponent.AddNullMask(builder, NullMask);
			IFollowTrackComponent.AddEndTypeType(builder, EndType_type);
			IFollowTrackComponent.AddDisabled(builder, Disabled);
			return IFollowTrackComponent.EndIFollowTrackComponent(builder);
		}

		// Token: 0x060247C2 RID: 149442 RVA: 0x00503669 File Offset: 0x00501869
		public static void StartIFollowTrackComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060247C3 RID: 149443 RVA: 0x00503672 File Offset: 0x00501872
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060247C4 RID: 149444 RVA: 0x0050367D File Offset: 0x0050187D
		public static void AddRange(FlatBufferBuilder builder, float range)
		{
			builder.AddFloat(1, range, 0.0);
		}

		// Token: 0x060247C5 RID: 149445 RVA: 0x00503690 File Offset: 0x00501890
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(2, splineEntityId, 0);
		}

		// Token: 0x060247C6 RID: 149446 RVA: 0x0050369B File Offset: 0x0050189B
		public static void AddEndTypeType(FlatBufferBuilder builder, TFollowTrackEndOption endTypeType)
		{
			builder.AddByte(3, (byte)endTypeType, 0);
		}

		// Token: 0x060247C7 RID: 149447 RVA: 0x005036A6 File Offset: 0x005018A6
		public static void AddEndType(FlatBufferBuilder builder, int endTypeOffset)
		{
			builder.AddOffset(4, endTypeOffset, 0);
		}

		// Token: 0x060247C8 RID: 149448 RVA: 0x005036B1 File Offset: 0x005018B1
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060247C9 RID: 149449 RVA: 0x005036BC File Offset: 0x005018BC
		public static Offset<IFollowTrackComponent> EndIFollowTrackComponent(FlatBufferBuilder builder)
		{
			return new Offset<IFollowTrackComponent>(builder.EndTable());
		}

		// Token: 0x060247CA RID: 149450 RVA: 0x005036CC File Offset: 0x005018CC
		public IFollowTrackComponentT UnPack()
		{
			IFollowTrackComponentT followTrackComponentT = new IFollowTrackComponentT();
			this.UnPackTo(followTrackComponentT);
			return followTrackComponentT;
		}

		// Token: 0x060247CB RID: 149451 RVA: 0x005036E8 File Offset: 0x005018E8
		public void UnPackTo(IFollowTrackComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Range = this.Range;
			_o.SplineEntityId = this.SplineEntityId;
			_o.EndType = new TFollowTrackEndOptionUnion();
			_o.EndType.Type = this.EndTypeType;
			switch (this.EndTypeType)
			{
			case TFollowTrackEndOption.IFollowTrackToFoundation:
				_o.EndType.Value = ((this.EndType<IFollowTrackToFoundation>() != null) ? this.EndType<IFollowTrackToFoundation>().Value.UnPack() : null);
				break;
			case TFollowTrackEndOption.IFollowTrackToSplineDestination:
				_o.EndType.Value = ((this.EndType<IFollowTrackToSplineDestination>() != null) ? this.EndType<IFollowTrackToSplineDestination>().Value.UnPack() : null);
				break;
			case TFollowTrackEndOption.IFollowTrackToStart:
				_o.EndType.Value = ((this.EndType<IFollowTrackToStart>() != null) ? this.EndType<IFollowTrackToStart>().Value.UnPack() : null);
				break;
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060247CC RID: 149452 RVA: 0x00503808 File Offset: 0x00501A08
		public static Offset<IFollowTrackComponent> Pack(FlatBufferBuilder builder, IFollowTrackComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFollowTrackComponent>);
			}
			TFollowTrackEndOption endType_type = (_o.EndType == null) ? TFollowTrackEndOption.NONE : _o.EndType.Type;
			int endTypeOffset = (_o.EndType == null) ? 0 : TFollowTrackEndOptionUnion.Pack(builder, _o.EndType);
			return IFollowTrackComponent.CreateIFollowTrackComponent(builder, _o.Disabled, _o.Range, _o.SplineEntityId, endType_type, endTypeOffset, _o.NullMask);
		}

		// Token: 0x0400F02F RID: 61487
		private Table __p;
	}
}
