using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.ExtraEffect
{
	// Token: 0x02006382 RID: 25474
	[NullableContext(1)]
	[Nullable(0)]
	public class AbnormalIce : BuffEffect
	{
		// Token: 0x0603DB96 RID: 252822 RVA: 0x011E2C05 File Offset: 0x011E0E05
		public AbnormalIce(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
		{
		}

		// Token: 0x0603DB97 RID: 252823 RVA: 0x011E2C20 File Offset: 0x011E0E20
		protected override void InitParameters(ExtraEffectParameters parameters)
		{
			this._modifierValue.Clear();
			if (parameters.ExtraEffectParameters_ == null)
			{
				return;
			}
			string[] array = ((parameters.ExtraEffectParameters_.Length != 0) ? parameters.ExtraEffectParameters_[0] : "").Split('|', StringSplitOptions.None);
			for (int i = 0; i < array.Length; i++)
			{
				string[] array2 = array[i].Trim().Split('#', StringSplitOptions.None);
				this._modifierValue.Add(new ValueTuple<int, int>(int.Parse(array2[0].Trim()), int.Parse(array2[1].Trim())));
			}
		}

		// Token: 0x0603DB98 RID: 252824 RVA: 0x011E2CAB File Offset: 0x011E0EAB
		public override void OnCreated()
		{
		}

		// Token: 0x0603DB99 RID: 252825 RVA: 0x011E2CAD File Offset: 0x011E0EAD
		[return: Nullable(2)]
		public override object OnExecute(params object[] args)
		{
			return null;
		}

		// Token: 0x0603DB9A RID: 252826 RVA: 0x011E2CB0 File Offset: 0x011E0EB0
		public override void OnRemoved(bool bPremature)
		{
		}

		// Token: 0x0603DB9B RID: 252827 RVA: 0x011E2CB2 File Offset: 0x011E0EB2
		public override void OnStackIncreased(int newCount, int oldCount, long? instigatorId)
		{
		}

		// Token: 0x0603DB9C RID: 252828 RVA: 0x011E2CB4 File Offset: 0x011E0EB4
		public override void OnStackDecreased(int newCount, int oldCount, bool bPremature)
		{
		}

		// Token: 0x0603DB9D RID: 252829 RVA: 0x011E2CB8 File Offset: 0x011E0EB8
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

		// Token: 0x0603DB9E RID: 252830 RVA: 0x011E2CF8 File Offset: 0x011E0EF8
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

		// Token: 0x04020BA7 RID: 134055
		private int _modifierHandle;

		// Token: 0x04020BA8 RID: 134056
		[Nullable(new byte[]
		{
			1,
			0
		})]
		private readonly List<ValueTuple<int, int>> _modifierValue = new List<ValueTuple<int, int>>();
	}
}
