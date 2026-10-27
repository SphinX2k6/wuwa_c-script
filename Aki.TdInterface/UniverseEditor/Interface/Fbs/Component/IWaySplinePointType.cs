using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B5F RID: 23391
	public struct IWaySplinePointType : IFlatbufferObject
	{
		// Token: 0x1700B0BD RID: 45245
		// (get) Token: 0x0602806D RID: 163949 RVA: 0x00580EDE File Offset: 0x0057F0DE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602806E RID: 163950 RVA: 0x00580EEB File Offset: 0x0057F0EB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602806F RID: 163951 RVA: 0x00580EF4 File Offset: 0x0057F0F4
		public static IWaySplinePointType GetRootAsIWaySplinePointType(ByteBuffer _bb)
		{
			return IWaySplinePointType.GetRootAsIWaySplinePointType(_bb, default(IWaySplinePointType));
		}

		// Token: 0x06028070 RID: 163952 RVA: 0x00580F10 File Offset: 0x0057F110
		public static IWaySplinePointType GetRootAsIWaySplinePointType(ByteBuffer _bb, IWaySplinePointType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028071 RID: 163953 RVA: 0x00580F2D File Offset: 0x0057F12D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028072 RID: 163954 RVA: 0x00580F3C File Offset: 0x0057F13C
		public IWaySplinePointType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B0BE RID: 45246
		// (get) Token: 0x06028073 RID: 163955 RVA: 0x00580F4C File Offset: 0x0057F14C
		public EWaySplinePointType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWaySplinePointType.Common;
				}
				return (EWaySplinePointType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028074 RID: 163956 RVA: 0x00580F88 File Offset: 0x0057F188
		public static Offset<IWaySplinePointType> CreateIWaySplinePointType(FlatBufferBuilder builder, EWaySplinePointType Type = EWaySplinePointType.Common)
		{
			builder.StartTable(1);
			IWaySplinePointType.AddType(builder, Type);
			return IWaySplinePointType.EndIWaySplinePointType(builder);
		}

		// Token: 0x06028075 RID: 163957 RVA: 0x00580F9E File Offset: 0x0057F19E
		public static void StartIWaySplinePointType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06028076 RID: 163958 RVA: 0x00580FA7 File Offset: 0x0057F1A7
		public static void AddType(FlatBufferBuilder builder, EWaySplinePointType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028077 RID: 163959 RVA: 0x00580FB2 File Offset: 0x0057F1B2
		public static Offset<IWaySplinePointType> EndIWaySplinePointType(FlatBufferBuilder builder)
		{
			return new Offset<IWaySplinePointType>(builder.EndTable());
		}

		// Token: 0x06028078 RID: 163960 RVA: 0x00580FC0 File Offset: 0x0057F1C0
		public IWaySplinePointTypeT UnPack()
		{
			IWaySplinePointTypeT waySplinePointTypeT = new IWaySplinePointTypeT();
			this.UnPackTo(waySplinePointTypeT);
			return waySplinePointTypeT;
		}

		// Token: 0x06028079 RID: 163961 RVA: 0x00580FDB File Offset: 0x0057F1DB
		public void UnPackTo(IWaySplinePointTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602807A RID: 163962 RVA: 0x00580FEC File Offset: 0x0057F1EC
		public static Offset<IWaySplinePointType> Pack(FlatBufferBuilder builder, IWaySplinePointTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWaySplinePointType>);
			}
			return IWaySplinePointType.CreateIWaySplinePointType(builder, _o.Type);
		}

		// Token: 0x0400F2AA RID: 62122
		private Table __p;
	}
}
