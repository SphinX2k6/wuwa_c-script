using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007059 RID: 28761
	public class IInteractPointInteraction_UnionUnion
	{
		// Token: 0x1700D2A8 RID: 53928
		// (get) Token: 0x06031DE9 RID: 204265 RVA: 0x006C0391 File Offset: 0x006BE591
		// (set) Token: 0x06031DEA RID: 204266 RVA: 0x006C0399 File Offset: 0x006BE599
		public IInteractPointInteraction_Union Type { get; set; }

		// Token: 0x1700D2A9 RID: 53929
		// (get) Token: 0x06031DEB RID: 204267 RVA: 0x006C03A2 File Offset: 0x006BE5A2
		// (set) Token: 0x06031DEC RID: 204268 RVA: 0x006C03AA File Offset: 0x006BE5AA
		public object Value { get; set; }

		// Token: 0x06031DED RID: 204269 RVA: 0x006C03B3 File Offset: 0x006BE5B3
		public IInteractPointInteraction_UnionUnion()
		{
			this.Type = IInteractPointInteraction_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06031DEE RID: 204270 RVA: 0x006C03C9 File Offset: 0x006BE5C9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06031DEF RID: 204271 RVA: 0x006C03DB File Offset: 0x006BE5DB
		public IInteractPointInteractionT AsIInteractPointInteraction()
		{
			return this.As<IInteractPointInteractionT>();
		}

		// Token: 0x06031DF0 RID: 204272 RVA: 0x006C03E3 File Offset: 0x006BE5E3
		public static IInteractPointInteraction_UnionUnion FromIInteractPointInteraction(IInteractPointInteractionT _iinteractpointinteraction)
		{
			return new IInteractPointInteraction_UnionUnion
			{
				Type = IInteractPointInteraction_Union.IInteractPointInteraction,
				Value = _iinteractpointinteraction
			};
		}

		// Token: 0x06031DF1 RID: 204273 RVA: 0x006C03F8 File Offset: 0x006BE5F8
		public IDragInteractPointInteractionT AsIDragInteractPointInteraction()
		{
			return this.As<IDragInteractPointInteractionT>();
		}

		// Token: 0x06031DF2 RID: 204274 RVA: 0x006C0400 File Offset: 0x006BE600
		public static IInteractPointInteraction_UnionUnion FromIDragInteractPointInteraction(IDragInteractPointInteractionT _idraginteractpointinteraction)
		{
			return new IInteractPointInteraction_UnionUnion
			{
				Type = IInteractPointInteraction_Union.IDragInteractPointInteraction,
				Value = _idraginteractpointinteraction
			};
		}

		// Token: 0x06031DF3 RID: 204275 RVA: 0x006C0418 File Offset: 0x006BE618
		public static int Pack(FlatBufferBuilder builder, IInteractPointInteraction_UnionUnion _o)
		{
			IInteractPointInteraction_Union type = _o.Type;
			if (type == IInteractPointInteraction_Union.IInteractPointInteraction)
			{
				return IInteractPointInteraction.Pack(builder, _o.AsIInteractPointInteraction()).Value;
			}
			if (type != IInteractPointInteraction_Union.IDragInteractPointInteraction)
			{
				return 0;
			}
			return IDragInteractPointInteraction.Pack(builder, _o.AsIDragInteractPointInteraction()).Value;
		}
	}
}
