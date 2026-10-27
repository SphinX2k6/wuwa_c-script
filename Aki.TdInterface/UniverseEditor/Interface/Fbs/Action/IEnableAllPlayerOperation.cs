using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200664B RID: 26187
	public struct IEnableAllPlayerOperation : IFlatbufferObject
	{
		// Token: 0x1700C292 RID: 49810
		// (get) Token: 0x0602D7C9 RID: 186313 RVA: 0x0063AD85 File Offset: 0x00638F85
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D7CA RID: 186314 RVA: 0x0063AD92 File Offset: 0x00638F92
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D7CB RID: 186315 RVA: 0x0063AD9C File Offset: 0x00638F9C
		public static IEnableAllPlayerOperation GetRootAsIEnableAllPlayerOperation(ByteBuffer _bb)
		{
			return IEnableAllPlayerOperation.GetRootAsIEnableAllPlayerOperation(_bb, default(IEnableAllPlayerOperation));
		}

		// Token: 0x0602D7CC RID: 186316 RVA: 0x0063ADB8 File Offset: 0x00638FB8
		public static IEnableAllPlayerOperation GetRootAsIEnableAllPlayerOperation(ByteBuffer _bb, IEnableAllPlayerOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D7CD RID: 186317 RVA: 0x0063ADD5 File Offset: 0x00638FD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D7CE RID: 186318 RVA: 0x0063ADE4 File Offset: 0x00638FE4
		public IEnableAllPlayerOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C293 RID: 49811
		// (get) Token: 0x0602D7CF RID: 186319 RVA: 0x0063ADF4 File Offset: 0x00638FF4
		public EPlayerOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPlayerOperationType.EnableAll;
				}
				return (EPlayerOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C294 RID: 49812
		// (get) Token: 0x0602D7D0 RID: 186320 RVA: 0x0063AE30 File Offset: 0x00639030
		public bool IsUiFadeEffect
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C295 RID: 49813
		// (get) Token: 0x0602D7D1 RID: 186321 RVA: 0x0063AE70 File Offset: 0x00639070
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D7D2 RID: 186322 RVA: 0x0063AEAC File Offset: 0x006390AC
		public static Offset<IEnableAllPlayerOperation> CreateIEnableAllPlayerOperation(FlatBufferBuilder builder, EPlayerOperationType Type = EPlayerOperationType.EnableAll, bool IsUiFadeEffect = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IEnableAllPlayerOperation.AddNullMask(builder, NullMask);
			IEnableAllPlayerOperation.AddIsUiFadeEffect(builder, IsUiFadeEffect);
			IEnableAllPlayerOperation.AddType(builder, Type);
			return IEnableAllPlayerOperation.EndIEnableAllPlayerOperation(builder);
		}

		// Token: 0x0602D7D3 RID: 186323 RVA: 0x0063AED0 File Offset: 0x006390D0
		public static void StartIEnableAllPlayerOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602D7D4 RID: 186324 RVA: 0x0063AED9 File Offset: 0x006390D9
		public static void AddType(FlatBufferBuilder builder, EPlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D7D5 RID: 186325 RVA: 0x0063AEE4 File Offset: 0x006390E4
		public static void AddIsUiFadeEffect(FlatBufferBuilder builder, bool isUiFadeEffect)
		{
			builder.AddBool(1, isUiFadeEffect, false);
		}

		// Token: 0x0602D7D6 RID: 186326 RVA: 0x0063AEEF File Offset: 0x006390EF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602D7D7 RID: 186327 RVA: 0x0063AEFA File Offset: 0x006390FA
		public static Offset<IEnableAllPlayerOperation> EndIEnableAllPlayerOperation(FlatBufferBuilder builder)
		{
			return new Offset<IEnableAllPlayerOperation>(builder.EndTable());
		}

		// Token: 0x0602D7D8 RID: 186328 RVA: 0x0063AF08 File Offset: 0x00639108
		public IEnableAllPlayerOperationT UnPack()
		{
			IEnableAllPlayerOperationT enableAllPlayerOperationT = new IEnableAllPlayerOperationT();
			this.UnPackTo(enableAllPlayerOperationT);
			return enableAllPlayerOperationT;
		}

		// Token: 0x0602D7D9 RID: 186329 RVA: 0x0063AF23 File Offset: 0x00639123
		public void UnPackTo(IEnableAllPlayerOperationT _o)
		{
			_o.Type = this.Type;
			_o.IsUiFadeEffect = this.IsUiFadeEffect;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602D7DA RID: 186330 RVA: 0x0063AF4C File Offset: 0x0063914C
		public static Offset<IEnableAllPlayerOperation> Pack(FlatBufferBuilder builder, IEnableAllPlayerOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableAllPlayerOperation>);
			}
			return IEnableAllPlayerOperation.CreateIEnableAllPlayerOperation(builder, _o.Type, _o.IsUiFadeEffect, _o.NullMask);
		}

		// Token: 0x04010CE8 RID: 68840
		private Table __p;
	}
}
