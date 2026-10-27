using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D37 RID: 15671
	public struct IBossRushBuffInfoView : IFlatbufferObject
	{
		// Token: 0x17006B7B RID: 27515
		// (get) Token: 0x06015A47 RID: 88647 RVA: 0x0031FAAA File Offset: 0x0031DCAA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015A48 RID: 88648 RVA: 0x0031FAB7 File Offset: 0x0031DCB7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015A49 RID: 88649 RVA: 0x0031FAC0 File Offset: 0x0031DCC0
		public static IBossRushBuffInfoView GetRootAsIBossRushBuffInfoView(ByteBuffer _bb)
		{
			return IBossRushBuffInfoView.GetRootAsIBossRushBuffInfoView(_bb, default(IBossRushBuffInfoView));
		}

		// Token: 0x06015A4A RID: 88650 RVA: 0x0031FADC File Offset: 0x0031DCDC
		public static IBossRushBuffInfoView GetRootAsIBossRushBuffInfoView(ByteBuffer _bb, IBossRushBuffInfoView obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015A4B RID: 88651 RVA: 0x0031FAF9 File Offset: 0x0031DCF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015A4C RID: 88652 RVA: 0x0031FB08 File Offset: 0x0031DD08
		public IBossRushBuffInfoView __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B7C RID: 27516
		// (get) Token: 0x06015A4D RID: 88653 RVA: 0x0031FB18 File Offset: 0x0031DD18
		public EInformationViewType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInformationViewType.LevelPlay;
				}
				return (EInformationViewType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015A4E RID: 88654 RVA: 0x0031FB54 File Offset: 0x0031DD54
		public static Offset<IBossRushBuffInfoView> CreateIBossRushBuffInfoView(FlatBufferBuilder builder, EInformationViewType Type = EInformationViewType.LevelPlay)
		{
			builder.StartTable(1);
			IBossRushBuffInfoView.AddType(builder, Type);
			return IBossRushBuffInfoView.EndIBossRushBuffInfoView(builder);
		}

		// Token: 0x06015A4F RID: 88655 RVA: 0x0031FB6A File Offset: 0x0031DD6A
		public static void StartIBossRushBuffInfoView(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06015A50 RID: 88656 RVA: 0x0031FB73 File Offset: 0x0031DD73
		public static void AddType(FlatBufferBuilder builder, EInformationViewType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015A51 RID: 88657 RVA: 0x0031FB7E File Offset: 0x0031DD7E
		public static Offset<IBossRushBuffInfoView> EndIBossRushBuffInfoView(FlatBufferBuilder builder)
		{
			return new Offset<IBossRushBuffInfoView>(builder.EndTable());
		}

		// Token: 0x06015A52 RID: 88658 RVA: 0x0031FB8C File Offset: 0x0031DD8C
		public IBossRushBuffInfoViewT UnPack()
		{
			IBossRushBuffInfoViewT bossRushBuffInfoViewT = new IBossRushBuffInfoViewT();
			this.UnPackTo(bossRushBuffInfoViewT);
			return bossRushBuffInfoViewT;
		}

		// Token: 0x06015A53 RID: 88659 RVA: 0x0031FBA7 File Offset: 0x0031DDA7
		public void UnPackTo(IBossRushBuffInfoViewT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06015A54 RID: 88660 RVA: 0x0031FBB8 File Offset: 0x0031DDB8
		public static Offset<IBossRushBuffInfoView> Pack(FlatBufferBuilder builder, IBossRushBuffInfoViewT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBossRushBuffInfoView>);
			}
			return IBossRushBuffInfoView.CreateIBossRushBuffInfoView(builder, _o.Type);
		}

		// Token: 0x0400B5F7 RID: 46583
		private Table __p;
	}
}
