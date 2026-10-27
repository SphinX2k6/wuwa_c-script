using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200256E RID: 9582
	public class IVisualNovelDisplayItemPrefab : IVisualNovelDisplayItemBase
	{
		// Token: 0x0600D70C RID: 55052 RVA: 0x00200A60 File Offset: 0x001FEC60
		[NullableContext(1)]
		public static IVisualNovelDisplayItemPrefab Create(IVisualNovelDisplayItemPrefab? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelDisplayItemPrefab
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003DF2 RID: 15858
		// (get) Token: 0x0600D70D RID: 55053 RVA: 0x00200A7F File Offset: 0x001FEC7F
		public override EVisualNovelDisplayItemType Type
		{
			get
			{
				return (EVisualNovelDisplayItemType)this.Instance.Type;
			}
		}

		// Token: 0x17003DF3 RID: 15859
		// (get) Token: 0x0600D70E RID: 55054 RVA: 0x00200A8C File Offset: 0x001FEC8C
		public virtual int PrefabId
		{
			get
			{
				return this.Instance.PrefabId;
			}
		}

		// Token: 0x04007710 RID: 30480
		private IVisualNovelDisplayItemPrefab Instance;
	}
}
