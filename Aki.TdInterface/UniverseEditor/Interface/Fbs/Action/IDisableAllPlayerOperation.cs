using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C3B RID: 27707
	public struct IDisableAllPlayerOperation : IFlatbufferObject
	{
		// Token: 0x1700CAFE RID: 51966
		// (get) Token: 0x0602FACE RID: 195278 RVA: 0x0067E679 File Offset: 0x0067C879
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FACF RID: 195279 RVA: 0x0067E686 File Offset: 0x0067C886
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FAD0 RID: 195280 RVA: 0x0067E690 File Offset: 0x0067C890
		public static IDisableAllPlayerOperation GetRootAsIDisableAllPlayerOperation(ByteBuffer _bb)
		{
			return IDisableAllPlayerOperation.GetRootAsIDisableAllPlayerOperation(_bb, default(IDisableAllPlayerOperation));
		}

		// Token: 0x0602FAD1 RID: 195281 RVA: 0x0067E6AC File Offset: 0x0067C8AC
		public static IDisableAllPlayerOperation GetRootAsIDisableAllPlayerOperation(ByteBuffer _bb, IDisableAllPlayerOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FAD2 RID: 195282 RVA: 0x0067E6C9 File Offset: 0x0067C8C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FAD3 RID: 195283 RVA: 0x0067E6D8 File Offset: 0x0067C8D8
		public IDisableAllPlayerOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CAFF RID: 51967
		// (get) Token: 0x0602FAD4 RID: 195284 RVA: 0x0067E6E8 File Offset: 0x0067C8E8
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

		// Token: 0x1700CB00 RID: 51968
		// (get) Token: 0x0602FAD5 RID: 195285 RVA: 0x0067E724 File Offset: 0x0067C924
		public EDisplayModeInPlayerOp DisplayMode
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EDisplayModeInPlayerOp.ShowUi;
				}
				return (EDisplayModeInPlayerOp)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CB01 RID: 51969
		// (get) Token: 0x0602FAD6 RID: 195286 RVA: 0x0067E760 File Offset: 0x0067C960
		public bool IsUiFadeEffect
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CB02 RID: 51970
		// (get) Token: 0x0602FAD7 RID: 195287 RVA: 0x0067E7A0 File Offset: 0x0067C9A0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FAD8 RID: 195288 RVA: 0x0067E7DD File Offset: 0x0067C9DD
		public static Offset<IDisableAllPlayerOperation> CreateIDisableAllPlayerOperation(FlatBufferBuilder builder, EPlayerOperationType Type = EPlayerOperationType.EnableAll, EDisplayModeInPlayerOp DisplayMode = EDisplayModeInPlayerOp.ShowUi, bool IsUiFadeEffect = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IDisableAllPlayerOperation.AddNullMask(builder, NullMask);
			IDisableAllPlayerOperation.AddIsUiFadeEffect(builder, IsUiFadeEffect);
			IDisableAllPlayerOperation.AddDisplayMode(builder, DisplayMode);
			IDisableAllPlayerOperation.AddType(builder, Type);
			return IDisableAllPlayerOperation.EndIDisableAllPlayerOperation(builder);
		}

		// Token: 0x0602FAD9 RID: 195289 RVA: 0x0067E809 File Offset: 0x0067CA09
		public static void StartIDisableAllPlayerOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602FADA RID: 195290 RVA: 0x0067E812 File Offset: 0x0067CA12
		public static void AddType(FlatBufferBuilder builder, EPlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FADB RID: 195291 RVA: 0x0067E81D File Offset: 0x0067CA1D
		public static void AddDisplayMode(FlatBufferBuilder builder, EDisplayModeInPlayerOp displayMode)
		{
			builder.AddByte(1, (byte)displayMode, 0);
		}

		// Token: 0x0602FADC RID: 195292 RVA: 0x0067E828 File Offset: 0x0067CA28
		public static void AddIsUiFadeEffect(FlatBufferBuilder builder, bool isUiFadeEffect)
		{
			builder.AddBool(2, isUiFadeEffect, false);
		}

		// Token: 0x0602FADD RID: 195293 RVA: 0x0067E833 File Offset: 0x0067CA33
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602FADE RID: 195294 RVA: 0x0067E83E File Offset: 0x0067CA3E
		public static Offset<IDisableAllPlayerOperation> EndIDisableAllPlayerOperation(FlatBufferBuilder builder)
		{
			return new Offset<IDisableAllPlayerOperation>(builder.EndTable());
		}

		// Token: 0x0602FADF RID: 195295 RVA: 0x0067E84C File Offset: 0x0067CA4C
		public IDisableAllPlayerOperationT UnPack()
		{
			IDisableAllPlayerOperationT disableAllPlayerOperationT = new IDisableAllPlayerOperationT();
			this.UnPackTo(disableAllPlayerOperationT);
			return disableAllPlayerOperationT;
		}

		// Token: 0x0602FAE0 RID: 195296 RVA: 0x0067E867 File Offset: 0x0067CA67
		public void UnPackTo(IDisableAllPlayerOperationT _o)
		{
			_o.Type = this.Type;
			_o.DisplayMode = this.DisplayMode;
			_o.IsUiFadeEffect = this.IsUiFadeEffect;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602FAE1 RID: 195297 RVA: 0x0067E89C File Offset: 0x0067CA9C
		public static Offset<IDisableAllPlayerOperation> Pack(FlatBufferBuilder builder, IDisableAllPlayerOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableAllPlayerOperation>);
			}
			return IDisableAllPlayerOperation.CreateIDisableAllPlayerOperation(builder, _o.Type, _o.DisplayMode, _o.IsUiFadeEffect, _o.NullMask);
		}

		// Token: 0x04011A45 RID: 72261
		private Table __p;
	}
}
