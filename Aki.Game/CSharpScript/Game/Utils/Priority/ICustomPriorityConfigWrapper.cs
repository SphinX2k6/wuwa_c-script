using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.Priority
{
	// Token: 0x02004560 RID: 17760
	[NullableContext(1)]
	internal interface ICustomPriorityConfigWrapper<[Nullable(0)] T> where T : struct, Enum
	{
		// Token: 0x1700756D RID: 30061
		// (get) Token: 0x0602DDF4 RID: 187892
		// (set) Token: 0x0602DDF5 RID: 187893
		bool Enable { get; set; }

		// Token: 0x1700756E RID: 30062
		// (get) Token: 0x0602DDF6 RID: 187894
		// (set) Token: 0x0602DDF7 RID: 187895
		[Nullable(0)]
		T Enum { [NullableContext(0)] get; [NullableContext(0)] set; }

		// Token: 0x1700756F RID: 30063
		// (get) Token: 0x0602DDF8 RID: 187896
		// (set) Token: 0x0602DDF9 RID: 187897
		int Priority { get; set; }

		// Token: 0x17007570 RID: 30064
		// (get) Token: 0x0602DDFA RID: 187898
		// (set) Token: 0x0602DDFB RID: 187899
		[Nullable(new byte[]
		{
			2,
			1
		})]
		Func<ICustomPriorityCallbackParam, bool> EnterCallback { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17007571 RID: 30065
		// (get) Token: 0x0602DDFC RID: 187900
		// (set) Token: 0x0602DDFD RID: 187901
		bool? EnterReentrant { get; set; }

		// Token: 0x17007572 RID: 30066
		// (get) Token: 0x0602DDFE RID: 187902
		// (set) Token: 0x0602DDFF RID: 187903
		bool? ForceEnterCallback { get; set; }

		// Token: 0x17007573 RID: 30067
		// (get) Token: 0x0602DE00 RID: 187904
		// (set) Token: 0x0602DE01 RID: 187905
		bool? CheckEnterValid { get; set; }

		// Token: 0x17007574 RID: 30068
		// (get) Token: 0x0602DE02 RID: 187906
		// (set) Token: 0x0602DE03 RID: 187907
		[Nullable(new byte[]
		{
			2,
			1
		})]
		Func<ICustomPriorityCallbackParam, bool> ExitCallback { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17007575 RID: 30069
		// (get) Token: 0x0602DE04 RID: 187908
		// (set) Token: 0x0602DE05 RID: 187909
		bool? ForceExitCallback { get; set; }

		// Token: 0x17007576 RID: 30070
		// (get) Token: 0x0602DE06 RID: 187910
		// (set) Token: 0x0602DE07 RID: 187911
		bool? CheckExitValid { get; set; }

		// Token: 0x17007577 RID: 30071
		// (get) Token: 0x0602DE08 RID: 187912
		// (set) Token: 0x0602DE09 RID: 187913
		Func<bool, bool, string, bool> EnterWrapper { get; set; }

		// Token: 0x17007578 RID: 30072
		// (get) Token: 0x0602DE0A RID: 187914
		// (set) Token: 0x0602DE0B RID: 187915
		Func<bool, string, bool> ExitWrapper { get; set; }
	}
}
