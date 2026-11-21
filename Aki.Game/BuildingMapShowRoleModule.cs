using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020007A3 RID: 1955
public class BuildingMapShowRoleModule : UiPanelBase
{
	// Token: 0x060059A7 RID: 22951 RVA: 0x001D1D6C File Offset: 0x001CFF6C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUITexture)),
			new ValueTuple<int, Type>(5, typeof(UUITexture)),
			new ValueTuple<int, Type>(6, typeof(UUITexture)),
			new ValueTuple<int, Type>(7, typeof(UUITexture)),
			new ValueTuple<int, Type>(8, typeof(UUITexture)),
			new ValueTuple<int, Type>(9, typeof(UUITexture)),
			new ValueTuple<int, Type>(10, typeof(UUITexture)),
			new ValueTuple<int, Type>(11, typeof(UUITexture)),
			new ValueTuple<int, Type>(12, typeof(UUITexture))
		};
	}

	// Token: 0x060059A8 RID: 22952 RVA: 0x001D1EA8 File Offset: 0x001D00A8
	[NullableContext(1)]
	protected List<UUITexture> GetRoleTextureList()
	{
		return new List<UUITexture>
		{
			base.GetTexture(0),
			base.GetTexture(1),
			base.GetTexture(2),
			base.GetTexture(3),
			base.GetTexture(4),
			base.GetTexture(5),
			base.GetTexture(6),
			base.GetTexture(7),
			base.GetTexture(8),
			base.GetTexture(9),
			base.GetTexture(10),
			base.GetTexture(11),
			base.GetTexture(12)
		};
	}

	// Token: 0x060059A9 RID: 22953 RVA: 0x001D1F68 File Offset: 0x001D0168
	protected override UniTask OnBeforeStartAsync()
	{
		BuildingMapShowRoleModule.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BuildingMapShowRoleModule.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x02006A9B RID: 27291
	private static class EComponents
	{
		// Token: 0x04023154 RID: 143700
		public const int RoleItem1 = 0;

		// Token: 0x04023155 RID: 143701
		public const int RoleItem2 = 1;

		// Token: 0x04023156 RID: 143702
		public const int RoleItem3 = 2;

		// Token: 0x04023157 RID: 143703
		public const int RoleItem4 = 3;

		// Token: 0x04023158 RID: 143704
		public const int RoleItem5 = 4;

		// Token: 0x04023159 RID: 143705
		public const int RoleItem6 = 5;

		// Token: 0x0402315A RID: 143706
		public const int RoleItem7 = 6;

		// Token: 0x0402315B RID: 143707
		public const int RoleItem8 = 7;

		// Token: 0x0402315C RID: 143708
		public const int RoleItem9 = 8;

		// Token: 0x0402315D RID: 143709
		public const int RoleItem10 = 9;

		// Token: 0x0402315E RID: 143710
		public const int RoleItem11 = 10;

		// Token: 0x0402315F RID: 143711
		public const int RoleItem12 = 11;

		// Token: 0x04023160 RID: 143712
		public const int RoleItem13 = 12;
	}
}
