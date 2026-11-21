using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component
{
	// Token: 0x020041C1 RID: 16833
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CardSkillComponent : CardComponentBase<ICardSkillComponentData>
	{
		// Token: 0x0602A973 RID: 174451 RVA: 0x00C0294C File Offset: 0x00C00B4C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUISprite)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(3, new Action(this.OnSkillBtnClick))
			};
		}

		// Token: 0x0602A974 RID: 174452 RVA: 0x00C029DF File Offset: 0x00C00BDF
		protected override void OnStart()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
			this.Sequence.BindOnEndSequenceEvent(new Action<string>(this.OnSequenceEndEvent));
		}

		// Token: 0x0602A975 RID: 174453 RVA: 0x00C02A09 File Offset: 0x00C00C09
		protected override void OnBeforeDestroy()
		{
			this.Sequence.Clear();
		}

		// Token: 0x0602A976 RID: 174454 RVA: 0x00C02A16 File Offset: 0x00C00C16
		private void OnSkillBtnClick()
		{
			this.SkillBtnClick();
		}

		// Token: 0x0602A977 RID: 174455 RVA: 0x00C02A24 File Offset: 0x00C00C24
		private void OnSequenceEndEvent(string sequenceName)
		{
			if (sequenceName == "NorToUse")
			{
				base.GetItem(0).SetUIActive(false);
				return;
			}
			if (sequenceName == "UseToNor")
			{
				base.GetButton(3).RootUIComp.Get().SetUIActive(false);
				return;
			}
			if (sequenceName == "UseToCd")
			{
				base.GetButton(3).RootUIComp.Get().SetUIActive(false);
				return;
			}
			if (sequenceName == "CdToNor")
			{
				base.GetSprite(2).SetUIActive(false);
			}
		}

		// Token: 0x0602A978 RID: 174456 RVA: 0x00C02AB8 File Offset: 0x00C00CB8
		private void SwitchUseToNor()
		{
			this.Sequence.StopPrevSequence(false, true);
			this.Sequence.PlaySequence("UseToNor", false, null);
			base.GetItem(0).SetUIActive(true);
		}

		// Token: 0x0602A979 RID: 174457 RVA: 0x00C02AFC File Offset: 0x00C00CFC
		private void SwitchNorToUse()
		{
			this.Sequence.StopPrevSequence(false, true);
			this.Sequence.PlaySequence("NorToUse", false, null);
			base.GetItem(0).SetUIActive(true);
			base.GetButton(3).RootUIComp.Get().SetUIActive(true);
		}

		// Token: 0x0602A97A RID: 174458 RVA: 0x00C02B58 File Offset: 0x00C00D58
		private void SwitchCdToNor()
		{
			this.Sequence.StopPrevSequence(false, true);
			this.Sequence.PlaySequence("CdToNor", false, null);
			base.GetSprite(1).SetUIActive(true);
		}

		// Token: 0x0602A97B RID: 174459 RVA: 0x00C02B9C File Offset: 0x00C00D9C
		private void SwitchUseToCd()
		{
			this.Sequence.StopPrevSequence(false, true);
			this.Sequence.PlaySequence("UseToCd", false, null);
			base.GetItem(0).SetUIActive(true);
			base.GetButton(3).RootUIComp.Get().SetUIActive(false);
			base.GetSprite(2).SetUIActive(true);
		}

		// Token: 0x0602A97C RID: 174460 RVA: 0x00C02C04 File Offset: 0x00C00E04
		public override void Refresh(ICardSkillComponentData data)
		{
			if (!data.InFight)
			{
				this.SetActive(false);
				this.Data = data;
				return;
			}
			this.SetActive(true);
			if (data.InSelect && data.SkillCd <= 0)
			{
				this.TriggerCanUseState();
			}
			else
			{
				this.TriggerNormalState(data);
			}
			this.Data = data;
		}

		// Token: 0x0602A97D RID: 174461 RVA: 0x00C02C56 File Offset: 0x00C00E56
		public void TriggerCanUseState()
		{
			this.SwitchNorToUse();
		}

		// Token: 0x0602A97E RID: 174462 RVA: 0x00C02C60 File Offset: 0x00C00E60
		public void TriggerNormalState(ICardSkillComponentData data)
		{
			ICardSkillComponentData data2 = this.Data;
			bool flag;
			if (data2 == null)
			{
				flag = false;
			}
			else
			{
				int skillCd = data2.SkillCd;
				flag = true;
			}
			bool flag2 = flag && this.Data.SkillCd > 0;
			if (data.SkillCd > 0)
			{
				if (!flag2)
				{
					this.SwitchUseToCd();
					return;
				}
			}
			else
			{
				if (flag2)
				{
					this.SwitchCdToNor();
					return;
				}
				if (!data.InSelect)
				{
					ICardSkillComponentData data3 = this.Data;
					if (data3 != null && data3.InSelect)
					{
						this.SwitchUseToNor();
					}
				}
			}
		}

		// Token: 0x040171AB RID: 94635
		public Action SkillBtnClick;

		// Token: 0x040171AC RID: 94636
		protected UiSequencePlayer Sequence;

		// Token: 0x040171AD RID: 94637
		protected ICardSkillComponentData Data;

		// Token: 0x02009DAA RID: 40362
		[NullableContext(0)]
		private static class EComponentDefine
		{
			// Token: 0x0403107A RID: 200826
			public const int NormalItem = 0;

			// Token: 0x0403107B RID: 200827
			public const int NormalIcon = 1;

			// Token: 0x0403107C RID: 200828
			public const int CountDownIcon = 2;

			// Token: 0x0403107D RID: 200829
			public const int SkillBtn = 3;
		}
	}
}
