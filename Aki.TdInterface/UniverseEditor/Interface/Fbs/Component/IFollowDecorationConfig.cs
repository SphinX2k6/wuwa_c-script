using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005291 RID: 21137
	public struct IFollowDecorationConfig : IFlatbufferObject
	{
		// Token: 0x17009AFD RID: 39677
		// (get) Token: 0x06022720 RID: 141088 RVA: 0x004C6913 File Offset: 0x004C4B13
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022721 RID: 141089 RVA: 0x004C6920 File Offset: 0x004C4B20
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022722 RID: 141090 RVA: 0x004C6928 File Offset: 0x004C4B28
		public static IFollowDecorationConfig GetRootAsIFollowDecorationConfig(ByteBuffer _bb)
		{
			return IFollowDecorationConfig.GetRootAsIFollowDecorationConfig(_bb, default(IFollowDecorationConfig));
		}

		// Token: 0x06022723 RID: 141091 RVA: 0x004C6944 File Offset: 0x004C4B44
		public static IFollowDecorationConfig GetRootAsIFollowDecorationConfig(ByteBuffer _bb, IFollowDecorationConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022724 RID: 141092 RVA: 0x004C6961 File Offset: 0x004C4B61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022725 RID: 141093 RVA: 0x004C6970 File Offset: 0x004C4B70
		public IFollowDecorationConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009AFE RID: 39678
		// (get) Token: 0x06022726 RID: 141094 RVA: 0x004C6980 File Offset: 0x004C4B80
		public EFollowDecorationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFollowDecorationType.Chair;
				}
				return (EFollowDecorationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022727 RID: 141095 RVA: 0x004C69BC File Offset: 0x004C4BBC
		public static Offset<IFollowDecorationConfig> CreateIFollowDecorationConfig(FlatBufferBuilder builder, EFollowDecorationType Type = EFollowDecorationType.Chair)
		{
			builder.StartTable(1);
			IFollowDecorationConfig.AddType(builder, Type);
			return IFollowDecorationConfig.EndIFollowDecorationConfig(builder);
		}

		// Token: 0x06022728 RID: 141096 RVA: 0x004C69D2 File Offset: 0x004C4BD2
		public static void StartIFollowDecorationConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06022729 RID: 141097 RVA: 0x004C69DB File Offset: 0x004C4BDB
		public static void AddType(FlatBufferBuilder builder, EFollowDecorationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602272A RID: 141098 RVA: 0x004C69E6 File Offset: 0x004C4BE6
		public static Offset<IFollowDecorationConfig> EndIFollowDecorationConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFollowDecorationConfig>(builder.EndTable());
		}

		// Token: 0x0602272B RID: 141099 RVA: 0x004C69F4 File Offset: 0x004C4BF4
		public IFollowDecorationConfigT UnPack()
		{
			IFollowDecorationConfigT followDecorationConfigT = new IFollowDecorationConfigT();
			this.UnPackTo(followDecorationConfigT);
			return followDecorationConfigT;
		}

		// Token: 0x0602272C RID: 141100 RVA: 0x004C6A0F File Offset: 0x004C4C0F
		public void UnPackTo(IFollowDecorationConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602272D RID: 141101 RVA: 0x004C6A20 File Offset: 0x004C4C20
		public static Offset<IFollowDecorationConfig> Pack(FlatBufferBuilder builder, IFollowDecorationConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFollowDecorationConfig>);
			}
			return IFollowDecorationConfig.CreateIFollowDecorationConfig(builder, _o.Type);
		}

		// Token: 0x0400E3FE RID: 58366
		private Table __p;
	}
}
