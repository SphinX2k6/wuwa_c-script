using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007705 RID: 30469
	public class TLevelSequenceTransitionUnion
	{
		// Token: 0x1700E647 RID: 58951
		// (get) Token: 0x06037662 RID: 226914 RVA: 0x00780AFC File Offset: 0x0077ECFC
		// (set) Token: 0x06037663 RID: 226915 RVA: 0x00780B04 File Offset: 0x0077ED04
		public TLevelSequenceTransition Type { get; set; }

		// Token: 0x1700E648 RID: 58952
		// (get) Token: 0x06037664 RID: 226916 RVA: 0x00780B0D File Offset: 0x0077ED0D
		// (set) Token: 0x06037665 RID: 226917 RVA: 0x00780B15 File Offset: 0x0077ED15
		public object Value { get; set; }

		// Token: 0x06037666 RID: 226918 RVA: 0x00780B1E File Offset: 0x0077ED1E
		public TLevelSequenceTransitionUnion()
		{
			this.Type = TLevelSequenceTransition.NONE;
			this.Value = null;
		}

		// Token: 0x06037667 RID: 226919 RVA: 0x00780B34 File Offset: 0x0077ED34
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037668 RID: 226920 RVA: 0x00780B46 File Offset: 0x0077ED46
		public ICameraTransitionT AsICameraTransition()
		{
			return this.As<ICameraTransitionT>();
		}

		// Token: 0x06037669 RID: 226921 RVA: 0x00780B4E File Offset: 0x0077ED4E
		public static TLevelSequenceTransitionUnion FromICameraTransition(ICameraTransitionT _icameratransition)
		{
			return new TLevelSequenceTransitionUnion
			{
				Type = TLevelSequenceTransition.ICameraTransition,
				Value = _icameratransition
			};
		}

		// Token: 0x0603766A RID: 226922 RVA: 0x00780B63 File Offset: 0x0077ED63
		public IMaskTransitionT AsIMaskTransition()
		{
			return this.As<IMaskTransitionT>();
		}

		// Token: 0x0603766B RID: 226923 RVA: 0x00780B6B File Offset: 0x0077ED6B
		public static TLevelSequenceTransitionUnion FromIMaskTransition(IMaskTransitionT _imasktransition)
		{
			return new TLevelSequenceTransitionUnion
			{
				Type = TLevelSequenceTransition.IMaskTransition,
				Value = _imasktransition
			};
		}

		// Token: 0x0603766C RID: 226924 RVA: 0x00780B80 File Offset: 0x0077ED80
		public static int Pack(FlatBufferBuilder builder, TLevelSequenceTransitionUnion _o)
		{
			TLevelSequenceTransition type = _o.Type;
			if (type == TLevelSequenceTransition.ICameraTransition)
			{
				return ICameraTransition.Pack(builder, _o.AsICameraTransition()).Value;
			}
			if (type != TLevelSequenceTransition.IMaskTransition)
			{
				return 0;
			}
			return IMaskTransition.Pack(builder, _o.AsIMaskTransition()).Value;
		}
	}
}
