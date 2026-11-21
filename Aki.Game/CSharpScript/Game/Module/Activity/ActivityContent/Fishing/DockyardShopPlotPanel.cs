using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200553E RID: 21822
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardShopPlotPanel : UiPanelBase
	{
		// Token: 0x06036235 RID: 221749 RVA: 0x00F1C6D0 File Offset: 0x00F1A8D0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06036236 RID: 221750 RVA: 0x00F1C73C File Offset: 0x00F1A93C
		private void PlayPlot()
		{
			FishingNpcPerform fishingNpcPerform = FishingConfig.Instance.GetFishingNpcPerform(this.PerformId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), fishingNpcPerform.Title, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), fishingNpcPerform.Content, Array.Empty<object>());
		}

		// Token: 0x06036237 RID: 221751 RVA: 0x00F1C794 File Offset: 0x00F1A994
		private void PlayNpcMontage(string montageName)
		{
			int entityIdByPbDataId = CreatureModel.Instance.GetEntityIdByPbDataId(this.EntityId);
			EntityHandle entityById = CreatureModel.Instance.GetEntityById(entityIdByPbDataId);
			if (entityById != null)
			{
				object obj;
				if (entityById == null)
				{
					obj = null;
				}
				else
				{
					WorldEntity entity = entityById.Entity;
					obj = ((entity != null) ? entity.GetComponent<NpcPerformComponent>() : null);
				}
				BaseAnimationComponent baseAnimationComponent;
				if (entityById == null)
				{
					baseAnimationComponent = null;
				}
				else
				{
					WorldEntity entity2 = entityById.Entity;
					baseAnimationComponent = ((entity2 != null) ? entity2.GetComponent<BaseAnimationComponent>() : null);
				}
				BaseAnimationComponent baseAnimationComponent2 = baseAnimationComponent;
				object obj2 = obj;
				if (obj2 == null)
				{
					return;
				}
				obj2.PlayPerformMontage(EPerformMode.Action, new IPlayMontageParam
				{
					MontagePath = ((baseAnimationComponent2 != null) ? baseAnimationComponent2.GetMontageResPathByName(montageName) : null)
				}, null, null, false);
			}
		}

		// Token: 0x06036238 RID: 221752 RVA: 0x00F1C819 File Offset: 0x00F1AA19
		private void PlayAudio(string audioEvent)
		{
			AudioSystem.Instance.PostEvent(audioEvent);
		}

		// Token: 0x06036239 RID: 221753 RVA: 0x00F1C828 File Offset: 0x00F1AA28
		private void PlayOther()
		{
			double serverTimeStamp = Time.Instance.ServerTimeStamp;
			if (serverTimeStamp - this.LastTimeStamp < 5000.0)
			{
				return;
			}
			this.LastTimeStamp = serverTimeStamp;
			FishingNpcPerform fishingNpcPerform = FishingConfig.Instance.GetFishingNpcPerform(this.PerformId);
			this.PlayNpcMontage(fishingNpcPerform.MontagePath);
			this.PlayAudio(fishingNpcPerform.AudioEvent);
		}

		// Token: 0x0603623A RID: 221754 RVA: 0x00F1C886 File Offset: 0x00F1AA86
		private void Refresh()
		{
			this.PlayPlot();
			this.PlayOther();
		}

		// Token: 0x0603623B RID: 221755 RVA: 0x00F1C894 File Offset: 0x00F1AA94
		public void ShowPanel(string performId)
		{
			this.PerformId = performId;
			this.Refresh();
			this.SetActive(true);
		}

		// Token: 0x0603623C RID: 221756 RVA: 0x00F1C8AA File Offset: 0x00F1AAAA
		public void HidePanel()
		{
			this.SetActive(false);
		}

		// Token: 0x0401C939 RID: 117049
		private string PerformId = string.Empty;

		// Token: 0x0401C93A RID: 117050
		public int EntityId;

		// Token: 0x0401C93B RID: 117051
		private double LastTimeStamp;

		// Token: 0x0401C93C RID: 117052
		private const int COOLDOWN_TIME = 5000;

		// Token: 0x0200B1C6 RID: 45510
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04036F44 RID: 225092
			public const int Name = 0;

			// Token: 0x04036F45 RID: 225093
			public const int Content = 1;
		}
	}
}
