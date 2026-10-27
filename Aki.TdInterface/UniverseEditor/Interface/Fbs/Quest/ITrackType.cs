using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200421D RID: 16925
	public struct ITrackType : IFlatbufferObject
	{
		// Token: 0x17007840 RID: 30784
		// (get) Token: 0x0601904E RID: 102478 RVA: 0x00399B85 File Offset: 0x00397D85
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601904F RID: 102479 RVA: 0x00399B92 File Offset: 0x00397D92
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019050 RID: 102480 RVA: 0x00399B9C File Offset: 0x00397D9C
		public static ITrackType GetRootAsITrackType(ByteBuffer _bb)
		{
			return ITrackType.GetRootAsITrackType(_bb, default(ITrackType));
		}

		// Token: 0x06019051 RID: 102481 RVA: 0x00399BB8 File Offset: 0x00397DB8
		public static ITrackType GetRootAsITrackType(ByteBuffer _bb, ITrackType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019052 RID: 102482 RVA: 0x00399BD5 File Offset: 0x00397DD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019053 RID: 102483 RVA: 0x00399BE4 File Offset: 0x00397DE4
		public ITrackType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007841 RID: 30785
		// (get) Token: 0x06019054 RID: 102484 RVA: 0x00399BF4 File Offset: 0x00397DF4
		public ETrackType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrackType.Locations;
				}
				return (ETrackType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007842 RID: 30786
		// (get) Token: 0x06019055 RID: 102485 RVA: 0x00399C30 File Offset: 0x00397E30
		public TGravityDirection GravityDirectionType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TGravityDirection.NONE;
				}
				return (TGravityDirection)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019056 RID: 102486 RVA: 0x00399C6C File Offset: 0x00397E6C
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06019057 RID: 102487 RVA: 0x00399CB0 File Offset: 0x00397EB0
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x06019058 RID: 102488 RVA: 0x00399CCC File Offset: 0x00397ECC
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x06019059 RID: 102489 RVA: 0x00399CE8 File Offset: 0x00397EE8
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x0601905A RID: 102490 RVA: 0x00399D04 File Offset: 0x00397F04
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x0601905B RID: 102491 RVA: 0x00399D1F File Offset: 0x00397F1F
		public static Offset<ITrackType> CreateITrackType(FlatBufferBuilder builder, ETrackType Type = ETrackType.Locations, TGravityDirection GravityDirection_type = TGravityDirection.NONE, int GravityDirectionOffset = 0)
		{
			builder.StartTable(3);
			ITrackType.AddGravityDirection(builder, GravityDirectionOffset);
			ITrackType.AddGravityDirectionType(builder, GravityDirection_type);
			ITrackType.AddType(builder, Type);
			return ITrackType.EndITrackType(builder);
		}

		// Token: 0x0601905C RID: 102492 RVA: 0x00399D43 File Offset: 0x00397F43
		public static void StartITrackType(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601905D RID: 102493 RVA: 0x00399D4C File Offset: 0x00397F4C
		public static void AddType(FlatBufferBuilder builder, ETrackType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601905E RID: 102494 RVA: 0x00399D57 File Offset: 0x00397F57
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(1, (byte)gravityDirectionType, 0);
		}

		// Token: 0x0601905F RID: 102495 RVA: 0x00399D62 File Offset: 0x00397F62
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(2, gravityDirectionOffset, 0);
		}

		// Token: 0x06019060 RID: 102496 RVA: 0x00399D6D File Offset: 0x00397F6D
		public static Offset<ITrackType> EndITrackType(FlatBufferBuilder builder)
		{
			return new Offset<ITrackType>(builder.EndTable());
		}

		// Token: 0x06019061 RID: 102497 RVA: 0x00399D7C File Offset: 0x00397F7C
		public ITrackTypeT UnPack()
		{
			ITrackTypeT trackTypeT = new ITrackTypeT();
			this.UnPackTo(trackTypeT);
			return trackTypeT;
		}

		// Token: 0x06019062 RID: 102498 RVA: 0x00399D98 File Offset: 0x00397F98
		public void UnPackTo(ITrackTypeT _o)
		{
			_o.Type = this.Type;
			_o.GravityDirection = new TGravityDirectionUnion();
			_o.GravityDirection.Type = this.GravityDirectionType;
			switch (this.GravityDirectionType)
			{
			case TGravityDirection.IGravityDirectionByEntityGravity:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionByEntityGravity>() != null) ? this.GravityDirection<IGravityDirectionByEntityGravity>().Value.UnPack() : null);
				return;
			case TGravityDirection.IGravityDirectionSelfRotation:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionSelfRotation>() != null) ? this.GravityDirection<IGravityDirectionSelfRotation>().Value.UnPack() : null);
				return;
			case TGravityDirection.IGravityDirectionVectorInfo:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionVectorInfo>() != null) ? this.GravityDirection<IGravityDirectionVectorInfo>().Value.UnPack() : null);
				return;
			case TGravityDirection.IGravityDirectionWorldAxis:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionWorldAxis>() != null) ? this.GravityDirection<IGravityDirectionWorldAxis>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06019063 RID: 102499 RVA: 0x00399EC8 File Offset: 0x003980C8
		public static Offset<ITrackType> Pack(FlatBufferBuilder builder, ITrackTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrackType>);
			}
			TGravityDirection gravityDirection_type = (_o.GravityDirection == null) ? TGravityDirection.NONE : _o.GravityDirection.Type;
			int gravityDirectionOffset = (_o.GravityDirection == null) ? 0 : TGravityDirectionUnion.Pack(builder, _o.GravityDirection);
			return ITrackType.CreateITrackType(builder, _o.Type, gravityDirection_type, gravityDirectionOffset);
		}

		// Token: 0x0400BE97 RID: 48791
		private Table __p;
	}
}
