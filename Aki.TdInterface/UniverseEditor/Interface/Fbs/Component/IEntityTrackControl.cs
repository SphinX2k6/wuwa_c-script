using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005724 RID: 22308
	public struct IEntityTrackControl : IFlatbufferObject
	{
		// Token: 0x1700A104 RID: 41220
		// (get) Token: 0x06023DE8 RID: 146920 RVA: 0x004EE5A6 File Offset: 0x004EC7A6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023DE9 RID: 146921 RVA: 0x004EE5B3 File Offset: 0x004EC7B3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023DEA RID: 146922 RVA: 0x004EE5BC File Offset: 0x004EC7BC
		public static IEntityTrackControl GetRootAsIEntityTrackControl(ByteBuffer _bb)
		{
			return IEntityTrackControl.GetRootAsIEntityTrackControl(_bb, default(IEntityTrackControl));
		}

		// Token: 0x06023DEB RID: 146923 RVA: 0x004EE5D8 File Offset: 0x004EC7D8
		public static IEntityTrackControl GetRootAsIEntityTrackControl(ByteBuffer _bb, IEntityTrackControl obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023DEC RID: 146924 RVA: 0x004EE5F5 File Offset: 0x004EC7F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023DED RID: 146925 RVA: 0x004EE604 File Offset: 0x004EC804
		public IEntityTrackControl __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A105 RID: 41221
		// (get) Token: 0x06023DEE RID: 146926 RVA: 0x004EE614 File Offset: 0x004EC814
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

		// Token: 0x1700A106 RID: 41222
		// (get) Token: 0x06023DEF RID: 146927 RVA: 0x004EE650 File Offset: 0x004EC850
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

		// Token: 0x06023DF0 RID: 146928 RVA: 0x004EE68C File Offset: 0x004EC88C
		public IEntityTrackControlPoint? ControlPoints(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IEntityTrackControlPoint?(default(IEntityTrackControlPoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A107 RID: 41223
		// (get) Token: 0x06023DF1 RID: 146929 RVA: 0x004EE6EC File Offset: 0x004EC8EC
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

		// Token: 0x06023DF2 RID: 146930 RVA: 0x004EE717 File Offset: 0x004EC917
		public static Offset<IEntityTrackControl> CreateIEntityTrackControl(FlatBufferBuilder builder, ETrackControlMode Type = ETrackControlMode.Sequence, int EntityId = 0, VectorOffset ControlPointsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IEntityTrackControl.AddControlPoints(builder, ControlPointsOffset);
			IEntityTrackControl.AddEntityId(builder, EntityId);
			IEntityTrackControl.AddType(builder, Type);
			return IEntityTrackControl.EndIEntityTrackControl(builder);
		}

		// Token: 0x06023DF3 RID: 146931 RVA: 0x004EE73B File Offset: 0x004EC93B
		public static void StartIEntityTrackControl(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06023DF4 RID: 146932 RVA: 0x004EE744 File Offset: 0x004EC944
		public static void AddType(FlatBufferBuilder builder, ETrackControlMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023DF5 RID: 146933 RVA: 0x004EE74F File Offset: 0x004EC94F
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x06023DF6 RID: 146934 RVA: 0x004EE75A File Offset: 0x004EC95A
		public static void AddControlPoints(FlatBufferBuilder builder, VectorOffset controlPointsOffset)
		{
			builder.AddOffset(2, controlPointsOffset.Value, 0);
		}

		// Token: 0x06023DF7 RID: 146935 RVA: 0x004EE76C File Offset: 0x004EC96C
		public static VectorOffset CreateControlPointsVector(FlatBufferBuilder builder, Offset<IEntityTrackControlPoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023DF8 RID: 146936 RVA: 0x004EE7AC File Offset: 0x004EC9AC
		public static VectorOffset CreateControlPointsVectorBlock(FlatBufferBuilder builder, Offset<IEntityTrackControlPoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityTrackControlPoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023DF9 RID: 146937 RVA: 0x004EE7C6 File Offset: 0x004EC9C6
		public static VectorOffset CreateControlPointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityTrackControlPoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityTrackControlPoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023DFA RID: 146938 RVA: 0x004EE7E4 File Offset: 0x004EC9E4
		public static VectorOffset CreateControlPointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityTrackControlPoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023DFB RID: 146939 RVA: 0x004EE7FD File Offset: 0x004EC9FD
		public static void StartControlPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023DFC RID: 146940 RVA: 0x004EE808 File Offset: 0x004ECA08
		public static Offset<IEntityTrackControl> EndIEntityTrackControl(FlatBufferBuilder builder)
		{
			return new Offset<IEntityTrackControl>(builder.EndTable());
		}

		// Token: 0x06023DFD RID: 146941 RVA: 0x004EE818 File Offset: 0x004ECA18
		public IEntityTrackControlT UnPack()
		{
			IEntityTrackControlT entityTrackControlT = new IEntityTrackControlT();
			this.UnPackTo(entityTrackControlT);
			return entityTrackControlT;
		}

		// Token: 0x06023DFE RID: 146942 RVA: 0x004EE834 File Offset: 0x004ECA34
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

		// Token: 0x06023DFF RID: 146943 RVA: 0x004EE8AC File Offset: 0x004ECAAC
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

		// Token: 0x0400EEB6 RID: 61110
		private Table __p;
	}
}
