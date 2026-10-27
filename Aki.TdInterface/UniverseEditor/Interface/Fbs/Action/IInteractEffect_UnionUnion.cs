using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006985 RID: 27013
	public class IInteractEffect_UnionUnion
	{
		// Token: 0x1700C856 RID: 51286
		// (get) Token: 0x0602F2CE RID: 193230 RVA: 0x0066D1C0 File Offset: 0x0066B3C0
		// (set) Token: 0x0602F2CF RID: 193231 RVA: 0x0066D1C8 File Offset: 0x0066B3C8
		public IInteractEffect_Union Type { get; set; }

		// Token: 0x1700C857 RID: 51287
		// (get) Token: 0x0602F2D0 RID: 193232 RVA: 0x0066D1D1 File Offset: 0x0066B3D1
		// (set) Token: 0x0602F2D1 RID: 193233 RVA: 0x0066D1D9 File Offset: 0x0066B3D9
		public object Value { get; set; }

		// Token: 0x0602F2D2 RID: 193234 RVA: 0x0066D1E2 File Offset: 0x0066B3E2
		public IInteractEffect_UnionUnion()
		{
			this.Type = IInteractEffect_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602F2D3 RID: 193235 RVA: 0x0066D1F8 File Offset: 0x0066B3F8
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602F2D4 RID: 193236 RVA: 0x0066D20A File Offset: 0x0066B40A
		public IInteractEffectT AsIInteractEffect()
		{
			return this.As<IInteractEffectT>();
		}

		// Token: 0x0602F2D5 RID: 193237 RVA: 0x0066D212 File Offset: 0x0066B412
		public static IInteractEffect_UnionUnion FromIInteractEffect(IInteractEffectT _iinteracteffect)
		{
			return new IInteractEffect_UnionUnion
			{
				Type = IInteractEffect_Union.IInteractEffect,
				Value = _iinteracteffect
			};
		}

		// Token: 0x0602F2D6 RID: 193238 RVA: 0x0066D227 File Offset: 0x0066B427
		public IModifyTipTextT AsIModifyTipText()
		{
			return this.As<IModifyTipTextT>();
		}

		// Token: 0x0602F2D7 RID: 193239 RVA: 0x0066D22F File Offset: 0x0066B42F
		public static IInteractEffect_UnionUnion FromIModifyTipText(IModifyTipTextT _imodifytiptext)
		{
			return new IInteractEffect_UnionUnion
			{
				Type = IInteractEffect_Union.IModifyTipText,
				Value = _imodifytiptext
			};
		}

		// Token: 0x0602F2D8 RID: 193240 RVA: 0x0066D244 File Offset: 0x0066B444
		public IExecuteTagT AsIExecuteTag()
		{
			return this.As<IExecuteTagT>();
		}

		// Token: 0x0602F2D9 RID: 193241 RVA: 0x0066D24C File Offset: 0x0066B44C
		public static IInteractEffect_UnionUnion FromIExecuteTag(IExecuteTagT _iexecutetag)
		{
			return new IInteractEffect_UnionUnion
			{
				Type = IInteractEffect_Union.IExecuteTag,
				Value = _iexecutetag
			};
		}

		// Token: 0x0602F2DA RID: 193242 RVA: 0x0066D261 File Offset: 0x0066B461
		public ITriggerDialoguesT AsITriggerDialogues()
		{
			return this.As<ITriggerDialoguesT>();
		}

		// Token: 0x0602F2DB RID: 193243 RVA: 0x0066D269 File Offset: 0x0066B469
		public static IInteractEffect_UnionUnion FromITriggerDialogues(ITriggerDialoguesT _itriggerdialogues)
		{
			return new IInteractEffect_UnionUnion
			{
				Type = IInteractEffect_Union.ITriggerDialogues,
				Value = _itriggerdialogues
			};
		}

		// Token: 0x0602F2DC RID: 193244 RVA: 0x0066D27E File Offset: 0x0066B47E
		public ITriggerVoiceDialoguesT AsITriggerVoiceDialogues()
		{
			return this.As<ITriggerVoiceDialoguesT>();
		}

		// Token: 0x0602F2DD RID: 193245 RVA: 0x0066D286 File Offset: 0x0066B486
		public static IInteractEffect_UnionUnion FromITriggerVoiceDialogues(ITriggerVoiceDialoguesT _itriggervoicedialogues)
		{
			return new IInteractEffect_UnionUnion
			{
				Type = IInteractEffect_Union.ITriggerVoiceDialogues,
				Value = _itriggervoicedialogues
			};
		}

		// Token: 0x0602F2DE RID: 193246 RVA: 0x0066D29C File Offset: 0x0066B49C
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
