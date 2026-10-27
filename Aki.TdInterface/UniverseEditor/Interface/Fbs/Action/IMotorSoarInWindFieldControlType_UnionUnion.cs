using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B3A RID: 27450
	public class IMotorSoarInWindFieldControlType_UnionUnion
	{
		// Token: 0x1700CBF2 RID: 52210
		// (get) Token: 0x060302D1 RID: 197329 RVA: 0x0068C2CD File Offset: 0x0068A4CD
		// (set) Token: 0x060302D2 RID: 197330 RVA: 0x0068C2D5 File Offset: 0x0068A4D5
		public IMotorSoarInWindFieldControlType_Union Type { get; set; }

		// Token: 0x1700CBF3 RID: 52211
		// (get) Token: 0x060302D3 RID: 197331 RVA: 0x0068C2DE File Offset: 0x0068A4DE
		// (set) Token: 0x060302D4 RID: 197332 RVA: 0x0068C2E6 File Offset: 0x0068A4E6
		public object Value { get; set; }

		// Token: 0x060302D5 RID: 197333 RVA: 0x0068C2EF File Offset: 0x0068A4EF
		public IMotorSoarInWindFieldControlType_UnionUnion()
		{
			this.Type = IMotorSoarInWindFieldControlType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060302D6 RID: 197334 RVA: 0x0068C305 File Offset: 0x0068A505
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060302D7 RID: 197335 RVA: 0x0068C317 File Offset: 0x0068A517
		public IMotorSoarInWindFieldControlTypeT AsIMotorSoarInWindFieldControlType()
		{
			return this.As<IMotorSoarInWindFieldControlTypeT>();
		}

		// Token: 0x060302D8 RID: 197336 RVA: 0x0068C31F File Offset: 0x0068A51F
		public static IMotorSoarInWindFieldControlType_UnionUnion FromIMotorSoarInWindFieldControlType(IMotorSoarInWindFieldControlTypeT _imotorsoarinwindfieldcontroltype)
		{
			return new IMotorSoarInWindFieldControlType_UnionUnion
			{
				Type = IMotorSoarInWindFieldControlType_Union.IMotorSoarInWindFieldControlType,
				Value = _imotorsoarinwindfieldcontroltype
			};
		}

		// Token: 0x060302D9 RID: 197337 RVA: 0x0068C334 File Offset: 0x0068A534
		public IMotorSoarInWindFieldEnterWindFieldT AsIMotorSoarInWindFieldEnterWindField()
		{
			return this.As<IMotorSoarInWindFieldEnterWindFieldT>();
		}

		// Token: 0x060302DA RID: 197338 RVA: 0x0068C33C File Offset: 0x0068A53C
		public static IMotorSoarInWindFieldControlType_UnionUnion FromIMotorSoarInWindFieldEnterWindField(IMotorSoarInWindFieldEnterWindFieldT _imotorsoarinwindfieldenterwindfield)
		{
			return new IMotorSoarInWindFieldControlType_UnionUnion
			{
				Type = IMotorSoarInWindFieldControlType_Union.IMotorSoarInWindFieldEnterWindField,
				Value = _imotorsoarinwindfieldenterwindfield
			};
		}

		// Token: 0x060302DB RID: 197339 RVA: 0x0068C351 File Offset: 0x0068A551
		public IMotorSoarInWindFieldExitWindFieldT AsIMotorSoarInWindFieldExitWindField()
		{
			return this.As<IMotorSoarInWindFieldExitWindFieldT>();
		}

		// Token: 0x060302DC RID: 197340 RVA: 0x0068C359 File Offset: 0x0068A559
		public static IMotorSoarInWindFieldControlType_UnionUnion FromIMotorSoarInWindFieldExitWindField(IMotorSoarInWindFieldExitWindFieldT _imotorsoarinwindfieldexitwindfield)
		{
			return new IMotorSoarInWindFieldControlType_UnionUnion
			{
				Type = IMotorSoarInWindFieldControlType_Union.IMotorSoarInWindFieldExitWindField,
				Value = _imotorsoarinwindfieldexitwindfield
			};
		}

		// Token: 0x060302DD RID: 197341 RVA: 0x0068C370 File Offset: 0x0068A570
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
