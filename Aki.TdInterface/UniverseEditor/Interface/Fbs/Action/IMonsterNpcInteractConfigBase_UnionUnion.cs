using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200721D RID: 29213
	public class IMonsterNpcInteractConfigBase_UnionUnion
	{
		// Token: 0x1700D5D1 RID: 54737
		// (get) Token: 0x06032D46 RID: 208198 RVA: 0x006DD1FD File Offset: 0x006DB3FD
		// (set) Token: 0x06032D47 RID: 208199 RVA: 0x006DD205 File Offset: 0x006DB405
		public IMonsterNpcInteractConfigBase_Union Type { get; set; }

		// Token: 0x1700D5D2 RID: 54738
		// (get) Token: 0x06032D48 RID: 208200 RVA: 0x006DD20E File Offset: 0x006DB40E
		// (set) Token: 0x06032D49 RID: 208201 RVA: 0x006DD216 File Offset: 0x006DB416
		public object Value { get; set; }

		// Token: 0x06032D4A RID: 208202 RVA: 0x006DD21F File Offset: 0x006DB41F
		public IMonsterNpcInteractConfigBase_UnionUnion()
		{
			this.Type = IMonsterNpcInteractConfigBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06032D4B RID: 208203 RVA: 0x006DD235 File Offset: 0x006DB435
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06032D4C RID: 208204 RVA: 0x006DD247 File Offset: 0x006DB447
		public IMonsterNpcInteractConfigBaseT AsIMonsterNpcInteractConfigBase()
		{
			return this.As<IMonsterNpcInteractConfigBaseT>();
		}

		// Token: 0x06032D4D RID: 208205 RVA: 0x006DD24F File Offset: 0x006DB44F
		public static IMonsterNpcInteractConfigBase_UnionUnion FromIMonsterNpcInteractConfigBase(IMonsterNpcInteractConfigBaseT _imonsternpcinteractconfigbase)
		{
			return new IMonsterNpcInteractConfigBase_UnionUnion
			{
				Type = IMonsterNpcInteractConfigBase_Union.IMonsterNpcInteractConfigBase,
				Value = _imonsternpcinteractconfigbase
			};
		}

		// Token: 0x06032D4E RID: 208206 RVA: 0x006DD264 File Offset: 0x006DB464
		public IMonsterNpcInteractTriggerHookT AsIMonsterNpcInteractTriggerHook()
		{
			return this.As<IMonsterNpcInteractTriggerHookT>();
		}

		// Token: 0x06032D4F RID: 208207 RVA: 0x006DD26C File Offset: 0x006DB46C
		public static IMonsterNpcInteractConfigBase_UnionUnion FromIMonsterNpcInteractTriggerHook(IMonsterNpcInteractTriggerHookT _imonsternpcinteracttriggerhook)
		{
			return new IMonsterNpcInteractConfigBase_UnionUnion
			{
				Type = IMonsterNpcInteractConfigBase_Union.IMonsterNpcInteractTriggerHook,
				Value = _imonsternpcinteracttriggerhook
			};
		}

		// Token: 0x06032D50 RID: 208208 RVA: 0x006DD284 File Offset: 0x006DB484
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
