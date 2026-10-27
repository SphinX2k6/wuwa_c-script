using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BD3 RID: 23507
	public struct IWuWaGoRoleInfo : IFlatbufferObject
	{
		// Token: 0x1700B19F RID: 45471
		// (get) Token: 0x0602846B RID: 164971 RVA: 0x00588ACC File Offset: 0x00586CCC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602846C RID: 164972 RVA: 0x00588AD9 File Offset: 0x00586CD9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602846D RID: 164973 RVA: 0x00588AE0 File Offset: 0x00586CE0
		public static IWuWaGoRoleInfo GetRootAsIWuWaGoRoleInfo(ByteBuffer _bb)
		{
			return IWuWaGoRoleInfo.GetRootAsIWuWaGoRoleInfo(_bb, default(IWuWaGoRoleInfo));
		}

		// Token: 0x0602846E RID: 164974 RVA: 0x00588AFC File Offset: 0x00586CFC
		public static IWuWaGoRoleInfo GetRootAsIWuWaGoRoleInfo(ByteBuffer _bb, IWuWaGoRoleInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602846F RID: 164975 RVA: 0x00588B19 File Offset: 0x00586D19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028470 RID: 164976 RVA: 0x00588B28 File Offset: 0x00586D28
		public IWuWaGoRoleInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B1A0 RID: 45472
		// (get) Token: 0x06028471 RID: 164977 RVA: 0x00588B38 File Offset: 0x00586D38
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

		// Token: 0x1700B1A1 RID: 45473
		// (get) Token: 0x06028472 RID: 164978 RVA: 0x00588B74 File Offset: 0x00586D74
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

		// Token: 0x1700B1A2 RID: 45474
		// (get) Token: 0x06028473 RID: 164979 RVA: 0x00588BD4 File Offset: 0x00586DD4
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

		// Token: 0x06028474 RID: 164980 RVA: 0x00588C31 File Offset: 0x00586E31
		public static Offset<IWuWaGoRoleInfo> CreateIWuWaGoRoleInfo(FlatBufferBuilder builder, EWuWaGoRoleType RoleType = EWuWaGoRoleType.AircraftSoldiers, Offset<IVectorInfo> PositionOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotationOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			IWuWaGoRoleInfo.AddRotation(builder, RotationOffset);
			IWuWaGoRoleInfo.AddPosition(builder, PositionOffset);
			IWuWaGoRoleInfo.AddRoleType(builder, RoleType);
			return IWuWaGoRoleInfo.EndIWuWaGoRoleInfo(builder);
		}

		// Token: 0x06028475 RID: 164981 RVA: 0x00588C55 File Offset: 0x00586E55
		public static void StartIWuWaGoRoleInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06028476 RID: 164982 RVA: 0x00588C5E File Offset: 0x00586E5E
		public static void AddRoleType(FlatBufferBuilder builder, EWuWaGoRoleType roleType)
		{
			builder.AddByte(0, (byte)roleType, 0);
		}

		// Token: 0x06028477 RID: 164983 RVA: 0x00588C69 File Offset: 0x00586E69
		public static void AddPosition(FlatBufferBuilder builder, Offset<IVectorInfo> positionOffset)
		{
			builder.AddOffset(1, positionOffset.Value, 0);
		}

		// Token: 0x06028478 RID: 164984 RVA: 0x00588C79 File Offset: 0x00586E79
		public static void AddRotation(FlatBufferBuilder builder, Offset<IVectorInfo> rotationOffset)
		{
			builder.AddOffset(2, rotationOffset.Value, 0);
		}

		// Token: 0x06028479 RID: 164985 RVA: 0x00588C89 File Offset: 0x00586E89
		public static Offset<IWuWaGoRoleInfo> EndIWuWaGoRoleInfo(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoRoleInfo>(builder.EndTable());
		}

		// Token: 0x0602847A RID: 164986 RVA: 0x00588C98 File Offset: 0x00586E98
		public IWuWaGoRoleInfoT UnPack()
		{
			IWuWaGoRoleInfoT wuWaGoRoleInfoT = new IWuWaGoRoleInfoT();
			this.UnPackTo(wuWaGoRoleInfoT);
			return wuWaGoRoleInfoT;
		}

		// Token: 0x0602847B RID: 164987 RVA: 0x00588CB4 File Offset: 0x00586EB4
		public void UnPackTo(IWuWaGoRoleInfoT _o)
		{
			_o.RoleType = this.RoleType;
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
			_o.Rotation = ((this.Rotation != null) ? this.Rotation.Value.UnPack() : null);
		}

		// Token: 0x0602847C RID: 164988 RVA: 0x00588D2C File Offset: 0x00586F2C
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

		// Token: 0x0400F351 RID: 62289
		private Table __p;
	}
}
