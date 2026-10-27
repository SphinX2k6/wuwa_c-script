using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A7F RID: 27263
	public struct IMechEscortFly : IFlatbufferObject
	{
		// Token: 0x1700CA5F RID: 51807
		// (get) Token: 0x0602FC45 RID: 195653 RVA: 0x0067FFDE File Offset: 0x0067E1DE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FC46 RID: 195654 RVA: 0x0067FFEB File Offset: 0x0067E1EB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FC47 RID: 195655 RVA: 0x0067FFF4 File Offset: 0x0067E1F4
		public static IMechEscortFly GetRootAsIMechEscortFly(ByteBuffer _bb)
		{
			return IMechEscortFly.GetRootAsIMechEscortFly(_bb, default(IMechEscortFly));
		}

		// Token: 0x0602FC48 RID: 195656 RVA: 0x00680010 File Offset: 0x0067E210
		public static IMechEscortFly GetRootAsIMechEscortFly(ByteBuffer _bb, IMechEscortFly obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FC49 RID: 195657 RVA: 0x0068002D File Offset: 0x0067E22D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FC4A RID: 195658 RVA: 0x0068003C File Offset: 0x0067E23C
		public IMechEscortFly __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA60 RID: 51808
		// (get) Token: 0x0602FC4B RID: 195659 RVA: 0x0068004C File Offset: 0x0067E24C
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

		// Token: 0x1700CA61 RID: 51809
		// (get) Token: 0x0602FC4C RID: 195660 RVA: 0x00680088 File Offset: 0x0067E288
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

		// Token: 0x1700CA62 RID: 51810
		// (get) Token: 0x0602FC4D RID: 195661 RVA: 0x006800C4 File Offset: 0x0067E2C4
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

		// Token: 0x0602FC4E RID: 195662 RVA: 0x00680100 File Offset: 0x0067E300
		public IMechEscortPoint? EscortPoints(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IMechEscortPoint?(default(IMechEscortPoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700CA63 RID: 51811
		// (get) Token: 0x0602FC4F RID: 195663 RVA: 0x00680164 File Offset: 0x0067E364
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

		// Token: 0x0602FC50 RID: 195664 RVA: 0x00680190 File Offset: 0x0067E390
		public static Offset<IMechEscortFly> CreateIMechEscortFly(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill, int TargetEntity = 0, int TargetSpline = 0, VectorOffset EscortPointsOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			IMechEscortFly.AddEscortPoints(builder, EscortPointsOffset);
			IMechEscortFly.AddTargetSpline(builder, TargetSpline);
			IMechEscortFly.AddTargetEntity(builder, TargetEntity);
			IMechEscortFly.AddType(builder, Type);
			return IMechEscortFly.EndIMechEscortFly(builder);
		}

		// Token: 0x0602FC51 RID: 195665 RVA: 0x006801BC File Offset: 0x0067E3BC
		public static void StartIMechEscortFly(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602FC52 RID: 195666 RVA: 0x006801C5 File Offset: 0x0067E3C5
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FC53 RID: 195667 RVA: 0x006801D0 File Offset: 0x0067E3D0
		public static void AddTargetEntity(FlatBufferBuilder builder, int targetEntity)
		{
			builder.AddInt(1, targetEntity, 0);
		}

		// Token: 0x0602FC54 RID: 195668 RVA: 0x006801DB File Offset: 0x0067E3DB
		public static void AddTargetSpline(FlatBufferBuilder builder, int targetSpline)
		{
			builder.AddInt(2, targetSpline, 0);
		}

		// Token: 0x0602FC55 RID: 195669 RVA: 0x006801E6 File Offset: 0x0067E3E6
		public static void AddEscortPoints(FlatBufferBuilder builder, VectorOffset escortPointsOffset)
		{
			builder.AddOffset(3, escortPointsOffset.Value, 0);
		}

		// Token: 0x0602FC56 RID: 195670 RVA: 0x006801F8 File Offset: 0x0067E3F8
		public static VectorOffset CreateEscortPointsVector(FlatBufferBuilder builder, Offset<IMechEscortPoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602FC57 RID: 195671 RVA: 0x00680238 File Offset: 0x0067E438
		public static VectorOffset CreateEscortPointsVectorBlock(FlatBufferBuilder builder, Offset<IMechEscortPoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMechEscortPoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602FC58 RID: 195672 RVA: 0x00680252 File Offset: 0x0067E452
		public static VectorOffset CreateEscortPointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMechEscortPoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMechEscortPoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602FC59 RID: 195673 RVA: 0x00680270 File Offset: 0x0067E470
		public static VectorOffset CreateEscortPointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMechEscortPoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602FC5A RID: 195674 RVA: 0x00680289 File Offset: 0x0067E489
		public static void StartEscortPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602FC5B RID: 195675 RVA: 0x00680294 File Offset: 0x0067E494
		public static Offset<IMechEscortFly> EndIMechEscortFly(FlatBufferBuilder builder)
		{
			return new Offset<IMechEscortFly>(builder.EndTable());
		}

		// Token: 0x0602FC5C RID: 195676 RVA: 0x006802A4 File Offset: 0x0067E4A4
		public IMechEscortFlyT UnPack()
		{
			IMechEscortFlyT mechEscortFlyT = new IMechEscortFlyT();
			this.UnPackTo(mechEscortFlyT);
			return mechEscortFlyT;
		}

		// Token: 0x0602FC5D RID: 195677 RVA: 0x006802C0 File Offset: 0x0067E4C0
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

		// Token: 0x0602FC5E RID: 195678 RVA: 0x00680344 File Offset: 0x0067E544
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

		// Token: 0x040112B3 RID: 70323
		private Table __p;
	}
}
