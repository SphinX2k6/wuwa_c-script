using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200762A RID: 30250
	public struct IResetPosType : IFlatbufferObject
	{
		// Token: 0x1700DE3C RID: 56892
		// (get) Token: 0x06035143 RID: 217411 RVA: 0x0072108D File Offset: 0x0071F28D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035144 RID: 217412 RVA: 0x0072109A File Offset: 0x0071F29A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035145 RID: 217413 RVA: 0x007210A4 File Offset: 0x0071F2A4
		public static IResetPosType GetRootAsIResetPosType(ByteBuffer _bb)
		{
			return IResetPosType.GetRootAsIResetPosType(_bb, default(IResetPosType));
		}

		// Token: 0x06035146 RID: 217414 RVA: 0x007210C0 File Offset: 0x0071F2C0
		public static IResetPosType GetRootAsIResetPosType(ByteBuffer _bb, IResetPosType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035147 RID: 217415 RVA: 0x007210DD File Offset: 0x0071F2DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035148 RID: 217416 RVA: 0x007210EC File Offset: 0x0071F2EC
		public IResetPosType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DE3D RID: 56893
		// (get) Token: 0x06035149 RID: 217417 RVA: 0x007210FC File Offset: 0x0071F2FC
		public EResetPosType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EResetPosType.PosEntity;
				}
				return (EResetPosType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603514A RID: 217418 RVA: 0x00721138 File Offset: 0x0071F338
		public static Offset<IResetPosType> CreateIResetPosType(FlatBufferBuilder builder, EResetPosType Type = EResetPosType.PosEntity)
		{
			builder.StartTable(1);
			IResetPosType.AddType(builder, Type);
			return IResetPosType.EndIResetPosType(builder);
		}

		// Token: 0x0603514B RID: 217419 RVA: 0x0072114E File Offset: 0x0071F34E
		public static void StartIResetPosType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603514C RID: 217420 RVA: 0x00721157 File Offset: 0x0071F357
		public static void AddType(FlatBufferBuilder builder, EResetPosType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603514D RID: 217421 RVA: 0x00721162 File Offset: 0x0071F362
		public static Offset<IResetPosType> EndIResetPosType(FlatBufferBuilder builder)
		{
			return new Offset<IResetPosType>(builder.EndTable());
		}

		// Token: 0x0603514E RID: 217422 RVA: 0x00721170 File Offset: 0x0071F370
		public IResetPosTypeT UnPack()
		{
			IResetPosTypeT resetPosTypeT = new IResetPosTypeT();
			this.UnPackTo(resetPosTypeT);
			return resetPosTypeT;
		}

		// Token: 0x0603514F RID: 217423 RVA: 0x0072118B File Offset: 0x0071F38B
		public void UnPackTo(IResetPosTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06035150 RID: 217424 RVA: 0x0072119C File Offset: 0x0071F39C
		public static Offset<IResetPosType> Pack(FlatBufferBuilder builder, IResetPosTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IResetPosType>);
			}
			return IResetPosType.CreateIResetPosType(builder, _o.Type);
		}

		// Token: 0x0401281D RID: 75805
		private Table __p;
	}
}
