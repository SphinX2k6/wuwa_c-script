using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005775 RID: 22389
	public struct IExploreSkillStatueInteractPoint : IFlatbufferObject
	{
		// Token: 0x1700A1D2 RID: 41426
		// (get) Token: 0x0602419C RID: 147868 RVA: 0x004F6E9C File Offset: 0x004F509C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602419D RID: 147869 RVA: 0x004F6EA9 File Offset: 0x004F50A9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602419E RID: 147870 RVA: 0x004F6EB0 File Offset: 0x004F50B0
		public static IExploreSkillStatueInteractPoint GetRootAsIExploreSkillStatueInteractPoint(ByteBuffer _bb)
		{
			return IExploreSkillStatueInteractPoint.GetRootAsIExploreSkillStatueInteractPoint(_bb, default(IExploreSkillStatueInteractPoint));
		}

		// Token: 0x0602419F RID: 147871 RVA: 0x004F6ECC File Offset: 0x004F50CC
		public static IExploreSkillStatueInteractPoint GetRootAsIExploreSkillStatueInteractPoint(ByteBuffer _bb, IExploreSkillStatueInteractPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060241A0 RID: 147872 RVA: 0x004F6EE9 File Offset: 0x004F50E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060241A1 RID: 147873 RVA: 0x004F6EF8 File Offset: 0x004F50F8
		public IExploreSkillStatueInteractPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A1D3 RID: 41427
		// (get) Token: 0x060241A2 RID: 147874 RVA: 0x004F6F08 File Offset: 0x004F5108
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

		// Token: 0x1700A1D4 RID: 41428
		// (get) Token: 0x060241A3 RID: 147875 RVA: 0x004F6F44 File Offset: 0x004F5144
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

		// Token: 0x060241A4 RID: 147876 RVA: 0x004F6F84 File Offset: 0x004F5184
		public string HangingPointList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A1D5 RID: 41429
		// (get) Token: 0x060241A5 RID: 147877 RVA: 0x004F6FC0 File Offset: 0x004F51C0
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

		// Token: 0x060241A6 RID: 147878 RVA: 0x004F6FEB File Offset: 0x004F51EB
		public static Offset<IExploreSkillStatueInteractPoint> CreateIExploreSkillStatueInteractPoint(FlatBufferBuilder builder, EExploreSkillInteractType Type = EExploreSkillInteractType.PullGiant, float PullTime = 0f, VectorOffset HangingPointListOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IExploreSkillStatueInteractPoint.AddHangingPointList(builder, HangingPointListOffset);
			IExploreSkillStatueInteractPoint.AddPullTime(builder, PullTime);
			IExploreSkillStatueInteractPoint.AddType(builder, Type);
			return IExploreSkillStatueInteractPoint.EndIExploreSkillStatueInteractPoint(builder);
		}

		// Token: 0x060241A7 RID: 147879 RVA: 0x004F700F File Offset: 0x004F520F
		public static void StartIExploreSkillStatueInteractPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060241A8 RID: 147880 RVA: 0x004F7018 File Offset: 0x004F5218
		public static void AddType(FlatBufferBuilder builder, EExploreSkillInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060241A9 RID: 147881 RVA: 0x004F7023 File Offset: 0x004F5223
		public static void AddPullTime(FlatBufferBuilder builder, float pullTime)
		{
			builder.AddFloat(1, pullTime, 0.0);
		}

		// Token: 0x060241AA RID: 147882 RVA: 0x004F7036 File Offset: 0x004F5236
		public static void AddHangingPointList(FlatBufferBuilder builder, VectorOffset hangingPointListOffset)
		{
			builder.AddOffset(2, hangingPointListOffset.Value, 0);
		}

		// Token: 0x060241AB RID: 147883 RVA: 0x004F7048 File Offset: 0x004F5248
		public static VectorOffset CreateHangingPointListVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060241AC RID: 147884 RVA: 0x004F7088 File Offset: 0x004F5288
		public static VectorOffset CreateHangingPointListVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060241AD RID: 147885 RVA: 0x004F70A2 File Offset: 0x004F52A2
		public static VectorOffset CreateHangingPointListVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x060241AE RID: 147886 RVA: 0x004F70C0 File Offset: 0x004F52C0
		public static VectorOffset CreateHangingPointListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060241AF RID: 147887 RVA: 0x004F70D9 File Offset: 0x004F52D9
		public static void StartHangingPointListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060241B0 RID: 147888 RVA: 0x004F70E4 File Offset: 0x004F52E4
		public static Offset<IExploreSkillStatueInteractPoint> EndIExploreSkillStatueInteractPoint(FlatBufferBuilder builder)
		{
			return new Offset<IExploreSkillStatueInteractPoint>(builder.EndTable());
		}

		// Token: 0x060241B1 RID: 147889 RVA: 0x004F70F4 File Offset: 0x004F52F4
		public IExploreSkillStatueInteractPointT UnPack()
		{
			IExploreSkillStatueInteractPointT exploreSkillStatueInteractPointT = new IExploreSkillStatueInteractPointT();
			this.UnPackTo(exploreSkillStatueInteractPointT);
			return exploreSkillStatueInteractPointT;
		}

		// Token: 0x060241B2 RID: 147890 RVA: 0x004F7110 File Offset: 0x004F5310
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

		// Token: 0x060241B3 RID: 147891 RVA: 0x004F7164 File Offset: 0x004F5364
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

		// Token: 0x0400EF47 RID: 61255
		private Table __p;
	}
}
