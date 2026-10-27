using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AB7 RID: 19127
	public struct ICheckJigsawType : IFlatbufferObject
	{
		// Token: 0x17008AA9 RID: 35497
		// (get) Token: 0x0601E06A RID: 122986 RVA: 0x00436DBB File Offset: 0x00434FBB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E06B RID: 122987 RVA: 0x00436DC8 File Offset: 0x00434FC8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E06C RID: 122988 RVA: 0x00436DD0 File Offset: 0x00434FD0
		public static ICheckJigsawType GetRootAsICheckJigsawType(ByteBuffer _bb)
		{
			return ICheckJigsawType.GetRootAsICheckJigsawType(_bb, default(ICheckJigsawType));
		}

		// Token: 0x0601E06D RID: 122989 RVA: 0x00436DEC File Offset: 0x00434FEC
		public static ICheckJigsawType GetRootAsICheckJigsawType(ByteBuffer _bb, ICheckJigsawType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E06E RID: 122990 RVA: 0x00436E09 File Offset: 0x00435009
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E06F RID: 122991 RVA: 0x00436E18 File Offset: 0x00435018
		public ICheckJigsawType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008AAA RID: 35498
		// (get) Token: 0x0601E070 RID: 122992 RVA: 0x00436E28 File Offset: 0x00435028
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

		// Token: 0x0601E071 RID: 122993 RVA: 0x00436E64 File Offset: 0x00435064
		public static Offset<ICheckJigsawType> CreateICheckJigsawType(FlatBufferBuilder builder, ECheckJigsawInfoType Type = ECheckJigsawInfoType.CheckJigsawItemPlaceIndex)
		{
			builder.StartTable(1);
			ICheckJigsawType.AddType(builder, Type);
			return ICheckJigsawType.EndICheckJigsawType(builder);
		}

		// Token: 0x0601E072 RID: 122994 RVA: 0x00436E7A File Offset: 0x0043507A
		public static void StartICheckJigsawType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601E073 RID: 122995 RVA: 0x00436E83 File Offset: 0x00435083
		public static void AddType(FlatBufferBuilder builder, ECheckJigsawInfoType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E074 RID: 122996 RVA: 0x00436E8E File Offset: 0x0043508E
		public static Offset<ICheckJigsawType> EndICheckJigsawType(FlatBufferBuilder builder)
		{
			return new Offset<ICheckJigsawType>(builder.EndTable());
		}

		// Token: 0x0601E075 RID: 122997 RVA: 0x00436E9C File Offset: 0x0043509C
		public ICheckJigsawTypeT UnPack()
		{
			ICheckJigsawTypeT checkJigsawTypeT = new ICheckJigsawTypeT();
			this.UnPackTo(checkJigsawTypeT);
			return checkJigsawTypeT;
		}

		// Token: 0x0601E076 RID: 122998 RVA: 0x00436EB7 File Offset: 0x004350B7
		public void UnPackTo(ICheckJigsawTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601E077 RID: 122999 RVA: 0x00436EC8 File Offset: 0x004350C8
		public static Offset<ICheckJigsawType> Pack(FlatBufferBuilder builder, ICheckJigsawTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckJigsawType>);
			}
			return ICheckJigsawType.CreateICheckJigsawType(builder, _o.Type);
		}

		// Token: 0x0400D336 RID: 54070
		private Table __p;
	}
}
