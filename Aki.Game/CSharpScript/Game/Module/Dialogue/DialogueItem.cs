using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Dialogue
{
	// Token: 0x02004A9D RID: 19101
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class DialogueItem
	{
		// Token: 0x17005FF2 RID: 24562
		// (get) Token: 0x0602FCBF RID: 195775 RVA: 0x00D55F1C File Offset: 0x00D5411C
		public int Index { get; }

		// Token: 0x17005FF3 RID: 24563
		// (get) Token: 0x0602FCC0 RID: 195776 RVA: 0x00D55F24 File Offset: 0x00D54124
		public ITalkItem Config { get; }

		// Token: 0x17005FF4 RID: 24564
		// (get) Token: 0x0602FCC1 RID: 195777 RVA: 0x00D55F2C File Offset: 0x00D5412C
		public int Id
		{
			get
			{
				return this.Config.Id;
			}
		}

		// Token: 0x17005FF5 RID: 24565
		// (get) Token: 0x0602FCC2 RID: 195778 RVA: 0x00D55F39 File Offset: 0x00D54139
		public DialogueJump? Jump { get; }

		// Token: 0x17005FF6 RID: 24566
		// (get) Token: 0x0602FCC3 RID: 195779 RVA: 0x00D55F41 File Offset: 0x00D54141
		public IReadOnlyList<DialogueOption> Options { get; }

		// Token: 0x0602FCC4 RID: 195780 RVA: 0x00D55F49 File Offset: 0x00D54149
		public DialogueItem(int index, ITalkItem config)
		{
			this.Index = index;
			this.Config = config;
			this.Jump = DialogueJump.From(config.Actions);
			this.Options = DialogueItem.CreateOptions(config.Options);
		}

		// Token: 0x0602FCC5 RID: 195781 RVA: 0x00D55F84 File Offset: 0x00D54184
		private static IReadOnlyList<DialogueOption> CreateOptions([Nullable(new byte[]
		{
			2,
			1
		})] IReadOnlyList<ITalkOption> configs)
		{
			if (configs == null || configs.Count == 0)
			{
				return Array.Empty<DialogueOption>();
			}
			List<DialogueOption> list = new List<DialogueOption>(configs.Count);
			for (int i = 0; i < configs.Count; i++)
			{
				ITalkOption talkOption = configs[i];
				if (talkOption != null)
				{
					list.Add(new DialogueOption(i, talkOption));
				}
			}
			return list;
		}
	}
}
