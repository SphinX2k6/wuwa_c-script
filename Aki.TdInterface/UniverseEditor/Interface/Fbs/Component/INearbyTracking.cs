using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055F0 RID: 22000
	public struct INearbyTracking : IFlatbufferObject
	{
		// Token: 0x1700A2C7 RID: 41671
		// (get) Token: 0x060247F1 RID: 149489 RVA: 0x00509936 File Offset: 0x00507B36
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060247F2 RID: 149490 RVA: 0x00509943 File Offset: 0x00507B43
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060247F3 RID: 149491 RVA: 0x0050994C File Offset: 0x00507B4C
		public static INearbyTracking GetRootAsINearbyTracking(ByteBuffer _bb)
		{
			return INearbyTracking.GetRootAsINearbyTracking(_bb, default(INearbyTracking));
		}

		// Token: 0x060247F4 RID: 149492 RVA: 0x00509968 File Offset: 0x00507B68
		public static INearbyTracking GetRootAsINearbyTracking(ByteBuffer _bb, INearbyTracking obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060247F5 RID: 149493 RVA: 0x00509985 File Offset: 0x00507B85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060247F6 RID: 149494 RVA: 0x00509994 File Offset: 0x00507B94
		public INearbyTracking __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A2C8 RID: 41672
		// (get) Token: 0x060247F7 RID: 149495 RVA: 0x005099A4 File Offset: 0x00507BA4
		public ENearbyTrackingType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENearbyTrackingType.Icon;
				}
				return (ENearbyTrackingType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060247F8 RID: 149496 RVA: 0x005099E0 File Offset: 0x00507BE0
		public static Offset<INearbyTracking> CreateINearbyTracking(FlatBufferBuilder builder, ENearbyTrackingType Type = ENearbyTrackingType.Icon)
		{
			builder.StartTable(1);
			INearbyTracking.AddType(builder, Type);
			return INearbyTracking.EndINearbyTracking(builder);
		}

		// Token: 0x060247F9 RID: 149497 RVA: 0x005099F6 File Offset: 0x00507BF6
		public static void StartINearbyTracking(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060247FA RID: 149498 RVA: 0x005099FF File Offset: 0x00507BFF
		public static void AddType(FlatBufferBuilder builder, ENearbyTrackingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060247FB RID: 149499 RVA: 0x00509A0A File Offset: 0x00507C0A
		public static Offset<INearbyTracking> EndINearbyTracking(FlatBufferBuilder builder)
		{
			return new Offset<INearbyTracking>(builder.EndTable());
		}

		// Token: 0x060247FC RID: 149500 RVA: 0x00509A18 File Offset: 0x00507C18
		public INearbyTrackingT UnPack()
		{
			INearbyTrackingT nearbyTrackingT = new INearbyTrackingT();
			this.UnPackTo(nearbyTrackingT);
			return nearbyTrackingT;
		}

		// Token: 0x060247FD RID: 149501 RVA: 0x00509A33 File Offset: 0x00507C33
		public void UnPackTo(INearbyTrackingT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060247FE RID: 149502 RVA: 0x00509A44 File Offset: 0x00507C44
		public static Offset<INearbyTracking> Pack(FlatBufferBuilder builder, INearbyTrackingT _o)
		{
			if (_o == null)
			{
				return default(Offset<INearbyTracking>);
			}
			return INearbyTracking.CreateINearbyTracking(builder, _o.Type);
		}

		// Token: 0x0400E95D RID: 59741
		private Table __p;
	}
}
