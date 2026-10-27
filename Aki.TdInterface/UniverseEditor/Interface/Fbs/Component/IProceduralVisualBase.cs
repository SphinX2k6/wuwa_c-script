using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005790 RID: 22416
	public struct IProceduralVisualBase : IFlatbufferObject
	{
		// Token: 0x1700A72E RID: 42798
		// (get) Token: 0x06025945 RID: 153925 RVA: 0x0052EEBE File Offset: 0x0052D0BE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025946 RID: 153926 RVA: 0x0052EECB File Offset: 0x0052D0CB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025947 RID: 153927 RVA: 0x0052EED4 File Offset: 0x0052D0D4
		public static IProceduralVisualBase GetRootAsIProceduralVisualBase(ByteBuffer _bb)
		{
			return IProceduralVisualBase.GetRootAsIProceduralVisualBase(_bb, default(IProceduralVisualBase));
		}

		// Token: 0x06025948 RID: 153928 RVA: 0x0052EEF0 File Offset: 0x0052D0F0
		public static IProceduralVisualBase GetRootAsIProceduralVisualBase(ByteBuffer _bb, IProceduralVisualBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025949 RID: 153929 RVA: 0x0052EF0D File Offset: 0x0052D10D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602594A RID: 153930 RVA: 0x0052EF1C File Offset: 0x0052D11C
		public IProceduralVisualBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A72F RID: 42799
		// (get) Token: 0x0602594B RID: 153931 RVA: 0x0052EF2C File Offset: 0x0052D12C
		public EProceduralVisualType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EProceduralVisualType.LookAt;
				}
				return (EProceduralVisualType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A730 RID: 42800
		// (get) Token: 0x0602594C RID: 153932 RVA: 0x0052EF68 File Offset: 0x0052D168
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602594D RID: 153933 RVA: 0x0052EFC5 File Offset: 0x0052D1C5
		public static Offset<IProceduralVisualBase> CreateIProceduralVisualBase(FlatBufferBuilder builder, EProceduralVisualType Type = EProceduralVisualType.LookAt, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(2);
			IProceduralVisualBase.AddCondition(builder, ConditionOffset);
			IProceduralVisualBase.AddType(builder, Type);
			return IProceduralVisualBase.EndIProceduralVisualBase(builder);
		}

		// Token: 0x0602594E RID: 153934 RVA: 0x0052EFE2 File Offset: 0x0052D1E2
		public static void StartIProceduralVisualBase(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602594F RID: 153935 RVA: 0x0052EFEB File Offset: 0x0052D1EB
		public static void AddType(FlatBufferBuilder builder, EProceduralVisualType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025950 RID: 153936 RVA: 0x0052EFF6 File Offset: 0x0052D1F6
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(1, conditionOffset.Value, 0);
		}

		// Token: 0x06025951 RID: 153937 RVA: 0x0052F006 File Offset: 0x0052D206
		public static Offset<IProceduralVisualBase> EndIProceduralVisualBase(FlatBufferBuilder builder)
		{
			return new Offset<IProceduralVisualBase>(builder.EndTable());
		}

		// Token: 0x06025952 RID: 153938 RVA: 0x0052F014 File Offset: 0x0052D214
		public IProceduralVisualBaseT UnPack()
		{
			IProceduralVisualBaseT proceduralVisualBaseT = new IProceduralVisualBaseT();
			this.UnPackTo(proceduralVisualBaseT);
			return proceduralVisualBaseT;
		}

		// Token: 0x06025953 RID: 153939 RVA: 0x0052F030 File Offset: 0x0052D230
		public void UnPackTo(IProceduralVisualBaseT _o)
		{
			_o.Type = this.Type;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
		}

		// Token: 0x06025954 RID: 153940 RVA: 0x0052F078 File Offset: 0x0052D278
		public static Offset<IProceduralVisualBase> Pack(FlatBufferBuilder builder, IProceduralVisualBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IProceduralVisualBase>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			return IProceduralVisualBase.CreateIProceduralVisualBase(builder, _o.Type, conditionOffset);
		}

		// Token: 0x0400EC41 RID: 60481
		private Table __p;
	}
}
