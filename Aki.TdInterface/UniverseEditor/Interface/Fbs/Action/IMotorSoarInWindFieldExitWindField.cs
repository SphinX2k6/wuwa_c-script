using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007285 RID: 29317
	public struct IMotorSoarInWindFieldExitWindField : IFlatbufferObject
	{
		// Token: 0x1700D6E8 RID: 55016
		// (get) Token: 0x06033162 RID: 209250 RVA: 0x006E5024 File Offset: 0x006E3224
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033163 RID: 209251 RVA: 0x006E5031 File Offset: 0x006E3231
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033164 RID: 209252 RVA: 0x006E5038 File Offset: 0x006E3238
		public static IMotorSoarInWindFieldExitWindField GetRootAsIMotorSoarInWindFieldExitWindField(ByteBuffer _bb)
		{
			return IMotorSoarInWindFieldExitWindField.GetRootAsIMotorSoarInWindFieldExitWindField(_bb, default(IMotorSoarInWindFieldExitWindField));
		}

		// Token: 0x06033165 RID: 209253 RVA: 0x006E5054 File Offset: 0x006E3254
		public static IMotorSoarInWindFieldExitWindField GetRootAsIMotorSoarInWindFieldExitWindField(ByteBuffer _bb, IMotorSoarInWindFieldExitWindField obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033166 RID: 209254 RVA: 0x006E5071 File Offset: 0x006E3271
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033167 RID: 209255 RVA: 0x006E5080 File Offset: 0x006E3280
		public IMotorSoarInWindFieldExitWindField __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D6E9 RID: 55017
		// (get) Token: 0x06033168 RID: 209256 RVA: 0x006E5090 File Offset: 0x006E3290
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

		// Token: 0x06033169 RID: 209257 RVA: 0x006E50CC File Offset: 0x006E32CC
		public static Offset<IMotorSoarInWindFieldExitWindField> CreateIMotorSoarInWindFieldExitWindField(FlatBufferBuilder builder, EMotorSoarInWindFieldControlType Type = EMotorSoarInWindFieldControlType.EnterWindField)
		{
			builder.StartTable(1);
			IMotorSoarInWindFieldExitWindField.AddType(builder, Type);
			return IMotorSoarInWindFieldExitWindField.EndIMotorSoarInWindFieldExitWindField(builder);
		}

		// Token: 0x0603316A RID: 209258 RVA: 0x006E50E2 File Offset: 0x006E32E2
		public static void StartIMotorSoarInWindFieldExitWindField(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603316B RID: 209259 RVA: 0x006E50EB File Offset: 0x006E32EB
		public static void AddType(FlatBufferBuilder builder, EMotorSoarInWindFieldControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603316C RID: 209260 RVA: 0x006E50F6 File Offset: 0x006E32F6
		public static Offset<IMotorSoarInWindFieldExitWindField> EndIMotorSoarInWindFieldExitWindField(FlatBufferBuilder builder)
		{
			return new Offset<IMotorSoarInWindFieldExitWindField>(builder.EndTable());
		}

		// Token: 0x0603316D RID: 209261 RVA: 0x006E5104 File Offset: 0x006E3304
		public IMotorSoarInWindFieldExitWindFieldT UnPack()
		{
			IMotorSoarInWindFieldExitWindFieldT motorSoarInWindFieldExitWindFieldT = new IMotorSoarInWindFieldExitWindFieldT();
			this.UnPackTo(motorSoarInWindFieldExitWindFieldT);
			return motorSoarInWindFieldExitWindFieldT;
		}

		// Token: 0x0603316E RID: 209262 RVA: 0x006E511F File Offset: 0x006E331F
		public void UnPackTo(IMotorSoarInWindFieldExitWindFieldT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603316F RID: 209263 RVA: 0x006E5130 File Offset: 0x006E3330
		public static Offset<IMotorSoarInWindFieldExitWindField> Pack(FlatBufferBuilder builder, IMotorSoarInWindFieldExitWindFieldT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorSoarInWindFieldExitWindField>);
			}
			return IMotorSoarInWindFieldExitWindField.CreateIMotorSoarInWindFieldExitWindField(builder, _o.Type);
		}

		// Token: 0x04012307 RID: 74503
		private Table __p;
	}
}
