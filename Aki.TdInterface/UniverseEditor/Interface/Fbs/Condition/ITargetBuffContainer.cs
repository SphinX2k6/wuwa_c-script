using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051E1 RID: 20961
	public struct ITargetBuffContainer : IFlatbufferObject
	{
		// Token: 0x17009618 RID: 38424
		// (get) Token: 0x06021027 RID: 135207 RVA: 0x004903EE File Offset: 0x0048E5EE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021028 RID: 135208 RVA: 0x004903FB File Offset: 0x0048E5FB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021029 RID: 135209 RVA: 0x00490404 File Offset: 0x0048E604
		public static ITargetBuffContainer GetRootAsITargetBuffContainer(ByteBuffer _bb)
		{
			return ITargetBuffContainer.GetRootAsITargetBuffContainer(_bb, default(ITargetBuffContainer));
		}

		// Token: 0x0602102A RID: 135210 RVA: 0x00490420 File Offset: 0x0048E620
		public static ITargetBuffContainer GetRootAsITargetBuffContainer(ByteBuffer _bb, ITargetBuffContainer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602102B RID: 135211 RVA: 0x0049043D File Offset: 0x0048E63D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602102C RID: 135212 RVA: 0x0049044C File Offset: 0x0048E64C
		public ITargetBuffContainer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009619 RID: 38425
		// (get) Token: 0x0602102D RID: 135213 RVA: 0x0049045C File Offset: 0x0048E65C
		public ETargetBuffContainer Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetBuffContainer.Monster;
				}
				return (ETargetBuffContainer)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602102E RID: 135214 RVA: 0x00490498 File Offset: 0x0048E698
		public static Offset<ITargetBuffContainer> CreateITargetBuffContainer(FlatBufferBuilder builder, ETargetBuffContainer Type = ETargetBuffContainer.Monster)
		{
			builder.StartTable(1);
			ITargetBuffContainer.AddType(builder, Type);
			return ITargetBuffContainer.EndITargetBuffContainer(builder);
		}

		// Token: 0x0602102F RID: 135215 RVA: 0x004904AE File Offset: 0x0048E6AE
		public static void StartITargetBuffContainer(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06021030 RID: 135216 RVA: 0x004904B7 File Offset: 0x0048E6B7
		public static void AddType(FlatBufferBuilder builder, ETargetBuffContainer type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021031 RID: 135217 RVA: 0x004904C2 File Offset: 0x0048E6C2
		public static Offset<ITargetBuffContainer> EndITargetBuffContainer(FlatBufferBuilder builder)
		{
			return new Offset<ITargetBuffContainer>(builder.EndTable());
		}

		// Token: 0x06021032 RID: 135218 RVA: 0x004904D0 File Offset: 0x0048E6D0
		public ITargetBuffContainerT UnPack()
		{
			ITargetBuffContainerT targetBuffContainerT = new ITargetBuffContainerT();
			this.UnPackTo(targetBuffContainerT);
			return targetBuffContainerT;
		}

		// Token: 0x06021033 RID: 135219 RVA: 0x004904EB File Offset: 0x0048E6EB
		public void UnPackTo(ITargetBuffContainerT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06021034 RID: 135220 RVA: 0x004904FC File Offset: 0x0048E6FC
		public static Offset<ITargetBuffContainer> Pack(FlatBufferBuilder builder, ITargetBuffContainerT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITargetBuffContainer>);
			}
			return ITargetBuffContainer.CreateITargetBuffContainer(builder, _o.Type);
		}

		// Token: 0x0400E1E5 RID: 57829
		private Table __p;
	}
}
