using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057B2 RID: 22450
	public class IFightMusicsSwitchType_UnionUnion
	{
		// Token: 0x1700A251 RID: 41553
		// (get) Token: 0x060243D9 RID: 148441 RVA: 0x004FB4D1 File Offset: 0x004F96D1
		// (set) Token: 0x060243DA RID: 148442 RVA: 0x004FB4D9 File Offset: 0x004F96D9
		public IFightMusicsSwitchType_Union Type { get; set; }

		// Token: 0x1700A252 RID: 41554
		// (get) Token: 0x060243DB RID: 148443 RVA: 0x004FB4E2 File Offset: 0x004F96E2
		// (set) Token: 0x060243DC RID: 148444 RVA: 0x004FB4EA File Offset: 0x004F96EA
		public object Value { get; set; }

		// Token: 0x060243DD RID: 148445 RVA: 0x004FB4F3 File Offset: 0x004F96F3
		public IFightMusicsSwitchType_UnionUnion()
		{
			this.Type = IFightMusicsSwitchType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060243DE RID: 148446 RVA: 0x004FB509 File Offset: 0x004F9709
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060243DF RID: 148447 RVA: 0x004FB51B File Offset: 0x004F971B
		public IFightMusicsSwitchTypeT AsIFightMusicsSwitchType()
		{
			return this.As<IFightMusicsSwitchTypeT>();
		}

		// Token: 0x060243E0 RID: 148448 RVA: 0x004FB523 File Offset: 0x004F9723
		public static IFightMusicsSwitchType_UnionUnion FromIFightMusicsSwitchType(IFightMusicsSwitchTypeT _ifightmusicsswitchtype)
		{
			return new IFightMusicsSwitchType_UnionUnion
			{
				Type = IFightMusicsSwitchType_Union.IFightMusicsSwitchType,
				Value = _ifightmusicsswitchtype
			};
		}

		// Token: 0x060243E1 RID: 148449 RVA: 0x004FB538 File Offset: 0x004F9738
		public IFightMusicsSwitchByTagListT AsIFightMusicsSwitchByTagList()
		{
			return this.As<IFightMusicsSwitchByTagListT>();
		}

		// Token: 0x060243E2 RID: 148450 RVA: 0x004FB540 File Offset: 0x004F9740
		public static IFightMusicsSwitchType_UnionUnion FromIFightMusicsSwitchByTagList(IFightMusicsSwitchByTagListT _ifightmusicsswitchbytaglist)
		{
			return new IFightMusicsSwitchType_UnionUnion
			{
				Type = IFightMusicsSwitchType_Union.IFightMusicsSwitchByTagList,
				Value = _ifightmusicsswitchbytaglist
			};
		}

		// Token: 0x060243E3 RID: 148451 RVA: 0x004FB558 File Offset: 0x004F9758
		public static int Pack(FlatBufferBuilder builder, IFightMusicsSwitchType_UnionUnion _o)
		{
			IFightMusicsSwitchType_Union type = _o.Type;
			if (type == IFightMusicsSwitchType_Union.IFightMusicsSwitchType)
			{
				return IFightMusicsSwitchType.Pack(builder, _o.AsIFightMusicsSwitchType()).Value;
			}
			if (type != IFightMusicsSwitchType_Union.IFightMusicsSwitchByTagList)
			{
				return 0;
			}
			return IFightMusicsSwitchByTagList.Pack(builder, _o.AsIFightMusicsSwitchByTagList()).Value;
		}
	}
}
