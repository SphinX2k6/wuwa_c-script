using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Base
{
	// Token: 0x0200456E RID: 17774
	public abstract class MapEntity
	{
		// Token: 0x0602CCA6 RID: 183462 RVA: 0x00C8A90B File Offset: 0x00C88B0B
		public void Init()
		{
			this.OnInit();
			this.MapComponentContainer.Init();
		}

		// Token: 0x0602CCA7 RID: 183463 RVA: 0x00C8A91E File Offset: 0x00C88B1E
		public void Tick(float delta)
		{
			this.MapComponentContainer.Tick(delta);
			this.OnTick();
		}

		// Token: 0x0602CCA8 RID: 183464 RVA: 0x00C8A932 File Offset: 0x00C88B32
		public void Update()
		{
			this.MapComponentContainer.Update();
			this.OnUpdate();
		}

		// Token: 0x0602CCA9 RID: 183465 RVA: 0x00C8A945 File Offset: 0x00C88B45
		public void Dispose()
		{
			this.MapComponentContainer.RemoveAll();
			this.OnDispose();
		}

		// Token: 0x0602CCAA RID: 183466 RVA: 0x00C8A958 File Offset: 0x00C88B58
		protected virtual void OnInit()
		{
		}

		// Token: 0x0602CCAB RID: 183467 RVA: 0x00C8A95A File Offset: 0x00C88B5A
		protected virtual void OnUpdate()
		{
		}

		// Token: 0x0602CCAC RID: 183468 RVA: 0x00C8A95C File Offset: 0x00C88B5C
		protected virtual void OnTick()
		{
		}

		// Token: 0x0602CCAD RID: 183469 RVA: 0x00C8A95E File Offset: 0x00C88B5E
		protected virtual void OnDispose()
		{
		}

		// Token: 0x0602CCAE RID: 183470 RVA: 0x00C8A960 File Offset: 0x00C88B60
		[NullableContext(1)]
		public T AddComponent<[Nullable(0)] T>(EMapComponent componentType) where T : MapComponent
		{
			return this.MapComponentContainer.AddComponent<T>(componentType, new OneOf<MapComponent, MapComponentContainer, MapEntity>?(this));
		}

		// Token: 0x0602CCAF RID: 183471 RVA: 0x00C8A979 File Offset: 0x00C88B79
		[return: Nullable(2)]
		public T GetComponent<T>(EMapComponent componentType) where T : MapComponent
		{
			return this.MapComponentContainer.GetComponent<T>(componentType);
		}

		// Token: 0x0602CCB0 RID: 183472 RVA: 0x00C8A988 File Offset: 0x00C88B88
		[NullableContext(1)]
		public T GetOrAddComponent<[Nullable(0)] T>(EMapComponent componentType) where T : MapComponent
		{
			T component = this.GetComponent<T>(componentType);
			if (component != null)
			{
				return component;
			}
			return this.AddComponent<T>(componentType);
		}

		// Token: 0x0602CCB1 RID: 183473 RVA: 0x00C8A9AE File Offset: 0x00C88BAE
		public void EnsureComponent<T>(EMapComponent componentType) where T : MapComponent
		{
			this.GetOrAddComponent<T>(componentType);
		}

		// Token: 0x0602CCB2 RID: 183474 RVA: 0x00C8A9B8 File Offset: 0x00C88BB8
		public void RemoveComponent(EMapComponent componentType)
		{
			this.MapComponentContainer.RemoveComponent(componentType);
		}

		// Token: 0x0602CCB3 RID: 183475 RVA: 0x00C8A9C6 File Offset: 0x00C88BC6
		public void ReloadComponent<T>(EMapComponent componentType) where T : MapComponent
		{
			this.RemoveComponent(componentType);
			this.AddComponent<T>(componentType);
		}

		// Token: 0x0401800A RID: 98314
		[Nullable(1)]
		protected readonly MapComponentContainer MapComponentContainer = new MapComponentContainer();

		// Token: 0x0401800B RID: 98315
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			0,
			1
		})]
		protected PropertyMap<OneOf<int, string>, OneOf<Vector2D, FVector2D, int>> PropertyMap = new PropertyMap<OneOf<int, string>, OneOf<Vector2D, FVector2D, int>>();
	}
}
