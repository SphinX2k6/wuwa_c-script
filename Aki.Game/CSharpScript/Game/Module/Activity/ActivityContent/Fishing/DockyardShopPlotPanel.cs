using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065C0 RID: 26048
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardShopPlotPanel : UiPanelBase
	{
		// Token: 0x06041570 RID: 267632 RVA: 0x00FD5694 File Offset: 0x00FD3894
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

		// Token: 0x06041571 RID: 267633 RVA: 0x00FD5700 File Offset: 0x00FD3900
		private void PlayPlot()
		{
			FishingNpcPerform fishingNpcPerform = FishingConfig.Instance.GetFishingNpcPerform(this.PerformId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), fishingNpcPerform.Title, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), fishingNpcPerform.Content, Array.Empty<object>());
		}

		// Token: 0x06041572 RID: 267634 RVA: 0x00FD5758 File Offset: 0x00FD3958
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

		// Token: 0x06041573 RID: 267635 RVA: 0x00FD57DD File Offset: 0x00FD39DD
		private void PlayAudio(string audioEvent)
		{
			AudioSystem.Instance.PostEvent(audioEvent);
		}

		// Token: 0x06041574 RID: 267636 RVA: 0x00FD57EC File Offset: 0x00FD39EC
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

		// Token: 0x06041575 RID: 267637 RVA: 0x00FD584A File Offset: 0x00FD3A4A
		private void Refresh()
		{
			this.PlayPlot();
			this.PlayOther();
		}

		// Token: 0x06041576 RID: 267638 RVA: 0x00FD5858 File Offset: 0x00FD3A58
		public void ShowPanel(string performId)
		{
			this.PerformId = performId;
			this.Refresh();
			this.SetActive(true);
		}

		// Token: 0x06041577 RID: 267639 RVA: 0x00FD586E File Offset: 0x00FD3A6E
		public void HidePanel()
		{
			this.SetActive(false);
		}

		// Token: 0x04022008 RID: 139272
		private string PerformId = string.Empty;

		// Token: 0x04022009 RID: 139273
		public int EntityId;

		// Token: 0x0402200A RID: 139274
		private double LastTimeStamp;

		// Token: 0x0402200B RID: 139275
		private const int COOLDOWN_TIME = 5000;

		// Token: 0x0200C7E3 RID: 51171
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403C5F6 RID: 247286
			public const int Name = 0;

			// Token: 0x0403C5F7 RID: 247287
			public const int Content = 1;
		}
	}
}
