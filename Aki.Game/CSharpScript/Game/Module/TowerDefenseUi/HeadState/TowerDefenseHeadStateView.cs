using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefenseUi.HeadState
{
	// Token: 0x02003AA8 RID: 15016
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseHeadStateView : UiPanelBase
	{
		// Token: 0x0602691D RID: 157981 RVA: 0x00AD0230 File Offset: 0x00ACE430
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602691E RID: 157982 RVA: 0x00AD02BA File Offset: 0x00ACE4BA
		protected override void OnStart()
		{
			this.HpBarSprite = base.GetSprite(0);
			this.HpBarBufferSprite = base.GetSprite(1);
			this.ShieldBarSprite = base.GetSprite(2);
			this.InitUvModifier();
		}

		// Token: 0x0602691F RID: 157983 RVA: 0x00AD02EC File Offset: 0x00ACE4EC
		private void InitUvModifier()
		{
			foreach (UActorComponent uactorComponent in ULGUIBPLibrary.GetComponentsInChildrenWithHirerarchyIndex(this.RootActor, UUITextAdditionalUVModifier.StaticClass(), false))
			{
				this.UvModifierList.Add(uactorComponent as UUITextAdditionalUVModifier);
			}
		}

		// Token: 0x06026920 RID: 157984 RVA: 0x00AD035C File Offset: 0x00ACE55C
		public void Refresh(TowerDefenseHeadStateData headStateData, Vector rootWorldPos)
		{
			headStateData.Position.Subtraction(rootWorldPos, this.TmpVector);
			FVector2D fvector2D = new FVector2D((float)this.TmpVector.X, (float)this.TmpVector.Y);
			foreach (UUITextAdditionalUVModifier uuitextAdditionalUVModifier in this.UvModifierList)
			{
				uuitextAdditionalUVModifier.SetAdditionalUV(0, fvector2D);
			}
			fvector2D = new FVector2D((float)this.TmpVector.Z, (float)headStateData.ActorScale.X);
			foreach (UUITextAdditionalUVModifier uuitextAdditionalUVModifier2 in this.UvModifierList)
			{
				uuitextAdditionalUVModifier2.SetAdditionalUV(1, fvector2D);
			}
			FVector2D fvector2D2;
			foreach (UUITextAdditionalUVModifier uuitextAdditionalUVModifier3 in this.UvModifierList)
			{
				AUIBaseActor auibaseActor = uuitextAdditionalUVModifier3.GetOwner() as AUIBaseActor;
				UUIItem uuiitem = (auibaseActor != null) ? auibaseActor.GetUIItem() : null;
				float inX = (uuiitem != null) ? uuiitem.GetPivot().X : 0f;
				float inY = (uuiitem != null) ? uuiitem.GetWidth() : 1f;
				int additionalUVChannel = 2;
				fvector2D2 = new FVector2D(inX, inY);
				uuitextAdditionalUVModifier3.SetAdditionalUV(additionalUVChannel, fvector2D2);
				int additionalUVChannel2 = -1;
				fvector2D2 = new FVector2D(1f, 0f);
				uuitextAdditionalUVModifier3.SetAdditionalUV(additionalUVChannel2, fvector2D2);
			}
			UUITextAdditionalUVModifier uuitextAdditionalUVModifier4 = this.HpBarSprite.GetOwner().GetComponentByClass(UUITextAdditionalUVModifier.StaticClass()) as UUITextAdditionalUVModifier;
			UUITextAdditionalUVModifier uuitextAdditionalUVModifier5 = this.HpBarBufferSprite.GetOwner().GetComponentByClass(UUITextAdditionalUVModifier.StaticClass()) as UUITextAdditionalUVModifier;
			UUITextAdditionalUVModifier uuitextAdditionalUVModifier6 = this.ShieldBarSprite.GetOwner().GetComponentByClass(UUITextAdditionalUVModifier.StaticClass()) as UUITextAdditionalUVModifier;
			UUITextAdditionalUVModifier uuitextAdditionalUVModifier7 = uuitextAdditionalUVModifier4;
			int additionalUVChannel3 = -1;
			fvector2D2 = new FVector2D(headStateData.HpPercent, 0f);
			uuitextAdditionalUVModifier7.SetAdditionalUV(additionalUVChannel3, fvector2D2);
			UUITextAdditionalUVModifier uuitextAdditionalUVModifier8 = uuitextAdditionalUVModifier5;
			int additionalUVChannel4 = -1;
			fvector2D2 = new FVector2D(headStateData.HpBufferPercent, 0f);
			uuitextAdditionalUVModifier8.SetAdditionalUV(additionalUVChannel4, fvector2D2);
			int additionalUVChannel5 = -1;
			fvector2D2 = new FVector2D(headStateData.ShieldPercent, 0f);
			uuitextAdditionalUVModifier6.SetAdditionalUV(additionalUVChannel5, fvector2D2);
		}

		// Token: 0x04015229 RID: 86569
		[Nullable(2)]
		private UUISprite HpBarSprite;

		// Token: 0x0401522A RID: 86570
		[Nullable(2)]
		private UUISprite HpBarBufferSprite;

		// Token: 0x0401522B RID: 86571
		[Nullable(2)]
		private UUISprite ShieldBarSprite;

		// Token: 0x0401522C RID: 86572
		private readonly List<UUITextAdditionalUVModifier> UvModifierList = new List<UUITextAdditionalUVModifier>();

		// Token: 0x0401522D RID: 86573
		private readonly Vector TmpVector = Vector.Create();

		// Token: 0x020096AE RID: 38574
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0402F0B0 RID: 192688
			HpBarSprite,
			// Token: 0x0402F0B1 RID: 192689
			HpBarBufferSprite,
			// Token: 0x0402F0B2 RID: 192690
			ShieldBarSprite
		}
	}
}
