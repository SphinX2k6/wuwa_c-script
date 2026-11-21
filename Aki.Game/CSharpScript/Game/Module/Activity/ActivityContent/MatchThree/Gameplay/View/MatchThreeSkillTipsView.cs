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
	// Token: 0x02005461 RID: 21601
	public class MatchThreeSkillTipsView : UiPanelBase
	{
		// Token: 0x06035A24 RID: 219684 RVA: 0x00EFB9EC File Offset: 0x00EF9BEC
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

		// Token: 0x06035A25 RID: 219685 RVA: 0x00EFBA55 File Offset: 0x00EF9C55
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
		}

		// Token: 0x06035A26 RID: 219686 RVA: 0x00EFBA68 File Offset: 0x00EF9C68
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

		// Token: 0x06035A27 RID: 219687 RVA: 0x00EFBAB8 File Offset: 0x00EF9CB8
		protected override UniTask OnShowAsyncImplementImplement()
		{
			MatchThreeSkillTipsView.<OnShowAsyncImplementImplement>d__5 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<MatchThreeSkillTipsView.<OnShowAsyncImplementImplement>d__5>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06035A28 RID: 219688 RVA: 0x00EFBAFB File Offset: 0x00EF9CFB
		protected override void OnBeforeDestroy()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x0401C5A0 RID: 116128
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0200B108 RID: 45320
		private enum EComponent
		{
			// Token: 0x04036BEE RID: 224238
			SprIcon,
			// Token: 0x04036BEF RID: 224239
			TextName
		}
	}
}
