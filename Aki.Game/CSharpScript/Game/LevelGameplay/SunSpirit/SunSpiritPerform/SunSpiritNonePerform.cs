using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SunSpirit.SunSpiritPerform
{
	// Token: 0x02005B62 RID: 23394
	[NullableContext(1)]
	[Nullable(0)]
	public class SunSpiritNonePerform : SunSpiritBasePerform, ISunSpiritScenePerform
	{
		// Token: 0x06039874 RID: 235636 RVA: 0x01027372 File Offset: 0x01025572
		public SunSpiritNonePerform(SunSpiritData sunSpiritData, Transform initTransform) : base(sunSpiritData)
		{
			this.SavedTransform.Set(initTransform.GetLocation(), initTransform.GetRotation(), initTransform.GetScale3D());
		}

		// Token: 0x06039875 RID: 235637 RVA: 0x010273A4 File Offset: 0x010255A4
		[NullableContext(2)]
		public bool GetTransformData(Vector outLocation = null, object outRotation = null, Vector outScale = null)
		{
			if (outLocation != null)
			{
				outLocation.DeepCopy(this.SavedTransform.GetLocation());
			}
			Quat quat = outRotation as Quat;
			if (quat != null)
			{
				quat.DeepCopy(this.SavedTransform.GetRotation());
			}
			else
			{
				Rotator rotator = outRotation as Rotator;
				if (rotator != null)
				{
					this.SavedTransform.GetRotation().Rotator(rotator);
				}
			}
			if (outScale != null)
			{
				outScale.DeepCopy(this.SavedTransform.GetScale3D());
			}
			return true;
		}

		// Token: 0x06039876 RID: 235638 RVA: 0x01027413 File Offset: 0x01025613
		public bool GetTransform(Transform outTransform)
		{
			outTransform.Set(this.SavedTransform.GetLocation(), this.SavedTransform.GetRotation(), this.SavedTransform.GetScale3D());
			return true;
		}

		// Token: 0x06039877 RID: 235639 RVA: 0x01027440 File Offset: 0x01025640
		[NullableContext(2)]
		public bool SetTransformData(Vector inLocation = null, object inRotation = null, Vector inScale = null)
		{
			if (inLocation != null)
			{
				this.SavedTransform.SetLocation(inLocation);
			}
			Quat quat = inRotation as Quat;
			if (quat != null)
			{
				this.SavedTransform.SetRotation(quat);
			}
			else
			{
				Rotator rotator = inRotation as Rotator;
				if (rotator != null)
				{
					this.SavedTransform.SetRotation(rotator.Quaternion(null));
				}
			}
			if (inScale != null)
			{
				this.SavedTransform.SetScale3D(inScale);
			}
			return true;
		}

		// Token: 0x06039878 RID: 235640 RVA: 0x010274A0 File Offset: 0x010256A0
		public bool SetTransform(Transform inTransform)
		{
			this.SavedTransform.Set(inTransform.GetLocation(), inTransform.GetRotation(), inTransform.GetScale3D());
			return true;
		}

		// Token: 0x0401E5CD RID: 124365
		private readonly Transform SavedTransform = Transform.Create();
	}
}
