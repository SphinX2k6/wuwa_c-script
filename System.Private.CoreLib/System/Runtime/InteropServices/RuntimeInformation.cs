using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005ED RID: 1517
	[NullableContext(1)]
	[Nullable(0)]
	public static class RuntimeInformation
	{
		// Token: 0x17000DF5 RID: 3573
		// (get) Token: 0x0600716B RID: 29035 RVA: 0x0010FF7D File Offset: 0x0010E17D
		public static string RuntimeIdentifier
		{
			get
			{
				string result;
				if ((result = RuntimeInformation.s_runtimeIdentifier) == null)
				{
					result = (RuntimeInformation.s_runtimeIdentifier = ((AppContext.GetData("RUNTIME_IDENTIFIER") as string) ?? "unknown"));
				}
				return result;
			}
		}

		// Token: 0x0600716C RID: 29036 RVA: 0x0010FFA6 File Offset: 0x0010E1A6
		public static bool IsOSPlatform(OSPlatform osPlatform)
		{
			return OperatingSystem.IsOSPlatform(osPlatform.Name);
		}

		// Token: 0x17000DF6 RID: 3574
		// (get) Token: 0x0600716D RID: 29037 RVA: 0x000070DD File Offset: 0x000052DD
		public static Architecture ProcessArchitecture
		{
			get
			{
				return Architecture.X64;
			}
		}

		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x0600716E RID: 29038 RVA: 0x0010FFB4 File Offset: 0x0010E1B4
		public unsafe static string OSDescription
		{
			get
			{
				string text = RuntimeInformation.s_osDescription;
				if (text == null)
				{
					OperatingSystem osversion = Environment.OSVersion;
					Version version = osversion.Version;
					Span<char> span = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
					string text2;
					if (!string.IsNullOrEmpty(osversion.ServicePack))
					{
						IFormatProvider formatProvider = null;
						IFormatProvider provider = formatProvider;
						Span<char> span2 = span;
						Span<char> initialBuffer = span2;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 5, formatProvider, span2);
						defaultInterpolatedStringHandler.AppendFormatted("Microsoft Windows");
						defaultInterpolatedStringHandler.AppendLiteral(" ");
						defaultInterpolatedStringHandler.AppendFormatted<uint>((uint)version.Major);
						defaultInterpolatedStringHandler.AppendLiteral(".");
						defaultInterpolatedStringHandler.AppendFormatted<uint>((uint)version.Minor);
						defaultInterpolatedStringHandler.AppendLiteral(".");
						defaultInterpolatedStringHandler.AppendFormatted<uint>((uint)version.Build);
						defaultInterpolatedStringHandler.AppendLiteral(" ");
						defaultInterpolatedStringHandler.AppendFormatted(osversion.ServicePack);
						text2 = string.Create(provider, initialBuffer, ref defaultInterpolatedStringHandler);
					}
					else
					{
						IFormatProvider formatProvider = null;
						IFormatProvider provider2 = formatProvider;
						Span<char> span2 = span;
						Span<char> initialBuffer2 = span2;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(3, 4, formatProvider, span2);
						defaultInterpolatedStringHandler2.AppendFormatted("Microsoft Windows");
						defaultInterpolatedStringHandler2.AppendLiteral(" ");
						defaultInterpolatedStringHandler2.AppendFormatted<uint>((uint)version.Major);
						defaultInterpolatedStringHandler2.AppendLiteral(".");
						defaultInterpolatedStringHandler2.AppendFormatted<uint>((uint)version.Minor);
						defaultInterpolatedStringHandler2.AppendLiteral(".");
						defaultInterpolatedStringHandler2.AppendFormatted<uint>((uint)version.Build);
						text2 = string.Create(provider2, initialBuffer2, ref defaultInterpolatedStringHandler2);
					}
					text = (RuntimeInformation.s_osDescription = text2);
				}
				return text;
			}
		}

		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x0600716F RID: 29039 RVA: 0x0011010C File Offset: 0x0010E30C
		public static Architecture OSArchitecture
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600716F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Runtime.InteropServices.Architecture System.Runtime.InteropServices.RuntimeInformation::get_OSArchitecture()

 ---> System.Exception: Inconsistent stack size at IL_53
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
			}
		}

		// Token: 0x06007170 RID: 29040 RVA: 0x0011018E File Offset: 0x0010E38E
		private static Architecture Map(int processorArchitecture)
		{
			if (processorArchitecture <= 5)
			{
				if (processorArchitecture != 0)
				{
					if (processorArchitecture == 5)
					{
						return Architecture.Arm;
					}
				}
			}
			else
			{
				if (processorArchitecture == 9)
				{
					return Architecture.X64;
				}
				if (processorArchitecture == 12)
				{
					return Architecture.Arm64;
				}
			}
			return Architecture.X86;
		}

		// Token: 0x06007171 RID: 29041 RVA: 0x001101AE File Offset: 0x0010E3AE
		private static Architecture MapMachineConstant(ushort processMachine)
		{
			if (processMachine <= 452)
			{
				if (processMachine == 332)
				{
					return Architecture.X86;
				}
				if (processMachine == 452)
				{
					return Architecture.Arm;
				}
			}
			else
			{
				if (processMachine == 34404)
				{
					return Architecture.X64;
				}
				if (processMachine == 43620)
				{
					return Architecture.Arm64;
				}
			}
			return Architecture.X64;
		}

		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x06007172 RID: 29042 RVA: 0x001101E5 File Offset: 0x0010E3E5
		[Nullable(0)]
		public static string FrameworkDescription
		{
			[NullableContext(0)]
			get
			{
				return ".NET 9.0.6";
			}
		}

		// Token: 0x040012C9 RID: 4809
		private static string s_runtimeIdentifier;

		// Token: 0x040012CA RID: 4810
		private static string s_osDescription;

		// Token: 0x040012CB RID: 4811
		private static volatile int s_osArchPlusOne;
	}
}
