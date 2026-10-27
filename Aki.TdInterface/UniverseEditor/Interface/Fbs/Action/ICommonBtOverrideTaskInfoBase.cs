using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200646E RID: 25710
	public struct ICommonBtOverrideTaskInfoBase : IFlatbufferObject
	{
		// Token: 0x1700BF53 RID: 48979
		// (get) Token: 0x0602C87F RID: 182399 RVA: 0x0061D444 File Offset: 0x0061B644
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C880 RID: 182400 RVA: 0x0061D451 File Offset: 0x0061B651
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C881 RID: 182401 RVA: 0x0061D458 File Offset: 0x0061B658
		public static ICommonBtOverrideTaskInfoBase GetRootAsICommonBtOverrideTaskInfoBase(ByteBuffer _bb)
		{
			return ICommonBtOverrideTaskInfoBase.GetRootAsICommonBtOverrideTaskInfoBase(_bb, default(ICommonBtOverrideTaskInfoBase));
		}

		// Token: 0x0602C882 RID: 182402 RVA: 0x0061D474 File Offset: 0x0061B674
		public static ICommonBtOverrideTaskInfoBase GetRootAsICommonBtOverrideTaskInfoBase(ByteBuffer _bb, ICommonBtOverrideTaskInfoBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C883 RID: 182403 RVA: 0x0061D491 File Offset: 0x0061B691
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C884 RID: 182404 RVA: 0x0061D4A0 File Offset: 0x0061B6A0
		public ICommonBtOverrideTaskInfoBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF54 RID: 48980
		// (get) Token: 0x0602C885 RID: 182405 RVA: 0x0061D4B0 File Offset: 0x0061B6B0
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

		// Token: 0x0602C886 RID: 182406 RVA: 0x0061D4EC File Offset: 0x0061B6EC
		public static Offset<ICommonBtOverrideTaskInfoBase> CreateICommonBtOverrideTaskInfoBase(FlatBufferBuilder builder, ECommonBtPlaceholderTargetType Type = ECommonBtPlaceholderTargetType.Action)
		{
			builder.StartTable(1);
			ICommonBtOverrideTaskInfoBase.AddType(builder, Type);
			return ICommonBtOverrideTaskInfoBase.EndICommonBtOverrideTaskInfoBase(builder);
		}

		// Token: 0x0602C887 RID: 182407 RVA: 0x0061D502 File Offset: 0x0061B702
		public static void StartICommonBtOverrideTaskInfoBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602C888 RID: 182408 RVA: 0x0061D50B File Offset: 0x0061B70B
		public static void AddType(FlatBufferBuilder builder, ECommonBtPlaceholderTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C889 RID: 182409 RVA: 0x0061D516 File Offset: 0x0061B716
		public static Offset<ICommonBtOverrideTaskInfoBase> EndICommonBtOverrideTaskInfoBase(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtOverrideTaskInfoBase>(builder.EndTable());
		}

		// Token: 0x0602C88A RID: 182410 RVA: 0x0061D524 File Offset: 0x0061B724
		public ICommonBtOverrideTaskInfoBaseT UnPack()
		{
			ICommonBtOverrideTaskInfoBaseT commonBtOverrideTaskInfoBaseT = new ICommonBtOverrideTaskInfoBaseT();
			this.UnPackTo(commonBtOverrideTaskInfoBaseT);
			return commonBtOverrideTaskInfoBaseT;
		}

		// Token: 0x0602C88B RID: 182411 RVA: 0x0061D53F File Offset: 0x0061B73F
		public void UnPackTo(ICommonBtOverrideTaskInfoBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602C88C RID: 182412 RVA: 0x0061D550 File Offset: 0x0061B750
		public static Offset<ICommonBtOverrideTaskInfoBase> Pack(FlatBufferBuilder builder, ICommonBtOverrideTaskInfoBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonBtOverrideTaskInfoBase>);
			}
			return ICommonBtOverrideTaskInfoBase.CreateICommonBtOverrideTaskInfoBase(builder, _o.Type);
		}

		// Token: 0x04010A6C RID: 68204
		private Table __p;
	}
}
