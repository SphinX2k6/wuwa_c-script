using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004ADF RID: 19167
	public class ICheckPlayerCanJoinActivityType_UnionUnion
	{
		// Token: 0x17008AF6 RID: 35574
		// (get) Token: 0x0601E1B4 RID: 123316 RVA: 0x0043926A File Offset: 0x0043746A
		// (set) Token: 0x0601E1B5 RID: 123317 RVA: 0x00439272 File Offset: 0x00437472
		public ICheckPlayerCanJoinActivityType_Union Type { get; set; }

		// Token: 0x17008AF7 RID: 35575
		// (get) Token: 0x0601E1B6 RID: 123318 RVA: 0x0043927B File Offset: 0x0043747B
		// (set) Token: 0x0601E1B7 RID: 123319 RVA: 0x00439283 File Offset: 0x00437483
		public object Value { get; set; }

		// Token: 0x0601E1B8 RID: 123320 RVA: 0x0043928C File Offset: 0x0043748C
		public ICheckPlayerCanJoinActivityType_UnionUnion()
		{
			this.Type = ICheckPlayerCanJoinActivityType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601E1B9 RID: 123321 RVA: 0x004392A2 File Offset: 0x004374A2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601E1BA RID: 123322 RVA: 0x004392B4 File Offset: 0x004374B4
		public ICheckPlayerCanJoinActivityTypeT AsICheckPlayerCanJoinActivityType()
		{
			return this.As<ICheckPlayerCanJoinActivityTypeT>();
		}

		// Token: 0x0601E1BB RID: 123323 RVA: 0x004392BC File Offset: 0x004374BC
		public static ICheckPlayerCanJoinActivityType_UnionUnion FromICheckPlayerCanJoinActivityType(ICheckPlayerCanJoinActivityTypeT _icheckplayercanjoinactivitytype)
		{
			return new ICheckPlayerCanJoinActivityType_UnionUnion
			{
				Type = ICheckPlayerCanJoinActivityType_Union.ICheckPlayerCanJoinActivityType,
				Value = _icheckplayercanjoinactivitytype
			};
		}

		// Token: 0x0601E1BC RID: 123324 RVA: 0x004392D1 File Offset: 0x004374D1
		public ICheckPlayerCanJoinRogueT AsICheckPlayerCanJoinRogue()
		{
			return this.As<ICheckPlayerCanJoinRogueT>();
		}

		// Token: 0x0601E1BD RID: 123325 RVA: 0x004392D9 File Offset: 0x004374D9
		public static ICheckPlayerCanJoinActivityType_UnionUnion FromICheckPlayerCanJoinRogue(ICheckPlayerCanJoinRogueT _icheckplayercanjoinrogue)
		{
			return new ICheckPlayerCanJoinActivityType_UnionUnion
			{
				Type = ICheckPlayerCanJoinActivityType_Union.ICheckPlayerCanJoinRogue,
				Value = _icheckplayercanjoinrogue
			};
		}

		// Token: 0x0601E1BE RID: 123326 RVA: 0x004392F0 File Offset: 0x004374F0
		public static int Pack(FlatBufferBuilder builder, ICheckPlayerCanJoinActivityType_UnionUnion _o)
		{
			ICheckPlayerCanJoinActivityType_Union type = _o.Type;
			if (type == ICheckPlayerCanJoinActivityType_Union.ICheckPlayerCanJoinActivityType)
			{
				return ICheckPlayerCanJoinActivityType.Pack(builder, _o.AsICheckPlayerCanJoinActivityType()).Value;
			}
			if (type != ICheckPlayerCanJoinActivityType_Union.ICheckPlayerCanJoinRogue)
			{
				return 0;
			}
			return ICheckPlayerCanJoinRogue.Pack(builder, _o.AsICheckPlayerCanJoinRogue()).Value;
		}
	}
}
