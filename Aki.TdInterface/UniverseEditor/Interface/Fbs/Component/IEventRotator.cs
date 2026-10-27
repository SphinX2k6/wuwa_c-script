using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051C8 RID: 20936
	public struct IEventRotator : IFlatbufferObject
	{
		// Token: 0x17009936 RID: 39222
		// (get) Token: 0x06021F04 RID: 139012 RVA: 0x004B54F8 File Offset: 0x004B36F8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021F05 RID: 139013 RVA: 0x004B5505 File Offset: 0x004B3705
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021F06 RID: 139014 RVA: 0x004B550C File Offset: 0x004B370C
		public static IEventRotator GetRootAsIEventRotator(ByteBuffer _bb)
		{
			return IEventRotator.GetRootAsIEventRotator(_bb, default(IEventRotator));
		}

		// Token: 0x06021F07 RID: 139015 RVA: 0x004B5528 File Offset: 0x004B3728
		public static IEventRotator GetRootAsIEventRotator(ByteBuffer _bb, IEventRotator obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021F08 RID: 139016 RVA: 0x004B5545 File Offset: 0x004B3745
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021F09 RID: 139017 RVA: 0x004B5554 File Offset: 0x004B3754
		public IEventRotator __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06021F0A RID: 139018 RVA: 0x004B5564 File Offset: 0x004B3764
		public IActionInfo? StartActions(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009937 RID: 39223
		// (get) Token: 0x06021F0B RID: 139019 RVA: 0x004B55C4 File Offset: 0x004B37C4
		public int StartActionsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06021F0C RID: 139020 RVA: 0x004B55F0 File Offset: 0x004B37F0
		public IActionInfo? EndActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009938 RID: 39224
		// (get) Token: 0x06021F0D RID: 139021 RVA: 0x004B5650 File Offset: 0x004B3850
		public int EndActionsLength
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

		// Token: 0x06021F0E RID: 139022 RVA: 0x004B567B File Offset: 0x004B387B
		public static Offset<IEventRotator> CreateIEventRotator(FlatBufferBuilder builder, VectorOffset StartActionsOffset = default(VectorOffset), VectorOffset EndActionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IEventRotator.AddEndActions(builder, EndActionsOffset);
			IEventRotator.AddStartActions(builder, StartActionsOffset);
			return IEventRotator.EndIEventRotator(builder);
		}

		// Token: 0x06021F0F RID: 139023 RVA: 0x004B5698 File Offset: 0x004B3898
		public static void StartIEventRotator(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06021F10 RID: 139024 RVA: 0x004B56A1 File Offset: 0x004B38A1
		public static void AddStartActions(FlatBufferBuilder builder, VectorOffset startActionsOffset)
		{
			builder.AddOffset(0, startActionsOffset.Value, 0);
		}

		// Token: 0x06021F11 RID: 139025 RVA: 0x004B56B4 File Offset: 0x004B38B4
		public static VectorOffset CreateStartActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021F12 RID: 139026 RVA: 0x004B56F4 File Offset: 0x004B38F4
		public static VectorOffset CreateStartActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021F13 RID: 139027 RVA: 0x004B570E File Offset: 0x004B390E
		public static VectorOffset CreateStartActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021F14 RID: 139028 RVA: 0x004B572C File Offset: 0x004B392C
		public static VectorOffset CreateStartActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021F15 RID: 139029 RVA: 0x004B5745 File Offset: 0x004B3945
		public static void StartStartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021F16 RID: 139030 RVA: 0x004B5750 File Offset: 0x004B3950
		public static void AddEndActions(FlatBufferBuilder builder, VectorOffset endActionsOffset)
		{
			builder.AddOffset(1, endActionsOffset.Value, 0);
		}

		// Token: 0x06021F17 RID: 139031 RVA: 0x004B5760 File Offset: 0x004B3960
		public static VectorOffset CreateEndActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021F18 RID: 139032 RVA: 0x004B57A0 File Offset: 0x004B39A0
		public static VectorOffset CreateEndActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021F19 RID: 139033 RVA: 0x004B57BA File Offset: 0x004B39BA
		public static VectorOffset CreateEndActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021F1A RID: 139034 RVA: 0x004B57D8 File Offset: 0x004B39D8
		public static VectorOffset CreateEndActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021F1B RID: 139035 RVA: 0x004B57F1 File Offset: 0x004B39F1
		public static void StartEndActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021F1C RID: 139036 RVA: 0x004B57FC File Offset: 0x004B39FC
		public static Offset<IEventRotator> EndIEventRotator(FlatBufferBuilder builder)
		{
			return new Offset<IEventRotator>(builder.EndTable());
		}

		// Token: 0x06021F1D RID: 139037 RVA: 0x004B580C File Offset: 0x004B3A0C
		public IEventRotatorT UnPack()
		{
			IEventRotatorT eventRotatorT = new IEventRotatorT();
			this.UnPackTo(eventRotatorT);
			return eventRotatorT;
		}

		// Token: 0x06021F1E RID: 139038 RVA: 0x004B5828 File Offset: 0x004B3A28
		public void UnPackTo(IEventRotatorT _o)
		{
			_o.StartActions = new List<IActionInfoT>();
			for (int i = 0; i < this.StartActionsLength; i++)
			{
				_o.StartActions.Add((this.StartActions(i) != null) ? this.StartActions(i).Value.UnPack() : null);
			}
			_o.EndActions = new List<IActionInfoT>();
			for (int j = 0; j < this.EndActionsLength; j++)
			{
				_o.EndActions.Add((this.EndActions(j) != null) ? this.EndActions(j).Value.UnPack() : null);
			}
		}

		// Token: 0x06021F1F RID: 139039 RVA: 0x004B58DC File Offset: 0x004B3ADC
		public static Offset<IEventRotator> Pack(FlatBufferBuilder builder, IEventRotatorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEventRotator>);
			}
			VectorOffset startActionsOffset = default(VectorOffset);
			if (_o.StartActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.StartActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.StartActions[i]);
				}
				startActionsOffset = IEventRotator.CreateStartActionsVector(builder, array);
			}
			VectorOffset endActionsOffset = default(VectorOffset);
			if (_o.EndActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.EndActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.EndActions[j]);
				}
				endActionsOffset = IEventRotator.CreateEndActionsVector(builder, array2);
			}
			return IEventRotator.CreateIEventRotator(builder, startActionsOffset, endActionsOffset);
		}

		// Token: 0x0400E2CA RID: 58058
		private Table __p;
	}
}
