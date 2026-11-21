using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FCB RID: 32715
	public class TSkillOperationUnion
	{
		// Token: 0x1700F2FF RID: 62207
		// (get) Token: 0x0603AE8B RID: 241291 RVA: 0x007E9F1C File Offset: 0x007E811C
		// (set) Token: 0x0603AE8C RID: 241292 RVA: 0x007E9F24 File Offset: 0x007E8124
		public TSkillOperation Type { get; set; }

		// Token: 0x1700F300 RID: 62208
		// (get) Token: 0x0603AE8D RID: 241293 RVA: 0x007E9F2D File Offset: 0x007E812D
		// (set) Token: 0x0603AE8E RID: 241294 RVA: 0x007E9F35 File Offset: 0x007E8135
		public object Value { get; set; }

		// Token: 0x0603AE8F RID: 241295 RVA: 0x007E9F3E File Offset: 0x007E813E
		public TSkillOperationUnion()
		{
			this.Type = TSkillOperation.NONE;
			this.Value = null;
		}

		// Token: 0x0603AE90 RID: 241296 RVA: 0x007E9F54 File Offset: 0x007E8154
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AE91 RID: 241297 RVA: 0x007E9F66 File Offset: 0x007E8166
		public IDisableSectionalSkillOperationT AsIDisableSectionalSkillOperation()
		{
			return this.As<IDisableSectionalSkillOperationT>();
		}

		// Token: 0x0603AE92 RID: 241298 RVA: 0x007E9F6E File Offset: 0x007E816E
		public static TSkillOperationUnion FromIDisableSectionalSkillOperation(IDisableSectionalSkillOperationT _idisablesectionalskilloperation)
		{
			return new TSkillOperationUnion
			{
				Type = TSkillOperation.IDisableSectionalSkillOperation,
				Value = _idisablesectionalskilloperation
			};
		}

		// Token: 0x0603AE93 RID: 241299 RVA: 0x007E9F83 File Offset: 0x007E8183
		public IDisableSkillOperationT AsIDisableSkillOperation()
		{
			return this.As<IDisableSkillOperationT>();
		}

		// Token: 0x0603AE94 RID: 241300 RVA: 0x007E9F8B File Offset: 0x007E818B
		public static TSkillOperationUnion FromIDisableSkillOperation(IDisableSkillOperationT _idisableskilloperation)
		{
			return new TSkillOperationUnion
			{
				Type = TSkillOperation.IDisableSkillOperation,
				Value = _idisableskilloperation
			};
		}

		// Token: 0x0603AE95 RID: 241301 RVA: 0x007E9FA0 File Offset: 0x007E81A0
		public IEnableSkillOperationT AsIEnableSkillOperation()
		{
			return this.As<IEnableSkillOperationT>();
		}

		// Token: 0x0603AE96 RID: 241302 RVA: 0x007E9FA8 File Offset: 0x007E81A8
		public static TSkillOperationUnion FromIEnableSkillOperation(IEnableSkillOperationT _ienableskilloperation)
		{
			return new TSkillOperationUnion
			{
				Type = TSkillOperation.IEnableSkillOperation,
				Value = _ienableskilloperation
			};
		}

		// Token: 0x0603AE97 RID: 241303 RVA: 0x007E9FC0 File Offset: 0x007E81C0
		public static int Pack(FlatBufferBuilder builder, TSkillOperationUnion _o)
		{
			switch (_o.Type)
			{
			case TSkillOperation.IDisableSectionalSkillOperation:
				return IDisableSectionalSkillOperation.Pack(builder, _o.AsIDisableSectionalSkillOperation()).Value;
			case TSkillOperation.IDisableSkillOperation:
				return IDisableSkillOperation.Pack(builder, _o.AsIDisableSkillOperation()).Value;
			case TSkillOperation.IEnableSkillOperation:
				return IEnableSkillOperation.Pack(builder, _o.AsIEnableSkillOperation()).Value;
			default:
				return 0;
			}
		}
	}
}
