using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D5A RID: 3418
	[NullableContext(2)]
	[Nullable(0)]
	public class IGroupAiMonsterMember
	{
		// Token: 0x06004DE3 RID: 19939 RVA: 0x000C18B6 File Offset: 0x000BFAB6
		[NullableContext(1)]
		public static IGroupAiMonsterMember Create(IGroupAiMonsterMember? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGroupAiMonsterMember
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170018EC RID: 6380
		// (get) Token: 0x06004DE4 RID: 19940 RVA: 0x000C18D5 File Offset: 0x000BFAD5
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x170018ED RID: 6381
		// (get) Token: 0x06004DE5 RID: 19941 RVA: 0x000C18E2 File Offset: 0x000BFAE2
		[Nullable(1)]
		public virtual PosAndRot RelativeTransform
		{
			[NullableContext(1)]
			get
			{
				if (this._RelativeTransformInited)
				{
					return this._RelativeTransformCache;
				}
				this._RelativeTransformInited = true;
				this._RelativeTransformCache = PosAndRot.Create(this.Instance.RelativeTransform);
				return this._RelativeTransformCache;
			}
		}

		// Token: 0x170018EE RID: 6382
		// (get) Token: 0x06004DE6 RID: 19942 RVA: 0x000C1916 File Offset: 0x000BFB16
		public virtual IGroupAiMonsterMemberActionTagAttach ActionTagAttach
		{
			get
			{
				if (this._ActionTagAttachInited)
				{
					return this._ActionTagAttachCache;
				}
				this._ActionTagAttachInited = true;
				this._ActionTagAttachCache = IGroupAiMonsterMemberActionTagAttach.Create(this.Instance.ActionTagAttach);
				return this._ActionTagAttachCache;
			}
		}

		// Token: 0x04002CA1 RID: 11425
		private IGroupAiMonsterMember Instance;

		// Token: 0x04002CA2 RID: 11426
		private PosAndRot _RelativeTransformCache;

		// Token: 0x04002CA3 RID: 11427
		private bool _RelativeTransformInited;

		// Token: 0x04002CA4 RID: 11428
		private IGroupAiMonsterMemberActionTagAttach _ActionTagAttachCache;

		// Token: 0x04002CA5 RID: 11429
		private bool _ActionTagAttachInited;
	}
}
