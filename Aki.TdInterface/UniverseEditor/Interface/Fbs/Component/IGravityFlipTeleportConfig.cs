using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058AD RID: 22701
	public struct IGravityFlipTeleportConfig : IFlatbufferObject
	{
		// Token: 0x1700A488 RID: 42120
		// (get) Token: 0x06024D42 RID: 150850 RVA: 0x0050E8B6 File Offset: 0x0050CAB6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024D43 RID: 150851 RVA: 0x0050E8C3 File Offset: 0x0050CAC3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024D44 RID: 150852 RVA: 0x0050E8CC File Offset: 0x0050CACC
		public static IGravityFlipTeleportConfig GetRootAsIGravityFlipTeleportConfig(ByteBuffer _bb)
		{
			return IGravityFlipTeleportConfig.GetRootAsIGravityFlipTeleportConfig(_bb, default(IGravityFlipTeleportConfig));
		}

		// Token: 0x06024D45 RID: 150853 RVA: 0x0050E8E8 File Offset: 0x0050CAE8
		public static IGravityFlipTeleportConfig GetRootAsIGravityFlipTeleportConfig(ByteBuffer _bb, IGravityFlipTeleportConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024D46 RID: 150854 RVA: 0x0050E905 File Offset: 0x0050CB05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024D47 RID: 150855 RVA: 0x0050E914 File Offset: 0x0050CB14
		public IGravityFlipTeleportConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A489 RID: 42121
		// (get) Token: 0x06024D48 RID: 150856 RVA: 0x0050E924 File Offset: 0x0050CB24
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

		// Token: 0x06024D49 RID: 150857 RVA: 0x0050E960 File Offset: 0x0050CB60
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06024D4A RID: 150858 RVA: 0x0050E9A4 File Offset: 0x0050CBA4
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x06024D4B RID: 150859 RVA: 0x0050E9C0 File Offset: 0x0050CBC0
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x06024D4C RID: 150860 RVA: 0x0050E9DC File Offset: 0x0050CBDC
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x06024D4D RID: 150861 RVA: 0x0050E9F8 File Offset: 0x0050CBF8
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x1700A48A RID: 42122
		// (get) Token: 0x06024D4E RID: 150862 RVA: 0x0050EA14 File Offset: 0x0050CC14
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

		// Token: 0x06024D4F RID: 150863 RVA: 0x0050EA71 File Offset: 0x0050CC71
		public static Offset<IGravityFlipTeleportConfig> CreateIGravityFlipTeleportConfig(FlatBufferBuilder builder, TGravityDirection GravityDirection_type = TGravityDirection.NONE, int GravityDirectionOffset = 0, Offset<IVectorInfo> SafeLocationOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			IGravityFlipTeleportConfig.AddSafeLocation(builder, SafeLocationOffset);
			IGravityFlipTeleportConfig.AddGravityDirection(builder, GravityDirectionOffset);
			IGravityFlipTeleportConfig.AddGravityDirectionType(builder, GravityDirection_type);
			return IGravityFlipTeleportConfig.EndIGravityFlipTeleportConfig(builder);
		}

		// Token: 0x06024D50 RID: 150864 RVA: 0x0050EA95 File Offset: 0x0050CC95
		public static void StartIGravityFlipTeleportConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06024D51 RID: 150865 RVA: 0x0050EA9E File Offset: 0x0050CC9E
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(0, (byte)gravityDirectionType, 0);
		}

		// Token: 0x06024D52 RID: 150866 RVA: 0x0050EAA9 File Offset: 0x0050CCA9
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(1, gravityDirectionOffset, 0);
		}

		// Token: 0x06024D53 RID: 150867 RVA: 0x0050EAB4 File Offset: 0x0050CCB4
		public static void AddSafeLocation(FlatBufferBuilder builder, Offset<IVectorInfo> safeLocationOffset)
		{
			builder.AddOffset(2, safeLocationOffset.Value, 0);
		}

		// Token: 0x06024D54 RID: 150868 RVA: 0x0050EAC4 File Offset: 0x0050CCC4
		public static Offset<IGravityFlipTeleportConfig> EndIGravityFlipTeleportConfig(FlatBufferBuilder builder)
		{
			return new Offset<IGravityFlipTeleportConfig>(builder.EndTable());
		}

		// Token: 0x06024D55 RID: 150869 RVA: 0x0050EAD4 File Offset: 0x0050CCD4
		public IGravityFlipTeleportConfigT UnPack()
		{
			IGravityFlipTeleportConfigT gravityFlipTeleportConfigT = new IGravityFlipTeleportConfigT();
			this.UnPackTo(gravityFlipTeleportConfigT);
			return gravityFlipTeleportConfigT;
		}

		// Token: 0x06024D56 RID: 150870 RVA: 0x0050EAF0 File Offset: 0x0050CCF0
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

		// Token: 0x06024D57 RID: 150871 RVA: 0x0050EC50 File Offset: 0x0050CE50
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

		// Token: 0x0400F113 RID: 61715
		private Table __p;
	}
}
