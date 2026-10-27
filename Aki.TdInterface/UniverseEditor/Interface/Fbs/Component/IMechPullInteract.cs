using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005548 RID: 21832
	public struct IMechPullInteract : IFlatbufferObject
	{
		// Token: 0x1700A12D RID: 41261
		// (get) Token: 0x06024143 RID: 147779 RVA: 0x004FBF94 File Offset: 0x004FA194
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024144 RID: 147780 RVA: 0x004FBFA1 File Offset: 0x004FA1A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024145 RID: 147781 RVA: 0x004FBFA8 File Offset: 0x004FA1A8
		public static IMechPullInteract GetRootAsIMechPullInteract(ByteBuffer _bb)
		{
			return IMechPullInteract.GetRootAsIMechPullInteract(_bb, default(IMechPullInteract));
		}

		// Token: 0x06024146 RID: 147782 RVA: 0x004FBFC4 File Offset: 0x004FA1C4
		public static IMechPullInteract GetRootAsIMechPullInteract(ByteBuffer _bb, IMechPullInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024147 RID: 147783 RVA: 0x004FBFE1 File Offset: 0x004FA1E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024148 RID: 147784 RVA: 0x004FBFF0 File Offset: 0x004FA1F0
		public IMechPullInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A12E RID: 41262
		// (get) Token: 0x06024149 RID: 147785 RVA: 0x004FC000 File Offset: 0x004FA200
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

		// Token: 0x0602414A RID: 147786 RVA: 0x004FC03C File Offset: 0x004FA23C
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A12F RID: 41263
		// (get) Token: 0x0602414B RID: 147787 RVA: 0x004FC09C File Offset: 0x004FA29C
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

		// Token: 0x0602414C RID: 147788 RVA: 0x004FC0C8 File Offset: 0x004FA2C8
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A130 RID: 41264
		// (get) Token: 0x0602414D RID: 147789 RVA: 0x004FC128 File Offset: 0x004FA328
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

		// Token: 0x0602414E RID: 147790 RVA: 0x004FC154 File Offset: 0x004FA354
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A131 RID: 41265
		// (get) Token: 0x0602414F RID: 147791 RVA: 0x004FC1B8 File Offset: 0x004FA3B8
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

		// Token: 0x1700A132 RID: 41266
		// (get) Token: 0x06024150 RID: 147792 RVA: 0x004FC1E4 File Offset: 0x004FA3E4
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

		// Token: 0x1700A133 RID: 41267
		// (get) Token: 0x06024151 RID: 147793 RVA: 0x004FC244 File Offset: 0x004FA444
		public bool IsPlayPullProgress
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A134 RID: 41268
		// (get) Token: 0x06024152 RID: 147794 RVA: 0x004FC284 File Offset: 0x004FA484
		public float PullMoveSpeed
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A135 RID: 41269
		// (get) Token: 0x06024153 RID: 147795 RVA: 0x004FC2C8 File Offset: 0x004FA4C8
		public bool IsFixedWhenNotMech
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A136 RID: 41270
		// (get) Token: 0x06024154 RID: 147796 RVA: 0x004FC308 File Offset: 0x004FA508
		public bool DisableAreaEffect
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A137 RID: 41271
		// (get) Token: 0x06024155 RID: 147797 RVA: 0x004FC348 File Offset: 0x004FA548
		public bool DisableCollectEffect
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A138 RID: 41272
		// (get) Token: 0x06024156 RID: 147798 RVA: 0x004FC388 File Offset: 0x004FA588
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024157 RID: 147799 RVA: 0x004FC3C8 File Offset: 0x004FA5C8
		public static Offset<IMechPullInteract> CreateIMechPullInteract(FlatBufferBuilder builder, EHookInteractType Type = EHookInteractType.FixedPointHook, VectorOffset HookActionsOffset = default(VectorOffset), VectorOffset ExitHookActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), Offset<IClientHookActionConfig> ClientHookActionConfigOffset = default(Offset<IClientHookActionConfig>), bool IsPlayPullProgress = false, float PullMoveSpeed = 0f, bool IsFixedWhenNotMech = false, bool DisableAreaEffect = false, bool DisableCollectEffect = false, byte NullMask = 0)
		{
			builder.StartTable(11);
			IMechPullInteract.AddPullMoveSpeed(builder, PullMoveSpeed);
			IMechPullInteract.AddClientHookActionConfig(builder, ClientHookActionConfigOffset);
			IMechPullInteract.AddFinishActions(builder, FinishActionsOffset);
			IMechPullInteract.AddExitHookActions(builder, ExitHookActionsOffset);
			IMechPullInteract.AddHookActions(builder, HookActionsOffset);
			IMechPullInteract.AddNullMask(builder, NullMask);
			IMechPullInteract.AddDisableCollectEffect(builder, DisableCollectEffect);
			IMechPullInteract.AddDisableAreaEffect(builder, DisableAreaEffect);
			IMechPullInteract.AddIsFixedWhenNotMech(builder, IsFixedWhenNotMech);
			IMechPullInteract.AddIsPlayPullProgress(builder, IsPlayPullProgress);
			IMechPullInteract.AddType(builder, Type);
			return IMechPullInteract.EndIMechPullInteract(builder);
		}

		// Token: 0x06024158 RID: 147800 RVA: 0x004FC438 File Offset: 0x004FA638
		public static void StartIMechPullInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x06024159 RID: 147801 RVA: 0x004FC442 File Offset: 0x004FA642
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602415A RID: 147802 RVA: 0x004FC44D File Offset: 0x004FA64D
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x0602415B RID: 147803 RVA: 0x004FC460 File Offset: 0x004FA660
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602415C RID: 147804 RVA: 0x004FC4A0 File Offset: 0x004FA6A0
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602415D RID: 147805 RVA: 0x004FC4BA File Offset: 0x004FA6BA
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602415E RID: 147806 RVA: 0x004FC4D8 File Offset: 0x004FA6D8
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602415F RID: 147807 RVA: 0x004FC4F1 File Offset: 0x004FA6F1
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024160 RID: 147808 RVA: 0x004FC4FC File Offset: 0x004FA6FC
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x06024161 RID: 147809 RVA: 0x004FC50C File Offset: 0x004FA70C
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024162 RID: 147810 RVA: 0x004FC54C File Offset: 0x004FA74C
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024163 RID: 147811 RVA: 0x004FC566 File Offset: 0x004FA766
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024164 RID: 147812 RVA: 0x004FC584 File Offset: 0x004FA784
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024165 RID: 147813 RVA: 0x004FC59D File Offset: 0x004FA79D
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024166 RID: 147814 RVA: 0x004FC5A8 File Offset: 0x004FA7A8
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x06024167 RID: 147815 RVA: 0x004FC5B8 File Offset: 0x004FA7B8
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024168 RID: 147816 RVA: 0x004FC5F8 File Offset: 0x004FA7F8
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024169 RID: 147817 RVA: 0x004FC612 File Offset: 0x004FA812
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602416A RID: 147818 RVA: 0x004FC630 File Offset: 0x004FA830
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602416B RID: 147819 RVA: 0x004FC649 File Offset: 0x004FA849
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602416C RID: 147820 RVA: 0x004FC654 File Offset: 0x004FA854
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x0602416D RID: 147821 RVA: 0x004FC664 File Offset: 0x004FA864
		public static void AddIsPlayPullProgress(FlatBufferBuilder builder, bool isPlayPullProgress)
		{
			builder.AddBool(5, isPlayPullProgress, false);
		}

		// Token: 0x0602416E RID: 147822 RVA: 0x004FC66F File Offset: 0x004FA86F
		public static void AddPullMoveSpeed(FlatBufferBuilder builder, float pullMoveSpeed)
		{
			builder.AddFloat(6, pullMoveSpeed, 0.0);
		}

		// Token: 0x0602416F RID: 147823 RVA: 0x004FC682 File Offset: 0x004FA882
		public static void AddIsFixedWhenNotMech(FlatBufferBuilder builder, bool isFixedWhenNotMech)
		{
			builder.AddBool(7, isFixedWhenNotMech, false);
		}

		// Token: 0x06024170 RID: 147824 RVA: 0x004FC68D File Offset: 0x004FA88D
		public static void AddDisableAreaEffect(FlatBufferBuilder builder, bool disableAreaEffect)
		{
			builder.AddBool(8, disableAreaEffect, false);
		}

		// Token: 0x06024171 RID: 147825 RVA: 0x004FC698 File Offset: 0x004FA898
		public static void AddDisableCollectEffect(FlatBufferBuilder builder, bool disableCollectEffect)
		{
			builder.AddBool(9, disableCollectEffect, false);
		}

		// Token: 0x06024172 RID: 147826 RVA: 0x004FC6A4 File Offset: 0x004FA8A4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(10, nullMask, 0);
		}

		// Token: 0x06024173 RID: 147827 RVA: 0x004FC6B0 File Offset: 0x004FA8B0
		public static Offset<IMechPullInteract> EndIMechPullInteract(FlatBufferBuilder builder)
		{
			return new Offset<IMechPullInteract>(builder.EndTable());
		}

		// Token: 0x06024174 RID: 147828 RVA: 0x004FC6C0 File Offset: 0x004FA8C0
		public IMechPullInteractT UnPack()
		{
			IMechPullInteractT mechPullInteractT = new IMechPullInteractT();
			this.UnPackTo(mechPullInteractT);
			return mechPullInteractT;
		}

		// Token: 0x06024175 RID: 147829 RVA: 0x004FC6DC File Offset: 0x004FA8DC
		public void UnPackTo(IMechPullInteractT _o)
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
			_o.IsPlayPullProgress = this.IsPlayPullProgress;
			_o.PullMoveSpeed = this.PullMoveSpeed;
			_o.IsFixedWhenNotMech = this.IsFixedWhenNotMech;
			_o.DisableAreaEffect = this.DisableAreaEffect;
			_o.DisableCollectEffect = this.DisableCollectEffect;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06024176 RID: 147830 RVA: 0x004FC86C File Offset: 0x004FAA6C
		public static Offset<IMechPullInteract> Pack(FlatBufferBuilder builder, IMechPullInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechPullInteract>);
			}
			VectorOffset hookActionsOffset = default(VectorOffset);
			if (_o.HookActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.HookActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.HookActions[i]);
				}
				hookActionsOffset = IMechPullInteract.CreateHookActionsVector(builder, array);
			}
			VectorOffset exitHookActionsOffset = default(VectorOffset);
			if (_o.ExitHookActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ExitHookActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ExitHookActions[j]);
				}
				exitHookActionsOffset = IMechPullInteract.CreateExitHookActionsVector(builder, array2);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.FinishActions[k]);
				}
				finishActionsOffset = IMechPullInteract.CreateFinishActionsVector(builder, array3);
			}
			Offset<IClientHookActionConfig> clientHookActionConfigOffset = (_o.ClientHookActionConfig == null) ? default(Offset<IClientHookActionConfig>) : IClientHookActionConfig.Pack(builder, _o.ClientHookActionConfig);
			return IMechPullInteract.CreateIMechPullInteract(builder, _o.Type, hookActionsOffset, exitHookActionsOffset, finishActionsOffset, clientHookActionConfigOffset, _o.IsPlayPullProgress, _o.PullMoveSpeed, _o.IsFixedWhenNotMech, _o.DisableAreaEffect, _o.DisableCollectEffect, _o.NullMask);
		}

		// Token: 0x0400E84E RID: 59470
		private Table __p;
	}
}
