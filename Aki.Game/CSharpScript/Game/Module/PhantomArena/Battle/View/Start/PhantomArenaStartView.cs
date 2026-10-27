using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Start
{
	// Token: 0x02005250 RID: 21072
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaStartView : UiViewBase, IUiViewResource
	{
		// Token: 0x06035D8F RID: 220559 RVA: 0x00CBE285 File Offset: 0x00CBC485
		public PhantomArenaStartView(UiViewInfo uiViewInfo) : base(uiViewInfo)
		{
		}

		// Token: 0x06035D90 RID: 220560 RVA: 0x00CBE28E File Offset: 0x00CBC48E
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x06035D91 RID: 220561 RVA: 0x00CBE2C8 File Offset: 0x00CBC4C8
		protected override void OnStart()
		{
			this.Data = (this.OpenParam as IPhantomArenaStartViewData);
			int round = PhantomArenaBattleModel.Instance.Round;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), this.Data.ContentTextId, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "PhantomBattle_1030", new <>z__ReadOnlySingleElementList<object>(round));
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PhantomArena;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "回合开始";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("回合数", round);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.Handle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.RemoveHandle();
				base.CloseMe(null);
			}, 2000f, null, null, true, 1f);
		}

		// Token: 0x06035D92 RID: 220562 RVA: 0x00CBE38B File Offset: 0x00CBC58B
		protected override void OnBeforeDestroy()
		{
			this.RemoveHandle();
			IPhantomArenaStartViewData data = this.Data;
			if (data == null)
			{
				return;
			}
			Action callback = data.Callback;
			if (callback == null)
			{
				return;
			}
			callback();
		}

		// Token: 0x06035D93 RID: 220563 RVA: 0x00CBE3AD File Offset: 0x00CBC5AD
		private void RemoveHandle()
		{
			if (this.Handle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.Handle);
				this.Handle = null;
			}
		}

		// Token: 0x06035D94 RID: 220564 RVA: 0x00CBE3CF File Offset: 0x00CBC5CF
		public string GetExtraResourceId([Nullable(2)] object param)
		{
			IPhantomArenaStartViewData phantomArenaStartViewData = param as IPhantomArenaStartViewData;
			if (phantomArenaStartViewData != null && phantomArenaStartViewData.IsOwn)
			{
				return "UiItem_BattleStart1";
			}
			return "UiItem_BattleStart";
		}

		// Token: 0x0401C8A5 RID: 116901
		private const int SHOW_TIME = 2000;

		// Token: 0x0401C8A6 RID: 116902
		private TimerHandle Handle;

		// Token: 0x0401C8A7 RID: 116903
		private IPhantomArenaStartViewData Data;

		// Token: 0x0200B406 RID: 46086
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x040368D3 RID: 223443
			public const int TimeText = 0;

			// Token: 0x040368D4 RID: 223444
			public const int TitleText = 1;
		}
	}
}
