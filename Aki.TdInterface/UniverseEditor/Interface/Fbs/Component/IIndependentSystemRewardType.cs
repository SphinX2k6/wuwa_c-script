using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005978 RID: 22904
	public struct IIndependentSystemRewardType : IFlatbufferObject
	{
		// Token: 0x1700A663 RID: 42595
		// (get) Token: 0x06025561 RID: 152929 RVA: 0x0051FE27 File Offset: 0x0051E027
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025562 RID: 152930 RVA: 0x0051FE34 File Offset: 0x0051E034
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025563 RID: 152931 RVA: 0x0051FE3C File Offset: 0x0051E03C
		public static IIndependentSystemRewardType GetRootAsIIndependentSystemRewardType(ByteBuffer _bb)
		{
			return IIndependentSystemRewardType.GetRootAsIIndependentSystemRewardType(_bb, default(IIndependentSystemRewardType));
		}

		// Token: 0x06025564 RID: 152932 RVA: 0x0051FE58 File Offset: 0x0051E058
		public static IIndependentSystemRewardType GetRootAsIIndependentSystemRewardType(ByteBuffer _bb, IIndependentSystemRewardType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025565 RID: 152933 RVA: 0x0051FE75 File Offset: 0x0051E075
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025566 RID: 152934 RVA: 0x0051FE84 File Offset: 0x0051E084
		public IIndependentSystemRewardType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A664 RID: 42596
		// (get) Token: 0x06025567 RID: 152935 RVA: 0x0051FE94 File Offset: 0x0051E094
		public EIndependentSystemRewardType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EIndependentSystemRewardType.DarkTide;
				}
				return (EIndependentSystemRewardType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025568 RID: 152936 RVA: 0x0051FED0 File Offset: 0x0051E0D0
		public static Offset<IIndependentSystemRewardType> CreateIIndependentSystemRewardType(FlatBufferBuilder builder, EIndependentSystemRewardType Type = EIndependentSystemRewardType.DarkTide)
		{
			builder.StartTable(1);
			IIndependentSystemRewardType.AddType(builder, Type);
			return IIndependentSystemRewardType.EndIIndependentSystemRewardType(builder);
		}

		// Token: 0x06025569 RID: 152937 RVA: 0x0051FEE6 File Offset: 0x0051E0E6
		public static void StartIIndependentSystemRewardType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602556A RID: 152938 RVA: 0x0051FEEF File Offset: 0x0051E0EF
		public static void AddType(FlatBufferBuilder builder, EIndependentSystemRewardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602556B RID: 152939 RVA: 0x0051FEFA File Offset: 0x0051E0FA
		public static Offset<IIndependentSystemRewardType> EndIIndependentSystemRewardType(FlatBufferBuilder builder)
		{
			return new Offset<IIndependentSystemRewardType>(builder.EndTable());
		}

		// Token: 0x0602556C RID: 152940 RVA: 0x0051FF08 File Offset: 0x0051E108
		public IIndependentSystemRewardTypeT UnPack()
		{
			IIndependentSystemRewardTypeT independentSystemRewardTypeT = new IIndependentSystemRewardTypeT();
			this.UnPackTo(independentSystemRewardTypeT);
			return independentSystemRewardTypeT;
		}

		// Token: 0x0602556D RID: 152941 RVA: 0x0051FF23 File Offset: 0x0051E123
		public void UnPackTo(IIndependentSystemRewardTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602556E RID: 152942 RVA: 0x0051FF34 File Offset: 0x0051E134
		public static Offset<IIndependentSystemRewardType> Pack(FlatBufferBuilder builder, IIndependentSystemRewardTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IIndependentSystemRewardType>);
			}
			return IIndependentSystemRewardType.CreateIIndependentSystemRewardType(builder, _o.Type);
		}

		// Token: 0x0400F264 RID: 62052
		private Table __p;
	}
}
