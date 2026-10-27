using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B3F RID: 27455
	public struct IMotorSoarInWindFieldExitWindField : IFlatbufferObject
	{
		// Token: 0x1700CC03 RID: 52227
		// (get) Token: 0x0603030B RID: 197387 RVA: 0x0068CA68 File Offset: 0x0068AC68
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603030C RID: 197388 RVA: 0x0068CA75 File Offset: 0x0068AC75
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603030D RID: 197389 RVA: 0x0068CA7C File Offset: 0x0068AC7C
		public static IMotorSoarInWindFieldExitWindField GetRootAsIMotorSoarInWindFieldExitWindField(ByteBuffer _bb)
		{
			return IMotorSoarInWindFieldExitWindField.GetRootAsIMotorSoarInWindFieldExitWindField(_bb, default(IMotorSoarInWindFieldExitWindField));
		}

		// Token: 0x0603030E RID: 197390 RVA: 0x0068CA98 File Offset: 0x0068AC98
		public static IMotorSoarInWindFieldExitWindField GetRootAsIMotorSoarInWindFieldExitWindField(ByteBuffer _bb, IMotorSoarInWindFieldExitWindField obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603030F RID: 197391 RVA: 0x0068CAB5 File Offset: 0x0068ACB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030310 RID: 197392 RVA: 0x0068CAC4 File Offset: 0x0068ACC4
		public IMotorSoarInWindFieldExitWindField __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC04 RID: 52228
		// (get) Token: 0x06030311 RID: 197393 RVA: 0x0068CAD4 File Offset: 0x0068ACD4
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

		// Token: 0x06030312 RID: 197394 RVA: 0x0068CB10 File Offset: 0x0068AD10
		public static Offset<IMotorSoarInWindFieldExitWindField> CreateIMotorSoarInWindFieldExitWindField(FlatBufferBuilder builder, EMotorSoarInWindFieldControlType Type = EMotorSoarInWindFieldControlType.EnterWindField)
		{
			builder.StartTable(1);
			IMotorSoarInWindFieldExitWindField.AddType(builder, Type);
			return IMotorSoarInWindFieldExitWindField.EndIMotorSoarInWindFieldExitWindField(builder);
		}

		// Token: 0x06030313 RID: 197395 RVA: 0x0068CB26 File Offset: 0x0068AD26
		public static void StartIMotorSoarInWindFieldExitWindField(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06030314 RID: 197396 RVA: 0x0068CB2F File Offset: 0x0068AD2F
		public static void AddType(FlatBufferBuilder builder, EMotorSoarInWindFieldControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030315 RID: 197397 RVA: 0x0068CB3A File Offset: 0x0068AD3A
		public static Offset<IMotorSoarInWindFieldExitWindField> EndIMotorSoarInWindFieldExitWindField(FlatBufferBuilder builder)
		{
			return new Offset<IMotorSoarInWindFieldExitWindField>(builder.EndTable());
		}

		// Token: 0x06030316 RID: 197398 RVA: 0x0068CB48 File Offset: 0x0068AD48
		public IMotorSoarInWindFieldExitWindFieldT UnPack()
		{
			IMotorSoarInWindFieldExitWindFieldT motorSoarInWindFieldExitWindFieldT = new IMotorSoarInWindFieldExitWindFieldT();
			this.UnPackTo(motorSoarInWindFieldExitWindFieldT);
			return motorSoarInWindFieldExitWindFieldT;
		}

		// Token: 0x06030317 RID: 197399 RVA: 0x0068CB63 File Offset: 0x0068AD63
		public void UnPackTo(IMotorSoarInWindFieldExitWindFieldT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06030318 RID: 197400 RVA: 0x0068CB74 File Offset: 0x0068AD74
		public static Offset<IMotorSoarInWindFieldExitWindField> Pack(FlatBufferBuilder builder, IMotorSoarInWindFieldExitWindFieldT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorSoarInWindFieldExitWindField>);
			}
			return IMotorSoarInWindFieldExitWindField.CreateIMotorSoarInWindFieldExitWindField(builder, _o.Type);
		}

		// Token: 0x040113DE RID: 70622
		private Table __p;
	}
}
