using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053A3 RID: 21411
	public struct IAirWallCover : IFlatbufferObject
	{
		// Token: 0x17009770 RID: 38768
		// (get) Token: 0x06021699 RID: 136857 RVA: 0x0049C2F2 File Offset: 0x0049A4F2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602169A RID: 136858 RVA: 0x0049C2FF File Offset: 0x0049A4FF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602169B RID: 136859 RVA: 0x0049C308 File Offset: 0x0049A508
		public static IAirWallCover GetRootAsIAirWallCover(ByteBuffer _bb)
		{
			return IAirWallCover.GetRootAsIAirWallCover(_bb, default(IAirWallCover));
		}

		// Token: 0x0602169C RID: 136860 RVA: 0x0049C324 File Offset: 0x0049A524
		public static IAirWallCover GetRootAsIAirWallCover(ByteBuffer _bb, IAirWallCover obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602169D RID: 136861 RVA: 0x0049C341 File Offset: 0x0049A541
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602169E RID: 136862 RVA: 0x0049C350 File Offset: 0x0049A550
		public IAirWallCover __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009771 RID: 38769
		// (get) Token: 0x0602169F RID: 136863 RVA: 0x0049C360 File Offset: 0x0049A560
		public float Height
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060216A0 RID: 136864 RVA: 0x0049C3A0 File Offset: 0x0049A5A0
		public static Offset<IAirWallCover> CreateIAirWallCover(FlatBufferBuilder builder, float Height = 0f)
		{
			builder.StartTable(1);
			IAirWallCover.AddHeight(builder, Height);
			return IAirWallCover.EndIAirWallCover(builder);
		}

		// Token: 0x060216A1 RID: 136865 RVA: 0x0049C3B6 File Offset: 0x0049A5B6
		public static void StartIAirWallCover(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060216A2 RID: 136866 RVA: 0x0049C3BF File Offset: 0x0049A5BF
		public static void AddHeight(FlatBufferBuilder builder, float height)
		{
			builder.AddFloat(0, height, 0.0);
		}

		// Token: 0x060216A3 RID: 136867 RVA: 0x0049C3D2 File Offset: 0x0049A5D2
		public static Offset<IAirWallCover> EndIAirWallCover(FlatBufferBuilder builder)
		{
			return new Offset<IAirWallCover>(builder.EndTable());
		}

		// Token: 0x060216A4 RID: 136868 RVA: 0x0049C3E0 File Offset: 0x0049A5E0
		public IAirWallCoverT UnPack()
		{
			IAirWallCoverT airWallCoverT = new IAirWallCoverT();
			this.UnPackTo(airWallCoverT);
			return airWallCoverT;
		}

		// Token: 0x060216A5 RID: 136869 RVA: 0x0049C3FB File Offset: 0x0049A5FB
		public void UnPackTo(IAirWallCoverT _o)
		{
			_o.Height = this.Height;
		}

		// Token: 0x060216A6 RID: 136870 RVA: 0x0049C40C File Offset: 0x0049A60C
		public static Offset<IAirWallCover> Pack(FlatBufferBuilder builder, IAirWallCoverT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAirWallCover>);
			}
			return IAirWallCover.CreateIAirWallCover(builder, _o.Height);
		}

		// Token: 0x0400E7DB RID: 59355
		private Table __p;
	}
}
