using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200513F RID: 20799
	public struct IListenEntitySelfEventCondition : IFlatbufferObject
	{
		// Token: 0x1700950F RID: 38159
		// (get) Token: 0x06020B6D RID: 133997 RVA: 0x004885A2 File Offset: 0x004867A2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020B6E RID: 133998 RVA: 0x004885AF File Offset: 0x004867AF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020B6F RID: 133999 RVA: 0x004885B8 File Offset: 0x004867B8
		public static IListenEntitySelfEventCondition GetRootAsIListenEntitySelfEventCondition(ByteBuffer _bb)
		{
			return IListenEntitySelfEventCondition.GetRootAsIListenEntitySelfEventCondition(_bb, default(IListenEntitySelfEventCondition));
		}

		// Token: 0x06020B70 RID: 134000 RVA: 0x004885D4 File Offset: 0x004867D4
		public static IListenEntitySelfEventCondition GetRootAsIListenEntitySelfEventCondition(ByteBuffer _bb, IListenEntitySelfEventCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020B71 RID: 134001 RVA: 0x004885F1 File Offset: 0x004867F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020B72 RID: 134002 RVA: 0x00488600 File Offset: 0x00486800
		public IListenEntitySelfEventCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009510 RID: 38160
		// (get) Token: 0x06020B73 RID: 134003 RVA: 0x00488610 File Offset: 0x00486810
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

		// Token: 0x17009511 RID: 38161
		// (get) Token: 0x06020B74 RID: 134004 RVA: 0x0048864C File Offset: 0x0048684C
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

		// Token: 0x06020B75 RID: 134005 RVA: 0x00488683 File Offset: 0x00486883
		public Span<byte> GetEventKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06020B76 RID: 134006 RVA: 0x00488692 File Offset: 0x00486892
		public byte[] GetEventKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17009512 RID: 38162
		// (get) Token: 0x06020B77 RID: 134007 RVA: 0x004886A0 File Offset: 0x004868A0
		public bool ResetAfterConditionMet
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009513 RID: 38163
		// (get) Token: 0x06020B78 RID: 134008 RVA: 0x004886E0 File Offset: 0x004868E0
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

		// Token: 0x06020B79 RID: 134009 RVA: 0x0048871D File Offset: 0x0048691D
		public static Offset<IListenEntitySelfEventCondition> CreateIListenEntitySelfEventCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, StringOffset EventKeyOffset = default(StringOffset), bool ResetAfterConditionMet = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IListenEntitySelfEventCondition.AddEventKey(builder, EventKeyOffset);
			IListenEntitySelfEventCondition.AddNullMask(builder, NullMask);
			IListenEntitySelfEventCondition.AddResetAfterConditionMet(builder, ResetAfterConditionMet);
			IListenEntitySelfEventCondition.AddType(builder, Type);
			return IListenEntitySelfEventCondition.EndIListenEntitySelfEventCondition(builder);
		}

		// Token: 0x06020B7A RID: 134010 RVA: 0x00488749 File Offset: 0x00486949
		public static void StartIListenEntitySelfEventCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06020B7B RID: 134011 RVA: 0x00488752 File Offset: 0x00486952
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020B7C RID: 134012 RVA: 0x0048875D File Offset: 0x0048695D
		public static void AddEventKey(FlatBufferBuilder builder, StringOffset eventKeyOffset)
		{
			builder.AddOffset(1, eventKeyOffset.Value, 0);
		}

		// Token: 0x06020B7D RID: 134013 RVA: 0x0048876D File Offset: 0x0048696D
		public static void AddResetAfterConditionMet(FlatBufferBuilder builder, bool resetAfterConditionMet)
		{
			builder.AddBool(2, resetAfterConditionMet, false);
		}

		// Token: 0x06020B7E RID: 134014 RVA: 0x00488778 File Offset: 0x00486978
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06020B7F RID: 134015 RVA: 0x00488783 File Offset: 0x00486983
		public static Offset<IListenEntitySelfEventCondition> EndIListenEntitySelfEventCondition(FlatBufferBuilder builder)
		{
			return new Offset<IListenEntitySelfEventCondition>(builder.EndTable());
		}

		// Token: 0x06020B80 RID: 134016 RVA: 0x00488790 File Offset: 0x00486990
		public IListenEntitySelfEventConditionT UnPack()
		{
			IListenEntitySelfEventConditionT listenEntitySelfEventConditionT = new IListenEntitySelfEventConditionT();
			this.UnPackTo(listenEntitySelfEventConditionT);
			return listenEntitySelfEventConditionT;
		}

		// Token: 0x06020B81 RID: 134017 RVA: 0x004887AB File Offset: 0x004869AB
		public void UnPackTo(IListenEntitySelfEventConditionT _o)
		{
			_o.Type = this.Type;
			_o.EventKey = this.EventKey;
			_o.ResetAfterConditionMet = this.ResetAfterConditionMet;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06020B82 RID: 134018 RVA: 0x004887E0 File Offset: 0x004869E0
		public static Offset<IListenEntitySelfEventCondition> Pack(FlatBufferBuilder builder, IListenEntitySelfEventConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IListenEntitySelfEventCondition>);
			}
			StringOffset eventKeyOffset = (_o.EventKey == null) ? default(StringOffset) : builder.CreateString(_o.EventKey);
			return IListenEntitySelfEventCondition.CreateIListenEntitySelfEventCondition(builder, _o.Type, eventKeyOffset, _o.ResetAfterConditionMet, _o.NullMask);
		}

		// Token: 0x0400E112 RID: 57618
		private Table __p;
	}
}
