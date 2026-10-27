using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005327 RID: 21287
	public struct IGravityFlipTeleportConfig : IFlatbufferObject
	{
		// Token: 0x17009C50 RID: 40016
		// (get) Token: 0x06022C8E RID: 142478 RVA: 0x004D19E2 File Offset: 0x004CFBE2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022C8F RID: 142479 RVA: 0x004D19EF File Offset: 0x004CFBEF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022C90 RID: 142480 RVA: 0x004D19F8 File Offset: 0x004CFBF8
		public static IGravityFlipTeleportConfig GetRootAsIGravityFlipTeleportConfig(ByteBuffer _bb)
		{
			return IGravityFlipTeleportConfig.GetRootAsIGravityFlipTeleportConfig(_bb, default(IGravityFlipTeleportConfig));
		}

		// Token: 0x06022C91 RID: 142481 RVA: 0x004D1A14 File Offset: 0x004CFC14
		public static IGravityFlipTeleportConfig GetRootAsIGravityFlipTeleportConfig(ByteBuffer _bb, IGravityFlipTeleportConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022C92 RID: 142482 RVA: 0x004D1A31 File Offset: 0x004CFC31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022C93 RID: 142483 RVA: 0x004D1A40 File Offset: 0x004CFC40
		public IGravityFlipTeleportConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C51 RID: 40017
		// (get) Token: 0x06022C94 RID: 142484 RVA: 0x004D1A50 File Offset: 0x004CFC50
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

		// Token: 0x06022C95 RID: 142485 RVA: 0x004D1A8C File Offset: 0x004CFC8C
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06022C96 RID: 142486 RVA: 0x004D1AD0 File Offset: 0x004CFCD0
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x06022C97 RID: 142487 RVA: 0x004D1AEC File Offset: 0x004CFCEC
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x06022C98 RID: 142488 RVA: 0x004D1B08 File Offset: 0x004CFD08
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x06022C99 RID: 142489 RVA: 0x004D1B24 File Offset: 0x004CFD24
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x17009C52 RID: 40018
		// (get) Token: 0x06022C9A RID: 142490 RVA: 0x004D1B40 File Offset: 0x004CFD40
		public IVectorInfo? SafeLocation
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

		// Token: 0x06022C9B RID: 142491 RVA: 0x004D1B9D File Offset: 0x004CFD9D
		public static Offset<IGravityFlipTeleportConfig> CreateIGravityFlipTeleportConfig(FlatBufferBuilder builder, TGravityDirection GravityDirection_type = TGravityDirection.NONE, int GravityDirectionOffset = 0, Offset<IVectorInfo> SafeLocationOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			IGravityFlipTeleportConfig.AddSafeLocation(builder, SafeLocationOffset);
			IGravityFlipTeleportConfig.AddGravityDirection(builder, GravityDirectionOffset);
			IGravityFlipTeleportConfig.AddGravityDirectionType(builder, GravityDirection_type);
			return IGravityFlipTeleportConfig.EndIGravityFlipTeleportConfig(builder);
		}

		// Token: 0x06022C9C RID: 142492 RVA: 0x004D1BC1 File Offset: 0x004CFDC1
		public static void StartIGravityFlipTeleportConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06022C9D RID: 142493 RVA: 0x004D1BCA File Offset: 0x004CFDCA
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(0, (byte)gravityDirectionType, 0);
		}

		// Token: 0x06022C9E RID: 142494 RVA: 0x004D1BD5 File Offset: 0x004CFDD5
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(1, gravityDirectionOffset, 0);
		}

		// Token: 0x06022C9F RID: 142495 RVA: 0x004D1BE0 File Offset: 0x004CFDE0
		public static void AddSafeLocation(FlatBufferBuilder builder, Offset<IVectorInfo> safeLocationOffset)
		{
			builder.AddOffset(2, safeLocationOffset.Value, 0);
		}

		// Token: 0x06022CA0 RID: 142496 RVA: 0x004D1BF0 File Offset: 0x004CFDF0
		public static Offset<IGravityFlipTeleportConfig> EndIGravityFlipTeleportConfig(FlatBufferBuilder builder)
		{
			return new Offset<IGravityFlipTeleportConfig>(builder.EndTable());
		}

		// Token: 0x06022CA1 RID: 142497 RVA: 0x004D1C00 File Offset: 0x004CFE00
		public IGravityFlipTeleportConfigT UnPack()
		{
			IGravityFlipTeleportConfigT gravityFlipTeleportConfigT = new IGravityFlipTeleportConfigT();
			this.UnPackTo(gravityFlipTeleportConfigT);
			return gravityFlipTeleportConfigT;
		}

		// Token: 0x06022CA2 RID: 142498 RVA: 0x004D1C1C File Offset: 0x004CFE1C
		public void UnPackTo(IGravityFlipTeleportConfigT _o)
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
			_o.SafeLocation = ((this.SafeLocation != null) ? this.SafeLocation.Value.UnPack() : null);
		}

		// Token: 0x06022CA3 RID: 142499 RVA: 0x004D1D7C File Offset: 0x004CFF7C
		public static Offset<IGravityFlipTeleportConfig> Pack(FlatBufferBuilder builder, IGravityFlipTeleportConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGravityFlipTeleportConfig>);
			}
			TGravityDirection gravityDirection_type = (_o.GravityDirection == null) ? TGravityDirection.NONE : _o.GravityDirection.Type;
			int gravityDirectionOffset = (_o.GravityDirection == null) ? 0 : TGravityDirectionUnion.Pack(builder, _o.GravityDirection);
			Offset<IVectorInfo> safeLocationOffset = (_o.SafeLocation == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.SafeLocation);
			return IGravityFlipTeleportConfig.CreateIGravityFlipTeleportConfig(builder, gravityDirection_type, gravityDirectionOffset, safeLocationOffset);
		}

		// Token: 0x0400E4E3 RID: 58595
		private Table __p;
	}
}
