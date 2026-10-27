using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F79 RID: 20345
	public class QuickHackFormationAttributeRamManager : QuickHackRamManager
	{
		// Token: 0x060341AA RID: 213418 RVA: 0x00C3A2B4 File Offset: 0x00C384B4
		[NullableContext(2)]
		public override void Init(int param, Action<float> onCurrentRamChange = null, Action<float> onMaxRamChange = null)
		{
			base.Init(param, onCurrentRamChange, onMaxRamChange);
			this.AttributeId = (EFormationAttributeId)param;
			if (onCurrentRamChange != null)
			{
				FormationAttributeController.Instance.AddValueListener(this.AttributeId, new TValueListener(this.OnAttributeValueChange), null);
			}
			if (onMaxRamChange != null)
			{
				FormationAttributeController.Instance.AddMaxListener(this.AttributeId, new TValueListener(this.OnAttributeMaxChange), null);
			}
		}

		// Token: 0x060341AB RID: 213419 RVA: 0x00C3A311 File Offset: 0x00C38511
		private void OnAttributeValueChange(EFormationAttributeId attrId, float newValue, float oldValue)
		{
			Action<float> onCurrentRamChange = this.OnCurrentRamChange;
			if (onCurrentRamChange == null)
			{
				return;
			}
			onCurrentRamChange(newValue);
		}

		// Token: 0x060341AC RID: 213420 RVA: 0x00C3A324 File Offset: 0x00C38524
		private void OnAttributeMaxChange(EFormationAttributeId attrId, float newValue, float oldValue)
		{
			Action<float> onMaxRamChange = this.OnMaxRamChange;
			if (onMaxRamChange == null)
			{
				return;
			}
			onMaxRamChange(newValue);
		}

		// Token: 0x060341AD RID: 213421 RVA: 0x00C3A338 File Offset: 0x00C38538
		public override void Clear()
		{
			if (this.OnCurrentRamChange != null)
			{
				FormationAttributeController.Instance.RemoveValueListener(this.AttributeId, new TValueListener(this.OnAttributeValueChange));
			}
			if (this.OnMaxRamChange != null)
			{
				FormationAttributeController.Instance.RemoveMaxListener(this.AttributeId, new TValueListener(this.OnAttributeMaxChange));
			}
			this.AttributeId = (EFormationAttributeId)0;
			base.Clear();
		}

		// Token: 0x060341AE RID: 213422 RVA: 0x00C3A39A File Offset: 0x00C3859A
		public override float GetCurrentRam()
		{
			return FormationAttributeController.Instance.GetValue(this.AttributeId);
		}

		// Token: 0x060341AF RID: 213423 RVA: 0x00C3A3AC File Offset: 0x00C385AC
		public override float GetMaxRam()
		{
			return FormationAttributeController.Instance.GetMax(this.AttributeId);
		}

		// Token: 0x060341B0 RID: 213424 RVA: 0x00C3A3BE File Offset: 0x00C385BE
		public override void ChangeRam(float addValue)
		{
			FormationAttributeController.Instance.AddValue(this.AttributeId, addValue);
		}

		// Token: 0x0401BB44 RID: 113476
		private EFormationAttributeId AttributeId;
	}
}
