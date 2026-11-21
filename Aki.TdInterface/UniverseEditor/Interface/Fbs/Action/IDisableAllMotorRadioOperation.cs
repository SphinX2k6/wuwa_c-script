using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C38 RID: 27704
	public struct IDisableAllMotorRadioOperation : IFlatbufferObject
	{
		// Token: 0x1700CAFB RID: 51963
		// (get) Token: 0x0602FABC RID: 195260 RVA: 0x0067E502 File Offset: 0x0067C702
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FABD RID: 195261 RVA: 0x0067E50F File Offset: 0x0067C70F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FABE RID: 195262 RVA: 0x0067E518 File Offset: 0x0067C718
		public static IDisableAllMotorRadioOperation GetRootAsIDisableAllMotorRadioOperation(ByteBuffer _bb)
		{
			return IDisableAllMotorRadioOperation.GetRootAsIDisableAllMotorRadioOperation(_bb, default(IDisableAllMotorRadioOperation));
		}

		// Token: 0x0602FABF RID: 195263 RVA: 0x0067E534 File Offset: 0x0067C734
		public static IDisableAllMotorRadioOperation GetRootAsIDisableAllMotorRadioOperation(ByteBuffer _bb, IDisableAllMotorRadioOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FAC0 RID: 195264 RVA: 0x0067E551 File Offset: 0x0067C751
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FAC1 RID: 195265 RVA: 0x0067E560 File Offset: 0x0067C760
		public IDisableAllMotorRadioOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CAFC RID: 51964
		// (get) Token: 0x0602FAC2 RID: 195266 RVA: 0x0067E570 File Offset: 0x0067C770
		public EMotorRadioOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMotorRadioOperationType.EnableAll;
				}
				return (EMotorRadioOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FAC3 RID: 195267 RVA: 0x0067E5AC File Offset: 0x0067C7AC
		public static Offset<IDisableAllMotorRadioOperation> CreateIDisableAllMotorRadioOperation(FlatBufferBuilder builder, EMotorRadioOperationType Type = EMotorRadioOperationType.EnableAll)
		{
			builder.StartTable(1);
			IDisableAllMotorRadioOperation.AddType(builder, Type);
			return IDisableAllMotorRadioOperation.EndIDisableAllMotorRadioOperation(builder);
		}

		// Token: 0x0602FAC4 RID: 195268 RVA: 0x0067E5C2 File Offset: 0x0067C7C2
		public static void StartIDisableAllMotorRadioOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602FAC5 RID: 195269 RVA: 0x0067E5CB File Offset: 0x0067C7CB
		public static void AddType(FlatBufferBuilder builder, EMotorRadioOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FAC6 RID: 195270 RVA: 0x0067E5D6 File Offset: 0x0067C7D6
		public static Offset<IDisableAllMotorRadioOperation> EndIDisableAllMotorRadioOperation(FlatBufferBuilder builder)
		{
			return new Offset<IDisableAllMotorRadioOperation>(builder.EndTable());
		}

		// Token: 0x0602FAC7 RID: 195271 RVA: 0x0067E5E4 File Offset: 0x0067C7E4
		public IDisableAllMotorRadioOperationT UnPack()
		{
			IDisableAllMotorRadioOperationT disableAllMotorRadioOperationT = new IDisableAllMotorRadioOperationT();
			this.UnPackTo(disableAllMotorRadioOperationT);
			return disableAllMotorRadioOperationT;
		}

		// Token: 0x0602FAC8 RID: 195272 RVA: 0x0067E5FF File Offset: 0x0067C7FF
		public void UnPackTo(IDisableAllMotorRadioOperationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602FAC9 RID: 195273 RVA: 0x0067E610 File Offset: 0x0067C810
		public static Offset<IDisableAllMotorRadioOperation> Pack(FlatBufferBuilder builder, IDisableAllMotorRadioOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableAllMotorRadioOperation>);
			}
			return IDisableAllMotorRadioOperation.CreateIDisableAllMotorRadioOperation(builder, _o.Type);
		}

		// Token: 0x04011A43 RID: 72259
		private Table __p;
	}
}
