using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200524A RID: 21066
	public class IFightMusicsSwitchType_UnionUnion
	{
		// Token: 0x17009A55 RID: 39509
		// (get) Token: 0x06022443 RID: 140355 RVA: 0x004C0A0D File Offset: 0x004BEC0D
		// (set) Token: 0x06022444 RID: 140356 RVA: 0x004C0A15 File Offset: 0x004BEC15
		public IFightMusicsSwitchType_Union Type { get; set; }

		// Token: 0x17009A56 RID: 39510
		// (get) Token: 0x06022445 RID: 140357 RVA: 0x004C0A1E File Offset: 0x004BEC1E
		// (set) Token: 0x06022446 RID: 140358 RVA: 0x004C0A26 File Offset: 0x004BEC26
		public object Value { get; set; }

		// Token: 0x06022447 RID: 140359 RVA: 0x004C0A2F File Offset: 0x004BEC2F
		public IFightMusicsSwitchType_UnionUnion()
		{
			this.Type = IFightMusicsSwitchType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06022448 RID: 140360 RVA: 0x004C0A45 File Offset: 0x004BEC45
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06022449 RID: 140361 RVA: 0x004C0A57 File Offset: 0x004BEC57
		public IFightMusicsSwitchTypeT AsIFightMusicsSwitchType()
		{
			return this.As<IFightMusicsSwitchTypeT>();
		}

		// Token: 0x0602244A RID: 140362 RVA: 0x004C0A5F File Offset: 0x004BEC5F
		public static IFightMusicsSwitchType_UnionUnion FromIFightMusicsSwitchType(IFightMusicsSwitchTypeT _ifightmusicsswitchtype)
		{
			return new IFightMusicsSwitchType_UnionUnion
			{
				Type = IFightMusicsSwitchType_Union.IFightMusicsSwitchType,
				Value = _ifightmusicsswitchtype
			};
		}

		// Token: 0x0602244B RID: 140363 RVA: 0x004C0A74 File Offset: 0x004BEC74
		public IFightMusicsSwitchByTagListT AsIFightMusicsSwitchByTagList()
		{
			return this.As<IFightMusicsSwitchByTagListT>();
		}

		// Token: 0x0602244C RID: 140364 RVA: 0x004C0A7C File Offset: 0x004BEC7C
		public static IFightMusicsSwitchType_UnionUnion FromIFightMusicsSwitchByTagList(IFightMusicsSwitchByTagListT _ifightmusicsswitchbytaglist)
		{
			return new IFightMusicsSwitchType_UnionUnion
			{
				Type = IFightMusicsSwitchType_Union.IFightMusicsSwitchByTagList,
				Value = _ifightmusicsswitchbytaglist
			};
		}

		// Token: 0x0602244D RID: 140365 RVA: 0x004C0A94 File Offset: 0x004BEC94
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
