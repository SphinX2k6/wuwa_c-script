using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042AD RID: 17069
	public struct IFreezeOnSightGamePlayConfig : IFlatbufferObject
	{
		// Token: 0x170074C7 RID: 29895
		// (get) Token: 0x06017E8A RID: 97930 RVA: 0x0036A17C File Offset: 0x0036837C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017E8B RID: 97931 RVA: 0x0036A189 File Offset: 0x00368389
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017E8C RID: 97932 RVA: 0x0036A190 File Offset: 0x00368390
		public static IFreezeOnSightGamePlayConfig GetRootAsIFreezeOnSightGamePlayConfig(ByteBuffer _bb)
		{
			return IFreezeOnSightGamePlayConfig.GetRootAsIFreezeOnSightGamePlayConfig(_bb, default(IFreezeOnSightGamePlayConfig));
		}

		// Token: 0x06017E8D RID: 97933 RVA: 0x0036A1AC File Offset: 0x003683AC
		public static IFreezeOnSightGamePlayConfig GetRootAsIFreezeOnSightGamePlayConfig(ByteBuffer _bb, IFreezeOnSightGamePlayConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017E8E RID: 97934 RVA: 0x0036A1C9 File Offset: 0x003683C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017E8F RID: 97935 RVA: 0x0036A1D8 File Offset: 0x003683D8
		public IFreezeOnSightGamePlayConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170074C8 RID: 29896
		// (get) Token: 0x06017E90 RID: 97936 RVA: 0x0036A1E8 File Offset: 0x003683E8
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

		// Token: 0x06017E91 RID: 97937 RVA: 0x0036A224 File Offset: 0x00368424
		public static Offset<IFreezeOnSightGamePlayConfig> CreateIFreezeOnSightGamePlayConfig(FlatBufferBuilder builder, ESpecialGamePlayConfigType Type = ESpecialGamePlayConfigType.Stalking)
		{
			builder.StartTable(1);
			IFreezeOnSightGamePlayConfig.AddType(builder, Type);
			return IFreezeOnSightGamePlayConfig.EndIFreezeOnSightGamePlayConfig(builder);
		}

		// Token: 0x06017E92 RID: 97938 RVA: 0x0036A23A File Offset: 0x0036843A
		public static void StartIFreezeOnSightGamePlayConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06017E93 RID: 97939 RVA: 0x0036A243 File Offset: 0x00368443
		public static void AddType(FlatBufferBuilder builder, ESpecialGamePlayConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017E94 RID: 97940 RVA: 0x0036A24E File Offset: 0x0036844E
		public static Offset<IFreezeOnSightGamePlayConfig> EndIFreezeOnSightGamePlayConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFreezeOnSightGamePlayConfig>(builder.EndTable());
		}

		// Token: 0x06017E95 RID: 97941 RVA: 0x0036A25C File Offset: 0x0036845C
		public IFreezeOnSightGamePlayConfigT UnPack()
		{
			IFreezeOnSightGamePlayConfigT freezeOnSightGamePlayConfigT = new IFreezeOnSightGamePlayConfigT();
			this.UnPackTo(freezeOnSightGamePlayConfigT);
			return freezeOnSightGamePlayConfigT;
		}

		// Token: 0x06017E96 RID: 97942 RVA: 0x0036A277 File Offset: 0x00368477
		public void UnPackTo(IFreezeOnSightGamePlayConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06017E97 RID: 97943 RVA: 0x0036A288 File Offset: 0x00368488
		public static Offset<IFreezeOnSightGamePlayConfig> Pack(FlatBufferBuilder builder, IFreezeOnSightGamePlayConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFreezeOnSightGamePlayConfig>);
			}
			return IFreezeOnSightGamePlayConfig.CreateIFreezeOnSightGamePlayConfig(builder, _o.Type);
		}

		// Token: 0x0400C203 RID: 49667
		private Table __p;
	}
}
