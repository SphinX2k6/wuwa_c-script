using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FFC RID: 24572
	public struct ISuiGuangHook : IFlatbufferObject
	{
		// Token: 0x1700B629 RID: 46633
		// (get) Token: 0x0602966E RID: 169582 RVA: 0x005A6974 File Offset: 0x005A4B74
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602966F RID: 169583 RVA: 0x005A6981 File Offset: 0x005A4B81
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029670 RID: 169584 RVA: 0x005A6988 File Offset: 0x005A4B88
		public static ISuiGuangHook GetRootAsISuiGuangHook(ByteBuffer _bb)
		{
			return ISuiGuangHook.GetRootAsISuiGuangHook(_bb, default(ISuiGuangHook));
		}

		// Token: 0x06029671 RID: 169585 RVA: 0x005A69A4 File Offset: 0x005A4BA4
		public static ISuiGuangHook GetRootAsISuiGuangHook(ByteBuffer _bb, ISuiGuangHook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029672 RID: 169586 RVA: 0x005A69C1 File Offset: 0x005A4BC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029673 RID: 169587 RVA: 0x005A69D0 File Offset: 0x005A4BD0
		public ISuiGuangHook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B62A RID: 46634
		// (get) Token: 0x06029674 RID: 169588 RVA: 0x005A69E0 File Offset: 0x005A4BE0
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

		// Token: 0x06029675 RID: 169589 RVA: 0x005A6A1C File Offset: 0x005A4C1C
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B62B RID: 46635
		// (get) Token: 0x06029676 RID: 169590 RVA: 0x005A6A7C File Offset: 0x005A4C7C
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

		// Token: 0x06029677 RID: 169591 RVA: 0x005A6AA8 File Offset: 0x005A4CA8
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B62C RID: 46636
		// (get) Token: 0x06029678 RID: 169592 RVA: 0x005A6B08 File Offset: 0x005A4D08
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

		// Token: 0x06029679 RID: 169593 RVA: 0x005A6B34 File Offset: 0x005A4D34
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B62D RID: 46637
		// (get) Token: 0x0602967A RID: 169594 RVA: 0x005A6B98 File Offset: 0x005A4D98
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

		// Token: 0x1700B62E RID: 46638
		// (get) Token: 0x0602967B RID: 169595 RVA: 0x005A6BC4 File Offset: 0x005A4DC4
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

		// Token: 0x1700B62F RID: 46639
		// (get) Token: 0x0602967C RID: 169596 RVA: 0x005A6C24 File Offset: 0x005A4E24
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

		// Token: 0x0602967D RID: 169597 RVA: 0x005A6C61 File Offset: 0x005A4E61
		public static Offset<ISuiGuangHook> CreateISuiGuangHook(FlatBufferBuilder builder, EHookInteractType Type = EHookInteractType.FixedPointHook, VectorOffset HookActionsOffset = default(VectorOffset), VectorOffset ExitHookActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), Offset<IClientHookActionConfig> ClientHookActionConfigOffset = default(Offset<IClientHookActionConfig>), byte NullMask = 0)
		{
			builder.StartTable(6);
			ISuiGuangHook.AddClientHookActionConfig(builder, ClientHookActionConfigOffset);
			ISuiGuangHook.AddFinishActions(builder, FinishActionsOffset);
			ISuiGuangHook.AddExitHookActions(builder, ExitHookActionsOffset);
			ISuiGuangHook.AddHookActions(builder, HookActionsOffset);
			ISuiGuangHook.AddNullMask(builder, NullMask);
			ISuiGuangHook.AddType(builder, Type);
			return ISuiGuangHook.EndISuiGuangHook(builder);
		}

		// Token: 0x0602967E RID: 169598 RVA: 0x005A6C9D File Offset: 0x005A4E9D
		public static void StartISuiGuangHook(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602967F RID: 169599 RVA: 0x005A6CA6 File Offset: 0x005A4EA6
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029680 RID: 169600 RVA: 0x005A6CB1 File Offset: 0x005A4EB1
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x06029681 RID: 169601 RVA: 0x005A6CC4 File Offset: 0x005A4EC4
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06029682 RID: 169602 RVA: 0x005A6D04 File Offset: 0x005A4F04
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029683 RID: 169603 RVA: 0x005A6D1E File Offset: 0x005A4F1E
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029684 RID: 169604 RVA: 0x005A6D3C File Offset: 0x005A4F3C
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029685 RID: 169605 RVA: 0x005A6D55 File Offset: 0x005A4F55
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029686 RID: 169606 RVA: 0x005A6D60 File Offset: 0x005A4F60
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x06029687 RID: 169607 RVA: 0x005A6D70 File Offset: 0x005A4F70
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06029688 RID: 169608 RVA: 0x005A6DB0 File Offset: 0x005A4FB0
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029689 RID: 169609 RVA: 0x005A6DCA File Offset: 0x005A4FCA
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602968A RID: 169610 RVA: 0x005A6DE8 File Offset: 0x005A4FE8
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602968B RID: 169611 RVA: 0x005A6E01 File Offset: 0x005A5001
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602968C RID: 169612 RVA: 0x005A6E0C File Offset: 0x005A500C
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x0602968D RID: 169613 RVA: 0x005A6E1C File Offset: 0x005A501C
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602968E RID: 169614 RVA: 0x005A6E5C File Offset: 0x005A505C
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602968F RID: 169615 RVA: 0x005A6E76 File Offset: 0x005A5076
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029690 RID: 169616 RVA: 0x005A6E94 File Offset: 0x005A5094
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029691 RID: 169617 RVA: 0x005A6EAD File Offset: 0x005A50AD
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029692 RID: 169618 RVA: 0x005A6EB8 File Offset: 0x005A50B8
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x06029693 RID: 169619 RVA: 0x005A6EC8 File Offset: 0x005A50C8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06029694 RID: 169620 RVA: 0x005A6ED3 File Offset: 0x005A50D3
		public static Offset<ISuiGuangHook> EndISuiGuangHook(FlatBufferBuilder builder)
		{
			return new Offset<ISuiGuangHook>(builder.EndTable());
		}

		// Token: 0x06029695 RID: 169621 RVA: 0x005A6EE0 File Offset: 0x005A50E0
		public ISuiGuangHookT UnPack()
		{
			ISuiGuangHookT suiGuangHookT = new ISuiGuangHookT();
			this.UnPackTo(suiGuangHookT);
			return suiGuangHookT;
		}

		// Token: 0x06029696 RID: 169622 RVA: 0x005A6EFC File Offset: 0x005A50FC
		public void UnPackTo(ISuiGuangHookT _o)
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

		// Token: 0x06029697 RID: 169623 RVA: 0x005A7050 File Offset: 0x005A5250
		public static Offset<ISuiGuangHook> Pack(FlatBufferBuilder builder, ISuiGuangHookT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISuiGuangHook>);
			}
			VectorOffset hookActionsOffset = default(VectorOffset);
			if (_o.HookActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.HookActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.HookActions[i]);
				}
				hookActionsOffset = ISuiGuangHook.CreateHookActionsVector(builder, array);
			}
			VectorOffset exitHookActionsOffset = default(VectorOffset);
			if (_o.ExitHookActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ExitHookActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ExitHookActions[j]);
				}
				exitHookActionsOffset = ISuiGuangHook.CreateExitHookActionsVector(builder, array2);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.FinishActions[k]);
				}
				finishActionsOffset = ISuiGuangHook.CreateFinishActionsVector(builder, array3);
			}
			Offset<IClientHookActionConfig> clientHookActionConfigOffset = (_o.ClientHookActionConfig == null) ? default(Offset<IClientHookActionConfig>) : IClientHookActionConfig.Pack(builder, _o.ClientHookActionConfig);
			return ISuiGuangHook.CreateISuiGuangHook(builder, _o.Type, hookActionsOffset, exitHookActionsOffset, finishActionsOffset, clientHookActionConfigOffset, _o.NullMask);
		}

		// Token: 0x0400FD1D RID: 64797
		private Table __p;
	}
}
