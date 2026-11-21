using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053AF RID: 21423
	public struct IAirWallSpawnStyle : IFlatbufferObject
	{
		// Token: 0x1700978F RID: 38799
		// (get) Token: 0x0602170B RID: 136971 RVA: 0x0049D09A File Offset: 0x0049B29A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602170C RID: 136972 RVA: 0x0049D0A7 File Offset: 0x0049B2A7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602170D RID: 136973 RVA: 0x0049D0B0 File Offset: 0x0049B2B0
		public static IAirWallSpawnStyle GetRootAsIAirWallSpawnStyle(ByteBuffer _bb)
		{
			return IAirWallSpawnStyle.GetRootAsIAirWallSpawnStyle(_bb, default(IAirWallSpawnStyle));
		}

		// Token: 0x0602170E RID: 136974 RVA: 0x0049D0CC File Offset: 0x0049B2CC
		public static IAirWallSpawnStyle GetRootAsIAirWallSpawnStyle(ByteBuffer _bb, IAirWallSpawnStyle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602170F RID: 136975 RVA: 0x0049D0E9 File Offset: 0x0049B2E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021710 RID: 136976 RVA: 0x0049D0F8 File Offset: 0x0049B2F8
		public IAirWallSpawnStyle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009790 RID: 38800
		// (get) Token: 0x06021711 RID: 136977 RVA: 0x0049D108 File Offset: 0x0049B308
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

		// Token: 0x06021712 RID: 136978 RVA: 0x0049D144 File Offset: 0x0049B344
		public static Offset<IAirWallSpawnStyle> CreateIAirWallSpawnStyle(FlatBufferBuilder builder, EAirWallSpawnStyle Type = EAirWallSpawnStyle.AlongSpline)
		{
			builder.StartTable(1);
			IAirWallSpawnStyle.AddType(builder, Type);
			return IAirWallSpawnStyle.EndIAirWallSpawnStyle(builder);
		}

		// Token: 0x06021713 RID: 136979 RVA: 0x0049D15A File Offset: 0x0049B35A
		public static void StartIAirWallSpawnStyle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06021714 RID: 136980 RVA: 0x0049D163 File Offset: 0x0049B363
		public static void AddType(FlatBufferBuilder builder, EAirWallSpawnStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021715 RID: 136981 RVA: 0x0049D16E File Offset: 0x0049B36E
		public static Offset<IAirWallSpawnStyle> EndIAirWallSpawnStyle(FlatBufferBuilder builder)
		{
			return new Offset<IAirWallSpawnStyle>(builder.EndTable());
		}

		// Token: 0x06021716 RID: 136982 RVA: 0x0049D17C File Offset: 0x0049B37C
		public IAirWallSpawnStyleT UnPack()
		{
			IAirWallSpawnStyleT airWallSpawnStyleT = new IAirWallSpawnStyleT();
			this.UnPackTo(airWallSpawnStyleT);
			return airWallSpawnStyleT;
		}

		// Token: 0x06021717 RID: 136983 RVA: 0x0049D197 File Offset: 0x0049B397
		public void UnPackTo(IAirWallSpawnStyleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06021718 RID: 136984 RVA: 0x0049D1A8 File Offset: 0x0049B3A8
		public static Offset<IAirWallSpawnStyle> Pack(FlatBufferBuilder builder, IAirWallSpawnStyleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAirWallSpawnStyle>);
			}
			return IAirWallSpawnStyle.CreateIAirWallSpawnStyle(builder, _o.Type);
		}

		// Token: 0x0400E7F1 RID: 59377
		private Table __p;
	}
}
