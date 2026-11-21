using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E54 RID: 3668
	public class IGroupAiMonsterMember
	{
		// Token: 0x060052FF RID: 21247 RVA: 0x000CCFFA File Offset: 0x000CB1FA
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

		// Token: 0x17001A52 RID: 6738
		// (get) Token: 0x06005300 RID: 21248 RVA: 0x000CD019 File Offset: 0x000CB219
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17001A53 RID: 6739
		// (get) Token: 0x06005301 RID: 21249 RVA: 0x000CD026 File Offset: 0x000CB226
		public virtual PosAndRot RelativeTransform
		{
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

		// Token: 0x17001A54 RID: 6740
		// (get) Token: 0x06005302 RID: 21250 RVA: 0x000CD05A File Offset: 0x000CB25A
		[Nullable(2)]
		public virtual IGroupAiMonsterMemberActionTagAttach ActionTagAttach
		{
			[NullableContext(2)]
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

		// Token: 0x04002F61 RID: 12129
		private IGroupAiMonsterMember Instance;

		// Token: 0x04002F62 RID: 12130
		[Nullable(2)]
		private PosAndRot _RelativeTransformCache;

		// Token: 0x04002F63 RID: 12131
		private bool _RelativeTransformInited;

		// Token: 0x04002F64 RID: 12132
		[Nullable(2)]
		private IGroupAiMonsterMemberActionTagAttach _ActionTagAttachCache;

		// Token: 0x04002F65 RID: 12133
		private bool _ActionTagAttachInited;
	}
}
