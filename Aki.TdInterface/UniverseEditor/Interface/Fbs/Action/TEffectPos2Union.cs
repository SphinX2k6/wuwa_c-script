using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076AE RID: 30382
	public class TEffectPos2Union
	{
		// Token: 0x1700E60D RID: 58893
		// (get) Token: 0x06037452 RID: 226386 RVA: 0x0077D5F6 File Offset: 0x0077B7F6
		// (set) Token: 0x06037453 RID: 226387 RVA: 0x0077D5FE File Offset: 0x0077B7FE
		public TEffectPos2 Type { get; set; }

		// Token: 0x1700E60E RID: 58894
		// (get) Token: 0x06037454 RID: 226388 RVA: 0x0077D607 File Offset: 0x0077B807
		// (set) Token: 0x06037455 RID: 226389 RVA: 0x0077D60F File Offset: 0x0077B80F
		public object Value { get; set; }

		// Token: 0x06037456 RID: 226390 RVA: 0x0077D618 File Offset: 0x0077B818
		public TEffectPos2Union()
		{
			this.Type = TEffectPos2.NONE;
			this.Value = null;
		}

		// Token: 0x06037457 RID: 226391 RVA: 0x0077D62E File Offset: 0x0077B82E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037458 RID: 226392 RVA: 0x0077D640 File Offset: 0x0077B840
		public IAbsolutePos2T AsIAbsolutePos2()
		{
			return this.As<IAbsolutePos2T>();
		}

		// Token: 0x06037459 RID: 226393 RVA: 0x0077D648 File Offset: 0x0077B848
		public static TEffectPos2Union FromIAbsolutePos2(IAbsolutePos2T _iabsolutepos2)
		{
			return new TEffectPos2Union
			{
				Type = TEffectPos2.IAbsolutePos2,
				Value = _iabsolutepos2
			};
		}

		// Token: 0x0603745A RID: 226394 RVA: 0x0077D65D File Offset: 0x0077B85D
		public IEffectEntityPos2T AsIEffectEntityPos2()
		{
			return this.As<IEffectEntityPos2T>();
		}

		// Token: 0x0603745B RID: 226395 RVA: 0x0077D665 File Offset: 0x0077B865
		public static TEffectPos2Union FromIEffectEntityPos2(IEffectEntityPos2T _ieffectentitypos2)
		{
			return new TEffectPos2Union
			{
				Type = TEffectPos2.IEffectEntityPos2,
				Value = _ieffectentitypos2
			};
		}

		// Token: 0x0603745C RID: 226396 RVA: 0x0077D67A File Offset: 0x0077B87A
		public IEffectPlayerPos2T AsIEffectPlayerPos2()
		{
			return this.As<IEffectPlayerPos2T>();
		}

		// Token: 0x0603745D RID: 226397 RVA: 0x0077D682 File Offset: 0x0077B882
		public static TEffectPos2Union FromIEffectPlayerPos2(IEffectPlayerPos2T _ieffectplayerpos2)
		{
			return new TEffectPos2Union
			{
				Type = TEffectPos2.IEffectPlayerPos2,
				Value = _ieffectplayerpos2
			};
		}

		// Token: 0x0603745E RID: 226398 RVA: 0x0077D698 File Offset: 0x0077B898
		public static int Pack(FlatBufferBuilder builder, TEffectPos2Union _o)
		{
			switch (_o.Type)
			{
			case TEffectPos2.IAbsolutePos2:
				return IAbsolutePos2.Pack(builder, _o.AsIAbsolutePos2()).Value;
			case TEffectPos2.IEffectEntityPos2:
				return IEffectEntityPos2.Pack(builder, _o.AsIEffectEntityPos2()).Value;
			case TEffectPos2.IEffectPlayerPos2:
				return IEffectPlayerPos2.Pack(builder, _o.AsIEffectPlayerPos2()).Value;
			default:
				return 0;
			}
		}
	}
}
