using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A17 RID: 23063
	public struct IItemFoundation : IFlatbufferObject
	{
		// Token: 0x1700A79B RID: 42907
		// (get) Token: 0x06025AB0 RID: 154288 RVA: 0x00529E1E File Offset: 0x0052801E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025AB1 RID: 154289 RVA: 0x00529E2B File Offset: 0x0052802B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025AB2 RID: 154290 RVA: 0x00529E34 File Offset: 0x00528034
		public static IItemFoundation GetRootAsIItemFoundation(ByteBuffer _bb)
		{
			return IItemFoundation.GetRootAsIItemFoundation(_bb, default(IItemFoundation));
		}

		// Token: 0x06025AB3 RID: 154291 RVA: 0x00529E50 File Offset: 0x00528050
		public static IItemFoundation GetRootAsIItemFoundation(ByteBuffer _bb, IItemFoundation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025AB4 RID: 154292 RVA: 0x00529E6D File Offset: 0x0052806D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025AB5 RID: 154293 RVA: 0x00529E7C File Offset: 0x0052807C
		public IItemFoundation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A79C RID: 42908
		// (get) Token: 0x06025AB6 RID: 154294 RVA: 0x00529E8C File Offset: 0x0052808C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A79D RID: 42909
		// (get) Token: 0x06025AB7 RID: 154295 RVA: 0x00529ECC File Offset: 0x005280CC
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

		// Token: 0x1700A79E RID: 42910
		// (get) Token: 0x06025AB8 RID: 154296 RVA: 0x00529F2C File Offset: 0x0052812C
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

		// Token: 0x1700A79F RID: 42911
		// (get) Token: 0x06025AB9 RID: 154297 RVA: 0x00529F8C File Offset: 0x0052818C
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

		// Token: 0x1700A7A0 RID: 42912
		// (get) Token: 0x06025ABA RID: 154298 RVA: 0x00529FEC File Offset: 0x005281EC
		public bool IsSilent
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A7A1 RID: 42913
		// (get) Token: 0x06025ABB RID: 154299 RVA: 0x0052A02C File Offset: 0x0052822C
		public bool IsDestroy
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A7A2 RID: 42914
		// (get) Token: 0x06025ABC RID: 154300 RVA: 0x0052A06C File Offset: 0x0052826C
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

		// Token: 0x1700A7A3 RID: 42915
		// (get) Token: 0x06025ABD RID: 154301 RVA: 0x0052A0CC File Offset: 0x005282CC
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

		// Token: 0x06025ABE RID: 154302 RVA: 0x0052A10C File Offset: 0x0052830C
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

		// Token: 0x06025ABF RID: 154303 RVA: 0x0052A163 File Offset: 0x00528363
		public static void StartIItemFoundation(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06025AC0 RID: 154304 RVA: 0x0052A16C File Offset: 0x0052836C
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06025AC1 RID: 154305 RVA: 0x0052A177 File Offset: 0x00528377
		public static void AddAdsorptionPoint(FlatBufferBuilder builder, Offset<IAdsortTransform> adsorptionPointOffset)
		{
			builder.AddOffset(1, adsorptionPointOffset.Value, 0);
		}

		// Token: 0x06025AC2 RID: 154306 RVA: 0x0052A187 File Offset: 0x00528387
		public static void AddAdsorptionMatch(FlatBufferBuilder builder, Offset<IEntityMatch> adsorptionMatchOffset)
		{
			builder.AddOffset(2, adsorptionMatchOffset.Value, 0);
		}

		// Token: 0x06025AC3 RID: 154307 RVA: 0x0052A197 File Offset: 0x00528397
		public static void AddActiveMatch(FlatBufferBuilder builder, Offset<IEntityMatch> activeMatchOffset)
		{
			builder.AddOffset(3, activeMatchOffset.Value, 0);
		}

		// Token: 0x06025AC4 RID: 154308 RVA: 0x0052A1A7 File Offset: 0x005283A7
		public static void AddIsSilent(FlatBufferBuilder builder, bool isSilent)
		{
			builder.AddBool(4, isSilent, false);
		}

		// Token: 0x06025AC5 RID: 154309 RVA: 0x0052A1B2 File Offset: 0x005283B2
		public static void AddIsDestroy(FlatBufferBuilder builder, bool isDestroy)
		{
			builder.AddBool(5, isDestroy, false);
		}

		// Token: 0x06025AC6 RID: 154310 RVA: 0x0052A1BD File Offset: 0x005283BD
		public static void AddChangeAdsorbateState(FlatBufferBuilder builder, Offset<IItemChangeAdsorbateState> changeAdsorbateStateOffset)
		{
			builder.AddOffset(6, changeAdsorbateStateOffset.Value, 0);
		}

		// Token: 0x06025AC7 RID: 154311 RVA: 0x0052A1CD File Offset: 0x005283CD
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06025AC8 RID: 154312 RVA: 0x0052A1D8 File Offset: 0x005283D8
		public static Offset<IItemFoundation> EndIItemFoundation(FlatBufferBuilder builder)
		{
			return new Offset<IItemFoundation>(builder.EndTable());
		}

		// Token: 0x06025AC9 RID: 154313 RVA: 0x0052A1E8 File Offset: 0x005283E8
		public IItemFoundationT UnPack()
		{
			IItemFoundationT itemFoundationT = new IItemFoundationT();
			this.UnPackTo(itemFoundationT);
			return itemFoundationT;
		}

		// Token: 0x06025ACA RID: 154314 RVA: 0x0052A204 File Offset: 0x00528404
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

		// Token: 0x06025ACB RID: 154315 RVA: 0x0052A300 File Offset: 0x00528500
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

		// Token: 0x0400F351 RID: 62289
		private Table __p;
	}
}
