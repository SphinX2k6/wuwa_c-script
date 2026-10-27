using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005162 RID: 20834
	public struct IEntityBatchType : IFlatbufferObject
	{
		// Token: 0x170097FA RID: 38906
		// (get) Token: 0x06021A3C RID: 137788 RVA: 0x004AB32A File Offset: 0x004A952A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021A3D RID: 137789 RVA: 0x004AB337 File Offset: 0x004A9537
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021A3E RID: 137790 RVA: 0x004AB340 File Offset: 0x004A9540
		public static IEntityBatchType GetRootAsIEntityBatchType(ByteBuffer _bb)
		{
			return IEntityBatchType.GetRootAsIEntityBatchType(_bb, default(IEntityBatchType));
		}

		// Token: 0x06021A3F RID: 137791 RVA: 0x004AB35C File Offset: 0x004A955C
		public static IEntityBatchType GetRootAsIEntityBatchType(ByteBuffer _bb, IEntityBatchType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021A40 RID: 137792 RVA: 0x004AB379 File Offset: 0x004A9579
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021A41 RID: 137793 RVA: 0x004AB388 File Offset: 0x004A9588
		public IEntityBatchType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170097FB RID: 38907
		// (get) Token: 0x06021A42 RID: 137794 RVA: 0x004AB398 File Offset: 0x004A9598
		public EEntityBatchType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEntityBatchType.EntityList;
				}
				return (EEntityBatchType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021A43 RID: 137795 RVA: 0x004AB3D4 File Offset: 0x004A95D4
		public static Offset<IEntityBatchType> CreateIEntityBatchType(FlatBufferBuilder builder, EEntityBatchType Type = EEntityBatchType.EntityList)
		{
			builder.StartTable(1);
			IEntityBatchType.AddType(builder, Type);
			return IEntityBatchType.EndIEntityBatchType(builder);
		}

		// Token: 0x06021A44 RID: 137796 RVA: 0x004AB3EA File Offset: 0x004A95EA
		public static void StartIEntityBatchType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06021A45 RID: 137797 RVA: 0x004AB3F3 File Offset: 0x004A95F3
		public static void AddType(FlatBufferBuilder builder, EEntityBatchType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021A46 RID: 137798 RVA: 0x004AB3FE File Offset: 0x004A95FE
		public static Offset<IEntityBatchType> EndIEntityBatchType(FlatBufferBuilder builder)
		{
			return new Offset<IEntityBatchType>(builder.EndTable());
		}

		// Token: 0x06021A47 RID: 137799 RVA: 0x004AB40C File Offset: 0x004A960C
		public IEntityBatchTypeT UnPack()
		{
			IEntityBatchTypeT entityBatchTypeT = new IEntityBatchTypeT();
			this.UnPackTo(entityBatchTypeT);
			return entityBatchTypeT;
		}

		// Token: 0x06021A48 RID: 137800 RVA: 0x004AB427 File Offset: 0x004A9627
		public void UnPackTo(IEntityBatchTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06021A49 RID: 137801 RVA: 0x004AB438 File Offset: 0x004A9638
		public static Offset<IEntityBatchType> Pack(FlatBufferBuilder builder, IEntityBatchTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityBatchType>);
			}
			return IEntityBatchType.CreateIEntityBatchType(builder, _o.Type);
		}

		// Token: 0x0400E20A RID: 57866
		private Table __p;
	}
}
