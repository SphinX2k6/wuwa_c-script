using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CEC RID: 31980
	public struct IVariableMotion : IFlatbufferObject
	{
		// Token: 0x1700EF59 RID: 61273
		// (get) Token: 0x06039B32 RID: 236338 RVA: 0x007C8B34 File Offset: 0x007C6D34
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039B33 RID: 236339 RVA: 0x007C8B41 File Offset: 0x007C6D41
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039B34 RID: 236340 RVA: 0x007C8B48 File Offset: 0x007C6D48
		public static IVariableMotion GetRootAsIVariableMotion(ByteBuffer _bb)
		{
			return IVariableMotion.GetRootAsIVariableMotion(_bb, default(IVariableMotion));
		}

		// Token: 0x06039B35 RID: 236341 RVA: 0x007C8B64 File Offset: 0x007C6D64
		public static IVariableMotion GetRootAsIVariableMotion(ByteBuffer _bb, IVariableMotion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039B36 RID: 236342 RVA: 0x007C8B81 File Offset: 0x007C6D81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039B37 RID: 236343 RVA: 0x007C8B90 File Offset: 0x007C6D90
		public IVariableMotion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EF5A RID: 61274
		// (get) Token: 0x06039B38 RID: 236344 RVA: 0x007C8BA0 File Offset: 0x007C6DA0
		public EMoveMotion Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMoveMotion.UniformMotion;
				}
				return (EMoveMotion)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700EF5B RID: 61275
		// (get) Token: 0x06039B39 RID: 236345 RVA: 0x007C8BDC File Offset: 0x007C6DDC
		public float Acceleration
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

		// Token: 0x1700EF5C RID: 61276
		// (get) Token: 0x06039B3A RID: 236346 RVA: 0x007C8C1C File Offset: 0x007C6E1C
		public float MaxSpeed
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

		// Token: 0x06039B3B RID: 236347 RVA: 0x007C8C5C File Offset: 0x007C6E5C
		public static Offset<IVariableMotion> CreateIVariableMotion(FlatBufferBuilder builder, EMoveMotion Type = EMoveMotion.UniformMotion, float Acceleration = 0f, float MaxSpeed = 0f)
		{
			builder.StartTable(3);
			IVariableMotion.AddMaxSpeed(builder, MaxSpeed);
			IVariableMotion.AddAcceleration(builder, Acceleration);
			IVariableMotion.AddType(builder, Type);
			return IVariableMotion.EndIVariableMotion(builder);
		}

		// Token: 0x06039B3C RID: 236348 RVA: 0x007C8C80 File Offset: 0x007C6E80
		public static void StartIVariableMotion(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06039B3D RID: 236349 RVA: 0x007C8C89 File Offset: 0x007C6E89
		public static void AddType(FlatBufferBuilder builder, EMoveMotion type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039B3E RID: 236350 RVA: 0x007C8C94 File Offset: 0x007C6E94
		public static void AddAcceleration(FlatBufferBuilder builder, float acceleration)
		{
			builder.AddFloat(1, acceleration, 0.0);
		}

		// Token: 0x06039B3F RID: 236351 RVA: 0x007C8CA7 File Offset: 0x007C6EA7
		public static void AddMaxSpeed(FlatBufferBuilder builder, float maxSpeed)
		{
			builder.AddFloat(2, maxSpeed, 0.0);
		}

		// Token: 0x06039B40 RID: 236352 RVA: 0x007C8CBA File Offset: 0x007C6EBA
		public static Offset<IVariableMotion> EndIVariableMotion(FlatBufferBuilder builder)
		{
			return new Offset<IVariableMotion>(builder.EndTable());
		}

		// Token: 0x06039B41 RID: 236353 RVA: 0x007C8CC8 File Offset: 0x007C6EC8
		public IVariableMotionT UnPack()
		{
			IVariableMotionT variableMotionT = new IVariableMotionT();
			this.UnPackTo(variableMotionT);
			return variableMotionT;
		}

		// Token: 0x06039B42 RID: 236354 RVA: 0x007C8CE3 File Offset: 0x007C6EE3
		public void UnPackTo(IVariableMotionT _o)
		{
			_o.Type = this.Type;
			_o.Acceleration = this.Acceleration;
			_o.MaxSpeed = this.MaxSpeed;
		}

		// Token: 0x06039B43 RID: 236355 RVA: 0x007C8D0C File Offset: 0x007C6F0C
		public static Offset<IVariableMotion> Pack(FlatBufferBuilder builder, IVariableMotionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVariableMotion>);
			}
			return IVariableMotion.CreateIVariableMotion(builder, _o.Type, _o.Acceleration, _o.MaxSpeed);
		}

		// Token: 0x04013403 RID: 78851
		private Table __p;
	}
}
