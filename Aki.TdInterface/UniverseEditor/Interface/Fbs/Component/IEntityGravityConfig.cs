using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005177 RID: 20855
	public struct IEntityGravityConfig : IFlatbufferObject
	{
		// Token: 0x17009856 RID: 38998
		// (get) Token: 0x06021B55 RID: 138069 RVA: 0x004AD712 File Offset: 0x004AB912
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021B56 RID: 138070 RVA: 0x004AD71F File Offset: 0x004AB91F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021B57 RID: 138071 RVA: 0x004AD728 File Offset: 0x004AB928
		public static IEntityGravityConfig GetRootAsIEntityGravityConfig(ByteBuffer _bb)
		{
			return IEntityGravityConfig.GetRootAsIEntityGravityConfig(_bb, default(IEntityGravityConfig));
		}

		// Token: 0x06021B58 RID: 138072 RVA: 0x004AD744 File Offset: 0x004AB944
		public static IEntityGravityConfig GetRootAsIEntityGravityConfig(ByteBuffer _bb, IEntityGravityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021B59 RID: 138073 RVA: 0x004AD761 File Offset: 0x004AB961
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021B5A RID: 138074 RVA: 0x004AD770 File Offset: 0x004AB970
		public IEntityGravityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009857 RID: 38999
		// (get) Token: 0x06021B5B RID: 138075 RVA: 0x004AD780 File Offset: 0x004AB980
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

		// Token: 0x06021B5C RID: 138076 RVA: 0x004AD7BC File Offset: 0x004AB9BC
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06021B5D RID: 138077 RVA: 0x004AD800 File Offset: 0x004ABA00
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x06021B5E RID: 138078 RVA: 0x004AD81C File Offset: 0x004ABA1C
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x06021B5F RID: 138079 RVA: 0x004AD838 File Offset: 0x004ABA38
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x06021B60 RID: 138080 RVA: 0x004AD854 File Offset: 0x004ABA54
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x17009858 RID: 39000
		// (get) Token: 0x06021B61 RID: 138081 RVA: 0x004AD870 File Offset: 0x004ABA70
		public bool SpecifyGravityLoad
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009859 RID: 39001
		// (get) Token: 0x06021B62 RID: 138082 RVA: 0x004AD8B0 File Offset: 0x004ABAB0
		public bool SpecifyGravityLock
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700985A RID: 39002
		// (get) Token: 0x06021B63 RID: 138083 RVA: 0x004AD8F0 File Offset: 0x004ABAF0
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

		// Token: 0x06021B64 RID: 138084 RVA: 0x004AD92D File Offset: 0x004ABB2D
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

		// Token: 0x06021B65 RID: 138085 RVA: 0x004AD961 File Offset: 0x004ABB61
		public static void StartIEntityGravityConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06021B66 RID: 138086 RVA: 0x004AD96A File Offset: 0x004ABB6A
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(0, (byte)gravityDirectionType, 0);
		}

		// Token: 0x06021B67 RID: 138087 RVA: 0x004AD975 File Offset: 0x004ABB75
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(1, gravityDirectionOffset, 0);
		}

		// Token: 0x06021B68 RID: 138088 RVA: 0x004AD980 File Offset: 0x004ABB80
		public static void AddSpecifyGravityLoad(FlatBufferBuilder builder, bool specifyGravityLoad)
		{
			builder.AddBool(2, specifyGravityLoad, false);
		}

		// Token: 0x06021B69 RID: 138089 RVA: 0x004AD98B File Offset: 0x004ABB8B
		public static void AddSpecifyGravityLock(FlatBufferBuilder builder, bool specifyGravityLock)
		{
			builder.AddBool(3, specifyGravityLock, false);
		}

		// Token: 0x06021B6A RID: 138090 RVA: 0x004AD996 File Offset: 0x004ABB96
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06021B6B RID: 138091 RVA: 0x004AD9A1 File Offset: 0x004ABBA1
		public static Offset<IEntityGravityConfig> EndIEntityGravityConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEntityGravityConfig>(builder.EndTable());
		}

		// Token: 0x06021B6C RID: 138092 RVA: 0x004AD9B0 File Offset: 0x004ABBB0
		public IEntityGravityConfigT UnPack()
		{
			IEntityGravityConfigT entityGravityConfigT = new IEntityGravityConfigT();
			this.UnPackTo(entityGravityConfigT);
			return entityGravityConfigT;
		}

		// Token: 0x06021B6D RID: 138093 RVA: 0x004AD9CC File Offset: 0x004ABBCC
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

		// Token: 0x06021B6E RID: 138094 RVA: 0x004ADB20 File Offset: 0x004ABD20
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

		// Token: 0x0400E240 RID: 57920
		private Table __p;
	}
}
