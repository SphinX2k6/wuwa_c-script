using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057A3 RID: 22435
	public class IFanInteractType_UnionUnion
	{
		// Token: 0x1700A235 RID: 41525
		// (get) Token: 0x0602435F RID: 148319 RVA: 0x004FA665 File Offset: 0x004F8865
		// (set) Token: 0x06024360 RID: 148320 RVA: 0x004FA66D File Offset: 0x004F886D
		public IFanInteractType_Union Type { get; set; }

		// Token: 0x1700A236 RID: 41526
		// (get) Token: 0x06024361 RID: 148321 RVA: 0x004FA676 File Offset: 0x004F8876
		// (set) Token: 0x06024362 RID: 148322 RVA: 0x004FA67E File Offset: 0x004F887E
		public object Value { get; set; }

		// Token: 0x06024363 RID: 148323 RVA: 0x004FA687 File Offset: 0x004F8887
		public IFanInteractType_UnionUnion()
		{
			this.Type = IFanInteractType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06024364 RID: 148324 RVA: 0x004FA69D File Offset: 0x004F889D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06024365 RID: 148325 RVA: 0x004FA6AF File Offset: 0x004F88AF
		public IFanInteractTypeT AsIFanInteractType()
		{
			return this.As<IFanInteractTypeT>();
		}

		// Token: 0x06024366 RID: 148326 RVA: 0x004FA6B7 File Offset: 0x004F88B7
		public static IFanInteractType_UnionUnion FromIFanInteractType(IFanInteractTypeT _ifaninteracttype)
		{
			return new IFanInteractType_UnionUnion
			{
				Type = IFanInteractType_Union.IFanInteractType,
				Value = _ifaninteracttype
			};
		}

		// Token: 0x06024367 RID: 148327 RVA: 0x004FA6CC File Offset: 0x004F88CC
		public IFanInteractByHitT AsIFanInteractByHit()
		{
			return this.As<IFanInteractByHitT>();
		}

		// Token: 0x06024368 RID: 148328 RVA: 0x004FA6D4 File Offset: 0x004F88D4
		public static IFanInteractType_UnionUnion FromIFanInteractByHit(IFanInteractByHitT _ifaninteractbyhit)
		{
			return new IFanInteractType_UnionUnion
			{
				Type = IFanInteractType_Union.IFanInteractByHit,
				Value = _ifaninteractbyhit
			};
		}

		// Token: 0x06024369 RID: 148329 RVA: 0x004FA6E9 File Offset: 0x004F88E9
		public IFanInteractByFKeyT AsIFanInteractByFKey()
		{
			return this.As<IFanInteractByFKeyT>();
		}

		// Token: 0x0602436A RID: 148330 RVA: 0x004FA6F1 File Offset: 0x004F88F1
		public static IFanInteractType_UnionUnion FromIFanInteractByFKey(IFanInteractByFKeyT _ifaninteractbyfkey)
		{
			return new IFanInteractType_UnionUnion
			{
				Type = IFanInteractType_Union.IFanInteractByFKey,
				Value = _ifaninteractbyfkey
			};
		}

		// Token: 0x0602436B RID: 148331 RVA: 0x004FA708 File Offset: 0x004F8908
		public static int Pack(FlatBufferBuilder builder, IFanInteractType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IFanInteractType_Union.IFanInteractType:
				return IFanInteractType.Pack(builder, _o.AsIFanInteractType()).Value;
			case IFanInteractType_Union.IFanInteractByHit:
				return IFanInteractByHit.Pack(builder, _o.AsIFanInteractByHit()).Value;
			case IFanInteractType_Union.IFanInteractByFKey:
				return IFanInteractByFKey.Pack(builder, _o.AsIFanInteractByFKey()).Value;
			default:
				return 0;
			}
		}
	}
}
