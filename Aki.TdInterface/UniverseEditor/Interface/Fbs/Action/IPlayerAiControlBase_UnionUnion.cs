using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007466 RID: 29798
	public class IPlayerAiControlBase_UnionUnion
	{
		// Token: 0x1700DAF3 RID: 56051
		// (get) Token: 0x060342A1 RID: 213665 RVA: 0x007072D1 File Offset: 0x007054D1
		// (set) Token: 0x060342A2 RID: 213666 RVA: 0x007072D9 File Offset: 0x007054D9
		public IPlayerAiControlBase_Union Type { get; set; }

		// Token: 0x1700DAF4 RID: 56052
		// (get) Token: 0x060342A3 RID: 213667 RVA: 0x007072E2 File Offset: 0x007054E2
		// (set) Token: 0x060342A4 RID: 213668 RVA: 0x007072EA File Offset: 0x007054EA
		public object Value { get; set; }

		// Token: 0x060342A5 RID: 213669 RVA: 0x007072F3 File Offset: 0x007054F3
		public IPlayerAiControlBase_UnionUnion()
		{
			this.Type = IPlayerAiControlBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060342A6 RID: 213670 RVA: 0x00707309 File Offset: 0x00705509
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060342A7 RID: 213671 RVA: 0x0070731B File Offset: 0x0070551B
		public IPlayerAiControlBaseT AsIPlayerAiControlBase()
		{
			return this.As<IPlayerAiControlBaseT>();
		}

		// Token: 0x060342A8 RID: 213672 RVA: 0x00707323 File Offset: 0x00705523
		public static IPlayerAiControlBase_UnionUnion FromIPlayerAiControlBase(IPlayerAiControlBaseT _iplayeraicontrolbase)
		{
			return new IPlayerAiControlBase_UnionUnion
			{
				Type = IPlayerAiControlBase_Union.IPlayerAiControlBase,
				Value = _iplayeraicontrolbase
			};
		}

		// Token: 0x060342A9 RID: 213673 RVA: 0x00707338 File Offset: 0x00705538
		public IEnablePlayerAiControlT AsIEnablePlayerAiControl()
		{
			return this.As<IEnablePlayerAiControlT>();
		}

		// Token: 0x060342AA RID: 213674 RVA: 0x00707340 File Offset: 0x00705540
		public static IPlayerAiControlBase_UnionUnion FromIEnablePlayerAiControl(IEnablePlayerAiControlT _ienableplayeraicontrol)
		{
			return new IPlayerAiControlBase_UnionUnion
			{
				Type = IPlayerAiControlBase_Union.IEnablePlayerAiControl,
				Value = _ienableplayeraicontrol
			};
		}

		// Token: 0x060342AB RID: 213675 RVA: 0x00707355 File Offset: 0x00705555
		public IDisablePlayerAiControlT AsIDisablePlayerAiControl()
		{
			return this.As<IDisablePlayerAiControlT>();
		}

		// Token: 0x060342AC RID: 213676 RVA: 0x0070735D File Offset: 0x0070555D
		public static IPlayerAiControlBase_UnionUnion FromIDisablePlayerAiControl(IDisablePlayerAiControlT _idisableplayeraicontrol)
		{
			return new IPlayerAiControlBase_UnionUnion
			{
				Type = IPlayerAiControlBase_Union.IDisablePlayerAiControl,
				Value = _idisableplayeraicontrol
			};
		}

		// Token: 0x060342AD RID: 213677 RVA: 0x00707374 File Offset: 0x00705574
		public static int Pack(FlatBufferBuilder builder, IPlayerAiControlBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IPlayerAiControlBase_Union.IPlayerAiControlBase:
				return IPlayerAiControlBase.Pack(builder, _o.AsIPlayerAiControlBase()).Value;
			case IPlayerAiControlBase_Union.IEnablePlayerAiControl:
				return IEnablePlayerAiControl.Pack(builder, _o.AsIEnablePlayerAiControl()).Value;
			case IPlayerAiControlBase_Union.IDisablePlayerAiControl:
				return IDisablePlayerAiControl.Pack(builder, _o.AsIDisablePlayerAiControl()).Value;
			default:
				return 0;
			}
		}
	}
}
