using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UnrealEngine;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.Input
{
	// Token: 0x02002FF0 RID: 12272
	internal readonly struct TetrisPointerSnapshot : IEquatable<TetrisPointerSnapshot>
	{
		// Token: 0x0601D20A RID: 119306 RVA: 0x008E6BD8 File Offset: 0x008E4DD8
		public TetrisPointerSnapshot(EInputControllerMainType InputMode, int PointerId, EMouseButtonType MouseButtonType, FVector PointerPosition, int SourceId, int SourceIndex, ELGUIPointerInputType PointerInputType)
		{
			this.InputMode = InputMode;
			this.PointerId = PointerId;
			this.MouseButtonType = MouseButtonType;
			this.PointerPosition = PointerPosition;
			this.SourceId = SourceId;
			this.SourceIndex = SourceIndex;
			this.PointerInputType = PointerInputType;
		}

		// Token: 0x17002E3A RID: 11834
		// (get) Token: 0x0601D20B RID: 119307 RVA: 0x008E6C0F File Offset: 0x008E4E0F
		// (set) Token: 0x0601D20C RID: 119308 RVA: 0x008E6C17 File Offset: 0x008E4E17
		public EInputControllerMainType InputMode { get; set; }

		// Token: 0x17002E3B RID: 11835
		// (get) Token: 0x0601D20D RID: 119309 RVA: 0x008E6C20 File Offset: 0x008E4E20
		// (set) Token: 0x0601D20E RID: 119310 RVA: 0x008E6C28 File Offset: 0x008E4E28
		public int PointerId { get; set; }

		// Token: 0x17002E3C RID: 11836
		// (get) Token: 0x0601D20F RID: 119311 RVA: 0x008E6C31 File Offset: 0x008E4E31
		// (set) Token: 0x0601D210 RID: 119312 RVA: 0x008E6C39 File Offset: 0x008E4E39
		public EMouseButtonType MouseButtonType { get; set; }

		// Token: 0x17002E3D RID: 11837
		// (get) Token: 0x0601D211 RID: 119313 RVA: 0x008E6C42 File Offset: 0x008E4E42
		// (set) Token: 0x0601D212 RID: 119314 RVA: 0x008E6C4A File Offset: 0x008E4E4A
		public FVector PointerPosition { get; set; }

		// Token: 0x17002E3E RID: 11838
		// (get) Token: 0x0601D213 RID: 119315 RVA: 0x008E6C53 File Offset: 0x008E4E53
		// (set) Token: 0x0601D214 RID: 119316 RVA: 0x008E6C5B File Offset: 0x008E4E5B
		public int SourceId { get; set; }

		// Token: 0x17002E3F RID: 11839
		// (get) Token: 0x0601D215 RID: 119317 RVA: 0x008E6C64 File Offset: 0x008E4E64
		// (set) Token: 0x0601D216 RID: 119318 RVA: 0x008E6C6C File Offset: 0x008E4E6C
		public int SourceIndex { get; set; }

		// Token: 0x17002E40 RID: 11840
		// (get) Token: 0x0601D217 RID: 119319 RVA: 0x008E6C75 File Offset: 0x008E4E75
		// (set) Token: 0x0601D218 RID: 119320 RVA: 0x008E6C7D File Offset: 0x008E4E7D
		public ELGUIPointerInputType PointerInputType { get; set; }

		// Token: 0x0601D219 RID: 119321 RVA: 0x008E6C88 File Offset: 0x008E4E88
		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("TetrisPointerSnapshot");
			stringBuilder.Append(" { ");
			if (this.PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x0601D21A RID: 119322 RVA: 0x008E6CD4 File Offset: 0x008E4ED4
		[CompilerGenerated]
		private bool PrintMembers(StringBuilder builder)
		{
			builder.Append("InputMode = ");
			builder.Append(this.InputMode.ToString());
			builder.Append(", PointerId = ");
			builder.Append(this.PointerId.ToString());
			builder.Append(", MouseButtonType = ");
			builder.Append(this.MouseButtonType.ToString());
			builder.Append(", PointerPosition = ");
			builder.Append(this.PointerPosition.ToString());
			builder.Append(", SourceId = ");
			builder.Append(this.SourceId.ToString());
			builder.Append(", SourceIndex = ");
			builder.Append(this.SourceIndex.ToString());
			builder.Append(", PointerInputType = ");
			builder.Append(this.PointerInputType.ToString());
			return true;
		}

		// Token: 0x0601D21B RID: 119323 RVA: 0x008E6DF4 File Offset: 0x008E4FF4
		[CompilerGenerated]
		public static bool operator !=(TetrisPointerSnapshot left, TetrisPointerSnapshot right)
		{
			return !(left == right);
		}

		// Token: 0x0601D21C RID: 119324 RVA: 0x008E6E00 File Offset: 0x008E5000
		[CompilerGenerated]
		public static bool operator ==(TetrisPointerSnapshot left, TetrisPointerSnapshot right)
		{
			return left.Equals(right);
		}

		// Token: 0x0601D21D RID: 119325 RVA: 0x008E6E0C File Offset: 0x008E500C
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((((EqualityComparer<EInputControllerMainType>.Default.GetHashCode(this.<InputMode>k__BackingField) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<PointerId>k__BackingField)) * -1521134295 + EqualityComparer<EMouseButtonType>.Default.GetHashCode(this.<MouseButtonType>k__BackingField)) * -1521134295 + EqualityComparer<FVector>.Default.GetHashCode(this.<PointerPosition>k__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<SourceId>k__BackingField)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<SourceIndex>k__BackingField)) * -1521134295 + EqualityComparer<ELGUIPointerInputType>.Default.GetHashCode(this.<PointerInputType>k__BackingField);
		}

		// Token: 0x0601D21E RID: 119326 RVA: 0x008E6EB3 File Offset: 0x008E50B3
		[CompilerGenerated]
		public override bool Equals(object obj)
		{
			return obj is TetrisPointerSnapshot && this.Equals((TetrisPointerSnapshot)obj);
		}

		// Token: 0x0601D21F RID: 119327 RVA: 0x008E6ECC File Offset: 0x008E50CC
		[CompilerGenerated]
		public bool Equals(TetrisPointerSnapshot other)
		{
			return EqualityComparer<EInputControllerMainType>.Default.Equals(this.<InputMode>k__BackingField, other.<InputMode>k__BackingField) && EqualityComparer<int>.Default.Equals(this.<PointerId>k__BackingField, other.<PointerId>k__BackingField) && EqualityComparer<EMouseButtonType>.Default.Equals(this.<MouseButtonType>k__BackingField, other.<MouseButtonType>k__BackingField) && EqualityComparer<FVector>.Default.Equals(this.<PointerPosition>k__BackingField, other.<PointerPosition>k__BackingField) && EqualityComparer<int>.Default.Equals(this.<SourceId>k__BackingField, other.<SourceId>k__BackingField) && EqualityComparer<int>.Default.Equals(this.<SourceIndex>k__BackingField, other.<SourceIndex>k__BackingField) && EqualityComparer<ELGUIPointerInputType>.Default.Equals(this.<PointerInputType>k__BackingField, other.<PointerInputType>k__BackingField);
		}

		// Token: 0x0601D220 RID: 119328 RVA: 0x008E6F84 File Offset: 0x008E5184
		[CompilerGenerated]
		public void Deconstruct(out EInputControllerMainType InputMode, out int PointerId, out EMouseButtonType MouseButtonType, out FVector PointerPosition, out int SourceId, out int SourceIndex, out ELGUIPointerInputType PointerInputType)
		{
			InputMode = this.InputMode;
			PointerId = this.PointerId;
			MouseButtonType = this.MouseButtonType;
			PointerPosition = this.PointerPosition;
			SourceId = this.SourceId;
			SourceIndex = this.SourceIndex;
			PointerInputType = this.PointerInputType;
		}
	}
}
