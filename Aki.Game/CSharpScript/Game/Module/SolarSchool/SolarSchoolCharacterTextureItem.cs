using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.VisualNovel;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A12 RID: 23058
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolCharacterTextureItem : UiPanelBase
	{
		// Token: 0x17006C6C RID: 27756
		// (get) Token: 0x06038C85 RID: 232581 RVA: 0x00FE52A5 File Offset: 0x00FE34A5
		// (set) Token: 0x06038C86 RID: 232582 RVA: 0x00FE52AD File Offset: 0x00FE34AD
		public VisualNovelTextureCharacter Character { get; private set; }

		// Token: 0x06038C87 RID: 232583 RVA: 0x00FE52B8 File Offset: 0x00FE34B8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038C88 RID: 232584 RVA: 0x00FE5300 File Offset: 0x00FE3500
		protected override UniTask OnBeforeStartAsync()
		{
			this.Character = new VisualNovelTextureCharacter(base.GetRootItem(), base.GetTexture(0), () => this.AssetCache);
			return UniTask.CompletedTask;
		}

		// Token: 0x06038C89 RID: 232585 RVA: 0x00FE532B File Offset: 0x00FE352B
		public void SetAssetCache(VisualNovelAssetCache assetCache)
		{
			this.AssetCache = assetCache;
		}

		// Token: 0x06038C8A RID: 232586 RVA: 0x00FE5334 File Offset: 0x00FE3534
		protected override void OnBeforeDestroy()
		{
			VisualNovelTextureCharacter character = this.Character;
			if (character == null)
			{
				return;
			}
			character.Destroy();
		}

		// Token: 0x0401DE41 RID: 122433
		private const int CharacterTexture = 0;

		// Token: 0x0401DE42 RID: 122434
		private VisualNovelAssetCache AssetCache;
	}
}
