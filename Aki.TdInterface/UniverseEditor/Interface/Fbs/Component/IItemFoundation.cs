using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005491 RID: 21649
	public struct IItemFoundation : IFlatbufferObject
	{
		// Token: 0x17009F61 RID: 40801
		// (get) Token: 0x060239F8 RID: 145912 RVA: 0x004ECDAA File Offset: 0x004EAFAA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060239F9 RID: 145913 RVA: 0x004ECDB7 File Offset: 0x004EAFB7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060239FA RID: 145914 RVA: 0x004ECDC0 File Offset: 0x004EAFC0
		public static IItemFoundation GetRootAsIItemFoundation(ByteBuffer _bb)
		{
			return IItemFoundation.GetRootAsIItemFoundation(_bb, default(IItemFoundation));
		}

		// Token: 0x060239FB RID: 145915 RVA: 0x004ECDDC File Offset: 0x004EAFDC
		public static IItemFoundation GetRootAsIItemFoundation(ByteBuffer _bb, IItemFoundation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060239FC RID: 145916 RVA: 0x004ECDF9 File Offset: 0x004EAFF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060239FD RID: 145917 RVA: 0x004ECE08 File Offset: 0x004EB008
		public IItemFoundation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009F62 RID: 40802
		// (get) Token: 0x060239FE RID: 145918 RVA: 0x004ECE18 File Offset: 0x004EB018
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009F63 RID: 40803
		// (get) Token: 0x060239FF RID: 145919 RVA: 0x004ECE58 File Offset: 0x004EB058
		public IAdsortTransform? AdsorptionPoint
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IAdsortTransform?(default(IAdsortTransform).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009F64 RID: 40804
		// (get) Token: 0x06023A00 RID: 145920 RVA: 0x004ECEB8 File Offset: 0x004EB0B8
		public IEntityMatch? AdsorptionMatch
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IEntityMatch?(default(IEntityMatch).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009F65 RID: 40805
		// (get) Token: 0x06023A01 RID: 145921 RVA: 0x004ECF18 File Offset: 0x004EB118
		public IEntityMatch? ActiveMatch
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IEntityMatch?(default(IEntityMatch).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009F66 RID: 40806
		// (get) Token: 0x06023A02 RID: 145922 RVA: 0x004ECF78 File Offset: 0x004EB178
		public bool IsSilent
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009F67 RID: 40807
		// (get) Token: 0x06023A03 RID: 145923 RVA: 0x004ECFB8 File Offset: 0x004EB1B8
		public bool IsDestroy
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009F68 RID: 40808
		// (get) Token: 0x06023A04 RID: 145924 RVA: 0x004ECFF8 File Offset: 0x004EB1F8
		public IItemChangeAdsorbateState? ChangeAdsorbateState
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new IItemChangeAdsorbateState?(default(IItemChangeAdsorbateState).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009F69 RID: 40809
		// (get) Token: 0x06023A05 RID: 145925 RVA: 0x004ED058 File Offset: 0x004EB258
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023A06 RID: 145926 RVA: 0x004ED098 File Offset: 0x004EB298
		public static Offset<IItemFoundation> CreateIItemFoundation(FlatBufferBuilder builder, bool Disabled = false, Offset<IAdsortTransform> AdsorptionPointOffset = default(Offset<IAdsortTransform>), Offset<IEntityMatch> AdsorptionMatchOffset = default(Offset<IEntityMatch>), Offset<IEntityMatch> ActiveMatchOffset = default(Offset<IEntityMatch>), bool IsSilent = false, bool IsDestroy = false, Offset<IItemChangeAdsorbateState> ChangeAdsorbateStateOffset = default(Offset<IItemChangeAdsorbateState>), byte NullMask = 0)
		{
			builder.StartTable(8);
			IItemFoundation.AddChangeAdsorbateState(builder, ChangeAdsorbateStateOffset);
			IItemFoundation.AddActiveMatch(builder, ActiveMatchOffset);
			IItemFoundation.AddAdsorptionMatch(builder, AdsorptionMatchOffset);
			IItemFoundation.AddAdsorptionPoint(builder, AdsorptionPointOffset);
			IItemFoundation.AddNullMask(builder, NullMask);
			IItemFoundation.AddIsDestroy(builder, IsDestroy);
			IItemFoundation.AddIsSilent(builder, IsSilent);
			IItemFoundation.AddDisabled(builder, Disabled);
			return IItemFoundation.EndIItemFoundation(builder);
		}

		// Token: 0x06023A07 RID: 145927 RVA: 0x004ED0EF File Offset: 0x004EB2EF
		public static void StartIItemFoundation(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06023A08 RID: 145928 RVA: 0x004ED0F8 File Offset: 0x004EB2F8
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06023A09 RID: 145929 RVA: 0x004ED103 File Offset: 0x004EB303
		public static void AddAdsorptionPoint(FlatBufferBuilder builder, Offset<IAdsortTransform> adsorptionPointOffset)
		{
			builder.AddOffset(1, adsorptionPointOffset.Value, 0);
		}

		// Token: 0x06023A0A RID: 145930 RVA: 0x004ED113 File Offset: 0x004EB313
		public static void AddAdsorptionMatch(FlatBufferBuilder builder, Offset<IEntityMatch> adsorptionMatchOffset)
		{
			builder.AddOffset(2, adsorptionMatchOffset.Value, 0);
		}

		// Token: 0x06023A0B RID: 145931 RVA: 0x004ED123 File Offset: 0x004EB323
		public static void AddActiveMatch(FlatBufferBuilder builder, Offset<IEntityMatch> activeMatchOffset)
		{
			builder.AddOffset(3, activeMatchOffset.Value, 0);
		}

		// Token: 0x06023A0C RID: 145932 RVA: 0x004ED133 File Offset: 0x004EB333
		public static void AddIsSilent(FlatBufferBuilder builder, bool isSilent)
		{
			builder.AddBool(4, isSilent, false);
		}

		// Token: 0x06023A0D RID: 145933 RVA: 0x004ED13E File Offset: 0x004EB33E
		public static void AddIsDestroy(FlatBufferBuilder builder, bool isDestroy)
		{
			builder.AddBool(5, isDestroy, false);
		}

		// Token: 0x06023A0E RID: 145934 RVA: 0x004ED149 File Offset: 0x004EB349
		public static void AddChangeAdsorbateState(FlatBufferBuilder builder, Offset<IItemChangeAdsorbateState> changeAdsorbateStateOffset)
		{
			builder.AddOffset(6, changeAdsorbateStateOffset.Value, 0);
		}

		// Token: 0x06023A0F RID: 145935 RVA: 0x004ED159 File Offset: 0x004EB359
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06023A10 RID: 145936 RVA: 0x004ED164 File Offset: 0x004EB364
		public static Offset<IItemFoundation> EndIItemFoundation(FlatBufferBuilder builder)
		{
			return new Offset<IItemFoundation>(builder.EndTable());
		}

		// Token: 0x06023A11 RID: 145937 RVA: 0x004ED174 File Offset: 0x004EB374
		public IItemFoundationT UnPack()
		{
			IItemFoundationT itemFoundationT = new IItemFoundationT();
			this.UnPackTo(itemFoundationT);
			return itemFoundationT;
		}

		// Token: 0x06023A12 RID: 145938 RVA: 0x004ED190 File Offset: 0x004EB390
		public void UnPackTo(IItemFoundationT _o)
		{
			_o.Disabled = this.Disabled;
			_o.AdsorptionPoint = ((this.AdsorptionPoint != null) ? this.AdsorptionPoint.Value.UnPack() : null);
			_o.AdsorptionMatch = ((this.AdsorptionMatch != null) ? this.AdsorptionMatch.Value.UnPack() : null);
			_o.ActiveMatch = ((this.ActiveMatch != null) ? this.ActiveMatch.Value.UnPack() : null);
			_o.IsSilent = this.IsSilent;
			_o.IsDestroy = this.IsDestroy;
			_o.ChangeAdsorbateState = ((this.ChangeAdsorbateState != null) ? this.ChangeAdsorbateState.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023A13 RID: 145939 RVA: 0x004ED28C File Offset: 0x004EB48C
		public static Offset<IItemFoundation> Pack(FlatBufferBuilder builder, IItemFoundationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IItemFoundation>);
			}
			Offset<IAdsortTransform> adsorptionPointOffset = (_o.AdsorptionPoint == null) ? default(Offset<IAdsortTransform>) : IAdsortTransform.Pack(builder, _o.AdsorptionPoint);
			Offset<IEntityMatch> adsorptionMatchOffset = (_o.AdsorptionMatch == null) ? default(Offset<IEntityMatch>) : IEntityMatch.Pack(builder, _o.AdsorptionMatch);
			Offset<IEntityMatch> activeMatchOffset = (_o.ActiveMatch == null) ? default(Offset<IEntityMatch>) : IEntityMatch.Pack(builder, _o.ActiveMatch);
			Offset<IItemChangeAdsorbateState> changeAdsorbateStateOffset = (_o.ChangeAdsorbateState == null) ? default(Offset<IItemChangeAdsorbateState>) : IItemChangeAdsorbateState.Pack(builder, _o.ChangeAdsorbateState);
			return IItemFoundation.CreateIItemFoundation(builder, _o.Disabled, adsorptionPointOffset, adsorptionMatchOffset, activeMatchOffset, _o.IsSilent, _o.IsDestroy, changeAdsorbateStateOffset, _o.NullMask);
		}

		// Token: 0x0400E720 RID: 59168
		private Table __p;
	}
}
