using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052BE RID: 21182
	public struct IFoxJumpingPoint : IFlatbufferObject
	{
		// Token: 0x17009B4F RID: 39759
		// (get) Token: 0x06022891 RID: 141457 RVA: 0x004C94E8 File Offset: 0x004C76E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022892 RID: 141458 RVA: 0x004C94F5 File Offset: 0x004C76F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022893 RID: 141459 RVA: 0x004C94FC File Offset: 0x004C76FC
		public static IFoxJumpingPoint GetRootAsIFoxJumpingPoint(ByteBuffer _bb)
		{
			return IFoxJumpingPoint.GetRootAsIFoxJumpingPoint(_bb, default(IFoxJumpingPoint));
		}

		// Token: 0x06022894 RID: 141460 RVA: 0x004C9518 File Offset: 0x004C7718
		public static IFoxJumpingPoint GetRootAsIFoxJumpingPoint(ByteBuffer _bb, IFoxJumpingPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022895 RID: 141461 RVA: 0x004C9535 File Offset: 0x004C7735
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022896 RID: 141462 RVA: 0x004C9544 File Offset: 0x004C7744
		public IFoxJumpingPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009B50 RID: 39760
		// (get) Token: 0x06022897 RID: 141463 RVA: 0x004C9554 File Offset: 0x004C7754
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

		// Token: 0x06022898 RID: 141464 RVA: 0x004C9590 File Offset: 0x004C7790
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009B51 RID: 39761
		// (get) Token: 0x06022899 RID: 141465 RVA: 0x004C95F0 File Offset: 0x004C77F0
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

		// Token: 0x0602289A RID: 141466 RVA: 0x004C961C File Offset: 0x004C781C
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009B52 RID: 39762
		// (get) Token: 0x0602289B RID: 141467 RVA: 0x004C967C File Offset: 0x004C787C
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

		// Token: 0x0602289C RID: 141468 RVA: 0x004C96A8 File Offset: 0x004C78A8
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009B53 RID: 39763
		// (get) Token: 0x0602289D RID: 141469 RVA: 0x004C970C File Offset: 0x004C790C
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

		// Token: 0x17009B54 RID: 39764
		// (get) Token: 0x0602289E RID: 141470 RVA: 0x004C9738 File Offset: 0x004C7938
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

		// Token: 0x17009B55 RID: 39765
		// (get) Token: 0x0602289F RID: 141471 RVA: 0x004C9798 File Offset: 0x004C7998
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060228A0 RID: 141472 RVA: 0x004C97D5 File Offset: 0x004C79D5
		public static Offset<IFoxJumpingPoint> CreateIFoxJumpingPoint(FlatBufferBuilder builder, EHookInteractType Type = EHookInteractType.FixedPointHook, VectorOffset HookActionsOffset = default(VectorOffset), VectorOffset ExitHookActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), Offset<IClientHookActionConfig> ClientHookActionConfigOffset = default(Offset<IClientHookActionConfig>), byte NullMask = 0)
		{
			builder.StartTable(6);
			IFoxJumpingPoint.AddClientHookActionConfig(builder, ClientHookActionConfigOffset);
			IFoxJumpingPoint.AddFinishActions(builder, FinishActionsOffset);
			IFoxJumpingPoint.AddExitHookActions(builder, ExitHookActionsOffset);
			IFoxJumpingPoint.AddHookActions(builder, HookActionsOffset);
			IFoxJumpingPoint.AddNullMask(builder, NullMask);
			IFoxJumpingPoint.AddType(builder, Type);
			return IFoxJumpingPoint.EndIFoxJumpingPoint(builder);
		}

		// Token: 0x060228A1 RID: 141473 RVA: 0x004C9811 File Offset: 0x004C7A11
		public static void StartIFoxJumpingPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060228A2 RID: 141474 RVA: 0x004C981A File Offset: 0x004C7A1A
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060228A3 RID: 141475 RVA: 0x004C9825 File Offset: 0x004C7A25
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x060228A4 RID: 141476 RVA: 0x004C9838 File Offset: 0x004C7A38
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060228A5 RID: 141477 RVA: 0x004C9878 File Offset: 0x004C7A78
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060228A6 RID: 141478 RVA: 0x004C9892 File Offset: 0x004C7A92
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060228A7 RID: 141479 RVA: 0x004C98B0 File Offset: 0x004C7AB0
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060228A8 RID: 141480 RVA: 0x004C98C9 File Offset: 0x004C7AC9
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060228A9 RID: 141481 RVA: 0x004C98D4 File Offset: 0x004C7AD4
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x060228AA RID: 141482 RVA: 0x004C98E4 File Offset: 0x004C7AE4
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060228AB RID: 141483 RVA: 0x004C9924 File Offset: 0x004C7B24
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060228AC RID: 141484 RVA: 0x004C993E File Offset: 0x004C7B3E
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060228AD RID: 141485 RVA: 0x004C995C File Offset: 0x004C7B5C
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060228AE RID: 141486 RVA: 0x004C9975 File Offset: 0x004C7B75
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060228AF RID: 141487 RVA: 0x004C9980 File Offset: 0x004C7B80
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x060228B0 RID: 141488 RVA: 0x004C9990 File Offset: 0x004C7B90
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060228B1 RID: 141489 RVA: 0x004C99D0 File Offset: 0x004C7BD0
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060228B2 RID: 141490 RVA: 0x004C99EA File Offset: 0x004C7BEA
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060228B3 RID: 141491 RVA: 0x004C9A08 File Offset: 0x004C7C08
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060228B4 RID: 141492 RVA: 0x004C9A21 File Offset: 0x004C7C21
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060228B5 RID: 141493 RVA: 0x004C9A2C File Offset: 0x004C7C2C
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x060228B6 RID: 141494 RVA: 0x004C9A3C File Offset: 0x004C7C3C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060228B7 RID: 141495 RVA: 0x004C9A47 File Offset: 0x004C7C47
		public static Offset<IFoxJumpingPoint> EndIFoxJumpingPoint(FlatBufferBuilder builder)
		{
			return new Offset<IFoxJumpingPoint>(builder.EndTable());
		}

		// Token: 0x060228B8 RID: 141496 RVA: 0x004C9A54 File Offset: 0x004C7C54
		public IFoxJumpingPointT UnPack()
		{
			IFoxJumpingPointT foxJumpingPointT = new IFoxJumpingPointT();
			this.UnPackTo(foxJumpingPointT);
			return foxJumpingPointT;
		}

		// Token: 0x060228B9 RID: 141497 RVA: 0x004C9A70 File Offset: 0x004C7C70
		public void UnPackTo(IFoxJumpingPointT _o)
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
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060228BA RID: 141498 RVA: 0x004C9BC4 File Offset: 0x004C7DC4
		public static Offset<IFoxJumpingPoint> Pack(FlatBufferBuilder builder, IFoxJumpingPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFoxJumpingPoint>);
			}
			VectorOffset hookActionsOffset = default(VectorOffset);
			if (_o.HookActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.HookActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.HookActions[i]);
				}
				hookActionsOffset = IFoxJumpingPoint.CreateHookActionsVector(builder, array);
			}
			VectorOffset exitHookActionsOffset = default(VectorOffset);
			if (_o.ExitHookActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ExitHookActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ExitHookActions[j]);
				}
				exitHookActionsOffset = IFoxJumpingPoint.CreateExitHookActionsVector(builder, array2);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.FinishActions[k]);
				}
				finishActionsOffset = IFoxJumpingPoint.CreateFinishActionsVector(builder, array3);
			}
			Offset<IClientHookActionConfig> clientHookActionConfigOffset = (_o.ClientHookActionConfig == null) ? default(Offset<IClientHookActionConfig>) : IClientHookActionConfig.Pack(builder, _o.ClientHookActionConfig);
			return IFoxJumpingPoint.CreateIFoxJumpingPoint(builder, _o.Type, hookActionsOffset, exitHookActionsOffset, finishActionsOffset, clientHookActionConfigOffset, _o.NullMask);
		}

		// Token: 0x0400E43E RID: 58430
		private Table __p;
	}
}
