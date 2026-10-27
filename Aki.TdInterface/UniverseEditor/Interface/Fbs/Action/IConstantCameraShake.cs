using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064C5 RID: 25797
	public struct IConstantCameraShake : IFlatbufferObject
	{
		// Token: 0x1700BFF8 RID: 49144
		// (get) Token: 0x0602CBEC RID: 183276 RVA: 0x006268CB File Offset: 0x00624ACB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CBED RID: 183277 RVA: 0x006268D8 File Offset: 0x00624AD8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CBEE RID: 183278 RVA: 0x006268E0 File Offset: 0x00624AE0
		public static IConstantCameraShake GetRootAsIConstantCameraShake(ByteBuffer _bb)
		{
			return IConstantCameraShake.GetRootAsIConstantCameraShake(_bb, default(IConstantCameraShake));
		}

		// Token: 0x0602CBEF RID: 183279 RVA: 0x006268FC File Offset: 0x00624AFC
		public static IConstantCameraShake GetRootAsIConstantCameraShake(ByteBuffer _bb, IConstantCameraShake obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CBF0 RID: 183280 RVA: 0x00626919 File Offset: 0x00624B19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CBF1 RID: 183281 RVA: 0x00626928 File Offset: 0x00624B28
		public IConstantCameraShake __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BFF9 RID: 49145
		// (get) Token: 0x0602CBF2 RID: 183282 RVA: 0x00626938 File Offset: 0x00624B38
		public ECameraShakeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECameraShakeType.Constant;
				}
				return (ECameraShakeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CBF3 RID: 183283 RVA: 0x00626974 File Offset: 0x00624B74
		public static Offset<IConstantCameraShake> CreateIConstantCameraShake(FlatBufferBuilder builder, ECameraShakeType Type = ECameraShakeType.Constant)
		{
			builder.StartTable(1);
			IConstantCameraShake.AddType(builder, Type);
			return IConstantCameraShake.EndIConstantCameraShake(builder);
		}

		// Token: 0x0602CBF4 RID: 183284 RVA: 0x0062698A File Offset: 0x00624B8A
		public static void StartIConstantCameraShake(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602CBF5 RID: 183285 RVA: 0x00626993 File Offset: 0x00624B93
		public static void AddType(FlatBufferBuilder builder, ECameraShakeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CBF6 RID: 183286 RVA: 0x0062699E File Offset: 0x00624B9E
		public static Offset<IConstantCameraShake> EndIConstantCameraShake(FlatBufferBuilder builder)
		{
			return new Offset<IConstantCameraShake>(builder.EndTable());
		}

		// Token: 0x0602CBF7 RID: 183287 RVA: 0x006269AC File Offset: 0x00624BAC
		public IConstantCameraShakeT UnPack()
		{
			IConstantCameraShakeT constantCameraShakeT = new IConstantCameraShakeT();
			this.UnPackTo(constantCameraShakeT);
			return constantCameraShakeT;
		}

		// Token: 0x0602CBF8 RID: 183288 RVA: 0x006269C7 File Offset: 0x00624BC7
		public void UnPackTo(IConstantCameraShakeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602CBF9 RID: 183289 RVA: 0x006269D8 File Offset: 0x00624BD8
		public static Offset<IConstantCameraShake> Pack(FlatBufferBuilder builder, IConstantCameraShakeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConstantCameraShake>);
			}
			return IConstantCameraShake.CreateIConstantCameraShake(builder, _o.Type);
		}

		// Token: 0x04010AFA RID: 68346
		private Table __p;
	}
}
