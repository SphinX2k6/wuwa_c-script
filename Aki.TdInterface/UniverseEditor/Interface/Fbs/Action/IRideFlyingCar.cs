using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ECD RID: 28365
	public struct IRideFlyingCar : IFlatbufferObject
	{
		// Token: 0x1700D312 RID: 54034
		// (get) Token: 0x06032205 RID: 205317 RVA: 0x006C6BBE File Offset: 0x006C4DBE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032206 RID: 205318 RVA: 0x006C6BCB File Offset: 0x006C4DCB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032207 RID: 205319 RVA: 0x006C6BD4 File Offset: 0x006C4DD4
		public static IRideFlyingCar GetRootAsIRideFlyingCar(ByteBuffer _bb)
		{
			return IRideFlyingCar.GetRootAsIRideFlyingCar(_bb, default(IRideFlyingCar));
		}

		// Token: 0x06032208 RID: 205320 RVA: 0x006C6BF0 File Offset: 0x006C4DF0
		public static IRideFlyingCar GetRootAsIRideFlyingCar(ByteBuffer _bb, IRideFlyingCar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032209 RID: 205321 RVA: 0x006C6C0D File Offset: 0x006C4E0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603220A RID: 205322 RVA: 0x006C6C1C File Offset: 0x006C4E1C
		public IRideFlyingCar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D313 RID: 54035
		// (get) Token: 0x0603220B RID: 205323 RVA: 0x006C6C2C File Offset: 0x006C4E2C
		public ESimpleGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESimpleGameplayType.Cipher;
				}
				return (ESimpleGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D314 RID: 54036
		// (get) Token: 0x0603220C RID: 205324 RVA: 0x006C6C68 File Offset: 0x006C4E68
		public int FirstPersonCameraTag
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D315 RID: 54037
		// (get) Token: 0x0603220D RID: 205325 RVA: 0x006C6CA4 File Offset: 0x006C4EA4
		public int ThirdPersonCameraTag
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

		// Token: 0x1700D316 RID: 54038
		// (get) Token: 0x0603220E RID: 205326 RVA: 0x006C6CE0 File Offset: 0x006C4EE0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603220F RID: 205327 RVA: 0x006C6D1D File Offset: 0x006C4F1D
		public static Offset<IRideFlyingCar> CreateIRideFlyingCar(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, int FirstPersonCameraTag = 0, int ThirdPersonCameraTag = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IRideFlyingCar.AddThirdPersonCameraTag(builder, ThirdPersonCameraTag);
			IRideFlyingCar.AddFirstPersonCameraTag(builder, FirstPersonCameraTag);
			IRideFlyingCar.AddNullMask(builder, NullMask);
			IRideFlyingCar.AddType(builder, Type);
			return IRideFlyingCar.EndIRideFlyingCar(builder);
		}

		// Token: 0x06032210 RID: 205328 RVA: 0x006C6D49 File Offset: 0x006C4F49
		public static void StartIRideFlyingCar(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06032211 RID: 205329 RVA: 0x006C6D52 File Offset: 0x006C4F52
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032212 RID: 205330 RVA: 0x006C6D5D File Offset: 0x006C4F5D
		public static void AddFirstPersonCameraTag(FlatBufferBuilder builder, int firstPersonCameraTag)
		{
			builder.AddInt(1, firstPersonCameraTag, 0);
		}

		// Token: 0x06032213 RID: 205331 RVA: 0x006C6D68 File Offset: 0x006C4F68
		public static void AddThirdPersonCameraTag(FlatBufferBuilder builder, int thirdPersonCameraTag)
		{
			builder.AddInt(2, thirdPersonCameraTag, 0);
		}

		// Token: 0x06032214 RID: 205332 RVA: 0x006C6D73 File Offset: 0x006C4F73
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06032215 RID: 205333 RVA: 0x006C6D7E File Offset: 0x006C4F7E
		public static Offset<IRideFlyingCar> EndIRideFlyingCar(FlatBufferBuilder builder)
		{
			return new Offset<IRideFlyingCar>(builder.EndTable());
		}

		// Token: 0x06032216 RID: 205334 RVA: 0x006C6D8C File Offset: 0x006C4F8C
		public IRideFlyingCarT UnPack()
		{
			IRideFlyingCarT rideFlyingCarT = new IRideFlyingCarT();
			this.UnPackTo(rideFlyingCarT);
			return rideFlyingCarT;
		}

		// Token: 0x06032217 RID: 205335 RVA: 0x006C6DA7 File Offset: 0x006C4FA7
		public void UnPackTo(IRideFlyingCarT _o)
		{
			_o.Type = this.Type;
			_o.FirstPersonCameraTag = this.FirstPersonCameraTag;
			_o.ThirdPersonCameraTag = this.ThirdPersonCameraTag;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06032218 RID: 205336 RVA: 0x006C6DDC File Offset: 0x006C4FDC
		public static Offset<IRideFlyingCar> Pack(FlatBufferBuilder builder, IRideFlyingCarT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRideFlyingCar>);
			}
			return IRideFlyingCar.CreateIRideFlyingCar(builder, _o.Type, _o.FirstPersonCameraTag, _o.ThirdPersonCameraTag, _o.NullMask);
		}

		// Token: 0x040118BF RID: 71871
		private Table __p;
	}
}
