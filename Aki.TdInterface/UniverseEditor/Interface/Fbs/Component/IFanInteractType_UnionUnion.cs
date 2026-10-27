using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200523B RID: 21051
	public class IFanInteractType_UnionUnion
	{
		// Token: 0x17009A39 RID: 39481
		// (get) Token: 0x060223C9 RID: 140233 RVA: 0x004BFBA1 File Offset: 0x004BDDA1
		// (set) Token: 0x060223CA RID: 140234 RVA: 0x004BFBA9 File Offset: 0x004BDDA9
		public IFanInteractType_Union Type { get; set; }

		// Token: 0x17009A3A RID: 39482
		// (get) Token: 0x060223CB RID: 140235 RVA: 0x004BFBB2 File Offset: 0x004BDDB2
		// (set) Token: 0x060223CC RID: 140236 RVA: 0x004BFBBA File Offset: 0x004BDDBA
		public object Value { get; set; }

		// Token: 0x060223CD RID: 140237 RVA: 0x004BFBC3 File Offset: 0x004BDDC3
		public IFanInteractType_UnionUnion()
		{
			this.Type = IFanInteractType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060223CE RID: 140238 RVA: 0x004BFBD9 File Offset: 0x004BDDD9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060223CF RID: 140239 RVA: 0x004BFBEB File Offset: 0x004BDDEB
		public IFanInteractTypeT AsIFanInteractType()
		{
			return this.As<IFanInteractTypeT>();
		}

		// Token: 0x060223D0 RID: 140240 RVA: 0x004BFBF3 File Offset: 0x004BDDF3
		public static IFanInteractType_UnionUnion FromIFanInteractType(IFanInteractTypeT _ifaninteracttype)
		{
			return new IFanInteractType_UnionUnion
			{
				Type = IFanInteractType_Union.IFanInteractType,
				Value = _ifaninteracttype
			};
		}

		// Token: 0x060223D1 RID: 140241 RVA: 0x004BFC08 File Offset: 0x004BDE08
		public IFanInteractByHitT AsIFanInteractByHit()
		{
			return this.As<IFanInteractByHitT>();
		}

		// Token: 0x060223D2 RID: 140242 RVA: 0x004BFC10 File Offset: 0x004BDE10
		public static IFanInteractType_UnionUnion FromIFanInteractByHit(IFanInteractByHitT _ifaninteractbyhit)
		{
			return new IFanInteractType_UnionUnion
			{
				Type = IFanInteractType_Union.IFanInteractByHit,
				Value = _ifaninteractbyhit
			};
		}

		// Token: 0x060223D3 RID: 140243 RVA: 0x004BFC25 File Offset: 0x004BDE25
		public IFanInteractByFKeyT AsIFanInteractByFKey()
		{
			return this.As<IFanInteractByFKeyT>();
		}

		// Token: 0x060223D4 RID: 140244 RVA: 0x004BFC2D File Offset: 0x004BDE2D
		public static IFanInteractType_UnionUnion FromIFanInteractByFKey(IFanInteractByFKeyT _ifaninteractbyfkey)
		{
			return new IFanInteractType_UnionUnion
			{
				Type = IFanInteractType_Union.IFanInteractByFKey,
				Value = _ifaninteractbyfkey
			};
		}

		// Token: 0x060223D5 RID: 140245 RVA: 0x004BFC44 File Offset: 0x004BDE44
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
