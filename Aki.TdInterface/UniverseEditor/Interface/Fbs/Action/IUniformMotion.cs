using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074B7 RID: 29879
	public struct IUniformMotion : IFlatbufferObject
	{
		// Token: 0x1700E2CD RID: 58061
		// (get) Token: 0x06036526 RID: 222502 RVA: 0x00761FE9 File Offset: 0x007601E9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036527 RID: 222503 RVA: 0x00761FF6 File Offset: 0x007601F6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036528 RID: 222504 RVA: 0x00762000 File Offset: 0x00760200
		public static IUniformMotion GetRootAsIUniformMotion(ByteBuffer _bb)
		{
			return IUniformMotion.GetRootAsIUniformMotion(_bb, default(IUniformMotion));
		}

		// Token: 0x06036529 RID: 222505 RVA: 0x0076201C File Offset: 0x0076021C
		public static IUniformMotion GetRootAsIUniformMotion(ByteBuffer _bb, IUniformMotion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603652A RID: 222506 RVA: 0x00762039 File Offset: 0x00760239
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603652B RID: 222507 RVA: 0x00762048 File Offset: 0x00760248
		public IUniformMotion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E2CE RID: 58062
		// (get) Token: 0x0603652C RID: 222508 RVA: 0x00762058 File Offset: 0x00760258
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

		// Token: 0x1700E2CF RID: 58063
		// (get) Token: 0x0603652D RID: 222509 RVA: 0x00762094 File Offset: 0x00760294
		public float Time
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

		// Token: 0x0603652E RID: 222510 RVA: 0x007620D4 File Offset: 0x007602D4
		public static Offset<IUniformMotion> CreateIUniformMotion(FlatBufferBuilder builder, EMoveMotion Type = EMoveMotion.UniformMotion, float Time = 0f)
		{
			builder.StartTable(2);
			IUniformMotion.AddTime(builder, Time);
			IUniformMotion.AddType(builder, Type);
			return IUniformMotion.EndIUniformMotion(builder);
		}

		// Token: 0x0603652F RID: 222511 RVA: 0x007620F1 File Offset: 0x007602F1
		public static void StartIUniformMotion(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06036530 RID: 222512 RVA: 0x007620FA File Offset: 0x007602FA
		public static void AddType(FlatBufferBuilder builder, EMoveMotion type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036531 RID: 222513 RVA: 0x00762105 File Offset: 0x00760305
		public static void AddTime(FlatBufferBuilder builder, float time)
		{
			builder.AddFloat(1, time, 0.0);
		}

		// Token: 0x06036532 RID: 222514 RVA: 0x00762118 File Offset: 0x00760318
		public static Offset<IUniformMotion> EndIUniformMotion(FlatBufferBuilder builder)
		{
			return new Offset<IUniformMotion>(builder.EndTable());
		}

		// Token: 0x06036533 RID: 222515 RVA: 0x00762128 File Offset: 0x00760328
		public IUniformMotionT UnPack()
		{
			IUniformMotionT uniformMotionT = new IUniformMotionT();
			this.UnPackTo(uniformMotionT);
			return uniformMotionT;
		}

		// Token: 0x06036534 RID: 222516 RVA: 0x00762143 File Offset: 0x00760343
		public void UnPackTo(IUniformMotionT _o)
		{
			_o.Type = this.Type;
			_o.Time = this.Time;
		}

		// Token: 0x06036535 RID: 222517 RVA: 0x00762160 File Offset: 0x00760360
		public static Offset<IUniformMotion> Pack(FlatBufferBuilder builder, IUniformMotionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUniformMotion>);
			}
			return IUniformMotion.CreateIUniformMotion(builder, _o.Type, _o.Time);
		}

		// Token: 0x04012380 RID: 74624
		private Table __p;
	}
}
