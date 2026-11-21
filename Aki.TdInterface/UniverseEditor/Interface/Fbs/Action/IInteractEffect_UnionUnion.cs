using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007038 RID: 28728
	public class IInteractEffect_UnionUnion
	{
		// Token: 0x1700D259 RID: 53849
		// (get) Token: 0x06031C9E RID: 203934 RVA: 0x006BD6A8 File Offset: 0x006BB8A8
		// (set) Token: 0x06031C9F RID: 203935 RVA: 0x006BD6B0 File Offset: 0x006BB8B0
		public IInteractEffect_Union Type { get; set; }

		// Token: 0x1700D25A RID: 53850
		// (get) Token: 0x06031CA0 RID: 203936 RVA: 0x006BD6B9 File Offset: 0x006BB8B9
		// (set) Token: 0x06031CA1 RID: 203937 RVA: 0x006BD6C1 File Offset: 0x006BB8C1
		public object Value { get; set; }

		// Token: 0x06031CA2 RID: 203938 RVA: 0x006BD6CA File Offset: 0x006BB8CA
		public IInteractEffect_UnionUnion()
		{
			this.Type = IInteractEffect_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06031CA3 RID: 203939 RVA: 0x006BD6E0 File Offset: 0x006BB8E0
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06031CA4 RID: 203940 RVA: 0x006BD6F2 File Offset: 0x006BB8F2
		public IInteractEffectT AsIInteractEffect()
		{
			return this.As<IInteractEffectT>();
		}

		// Token: 0x06031CA5 RID: 203941 RVA: 0x006BD6FA File Offset: 0x006BB8FA
		public static IInteractEffect_UnionUnion FromIInteractEffect(IInteractEffectT _iinteracteffect)
		{
			return new IInteractEffect_UnionUnion
			{
				Type = IInteractEffect_Union.IInteractEffect,
				Value = _iinteracteffect
			};
		}

		// Token: 0x06031CA6 RID: 203942 RVA: 0x006BD70F File Offset: 0x006BB90F
		public IModifyTipTextT AsIModifyTipText()
		{
			return this.As<IModifyTipTextT>();
		}

		// Token: 0x06031CA7 RID: 203943 RVA: 0x006BD717 File Offset: 0x006BB917
		public static IInteractEffect_UnionUnion FromIModifyTipText(IModifyTipTextT _imodifytiptext)
		{
			return new IInteractEffect_UnionUnion
			{
				Type = IInteractEffect_Union.IModifyTipText,
				Value = _imodifytiptext
			};
		}

		// Token: 0x06031CA8 RID: 203944 RVA: 0x006BD72C File Offset: 0x006BB92C
		public IExecuteTagT AsIExecuteTag()
		{
			return this.As<IExecuteTagT>();
		}

		// Token: 0x06031CA9 RID: 203945 RVA: 0x006BD734 File Offset: 0x006BB934
		public static IInteractEffect_UnionUnion FromIExecuteTag(IExecuteTagT _iexecutetag)
		{
			return new IInteractEffect_UnionUnion
			{
				Type = IInteractEffect_Union.IExecuteTag,
				Value = _iexecutetag
			};
		}

		// Token: 0x06031CAA RID: 203946 RVA: 0x006BD749 File Offset: 0x006BB949
		public ITriggerDialoguesT AsITriggerDialogues()
		{
			return this.As<ITriggerDialoguesT>();
		}

		// Token: 0x06031CAB RID: 203947 RVA: 0x006BD751 File Offset: 0x006BB951
		public static IInteractEffect_UnionUnion FromITriggerDialogues(ITriggerDialoguesT _itriggerdialogues)
		{
			return new IInteractEffect_UnionUnion
			{
				Type = IInteractEffect_Union.ITriggerDialogues,
				Value = _itriggerdialogues
			};
		}

		// Token: 0x06031CAC RID: 203948 RVA: 0x006BD766 File Offset: 0x006BB966
		public ITriggerVoiceDialoguesT AsITriggerVoiceDialogues()
		{
			return this.As<ITriggerVoiceDialoguesT>();
		}

		// Token: 0x06031CAD RID: 203949 RVA: 0x006BD76E File Offset: 0x006BB96E
		public static IInteractEffect_UnionUnion FromITriggerVoiceDialogues(ITriggerVoiceDialoguesT _itriggervoicedialogues)
		{
			return new IInteractEffect_UnionUnion
			{
				Type = IInteractEffect_Union.ITriggerVoiceDialogues,
				Value = _itriggervoicedialogues
			};
		}

		// Token: 0x06031CAE RID: 203950 RVA: 0x006BD784 File Offset: 0x006BB984
		public static int Pack(FlatBufferBuilder builder, IInteractEffect_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IInteractEffect_Union.IInteractEffect:
				return IInteractEffect.Pack(builder, _o.AsIInteractEffect()).Value;
			case IInteractEffect_Union.IModifyTipText:
				return IModifyTipText.Pack(builder, _o.AsIModifyTipText()).Value;
			case IInteractEffect_Union.IExecuteTag:
				return IExecuteTag.Pack(builder, _o.AsIExecuteTag()).Value;
			case IInteractEffect_Union.ITriggerDialogues:
				return ITriggerDialogues.Pack(builder, _o.AsITriggerDialogues()).Value;
			case IInteractEffect_Union.ITriggerVoiceDialogues:
				return ITriggerVoiceDialogues.Pack(builder, _o.AsITriggerVoiceDialogues()).Value;
			default:
				return 0;
			}
		}
	}
}
