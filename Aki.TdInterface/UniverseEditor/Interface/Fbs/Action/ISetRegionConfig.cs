using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200782A RID: 30762
	public struct ISetRegionConfig : IFlatbufferObject
	{
		// Token: 0x1700E1B8 RID: 57784
		// (get) Token: 0x06036197 RID: 221591 RVA: 0x0073FA0F File Offset: 0x0073DC0F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036198 RID: 221592 RVA: 0x0073FA1C File Offset: 0x0073DC1C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036199 RID: 221593 RVA: 0x0073FA24 File Offset: 0x0073DC24
		public static ISetRegionConfig GetRootAsISetRegionConfig(ByteBuffer _bb)
		{
			return ISetRegionConfig.GetRootAsISetRegionConfig(_bb, default(ISetRegionConfig));
		}

		// Token: 0x0603619A RID: 221594 RVA: 0x0073FA40 File Offset: 0x0073DC40
		public static ISetRegionConfig GetRootAsISetRegionConfig(ByteBuffer _bb, ISetRegionConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603619B RID: 221595 RVA: 0x0073FA5D File Offset: 0x0073DC5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603619C RID: 221596 RVA: 0x0073FA6C File Offset: 0x0073DC6C
		public ISetRegionConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E1B9 RID: 57785
		// (get) Token: 0x0603619D RID: 221597 RVA: 0x0073FA7C File Offset: 0x0073DC7C
		public ERegionConfigType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERegionConfigType.Mpc;
				}
				return (ERegionConfigType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603619E RID: 221598 RVA: 0x0073FAB8 File Offset: 0x0073DCB8
		public static Offset<ISetRegionConfig> CreateISetRegionConfig(FlatBufferBuilder builder, ERegionConfigType Type = ERegionConfigType.Mpc)
		{
			builder.StartTable(1);
			ISetRegionConfig.AddType(builder, Type);
			return ISetRegionConfig.EndISetRegionConfig(builder);
		}

		// Token: 0x0603619F RID: 221599 RVA: 0x0073FACE File Offset: 0x0073DCCE
		public static void StartISetRegionConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060361A0 RID: 221600 RVA: 0x0073FAD7 File Offset: 0x0073DCD7
		public static void AddType(FlatBufferBuilder builder, ERegionConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060361A1 RID: 221601 RVA: 0x0073FAE2 File Offset: 0x0073DCE2
		public static Offset<ISetRegionConfig> EndISetRegionConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISetRegionConfig>(builder.EndTable());
		}

		// Token: 0x060361A2 RID: 221602 RVA: 0x0073FAF0 File Offset: 0x0073DCF0
		public ISetRegionConfigT UnPack()
		{
			ISetRegionConfigT setRegionConfigT = new ISetRegionConfigT();
			this.UnPackTo(setRegionConfigT);
			return setRegionConfigT;
		}

		// Token: 0x060361A3 RID: 221603 RVA: 0x0073FB0B File Offset: 0x0073DD0B
		public void UnPackTo(ISetRegionConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060361A4 RID: 221604 RVA: 0x0073FB1C File Offset: 0x0073DD1C
		public static Offset<ISetRegionConfig> Pack(FlatBufferBuilder builder, ISetRegionConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetRegionConfig>);
			}
			return ISetRegionConfig.CreateISetRegionConfig(builder, _o.Type);
		}

		// Token: 0x04012AAD RID: 76461
		private Table __p;
	}
}
