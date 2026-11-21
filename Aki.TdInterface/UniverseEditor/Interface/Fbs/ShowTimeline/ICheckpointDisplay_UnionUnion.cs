using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003F9E RID: 16286
	public class ICheckpointDisplay_UnionUnion
	{
		// Token: 0x17006E26 RID: 28198
		// (get) Token: 0x06016314 RID: 90900 RVA: 0x0032E77E File Offset: 0x0032C97E
		// (set) Token: 0x06016315 RID: 90901 RVA: 0x0032E786 File Offset: 0x0032C986
		public ICheckpointDisplay_Union Type { get; set; }

		// Token: 0x17006E27 RID: 28199
		// (get) Token: 0x06016316 RID: 90902 RVA: 0x0032E78F File Offset: 0x0032C98F
		// (set) Token: 0x06016317 RID: 90903 RVA: 0x0032E797 File Offset: 0x0032C997
		public object Value { get; set; }

		// Token: 0x06016318 RID: 90904 RVA: 0x0032E7A0 File Offset: 0x0032C9A0
		public ICheckpointDisplay_UnionUnion()
		{
			this.Type = ICheckpointDisplay_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06016319 RID: 90905 RVA: 0x0032E7B6 File Offset: 0x0032C9B6
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601631A RID: 90906 RVA: 0x0032E7C8 File Offset: 0x0032C9C8
		public ICheckpointDisplayT AsICheckpointDisplay()
		{
			return this.As<ICheckpointDisplayT>();
		}

		// Token: 0x0601631B RID: 90907 RVA: 0x0032E7D0 File Offset: 0x0032C9D0
		public static ICheckpointDisplay_UnionUnion FromICheckpointDisplay(ICheckpointDisplayT _icheckpointdisplay)
		{
			return new ICheckpointDisplay_UnionUnion
			{
				Type = ICheckpointDisplay_Union.ICheckpointDisplay,
				Value = _icheckpointdisplay
			};
		}

		// Token: 0x0601631C RID: 90908 RVA: 0x0032E7E5 File Offset: 0x0032C9E5
		public ICheckpointDisplayRoleT AsICheckpointDisplayRole()
		{
			return this.As<ICheckpointDisplayRoleT>();
		}

		// Token: 0x0601631D RID: 90909 RVA: 0x0032E7ED File Offset: 0x0032C9ED
		public static ICheckpointDisplay_UnionUnion FromICheckpointDisplayRole(ICheckpointDisplayRoleT _icheckpointdisplayrole)
		{
			return new ICheckpointDisplay_UnionUnion
			{
				Type = ICheckpointDisplay_Union.ICheckpointDisplayRole,
				Value = _icheckpointdisplayrole
			};
		}

		// Token: 0x0601631E RID: 90910 RVA: 0x0032E804 File Offset: 0x0032CA04
		public static int Pack(FlatBufferBuilder builder, ICheckpointDisplay_UnionUnion _o)
		{
			ICheckpointDisplay_Union type = _o.Type;
			if (type == ICheckpointDisplay_Union.ICheckpointDisplay)
			{
				return ICheckpointDisplay.Pack(builder, _o.AsICheckpointDisplay()).Value;
			}
			if (type != ICheckpointDisplay_Union.ICheckpointDisplayRole)
			{
				return 0;
			}
			return ICheckpointDisplayRole.Pack(builder, _o.AsICheckpointDisplayRole()).Value;
		}
	}
}
