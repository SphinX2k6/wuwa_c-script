using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005161 RID: 20833
	public class IOnlinePlayerConditionTarget_UnionUnion
	{
		// Token: 0x1700953E RID: 38206
		// (get) Token: 0x06020C51 RID: 134225 RVA: 0x00489BE2 File Offset: 0x00487DE2
		// (set) Token: 0x06020C52 RID: 134226 RVA: 0x00489BEA File Offset: 0x00487DEA
		public IOnlinePlayerConditionTarget_Union Type { get; set; }

		// Token: 0x1700953F RID: 38207
		// (get) Token: 0x06020C53 RID: 134227 RVA: 0x00489BF3 File Offset: 0x00487DF3
		// (set) Token: 0x06020C54 RID: 134228 RVA: 0x00489BFB File Offset: 0x00487DFB
		public object Value { get; set; }

		// Token: 0x06020C55 RID: 134229 RVA: 0x00489C04 File Offset: 0x00487E04
		public IOnlinePlayerConditionTarget_UnionUnion()
		{
			this.Type = IOnlinePlayerConditionTarget_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06020C56 RID: 134230 RVA: 0x00489C1A File Offset: 0x00487E1A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06020C57 RID: 134231 RVA: 0x00489C2C File Offset: 0x00487E2C
		public IOnlinePlayerConditionTargetT AsIOnlinePlayerConditionTarget()
		{
			return this.As<IOnlinePlayerConditionTargetT>();
		}

		// Token: 0x06020C58 RID: 134232 RVA: 0x00489C34 File Offset: 0x00487E34
		public static IOnlinePlayerConditionTarget_UnionUnion FromIOnlinePlayerConditionTarget(IOnlinePlayerConditionTargetT _ionlineplayerconditiontarget)
		{
			return new IOnlinePlayerConditionTarget_UnionUnion
			{
				Type = IOnlinePlayerConditionTarget_Union.IOnlinePlayerConditionTarget,
				Value = _ionlineplayerconditiontarget
			};
		}

		// Token: 0x06020C59 RID: 134233 RVA: 0x00489C49 File Offset: 0x00487E49
		public IOnlinePlayerConditionTargetHostT AsIOnlinePlayerConditionTargetHost()
		{
			return this.As<IOnlinePlayerConditionTargetHostT>();
		}

		// Token: 0x06020C5A RID: 134234 RVA: 0x00489C51 File Offset: 0x00487E51
		public static IOnlinePlayerConditionTarget_UnionUnion FromIOnlinePlayerConditionTargetHost(IOnlinePlayerConditionTargetHostT _ionlineplayerconditiontargethost)
		{
			return new IOnlinePlayerConditionTarget_UnionUnion
			{
				Type = IOnlinePlayerConditionTarget_Union.IOnlinePlayerConditionTargetHost,
				Value = _ionlineplayerconditiontargethost
			};
		}

		// Token: 0x06020C5B RID: 134235 RVA: 0x00489C66 File Offset: 0x00487E66
		public IOnlinePlayerConditionTargetParticipatorT AsIOnlinePlayerConditionTargetParticipator()
		{
			return this.As<IOnlinePlayerConditionTargetParticipatorT>();
		}

		// Token: 0x06020C5C RID: 134236 RVA: 0x00489C6E File Offset: 0x00487E6E
		public static IOnlinePlayerConditionTarget_UnionUnion FromIOnlinePlayerConditionTargetParticipator(IOnlinePlayerConditionTargetParticipatorT _ionlineplayerconditiontargetparticipator)
		{
			return new IOnlinePlayerConditionTarget_UnionUnion
			{
				Type = IOnlinePlayerConditionTarget_Union.IOnlinePlayerConditionTargetParticipator,
				Value = _ionlineplayerconditiontargetparticipator
			};
		}

		// Token: 0x06020C5D RID: 134237 RVA: 0x00489C84 File Offset: 0x00487E84
		public static int Pack(FlatBufferBuilder builder, IOnlinePlayerConditionTarget_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IOnlinePlayerConditionTarget_Union.IOnlinePlayerConditionTarget:
				return IOnlinePlayerConditionTarget.Pack(builder, _o.AsIOnlinePlayerConditionTarget()).Value;
			case IOnlinePlayerConditionTarget_Union.IOnlinePlayerConditionTargetHost:
				return IOnlinePlayerConditionTargetHost.Pack(builder, _o.AsIOnlinePlayerConditionTargetHost()).Value;
			case IOnlinePlayerConditionTarget_Union.IOnlinePlayerConditionTargetParticipator:
				return IOnlinePlayerConditionTargetParticipator.Pack(builder, _o.AsIOnlinePlayerConditionTargetParticipator()).Value;
			default:
				return 0;
			}
		}
	}
}
