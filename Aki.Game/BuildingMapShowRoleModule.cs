using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020012EF RID: 4847
public class BuildingMapShowRoleModule : UiPanelBase
{
	// Token: 0x0600860C RID: 34316 RVA: 0x001C8F00 File Offset: 0x001C7100
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

	// Token: 0x0600860D RID: 34317 RVA: 0x001C903C File Offset: 0x001C723C
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

	// Token: 0x0600860E RID: 34318 RVA: 0x001C90FC File Offset: 0x001C72FC
	protected override UniTask OnBeforeStartAsync()
	{
		BuildingMapShowRoleModule.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BuildingMapShowRoleModule.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x02007911 RID: 30993
	private static class EComponents
	{
		// Token: 0x04027E27 RID: 163367
		public const int RoleItem1 = 0;

		// Token: 0x04027E28 RID: 163368
		public const int RoleItem2 = 1;

		// Token: 0x04027E29 RID: 163369
		public const int RoleItem3 = 2;

		// Token: 0x04027E2A RID: 163370
		public const int RoleItem4 = 3;

		// Token: 0x04027E2B RID: 163371
		public const int RoleItem5 = 4;

		// Token: 0x04027E2C RID: 163372
		public const int RoleItem6 = 5;

		// Token: 0x04027E2D RID: 163373
		public const int RoleItem7 = 6;

		// Token: 0x04027E2E RID: 163374
		public const int RoleItem8 = 7;

		// Token: 0x04027E2F RID: 163375
		public const int RoleItem9 = 8;

		// Token: 0x04027E30 RID: 163376
		public const int RoleItem10 = 9;

		// Token: 0x04027E31 RID: 163377
		public const int RoleItem11 = 10;

		// Token: 0x04027E32 RID: 163378
		public const int RoleItem12 = 11;

		// Token: 0x04027E33 RID: 163379
		public const int RoleItem13 = 12;
	}
}
