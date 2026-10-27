using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E0A RID: 28170
	public struct IRangeCheck : IFlatbufferObject
	{
		// Token: 0x1700D202 RID: 53762
		// (get) Token: 0x06031C68 RID: 203880 RVA: 0x006BD59B File Offset: 0x006BB79B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031C69 RID: 203881 RVA: 0x006BD5A8 File Offset: 0x006BB7A8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031C6A RID: 203882 RVA: 0x006BD5B0 File Offset: 0x006BB7B0
		public static IRangeCheck GetRootAsIRangeCheck(ByteBuffer _bb)
		{
			return IRangeCheck.GetRootAsIRangeCheck(_bb, default(IRangeCheck));
		}

		// Token: 0x06031C6B RID: 203883 RVA: 0x006BD5CC File Offset: 0x006BB7CC
		public static IRangeCheck GetRootAsIRangeCheck(ByteBuffer _bb, IRangeCheck obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031C6C RID: 203884 RVA: 0x006BD5E9 File Offset: 0x006BB7E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031C6D RID: 203885 RVA: 0x006BD5F8 File Offset: 0x006BB7F8
		public IRangeCheck __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D203 RID: 53763
		// (get) Token: 0x06031C6E RID: 203886 RVA: 0x006BD608 File Offset: 0x006BB808
		public ERangeCheckType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERangeCheckType.Cone;
				}
				return (ERangeCheckType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031C6F RID: 203887 RVA: 0x006BD644 File Offset: 0x006BB844
		public static Offset<IRangeCheck> CreateIRangeCheck(FlatBufferBuilder builder, ERangeCheckType Type = ERangeCheckType.Cone)
		{
			builder.StartTable(1);
			IRangeCheck.AddType(builder, Type);
			return IRangeCheck.EndIRangeCheck(builder);
		}

		// Token: 0x06031C70 RID: 203888 RVA: 0x006BD65A File Offset: 0x006BB85A
		public static void StartIRangeCheck(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031C71 RID: 203889 RVA: 0x006BD663 File Offset: 0x006BB863
		public static void AddType(FlatBufferBuilder builder, ERangeCheckType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031C72 RID: 203890 RVA: 0x006BD66E File Offset: 0x006BB86E
		public static Offset<IRangeCheck> EndIRangeCheck(FlatBufferBuilder builder)
		{
			return new Offset<IRangeCheck>(builder.EndTable());
		}

		// Token: 0x06031C73 RID: 203891 RVA: 0x006BD67C File Offset: 0x006BB87C
		public IRangeCheckT UnPack()
		{
			IRangeCheckT rangeCheckT = new IRangeCheckT();
			this.UnPackTo(rangeCheckT);
			return rangeCheckT;
		}

		// Token: 0x06031C74 RID: 203892 RVA: 0x006BD697 File Offset: 0x006BB897
		public void UnPackTo(IRangeCheckT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031C75 RID: 203893 RVA: 0x006BD6A8 File Offset: 0x006BB8A8
		public static Offset<IRangeCheck> Pack(FlatBufferBuilder builder, IRangeCheckT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRangeCheck>);
			}
			return IRangeCheck.CreateIRangeCheck(builder, _o.Type);
		}

		// Token: 0x040117F1 RID: 71665
		private Table __p;
	}
}
