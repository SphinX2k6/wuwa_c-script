using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;

// Token: 0x02002C47 RID: 11335
[NullableContext(2)]
[Nullable(0)]
public class UiCameraComponent
{
	// Token: 0x06017A33 RID: 96819 RVA: 0x00603CAD File Offset: 0x00601EAD
	public UiCameraComponent()
	{
		this.TickHandleId = -1;
	}

	// Token: 0x06017A34 RID: 96820 RVA: 0x00603CBC File Offset: 0x00601EBC
	[NullableContext(1)]
	public void Initialize(UiCamera ownerUiCamera)
	{
		this.OwnerUiCamera = ownerUiCamera;
		this.CameraActor = this.OwnerUiCamera.GetCameraActor();
		this.CameraActor.SetTickableWhenPaused(true);
		this.CineCameraComponent = this.OwnerUiCamera.GetCineCameraComponent();
		UCineCameraComponent cineCameraComponent = this.CineCameraComponent;
		if (cineCameraComponent != null)
		{
			cineCameraComponent.SetTickableWhenPaused(true);
		}
		this.OnInitialize();
	}

	// Token: 0x06017A35 RID: 96821 RVA: 0x00603D16 File Offset: 0x00601F16
	public void Destroy()
	{
		this.CameraActor = null;
		this.CineCameraComponent = null;
		this.Deactivate();
		this.OnDestroy();
	}

	// Token: 0x06017A36 RID: 96822 RVA: 0x00603D34 File Offset: 0x00601F34
	public void Activate()
	{
		if (this.IsActivate)
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.UiCamera;
		ELogAuthor author = ELogAuthor.BB;
		string message = "激活相机组件";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Name", base.GetType().Name);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.OnAddEvents();
		this.OnActivate();
		this.IsActivate = true;
	}

	// Token: 0x06017A37 RID: 96823 RVA: 0x00603D90 File Offset: 0x00601F90
	public void Deactivate()
	{
		if (!this.IsActivate)
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.UiCamera;
		ELogAuthor author = ELogAuthor.BB;
		string message = "休眠相机组件";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Name", base.GetType().Name);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.RemoveTick();
		this.OnRemoveEvents();
		this.OnDeactivate();
		this.IsActivate = false;
	}

	// Token: 0x06017A38 RID: 96824 RVA: 0x00603DF0 File Offset: 0x00601FF0
	public void EnableTick()
	{
		if (this.TickHandleId != -1)
		{
			return;
		}
		this.TickHandleId = TickSystem.Instance.Add(new Action<float>(this.Tick), base.GetType().Name, ETickingGroup.TG_PrePhysics, true, 0, true).Id;
	}

	// Token: 0x06017A39 RID: 96825 RVA: 0x00603E2C File Offset: 0x0060202C
	public void ResumeTick()
	{
		if (this.TickHandleId == -1)
		{
			return;
		}
		TickSystem.Instance.Resume(this.TickHandleId);
	}

	// Token: 0x06017A3A RID: 96826 RVA: 0x00603E49 File Offset: 0x00602049
	public void PauseTick()
	{
		if (this.TickHandleId == -1)
		{
			return;
		}
		TickSystem.Instance.Pause(this.TickHandleId);
	}

	// Token: 0x06017A3B RID: 96827 RVA: 0x00603E66 File Offset: 0x00602066
	public void RemoveTick()
	{
		if (this.TickHandleId == -1)
		{
			return;
		}
		TickSystem.Instance.Remove(this.TickHandleId);
		this.TickHandleId = -1;
	}

	// Token: 0x06017A3C RID: 96828 RVA: 0x00603E8A File Offset: 0x0060208A
	private void Tick(float delta)
	{
		this.OnTick(delta);
	}

	// Token: 0x06017A3D RID: 96829 RVA: 0x00603E93 File Offset: 0x00602093
	protected virtual void OnInitialize()
	{
	}

	// Token: 0x06017A3E RID: 96830 RVA: 0x00603E95 File Offset: 0x00602095
	protected virtual void OnDestroy()
	{
	}

	// Token: 0x06017A3F RID: 96831 RVA: 0x00603E97 File Offset: 0x00602097
	protected virtual void OnActivate()
	{
	}

	// Token: 0x06017A40 RID: 96832 RVA: 0x00603E99 File Offset: 0x00602099
	protected virtual void OnDeactivate()
	{
	}

	// Token: 0x06017A41 RID: 96833 RVA: 0x00603E9B File Offset: 0x0060209B
	protected virtual void OnAddEvents()
	{
	}

	// Token: 0x06017A42 RID: 96834 RVA: 0x00603E9D File Offset: 0x0060209D
	protected virtual void OnRemoveEvents()
	{
	}

	// Token: 0x06017A43 RID: 96835 RVA: 0x00603E9F File Offset: 0x0060209F
	protected virtual void OnTick(float delta)
	{
	}

	// Token: 0x06017A44 RID: 96836 RVA: 0x00603EA1 File Offset: 0x006020A1
	public bool GetIsActivate()
	{
		return this.IsActivate;
	}

	// Token: 0x06017A45 RID: 96837 RVA: 0x00603EA9 File Offset: 0x006020A9
	[NullableContext(1)]
	protected UiCameraStructure GetCameraStructure()
	{
		return this.OwnerUiCamera.GetStructure();
	}

	// Token: 0x0400B028 RID: 45096
	protected UiCamera OwnerUiCamera;

	// Token: 0x0400B029 RID: 45097
	protected BP_CineCamera_C CameraActor;

	// Token: 0x0400B02A RID: 45098
	protected UCineCameraComponent CineCameraComponent;

	// Token: 0x0400B02B RID: 45099
	private int TickHandleId;

	// Token: 0x0400B02C RID: 45100
	private bool IsActivate;
}
