using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x02000229 RID: 553
	[NullableContext(1)]
	[Nullable(0)]
	public class ChunkTool
	{
		// Token: 0x06000E4D RID: 3661 RVA: 0x0005775C File Offset: 0x0005595C
		private static string ExtractChunkNumber(string input)
		{
			if (ChunkTool.pakchunkRegex == null)
			{
				ChunkTool.pakchunkRegex = new Regex("pakchunk(\\d+)");
			}
			MatchCollection matchCollection = ChunkTool.pakchunkRegex.Matches(input);
			if (matchCollection.Count <= 0)
			{
				return "";
			}
			return matchCollection[0].Groups[1].Value;
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x000577B4 File Offset: 0x000559B4
		public static bool IsChunk0or1(string file)
		{
			string a = ChunkTool.ExtractChunkNumber(file);
			return a == "0" || a == "1";
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x000577E4 File Offset: 0x000559E4
		public static bool IsRestartRequiredAfterHotPatchChunk(string file)
		{
			string a = ChunkTool.ExtractChunkNumber(file);
			return a == "0" || a == "1";
		}

		// Token: 0x04000911 RID: 2321
		public const string Pak18NameMarker = "pakchunk18";

		// Token: 0x04000912 RID: 2322
		[Nullable(2)]
		[StaticVariableRuleIgnore]
		private static Regex pakchunkRegex;
	}
}
