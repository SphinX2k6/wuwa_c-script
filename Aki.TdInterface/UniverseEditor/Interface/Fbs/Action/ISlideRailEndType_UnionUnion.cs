using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007918 RID: 31000
	public class ISlideRailEndType_UnionUnion
	{
		// Token: 0x1700E360 RID: 58208
		// (get) Token: 0x0603694E RID: 223566 RVA: 0x0074E279 File Offset: 0x0074C479
		// (set) Token: 0x0603694F RID: 223567 RVA: 0x0074E281 File Offset: 0x0074C481
		public ISlideRailEndType_Union Type { get; set; }

		// Token: 0x1700E361 RID: 58209
		// (get) Token: 0x06036950 RID: 223568 RVA: 0x0074E28A File Offset: 0x0074C48A
		// (set) Token: 0x06036951 RID: 223569 RVA: 0x0074E292 File Offset: 0x0074C492
		public object Value { get; set; }

		// Token: 0x06036952 RID: 223570 RVA: 0x0074E29B File Offset: 0x0074C49B
		public ISlideRailEndType_UnionUnion()
		{
			this.Type = ISlideRailEndType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06036953 RID: 223571 RVA: 0x0074E2B1 File Offset: 0x0074C4B1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06036954 RID: 223572 RVA: 0x0074E2C3 File Offset: 0x0074C4C3
		public ISlideRailEndTypeT AsISlideRailEndType()
		{
			return this.As<ISlideRailEndTypeT>();
		}

		// Token: 0x06036955 RID: 223573 RVA: 0x0074E2CB File Offset: 0x0074C4CB
		public static ISlideRailEndType_UnionUnion FromISlideRailEndType(ISlideRailEndTypeT _isliderailendtype)
		{
			return new ISlideRailEndType_UnionUnion
			{
				Type = ISlideRailEndType_Union.ISlideRailEndType,
				Value = _isliderailendtype
			};
		}

		// Token: 0x06036956 RID: 223574 RVA: 0x0074E2E0 File Offset: 0x0074C4E0
		public IPlayerSlideRailEndT AsIPlayerSlideRailEnd()
		{
			return this.As<IPlayerSlideRailEndT>();
		}

		// Token: 0x06036957 RID: 223575 RVA: 0x0074E2E8 File Offset: 0x0074C4E8
		public static ISlideRailEndType_UnionUnion FromIPlayerSlideRailEnd(IPlayerSlideRailEndT _iplayersliderailend)
		{
			return new ISlideRailEndType_UnionUnion
			{
				Type = ISlideRailEndType_Union.IPlayerSlideRailEnd,
				Value = _iplayersliderailend
			};
		}

		// Token: 0x06036958 RID: 223576 RVA: 0x0074E2FD File Offset: 0x0074C4FD
		public IAiFollowerSlideRailEndT AsIAiFollowerSlideRailEnd()
		{
			return this.As<IAiFollowerSlideRailEndT>();
		}

		// Token: 0x06036959 RID: 223577 RVA: 0x0074E305 File Offset: 0x0074C505
		public static ISlideRailEndType_UnionUnion FromIAiFollowerSlideRailEnd(IAiFollowerSlideRailEndT _iaifollowersliderailend)
		{
			return new ISlideRailEndType_UnionUnion
			{
				Type = ISlideRailEndType_Union.IAiFollowerSlideRailEnd,
				Value = _iaifollowersliderailend
			};
		}

		// Token: 0x0603695A RID: 223578 RVA: 0x0074E31C File Offset: 0x0074C51C
		public static int Pack(FlatBufferBuilder builder, ISlideRailEndType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISlideRailEndType_Union.ISlideRailEndType:
				return ISlideRailEndType.Pack(builder, _o.AsISlideRailEndType()).Value;
			case ISlideRailEndType_Union.IPlayerSlideRailEnd:
				return IPlayerSlideRailEnd.Pack(builder, _o.AsIPlayerSlideRailEnd()).Value;
			case ISlideRailEndType_Union.IAiFollowerSlideRailEnd:
				return IAiFollowerSlideRailEnd.Pack(builder, _o.AsIAiFollowerSlideRailEnd()).Value;
			default:
				return 0;
			}
		}
	}
}
