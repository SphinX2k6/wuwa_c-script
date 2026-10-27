using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B8C RID: 19340
	public struct IComparedAlertValueType : IFlatbufferObject
	{
		// Token: 0x17008C5C RID: 35932
		// (get) Token: 0x0601E7C0 RID: 124864 RVA: 0x0044476A File Offset: 0x0044296A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E7C1 RID: 124865 RVA: 0x00444777 File Offset: 0x00442977
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E7C2 RID: 124866 RVA: 0x00444780 File Offset: 0x00442980
		public static IComparedAlertValueType GetRootAsIComparedAlertValueType(ByteBuffer _bb)
		{
			return IComparedAlertValueType.GetRootAsIComparedAlertValueType(_bb, default(IComparedAlertValueType));
		}

		// Token: 0x0601E7C3 RID: 124867 RVA: 0x0044479C File Offset: 0x0044299C
		public static IComparedAlertValueType GetRootAsIComparedAlertValueType(ByteBuffer _bb, IComparedAlertValueType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E7C4 RID: 124868 RVA: 0x004447B9 File Offset: 0x004429B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E7C5 RID: 124869 RVA: 0x004447C8 File Offset: 0x004429C8
		public IComparedAlertValueType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008C5D RID: 35933
		// (get) Token: 0x0601E7C6 RID: 124870 RVA: 0x004447D8 File Offset: 0x004429D8
		public EComparedAlertValueType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EComparedAlertValueType.Min;
				}
				return (EComparedAlertValueType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E7C7 RID: 124871 RVA: 0x00444814 File Offset: 0x00442A14
		public static Offset<IComparedAlertValueType> CreateIComparedAlertValueType(FlatBufferBuilder builder, EComparedAlertValueType Type = EComparedAlertValueType.Min)
		{
			builder.StartTable(1);
			IComparedAlertValueType.AddType(builder, Type);
			return IComparedAlertValueType.EndIComparedAlertValueType(builder);
		}

		// Token: 0x0601E7C8 RID: 124872 RVA: 0x0044482A File Offset: 0x00442A2A
		public static void StartIComparedAlertValueType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601E7C9 RID: 124873 RVA: 0x00444833 File Offset: 0x00442A33
		public static void AddType(FlatBufferBuilder builder, EComparedAlertValueType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E7CA RID: 124874 RVA: 0x0044483E File Offset: 0x00442A3E
		public static Offset<IComparedAlertValueType> EndIComparedAlertValueType(FlatBufferBuilder builder)
		{
			return new Offset<IComparedAlertValueType>(builder.EndTable());
		}

		// Token: 0x0601E7CB RID: 124875 RVA: 0x0044484C File Offset: 0x00442A4C
		public IComparedAlertValueTypeT UnPack()
		{
			IComparedAlertValueTypeT comparedAlertValueTypeT = new IComparedAlertValueTypeT();
			this.UnPackTo(comparedAlertValueTypeT);
			return comparedAlertValueTypeT;
		}

		// Token: 0x0601E7CC RID: 124876 RVA: 0x00444867 File Offset: 0x00442A67
		public void UnPackTo(IComparedAlertValueTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601E7CD RID: 124877 RVA: 0x00444878 File Offset: 0x00442A78
		public static Offset<IComparedAlertValueType> Pack(FlatBufferBuilder builder, IComparedAlertValueTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IComparedAlertValueType>);
			}
			return IComparedAlertValueType.CreateIComparedAlertValueType(builder, _o.Type);
		}

		// Token: 0x0400D45F RID: 54367
		private Table __p;
	}
}
