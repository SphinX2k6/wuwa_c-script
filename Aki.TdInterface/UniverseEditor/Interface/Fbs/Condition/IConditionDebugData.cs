using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BE0 RID: 19424
	public struct IConditionDebugData : IFlatbufferObject
	{
		// Token: 0x17008D1A RID: 36122
		// (get) Token: 0x0601EBD7 RID: 125911 RVA: 0x0044C5C3 File Offset: 0x0044A7C3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EBD8 RID: 125912 RVA: 0x0044C5D0 File Offset: 0x0044A7D0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EBD9 RID: 125913 RVA: 0x0044C5D8 File Offset: 0x0044A7D8
		public static IConditionDebugData GetRootAsIConditionDebugData(ByteBuffer _bb)
		{
			return IConditionDebugData.GetRootAsIConditionDebugData(_bb, default(IConditionDebugData));
		}

		// Token: 0x0601EBDA RID: 125914 RVA: 0x0044C5F4 File Offset: 0x0044A7F4
		public static IConditionDebugData GetRootAsIConditionDebugData(ByteBuffer _bb, IConditionDebugData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EBDB RID: 125915 RVA: 0x0044C611 File Offset: 0x0044A811
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EBDC RID: 125916 RVA: 0x0044C620 File Offset: 0x0044A820
		public IConditionDebugData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D1B RID: 36123
		// (get) Token: 0x0601EBDD RID: 125917 RVA: 0x0044C630 File Offset: 0x0044A830
		public EConditionLogicType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EConditionLogicType.BaseAccessQuest;
				}
				return (EConditionLogicType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601EBDE RID: 125918 RVA: 0x0044C66C File Offset: 0x0044A86C
		public static Offset<IConditionDebugData> CreateIConditionDebugData(FlatBufferBuilder builder, EConditionLogicType Type = EConditionLogicType.BaseAccessQuest)
		{
			builder.StartTable(1);
			IConditionDebugData.AddType(builder, Type);
			return IConditionDebugData.EndIConditionDebugData(builder);
		}

		// Token: 0x0601EBDF RID: 125919 RVA: 0x0044C682 File Offset: 0x0044A882
		public static void StartIConditionDebugData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601EBE0 RID: 125920 RVA: 0x0044C68B File Offset: 0x0044A88B
		public static void AddType(FlatBufferBuilder builder, EConditionLogicType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EBE1 RID: 125921 RVA: 0x0044C696 File Offset: 0x0044A896
		public static Offset<IConditionDebugData> EndIConditionDebugData(FlatBufferBuilder builder)
		{
			return new Offset<IConditionDebugData>(builder.EndTable());
		}

		// Token: 0x0601EBE2 RID: 125922 RVA: 0x0044C6A4 File Offset: 0x0044A8A4
		public IConditionDebugDataT UnPack()
		{
			IConditionDebugDataT conditionDebugDataT = new IConditionDebugDataT();
			this.UnPackTo(conditionDebugDataT);
			return conditionDebugDataT;
		}

		// Token: 0x0601EBE3 RID: 125923 RVA: 0x0044C6BF File Offset: 0x0044A8BF
		public void UnPackTo(IConditionDebugDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601EBE4 RID: 125924 RVA: 0x0044C6D0 File Offset: 0x0044A8D0
		public static Offset<IConditionDebugData> Pack(FlatBufferBuilder builder, IConditionDebugDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConditionDebugData>);
			}
			return IConditionDebugData.CreateIConditionDebugData(builder, _o.Type);
		}

		// Token: 0x0400D566 RID: 54630
		private Table __p;
	}
}
