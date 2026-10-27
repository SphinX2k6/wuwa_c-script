using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007404 RID: 29700
	public class IToggleDragActorPlayType_UnionUnion
	{
		// Token: 0x1700E196 RID: 57750
		// (get) Token: 0x06035F4D RID: 221005 RVA: 0x007578D9 File Offset: 0x00755AD9
		// (set) Token: 0x06035F4E RID: 221006 RVA: 0x007578E1 File Offset: 0x00755AE1
		public IToggleDragActorPlayType_Union Type { get; set; }

		// Token: 0x1700E197 RID: 57751
		// (get) Token: 0x06035F4F RID: 221007 RVA: 0x007578EA File Offset: 0x00755AEA
		// (set) Token: 0x06035F50 RID: 221008 RVA: 0x007578F2 File Offset: 0x00755AF2
		public object Value { get; set; }

		// Token: 0x06035F51 RID: 221009 RVA: 0x007578FB File Offset: 0x00755AFB
		public IToggleDragActorPlayType_UnionUnion()
		{
			this.Type = IToggleDragActorPlayType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06035F52 RID: 221010 RVA: 0x00757911 File Offset: 0x00755B11
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06035F53 RID: 221011 RVA: 0x00757923 File Offset: 0x00755B23
		public IToggleDragActorPlayTypeT AsIToggleDragActorPlayType()
		{
			return this.As<IToggleDragActorPlayTypeT>();
		}

		// Token: 0x06035F54 RID: 221012 RVA: 0x0075792B File Offset: 0x00755B2B
		public static IToggleDragActorPlayType_UnionUnion FromIToggleDragActorPlayType(IToggleDragActorPlayTypeT _itoggledragactorplaytype)
		{
			return new IToggleDragActorPlayType_UnionUnion
			{
				Type = IToggleDragActorPlayType_Union.IToggleDragActorPlayType,
				Value = _itoggledragactorplaytype
			};
		}

		// Token: 0x06035F55 RID: 221013 RVA: 0x00757940 File Offset: 0x00755B40
		public IToggleDragActorPlayEnableT AsIToggleDragActorPlayEnable()
		{
			return this.As<IToggleDragActorPlayEnableT>();
		}

		// Token: 0x06035F56 RID: 221014 RVA: 0x00757948 File Offset: 0x00755B48
		public static IToggleDragActorPlayType_UnionUnion FromIToggleDragActorPlayEnable(IToggleDragActorPlayEnableT _itoggledragactorplayenable)
		{
			return new IToggleDragActorPlayType_UnionUnion
			{
				Type = IToggleDragActorPlayType_Union.IToggleDragActorPlayEnable,
				Value = _itoggledragactorplayenable
			};
		}

		// Token: 0x06035F57 RID: 221015 RVA: 0x0075795D File Offset: 0x00755B5D
		public IToggleDragActorPlayDisableT AsIToggleDragActorPlayDisable()
		{
			return this.As<IToggleDragActorPlayDisableT>();
		}

		// Token: 0x06035F58 RID: 221016 RVA: 0x00757965 File Offset: 0x00755B65
		public static IToggleDragActorPlayType_UnionUnion FromIToggleDragActorPlayDisable(IToggleDragActorPlayDisableT _itoggledragactorplaydisable)
		{
			return new IToggleDragActorPlayType_UnionUnion
			{
				Type = IToggleDragActorPlayType_Union.IToggleDragActorPlayDisable,
				Value = _itoggledragactorplaydisable
			};
		}

		// Token: 0x06035F59 RID: 221017 RVA: 0x0075797C File Offset: 0x00755B7C
		public static int Pack(FlatBufferBuilder builder, IToggleDragActorPlayType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IToggleDragActorPlayType_Union.IToggleDragActorPlayType:
				return IToggleDragActorPlayType.Pack(builder, _o.AsIToggleDragActorPlayType()).Value;
			case IToggleDragActorPlayType_Union.IToggleDragActorPlayEnable:
				return IToggleDragActorPlayEnable.Pack(builder, _o.AsIToggleDragActorPlayEnable()).Value;
			case IToggleDragActorPlayType_Union.IToggleDragActorPlayDisable:
				return IToggleDragActorPlayDisable.Pack(builder, _o.AsIToggleDragActorPlayDisable()).Value;
			default:
				return 0;
			}
		}
	}
}
