using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F0D RID: 32525
	public class TInteractEffectUnion
	{
		// Token: 0x1700F281 RID: 62081
		// (get) Token: 0x0603AA91 RID: 240273 RVA: 0x007E3D4A File Offset: 0x007E1F4A
		// (set) Token: 0x0603AA92 RID: 240274 RVA: 0x007E3D52 File Offset: 0x007E1F52
		public TInteractEffect Type { get; set; }

		// Token: 0x1700F282 RID: 62082
		// (get) Token: 0x0603AA93 RID: 240275 RVA: 0x007E3D5B File Offset: 0x007E1F5B
		// (set) Token: 0x0603AA94 RID: 240276 RVA: 0x007E3D63 File Offset: 0x007E1F63
		public object Value { get; set; }

		// Token: 0x0603AA95 RID: 240277 RVA: 0x007E3D6C File Offset: 0x007E1F6C
		public TInteractEffectUnion()
		{
			this.Type = TInteractEffect.NONE;
			this.Value = null;
		}

		// Token: 0x0603AA96 RID: 240278 RVA: 0x007E3D82 File Offset: 0x007E1F82
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AA97 RID: 240279 RVA: 0x007E3D94 File Offset: 0x007E1F94
		public IExecuteTagT AsIExecuteTag()
		{
			return this.As<IExecuteTagT>();
		}

		// Token: 0x0603AA98 RID: 240280 RVA: 0x007E3D9C File Offset: 0x007E1F9C
		public static TInteractEffectUnion FromIExecuteTag(IExecuteTagT _iexecutetag)
		{
			return new TInteractEffectUnion
			{
				Type = TInteractEffect.IExecuteTag,
				Value = _iexecutetag
			};
		}

		// Token: 0x0603AA99 RID: 240281 RVA: 0x007E3DB1 File Offset: 0x007E1FB1
		public IModifyTipTextT AsIModifyTipText()
		{
			return this.As<IModifyTipTextT>();
		}

		// Token: 0x0603AA9A RID: 240282 RVA: 0x007E3DB9 File Offset: 0x007E1FB9
		public static TInteractEffectUnion FromIModifyTipText(IModifyTipTextT _imodifytiptext)
		{
			return new TInteractEffectUnion
			{
				Type = TInteractEffect.IModifyTipText,
				Value = _imodifytiptext
			};
		}

		// Token: 0x0603AA9B RID: 240283 RVA: 0x007E3DCE File Offset: 0x007E1FCE
		public ITriggerDialoguesT AsITriggerDialogues()
		{
			return this.As<ITriggerDialoguesT>();
		}

		// Token: 0x0603AA9C RID: 240284 RVA: 0x007E3DD6 File Offset: 0x007E1FD6
		public static TInteractEffectUnion FromITriggerDialogues(ITriggerDialoguesT _itriggerdialogues)
		{
			return new TInteractEffectUnion
			{
				Type = TInteractEffect.ITriggerDialogues,
				Value = _itriggerdialogues
			};
		}

		// Token: 0x0603AA9D RID: 240285 RVA: 0x007E3DEB File Offset: 0x007E1FEB
		public ITriggerVoiceDialoguesT AsITriggerVoiceDialogues()
		{
			return this.As<ITriggerVoiceDialoguesT>();
		}

		// Token: 0x0603AA9E RID: 240286 RVA: 0x007E3DF3 File Offset: 0x007E1FF3
		public static TInteractEffectUnion FromITriggerVoiceDialogues(ITriggerVoiceDialoguesT _itriggervoicedialogues)
		{
			return new TInteractEffectUnion
			{
				Type = TInteractEffect.ITriggerVoiceDialogues,
				Value = _itriggervoicedialogues
			};
		}

		// Token: 0x0603AA9F RID: 240287 RVA: 0x007E3E08 File Offset: 0x007E2008
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
