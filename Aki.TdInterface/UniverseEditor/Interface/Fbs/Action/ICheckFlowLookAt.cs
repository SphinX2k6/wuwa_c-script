using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069CC RID: 27084
	public struct ICheckFlowLookAt : IFlatbufferObject
	{
		// Token: 0x1700C74D RID: 51021
		// (get) Token: 0x0602E767 RID: 190311 RVA: 0x00656E7B File Offset: 0x0065507B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E768 RID: 190312 RVA: 0x00656E88 File Offset: 0x00655088
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E769 RID: 190313 RVA: 0x00656E90 File Offset: 0x00655090
		public static ICheckFlowLookAt GetRootAsICheckFlowLookAt(ByteBuffer _bb)
		{
			return ICheckFlowLookAt.GetRootAsICheckFlowLookAt(_bb, default(ICheckFlowLookAt));
		}

		// Token: 0x0602E76A RID: 190314 RVA: 0x00656EAC File Offset: 0x006550AC
		public static ICheckFlowLookAt GetRootAsICheckFlowLookAt(ByteBuffer _bb, ICheckFlowLookAt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E76B RID: 190315 RVA: 0x00656EC9 File Offset: 0x006550C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E76C RID: 190316 RVA: 0x00656ED8 File Offset: 0x006550D8
		public ICheckFlowLookAt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C74E RID: 51022
		// (get) Token: 0x0602E76D RID: 190317 RVA: 0x00656EE8 File Offset: 0x006550E8
		public EOverrideLookAtType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EOverrideLookAtType.CheckFlowLookAt;
				}
				return (EOverrideLookAtType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E76E RID: 190318 RVA: 0x00656F24 File Offset: 0x00655124
		public ICheckFlowLookAtConfig? CheckFlowLookAtConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ICheckFlowLookAtConfig?(default(ICheckFlowLookAtConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700C74F RID: 51023
		// (get) Token: 0x0602E76F RID: 190319 RVA: 0x00656F84 File Offset: 0x00655184
		public int CheckFlowLookAtConfigsLength
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

		// Token: 0x0602E770 RID: 190320 RVA: 0x00656FAF File Offset: 0x006551AF
		public static Offset<ICheckFlowLookAt> CreateICheckFlowLookAt(FlatBufferBuilder builder, EOverrideLookAtType Type = EOverrideLookAtType.CheckFlowLookAt, VectorOffset CheckFlowLookAtConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ICheckFlowLookAt.AddCheckFlowLookAtConfigs(builder, CheckFlowLookAtConfigsOffset);
			ICheckFlowLookAt.AddType(builder, Type);
			return ICheckFlowLookAt.EndICheckFlowLookAt(builder);
		}

		// Token: 0x0602E771 RID: 190321 RVA: 0x00656FCC File Offset: 0x006551CC
		public static void StartICheckFlowLookAt(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E772 RID: 190322 RVA: 0x00656FD5 File Offset: 0x006551D5
		public static void AddType(FlatBufferBuilder builder, EOverrideLookAtType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E773 RID: 190323 RVA: 0x00656FE0 File Offset: 0x006551E0
		public static void AddCheckFlowLookAtConfigs(FlatBufferBuilder builder, VectorOffset checkFlowLookAtConfigsOffset)
		{
			builder.AddOffset(1, checkFlowLookAtConfigsOffset.Value, 0);
		}

		// Token: 0x0602E774 RID: 190324 RVA: 0x00656FF0 File Offset: 0x006551F0
		public static VectorOffset CreateCheckFlowLookAtConfigsVector(FlatBufferBuilder builder, Offset<ICheckFlowLookAtConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602E775 RID: 190325 RVA: 0x00657030 File Offset: 0x00655230
		public static VectorOffset CreateCheckFlowLookAtConfigsVectorBlock(FlatBufferBuilder builder, Offset<ICheckFlowLookAtConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICheckFlowLookAtConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E776 RID: 190326 RVA: 0x0065704A File Offset: 0x0065524A
		public static VectorOffset CreateCheckFlowLookAtConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICheckFlowLookAtConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICheckFlowLookAtConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602E777 RID: 190327 RVA: 0x00657068 File Offset: 0x00655268
		public static VectorOffset CreateCheckFlowLookAtConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICheckFlowLookAtConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602E778 RID: 190328 RVA: 0x00657081 File Offset: 0x00655281
		public static void StartCheckFlowLookAtConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602E779 RID: 190329 RVA: 0x0065708C File Offset: 0x0065528C
		public static Offset<ICheckFlowLookAt> EndICheckFlowLookAt(FlatBufferBuilder builder)
		{
			return new Offset<ICheckFlowLookAt>(builder.EndTable());
		}

		// Token: 0x0602E77A RID: 190330 RVA: 0x0065709C File Offset: 0x0065529C
		public ICheckFlowLookAtT UnPack()
		{
			ICheckFlowLookAtT checkFlowLookAtT = new ICheckFlowLookAtT();
			this.UnPackTo(checkFlowLookAtT);
			return checkFlowLookAtT;
		}

		// Token: 0x0602E77B RID: 190331 RVA: 0x006570B8 File Offset: 0x006552B8
		public void UnPackTo(ICheckFlowLookAtT _o)
		{
			_o.Type = this.Type;
			_o.CheckFlowLookAtConfigs = new List<ICheckFlowLookAtConfigT>();
			for (int i = 0; i < this.CheckFlowLookAtConfigsLength; i++)
			{
				_o.CheckFlowLookAtConfigs.Add((this.CheckFlowLookAtConfigs(i) != null) ? this.CheckFlowLookAtConfigs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602E77C RID: 190332 RVA: 0x00657124 File Offset: 0x00655324
		public static Offset<ICheckFlowLookAt> Pack(FlatBufferBuilder builder, ICheckFlowLookAtT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckFlowLookAt>);
			}
			VectorOffset checkFlowLookAtConfigsOffset = default(VectorOffset);
			if (_o.CheckFlowLookAtConfigs != null)
			{
				Offset<ICheckFlowLookAtConfig>[] array = new Offset<ICheckFlowLookAtConfig>[_o.CheckFlowLookAtConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ICheckFlowLookAtConfig.Pack(builder, _o.CheckFlowLookAtConfigs[i]);
				}
				checkFlowLookAtConfigsOffset = ICheckFlowLookAt.CreateCheckFlowLookAtConfigsVector(builder, array);
			}
			return ICheckFlowLookAt.CreateICheckFlowLookAt(builder, _o.Type, checkFlowLookAtConfigsOffset);
		}

		// Token: 0x0401173D RID: 71485
		private Table __p;
	}
}
