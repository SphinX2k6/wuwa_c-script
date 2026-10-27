using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020025AB RID: 9643
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class PhotoSnapshotController : ControllerBase
{
	// Token: 0x06013859 RID: 79961 RVA: 0x004E0A3C File Offset: 0x004DEC3C
	[NullableContext(2)]
	public PhotoCameraSnapshot GetSessionSnapshot(int modeId)
	{
		PhotoCameraSnapshot result;
		if (!this.ModeSnapShot.TryGetValue(modeId, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x0601385A RID: 79962 RVA: 0x004E0A5C File Offset: 0x004DEC5C
	public void SetSessionSnapshot(int modeId, PhotoCameraSnapshot snapshot)
	{
		this.ModeSnapShot[modeId] = snapshot;
	}

	// Token: 0x0601385B RID: 79963 RVA: 0x004E0A6C File Offset: 0x004DEC6C
	public PhotoCameraSnapshot GetOrCreateSessionSnapshot(int modeId)
	{
		PhotoCameraSnapshot photoCameraSnapshot = this.GetSessionSnapshot(modeId);
		if (photoCameraSnapshot != null)
		{
			return photoCameraSnapshot;
		}
		photoCameraSnapshot = PhotoCameraSnapshot.Create(modeId, EPhotoSnapshotParts.ModePrivate);
		this.SetSessionSnapshot(modeId, photoCameraSnapshot);
		return photoCameraSnapshot;
	}

	// Token: 0x0601385C RID: 79964 RVA: 0x004E0A98 File Offset: 0x004DEC98
	public void ClearSession()
	{
		this.ModeSnapShot.Clear();
		Log.Instance.Info(ELogModule.PhotoCamera, ELogAuthor.CXJ, "相机快照:拍照界面缓存已清空", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0601385D RID: 79965 RVA: 0x004E0ACF File Offset: 0x004DECCF
	protected override bool OnClear()
	{
		this.ModeSnapShot.Clear();
		return true;
	}

	// Token: 0x17001919 RID: 6425
	// (get) Token: 0x0601385E RID: 79966 RVA: 0x004E0ADD File Offset: 0x004DECDD
	public static PhotoSnapshotController Instance
	{
		get
		{
			return PhotoSnapshotController._Instance;
		}
	}

	// Token: 0x0601385F RID: 79967 RVA: 0x004E0AE4 File Offset: 0x004DECE4
	public static PhotoSnapshotController GetOrCreateInstance()
	{
		if (PhotoSnapshotController._Instance == null)
		{
			PhotoSnapshotController.CreateInstance();
		}
		return PhotoSnapshotController._Instance;
	}

	// Token: 0x06013860 RID: 79968 RVA: 0x004E0AF8 File Offset: 0x004DECF8
	public static bool CreateInstance()
	{
		if (PhotoSnapshotController._Instance != null)
		{
			return true;
		}
		PhotoSnapshotController._Instance = new PhotoSnapshotController();
		return true;
	}

	// Token: 0x06013861 RID: 79969 RVA: 0x004E0B0E File Offset: 0x004DED0E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06013862 RID: 79970 RVA: 0x004E0B10 File Offset: 0x004DED10
	public static void ResetStaticDefaultValue()
	{
		PhotoSnapshotController._Instance = null;
	}

	// Token: 0x06013863 RID: 79971 RVA: 0x004E0B18 File Offset: 0x004DED18
	static PhotoSnapshotController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhotoSnapshotController.CreateStaticDefaultValue), new Action(PhotoSnapshotController.ResetStaticDefaultValue));
	}

	// Token: 0x04009367 RID: 37735
	private readonly Dictionary<int, PhotoCameraSnapshot> ModeSnapShot = new Dictionary<int, PhotoCameraSnapshot>();

	// Token: 0x04009368 RID: 37736
	[Nullable(2)]
	private static PhotoSnapshotController _Instance;
}
