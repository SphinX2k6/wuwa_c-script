using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071A1 RID: 29089
	public struct IMechEscortFly : IFlatbufferObject
	{
		// Token: 0x1700D50A RID: 54538
		// (get) Token: 0x0603296B RID: 207211 RVA: 0x006D609E File Offset: 0x006D429E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603296C RID: 207212 RVA: 0x006D60AB File Offset: 0x006D42AB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603296D RID: 207213 RVA: 0x006D60B4 File Offset: 0x006D42B4
		public static IMechEscortFly GetRootAsIMechEscortFly(ByteBuffer _bb)
		{
			return IMechEscortFly.GetRootAsIMechEscortFly(_bb, default(IMechEscortFly));
		}

		// Token: 0x0603296E RID: 207214 RVA: 0x006D60D0 File Offset: 0x006D42D0
		public static IMechEscortFly GetRootAsIMechEscortFly(ByteBuffer _bb, IMechEscortFly obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603296F RID: 207215 RVA: 0x006D60ED File Offset: 0x006D42ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032970 RID: 207216 RVA: 0x006D60FC File Offset: 0x006D42FC
		public IMechEscortFly __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D50B RID: 54539
		// (get) Token: 0x06032971 RID: 207217 RVA: 0x006D610C File Offset: 0x006D430C
		public ELeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELeisureInteract.CustomSkill;
				}
				return (ELeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D50C RID: 54540
		// (get) Token: 0x06032972 RID: 207218 RVA: 0x006D6148 File Offset: 0x006D4348
		public int TargetEntity
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D50D RID: 54541
		// (get) Token: 0x06032973 RID: 207219 RVA: 0x006D6184 File Offset: 0x006D4384
		public int TargetSpline
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032974 RID: 207220 RVA: 0x006D61C0 File Offset: 0x006D43C0
		public IMechEscortPoint? EscortPoints(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IMechEscortPoint?(default(IMechEscortPoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D50E RID: 54542
		// (get) Token: 0x06032975 RID: 207221 RVA: 0x006D6224 File Offset: 0x006D4424
		public int EscortPointsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06032976 RID: 207222 RVA: 0x006D6250 File Offset: 0x006D4450
		public static Offset<IMechEscortFly> CreateIMechEscortFly(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill, int TargetEntity = 0, int TargetSpline = 0, VectorOffset EscortPointsOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			IMechEscortFly.AddEscortPoints(builder, EscortPointsOffset);
			IMechEscortFly.AddTargetSpline(builder, TargetSpline);
			IMechEscortFly.AddTargetEntity(builder, TargetEntity);
			IMechEscortFly.AddType(builder, Type);
			return IMechEscortFly.EndIMechEscortFly(builder);
		}

		// Token: 0x06032977 RID: 207223 RVA: 0x006D627C File Offset: 0x006D447C
		public static void StartIMechEscortFly(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06032978 RID: 207224 RVA: 0x006D6285 File Offset: 0x006D4485
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032979 RID: 207225 RVA: 0x006D6290 File Offset: 0x006D4490
		public static void AddTargetEntity(FlatBufferBuilder builder, int targetEntity)
		{
			builder.AddInt(1, targetEntity, 0);
		}

		// Token: 0x0603297A RID: 207226 RVA: 0x006D629B File Offset: 0x006D449B
		public static void AddTargetSpline(FlatBufferBuilder builder, int targetSpline)
		{
			builder.AddInt(2, targetSpline, 0);
		}

		// Token: 0x0603297B RID: 207227 RVA: 0x006D62A6 File Offset: 0x006D44A6
		public static void AddEscortPoints(FlatBufferBuilder builder, VectorOffset escortPointsOffset)
		{
			builder.AddOffset(3, escortPointsOffset.Value, 0);
		}

		// Token: 0x0603297C RID: 207228 RVA: 0x006D62B8 File Offset: 0x006D44B8
		public static VectorOffset CreateEscortPointsVector(FlatBufferBuilder builder, Offset<IMechEscortPoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0603297D RID: 207229 RVA: 0x006D62F8 File Offset: 0x006D44F8
		public static VectorOffset CreateEscortPointsVectorBlock(FlatBufferBuilder builder, Offset<IMechEscortPoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMechEscortPoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603297E RID: 207230 RVA: 0x006D6312 File Offset: 0x006D4512
		public static VectorOffset CreateEscortPointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMechEscortPoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMechEscortPoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603297F RID: 207231 RVA: 0x006D6330 File Offset: 0x006D4530
		public static VectorOffset CreateEscortPointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMechEscortPoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06032980 RID: 207232 RVA: 0x006D6349 File Offset: 0x006D4549
		public static void StartEscortPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06032981 RID: 207233 RVA: 0x006D6354 File Offset: 0x006D4554
		public static Offset<IMechEscortFly> EndIMechEscortFly(FlatBufferBuilder builder)
		{
			return new Offset<IMechEscortFly>(builder.EndTable());
		}

		// Token: 0x06032982 RID: 207234 RVA: 0x006D6364 File Offset: 0x006D4564
		public IMechEscortFlyT UnPack()
		{
			IMechEscortFlyT mechEscortFlyT = new IMechEscortFlyT();
			this.UnPackTo(mechEscortFlyT);
			return mechEscortFlyT;
		}

		// Token: 0x06032983 RID: 207235 RVA: 0x006D6380 File Offset: 0x006D4580
		public void UnPackTo(IMechEscortFlyT _o)
		{
			_o.Type = this.Type;
			_o.TargetEntity = this.TargetEntity;
			_o.TargetSpline = this.TargetSpline;
			_o.EscortPoints = new List<IMechEscortPointT>();
			for (int i = 0; i < this.EscortPointsLength; i++)
			{
				_o.EscortPoints.Add((this.EscortPoints(i) != null) ? this.EscortPoints(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06032984 RID: 207236 RVA: 0x006D6404 File Offset: 0x006D4604
		public static Offset<IMechEscortFly> Pack(FlatBufferBuilder builder, IMechEscortFlyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechEscortFly>);
			}
			VectorOffset escortPointsOffset = default(VectorOffset);
			if (_o.EscortPoints != null)
			{
				Offset<IMechEscortPoint>[] array = new Offset<IMechEscortPoint>[_o.EscortPoints.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IMechEscortPoint.Pack(builder, _o.EscortPoints[i]);
				}
				escortPointsOffset = IMechEscortFly.CreateEscortPointsVector(builder, array);
			}
			return IMechEscortFly.CreateIMechEscortFly(builder, _o.Type, _o.TargetEntity, _o.TargetSpline, escortPointsOffset);
		}

		// Token: 0x040121AB RID: 74155
		private Table __p;
	}
}
