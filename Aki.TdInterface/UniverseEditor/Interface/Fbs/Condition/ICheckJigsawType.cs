using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F86 RID: 20358
	public struct ICheckJigsawType : IFlatbufferObject
	{
		// Token: 0x17009196 RID: 37270
		// (get) Token: 0x0601FB53 RID: 129875 RVA: 0x004685DB File Offset: 0x004667DB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FB54 RID: 129876 RVA: 0x004685E8 File Offset: 0x004667E8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FB55 RID: 129877 RVA: 0x004685F0 File Offset: 0x004667F0
		public static ICheckJigsawType GetRootAsICheckJigsawType(ByteBuffer _bb)
		{
			return ICheckJigsawType.GetRootAsICheckJigsawType(_bb, default(ICheckJigsawType));
		}

		// Token: 0x0601FB56 RID: 129878 RVA: 0x0046860C File Offset: 0x0046680C
		public static ICheckJigsawType GetRootAsICheckJigsawType(ByteBuffer _bb, ICheckJigsawType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FB57 RID: 129879 RVA: 0x00468629 File Offset: 0x00466829
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FB58 RID: 129880 RVA: 0x00468638 File Offset: 0x00466838
		public ICheckJigsawType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009197 RID: 37271
		// (get) Token: 0x0601FB59 RID: 129881 RVA: 0x00468648 File Offset: 0x00466848
		public ECheckJigsawInfoType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckJigsawInfoType.CheckJigsawItemPlaceIndex;
				}
				return (ECheckJigsawInfoType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601FB5A RID: 129882 RVA: 0x00468684 File Offset: 0x00466884
		public static Offset<ICheckJigsawType> CreateICheckJigsawType(FlatBufferBuilder builder, ECheckJigsawInfoType Type = ECheckJigsawInfoType.CheckJigsawItemPlaceIndex)
		{
			builder.StartTable(1);
			ICheckJigsawType.AddType(builder, Type);
			return ICheckJigsawType.EndICheckJigsawType(builder);
		}

		// Token: 0x0601FB5B RID: 129883 RVA: 0x0046869A File Offset: 0x0046689A
		public static void StartICheckJigsawType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601FB5C RID: 129884 RVA: 0x004686A3 File Offset: 0x004668A3
		public static void AddType(FlatBufferBuilder builder, ECheckJigsawInfoType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FB5D RID: 129885 RVA: 0x004686AE File Offset: 0x004668AE
		public static Offset<ICheckJigsawType> EndICheckJigsawType(FlatBufferBuilder builder)
		{
			return new Offset<ICheckJigsawType>(builder.EndTable());
		}

		// Token: 0x0601FB5E RID: 129886 RVA: 0x004686BC File Offset: 0x004668BC
		public ICheckJigsawTypeT UnPack()
		{
			ICheckJigsawTypeT checkJigsawTypeT = new ICheckJigsawTypeT();
			this.UnPackTo(checkJigsawTypeT);
			return checkJigsawTypeT;
		}

		// Token: 0x0601FB5F RID: 129887 RVA: 0x004686D7 File Offset: 0x004668D7
		public void UnPackTo(ICheckJigsawTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601FB60 RID: 129888 RVA: 0x004686E8 File Offset: 0x004668E8
		public static Offset<ICheckJigsawType> Pack(FlatBufferBuilder builder, ICheckJigsawTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckJigsawType>);
			}
			return ICheckJigsawType.CreateICheckJigsawType(builder, _o.Type);
		}

		// Token: 0x0400DE1B RID: 56859
		private Table __p;
	}
}
