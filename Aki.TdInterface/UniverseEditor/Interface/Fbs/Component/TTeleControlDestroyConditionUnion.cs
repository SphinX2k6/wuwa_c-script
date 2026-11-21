using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062EF RID: 25327
	public class TTeleControlDestroyConditionUnion
	{
		// Token: 0x1700BBB6 RID: 48054
		// (get) Token: 0x0602B08B RID: 176267 RVA: 0x005DE132 File Offset: 0x005DC332
		// (set) Token: 0x0602B08C RID: 176268 RVA: 0x005DE13A File Offset: 0x005DC33A
		public TTeleControlDestroyCondition Type { get; set; }

		// Token: 0x1700BBB7 RID: 48055
		// (get) Token: 0x0602B08D RID: 176269 RVA: 0x005DE143 File Offset: 0x005DC343
		// (set) Token: 0x0602B08E RID: 176270 RVA: 0x005DE14B File Offset: 0x005DC34B
		public object Value { get; set; }

		// Token: 0x0602B08F RID: 176271 RVA: 0x005DE154 File Offset: 0x005DC354
		public TTeleControlDestroyConditionUnion()
		{
			this.Type = TTeleControlDestroyCondition.NONE;
			this.Value = null;
		}

		// Token: 0x0602B090 RID: 176272 RVA: 0x005DE16A File Offset: 0x005DC36A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B091 RID: 176273 RVA: 0x005DE17C File Offset: 0x005DC37C
		public ICreateBulletDestroyConditionT AsICreateBulletDestroyCondition()
		{
			return this.As<ICreateBulletDestroyConditionT>();
		}

		// Token: 0x0602B092 RID: 176274 RVA: 0x005DE184 File Offset: 0x005DC384
		public static TTeleControlDestroyConditionUnion FromICreateBulletDestroyCondition(ICreateBulletDestroyConditionT _icreatebulletdestroycondition)
		{
			return new TTeleControlDestroyConditionUnion
			{
				Type = TTeleControlDestroyCondition.ICreateBulletDestroyCondition,
				Value = _icreatebulletdestroycondition
			};
		}

		// Token: 0x0602B093 RID: 176275 RVA: 0x005DE199 File Offset: 0x005DC399
		public ILetGoDestroyConditionT AsILetGoDestroyCondition()
		{
			return this.As<ILetGoDestroyConditionT>();
		}

		// Token: 0x0602B094 RID: 176276 RVA: 0x005DE1A1 File Offset: 0x005DC3A1
		public static TTeleControlDestroyConditionUnion FromILetGoDestroyCondition(ILetGoDestroyConditionT _iletgodestroycondition)
		{
			return new TTeleControlDestroyConditionUnion
			{
				Type = TTeleControlDestroyCondition.ILetGoDestroyCondition,
				Value = _iletgodestroycondition
			};
		}

		// Token: 0x0602B095 RID: 176277 RVA: 0x005DE1B6 File Offset: 0x005DC3B6
		public IThrowDestroyConditionT AsIThrowDestroyCondition()
		{
			return this.As<IThrowDestroyConditionT>();
		}

		// Token: 0x0602B096 RID: 176278 RVA: 0x005DE1BE File Offset: 0x005DC3BE
		public static TTeleControlDestroyConditionUnion FromIThrowDestroyCondition(IThrowDestroyConditionT _ithrowdestroycondition)
		{
			return new TTeleControlDestroyConditionUnion
			{
				Type = TTeleControlDestroyCondition.IThrowDestroyCondition,
				Value = _ithrowdestroycondition
			};
		}

		// Token: 0x0602B097 RID: 176279 RVA: 0x005DE1D4 File Offset: 0x005DC3D4
		public static int Pack(FlatBufferBuilder builder, TTeleControlDestroyConditionUnion _o)
		{
			switch (_o.Type)
			{
			case TTeleControlDestroyCondition.ICreateBulletDestroyCondition:
				return ICreateBulletDestroyCondition.Pack(builder, _o.AsICreateBulletDestroyCondition()).Value;
			case TTeleControlDestroyCondition.ILetGoDestroyCondition:
				return ILetGoDestroyCondition.Pack(builder, _o.AsILetGoDestroyCondition()).Value;
			case TTeleControlDestroyCondition.IThrowDestroyCondition:
				return IThrowDestroyCondition.Pack(builder, _o.AsIThrowDestroyCondition()).Value;
			default:
				return 0;
			}
		}
	}
}
