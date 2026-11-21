using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053A0 RID: 21408
	public struct IAirWallBothSidesStyle : IFlatbufferObject
	{
		// Token: 0x1700976B RID: 38763
		// (get) Token: 0x06021683 RID: 136835 RVA: 0x0049C0E3 File Offset: 0x0049A2E3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021684 RID: 136836 RVA: 0x0049C0F0 File Offset: 0x0049A2F0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021685 RID: 136837 RVA: 0x0049C0F8 File Offset: 0x0049A2F8
		public static IAirWallBothSidesStyle GetRootAsIAirWallBothSidesStyle(ByteBuffer _bb)
		{
			return IAirWallBothSidesStyle.GetRootAsIAirWallBothSidesStyle(_bb, default(IAirWallBothSidesStyle));
		}

		// Token: 0x06021686 RID: 136838 RVA: 0x0049C114 File Offset: 0x0049A314
		public static IAirWallBothSidesStyle GetRootAsIAirWallBothSidesStyle(ByteBuffer _bb, IAirWallBothSidesStyle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021687 RID: 136839 RVA: 0x0049C131 File Offset: 0x0049A331
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021688 RID: 136840 RVA: 0x0049C140 File Offset: 0x0049A340
		public IAirWallBothSidesStyle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700976C RID: 38764
		// (get) Token: 0x06021689 RID: 136841 RVA: 0x0049C150 File Offset: 0x0049A350
		public EAirWallSpawnStyle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAirWallSpawnStyle.AlongSpline;
				}
				return (EAirWallSpawnStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700976D RID: 38765
		// (get) Token: 0x0602168A RID: 136842 RVA: 0x0049C18C File Offset: 0x0049A38C
		public float GapWidth
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602168B RID: 136843 RVA: 0x0049C1CC File Offset: 0x0049A3CC
		public static Offset<IAirWallBothSidesStyle> CreateIAirWallBothSidesStyle(FlatBufferBuilder builder, EAirWallSpawnStyle Type = EAirWallSpawnStyle.AlongSpline, float GapWidth = 0f)
		{
			builder.StartTable(2);
			IAirWallBothSidesStyle.AddGapWidth(builder, GapWidth);
			IAirWallBothSidesStyle.AddType(builder, Type);
			return IAirWallBothSidesStyle.EndIAirWallBothSidesStyle(builder);
		}

		// Token: 0x0602168C RID: 136844 RVA: 0x0049C1E9 File Offset: 0x0049A3E9
		public static void StartIAirWallBothSidesStyle(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602168D RID: 136845 RVA: 0x0049C1F2 File Offset: 0x0049A3F2
		public static void AddType(FlatBufferBuilder builder, EAirWallSpawnStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602168E RID: 136846 RVA: 0x0049C1FD File Offset: 0x0049A3FD
		public static void AddGapWidth(FlatBufferBuilder builder, float gapWidth)
		{
			builder.AddFloat(1, gapWidth, 0.0);
		}

		// Token: 0x0602168F RID: 136847 RVA: 0x0049C210 File Offset: 0x0049A410
		public static Offset<IAirWallBothSidesStyle> EndIAirWallBothSidesStyle(FlatBufferBuilder builder)
		{
			return new Offset<IAirWallBothSidesStyle>(builder.EndTable());
		}

		// Token: 0x06021690 RID: 136848 RVA: 0x0049C220 File Offset: 0x0049A420
		public IAirWallBothSidesStyleT UnPack()
		{
			IAirWallBothSidesStyleT airWallBothSidesStyleT = new IAirWallBothSidesStyleT();
			this.UnPackTo(airWallBothSidesStyleT);
			return airWallBothSidesStyleT;
		}

		// Token: 0x06021691 RID: 136849 RVA: 0x0049C23B File Offset: 0x0049A43B
		public void UnPackTo(IAirWallBothSidesStyleT _o)
		{
			_o.Type = this.Type;
			_o.GapWidth = this.GapWidth;
		}

		// Token: 0x06021692 RID: 136850 RVA: 0x0049C258 File Offset: 0x0049A458
		public static Offset<IAirWallBothSidesStyle> Pack(FlatBufferBuilder builder, IAirWallBothSidesStyleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAirWallBothSidesStyle>);
			}
			return IAirWallBothSidesStyle.CreateIAirWallBothSidesStyle(builder, _o.Type, _o.GapWidth);
		}

		// Token: 0x0400E7D8 RID: 59352
		private Table __p;
	}
}
