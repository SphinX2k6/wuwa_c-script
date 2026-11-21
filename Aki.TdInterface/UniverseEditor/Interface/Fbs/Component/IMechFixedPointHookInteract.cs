using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AC8 RID: 23240
	public struct IMechFixedPointHookInteract : IFlatbufferObject
	{
		// Token: 0x1700A964 RID: 43364
		// (get) Token: 0x060261DF RID: 156127 RVA: 0x00538D2B File Offset: 0x00536F2B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060261E0 RID: 156128 RVA: 0x00538D38 File Offset: 0x00536F38
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060261E1 RID: 156129 RVA: 0x00538D40 File Offset: 0x00536F40
		public static IMechFixedPointHookInteract GetRootAsIMechFixedPointHookInteract(ByteBuffer _bb)
		{
			return IMechFixedPointHookInteract.GetRootAsIMechFixedPointHookInteract(_bb, default(IMechFixedPointHookInteract));
		}

		// Token: 0x060261E2 RID: 156130 RVA: 0x00538D5C File Offset: 0x00536F5C
		public static IMechFixedPointHookInteract GetRootAsIMechFixedPointHookInteract(ByteBuffer _bb, IMechFixedPointHookInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060261E3 RID: 156131 RVA: 0x00538D79 File Offset: 0x00536F79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060261E4 RID: 156132 RVA: 0x00538D88 File Offset: 0x00536F88
		public IMechFixedPointHookInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A965 RID: 43365
		// (get) Token: 0x060261E5 RID: 156133 RVA: 0x00538D98 File Offset: 0x00536F98
		public EMechHookInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMechHookInteractType.FixedPointHook;
				}
				return (EMechHookInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060261E6 RID: 156134 RVA: 0x00538DD4 File Offset: 0x00536FD4
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A966 RID: 43366
		// (get) Token: 0x060261E7 RID: 156135 RVA: 0x00538E34 File Offset: 0x00537034
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

		// Token: 0x060261E8 RID: 156136 RVA: 0x00538E60 File Offset: 0x00537060
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A967 RID: 43367
		// (get) Token: 0x060261E9 RID: 156137 RVA: 0x00538EC0 File Offset: 0x005370C0
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

		// Token: 0x060261EA RID: 156138 RVA: 0x00538EEC File Offset: 0x005370EC
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A968 RID: 43368
		// (get) Token: 0x060261EB RID: 156139 RVA: 0x00538F50 File Offset: 0x00537150
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

		// Token: 0x1700A969 RID: 43369
		// (get) Token: 0x060261EC RID: 156140 RVA: 0x00538F7C File Offset: 0x0053717C
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

		// Token: 0x1700A96A RID: 43370
		// (get) Token: 0x060261ED RID: 156141 RVA: 0x00538FDC File Offset: 0x005371DC
		public IMechBehaviorConfig? MechBehaviorConfig
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IMechBehaviorConfig?(default(IMechBehaviorConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A96B RID: 43371
		// (get) Token: 0x060261EE RID: 156142 RVA: 0x0053903C File Offset: 0x0053723C
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

		// Token: 0x060261EF RID: 156143 RVA: 0x0053907C File Offset: 0x0053727C
		public static Offset<IMechFixedPointHookInteract> CreateIMechFixedPointHookInteract(FlatBufferBuilder builder, EMechHookInteractType Type = EMechHookInteractType.FixedPointHook, VectorOffset HookActionsOffset = default(VectorOffset), VectorOffset ExitHookActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), Offset<IClientHookActionConfig> ClientHookActionConfigOffset = default(Offset<IClientHookActionConfig>), Offset<IMechBehaviorConfig> MechBehaviorConfigOffset = default(Offset<IMechBehaviorConfig>), byte NullMask = 0)
		{
			builder.StartTable(7);
			IMechFixedPointHookInteract.AddMechBehaviorConfig(builder, MechBehaviorConfigOffset);
			IMechFixedPointHookInteract.AddClientHookActionConfig(builder, ClientHookActionConfigOffset);
			IMechFixedPointHookInteract.AddFinishActions(builder, FinishActionsOffset);
			IMechFixedPointHookInteract.AddExitHookActions(builder, ExitHookActionsOffset);
			IMechFixedPointHookInteract.AddHookActions(builder, HookActionsOffset);
			IMechFixedPointHookInteract.AddNullMask(builder, NullMask);
			IMechFixedPointHookInteract.AddType(builder, Type);
			return IMechFixedPointHookInteract.EndIMechFixedPointHookInteract(builder);
		}

		// Token: 0x060261F0 RID: 156144 RVA: 0x005390CB File Offset: 0x005372CB
		public static void StartIMechFixedPointHookInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x060261F1 RID: 156145 RVA: 0x005390D4 File Offset: 0x005372D4
		public static void AddType(FlatBufferBuilder builder, EMechHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060261F2 RID: 156146 RVA: 0x005390DF File Offset: 0x005372DF
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x060261F3 RID: 156147 RVA: 0x005390F0 File Offset: 0x005372F0
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060261F4 RID: 156148 RVA: 0x00539130 File Offset: 0x00537330
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060261F5 RID: 156149 RVA: 0x0053914A File Offset: 0x0053734A
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060261F6 RID: 156150 RVA: 0x00539168 File Offset: 0x00537368
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060261F7 RID: 156151 RVA: 0x00539181 File Offset: 0x00537381
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060261F8 RID: 156152 RVA: 0x0053918C File Offset: 0x0053738C
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x060261F9 RID: 156153 RVA: 0x0053919C File Offset: 0x0053739C
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060261FA RID: 156154 RVA: 0x005391DC File Offset: 0x005373DC
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060261FB RID: 156155 RVA: 0x005391F6 File Offset: 0x005373F6
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060261FC RID: 156156 RVA: 0x00539214 File Offset: 0x00537414
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060261FD RID: 156157 RVA: 0x0053922D File Offset: 0x0053742D
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060261FE RID: 156158 RVA: 0x00539238 File Offset: 0x00537438
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x060261FF RID: 156159 RVA: 0x00539248 File Offset: 0x00537448
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026200 RID: 156160 RVA: 0x00539288 File Offset: 0x00537488
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026201 RID: 156161 RVA: 0x005392A2 File Offset: 0x005374A2
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026202 RID: 156162 RVA: 0x005392C0 File Offset: 0x005374C0
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026203 RID: 156163 RVA: 0x005392D9 File Offset: 0x005374D9
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026204 RID: 156164 RVA: 0x005392E4 File Offset: 0x005374E4
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x06026205 RID: 156165 RVA: 0x005392F4 File Offset: 0x005374F4
		public static void AddMechBehaviorConfig(FlatBufferBuilder builder, Offset<IMechBehaviorConfig> mechBehaviorConfigOffset)
		{
			builder.AddOffset(5, mechBehaviorConfigOffset.Value, 0);
		}

		// Token: 0x06026206 RID: 156166 RVA: 0x00539304 File Offset: 0x00537504
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06026207 RID: 156167 RVA: 0x0053930F File Offset: 0x0053750F
		public static Offset<IMechFixedPointHookInteract> EndIMechFixedPointHookInteract(FlatBufferBuilder builder)
		{
			return new Offset<IMechFixedPointHookInteract>(builder.EndTable());
		}

		// Token: 0x06026208 RID: 156168 RVA: 0x0053931C File Offset: 0x0053751C
		public IMechFixedPointHookInteractT UnPack()
		{
			IMechFixedPointHookInteractT mechFixedPointHookInteractT = new IMechFixedPointHookInteractT();
			this.UnPackTo(mechFixedPointHookInteractT);
			return mechFixedPointHookInteractT;
		}

		// Token: 0x06026209 RID: 156169 RVA: 0x00539338 File Offset: 0x00537538
		public void UnPackTo(IMechFixedPointHookInteractT _o)
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
			_o.MechBehaviorConfig = ((this.MechBehaviorConfig != null) ? this.MechBehaviorConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602620A RID: 156170 RVA: 0x005394C0 File Offset: 0x005376C0
		public static Offset<IMechFixedPointHookInteract> Pack(FlatBufferBuilder builder, IMechFixedPointHookInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechFixedPointHookInteract>);
			}
			VectorOffset hookActionsOffset = default(VectorOffset);
			if (_o.HookActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.HookActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.HookActions[i]);
				}
				hookActionsOffset = IMechFixedPointHookInteract.CreateHookActionsVector(builder, array);
			}
			VectorOffset exitHookActionsOffset = default(VectorOffset);
			if (_o.ExitHookActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ExitHookActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ExitHookActions[j]);
				}
				exitHookActionsOffset = IMechFixedPointHookInteract.CreateExitHookActionsVector(builder, array2);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.FinishActions[k]);
				}
				finishActionsOffset = IMechFixedPointHookInteract.CreateFinishActionsVector(builder, array3);
			}
			Offset<IClientHookActionConfig> clientHookActionConfigOffset = (_o.ClientHookActionConfig == null) ? default(Offset<IClientHookActionConfig>) : IClientHookActionConfig.Pack(builder, _o.ClientHookActionConfig);
			Offset<IMechBehaviorConfig> mechBehaviorConfigOffset = (_o.MechBehaviorConfig == null) ? default(Offset<IMechBehaviorConfig>) : IMechBehaviorConfig.Pack(builder, _o.MechBehaviorConfig);
			return IMechFixedPointHookInteract.CreateIMechFixedPointHookInteract(builder, _o.Type, hookActionsOffset, exitHookActionsOffset, finishActionsOffset, clientHookActionConfigOffset, mechBehaviorConfigOffset, _o.NullMask);
		}

		// Token: 0x0400F477 RID: 62583
		private Table __p;
	}
}
