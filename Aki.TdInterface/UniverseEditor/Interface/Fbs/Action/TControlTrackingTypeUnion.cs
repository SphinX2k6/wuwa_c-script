using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EA1 RID: 32417
	public class TControlTrackingTypeUnion
	{
		// Token: 0x1700F233 RID: 62003
		// (get) Token: 0x0603A86F RID: 239727 RVA: 0x007E0742 File Offset: 0x007DE942
		// (set) Token: 0x0603A870 RID: 239728 RVA: 0x007E074A File Offset: 0x007DE94A
		public TControlTrackingType Type { get; set; }

		// Token: 0x1700F234 RID: 62004
		// (get) Token: 0x0603A871 RID: 239729 RVA: 0x007E0753 File Offset: 0x007DE953
		// (set) Token: 0x0603A872 RID: 239730 RVA: 0x007E075B File Offset: 0x007DE95B
		public object Value { get; set; }

		// Token: 0x0603A873 RID: 239731 RVA: 0x007E0764 File Offset: 0x007DE964
		public TControlTrackingTypeUnion()
		{
			this.Type = TControlTrackingType.NONE;
			this.Value = null;
		}

		// Token: 0x0603A874 RID: 239732 RVA: 0x007E077A File Offset: 0x007DE97A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A875 RID: 239733 RVA: 0x007E078C File Offset: 0x007DE98C
		public IControlTrackingOtherT AsIControlTrackingOther()
		{
			return this.As<IControlTrackingOtherT>();
		}

		// Token: 0x0603A876 RID: 239734 RVA: 0x007E0794 File Offset: 0x007DE994
		public static TControlTrackingTypeUnion FromIControlTrackingOther(IControlTrackingOtherT _icontroltrackingother)
		{
			return new TControlTrackingTypeUnion
			{
				Type = TControlTrackingType.IControlTrackingOther,
				Value = _icontroltrackingother
			};
		}

		// Token: 0x0603A877 RID: 239735 RVA: 0x007E07A9 File Offset: 0x007DE9A9
		public IControlTrackingSelfT AsIControlTrackingSelf()
		{
			return this.As<IControlTrackingSelfT>();
		}

		// Token: 0x0603A878 RID: 239736 RVA: 0x007E07B1 File Offset: 0x007DE9B1
		public static TControlTrackingTypeUnion FromIControlTrackingSelf(IControlTrackingSelfT _icontroltrackingself)
		{
			return new TControlTrackingTypeUnion
			{
				Type = TControlTrackingType.IControlTrackingSelf,
				Value = _icontroltrackingself
			};
		}

		// Token: 0x0603A879 RID: 239737 RVA: 0x007E07C8 File Offset: 0x007DE9C8
		public static int Pack(FlatBufferBuilder builder, TControlTrackingTypeUnion _o)
		{
			TControlTrackingType type = _o.Type;
			if (type == TControlTrackingType.IControlTrackingOther)
			{
				return IControlTrackingOther.Pack(builder, _o.AsIControlTrackingOther()).Value;
			}
			if (type != TControlTrackingType.IControlTrackingSelf)
			{
				return 0;
			}
			return IControlTrackingSelf.Pack(builder, _o.AsIControlTrackingSelf()).Value;
		}
	}
}
