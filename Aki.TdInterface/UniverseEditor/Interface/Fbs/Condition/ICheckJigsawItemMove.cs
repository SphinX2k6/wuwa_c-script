using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AB1 RID: 19121
	public struct ICheckJigsawItemMove : IFlatbufferObject
	{
		// Token: 0x17008A97 RID: 35479
		// (get) Token: 0x0601E02E RID: 122926 RVA: 0x00436700 File Offset: 0x00434900
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E02F RID: 122927 RVA: 0x0043670D File Offset: 0x0043490D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E030 RID: 122928 RVA: 0x00436714 File Offset: 0x00434914
		public static ICheckJigsawItemMove GetRootAsICheckJigsawItemMove(ByteBuffer _bb)
		{
			return ICheckJigsawItemMove.GetRootAsICheckJigsawItemMove(_bb, default(ICheckJigsawItemMove));
		}

		// Token: 0x0601E031 RID: 122929 RVA: 0x00436730 File Offset: 0x00434930
		public static ICheckJigsawItemMove GetRootAsICheckJigsawItemMove(ByteBuffer _bb, ICheckJigsawItemMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E032 RID: 122930 RVA: 0x0043674D File Offset: 0x0043494D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E033 RID: 122931 RVA: 0x0043675C File Offset: 0x0043495C
		public ICheckJigsawItemMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008A98 RID: 35480
		// (get) Token: 0x0601E034 RID: 122932 RVA: 0x0043676C File Offset: 0x0043496C
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

		// Token: 0x17008A99 RID: 35481
		// (get) Token: 0x0601E035 RID: 122933 RVA: 0x004367A8 File Offset: 0x004349A8
		public int ItemEntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008A9A RID: 35482
		// (get) Token: 0x0601E036 RID: 122934 RVA: 0x004367E4 File Offset: 0x004349E4
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E037 RID: 122935 RVA: 0x00436820 File Offset: 0x00434A20
		public static Offset<ICheckJigsawItemMove> CreateICheckJigsawItemMove(FlatBufferBuilder builder, ECheckJigsawInfoType Type = ECheckJigsawInfoType.CheckJigsawItemPlaceIndex, int ItemEntityId = 0, ECompare Compare = ECompare.Eq)
		{
			builder.StartTable(3);
			ICheckJigsawItemMove.AddItemEntityId(builder, ItemEntityId);
			ICheckJigsawItemMove.AddCompare(builder, Compare);
			ICheckJigsawItemMove.AddType(builder, Type);
			return ICheckJigsawItemMove.EndICheckJigsawItemMove(builder);
		}

		// Token: 0x0601E038 RID: 122936 RVA: 0x00436844 File Offset: 0x00434A44
		public static void StartICheckJigsawItemMove(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601E039 RID: 122937 RVA: 0x0043684D File Offset: 0x00434A4D
		public static void AddType(FlatBufferBuilder builder, ECheckJigsawInfoType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E03A RID: 122938 RVA: 0x00436858 File Offset: 0x00434A58
		public static void AddItemEntityId(FlatBufferBuilder builder, int itemEntityId)
		{
			builder.AddInt(1, itemEntityId, 0);
		}

		// Token: 0x0601E03B RID: 122939 RVA: 0x00436863 File Offset: 0x00434A63
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601E03C RID: 122940 RVA: 0x0043686E File Offset: 0x00434A6E
		public static Offset<ICheckJigsawItemMove> EndICheckJigsawItemMove(FlatBufferBuilder builder)
		{
			return new Offset<ICheckJigsawItemMove>(builder.EndTable());
		}

		// Token: 0x0601E03D RID: 122941 RVA: 0x0043687C File Offset: 0x00434A7C
		public ICheckJigsawItemMoveT UnPack()
		{
			ICheckJigsawItemMoveT checkJigsawItemMoveT = new ICheckJigsawItemMoveT();
			this.UnPackTo(checkJigsawItemMoveT);
			return checkJigsawItemMoveT;
		}

		// Token: 0x0601E03E RID: 122942 RVA: 0x00436897 File Offset: 0x00434A97
		public void UnPackTo(ICheckJigsawItemMoveT _o)
		{
			_o.Type = this.Type;
			_o.ItemEntityId = this.ItemEntityId;
			_o.Compare = this.Compare;
		}

		// Token: 0x0601E03F RID: 122943 RVA: 0x004368C0 File Offset: 0x00434AC0
		public static Offset<ICheckJigsawItemMove> Pack(FlatBufferBuilder builder, ICheckJigsawItemMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckJigsawItemMove>);
			}
			return ICheckJigsawItemMove.CreateICheckJigsawItemMove(builder, _o.Type, _o.ItemEntityId, _o.Compare);
		}

		// Token: 0x0400D32C RID: 54060
		private Table __p;
	}
}
