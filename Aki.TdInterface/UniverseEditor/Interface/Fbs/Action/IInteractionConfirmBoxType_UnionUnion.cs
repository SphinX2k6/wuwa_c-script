using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007041 RID: 28737
	public class IInteractionConfirmBoxType_UnionUnion
	{
		// Token: 0x1700D263 RID: 53859
		// (get) Token: 0x06031CD8 RID: 203992 RVA: 0x006BDC75 File Offset: 0x006BBE75
		// (set) Token: 0x06031CD9 RID: 203993 RVA: 0x006BDC7D File Offset: 0x006BBE7D
		public IInteractionConfirmBoxType_Union Type { get; set; }

		// Token: 0x1700D264 RID: 53860
		// (get) Token: 0x06031CDA RID: 203994 RVA: 0x006BDC86 File Offset: 0x006BBE86
		// (set) Token: 0x06031CDB RID: 203995 RVA: 0x006BDC8E File Offset: 0x006BBE8E
		public object Value { get; set; }

		// Token: 0x06031CDC RID: 203996 RVA: 0x006BDC97 File Offset: 0x006BBE97
		public IInteractionConfirmBoxType_UnionUnion()
		{
			this.Type = IInteractionConfirmBoxType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06031CDD RID: 203997 RVA: 0x006BDCAD File Offset: 0x006BBEAD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06031CDE RID: 203998 RVA: 0x006BDCBF File Offset: 0x006BBEBF
		public IInteractionConfirmBoxTypeT AsIInteractionConfirmBoxType()
		{
			return this.As<IInteractionConfirmBoxTypeT>();
		}

		// Token: 0x06031CDF RID: 203999 RVA: 0x006BDCC7 File Offset: 0x006BBEC7
		public static IInteractionConfirmBoxType_UnionUnion FromIInteractionConfirmBoxType(IInteractionConfirmBoxTypeT _iinteractionconfirmboxtype)
		{
			return new IInteractionConfirmBoxType_UnionUnion
			{
				Type = IInteractionConfirmBoxType_Union.IInteractionConfirmBoxType,
				Value = _iinteractionconfirmboxtype
			};
		}

		// Token: 0x06031CE0 RID: 204000 RVA: 0x006BDCDC File Offset: 0x006BBEDC
		public ICommonConfirmBoxT AsICommonConfirmBox()
		{
			return this.As<ICommonConfirmBoxT>();
		}

		// Token: 0x06031CE1 RID: 204001 RVA: 0x006BDCE4 File Offset: 0x006BBEE4
		public static IInteractionConfirmBoxType_UnionUnion FromICommonConfirmBox(ICommonConfirmBoxT _icommonconfirmbox)
		{
			return new IInteractionConfirmBoxType_UnionUnion
			{
				Type = IInteractionConfirmBoxType_Union.ICommonConfirmBox,
				Value = _icommonconfirmbox
			};
		}

		// Token: 0x06031CE2 RID: 204002 RVA: 0x006BDCF9 File Offset: 0x006BBEF9
		public IHonamiStoryCorruptedChestConfirmBoxT AsIHonamiStoryCorruptedChestConfirmBox()
		{
			return this.As<IHonamiStoryCorruptedChestConfirmBoxT>();
		}

		// Token: 0x06031CE3 RID: 204003 RVA: 0x006BDD01 File Offset: 0x006BBF01
		public static IInteractionConfirmBoxType_UnionUnion FromIHonamiStoryCorruptedChestConfirmBox(IHonamiStoryCorruptedChestConfirmBoxT _ihonamistorycorruptedchestconfirmbox)
		{
			return new IInteractionConfirmBoxType_UnionUnion
			{
				Type = IInteractionConfirmBoxType_Union.IHonamiStoryCorruptedChestConfirmBox,
				Value = _ihonamistorycorruptedchestconfirmbox
			};
		}

		// Token: 0x06031CE4 RID: 204004 RVA: 0x006BDD16 File Offset: 0x006BBF16
		public IHonamiStoryEvacuateConfirmBoxT AsIHonamiStoryEvacuateConfirmBox()
		{
			return this.As<IHonamiStoryEvacuateConfirmBoxT>();
		}

		// Token: 0x06031CE5 RID: 204005 RVA: 0x006BDD1E File Offset: 0x006BBF1E
		public static IInteractionConfirmBoxType_UnionUnion FromIHonamiStoryEvacuateConfirmBox(IHonamiStoryEvacuateConfirmBoxT _ihonamistoryevacuateconfirmbox)
		{
			return new IInteractionConfirmBoxType_UnionUnion
			{
				Type = IInteractionConfirmBoxType_Union.IHonamiStoryEvacuateConfirmBox,
				Value = _ihonamistoryevacuateconfirmbox
			};
		}

		// Token: 0x06031CE6 RID: 204006 RVA: 0x006BDD34 File Offset: 0x006BBF34
		public static int Pack(FlatBufferBuilder builder, IInteractionConfirmBoxType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IInteractionConfirmBoxType_Union.IInteractionConfirmBoxType:
				return IInteractionConfirmBoxType.Pack(builder, _o.AsIInteractionConfirmBoxType()).Value;
			case IInteractionConfirmBoxType_Union.ICommonConfirmBox:
				return ICommonConfirmBox.Pack(builder, _o.AsICommonConfirmBox()).Value;
			case IInteractionConfirmBoxType_Union.IHonamiStoryCorruptedChestConfirmBox:
				return IHonamiStoryCorruptedChestConfirmBox.Pack(builder, _o.AsIHonamiStoryCorruptedChestConfirmBox()).Value;
			case IInteractionConfirmBoxType_Union.IHonamiStoryEvacuateConfirmBox:
				return IHonamiStoryEvacuateConfirmBox.Pack(builder, _o.AsIHonamiStoryEvacuateConfirmBox()).Value;
			default:
				return 0;
			}
		}
	}
}
