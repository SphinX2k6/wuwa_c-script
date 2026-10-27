using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BD4 RID: 23508
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CiacconaGalStepChoiceItem : GridProxyAbstract<CiacconaGalChoiceData>
	{
		// Token: 0x0603B6E6 RID: 243430 RVA: 0x00E2BD94 File Offset: 0x00E29F94
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIExtendToggleTextureTransition));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClicked));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603B6E7 RID: 243431 RVA: 0x00E2BE5B File Offset: 0x00E2A05B
		protected override void OnStart()
		{
			this.Toggle = base.GetExtendToggle(0);
			this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0603B6E8 RID: 243432 RVA: 0x00E2BE7C File Offset: 0x00E2A07C
		protected override void OnAfterShow()
		{
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer == null)
			{
				return;
			}
			seqPlayer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x0603B6E9 RID: 243433 RVA: 0x00E2BEA9 File Offset: 0x00E2A0A9
		[NullableContext(1)]
		public override void Refresh(CiacconaGalChoiceData data, bool isSelected, int gridIndex)
		{
			this.ChoiceData = data;
			this.RefreshContent();
			this.RefreshState();
		}

		// Token: 0x0603B6EA RID: 243434 RVA: 0x00E2BEBE File Offset: 0x00E2A0BE
		private void RefreshContent()
		{
			if (this.ChoiceData == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), this.ChoiceData.Content, Array.Empty<object>());
		}

		// Token: 0x0603B6EB RID: 243435 RVA: 0x00E2BEEC File Offset: 0x00E2A0EC
		private void RefreshState()
		{
			if (this.ChoiceData == null)
			{
				return;
			}
			UUIExtendToggle toggle = this.Toggle;
			if (toggle != null)
			{
				toggle.OnPointUpCallBack.Unbind();
			}
			switch (this.ChoiceData.State)
			{
			case ECiacconaGalStepState.Normal:
			{
				if (this.LastState == ECiacconaGalStepState.LockingByInspiration)
				{
					LevelSequencePlayer seqPlayer = this.SeqPlayer;
					if (seqPlayer != null)
					{
						seqPlayer.PlayLevelSequenceByName("Use", false, null, false);
					}
				}
				this.UpdateIcon("T_PlotReasoningIcon04");
				UUIExtendToggle toggle2 = this.Toggle;
				if (toggle2 != null)
				{
					toggle2.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
				}
				break;
			}
			case ECiacconaGalStepState.LockingByInspiration:
			{
				this.UpdateIcon("T_PlotReasoningIcon02");
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Xkjsx_Inspiration_Unlockcondition", new int[]
				{
					this.ChoiceData.RequiredInspiration
				});
				UUIExtendToggle toggle3 = this.Toggle;
				if (toggle3 != null)
				{
					toggle3.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
				}
				break;
			}
			case ECiacconaGalStepState.LockingByCondition:
			{
				this.UpdateIcon("T_PlotReasoningIcon01");
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), this.ChoiceData.Content, Array.Empty<object>());
				UUIExtendToggle toggle4 = this.Toggle;
				if (toggle4 != null)
				{
					toggle4.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
				}
				break;
			}
			case ECiacconaGalStepState.Chosen:
			{
				this.UpdateIcon("T_PlotReasoningIcon03");
				UUIExtendToggle toggle5 = this.Toggle;
				if (toggle5 != null)
				{
					toggle5.SetToggleState(EToggleState.ETT_UnDetermined, false, false, false);
				}
				UUIExtendToggle toggle6 = this.Toggle;
				if (toggle6 != null)
				{
					toggle6.OnPointUpCallBack.Bind(new Action<EToggleState>(this.OnToggleClicked));
				}
				break;
			}
			}
			this.LastState = this.ChoiceData.State;
		}

		// Token: 0x0603B6EC RID: 243436 RVA: 0x00E2C084 File Offset: 0x00E2A284
		[NullableContext(1)]
		private UniTask UpdateIcon(string resourceName)
		{
			CiacconaGalStepChoiceItem.<UpdateIcon>d__11 <UpdateIcon>d__;
			<UpdateIcon>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateIcon>d__.<>4__this = this;
			<UpdateIcon>d__.resourceName = resourceName;
			<UpdateIcon>d__.<>1__state = -1;
			<UpdateIcon>d__.<>t__builder.Start<CiacconaGalStepChoiceItem.<UpdateIcon>d__11>(ref <UpdateIcon>d__);
			return <UpdateIcon>d__.<>t__builder.Task;
		}

		// Token: 0x0603B6ED RID: 243437 RVA: 0x00E2C0CF File Offset: 0x00E2A2CF
		private void OnToggleClicked(EToggleState state)
		{
			CiacconaGalController.Instance.GalPlayer.OnClick(new int?(this.ChoiceData.Id));
		}

		// Token: 0x0401EF7D RID: 126845
		private CiacconaGalChoiceData ChoiceData;

		// Token: 0x0401EF7E RID: 126846
		private ECiacconaGalStepState LastState;

		// Token: 0x0401EF7F RID: 126847
		private UUIExtendToggle Toggle;

		// Token: 0x0401EF80 RID: 126848
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0200BDAD RID: 48557
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04039341 RID: 234305
			public const int Toggle = 0;

			// Token: 0x04039342 RID: 234306
			public const int TextContent = 1;

			// Token: 0x04039343 RID: 234307
			public const int ImageIcon = 2;
		}
	}
}
