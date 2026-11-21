using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AEF RID: 23279
	public struct IModelConfig : IFlatbufferObject
	{
		// Token: 0x1700A9E8 RID: 43496
		// (get) Token: 0x060263F4 RID: 156660 RVA: 0x0053DC0E File Offset: 0x0053BE0E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060263F5 RID: 156661 RVA: 0x0053DC1B File Offset: 0x0053BE1B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060263F6 RID: 156662 RVA: 0x0053DC24 File Offset: 0x0053BE24
		public static IModelConfig GetRootAsIModelConfig(ByteBuffer _bb)
		{
			return IModelConfig.GetRootAsIModelConfig(_bb, default(IModelConfig));
		}

		// Token: 0x060263F7 RID: 156663 RVA: 0x0053DC40 File Offset: 0x0053BE40
		public static IModelConfig GetRootAsIModelConfig(ByteBuffer _bb, IModelConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060263F8 RID: 156664 RVA: 0x0053DC5D File Offset: 0x0053BE5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060263F9 RID: 156665 RVA: 0x0053DC6C File Offset: 0x0053BE6C
		public IModelConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A9E9 RID: 43497
		// (get) Token: 0x060263FA RID: 156666 RVA: 0x0053DC7C File Offset: 0x0053BE7C
		public EModelType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EModelType.LevelPrefab;
				}
				return (EModelType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060263FB RID: 156667 RVA: 0x0053DCB8 File Offset: 0x0053BEB8
		public static Offset<IModelConfig> CreateIModelConfig(FlatBufferBuilder builder, EModelType Type = EModelType.LevelPrefab)
		{
			builder.StartTable(1);
			IModelConfig.AddType(builder, Type);
			return IModelConfig.EndIModelConfig(builder);
		}

		// Token: 0x060263FC RID: 156668 RVA: 0x0053DCCE File Offset: 0x0053BECE
		public static void StartIModelConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060263FD RID: 156669 RVA: 0x0053DCD7 File Offset: 0x0053BED7
		public static void AddType(FlatBufferBuilder builder, EModelType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060263FE RID: 156670 RVA: 0x0053DCE2 File Offset: 0x0053BEE2
		public static Offset<IModelConfig> EndIModelConfig(FlatBufferBuilder builder)
		{
			return new Offset<IModelConfig>(builder.EndTable());
		}

		// Token: 0x060263FF RID: 156671 RVA: 0x0053DCF0 File Offset: 0x0053BEF0
		public IModelConfigT UnPack()
		{
			IModelConfigT modelConfigT = new IModelConfigT();
			this.UnPackTo(modelConfigT);
			return modelConfigT;
		}

		// Token: 0x06026400 RID: 156672 RVA: 0x0053DD0B File Offset: 0x0053BF0B
		public void UnPackTo(IModelConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06026401 RID: 156673 RVA: 0x0053DD1C File Offset: 0x0053BF1C
		public static Offset<IModelConfig> Pack(FlatBufferBuilder builder, IModelConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IModelConfig>);
			}
			return IModelConfig.CreateIModelConfig(builder, _o.Type);
		}

		// Token: 0x0400F4C6 RID: 62662
		private Table __p;
	}
}
