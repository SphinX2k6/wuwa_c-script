using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076FF RID: 30463
	public class TInteractOptionConfirmBoxOptionUnion
	{
		// Token: 0x1700E643 RID: 58947
		// (get) Token: 0x060375E0 RID: 226784 RVA: 0x0077FAC6 File Offset: 0x0077DCC6
		// (set) Token: 0x060375E1 RID: 226785 RVA: 0x0077FACE File Offset: 0x0077DCCE
		public TInteractOptionConfirmBoxOption Type { get; set; }

		// Token: 0x1700E644 RID: 58948
		// (get) Token: 0x060375E2 RID: 226786 RVA: 0x0077FAD7 File Offset: 0x0077DCD7
		// (set) Token: 0x060375E3 RID: 226787 RVA: 0x0077FADF File Offset: 0x0077DCDF
		public object Value { get; set; }

		// Token: 0x060375E4 RID: 226788 RVA: 0x0077FAE8 File Offset: 0x0077DCE8
		public TInteractOptionConfirmBoxOptionUnion()
		{
			this.Type = TInteractOptionConfirmBoxOption.NONE;
			this.Value = null;
		}

		// Token: 0x060375E5 RID: 226789 RVA: 0x0077FAFE File Offset: 0x0077DCFE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060375E6 RID: 226790 RVA: 0x0077FB10 File Offset: 0x0077DD10
		public ICommonConfirmBoxT AsICommonConfirmBox()
		{
			return this.As<ICommonConfirmBoxT>();
		}

		// Token: 0x060375E7 RID: 226791 RVA: 0x0077FB18 File Offset: 0x0077DD18
		public static TInteractOptionConfirmBoxOptionUnion FromICommonConfirmBox(ICommonConfirmBoxT _icommonconfirmbox)
		{
			return new TInteractOptionConfirmBoxOptionUnion
			{
				Type = TInteractOptionConfirmBoxOption.ICommonConfirmBox,
				Value = _icommonconfirmbox
			};
		}

		// Token: 0x060375E8 RID: 226792 RVA: 0x0077FB2D File Offset: 0x0077DD2D
		public IHonamiStoryCorruptedChestConfirmBoxT AsIHonamiStoryCorruptedChestConfirmBox()
		{
			return this.As<IHonamiStoryCorruptedChestConfirmBoxT>();
		}

		// Token: 0x060375E9 RID: 226793 RVA: 0x0077FB35 File Offset: 0x0077DD35
		public static TInteractOptionConfirmBoxOptionUnion FromIHonamiStoryCorruptedChestConfirmBox(IHonamiStoryCorruptedChestConfirmBoxT _ihonamistorycorruptedchestconfirmbox)
		{
			return new TInteractOptionConfirmBoxOptionUnion
			{
				Type = TInteractOptionConfirmBoxOption.IHonamiStoryCorruptedChestConfirmBox,
				Value = _ihonamistorycorruptedchestconfirmbox
			};
		}

		// Token: 0x060375EA RID: 226794 RVA: 0x0077FB4A File Offset: 0x0077DD4A
		public IHonamiStoryEvacuateConfirmBoxT AsIHonamiStoryEvacuateConfirmBox()
		{
			return this.As<IHonamiStoryEvacuateConfirmBoxT>();
		}

		// Token: 0x060375EB RID: 226795 RVA: 0x0077FB52 File Offset: 0x0077DD52
		public static TInteractOptionConfirmBoxOptionUnion FromIHonamiStoryEvacuateConfirmBox(IHonamiStoryEvacuateConfirmBoxT _ihonamistoryevacuateconfirmbox)
		{
			return new TInteractOptionConfirmBoxOptionUnion
			{
				Type = TInteractOptionConfirmBoxOption.IHonamiStoryEvacuateConfirmBox,
				Value = _ihonamistoryevacuateconfirmbox
			};
		}

		// Token: 0x060375EC RID: 226796 RVA: 0x0077FB68 File Offset: 0x0077DD68
		public static int Pack(FlatBufferBuilder builder, TInteractOptionConfirmBoxOptionUnion _o)
		{
			switch (_o.Type)
			{
			case TInteractOptionConfirmBoxOption.ICommonConfirmBox:
				return ICommonConfirmBox.Pack(builder, _o.AsICommonConfirmBox()).Value;
			case TInteractOptionConfirmBoxOption.IHonamiStoryCorruptedChestConfirmBox:
				return IHonamiStoryCorruptedChestConfirmBox.Pack(builder, _o.AsIHonamiStoryCorruptedChestConfirmBox()).Value;
			case TInteractOptionConfirmBoxOption.IHonamiStoryEvacuateConfirmBox:
				return IHonamiStoryEvacuateConfirmBox.Pack(builder, _o.AsIHonamiStoryEvacuateConfirmBox()).Value;
			default:
				return 0;
			}
		}
	}
}
