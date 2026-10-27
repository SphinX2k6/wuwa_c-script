using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Base
{
	// Token: 0x02005598 RID: 21912
	public abstract class MapEntity
	{
		// Token: 0x06037DA8 RID: 228776 RVA: 0x00D3CBC3 File Offset: 0x00D3ADC3
		public void Init()
		{
			this.OnInit();
			this.MapComponentContainer.Init();
		}

		// Token: 0x06037DA9 RID: 228777 RVA: 0x00D3CBD6 File Offset: 0x00D3ADD6
		public void Tick(float delta)
		{
			this.MapComponentContainer.Tick(delta);
			this.OnTick();
		}

		// Token: 0x06037DAA RID: 228778 RVA: 0x00D3CBEA File Offset: 0x00D3ADEA
		public void Update()
		{
			this.MapComponentContainer.Update();
			this.OnUpdate();
		}

		// Token: 0x06037DAB RID: 228779 RVA: 0x00D3CBFD File Offset: 0x00D3ADFD
		public void Dispose()
		{
			this.MapComponentContainer.RemoveAll();
			this.OnDispose();
		}

		// Token: 0x06037DAC RID: 228780 RVA: 0x00D3CC10 File Offset: 0x00D3AE10
		protected virtual void OnInit()
		{
		}

		// Token: 0x06037DAD RID: 228781 RVA: 0x00D3CC12 File Offset: 0x00D3AE12
		protected virtual void OnUpdate()
		{
		}

		// Token: 0x06037DAE RID: 228782 RVA: 0x00D3CC14 File Offset: 0x00D3AE14
		protected virtual void OnTick()
		{
		}

		// Token: 0x06037DAF RID: 228783 RVA: 0x00D3CC16 File Offset: 0x00D3AE16
		protected virtual void OnDispose()
		{
		}

		// Token: 0x06037DB0 RID: 228784 RVA: 0x00D3CC18 File Offset: 0x00D3AE18
		[NullableContext(1)]
		public T AddComponent<[Nullable(0)] T>(EMapComponent componentType) where T : MapComponent
		{
			return this.MapComponentContainer.AddComponent<T>(componentType, new OneOf<MapComponent, MapComponentContainer, MapEntity>?(this));
		}

		// Token: 0x06037DB1 RID: 228785 RVA: 0x00D3CC31 File Offset: 0x00D3AE31
		[return: Nullable(2)]
		public T GetComponent<T>(EMapComponent componentType) where T : MapComponent
		{
			return this.MapComponentContainer.GetComponent<T>(componentType);
		}

		// Token: 0x06037DB2 RID: 228786 RVA: 0x00D3CC40 File Offset: 0x00D3AE40
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

		// Token: 0x06037DB3 RID: 228787 RVA: 0x00D3CC66 File Offset: 0x00D3AE66
		public void EnsureComponent<T>(EMapComponent componentType) where T : MapComponent
		{
			this.GetOrAddComponent<T>(componentType);
		}

		// Token: 0x06037DB4 RID: 228788 RVA: 0x00D3CC70 File Offset: 0x00D3AE70
		public void RemoveComponent(EMapComponent componentType)
		{
			this.MapComponentContainer.RemoveComponent(componentType);
		}

		// Token: 0x06037DB5 RID: 228789 RVA: 0x00D3CC7E File Offset: 0x00D3AE7E
		public void ReloadComponent<T>(EMapComponent componentType) where T : MapComponent
		{
			this.RemoveComponent(componentType);
			this.AddComponent<T>(componentType);
		}

		// Token: 0x0401D57F RID: 120191
		[Nullable(1)]
		protected readonly MapComponentContainer MapComponentContainer = new MapComponentContainer();

		// Token: 0x0401D580 RID: 120192
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
