using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052A9 RID: 21161
	public struct IFollowTrackComponent : IFlatbufferObject
	{
		// Token: 0x17009B2B RID: 39723
		// (get) Token: 0x060227EE RID: 141294 RVA: 0x004C82F0 File Offset: 0x004C64F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060227EF RID: 141295 RVA: 0x004C82FD File Offset: 0x004C64FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060227F0 RID: 141296 RVA: 0x004C8304 File Offset: 0x004C6504
		public static IFollowTrackComponent GetRootAsIFollowTrackComponent(ByteBuffer _bb)
		{
			return IFollowTrackComponent.GetRootAsIFollowTrackComponent(_bb, default(IFollowTrackComponent));
		}

		// Token: 0x060227F1 RID: 141297 RVA: 0x004C8320 File Offset: 0x004C6520
		public static IFollowTrackComponent GetRootAsIFollowTrackComponent(ByteBuffer _bb, IFollowTrackComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060227F2 RID: 141298 RVA: 0x004C833D File Offset: 0x004C653D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060227F3 RID: 141299 RVA: 0x004C834C File Offset: 0x004C654C
		public IFollowTrackComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009B2C RID: 39724
		// (get) Token: 0x060227F4 RID: 141300 RVA: 0x004C835C File Offset: 0x004C655C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009B2D RID: 39725
		// (get) Token: 0x060227F5 RID: 141301 RVA: 0x004C839C File Offset: 0x004C659C
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

		// Token: 0x17009B2E RID: 39726
		// (get) Token: 0x060227F6 RID: 141302 RVA: 0x004C83DC File Offset: 0x004C65DC
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

		// Token: 0x17009B2F RID: 39727
		// (get) Token: 0x060227F7 RID: 141303 RVA: 0x004C8418 File Offset: 0x004C6618
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

		// Token: 0x060227F8 RID: 141304 RVA: 0x004C8458 File Offset: 0x004C6658
		public TTable? EndType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060227F9 RID: 141305 RVA: 0x004C84A0 File Offset: 0x004C66A0
		public IFollowTrackToFoundation EndTypeAsIFollowTrackToFoundation()
		{
			return this.EndType<IFollowTrackToFoundation>().Value;
		}

		// Token: 0x060227FA RID: 141306 RVA: 0x004C84BC File Offset: 0x004C66BC
		public IFollowTrackToSplineDestination EndTypeAsIFollowTrackToSplineDestination()
		{
			return this.EndType<IFollowTrackToSplineDestination>().Value;
		}

		// Token: 0x060227FB RID: 141307 RVA: 0x004C84D8 File Offset: 0x004C66D8
		public IFollowTrackToStart EndTypeAsIFollowTrackToStart()
		{
			return this.EndType<IFollowTrackToStart>().Value;
		}

		// Token: 0x17009B30 RID: 39728
		// (get) Token: 0x060227FC RID: 141308 RVA: 0x004C84F4 File Offset: 0x004C66F4
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

		// Token: 0x060227FD RID: 141309 RVA: 0x004C8531 File Offset: 0x004C6731
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

		// Token: 0x060227FE RID: 141310 RVA: 0x004C856D File Offset: 0x004C676D
		public static void StartIFollowTrackComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060227FF RID: 141311 RVA: 0x004C8576 File Offset: 0x004C6776
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06022800 RID: 141312 RVA: 0x004C8581 File Offset: 0x004C6781
		public static void AddRange(FlatBufferBuilder builder, float range)
		{
			builder.AddFloat(1, range, 0.0);
		}

		// Token: 0x06022801 RID: 141313 RVA: 0x004C8594 File Offset: 0x004C6794
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(2, splineEntityId, 0);
		}

		// Token: 0x06022802 RID: 141314 RVA: 0x004C859F File Offset: 0x004C679F
		public static void AddEndTypeType(FlatBufferBuilder builder, TFollowTrackEndOption endTypeType)
		{
			builder.AddByte(3, (byte)endTypeType, 0);
		}

		// Token: 0x06022803 RID: 141315 RVA: 0x004C85AA File Offset: 0x004C67AA
		public static void AddEndType(FlatBufferBuilder builder, int endTypeOffset)
		{
			builder.AddOffset(4, endTypeOffset, 0);
		}

		// Token: 0x06022804 RID: 141316 RVA: 0x004C85B5 File Offset: 0x004C67B5
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06022805 RID: 141317 RVA: 0x004C85C0 File Offset: 0x004C67C0
		public static Offset<IFollowTrackComponent> EndIFollowTrackComponent(FlatBufferBuilder builder)
		{
			return new Offset<IFollowTrackComponent>(builder.EndTable());
		}

		// Token: 0x06022806 RID: 141318 RVA: 0x004C85D0 File Offset: 0x004C67D0
		public IFollowTrackComponentT UnPack()
		{
			IFollowTrackComponentT followTrackComponentT = new IFollowTrackComponentT();
			this.UnPackTo(followTrackComponentT);
			return followTrackComponentT;
		}

		// Token: 0x06022807 RID: 141319 RVA: 0x004C85EC File Offset: 0x004C67EC
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

		// Token: 0x06022808 RID: 141320 RVA: 0x004C870C File Offset: 0x004C690C
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

		// Token: 0x0400E422 RID: 58402
		private Table __p;
	}
}
