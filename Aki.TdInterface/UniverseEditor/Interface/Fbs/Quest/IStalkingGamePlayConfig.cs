using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004142 RID: 16706
	public struct IStalkingGamePlayConfig : IFlatbufferObject
	{
		// Token: 0x1700764B RID: 30283
		// (get) Token: 0x06018800 RID: 100352 RVA: 0x0038800A File Offset: 0x0038620A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018801 RID: 100353 RVA: 0x00388017 File Offset: 0x00386217
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018802 RID: 100354 RVA: 0x00388020 File Offset: 0x00386220
		public static IStalkingGamePlayConfig GetRootAsIStalkingGamePlayConfig(ByteBuffer _bb)
		{
			return IStalkingGamePlayConfig.GetRootAsIStalkingGamePlayConfig(_bb, default(IStalkingGamePlayConfig));
		}

		// Token: 0x06018803 RID: 100355 RVA: 0x0038803C File Offset: 0x0038623C
		public static IStalkingGamePlayConfig GetRootAsIStalkingGamePlayConfig(ByteBuffer _bb, IStalkingGamePlayConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018804 RID: 100356 RVA: 0x00388059 File Offset: 0x00386259
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018805 RID: 100357 RVA: 0x00388068 File Offset: 0x00386268
		public IStalkingGamePlayConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700764C RID: 30284
		// (get) Token: 0x06018806 RID: 100358 RVA: 0x00388078 File Offset: 0x00386278
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

		// Token: 0x06018807 RID: 100359 RVA: 0x003880B4 File Offset: 0x003862B4
		public static Offset<IStalkingGamePlayConfig> CreateIStalkingGamePlayConfig(FlatBufferBuilder builder, ESpecialGamePlayConfigType Type = ESpecialGamePlayConfigType.Stalking)
		{
			builder.StartTable(1);
			IStalkingGamePlayConfig.AddType(builder, Type);
			return IStalkingGamePlayConfig.EndIStalkingGamePlayConfig(builder);
		}

		// Token: 0x06018808 RID: 100360 RVA: 0x003880CA File Offset: 0x003862CA
		public static void StartIStalkingGamePlayConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06018809 RID: 100361 RVA: 0x003880D3 File Offset: 0x003862D3
		public static void AddType(FlatBufferBuilder builder, ESpecialGamePlayConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601880A RID: 100362 RVA: 0x003880DE File Offset: 0x003862DE
		public static Offset<IStalkingGamePlayConfig> EndIStalkingGamePlayConfig(FlatBufferBuilder builder)
		{
			return new Offset<IStalkingGamePlayConfig>(builder.EndTable());
		}

		// Token: 0x0601880B RID: 100363 RVA: 0x003880EC File Offset: 0x003862EC
		public IStalkingGamePlayConfigT UnPack()
		{
			IStalkingGamePlayConfigT stalkingGamePlayConfigT = new IStalkingGamePlayConfigT();
			this.UnPackTo(stalkingGamePlayConfigT);
			return stalkingGamePlayConfigT;
		}

		// Token: 0x0601880C RID: 100364 RVA: 0x00388107 File Offset: 0x00386307
		public void UnPackTo(IStalkingGamePlayConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601880D RID: 100365 RVA: 0x00388118 File Offset: 0x00386318
		public static Offset<IStalkingGamePlayConfig> Pack(FlatBufferBuilder builder, IStalkingGamePlayConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStalkingGamePlayConfig>);
			}
			return IStalkingGamePlayConfig.CreateIStalkingGamePlayConfig(builder, _o.Type);
		}

		// Token: 0x0400BD4C RID: 48460
		private Table __p;
	}
}
