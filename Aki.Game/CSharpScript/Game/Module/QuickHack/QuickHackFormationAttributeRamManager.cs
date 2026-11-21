using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F42 RID: 16194
	public class QuickHackFormationAttributeRamManager : QuickHackRamManager
	{
		// Token: 0x06029018 RID: 167960 RVA: 0x00B83A60 File Offset: 0x00B81C60
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

		// Token: 0x06029019 RID: 167961 RVA: 0x00B83ABD File Offset: 0x00B81CBD
		private void OnAttributeValueChange(EFormationAttributeId attrId, float newValue, float oldValue)
		{
			Action<float> onCurrentRamChange = this.OnCurrentRamChange;
			if (onCurrentRamChange == null)
			{
				return;
			}
			onCurrentRamChange(newValue);
		}

		// Token: 0x0602901A RID: 167962 RVA: 0x00B83AD0 File Offset: 0x00B81CD0
		private void OnAttributeMaxChange(EFormationAttributeId attrId, float newValue, float oldValue)
		{
			Action<float> onMaxRamChange = this.OnMaxRamChange;
			if (onMaxRamChange == null)
			{
				return;
			}
			onMaxRamChange(newValue);
		}

		// Token: 0x0602901B RID: 167963 RVA: 0x00B83AE4 File Offset: 0x00B81CE4
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

		// Token: 0x0602901C RID: 167964 RVA: 0x00B83B46 File Offset: 0x00B81D46
		public override float GetCurrentRam()
		{
			return FormationAttributeController.Instance.GetValue(this.AttributeId);
		}

		// Token: 0x0602901D RID: 167965 RVA: 0x00B83B58 File Offset: 0x00B81D58
		public override float GetMaxRam()
		{
			return FormationAttributeController.Instance.GetMax(this.AttributeId);
		}

		// Token: 0x0602901E RID: 167966 RVA: 0x00B83B6A File Offset: 0x00B81D6A
		public override void ChangeRam(float addValue)
		{
			FormationAttributeController.Instance.AddValue(this.AttributeId, addValue);
		}

		// Token: 0x04016519 RID: 91417
		private EFormationAttributeId AttributeId;
	}
}
