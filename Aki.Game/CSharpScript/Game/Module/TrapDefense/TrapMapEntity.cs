using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039DA RID: 14810
	public class TrapMapEntity
	{
		// Token: 0x060262AE RID: 156334 RVA: 0x00AB507A File Offset: 0x00AB327A
		public void Init()
		{
			this.OnInit();
			this.MapComponentContainer.Init();
		}

		// Token: 0x060262AF RID: 156335 RVA: 0x00AB508D File Offset: 0x00AB328D
		public void Tick(float delta)
		{
			this.MapComponentContainer.Tick(delta);
			this.OnTick();
		}

		// Token: 0x060262B0 RID: 156336 RVA: 0x00AB50A1 File Offset: 0x00AB32A1
		public void Dispose()
		{
			this.MapComponentContainer.RemoveAll();
			this.OnDispose();
		}

		// Token: 0x060262B1 RID: 156337 RVA: 0x00AB50B4 File Offset: 0x00AB32B4
		protected virtual void OnInit()
		{
		}

		// Token: 0x060262B2 RID: 156338 RVA: 0x00AB50B6 File Offset: 0x00AB32B6
		protected virtual void OnTick()
		{
		}

		// Token: 0x060262B3 RID: 156339 RVA: 0x00AB50B8 File Offset: 0x00AB32B8
		protected virtual void OnDispose()
		{
		}

		// Token: 0x060262B4 RID: 156340 RVA: 0x00AB50BA File Offset: 0x00AB32BA
		[return: Nullable(2)]
		public T AddComponent<T>(ETrapDefenseMapComponent componentType) where T : TrapMapComponentBase
		{
			return this.MapComponentContainer.AddComponent(componentType, this) as T;
		}

		// Token: 0x060262B5 RID: 156341 RVA: 0x00AB50D3 File Offset: 0x00AB32D3
		[return: Nullable(2)]
		public T GetComponent<T>(ETrapDefenseMapComponent componentType) where T : TrapMapComponentBase
		{
			return this.MapComponentContainer.GetComponent<T>(componentType);
		}

		// Token: 0x060262B6 RID: 156342 RVA: 0x00AB50E1 File Offset: 0x00AB32E1
		public void RemoveComponent(ETrapDefenseMapComponent componentType)
		{
			this.MapComponentContainer.RemoveComponent(componentType);
		}

		// Token: 0x04014F13 RID: 85779
		[Nullable(1)]
		protected readonly TrapMapComponentContainer MapComponentContainer = new TrapMapComponentContainer();
	}
}
