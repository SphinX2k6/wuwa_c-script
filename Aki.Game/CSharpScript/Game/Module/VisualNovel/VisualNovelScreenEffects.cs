using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.VisualNovel
{
	// Token: 0x020037BF RID: 14271
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class VisualNovelScreenEffects
	{
		// Token: 0x06025262 RID: 152162 RVA: 0x00A7A812 File Offset: 0x00A78A12
		public VisualNovelScreenEffects(UiPanelBase owner, VisualNovelContext context)
		{
			this.Owner = owner;
			this.Context = context;
		}

		// Token: 0x06025263 RID: 152163 RVA: 0x00A7A84C File Offset: 0x00A78A4C
		public UniTask PrepareAsync(VisualNovelItem item)
		{
			Dictionary<string, int> dictionary = new Dictionary<string, int>();
			VisualNovelScreenEffects.CollectPaths(item.StartPerformances, dictionary);
			VisualNovelScreenEffects.CollectPaths(item.EndPerformances, dictionary);
			foreach (VisualNovelOption visualNovelOption in item.Options)
			{
				VisualNovelScreenEffects.CollectPaths(visualNovelOption.Performances, dictionary);
			}
			foreach (KeyValuePair<string, List<VisualNovelScreenEffectItem>> keyValuePair in this.PreparedItems)
			{
				string text;
				List<VisualNovelScreenEffectItem> list;
				keyValuePair.Deconstruct(out text, out list);
				string key = text;
				List<VisualNovelScreenEffectItem> list2 = list;
				int valueOrDefault = dictionary.GetValueOrDefault(key, 0);
				for (int i = list2.Count - 1; i >= valueOrDefault; i--)
				{
					list2[i].Dispose();
					list2.RemoveAt(i);
				}
				if (list2.Count == 0)
				{
					this.PreparedItems.Remove(key);
				}
			}
			List<UniTask> list3 = new List<UniTask>();
			UUIItem rootItem = this.Owner.GetRootItem();
			foreach (KeyValuePair<string, int> keyValuePair2 in dictionary)
			{
				string text;
				int num;
				keyValuePair2.Deconstruct(out text, out num);
				string text2 = text;
				int num2 = num;
				List<VisualNovelScreenEffectItem> list4;
				if (!this.PreparedItems.TryGetValue(text2, out list4))
				{
					list4 = new List<VisualNovelScreenEffectItem>(num2);
					this.PreparedItems.Add(text2, list4);
				}
				while (list4.Count < num2)
				{
					VisualNovelScreenEffectItem visualNovelScreenEffectItem = new VisualNovelScreenEffectItem(text2);
					list4.Add(visualNovelScreenEffectItem);
					list3.Add(visualNovelScreenEffectItem.PrepareAsync(rootItem));
				}
			}
			return UniTask.WhenAll(list3);
		}

		// Token: 0x06025264 RID: 152164 RVA: 0x00A7AA18 File Offset: 0x00A78C18
		public UniTask PlayAsync(string path, bool persistent)
		{
			VisualNovelScreenEffects.<PlayAsync>d__7 <PlayAsync>d__;
			<PlayAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayAsync>d__.<>4__this = this;
			<PlayAsync>d__.path = path;
			<PlayAsync>d__.persistent = persistent;
			<PlayAsync>d__.<>1__state = -1;
			<PlayAsync>d__.<>t__builder.Start<VisualNovelScreenEffects.<PlayAsync>d__7>(ref <PlayAsync>d__);
			return <PlayAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025265 RID: 152165 RVA: 0x00A7AA6C File Offset: 0x00A78C6C
		public UniTask StopAsync(string path)
		{
			VisualNovelScreenEffects.<StopAsync>d__8 <StopAsync>d__;
			<StopAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<StopAsync>d__.<>4__this = this;
			<StopAsync>d__.path = path;
			<StopAsync>d__.<>1__state = -1;
			<StopAsync>d__.<>t__builder.Start<VisualNovelScreenEffects.<StopAsync>d__8>(ref <StopAsync>d__);
			return <StopAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025266 RID: 152166 RVA: 0x00A7AAB8 File Offset: 0x00A78CB8
		public void Complete(string path)
		{
			foreach (VisualNovelScreenEffectItem visualNovelScreenEffectItem in this.Items.ToArray())
			{
				if (visualNovelScreenEffectItem.Path == path)
				{
					visualNovelScreenEffectItem.Complete();
				}
			}
		}

		// Token: 0x06025267 RID: 152167 RVA: 0x00A7AAF8 File Offset: 0x00A78CF8
		public void CompleteAll()
		{
			VisualNovelScreenEffectItem[] array = this.Items.ToArray();
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Complete();
			}
		}

		// Token: 0x06025268 RID: 152168 RVA: 0x00A7AB28 File Offset: 0x00A78D28
		public void SetPlaybackRate(float playbackRate)
		{
			foreach (VisualNovelScreenEffectItem visualNovelScreenEffectItem in this.Items)
			{
				visualNovelScreenEffectItem.SetPlaybackRate(playbackRate);
			}
		}

		// Token: 0x06025269 RID: 152169 RVA: 0x00A7AB7C File Offset: 0x00A78D7C
		public void SetPaused(bool paused)
		{
			VisualNovelScreenEffectItem[] array = this.Items.ToArray();
			for (int i = 0; i < array.Length; i++)
			{
				array[i].SetPaused(paused);
			}
		}

		// Token: 0x0602526A RID: 152170 RVA: 0x00A7ABAC File Offset: 0x00A78DAC
		public void Clear()
		{
			VisualNovelScreenEffectItem[] array = this.Items.ToArray();
			this.Items.Clear();
			this.PersistentItems.Clear();
			VisualNovelScreenEffectItem[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].Dispose();
			}
			foreach (List<VisualNovelScreenEffectItem> list in this.PreparedItems.Values)
			{
				foreach (VisualNovelScreenEffectItem visualNovelScreenEffectItem in list)
				{
					visualNovelScreenEffectItem.Dispose();
				}
			}
			this.PreparedItems.Clear();
		}

		// Token: 0x0602526B RID: 152171 RVA: 0x00A7AC78 File Offset: 0x00A78E78
		private static void CollectPaths([Nullable(new byte[]
		{
			2,
			1
		})] IReadOnlyList<IVisualNovelPerformanceBase> performances, Dictionary<string, int> counts)
		{
			if (performances == null)
			{
				return;
			}
			foreach (IVisualNovelPerformanceBase visualNovelPerformanceBase in performances)
			{
				IVisualNovelPerformancePlayScreenEffect visualNovelPerformancePlayScreenEffect = visualNovelPerformanceBase as IVisualNovelPerformancePlayScreenEffect;
				if (visualNovelPerformancePlayScreenEffect != null)
				{
					IVisualNovelPlayScreenEffectConfigBase effectConfig = visualNovelPerformancePlayScreenEffect.EffectConfig;
					IVisualNovelPlayScreenEffectOneShot visualNovelPlayScreenEffectOneShot = effectConfig as IVisualNovelPlayScreenEffectOneShot;
					string text;
					if (visualNovelPlayScreenEffectOneShot == null)
					{
						IVisualNovelPlayScreenEffectPersistent visualNovelPlayScreenEffectPersistent = effectConfig as IVisualNovelPlayScreenEffectPersistent;
						if (visualNovelPlayScreenEffectPersistent == null)
						{
							text = string.Empty;
						}
						else
						{
							text = visualNovelPlayScreenEffectPersistent.PersistentEffectPath;
						}
					}
					else
					{
						text = visualNovelPlayScreenEffectOneShot.OneShotEffectPath;
					}
					string text2 = text;
					if (!string.IsNullOrEmpty(text2))
					{
						counts[text2] = counts.GetValueOrDefault(text2, 0) + 1;
					}
				}
			}
		}

		// Token: 0x0602526C RID: 152172 RVA: 0x00A7AD20 File Offset: 0x00A78F20
		private UniTask PlayOneShotAsync(VisualNovelScreenEffectItem item)
		{
			VisualNovelScreenEffects.<PlayOneShotAsync>d__15 <PlayOneShotAsync>d__;
			<PlayOneShotAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayOneShotAsync>d__.<>4__this = this;
			<PlayOneShotAsync>d__.item = item;
			<PlayOneShotAsync>d__.<>1__state = -1;
			<PlayOneShotAsync>d__.<>t__builder.Start<VisualNovelScreenEffects.<PlayOneShotAsync>d__15>(ref <PlayOneShotAsync>d__);
			return <PlayOneShotAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602526D RID: 152173 RVA: 0x00A7AD6C File Offset: 0x00A78F6C
		private void Remove(VisualNovelScreenEffectItem item)
		{
			this.Items.Remove(item);
			VisualNovelScreenEffectItem visualNovelScreenEffectItem;
			if (this.PersistentItems.TryGetValue(item.Path, out visualNovelScreenEffectItem) && visualNovelScreenEffectItem == item)
			{
				this.PersistentItems.Remove(item.Path);
			}
			item.Dispose();
		}

		// Token: 0x040148B3 RID: 84147
		private readonly UiPanelBase Owner;

		// Token: 0x040148B4 RID: 84148
		private readonly VisualNovelContext Context;

		// Token: 0x040148B5 RID: 84149
		private readonly List<VisualNovelScreenEffectItem> Items = new List<VisualNovelScreenEffectItem>();

		// Token: 0x040148B6 RID: 84150
		private readonly Dictionary<string, VisualNovelScreenEffectItem> PersistentItems = new Dictionary<string, VisualNovelScreenEffectItem>();

		// Token: 0x040148B7 RID: 84151
		private readonly Dictionary<string, List<VisualNovelScreenEffectItem>> PreparedItems = new Dictionary<string, List<VisualNovelScreenEffectItem>>();
	}
}
