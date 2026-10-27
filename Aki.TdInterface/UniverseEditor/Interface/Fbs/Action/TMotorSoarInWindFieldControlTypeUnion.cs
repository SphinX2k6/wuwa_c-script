using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007726 RID: 30502
	public class TMotorSoarInWindFieldControlTypeUnion
	{
		// Token: 0x1700E65D RID: 58973
		// (get) Token: 0x06037700 RID: 227072 RVA: 0x00781956 File Offset: 0x0077FB56
		// (set) Token: 0x06037701 RID: 227073 RVA: 0x0078195E File Offset: 0x0077FB5E
		public TMotorSoarInWindFieldControlType Type { get; set; }

		// Token: 0x1700E65E RID: 58974
		// (get) Token: 0x06037702 RID: 227074 RVA: 0x00781967 File Offset: 0x0077FB67
		// (set) Token: 0x06037703 RID: 227075 RVA: 0x0078196F File Offset: 0x0077FB6F
		public object Value { get; set; }

		// Token: 0x06037704 RID: 227076 RVA: 0x00781978 File Offset: 0x0077FB78
		public TMotorSoarInWindFieldControlTypeUnion()
		{
			this.Type = TMotorSoarInWindFieldControlType.NONE;
			this.Value = null;
		}

		// Token: 0x06037705 RID: 227077 RVA: 0x0078198E File Offset: 0x0077FB8E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037706 RID: 227078 RVA: 0x007819A0 File Offset: 0x0077FBA0
		public IMotorSoarInWindFieldEnterWindFieldT AsIMotorSoarInWindFieldEnterWindField()
		{
			return this.As<IMotorSoarInWindFieldEnterWindFieldT>();
		}

		// Token: 0x06037707 RID: 227079 RVA: 0x007819A8 File Offset: 0x0077FBA8
		public static TMotorSoarInWindFieldControlTypeUnion FromIMotorSoarInWindFieldEnterWindField(IMotorSoarInWindFieldEnterWindFieldT _imotorsoarinwindfieldenterwindfield)
		{
			return new TMotorSoarInWindFieldControlTypeUnion
			{
				Type = TMotorSoarInWindFieldControlType.IMotorSoarInWindFieldEnterWindField,
				Value = _imotorsoarinwindfieldenterwindfield
			};
		}

		// Token: 0x06037708 RID: 227080 RVA: 0x007819BD File Offset: 0x0077FBBD
		public IMotorSoarInWindFieldExitWindFieldT AsIMotorSoarInWindFieldExitWindField()
		{
			return this.As<IMotorSoarInWindFieldExitWindFieldT>();
		}

		// Token: 0x06037709 RID: 227081 RVA: 0x007819C5 File Offset: 0x0077FBC5
		public static TMotorSoarInWindFieldControlTypeUnion FromIMotorSoarInWindFieldExitWindField(IMotorSoarInWindFieldExitWindFieldT _imotorsoarinwindfieldexitwindfield)
		{
			return new TMotorSoarInWindFieldControlTypeUnion
			{
				Type = TMotorSoarInWindFieldControlType.IMotorSoarInWindFieldExitWindField,
				Value = _imotorsoarinwindfieldexitwindfield
			};
		}

		// Token: 0x0603770A RID: 227082 RVA: 0x007819DC File Offset: 0x0077FBDC
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
