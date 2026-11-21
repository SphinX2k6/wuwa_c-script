using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007400 RID: 29696
	public struct IPetalFlyConfig : IFlatbufferObject
	{
		// Token: 0x1700DA24 RID: 55844
		// (get) Token: 0x06033F44 RID: 212804 RVA: 0x007010FF File Offset: 0x006FF2FF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033F45 RID: 212805 RVA: 0x0070110C File Offset: 0x006FF30C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033F46 RID: 212806 RVA: 0x00701114 File Offset: 0x006FF314
		public static IPetalFlyConfig GetRootAsIPetalFlyConfig(ByteBuffer _bb)
		{
			return IPetalFlyConfig.GetRootAsIPetalFlyConfig(_bb, default(IPetalFlyConfig));
		}

		// Token: 0x06033F47 RID: 212807 RVA: 0x00701130 File Offset: 0x006FF330
		public static IPetalFlyConfig GetRootAsIPetalFlyConfig(ByteBuffer _bb, IPetalFlyConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033F48 RID: 212808 RVA: 0x0070114D File Offset: 0x006FF34D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033F49 RID: 212809 RVA: 0x0070115C File Offset: 0x006FF35C
		public IPetalFlyConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DA25 RID: 55845
		// (get) Token: 0x06033F4A RID: 212810 RVA: 0x0070116C File Offset: 0x006FF36C
		public ESportStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESportStateType.Slide;
				}
				return (ESportStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033F4B RID: 212811 RVA: 0x007011A8 File Offset: 0x006FF3A8
		public static Offset<IPetalFlyConfig> CreateIPetalFlyConfig(FlatBufferBuilder builder, ESportStateType Type = ESportStateType.Slide)
		{
			builder.StartTable(1);
			IPetalFlyConfig.AddType(builder, Type);
			return IPetalFlyConfig.EndIPetalFlyConfig(builder);
		}

		// Token: 0x06033F4C RID: 212812 RVA: 0x007011BE File Offset: 0x006FF3BE
		public static void StartIPetalFlyConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033F4D RID: 212813 RVA: 0x007011C7 File Offset: 0x006FF3C7
		public static void AddType(FlatBufferBuilder builder, ESportStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033F4E RID: 212814 RVA: 0x007011D2 File Offset: 0x006FF3D2
		public static Offset<IPetalFlyConfig> EndIPetalFlyConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPetalFlyConfig>(builder.EndTable());
		}

		// Token: 0x06033F4F RID: 212815 RVA: 0x007011E0 File Offset: 0x006FF3E0
		public IPetalFlyConfigT UnPack()
		{
			IPetalFlyConfigT petalFlyConfigT = new IPetalFlyConfigT();
			this.UnPackTo(petalFlyConfigT);
			return petalFlyConfigT;
		}

		// Token: 0x06033F50 RID: 212816 RVA: 0x007011FB File Offset: 0x006FF3FB
		public void UnPackTo(IPetalFlyConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033F51 RID: 212817 RVA: 0x0070120C File Offset: 0x006FF40C
		public static Offset<IPetalFlyConfig> Pack(FlatBufferBuilder builder, IPetalFlyConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPetalFlyConfig>);
			}
			return IPetalFlyConfig.CreateIPetalFlyConfig(builder, _o.Type);
		}

		// Token: 0x04012548 RID: 75080
		private Table __p;
	}
}
