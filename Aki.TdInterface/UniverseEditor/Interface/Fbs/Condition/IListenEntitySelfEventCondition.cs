using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C4C RID: 19532
	public struct IListenEntitySelfEventCondition : IFlatbufferObject
	{
		// Token: 0x17008DE6 RID: 36326
		// (get) Token: 0x0601EF69 RID: 126825 RVA: 0x00454CC6 File Offset: 0x00452EC6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EF6A RID: 126826 RVA: 0x00454CD3 File Offset: 0x00452ED3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EF6B RID: 126827 RVA: 0x00454CDC File Offset: 0x00452EDC
		public static IListenEntitySelfEventCondition GetRootAsIListenEntitySelfEventCondition(ByteBuffer _bb)
		{
			return IListenEntitySelfEventCondition.GetRootAsIListenEntitySelfEventCondition(_bb, default(IListenEntitySelfEventCondition));
		}

		// Token: 0x0601EF6C RID: 126828 RVA: 0x00454CF8 File Offset: 0x00452EF8
		public static IListenEntitySelfEventCondition GetRootAsIListenEntitySelfEventCondition(ByteBuffer _bb, IListenEntitySelfEventCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EF6D RID: 126829 RVA: 0x00454D15 File Offset: 0x00452F15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EF6E RID: 126830 RVA: 0x00454D24 File Offset: 0x00452F24
		public IListenEntitySelfEventCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008DE7 RID: 36327
		// (get) Token: 0x0601EF6F RID: 126831 RVA: 0x00454D34 File Offset: 0x00452F34
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008DE8 RID: 36328
		// (get) Token: 0x0601EF70 RID: 126832 RVA: 0x00454D70 File Offset: 0x00452F70
		public string EventKey
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601EF71 RID: 126833 RVA: 0x00454DA7 File Offset: 0x00452FA7
		public Span<byte> GetEventKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601EF72 RID: 126834 RVA: 0x00454DB6 File Offset: 0x00452FB6
		public byte[] GetEventKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17008DE9 RID: 36329
		// (get) Token: 0x0601EF73 RID: 126835 RVA: 0x00454DC4 File Offset: 0x00452FC4
		public bool ResetAfterConditionMet
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008DEA RID: 36330
		// (get) Token: 0x0601EF74 RID: 126836 RVA: 0x00454E04 File Offset: 0x00453004
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601EF75 RID: 126837 RVA: 0x00454E41 File Offset: 0x00453041
		public static Offset<IListenEntitySelfEventCondition> CreateIListenEntitySelfEventCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, StringOffset EventKeyOffset = default(StringOffset), bool ResetAfterConditionMet = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IListenEntitySelfEventCondition.AddEventKey(builder, EventKeyOffset);
			IListenEntitySelfEventCondition.AddNullMask(builder, NullMask);
			IListenEntitySelfEventCondition.AddResetAfterConditionMet(builder, ResetAfterConditionMet);
			IListenEntitySelfEventCondition.AddType(builder, Type);
			return IListenEntitySelfEventCondition.EndIListenEntitySelfEventCondition(builder);
		}

		// Token: 0x0601EF76 RID: 126838 RVA: 0x00454E6D File Offset: 0x0045306D
		public static void StartIListenEntitySelfEventCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601EF77 RID: 126839 RVA: 0x00454E76 File Offset: 0x00453076
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EF78 RID: 126840 RVA: 0x00454E81 File Offset: 0x00453081
		public static void AddEventKey(FlatBufferBuilder builder, StringOffset eventKeyOffset)
		{
			builder.AddOffset(1, eventKeyOffset.Value, 0);
		}

		// Token: 0x0601EF79 RID: 126841 RVA: 0x00454E91 File Offset: 0x00453091
		public static void AddResetAfterConditionMet(FlatBufferBuilder builder, bool resetAfterConditionMet)
		{
			builder.AddBool(2, resetAfterConditionMet, false);
		}

		// Token: 0x0601EF7A RID: 126842 RVA: 0x00454E9C File Offset: 0x0045309C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0601EF7B RID: 126843 RVA: 0x00454EA7 File Offset: 0x004530A7
		public static Offset<IListenEntitySelfEventCondition> EndIListenEntitySelfEventCondition(FlatBufferBuilder builder)
		{
			return new Offset<IListenEntitySelfEventCondition>(builder.EndTable());
		}

		// Token: 0x0601EF7C RID: 126844 RVA: 0x00454EB4 File Offset: 0x004530B4
		public IListenEntitySelfEventConditionT UnPack()
		{
			IListenEntitySelfEventConditionT listenEntitySelfEventConditionT = new IListenEntitySelfEventConditionT();
			this.UnPackTo(listenEntitySelfEventConditionT);
			return listenEntitySelfEventConditionT;
		}

		// Token: 0x0601EF7D RID: 126845 RVA: 0x00454ECF File Offset: 0x004530CF
		public void UnPackTo(IListenEntitySelfEventConditionT _o)
		{
			_o.Type = this.Type;
			_o.EventKey = this.EventKey;
			_o.ResetAfterConditionMet = this.ResetAfterConditionMet;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601EF7E RID: 126846 RVA: 0x00454F04 File Offset: 0x00453104
		public static Offset<IListenEntitySelfEventCondition> Pack(FlatBufferBuilder builder, IListenEntitySelfEventConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IListenEntitySelfEventCondition>);
			}
			StringOffset eventKeyOffset = (_o.EventKey == null) ? default(StringOffset) : builder.CreateString(_o.EventKey);
			return IListenEntitySelfEventCondition.CreateIListenEntitySelfEventCondition(builder, _o.Type, eventKeyOffset, _o.ResetAfterConditionMet, _o.NullMask);
		}

		// Token: 0x0400D5F3 RID: 54771
		private Table __p;
	}
}
