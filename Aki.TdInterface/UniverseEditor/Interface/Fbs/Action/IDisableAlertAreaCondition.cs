using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065C4 RID: 26052
	public struct IDisableAlertAreaCondition : IFlatbufferObject
	{
		// Token: 0x1700C15D RID: 49501
		// (get) Token: 0x0602D2EC RID: 185068 RVA: 0x00631C7E File Offset: 0x0062FE7E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D2ED RID: 185069 RVA: 0x00631C8B File Offset: 0x0062FE8B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D2EE RID: 185070 RVA: 0x00631C94 File Offset: 0x0062FE94
		public static IDisableAlertAreaCondition GetRootAsIDisableAlertAreaCondition(ByteBuffer _bb)
		{
			return IDisableAlertAreaCondition.GetRootAsIDisableAlertAreaCondition(_bb, default(IDisableAlertAreaCondition));
		}

		// Token: 0x0602D2EF RID: 185071 RVA: 0x00631CB0 File Offset: 0x0062FEB0
		public static IDisableAlertAreaCondition GetRootAsIDisableAlertAreaCondition(ByteBuffer _bb, IDisableAlertAreaCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D2F0 RID: 185072 RVA: 0x00631CCD File Offset: 0x0062FECD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D2F1 RID: 185073 RVA: 0x00631CDC File Offset: 0x0062FEDC
		public IDisableAlertAreaCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C15E RID: 49502
		// (get) Token: 0x0602D2F2 RID: 185074 RVA: 0x00631CEC File Offset: 0x0062FEEC
		public EDisableAlertAreaCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDisableAlertAreaCondition.DungeonCondition;
				}
				return (EDisableAlertAreaCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D2F3 RID: 185075 RVA: 0x00631D28 File Offset: 0x0062FF28
		public static Offset<IDisableAlertAreaCondition> CreateIDisableAlertAreaCondition(FlatBufferBuilder builder, EDisableAlertAreaCondition Type = EDisableAlertAreaCondition.DungeonCondition)
		{
			builder.StartTable(1);
			IDisableAlertAreaCondition.AddType(builder, Type);
			return IDisableAlertAreaCondition.EndIDisableAlertAreaCondition(builder);
		}

		// Token: 0x0602D2F4 RID: 185076 RVA: 0x00631D3E File Offset: 0x0062FF3E
		public static void StartIDisableAlertAreaCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D2F5 RID: 185077 RVA: 0x00631D47 File Offset: 0x0062FF47
		public static void AddType(FlatBufferBuilder builder, EDisableAlertAreaCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D2F6 RID: 185078 RVA: 0x00631D52 File Offset: 0x0062FF52
		public static Offset<IDisableAlertAreaCondition> EndIDisableAlertAreaCondition(FlatBufferBuilder builder)
		{
			return new Offset<IDisableAlertAreaCondition>(builder.EndTable());
		}

		// Token: 0x0602D2F7 RID: 185079 RVA: 0x00631D60 File Offset: 0x0062FF60
		public IDisableAlertAreaConditionT UnPack()
		{
			IDisableAlertAreaConditionT disableAlertAreaConditionT = new IDisableAlertAreaConditionT();
			this.UnPackTo(disableAlertAreaConditionT);
			return disableAlertAreaConditionT;
		}

		// Token: 0x0602D2F8 RID: 185080 RVA: 0x00631D7B File Offset: 0x0062FF7B
		public void UnPackTo(IDisableAlertAreaConditionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602D2F9 RID: 185081 RVA: 0x00631D8C File Offset: 0x0062FF8C
		public static Offset<IDisableAlertAreaCondition> Pack(FlatBufferBuilder builder, IDisableAlertAreaConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableAlertAreaCondition>);
			}
			return IDisableAlertAreaCondition.CreateIDisableAlertAreaCondition(builder, _o.Type);
		}

		// Token: 0x04010C22 RID: 68642
		private Table __p;
	}
}
