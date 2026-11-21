using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CBC RID: 27836
	public struct IEnableAllPlayerOperation : IFlatbufferObject
	{
		// Token: 0x1700CC30 RID: 52272
		// (get) Token: 0x0602FF9A RID: 196506 RVA: 0x006878ED File Offset: 0x00685AED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FF9B RID: 196507 RVA: 0x006878FA File Offset: 0x00685AFA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FF9C RID: 196508 RVA: 0x00687904 File Offset: 0x00685B04
		public static IEnableAllPlayerOperation GetRootAsIEnableAllPlayerOperation(ByteBuffer _bb)
		{
			return IEnableAllPlayerOperation.GetRootAsIEnableAllPlayerOperation(_bb, default(IEnableAllPlayerOperation));
		}

		// Token: 0x0602FF9D RID: 196509 RVA: 0x00687920 File Offset: 0x00685B20
		public static IEnableAllPlayerOperation GetRootAsIEnableAllPlayerOperation(ByteBuffer _bb, IEnableAllPlayerOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FF9E RID: 196510 RVA: 0x0068793D File Offset: 0x00685B3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FF9F RID: 196511 RVA: 0x0068794C File Offset: 0x00685B4C
		public IEnableAllPlayerOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC31 RID: 52273
		// (get) Token: 0x0602FFA0 RID: 196512 RVA: 0x0068795C File Offset: 0x00685B5C
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

		// Token: 0x1700CC32 RID: 52274
		// (get) Token: 0x0602FFA1 RID: 196513 RVA: 0x00687998 File Offset: 0x00685B98
		public bool IsUiFadeEffect
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CC33 RID: 52275
		// (get) Token: 0x0602FFA2 RID: 196514 RVA: 0x006879D8 File Offset: 0x00685BD8
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

		// Token: 0x0602FFA3 RID: 196515 RVA: 0x00687A14 File Offset: 0x00685C14
		public static Offset<IEnableAllPlayerOperation> CreateIEnableAllPlayerOperation(FlatBufferBuilder builder, EPlayerOperationType Type = EPlayerOperationType.EnableAll, bool IsUiFadeEffect = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IEnableAllPlayerOperation.AddNullMask(builder, NullMask);
			IEnableAllPlayerOperation.AddIsUiFadeEffect(builder, IsUiFadeEffect);
			IEnableAllPlayerOperation.AddType(builder, Type);
			return IEnableAllPlayerOperation.EndIEnableAllPlayerOperation(builder);
		}

		// Token: 0x0602FFA4 RID: 196516 RVA: 0x00687A38 File Offset: 0x00685C38
		public static void StartIEnableAllPlayerOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602FFA5 RID: 196517 RVA: 0x00687A41 File Offset: 0x00685C41
		public static void AddType(FlatBufferBuilder builder, EPlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FFA6 RID: 196518 RVA: 0x00687A4C File Offset: 0x00685C4C
		public static void AddIsUiFadeEffect(FlatBufferBuilder builder, bool isUiFadeEffect)
		{
			builder.AddBool(1, isUiFadeEffect, false);
		}

		// Token: 0x0602FFA7 RID: 196519 RVA: 0x00687A57 File Offset: 0x00685C57
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602FFA8 RID: 196520 RVA: 0x00687A62 File Offset: 0x00685C62
		public static Offset<IEnableAllPlayerOperation> EndIEnableAllPlayerOperation(FlatBufferBuilder builder)
		{
			return new Offset<IEnableAllPlayerOperation>(builder.EndTable());
		}

		// Token: 0x0602FFA9 RID: 196521 RVA: 0x00687A70 File Offset: 0x00685C70
		public IEnableAllPlayerOperationT UnPack()
		{
			IEnableAllPlayerOperationT enableAllPlayerOperationT = new IEnableAllPlayerOperationT();
			this.UnPackTo(enableAllPlayerOperationT);
			return enableAllPlayerOperationT;
		}

		// Token: 0x0602FFAA RID: 196522 RVA: 0x00687A8B File Offset: 0x00685C8B
		public void UnPackTo(IEnableAllPlayerOperationT _o)
		{
			_o.Type = this.Type;
			_o.IsUiFadeEffect = this.IsUiFadeEffect;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602FFAB RID: 196523 RVA: 0x00687AB4 File Offset: 0x00685CB4
		public static Offset<IEnableAllPlayerOperation> Pack(FlatBufferBuilder builder, IEnableAllPlayerOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableAllPlayerOperation>);
			}
			return IEnableAllPlayerOperation.CreateIEnableAllPlayerOperation(builder, _o.Type, _o.IsUiFadeEffect, _o.NullMask);
		}

		// Token: 0x04011B03 RID: 72451
		private Table __p;
	}
}
