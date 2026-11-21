using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AD6 RID: 27350
	public struct ICommonBtOverrideTaskInfoBase : IFlatbufferObject
	{
		// Token: 0x1700C8D5 RID: 51413
		// (get) Token: 0x0602EFD0 RID: 192464 RVA: 0x00668A50 File Offset: 0x00666C50
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EFD1 RID: 192465 RVA: 0x00668A5D File Offset: 0x00666C5D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EFD2 RID: 192466 RVA: 0x00668A64 File Offset: 0x00666C64
		public static ICommonBtOverrideTaskInfoBase GetRootAsICommonBtOverrideTaskInfoBase(ByteBuffer _bb)
		{
			return ICommonBtOverrideTaskInfoBase.GetRootAsICommonBtOverrideTaskInfoBase(_bb, default(ICommonBtOverrideTaskInfoBase));
		}

		// Token: 0x0602EFD3 RID: 192467 RVA: 0x00668A80 File Offset: 0x00666C80
		public static ICommonBtOverrideTaskInfoBase GetRootAsICommonBtOverrideTaskInfoBase(ByteBuffer _bb, ICommonBtOverrideTaskInfoBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EFD4 RID: 192468 RVA: 0x00668A9D File Offset: 0x00666C9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EFD5 RID: 192469 RVA: 0x00668AAC File Offset: 0x00666CAC
		public ICommonBtOverrideTaskInfoBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C8D6 RID: 51414
		// (get) Token: 0x0602EFD6 RID: 192470 RVA: 0x00668ABC File Offset: 0x00666CBC
		public ECommonBtPlaceholderTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonBtPlaceholderTargetType.Action;
				}
				return (ECommonBtPlaceholderTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EFD7 RID: 192471 RVA: 0x00668AF8 File Offset: 0x00666CF8
		public static Offset<ICommonBtOverrideTaskInfoBase> CreateICommonBtOverrideTaskInfoBase(FlatBufferBuilder builder, ECommonBtPlaceholderTargetType Type = ECommonBtPlaceholderTargetType.Action)
		{
			builder.StartTable(1);
			ICommonBtOverrideTaskInfoBase.AddType(builder, Type);
			return ICommonBtOverrideTaskInfoBase.EndICommonBtOverrideTaskInfoBase(builder);
		}

		// Token: 0x0602EFD8 RID: 192472 RVA: 0x00668B0E File Offset: 0x00666D0E
		public static void StartICommonBtOverrideTaskInfoBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602EFD9 RID: 192473 RVA: 0x00668B17 File Offset: 0x00666D17
		public static void AddType(FlatBufferBuilder builder, ECommonBtPlaceholderTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EFDA RID: 192474 RVA: 0x00668B22 File Offset: 0x00666D22
		public static Offset<ICommonBtOverrideTaskInfoBase> EndICommonBtOverrideTaskInfoBase(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtOverrideTaskInfoBase>(builder.EndTable());
		}

		// Token: 0x0602EFDB RID: 192475 RVA: 0x00668B30 File Offset: 0x00666D30
		public ICommonBtOverrideTaskInfoBaseT UnPack()
		{
			ICommonBtOverrideTaskInfoBaseT commonBtOverrideTaskInfoBaseT = new ICommonBtOverrideTaskInfoBaseT();
			this.UnPackTo(commonBtOverrideTaskInfoBaseT);
			return commonBtOverrideTaskInfoBaseT;
		}

		// Token: 0x0602EFDC RID: 192476 RVA: 0x00668B4B File Offset: 0x00666D4B
		public void UnPackTo(ICommonBtOverrideTaskInfoBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602EFDD RID: 192477 RVA: 0x00668B5C File Offset: 0x00666D5C
		public static Offset<ICommonBtOverrideTaskInfoBase> Pack(FlatBufferBuilder builder, ICommonBtOverrideTaskInfoBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonBtOverrideTaskInfoBase>);
			}
			return ICommonBtOverrideTaskInfoBase.CreateICommonBtOverrideTaskInfoBase(builder, _o.Type);
		}

		// Token: 0x04011877 RID: 71799
		private Table __p;
	}
}
