using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02003FD0 RID: 16336
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotTextReplacer
	{
		// Token: 0x0602957F RID: 169343 RVA: 0x00BA3C08 File Offset: 0x00BA1E08
		public void Init()
		{
			if (this.IsInit)
			{
				return;
			}
			this.IsMale = (PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male);
			this.PlayerName = FunctionModel.Instance.GetPlayerName();
			this.ThirdPerson = (this.IsMale ? TextConfig.Instance.GetTextById("He") : TextConfig.Instance.GetTextById("She"));
			this.IsInit = true;
		}

		// Token: 0x06029580 RID: 169344 RVA: 0x00BA3C76 File Offset: 0x00BA1E76
		public void Clear()
		{
			this.IsInit = false;
		}

		// Token: 0x06029581 RID: 169345 RVA: 0x00BA3C7F File Offset: 0x00BA1E7F
		[NullableContext(2)]
		public string Replace(string text, bool needClear = false)
		{
			if (text == null)
			{
				return null;
			}
			if (needClear)
			{
				this.Clear();
			}
			this.Init();
			return this.Pattern.Replace(text, new MatchEvaluator(this.Replacer));
		}

		// Token: 0x06029582 RID: 169346 RVA: 0x00BA3CB0 File Offset: 0x00BA1EB0
		private string Replacer(Match match)
		{
			string value = match.Value;
			GroupCollection groups = match.Groups;
			if (groups.Count >= 3 && !string.IsNullOrEmpty(groups[1].Value) && !string.IsNullOrEmpty(groups[2].Value))
			{
				if (!this.IsMale)
				{
					return groups[2].Value;
				}
				return groups[1].Value;
			}
			else
			{
				if (value == "{TA}")
				{
					return this.ThirdPerson;
				}
				if (value == "{PlayerName}")
				{
					return this.PlayerName;
				}
				return value;
			}
		}

		// Token: 0x040168B9 RID: 92345
		private const string TA = "{TA}";

		// Token: 0x040168BA RID: 92346
		private const string PLAYER_NAME = "{PlayerName}";

		// Token: 0x040168BB RID: 92347
		private bool IsInit;

		// Token: 0x040168BC RID: 92348
		private bool IsMale;

		// Token: 0x040168BD RID: 92349
		private string PlayerName = "";

		// Token: 0x040168BE RID: 92350
		private string ThirdPerson = "";

		// Token: 0x040168BF RID: 92351
		private readonly Regex Pattern = new Regex("\\{(?:Male=(.*?);Female=(.*?)|TA|PlayerName)\\}");
	}
}
