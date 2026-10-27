using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200698E RID: 27022
	public class IInteractionConfirmBoxType_UnionUnion
	{
		// Token: 0x1700C860 RID: 51296
		// (get) Token: 0x0602F308 RID: 193288 RVA: 0x0066D78D File Offset: 0x0066B98D
		// (set) Token: 0x0602F309 RID: 193289 RVA: 0x0066D795 File Offset: 0x0066B995
		public IInteractionConfirmBoxType_Union Type { get; set; }

		// Token: 0x1700C861 RID: 51297
		// (get) Token: 0x0602F30A RID: 193290 RVA: 0x0066D79E File Offset: 0x0066B99E
		// (set) Token: 0x0602F30B RID: 193291 RVA: 0x0066D7A6 File Offset: 0x0066B9A6
		public object Value { get; set; }

		// Token: 0x0602F30C RID: 193292 RVA: 0x0066D7AF File Offset: 0x0066B9AF
		public IInteractionConfirmBoxType_UnionUnion()
		{
			this.Type = IInteractionConfirmBoxType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602F30D RID: 193293 RVA: 0x0066D7C5 File Offset: 0x0066B9C5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602F30E RID: 193294 RVA: 0x0066D7D7 File Offset: 0x0066B9D7
		public IInteractionConfirmBoxTypeT AsIInteractionConfirmBoxType()
		{
			return this.As<IInteractionConfirmBoxTypeT>();
		}

		// Token: 0x0602F30F RID: 193295 RVA: 0x0066D7DF File Offset: 0x0066B9DF
		public static IInteractionConfirmBoxType_UnionUnion FromIInteractionConfirmBoxType(IInteractionConfirmBoxTypeT _iinteractionconfirmboxtype)
		{
			return new IInteractionConfirmBoxType_UnionUnion
			{
				Type = IInteractionConfirmBoxType_Union.IInteractionConfirmBoxType,
				Value = _iinteractionconfirmboxtype
			};
		}

		// Token: 0x0602F310 RID: 193296 RVA: 0x0066D7F4 File Offset: 0x0066B9F4
		public ICommonConfirmBoxT AsICommonConfirmBox()
		{
			return this.As<ICommonConfirmBoxT>();
		}

		// Token: 0x0602F311 RID: 193297 RVA: 0x0066D7FC File Offset: 0x0066B9FC
		public static IInteractionConfirmBoxType_UnionUnion FromICommonConfirmBox(ICommonConfirmBoxT _icommonconfirmbox)
		{
			return new IInteractionConfirmBoxType_UnionUnion
			{
				Type = IInteractionConfirmBoxType_Union.ICommonConfirmBox,
				Value = _icommonconfirmbox
			};
		}

		// Token: 0x0602F312 RID: 193298 RVA: 0x0066D811 File Offset: 0x0066BA11
		public IHonamiStoryCorruptedChestConfirmBoxT AsIHonamiStoryCorruptedChestConfirmBox()
		{
			return this.As<IHonamiStoryCorruptedChestConfirmBoxT>();
		}

		// Token: 0x0602F313 RID: 193299 RVA: 0x0066D819 File Offset: 0x0066BA19
		public static IInteractionConfirmBoxType_UnionUnion FromIHonamiStoryCorruptedChestConfirmBox(IHonamiStoryCorruptedChestConfirmBoxT _ihonamistorycorruptedchestconfirmbox)
		{
			return new IInteractionConfirmBoxType_UnionUnion
			{
				Type = IInteractionConfirmBoxType_Union.IHonamiStoryCorruptedChestConfirmBox,
				Value = _ihonamistorycorruptedchestconfirmbox
			};
		}

		// Token: 0x0602F314 RID: 193300 RVA: 0x0066D82E File Offset: 0x0066BA2E
		public IHonamiStoryEvacuateConfirmBoxT AsIHonamiStoryEvacuateConfirmBox()
		{
			return this.As<IHonamiStoryEvacuateConfirmBoxT>();
		}

		// Token: 0x0602F315 RID: 193301 RVA: 0x0066D836 File Offset: 0x0066BA36
		public static IInteractionConfirmBoxType_UnionUnion FromIHonamiStoryEvacuateConfirmBox(IHonamiStoryEvacuateConfirmBoxT _ihonamistoryevacuateconfirmbox)
		{
			return new IInteractionConfirmBoxType_UnionUnion
			{
				Type = IInteractionConfirmBoxType_Union.IHonamiStoryEvacuateConfirmBox,
				Value = _ihonamistoryevacuateconfirmbox
			};
		}

		// Token: 0x0602F316 RID: 193302 RVA: 0x0066D84C File Offset: 0x0066BA4C
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
