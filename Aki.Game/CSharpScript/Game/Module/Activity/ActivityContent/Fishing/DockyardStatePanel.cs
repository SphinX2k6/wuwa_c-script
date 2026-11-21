using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005548 RID: 21832
	public class DockyardStatePanel : UiPanelBase
	{
		// Token: 0x06036286 RID: 221830 RVA: 0x00F1DA54 File Offset: 0x00F1BC54
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06036287 RID: 221831 RVA: 0x00F1DB20 File Offset: 0x00F1BD20
		[NullableContext(1)]
		protected UniTask InitConsumeItem(int itemId, UUIItem item)
		{
			DockyardStatePanel.<InitConsumeItem>d__2 <InitConsumeItem>d__;
			<InitConsumeItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitConsumeItem>d__.itemId = itemId;
			<InitConsumeItem>d__.item = item;
			<InitConsumeItem>d__.<>1__state = -1;
			<InitConsumeItem>d__.<>t__builder.Start<DockyardStatePanel.<InitConsumeItem>d__2>(ref <InitConsumeItem>d__);
			return <InitConsumeItem>d__.<>t__builder.Task;
		}

		// Token: 0x06036288 RID: 221832 RVA: 0x00F1DB6C File Offset: 0x00F1BD6C
		protected void InitSkillText()
		{
			int unlockFishingTechCount = FishingModel.Instance.UnlockFishingTechCount;
			int allFishingTechCount = FishingModel.Instance.AllFishingTechCount;
			UUIText text = base.GetText(3);
			if (text == null)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(unlockFishingTechCount);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(allFishingTechCount);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x06036289 RID: 221833 RVA: 0x00F1DBD0 File Offset: 0x00F1BDD0
		protected void InitSpeedText()
		{
			EntityHandle entityHandle = FishingModel.Instance.GetShipData().GetEntityHandle();
			object obj;
			if (entityHandle == null)
			{
				obj = null;
			}
			else
			{
				WorldEntity entity = entityHandle.Entity;
				obj = ((entity != null) ? entity.GetComponent<VehicleMoveComponent>() : null);
			}
			object obj2 = obj;
			float? num;
			if (obj2 == null)
			{
				num = null;
			}
			else
			{
				UKuroVehicleMovementComponent vehicleMovement = obj2.VehicleMovement;
				num = ((vehicleMovement != null) ? new float?(vehicleMovement.MaxSpeed) : null);
			}
			float? num2 = num;
			float valueOrDefault = num2.GetValueOrDefault();
			UUIText text = base.GetText(4);
			if (text == null)
			{
				return;
			}
			text.SetText(valueOrDefault.ToString(), true);
		}

		// Token: 0x0603628A RID: 221834 RVA: 0x00F1DC54 File Offset: 0x00F1BE54
		protected override UniTask OnBeforeStartAsync()
		{
			DockyardStatePanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DockyardStatePanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0200B1D2 RID: 45522
		private class EComponentDefine
		{
			// Token: 0x04036F6D RID: 225133
			public const int CurrencyItem = 0;

			// Token: 0x04036F6E RID: 225134
			public const int BombItem = 1;

			// Token: 0x04036F6F RID: 225135
			public const int BaitItem = 2;

			// Token: 0x04036F70 RID: 225136
			public const int SkillText = 3;

			// Token: 0x04036F71 RID: 225137
			public const int SpeedText = 4;
		}
	}
}
