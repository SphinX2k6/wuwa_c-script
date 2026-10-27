using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C68 RID: 19560
	public class IOnlinePlayerConditionTarget_UnionUnion
	{
		// Token: 0x17008E10 RID: 36368
		// (get) Token: 0x0601F02F RID: 127023 RVA: 0x00456092 File Offset: 0x00454292
		// (set) Token: 0x0601F030 RID: 127024 RVA: 0x0045609A File Offset: 0x0045429A
		public IOnlinePlayerConditionTarget_Union Type { get; set; }

		// Token: 0x17008E11 RID: 36369
		// (get) Token: 0x0601F031 RID: 127025 RVA: 0x004560A3 File Offset: 0x004542A3
		// (set) Token: 0x0601F032 RID: 127026 RVA: 0x004560AB File Offset: 0x004542AB
		public object Value { get; set; }

		// Token: 0x0601F033 RID: 127027 RVA: 0x004560B4 File Offset: 0x004542B4
		public IOnlinePlayerConditionTarget_UnionUnion()
		{
			this.Type = IOnlinePlayerConditionTarget_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601F034 RID: 127028 RVA: 0x004560CA File Offset: 0x004542CA
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601F035 RID: 127029 RVA: 0x004560DC File Offset: 0x004542DC
		public IOnlinePlayerConditionTargetT AsIOnlinePlayerConditionTarget()
		{
			return this.As<IOnlinePlayerConditionTargetT>();
		}

		// Token: 0x0601F036 RID: 127030 RVA: 0x004560E4 File Offset: 0x004542E4
		public static IOnlinePlayerConditionTarget_UnionUnion FromIOnlinePlayerConditionTarget(IOnlinePlayerConditionTargetT _ionlineplayerconditiontarget)
		{
			return new IOnlinePlayerConditionTarget_UnionUnion
			{
				Type = IOnlinePlayerConditionTarget_Union.IOnlinePlayerConditionTarget,
				Value = _ionlineplayerconditiontarget
			};
		}

		// Token: 0x0601F037 RID: 127031 RVA: 0x004560F9 File Offset: 0x004542F9
		public IOnlinePlayerConditionTargetHostT AsIOnlinePlayerConditionTargetHost()
		{
			return this.As<IOnlinePlayerConditionTargetHostT>();
		}

		// Token: 0x0601F038 RID: 127032 RVA: 0x00456101 File Offset: 0x00454301
		public static IOnlinePlayerConditionTarget_UnionUnion FromIOnlinePlayerConditionTargetHost(IOnlinePlayerConditionTargetHostT _ionlineplayerconditiontargethost)
		{
			return new IOnlinePlayerConditionTarget_UnionUnion
			{
				Type = IOnlinePlayerConditionTarget_Union.IOnlinePlayerConditionTargetHost,
				Value = _ionlineplayerconditiontargethost
			};
		}

		// Token: 0x0601F039 RID: 127033 RVA: 0x00456116 File Offset: 0x00454316
		public IOnlinePlayerConditionTargetParticipatorT AsIOnlinePlayerConditionTargetParticipator()
		{
			return this.As<IOnlinePlayerConditionTargetParticipatorT>();
		}

		// Token: 0x0601F03A RID: 127034 RVA: 0x0045611E File Offset: 0x0045431E
		public static IOnlinePlayerConditionTarget_UnionUnion FromIOnlinePlayerConditionTargetParticipator(IOnlinePlayerConditionTargetParticipatorT _ionlineplayerconditiontargetparticipator)
		{
			return new IOnlinePlayerConditionTarget_UnionUnion
			{
				Type = IOnlinePlayerConditionTarget_Union.IOnlinePlayerConditionTargetParticipator,
				Value = _ionlineplayerconditiontargetparticipator
			};
		}

		// Token: 0x0601F03B RID: 127035 RVA: 0x00456134 File Offset: 0x00454334
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
