using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200636B RID: 25451
	public class ICheckFlowLookAtTarget_UnionUnion
	{
		// Token: 0x1700BDDC RID: 48604
		// (get) Token: 0x0602C071 RID: 180337 RVA: 0x0060CAD5 File Offset: 0x0060ACD5
		// (set) Token: 0x0602C072 RID: 180338 RVA: 0x0060CADD File Offset: 0x0060ACDD
		public ICheckFlowLookAtTarget_Union Type { get; set; }

		// Token: 0x1700BDDD RID: 48605
		// (get) Token: 0x0602C073 RID: 180339 RVA: 0x0060CAE6 File Offset: 0x0060ACE6
		// (set) Token: 0x0602C074 RID: 180340 RVA: 0x0060CAEE File Offset: 0x0060ACEE
		public object Value { get; set; }

		// Token: 0x0602C075 RID: 180341 RVA: 0x0060CAF7 File Offset: 0x0060ACF7
		public ICheckFlowLookAtTarget_UnionUnion()
		{
			this.Type = ICheckFlowLookAtTarget_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602C076 RID: 180342 RVA: 0x0060CB0D File Offset: 0x0060AD0D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602C077 RID: 180343 RVA: 0x0060CB1F File Offset: 0x0060AD1F
		public ICheckFlowLookAtTargetT AsICheckFlowLookAtTarget()
		{
			return this.As<ICheckFlowLookAtTargetT>();
		}

		// Token: 0x0602C078 RID: 180344 RVA: 0x0060CB27 File Offset: 0x0060AD27
		public static ICheckFlowLookAtTarget_UnionUnion FromICheckFlowLookAtTarget(ICheckFlowLookAtTargetT _icheckflowlookattarget)
		{
			return new ICheckFlowLookAtTarget_UnionUnion
			{
				Type = ICheckFlowLookAtTarget_Union.ICheckFlowLookAtTarget,
				Value = _icheckflowlookattarget
			};
		}

		// Token: 0x0602C079 RID: 180345 RVA: 0x0060CB3C File Offset: 0x0060AD3C
		public ICheckFlowLookAtEntityT AsICheckFlowLookAtEntity()
		{
			return this.As<ICheckFlowLookAtEntityT>();
		}

		// Token: 0x0602C07A RID: 180346 RVA: 0x0060CB44 File Offset: 0x0060AD44
		public static ICheckFlowLookAtTarget_UnionUnion FromICheckFlowLookAtEntity(ICheckFlowLookAtEntityT _icheckflowlookatentity)
		{
			return new ICheckFlowLookAtTarget_UnionUnion
			{
				Type = ICheckFlowLookAtTarget_Union.ICheckFlowLookAtEntity,
				Value = _icheckflowlookatentity
			};
		}

		// Token: 0x0602C07B RID: 180347 RVA: 0x0060CB59 File Offset: 0x0060AD59
		public ICheckFlowLookAtPlayerT AsICheckFlowLookAtPlayer()
		{
			return this.As<ICheckFlowLookAtPlayerT>();
		}

		// Token: 0x0602C07C RID: 180348 RVA: 0x0060CB61 File Offset: 0x0060AD61
		public static ICheckFlowLookAtTarget_UnionUnion FromICheckFlowLookAtPlayer(ICheckFlowLookAtPlayerT _icheckflowlookatplayer)
		{
			return new ICheckFlowLookAtTarget_UnionUnion
			{
				Type = ICheckFlowLookAtTarget_Union.ICheckFlowLookAtPlayer,
				Value = _icheckflowlookatplayer
			};
		}

		// Token: 0x0602C07D RID: 180349 RVA: 0x0060CB78 File Offset: 0x0060AD78
		public static int Pack(FlatBufferBuilder builder, ICheckFlowLookAtTarget_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ICheckFlowLookAtTarget_Union.ICheckFlowLookAtTarget:
				return ICheckFlowLookAtTarget.Pack(builder, _o.AsICheckFlowLookAtTarget()).Value;
			case ICheckFlowLookAtTarget_Union.ICheckFlowLookAtEntity:
				return ICheckFlowLookAtEntity.Pack(builder, _o.AsICheckFlowLookAtEntity()).Value;
			case ICheckFlowLookAtTarget_Union.ICheckFlowLookAtPlayer:
				return ICheckFlowLookAtPlayer.Pack(builder, _o.AsICheckFlowLookAtPlayer()).Value;
			default:
				return 0;
			}
		}
	}
}
