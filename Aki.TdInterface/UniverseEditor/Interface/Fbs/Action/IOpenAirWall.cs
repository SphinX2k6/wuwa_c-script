using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BF1 RID: 27633
	public struct IOpenAirWall : IFlatbufferObject
	{
		// Token: 0x1700CD69 RID: 52585
		// (get) Token: 0x060308F0 RID: 198896 RVA: 0x00697614 File Offset: 0x00695814
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060308F1 RID: 198897 RVA: 0x00697621 File Offset: 0x00695821
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060308F2 RID: 198898 RVA: 0x00697628 File Offset: 0x00695828
		public static IOpenAirWall GetRootAsIOpenAirWall(ByteBuffer _bb)
		{
			return IOpenAirWall.GetRootAsIOpenAirWall(_bb, default(IOpenAirWall));
		}

		// Token: 0x060308F3 RID: 198899 RVA: 0x00697644 File Offset: 0x00695844
		public static IOpenAirWall GetRootAsIOpenAirWall(ByteBuffer _bb, IOpenAirWall obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060308F4 RID: 198900 RVA: 0x00697661 File Offset: 0x00695861
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060308F5 RID: 198901 RVA: 0x00697670 File Offset: 0x00695870
		public IOpenAirWall __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD6A RID: 52586
		// (get) Token: 0x060308F6 RID: 198902 RVA: 0x00697680 File Offset: 0x00695880
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

		// Token: 0x1700CD6B RID: 52587
		// (get) Token: 0x060308F7 RID: 198903 RVA: 0x006976BC File Offset: 0x006958BC
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

		// Token: 0x060308F8 RID: 198904 RVA: 0x006976F3 File Offset: 0x006958F3
		public Span<byte> GetHitEffectDataBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060308F9 RID: 198905 RVA: 0x00697702 File Offset: 0x00695902
		public byte[] GetHitEffectDataArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700CD6C RID: 52588
		// (get) Token: 0x060308FA RID: 198906 RVA: 0x00697710 File Offset: 0x00695910
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

		// Token: 0x1700CD6D RID: 52589
		// (get) Token: 0x060308FB RID: 198907 RVA: 0x00697750 File Offset: 0x00695950
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

		// Token: 0x060308FC RID: 198908 RVA: 0x00697788 File Offset: 0x00695988
		public Span<byte> GetAirWallEffectDataBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060308FD RID: 198909 RVA: 0x00697798 File Offset: 0x00695998
		public byte[] GetAirWallEffectDataArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700CD6E RID: 52590
		// (get) Token: 0x060308FE RID: 198910 RVA: 0x006977A8 File Offset: 0x006959A8
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

		// Token: 0x060308FF RID: 198911 RVA: 0x006977E0 File Offset: 0x006959E0
		public Span<byte> GetVectorArrayAirWallEffectDataBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06030900 RID: 198912 RVA: 0x006977F0 File Offset: 0x006959F0
		public byte[] GetVectorArrayAirWallEffectDataArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700CD6F RID: 52591
		// (get) Token: 0x06030901 RID: 198913 RVA: 0x00697800 File Offset: 0x00695A00
		public float AirWallEffectHeight
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CD70 RID: 52592
		// (get) Token: 0x06030902 RID: 198914 RVA: 0x00697844 File Offset: 0x00695A44
		public float AirWallEffectThickness
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

		// Token: 0x1700CD71 RID: 52593
		// (get) Token: 0x06030903 RID: 198915 RVA: 0x00697888 File Offset: 0x00695A88
		public EAirWallCollisionPreset CollisionPreset
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return EAirWallCollisionPreset.Normal;
				}
				return (EAirWallCollisionPreset)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CD72 RID: 52594
		// (get) Token: 0x06030904 RID: 198916 RVA: 0x006978C8 File Offset: 0x00695AC8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030905 RID: 198917 RVA: 0x00697908 File Offset: 0x00695B08
		public static Offset<IOpenAirWall> CreateIOpenAirWall(FlatBufferBuilder builder, EToggleAirWall Type = EToggleAirWall.Open, StringOffset HitEffectDataOffset = default(StringOffset), float HitCd = 0f, StringOffset AirWallEffectDataOffset = default(StringOffset), StringOffset VectorArrayAirWallEffectDataOffset = default(StringOffset), float AirWallEffectHeight = 0f, float AirWallEffectThickness = 0f, EAirWallCollisionPreset CollisionPreset = EAirWallCollisionPreset.Normal, byte NullMask = 0)
		{
			builder.StartTable(9);
			IOpenAirWall.AddAirWallEffectThickness(builder, AirWallEffectThickness);
			IOpenAirWall.AddAirWallEffectHeight(builder, AirWallEffectHeight);
			IOpenAirWall.AddVectorArrayAirWallEffectData(builder, VectorArrayAirWallEffectDataOffset);
			IOpenAirWall.AddAirWallEffectData(builder, AirWallEffectDataOffset);
			IOpenAirWall.AddHitCd(builder, HitCd);
			IOpenAirWall.AddHitEffectData(builder, HitEffectDataOffset);
			IOpenAirWall.AddNullMask(builder, NullMask);
			IOpenAirWall.AddCollisionPreset(builder, CollisionPreset);
			IOpenAirWall.AddType(builder, Type);
			return IOpenAirWall.EndIOpenAirWall(builder);
		}

		// Token: 0x06030906 RID: 198918 RVA: 0x00697968 File Offset: 0x00695B68
		public static void StartIOpenAirWall(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06030907 RID: 198919 RVA: 0x00697972 File Offset: 0x00695B72
		public static void AddType(FlatBufferBuilder builder, EToggleAirWall type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030908 RID: 198920 RVA: 0x0069797D File Offset: 0x00695B7D
		public static void AddHitEffectData(FlatBufferBuilder builder, StringOffset hitEffectDataOffset)
		{
			builder.AddOffset(1, hitEffectDataOffset.Value, 0);
		}

		// Token: 0x06030909 RID: 198921 RVA: 0x0069798D File Offset: 0x00695B8D
		public static void AddHitCd(FlatBufferBuilder builder, float hitCd)
		{
			builder.AddFloat(2, hitCd, 0.0);
		}

		// Token: 0x0603090A RID: 198922 RVA: 0x006979A0 File Offset: 0x00695BA0
		public static void AddAirWallEffectData(FlatBufferBuilder builder, StringOffset airWallEffectDataOffset)
		{
			builder.AddOffset(3, airWallEffectDataOffset.Value, 0);
		}

		// Token: 0x0603090B RID: 198923 RVA: 0x006979B0 File Offset: 0x00695BB0
		public static void AddVectorArrayAirWallEffectData(FlatBufferBuilder builder, StringOffset vectorArrayAirWallEffectDataOffset)
		{
			builder.AddOffset(4, vectorArrayAirWallEffectDataOffset.Value, 0);
		}

		// Token: 0x0603090C RID: 198924 RVA: 0x006979C0 File Offset: 0x00695BC0
		public static void AddAirWallEffectHeight(FlatBufferBuilder builder, float airWallEffectHeight)
		{
			builder.AddFloat(5, airWallEffectHeight, 0.0);
		}

		// Token: 0x0603090D RID: 198925 RVA: 0x006979D3 File Offset: 0x00695BD3
		public static void AddAirWallEffectThickness(FlatBufferBuilder builder, float airWallEffectThickness)
		{
			builder.AddFloat(6, airWallEffectThickness, 0.0);
		}

		// Token: 0x0603090E RID: 198926 RVA: 0x006979E6 File Offset: 0x00695BE6
		public static void AddCollisionPreset(FlatBufferBuilder builder, EAirWallCollisionPreset collisionPreset)
		{
			builder.AddByte(7, (byte)collisionPreset, 0);
		}

		// Token: 0x0603090F RID: 198927 RVA: 0x006979F1 File Offset: 0x00695BF1
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06030910 RID: 198928 RVA: 0x006979FC File Offset: 0x00695BFC
		public static Offset<IOpenAirWall> EndIOpenAirWall(FlatBufferBuilder builder)
		{
			return new Offset<IOpenAirWall>(builder.EndTable());
		}

		// Token: 0x06030911 RID: 198929 RVA: 0x00697A0C File Offset: 0x00695C0C
		public IOpenAirWallT UnPack()
		{
			IOpenAirWallT openAirWallT = new IOpenAirWallT();
			this.UnPackTo(openAirWallT);
			return openAirWallT;
		}

		// Token: 0x06030912 RID: 198930 RVA: 0x00697A28 File Offset: 0x00695C28
		public void UnPackTo(IOpenAirWallT _o)
		{
			_o.Type = this.Type;
			_o.HitEffectData = this.HitEffectData;
			_o.HitCd = this.HitCd;
			_o.AirWallEffectData = this.AirWallEffectData;
			_o.VectorArrayAirWallEffectData = this.VectorArrayAirWallEffectData;
			_o.AirWallEffectHeight = this.AirWallEffectHeight;
			_o.AirWallEffectThickness = this.AirWallEffectThickness;
			_o.CollisionPreset = this.CollisionPreset;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06030913 RID: 198931 RVA: 0x00697AA4 File Offset: 0x00695CA4
		public static Offset<IOpenAirWall> Pack(FlatBufferBuilder builder, IOpenAirWallT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenAirWall>);
			}
			StringOffset hitEffectDataOffset = (_o.HitEffectData == null) ? default(StringOffset) : builder.CreateString(_o.HitEffectData);
			StringOffset airWallEffectDataOffset = (_o.AirWallEffectData == null) ? default(StringOffset) : builder.CreateString(_o.AirWallEffectData);
			StringOffset vectorArrayAirWallEffectDataOffset = (_o.VectorArrayAirWallEffectData == null) ? default(StringOffset) : builder.CreateString(_o.VectorArrayAirWallEffectData);
			return IOpenAirWall.CreateIOpenAirWall(builder, _o.Type, hitEffectDataOffset, _o.HitCd, airWallEffectDataOffset, vectorArrayAirWallEffectDataOffset, _o.AirWallEffectHeight, _o.AirWallEffectThickness, _o.CollisionPreset, _o.NullMask);
		}

		// Token: 0x040114E2 RID: 70882
		private Table __p;
	}
}
