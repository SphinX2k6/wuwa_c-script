using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074F6 RID: 29942
	public struct IVariableMotion : IFlatbufferObject
	{
		// Token: 0x1700E32F RID: 58159
		// (get) Token: 0x0603671D RID: 223005 RVA: 0x007658E4 File Offset: 0x00763AE4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603671E RID: 223006 RVA: 0x007658F1 File Offset: 0x00763AF1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603671F RID: 223007 RVA: 0x007658F8 File Offset: 0x00763AF8
		public static IVariableMotion GetRootAsIVariableMotion(ByteBuffer _bb)
		{
			return IVariableMotion.GetRootAsIVariableMotion(_bb, default(IVariableMotion));
		}

		// Token: 0x06036720 RID: 223008 RVA: 0x00765914 File Offset: 0x00763B14
		public static IVariableMotion GetRootAsIVariableMotion(ByteBuffer _bb, IVariableMotion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036721 RID: 223009 RVA: 0x00765931 File Offset: 0x00763B31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036722 RID: 223010 RVA: 0x00765940 File Offset: 0x00763B40
		public IVariableMotion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E330 RID: 58160
		// (get) Token: 0x06036723 RID: 223011 RVA: 0x00765950 File Offset: 0x00763B50
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

		// Token: 0x1700E331 RID: 58161
		// (get) Token: 0x06036724 RID: 223012 RVA: 0x0076598C File Offset: 0x00763B8C
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

		// Token: 0x1700E332 RID: 58162
		// (get) Token: 0x06036725 RID: 223013 RVA: 0x007659CC File Offset: 0x00763BCC
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

		// Token: 0x06036726 RID: 223014 RVA: 0x00765A0C File Offset: 0x00763C0C
		public static Offset<IVariableMotion> CreateIVariableMotion(FlatBufferBuilder builder, EMoveMotion Type = EMoveMotion.UniformMotion, float Acceleration = 0f, float MaxSpeed = 0f)
		{
			builder.StartTable(3);
			IVariableMotion.AddMaxSpeed(builder, MaxSpeed);
			IVariableMotion.AddAcceleration(builder, Acceleration);
			IVariableMotion.AddType(builder, Type);
			return IVariableMotion.EndIVariableMotion(builder);
		}

		// Token: 0x06036727 RID: 223015 RVA: 0x00765A30 File Offset: 0x00763C30
		public static void StartIVariableMotion(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06036728 RID: 223016 RVA: 0x00765A39 File Offset: 0x00763C39
		public static void AddType(FlatBufferBuilder builder, EMoveMotion type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036729 RID: 223017 RVA: 0x00765A44 File Offset: 0x00763C44
		public static void AddAcceleration(FlatBufferBuilder builder, float acceleration)
		{
			builder.AddFloat(1, acceleration, 0.0);
		}

		// Token: 0x0603672A RID: 223018 RVA: 0x00765A57 File Offset: 0x00763C57
		public static void AddMaxSpeed(FlatBufferBuilder builder, float maxSpeed)
		{
			builder.AddFloat(2, maxSpeed, 0.0);
		}

		// Token: 0x0603672B RID: 223019 RVA: 0x00765A6A File Offset: 0x00763C6A
		public static Offset<IVariableMotion> EndIVariableMotion(FlatBufferBuilder builder)
		{
			return new Offset<IVariableMotion>(builder.EndTable());
		}

		// Token: 0x0603672C RID: 223020 RVA: 0x00765A78 File Offset: 0x00763C78
		public IVariableMotionT UnPack()
		{
			IVariableMotionT variableMotionT = new IVariableMotionT();
			this.UnPackTo(variableMotionT);
			return variableMotionT;
		}

		// Token: 0x0603672D RID: 223021 RVA: 0x00765A93 File Offset: 0x00763C93
		public void UnPackTo(IVariableMotionT _o)
		{
			_o.Type = this.Type;
			_o.Acceleration = this.Acceleration;
			_o.MaxSpeed = this.MaxSpeed;
		}

		// Token: 0x0603672E RID: 223022 RVA: 0x00765ABC File Offset: 0x00763CBC
		public static Offset<IVariableMotion> Pack(FlatBufferBuilder builder, IVariableMotionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVariableMotion>);
			}
			return IVariableMotion.CreateIVariableMotion(builder, _o.Type, _o.Acceleration, _o.MaxSpeed);
		}

		// Token: 0x040123D2 RID: 74706
		private Table __p;
	}
}
