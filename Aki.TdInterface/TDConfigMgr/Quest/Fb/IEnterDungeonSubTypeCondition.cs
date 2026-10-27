using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200138A RID: 5002
	public class IEnterDungeonSubTypeCondition : IEnterDungeon
	{
		// Token: 0x0600726F RID: 29295 RVA: 0x00113391 File Offset: 0x00111591
		[NullableContext(1)]
		public static IEnterDungeonSubTypeCondition Create(IEnterDungeonSubTypeCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnterDungeonSubTypeCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700252E RID: 9518
		// (get) Token: 0x06007270 RID: 29296 RVA: 0x001133B0 File Offset: 0x001115B0
		public override EDungeonConditionType Type
		{
			get
			{
				return (EDungeonConditionType)this.Instance.Type;
			}
		}

		// Token: 0x1700252F RID: 9519
		// (get) Token: 0x06007271 RID: 29297 RVA: 0x001133BD File Offset: 0x001115BD
		public virtual EDungeonSubType DungeonSubType
		{
			get
			{
				return (EDungeonSubType)this.Instance.DungeonSubType;
			}
		}

		// Token: 0x04004222 RID: 16930
		private IEnterDungeonSubTypeCondition Instance;
	}
}
