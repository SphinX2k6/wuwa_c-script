using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200547B RID: 21627
	public struct ICableWay : IFlatbufferObject
	{
		// Token: 0x170099D3 RID: 39379
		// (get) Token: 0x06021FBB RID: 139195 RVA: 0x004AF295 File Offset: 0x004AD495
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021FBC RID: 139196 RVA: 0x004AF2A2 File Offset: 0x004AD4A2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021FBD RID: 139197 RVA: 0x004AF2AC File Offset: 0x004AD4AC
		public static ICableWay GetRootAsICableWay(ByteBuffer _bb)
		{
			return ICableWay.GetRootAsICableWay(_bb, default(ICableWay));
		}

		// Token: 0x06021FBE RID: 139198 RVA: 0x004AF2C8 File Offset: 0x004AD4C8
		public static ICableWay GetRootAsICableWay(ByteBuffer _bb, ICableWay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021FBF RID: 139199 RVA: 0x004AF2E5 File Offset: 0x004AD4E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021FC0 RID: 139200 RVA: 0x004AF2F4 File Offset: 0x004AD4F4
		public ICableWay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170099D4 RID: 39380
		// (get) Token: 0x06021FC1 RID: 139201 RVA: 0x004AF304 File Offset: 0x004AD504
		public EHookInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHookInteractType.FixedPointHook;
				}
				return (EHookInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021FC2 RID: 139202 RVA: 0x004AF340 File Offset: 0x004AD540
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170099D5 RID: 39381
		// (get) Token: 0x06021FC3 RID: 139203 RVA: 0x004AF3A0 File Offset: 0x004AD5A0
		public int HookActionsLength
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

		// Token: 0x06021FC4 RID: 139204 RVA: 0x004AF3CC File Offset: 0x004AD5CC
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170099D6 RID: 39382
		// (get) Token: 0x06021FC5 RID: 139205 RVA: 0x004AF42C File Offset: 0x004AD62C
		public int ExitHookActionsLength
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

		// Token: 0x06021FC6 RID: 139206 RVA: 0x004AF458 File Offset: 0x004AD658
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170099D7 RID: 39383
		// (get) Token: 0x06021FC7 RID: 139207 RVA: 0x004AF4BC File Offset: 0x004AD6BC
		public int FinishActionsLength
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

		// Token: 0x170099D8 RID: 39384
		// (get) Token: 0x06021FC8 RID: 139208 RVA: 0x004AF4E8 File Offset: 0x004AD6E8
		public IClientHookActionConfig? ClientHookActionConfig
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IClientHookActionConfig?(default(IClientHookActionConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170099D9 RID: 39385
		// (get) Token: 0x06021FC9 RID: 139209 RVA: 0x004AF548 File Offset: 0x004AD748
		public int SplineEntityId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170099DA RID: 39386
		// (get) Token: 0x06021FCA RID: 139210 RVA: 0x004AF588 File Offset: 0x004AD788
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

		// Token: 0x06021FCB RID: 139211 RVA: 0x004AF5C8 File Offset: 0x004AD7C8
		public static Offset<ICableWay> CreateICableWay(FlatBufferBuilder builder, EHookInteractType Type = EHookInteractType.FixedPointHook, VectorOffset HookActionsOffset = default(VectorOffset), VectorOffset ExitHookActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), Offset<IClientHookActionConfig> ClientHookActionConfigOffset = default(Offset<IClientHookActionConfig>), int SplineEntityId = 0, byte NullMask = 0)
		{
			builder.StartTable(7);
			ICableWay.AddSplineEntityId(builder, SplineEntityId);
			ICableWay.AddClientHookActionConfig(builder, ClientHookActionConfigOffset);
			ICableWay.AddFinishActions(builder, FinishActionsOffset);
			ICableWay.AddExitHookActions(builder, ExitHookActionsOffset);
			ICableWay.AddHookActions(builder, HookActionsOffset);
			ICableWay.AddNullMask(builder, NullMask);
			ICableWay.AddType(builder, Type);
			return ICableWay.EndICableWay(builder);
		}

		// Token: 0x06021FCC RID: 139212 RVA: 0x004AF617 File Offset: 0x004AD817
		public static void StartICableWay(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06021FCD RID: 139213 RVA: 0x004AF620 File Offset: 0x004AD820
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021FCE RID: 139214 RVA: 0x004AF62B File Offset: 0x004AD82B
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x06021FCF RID: 139215 RVA: 0x004AF63C File Offset: 0x004AD83C
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021FD0 RID: 139216 RVA: 0x004AF67C File Offset: 0x004AD87C
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021FD1 RID: 139217 RVA: 0x004AF696 File Offset: 0x004AD896
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021FD2 RID: 139218 RVA: 0x004AF6B4 File Offset: 0x004AD8B4
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021FD3 RID: 139219 RVA: 0x004AF6CD File Offset: 0x004AD8CD
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021FD4 RID: 139220 RVA: 0x004AF6D8 File Offset: 0x004AD8D8
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x06021FD5 RID: 139221 RVA: 0x004AF6E8 File Offset: 0x004AD8E8
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021FD6 RID: 139222 RVA: 0x004AF728 File Offset: 0x004AD928
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021FD7 RID: 139223 RVA: 0x004AF742 File Offset: 0x004AD942
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021FD8 RID: 139224 RVA: 0x004AF760 File Offset: 0x004AD960
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021FD9 RID: 139225 RVA: 0x004AF779 File Offset: 0x004AD979
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021FDA RID: 139226 RVA: 0x004AF784 File Offset: 0x004AD984
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x06021FDB RID: 139227 RVA: 0x004AF794 File Offset: 0x004AD994
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021FDC RID: 139228 RVA: 0x004AF7D4 File Offset: 0x004AD9D4
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021FDD RID: 139229 RVA: 0x004AF7EE File Offset: 0x004AD9EE
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021FDE RID: 139230 RVA: 0x004AF80C File Offset: 0x004ADA0C
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021FDF RID: 139231 RVA: 0x004AF825 File Offset: 0x004ADA25
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021FE0 RID: 139232 RVA: 0x004AF830 File Offset: 0x004ADA30
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x06021FE1 RID: 139233 RVA: 0x004AF840 File Offset: 0x004ADA40
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(5, splineEntityId, 0);
		}

		// Token: 0x06021FE2 RID: 139234 RVA: 0x004AF84B File Offset: 0x004ADA4B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06021FE3 RID: 139235 RVA: 0x004AF856 File Offset: 0x004ADA56
		public static Offset<ICableWay> EndICableWay(FlatBufferBuilder builder)
		{
			return new Offset<ICableWay>(builder.EndTable());
		}

		// Token: 0x06021FE4 RID: 139236 RVA: 0x004AF864 File Offset: 0x004ADA64
		public ICableWayT UnPack()
		{
			ICableWayT cableWayT = new ICableWayT();
			this.UnPackTo(cableWayT);
			return cableWayT;
		}

		// Token: 0x06021FE5 RID: 139237 RVA: 0x004AF880 File Offset: 0x004ADA80
		public void UnPackTo(ICableWayT _o)
		{
			_o.Type = this.Type;
			_o.HookActions = new List<IActionInfoT>();
			for (int i = 0; i < this.HookActionsLength; i++)
			{
				_o.HookActions.Add((this.HookActions(i) != null) ? this.HookActions(i).Value.UnPack() : null);
			}
			_o.ExitHookActions = new List<IActionInfoT>();
			for (int j = 0; j < this.ExitHookActionsLength; j++)
			{
				_o.ExitHookActions.Add((this.ExitHookActions(j) != null) ? this.ExitHookActions(j).Value.UnPack() : null);
			}
			_o.FinishActions = new List<IActionInfoT>();
			for (int k = 0; k < this.FinishActionsLength; k++)
			{
				_o.FinishActions.Add((this.FinishActions(k) != null) ? this.FinishActions(k).Value.UnPack() : null);
			}
			_o.ClientHookActionConfig = ((this.ClientHookActionConfig != null) ? this.ClientHookActionConfig.Value.UnPack() : null);
			_o.SplineEntityId = this.SplineEntityId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021FE6 RID: 139238 RVA: 0x004AF9E0 File Offset: 0x004ADBE0
		public static Offset<ICableWay> Pack(FlatBufferBuilder builder, ICableWayT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICableWay>);
			}
			VectorOffset hookActionsOffset = default(VectorOffset);
			if (_o.HookActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.HookActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.HookActions[i]);
				}
				hookActionsOffset = ICableWay.CreateHookActionsVector(builder, array);
			}
			VectorOffset exitHookActionsOffset = default(VectorOffset);
			if (_o.ExitHookActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ExitHookActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ExitHookActions[j]);
				}
				exitHookActionsOffset = ICableWay.CreateExitHookActionsVector(builder, array2);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.FinishActions[k]);
				}
				finishActionsOffset = ICableWay.CreateFinishActionsVector(builder, array3);
			}
			Offset<IClientHookActionConfig> clientHookActionConfigOffset = (_o.ClientHookActionConfig == null) ? default(Offset<IClientHookActionConfig>) : IClientHookActionConfig.Pack(builder, _o.ClientHookActionConfig);
			return ICableWay.CreateICableWay(builder, _o.Type, hookActionsOffset, exitHookActionsOffset, finishActionsOffset, clientHookActionConfigOffset, _o.SplineEntityId, _o.NullMask);
		}

		// Token: 0x0400E96B RID: 59755
		private Table __p;
	}
}
