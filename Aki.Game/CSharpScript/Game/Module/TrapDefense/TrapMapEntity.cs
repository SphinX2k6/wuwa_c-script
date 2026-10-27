using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A32 RID: 18994
	public class TrapMapEntity
	{
		// Token: 0x0603151E RID: 202014 RVA: 0x00B71106 File Offset: 0x00B6F306
		public void Init()
		{
			this.OnInit();
			this.MapComponentContainer.Init();
		}

		// Token: 0x0603151F RID: 202015 RVA: 0x00B71119 File Offset: 0x00B6F319
		public void Tick(float delta)
		{
			this.MapComponentContainer.Tick(delta);
			this.OnTick();
		}

		// Token: 0x06031520 RID: 202016 RVA: 0x00B7112D File Offset: 0x00B6F32D
		public void Dispose()
		{
			this.MapComponentContainer.RemoveAll();
			this.OnDispose();
		}

		// Token: 0x06031521 RID: 202017 RVA: 0x00B71140 File Offset: 0x00B6F340
		protected virtual void OnInit()
		{
		}

		// Token: 0x06031522 RID: 202018 RVA: 0x00B71142 File Offset: 0x00B6F342
		protected virtual void OnTick()
		{
		}

		// Token: 0x06031523 RID: 202019 RVA: 0x00B71144 File Offset: 0x00B6F344
		protected virtual void OnDispose()
		{
		}

		// Token: 0x06031524 RID: 202020 RVA: 0x00B71146 File Offset: 0x00B6F346
		[return: Nullable(2)]
		public T AddComponent<T>(ETrapDefenseMapComponent componentType) where T : TrapMapComponentBase
		{
			return this.MapComponentContainer.AddComponent(componentType, this) as T;
		}

		// Token: 0x06031525 RID: 202021 RVA: 0x00B7115F File Offset: 0x00B6F35F
		[return: Nullable(2)]
		public T GetComponent<T>(ETrapDefenseMapComponent componentType) where T : TrapMapComponentBase
		{
			return this.MapComponentContainer.GetComponent<T>(componentType);
		}

		// Token: 0x06031526 RID: 202022 RVA: 0x00B7116D File Offset: 0x00B6F36D
		public void RemoveComponent(ETrapDefenseMapComponent componentType)
		{
			this.MapComponentContainer.RemoveComponent(componentType);
		}

		// Token: 0x0401A5C1 RID: 107969
		[Nullable(1)]
		protected readonly TrapMapComponentContainer MapComponentContainer = new TrapMapComponentContainer();
	}
}
