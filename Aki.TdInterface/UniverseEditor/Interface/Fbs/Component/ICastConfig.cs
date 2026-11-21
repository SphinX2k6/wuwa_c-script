using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005487 RID: 21639
	public struct ICastConfig : IFlatbufferObject
	{
		// Token: 0x17009A15 RID: 39445
		// (get) Token: 0x0602208D RID: 139405 RVA: 0x004B11CB File Offset: 0x004AF3CB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602208E RID: 139406 RVA: 0x004B11D8 File Offset: 0x004AF3D8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602208F RID: 139407 RVA: 0x004B11E0 File Offset: 0x004AF3E0
		public static ICastConfig GetRootAsICastConfig(ByteBuffer _bb)
		{
			return ICastConfig.GetRootAsICastConfig(_bb, default(ICastConfig));
		}

		// Token: 0x06022090 RID: 139408 RVA: 0x004B11FC File Offset: 0x004AF3FC
		public static ICastConfig GetRootAsICastConfig(ByteBuffer _bb, ICastConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022091 RID: 139409 RVA: 0x004B1219 File Offset: 0x004AF419
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022092 RID: 139410 RVA: 0x004B1228 File Offset: 0x004AF428
		public ICastConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009A16 RID: 39446
		// (get) Token: 0x06022093 RID: 139411 RVA: 0x004B1238 File Offset: 0x004AF438
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

		// Token: 0x17009A17 RID: 39447
		// (get) Token: 0x06022094 RID: 139412 RVA: 0x004B1274 File Offset: 0x004AF474
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

		// Token: 0x06022095 RID: 139413 RVA: 0x004B12AB File Offset: 0x004AF4AB
		public Span<byte> GetCastCameraShakeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06022096 RID: 139414 RVA: 0x004B12BA File Offset: 0x004AF4BA
		public byte[] GetCastCameraShakeArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17009A18 RID: 39448
		// (get) Token: 0x06022097 RID: 139415 RVA: 0x004B12C8 File Offset: 0x004AF4C8
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

		// Token: 0x06022098 RID: 139416 RVA: 0x004B1304 File Offset: 0x004AF504
		public static Offset<ICastConfig> CreateICastConfig(FlatBufferBuilder builder, int CastAngularVelocity = 0, StringOffset CastCameraShakeOffset = default(StringOffset), int CastVelocity = 0)
		{
			builder.StartTable(3);
			ICastConfig.AddCastVelocity(builder, CastVelocity);
			ICastConfig.AddCastCameraShake(builder, CastCameraShakeOffset);
			ICastConfig.AddCastAngularVelocity(builder, CastAngularVelocity);
			return ICastConfig.EndICastConfig(builder);
		}

		// Token: 0x06022099 RID: 139417 RVA: 0x004B1328 File Offset: 0x004AF528
		public static void StartICastConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602209A RID: 139418 RVA: 0x004B1331 File Offset: 0x004AF531
		public static void AddCastAngularVelocity(FlatBufferBuilder builder, int castAngularVelocity)
		{
			builder.AddInt(0, castAngularVelocity, 0);
		}

		// Token: 0x0602209B RID: 139419 RVA: 0x004B133C File Offset: 0x004AF53C
		public static void AddCastCameraShake(FlatBufferBuilder builder, StringOffset castCameraShakeOffset)
		{
			builder.AddOffset(1, castCameraShakeOffset.Value, 0);
		}

		// Token: 0x0602209C RID: 139420 RVA: 0x004B134C File Offset: 0x004AF54C
		public static void AddCastVelocity(FlatBufferBuilder builder, int castVelocity)
		{
			builder.AddInt(2, castVelocity, 0);
		}

		// Token: 0x0602209D RID: 139421 RVA: 0x004B1357 File Offset: 0x004AF557
		public static Offset<ICastConfig> EndICastConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICastConfig>(builder.EndTable());
		}

		// Token: 0x0602209E RID: 139422 RVA: 0x004B1364 File Offset: 0x004AF564
		public ICastConfigT UnPack()
		{
			ICastConfigT castConfigT = new ICastConfigT();
			this.UnPackTo(castConfigT);
			return castConfigT;
		}

		// Token: 0x0602209F RID: 139423 RVA: 0x004B137F File Offset: 0x004AF57F
		public void UnPackTo(ICastConfigT _o)
		{
			_o.CastAngularVelocity = this.CastAngularVelocity;
			_o.CastCameraShake = this.CastCameraShake;
			_o.CastVelocity = this.CastVelocity;
		}

		// Token: 0x060220A0 RID: 139424 RVA: 0x004B13A8 File Offset: 0x004AF5A8
		public static Offset<ICastConfig> Pack(FlatBufferBuilder builder, ICastConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICastConfig>);
			}
			StringOffset castCameraShakeOffset = (_o.CastCameraShake == null) ? default(StringOffset) : builder.CreateString(_o.CastCameraShake);
			return ICastConfig.CreateICastConfig(builder, _o.CastAngularVelocity, castCameraShakeOffset, _o.CastVelocity);
		}

		// Token: 0x0400E98E RID: 59790
		private Table __p;
	}
}
