using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FB3 RID: 16307
	public class IShowTimelineBase_UnionUnion
	{
		// Token: 0x17006E51 RID: 28241
		// (get) Token: 0x060163C5 RID: 91077 RVA: 0x0032FB35 File Offset: 0x0032DD35
		// (set) Token: 0x060163C6 RID: 91078 RVA: 0x0032FB3D File Offset: 0x0032DD3D
		public IShowTimelineBase_Union Type { get; set; }

		// Token: 0x17006E52 RID: 28242
		// (get) Token: 0x060163C7 RID: 91079 RVA: 0x0032FB46 File Offset: 0x0032DD46
		// (set) Token: 0x060163C8 RID: 91080 RVA: 0x0032FB4E File Offset: 0x0032DD4E
		public object Value { get; set; }

		// Token: 0x060163C9 RID: 91081 RVA: 0x0032FB57 File Offset: 0x0032DD57
		public IShowTimelineBase_UnionUnion()
		{
			this.Type = IShowTimelineBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060163CA RID: 91082 RVA: 0x0032FB6D File Offset: 0x0032DD6D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060163CB RID: 91083 RVA: 0x0032FB7F File Offset: 0x0032DD7F
		public IShowTimelineBaseT AsIShowTimelineBase()
		{
			return this.As<IShowTimelineBaseT>();
		}

		// Token: 0x060163CC RID: 91084 RVA: 0x0032FB87 File Offset: 0x0032DD87
		public static IShowTimelineBase_UnionUnion FromIShowTimelineBase(IShowTimelineBaseT _ishowtimelinebase)
		{
			return new IShowTimelineBase_UnionUnion
			{
				Type = IShowTimelineBase_Union.IShowTimelineBase,
				Value = _ishowtimelinebase
			};
		}

		// Token: 0x060163CD RID: 91085 RVA: 0x0032FB9C File Offset: 0x0032DD9C
		public IShowTimelineCheckpointT AsIShowTimelineCheckpoint()
		{
			return this.As<IShowTimelineCheckpointT>();
		}

		// Token: 0x060163CE RID: 91086 RVA: 0x0032FBA4 File Offset: 0x0032DDA4
		public static IShowTimelineBase_UnionUnion FromIShowTimelineCheckpoint(IShowTimelineCheckpointT _ishowtimelinecheckpoint)
		{
			return new IShowTimelineBase_UnionUnion
			{
				Type = IShowTimelineBase_Union.IShowTimelineCheckpoint,
				Value = _ishowtimelinecheckpoint
			};
		}

		// Token: 0x060163CF RID: 91087 RVA: 0x0032FBB9 File Offset: 0x0032DDB9
		public IShowTimelineInputT AsIShowTimelineInput()
		{
			return this.As<IShowTimelineInputT>();
		}

		// Token: 0x060163D0 RID: 91088 RVA: 0x0032FBC1 File Offset: 0x0032DDC1
		public static IShowTimelineBase_UnionUnion FromIShowTimelineInput(IShowTimelineInputT _ishowtimelineinput)
		{
			return new IShowTimelineBase_UnionUnion
			{
				Type = IShowTimelineBase_Union.IShowTimelineInput,
				Value = _ishowtimelineinput
			};
		}

		// Token: 0x060163D1 RID: 91089 RVA: 0x0032FBD6 File Offset: 0x0032DDD6
		public IShowTimelineActionT AsIShowTimelineAction()
		{
			return this.As<IShowTimelineActionT>();
		}

		// Token: 0x060163D2 RID: 91090 RVA: 0x0032FBDE File Offset: 0x0032DDDE
		public static IShowTimelineBase_UnionUnion FromIShowTimelineAction(IShowTimelineActionT _ishowtimelineaction)
		{
			return new IShowTimelineBase_UnionUnion
			{
				Type = IShowTimelineBase_Union.IShowTimelineAction,
				Value = _ishowtimelineaction
			};
		}

		// Token: 0x060163D3 RID: 91091 RVA: 0x0032FBF3 File Offset: 0x0032DDF3
		public IShowTimelineBuffT AsIShowTimelineBuff()
		{
			return this.As<IShowTimelineBuffT>();
		}

		// Token: 0x060163D4 RID: 91092 RVA: 0x0032FBFB File Offset: 0x0032DDFB
		public static IShowTimelineBase_UnionUnion FromIShowTimelineBuff(IShowTimelineBuffT _ishowtimelinebuff)
		{
			return new IShowTimelineBase_UnionUnion
			{
				Type = IShowTimelineBase_Union.IShowTimelineBuff,
				Value = _ishowtimelinebuff
			};
		}

		// Token: 0x060163D5 RID: 91093 RVA: 0x0032FC10 File Offset: 0x0032DE10
		public IShowTimelineGuideT AsIShowTimelineGuide()
		{
			return this.As<IShowTimelineGuideT>();
		}

		// Token: 0x060163D6 RID: 91094 RVA: 0x0032FC18 File Offset: 0x0032DE18
		public static IShowTimelineBase_UnionUnion FromIShowTimelineGuide(IShowTimelineGuideT _ishowtimelineguide)
		{
			return new IShowTimelineBase_UnionUnion
			{
				Type = IShowTimelineBase_Union.IShowTimelineGuide,
				Value = _ishowtimelineguide
			};
		}

		// Token: 0x060163D7 RID: 91095 RVA: 0x0032FC30 File Offset: 0x0032DE30
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
