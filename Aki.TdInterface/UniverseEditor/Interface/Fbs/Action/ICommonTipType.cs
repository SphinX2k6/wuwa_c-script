using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B1B RID: 27419
	public struct ICommonTipType : IFlatbufferObject
	{
		// Token: 0x1700C95C RID: 51548
		// (get) Token: 0x0602F258 RID: 193112 RVA: 0x0066DA9D File Offset: 0x0066BC9D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F259 RID: 193113 RVA: 0x0066DAAA File Offset: 0x0066BCAA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F25A RID: 193114 RVA: 0x0066DAB4 File Offset: 0x0066BCB4
		public static ICommonTipType GetRootAsICommonTipType(ByteBuffer _bb)
		{
			return ICommonTipType.GetRootAsICommonTipType(_bb, default(ICommonTipType));
		}

		// Token: 0x0602F25B RID: 193115 RVA: 0x0066DAD0 File Offset: 0x0066BCD0
		public static ICommonTipType GetRootAsICommonTipType(ByteBuffer _bb, ICommonTipType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F25C RID: 193116 RVA: 0x0066DAED File Offset: 0x0066BCED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F25D RID: 193117 RVA: 0x0066DAFC File Offset: 0x0066BCFC
		public ICommonTipType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C95D RID: 51549
		// (get) Token: 0x0602F25E RID: 193118 RVA: 0x0066DB0C File Offset: 0x0066BD0C
		public ECommonTipType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return (ECommonTipType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F25F RID: 193119 RVA: 0x0066DB48 File Offset: 0x0066BD48
		public static Offset<ICommonTipType> CreateICommonTipType(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition)
		{
			builder.StartTable(1);
			ICommonTipType.AddType(builder, Type);
			return ICommonTipType.EndICommonTipType(builder);
		}

		// Token: 0x0602F260 RID: 193120 RVA: 0x0066DB5E File Offset: 0x0066BD5E
		public static void StartICommonTipType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F261 RID: 193121 RVA: 0x0066DB67 File Offset: 0x0066BD67
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F262 RID: 193122 RVA: 0x0066DB72 File Offset: 0x0066BD72
		public static Offset<ICommonTipType> EndICommonTipType(FlatBufferBuilder builder)
		{
			return new Offset<ICommonTipType>(builder.EndTable());
		}

		// Token: 0x0602F263 RID: 193123 RVA: 0x0066DB80 File Offset: 0x0066BD80
		public ICommonTipTypeT UnPack()
		{
			ICommonTipTypeT commonTipTypeT = new ICommonTipTypeT();
			this.UnPackTo(commonTipTypeT);
			return commonTipTypeT;
		}

		// Token: 0x0602F264 RID: 193124 RVA: 0x0066DB9B File Offset: 0x0066BD9B
		public void UnPackTo(ICommonTipTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F265 RID: 193125 RVA: 0x0066DBAC File Offset: 0x0066BDAC
		public static Offset<ICommonTipType> Pack(FlatBufferBuilder builder, ICommonTipTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonTipType>);
			}
			return ICommonTipType.CreateICommonTipType(builder, _o.Type);
		}

		// Token: 0x040118D0 RID: 71888
		private Table __p;
	}
}
