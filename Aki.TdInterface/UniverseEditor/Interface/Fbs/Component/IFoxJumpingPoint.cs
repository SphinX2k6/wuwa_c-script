using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005829 RID: 22569
	public struct IFoxJumpingPoint : IFlatbufferObject
	{
		// Token: 0x1700A358 RID: 41816
		// (get) Token: 0x06024855 RID: 149589 RVA: 0x005045E4 File Offset: 0x005027E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024856 RID: 149590 RVA: 0x005045F1 File Offset: 0x005027F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024857 RID: 149591 RVA: 0x005045F8 File Offset: 0x005027F8
		public static IFoxJumpingPoint GetRootAsIFoxJumpingPoint(ByteBuffer _bb)
		{
			return IFoxJumpingPoint.GetRootAsIFoxJumpingPoint(_bb, default(IFoxJumpingPoint));
		}

		// Token: 0x06024858 RID: 149592 RVA: 0x00504614 File Offset: 0x00502814
		public static IFoxJumpingPoint GetRootAsIFoxJumpingPoint(ByteBuffer _bb, IFoxJumpingPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024859 RID: 149593 RVA: 0x00504631 File Offset: 0x00502831
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602485A RID: 149594 RVA: 0x00504640 File Offset: 0x00502840
		public IFoxJumpingPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A359 RID: 41817
		// (get) Token: 0x0602485B RID: 149595 RVA: 0x00504650 File Offset: 0x00502850
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

		// Token: 0x0602485C RID: 149596 RVA: 0x0050468C File Offset: 0x0050288C
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A35A RID: 41818
		// (get) Token: 0x0602485D RID: 149597 RVA: 0x005046EC File Offset: 0x005028EC
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

		// Token: 0x0602485E RID: 149598 RVA: 0x00504718 File Offset: 0x00502918
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A35B RID: 41819
		// (get) Token: 0x0602485F RID: 149599 RVA: 0x00504778 File Offset: 0x00502978
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

		// Token: 0x06024860 RID: 149600 RVA: 0x005047A4 File Offset: 0x005029A4
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A35C RID: 41820
		// (get) Token: 0x06024861 RID: 149601 RVA: 0x00504808 File Offset: 0x00502A08
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

		// Token: 0x1700A35D RID: 41821
		// (get) Token: 0x06024862 RID: 149602 RVA: 0x00504834 File Offset: 0x00502A34
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

		// Token: 0x1700A35E RID: 41822
		// (get) Token: 0x06024863 RID: 149603 RVA: 0x00504894 File Offset: 0x00502A94
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

		// Token: 0x06024864 RID: 149604 RVA: 0x005048D1 File Offset: 0x00502AD1
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

		// Token: 0x06024865 RID: 149605 RVA: 0x0050490D File Offset: 0x00502B0D
		public static void StartIFoxJumpingPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06024866 RID: 149606 RVA: 0x00504916 File Offset: 0x00502B16
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024867 RID: 149607 RVA: 0x00504921 File Offset: 0x00502B21
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x06024868 RID: 149608 RVA: 0x00504934 File Offset: 0x00502B34
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024869 RID: 149609 RVA: 0x00504974 File Offset: 0x00502B74
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602486A RID: 149610 RVA: 0x0050498E File Offset: 0x00502B8E
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602486B RID: 149611 RVA: 0x005049AC File Offset: 0x00502BAC
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602486C RID: 149612 RVA: 0x005049C5 File Offset: 0x00502BC5
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602486D RID: 149613 RVA: 0x005049D0 File Offset: 0x00502BD0
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x0602486E RID: 149614 RVA: 0x005049E0 File Offset: 0x00502BE0
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602486F RID: 149615 RVA: 0x00504A20 File Offset: 0x00502C20
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024870 RID: 149616 RVA: 0x00504A3A File Offset: 0x00502C3A
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024871 RID: 149617 RVA: 0x00504A58 File Offset: 0x00502C58
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024872 RID: 149618 RVA: 0x00504A71 File Offset: 0x00502C71
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024873 RID: 149619 RVA: 0x00504A7C File Offset: 0x00502C7C
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x06024874 RID: 149620 RVA: 0x00504A8C File Offset: 0x00502C8C
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024875 RID: 149621 RVA: 0x00504ACC File Offset: 0x00502CCC
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024876 RID: 149622 RVA: 0x00504AE6 File Offset: 0x00502CE6
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024877 RID: 149623 RVA: 0x00504B04 File Offset: 0x00502D04
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024878 RID: 149624 RVA: 0x00504B1D File Offset: 0x00502D1D
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024879 RID: 149625 RVA: 0x00504B28 File Offset: 0x00502D28
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x0602487A RID: 149626 RVA: 0x00504B38 File Offset: 0x00502D38
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602487B RID: 149627 RVA: 0x00504B43 File Offset: 0x00502D43
		public static Offset<IFoxJumpingPoint> EndIFoxJumpingPoint(FlatBufferBuilder builder)
		{
			return new Offset<IFoxJumpingPoint>(builder.EndTable());
		}

		// Token: 0x0602487C RID: 149628 RVA: 0x00504B50 File Offset: 0x00502D50
		public IFoxJumpingPointT UnPack()
		{
			IFoxJumpingPointT foxJumpingPointT = new IFoxJumpingPointT();
			this.UnPackTo(foxJumpingPointT);
			return foxJumpingPointT;
		}

		// Token: 0x0602487D RID: 149629 RVA: 0x00504B6C File Offset: 0x00502D6C
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

		// Token: 0x0602487E RID: 149630 RVA: 0x00504CC0 File Offset: 0x00502EC0
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

		// Token: 0x0400F04B RID: 61515
		private Table __p;
	}
}
