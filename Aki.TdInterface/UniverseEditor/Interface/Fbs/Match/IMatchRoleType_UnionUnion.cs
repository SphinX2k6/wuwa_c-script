using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Match
{
	// Token: 0x02004404 RID: 17412
	public class IMatchRoleType_UnionUnion
	{
		// Token: 0x17007ADA RID: 31450
		// (get) Token: 0x06019EBE RID: 106174 RVA: 0x003B53D9 File Offset: 0x003B35D9
		// (set) Token: 0x06019EBF RID: 106175 RVA: 0x003B53E1 File Offset: 0x003B35E1
		public IMatchRoleType_Union Type { get; set; }

		// Token: 0x17007ADB RID: 31451
		// (get) Token: 0x06019EC0 RID: 106176 RVA: 0x003B53EA File Offset: 0x003B35EA
		// (set) Token: 0x06019EC1 RID: 106177 RVA: 0x003B53F2 File Offset: 0x003B35F2
		public object Value { get; set; }

		// Token: 0x06019EC2 RID: 106178 RVA: 0x003B53FB File Offset: 0x003B35FB
		public IMatchRoleType_UnionUnion()
		{
			this.Type = IMatchRoleType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06019EC3 RID: 106179 RVA: 0x003B5411 File Offset: 0x003B3611
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06019EC4 RID: 106180 RVA: 0x003B5423 File Offset: 0x003B3623
		public IMatchRoleTypeT AsIMatchRoleType()
		{
			return this.As<IMatchRoleTypeT>();
		}

		// Token: 0x06019EC5 RID: 106181 RVA: 0x003B542B File Offset: 0x003B362B
		public static IMatchRoleType_UnionUnion FromIMatchRoleType(IMatchRoleTypeT _imatchroletype)
		{
			return new IMatchRoleType_UnionUnion
			{
				Type = IMatchRoleType_Union.IMatchRoleType,
				Value = _imatchroletype
			};
		}

		// Token: 0x06019EC6 RID: 106182 RVA: 0x003B5440 File Offset: 0x003B3640
		public IMatchPlayerRoleT AsIMatchPlayerRole()
		{
			return this.As<IMatchPlayerRoleT>();
		}

		// Token: 0x06019EC7 RID: 106183 RVA: 0x003B5448 File Offset: 0x003B3648
		public static IMatchRoleType_UnionUnion FromIMatchPlayerRole(IMatchPlayerRoleT _imatchplayerrole)
		{
			return new IMatchRoleType_UnionUnion
			{
				Type = IMatchRoleType_Union.IMatchPlayerRole,
				Value = _imatchplayerrole
			};
		}

		// Token: 0x06019EC8 RID: 106184 RVA: 0x003B545D File Offset: 0x003B365D
		public IMatchPhantomRoleT AsIMatchPhantomRole()
		{
			return this.As<IMatchPhantomRoleT>();
		}

		// Token: 0x06019EC9 RID: 106185 RVA: 0x003B5465 File Offset: 0x003B3665
		public static IMatchRoleType_UnionUnion FromIMatchPhantomRole(IMatchPhantomRoleT _imatchphantomrole)
		{
			return new IMatchRoleType_UnionUnion
			{
				Type = IMatchRoleType_Union.IMatchPhantomRole,
				Value = _imatchphantomrole
			};
		}

		// Token: 0x06019ECA RID: 106186 RVA: 0x003B547C File Offset: 0x003B367C
		public static int Pack(FlatBufferBuilder builder, IMatchRoleType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IMatchRoleType_Union.IMatchRoleType:
				return IMatchRoleType.Pack(builder, _o.AsIMatchRoleType()).Value;
			case IMatchRoleType_Union.IMatchPlayerRole:
				return IMatchPlayerRole.Pack(builder, _o.AsIMatchPlayerRole()).Value;
			case IMatchRoleType_Union.IMatchPhantomRole:
				return IMatchPhantomRole.Pack(builder, _o.AsIMatchPhantomRole()).Value;
			default:
				return 0;
			}
		}
	}
}
