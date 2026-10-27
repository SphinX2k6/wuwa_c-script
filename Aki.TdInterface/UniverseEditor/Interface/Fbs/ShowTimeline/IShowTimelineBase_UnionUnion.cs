using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BAB RID: 15275
	public class IShowTimelineBase_UnionUnion
	{
		// Token: 0x170068B2 RID: 26802
		// (get) Token: 0x06014EFB RID: 85755 RVA: 0x0030959D File Offset: 0x0030779D
		// (set) Token: 0x06014EFC RID: 85756 RVA: 0x003095A5 File Offset: 0x003077A5
		public IShowTimelineBase_Union Type { get; set; }

		// Token: 0x170068B3 RID: 26803
		// (get) Token: 0x06014EFD RID: 85757 RVA: 0x003095AE File Offset: 0x003077AE
		// (set) Token: 0x06014EFE RID: 85758 RVA: 0x003095B6 File Offset: 0x003077B6
		public object Value { get; set; }

		// Token: 0x06014EFF RID: 85759 RVA: 0x003095BF File Offset: 0x003077BF
		public IShowTimelineBase_UnionUnion()
		{
			this.Type = IShowTimelineBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06014F00 RID: 85760 RVA: 0x003095D5 File Offset: 0x003077D5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06014F01 RID: 85761 RVA: 0x003095E7 File Offset: 0x003077E7
		public IShowTimelineBaseT AsIShowTimelineBase()
		{
			return this.As<IShowTimelineBaseT>();
		}

		// Token: 0x06014F02 RID: 85762 RVA: 0x003095EF File Offset: 0x003077EF
		public static IShowTimelineBase_UnionUnion FromIShowTimelineBase(IShowTimelineBaseT _ishowtimelinebase)
		{
			return new IShowTimelineBase_UnionUnion
			{
				Type = IShowTimelineBase_Union.IShowTimelineBase,
				Value = _ishowtimelinebase
			};
		}

		// Token: 0x06014F03 RID: 85763 RVA: 0x00309604 File Offset: 0x00307804
		public IShowTimelineCheckpointT AsIShowTimelineCheckpoint()
		{
			return this.As<IShowTimelineCheckpointT>();
		}

		// Token: 0x06014F04 RID: 85764 RVA: 0x0030960C File Offset: 0x0030780C
		public static IShowTimelineBase_UnionUnion FromIShowTimelineCheckpoint(IShowTimelineCheckpointT _ishowtimelinecheckpoint)
		{
			return new IShowTimelineBase_UnionUnion
			{
				Type = IShowTimelineBase_Union.IShowTimelineCheckpoint,
				Value = _ishowtimelinecheckpoint
			};
		}

		// Token: 0x06014F05 RID: 85765 RVA: 0x00309621 File Offset: 0x00307821
		public IShowTimelineInputT AsIShowTimelineInput()
		{
			return this.As<IShowTimelineInputT>();
		}

		// Token: 0x06014F06 RID: 85766 RVA: 0x00309629 File Offset: 0x00307829
		public static IShowTimelineBase_UnionUnion FromIShowTimelineInput(IShowTimelineInputT _ishowtimelineinput)
		{
			return new IShowTimelineBase_UnionUnion
			{
				Type = IShowTimelineBase_Union.IShowTimelineInput,
				Value = _ishowtimelineinput
			};
		}

		// Token: 0x06014F07 RID: 85767 RVA: 0x0030963E File Offset: 0x0030783E
		public IShowTimelineActionT AsIShowTimelineAction()
		{
			return this.As<IShowTimelineActionT>();
		}

		// Token: 0x06014F08 RID: 85768 RVA: 0x00309646 File Offset: 0x00307846
		public static IShowTimelineBase_UnionUnion FromIShowTimelineAction(IShowTimelineActionT _ishowtimelineaction)
		{
			return new IShowTimelineBase_UnionUnion
			{
				Type = IShowTimelineBase_Union.IShowTimelineAction,
				Value = _ishowtimelineaction
			};
		}

		// Token: 0x06014F09 RID: 85769 RVA: 0x0030965B File Offset: 0x0030785B
		public IShowTimelineBuffT AsIShowTimelineBuff()
		{
			return this.As<IShowTimelineBuffT>();
		}

		// Token: 0x06014F0A RID: 85770 RVA: 0x00309663 File Offset: 0x00307863
		public static IShowTimelineBase_UnionUnion FromIShowTimelineBuff(IShowTimelineBuffT _ishowtimelinebuff)
		{
			return new IShowTimelineBase_UnionUnion
			{
				Type = IShowTimelineBase_Union.IShowTimelineBuff,
				Value = _ishowtimelinebuff
			};
		}

		// Token: 0x06014F0B RID: 85771 RVA: 0x00309678 File Offset: 0x00307878
		public IShowTimelineGuideT AsIShowTimelineGuide()
		{
			return this.As<IShowTimelineGuideT>();
		}

		// Token: 0x06014F0C RID: 85772 RVA: 0x00309680 File Offset: 0x00307880
		public static IShowTimelineBase_UnionUnion FromIShowTimelineGuide(IShowTimelineGuideT _ishowtimelineguide)
		{
			return new IShowTimelineBase_UnionUnion
			{
				Type = IShowTimelineBase_Union.IShowTimelineGuide,
				Value = _ishowtimelineguide
			};
		}

		// Token: 0x06014F0D RID: 85773 RVA: 0x00309698 File Offset: 0x00307898
		public static int Pack(FlatBufferBuilder builder, IShowTimelineBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IShowTimelineBase_Union.IShowTimelineBase:
				return IShowTimelineBase.Pack(builder, _o.AsIShowTimelineBase()).Value;
			case IShowTimelineBase_Union.IShowTimelineCheckpoint:
				return IShowTimelineCheckpoint.Pack(builder, _o.AsIShowTimelineCheckpoint()).Value;
			case IShowTimelineBase_Union.IShowTimelineInput:
				return IShowTimelineInput.Pack(builder, _o.AsIShowTimelineInput()).Value;
			case IShowTimelineBase_Union.IShowTimelineAction:
				return IShowTimelineAction.Pack(builder, _o.AsIShowTimelineAction()).Value;
			case IShowTimelineBase_Union.IShowTimelineBuff:
				return IShowTimelineBuff.Pack(builder, _o.AsIShowTimelineBuff()).Value;
			case IShowTimelineBase_Union.IShowTimelineGuide:
				return IShowTimelineGuide.Pack(builder, _o.AsIShowTimelineGuide()).Value;
			default:
				return 0;
			}
		}
	}
}
