using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005915 RID: 22805
	public struct IHitLogicChangeByPartHit : IFlatbufferObject
	{
		// Token: 0x1700A56B RID: 42347
		// (get) Token: 0x0602512E RID: 151854 RVA: 0x00516BE8 File Offset: 0x00514DE8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602512F RID: 151855 RVA: 0x00516BF5 File Offset: 0x00514DF5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025130 RID: 151856 RVA: 0x00516BFC File Offset: 0x00514DFC
		public static IHitLogicChangeByPartHit GetRootAsIHitLogicChangeByPartHit(ByteBuffer _bb)
		{
			return IHitLogicChangeByPartHit.GetRootAsIHitLogicChangeByPartHit(_bb, default(IHitLogicChangeByPartHit));
		}

		// Token: 0x06025131 RID: 151857 RVA: 0x00516C18 File Offset: 0x00514E18
		public static IHitLogicChangeByPartHit GetRootAsIHitLogicChangeByPartHit(ByteBuffer _bb, IHitLogicChangeByPartHit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025132 RID: 151858 RVA: 0x00516C35 File Offset: 0x00514E35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025133 RID: 151859 RVA: 0x00516C44 File Offset: 0x00514E44
		public IHitLogicChangeByPartHit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A56C RID: 42348
		// (get) Token: 0x06025134 RID: 151860 RVA: 0x00516C54 File Offset: 0x00514E54
		public EHitLogicType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHitLogicType.ChangeNextState;
				}
				return (EHitLogicType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025135 RID: 151861 RVA: 0x00516C90 File Offset: 0x00514E90
		public IPartHitConfig? PartHitConfig(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IPartHitConfig?(default(IPartHitConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A56D RID: 42349
		// (get) Token: 0x06025136 RID: 151862 RVA: 0x00516CF0 File Offset: 0x00514EF0
		public int PartHitConfigLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06025137 RID: 151863 RVA: 0x00516D1B File Offset: 0x00514F1B
		public static Offset<IHitLogicChangeByPartHit> CreateIHitLogicChangeByPartHit(FlatBufferBuilder builder, EHitLogicType Type = EHitLogicType.ChangeNextState, VectorOffset PartHitConfigOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IHitLogicChangeByPartHit.AddPartHitConfig(builder, PartHitConfigOffset);
			IHitLogicChangeByPartHit.AddType(builder, Type);
			return IHitLogicChangeByPartHit.EndIHitLogicChangeByPartHit(builder);
		}

		// Token: 0x06025138 RID: 151864 RVA: 0x00516D38 File Offset: 0x00514F38
		public static void StartIHitLogicChangeByPartHit(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06025139 RID: 151865 RVA: 0x00516D41 File Offset: 0x00514F41
		public static void AddType(FlatBufferBuilder builder, EHitLogicType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602513A RID: 151866 RVA: 0x00516D4C File Offset: 0x00514F4C
		public static void AddPartHitConfig(FlatBufferBuilder builder, VectorOffset partHitConfigOffset)
		{
			builder.AddOffset(1, partHitConfigOffset.Value, 0);
		}

		// Token: 0x0602513B RID: 151867 RVA: 0x00516D5C File Offset: 0x00514F5C
		public static VectorOffset CreatePartHitConfigVector(FlatBufferBuilder builder, Offset<IPartHitConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602513C RID: 151868 RVA: 0x00516D9C File Offset: 0x00514F9C
		public static VectorOffset CreatePartHitConfigVectorBlock(FlatBufferBuilder builder, Offset<IPartHitConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPartHitConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602513D RID: 151869 RVA: 0x00516DB6 File Offset: 0x00514FB6
		public static VectorOffset CreatePartHitConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPartHitConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPartHitConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602513E RID: 151870 RVA: 0x00516DD4 File Offset: 0x00514FD4
		public static VectorOffset CreatePartHitConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPartHitConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602513F RID: 151871 RVA: 0x00516DED File Offset: 0x00514FED
		public static void StartPartHitConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025140 RID: 151872 RVA: 0x00516DF8 File Offset: 0x00514FF8
		public static Offset<IHitLogicChangeByPartHit> EndIHitLogicChangeByPartHit(FlatBufferBuilder builder)
		{
			return new Offset<IHitLogicChangeByPartHit>(builder.EndTable());
		}

		// Token: 0x06025141 RID: 151873 RVA: 0x00516E08 File Offset: 0x00515008
		public IHitLogicChangeByPartHitT UnPack()
		{
			IHitLogicChangeByPartHitT hitLogicChangeByPartHitT = new IHitLogicChangeByPartHitT();
			this.UnPackTo(hitLogicChangeByPartHitT);
			return hitLogicChangeByPartHitT;
		}

		// Token: 0x06025142 RID: 151874 RVA: 0x00516E24 File Offset: 0x00515024
		public void UnPackTo(IHitLogicChangeByPartHitT _o)
		{
			_o.Type = this.Type;
			_o.PartHitConfig = new List<IPartHitConfigT>();
			for (int i = 0; i < this.PartHitConfigLength; i++)
			{
				_o.PartHitConfig.Add((this.PartHitConfig(i) != null) ? this.PartHitConfig(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06025143 RID: 151875 RVA: 0x00516E90 File Offset: 0x00515090
		public static Offset<IHitLogicChangeByPartHit> Pack(FlatBufferBuilder builder, IHitLogicChangeByPartHitT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHitLogicChangeByPartHit>);
			}
			VectorOffset partHitConfigOffset = default(VectorOffset);
			if (_o.PartHitConfig != null)
			{
				Offset<IPartHitConfig>[] array = new Offset<IPartHitConfig>[_o.PartHitConfig.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IPartHitConfig.Pack(builder, _o.PartHitConfig[i]);
				}
				partHitConfigOffset = IHitLogicChangeByPartHit.CreatePartHitConfigVector(builder, array);
			}
			return IHitLogicChangeByPartHit.CreateIHitLogicChangeByPartHit(builder, _o.Type, partHitConfigOffset);
		}

		// Token: 0x0400F1AB RID: 61867
		private Table __p;
	}
}
