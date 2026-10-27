using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020025AA RID: 9642
public class PhotoOptionPart : IPhotoSnapshotPart
{
	// Token: 0x06013855 RID: 79957 RVA: 0x004E0974 File Offset: 0x004DEB74
	public void Capture()
	{
		this.SetUpValueMap.Clear();
		foreach (KeyValuePair<EPhotoSetupValueType, float> keyValuePair in PhotographModel.Instance.GetAllPhotographOption())
		{
			if (!PhotographController.Instance.IsLocalStorageSetup(keyValuePair.Key))
			{
				this.SetUpValueMap[keyValuePair.Key] = keyValuePair.Value;
			}
		}
	}

	// Token: 0x06013856 RID: 79958 RVA: 0x004E09F8 File Offset: 0x004DEBF8
	public float? TryGetValue(EPhotoSetupValueType valueType)
	{
		float value;
		if (!this.SetUpValueMap.TryGetValue(valueType, out value))
		{
			return null;
		}
		return new float?(value);
	}

	// Token: 0x06013857 RID: 79959 RVA: 0x004E0A25 File Offset: 0x004DEC25
	public void Apply()
	{
	}

	// Token: 0x04009366 RID: 37734
	[Nullable(1)]
	public readonly Dictionary<EPhotoSetupValueType, float> SetUpValueMap = new Dictionary<EPhotoSetupValueType, float>();
}
