using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006262 RID: 25186
	public class TInhalationPerformanceUnion
	{
		// Token: 0x1700BB58 RID: 47960
		// (get) Token: 0x0602ADE3 RID: 175587 RVA: 0x005DA302 File Offset: 0x005D8502
		// (set) Token: 0x0602ADE4 RID: 175588 RVA: 0x005DA30A File Offset: 0x005D850A
		public TInhalationPerformance Type { get; set; }

		// Token: 0x1700BB59 RID: 47961
		// (get) Token: 0x0602ADE5 RID: 175589 RVA: 0x005DA313 File Offset: 0x005D8513
		// (set) Token: 0x0602ADE6 RID: 175590 RVA: 0x005DA31B File Offset: 0x005D851B
		public object Value { get; set; }

		// Token: 0x0602ADE7 RID: 175591 RVA: 0x005DA324 File Offset: 0x005D8524
		public TInhalationPerformanceUnion()
		{
			this.Type = TInhalationPerformance.NONE;
			this.Value = null;
		}

		// Token: 0x0602ADE8 RID: 175592 RVA: 0x005DA33A File Offset: 0x005D853A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602ADE9 RID: 175593 RVA: 0x005DA34C File Offset: 0x005D854C
		public IRoleInhalationT AsIRoleInhalation()
		{
			return this.As<IRoleInhalationT>();
		}

		// Token: 0x0602ADEA RID: 175594 RVA: 0x005DA354 File Offset: 0x005D8554
		public static TInhalationPerformanceUnion FromIRoleInhalation(IRoleInhalationT _iroleinhalation)
		{
			return new TInhalationPerformanceUnion
			{
				Type = TInhalationPerformance.IRoleInhalation,
				Value = _iroleinhalation
			};
		}

		// Token: 0x0602ADEB RID: 175595 RVA: 0x005DA369 File Offset: 0x005D8569
		public ISceneItemInhalationT AsISceneItemInhalation()
		{
			return this.As<ISceneItemInhalationT>();
		}

		// Token: 0x0602ADEC RID: 175596 RVA: 0x005DA371 File Offset: 0x005D8571
		public static TInhalationPerformanceUnion FromISceneItemInhalation(ISceneItemInhalationT _isceneiteminhalation)
		{
			return new TInhalationPerformanceUnion
			{
				Type = TInhalationPerformance.ISceneItemInhalation,
				Value = _isceneiteminhalation
			};
		}

		// Token: 0x0602ADED RID: 175597 RVA: 0x005DA388 File Offset: 0x005D8588
		public static int Pack(FlatBufferBuilder builder, TInhalationPerformanceUnion _o)
		{
			TInhalationPerformance type = _o.Type;
			if (type == TInhalationPerformance.IRoleInhalation)
			{
				return IRoleInhalation.Pack(builder, _o.AsIRoleInhalation()).Value;
			}
			if (type != TInhalationPerformance.ISceneItemInhalation)
			{
				return 0;
			}
			return ISceneItemInhalation.Pack(builder, _o.AsISceneItemInhalation()).Value;
		}
	}
}
