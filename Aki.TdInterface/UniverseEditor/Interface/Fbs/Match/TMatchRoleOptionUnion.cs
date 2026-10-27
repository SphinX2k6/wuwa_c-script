using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Match
{
	// Token: 0x02004407 RID: 17415
	public class TMatchRoleOptionUnion
	{
		// Token: 0x17007ADC RID: 31452
		// (get) Token: 0x06019ECC RID: 106188 RVA: 0x003B5524 File Offset: 0x003B3724
		// (set) Token: 0x06019ECD RID: 106189 RVA: 0x003B552C File Offset: 0x003B372C
		public TMatchRoleOption Type { get; set; }

		// Token: 0x17007ADD RID: 31453
		// (get) Token: 0x06019ECE RID: 106190 RVA: 0x003B5535 File Offset: 0x003B3735
		// (set) Token: 0x06019ECF RID: 106191 RVA: 0x003B553D File Offset: 0x003B373D
		public object Value { get; set; }

		// Token: 0x06019ED0 RID: 106192 RVA: 0x003B5546 File Offset: 0x003B3746
		public TMatchRoleOptionUnion()
		{
			this.Type = TMatchRoleOption.NONE;
			this.Value = null;
		}

		// Token: 0x06019ED1 RID: 106193 RVA: 0x003B555C File Offset: 0x003B375C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06019ED2 RID: 106194 RVA: 0x003B556E File Offset: 0x003B376E
		public IMatchPhantomRoleT AsIMatchPhantomRole()
		{
			return this.As<IMatchPhantomRoleT>();
		}

		// Token: 0x06019ED3 RID: 106195 RVA: 0x003B5576 File Offset: 0x003B3776
		public static TMatchRoleOptionUnion FromIMatchPhantomRole(IMatchPhantomRoleT _imatchphantomrole)
		{
			return new TMatchRoleOptionUnion
			{
				Type = TMatchRoleOption.IMatchPhantomRole,
				Value = _imatchphantomrole
			};
		}

		// Token: 0x06019ED4 RID: 106196 RVA: 0x003B558B File Offset: 0x003B378B
		public IMatchPlayerRoleT AsIMatchPlayerRole()
		{
			return this.As<IMatchPlayerRoleT>();
		}

		// Token: 0x06019ED5 RID: 106197 RVA: 0x003B5593 File Offset: 0x003B3793
		public static TMatchRoleOptionUnion FromIMatchPlayerRole(IMatchPlayerRoleT _imatchplayerrole)
		{
			return new TMatchRoleOptionUnion
			{
				Type = TMatchRoleOption.IMatchPlayerRole,
				Value = _imatchplayerrole
			};
		}

		// Token: 0x06019ED6 RID: 106198 RVA: 0x003B55A8 File Offset: 0x003B37A8
		public static int Pack(FlatBufferBuilder builder, TMatchRoleOptionUnion _o)
		{
			TMatchRoleOption type = _o.Type;
			if (type == TMatchRoleOption.IMatchPhantomRole)
			{
				return IMatchPhantomRole.Pack(builder, _o.AsIMatchPhantomRole()).Value;
			}
			if (type != TMatchRoleOption.IMatchPlayerRole)
			{
				return 0;
			}
			return IMatchPlayerRole.Pack(builder, _o.AsIMatchPlayerRole()).Value;
		}
	}
}
