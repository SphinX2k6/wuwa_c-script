using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051BF RID: 20927
	public struct IEntityTrackControl : IFlatbufferObject
	{
		// Token: 0x17009915 RID: 39189
		// (get) Token: 0x06021E90 RID: 138896 RVA: 0x004B453E File Offset: 0x004B273E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021E91 RID: 138897 RVA: 0x004B454B File Offset: 0x004B274B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021E92 RID: 138898 RVA: 0x004B4554 File Offset: 0x004B2754
		public static IEntityTrackControl GetRootAsIEntityTrackControl(ByteBuffer _bb)
		{
			return IEntityTrackControl.GetRootAsIEntityTrackControl(_bb, default(IEntityTrackControl));
		}

		// Token: 0x06021E93 RID: 138899 RVA: 0x004B4570 File Offset: 0x004B2770
		public static IEntityTrackControl GetRootAsIEntityTrackControl(ByteBuffer _bb, IEntityTrackControl obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021E94 RID: 138900 RVA: 0x004B458D File Offset: 0x004B278D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021E95 RID: 138901 RVA: 0x004B459C File Offset: 0x004B279C
		public IEntityTrackControl __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009916 RID: 39190
		// (get) Token: 0x06021E96 RID: 138902 RVA: 0x004B45AC File Offset: 0x004B27AC
		public ETrackControlMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrackControlMode.Sequence;
				}
				return (ETrackControlMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009917 RID: 39191
		// (get) Token: 0x06021E97 RID: 138903 RVA: 0x004B45E8 File Offset: 0x004B27E8
		public int EntityId
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

		// Token: 0x06021E98 RID: 138904 RVA: 0x004B4624 File Offset: 0x004B2824
		public IEntityTrackControlPoint? ControlPoints(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IEntityTrackControlPoint?(default(IEntityTrackControlPoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009918 RID: 39192
		// (get) Token: 0x06021E99 RID: 138905 RVA: 0x004B4684 File Offset: 0x004B2884
		public int ControlPointsLength
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

		// Token: 0x06021E9A RID: 138906 RVA: 0x004B46AF File Offset: 0x004B28AF
		public static Offset<IEntityTrackControl> CreateIEntityTrackControl(FlatBufferBuilder builder, ETrackControlMode Type = ETrackControlMode.Sequence, int EntityId = 0, VectorOffset ControlPointsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IEntityTrackControl.AddControlPoints(builder, ControlPointsOffset);
			IEntityTrackControl.AddEntityId(builder, EntityId);
			IEntityTrackControl.AddType(builder, Type);
			return IEntityTrackControl.EndIEntityTrackControl(builder);
		}

		// Token: 0x06021E9B RID: 138907 RVA: 0x004B46D3 File Offset: 0x004B28D3
		public static void StartIEntityTrackControl(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06021E9C RID: 138908 RVA: 0x004B46DC File Offset: 0x004B28DC
		public static void AddType(FlatBufferBuilder builder, ETrackControlMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021E9D RID: 138909 RVA: 0x004B46E7 File Offset: 0x004B28E7
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x06021E9E RID: 138910 RVA: 0x004B46F2 File Offset: 0x004B28F2
		public static void AddControlPoints(FlatBufferBuilder builder, VectorOffset controlPointsOffset)
		{
			builder.AddOffset(2, controlPointsOffset.Value, 0);
		}

		// Token: 0x06021E9F RID: 138911 RVA: 0x004B4704 File Offset: 0x004B2904
		public static VectorOffset CreateControlPointsVector(FlatBufferBuilder builder, Offset<IEntityTrackControlPoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021EA0 RID: 138912 RVA: 0x004B4744 File Offset: 0x004B2944
		public static VectorOffset CreateControlPointsVectorBlock(FlatBufferBuilder builder, Offset<IEntityTrackControlPoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityTrackControlPoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021EA1 RID: 138913 RVA: 0x004B475E File Offset: 0x004B295E
		public static VectorOffset CreateControlPointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityTrackControlPoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityTrackControlPoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021EA2 RID: 138914 RVA: 0x004B477C File Offset: 0x004B297C
		public static VectorOffset CreateControlPointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityTrackControlPoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021EA3 RID: 138915 RVA: 0x004B4795 File Offset: 0x004B2995
		public static void StartControlPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021EA4 RID: 138916 RVA: 0x004B47A0 File Offset: 0x004B29A0
		public static Offset<IEntityTrackControl> EndIEntityTrackControl(FlatBufferBuilder builder)
		{
			return new Offset<IEntityTrackControl>(builder.EndTable());
		}

		// Token: 0x06021EA5 RID: 138917 RVA: 0x004B47B0 File Offset: 0x004B29B0
		public IEntityTrackControlT UnPack()
		{
			IEntityTrackControlT entityTrackControlT = new IEntityTrackControlT();
			this.UnPackTo(entityTrackControlT);
			return entityTrackControlT;
		}

		// Token: 0x06021EA6 RID: 138918 RVA: 0x004B47CC File Offset: 0x004B29CC
		public void UnPackTo(IEntityTrackControlT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.ControlPoints = new List<IEntityTrackControlPointT>();
			for (int i = 0; i < this.ControlPointsLength; i++)
			{
				_o.ControlPoints.Add((this.ControlPoints(i) != null) ? this.ControlPoints(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06021EA7 RID: 138919 RVA: 0x004B4844 File Offset: 0x004B2A44
		public static Offset<IEntityTrackControl> Pack(FlatBufferBuilder builder, IEntityTrackControlT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityTrackControl>);
			}
			VectorOffset controlPointsOffset = default(VectorOffset);
			if (_o.ControlPoints != null)
			{
				Offset<IEntityTrackControlPoint>[] array = new Offset<IEntityTrackControlPoint>[_o.ControlPoints.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEntityTrackControlPoint.Pack(builder, _o.ControlPoints[i]);
				}
				controlPointsOffset = IEntityTrackControl.CreateControlPointsVector(builder, array);
			}
			return IEntityTrackControl.CreateIEntityTrackControl(builder, _o.Type, _o.EntityId, controlPointsOffset);
		}

		// Token: 0x0400E2B8 RID: 58040
		private Table __p;
	}
}
