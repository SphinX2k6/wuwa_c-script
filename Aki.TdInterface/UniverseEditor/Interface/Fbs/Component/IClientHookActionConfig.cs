using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005505 RID: 21765
	public struct IClientHookActionConfig : IFlatbufferObject
	{
		// Token: 0x17009B82 RID: 39810
		// (get) Token: 0x06022619 RID: 140825 RVA: 0x004BCE2B File Offset: 0x004BB02B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602261A RID: 140826 RVA: 0x004BCE38 File Offset: 0x004BB038
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602261B RID: 140827 RVA: 0x004BCE40 File Offset: 0x004BB040
		public static IClientHookActionConfig GetRootAsIClientHookActionConfig(ByteBuffer _bb)
		{
			return IClientHookActionConfig.GetRootAsIClientHookActionConfig(_bb, default(IClientHookActionConfig));
		}

		// Token: 0x0602261C RID: 140828 RVA: 0x004BCE5C File Offset: 0x004BB05C
		public static IClientHookActionConfig GetRootAsIClientHookActionConfig(ByteBuffer _bb, IClientHookActionConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602261D RID: 140829 RVA: 0x004BCE79 File Offset: 0x004BB079
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602261E RID: 140830 RVA: 0x004BCE88 File Offset: 0x004BB088
		public IClientHookActionConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602261F RID: 140831 RVA: 0x004BCE98 File Offset: 0x004BB098
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009B83 RID: 39811
		// (get) Token: 0x06022620 RID: 140832 RVA: 0x004BCEF8 File Offset: 0x004BB0F8
		public int HookActionsLength
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

		// Token: 0x06022621 RID: 140833 RVA: 0x004BCF24 File Offset: 0x004BB124
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009B84 RID: 39812
		// (get) Token: 0x06022622 RID: 140834 RVA: 0x004BCF84 File Offset: 0x004BB184
		public int ExitHookActionsLength
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

		// Token: 0x06022623 RID: 140835 RVA: 0x004BCFB0 File Offset: 0x004BB1B0
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009B85 RID: 39813
		// (get) Token: 0x06022624 RID: 140836 RVA: 0x004BD010 File Offset: 0x004BB210
		public int FinishActionsLength
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

		// Token: 0x17009B86 RID: 39814
		// (get) Token: 0x06022625 RID: 140837 RVA: 0x004BD03C File Offset: 0x004BB23C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022626 RID: 140838 RVA: 0x004BD079 File Offset: 0x004BB279
		public static Offset<IClientHookActionConfig> CreateIClientHookActionConfig(FlatBufferBuilder builder, VectorOffset HookActionsOffset = default(VectorOffset), VectorOffset ExitHookActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IClientHookActionConfig.AddFinishActions(builder, FinishActionsOffset);
			IClientHookActionConfig.AddExitHookActions(builder, ExitHookActionsOffset);
			IClientHookActionConfig.AddHookActions(builder, HookActionsOffset);
			IClientHookActionConfig.AddNullMask(builder, NullMask);
			return IClientHookActionConfig.EndIClientHookActionConfig(builder);
		}

		// Token: 0x06022627 RID: 140839 RVA: 0x004BD0A5 File Offset: 0x004BB2A5
		public static void StartIClientHookActionConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06022628 RID: 140840 RVA: 0x004BD0AE File Offset: 0x004BB2AE
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(0, hookActionsOffset.Value, 0);
		}

		// Token: 0x06022629 RID: 140841 RVA: 0x004BD0C0 File Offset: 0x004BB2C0
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602262A RID: 140842 RVA: 0x004BD100 File Offset: 0x004BB300
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602262B RID: 140843 RVA: 0x004BD11A File Offset: 0x004BB31A
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602262C RID: 140844 RVA: 0x004BD138 File Offset: 0x004BB338
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602262D RID: 140845 RVA: 0x004BD151 File Offset: 0x004BB351
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602262E RID: 140846 RVA: 0x004BD15C File Offset: 0x004BB35C
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(1, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x0602262F RID: 140847 RVA: 0x004BD16C File Offset: 0x004BB36C
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022630 RID: 140848 RVA: 0x004BD1AC File Offset: 0x004BB3AC
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022631 RID: 140849 RVA: 0x004BD1C6 File Offset: 0x004BB3C6
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022632 RID: 140850 RVA: 0x004BD1E4 File Offset: 0x004BB3E4
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022633 RID: 140851 RVA: 0x004BD1FD File Offset: 0x004BB3FD
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022634 RID: 140852 RVA: 0x004BD208 File Offset: 0x004BB408
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(2, finishActionsOffset.Value, 0);
		}

		// Token: 0x06022635 RID: 140853 RVA: 0x004BD218 File Offset: 0x004BB418
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022636 RID: 140854 RVA: 0x004BD258 File Offset: 0x004BB458
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022637 RID: 140855 RVA: 0x004BD272 File Offset: 0x004BB472
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022638 RID: 140856 RVA: 0x004BD290 File Offset: 0x004BB490
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022639 RID: 140857 RVA: 0x004BD2A9 File Offset: 0x004BB4A9
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602263A RID: 140858 RVA: 0x004BD2B4 File Offset: 0x004BB4B4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602263B RID: 140859 RVA: 0x004BD2BF File Offset: 0x004BB4BF
		public static Offset<IClientHookActionConfig> EndIClientHookActionConfig(FlatBufferBuilder builder)
		{
			return new Offset<IClientHookActionConfig>(builder.EndTable());
		}

		// Token: 0x0602263C RID: 140860 RVA: 0x004BD2CC File Offset: 0x004BB4CC
		public IClientHookActionConfigT UnPack()
		{
			IClientHookActionConfigT clientHookActionConfigT = new IClientHookActionConfigT();
			this.UnPackTo(clientHookActionConfigT);
			return clientHookActionConfigT;
		}

		// Token: 0x0602263D RID: 140861 RVA: 0x004BD2E8 File Offset: 0x004BB4E8
		public void UnPackTo(IClientHookActionConfigT _o)
		{
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
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602263E RID: 140862 RVA: 0x004BD400 File Offset: 0x004BB600
		public static Offset<IClientHookActionConfig> Pack(FlatBufferBuilder builder, IClientHookActionConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientHookActionConfig>);
			}
			VectorOffset hookActionsOffset = default(VectorOffset);
			if (_o.HookActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.HookActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.HookActions[i]);
				}
				hookActionsOffset = IClientHookActionConfig.CreateHookActionsVector(builder, array);
			}
			VectorOffset exitHookActionsOffset = default(VectorOffset);
			if (_o.ExitHookActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ExitHookActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ExitHookActions[j]);
				}
				exitHookActionsOffset = IClientHookActionConfig.CreateExitHookActionsVector(builder, array2);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.FinishActions[k]);
				}
				finishActionsOffset = IClientHookActionConfig.CreateFinishActionsVector(builder, array3);
			}
			return IClientHookActionConfig.CreateIClientHookActionConfig(builder, hookActionsOffset, exitHookActionsOffset, finishActionsOffset, _o.NullMask);
		}

		// Token: 0x0400EA6B RID: 60011
		private Table __p;
	}
}
