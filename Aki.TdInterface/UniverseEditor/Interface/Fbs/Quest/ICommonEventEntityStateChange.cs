using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041AB RID: 16811
	public struct ICommonEventEntityStateChange : IFlatbufferObject
	{
		// Token: 0x17007224 RID: 29220
		// (get) Token: 0x0601737E RID: 95102 RVA: 0x0035078C File Offset: 0x0034E98C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601737F RID: 95103 RVA: 0x00350799 File Offset: 0x0034E999
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017380 RID: 95104 RVA: 0x003507A0 File Offset: 0x0034E9A0
		public static ICommonEventEntityStateChange GetRootAsICommonEventEntityStateChange(ByteBuffer _bb)
		{
			return ICommonEventEntityStateChange.GetRootAsICommonEventEntityStateChange(_bb, default(ICommonEventEntityStateChange));
		}

		// Token: 0x06017381 RID: 95105 RVA: 0x003507BC File Offset: 0x0034E9BC
		public static ICommonEventEntityStateChange GetRootAsICommonEventEntityStateChange(ByteBuffer _bb, ICommonEventEntityStateChange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017382 RID: 95106 RVA: 0x003507D9 File Offset: 0x0034E9D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017383 RID: 95107 RVA: 0x003507E8 File Offset: 0x0034E9E8
		public ICommonEventEntityStateChange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007225 RID: 29221
		// (get) Token: 0x06017384 RID: 95108 RVA: 0x003507F8 File Offset: 0x0034E9F8
		public ECommonEventType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonEventType.VarValueChange;
				}
				return (ECommonEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007226 RID: 29222
		// (get) Token: 0x06017385 RID: 95109 RVA: 0x00350834 File Offset: 0x0034EA34
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017386 RID: 95110 RVA: 0x00350870 File Offset: 0x0034EA70
		public static Offset<ICommonEventEntityStateChange> CreateICommonEventEntityStateChange(FlatBufferBuilder builder, ECommonEventType Type = ECommonEventType.VarValueChange, int EntityId = 0)
		{
			builder.StartTable(2);
			ICommonEventEntityStateChange.AddEntityId(builder, EntityId);
			ICommonEventEntityStateChange.AddType(builder, Type);
			return ICommonEventEntityStateChange.EndICommonEventEntityStateChange(builder);
		}

		// Token: 0x06017387 RID: 95111 RVA: 0x0035088D File Offset: 0x0034EA8D
		public static void StartICommonEventEntityStateChange(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06017388 RID: 95112 RVA: 0x00350896 File Offset: 0x0034EA96
		public static void AddType(FlatBufferBuilder builder, ECommonEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017389 RID: 95113 RVA: 0x003508A1 File Offset: 0x0034EAA1
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0601738A RID: 95114 RVA: 0x003508AC File Offset: 0x0034EAAC
		public static Offset<ICommonEventEntityStateChange> EndICommonEventEntityStateChange(FlatBufferBuilder builder)
		{
			return new Offset<ICommonEventEntityStateChange>(builder.EndTable());
		}

		// Token: 0x0601738B RID: 95115 RVA: 0x003508BC File Offset: 0x0034EABC
		public ICommonEventEntityStateChangeT UnPack()
		{
			ICommonEventEntityStateChangeT commonEventEntityStateChangeT = new ICommonEventEntityStateChangeT();
			this.UnPackTo(commonEventEntityStateChangeT);
			return commonEventEntityStateChangeT;
		}

		// Token: 0x0601738C RID: 95116 RVA: 0x003508D7 File Offset: 0x0034EAD7
		public void UnPackTo(ICommonEventEntityStateChangeT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x0601738D RID: 95117 RVA: 0x003508F4 File Offset: 0x0034EAF4
		public static Offset<ICommonEventEntityStateChange> Pack(FlatBufferBuilder builder, ICommonEventEntityStateChangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonEventEntityStateChange>);
			}
			return ICommonEventEntityStateChange.CreateICommonEventEntityStateChange(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x0400C04C RID: 49228
		private Table __p;
	}
}
