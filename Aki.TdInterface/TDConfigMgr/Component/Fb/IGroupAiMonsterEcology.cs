using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E55 RID: 3669
	public class IGroupAiMonsterEcology : IGroupAiMode
	{
		// Token: 0x06005304 RID: 21252 RVA: 0x000CD096 File Offset: 0x000CB296
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

		// Token: 0x17001A55 RID: 6741
		// (get) Token: 0x06005305 RID: 21253 RVA: 0x000CD0B5 File Offset: 0x000CB2B5
		public override EGroupAiMode Type
		{
			get
			{
				return (EGroupAiMode)this.Instance.Type;
			}
		}

		// Token: 0x17001A56 RID: 6742
		// (get) Token: 0x06005306 RID: 21254 RVA: 0x000CD0C2 File Offset: 0x000CB2C2
		public virtual int Leader
		{
			get
			{
				return this.Instance.Leader;
			}
		}

		// Token: 0x17001A57 RID: 6743
		// (get) Token: 0x06005307 RID: 21255 RVA: 0x000CD0D0 File Offset: 0x000CB2D0
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

		// Token: 0x04002F66 RID: 12134
		private IGroupAiMonsterEcology Instance;

		// Token: 0x04002F67 RID: 12135
		private List<IGroupAiMonsterMember> _MembersCache;

		// Token: 0x04002F68 RID: 12136
		private bool _MembersInited;
	}
}
