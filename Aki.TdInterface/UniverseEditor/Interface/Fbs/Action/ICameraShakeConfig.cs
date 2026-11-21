using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006913 RID: 26899
	public struct ICameraShakeConfig : IFlatbufferObject
	{
		// Token: 0x1700C606 RID: 50694
		// (get) Token: 0x0602E170 RID: 188784 RVA: 0x0064C6A4 File Offset: 0x0064A8A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E171 RID: 188785 RVA: 0x0064C6B1 File Offset: 0x0064A8B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E172 RID: 188786 RVA: 0x0064C6B8 File Offset: 0x0064A8B8
		public static ICameraShakeConfig GetRootAsICameraShakeConfig(ByteBuffer _bb)
		{
			return ICameraShakeConfig.GetRootAsICameraShakeConfig(_bb, default(ICameraShakeConfig));
		}

		// Token: 0x0602E173 RID: 188787 RVA: 0x0064C6D4 File Offset: 0x0064A8D4
		public static ICameraShakeConfig GetRootAsICameraShakeConfig(ByteBuffer _bb, ICameraShakeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E174 RID: 188788 RVA: 0x0064C6F1 File Offset: 0x0064A8F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E175 RID: 188789 RVA: 0x0064C700 File Offset: 0x0064A900
		public ICameraShakeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C607 RID: 50695
		// (get) Token: 0x0602E176 RID: 188790 RVA: 0x0064C710 File Offset: 0x0064A910
		public ECameraShakeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECameraShakeType.Constant;
				}
				return (ECameraShakeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E177 RID: 188791 RVA: 0x0064C74C File Offset: 0x0064A94C
		public static Offset<ICameraShakeConfig> CreateICameraShakeConfig(FlatBufferBuilder builder, ECameraShakeType Type = ECameraShakeType.Constant)
		{
			builder.StartTable(1);
			ICameraShakeConfig.AddType(builder, Type);
			return ICameraShakeConfig.EndICameraShakeConfig(builder);
		}

		// Token: 0x0602E178 RID: 188792 RVA: 0x0064C762 File Offset: 0x0064A962
		public static void StartICameraShakeConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E179 RID: 188793 RVA: 0x0064C76B File Offset: 0x0064A96B
		public static void AddType(FlatBufferBuilder builder, ECameraShakeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E17A RID: 188794 RVA: 0x0064C776 File Offset: 0x0064A976
		public static Offset<ICameraShakeConfig> EndICameraShakeConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICameraShakeConfig>(builder.EndTable());
		}

		// Token: 0x0602E17B RID: 188795 RVA: 0x0064C784 File Offset: 0x0064A984
		public ICameraShakeConfigT UnPack()
		{
			ICameraShakeConfigT cameraShakeConfigT = new ICameraShakeConfigT();
			this.UnPackTo(cameraShakeConfigT);
			return cameraShakeConfigT;
		}

		// Token: 0x0602E17C RID: 188796 RVA: 0x0064C79F File Offset: 0x0064A99F
		public void UnPackTo(ICameraShakeConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602E17D RID: 188797 RVA: 0x0064C7B0 File Offset: 0x0064A9B0
		public static Offset<ICameraShakeConfig> Pack(FlatBufferBuilder builder, ICameraShakeConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICameraShakeConfig>);
			}
			return ICameraShakeConfig.CreateICameraShakeConfig(builder, _o.Type);
		}

		// Token: 0x0401164E RID: 71246
		private Table __p;
	}
}
