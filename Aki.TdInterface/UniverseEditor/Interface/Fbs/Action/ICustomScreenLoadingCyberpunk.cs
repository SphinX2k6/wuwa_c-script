using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006501 RID: 25857
	public struct ICustomScreenLoadingCyberpunk : IFlatbufferObject
	{
		// Token: 0x1700C04F RID: 49231
		// (get) Token: 0x0602CDB1 RID: 183729 RVA: 0x00629790 File Offset: 0x00627990
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CDB2 RID: 183730 RVA: 0x0062979D File Offset: 0x0062799D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CDB3 RID: 183731 RVA: 0x006297A4 File Offset: 0x006279A4
		public static ICustomScreenLoadingCyberpunk GetRootAsICustomScreenLoadingCyberpunk(ByteBuffer _bb)
		{
			return ICustomScreenLoadingCyberpunk.GetRootAsICustomScreenLoadingCyberpunk(_bb, default(ICustomScreenLoadingCyberpunk));
		}

		// Token: 0x0602CDB4 RID: 183732 RVA: 0x006297C0 File Offset: 0x006279C0
		public static ICustomScreenLoadingCyberpunk GetRootAsICustomScreenLoadingCyberpunk(ByteBuffer _bb, ICustomScreenLoadingCyberpunk obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CDB5 RID: 183733 RVA: 0x006297DD File Offset: 0x006279DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CDB6 RID: 183734 RVA: 0x006297EC File Offset: 0x006279EC
		public ICustomScreenLoadingCyberpunk __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C050 RID: 49232
		// (get) Token: 0x0602CDB7 RID: 183735 RVA: 0x006297FC File Offset: 0x006279FC
		public ECustomScreenLoading Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECustomScreenLoading.Cyberpunk;
				}
				return (ECustomScreenLoading)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CDB8 RID: 183736 RVA: 0x00629838 File Offset: 0x00627A38
		public static Offset<ICustomScreenLoadingCyberpunk> CreateICustomScreenLoadingCyberpunk(FlatBufferBuilder builder, ECustomScreenLoading Type = ECustomScreenLoading.Cyberpunk)
		{
			builder.StartTable(1);
			ICustomScreenLoadingCyberpunk.AddType(builder, Type);
			return ICustomScreenLoadingCyberpunk.EndICustomScreenLoadingCyberpunk(builder);
		}

		// Token: 0x0602CDB9 RID: 183737 RVA: 0x0062984E File Offset: 0x00627A4E
		public static void StartICustomScreenLoadingCyberpunk(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602CDBA RID: 183738 RVA: 0x00629857 File Offset: 0x00627A57
		public static void AddType(FlatBufferBuilder builder, ECustomScreenLoading type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CDBB RID: 183739 RVA: 0x00629862 File Offset: 0x00627A62
		public static Offset<ICustomScreenLoadingCyberpunk> EndICustomScreenLoadingCyberpunk(FlatBufferBuilder builder)
		{
			return new Offset<ICustomScreenLoadingCyberpunk>(builder.EndTable());
		}

		// Token: 0x0602CDBC RID: 183740 RVA: 0x00629870 File Offset: 0x00627A70
		public ICustomScreenLoadingCyberpunkT UnPack()
		{
			ICustomScreenLoadingCyberpunkT customScreenLoadingCyberpunkT = new ICustomScreenLoadingCyberpunkT();
			this.UnPackTo(customScreenLoadingCyberpunkT);
			return customScreenLoadingCyberpunkT;
		}

		// Token: 0x0602CDBD RID: 183741 RVA: 0x0062988B File Offset: 0x00627A8B
		public void UnPackTo(ICustomScreenLoadingCyberpunkT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602CDBE RID: 183742 RVA: 0x0062989C File Offset: 0x00627A9C
		public static Offset<ICustomScreenLoadingCyberpunk> Pack(FlatBufferBuilder builder, ICustomScreenLoadingCyberpunkT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomScreenLoadingCyberpunk>);
			}
			return ICustomScreenLoadingCyberpunk.CreateICustomScreenLoadingCyberpunk(builder, _o.Type);
		}

		// Token: 0x04010B44 RID: 68420
		private Table __p;
	}
}
