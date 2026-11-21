using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C68 RID: 27752
	public struct IDisableUiOperation : IFlatbufferObject
	{
		// Token: 0x1700CB91 RID: 52113
		// (get) Token: 0x0602FCD4 RID: 195796 RVA: 0x006828C8 File Offset: 0x00680AC8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FCD5 RID: 195797 RVA: 0x006828D5 File Offset: 0x00680AD5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FCD6 RID: 195798 RVA: 0x006828DC File Offset: 0x00680ADC
		public static IDisableUiOperation GetRootAsIDisableUiOperation(ByteBuffer _bb)
		{
			return IDisableUiOperation.GetRootAsIDisableUiOperation(_bb, default(IDisableUiOperation));
		}

		// Token: 0x0602FCD7 RID: 195799 RVA: 0x006828F8 File Offset: 0x00680AF8
		public static IDisableUiOperation GetRootAsIDisableUiOperation(ByteBuffer _bb, IDisableUiOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FCD8 RID: 195800 RVA: 0x00682915 File Offset: 0x00680B15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FCD9 RID: 195801 RVA: 0x00682924 File Offset: 0x00680B24
		public IDisableUiOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CB92 RID: 52114
		// (get) Token: 0x0602FCDA RID: 195802 RVA: 0x00682934 File Offset: 0x00680B34
		public EUiOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EUiOperationType.Enable;
				}
				return (EUiOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FCDB RID: 195803 RVA: 0x00682970 File Offset: 0x00680B70
		public static Offset<IDisableUiOperation> CreateIDisableUiOperation(FlatBufferBuilder builder, EUiOperationType Type = EUiOperationType.Enable)
		{
			builder.StartTable(1);
			IDisableUiOperation.AddType(builder, Type);
			return IDisableUiOperation.EndIDisableUiOperation(builder);
		}

		// Token: 0x0602FCDC RID: 195804 RVA: 0x00682986 File Offset: 0x00680B86
		public static void StartIDisableUiOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602FCDD RID: 195805 RVA: 0x0068298F File Offset: 0x00680B8F
		public static void AddType(FlatBufferBuilder builder, EUiOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FCDE RID: 195806 RVA: 0x0068299A File Offset: 0x00680B9A
		public static Offset<IDisableUiOperation> EndIDisableUiOperation(FlatBufferBuilder builder)
		{
			return new Offset<IDisableUiOperation>(builder.EndTable());
		}

		// Token: 0x0602FCDF RID: 195807 RVA: 0x006829A8 File Offset: 0x00680BA8
		public IDisableUiOperationT UnPack()
		{
			IDisableUiOperationT disableUiOperationT = new IDisableUiOperationT();
			this.UnPackTo(disableUiOperationT);
			return disableUiOperationT;
		}

		// Token: 0x0602FCE0 RID: 195808 RVA: 0x006829C3 File Offset: 0x00680BC3
		public void UnPackTo(IDisableUiOperationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602FCE1 RID: 195809 RVA: 0x006829D4 File Offset: 0x00680BD4
		public static Offset<IDisableUiOperation> Pack(FlatBufferBuilder builder, IDisableUiOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableUiOperation>);
			}
			return IDisableUiOperation.CreateIDisableUiOperation(builder, _o.Type);
		}

		// Token: 0x04011A96 RID: 72342
		private Table __p;
	}
}
