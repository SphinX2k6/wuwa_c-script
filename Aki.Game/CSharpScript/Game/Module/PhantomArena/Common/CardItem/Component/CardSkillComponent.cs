using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component
{
	// Token: 0x020051F1 RID: 20977
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CardSkillComponent : CardComponentBase<ICardSkillComponentData>
	{
		// Token: 0x06035A78 RID: 219768 RVA: 0x00CB5310 File Offset: 0x00CB3510
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

		// Token: 0x06035A79 RID: 219769 RVA: 0x00CB53A3 File Offset: 0x00CB35A3
		protected override void OnStart()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
			this.Sequence.BindOnEndSequenceEvent(new Action<string>(this.OnSequenceEndEvent));
		}

		// Token: 0x06035A7A RID: 219770 RVA: 0x00CB53CD File Offset: 0x00CB35CD
		protected override void OnBeforeDestroy()
		{
			this.Sequence.Clear();
		}

		// Token: 0x06035A7B RID: 219771 RVA: 0x00CB53DA File Offset: 0x00CB35DA
		private void OnSkillBtnClick()
		{
			this.SkillBtnClick();
		}

		// Token: 0x06035A7C RID: 219772 RVA: 0x00CB53E8 File Offset: 0x00CB35E8
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

		// Token: 0x06035A7D RID: 219773 RVA: 0x00CB547C File Offset: 0x00CB367C
		private void SwitchUseToNor()
		{
			this.Sequence.StopPrevSequence(false, true);
			this.Sequence.PlaySequence("UseToNor", false, null);
			base.GetItem(0).SetUIActive(true);
		}

		// Token: 0x06035A7E RID: 219774 RVA: 0x00CB54C0 File Offset: 0x00CB36C0
		private void SwitchNorToUse()
		{
			this.Sequence.StopPrevSequence(false, true);
			this.Sequence.PlaySequence("NorToUse", false, null);
			base.GetItem(0).SetUIActive(true);
			base.GetButton(3).RootUIComp.Get().SetUIActive(true);
		}

		// Token: 0x06035A7F RID: 219775 RVA: 0x00CB551C File Offset: 0x00CB371C
		private void SwitchCdToNor()
		{
			this.Sequence.StopPrevSequence(false, true);
			this.Sequence.PlaySequence("CdToNor", false, null);
			base.GetSprite(1).SetUIActive(true);
		}

		// Token: 0x06035A80 RID: 219776 RVA: 0x00CB5560 File Offset: 0x00CB3760
		private void SwitchUseToCd()
		{
			this.Sequence.StopPrevSequence(false, true);
			this.Sequence.PlaySequence("UseToCd", false, null);
			base.GetItem(0).SetUIActive(true);
			base.GetButton(3).RootUIComp.Get().SetUIActive(false);
			base.GetSprite(2).SetUIActive(true);
		}

		// Token: 0x06035A81 RID: 219777 RVA: 0x00CB55C8 File Offset: 0x00CB37C8
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

		// Token: 0x06035A82 RID: 219778 RVA: 0x00CB561A File Offset: 0x00CB381A
		public void TriggerCanUseState()
		{
			this.SwitchNorToUse();
		}

		// Token: 0x06035A83 RID: 219779 RVA: 0x00CB5624 File Offset: 0x00CB3824
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

		// Token: 0x0401C776 RID: 116598
		public Action SkillBtnClick;

		// Token: 0x0401C777 RID: 116599
		protected UiSequencePlayer Sequence;

		// Token: 0x0401C778 RID: 116600
		protected ICardSkillComponentData Data;

		// Token: 0x0200B372 RID: 45938
		[NullableContext(0)]
		private static class EComponentDefine
		{
			// Token: 0x04036627 RID: 222759
			public const int NormalItem = 0;

			// Token: 0x04036628 RID: 222760
			public const int NormalIcon = 1;

			// Token: 0x04036629 RID: 222761
			public const int CountDownIcon = 2;

			// Token: 0x0403662A RID: 222762
			public const int SkillBtn = 3;
		}
	}
}
