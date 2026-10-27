using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x02004508 RID: 17672
	[NullableContext(1)]
	[Nullable(0)]
	public class FormulaCacheManager : IStaticVariableResetter
	{
		// Token: 0x0602D7DA RID: 186330 RVA: 0x00A43D31 File Offset: 0x00A41F31
		static FormulaCacheManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FormulaCacheManager.CreateStaticDefaultValue), new Action(FormulaCacheManager.ResetStaticDefaultValue));
		}

		// Token: 0x0602D7DB RID: 186331 RVA: 0x00A43D50 File Offset: 0x00A41F50
		public static void CreateStaticDefaultValue()
		{
			FormulaCacheManager.Cache = new Dictionary<string, CachedAstEntry>();
		}

		// Token: 0x0602D7DC RID: 186332 RVA: 0x00A43D5C File Offset: 0x00A41F5C
		public static void ResetStaticDefaultValue()
		{
			FormulaCacheManager.Cache = null;
		}

		// Token: 0x0602D7DD RID: 186333 RVA: 0x00A43D64 File Offset: 0x00A41F64
		public static IAstNode Acquire(string formulaStr)
		{
			CachedAstEntry cachedAstEntry;
			if (FormulaCacheManager.Cache.TryGetValue(formulaStr, out cachedAstEntry))
			{
				cachedAstEntry.RefCount++;
				return cachedAstEntry.Ast;
			}
			IAstNode astNode = new Parser(new Lexer(formulaStr).Tokenize()).Parse(formulaStr);
			FormulaCacheManager.Cache[formulaStr] = new CachedAstEntry
			{
				Ast = astNode,
				RefCount = 1
			};
			return astNode;
		}

		// Token: 0x0602D7DE RID: 186334 RVA: 0x00A43DCC File Offset: 0x00A41FCC
		public static void Release(string formulaStr)
		{
			CachedAstEntry cachedAstEntry;
			if (!FormulaCacheManager.Cache.TryGetValue(formulaStr, out cachedAstEntry))
			{
				return;
			}
			cachedAstEntry.RefCount--;
			if (cachedAstEntry.RefCount <= 0)
			{
				FormulaCacheManager.Cache.Remove(formulaStr);
			}
		}

		// Token: 0x0602D7DF RID: 186335 RVA: 0x00A43E0C File Offset: 0x00A4200C
		public static int GetCacheSize()
		{
			return 0;
		}

		// Token: 0x0602D7E0 RID: 186336 RVA: 0x00A43E0F File Offset: 0x00A4200F
		public static int GetRefCount(string formulaStr)
		{
			return 0;
		}

		// Token: 0x0401850C RID: 99596
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private static Dictionary<string, CachedAstEntry> Cache;
	}
}
