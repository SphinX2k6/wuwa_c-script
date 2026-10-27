using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200520D RID: 21005
	public struct IExploreSkillStatueInteractPoint : IFlatbufferObject
	{
		// Token: 0x170099D6 RID: 39382
		// (get) Token: 0x06022206 RID: 139782 RVA: 0x004BC3D8 File Offset: 0x004BA5D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022207 RID: 139783 RVA: 0x004BC3E5 File Offset: 0x004BA5E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022208 RID: 139784 RVA: 0x004BC3EC File Offset: 0x004BA5EC
		public static IExploreSkillStatueInteractPoint GetRootAsIExploreSkillStatueInteractPoint(ByteBuffer _bb)
		{
			return IExploreSkillStatueInteractPoint.GetRootAsIExploreSkillStatueInteractPoint(_bb, default(IExploreSkillStatueInteractPoint));
		}

		// Token: 0x06022209 RID: 139785 RVA: 0x004BC408 File Offset: 0x004BA608
		public static IExploreSkillStatueInteractPoint GetRootAsIExploreSkillStatueInteractPoint(ByteBuffer _bb, IExploreSkillStatueInteractPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602220A RID: 139786 RVA: 0x004BC425 File Offset: 0x004BA625
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602220B RID: 139787 RVA: 0x004BC434 File Offset: 0x004BA634
		public IExploreSkillStatueInteractPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170099D7 RID: 39383
		// (get) Token: 0x0602220C RID: 139788 RVA: 0x004BC444 File Offset: 0x004BA644
		public EExploreSkillInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExploreSkillInteractType.PullGiant;
				}
				return (EExploreSkillInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170099D8 RID: 39384
		// (get) Token: 0x0602220D RID: 139789 RVA: 0x004BC480 File Offset: 0x004BA680
		public float PullTime
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602220E RID: 139790 RVA: 0x004BC4C0 File Offset: 0x004BA6C0
		public string HangingPointList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170099D9 RID: 39385
		// (get) Token: 0x0602220F RID: 139791 RVA: 0x004BC4FC File Offset: 0x004BA6FC
		public int HangingPointListLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06022210 RID: 139792 RVA: 0x004BC527 File Offset: 0x004BA727
		public static Offset<IExploreSkillStatueInteractPoint> CreateIExploreSkillStatueInteractPoint(FlatBufferBuilder builder, EExploreSkillInteractType Type = EExploreSkillInteractType.PullGiant, float PullTime = 0f, VectorOffset HangingPointListOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IExploreSkillStatueInteractPoint.AddHangingPointList(builder, HangingPointListOffset);
			IExploreSkillStatueInteractPoint.AddPullTime(builder, PullTime);
			IExploreSkillStatueInteractPoint.AddType(builder, Type);
			return IExploreSkillStatueInteractPoint.EndIExploreSkillStatueInteractPoint(builder);
		}

		// Token: 0x06022211 RID: 139793 RVA: 0x004BC54B File Offset: 0x004BA74B
		public static void StartIExploreSkillStatueInteractPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06022212 RID: 139794 RVA: 0x004BC554 File Offset: 0x004BA754
		public static void AddType(FlatBufferBuilder builder, EExploreSkillInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022213 RID: 139795 RVA: 0x004BC55F File Offset: 0x004BA75F
		public static void AddPullTime(FlatBufferBuilder builder, float pullTime)
		{
			builder.AddFloat(1, pullTime, 0.0);
		}

		// Token: 0x06022214 RID: 139796 RVA: 0x004BC572 File Offset: 0x004BA772
		public static void AddHangingPointList(FlatBufferBuilder builder, VectorOffset hangingPointListOffset)
		{
			builder.AddOffset(2, hangingPointListOffset.Value, 0);
		}

		// Token: 0x06022215 RID: 139797 RVA: 0x004BC584 File Offset: 0x004BA784
		public static VectorOffset CreateHangingPointListVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022216 RID: 139798 RVA: 0x004BC5C4 File Offset: 0x004BA7C4
		public static VectorOffset CreateHangingPointListVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06022217 RID: 139799 RVA: 0x004BC5DE File Offset: 0x004BA7DE
		public static VectorOffset CreateHangingPointListVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06022218 RID: 139800 RVA: 0x004BC5FC File Offset: 0x004BA7FC
		public static VectorOffset CreateHangingPointListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022219 RID: 139801 RVA: 0x004BC615 File Offset: 0x004BA815
		public static void StartHangingPointListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602221A RID: 139802 RVA: 0x004BC620 File Offset: 0x004BA820
		public static Offset<IExploreSkillStatueInteractPoint> EndIExploreSkillStatueInteractPoint(FlatBufferBuilder builder)
		{
			return new Offset<IExploreSkillStatueInteractPoint>(builder.EndTable());
		}

		// Token: 0x0602221B RID: 139803 RVA: 0x004BC630 File Offset: 0x004BA830
		public IExploreSkillStatueInteractPointT UnPack()
		{
			IExploreSkillStatueInteractPointT exploreSkillStatueInteractPointT = new IExploreSkillStatueInteractPointT();
			this.UnPackTo(exploreSkillStatueInteractPointT);
			return exploreSkillStatueInteractPointT;
		}

		// Token: 0x0602221C RID: 139804 RVA: 0x004BC64C File Offset: 0x004BA84C
		public void UnPackTo(IExploreSkillStatueInteractPointT _o)
		{
			_o.Type = this.Type;
			_o.PullTime = this.PullTime;
			_o.HangingPointList = new List<string>();
			for (int i = 0; i < this.HangingPointListLength; i++)
			{
				_o.HangingPointList.Add(this.HangingPointList(i));
			}
		}

		// Token: 0x0602221D RID: 139805 RVA: 0x004BC6A0 File Offset: 0x004BA8A0
		public static Offset<IExploreSkillStatueInteractPoint> Pack(FlatBufferBuilder builder, IExploreSkillStatueInteractPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExploreSkillStatueInteractPoint>);
			}
			VectorOffset hangingPointListOffset = default(VectorOffset);
			if (_o.HangingPointList != null)
			{
				StringOffset[] array = new StringOffset[_o.HangingPointList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.HangingPointList[i]);
				}
				hangingPointListOffset = IExploreSkillStatueInteractPoint.CreateHangingPointListVector(builder, array);
			}
			return IExploreSkillStatueInteractPoint.CreateIExploreSkillStatueInteractPoint(builder, _o.Type, _o.PullTime, hangingPointListOffset);
		}

		// Token: 0x0400E341 RID: 58177
		private Table __p;
	}
}
