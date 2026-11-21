using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BEE RID: 31726
	public class IToggleDragActorPlayType_UnionUnion
	{
		// Token: 0x1700EDAB RID: 60843
		// (get) Token: 0x06039300 RID: 234240 RVA: 0x007BA04D File Offset: 0x007B824D
		// (set) Token: 0x06039301 RID: 234241 RVA: 0x007BA055 File Offset: 0x007B8255
		public IToggleDragActorPlayType_Union Type { get; set; }

		// Token: 0x1700EDAC RID: 60844
		// (get) Token: 0x06039302 RID: 234242 RVA: 0x007BA05E File Offset: 0x007B825E
		// (set) Token: 0x06039303 RID: 234243 RVA: 0x007BA066 File Offset: 0x007B8266
		public object Value { get; set; }

		// Token: 0x06039304 RID: 234244 RVA: 0x007BA06F File Offset: 0x007B826F
		public IToggleDragActorPlayType_UnionUnion()
		{
			this.Type = IToggleDragActorPlayType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06039305 RID: 234245 RVA: 0x007BA085 File Offset: 0x007B8285
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06039306 RID: 234246 RVA: 0x007BA097 File Offset: 0x007B8297
		public IToggleDragActorPlayTypeT AsIToggleDragActorPlayType()
		{
			return this.As<IToggleDragActorPlayTypeT>();
		}

		// Token: 0x06039307 RID: 234247 RVA: 0x007BA09F File Offset: 0x007B829F
		public static IToggleDragActorPlayType_UnionUnion FromIToggleDragActorPlayType(IToggleDragActorPlayTypeT _itoggledragactorplaytype)
		{
			return new IToggleDragActorPlayType_UnionUnion
			{
				Type = IToggleDragActorPlayType_Union.IToggleDragActorPlayType,
				Value = _itoggledragactorplaytype
			};
		}

		// Token: 0x06039308 RID: 234248 RVA: 0x007BA0B4 File Offset: 0x007B82B4
		public IToggleDragActorPlayEnableT AsIToggleDragActorPlayEnable()
		{
			return this.As<IToggleDragActorPlayEnableT>();
		}

		// Token: 0x06039309 RID: 234249 RVA: 0x007BA0BC File Offset: 0x007B82BC
		public static IToggleDragActorPlayType_UnionUnion FromIToggleDragActorPlayEnable(IToggleDragActorPlayEnableT _itoggledragactorplayenable)
		{
			return new IToggleDragActorPlayType_UnionUnion
			{
				Type = IToggleDragActorPlayType_Union.IToggleDragActorPlayEnable,
				Value = _itoggledragactorplayenable
			};
		}

		// Token: 0x0603930A RID: 234250 RVA: 0x007BA0D1 File Offset: 0x007B82D1
		public IToggleDragActorPlayDisableT AsIToggleDragActorPlayDisable()
		{
			return this.As<IToggleDragActorPlayDisableT>();
		}

		// Token: 0x0603930B RID: 234251 RVA: 0x007BA0D9 File Offset: 0x007B82D9
		public static IToggleDragActorPlayType_UnionUnion FromIToggleDragActorPlayDisable(IToggleDragActorPlayDisableT _itoggledragactorplaydisable)
		{
			return new IToggleDragActorPlayType_UnionUnion
			{
				Type = IToggleDragActorPlayType_Union.IToggleDragActorPlayDisable,
				Value = _itoggledragactorplaydisable
			};
		}

		// Token: 0x0603930C RID: 234252 RVA: 0x007BA0F0 File Offset: 0x007B82F0
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
