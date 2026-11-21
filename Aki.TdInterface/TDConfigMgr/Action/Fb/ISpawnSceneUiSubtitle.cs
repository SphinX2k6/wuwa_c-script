using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200288B RID: 10379
	public class ISpawnSceneUiSubtitle : ISceneUiSubtitleOperationBase
	{
		// Token: 0x0600E749 RID: 59209 RVA: 0x00223688 File Offset: 0x00221888
		public static ISpawnSceneUiSubtitle Create(ISpawnSceneUiSubtitle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpawnSceneUiSubtitle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042E1 RID: 17121
		// (get) Token: 0x0600E74A RID: 59210 RVA: 0x002236A7 File Offset: 0x002218A7
		public override ESceneUiSubtitleOperationType Type
		{
			get
			{
				return (ESceneUiSubtitleOperationType)this.Instance.Type;
			}
		}

		// Token: 0x170042E2 RID: 17122
		// (get) Token: 0x0600E74B RID: 59211 RVA: 0x002236B4 File Offset: 0x002218B4
		public virtual string Mark
		{
			get
			{
				return this.Instance.Mark;
			}
		}

		// Token: 0x170042E3 RID: 17123
		// (get) Token: 0x0600E74C RID: 59212 RVA: 0x002236C1 File Offset: 0x002218C1
		public virtual ISceneUiSubtitleStyleBase Style
		{
			get
			{
				if (this._StyleInited)
				{
					return this._StyleCache;
				}
				this._StyleInited = true;
				this._StyleCache = ActionReadHelper.ReadISpawnSceneUiSubtitle_Style(this.Instance);
				return this._StyleCache;
			}
		}

		// Token: 0x170042E4 RID: 17124
		// (get) Token: 0x0600E74D RID: 59213 RVA: 0x002236F0 File Offset: 0x002218F0
		public virtual ISceneUiSubtitleTextBase Text
		{
			get
			{
				if (this._TextInited)
				{
					return this._TextCache;
				}
				this._TextInited = true;
				this._TextCache = ActionReadHelper.ReadISpawnSceneUiSubtitle_Text(this.Instance);
				return this._TextCache;
			}
		}

		// Token: 0x170042E5 RID: 17125
		// (get) Token: 0x0600E74E RID: 59214 RVA: 0x00223720 File Offset: 0x00221920
		public virtual bool? RemoveAfterPlay
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.RemoveAfterPlay);
			}
		}

		// Token: 0x04007F5B RID: 32603
		private ISpawnSceneUiSubtitle Instance;

		// Token: 0x04007F5C RID: 32604
		private ISceneUiSubtitleStyleBase _StyleCache;

		// Token: 0x04007F5D RID: 32605
		private bool _StyleInited;

		// Token: 0x04007F5E RID: 32606
		private ISceneUiSubtitleTextBase _TextCache;

		// Token: 0x04007F5F RID: 32607
		private bool _TextInited;
	}
}
