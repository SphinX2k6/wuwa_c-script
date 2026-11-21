using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Match
{
	// Token: 0x0200486C RID: 18540
	public class IMatchRoleType_UnionUnion
	{
		// Token: 0x17008119 RID: 33049
		// (get) Token: 0x0601B68B RID: 112267 RVA: 0x003E1555 File Offset: 0x003DF755
		// (set) Token: 0x0601B68C RID: 112268 RVA: 0x003E155D File Offset: 0x003DF75D
		public IMatchRoleType_Union Type { get; set; }

		// Token: 0x1700811A RID: 33050
		// (get) Token: 0x0601B68D RID: 112269 RVA: 0x003E1566 File Offset: 0x003DF766
		// (set) Token: 0x0601B68E RID: 112270 RVA: 0x003E156E File Offset: 0x003DF76E
		public object Value { get; set; }

		// Token: 0x0601B68F RID: 112271 RVA: 0x003E1577 File Offset: 0x003DF777
		public IMatchRoleType_UnionUnion()
		{
			this.Type = IMatchRoleType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601B690 RID: 112272 RVA: 0x003E158D File Offset: 0x003DF78D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601B691 RID: 112273 RVA: 0x003E159F File Offset: 0x003DF79F
		public IMatchRoleTypeT AsIMatchRoleType()
		{
			return this.As<IMatchRoleTypeT>();
		}

		// Token: 0x0601B692 RID: 112274 RVA: 0x003E15A7 File Offset: 0x003DF7A7
		public static IMatchRoleType_UnionUnion FromIMatchRoleType(IMatchRoleTypeT _imatchroletype)
		{
			return new IMatchRoleType_UnionUnion
			{
				Type = IMatchRoleType_Union.IMatchRoleType,
				Value = _imatchroletype
			};
		}

		// Token: 0x0601B693 RID: 112275 RVA: 0x003E15BC File Offset: 0x003DF7BC
		public IMatchPlayerRoleT AsIMatchPlayerRole()
		{
			return this.As<IMatchPlayerRoleT>();
		}

		// Token: 0x0601B694 RID: 112276 RVA: 0x003E15C4 File Offset: 0x003DF7C4
		public static IMatchRoleType_UnionUnion FromIMatchPlayerRole(IMatchPlayerRoleT _imatchplayerrole)
		{
			return new IMatchRoleType_UnionUnion
			{
				Type = IMatchRoleType_Union.IMatchPlayerRole,
				Value = _imatchplayerrole
			};
		}

		// Token: 0x0601B695 RID: 112277 RVA: 0x003E15D9 File Offset: 0x003DF7D9
		public IMatchPhantomRoleT AsIMatchPhantomRole()
		{
			return this.As<IMatchPhantomRoleT>();
		}

		// Token: 0x0601B696 RID: 112278 RVA: 0x003E15E1 File Offset: 0x003DF7E1
		public static IMatchRoleType_UnionUnion FromIMatchPhantomRole(IMatchPhantomRoleT _imatchphantomrole)
		{
			return new IMatchRoleType_UnionUnion
			{
				Type = IMatchRoleType_Union.IMatchPhantomRole,
				Value = _imatchphantomrole
			};
		}

		// Token: 0x0601B697 RID: 112279 RVA: 0x003E15F6 File Offset: 0x003DF7F6
		public IMatchAssistCharacterRoleT AsIMatchAssistCharacterRole()
		{
			return this.As<IMatchAssistCharacterRoleT>();
		}

		// Token: 0x0601B698 RID: 112280 RVA: 0x003E15FE File Offset: 0x003DF7FE
		public static IMatchRoleType_UnionUnion FromIMatchAssistCharacterRole(IMatchAssistCharacterRoleT _imatchassistcharacterrole)
		{
			return new IMatchRoleType_UnionUnion
			{
				Type = IMatchRoleType_Union.IMatchAssistCharacterRole,
				Value = _imatchassistcharacterrole
			};
		}

		// Token: 0x0601B699 RID: 112281 RVA: 0x003E1614 File Offset: 0x003DF814
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
			case IMatchRoleType_Union.IMatchAssistCharacterRole:
				return IMatchAssistCharacterRole.Pack(builder, _o.AsIMatchAssistCharacterRole()).Value;
			default:
				return 0;
			}
		}
	}
}
