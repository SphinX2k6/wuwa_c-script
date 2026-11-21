using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200727C RID: 29308
	public struct IMotorSoarInWindFieldControlType : IFlatbufferObject
	{
		// Token: 0x1700D6D4 RID: 54996
		// (get) Token: 0x06033116 RID: 209174 RVA: 0x006E4711 File Offset: 0x006E2911
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033117 RID: 209175 RVA: 0x006E471E File Offset: 0x006E291E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033118 RID: 209176 RVA: 0x006E4728 File Offset: 0x006E2928
		public static IMotorSoarInWindFieldControlType GetRootAsIMotorSoarInWindFieldControlType(ByteBuffer _bb)
		{
			return IMotorSoarInWindFieldControlType.GetRootAsIMotorSoarInWindFieldControlType(_bb, default(IMotorSoarInWindFieldControlType));
		}

		// Token: 0x06033119 RID: 209177 RVA: 0x006E4744 File Offset: 0x006E2944
		public static IMotorSoarInWindFieldControlType GetRootAsIMotorSoarInWindFieldControlType(ByteBuffer _bb, IMotorSoarInWindFieldControlType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603311A RID: 209178 RVA: 0x006E4761 File Offset: 0x006E2961
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603311B RID: 209179 RVA: 0x006E4770 File Offset: 0x006E2970
		public IMotorSoarInWindFieldControlType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D6D5 RID: 54997
		// (get) Token: 0x0603311C RID: 209180 RVA: 0x006E4780 File Offset: 0x006E2980
		public EMotorSoarInWindFieldControlType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMotorSoarInWindFieldControlType.EnterWindField;
				}
				return (EMotorSoarInWindFieldControlType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603311D RID: 209181 RVA: 0x006E47BC File Offset: 0x006E29BC
		public static Offset<IMotorSoarInWindFieldControlType> CreateIMotorSoarInWindFieldControlType(FlatBufferBuilder builder, EMotorSoarInWindFieldControlType Type = EMotorSoarInWindFieldControlType.EnterWindField)
		{
			builder.StartTable(1);
			IMotorSoarInWindFieldControlType.AddType(builder, Type);
			return IMotorSoarInWindFieldControlType.EndIMotorSoarInWindFieldControlType(builder);
		}

		// Token: 0x0603311E RID: 209182 RVA: 0x006E47D2 File Offset: 0x006E29D2
		public static void StartIMotorSoarInWindFieldControlType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603311F RID: 209183 RVA: 0x006E47DB File Offset: 0x006E29DB
		public static void AddType(FlatBufferBuilder builder, EMotorSoarInWindFieldControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033120 RID: 209184 RVA: 0x006E47E6 File Offset: 0x006E29E6
		public static Offset<IMotorSoarInWindFieldControlType> EndIMotorSoarInWindFieldControlType(FlatBufferBuilder builder)
		{
			return new Offset<IMotorSoarInWindFieldControlType>(builder.EndTable());
		}

		// Token: 0x06033121 RID: 209185 RVA: 0x006E47F4 File Offset: 0x006E29F4
		public IMotorSoarInWindFieldControlTypeT UnPack()
		{
			IMotorSoarInWindFieldControlTypeT motorSoarInWindFieldControlTypeT = new IMotorSoarInWindFieldControlTypeT();
			this.UnPackTo(motorSoarInWindFieldControlTypeT);
			return motorSoarInWindFieldControlTypeT;
		}

		// Token: 0x06033122 RID: 209186 RVA: 0x006E480F File Offset: 0x006E2A0F
		public void UnPackTo(IMotorSoarInWindFieldControlTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033123 RID: 209187 RVA: 0x006E4820 File Offset: 0x006E2A20
		public static Offset<IMotorSoarInWindFieldControlType> Pack(FlatBufferBuilder builder, IMotorSoarInWindFieldControlTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorSoarInWindFieldControlType>);
			}
			return IMotorSoarInWindFieldControlType.CreateIMotorSoarInWindFieldControlType(builder, _o.Type);
		}

		// Token: 0x040122F6 RID: 74486
		private Table __p;
	}
}
