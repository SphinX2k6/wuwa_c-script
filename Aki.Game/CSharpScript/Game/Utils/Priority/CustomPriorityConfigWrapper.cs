using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.Priority
{
	// Token: 0x02004561 RID: 17761
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	internal class CustomPriorityConfigWrapper<[Nullable(0)] T> : ICustomPriorityConfigWrapper<T> where T : struct, Enum
	{
		// Token: 0x17007579 RID: 30073
		// (get) Token: 0x0602DE0C RID: 187916 RVA: 0x00A8C2AB File Offset: 0x00A8A4AB
		// (set) Token: 0x0602DE0D RID: 187917 RVA: 0x00A8C2B3 File Offset: 0x00A8A4B3
		public bool Enable { get; set; }

		// Token: 0x1700757A RID: 30074
		// (get) Token: 0x0602DE0E RID: 187918 RVA: 0x00A8C2BC File Offset: 0x00A8A4BC
		// (set) Token: 0x0602DE0F RID: 187919 RVA: 0x00A8C2C4 File Offset: 0x00A8A4C4
		[Nullable(0)]
		[RequiredMember]
		public T Enum { [NullableContext(0)] get; [NullableContext(0)] set; }

		// Token: 0x1700757B RID: 30075
		// (get) Token: 0x0602DE10 RID: 187920 RVA: 0x00A8C2CD File Offset: 0x00A8A4CD
		// (set) Token: 0x0602DE11 RID: 187921 RVA: 0x00A8C2D5 File Offset: 0x00A8A4D5
		[RequiredMember]
		public int Priority { get; set; }

		// Token: 0x1700757C RID: 30076
		// (get) Token: 0x0602DE12 RID: 187922 RVA: 0x00A8C2DE File Offset: 0x00A8A4DE
		// (set) Token: 0x0602DE13 RID: 187923 RVA: 0x00A8C2E6 File Offset: 0x00A8A4E6
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<ICustomPriorityCallbackParam, bool> EnterCallback { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x1700757D RID: 30077
		// (get) Token: 0x0602DE14 RID: 187924 RVA: 0x00A8C2EF File Offset: 0x00A8A4EF
		// (set) Token: 0x0602DE15 RID: 187925 RVA: 0x00A8C2F7 File Offset: 0x00A8A4F7
		public bool? EnterReentrant { get; set; }

		// Token: 0x1700757E RID: 30078
		// (get) Token: 0x0602DE16 RID: 187926 RVA: 0x00A8C300 File Offset: 0x00A8A500
		// (set) Token: 0x0602DE17 RID: 187927 RVA: 0x00A8C308 File Offset: 0x00A8A508
		public bool? ForceEnterCallback { get; set; }

		// Token: 0x1700757F RID: 30079
		// (get) Token: 0x0602DE18 RID: 187928 RVA: 0x00A8C311 File Offset: 0x00A8A511
		// (set) Token: 0x0602DE19 RID: 187929 RVA: 0x00A8C319 File Offset: 0x00A8A519
		public bool? CheckEnterValid { get; set; }

		// Token: 0x17007580 RID: 30080
		// (get) Token: 0x0602DE1A RID: 187930 RVA: 0x00A8C322 File Offset: 0x00A8A522
		// (set) Token: 0x0602DE1B RID: 187931 RVA: 0x00A8C32A File Offset: 0x00A8A52A
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<ICustomPriorityCallbackParam, bool> ExitCallback { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17007581 RID: 30081
		// (get) Token: 0x0602DE1C RID: 187932 RVA: 0x00A8C333 File Offset: 0x00A8A533
		// (set) Token: 0x0602DE1D RID: 187933 RVA: 0x00A8C33B File Offset: 0x00A8A53B
		public bool? ForceExitCallback { get; set; }

		// Token: 0x17007582 RID: 30082
		// (get) Token: 0x0602DE1E RID: 187934 RVA: 0x00A8C344 File Offset: 0x00A8A544
		// (set) Token: 0x0602DE1F RID: 187935 RVA: 0x00A8C34C File Offset: 0x00A8A54C
		public bool? CheckExitValid { get; set; }

		// Token: 0x17007583 RID: 30083
		// (get) Token: 0x0602DE20 RID: 187936 RVA: 0x00A8C355 File Offset: 0x00A8A555
		// (set) Token: 0x0602DE21 RID: 187937 RVA: 0x00A8C35D File Offset: 0x00A8A55D
		[RequiredMember]
		public Func<bool, bool, string, bool> EnterWrapper { get; set; }

		// Token: 0x17007584 RID: 30084
		// (get) Token: 0x0602DE22 RID: 187938 RVA: 0x00A8C366 File Offset: 0x00A8A566
		// (set) Token: 0x0602DE23 RID: 187939 RVA: 0x00A8C36E File Offset: 0x00A8A56E
		[RequiredMember]
		public Func<bool, string, bool> ExitWrapper { get; set; }

		// Token: 0x0602DE24 RID: 187940 RVA: 0x00A8C377 File Offset: 0x00A8A577
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public CustomPriorityConfigWrapper()
		{
		}
	}
}
