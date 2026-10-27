using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062A2 RID: 25250
	public struct ICameraShakeConfig : IFlatbufferObject
	{
		// Token: 0x1700BC7E RID: 48254
		// (get) Token: 0x0602BA0F RID: 178703 RVA: 0x0060189C File Offset: 0x005FFA9C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BA10 RID: 178704 RVA: 0x006018A9 File Offset: 0x005FFAA9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BA11 RID: 178705 RVA: 0x006018B0 File Offset: 0x005FFAB0
		public static ICameraShakeConfig GetRootAsICameraShakeConfig(ByteBuffer _bb)
		{
			return ICameraShakeConfig.GetRootAsICameraShakeConfig(_bb, default(ICameraShakeConfig));
		}

		// Token: 0x0602BA12 RID: 178706 RVA: 0x006018CC File Offset: 0x005FFACC
		public static ICameraShakeConfig GetRootAsICameraShakeConfig(ByteBuffer _bb, ICameraShakeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BA13 RID: 178707 RVA: 0x006018E9 File Offset: 0x005FFAE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BA14 RID: 178708 RVA: 0x006018F8 File Offset: 0x005FFAF8
		public ICameraShakeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC7F RID: 48255
		// (get) Token: 0x0602BA15 RID: 178709 RVA: 0x00601908 File Offset: 0x005FFB08
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

		// Token: 0x0602BA16 RID: 178710 RVA: 0x00601944 File Offset: 0x005FFB44
		public static Offset<ICameraShakeConfig> CreateICameraShakeConfig(FlatBufferBuilder builder, ECameraShakeType Type = ECameraShakeType.Constant)
		{
			builder.StartTable(1);
			ICameraShakeConfig.AddType(builder, Type);
			return ICameraShakeConfig.EndICameraShakeConfig(builder);
		}

		// Token: 0x0602BA17 RID: 178711 RVA: 0x0060195A File Offset: 0x005FFB5A
		public static void StartICameraShakeConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602BA18 RID: 178712 RVA: 0x00601963 File Offset: 0x005FFB63
		public static void AddType(FlatBufferBuilder builder, ECameraShakeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BA19 RID: 178713 RVA: 0x0060196E File Offset: 0x005FFB6E
		public static Offset<ICameraShakeConfig> EndICameraShakeConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICameraShakeConfig>(builder.EndTable());
		}

		// Token: 0x0602BA1A RID: 178714 RVA: 0x0060197C File Offset: 0x005FFB7C
		public ICameraShakeConfigT UnPack()
		{
			ICameraShakeConfigT cameraShakeConfigT = new ICameraShakeConfigT();
			this.UnPackTo(cameraShakeConfigT);
			return cameraShakeConfigT;
		}

		// Token: 0x0602BA1B RID: 178715 RVA: 0x00601997 File Offset: 0x005FFB97
		public void UnPackTo(ICameraShakeConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602BA1C RID: 178716 RVA: 0x006019A8 File Offset: 0x005FFBA8
		public static Offset<ICameraShakeConfig> Pack(FlatBufferBuilder builder, ICameraShakeConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICameraShakeConfig>);
			}
			return ICameraShakeConfig.CreateICameraShakeConfig(builder, _o.Type);
		}

		// Token: 0x04010839 RID: 67641
		private Table __p;
	}
}
