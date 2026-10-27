using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003B96 RID: 15254
	public class ICheckpointDisplay_UnionUnion
	{
		// Token: 0x17006887 RID: 26759
		// (get) Token: 0x06014E4A RID: 85578 RVA: 0x003081E6 File Offset: 0x003063E6
		// (set) Token: 0x06014E4B RID: 85579 RVA: 0x003081EE File Offset: 0x003063EE
		public ICheckpointDisplay_Union Type { get; set; }

		// Token: 0x17006888 RID: 26760
		// (get) Token: 0x06014E4C RID: 85580 RVA: 0x003081F7 File Offset: 0x003063F7
		// (set) Token: 0x06014E4D RID: 85581 RVA: 0x003081FF File Offset: 0x003063FF
		public object Value { get; set; }

		// Token: 0x06014E4E RID: 85582 RVA: 0x00308208 File Offset: 0x00306408
		public ICheckpointDisplay_UnionUnion()
		{
			this.Type = ICheckpointDisplay_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06014E4F RID: 85583 RVA: 0x0030821E File Offset: 0x0030641E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06014E50 RID: 85584 RVA: 0x00308230 File Offset: 0x00306430
		public ICheckpointDisplayT AsICheckpointDisplay()
		{
			return this.As<ICheckpointDisplayT>();
		}

		// Token: 0x06014E51 RID: 85585 RVA: 0x00308238 File Offset: 0x00306438
		public static ICheckpointDisplay_UnionUnion FromICheckpointDisplay(ICheckpointDisplayT _icheckpointdisplay)
		{
			return new ICheckpointDisplay_UnionUnion
			{
				Type = ICheckpointDisplay_Union.ICheckpointDisplay,
				Value = _icheckpointdisplay
			};
		}

		// Token: 0x06014E52 RID: 85586 RVA: 0x0030824D File Offset: 0x0030644D
		public ICheckpointDisplayRoleT AsICheckpointDisplayRole()
		{
			return this.As<ICheckpointDisplayRoleT>();
		}

		// Token: 0x06014E53 RID: 85587 RVA: 0x00308255 File Offset: 0x00306455
		public static ICheckpointDisplay_UnionUnion FromICheckpointDisplayRole(ICheckpointDisplayRoleT _icheckpointdisplayrole)
		{
			return new ICheckpointDisplay_UnionUnion
			{
				Type = ICheckpointDisplay_Union.ICheckpointDisplayRole,
				Value = _icheckpointdisplayrole
			};
		}

		// Token: 0x06014E54 RID: 85588 RVA: 0x0030826C File Offset: 0x0030646C
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
