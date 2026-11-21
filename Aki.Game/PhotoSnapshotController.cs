using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001A96 RID: 6806
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class PhotoSnapshotController : ControllerBase
{
	// Token: 0x06010D3B RID: 68923 RVA: 0x004EF570 File Offset: 0x004ED770
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

	// Token: 0x06010D3C RID: 68924 RVA: 0x004EF590 File Offset: 0x004ED790
	public void SetSessionSnapshot(int modeId, PhotoCameraSnapshot snapshot)
	{
		this.ModeSnapShot[modeId] = snapshot;
	}

	// Token: 0x06010D3D RID: 68925 RVA: 0x004EF5A0 File Offset: 0x004ED7A0
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

	// Token: 0x06010D3E RID: 68926 RVA: 0x004EF5CC File Offset: 0x004ED7CC
	public void ClearSession()
	{
		this.ModeSnapShot.Clear();
		Log.Instance.Info(ELogModule.PhotoCamera, ELogAuthor.CXJ, "相机快照:拍照界面缓存已清空", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06010D3F RID: 68927 RVA: 0x004EF603 File Offset: 0x004ED803
	protected override bool OnClear()
	{
		this.ModeSnapShot.Clear();
		return true;
	}

	// Token: 0x17001953 RID: 6483
	// (get) Token: 0x06010D40 RID: 68928 RVA: 0x004EF611 File Offset: 0x004ED811
	public static PhotoSnapshotController Instance
	{
		get
		{
			return PhotoSnapshotController._Instance;
		}
	}

	// Token: 0x06010D41 RID: 68929 RVA: 0x004EF618 File Offset: 0x004ED818
	public static PhotoSnapshotController GetOrCreateInstance()
	{
		if (PhotoSnapshotController._Instance == null)
		{
			PhotoSnapshotController.CreateInstance();
		}
		return PhotoSnapshotController._Instance;
	}

	// Token: 0x06010D42 RID: 68930 RVA: 0x004EF62C File Offset: 0x004ED82C
	public static bool CreateInstance()
	{
		if (PhotoSnapshotController._Instance != null)
		{
			return true;
		}
		PhotoSnapshotController._Instance = new PhotoSnapshotController();
		return true;
	}

	// Token: 0x06010D43 RID: 68931 RVA: 0x004EF642 File Offset: 0x004ED842
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06010D44 RID: 68932 RVA: 0x004EF644 File Offset: 0x004ED844
	public static void ResetStaticDefaultValue()
	{
		PhotoSnapshotController._Instance = null;
	}

	// Token: 0x06010D45 RID: 68933 RVA: 0x004EF64C File Offset: 0x004ED84C
	static PhotoSnapshotController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhotoSnapshotController.CreateStaticDefaultValue), new Action(PhotoSnapshotController.ResetStaticDefaultValue));
	}

	// Token: 0x040094BF RID: 38079
	private readonly Dictionary<int, PhotoCameraSnapshot> ModeSnapShot = new Dictionary<int, PhotoCameraSnapshot>();

	// Token: 0x040094C0 RID: 38080
	[Nullable(2)]
	private static PhotoSnapshotController _Instance;
}
