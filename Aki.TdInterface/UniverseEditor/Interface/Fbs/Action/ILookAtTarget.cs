using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A5F RID: 27231
	public struct ILookAtTarget : IFlatbufferObject
	{
		// Token: 0x1700CA04 RID: 51716
		// (get) Token: 0x0602FAF6 RID: 195318 RVA: 0x0067D588 File Offset: 0x0067B788
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FAF7 RID: 195319 RVA: 0x0067D595 File Offset: 0x0067B795
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FAF8 RID: 195320 RVA: 0x0067D59C File Offset: 0x0067B79C
		public static ILookAtTarget GetRootAsILookAtTarget(ByteBuffer _bb)
		{
			return ILookAtTarget.GetRootAsILookAtTarget(_bb, default(ILookAtTarget));
		}

		// Token: 0x0602FAF9 RID: 195321 RVA: 0x0067D5B8 File Offset: 0x0067B7B8
		public static ILookAtTarget GetRootAsILookAtTarget(ByteBuffer _bb, ILookAtTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FAFA RID: 195322 RVA: 0x0067D5D5 File Offset: 0x0067B7D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FAFB RID: 195323 RVA: 0x0067D5E4 File Offset: 0x0067B7E4
		public ILookAtTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA05 RID: 51717
		// (get) Token: 0x0602FAFC RID: 195324 RVA: 0x0067D5F4 File Offset: 0x0067B7F4
		public EDefaultLookAtType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDefaultLookAtType.LookAtBubbleEntity;
				}
				return (EDefaultLookAtType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FAFD RID: 195325 RVA: 0x0067D630 File Offset: 0x0067B830
		public INpcLookAtConfig? LookAtConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new INpcLookAtConfig?(default(INpcLookAtConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700CA06 RID: 51718
		// (get) Token: 0x0602FAFE RID: 195326 RVA: 0x0067D690 File Offset: 0x0067B890
		public int LookAtConfigsLength
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

		// Token: 0x0602FAFF RID: 195327 RVA: 0x0067D6BB File Offset: 0x0067B8BB
		public static Offset<ILookAtTarget> CreateILookAtTarget(FlatBufferBuilder builder, EDefaultLookAtType Type = EDefaultLookAtType.LookAtBubbleEntity, VectorOffset LookAtConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ILookAtTarget.AddLookAtConfigs(builder, LookAtConfigsOffset);
			ILookAtTarget.AddType(builder, Type);
			return ILookAtTarget.EndILookAtTarget(builder);
		}

		// Token: 0x0602FB00 RID: 195328 RVA: 0x0067D6D8 File Offset: 0x0067B8D8
		public static void StartILookAtTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602FB01 RID: 195329 RVA: 0x0067D6E1 File Offset: 0x0067B8E1
		public static void AddType(FlatBufferBuilder builder, EDefaultLookAtType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FB02 RID: 195330 RVA: 0x0067D6EC File Offset: 0x0067B8EC
		public static void AddLookAtConfigs(FlatBufferBuilder builder, VectorOffset lookAtConfigsOffset)
		{
			builder.AddOffset(1, lookAtConfigsOffset.Value, 0);
		}

		// Token: 0x0602FB03 RID: 195331 RVA: 0x0067D6FC File Offset: 0x0067B8FC
		public static VectorOffset CreateLookAtConfigsVector(FlatBufferBuilder builder, Offset<INpcLookAtConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602FB04 RID: 195332 RVA: 0x0067D73C File Offset: 0x0067B93C
		public static VectorOffset CreateLookAtConfigsVectorBlock(FlatBufferBuilder builder, Offset<INpcLookAtConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<INpcLookAtConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602FB05 RID: 195333 RVA: 0x0067D756 File Offset: 0x0067B956
		public static VectorOffset CreateLookAtConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<INpcLookAtConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<INpcLookAtConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602FB06 RID: 195334 RVA: 0x0067D774 File Offset: 0x0067B974
		public static VectorOffset CreateLookAtConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<INpcLookAtConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602FB07 RID: 195335 RVA: 0x0067D78D File Offset: 0x0067B98D
		public static void StartLookAtConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602FB08 RID: 195336 RVA: 0x0067D798 File Offset: 0x0067B998
		public static Offset<ILookAtTarget> EndILookAtTarget(FlatBufferBuilder builder)
		{
			return new Offset<ILookAtTarget>(builder.EndTable());
		}

		// Token: 0x0602FB09 RID: 195337 RVA: 0x0067D7A8 File Offset: 0x0067B9A8
		public ILookAtTargetT UnPack()
		{
			ILookAtTargetT lookAtTargetT = new ILookAtTargetT();
			this.UnPackTo(lookAtTargetT);
			return lookAtTargetT;
		}

		// Token: 0x0602FB0A RID: 195338 RVA: 0x0067D7C4 File Offset: 0x0067B9C4
		public void UnPackTo(ILookAtTargetT _o)
		{
			_o.Type = this.Type;
			_o.LookAtConfigs = new List<INpcLookAtConfigT>();
			for (int i = 0; i < this.LookAtConfigsLength; i++)
			{
				_o.LookAtConfigs.Add((this.LookAtConfigs(i) != null) ? this.LookAtConfigs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602FB0B RID: 195339 RVA: 0x0067D830 File Offset: 0x0067BA30
		public static Offset<ILookAtTarget> Pack(FlatBufferBuilder builder, ILookAtTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILookAtTarget>);
			}
			VectorOffset lookAtConfigsOffset = default(VectorOffset);
			if (_o.LookAtConfigs != null)
			{
				Offset<INpcLookAtConfig>[] array = new Offset<INpcLookAtConfig>[_o.LookAtConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = INpcLookAtConfig.Pack(builder, _o.LookAtConfigs[i]);
				}
				lookAtConfigsOffset = ILookAtTarget.CreateLookAtConfigsVector(builder, array);
			}
			return ILookAtTarget.CreateILookAtTarget(builder, _o.Type, lookAtConfigsOffset);
		}

		// Token: 0x04011280 RID: 70272
		private Table __p;
	}
}
