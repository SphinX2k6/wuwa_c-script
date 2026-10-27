using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F58 RID: 20312
	public struct ICastConfig : IFlatbufferObject
	{
		// Token: 0x1700929C RID: 37532
		// (get) Token: 0x0602033B RID: 131899 RVA: 0x0047B1DB File Offset: 0x004793DB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602033C RID: 131900 RVA: 0x0047B1E8 File Offset: 0x004793E8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602033D RID: 131901 RVA: 0x0047B1F0 File Offset: 0x004793F0
		public static ICastConfig GetRootAsICastConfig(ByteBuffer _bb)
		{
			return ICastConfig.GetRootAsICastConfig(_bb, default(ICastConfig));
		}

		// Token: 0x0602033E RID: 131902 RVA: 0x0047B20C File Offset: 0x0047940C
		public static ICastConfig GetRootAsICastConfig(ByteBuffer _bb, ICastConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602033F RID: 131903 RVA: 0x0047B229 File Offset: 0x00479429
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020340 RID: 131904 RVA: 0x0047B238 File Offset: 0x00479438
		public ICastConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700929D RID: 37533
		// (get) Token: 0x06020341 RID: 131905 RVA: 0x0047B248 File Offset: 0x00479448
		public int CastAngularVelocity
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700929E RID: 37534
		// (get) Token: 0x06020342 RID: 131906 RVA: 0x0047B284 File Offset: 0x00479484
		public string CastCameraShake
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

		// Token: 0x06020343 RID: 131907 RVA: 0x0047B2BB File Offset: 0x004794BB
		public Span<byte> GetCastCameraShakeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06020344 RID: 131908 RVA: 0x0047B2CA File Offset: 0x004794CA
		public byte[] GetCastCameraShakeArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700929F RID: 37535
		// (get) Token: 0x06020345 RID: 131909 RVA: 0x0047B2D8 File Offset: 0x004794D8
		public int CastVelocity
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020346 RID: 131910 RVA: 0x0047B314 File Offset: 0x00479514
		public static Offset<ICastConfig> CreateICastConfig(FlatBufferBuilder builder, int CastAngularVelocity = 0, StringOffset CastCameraShakeOffset = default(StringOffset), int CastVelocity = 0)
		{
			builder.StartTable(3);
			ICastConfig.AddCastVelocity(builder, CastVelocity);
			ICastConfig.AddCastCameraShake(builder, CastCameraShakeOffset);
			ICastConfig.AddCastAngularVelocity(builder, CastAngularVelocity);
			return ICastConfig.EndICastConfig(builder);
		}

		// Token: 0x06020347 RID: 131911 RVA: 0x0047B338 File Offset: 0x00479538
		public static void StartICastConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06020348 RID: 131912 RVA: 0x0047B341 File Offset: 0x00479541
		public static void AddCastAngularVelocity(FlatBufferBuilder builder, int castAngularVelocity)
		{
			builder.AddInt(0, castAngularVelocity, 0);
		}

		// Token: 0x06020349 RID: 131913 RVA: 0x0047B34C File Offset: 0x0047954C
		public static void AddCastCameraShake(FlatBufferBuilder builder, StringOffset castCameraShakeOffset)
		{
			builder.AddOffset(1, castCameraShakeOffset.Value, 0);
		}

		// Token: 0x0602034A RID: 131914 RVA: 0x0047B35C File Offset: 0x0047955C
		public static void AddCastVelocity(FlatBufferBuilder builder, int castVelocity)
		{
			builder.AddInt(2, castVelocity, 0);
		}

		// Token: 0x0602034B RID: 131915 RVA: 0x0047B367 File Offset: 0x00479567
		public static Offset<ICastConfig> EndICastConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICastConfig>(builder.EndTable());
		}

		// Token: 0x0602034C RID: 131916 RVA: 0x0047B374 File Offset: 0x00479574
		public ICastConfigT UnPack()
		{
			ICastConfigT castConfigT = new ICastConfigT();
			this.UnPackTo(castConfigT);
			return castConfigT;
		}

		// Token: 0x0602034D RID: 131917 RVA: 0x0047B38F File Offset: 0x0047958F
		public void UnPackTo(ICastConfigT _o)
		{
			_o.CastAngularVelocity = this.CastAngularVelocity;
			_o.CastCameraShake = this.CastCameraShake;
			_o.CastVelocity = this.CastVelocity;
		}

		// Token: 0x0602034E RID: 131918 RVA: 0x0047B3B8 File Offset: 0x004795B8
		public static Offset<ICastConfig> Pack(FlatBufferBuilder builder, ICastConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICastConfig>);
			}
			StringOffset castCameraShakeOffset = (_o.CastCameraShake == null) ? default(StringOffset) : builder.CreateString(_o.CastCameraShake);
			return ICastConfig.CreateICastConfig(builder, _o.CastAngularVelocity, castCameraShakeOffset, _o.CastVelocity);
		}

		// Token: 0x0400DDE4 RID: 56804
		private Table __p;
	}
}
