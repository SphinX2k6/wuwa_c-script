using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006283 RID: 25219
	public class TMechHookInteractTypeUnion
	{
		// Token: 0x1700BB6E RID: 47982
		// (get) Token: 0x0602AE77 RID: 175735 RVA: 0x005DB00A File Offset: 0x005D920A
		// (set) Token: 0x0602AE78 RID: 175736 RVA: 0x005DB012 File Offset: 0x005D9212
		public TMechHookInteractType Type { get; set; }

		// Token: 0x1700BB6F RID: 47983
		// (get) Token: 0x0602AE79 RID: 175737 RVA: 0x005DB01B File Offset: 0x005D921B
		// (set) Token: 0x0602AE7A RID: 175738 RVA: 0x005DB023 File Offset: 0x005D9223
		public object Value { get; set; }

		// Token: 0x0602AE7B RID: 175739 RVA: 0x005DB02C File Offset: 0x005D922C
		public TMechHookInteractTypeUnion()
		{
			this.Type = TMechHookInteractType.NONE;
			this.Value = null;
		}

		// Token: 0x0602AE7C RID: 175740 RVA: 0x005DB042 File Offset: 0x005D9242
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AE7D RID: 175741 RVA: 0x005DB054 File Offset: 0x005D9254
		public IMechBurrowHookInteractT AsIMechBurrowHookInteract()
		{
			return this.As<IMechBurrowHookInteractT>();
		}

		// Token: 0x0602AE7E RID: 175742 RVA: 0x005DB05C File Offset: 0x005D925C
		public static TMechHookInteractTypeUnion FromIMechBurrowHookInteract(IMechBurrowHookInteractT _imechburrowhookinteract)
		{
			return new TMechHookInteractTypeUnion
			{
				Type = TMechHookInteractType.IMechBurrowHookInteract,
				Value = _imechburrowhookinteract
			};
		}

		// Token: 0x0602AE7F RID: 175743 RVA: 0x005DB071 File Offset: 0x005D9271
		public IMechFixedPointHookInteractT AsIMechFixedPointHookInteract()
		{
			return this.As<IMechFixedPointHookInteractT>();
		}

		// Token: 0x0602AE80 RID: 175744 RVA: 0x005DB079 File Offset: 0x005D9279
		public static TMechHookInteractTypeUnion FromIMechFixedPointHookInteract(IMechFixedPointHookInteractT _imechfixedpointhookinteract)
		{
			return new TMechHookInteractTypeUnion
			{
				Type = TMechHookInteractType.IMechFixedPointHookInteract,
				Value = _imechfixedpointhookinteract
			};
		}

		// Token: 0x0602AE81 RID: 175745 RVA: 0x005DB08E File Offset: 0x005D928E
		public IMechPullHookInteractT AsIMechPullHookInteract()
		{
			return this.As<IMechPullHookInteractT>();
		}

		// Token: 0x0602AE82 RID: 175746 RVA: 0x005DB096 File Offset: 0x005D9296
		public static TMechHookInteractTypeUnion FromIMechPullHookInteract(IMechPullHookInteractT _imechpullhookinteract)
		{
			return new TMechHookInteractTypeUnion
			{
				Type = TMechHookInteractType.IMechPullHookInteract,
				Value = _imechpullhookinteract
			};
		}

		// Token: 0x0602AE83 RID: 175747 RVA: 0x005DB0AC File Offset: 0x005D92AC
		public static int Pack(FlatBufferBuilder builder, TMechHookInteractTypeUnion _o)
		{
			switch (_o.Type)
			{
			case TMechHookInteractType.IMechBurrowHookInteract:
				return IMechBurrowHookInteract.Pack(builder, _o.AsIMechBurrowHookInteract()).Value;
			case TMechHookInteractType.IMechFixedPointHookInteract:
				return IMechFixedPointHookInteract.Pack(builder, _o.AsIMechFixedPointHookInteract()).Value;
			case TMechHookInteractType.IMechPullHookInteract:
				return IMechPullHookInteract.Pack(builder, _o.AsIMechPullHookInteract()).Value;
			default:
				return 0;
			}
		}
	}
}
