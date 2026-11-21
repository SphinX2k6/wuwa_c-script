using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006014 RID: 24596
	public struct ISunSpiritLauncher : IFlatbufferObject
	{
		// Token: 0x1700B65C RID: 46684
		// (get) Token: 0x06029748 RID: 169800 RVA: 0x005A8565 File Offset: 0x005A6765
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029749 RID: 169801 RVA: 0x005A8572 File Offset: 0x005A6772
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602974A RID: 169802 RVA: 0x005A857C File Offset: 0x005A677C
		public static ISunSpiritLauncher GetRootAsISunSpiritLauncher(ByteBuffer _bb)
		{
			return ISunSpiritLauncher.GetRootAsISunSpiritLauncher(_bb, default(ISunSpiritLauncher));
		}

		// Token: 0x0602974B RID: 169803 RVA: 0x005A8598 File Offset: 0x005A6798
		public static ISunSpiritLauncher GetRootAsISunSpiritLauncher(ByteBuffer _bb, ISunSpiritLauncher obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602974C RID: 169804 RVA: 0x005A85B5 File Offset: 0x005A67B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602974D RID: 169805 RVA: 0x005A85C4 File Offset: 0x005A67C4
		public ISunSpiritLauncher __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B65D RID: 46685
		// (get) Token: 0x0602974E RID: 169806 RVA: 0x005A85D4 File Offset: 0x005A67D4
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

		// Token: 0x0602974F RID: 169807 RVA: 0x005A8610 File Offset: 0x005A6810
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B65E RID: 46686
		// (get) Token: 0x06029750 RID: 169808 RVA: 0x005A8670 File Offset: 0x005A6870
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

		// Token: 0x06029751 RID: 169809 RVA: 0x005A869C File Offset: 0x005A689C
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B65F RID: 46687
		// (get) Token: 0x06029752 RID: 169810 RVA: 0x005A86FC File Offset: 0x005A68FC
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

		// Token: 0x06029753 RID: 169811 RVA: 0x005A8728 File Offset: 0x005A6928
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B660 RID: 46688
		// (get) Token: 0x06029754 RID: 169812 RVA: 0x005A878C File Offset: 0x005A698C
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

		// Token: 0x1700B661 RID: 46689
		// (get) Token: 0x06029755 RID: 169813 RVA: 0x005A87B8 File Offset: 0x005A69B8
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

		// Token: 0x1700B662 RID: 46690
		// (get) Token: 0x06029756 RID: 169814 RVA: 0x005A8818 File Offset: 0x005A6A18
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

		// Token: 0x06029757 RID: 169815 RVA: 0x005A8855 File Offset: 0x005A6A55
		public static Offset<ISunSpiritLauncher> CreateISunSpiritLauncher(FlatBufferBuilder builder, EHookInteractType Type = EHookInteractType.FixedPointHook, VectorOffset HookActionsOffset = default(VectorOffset), VectorOffset ExitHookActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), Offset<IClientHookActionConfig> ClientHookActionConfigOffset = default(Offset<IClientHookActionConfig>), byte NullMask = 0)
		{
			builder.StartTable(6);
			ISunSpiritLauncher.AddClientHookActionConfig(builder, ClientHookActionConfigOffset);
			ISunSpiritLauncher.AddFinishActions(builder, FinishActionsOffset);
			ISunSpiritLauncher.AddExitHookActions(builder, ExitHookActionsOffset);
			ISunSpiritLauncher.AddHookActions(builder, HookActionsOffset);
			ISunSpiritLauncher.AddNullMask(builder, NullMask);
			ISunSpiritLauncher.AddType(builder, Type);
			return ISunSpiritLauncher.EndISunSpiritLauncher(builder);
		}

		// Token: 0x06029758 RID: 169816 RVA: 0x005A8891 File Offset: 0x005A6A91
		public static void StartISunSpiritLauncher(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06029759 RID: 169817 RVA: 0x005A889A File Offset: 0x005A6A9A
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602975A RID: 169818 RVA: 0x005A88A5 File Offset: 0x005A6AA5
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x0602975B RID: 169819 RVA: 0x005A88B8 File Offset: 0x005A6AB8
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602975C RID: 169820 RVA: 0x005A88F8 File Offset: 0x005A6AF8
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602975D RID: 169821 RVA: 0x005A8912 File Offset: 0x005A6B12
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602975E RID: 169822 RVA: 0x005A8930 File Offset: 0x005A6B30
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602975F RID: 169823 RVA: 0x005A8949 File Offset: 0x005A6B49
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029760 RID: 169824 RVA: 0x005A8954 File Offset: 0x005A6B54
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x06029761 RID: 169825 RVA: 0x005A8964 File Offset: 0x005A6B64
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06029762 RID: 169826 RVA: 0x005A89A4 File Offset: 0x005A6BA4
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029763 RID: 169827 RVA: 0x005A89BE File Offset: 0x005A6BBE
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029764 RID: 169828 RVA: 0x005A89DC File Offset: 0x005A6BDC
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029765 RID: 169829 RVA: 0x005A89F5 File Offset: 0x005A6BF5
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029766 RID: 169830 RVA: 0x005A8A00 File Offset: 0x005A6C00
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x06029767 RID: 169831 RVA: 0x005A8A10 File Offset: 0x005A6C10
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06029768 RID: 169832 RVA: 0x005A8A50 File Offset: 0x005A6C50
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029769 RID: 169833 RVA: 0x005A8A6A File Offset: 0x005A6C6A
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602976A RID: 169834 RVA: 0x005A8A88 File Offset: 0x005A6C88
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602976B RID: 169835 RVA: 0x005A8AA1 File Offset: 0x005A6CA1
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602976C RID: 169836 RVA: 0x005A8AAC File Offset: 0x005A6CAC
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x0602976D RID: 169837 RVA: 0x005A8ABC File Offset: 0x005A6CBC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602976E RID: 169838 RVA: 0x005A8AC7 File Offset: 0x005A6CC7
		public static Offset<ISunSpiritLauncher> EndISunSpiritLauncher(FlatBufferBuilder builder)
		{
			return new Offset<ISunSpiritLauncher>(builder.EndTable());
		}

		// Token: 0x0602976F RID: 169839 RVA: 0x005A8AD4 File Offset: 0x005A6CD4
		public ISunSpiritLauncherT UnPack()
		{
			ISunSpiritLauncherT sunSpiritLauncherT = new ISunSpiritLauncherT();
			this.UnPackTo(sunSpiritLauncherT);
			return sunSpiritLauncherT;
		}

		// Token: 0x06029770 RID: 169840 RVA: 0x005A8AF0 File Offset: 0x005A6CF0
		public void UnPackTo(ISunSpiritLauncherT _o)
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

		// Token: 0x06029771 RID: 169841 RVA: 0x005A8C44 File Offset: 0x005A6E44
		public static Offset<ISunSpiritLauncher> Pack(FlatBufferBuilder builder, ISunSpiritLauncherT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISunSpiritLauncher>);
			}
			VectorOffset hookActionsOffset = default(VectorOffset);
			if (_o.HookActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.HookActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.HookActions[i]);
				}
				hookActionsOffset = ISunSpiritLauncher.CreateHookActionsVector(builder, array);
			}
			VectorOffset exitHookActionsOffset = default(VectorOffset);
			if (_o.ExitHookActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ExitHookActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ExitHookActions[j]);
				}
				exitHookActionsOffset = ISunSpiritLauncher.CreateExitHookActionsVector(builder, array2);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.FinishActions[k]);
				}
				finishActionsOffset = ISunSpiritLauncher.CreateFinishActionsVector(builder, array3);
			}
			Offset<IClientHookActionConfig> clientHookActionConfigOffset = (_o.ClientHookActionConfig == null) ? default(Offset<IClientHookActionConfig>) : IClientHookActionConfig.Pack(builder, _o.ClientHookActionConfig);
			return ISunSpiritLauncher.CreateISunSpiritLauncher(builder, _o.Type, hookActionsOffset, exitHookActionsOffset, finishActionsOffset, clientHookActionConfigOffset, _o.NullMask);
		}

		// Token: 0x0400FD40 RID: 64832
		private Table __p;
	}
}
