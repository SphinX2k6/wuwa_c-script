using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200469A RID: 18074
	public struct IUseCount : IFlatbufferObject
	{
		// Token: 0x17007E98 RID: 32408
		// (get) Token: 0x0601A8A7 RID: 108711 RVA: 0x003C6C48 File Offset: 0x003C4E48
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A8A8 RID: 108712 RVA: 0x003C6C55 File Offset: 0x003C4E55
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A8A9 RID: 108713 RVA: 0x003C6C5C File Offset: 0x003C4E5C
		public static IUseCount GetRootAsIUseCount(ByteBuffer _bb)
		{
			return IUseCount.GetRootAsIUseCount(_bb, default(IUseCount));
		}

		// Token: 0x0601A8AA RID: 108714 RVA: 0x003C6C78 File Offset: 0x003C4E78
		public static IUseCount GetRootAsIUseCount(ByteBuffer _bb, IUseCount obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A8AB RID: 108715 RVA: 0x003C6C95 File Offset: 0x003C4E95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A8AC RID: 108716 RVA: 0x003C6CA4 File Offset: 0x003C4EA4
		public IUseCount __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E99 RID: 32409
		// (get) Token: 0x0601A8AD RID: 108717 RVA: 0x003C6CB4 File Offset: 0x003C4EB4
		public EProgressBarLeftType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EProgressBarLeftType.UseCount;
				}
				return (EProgressBarLeftType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A8AE RID: 108718 RVA: 0x003C6CF0 File Offset: 0x003C4EF0
		public static Offset<IUseCount> CreateIUseCount(FlatBufferBuilder builder, EProgressBarLeftType Type = EProgressBarLeftType.UseCount)
		{
			builder.StartTable(1);
			IUseCount.AddType(builder, Type);
			return IUseCount.EndIUseCount(builder);
		}

		// Token: 0x0601A8AF RID: 108719 RVA: 0x003C6D06 File Offset: 0x003C4F06
		public static void StartIUseCount(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A8B0 RID: 108720 RVA: 0x003C6D0F File Offset: 0x003C4F0F
		public static void AddType(FlatBufferBuilder builder, EProgressBarLeftType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A8B1 RID: 108721 RVA: 0x003C6D1A File Offset: 0x003C4F1A
		public static Offset<IUseCount> EndIUseCount(FlatBufferBuilder builder)
		{
			return new Offset<IUseCount>(builder.EndTable());
		}

		// Token: 0x0601A8B2 RID: 108722 RVA: 0x003C6D28 File Offset: 0x003C4F28
		public IUseCountT UnPack()
		{
			IUseCountT useCountT = new IUseCountT();
			this.UnPackTo(useCountT);
			return useCountT;
		}

		// Token: 0x0601A8B3 RID: 108723 RVA: 0x003C6D43 File Offset: 0x003C4F43
		public void UnPackTo(IUseCountT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601A8B4 RID: 108724 RVA: 0x003C6D54 File Offset: 0x003C4F54
		public static Offset<IUseCount> Pack(FlatBufferBuilder builder, IUseCountT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUseCount>);
			}
			return IUseCount.CreateIUseCount(builder, _o.Type);
		}

		// Token: 0x0400C8CE RID: 51406
		private Table __p;
	}
}
