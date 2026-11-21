using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect
{
	// Token: 0x02005F63 RID: 24419
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class ItemInspectRangeChecker
	{
		// Token: 0x0603AB6A RID: 240490 RVA: 0x01099E50 File Offset: 0x01098050
		[return: Nullable(2)]
		public static ItemInspectRangeChecker Create(ERangeCheckType shapeType, IShapeParams @params, IVector location, IRotator rotation)
		{
			ItemInspectRangeChecker itemInspectRangeChecker = null;
			if (shapeType == ERangeCheckType.Cone)
			{
				itemInspectRangeChecker = new ConeRangeChecker();
			}
			if (itemInspectRangeChecker == null)
			{
				return null;
			}
			itemInspectRangeChecker.Init(@params, location, rotation);
			return itemInspectRangeChecker;
		}

		// Token: 0x0603AB6B RID: 240491
		public abstract bool IsPointInside(IVector point);

		// Token: 0x0603AB6C RID: 240492
		public abstract void DebugDraw();

		// Token: 0x0603AB6D RID: 240493 RVA: 0x01099E77 File Offset: 0x01098077
		private void Init(IShapeParams @params, IVector location, IRotator rotation)
		{
			this.Location.DeepCopy(location);
			this.Rotation.DeepCopy(rotation);
			this.OnInit(@params);
		}

		// Token: 0x0603AB6E RID: 240494
		protected abstract void OnInit(IShapeParams @params);

		// Token: 0x0401EDD3 RID: 126419
		protected readonly Vector Location = Vector.Create();

		// Token: 0x0401EDD4 RID: 126420
		protected readonly Rotator Rotation = Rotator.Create();
	}
}
