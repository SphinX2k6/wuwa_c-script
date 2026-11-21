using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.HonamiStory;
using UnrealEngine;

// Token: 0x02001398 RID: 5016
[NullableContext(2)]
[Nullable(0)]
public class HonamiStoryMainButtonConfig : IHonamiStoryMainButtonConfig
{
	// Token: 0x17001322 RID: 4898
	// (get) Token: 0x0600C6D9 RID: 50905 RVA: 0x003B3CE0 File Offset: 0x003B1EE0
	// (set) Token: 0x0600C6DA RID: 50906 RVA: 0x003B3CE8 File Offset: 0x003B1EE8
	public EHonamiStoryMainButtonFunctionType Type { get; set; }

	// Token: 0x17001323 RID: 4899
	// (get) Token: 0x0600C6DB RID: 50907 RVA: 0x003B3CF1 File Offset: 0x003B1EF1
	// (set) Token: 0x0600C6DC RID: 50908 RVA: 0x003B3CF9 File Offset: 0x003B1EF9
	public EHonamiStoryMainComponent ComponentId { get; set; }

	// Token: 0x17001324 RID: 4900
	// (get) Token: 0x0600C6DD RID: 50909 RVA: 0x003B3D02 File Offset: 0x003B1F02
	// (set) Token: 0x0600C6DE RID: 50910 RVA: 0x003B3D0A File Offset: 0x003B1F0A
	public EFunctionType? FunctionId { get; set; }

	// Token: 0x17001325 RID: 4901
	// (get) Token: 0x0600C6DF RID: 50911 RVA: 0x003B3D13 File Offset: 0x003B1F13
	// (set) Token: 0x0600C6E0 RID: 50912 RVA: 0x003B3D1B File Offset: 0x003B1F1B
	public Func<bool> ShowRedDot { get; set; }

	// Token: 0x17001326 RID: 4902
	// (get) Token: 0x0600C6E1 RID: 50913 RVA: 0x003B3D24 File Offset: 0x003B1F24
	// (set) Token: 0x0600C6E2 RID: 50914 RVA: 0x003B3D2C File Offset: 0x003B1F2C
	public Action<UUIText> SetTextCallback { get; set; }

	// Token: 0x17001327 RID: 4903
	// (get) Token: 0x0600C6E3 RID: 50915 RVA: 0x003B3D35 File Offset: 0x003B1F35
	// (set) Token: 0x0600C6E4 RID: 50916 RVA: 0x003B3D3D File Offset: 0x003B1F3D
	public Action OnClickCallback { get; set; }

	// Token: 0x17001328 RID: 4904
	// (get) Token: 0x0600C6E5 RID: 50917 RVA: 0x003B3D46 File Offset: 0x003B1F46
	// (set) Token: 0x0600C6E6 RID: 50918 RVA: 0x003B3D4E File Offset: 0x003B1F4E
	public Func<bool> ShowCallback { get; set; }

	// Token: 0x17001329 RID: 4905
	// (get) Token: 0x0600C6E7 RID: 50919 RVA: 0x003B3D57 File Offset: 0x003B1F57
	// (set) Token: 0x0600C6E8 RID: 50920 RVA: 0x003B3D5F File Offset: 0x003B1F5F
	public string SpecialSequenceName { get; set; }

	// Token: 0x1700132A RID: 4906
	// (get) Token: 0x0600C6E9 RID: 50921 RVA: 0x003B3D68 File Offset: 0x003B1F68
	// (set) Token: 0x0600C6EA RID: 50922 RVA: 0x003B3D70 File Offset: 0x003B1F70
	public string SpecialParamName { get; set; }
}
