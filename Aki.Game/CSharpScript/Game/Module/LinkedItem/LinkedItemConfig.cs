using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.LinkedItem
{
	// Token: 0x02004690 RID: 18064
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class LinkedItemConfig : ConfigBase
	{
		// Token: 0x0602D685 RID: 185989 RVA: 0x00CB65A4 File Offset: 0x00CB47A4
		protected override bool OnClear()
		{
			this.LinkedItemSet = null;
			return true;
		}

		// Token: 0x0602D686 RID: 185990 RVA: 0x00CB65B0 File Offset: 0x00CB47B0
		public bool IsLinkedItem(int itemId)
		{
			if (this.LinkedItemSet == null)
			{
				this.LinkedItemSet = new HashSet<int>();
				IReadOnlyList<CollaborativeContent> configList = ConfigCollaborativeContentAll.GetConfigList(true);
				if (configList != null)
				{
					foreach (CollaborativeContent collaborativeContent in configList)
					{
						this.LinkedItemSet.Add(collaborativeContent.Id);
					}
				}
			}
			return this.LinkedItemSet.Contains(itemId);
		}

		// Token: 0x0602D687 RID: 185991 RVA: 0x00CB6630 File Offset: 0x00CB4830
		public bool ShouldHide(int itemId, bool isUnlocked)
		{
			return this.IsLinkedItem(itemId) && !isUnlocked;
		}

		// Token: 0x17005B58 RID: 23384
		// (get) Token: 0x0602D688 RID: 185992 RVA: 0x00CB6641 File Offset: 0x00CB4841
		public static LinkedItemConfig Instance
		{
			get
			{
				return LinkedItemConfig._Instance;
			}
		}

		// Token: 0x0602D689 RID: 185993 RVA: 0x00CB6648 File Offset: 0x00CB4848
		public static LinkedItemConfig GetOrCreateInstance()
		{
			if (LinkedItemConfig._Instance == null)
			{
				LinkedItemConfig.CreateInstance();
			}
			return LinkedItemConfig._Instance;
		}

		// Token: 0x0602D68A RID: 185994 RVA: 0x00CB665C File Offset: 0x00CB485C
		public static bool CreateInstance()
		{
			if (LinkedItemConfig._Instance != null)
			{
				return true;
			}
			LinkedItemConfig._Instance = new LinkedItemConfig();
			return true;
		}

		// Token: 0x0602D68B RID: 185995 RVA: 0x00CB6672 File Offset: 0x00CB4872
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602D68C RID: 185996 RVA: 0x00CB6674 File Offset: 0x00CB4874
		public static void ResetStaticDefaultValue()
		{
			LinkedItemConfig._Instance = null;
		}

		// Token: 0x0602D68D RID: 185997 RVA: 0x00CB667C File Offset: 0x00CB487C
		static LinkedItemConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LinkedItemConfig.CreateStaticDefaultValue), new Action(LinkedItemConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04018509 RID: 99593
		[Nullable(2)]
		private HashSet<int> LinkedItemSet;

		// Token: 0x0401850A RID: 99594
		[Nullable(2)]
		private static LinkedItemConfig _Instance;
	}
}
