using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.View
{
	// Token: 0x020064E3 RID: 25827
	public class MatchThreeSkillTipsView : UiPanelBase
	{
		// Token: 0x06040D60 RID: 265568 RVA: 0x00FB49BC File Offset: 0x00FB2BBC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06040D61 RID: 265569 RVA: 0x00FB4A25 File Offset: 0x00FB2C25
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
		}

		// Token: 0x06040D62 RID: 265570 RVA: 0x00FB4A38 File Offset: 0x00FB2C38
		[NullableContext(2)]
		public void SetContent(string icon, string nameKey)
		{
			if (!string.IsNullOrEmpty(nameKey))
			{
				UUIText text = base.GetText(1);
				if (text != null)
				{
					text.ShowTextNew(nameKey);
				}
			}
			UUISprite sprite = base.GetSprite(0);
			if (sprite != null && !string.IsNullOrEmpty(icon))
			{
				this.SetSpriteByPath(icon, sprite, false, null, null);
			}
		}

		// Token: 0x06040D63 RID: 265571 RVA: 0x00FB4A88 File Offset: 0x00FB2C88
		protected override UniTask OnShowAsyncImplementImplement()
		{
			MatchThreeSkillTipsView.<OnShowAsyncImplementImplement>d__5 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<MatchThreeSkillTipsView.<OnShowAsyncImplementImplement>d__5>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06040D64 RID: 265572 RVA: 0x00FB4ACB File Offset: 0x00FB2CCB
		protected override void OnBeforeDestroy()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x04021C6F RID: 138351
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0200C722 RID: 50978
		private enum EComponent
		{
			// Token: 0x0403C293 RID: 246419
			SprIcon,
			// Token: 0x0403C294 RID: 246420
			TextName
		}
	}
}
