using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020D0 RID: 8400
	public class ISpawnSceneUiSubtitle : ISceneUiSubtitleOperationBase
	{
		// Token: 0x0600B256 RID: 45654 RVA: 0x00190918 File Offset: 0x0018EB18
		private ISpawnSceneUiSubtitle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISpawnSceneUiSubtitle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISpawnSceneUiSubtitle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISpawnSceneUiSubtitle_SetValue());
			}
			return result;
		}

		// Token: 0x0600B257 RID: 45655 RVA: 0x00190950 File Offset: 0x0018EB50
		public static ISpawnSceneUiSubtitle Create([Nullable(2)] ISpawnSceneUiSubtitle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpawnSceneUiSubtitle
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B258 RID: 45656 RVA: 0x00190963 File Offset: 0x0018EB63
		public static ISpawnSceneUiSubtitle CreateFromSetValue([Nullable(2)] ISpawnSceneUiSubtitle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISpawnSceneUiSubtitle
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B259 RID: 45657 RVA: 0x00190978 File Offset: 0x0018EB78
		public new ISpawnSceneUiSubtitle_SetValue ToSetValue()
		{
			return new ISpawnSceneUiSubtitle_SetValue
			{
				Type = this.Type,
				Mark = this.Mark,
				Style = this.Style,
				Text = this.Text,
				RemoveAfterPlay = this.RemoveAfterPlay
			};
		}

		// Token: 0x17003602 RID: 13826
		// (get) Token: 0x0600B25A RID: 45658 RVA: 0x001909C6 File Offset: 0x0018EBC6
		// (set) Token: 0x0600B25B RID: 45659 RVA: 0x001909F1 File Offset: 0x0018EBF1
		public override ESceneUiSubtitleOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESceneUiSubtitleOperationType.Spawn;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003603 RID: 13827
		// (get) Token: 0x0600B25C RID: 45660 RVA: 0x001909FF File Offset: 0x0018EBFF
		// (set) Token: 0x0600B25D RID: 45661 RVA: 0x00190A2A File Offset: 0x0018EC2A
		public virtual string Mark
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Mark;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Mark;
			}
			set
			{
				this.GetOrCreatePoco().Mark = value;
			}
		}

		// Token: 0x17003604 RID: 13828
		// (get) Token: 0x0600B25E RID: 45662 RVA: 0x00190A38 File Offset: 0x0018EC38
		// (set) Token: 0x0600B25F RID: 45663 RVA: 0x00190A5F File Offset: 0x0018EC5F
		public virtual ISceneUiSubtitleStyleBase Style
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Style;
				}
				ISpawnSceneUiSubtitle_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Style;
			}
			set
			{
				this.GetOrCreatePoco().Style = value;
			}
		}

		// Token: 0x17003605 RID: 13829
		// (get) Token: 0x0600B260 RID: 45664 RVA: 0x00190A6D File Offset: 0x0018EC6D
		// (set) Token: 0x0600B261 RID: 45665 RVA: 0x00190A94 File Offset: 0x0018EC94
		public virtual ISceneUiSubtitleTextBase Text
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Text;
				}
				ISpawnSceneUiSubtitle_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Text;
			}
			set
			{
				this.GetOrCreatePoco().Text = value;
			}
		}

		// Token: 0x17003606 RID: 13830
		// (get) Token: 0x0600B262 RID: 45666 RVA: 0x00190AA4 File Offset: 0x0018ECA4
		// (set) Token: 0x0600B263 RID: 45667 RVA: 0x00190ADE File Offset: 0x0018ECDE
		public virtual bool? RemoveAfterPlay
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RemoveAfterPlay;
				}
				ISpawnSceneUiSubtitle_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RemoveAfterPlay;
			}
			set
			{
				this.GetOrCreatePoco().RemoveAfterPlay = value;
			}
		}

		// Token: 0x040069D9 RID: 27097
		[Nullable(2)]
		protected new ISpawnSceneUiSubtitle FbInstance;

		// Token: 0x040069DA RID: 27098
		[Nullable(2)]
		protected new ISpawnSceneUiSubtitle_SetValue PocoInterface;
	}
}
