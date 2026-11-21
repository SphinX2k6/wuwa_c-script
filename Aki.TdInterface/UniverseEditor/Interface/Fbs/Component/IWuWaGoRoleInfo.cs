using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061E9 RID: 25065
	public struct IWuWaGoRoleInfo : IFlatbufferObject
	{
		// Token: 0x1700BAE7 RID: 47847
		// (get) Token: 0x0602AA2F RID: 174639 RVA: 0x005D055C File Offset: 0x005CE75C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602AA30 RID: 174640 RVA: 0x005D0569 File Offset: 0x005CE769
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602AA31 RID: 174641 RVA: 0x005D0570 File Offset: 0x005CE770
		public static IWuWaGoRoleInfo GetRootAsIWuWaGoRoleInfo(ByteBuffer _bb)
		{
			return IWuWaGoRoleInfo.GetRootAsIWuWaGoRoleInfo(_bb, default(IWuWaGoRoleInfo));
		}

		// Token: 0x0602AA32 RID: 174642 RVA: 0x005D058C File Offset: 0x005CE78C
		public static IWuWaGoRoleInfo GetRootAsIWuWaGoRoleInfo(ByteBuffer _bb, IWuWaGoRoleInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602AA33 RID: 174643 RVA: 0x005D05A9 File Offset: 0x005CE7A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602AA34 RID: 174644 RVA: 0x005D05B8 File Offset: 0x005CE7B8
		public IWuWaGoRoleInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BAE8 RID: 47848
		// (get) Token: 0x0602AA35 RID: 174645 RVA: 0x005D05C8 File Offset: 0x005CE7C8
		public EWuWaGoRoleType RoleType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWuWaGoRoleType.AircraftSoldiers;
				}
				return (EWuWaGoRoleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BAE9 RID: 47849
		// (get) Token: 0x0602AA36 RID: 174646 RVA: 0x005D0604 File Offset: 0x005CE804
		public IVectorInfo? Position
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700BAEA RID: 47850
		// (get) Token: 0x0602AA37 RID: 174647 RVA: 0x005D0664 File Offset: 0x005CE864
		public IVectorInfo? Rotation
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

		// Token: 0x0602AA38 RID: 174648 RVA: 0x005D06C1 File Offset: 0x005CE8C1
		public static Offset<IWuWaGoRoleInfo> CreateIWuWaGoRoleInfo(FlatBufferBuilder builder, EWuWaGoRoleType RoleType = EWuWaGoRoleType.AircraftSoldiers, Offset<IVectorInfo> PositionOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotationOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			IWuWaGoRoleInfo.AddRotation(builder, RotationOffset);
			IWuWaGoRoleInfo.AddPosition(builder, PositionOffset);
			IWuWaGoRoleInfo.AddRoleType(builder, RoleType);
			return IWuWaGoRoleInfo.EndIWuWaGoRoleInfo(builder);
		}

		// Token: 0x0602AA39 RID: 174649 RVA: 0x005D06E5 File Offset: 0x005CE8E5
		public static void StartIWuWaGoRoleInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602AA3A RID: 174650 RVA: 0x005D06EE File Offset: 0x005CE8EE
		public static void AddRoleType(FlatBufferBuilder builder, EWuWaGoRoleType roleType)
		{
			builder.AddByte(0, (byte)roleType, 0);
		}

		// Token: 0x0602AA3B RID: 174651 RVA: 0x005D06F9 File Offset: 0x005CE8F9
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(1, positionOffset.Value, 0);
		}

		// Token: 0x0602AA3C RID: 174652 RVA: 0x005D0709 File Offset: 0x005CE909
		public static void AddRotation(FlatBufferBuilder builder, Offset<IVectorInfo> rotationOffset)
		{
			builder.AddOffset(2, rotationOffset.Value, 0);
		}

		// Token: 0x0602AA3D RID: 174653 RVA: 0x005D0719 File Offset: 0x005CE919
		public static Offset<IWuWaGoRoleInfo> EndIWuWaGoRoleInfo(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoRoleInfo>(builder.EndTable());
		}

		// Token: 0x0602AA3E RID: 174654 RVA: 0x005D0728 File Offset: 0x005CE928
		public IWuWaGoRoleInfoT UnPack()
		{
			IWuWaGoRoleInfoT wuWaGoRoleInfoT = new IWuWaGoRoleInfoT();
			this.UnPackTo(wuWaGoRoleInfoT);
			return wuWaGoRoleInfoT;
		}

		// Token: 0x0602AA3F RID: 174655 RVA: 0x005D0744 File Offset: 0x005CE944
		public void UnPackTo(IWuWaGoRoleInfoT _o)
		{
			_o.RoleType = this.RoleType;
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
			_o.Rotation = ((this.Rotation != null) ? this.Rotation.Value.UnPack() : null);
		}

		// Token: 0x0602AA40 RID: 174656 RVA: 0x005D07BC File Offset: 0x005CE9BC
		public static Offset<IWuWaGoRoleInfo> Pack(FlatBufferBuilder builder, IWuWaGoRoleInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWuWaGoRoleInfo>);
			}
			Offset<IVectorInfo> positionOffset = (_o.Position == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Position);
			Offset<IVectorInfo> rotationOffset = (_o.Rotation == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rotation);
			return IWuWaGoRoleInfo.CreateIWuWaGoRoleInfo(builder, _o.RoleType, positionOffset, rotationOffset);
		}

		// Token: 0x04010057 RID: 65623
		private Table __p;
	}
}
