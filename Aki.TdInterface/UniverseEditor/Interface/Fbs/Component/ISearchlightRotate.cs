using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058F1 RID: 22769
	public struct ISearchlightRotate : IFlatbufferObject
	{
		// Token: 0x1700AA96 RID: 43670
		// (get) Token: 0x0602674A RID: 157514 RVA: 0x0054C7E0 File Offset: 0x0054A9E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602674B RID: 157515 RVA: 0x0054C7ED File Offset: 0x0054A9ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602674C RID: 157516 RVA: 0x0054C7F4 File Offset: 0x0054A9F4
		public static ISearchlightRotate GetRootAsISearchlightRotate(ByteBuffer _bb)
		{
			return ISearchlightRotate.GetRootAsISearchlightRotate(_bb, default(ISearchlightRotate));
		}

		// Token: 0x0602674D RID: 157517 RVA: 0x0054C810 File Offset: 0x0054AA10
		public static ISearchlightRotate GetRootAsISearchlightRotate(ByteBuffer _bb, ISearchlightRotate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602674E RID: 157518 RVA: 0x0054C82D File Offset: 0x0054AA2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602674F RID: 157519 RVA: 0x0054C83C File Offset: 0x0054AA3C
		public ISearchlightRotate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA97 RID: 43671
		// (get) Token: 0x06026750 RID: 157520 RVA: 0x0054C84C File Offset: 0x0054AA4C
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

		// Token: 0x1700AA98 RID: 43672
		// (get) Token: 0x06026751 RID: 157521 RVA: 0x0054C888 File Offset: 0x0054AA88
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

		// Token: 0x1700AA99 RID: 43673
		// (get) Token: 0x06026752 RID: 157522 RVA: 0x0054C8E8 File Offset: 0x0054AAE8
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

		// Token: 0x06026753 RID: 157523 RVA: 0x0054C91F File Offset: 0x0054AB1F
		public Span<byte> GetRotateNodeBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06026754 RID: 157524 RVA: 0x0054C92E File Offset: 0x0054AB2E
		public byte[] GetRotateNodeArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700AA9A RID: 43674
		// (get) Token: 0x06026755 RID: 157525 RVA: 0x0054C93C File Offset: 0x0054AB3C
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

		// Token: 0x1700AA9B RID: 43675
		// (get) Token: 0x06026756 RID: 157526 RVA: 0x0054C980 File Offset: 0x0054AB80
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

		// Token: 0x06026757 RID: 157527 RVA: 0x0054C9C0 File Offset: 0x0054ABC0
		public ISnapAngleConfig? SnapConfigs(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new ISnapAngleConfig?(default(ISnapAngleConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AA9C RID: 43676
		// (get) Token: 0x06026758 RID: 157528 RVA: 0x0054CA24 File Offset: 0x0054AC24
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

		// Token: 0x1700AA9D RID: 43677
		// (get) Token: 0x06026759 RID: 157529 RVA: 0x0054CA50 File Offset: 0x0054AC50
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

		// Token: 0x0602675A RID: 157530 RVA: 0x0054CA90 File Offset: 0x0054AC90
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

		// Token: 0x0602675B RID: 157531 RVA: 0x0054CADF File Offset: 0x0054ACDF
		public static void StartISearchlightRotate(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602675C RID: 157532 RVA: 0x0054CAE8 File Offset: 0x0054ACE8
		public static void AddType(FlatBufferBuilder builder, EProceduralVisualType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602675D RID: 157533 RVA: 0x0054CAF3 File Offset: 0x0054ACF3
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(1, conditionOffset.Value, 0);
		}

		// Token: 0x0602675E RID: 157534 RVA: 0x0054CB03 File Offset: 0x0054AD03
		public static void AddRotateNode(FlatBufferBuilder builder, StringOffset rotateNodeOffset)
		{
			builder.AddOffset(2, rotateNodeOffset.Value, 0);
		}

		// Token: 0x0602675F RID: 157535 RVA: 0x0054CB13 File Offset: 0x0054AD13
		public static void AddMaxAngleSpeed(FlatBufferBuilder builder, float maxAngleSpeed)
		{
			builder.AddFloat(3, maxAngleSpeed, 0.0);
		}

		// Token: 0x06026760 RID: 157536 RVA: 0x0054CB26 File Offset: 0x0054AD26
		public static void AddAxis(FlatBufferBuilder builder, ESearchlightRotateAxis axis)
		{
			builder.AddByte(4, (byte)axis, 0);
		}

		// Token: 0x06026761 RID: 157537 RVA: 0x0054CB31 File Offset: 0x0054AD31
		public static void AddSnapConfigs(FlatBufferBuilder builder, VectorOffset snapConfigsOffset)
		{
			builder.AddOffset(5, snapConfigsOffset.Value, 0);
		}

		// Token: 0x06026762 RID: 157538 RVA: 0x0054CB44 File Offset: 0x0054AD44
		public static VectorOffset CreateSnapConfigsVector(FlatBufferBuilder builder, Offset<ISnapAngleConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026763 RID: 157539 RVA: 0x0054CB84 File Offset: 0x0054AD84
		public static VectorOffset CreateSnapConfigsVectorBlock(FlatBufferBuilder builder, Offset<ISnapAngleConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISnapAngleConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026764 RID: 157540 RVA: 0x0054CB9E File Offset: 0x0054AD9E
		public static VectorOffset CreateSnapConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISnapAngleConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISnapAngleConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026765 RID: 157541 RVA: 0x0054CBBC File Offset: 0x0054ADBC
		public static VectorOffset CreateSnapConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISnapAngleConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026766 RID: 157542 RVA: 0x0054CBD5 File Offset: 0x0054ADD5
		public static void StartSnapConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026767 RID: 157543 RVA: 0x0054CBE0 File Offset: 0x0054ADE0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06026768 RID: 157544 RVA: 0x0054CBEB File Offset: 0x0054ADEB
		public static Offset<ISearchlightRotate> EndISearchlightRotate(FlatBufferBuilder builder)
		{
			return new Offset<ISearchlightRotate>(builder.EndTable());
		}

		// Token: 0x06026769 RID: 157545 RVA: 0x0054CBF8 File Offset: 0x0054ADF8
		public ISearchlightRotateT UnPack()
		{
			ISearchlightRotateT searchlightRotateT = new ISearchlightRotateT();
			this.UnPackTo(searchlightRotateT);
			return searchlightRotateT;
		}

		// Token: 0x0602676A RID: 157546 RVA: 0x0054CC14 File Offset: 0x0054AE14
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

		// Token: 0x0602676B RID: 157547 RVA: 0x0054CCE0 File Offset: 0x0054AEE0
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

		// Token: 0x0400EE85 RID: 61061
		private Table __p;
	}
}
