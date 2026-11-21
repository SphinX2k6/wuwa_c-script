using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.VisualNovel
{
	// Token: 0x020037BD RID: 14269
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class VisualNovelScene
	{
		// Token: 0x0602523F RID: 152127 RVA: 0x00A79F10 File Offset: 0x00A78110
		public VisualNovelScene() : this((int _) => null, delegate(VisualNovelCharacter character)
		{
			character.Destroy();
			return UniTask.CompletedTask;
		}, null, null, null)
		{
		}

		// Token: 0x06025240 RID: 152128 RVA: 0x00A79F64 File Offset: 0x00A78164
		public VisualNovelScene([Nullable(new byte[]
		{
			1,
			2
		})] Func<int, VisualNovelCharacter> acquireCharacter, Func<VisualNovelCharacter, UniTask> releaseCharacter, [Nullable(2)] VisualNovelBackground background = null, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Action<IReadOnlyList<VisualNovelCharacter>> applyCharacterOrder = null, [Nullable(new byte[]
		{
			2,
			1
		})] Func<IReadOnlyList<int>, UniTask> prepareCharacters = null)
		{
			this.AcquireCharacter = acquireCharacter;
			this.ReleaseCharacter = releaseCharacter;
			this.PrepareCharacters = prepareCharacters;
			this.Background = background;
			this.ApplyCharacterOrder = applyCharacterOrder;
		}

		// Token: 0x06025241 RID: 152129 RVA: 0x00A79FC8 File Offset: 0x00A781C8
		[NullableContext(2)]
		public VisualNovelCharacter GetCharacter(int characterId)
		{
			VisualNovelCharacter valueOrDefault = this.Characters.GetValueOrDefault(characterId);
			if (valueOrDefault == null || this.CharacterRemovals.ContainsKey(valueOrDefault))
			{
				return null;
			}
			return valueOrDefault;
		}

		// Token: 0x06025242 RID: 152130 RVA: 0x00A79FF8 File Offset: 0x00A781F8
		public bool TryGetCharacterRemoval(int characterId, out UniTask removal)
		{
			VisualNovelCharacter key;
			UniTaskCompletionSource uniTaskCompletionSource;
			if (this.Characters.TryGetValue(characterId, out key) && this.CharacterRemovals.TryGetValue(key, out uniTaskCompletionSource))
			{
				removal = uniTaskCompletionSource.Task;
				return true;
			}
			removal = UniTask.CompletedTask;
			return false;
		}

		// Token: 0x06025243 RID: 152131 RVA: 0x00A7A040 File Offset: 0x00A78240
		public UniTask PrepareAsync(VisualNovelItem item)
		{
			if (this.PrepareCharacters == null || this.IsDestroyed || this.ClearCompletion != null)
			{
				return UniTask.CompletedTask;
			}
			List<int> list = new List<int>();
			VisualNovelScene.CollectEnterCharacterIds(item.StartPerformances, list);
			VisualNovelScene.CollectEnterCharacterIds(item.EndPerformances, list);
			foreach (VisualNovelOption visualNovelOption in item.Options)
			{
				VisualNovelScene.CollectEnterCharacterIds(visualNovelOption.Performances, list);
			}
			if (list.Count <= 0)
			{
				return UniTask.CompletedTask;
			}
			return this.PrepareCharacters(list);
		}

		// Token: 0x06025244 RID: 152132 RVA: 0x00A7A0E8 File Offset: 0x00A782E8
		private static void CollectEnterCharacterIds([Nullable(new byte[]
		{
			2,
			1
		})] IReadOnlyList<IVisualNovelPerformanceBase> performances, List<int> characterIds)
		{
			if (performances == null)
			{
				return;
			}
			foreach (IVisualNovelPerformanceBase visualNovelPerformanceBase in performances)
			{
				IVisualNovelPerformanceEnter visualNovelPerformanceEnter = visualNovelPerformanceBase as IVisualNovelPerformanceEnter;
				if (visualNovelPerformanceEnter != null)
				{
					characterIds.Add(visualNovelPerformanceEnter.WhoId);
				}
			}
		}

		// Token: 0x06025245 RID: 152133 RVA: 0x00A7A144 File Offset: 0x00A78344
		public IEnumerable<VisualNovelCharacter> GetCharacters()
		{
			VisualNovelScene.<GetCharacters>d__19 <GetCharacters>d__ = new VisualNovelScene.<GetCharacters>d__19(-2);
			<GetCharacters>d__.<>4__this = this;
			return <GetCharacters>d__;
		}

		// Token: 0x06025246 RID: 152134 RVA: 0x00A7A154 File Offset: 0x00A78354
		[NullableContext(2)]
		public VisualNovelBackground GetBackground()
		{
			return this.Background;
		}

		// Token: 0x06025247 RID: 152135 RVA: 0x00A7A15C File Offset: 0x00A7835C
		public void SetCharacterCustomLayer(VisualNovelCharacter character, int customLayer)
		{
			int? characterId = character.CharacterId;
			VisualNovelCharacter visualNovelCharacter;
			if (characterId == null || !this.Characters.TryGetValue(characterId.Value, out visualNovelCharacter) || visualNovelCharacter != character || this.CharacterRemovals.ContainsKey(character))
			{
				return;
			}
			this.CharacterCustomLayers[character] = customLayer;
			this.RefreshCharacterOrder();
		}

		// Token: 0x06025248 RID: 152136 RVA: 0x00A7A1B5 File Offset: 0x00A783B5
		public void ResetCharacterCustomLayers()
		{
			if (this.CharacterCustomLayers.Count == 0)
			{
				return;
			}
			this.CharacterCustomLayers.Clear();
			this.RefreshCharacterOrder();
		}

		// Token: 0x06025249 RID: 152137 RVA: 0x00A7A1D8 File Offset: 0x00A783D8
		[NullableContext(2)]
		public VisualNovelCharacter CreateCharacter(int characterId)
		{
			if (this.IsDestroyed || this.ClearCompletion != null)
			{
				return null;
			}
			if (this.Characters.ContainsKey(characterId))
			{
				return this.GetCharacter(characterId);
			}
			VisualNovelCharacter visualNovelCharacter = this.AcquireCharacter(characterId);
			if (visualNovelCharacter == null)
			{
				return null;
			}
			if (!visualNovelCharacter.Load(characterId))
			{
				this.ReleaseCharacter(visualNovelCharacter).Forget();
				return null;
			}
			this.Characters.Add(characterId, visualNovelCharacter);
			Dictionary<VisualNovelCharacter, int> characterOrders = this.CharacterOrders;
			VisualNovelCharacter key = visualNovelCharacter;
			int nextCharacterOrder = this.NextCharacterOrder;
			this.NextCharacterOrder = nextCharacterOrder + 1;
			characterOrders.Add(key, nextCharacterOrder);
			this.RefreshCharacterOrder();
			return visualNovelCharacter;
		}

		// Token: 0x0602524A RID: 152138 RVA: 0x00A7A26C File Offset: 0x00A7846C
		public UniTask RemoveCharacterAsync(VisualNovelCharacter character)
		{
			UniTaskCompletionSource uniTaskCompletionSource;
			if (this.CharacterRemovals.TryGetValue(character, out uniTaskCompletionSource))
			{
				return uniTaskCompletionSource.Task;
			}
			int? characterId = character.CharacterId;
			VisualNovelCharacter visualNovelCharacter;
			if (characterId == null || !this.Characters.TryGetValue(characterId.Value, out visualNovelCharacter) || visualNovelCharacter != character)
			{
				return UniTask.CompletedTask;
			}
			UniTaskCompletionSource uniTaskCompletionSource2 = new UniTaskCompletionSource();
			this.CharacterRemovals.Add(character, uniTaskCompletionSource2);
			return this.RemoveCharacterCoreAsync(characterId.Value, character, uniTaskCompletionSource2);
		}

		// Token: 0x0602524B RID: 152139 RVA: 0x00A7A2E4 File Offset: 0x00A784E4
		private UniTask RemoveCharacterCoreAsync(int characterId, VisualNovelCharacter character, UniTaskCompletionSource completion)
		{
			VisualNovelScene.<RemoveCharacterCoreAsync>d__25 <RemoveCharacterCoreAsync>d__;
			<RemoveCharacterCoreAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RemoveCharacterCoreAsync>d__.<>4__this = this;
			<RemoveCharacterCoreAsync>d__.characterId = characterId;
			<RemoveCharacterCoreAsync>d__.character = character;
			<RemoveCharacterCoreAsync>d__.completion = completion;
			<RemoveCharacterCoreAsync>d__.<>1__state = -1;
			<RemoveCharacterCoreAsync>d__.<>t__builder.Start<VisualNovelScene.<RemoveCharacterCoreAsync>d__25>(ref <RemoveCharacterCoreAsync>d__);
			return <RemoveCharacterCoreAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602524C RID: 152140 RVA: 0x00A7A340 File Offset: 0x00A78540
		private void RefreshCharacterOrder()
		{
			if (this.ApplyCharacterOrder == null)
			{
				return;
			}
			List<VisualNovelCharacter> list = new List<VisualNovelCharacter>(this.Characters.Count);
			foreach (VisualNovelCharacter visualNovelCharacter in this.Characters.Values)
			{
				if (!this.CharacterRemovals.ContainsKey(visualNovelCharacter))
				{
					list.Add(visualNovelCharacter);
				}
			}
			list.Sort(new Comparison<VisualNovelCharacter>(this.CompareCharacterOrder));
			this.ApplyCharacterOrder(list);
		}

		// Token: 0x0602524D RID: 152141 RVA: 0x00A7A3E0 File Offset: 0x00A785E0
		private int CompareCharacterOrder(VisualNovelCharacter left, VisualNovelCharacter right)
		{
			int valueOrDefault = this.CharacterCustomLayers.GetValueOrDefault(left, 0);
			int valueOrDefault2 = this.CharacterCustomLayers.GetValueOrDefault(right, 0);
			int num = valueOrDefault.CompareTo(valueOrDefault2);
			if (num != 0)
			{
				return num;
			}
			return this.CharacterOrders.GetValueOrDefault(left, 0).CompareTo(this.CharacterOrders.GetValueOrDefault(right, 0));
		}

		// Token: 0x0602524E RID: 152142 RVA: 0x00A7A43C File Offset: 0x00A7863C
		public UniTask ClearAsync()
		{
			if (this.ClearCompletion != null)
			{
				return this.ClearCompletion.Task;
			}
			UniTaskCompletionSource uniTaskCompletionSource = new UniTaskCompletionSource();
			this.ClearCompletion = uniTaskCompletionSource;
			return this.ClearCoreAsync(uniTaskCompletionSource);
		}

		// Token: 0x0602524F RID: 152143 RVA: 0x00A7A474 File Offset: 0x00A78674
		private UniTask ClearCoreAsync(UniTaskCompletionSource completion)
		{
			VisualNovelScene.<ClearCoreAsync>d__29 <ClearCoreAsync>d__;
			<ClearCoreAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ClearCoreAsync>d__.<>4__this = this;
			<ClearCoreAsync>d__.completion = completion;
			<ClearCoreAsync>d__.<>1__state = -1;
			<ClearCoreAsync>d__.<>t__builder.Start<VisualNovelScene.<ClearCoreAsync>d__29>(ref <ClearCoreAsync>d__);
			return <ClearCoreAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025250 RID: 152144 RVA: 0x00A7A4C0 File Offset: 0x00A786C0
		public UniTask DestroyAsync()
		{
			if (this.DestroyCompletion != null)
			{
				return this.DestroyCompletion.Task;
			}
			this.IsDestroyed = true;
			UniTaskCompletionSource uniTaskCompletionSource = new UniTaskCompletionSource();
			this.DestroyCompletion = uniTaskCompletionSource;
			return this.DestroyCoreAsync(uniTaskCompletionSource);
		}

		// Token: 0x06025251 RID: 152145 RVA: 0x00A7A4FC File Offset: 0x00A786FC
		private UniTask DestroyCoreAsync(UniTaskCompletionSource completion)
		{
			VisualNovelScene.<DestroyCoreAsync>d__31 <DestroyCoreAsync>d__;
			<DestroyCoreAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DestroyCoreAsync>d__.<>4__this = this;
			<DestroyCoreAsync>d__.completion = completion;
			<DestroyCoreAsync>d__.<>1__state = -1;
			<DestroyCoreAsync>d__.<>t__builder.Start<VisualNovelScene.<DestroyCoreAsync>d__31>(ref <DestroyCoreAsync>d__);
			return <DestroyCoreAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401489C RID: 84124
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly Func<int, VisualNovelCharacter> AcquireCharacter;

		// Token: 0x0401489D RID: 84125
		private readonly Func<VisualNovelCharacter, UniTask> ReleaseCharacter;

		// Token: 0x0401489E RID: 84126
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private readonly Func<IReadOnlyList<int>, UniTask> PrepareCharacters;

		// Token: 0x0401489F RID: 84127
		[Nullable(2)]
		private readonly VisualNovelBackground Background;

		// Token: 0x040148A0 RID: 84128
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private readonly Action<IReadOnlyList<VisualNovelCharacter>> ApplyCharacterOrder;

		// Token: 0x040148A1 RID: 84129
		private readonly Dictionary<int, VisualNovelCharacter> Characters = new Dictionary<int, VisualNovelCharacter>();

		// Token: 0x040148A2 RID: 84130
		private readonly Dictionary<VisualNovelCharacter, UniTaskCompletionSource> CharacterRemovals = new Dictionary<VisualNovelCharacter, UniTaskCompletionSource>();

		// Token: 0x040148A3 RID: 84131
		private readonly Dictionary<VisualNovelCharacter, int> CharacterOrders = new Dictionary<VisualNovelCharacter, int>();

		// Token: 0x040148A4 RID: 84132
		private readonly Dictionary<VisualNovelCharacter, int> CharacterCustomLayers = new Dictionary<VisualNovelCharacter, int>();

		// Token: 0x040148A5 RID: 84133
		[Nullable(2)]
		private UniTaskCompletionSource ClearCompletion;

		// Token: 0x040148A6 RID: 84134
		[Nullable(2)]
		private UniTaskCompletionSource DestroyCompletion;

		// Token: 0x040148A7 RID: 84135
		private int NextCharacterOrder;

		// Token: 0x040148A8 RID: 84136
		private bool IsDestroyed;
	}
}
