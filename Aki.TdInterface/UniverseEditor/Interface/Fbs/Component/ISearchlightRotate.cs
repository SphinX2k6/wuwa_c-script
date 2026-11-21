using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EFE RID: 24318
	public struct ISearchlightRotate : IFlatbufferObject
	{
		// Token: 0x1700B3CA RID: 46026
		// (get) Token: 0x06028CB4 RID: 167092 RVA: 0x0059344C File Offset: 0x0059164C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028CB5 RID: 167093 RVA: 0x00593459 File Offset: 0x00591659
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028CB6 RID: 167094 RVA: 0x00593460 File Offset: 0x00591660
		public static ISearchlightRotate GetRootAsISearchlightRotate(ByteBuffer _bb)
		{
			return ISearchlightRotate.GetRootAsISearchlightRotate(_bb, default(ISearchlightRotate));
		}

		// Token: 0x06028CB7 RID: 167095 RVA: 0x0059347C File Offset: 0x0059167C
		public static ISearchlightRotate GetRootAsISearchlightRotate(ByteBuffer _bb, ISearchlightRotate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028CB8 RID: 167096 RVA: 0x00593499 File Offset: 0x00591699
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028CB9 RID: 167097 RVA: 0x005934A8 File Offset: 0x005916A8
		public ISearchlightRotate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B3CB RID: 46027
		// (get) Token: 0x06028CBA RID: 167098 RVA: 0x005934B8 File Offset: 0x005916B8
		public EProceduralVisualType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EProceduralVisualType.LookAt;
				}
				return (EProceduralVisualType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B3CC RID: 46028
		// (get) Token: 0x06028CBB RID: 167099 RVA: 0x005934F4 File Offset: 0x005916F4
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B3CD RID: 46029
		// (get) Token: 0x06028CBC RID: 167100 RVA: 0x00593554 File Offset: 0x00591754
		public string RotateNode
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028CBD RID: 167101 RVA: 0x0059358B File Offset: 0x0059178B
		public Span<byte> GetRotateNodeBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06028CBE RID: 167102 RVA: 0x0059359A File Offset: 0x0059179A
		public byte[] GetRotateNodeArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700B3CE RID: 46030
		// (get) Token: 0x06028CBF RID: 167103 RVA: 0x005935A8 File Offset: 0x005917A8
		public float MaxAngleSpeed
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B3CF RID: 46031
		// (get) Token: 0x06028CC0 RID: 167104 RVA: 0x005935EC File Offset: 0x005917EC
		public ESearchlightRotateAxis Axis
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return ESearchlightRotateAxis.Yaw;
				}
				return (ESearchlightRotateAxis)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028CC1 RID: 167105 RVA: 0x0059362C File Offset: 0x0059182C
		public ISnapAngleConfig? SnapConfigs(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new ISnapAngleConfig?(default(ISnapAngleConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B3D0 RID: 46032
		// (get) Token: 0x06028CC2 RID: 167106 RVA: 0x00593690 File Offset: 0x00591890
		public int SnapConfigsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700B3D1 RID: 46033
		// (get) Token: 0x06028CC3 RID: 167107 RVA: 0x005936BC File Offset: 0x005918BC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028CC4 RID: 167108 RVA: 0x005936FC File Offset: 0x005918FC
		public static Offset<ISearchlightRotate> CreateISearchlightRotate(FlatBufferBuilder builder, EProceduralVisualType Type = EProceduralVisualType.LookAt, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), StringOffset RotateNodeOffset = default(StringOffset), float MaxAngleSpeed = 0f, ESearchlightRotateAxis Axis = ESearchlightRotateAxis.Yaw, VectorOffset SnapConfigsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(7);
			ISearchlightRotate.AddSnapConfigs(builder, SnapConfigsOffset);
			ISearchlightRotate.AddMaxAngleSpeed(builder, MaxAngleSpeed);
			ISearchlightRotate.AddRotateNode(builder, RotateNodeOffset);
			ISearchlightRotate.AddCondition(builder, ConditionOffset);
			ISearchlightRotate.AddNullMask(builder, NullMask);
			ISearchlightRotate.AddAxis(builder, Axis);
			ISearchlightRotate.AddType(builder, Type);
			return ISearchlightRotate.EndISearchlightRotate(builder);
		}

		// Token: 0x06028CC5 RID: 167109 RVA: 0x0059374B File Offset: 0x0059194B
		public static void StartISearchlightRotate(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06028CC6 RID: 167110 RVA: 0x00593754 File Offset: 0x00591954
		public static void AddType(FlatBufferBuilder builder, EProceduralVisualType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028CC7 RID: 167111 RVA: 0x0059375F File Offset: 0x0059195F
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(1, conditionOffset.Value, 0);
		}

		// Token: 0x06028CC8 RID: 167112 RVA: 0x0059376F File Offset: 0x0059196F
		public static void AddRotateNode(FlatBufferBuilder builder, StringOffset rotateNodeOffset)
		{
			builder.AddOffset(2, rotateNodeOffset.Value, 0);
		}

		// Token: 0x06028CC9 RID: 167113 RVA: 0x0059377F File Offset: 0x0059197F
		public static void AddMaxAngleSpeed(FlatBufferBuilder builder, float maxAngleSpeed)
		{
			builder.AddFloat(3, maxAngleSpeed, 0.0);
		}

		// Token: 0x06028CCA RID: 167114 RVA: 0x00593792 File Offset: 0x00591992
		public static void AddAxis(FlatBufferBuilder builder, ESearchlightRotateAxis axis)
		{
			builder.AddByte(4, (byte)axis, 0);
		}

		// Token: 0x06028CCB RID: 167115 RVA: 0x0059379D File Offset: 0x0059199D
		public static void AddSnapConfigs(FlatBufferBuilder builder, VectorOffset snapConfigsOffset)
		{
			builder.AddOffset(5, snapConfigsOffset.Value, 0);
		}

		// Token: 0x06028CCC RID: 167116 RVA: 0x005937B0 File Offset: 0x005919B0
		public static VectorOffset CreateSnapConfigsVector(FlatBufferBuilder builder, Offset<ISnapAngleConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06028CCD RID: 167117 RVA: 0x005937F0 File Offset: 0x005919F0
		public static VectorOffset CreateSnapConfigsVectorBlock(FlatBufferBuilder builder, Offset<ISnapAngleConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISnapAngleConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028CCE RID: 167118 RVA: 0x0059380A File Offset: 0x00591A0A
		public static VectorOffset CreateSnapConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISnapAngleConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISnapAngleConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028CCF RID: 167119 RVA: 0x00593828 File Offset: 0x00591A28
		public static VectorOffset CreateSnapConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISnapAngleConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028CD0 RID: 167120 RVA: 0x00593841 File Offset: 0x00591A41
		public static void StartSnapConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028CD1 RID: 167121 RVA: 0x0059384C File Offset: 0x00591A4C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06028CD2 RID: 167122 RVA: 0x00593857 File Offset: 0x00591A57
		public static Offset<ISearchlightRotate> EndISearchlightRotate(FlatBufferBuilder builder)
		{
			return new Offset<ISearchlightRotate>(builder.EndTable());
		}

		// Token: 0x06028CD3 RID: 167123 RVA: 0x00593864 File Offset: 0x00591A64
		public ISearchlightRotateT UnPack()
		{
			ISearchlightRotateT searchlightRotateT = new ISearchlightRotateT();
			this.UnPackTo(searchlightRotateT);
			return searchlightRotateT;
		}

		// Token: 0x06028CD4 RID: 167124 RVA: 0x00593880 File Offset: 0x00591A80
		public void UnPackTo(ISearchlightRotateT _o)
		{
			_o.Type = this.Type;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.RotateNode = this.RotateNode;
			_o.MaxAngleSpeed = this.MaxAngleSpeed;
			_o.Axis = this.Axis;
			_o.SnapConfigs = new List<ISnapAngleConfigT>();
			for (int i = 0; i < this.SnapConfigsLength; i++)
			{
				_o.SnapConfigs.Add((this.SnapConfigs(i) != null) ? this.SnapConfigs(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06028CD5 RID: 167125 RVA: 0x0059394C File Offset: 0x00591B4C
		public static Offset<ISearchlightRotate> Pack(FlatBufferBuilder builder, ISearchlightRotateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISearchlightRotate>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			StringOffset rotateNodeOffset = (_o.RotateNode == null) ? default(StringOffset) : builder.CreateString(_o.RotateNode);
			VectorOffset snapConfigsOffset = default(VectorOffset);
			if (_o.SnapConfigs != null)
			{
				Offset<ISnapAngleConfig>[] array = new Offset<ISnapAngleConfig>[_o.SnapConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISnapAngleConfig.Pack(builder, _o.SnapConfigs[i]);
				}
				snapConfigsOffset = ISearchlightRotate.CreateSnapConfigsVector(builder, array);
			}
			return ISearchlightRotate.CreateISearchlightRotate(builder, _o.Type, conditionOffset, rotateNodeOffset, _o.MaxAngleSpeed, _o.Axis, snapConfigsOffset, _o.NullMask);
		}

		// Token: 0x0400FB7A RID: 64378
		private Table __p;
	}
}
