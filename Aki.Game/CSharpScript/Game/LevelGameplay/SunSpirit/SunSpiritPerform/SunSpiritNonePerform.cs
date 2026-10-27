using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SunSpirit.SunSpiritPerform
{
	// Token: 0x02006A05 RID: 27141
	[NullableContext(1)]
	[Nullable(0)]
	public class SunSpiritNonePerform : SunSpiritBasePerform, ISunSpiritScenePerform
	{
		// Token: 0x06043828 RID: 276520 RVA: 0x01082D4E File Offset: 0x01080F4E
		public SunSpiritNonePerform(SunSpiritData sunSpiritData, Transform initTransform) : base(sunSpiritData)
		{
			this.SavedTransform.Set(initTransform.GetLocation(), initTransform.GetRotation(), initTransform.GetScale3D());
		}

		// Token: 0x06043829 RID: 276521 RVA: 0x01082D80 File Offset: 0x01080F80
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

		// Token: 0x0604382A RID: 276522 RVA: 0x01082DEF File Offset: 0x01080FEF
		public bool GetTransform(Transform outTransform)
		{
			outTransform.Set(this.SavedTransform.GetLocation(), this.SavedTransform.GetRotation(), this.SavedTransform.GetScale3D());
			return true;
		}

		// Token: 0x0604382B RID: 276523 RVA: 0x01082E1C File Offset: 0x0108101C
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

		// Token: 0x0604382C RID: 276524 RVA: 0x01082E7C File Offset: 0x0108107C
		public bool SetTransform(Transform inTransform)
		{
			this.SavedTransform.Set(inTransform.GetLocation(), inTransform.GetRotation(), inTransform.GetScale3D());
			return true;
		}

		// Token: 0x040233DB RID: 144347
		private readonly Transform SavedTransform = Transform.Create();
	}
}
