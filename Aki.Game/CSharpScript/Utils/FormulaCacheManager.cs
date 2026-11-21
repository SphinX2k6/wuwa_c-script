using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x0200342A RID: 13354
	[NullableContext(1)]
	[Nullable(0)]
	public class FormulaCacheManager : IStaticVariableResetter
	{
		// Token: 0x06021EAA RID: 138922 RVA: 0x0096FB41 File Offset: 0x0096DD41
		static FormulaCacheManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FormulaCacheManager.CreateStaticDefaultValue), new Action(FormulaCacheManager.ResetStaticDefaultValue));
		}

		// Token: 0x06021EAB RID: 138923 RVA: 0x0096FB60 File Offset: 0x0096DD60
		public static void CreateStaticDefaultValue()
		{
			FormulaCacheManager.Cache = new Dictionary<string, CachedAstEntry>();
		}

		// Token: 0x06021EAC RID: 138924 RVA: 0x0096FB6C File Offset: 0x0096DD6C
		public static void ResetStaticDefaultValue()
		{
			FormulaCacheManager.Cache = null;
		}

		// Token: 0x06021EAD RID: 138925 RVA: 0x0096FB74 File Offset: 0x0096DD74
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

		// Token: 0x06021EAE RID: 138926 RVA: 0x0096FBDC File Offset: 0x0096DDDC
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

		// Token: 0x06021EAF RID: 138927 RVA: 0x0096FC1C File Offset: 0x0096DE1C
		public static int GetCacheSize()
		{
			return 0;
		}

		// Token: 0x06021EB0 RID: 138928 RVA: 0x0096FC1F File Offset: 0x0096DE1F
		public static int GetRefCount(string formulaStr)
		{
			return 0;
		}

		// Token: 0x04012B34 RID: 76596
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private static Dictionary<string, CachedAstEntry> Cache;
	}
}
