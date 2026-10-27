using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F8D RID: 16269
	public class IPhotographSubTarget_UnionUnion
	{
		// Token: 0x17007193 RID: 29075
		// (get) Token: 0x060173BE RID: 95166 RVA: 0x0035A0FF File Offset: 0x003582FF
		// (set) Token: 0x060173BF RID: 95167 RVA: 0x0035A107 File Offset: 0x00358307
		public IPhotographSubTarget_Union Type { get; set; }

		// Token: 0x17007194 RID: 29076
		// (get) Token: 0x060173C0 RID: 95168 RVA: 0x0035A110 File Offset: 0x00358310
		// (set) Token: 0x060173C1 RID: 95169 RVA: 0x0035A118 File Offset: 0x00358318
		public object Value { get; set; }

		// Token: 0x060173C2 RID: 95170 RVA: 0x0035A121 File Offset: 0x00358321
		public IPhotographSubTarget_UnionUnion()
		{
			this.Type = IPhotographSubTarget_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060173C3 RID: 95171 RVA: 0x0035A137 File Offset: 0x00358337
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060173C4 RID: 95172 RVA: 0x0035A149 File Offset: 0x00358349
		public IPhotographSubTargetT AsIPhotographSubTarget()
		{
			return this.As<IPhotographSubTargetT>();
		}

		// Token: 0x060173C5 RID: 95173 RVA: 0x0035A151 File Offset: 0x00358351
		public static IPhotographSubTarget_UnionUnion FromIPhotographSubTarget(IPhotographSubTargetT _iphotographsubtarget)
		{
			return new IPhotographSubTarget_UnionUnion
			{
				Type = IPhotographSubTarget_Union.IPhotographSubTarget,
				Value = _iphotographsubtarget
			};
		}

		// Token: 0x060173C6 RID: 95174 RVA: 0x0035A166 File Offset: 0x00358366
		public IPhotographSubTargetSpecificRoleT AsIPhotographSubTargetSpecificRole()
		{
			return this.As<IPhotographSubTargetSpecificRoleT>();
		}

		// Token: 0x060173C7 RID: 95175 RVA: 0x0035A16E File Offset: 0x0035836E
		public static IPhotographSubTarget_UnionUnion FromIPhotographSubTargetSpecificRole(IPhotographSubTargetSpecificRoleT _iphotographsubtargetspecificrole)
		{
			return new IPhotographSubTarget_UnionUnion
			{
				Type = IPhotographSubTarget_Union.IPhotographSubTargetSpecificRole,
				Value = _iphotographsubtargetspecificrole
			};
		}

		// Token: 0x060173C8 RID: 95176 RVA: 0x0035A183 File Offset: 0x00358383
		public IPhotographSubTargetAnyRoleT AsIPhotographSubTargetAnyRole()
		{
			return this.As<IPhotographSubTargetAnyRoleT>();
		}

		// Token: 0x060173C9 RID: 95177 RVA: 0x0035A18B File Offset: 0x0035838B
		public static IPhotographSubTarget_UnionUnion FromIPhotographSubTargetAnyRole(IPhotographSubTargetAnyRoleT _iphotographsubtargetanyrole)
		{
			return new IPhotographSubTarget_UnionUnion
			{
				Type = IPhotographSubTarget_Union.IPhotographSubTargetAnyRole,
				Value = _iphotographsubtargetanyrole
			};
		}

		// Token: 0x060173CA RID: 95178 RVA: 0x0035A1A0 File Offset: 0x003583A0
		public static int Pack(FlatBufferBuilder builder, IPhotographSubTarget_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IPhotographSubTarget_Union.IPhotographSubTarget:
				return IPhotographSubTarget.Pack(builder, _o.AsIPhotographSubTarget()).Value;
			case IPhotographSubTarget_Union.IPhotographSubTargetSpecificRole:
				return IPhotographSubTargetSpecificRole.Pack(builder, _o.AsIPhotographSubTargetSpecificRole()).Value;
			case IPhotographSubTarget_Union.IPhotographSubTargetAnyRole:
				return IPhotographSubTargetAnyRole.Pack(builder, _o.AsIPhotographSubTargetAnyRole()).Value;
			default:
				return 0;
			}
		}
	}
}
