using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FB4 RID: 20404
	public class ICheckPlayerCanJoinActivityType_UnionUnion
	{
		// Token: 0x170091ED RID: 37357
		// (get) Token: 0x0601FCC9 RID: 130249 RVA: 0x0046AF16 File Offset: 0x00469116
		// (set) Token: 0x0601FCCA RID: 130250 RVA: 0x0046AF1E File Offset: 0x0046911E
		public ICheckPlayerCanJoinActivityType_Union Type { get; set; }

		// Token: 0x170091EE RID: 37358
		// (get) Token: 0x0601FCCB RID: 130251 RVA: 0x0046AF27 File Offset: 0x00469127
		// (set) Token: 0x0601FCCC RID: 130252 RVA: 0x0046AF2F File Offset: 0x0046912F
		public object Value { get; set; }

		// Token: 0x0601FCCD RID: 130253 RVA: 0x0046AF38 File Offset: 0x00469138
		public ICheckPlayerCanJoinActivityType_UnionUnion()
		{
			this.Type = ICheckPlayerCanJoinActivityType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601FCCE RID: 130254 RVA: 0x0046AF4E File Offset: 0x0046914E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601FCCF RID: 130255 RVA: 0x0046AF60 File Offset: 0x00469160
		public ICheckPlayerCanJoinActivityTypeT AsICheckPlayerCanJoinActivityType()
		{
			return this.As<ICheckPlayerCanJoinActivityTypeT>();
		}

		// Token: 0x0601FCD0 RID: 130256 RVA: 0x0046AF68 File Offset: 0x00469168
		public static ICheckPlayerCanJoinActivityType_UnionUnion FromICheckPlayerCanJoinActivityType(ICheckPlayerCanJoinActivityTypeT _icheckplayercanjoinactivitytype)
		{
			return new ICheckPlayerCanJoinActivityType_UnionUnion
			{
				Type = ICheckPlayerCanJoinActivityType_Union.ICheckPlayerCanJoinActivityType,
				Value = _icheckplayercanjoinactivitytype
			};
		}

		// Token: 0x0601FCD1 RID: 130257 RVA: 0x0046AF7D File Offset: 0x0046917D
		public ICheckPlayerCanJoinRogueT AsICheckPlayerCanJoinRogue()
		{
			return this.As<ICheckPlayerCanJoinRogueT>();
		}

		// Token: 0x0601FCD2 RID: 130258 RVA: 0x0046AF85 File Offset: 0x00469185
		public static ICheckPlayerCanJoinActivityType_UnionUnion FromICheckPlayerCanJoinRogue(ICheckPlayerCanJoinRogueT _icheckplayercanjoinrogue)
		{
			return new ICheckPlayerCanJoinActivityType_UnionUnion
			{
				Type = ICheckPlayerCanJoinActivityType_Union.ICheckPlayerCanJoinRogue,
				Value = _icheckplayercanjoinrogue
			};
		}

		// Token: 0x0601FCD3 RID: 130259 RVA: 0x0046AF9C File Offset: 0x0046919C
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
