using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E72 RID: 15986
	public struct IFreezeOnSightGamePlayConfig : IFlatbufferObject
	{
		// Token: 0x17006EDF RID: 28383
		// (get) Token: 0x06016853 RID: 92243 RVA: 0x003413F7 File Offset: 0x0033F5F7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016854 RID: 92244 RVA: 0x00341404 File Offset: 0x0033F604
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016855 RID: 92245 RVA: 0x0034140C File Offset: 0x0033F60C
		public static IFreezeOnSightGamePlayConfig GetRootAsIFreezeOnSightGamePlayConfig(ByteBuffer _bb)
		{
			return IFreezeOnSightGamePlayConfig.GetRootAsIFreezeOnSightGamePlayConfig(_bb, default(IFreezeOnSightGamePlayConfig));
		}

		// Token: 0x06016856 RID: 92246 RVA: 0x00341428 File Offset: 0x0033F628
		public static IFreezeOnSightGamePlayConfig GetRootAsIFreezeOnSightGamePlayConfig(ByteBuffer _bb, IFreezeOnSightGamePlayConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016857 RID: 92247 RVA: 0x00341445 File Offset: 0x0033F645
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016858 RID: 92248 RVA: 0x00341454 File Offset: 0x0033F654
		public IFreezeOnSightGamePlayConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006EE0 RID: 28384
		// (get) Token: 0x06016859 RID: 92249 RVA: 0x00341464 File Offset: 0x0033F664
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

		// Token: 0x0601685A RID: 92250 RVA: 0x003414A0 File Offset: 0x0033F6A0
		public static Offset<IFreezeOnSightGamePlayConfig> CreateIFreezeOnSightGamePlayConfig(FlatBufferBuilder builder, ESpecialGamePlayConfigType Type = ESpecialGamePlayConfigType.Stalking)
		{
			builder.StartTable(1);
			IFreezeOnSightGamePlayConfig.AddType(builder, Type);
			return IFreezeOnSightGamePlayConfig.EndIFreezeOnSightGamePlayConfig(builder);
		}

		// Token: 0x0601685B RID: 92251 RVA: 0x003414B6 File Offset: 0x0033F6B6
		public static void StartIFreezeOnSightGamePlayConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601685C RID: 92252 RVA: 0x003414BF File Offset: 0x0033F6BF
		public static void AddType(FlatBufferBuilder builder, ESpecialGamePlayConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601685D RID: 92253 RVA: 0x003414CA File Offset: 0x0033F6CA
		public static Offset<IFreezeOnSightGamePlayConfig> EndIFreezeOnSightGamePlayConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFreezeOnSightGamePlayConfig>(builder.EndTable());
		}

		// Token: 0x0601685E RID: 92254 RVA: 0x003414D8 File Offset: 0x0033F6D8
		public IFreezeOnSightGamePlayConfigT UnPack()
		{
			IFreezeOnSightGamePlayConfigT freezeOnSightGamePlayConfigT = new IFreezeOnSightGamePlayConfigT();
			this.UnPackTo(freezeOnSightGamePlayConfigT);
			return freezeOnSightGamePlayConfigT;
		}

		// Token: 0x0601685F RID: 92255 RVA: 0x003414F3 File Offset: 0x0033F6F3
		public void UnPackTo(IFreezeOnSightGamePlayConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06016860 RID: 92256 RVA: 0x00341504 File Offset: 0x0033F704
		public static Offset<IFreezeOnSightGamePlayConfig> Pack(FlatBufferBuilder builder, IFreezeOnSightGamePlayConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFreezeOnSightGamePlayConfig>);
			}
			return IFreezeOnSightGamePlayConfig.CreateIFreezeOnSightGamePlayConfig(builder, _o.Type);
		}

		// Token: 0x0400B82A RID: 47146
		private Table __p;
	}
}
