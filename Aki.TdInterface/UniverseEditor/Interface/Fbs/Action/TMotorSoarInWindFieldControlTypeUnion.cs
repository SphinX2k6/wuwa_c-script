using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F4F RID: 32591
	public class TMotorSoarInWindFieldControlTypeUnion
	{
		// Token: 0x1700F2AD RID: 62125
		// (get) Token: 0x0603AC3B RID: 240699 RVA: 0x007E68E6 File Offset: 0x007E4AE6
		// (set) Token: 0x0603AC3C RID: 240700 RVA: 0x007E68EE File Offset: 0x007E4AEE
		public TMotorSoarInWindFieldControlType Type { get; set; }

		// Token: 0x1700F2AE RID: 62126
		// (get) Token: 0x0603AC3D RID: 240701 RVA: 0x007E68F7 File Offset: 0x007E4AF7
		// (set) Token: 0x0603AC3E RID: 240702 RVA: 0x007E68FF File Offset: 0x007E4AFF
		public object Value { get; set; }

		// Token: 0x0603AC3F RID: 240703 RVA: 0x007E6908 File Offset: 0x007E4B08
		public TMotorSoarInWindFieldControlTypeUnion()
		{
			this.Type = TMotorSoarInWindFieldControlType.NONE;
			this.Value = null;
		}

		// Token: 0x0603AC40 RID: 240704 RVA: 0x007E691E File Offset: 0x007E4B1E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AC41 RID: 240705 RVA: 0x007E6930 File Offset: 0x007E4B30
		public IMotorSoarInWindFieldEnterWindFieldT AsIMotorSoarInWindFieldEnterWindField()
		{
			return this.As<IMotorSoarInWindFieldEnterWindFieldT>();
		}

		// Token: 0x0603AC42 RID: 240706 RVA: 0x007E6938 File Offset: 0x007E4B38
		public static TMotorSoarInWindFieldControlTypeUnion FromIMotorSoarInWindFieldEnterWindField(IMotorSoarInWindFieldEnterWindFieldT _imotorsoarinwindfieldenterwindfield)
		{
			return new TMotorSoarInWindFieldControlTypeUnion
			{
				Type = TMotorSoarInWindFieldControlType.IMotorSoarInWindFieldEnterWindField,
				Value = _imotorsoarinwindfieldenterwindfield
			};
		}

		// Token: 0x0603AC43 RID: 240707 RVA: 0x007E694D File Offset: 0x007E4B4D
		public IMotorSoarInWindFieldExitWindFieldT AsIMotorSoarInWindFieldExitWindField()
		{
			return this.As<IMotorSoarInWindFieldExitWindFieldT>();
		}

		// Token: 0x0603AC44 RID: 240708 RVA: 0x007E6955 File Offset: 0x007E4B55
		public static TMotorSoarInWindFieldControlTypeUnion FromIMotorSoarInWindFieldExitWindField(IMotorSoarInWindFieldExitWindFieldT _imotorsoarinwindfieldexitwindfield)
		{
			return new TMotorSoarInWindFieldControlTypeUnion
			{
				Type = TMotorSoarInWindFieldControlType.IMotorSoarInWindFieldExitWindField,
				Value = _imotorsoarinwindfieldexitwindfield
			};
		}

		// Token: 0x0603AC45 RID: 240709 RVA: 0x007E696C File Offset: 0x007E4B6C
		public static int Pack(FlatBufferBuilder builder, TMotorSoarInWindFieldControlTypeUnion _o)
		{
			TMotorSoarInWindFieldControlType type = _o.Type;
			if (type == TMotorSoarInWindFieldControlType.IMotorSoarInWindFieldEnterWindField)
			{
				return IMotorSoarInWindFieldEnterWindField.Pack(builder, _o.AsIMotorSoarInWindFieldEnterWindField()).Value;
			}
			if (type != TMotorSoarInWindFieldControlType.IMotorSoarInWindFieldExitWindField)
			{
				return 0;
			}
			return IMotorSoarInWindFieldExitWindField.Pack(builder, _o.AsIMotorSoarInWindFieldExitWindField()).Value;
		}
	}
}
