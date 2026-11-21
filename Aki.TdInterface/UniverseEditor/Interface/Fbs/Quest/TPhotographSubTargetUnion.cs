using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004750 RID: 18256
	public class TPhotographSubTargetUnion
	{
		// Token: 0x17007F8B RID: 32651
		// (get) Token: 0x0601AE2F RID: 110127 RVA: 0x003D09D2 File Offset: 0x003CEBD2
		// (set) Token: 0x0601AE30 RID: 110128 RVA: 0x003D09DA File Offset: 0x003CEBDA
		public TPhotographSubTarget Type { get; set; }

		// Token: 0x17007F8C RID: 32652
		// (get) Token: 0x0601AE31 RID: 110129 RVA: 0x003D09E3 File Offset: 0x003CEBE3
		// (set) Token: 0x0601AE32 RID: 110130 RVA: 0x003D09EB File Offset: 0x003CEBEB
		public object Value { get; set; }

		// Token: 0x0601AE33 RID: 110131 RVA: 0x003D09F4 File Offset: 0x003CEBF4
		public TPhotographSubTargetUnion()
		{
			this.Type = TPhotographSubTarget.NONE;
			this.Value = null;
		}

		// Token: 0x0601AE34 RID: 110132 RVA: 0x003D0A0A File Offset: 0x003CEC0A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AE35 RID: 110133 RVA: 0x003D0A1C File Offset: 0x003CEC1C
		public IPhotographSubTargetAnyRoleT AsIPhotographSubTargetAnyRole()
		{
			return this.As<IPhotographSubTargetAnyRoleT>();
		}

		// Token: 0x0601AE36 RID: 110134 RVA: 0x003D0A24 File Offset: 0x003CEC24
		public static TPhotographSubTargetUnion FromIPhotographSubTargetAnyRole(IPhotographSubTargetAnyRoleT _iphotographsubtargetanyrole)
		{
			return new TPhotographSubTargetUnion
			{
				Type = TPhotographSubTarget.IPhotographSubTargetAnyRole,
				Value = _iphotographsubtargetanyrole
			};
		}

		// Token: 0x0601AE37 RID: 110135 RVA: 0x003D0A39 File Offset: 0x003CEC39
		public IPhotographSubTargetSpecificRoleT AsIPhotographSubTargetSpecificRole()
		{
			return this.As<IPhotographSubTargetSpecificRoleT>();
		}

		// Token: 0x0601AE38 RID: 110136 RVA: 0x003D0A41 File Offset: 0x003CEC41
		public static TPhotographSubTargetUnion FromIPhotographSubTargetSpecificRole(IPhotographSubTargetSpecificRoleT _iphotographsubtargetspecificrole)
		{
			return new TPhotographSubTargetUnion
			{
				Type = TPhotographSubTarget.IPhotographSubTargetSpecificRole,
				Value = _iphotographsubtargetspecificrole
			};
		}

		// Token: 0x0601AE39 RID: 110137 RVA: 0x003D0A58 File Offset: 0x003CEC58
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
