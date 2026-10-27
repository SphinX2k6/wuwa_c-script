using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068CA RID: 26826
	public struct IHeadStyle : IFlatbufferObject
	{
		// Token: 0x1700C70F RID: 50959
		// (get) Token: 0x0602EC9E RID: 191646 RVA: 0x00662AB1 File Offset: 0x00660CB1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EC9F RID: 191647 RVA: 0x00662ABE File Offset: 0x00660CBE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602ECA0 RID: 191648 RVA: 0x00662AC8 File Offset: 0x00660CC8
		public static IHeadStyle GetRootAsIHeadStyle(ByteBuffer _bb)
		{
			return IHeadStyle.GetRootAsIHeadStyle(_bb, default(IHeadStyle));
		}

		// Token: 0x0602ECA1 RID: 191649 RVA: 0x00662AE4 File Offset: 0x00660CE4
		public static IHeadStyle GetRootAsIHeadStyle(ByteBuffer _bb, IHeadStyle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602ECA2 RID: 191650 RVA: 0x00662B01 File Offset: 0x00660D01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602ECA3 RID: 191651 RVA: 0x00662B10 File Offset: 0x00660D10
		public IHeadStyle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C710 RID: 50960
		// (get) Token: 0x0602ECA4 RID: 191652 RVA: 0x00662B20 File Offset: 0x00660D20
		public EHeadStyle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHeadStyle.Normal;
				}
				return (EHeadStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602ECA5 RID: 191653 RVA: 0x00662B5C File Offset: 0x00660D5C
		public static Offset<IHeadStyle> CreateIHeadStyle(FlatBufferBuilder builder, EHeadStyle Type = EHeadStyle.Normal)
		{
			builder.StartTable(1);
			IHeadStyle.AddType(builder, Type);
			return IHeadStyle.EndIHeadStyle(builder);
		}

		// Token: 0x0602ECA6 RID: 191654 RVA: 0x00662B72 File Offset: 0x00660D72
		public static void StartIHeadStyle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602ECA7 RID: 191655 RVA: 0x00662B7B File Offset: 0x00660D7B
		public static void AddType(FlatBufferBuilder builder, EHeadStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602ECA8 RID: 191656 RVA: 0x00662B86 File Offset: 0x00660D86
		public static Offset<IHeadStyle> EndIHeadStyle(FlatBufferBuilder builder)
		{
			return new Offset<IHeadStyle>(builder.EndTable());
		}

		// Token: 0x0602ECA9 RID: 191657 RVA: 0x00662B94 File Offset: 0x00660D94
		public IHeadStyleT UnPack()
		{
			IHeadStyleT headStyleT = new IHeadStyleT();
			this.UnPackTo(headStyleT);
			return headStyleT;
		}

		// Token: 0x0602ECAA RID: 191658 RVA: 0x00662BAF File Offset: 0x00660DAF
		public void UnPackTo(IHeadStyleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602ECAB RID: 191659 RVA: 0x00662BC0 File Offset: 0x00660DC0
		public static Offset<IHeadStyle> Pack(FlatBufferBuilder builder, IHeadStyleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHeadStyle>);
			}
			return IHeadStyle.CreateIHeadStyle(builder, _o.Type);
		}

		// Token: 0x04011027 RID: 69671
		private Table __p;
	}
}
