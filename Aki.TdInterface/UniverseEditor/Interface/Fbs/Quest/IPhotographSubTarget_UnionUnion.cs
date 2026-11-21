using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043CE RID: 17358
	public class IPhotographSubTarget_UnionUnion
	{
		// Token: 0x17007791 RID: 30609
		// (get) Token: 0x06018A4D RID: 100941 RVA: 0x00383D17 File Offset: 0x00381F17
		// (set) Token: 0x06018A4E RID: 100942 RVA: 0x00383D1F File Offset: 0x00381F1F
		public IPhotographSubTarget_Union Type { get; set; }

		// Token: 0x17007792 RID: 30610
		// (get) Token: 0x06018A4F RID: 100943 RVA: 0x00383D28 File Offset: 0x00381F28
		// (set) Token: 0x06018A50 RID: 100944 RVA: 0x00383D30 File Offset: 0x00381F30
		public object Value { get; set; }

		// Token: 0x06018A51 RID: 100945 RVA: 0x00383D39 File Offset: 0x00381F39
		public IPhotographSubTarget_UnionUnion()
		{
			this.Type = IPhotographSubTarget_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06018A52 RID: 100946 RVA: 0x00383D4F File Offset: 0x00381F4F
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06018A53 RID: 100947 RVA: 0x00383D61 File Offset: 0x00381F61
		public IPhotographSubTargetT AsIPhotographSubTarget()
		{
			return this.As<IPhotographSubTargetT>();
		}

		// Token: 0x06018A54 RID: 100948 RVA: 0x00383D69 File Offset: 0x00381F69
		public static IPhotographSubTarget_UnionUnion FromIPhotographSubTarget(IPhotographSubTargetT _iphotographsubtarget)
		{
			return new IPhotographSubTarget_UnionUnion
			{
				Type = IPhotographSubTarget_Union.IPhotographSubTarget,
				Value = _iphotographsubtarget
			};
		}

		// Token: 0x06018A55 RID: 100949 RVA: 0x00383D7E File Offset: 0x00381F7E
		public IPhotographSubTargetSpecificRoleT AsIPhotographSubTargetSpecificRole()
		{
			return this.As<IPhotographSubTargetSpecificRoleT>();
		}

		// Token: 0x06018A56 RID: 100950 RVA: 0x00383D86 File Offset: 0x00381F86
		public static IPhotographSubTarget_UnionUnion FromIPhotographSubTargetSpecificRole(IPhotographSubTargetSpecificRoleT _iphotographsubtargetspecificrole)
		{
			return new IPhotographSubTarget_UnionUnion
			{
				Type = IPhotographSubTarget_Union.IPhotographSubTargetSpecificRole,
				Value = _iphotographsubtargetspecificrole
			};
		}

		// Token: 0x06018A57 RID: 100951 RVA: 0x00383D9B File Offset: 0x00381F9B
		public IPhotographSubTargetAnyRoleT AsIPhotographSubTargetAnyRole()
		{
			return this.As<IPhotographSubTargetAnyRoleT>();
		}

		// Token: 0x06018A58 RID: 100952 RVA: 0x00383DA3 File Offset: 0x00381FA3
		public static IPhotographSubTarget_UnionUnion FromIPhotographSubTargetAnyRole(IPhotographSubTargetAnyRoleT _iphotographsubtargetanyrole)
		{
			return new IPhotographSubTarget_UnionUnion
			{
				Type = IPhotographSubTarget_Union.IPhotographSubTargetAnyRole,
				Value = _iphotographsubtargetanyrole
			};
		}

		// Token: 0x06018A59 RID: 100953 RVA: 0x00383DB8 File Offset: 0x00381FB8
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
