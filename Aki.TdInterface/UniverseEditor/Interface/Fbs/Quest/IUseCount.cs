using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200423E RID: 16958
	public struct IUseCount : IFlatbufferObject
	{
		// Token: 0x17007867 RID: 30823
		// (get) Token: 0x0601913B RID: 102715 RVA: 0x0039B570 File Offset: 0x00399770
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601913C RID: 102716 RVA: 0x0039B57D File Offset: 0x0039977D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601913D RID: 102717 RVA: 0x0039B584 File Offset: 0x00399784
		public static IUseCount GetRootAsIUseCount(ByteBuffer _bb)
		{
			return IUseCount.GetRootAsIUseCount(_bb, default(IUseCount));
		}

		// Token: 0x0601913E RID: 102718 RVA: 0x0039B5A0 File Offset: 0x003997A0
		public static IUseCount GetRootAsIUseCount(ByteBuffer _bb, IUseCount obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601913F RID: 102719 RVA: 0x0039B5BD File Offset: 0x003997BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019140 RID: 102720 RVA: 0x0039B5CC File Offset: 0x003997CC
		public IUseCount __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007868 RID: 30824
		// (get) Token: 0x06019141 RID: 102721 RVA: 0x0039B5DC File Offset: 0x003997DC
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

		// Token: 0x06019142 RID: 102722 RVA: 0x0039B618 File Offset: 0x00399818
		public static Offset<IUseCount> CreateIUseCount(FlatBufferBuilder builder, EProgressBarLeftType Type = EProgressBarLeftType.UseCount)
		{
			builder.StartTable(1);
			IUseCount.AddType(builder, Type);
			return IUseCount.EndIUseCount(builder);
		}

		// Token: 0x06019143 RID: 102723 RVA: 0x0039B62E File Offset: 0x0039982E
		public static void StartIUseCount(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019144 RID: 102724 RVA: 0x0039B637 File Offset: 0x00399837
		public static void AddType(FlatBufferBuilder builder, EProgressBarLeftType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019145 RID: 102725 RVA: 0x0039B642 File Offset: 0x00399842
		public static Offset<IUseCount> EndIUseCount(FlatBufferBuilder builder)
		{
			return new Offset<IUseCount>(builder.EndTable());
		}

		// Token: 0x06019146 RID: 102726 RVA: 0x0039B650 File Offset: 0x00399850
		public IUseCountT UnPack()
		{
			IUseCountT useCountT = new IUseCountT();
			this.UnPackTo(useCountT);
			return useCountT;
		}

		// Token: 0x06019147 RID: 102727 RVA: 0x0039B66B File Offset: 0x0039986B
		public void UnPackTo(IUseCountT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06019148 RID: 102728 RVA: 0x0039B67C File Offset: 0x0039987C
		public static Offset<IUseCount> Pack(FlatBufferBuilder builder, IUseCountT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUseCount>);
			}
			return IUseCount.CreateIUseCount(builder, _o.Type);
		}

		// Token: 0x0400BEC1 RID: 48833
		private Table __p;
	}
}
