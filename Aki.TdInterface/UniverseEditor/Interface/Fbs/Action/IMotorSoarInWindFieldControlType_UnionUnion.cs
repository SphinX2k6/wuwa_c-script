using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007280 RID: 29312
	public class IMotorSoarInWindFieldControlType_UnionUnion
	{
		// Token: 0x1700D6D7 RID: 54999
		// (get) Token: 0x06033128 RID: 209192 RVA: 0x006E4889 File Offset: 0x006E2A89
		// (set) Token: 0x06033129 RID: 209193 RVA: 0x006E4891 File Offset: 0x006E2A91
		public IMotorSoarInWindFieldControlType_Union Type { get; set; }

		// Token: 0x1700D6D8 RID: 55000
		// (get) Token: 0x0603312A RID: 209194 RVA: 0x006E489A File Offset: 0x006E2A9A
		// (set) Token: 0x0603312B RID: 209195 RVA: 0x006E48A2 File Offset: 0x006E2AA2
		public object Value { get; set; }

		// Token: 0x0603312C RID: 209196 RVA: 0x006E48AB File Offset: 0x006E2AAB
		public IMotorSoarInWindFieldControlType_UnionUnion()
		{
			this.Type = IMotorSoarInWindFieldControlType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603312D RID: 209197 RVA: 0x006E48C1 File Offset: 0x006E2AC1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603312E RID: 209198 RVA: 0x006E48D3 File Offset: 0x006E2AD3
		public IMotorSoarInWindFieldControlTypeT AsIMotorSoarInWindFieldControlType()
		{
			return this.As<IMotorSoarInWindFieldControlTypeT>();
		}

		// Token: 0x0603312F RID: 209199 RVA: 0x006E48DB File Offset: 0x006E2ADB
		public static IMotorSoarInWindFieldControlType_UnionUnion FromIMotorSoarInWindFieldControlType(IMotorSoarInWindFieldControlTypeT _imotorsoarinwindfieldcontroltype)
		{
			return new IMotorSoarInWindFieldControlType_UnionUnion
			{
				Type = IMotorSoarInWindFieldControlType_Union.IMotorSoarInWindFieldControlType,
				Value = _imotorsoarinwindfieldcontroltype
			};
		}

		// Token: 0x06033130 RID: 209200 RVA: 0x006E48F0 File Offset: 0x006E2AF0
		public IMotorSoarInWindFieldEnterWindFieldT AsIMotorSoarInWindFieldEnterWindField()
		{
			return this.As<IMotorSoarInWindFieldEnterWindFieldT>();
		}

		// Token: 0x06033131 RID: 209201 RVA: 0x006E48F8 File Offset: 0x006E2AF8
		public static IMotorSoarInWindFieldControlType_UnionUnion FromIMotorSoarInWindFieldEnterWindField(IMotorSoarInWindFieldEnterWindFieldT _imotorsoarinwindfieldenterwindfield)
		{
			return new IMotorSoarInWindFieldControlType_UnionUnion
			{
				Type = IMotorSoarInWindFieldControlType_Union.IMotorSoarInWindFieldEnterWindField,
				Value = _imotorsoarinwindfieldenterwindfield
			};
		}

		// Token: 0x06033132 RID: 209202 RVA: 0x006E490D File Offset: 0x006E2B0D
		public IMotorSoarInWindFieldExitWindFieldT AsIMotorSoarInWindFieldExitWindField()
		{
			return this.As<IMotorSoarInWindFieldExitWindFieldT>();
		}

		// Token: 0x06033133 RID: 209203 RVA: 0x006E4915 File Offset: 0x006E2B15
		public static IMotorSoarInWindFieldControlType_UnionUnion FromIMotorSoarInWindFieldExitWindField(IMotorSoarInWindFieldExitWindFieldT _imotorsoarinwindfieldexitwindfield)
		{
			return new IMotorSoarInWindFieldControlType_UnionUnion
			{
				Type = IMotorSoarInWindFieldControlType_Union.IMotorSoarInWindFieldExitWindField,
				Value = _imotorsoarinwindfieldexitwindfield
			};
		}

		// Token: 0x06033134 RID: 209204 RVA: 0x006E492C File Offset: 0x006E2B2C
		public static int Pack(FlatBufferBuilder builder, IMotorSoarInWindFieldControlType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IMotorSoarInWindFieldControlType_Union.IMotorSoarInWindFieldControlType:
				return IMotorSoarInWindFieldControlType.Pack(builder, _o.AsIMotorSoarInWindFieldControlType()).Value;
			case IMotorSoarInWindFieldControlType_Union.IMotorSoarInWindFieldEnterWindField:
				return IMotorSoarInWindFieldEnterWindField.Pack(builder, _o.AsIMotorSoarInWindFieldEnterWindField()).Value;
			case IMotorSoarInWindFieldControlType_Union.IMotorSoarInWindFieldExitWindField:
				return IMotorSoarInWindFieldExitWindField.Pack(builder, _o.AsIMotorSoarInWindFieldExitWindField()).Value;
			default:
				return 0;
			}
		}
	}
}
