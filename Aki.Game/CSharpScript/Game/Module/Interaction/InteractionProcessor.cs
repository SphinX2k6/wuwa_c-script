using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x0200481E RID: 18462
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class InteractionProcessor
	{
		// Token: 0x17005E0A RID: 24074
		// (get) Token: 0x0602E61A RID: 189978 RVA: 0x00CF0D1B File Offset: 0x00CEEF1B
		// (set) Token: 0x0602E61B RID: 189979 RVA: 0x00CF0D23 File Offset: 0x00CEEF23
		private protected EInteractionType InteractionType { protected get; private set; }

		// Token: 0x17005E0B RID: 24075
		// (get) Token: 0x0602E61C RID: 189980 RVA: 0x00CF0D2C File Offset: 0x00CEEF2C
		// (set) Token: 0x0602E61D RID: 189981 RVA: 0x00CF0D34 File Offset: 0x00CEEF34
		protected bool IsPressing { get; set; }

		// Token: 0x17005E0C RID: 24076
		// (get) Token: 0x0602E61E RID: 189982 RVA: 0x00CF0D3D File Offset: 0x00CEEF3D
		// (set) Token: 0x0602E61F RID: 189983 RVA: 0x00CF0D45 File Offset: 0x00CEEF45
		protected bool IsCompleteInternal { get; set; }

		// Token: 0x17005E0D RID: 24077
		// (get) Token: 0x0602E620 RID: 189984 RVA: 0x00CF0D4E File Offset: 0x00CEEF4E
		// (set) Token: 0x0602E621 RID: 189985 RVA: 0x00CF0D56 File Offset: 0x00CEEF56
		private protected int Index { protected get; private set; }

		// Token: 0x17005E0E RID: 24078
		// (get) Token: 0x0602E622 RID: 189986 RVA: 0x00CF0D5F File Offset: 0x00CEEF5F
		// (set) Token: 0x0602E623 RID: 189987 RVA: 0x00CF0D67 File Offset: 0x00CEEF67
		private protected Entity Entity { protected get; private set; }

		// Token: 0x17005E0F RID: 24079
		// (get) Token: 0x0602E624 RID: 189988 RVA: 0x00CF0D70 File Offset: 0x00CEEF70
		public bool IsLongPressing
		{
			get
			{
				return this.IsLongPressType && this.IsPressing;
			}
		}

		// Token: 0x17005E10 RID: 24080
		// (get) Token: 0x0602E625 RID: 189989 RVA: 0x00CF0D82 File Offset: 0x00CEEF82
		public bool IsLongPressType
		{
			get
			{
				return this.InteractionType == EInteractionType.LongPress;
			}
		}

		// Token: 0x0602E626 RID: 189990 RVA: 0x00CF0D8D File Offset: 0x00CEEF8D
		protected InteractionProcessor(Entity entity, int index, EInteractionType type)
		{
			this.InteractionType = type;
			this.Entity = entity;
			this.Index = index;
		}

		// Token: 0x0602E627 RID: 189991
		public abstract void OnPress();

		// Token: 0x0602E628 RID: 189992
		public abstract void OnRelease();

		// Token: 0x0602E629 RID: 189993
		public abstract void OnReset();

		// Token: 0x0602E62A RID: 189994 RVA: 0x00CF0DAA File Offset: 0x00CEEFAA
		public bool IsCompleted()
		{
			return this.IsCompleteInternal;
		}

		// Token: 0x0602E62B RID: 189995 RVA: 0x00CF0DB2 File Offset: 0x00CEEFB2
		public void Reset()
		{
			this.IsCompleteInternal = false;
			this.OnReset();
		}

		// Token: 0x0602E62C RID: 189996 RVA: 0x00CF0DC1 File Offset: 0x00CEEFC1
		[NullableContext(0)]
		public virtual UniTask<bool> LoadAsset()
		{
			return UniTask.FromResult<bool>(true);
		}

		// Token: 0x0602E62D RID: 189997 RVA: 0x00CF0DC9 File Offset: 0x00CEEFC9
		protected void TriggerComplete()
		{
			this.IsCompleteInternal = true;
		}
	}
}
