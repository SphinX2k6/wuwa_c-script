using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BD7 RID: 19415
	public struct ICondition2 : IFlatbufferObject
	{
		// Token: 0x17008D10 RID: 36112
		// (get) Token: 0x0601EA85 RID: 125573 RVA: 0x00449A18 File Offset: 0x00447C18
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EA86 RID: 125574 RVA: 0x00449A25 File Offset: 0x00447C25
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EA87 RID: 125575 RVA: 0x00449A2C File Offset: 0x00447C2C
		public static ICondition2 GetRootAsICondition2(ByteBuffer _bb)
		{
			return ICondition2.GetRootAsICondition2(_bb, default(ICondition2));
		}

		// Token: 0x0601EA88 RID: 125576 RVA: 0x00449A48 File Offset: 0x00447C48
		public static ICondition2 GetRootAsICondition2(ByteBuffer _bb, ICondition2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EA89 RID: 125577 RVA: 0x00449A65 File Offset: 0x00447C65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EA8A RID: 125578 RVA: 0x00449A74 File Offset: 0x00447C74
		public ICondition2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D11 RID: 36113
		// (get) Token: 0x0601EA8B RID: 125579 RVA: 0x00449A84 File Offset: 0x00447C84
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601EA8C RID: 125580 RVA: 0x00449AC0 File Offset: 0x00447CC0
		public static Offset<ICondition2> CreateICondition2(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar)
		{
			builder.StartTable(1);
			ICondition2.AddType(builder, Type);
			return ICondition2.EndICondition2(builder);
		}

		// Token: 0x0601EA8D RID: 125581 RVA: 0x00449AD6 File Offset: 0x00447CD6
		public static void StartICondition2(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601EA8E RID: 125582 RVA: 0x00449ADF File Offset: 0x00447CDF
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EA8F RID: 125583 RVA: 0x00449AEA File Offset: 0x00447CEA
		public static Offset<ICondition2> EndICondition2(FlatBufferBuilder builder)
		{
			return new Offset<ICondition2>(builder.EndTable());
		}

		// Token: 0x0601EA90 RID: 125584 RVA: 0x00449AF8 File Offset: 0x00447CF8
		public ICondition2T UnPack()
		{
			ICondition2T condition2T = new ICondition2T();
			this.UnPackTo(condition2T);
			return condition2T;
		}

		// Token: 0x0601EA91 RID: 125585 RVA: 0x00449B13 File Offset: 0x00447D13
		public void UnPackTo(ICondition2T _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601EA92 RID: 125586 RVA: 0x00449B24 File Offset: 0x00447D24
		public static Offset<ICondition2> Pack(FlatBufferBuilder builder, ICondition2T _o)
		{
			if (_o == null)
			{
				return default(Offset<ICondition2>);
			}
			return ICondition2.CreateICondition2(builder, _o.Type);
		}

		// Token: 0x0400D4CC RID: 54476
		private Table __p;
	}
}
