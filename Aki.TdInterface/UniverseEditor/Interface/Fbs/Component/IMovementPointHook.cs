using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055DE RID: 21982
	public struct IMovementPointHook : IFlatbufferObject
	{
		// Token: 0x1700A2A0 RID: 41632
		// (get) Token: 0x0602474D RID: 149325 RVA: 0x00508450 File Offset: 0x00506650
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602474E RID: 149326 RVA: 0x0050845D File Offset: 0x0050665D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602474F RID: 149327 RVA: 0x00508464 File Offset: 0x00506664
		public static IMovementPointHook GetRootAsIMovementPointHook(ByteBuffer _bb)
		{
			return IMovementPointHook.GetRootAsIMovementPointHook(_bb, default(IMovementPointHook));
		}

		// Token: 0x06024750 RID: 149328 RVA: 0x00508480 File Offset: 0x00506680
		public static IMovementPointHook GetRootAsIMovementPointHook(ByteBuffer _bb, IMovementPointHook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024751 RID: 149329 RVA: 0x0050849D File Offset: 0x0050669D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024752 RID: 149330 RVA: 0x005084AC File Offset: 0x005066AC
		public IMovementPointHook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A2A1 RID: 41633
		// (get) Token: 0x06024753 RID: 149331 RVA: 0x005084BC File Offset: 0x005066BC
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

		// Token: 0x06024754 RID: 149332 RVA: 0x005084F8 File Offset: 0x005066F8
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A2A2 RID: 41634
		// (get) Token: 0x06024755 RID: 149333 RVA: 0x00508558 File Offset: 0x00506758
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

		// Token: 0x06024756 RID: 149334 RVA: 0x00508584 File Offset: 0x00506784
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A2A3 RID: 41635
		// (get) Token: 0x06024757 RID: 149335 RVA: 0x005085E4 File Offset: 0x005067E4
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

		// Token: 0x06024758 RID: 149336 RVA: 0x00508610 File Offset: 0x00506810
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A2A4 RID: 41636
		// (get) Token: 0x06024759 RID: 149337 RVA: 0x00508674 File Offset: 0x00506874
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

		// Token: 0x1700A2A5 RID: 41637
		// (get) Token: 0x0602475A RID: 149338 RVA: 0x005086A0 File Offset: 0x005068A0
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

		// Token: 0x1700A2A6 RID: 41638
		// (get) Token: 0x0602475B RID: 149339 RVA: 0x00508700 File Offset: 0x00506900
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

		// Token: 0x0602475C RID: 149340 RVA: 0x0050873D File Offset: 0x0050693D
		public static Offset<IMovementPointHook> CreateIMovementPointHook(FlatBufferBuilder builder, EHookInteractType Type = EHookInteractType.FixedPointHook, VectorOffset HookActionsOffset = default(VectorOffset), VectorOffset ExitHookActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), Offset<IClientHookActionConfig> ClientHookActionConfigOffset = default(Offset<IClientHookActionConfig>), byte NullMask = 0)
		{
			builder.StartTable(6);
			IMovementPointHook.AddClientHookActionConfig(builder, ClientHookActionConfigOffset);
			IMovementPointHook.AddFinishActions(builder, FinishActionsOffset);
			IMovementPointHook.AddExitHookActions(builder, ExitHookActionsOffset);
			IMovementPointHook.AddHookActions(builder, HookActionsOffset);
			IMovementPointHook.AddNullMask(builder, NullMask);
			IMovementPointHook.AddType(builder, Type);
			return IMovementPointHook.EndIMovementPointHook(builder);
		}

		// Token: 0x0602475D RID: 149341 RVA: 0x00508779 File Offset: 0x00506979
		public static void StartIMovementPointHook(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602475E RID: 149342 RVA: 0x00508782 File Offset: 0x00506982
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602475F RID: 149343 RVA: 0x0050878D File Offset: 0x0050698D
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x06024760 RID: 149344 RVA: 0x005087A0 File Offset: 0x005069A0
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024761 RID: 149345 RVA: 0x005087E0 File Offset: 0x005069E0
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024762 RID: 149346 RVA: 0x005087FA File Offset: 0x005069FA
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024763 RID: 149347 RVA: 0x00508818 File Offset: 0x00506A18
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024764 RID: 149348 RVA: 0x00508831 File Offset: 0x00506A31
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024765 RID: 149349 RVA: 0x0050883C File Offset: 0x00506A3C
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x06024766 RID: 149350 RVA: 0x0050884C File Offset: 0x00506A4C
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024767 RID: 149351 RVA: 0x0050888C File Offset: 0x00506A8C
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024768 RID: 149352 RVA: 0x005088A6 File Offset: 0x00506AA6
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024769 RID: 149353 RVA: 0x005088C4 File Offset: 0x00506AC4
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602476A RID: 149354 RVA: 0x005088DD File Offset: 0x00506ADD
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602476B RID: 149355 RVA: 0x005088E8 File Offset: 0x00506AE8
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x0602476C RID: 149356 RVA: 0x005088F8 File Offset: 0x00506AF8
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602476D RID: 149357 RVA: 0x00508938 File Offset: 0x00506B38
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602476E RID: 149358 RVA: 0x00508952 File Offset: 0x00506B52
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602476F RID: 149359 RVA: 0x00508970 File Offset: 0x00506B70
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024770 RID: 149360 RVA: 0x00508989 File Offset: 0x00506B89
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024771 RID: 149361 RVA: 0x00508994 File Offset: 0x00506B94
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x06024772 RID: 149362 RVA: 0x005089A4 File Offset: 0x00506BA4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06024773 RID: 149363 RVA: 0x005089AF File Offset: 0x00506BAF
		public static Offset<IMovementPointHook> EndIMovementPointHook(FlatBufferBuilder builder)
		{
			return new Offset<IMovementPointHook>(builder.EndTable());
		}

		// Token: 0x06024774 RID: 149364 RVA: 0x005089BC File Offset: 0x00506BBC
		public IMovementPointHookT UnPack()
		{
			IMovementPointHookT movementPointHookT = new IMovementPointHookT();
			this.UnPackTo(movementPointHookT);
			return movementPointHookT;
		}

		// Token: 0x06024775 RID: 149365 RVA: 0x005089D8 File Offset: 0x00506BD8
		public void UnPackTo(IMovementPointHookT _o)
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

		// Token: 0x06024776 RID: 149366 RVA: 0x00508B2C File Offset: 0x00506D2C
		public static Offset<IMovementPointHook> Pack(FlatBufferBuilder builder, IMovementPointHookT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMovementPointHook>);
			}
			VectorOffset hookActionsOffset = default(VectorOffset);
			if (_o.HookActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.HookActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.HookActions[i]);
				}
				hookActionsOffset = IMovementPointHook.CreateHookActionsVector(builder, array);
			}
			VectorOffset exitHookActionsOffset = default(VectorOffset);
			if (_o.ExitHookActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ExitHookActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ExitHookActions[j]);
				}
				exitHookActionsOffset = IMovementPointHook.CreateExitHookActionsVector(builder, array2);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.FinishActions[k]);
				}
				finishActionsOffset = IMovementPointHook.CreateFinishActionsVector(builder, array3);
			}
			Offset<IClientHookActionConfig> clientHookActionConfigOffset = (_o.ClientHookActionConfig == null) ? default(Offset<IClientHookActionConfig>) : IClientHookActionConfig.Pack(builder, _o.ClientHookActionConfig);
			return IMovementPointHook.CreateIMovementPointHook(builder, _o.Type, hookActionsOffset, exitHookActionsOffset, finishActionsOffset, clientHookActionConfigOffset, _o.NullMask);
		}

		// Token: 0x0400E942 RID: 59714
		private Table __p;
	}
}
