using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007355 RID: 29525
	public struct IOpenAirWall : IFlatbufferObject
	{
		// Token: 0x1700D875 RID: 55413
		// (get) Token: 0x0603380C RID: 210956 RVA: 0x006F0F14 File Offset: 0x006EF114
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603380D RID: 210957 RVA: 0x006F0F21 File Offset: 0x006EF121
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603380E RID: 210958 RVA: 0x006F0F28 File Offset: 0x006EF128
		public static IOpenAirWall GetRootAsIOpenAirWall(ByteBuffer _bb)
		{
			return IOpenAirWall.GetRootAsIOpenAirWall(_bb, default(IOpenAirWall));
		}

		// Token: 0x0603380F RID: 210959 RVA: 0x006F0F44 File Offset: 0x006EF144
		public static IOpenAirWall GetRootAsIOpenAirWall(ByteBuffer _bb, IOpenAirWall obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033810 RID: 210960 RVA: 0x006F0F61 File Offset: 0x006EF161
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033811 RID: 210961 RVA: 0x006F0F70 File Offset: 0x006EF170
		public IOpenAirWall __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D876 RID: 55414
		// (get) Token: 0x06033812 RID: 210962 RVA: 0x006F0F80 File Offset: 0x006EF180
		public EToggleAirWall Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EToggleAirWall.Open;
				}
				return (EToggleAirWall)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D877 RID: 55415
		// (get) Token: 0x06033813 RID: 210963 RVA: 0x006F0FBC File Offset: 0x006EF1BC
		public string HitEffectData
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033814 RID: 210964 RVA: 0x006F0FF3 File Offset: 0x006EF1F3
		public Span<byte> GetHitEffectDataBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06033815 RID: 210965 RVA: 0x006F1002 File Offset: 0x006EF202
		public byte[] GetHitEffectDataArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700D878 RID: 55416
		// (get) Token: 0x06033816 RID: 210966 RVA: 0x006F1010 File Offset: 0x006EF210
		public float HitCd
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D879 RID: 55417
		// (get) Token: 0x06033817 RID: 210967 RVA: 0x006F1050 File Offset: 0x006EF250
		public string AirWallEffectData
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033818 RID: 210968 RVA: 0x006F1088 File Offset: 0x006EF288
		public Span<byte> GetAirWallEffectDataBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06033819 RID: 210969 RVA: 0x006F1098 File Offset: 0x006EF298
		public byte[] GetAirWallEffectDataArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700D87A RID: 55418
		// (get) Token: 0x0603381A RID: 210970 RVA: 0x006F10A8 File Offset: 0x006EF2A8
		public string VectorArrayAirWallEffectData
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603381B RID: 210971 RVA: 0x006F10E0 File Offset: 0x006EF2E0
		public Span<byte> GetVectorArrayAirWallEffectDataBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0603381C RID: 210972 RVA: 0x006F10F0 File Offset: 0x006EF2F0
		public byte[] GetVectorArrayAirWallEffectDataArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700D87B RID: 55419
		// (get) Token: 0x0603381D RID: 210973 RVA: 0x006F1100 File Offset: 0x006EF300
		public int AirWallEffectSplineEntityId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D87C RID: 55420
		// (get) Token: 0x0603381E RID: 210974 RVA: 0x006F1140 File Offset: 0x006EF340
		public float AirWallEffectHeight
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D87D RID: 55421
		// (get) Token: 0x0603381F RID: 210975 RVA: 0x006F1184 File Offset: 0x006EF384
		public float AirWallEffectThickness
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D87E RID: 55422
		// (get) Token: 0x06033820 RID: 210976 RVA: 0x006F11C8 File Offset: 0x006EF3C8
		public EAirWallCollisionPreset CollisionPreset
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return EAirWallCollisionPreset.Normal;
				}
				return (EAirWallCollisionPreset)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D87F RID: 55423
		// (get) Token: 0x06033821 RID: 210977 RVA: 0x006F1208 File Offset: 0x006EF408
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033822 RID: 210978 RVA: 0x006F1248 File Offset: 0x006EF448
		public static Offset<IOpenAirWall> CreateIOpenAirWall(FlatBufferBuilder builder, EToggleAirWall Type = EToggleAirWall.Open, StringOffset HitEffectDataOffset = default(StringOffset), float HitCd = 0f, StringOffset AirWallEffectDataOffset = default(StringOffset), StringOffset VectorArrayAirWallEffectDataOffset = default(StringOffset), int AirWallEffectSplineEntityId = 0, float AirWallEffectHeight = 0f, float AirWallEffectThickness = 0f, EAirWallCollisionPreset CollisionPreset = EAirWallCollisionPreset.Normal, byte NullMask = 0)
		{
			builder.StartTable(10);
			IOpenAirWall.AddAirWallEffectThickness(builder, AirWallEffectThickness);
			IOpenAirWall.AddAirWallEffectHeight(builder, AirWallEffectHeight);
			IOpenAirWall.AddAirWallEffectSplineEntityId(builder, AirWallEffectSplineEntityId);
			IOpenAirWall.AddVectorArrayAirWallEffectData(builder, VectorArrayAirWallEffectDataOffset);
			IOpenAirWall.AddAirWallEffectData(builder, AirWallEffectDataOffset);
			IOpenAirWall.AddHitCd(builder, HitCd);
			IOpenAirWall.AddHitEffectData(builder, HitEffectDataOffset);
			IOpenAirWall.AddNullMask(builder, NullMask);
			IOpenAirWall.AddCollisionPreset(builder, CollisionPreset);
			IOpenAirWall.AddType(builder, Type);
			return IOpenAirWall.EndIOpenAirWall(builder);
		}

		// Token: 0x06033823 RID: 210979 RVA: 0x006F12B0 File Offset: 0x006EF4B0
		public static void StartIOpenAirWall(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x06033824 RID: 210980 RVA: 0x006F12BA File Offset: 0x006EF4BA
		public static void AddType(FlatBufferBuilder builder, EToggleAirWall type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033825 RID: 210981 RVA: 0x006F12C5 File Offset: 0x006EF4C5
		public static void AddHitEffectData(FlatBufferBuilder builder, StringOffset hitEffectDataOffset)
		{
			builder.AddOffset(1, hitEffectDataOffset.Value, 0);
		}

		// Token: 0x06033826 RID: 210982 RVA: 0x006F12D5 File Offset: 0x006EF4D5
		public static void AddHitCd(FlatBufferBuilder builder, float hitCd)
		{
			builder.AddFloat(2, hitCd, 0.0);
		}

		// Token: 0x06033827 RID: 210983 RVA: 0x006F12E8 File Offset: 0x006EF4E8
		public static void AddAirWallEffectData(FlatBufferBuilder builder, StringOffset airWallEffectDataOffset)
		{
			builder.AddOffset(3, airWallEffectDataOffset.Value, 0);
		}

		// Token: 0x06033828 RID: 210984 RVA: 0x006F12F8 File Offset: 0x006EF4F8
		public static void AddVectorArrayAirWallEffectData(FlatBufferBuilder builder, StringOffset vectorArrayAirWallEffectDataOffset)
		{
			builder.AddOffset(4, vectorArrayAirWallEffectDataOffset.Value, 0);
		}

		// Token: 0x06033829 RID: 210985 RVA: 0x006F1308 File Offset: 0x006EF508
		public static void AddAirWallEffectSplineEntityId(FlatBufferBuilder builder, int airWallEffectSplineEntityId)
		{
			builder.AddInt(5, airWallEffectSplineEntityId, 0);
		}

		// Token: 0x0603382A RID: 210986 RVA: 0x006F1313 File Offset: 0x006EF513
		public static void AddAirWallEffectHeight(FlatBufferBuilder builder, float airWallEffectHeight)
		{
			builder.AddFloat(6, airWallEffectHeight, 0.0);
		}

		// Token: 0x0603382B RID: 210987 RVA: 0x006F1326 File Offset: 0x006EF526
		public static void AddAirWallEffectThickness(FlatBufferBuilder builder, float airWallEffectThickness)
		{
			builder.AddFloat(7, airWallEffectThickness, 0.0);
		}

		// Token: 0x0603382C RID: 210988 RVA: 0x006F1339 File Offset: 0x006EF539
		public static void AddCollisionPreset(FlatBufferBuilder builder, EAirWallCollisionPreset collisionPreset)
		{
			builder.AddByte(8, (byte)collisionPreset, 0);
		}

		// Token: 0x0603382D RID: 210989 RVA: 0x006F1344 File Offset: 0x006EF544
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x0603382E RID: 210990 RVA: 0x006F1350 File Offset: 0x006EF550
		public static Offset<IOpenAirWall> EndIOpenAirWall(FlatBufferBuilder builder)
		{
			return new Offset<IOpenAirWall>(builder.EndTable());
		}

		// Token: 0x0603382F RID: 210991 RVA: 0x006F1360 File Offset: 0x006EF560
		public IOpenAirWallT UnPack()
		{
			IOpenAirWallT openAirWallT = new IOpenAirWallT();
			this.UnPackTo(openAirWallT);
			return openAirWallT;
		}

		// Token: 0x06033830 RID: 210992 RVA: 0x006F137C File Offset: 0x006EF57C
		public void UnPackTo(IOpenAirWallT _o)
		{
			_o.Type = this.Type;
			_o.HitEffectData = this.HitEffectData;
			_o.HitCd = this.HitCd;
			_o.AirWallEffectData = this.AirWallEffectData;
			_o.VectorArrayAirWallEffectData = this.VectorArrayAirWallEffectData;
			_o.AirWallEffectSplineEntityId = this.AirWallEffectSplineEntityId;
			_o.AirWallEffectHeight = this.AirWallEffectHeight;
			_o.AirWallEffectThickness = this.AirWallEffectThickness;
			_o.CollisionPreset = this.CollisionPreset;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06033831 RID: 210993 RVA: 0x006F1404 File Offset: 0x006EF604
		public static Offset<IOpenAirWall> Pack(FlatBufferBuilder builder, IOpenAirWallT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenAirWall>);
			}
			StringOffset hitEffectDataOffset = (_o.HitEffectData == null) ? default(StringOffset) : builder.CreateString(_o.HitEffectData);
			StringOffset airWallEffectDataOffset = (_o.AirWallEffectData == null) ? default(StringOffset) : builder.CreateString(_o.AirWallEffectData);
			StringOffset vectorArrayAirWallEffectDataOffset = (_o.VectorArrayAirWallEffectData == null) ? default(StringOffset) : builder.CreateString(_o.VectorArrayAirWallEffectData);
			return IOpenAirWall.CreateIOpenAirWall(builder, _o.Type, hitEffectDataOffset, _o.HitCd, airWallEffectDataOffset, vectorArrayAirWallEffectDataOffset, _o.AirWallEffectSplineEntityId, _o.AirWallEffectHeight, _o.AirWallEffectThickness, _o.CollisionPreset, _o.NullMask);
		}

		// Token: 0x04012431 RID: 74801
		private Table __p;
	}
}
