using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B64 RID: 23396
	public struct IMotorPullInteract : IFlatbufferObject
	{
		// Token: 0x1700AACA RID: 43722
		// (get) Token: 0x06026808 RID: 157704 RVA: 0x00545A96 File Offset: 0x00543C96
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026809 RID: 157705 RVA: 0x00545AA3 File Offset: 0x00543CA3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602680A RID: 157706 RVA: 0x00545AAC File Offset: 0x00543CAC
		public static IMotorPullInteract GetRootAsIMotorPullInteract(ByteBuffer _bb)
		{
			return IMotorPullInteract.GetRootAsIMotorPullInteract(_bb, default(IMotorPullInteract));
		}

		// Token: 0x0602680B RID: 157707 RVA: 0x00545AC8 File Offset: 0x00543CC8
		public static IMotorPullInteract GetRootAsIMotorPullInteract(ByteBuffer _bb, IMotorPullInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602680C RID: 157708 RVA: 0x00545AE5 File Offset: 0x00543CE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602680D RID: 157709 RVA: 0x00545AF4 File Offset: 0x00543CF4
		public IMotorPullInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AACB RID: 43723
		// (get) Token: 0x0602680E RID: 157710 RVA: 0x00545B04 File Offset: 0x00543D04
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

		// Token: 0x0602680F RID: 157711 RVA: 0x00545B40 File Offset: 0x00543D40
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AACC RID: 43724
		// (get) Token: 0x06026810 RID: 157712 RVA: 0x00545BA0 File Offset: 0x00543DA0
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

		// Token: 0x06026811 RID: 157713 RVA: 0x00545BCC File Offset: 0x00543DCC
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AACD RID: 43725
		// (get) Token: 0x06026812 RID: 157714 RVA: 0x00545C2C File Offset: 0x00543E2C
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

		// Token: 0x06026813 RID: 157715 RVA: 0x00545C58 File Offset: 0x00543E58
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AACE RID: 43726
		// (get) Token: 0x06026814 RID: 157716 RVA: 0x00545CBC File Offset: 0x00543EBC
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

		// Token: 0x1700AACF RID: 43727
		// (get) Token: 0x06026815 RID: 157717 RVA: 0x00545CE8 File Offset: 0x00543EE8
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

		// Token: 0x1700AAD0 RID: 43728
		// (get) Token: 0x06026816 RID: 157718 RVA: 0x00545D48 File Offset: 0x00543F48
		public bool IsPlayPullProgress
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AAD1 RID: 43729
		// (get) Token: 0x06026817 RID: 157719 RVA: 0x00545D88 File Offset: 0x00543F88
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

		// Token: 0x1700AAD2 RID: 43730
		// (get) Token: 0x06026818 RID: 157720 RVA: 0x00545DCC File Offset: 0x00543FCC
		public bool IsFixedWhenNotRide
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AAD3 RID: 43731
		// (get) Token: 0x06026819 RID: 157721 RVA: 0x00545E0C File Offset: 0x0054400C
		public bool DisableAreaEffect
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AAD4 RID: 43732
		// (get) Token: 0x0602681A RID: 157722 RVA: 0x00545E4C File Offset: 0x0054404C
		public bool DisableCollectEffect
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AAD5 RID: 43733
		// (get) Token: 0x0602681B RID: 157723 RVA: 0x00545E8C File Offset: 0x0054408C
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

		// Token: 0x0602681C RID: 157724 RVA: 0x00545ECC File Offset: 0x005440CC
		public static Offset<IMotorPullInteract> CreateIMotorPullInteract(FlatBufferBuilder builder, EHookInteractType Type = EHookInteractType.FixedPointHook, VectorOffset HookActionsOffset = default(VectorOffset), VectorOffset ExitHookActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), Offset<IClientHookActionConfig> ClientHookActionConfigOffset = default(Offset<IClientHookActionConfig>), bool IsPlayPullProgress = false, float PullMoveSpeed = 0f, bool IsFixedWhenNotRide = false, bool DisableAreaEffect = false, bool DisableCollectEffect = false, byte NullMask = 0)
		{
			builder.StartTable(11);
			IMotorPullInteract.AddPullMoveSpeed(builder, PullMoveSpeed);
			IMotorPullInteract.AddClientHookActionConfig(builder, ClientHookActionConfigOffset);
			IMotorPullInteract.AddFinishActions(builder, FinishActionsOffset);
			IMotorPullInteract.AddExitHookActions(builder, ExitHookActionsOffset);
			IMotorPullInteract.AddHookActions(builder, HookActionsOffset);
			IMotorPullInteract.AddNullMask(builder, NullMask);
			IMotorPullInteract.AddDisableCollectEffect(builder, DisableCollectEffect);
			IMotorPullInteract.AddDisableAreaEffect(builder, DisableAreaEffect);
			IMotorPullInteract.AddIsFixedWhenNotRide(builder, IsFixedWhenNotRide);
			IMotorPullInteract.AddIsPlayPullProgress(builder, IsPlayPullProgress);
			IMotorPullInteract.AddType(builder, Type);
			return IMotorPullInteract.EndIMotorPullInteract(builder);
		}

		// Token: 0x0602681D RID: 157725 RVA: 0x00545F3C File Offset: 0x0054413C
		public static void StartIMotorPullInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x0602681E RID: 157726 RVA: 0x00545F46 File Offset: 0x00544146
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602681F RID: 157727 RVA: 0x00545F51 File Offset: 0x00544151
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x06026820 RID: 157728 RVA: 0x00545F64 File Offset: 0x00544164
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026821 RID: 157729 RVA: 0x00545FA4 File Offset: 0x005441A4
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026822 RID: 157730 RVA: 0x00545FBE File Offset: 0x005441BE
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026823 RID: 157731 RVA: 0x00545FDC File Offset: 0x005441DC
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026824 RID: 157732 RVA: 0x00545FF5 File Offset: 0x005441F5
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026825 RID: 157733 RVA: 0x00546000 File Offset: 0x00544200
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x06026826 RID: 157734 RVA: 0x00546010 File Offset: 0x00544210
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026827 RID: 157735 RVA: 0x00546050 File Offset: 0x00544250
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026828 RID: 157736 RVA: 0x0054606A File Offset: 0x0054426A
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026829 RID: 157737 RVA: 0x00546088 File Offset: 0x00544288
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602682A RID: 157738 RVA: 0x005460A1 File Offset: 0x005442A1
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602682B RID: 157739 RVA: 0x005460AC File Offset: 0x005442AC
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x0602682C RID: 157740 RVA: 0x005460BC File Offset: 0x005442BC
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602682D RID: 157741 RVA: 0x005460FC File Offset: 0x005442FC
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602682E RID: 157742 RVA: 0x00546116 File Offset: 0x00544316
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602682F RID: 157743 RVA: 0x00546134 File Offset: 0x00544334
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026830 RID: 157744 RVA: 0x0054614D File Offset: 0x0054434D
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026831 RID: 157745 RVA: 0x00546158 File Offset: 0x00544358
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x06026832 RID: 157746 RVA: 0x00546168 File Offset: 0x00544368
		public static void AddIsPlayPullProgress(FlatBufferBuilder builder, bool isPlayPullProgress)
		{
			builder.AddBool(5, isPlayPullProgress, false);
		}

		// Token: 0x06026833 RID: 157747 RVA: 0x00546173 File Offset: 0x00544373
		public static void AddPullMoveSpeed(FlatBufferBuilder builder, float pullMoveSpeed)
		{
			builder.AddFloat(6, pullMoveSpeed, 0.0);
		}

		// Token: 0x06026834 RID: 157748 RVA: 0x00546186 File Offset: 0x00544386
		public static void AddIsFixedWhenNotRide(FlatBufferBuilder builder, bool isFixedWhenNotRide)
		{
			builder.AddBool(7, isFixedWhenNotRide, false);
		}

		// Token: 0x06026835 RID: 157749 RVA: 0x00546191 File Offset: 0x00544391
		public static void AddDisableAreaEffect(FlatBufferBuilder builder, bool disableAreaEffect)
		{
			builder.AddBool(8, disableAreaEffect, false);
		}

		// Token: 0x06026836 RID: 157750 RVA: 0x0054619C File Offset: 0x0054439C
		public static void AddDisableCollectEffect(FlatBufferBuilder builder, bool disableCollectEffect)
		{
			builder.AddBool(9, disableCollectEffect, false);
		}

		// Token: 0x06026837 RID: 157751 RVA: 0x005461A8 File Offset: 0x005443A8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(10, nullMask, 0);
		}

		// Token: 0x06026838 RID: 157752 RVA: 0x005461B4 File Offset: 0x005443B4
		public static Offset<IMotorPullInteract> EndIMotorPullInteract(FlatBufferBuilder builder)
		{
			return new Offset<IMotorPullInteract>(builder.EndTable());
		}

		// Token: 0x06026839 RID: 157753 RVA: 0x005461C4 File Offset: 0x005443C4
		public IMotorPullInteractT UnPack()
		{
			IMotorPullInteractT motorPullInteractT = new IMotorPullInteractT();
			this.UnPackTo(motorPullInteractT);
			return motorPullInteractT;
		}

		// Token: 0x0602683A RID: 157754 RVA: 0x005461E0 File Offset: 0x005443E0
		public void UnPackTo(IMotorPullInteractT _o)
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
			_o.IsFixedWhenNotRide = this.IsFixedWhenNotRide;
			_o.DisableAreaEffect = this.DisableAreaEffect;
			_o.DisableCollectEffect = this.DisableCollectEffect;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602683B RID: 157755 RVA: 0x00546370 File Offset: 0x00544570
		public static Offset<IMotorPullInteract> Pack(FlatBufferBuilder builder, IMotorPullInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorPullInteract>);
			}
			VectorOffset hookActionsOffset = default(VectorOffset);
			if (_o.HookActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.HookActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.HookActions[i]);
				}
				hookActionsOffset = IMotorPullInteract.CreateHookActionsVector(builder, array);
			}
			VectorOffset exitHookActionsOffset = default(VectorOffset);
			if (_o.ExitHookActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ExitHookActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ExitHookActions[j]);
				}
				exitHookActionsOffset = IMotorPullInteract.CreateExitHookActionsVector(builder, array2);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.FinishActions[k]);
				}
				finishActionsOffset = IMotorPullInteract.CreateFinishActionsVector(builder, array3);
			}
			Offset<IClientHookActionConfig> clientHookActionConfigOffset = (_o.ClientHookActionConfig == null) ? default(Offset<IClientHookActionConfig>) : IClientHookActionConfig.Pack(builder, _o.ClientHookActionConfig);
			return IMotorPullInteract.CreateIMotorPullInteract(builder, _o.Type, hookActionsOffset, exitHookActionsOffset, finishActionsOffset, clientHookActionConfigOffset, _o.IsPlayPullProgress, _o.PullMoveSpeed, _o.IsFixedWhenNotRide, _o.DisableAreaEffect, _o.DisableCollectEffect, _o.NullMask);
		}

		// Token: 0x0400F571 RID: 62833
		private Table __p;
	}
}
