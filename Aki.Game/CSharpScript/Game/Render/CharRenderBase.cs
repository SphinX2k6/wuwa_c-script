using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045BA RID: 17850
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class CharRenderBase
	{
		// Token: 0x0602E06C RID: 188524 RVA: 0x00A9B15C File Offset: 0x00A9935C
		public bool GetIsInitSuc()
		{
			return this.IsInitSuc;
		}

		// Token: 0x0602E06D RID: 188525 RVA: 0x00A9B164 File Offset: 0x00A99364
		[NullableContext(2)]
		public CharRenderingComponent GetRenderingComponent()
		{
			return this.RenderComponent;
		}

		// Token: 0x0602E06E RID: 188526 RVA: 0x00A9B16C File Offset: 0x00A9936C
		public void OnInitSuccess()
		{
			this.IsInitSuc = true;
		}

		// Token: 0x0602E06F RID: 188527
		public abstract string GetStatName();

		// Token: 0x0602E070 RID: 188528 RVA: 0x00A9B175 File Offset: 0x00A99375
		public virtual void Awake(CharRenderingComponent renderComponent)
		{
			this.RenderComponent = renderComponent;
		}

		// Token: 0x0602E071 RID: 188529 RVA: 0x00A9B17E File Offset: 0x00A9937E
		public virtual void Start()
		{
		}

		// Token: 0x0602E072 RID: 188530 RVA: 0x00A9B180 File Offset: 0x00A99380
		public virtual void Update()
		{
		}

		// Token: 0x0602E073 RID: 188531 RVA: 0x00A9B182 File Offset: 0x00A99382
		public virtual void LateUpdate()
		{
		}

		// Token: 0x0602E074 RID: 188532 RVA: 0x00A9B184 File Offset: 0x00A99384
		public virtual void Destroy()
		{
		}

		// Token: 0x0602E075 RID: 188533 RVA: 0x00A9B186 File Offset: 0x00A99386
		public virtual void OnResetRenderState()
		{
		}

		// Token: 0x0602E076 RID: 188534 RVA: 0x00A9B188 File Offset: 0x00A99388
		public virtual void PreBodyInfoRuntimeInit(FName bodyName)
		{
		}

		// Token: 0x0602E077 RID: 188535 RVA: 0x00A9B18A File Offset: 0x00A9938A
		public virtual void PostBodyInfoRuntimeInit(FName bodyName)
		{
		}

		// Token: 0x0602E078 RID: 188536 RVA: 0x00A9B18C File Offset: 0x00A9938C
		protected float GetDeltaTime()
		{
			CharRenderingComponent renderComponent = this.RenderComponent;
			if (renderComponent == null)
			{
				return 0f;
			}
			return renderComponent.GetDeltaTime();
		}

		// Token: 0x0602E079 RID: 188537
		public abstract int GetComponentId();

		// Token: 0x0602E07A RID: 188538 RVA: 0x00A9B1A3 File Offset: 0x00A993A3
		public Stat GetRenderStat()
		{
			if (this.RenderStat == null)
			{
				this.RenderStat = Stat.Create(this.GetStatName(), "", "");
			}
			return this.RenderStat;
		}

		// Token: 0x040189A8 RID: 100776
		[Nullable(2)]
		protected CharRenderingComponent RenderComponent;

		// Token: 0x040189A9 RID: 100777
		[Nullable(2)]
		protected Stat RenderStat;

		// Token: 0x040189AA RID: 100778
		private bool IsInitSuc;
	}
}
