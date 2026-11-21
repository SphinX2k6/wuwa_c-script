using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Start
{
	// Token: 0x02004220 RID: 16928
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaStartView : UiViewBase, IUiViewResource
	{
		// Token: 0x0602AC8A RID: 175242 RVA: 0x00C0B915 File Offset: 0x00C09B15
		public PhantomArenaStartView(UiViewInfo uiViewInfo) : base(uiViewInfo)
		{
		}

		// Token: 0x0602AC8B RID: 175243 RVA: 0x00C0B91E File Offset: 0x00C09B1E
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x0602AC8C RID: 175244 RVA: 0x00C0B958 File Offset: 0x00C09B58
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

		// Token: 0x0602AC8D RID: 175245 RVA: 0x00C0BA1B File Offset: 0x00C09C1B
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

		// Token: 0x0602AC8E RID: 175246 RVA: 0x00C0BA3D File Offset: 0x00C09C3D
		private void RemoveHandle()
		{
			if (this.Handle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.Handle);
				this.Handle = null;
			}
		}

		// Token: 0x0602AC8F RID: 175247 RVA: 0x00C0BA5F File Offset: 0x00C09C5F
		public string GetExtraResourceId([Nullable(2)] object param)
		{
			IPhantomArenaStartViewData phantomArenaStartViewData = param as IPhantomArenaStartViewData;
			if (phantomArenaStartViewData != null && phantomArenaStartViewData.IsOwn)
			{
				return "UiItem_BattleStart1";
			}
			return "UiItem_BattleStart";
		}

		// Token: 0x040172DA RID: 94938
		private const int SHOW_TIME = 2000;

		// Token: 0x040172DB RID: 94939
		private TimerHandle Handle;

		// Token: 0x040172DC RID: 94940
		private IPhantomArenaStartViewData Data;

		// Token: 0x02009E3E RID: 40510
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04031326 RID: 201510
			public const int TimeText = 0;

			// Token: 0x04031327 RID: 201511
			public const int TitleText = 1;
		}
	}
}
