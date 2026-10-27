using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D4C RID: 19788
	public class TOnlinePlayerConditionTargetUnion
	{
		// Token: 0x17008F4D RID: 36685
		// (get) Token: 0x0601F66E RID: 128622 RVA: 0x0046033A File Offset: 0x0045E53A
		// (set) Token: 0x0601F66F RID: 128623 RVA: 0x00460342 File Offset: 0x0045E542
		public TOnlinePlayerConditionTarget Type { get; set; }

		// Token: 0x17008F4E RID: 36686
		// (get) Token: 0x0601F670 RID: 128624 RVA: 0x0046034B File Offset: 0x0045E54B
		// (set) Token: 0x0601F671 RID: 128625 RVA: 0x00460353 File Offset: 0x0045E553
		public object Value { get; set; }

		// Token: 0x0601F672 RID: 128626 RVA: 0x0046035C File Offset: 0x0045E55C
		public TOnlinePlayerConditionTargetUnion()
		{
			this.Type = TOnlinePlayerConditionTarget.NONE;
			this.Value = null;
		}

		// Token: 0x0601F673 RID: 128627 RVA: 0x00460372 File Offset: 0x0045E572
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601F674 RID: 128628 RVA: 0x00460384 File Offset: 0x0045E584
		public IOnlinePlayerConditionTargetHostT AsIOnlinePlayerConditionTargetHost()
		{
			return this.As<IOnlinePlayerConditionTargetHostT>();
		}

		// Token: 0x0601F675 RID: 128629 RVA: 0x0046038C File Offset: 0x0045E58C
		public static TOnlinePlayerConditionTargetUnion FromIOnlinePlayerConditionTargetHost(IOnlinePlayerConditionTargetHostT _ionlineplayerconditiontargethost)
		{
			return new TOnlinePlayerConditionTargetUnion
			{
				Type = TOnlinePlayerConditionTarget.IOnlinePlayerConditionTargetHost,
				Value = _ionlineplayerconditiontargethost
			};
		}

		// Token: 0x0601F676 RID: 128630 RVA: 0x004603A1 File Offset: 0x0045E5A1
		public IOnlinePlayerConditionTargetParticipatorT AsIOnlinePlayerConditionTargetParticipator()
		{
			return this.As<IOnlinePlayerConditionTargetParticipatorT>();
		}

		// Token: 0x0601F677 RID: 128631 RVA: 0x004603A9 File Offset: 0x0045E5A9
		public static TOnlinePlayerConditionTargetUnion FromIOnlinePlayerConditionTargetParticipator(IOnlinePlayerConditionTargetParticipatorT _ionlineplayerconditiontargetparticipator)
		{
			return new TOnlinePlayerConditionTargetUnion
			{
				Type = TOnlinePlayerConditionTarget.IOnlinePlayerConditionTargetParticipator,
				Value = _ionlineplayerconditiontargetparticipator
			};
		}

		// Token: 0x0601F678 RID: 128632 RVA: 0x004603C0 File Offset: 0x0045E5C0
		public static int Pack(FlatBufferBuilder builder, TOnlinePlayerConditionTargetUnion _o)
		{
			TOnlinePlayerConditionTarget type = _o.Type;
			if (type == TOnlinePlayerConditionTarget.IOnlinePlayerConditionTargetHost)
			{
				return IOnlinePlayerConditionTargetHost.Pack(builder, _o.AsIOnlinePlayerConditionTargetHost()).Value;
			}
			if (type != TOnlinePlayerConditionTarget.IOnlinePlayerConditionTargetParticipator)
			{
				return 0;
			}
			return IOnlinePlayerConditionTargetParticipator.Pack(builder, _o.AsIOnlinePlayerConditionTargetParticipator()).Value;
		}
	}
}
