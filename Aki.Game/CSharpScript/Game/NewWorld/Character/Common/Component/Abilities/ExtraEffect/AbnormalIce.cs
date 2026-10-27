using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.ExtraEffect
{
	// Token: 0x02007154 RID: 29012
	[NullableContext(1)]
	[Nullable(0)]
	public class AbnormalIce : BuffEffect
	{
		// Token: 0x06046D3C RID: 290108 RVA: 0x011D9A2D File Offset: 0x011D7C2D
		public AbnormalIce(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
		{
		}

		// Token: 0x06046D3D RID: 290109 RVA: 0x011D9A48 File Offset: 0x011D7C48
		protected override void InitParameters(ExtraEffectParameters parameters)
		{
			this._modifierValue.Clear();
			if (parameters.ExtraEffectParameters_ == null)
			{
				return;
			}
			string[] array = (parameters.ExtraEffectParameters_.ElementAtOrDefault(0) ?? "").Split('|', StringSplitOptions.None);
			for (int i = 0; i < array.Length; i++)
			{
				string[] array2 = array[i].Trim().Split('#', StringSplitOptions.None);
				this._modifierValue.Add(new ValueTuple<int, int>(int.Parse(array2[0].Trim()), int.Parse(array2[1].Trim())));
			}
		}

		// Token: 0x06046D3E RID: 290110 RVA: 0x011D9AD0 File Offset: 0x011D7CD0
		public override void OnCreated()
		{
		}

		// Token: 0x06046D3F RID: 290111 RVA: 0x011D9AD2 File Offset: 0x011D7CD2
		[return: Nullable(2)]
		public override object OnExecute(params object[] args)
		{
			return null;
		}

		// Token: 0x06046D40 RID: 290112 RVA: 0x011D9AD5 File Offset: 0x011D7CD5
		public override void OnRemoved(bool bPremature)
		{
		}

		// Token: 0x06046D41 RID: 290113 RVA: 0x011D9AD7 File Offset: 0x011D7CD7
		public override void OnStackIncreased(int newCount, int oldCount, long? instigatorId)
		{
		}

		// Token: 0x06046D42 RID: 290114 RVA: 0x011D9AD9 File Offset: 0x011D7CD9
		public override void OnStackDecreased(int newCount, int oldCount, bool bPremature)
		{
		}

		// Token: 0x06046D43 RID: 290115 RVA: 0x011D9ADC File Offset: 0x011D7CDC
		public void ClearModifier()
		{
			Entity exactOwnerEntity = base.ExactOwnerEntity;
			BaseAttributeComponent baseAttributeComponent = (exactOwnerEntity != null) ? exactOwnerEntity.GetComponent<BaseAttributeComponent>() : null;
			if (this._modifierHandle != 0)
			{
				if (baseAttributeComponent != null)
				{
					baseAttributeComponent.RemoveModifier(EAttributeType.SpeedRatio, this._modifierHandle);
				}
				this._modifierHandle = 0;
			}
		}

		// Token: 0x06046D44 RID: 290116 RVA: 0x011D9B1C File Offset: 0x011D7D1C
		public void RefreshModifier(int stackCount)
		{
			this.ClearModifier();
			Entity exactOwnerEntity = base.ExactOwnerEntity;
			BaseAttributeComponent baseAttributeComponent = (exactOwnerEntity != null) ? exactOwnerEntity.GetComponent<BaseAttributeComponent>() : null;
			if (baseAttributeComponent == null)
			{
				return;
			}
			int num = 0;
			for (int i = this._modifierValue.Count - 1; i >= 0; i--)
			{
				ValueTuple<int, int> valueTuple = this._modifierValue[i];
				int item = valueTuple.Item1;
				int item2 = valueTuple.Item2;
				if (stackCount >= item)
				{
					num = item2;
					break;
				}
			}
			this._modifierHandle = baseAttributeComponent.AddModifier(EAttributeType.SpeedRatio, new CharacterAttributeTypes.AttributeModifier
			{
				Type = ECalculationPolicyType.AddFromAttr,
				Value1 = (float)(num - 10000)
			});
		}

		// Token: 0x040252C4 RID: 152260
		private int _modifierHandle;

		// Token: 0x040252C5 RID: 152261
		[Nullable(new byte[]
		{
			1,
			0
		})]
		private readonly List<ValueTuple<int, int>> _modifierValue = new List<ValueTuple<int, int>>();
	}
}
