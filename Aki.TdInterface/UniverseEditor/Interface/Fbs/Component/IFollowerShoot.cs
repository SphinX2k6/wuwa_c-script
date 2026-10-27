using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005297 RID: 21143
	public struct IFollowerShoot : IFlatbufferObject
	{
		// Token: 0x17009B02 RID: 39682
		// (get) Token: 0x0602273E RID: 141118 RVA: 0x004C6B86 File Offset: 0x004C4D86
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602273F RID: 141119 RVA: 0x004C6B93 File Offset: 0x004C4D93
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022740 RID: 141120 RVA: 0x004C6B9C File Offset: 0x004C4D9C
		public static IFollowerShoot GetRootAsIFollowerShoot(ByteBuffer _bb)
		{
			return IFollowerShoot.GetRootAsIFollowerShoot(_bb, default(IFollowerShoot));
		}

		// Token: 0x06022741 RID: 141121 RVA: 0x004C6BB8 File Offset: 0x004C4DB8
		public static IFollowerShoot GetRootAsIFollowerShoot(ByteBuffer _bb, IFollowerShoot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022742 RID: 141122 RVA: 0x004C6BD5 File Offset: 0x004C4DD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022743 RID: 141123 RVA: 0x004C6BE4 File Offset: 0x004C4DE4
		public IFollowerShoot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009B03 RID: 39683
		// (get) Token: 0x06022744 RID: 141124 RVA: 0x004C6BF4 File Offset: 0x004C4DF4
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

		// Token: 0x06022745 RID: 141125 RVA: 0x004C6C30 File Offset: 0x004C4E30
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009B04 RID: 39684
		// (get) Token: 0x06022746 RID: 141126 RVA: 0x004C6C90 File Offset: 0x004C4E90
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

		// Token: 0x06022747 RID: 141127 RVA: 0x004C6CBC File Offset: 0x004C4EBC
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009B05 RID: 39685
		// (get) Token: 0x06022748 RID: 141128 RVA: 0x004C6D1C File Offset: 0x004C4F1C
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

		// Token: 0x06022749 RID: 141129 RVA: 0x004C6D48 File Offset: 0x004C4F48
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009B06 RID: 39686
		// (get) Token: 0x0602274A RID: 141130 RVA: 0x004C6DAC File Offset: 0x004C4FAC
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

		// Token: 0x17009B07 RID: 39687
		// (get) Token: 0x0602274B RID: 141131 RVA: 0x004C6DD8 File Offset: 0x004C4FD8
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

		// Token: 0x17009B08 RID: 39688
		// (get) Token: 0x0602274C RID: 141132 RVA: 0x004C6E38 File Offset: 0x004C5038
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

		// Token: 0x0602274D RID: 141133 RVA: 0x004C6E75 File Offset: 0x004C5075
		public static Offset<IFollowerShoot> CreateIFollowerShoot(FlatBufferBuilder builder, EHookInteractType Type = EHookInteractType.FixedPointHook, VectorOffset HookActionsOffset = default(VectorOffset), VectorOffset ExitHookActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), Offset<IClientHookActionConfig> ClientHookActionConfigOffset = default(Offset<IClientHookActionConfig>), byte NullMask = 0)
		{
			builder.StartTable(6);
			IFollowerShoot.AddClientHookActionConfig(builder, ClientHookActionConfigOffset);
			IFollowerShoot.AddFinishActions(builder, FinishActionsOffset);
			IFollowerShoot.AddExitHookActions(builder, ExitHookActionsOffset);
			IFollowerShoot.AddHookActions(builder, HookActionsOffset);
			IFollowerShoot.AddNullMask(builder, NullMask);
			IFollowerShoot.AddType(builder, Type);
			return IFollowerShoot.EndIFollowerShoot(builder);
		}

		// Token: 0x0602274E RID: 141134 RVA: 0x004C6EB1 File Offset: 0x004C50B1
		public static void StartIFollowerShoot(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602274F RID: 141135 RVA: 0x004C6EBA File Offset: 0x004C50BA
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022750 RID: 141136 RVA: 0x004C6EC5 File Offset: 0x004C50C5
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x06022751 RID: 141137 RVA: 0x004C6ED8 File Offset: 0x004C50D8
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022752 RID: 141138 RVA: 0x004C6F18 File Offset: 0x004C5118
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022753 RID: 141139 RVA: 0x004C6F32 File Offset: 0x004C5132
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022754 RID: 141140 RVA: 0x004C6F50 File Offset: 0x004C5150
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022755 RID: 141141 RVA: 0x004C6F69 File Offset: 0x004C5169
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022756 RID: 141142 RVA: 0x004C6F74 File Offset: 0x004C5174
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x06022757 RID: 141143 RVA: 0x004C6F84 File Offset: 0x004C5184
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022758 RID: 141144 RVA: 0x004C6FC4 File Offset: 0x004C51C4
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022759 RID: 141145 RVA: 0x004C6FDE File Offset: 0x004C51DE
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602275A RID: 141146 RVA: 0x004C6FFC File Offset: 0x004C51FC
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602275B RID: 141147 RVA: 0x004C7015 File Offset: 0x004C5215
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602275C RID: 141148 RVA: 0x004C7020 File Offset: 0x004C5220
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x0602275D RID: 141149 RVA: 0x004C7030 File Offset: 0x004C5230
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602275E RID: 141150 RVA: 0x004C7070 File Offset: 0x004C5270
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602275F RID: 141151 RVA: 0x004C708A File Offset: 0x004C528A
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022760 RID: 141152 RVA: 0x004C70A8 File Offset: 0x004C52A8
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022761 RID: 141153 RVA: 0x004C70C1 File Offset: 0x004C52C1
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022762 RID: 141154 RVA: 0x004C70CC File Offset: 0x004C52CC
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x06022763 RID: 141155 RVA: 0x004C70DC File Offset: 0x004C52DC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06022764 RID: 141156 RVA: 0x004C70E7 File Offset: 0x004C52E7
		public static Offset<IFollowerShoot> EndIFollowerShoot(FlatBufferBuilder builder)
		{
			return new Offset<IFollowerShoot>(builder.EndTable());
		}

		// Token: 0x06022765 RID: 141157 RVA: 0x004C70F4 File Offset: 0x004C52F4
		public IFollowerShootT UnPack()
		{
			IFollowerShootT followerShootT = new IFollowerShootT();
			this.UnPackTo(followerShootT);
			return followerShootT;
		}

		// Token: 0x06022766 RID: 141158 RVA: 0x004C7110 File Offset: 0x004C5310
		public void UnPackTo(IFollowerShootT _o)
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

		// Token: 0x06022767 RID: 141159 RVA: 0x004C7264 File Offset: 0x004C5464
		public static Offset<IFollowerShoot> Pack(FlatBufferBuilder builder, IFollowerShootT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFollowerShoot>);
			}
			VectorOffset hookActionsOffset = default(VectorOffset);
			if (_o.HookActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.HookActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.HookActions[i]);
				}
				hookActionsOffset = IFollowerShoot.CreateHookActionsVector(builder, array);
			}
			VectorOffset exitHookActionsOffset = default(VectorOffset);
			if (_o.ExitHookActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ExitHookActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ExitHookActions[j]);
				}
				exitHookActionsOffset = IFollowerShoot.CreateExitHookActionsVector(builder, array2);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.FinishActions[k]);
				}
				finishActionsOffset = IFollowerShoot.CreateFinishActionsVector(builder, array3);
			}
			Offset<IClientHookActionConfig> clientHookActionConfigOffset = (_o.ClientHookActionConfig == null) ? default(Offset<IClientHookActionConfig>) : IClientHookActionConfig.Pack(builder, _o.ClientHookActionConfig);
			return IFollowerShoot.CreateIFollowerShoot(builder, _o.Type, hookActionsOffset, exitHookActionsOffset, finishActionsOffset, clientHookActionConfigOffset, _o.NullMask);
		}

		// Token: 0x0400E406 RID: 58374
		private Table __p;
	}
}
