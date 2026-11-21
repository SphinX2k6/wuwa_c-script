using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B8E RID: 23438
	public struct INearbyTracking : IFlatbufferObject
	{
		// Token: 0x1700AB4F RID: 43855
		// (get) Token: 0x060269FE RID: 158206 RVA: 0x00549EAE File Offset: 0x005480AE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060269FF RID: 158207 RVA: 0x00549EBB File Offset: 0x005480BB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026A00 RID: 158208 RVA: 0x00549EC4 File Offset: 0x005480C4
		public static INearbyTracking GetRootAsINearbyTracking(ByteBuffer _bb)
		{
			return INearbyTracking.GetRootAsINearbyTracking(_bb, default(INearbyTracking));
		}

		// Token: 0x06026A01 RID: 158209 RVA: 0x00549EE0 File Offset: 0x005480E0
		public static INearbyTracking GetRootAsINearbyTracking(ByteBuffer _bb, INearbyTracking obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026A02 RID: 158210 RVA: 0x00549EFD File Offset: 0x005480FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026A03 RID: 158211 RVA: 0x00549F0C File Offset: 0x0054810C
		public INearbyTracking __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AB50 RID: 43856
		// (get) Token: 0x06026A04 RID: 158212 RVA: 0x00549F1C File Offset: 0x0054811C
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

		// Token: 0x06026A05 RID: 158213 RVA: 0x00549F58 File Offset: 0x00548158
		public static Offset<INearbyTracking> CreateINearbyTracking(FlatBufferBuilder builder, ENearbyTrackingType Type = ENearbyTrackingType.Icon)
		{
			builder.StartTable(1);
			INearbyTracking.AddType(builder, Type);
			return INearbyTracking.EndINearbyTracking(builder);
		}

		// Token: 0x06026A06 RID: 158214 RVA: 0x00549F6E File Offset: 0x0054816E
		public static void StartINearbyTracking(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06026A07 RID: 158215 RVA: 0x00549F77 File Offset: 0x00548177
		public static void AddType(FlatBufferBuilder builder, ENearbyTrackingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026A08 RID: 158216 RVA: 0x00549F82 File Offset: 0x00548182
		public static Offset<INearbyTracking> EndINearbyTracking(FlatBufferBuilder builder)
		{
			return new Offset<INearbyTracking>(builder.EndTable());
		}

		// Token: 0x06026A09 RID: 158217 RVA: 0x00549F90 File Offset: 0x00548190
		public INearbyTrackingT UnPack()
		{
			INearbyTrackingT nearbyTrackingT = new INearbyTrackingT();
			this.UnPackTo(nearbyTrackingT);
			return nearbyTrackingT;
		}

		// Token: 0x06026A0A RID: 158218 RVA: 0x00549FAB File Offset: 0x005481AB
		public void UnPackTo(INearbyTrackingT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06026A0B RID: 158219 RVA: 0x00549FBC File Offset: 0x005481BC
		public static Offset<INearbyTracking> Pack(FlatBufferBuilder builder, INearbyTrackingT _o)
		{
			if (_o == null)
			{
				return default(Offset<INearbyTracking>);
			}
			return INearbyTracking.CreateINearbyTracking(builder, _o.Type);
		}

		// Token: 0x0400F5BF RID: 62911
		private Table __p;
	}
}
