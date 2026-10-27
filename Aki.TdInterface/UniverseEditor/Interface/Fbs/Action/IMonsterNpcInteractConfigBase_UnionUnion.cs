using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AE6 RID: 27366
	public class IMonsterNpcInteractConfigBase_UnionUnion
	{
		// Token: 0x1700CB02 RID: 51970
		// (get) Token: 0x0602FF72 RID: 196466 RVA: 0x00685B45 File Offset: 0x00683D45
		// (set) Token: 0x0602FF73 RID: 196467 RVA: 0x00685B4D File Offset: 0x00683D4D
		public IMonsterNpcInteractConfigBase_Union Type { get; set; }

		// Token: 0x1700CB03 RID: 51971
		// (get) Token: 0x0602FF74 RID: 196468 RVA: 0x00685B56 File Offset: 0x00683D56
		// (set) Token: 0x0602FF75 RID: 196469 RVA: 0x00685B5E File Offset: 0x00683D5E
		public object Value { get; set; }

		// Token: 0x0602FF76 RID: 196470 RVA: 0x00685B67 File Offset: 0x00683D67
		public IMonsterNpcInteractConfigBase_UnionUnion()
		{
			this.Type = IMonsterNpcInteractConfigBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602FF77 RID: 196471 RVA: 0x00685B7D File Offset: 0x00683D7D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602FF78 RID: 196472 RVA: 0x00685B8F File Offset: 0x00683D8F
		public IMonsterNpcInteractConfigBaseT AsIMonsterNpcInteractConfigBase()
		{
			return this.As<IMonsterNpcInteractConfigBaseT>();
		}

		// Token: 0x0602FF79 RID: 196473 RVA: 0x00685B97 File Offset: 0x00683D97
		public static IMonsterNpcInteractConfigBase_UnionUnion FromIMonsterNpcInteractConfigBase(IMonsterNpcInteractConfigBaseT _imonsternpcinteractconfigbase)
		{
			return new IMonsterNpcInteractConfigBase_UnionUnion
			{
				Type = IMonsterNpcInteractConfigBase_Union.IMonsterNpcInteractConfigBase,
				Value = _imonsternpcinteractconfigbase
			};
		}

		// Token: 0x0602FF7A RID: 196474 RVA: 0x00685BAC File Offset: 0x00683DAC
		public IMonsterNpcInteractTriggerHookT AsIMonsterNpcInteractTriggerHook()
		{
			return this.As<IMonsterNpcInteractTriggerHookT>();
		}

		// Token: 0x0602FF7B RID: 196475 RVA: 0x00685BB4 File Offset: 0x00683DB4
		public static IMonsterNpcInteractConfigBase_UnionUnion FromIMonsterNpcInteractTriggerHook(IMonsterNpcInteractTriggerHookT _imonsternpcinteracttriggerhook)
		{
			return new IMonsterNpcInteractConfigBase_UnionUnion
			{
				Type = IMonsterNpcInteractConfigBase_Union.IMonsterNpcInteractTriggerHook,
				Value = _imonsternpcinteracttriggerhook
			};
		}

		// Token: 0x0602FF7C RID: 196476 RVA: 0x00685BCC File Offset: 0x00683DCC
		public static int Pack(FlatBufferBuilder builder, IMonsterNpcInteractConfigBase_UnionUnion _o)
		{
			IMonsterNpcInteractConfigBase_Union type = _o.Type;
			if (type == IMonsterNpcInteractConfigBase_Union.IMonsterNpcInteractConfigBase)
			{
				return IMonsterNpcInteractConfigBase.Pack(builder, _o.AsIMonsterNpcInteractConfigBase()).Value;
			}
			if (type != IMonsterNpcInteractConfigBase_Union.IMonsterNpcInteractTriggerHook)
			{
				return 0;
			}
			return IMonsterNpcInteractTriggerHook.Pack(builder, _o.AsIMonsterNpcInteractTriggerHook()).Value;
		}
	}
}
