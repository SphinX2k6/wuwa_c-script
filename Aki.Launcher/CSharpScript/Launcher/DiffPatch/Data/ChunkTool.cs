using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x02000224 RID: 548
	[NullableContext(1)]
	[Nullable(0)]
	public class ChunkTool
	{
		// Token: 0x06000E0C RID: 3596 RVA: 0x00054C68 File Offset: 0x00052E68
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

		// Token: 0x06000E0D RID: 3597 RVA: 0x00054CC0 File Offset: 0x00052EC0
		public static bool IsChunk0or1(string file)
		{
			string a = ChunkTool.ExtractChunkNumber(file);
			return a == "0" || a == "1";
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x00054CF0 File Offset: 0x00052EF0
		public static bool IsRestartRequiredAfterHotPatchChunk(string file)
		{
			string a = ChunkTool.ExtractChunkNumber(file);
			return a == "0" || a == "1";
		}

		// Token: 0x040008D0 RID: 2256
		public const string Pak18NameMarker = "pakchunk18";

		// Token: 0x040008D1 RID: 2257
		[Nullable(2)]
		[StaticVariableRuleIgnore]
		private static Regex pakchunkRegex;
	}
}
