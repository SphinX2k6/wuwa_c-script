using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x02005846 RID: 22598
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class InteractionProcessor
	{
		// Token: 0x17008A41 RID: 35393
		// (get) Token: 0x06039703 RID: 235267 RVA: 0x00DA2043 File Offset: 0x00DA0243
		// (set) Token: 0x06039704 RID: 235268 RVA: 0x00DA204B File Offset: 0x00DA024B
		private protected EInteractionType InteractionType { protected get; private set; }

		// Token: 0x17008A42 RID: 35394
		// (get) Token: 0x06039705 RID: 235269 RVA: 0x00DA2054 File Offset: 0x00DA0254
		// (set) Token: 0x06039706 RID: 235270 RVA: 0x00DA205C File Offset: 0x00DA025C
		protected bool IsPressing { get; set; }

		// Token: 0x17008A43 RID: 35395
		// (get) Token: 0x06039707 RID: 235271 RVA: 0x00DA2065 File Offset: 0x00DA0265
		// (set) Token: 0x06039708 RID: 235272 RVA: 0x00DA206D File Offset: 0x00DA026D
		protected bool IsCompleteInternal { get; set; }

		// Token: 0x17008A44 RID: 35396
		// (get) Token: 0x06039709 RID: 235273 RVA: 0x00DA2076 File Offset: 0x00DA0276
		// (set) Token: 0x0603970A RID: 235274 RVA: 0x00DA207E File Offset: 0x00DA027E
		private protected int Index { protected get; private set; }

		// Token: 0x17008A45 RID: 35397
		// (get) Token: 0x0603970B RID: 235275 RVA: 0x00DA2087 File Offset: 0x00DA0287
		// (set) Token: 0x0603970C RID: 235276 RVA: 0x00DA208F File Offset: 0x00DA028F
		private protected Entity Entity { protected get; private set; }

		// Token: 0x17008A46 RID: 35398
		// (get) Token: 0x0603970D RID: 235277 RVA: 0x00DA2098 File Offset: 0x00DA0298
		public bool IsLongPressing
		{
			get
			{
				return this.IsLongPressType && this.IsPressing;
			}
		}

		// Token: 0x17008A47 RID: 35399
		// (get) Token: 0x0603970E RID: 235278 RVA: 0x00DA20AA File Offset: 0x00DA02AA
		public bool IsLongPressType
		{
			get
			{
				return this.InteractionType == EInteractionType.LongPress;
			}
		}

		// Token: 0x0603970F RID: 235279 RVA: 0x00DA20B5 File Offset: 0x00DA02B5
		protected InteractionProcessor(Entity entity, int index, EInteractionType type)
		{
			this.InteractionType = type;
			this.Entity = entity;
			this.Index = index;
		}

		// Token: 0x06039710 RID: 235280
		public abstract void OnPress();

		// Token: 0x06039711 RID: 235281
		public abstract void OnRelease();

		// Token: 0x06039712 RID: 235282
		public abstract void OnReset();

		// Token: 0x06039713 RID: 235283 RVA: 0x00DA20D2 File Offset: 0x00DA02D2
		public bool IsCompleted()
		{
			return this.IsCompleteInternal;
		}

		// Token: 0x06039714 RID: 235284 RVA: 0x00DA20DA File Offset: 0x00DA02DA
		public void Reset()
		{
			this.IsCompleteInternal = false;
			this.OnReset();
		}

		// Token: 0x06039715 RID: 235285 RVA: 0x00DA20E9 File Offset: 0x00DA02E9
		[NullableContext(0)]
		public virtual UniTask<bool> LoadAsset()
		{
			return UniTask.FromResult<bool>(true);
		}

		// Token: 0x06039716 RID: 235286 RVA: 0x00DA20F1 File Offset: 0x00DA02F1
		protected void TriggerComplete()
		{
			this.IsCompleteInternal = true;
		}
	}
}
