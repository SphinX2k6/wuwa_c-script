using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefenseUi.HeadState
{
	// Token: 0x02004B00 RID: 19200
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseHeadStateView : UiPanelBase
	{
		// Token: 0x06031B8D RID: 203661 RVA: 0x00B8C1D4 File Offset: 0x00B8A3D4
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

		// Token: 0x06031B8E RID: 203662 RVA: 0x00B8C25E File Offset: 0x00B8A45E
		protected override void OnStart()
		{
			this.HpBarSprite = base.GetSprite(0);
			this.HpBarBufferSprite = base.GetSprite(1);
			this.ShieldBarSprite = base.GetSprite(2);
			this.InitUvModifier();
		}

		// Token: 0x06031B8F RID: 203663 RVA: 0x00B8C290 File Offset: 0x00B8A490
		private void InitUvModifier()
		{
			foreach (UActorComponent uactorComponent in ULGUIBPLibrary.GetComponentsInChildrenWithHirerarchyIndex(this.RootActor, UUITextAdditionalUVModifier.StaticClass(), false))
			{
				this.UvModifierList.Add(uactorComponent as UUITextAdditionalUVModifier);
			}
		}

		// Token: 0x06031B90 RID: 203664 RVA: 0x00B8C2F8 File Offset: 0x00B8A4F8
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

		// Token: 0x0401A8D7 RID: 108759
		[Nullable(2)]
		private UUISprite HpBarSprite;

		// Token: 0x0401A8D8 RID: 108760
		[Nullable(2)]
		private UUISprite HpBarBufferSprite;

		// Token: 0x0401A8D9 RID: 108761
		[Nullable(2)]
		private UUISprite ShieldBarSprite;

		// Token: 0x0401A8DA RID: 108762
		private readonly List<UUITextAdditionalUVModifier> UvModifierList = new List<UUITextAdditionalUVModifier>();

		// Token: 0x0401A8DB RID: 108763
		private readonly Vector TmpVector = Vector.Create();

		// Token: 0x0200AC8E RID: 44174
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x040346FF RID: 214783
			HpBarSprite,
			// Token: 0x04034700 RID: 214784
			HpBarBufferSprite,
			// Token: 0x04034701 RID: 214785
			ShieldBarSprite
		}
	}
}
