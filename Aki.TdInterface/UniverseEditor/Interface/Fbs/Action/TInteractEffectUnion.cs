using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076F9 RID: 30457
	public class TInteractEffectUnion
	{
		// Token: 0x1700E63F RID: 58943
		// (get) Token: 0x060375C4 RID: 226756 RVA: 0x0077F83E File Offset: 0x0077DA3E
		// (set) Token: 0x060375C5 RID: 226757 RVA: 0x0077F846 File Offset: 0x0077DA46
		public TInteractEffect Type { get; set; }

		// Token: 0x1700E640 RID: 58944
		// (get) Token: 0x060375C6 RID: 226758 RVA: 0x0077F84F File Offset: 0x0077DA4F
		// (set) Token: 0x060375C7 RID: 226759 RVA: 0x0077F857 File Offset: 0x0077DA57
		public object Value { get; set; }

		// Token: 0x060375C8 RID: 226760 RVA: 0x0077F860 File Offset: 0x0077DA60
		public TInteractEffectUnion()
		{
			this.Type = TInteractEffect.NONE;
			this.Value = null;
		}

		// Token: 0x060375C9 RID: 226761 RVA: 0x0077F876 File Offset: 0x0077DA76
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060375CA RID: 226762 RVA: 0x0077F888 File Offset: 0x0077DA88
		public IExecuteTagT AsIExecuteTag()
		{
			return this.As<IExecuteTagT>();
		}

		// Token: 0x060375CB RID: 226763 RVA: 0x0077F890 File Offset: 0x0077DA90
		public static TInteractEffectUnion FromIExecuteTag(IExecuteTagT _iexecutetag)
		{
			return new TInteractEffectUnion
			{
				Type = TInteractEffect.IExecuteTag,
				Value = _iexecutetag
			};
		}

		// Token: 0x060375CC RID: 226764 RVA: 0x0077F8A5 File Offset: 0x0077DAA5
		public IModifyTipTextT AsIModifyTipText()
		{
			return this.As<IModifyTipTextT>();
		}

		// Token: 0x060375CD RID: 226765 RVA: 0x0077F8AD File Offset: 0x0077DAAD
		public static TInteractEffectUnion FromIModifyTipText(IModifyTipTextT _imodifytiptext)
		{
			return new TInteractEffectUnion
			{
				Type = TInteractEffect.IModifyTipText,
				Value = _imodifytiptext
			};
		}

		// Token: 0x060375CE RID: 226766 RVA: 0x0077F8C2 File Offset: 0x0077DAC2
		public ITriggerDialoguesT AsITriggerDialogues()
		{
			return this.As<ITriggerDialoguesT>();
		}

		// Token: 0x060375CF RID: 226767 RVA: 0x0077F8CA File Offset: 0x0077DACA
		public static TInteractEffectUnion FromITriggerDialogues(ITriggerDialoguesT _itriggerdialogues)
		{
			return new TInteractEffectUnion
			{
				Type = TInteractEffect.ITriggerDialogues,
				Value = _itriggerdialogues
			};
		}

		// Token: 0x060375D0 RID: 226768 RVA: 0x0077F8DF File Offset: 0x0077DADF
		public ITriggerVoiceDialoguesT AsITriggerVoiceDialogues()
		{
			return this.As<ITriggerVoiceDialoguesT>();
		}

		// Token: 0x060375D1 RID: 226769 RVA: 0x0077F8E7 File Offset: 0x0077DAE7
		public static TInteractEffectUnion FromITriggerVoiceDialogues(ITriggerVoiceDialoguesT _itriggervoicedialogues)
		{
			return new TInteractEffectUnion
			{
				Type = TInteractEffect.ITriggerVoiceDialogues,
				Value = _itriggervoicedialogues
			};
		}

		// Token: 0x060375D2 RID: 226770 RVA: 0x0077F8FC File Offset: 0x0077DAFC
		public static int Pack(FlatBufferBuilder builder, TInteractEffectUnion _o)
		{
			switch (_o.Type)
			{
			case TInteractEffect.IExecuteTag:
				return IExecuteTag.Pack(builder, _o.AsIExecuteTag()).Value;
			case TInteractEffect.IModifyTipText:
				return IModifyTipText.Pack(builder, _o.AsIModifyTipText()).Value;
			case TInteractEffect.ITriggerDialogues:
				return ITriggerDialogues.Pack(builder, _o.AsITriggerDialogues()).Value;
			case TInteractEffect.ITriggerVoiceDialogues:
				return ITriggerVoiceDialogues.Pack(builder, _o.AsITriggerVoiceDialogues()).Value;
			default:
				return 0;
			}
		}
	}
}
