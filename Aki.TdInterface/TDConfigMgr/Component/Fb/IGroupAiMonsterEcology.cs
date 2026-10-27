using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D5B RID: 3419
	[NullableContext(1)]
	[Nullable(0)]
	public class IGroupAiMonsterEcology : IGroupAiMode
	{
		// Token: 0x06004DE8 RID: 19944 RVA: 0x000C1952 File Offset: 0x000BFB52
		public static IGroupAiMonsterEcology Create(IGroupAiMonsterEcology? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGroupAiMonsterEcology
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170018EF RID: 6383
		// (get) Token: 0x06004DE9 RID: 19945 RVA: 0x000C1971 File Offset: 0x000BFB71
		public override EGroupAiMode Type
		{
			get
			{
				return (EGroupAiMode)this.Instance.Type;
			}
		}

		// Token: 0x170018F0 RID: 6384
		// (get) Token: 0x06004DEA RID: 19946 RVA: 0x000C197E File Offset: 0x000BFB7E
		public virtual int Leader
		{
			get
			{
				return this.Instance.Leader;
			}
		}

		// Token: 0x170018F1 RID: 6385
		// (get) Token: 0x06004DEB RID: 19947 RVA: 0x000C198C File Offset: 0x000BFB8C
		public virtual List<IGroupAiMonsterMember> Members
		{
			get
			{
				if (this._MembersInited)
				{
					return this._MembersCache;
				}
				this._MembersInited = true;
				int membersLength = this.Instance.MembersLength;
				this._MembersCache = new List<IGroupAiMonsterMember>(membersLength);
				for (int i = 0; i < membersLength; i++)
				{
					this._MembersCache.Add(IGroupAiMonsterMember.Create(this.Instance.Members(i)));
				}
				return this._MembersCache;
			}
		}

		// Token: 0x04002CA6 RID: 11430
		private IGroupAiMonsterEcology Instance;

		// Token: 0x04002CA7 RID: 11431
		private List<IGroupAiMonsterMember> _MembersCache;

		// Token: 0x04002CA8 RID: 11432
		private bool _MembersInited;
	}
}
