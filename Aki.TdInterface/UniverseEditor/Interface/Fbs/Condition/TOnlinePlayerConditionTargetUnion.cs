using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005248 RID: 21064
	public class TOnlinePlayerConditionTargetUnion
	{
		// Token: 0x17009686 RID: 38534
		// (get) Token: 0x060212B7 RID: 135863 RVA: 0x0049430E File Offset: 0x0049250E
		// (set) Token: 0x060212B8 RID: 135864 RVA: 0x00494316 File Offset: 0x00492516
		public TOnlinePlayerConditionTarget Type { get; set; }

		// Token: 0x17009687 RID: 38535
		// (get) Token: 0x060212B9 RID: 135865 RVA: 0x0049431F File Offset: 0x0049251F
		// (set) Token: 0x060212BA RID: 135866 RVA: 0x00494327 File Offset: 0x00492527
		public object Value { get; set; }

		// Token: 0x060212BB RID: 135867 RVA: 0x00494330 File Offset: 0x00492530
		public TOnlinePlayerConditionTargetUnion()
		{
			this.Type = TOnlinePlayerConditionTarget.NONE;
			this.Value = null;
		}

		// Token: 0x060212BC RID: 135868 RVA: 0x00494346 File Offset: 0x00492546
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060212BD RID: 135869 RVA: 0x00494358 File Offset: 0x00492558
		public IOnlinePlayerConditionTargetHostT AsIOnlinePlayerConditionTargetHost()
		{
			return this.As<IOnlinePlayerConditionTargetHostT>();
		}

		// Token: 0x060212BE RID: 135870 RVA: 0x00494360 File Offset: 0x00492560
		public static TOnlinePlayerConditionTargetUnion FromIOnlinePlayerConditionTargetHost(IOnlinePlayerConditionTargetHostT _ionlineplayerconditiontargethost)
		{
			return new TOnlinePlayerConditionTargetUnion
			{
				Type = TOnlinePlayerConditionTarget.IOnlinePlayerConditionTargetHost,
				Value = _ionlineplayerconditiontargethost
			};
		}

		// Token: 0x060212BF RID: 135871 RVA: 0x00494375 File Offset: 0x00492575
		public IOnlinePlayerConditionTargetParticipatorT AsIOnlinePlayerConditionTargetParticipator()
		{
			return this.As<IOnlinePlayerConditionTargetParticipatorT>();
		}

		// Token: 0x060212C0 RID: 135872 RVA: 0x0049437D File Offset: 0x0049257D
		public static TOnlinePlayerConditionTargetUnion FromIOnlinePlayerConditionTargetParticipator(IOnlinePlayerConditionTargetParticipatorT _ionlineplayerconditiontargetparticipator)
		{
			return new TOnlinePlayerConditionTargetUnion
			{
				Type = TOnlinePlayerConditionTarget.IOnlinePlayerConditionTargetParticipator,
				Value = _ionlineplayerconditiontargetparticipator
			};
		}

		// Token: 0x060212C1 RID: 135873 RVA: 0x00494394 File Offset: 0x00492594
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
