using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042F1 RID: 17137
	public class TPhotographSubTargetUnion
	{
		// Token: 0x17007958 RID: 31064
		// (get) Token: 0x060196AD RID: 104109 RVA: 0x003A50A2 File Offset: 0x003A32A2
		// (set) Token: 0x060196AE RID: 104110 RVA: 0x003A50AA File Offset: 0x003A32AA
		public TPhotographSubTarget Type { get; set; }

		// Token: 0x17007959 RID: 31065
		// (get) Token: 0x060196AF RID: 104111 RVA: 0x003A50B3 File Offset: 0x003A32B3
		// (set) Token: 0x060196B0 RID: 104112 RVA: 0x003A50BB File Offset: 0x003A32BB
		public object Value { get; set; }

		// Token: 0x060196B1 RID: 104113 RVA: 0x003A50C4 File Offset: 0x003A32C4
		public TPhotographSubTargetUnion()
		{
			this.Type = TPhotographSubTarget.NONE;
			this.Value = null;
		}

		// Token: 0x060196B2 RID: 104114 RVA: 0x003A50DA File Offset: 0x003A32DA
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060196B3 RID: 104115 RVA: 0x003A50EC File Offset: 0x003A32EC
		public IPhotographSubTargetAnyRoleT AsIPhotographSubTargetAnyRole()
		{
			return this.As<IPhotographSubTargetAnyRoleT>();
		}

		// Token: 0x060196B4 RID: 104116 RVA: 0x003A50F4 File Offset: 0x003A32F4
		public static TPhotographSubTargetUnion FromIPhotographSubTargetAnyRole(IPhotographSubTargetAnyRoleT _iphotographsubtargetanyrole)
		{
			return new TPhotographSubTargetUnion
			{
				Type = TPhotographSubTarget.IPhotographSubTargetAnyRole,
				Value = _iphotographsubtargetanyrole
			};
		}

		// Token: 0x060196B5 RID: 104117 RVA: 0x003A5109 File Offset: 0x003A3309
		public IPhotographSubTargetSpecificRoleT AsIPhotographSubTargetSpecificRole()
		{
			return this.As<IPhotographSubTargetSpecificRoleT>();
		}

		// Token: 0x060196B6 RID: 104118 RVA: 0x003A5111 File Offset: 0x003A3311
		public static TPhotographSubTargetUnion FromIPhotographSubTargetSpecificRole(IPhotographSubTargetSpecificRoleT _iphotographsubtargetspecificrole)
		{
			return new TPhotographSubTargetUnion
			{
				Type = TPhotographSubTarget.IPhotographSubTargetSpecificRole,
				Value = _iphotographsubtargetspecificrole
			};
		}

		// Token: 0x060196B7 RID: 104119 RVA: 0x003A5128 File Offset: 0x003A3328
		public static int Pack(FlatBufferBuilder builder, TPhotographSubTargetUnion _o)
		{
			TPhotographSubTarget type = _o.Type;
			if (type == TPhotographSubTarget.IPhotographSubTargetAnyRole)
			{
				return IPhotographSubTargetAnyRole.Pack(builder, _o.AsIPhotographSubTargetAnyRole()).Value;
			}
			if (type != TPhotographSubTarget.IPhotographSubTargetSpecificRole)
			{
				return 0;
			}
			return IPhotographSubTargetSpecificRole.Pack(builder, _o.AsIPhotographSubTargetSpecificRole()).Value;
		}
	}
}
