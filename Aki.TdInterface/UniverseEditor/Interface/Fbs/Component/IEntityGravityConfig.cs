using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056DC RID: 22236
	public struct IEntityGravityConfig : IFlatbufferObject
	{
		// Token: 0x1700A045 RID: 41029
		// (get) Token: 0x06023AAD RID: 146093 RVA: 0x004E7732 File Offset: 0x004E5932
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023AAE RID: 146094 RVA: 0x004E773F File Offset: 0x004E593F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023AAF RID: 146095 RVA: 0x004E7748 File Offset: 0x004E5948
		public static IEntityGravityConfig GetRootAsIEntityGravityConfig(ByteBuffer _bb)
		{
			return IEntityGravityConfig.GetRootAsIEntityGravityConfig(_bb, default(IEntityGravityConfig));
		}

		// Token: 0x06023AB0 RID: 146096 RVA: 0x004E7764 File Offset: 0x004E5964
		public static IEntityGravityConfig GetRootAsIEntityGravityConfig(ByteBuffer _bb, IEntityGravityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023AB1 RID: 146097 RVA: 0x004E7781 File Offset: 0x004E5981
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023AB2 RID: 146098 RVA: 0x004E7790 File Offset: 0x004E5990
		public IEntityGravityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A046 RID: 41030
		// (get) Token: 0x06023AB3 RID: 146099 RVA: 0x004E77A0 File Offset: 0x004E59A0
		public TGravityDirection GravityDirectionType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TGravityDirection.NONE;
				}
				return (TGravityDirection)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023AB4 RID: 146100 RVA: 0x004E77DC File Offset: 0x004E59DC
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06023AB5 RID: 146101 RVA: 0x004E7820 File Offset: 0x004E5A20
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x06023AB6 RID: 146102 RVA: 0x004E783C File Offset: 0x004E5A3C
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x06023AB7 RID: 146103 RVA: 0x004E7858 File Offset: 0x004E5A58
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x06023AB8 RID: 146104 RVA: 0x004E7874 File Offset: 0x004E5A74
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x1700A047 RID: 41031
		// (get) Token: 0x06023AB9 RID: 146105 RVA: 0x004E7890 File Offset: 0x004E5A90
		public bool SpecifyGravityLoad
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A048 RID: 41032
		// (get) Token: 0x06023ABA RID: 146106 RVA: 0x004E78D0 File Offset: 0x004E5AD0
		public bool SpecifyGravityLock
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A049 RID: 41033
		// (get) Token: 0x06023ABB RID: 146107 RVA: 0x004E7910 File Offset: 0x004E5B10
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023ABC RID: 146108 RVA: 0x004E794D File Offset: 0x004E5B4D
		public static Offset<IEntityGravityConfig> CreateIEntityGravityConfig(FlatBufferBuilder builder, TGravityDirection GravityDirection_type = TGravityDirection.NONE, int GravityDirectionOffset = 0, bool SpecifyGravityLoad = false, bool SpecifyGravityLock = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			IEntityGravityConfig.AddGravityDirection(builder, GravityDirectionOffset);
			IEntityGravityConfig.AddNullMask(builder, NullMask);
			IEntityGravityConfig.AddSpecifyGravityLock(builder, SpecifyGravityLock);
			IEntityGravityConfig.AddSpecifyGravityLoad(builder, SpecifyGravityLoad);
			IEntityGravityConfig.AddGravityDirectionType(builder, GravityDirection_type);
			return IEntityGravityConfig.EndIEntityGravityConfig(builder);
		}

		// Token: 0x06023ABD RID: 146109 RVA: 0x004E7981 File Offset: 0x004E5B81
		public static void StartIEntityGravityConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06023ABE RID: 146110 RVA: 0x004E798A File Offset: 0x004E5B8A
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(0, (byte)gravityDirectionType, 0);
		}

		// Token: 0x06023ABF RID: 146111 RVA: 0x004E7995 File Offset: 0x004E5B95
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(1, gravityDirectionOffset, 0);
		}

		// Token: 0x06023AC0 RID: 146112 RVA: 0x004E79A0 File Offset: 0x004E5BA0
		public static void AddSpecifyGravityLoad(FlatBufferBuilder builder, bool specifyGravityLoad)
		{
			builder.AddBool(2, specifyGravityLoad, false);
		}

		// Token: 0x06023AC1 RID: 146113 RVA: 0x004E79AB File Offset: 0x004E5BAB
		public static void AddSpecifyGravityLock(FlatBufferBuilder builder, bool specifyGravityLock)
		{
			builder.AddBool(3, specifyGravityLock, false);
		}

		// Token: 0x06023AC2 RID: 146114 RVA: 0x004E79B6 File Offset: 0x004E5BB6
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06023AC3 RID: 146115 RVA: 0x004E79C1 File Offset: 0x004E5BC1
		public static Offset<IEntityGravityConfig> EndIEntityGravityConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEntityGravityConfig>(builder.EndTable());
		}

		// Token: 0x06023AC4 RID: 146116 RVA: 0x004E79D0 File Offset: 0x004E5BD0
		public IEntityGravityConfigT UnPack()
		{
			IEntityGravityConfigT entityGravityConfigT = new IEntityGravityConfigT();
			this.UnPackTo(entityGravityConfigT);
			return entityGravityConfigT;
		}

		// Token: 0x06023AC5 RID: 146117 RVA: 0x004E79EC File Offset: 0x004E5BEC
		public void UnPackTo(IEntityGravityConfigT _o)
		{
			_o.GravityDirection = new TGravityDirectionUnion();
			_o.GravityDirection.Type = this.GravityDirectionType;
			switch (this.GravityDirectionType)
			{
			case TGravityDirection.IGravityDirectionByEntityGravity:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionByEntityGravity>() != null) ? this.GravityDirection<IGravityDirectionByEntityGravity>().Value.UnPack() : null);
				break;
			case TGravityDirection.IGravityDirectionSelfRotation:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionSelfRotation>() != null) ? this.GravityDirection<IGravityDirectionSelfRotation>().Value.UnPack() : null);
				break;
			case TGravityDirection.IGravityDirectionVectorInfo:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionVectorInfo>() != null) ? this.GravityDirection<IGravityDirectionVectorInfo>().Value.UnPack() : null);
				break;
			case TGravityDirection.IGravityDirectionWorldAxis:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionWorldAxis>() != null) ? this.GravityDirection<IGravityDirectionWorldAxis>().Value.UnPack() : null);
				break;
			}
			_o.SpecifyGravityLoad = this.SpecifyGravityLoad;
			_o.SpecifyGravityLock = this.SpecifyGravityLock;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023AC6 RID: 146118 RVA: 0x004E7B40 File Offset: 0x004E5D40
		public static Offset<IEntityGravityConfig> Pack(FlatBufferBuilder builder, IEntityGravityConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityGravityConfig>);
			}
			TGravityDirection gravityDirection_type = (_o.GravityDirection == null) ? TGravityDirection.NONE : _o.GravityDirection.Type;
			int gravityDirectionOffset = (_o.GravityDirection == null) ? 0 : TGravityDirectionUnion.Pack(builder, _o.GravityDirection);
			return IEntityGravityConfig.CreateIEntityGravityConfig(builder, gravityDirection_type, gravityDirectionOffset, _o.SpecifyGravityLoad, _o.SpecifyGravityLock, _o.NullMask);
		}

		// Token: 0x0400EE3E RID: 60990
		private Table __p;
	}
}
