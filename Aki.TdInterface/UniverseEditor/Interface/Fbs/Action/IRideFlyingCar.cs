using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007651 RID: 30289
	public struct IRideFlyingCar : IFlatbufferObject
	{
		// Token: 0x1700DE69 RID: 56937
		// (get) Token: 0x06035245 RID: 217669 RVA: 0x007228F2 File Offset: 0x00720AF2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035246 RID: 217670 RVA: 0x007228FF File Offset: 0x00720AFF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035247 RID: 217671 RVA: 0x00722908 File Offset: 0x00720B08
		public static IRideFlyingCar GetRootAsIRideFlyingCar(ByteBuffer _bb)
		{
			return IRideFlyingCar.GetRootAsIRideFlyingCar(_bb, default(IRideFlyingCar));
		}

		// Token: 0x06035248 RID: 217672 RVA: 0x00722924 File Offset: 0x00720B24
		public static IRideFlyingCar GetRootAsIRideFlyingCar(ByteBuffer _bb, IRideFlyingCar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035249 RID: 217673 RVA: 0x00722941 File Offset: 0x00720B41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603524A RID: 217674 RVA: 0x00722950 File Offset: 0x00720B50
		public IRideFlyingCar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DE6A RID: 56938
		// (get) Token: 0x0603524B RID: 217675 RVA: 0x00722960 File Offset: 0x00720B60
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

		// Token: 0x1700DE6B RID: 56939
		// (get) Token: 0x0603524C RID: 217676 RVA: 0x0072299C File Offset: 0x00720B9C
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

		// Token: 0x1700DE6C RID: 56940
		// (get) Token: 0x0603524D RID: 217677 RVA: 0x007229D8 File Offset: 0x00720BD8
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

		// Token: 0x1700DE6D RID: 56941
		// (get) Token: 0x0603524E RID: 217678 RVA: 0x00722A14 File Offset: 0x00720C14
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

		// Token: 0x0603524F RID: 217679 RVA: 0x00722A51 File Offset: 0x00720C51
		public static Offset<IRideFlyingCar> CreateIRideFlyingCar(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, int FirstPersonCameraTag = 0, int ThirdPersonCameraTag = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IRideFlyingCar.AddThirdPersonCameraTag(builder, ThirdPersonCameraTag);
			IRideFlyingCar.AddFirstPersonCameraTag(builder, FirstPersonCameraTag);
			IRideFlyingCar.AddNullMask(builder, NullMask);
			IRideFlyingCar.AddType(builder, Type);
			return IRideFlyingCar.EndIRideFlyingCar(builder);
		}

		// Token: 0x06035250 RID: 217680 RVA: 0x00722A7D File Offset: 0x00720C7D
		public static void StartIRideFlyingCar(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06035251 RID: 217681 RVA: 0x00722A86 File Offset: 0x00720C86
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035252 RID: 217682 RVA: 0x00722A91 File Offset: 0x00720C91
		public static void AddFirstPersonCameraTag(FlatBufferBuilder builder, int firstPersonCameraTag)
		{
			builder.AddInt(1, firstPersonCameraTag, 0);
		}

		// Token: 0x06035253 RID: 217683 RVA: 0x00722A9C File Offset: 0x00720C9C
		public static void AddThirdPersonCameraTag(FlatBufferBuilder builder, int thirdPersonCameraTag)
		{
			builder.AddInt(2, thirdPersonCameraTag, 0);
		}

		// Token: 0x06035254 RID: 217684 RVA: 0x00722AA7 File Offset: 0x00720CA7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06035255 RID: 217685 RVA: 0x00722AB2 File Offset: 0x00720CB2
		public static Offset<IRideFlyingCar> EndIRideFlyingCar(FlatBufferBuilder builder)
		{
			return new Offset<IRideFlyingCar>(builder.EndTable());
		}

		// Token: 0x06035256 RID: 217686 RVA: 0x00722AC0 File Offset: 0x00720CC0
		public IRideFlyingCarT UnPack()
		{
			IRideFlyingCarT rideFlyingCarT = new IRideFlyingCarT();
			this.UnPackTo(rideFlyingCarT);
			return rideFlyingCarT;
		}

		// Token: 0x06035257 RID: 217687 RVA: 0x00722ADB File Offset: 0x00720CDB
		public void UnPackTo(IRideFlyingCarT _o)
		{
			_o.Type = this.Type;
			_o.FirstPersonCameraTag = this.FirstPersonCameraTag;
			_o.ThirdPersonCameraTag = this.ThirdPersonCameraTag;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06035258 RID: 217688 RVA: 0x00722B10 File Offset: 0x00720D10
		public static Offset<IRideFlyingCar> Pack(FlatBufferBuilder builder, IRideFlyingCarT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRideFlyingCar>);
			}
			return IRideFlyingCar.CreateIRideFlyingCar(builder, _o.Type, _o.FirstPersonCameraTag, _o.ThirdPersonCameraTag, _o.NullMask);
		}

		// Token: 0x04012844 RID: 75844
		private Table __p;
	}
}
