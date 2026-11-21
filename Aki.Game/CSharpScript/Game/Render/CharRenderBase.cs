using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034E2 RID: 13538
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class CharRenderBase
	{
		// Token: 0x06022756 RID: 141142 RVA: 0x009C7380 File Offset: 0x009C5580
		public bool GetIsInitSuc()
		{
			return this.IsInitSuc;
		}

		// Token: 0x06022757 RID: 141143 RVA: 0x009C7388 File Offset: 0x009C5588
		[NullableContext(2)]
		public CharRenderingComponent GetRenderingComponent()
		{
			return this.RenderComponent;
		}

		// Token: 0x06022758 RID: 141144 RVA: 0x009C7390 File Offset: 0x009C5590
		public void OnInitSuccess()
		{
			this.IsInitSuc = true;
		}

		// Token: 0x06022759 RID: 141145
		public abstract string GetStatName();

		// Token: 0x0602275A RID: 141146 RVA: 0x009C7399 File Offset: 0x009C5599
		public virtual void Awake(CharRenderingComponent renderComponent)
		{
			this.RenderComponent = renderComponent;
		}

		// Token: 0x0602275B RID: 141147 RVA: 0x009C73A2 File Offset: 0x009C55A2
		public virtual void Start()
		{
		}

		// Token: 0x0602275C RID: 141148 RVA: 0x009C73A4 File Offset: 0x009C55A4
		public virtual void Update()
		{
		}

		// Token: 0x0602275D RID: 141149 RVA: 0x009C73A6 File Offset: 0x009C55A6
		public virtual void LateUpdate()
		{
		}

		// Token: 0x0602275E RID: 141150 RVA: 0x009C73A8 File Offset: 0x009C55A8
		public virtual void Destroy()
		{
		}

		// Token: 0x0602275F RID: 141151 RVA: 0x009C73AA File Offset: 0x009C55AA
		public virtual void OnResetRenderState()
		{
		}

		// Token: 0x06022760 RID: 141152 RVA: 0x009C73AC File Offset: 0x009C55AC
		public virtual void PreBodyInfoRuntimeInit(FName bodyName)
		{
		}

		// Token: 0x06022761 RID: 141153 RVA: 0x009C73AE File Offset: 0x009C55AE
		public virtual void PostBodyInfoRuntimeInit(FName bodyName)
		{
		}

		// Token: 0x06022762 RID: 141154 RVA: 0x009C73B0 File Offset: 0x009C55B0
		protected float GetDeltaTime()
		{
			CharRenderingComponent renderComponent = this.RenderComponent;
			if (renderComponent == null)
			{
				return 0f;
			}
			return renderComponent.GetDeltaTime();
		}

		// Token: 0x06022763 RID: 141155
		public abstract int GetComponentId();

		// Token: 0x06022764 RID: 141156 RVA: 0x009C73C7 File Offset: 0x009C55C7
		public Stat GetRenderStat()
		{
			if (this.RenderStat == null)
			{
				this.RenderStat = Stat.Create(this.GetStatName(), "", "");
			}
			return this.RenderStat;
		}

		// Token: 0x04012FE3 RID: 77795
		[Nullable(2)]
		protected CharRenderingComponent RenderComponent;

		// Token: 0x04012FE4 RID: 77796
		[Nullable(2)]
		protected Stat RenderStat;

		// Token: 0x04012FE5 RID: 77797
		private bool IsInitSuc;
	}
}
