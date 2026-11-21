using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064B0 RID: 25776
	public class TCommonTargetUnion
	{
		// Token: 0x1700BE25 RID: 48677
		// (get) Token: 0x0602BD2B RID: 179499 RVA: 0x005F5CAA File Offset: 0x005F3EAA
		// (set) Token: 0x0602BD2C RID: 179500 RVA: 0x005F5CB2 File Offset: 0x005F3EB2
		public TCommonTarget Type { get; set; }

		// Token: 0x1700BE26 RID: 48678
		// (get) Token: 0x0602BD2D RID: 179501 RVA: 0x005F5CBB File Offset: 0x005F3EBB
		// (set) Token: 0x0602BD2E RID: 179502 RVA: 0x005F5CC3 File Offset: 0x005F3EC3
		public object Value { get; set; }

		// Token: 0x0602BD2F RID: 179503 RVA: 0x005F5CCC File Offset: 0x005F3ECC
		public TCommonTargetUnion()
		{
			this.Type = TCommonTarget.NONE;
			this.Value = null;
		}

		// Token: 0x0602BD30 RID: 179504 RVA: 0x005F5CE2 File Offset: 0x005F3EE2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602BD31 RID: 179505 RVA: 0x005F5CF4 File Offset: 0x005F3EF4
		public IAssistCharacterTargetT AsIAssistCharacterTarget()
		{
			return this.As<IAssistCharacterTargetT>();
		}

		// Token: 0x0602BD32 RID: 179506 RVA: 0x005F5CFC File Offset: 0x005F3EFC
		public static TCommonTargetUnion FromIAssistCharacterTarget(IAssistCharacterTargetT _iassistcharactertarget)
		{
			return new TCommonTargetUnion
			{
				Type = TCommonTarget.IAssistCharacterTarget,
				Value = _iassistcharactertarget
			};
		}

		// Token: 0x0602BD33 RID: 179507 RVA: 0x005F5D11 File Offset: 0x005F3F11
		public IPlayerTargetT AsIPlayerTarget()
		{
			return this.As<IPlayerTargetT>();
		}

		// Token: 0x0602BD34 RID: 179508 RVA: 0x005F5D19 File Offset: 0x005F3F19
		public static TCommonTargetUnion FromIPlayerTarget(IPlayerTargetT _iplayertarget)
		{
			return new TCommonTargetUnion
			{
				Type = TCommonTarget.IPlayerTarget,
				Value = _iplayertarget
			};
		}

		// Token: 0x0602BD35 RID: 179509 RVA: 0x005F5D30 File Offset: 0x005F3F30
		public static int Pack(FlatBufferBuilder builder, TCommonTargetUnion _o)
		{
			TCommonTarget type = _o.Type;
			if (type == TCommonTarget.IAssistCharacterTarget)
			{
				return IAssistCharacterTarget.Pack(builder, _o.AsIAssistCharacterTarget()).Value;
			}
			if (type != TCommonTarget.IPlayerTarget)
			{
				return 0;
			}
			return IPlayerTarget.Pack(builder, _o.AsIPlayerTarget()).Value;
		}
	}
}
