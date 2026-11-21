using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B6F RID: 27503
	public struct ICustomScreenLoadingCyberpunk : IFlatbufferObject
	{
		// Token: 0x1700C9DF RID: 51679
		// (get) Token: 0x0602F547 RID: 193863 RVA: 0x00675A30 File Offset: 0x00673C30
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F548 RID: 193864 RVA: 0x00675A3D File Offset: 0x00673C3D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F549 RID: 193865 RVA: 0x00675A44 File Offset: 0x00673C44
		public static ICustomScreenLoadingCyberpunk GetRootAsICustomScreenLoadingCyberpunk(ByteBuffer _bb)
		{
			return ICustomScreenLoadingCyberpunk.GetRootAsICustomScreenLoadingCyberpunk(_bb, default(ICustomScreenLoadingCyberpunk));
		}

		// Token: 0x0602F54A RID: 193866 RVA: 0x00675A60 File Offset: 0x00673C60
		public static ICustomScreenLoadingCyberpunk GetRootAsICustomScreenLoadingCyberpunk(ByteBuffer _bb, ICustomScreenLoadingCyberpunk obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F54B RID: 193867 RVA: 0x00675A7D File Offset: 0x00673C7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F54C RID: 193868 RVA: 0x00675A8C File Offset: 0x00673C8C
		public ICustomScreenLoadingCyberpunk __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C9E0 RID: 51680
		// (get) Token: 0x0602F54D RID: 193869 RVA: 0x00675A9C File Offset: 0x00673C9C
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

		// Token: 0x0602F54E RID: 193870 RVA: 0x00675AD8 File Offset: 0x00673CD8
		public static Offset<ICustomScreenLoadingCyberpunk> CreateICustomScreenLoadingCyberpunk(FlatBufferBuilder builder, ECustomScreenLoading Type = ECustomScreenLoading.Cyberpunk)
		{
			builder.StartTable(1);
			ICustomScreenLoadingCyberpunk.AddType(builder, Type);
			return ICustomScreenLoadingCyberpunk.EndICustomScreenLoadingCyberpunk(builder);
		}

		// Token: 0x0602F54F RID: 193871 RVA: 0x00675AEE File Offset: 0x00673CEE
		public static void StartICustomScreenLoadingCyberpunk(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F550 RID: 193872 RVA: 0x00675AF7 File Offset: 0x00673CF7
		public static void AddType(FlatBufferBuilder builder, ECustomScreenLoading type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F551 RID: 193873 RVA: 0x00675B02 File Offset: 0x00673D02
		public static Offset<ICustomScreenLoadingCyberpunk> EndICustomScreenLoadingCyberpunk(FlatBufferBuilder builder)
		{
			return new Offset<ICustomScreenLoadingCyberpunk>(builder.EndTable());
		}

		// Token: 0x0602F552 RID: 193874 RVA: 0x00675B10 File Offset: 0x00673D10
		public ICustomScreenLoadingCyberpunkT UnPack()
		{
			ICustomScreenLoadingCyberpunkT customScreenLoadingCyberpunkT = new ICustomScreenLoadingCyberpunkT();
			this.UnPackTo(customScreenLoadingCyberpunkT);
			return customScreenLoadingCyberpunkT;
		}

		// Token: 0x0602F553 RID: 193875 RVA: 0x00675B2B File Offset: 0x00673D2B
		public void UnPackTo(ICustomScreenLoadingCyberpunkT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F554 RID: 193876 RVA: 0x00675B3C File Offset: 0x00673D3C
		public static Offset<ICustomScreenLoadingCyberpunk> Pack(FlatBufferBuilder builder, ICustomScreenLoadingCyberpunkT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomScreenLoadingCyberpunk>);
			}
			return ICustomScreenLoadingCyberpunk.CreateICustomScreenLoadingCyberpunk(builder, _o.Type);
		}

		// Token: 0x0401195C RID: 72028
		private Table __p;
	}
}
