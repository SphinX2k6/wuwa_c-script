using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004586 RID: 17798
	public struct IStalkingGamePlayConfig : IFlatbufferObject
	{
		// Token: 0x17007C5A RID: 31834
		// (get) Token: 0x06019EC8 RID: 106184 RVA: 0x003B25C8 File Offset: 0x003B07C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019EC9 RID: 106185 RVA: 0x003B25D5 File Offset: 0x003B07D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019ECA RID: 106186 RVA: 0x003B25DC File Offset: 0x003B07DC
		public static IStalkingGamePlayConfig GetRootAsIStalkingGamePlayConfig(ByteBuffer _bb)
		{
			return IStalkingGamePlayConfig.GetRootAsIStalkingGamePlayConfig(_bb, default(IStalkingGamePlayConfig));
		}

		// Token: 0x06019ECB RID: 106187 RVA: 0x003B25F8 File Offset: 0x003B07F8
		public static IStalkingGamePlayConfig GetRootAsIStalkingGamePlayConfig(ByteBuffer _bb, IStalkingGamePlayConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019ECC RID: 106188 RVA: 0x003B2615 File Offset: 0x003B0815
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019ECD RID: 106189 RVA: 0x003B2624 File Offset: 0x003B0824
		public IStalkingGamePlayConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C5B RID: 31835
		// (get) Token: 0x06019ECE RID: 106190 RVA: 0x003B2634 File Offset: 0x003B0834
		public ESpecialGamePlayConfigType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpecialGamePlayConfigType.Stalking;
				}
				return (ESpecialGamePlayConfigType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019ECF RID: 106191 RVA: 0x003B2670 File Offset: 0x003B0870
		public static Offset<IStalkingGamePlayConfig> CreateIStalkingGamePlayConfig(FlatBufferBuilder builder, ESpecialGamePlayConfigType Type = ESpecialGamePlayConfigType.Stalking)
		{
			builder.StartTable(1);
			IStalkingGamePlayConfig.AddType(builder, Type);
			return IStalkingGamePlayConfig.EndIStalkingGamePlayConfig(builder);
		}

		// Token: 0x06019ED0 RID: 106192 RVA: 0x003B2686 File Offset: 0x003B0886
		public static void StartIStalkingGamePlayConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019ED1 RID: 106193 RVA: 0x003B268F File Offset: 0x003B088F
		public static void AddType(FlatBufferBuilder builder, ESpecialGamePlayConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019ED2 RID: 106194 RVA: 0x003B269A File Offset: 0x003B089A
		public static Offset<IStalkingGamePlayConfig> EndIStalkingGamePlayConfig(FlatBufferBuilder builder)
		{
			return new Offset<IStalkingGamePlayConfig>(builder.EndTable());
		}

		// Token: 0x06019ED3 RID: 106195 RVA: 0x003B26A8 File Offset: 0x003B08A8
		public IStalkingGamePlayConfigT UnPack()
		{
			IStalkingGamePlayConfigT stalkingGamePlayConfigT = new IStalkingGamePlayConfigT();
			this.UnPackTo(stalkingGamePlayConfigT);
			return stalkingGamePlayConfigT;
		}

		// Token: 0x06019ED4 RID: 106196 RVA: 0x003B26C3 File Offset: 0x003B08C3
		public void UnPackTo(IStalkingGamePlayConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06019ED5 RID: 106197 RVA: 0x003B26D4 File Offset: 0x003B08D4
		public static Offset<IStalkingGamePlayConfig> Pack(FlatBufferBuilder builder, IStalkingGamePlayConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStalkingGamePlayConfig>);
			}
			return IStalkingGamePlayConfig.CreateIStalkingGamePlayConfig(builder, _o.Type);
		}

		// Token: 0x0400C73A RID: 51002
		private Table __p;
	}
}
