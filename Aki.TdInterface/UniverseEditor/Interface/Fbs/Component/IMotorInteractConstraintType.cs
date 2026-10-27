using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055C0 RID: 21952
	public struct IMotorInteractConstraintType : IFlatbufferObject
	{
		// Token: 0x1700A23D RID: 41533
		// (get) Token: 0x060245DD RID: 148957 RVA: 0x005052AB File Offset: 0x005034AB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060245DE RID: 148958 RVA: 0x005052B8 File Offset: 0x005034B8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060245DF RID: 148959 RVA: 0x005052C0 File Offset: 0x005034C0
		public static IMotorInteractConstraintType GetRootAsIMotorInteractConstraintType(ByteBuffer _bb)
		{
			return IMotorInteractConstraintType.GetRootAsIMotorInteractConstraintType(_bb, default(IMotorInteractConstraintType));
		}

		// Token: 0x060245E0 RID: 148960 RVA: 0x005052DC File Offset: 0x005034DC
		public static IMotorInteractConstraintType GetRootAsIMotorInteractConstraintType(ByteBuffer _bb, IMotorInteractConstraintType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060245E1 RID: 148961 RVA: 0x005052F9 File Offset: 0x005034F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060245E2 RID: 148962 RVA: 0x00505308 File Offset: 0x00503508
		public IMotorInteractConstraintType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A23E RID: 41534
		// (get) Token: 0x060245E3 RID: 148963 RVA: 0x00505318 File Offset: 0x00503518
		public EMotorInteractConstraintType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMotorInteractConstraintType.FaceToTarget;
				}
				return (EMotorInteractConstraintType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060245E4 RID: 148964 RVA: 0x00505354 File Offset: 0x00503554
		public static Offset<IMotorInteractConstraintType> CreateIMotorInteractConstraintType(FlatBufferBuilder builder, EMotorInteractConstraintType Type = EMotorInteractConstraintType.FaceToTarget)
		{
			builder.StartTable(1);
			IMotorInteractConstraintType.AddType(builder, Type);
			return IMotorInteractConstraintType.EndIMotorInteractConstraintType(builder);
		}

		// Token: 0x060245E5 RID: 148965 RVA: 0x0050536A File Offset: 0x0050356A
		public static void StartIMotorInteractConstraintType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060245E6 RID: 148966 RVA: 0x00505373 File Offset: 0x00503573
		public static void AddType(FlatBufferBuilder builder, EMotorInteractConstraintType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060245E7 RID: 148967 RVA: 0x0050537E File Offset: 0x0050357E
		public static Offset<IMotorInteractConstraintType> EndIMotorInteractConstraintType(FlatBufferBuilder builder)
		{
			return new Offset<IMotorInteractConstraintType>(builder.EndTable());
		}

		// Token: 0x060245E8 RID: 148968 RVA: 0x0050538C File Offset: 0x0050358C
		public IMotorInteractConstraintTypeT UnPack()
		{
			IMotorInteractConstraintTypeT motorInteractConstraintTypeT = new IMotorInteractConstraintTypeT();
			this.UnPackTo(motorInteractConstraintTypeT);
			return motorInteractConstraintTypeT;
		}

		// Token: 0x060245E9 RID: 148969 RVA: 0x005053A7 File Offset: 0x005035A7
		public void UnPackTo(IMotorInteractConstraintTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060245EA RID: 148970 RVA: 0x005053B8 File Offset: 0x005035B8
		public static Offset<IMotorInteractConstraintType> Pack(FlatBufferBuilder builder, IMotorInteractConstraintTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorInteractConstraintType>);
			}
			return IMotorInteractConstraintType.CreateIMotorInteractConstraintType(builder, _o.Type);
		}

		// Token: 0x0400E907 RID: 59655
		private Table __p;
	}
}
