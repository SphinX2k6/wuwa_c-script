using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02005006 RID: 20486
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotTextReplacer
	{
		// Token: 0x060346DC RID: 214748 RVA: 0x00C58708 File Offset: 0x00C56908
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

		// Token: 0x060346DD RID: 214749 RVA: 0x00C58776 File Offset: 0x00C56976
		public void Clear()
		{
			this.IsInit = false;
		}

		// Token: 0x060346DE RID: 214750 RVA: 0x00C5877F File Offset: 0x00C5697F
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

		// Token: 0x060346DF RID: 214751 RVA: 0x00C587B0 File Offset: 0x00C569B0
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

		// Token: 0x0401BED0 RID: 114384
		private const string TA = "{TA}";

		// Token: 0x0401BED1 RID: 114385
		private const string PLAYER_NAME = "{PlayerName}";

		// Token: 0x0401BED2 RID: 114386
		private bool IsInit;

		// Token: 0x0401BED3 RID: 114387
		private bool IsMale;

		// Token: 0x0401BED4 RID: 114388
		private string PlayerName = "";

		// Token: 0x0401BED5 RID: 114389
		private string ThirdPerson = "";

		// Token: 0x0401BED6 RID: 114390
		private readonly Regex Pattern = new Regex("\\{(?:Male=(.*?);Female=(.*?)|TA|PlayerName)\\}");
	}
}
