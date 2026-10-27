using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F4C RID: 20300
	public struct ICableWay : IFlatbufferObject
	{
		// Token: 0x1700925A RID: 37466
		// (get) Token: 0x06020269 RID: 131689 RVA: 0x004792A5 File Offset: 0x004774A5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602026A RID: 131690 RVA: 0x004792B2 File Offset: 0x004774B2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602026B RID: 131691 RVA: 0x004792BC File Offset: 0x004774BC
		public static ICableWay GetRootAsICableWay(ByteBuffer _bb)
		{
			return ICableWay.GetRootAsICableWay(_bb, default(ICableWay));
		}

		// Token: 0x0602026C RID: 131692 RVA: 0x004792D8 File Offset: 0x004774D8
		public static ICableWay GetRootAsICableWay(ByteBuffer _bb, ICableWay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602026D RID: 131693 RVA: 0x004792F5 File Offset: 0x004774F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602026E RID: 131694 RVA: 0x00479304 File Offset: 0x00477504
		public ICableWay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700925B RID: 37467
		// (get) Token: 0x0602026F RID: 131695 RVA: 0x00479314 File Offset: 0x00477514
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

		// Token: 0x06020270 RID: 131696 RVA: 0x00479350 File Offset: 0x00477550
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700925C RID: 37468
		// (get) Token: 0x06020271 RID: 131697 RVA: 0x004793B0 File Offset: 0x004775B0
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

		// Token: 0x06020272 RID: 131698 RVA: 0x004793DC File Offset: 0x004775DC
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700925D RID: 37469
		// (get) Token: 0x06020273 RID: 131699 RVA: 0x0047943C File Offset: 0x0047763C
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

		// Token: 0x06020274 RID: 131700 RVA: 0x00479468 File Offset: 0x00477668
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700925E RID: 37470
		// (get) Token: 0x06020275 RID: 131701 RVA: 0x004794CC File Offset: 0x004776CC
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

		// Token: 0x1700925F RID: 37471
		// (get) Token: 0x06020276 RID: 131702 RVA: 0x004794F8 File Offset: 0x004776F8
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

		// Token: 0x17009260 RID: 37472
		// (get) Token: 0x06020277 RID: 131703 RVA: 0x00479558 File Offset: 0x00477758
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

		// Token: 0x17009261 RID: 37473
		// (get) Token: 0x06020278 RID: 131704 RVA: 0x00479598 File Offset: 0x00477798
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

		// Token: 0x06020279 RID: 131705 RVA: 0x004795D8 File Offset: 0x004777D8
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

		// Token: 0x0602027A RID: 131706 RVA: 0x00479627 File Offset: 0x00477827
		public static void StartICableWay(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602027B RID: 131707 RVA: 0x00479630 File Offset: 0x00477830
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602027C RID: 131708 RVA: 0x0047963B File Offset: 0x0047783B
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x0602027D RID: 131709 RVA: 0x0047964C File Offset: 0x0047784C
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602027E RID: 131710 RVA: 0x0047968C File Offset: 0x0047788C
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602027F RID: 131711 RVA: 0x004796A6 File Offset: 0x004778A6
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020280 RID: 131712 RVA: 0x004796C4 File Offset: 0x004778C4
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020281 RID: 131713 RVA: 0x004796DD File Offset: 0x004778DD
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020282 RID: 131714 RVA: 0x004796E8 File Offset: 0x004778E8
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x06020283 RID: 131715 RVA: 0x004796F8 File Offset: 0x004778F8
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06020284 RID: 131716 RVA: 0x00479738 File Offset: 0x00477938
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020285 RID: 131717 RVA: 0x00479752 File Offset: 0x00477952
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020286 RID: 131718 RVA: 0x00479770 File Offset: 0x00477970
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020287 RID: 131719 RVA: 0x00479789 File Offset: 0x00477989
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020288 RID: 131720 RVA: 0x00479794 File Offset: 0x00477994
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x06020289 RID: 131721 RVA: 0x004797A4 File Offset: 0x004779A4
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602028A RID: 131722 RVA: 0x004797E4 File Offset: 0x004779E4
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602028B RID: 131723 RVA: 0x004797FE File Offset: 0x004779FE
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602028C RID: 131724 RVA: 0x0047981C File Offset: 0x00477A1C
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602028D RID: 131725 RVA: 0x00479835 File Offset: 0x00477A35
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602028E RID: 131726 RVA: 0x00479840 File Offset: 0x00477A40
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x0602028F RID: 131727 RVA: 0x00479850 File Offset: 0x00477A50
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(5, splineEntityId, 0);
		}

		// Token: 0x06020290 RID: 131728 RVA: 0x0047985B File Offset: 0x00477A5B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06020291 RID: 131729 RVA: 0x00479866 File Offset: 0x00477A66
		public static Offset<ICableWay> EndICableWay(FlatBufferBuilder builder)
		{
			return new Offset<ICableWay>(builder.EndTable());
		}

		// Token: 0x06020292 RID: 131730 RVA: 0x00479874 File Offset: 0x00477A74
		public ICableWayT UnPack()
		{
			ICableWayT cableWayT = new ICableWayT();
			this.UnPackTo(cableWayT);
			return cableWayT;
		}

		// Token: 0x06020293 RID: 131731 RVA: 0x00479890 File Offset: 0x00477A90
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

		// Token: 0x06020294 RID: 131732 RVA: 0x004799F0 File Offset: 0x00477BF0
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

		// Token: 0x0400DDC1 RID: 56769
		private Table __p;
	}
}
