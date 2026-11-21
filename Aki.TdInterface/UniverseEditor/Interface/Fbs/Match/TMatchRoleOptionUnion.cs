using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Match
{
	// Token: 0x0200486F RID: 18543
	public class TMatchRoleOptionUnion
	{
		// Token: 0x1700811B RID: 33051
		// (get) Token: 0x0601B69B RID: 112283 RVA: 0x003E16E2 File Offset: 0x003DF8E2
		// (set) Token: 0x0601B69C RID: 112284 RVA: 0x003E16EA File Offset: 0x003DF8EA
		public TMatchRoleOption Type { get; set; }

		// Token: 0x1700811C RID: 33052
		// (get) Token: 0x0601B69D RID: 112285 RVA: 0x003E16F3 File Offset: 0x003DF8F3
		// (set) Token: 0x0601B69E RID: 112286 RVA: 0x003E16FB File Offset: 0x003DF8FB
		public object Value { get; set; }

		// Token: 0x0601B69F RID: 112287 RVA: 0x003E1704 File Offset: 0x003DF904
		public TMatchRoleOptionUnion()
		{
			this.Type = TMatchRoleOption.NONE;
			this.Value = null;
		}

		// Token: 0x0601B6A0 RID: 112288 RVA: 0x003E171A File Offset: 0x003DF91A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601B6A1 RID: 112289 RVA: 0x003E172C File Offset: 0x003DF92C
		public IMatchAssistCharacterRoleT AsIMatchAssistCharacterRole()
		{
			return this.As<IMatchAssistCharacterRoleT>();
		}

		// Token: 0x0601B6A2 RID: 112290 RVA: 0x003E1734 File Offset: 0x003DF934
		public static TMatchRoleOptionUnion FromIMatchAssistCharacterRole(IMatchAssistCharacterRoleT _imatchassistcharacterrole)
		{
			return new TMatchRoleOptionUnion
			{
				Type = TMatchRoleOption.IMatchAssistCharacterRole,
				Value = _imatchassistcharacterrole
			};
		}

		// Token: 0x0601B6A3 RID: 112291 RVA: 0x003E1749 File Offset: 0x003DF949
		public IMatchPhantomRoleT AsIMatchPhantomRole()
		{
			return this.As<IMatchPhantomRoleT>();
		}

		// Token: 0x0601B6A4 RID: 112292 RVA: 0x003E1751 File Offset: 0x003DF951
		public static TMatchRoleOptionUnion FromIMatchPhantomRole(IMatchPhantomRoleT _imatchphantomrole)
		{
			return new TMatchRoleOptionUnion
			{
				Type = TMatchRoleOption.IMatchPhantomRole,
				Value = _imatchphantomrole
			};
		}

		// Token: 0x0601B6A5 RID: 112293 RVA: 0x003E1766 File Offset: 0x003DF966
		public IMatchPlayerRoleT AsIMatchPlayerRole()
		{
			return this.As<IMatchPlayerRoleT>();
		}

		// Token: 0x0601B6A6 RID: 112294 RVA: 0x003E176E File Offset: 0x003DF96E
		public static TMatchRoleOptionUnion FromIMatchPlayerRole(IMatchPlayerRoleT _imatchplayerrole)
		{
			return new TMatchRoleOptionUnion
			{
				Type = TMatchRoleOption.IMatchPlayerRole,
				Value = _imatchplayerrole
			};
		}

		// Token: 0x0601B6A7 RID: 112295 RVA: 0x003E1784 File Offset: 0x003DF984
		public static int Pack(FlatBufferBuilder builder, TMatchRoleOptionUnion _o)
		{
			switch (_o.Type)
			{
			case TMatchRoleOption.IMatchAssistCharacterRole:
				return IMatchAssistCharacterRole.Pack(builder, _o.AsIMatchAssistCharacterRole()).Value;
			case TMatchRoleOption.IMatchPhantomRole:
				return IMatchPhantomRole.Pack(builder, _o.AsIMatchPhantomRole()).Value;
			case TMatchRoleOption.IMatchPlayerRole:
				return IMatchPlayerRole.Pack(builder, _o.AsIMatchPlayerRole()).Value;
			default:
				return 0;
			}
		}
	}
}
