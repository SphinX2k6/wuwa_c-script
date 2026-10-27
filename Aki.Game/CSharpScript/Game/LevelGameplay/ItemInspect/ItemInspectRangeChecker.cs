using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect
{
	// Token: 0x02006DE4 RID: 28132
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class ItemInspectRangeChecker
	{
		// Token: 0x06044A06 RID: 281094 RVA: 0x010EFC04 File Offset: 0x010EDE04
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

		// Token: 0x06044A07 RID: 281095
		public abstract bool IsPointInside(IVector point);

		// Token: 0x06044A08 RID: 281096
		public abstract void DebugDraw();

		// Token: 0x06044A09 RID: 281097 RVA: 0x010EFC2B File Offset: 0x010EDE2B
		private void Init(IShapeParams @params, IVector location, IRotator rotation)
		{
			this.Location.DeepCopy(location);
			this.Rotation.DeepCopy(rotation);
			this.OnInit(@params);
		}

		// Token: 0x06044A0A RID: 281098
		protected abstract void OnInit(IShapeParams @params);

		// Token: 0x04023B31 RID: 146225
		protected readonly Vector Location = Vector.Create();

		// Token: 0x04023B32 RID: 146226
		protected readonly Rotator Rotation = Rotator.Create();
	}
}
