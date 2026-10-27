using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D94 RID: 15764
	public struct ICommonEventEntityStateChange : IFlatbufferObject
	{
		// Token: 0x17006C6A RID: 27754
		// (get) Token: 0x06015E46 RID: 89670 RVA: 0x00329460 File Offset: 0x00327660
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015E47 RID: 89671 RVA: 0x0032946D File Offset: 0x0032766D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015E48 RID: 89672 RVA: 0x00329474 File Offset: 0x00327674
		public static ICommonEventEntityStateChange GetRootAsICommonEventEntityStateChange(ByteBuffer _bb)
		{
			return ICommonEventEntityStateChange.GetRootAsICommonEventEntityStateChange(_bb, default(ICommonEventEntityStateChange));
		}

		// Token: 0x06015E49 RID: 89673 RVA: 0x00329490 File Offset: 0x00327690
		public static ICommonEventEntityStateChange GetRootAsICommonEventEntityStateChange(ByteBuffer _bb, ICommonEventEntityStateChange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015E4A RID: 89674 RVA: 0x003294AD File Offset: 0x003276AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015E4B RID: 89675 RVA: 0x003294BC File Offset: 0x003276BC
		public ICommonEventEntityStateChange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006C6B RID: 27755
		// (get) Token: 0x06015E4C RID: 89676 RVA: 0x003294CC File Offset: 0x003276CC
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

		// Token: 0x17006C6C RID: 27756
		// (get) Token: 0x06015E4D RID: 89677 RVA: 0x00329508 File Offset: 0x00327708
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

		// Token: 0x06015E4E RID: 89678 RVA: 0x00329544 File Offset: 0x00327744
		public static Offset<ICommonEventEntityStateChange> CreateICommonEventEntityStateChange(FlatBufferBuilder builder, ECommonEventType Type = ECommonEventType.VarValueChange, int EntityId = 0)
		{
			builder.StartTable(2);
			ICommonEventEntityStateChange.AddEntityId(builder, EntityId);
			ICommonEventEntityStateChange.AddType(builder, Type);
			return ICommonEventEntityStateChange.EndICommonEventEntityStateChange(builder);
		}

		// Token: 0x06015E4F RID: 89679 RVA: 0x00329561 File Offset: 0x00327761
		public static void StartICommonEventEntityStateChange(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06015E50 RID: 89680 RVA: 0x0032956A File Offset: 0x0032776A
		public static void AddType(FlatBufferBuilder builder, ECommonEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015E51 RID: 89681 RVA: 0x00329575 File Offset: 0x00327775
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x06015E52 RID: 89682 RVA: 0x00329580 File Offset: 0x00327780
		public static Offset<ICommonEventEntityStateChange> EndICommonEventEntityStateChange(FlatBufferBuilder builder)
		{
			return new Offset<ICommonEventEntityStateChange>(builder.EndTable());
		}

		// Token: 0x06015E53 RID: 89683 RVA: 0x00329590 File Offset: 0x00327790
		public ICommonEventEntityStateChangeT UnPack()
		{
			ICommonEventEntityStateChangeT commonEventEntityStateChangeT = new ICommonEventEntityStateChangeT();
			this.UnPackTo(commonEventEntityStateChangeT);
			return commonEventEntityStateChangeT;
		}

		// Token: 0x06015E54 RID: 89684 RVA: 0x003295AB File Offset: 0x003277AB
		public void UnPackTo(ICommonEventEntityStateChangeT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x06015E55 RID: 89685 RVA: 0x003295C8 File Offset: 0x003277C8
		public static Offset<ICommonEventEntityStateChange> Pack(FlatBufferBuilder builder, ICommonEventEntityStateChangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonEventEntityStateChange>);
			}
			return ICommonEventEntityStateChange.CreateICommonEventEntityStateChange(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x0400B69F RID: 46751
		private Table __p;
	}
}
