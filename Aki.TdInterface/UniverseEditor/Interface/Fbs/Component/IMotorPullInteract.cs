using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055C6 RID: 21958
	public struct IMotorPullInteract : IFlatbufferObject
	{
		// Token: 0x1700A242 RID: 41538
		// (get) Token: 0x060245FB RID: 148987 RVA: 0x0050551E File Offset: 0x0050371E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060245FC RID: 148988 RVA: 0x0050552B File Offset: 0x0050372B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060245FD RID: 148989 RVA: 0x00505534 File Offset: 0x00503734
		public static IMotorPullInteract GetRootAsIMotorPullInteract(ByteBuffer _bb)
		{
			return IMotorPullInteract.GetRootAsIMotorPullInteract(_bb, default(IMotorPullInteract));
		}

		// Token: 0x060245FE RID: 148990 RVA: 0x00505550 File Offset: 0x00503750
		public static IMotorPullInteract GetRootAsIMotorPullInteract(ByteBuffer _bb, IMotorPullInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060245FF RID: 148991 RVA: 0x0050556D File Offset: 0x0050376D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024600 RID: 148992 RVA: 0x0050557C File Offset: 0x0050377C
		public IMotorPullInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A243 RID: 41539
		// (get) Token: 0x06024601 RID: 148993 RVA: 0x0050558C File Offset: 0x0050378C
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

		// Token: 0x06024602 RID: 148994 RVA: 0x005055C8 File Offset: 0x005037C8
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A244 RID: 41540
		// (get) Token: 0x06024603 RID: 148995 RVA: 0x00505628 File Offset: 0x00503828
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

		// Token: 0x06024604 RID: 148996 RVA: 0x00505654 File Offset: 0x00503854
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A245 RID: 41541
		// (get) Token: 0x06024605 RID: 148997 RVA: 0x005056B4 File Offset: 0x005038B4
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

		// Token: 0x06024606 RID: 148998 RVA: 0x005056E0 File Offset: 0x005038E0
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A246 RID: 41542
		// (get) Token: 0x06024607 RID: 148999 RVA: 0x00505744 File Offset: 0x00503944
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

		// Token: 0x1700A247 RID: 41543
		// (get) Token: 0x06024608 RID: 149000 RVA: 0x00505770 File Offset: 0x00503970
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

		// Token: 0x1700A248 RID: 41544
		// (get) Token: 0x06024609 RID: 149001 RVA: 0x005057D0 File Offset: 0x005039D0
		public bool IsPlayPullProgress
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A249 RID: 41545
		// (get) Token: 0x0602460A RID: 149002 RVA: 0x00505810 File Offset: 0x00503A10
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

		// Token: 0x1700A24A RID: 41546
		// (get) Token: 0x0602460B RID: 149003 RVA: 0x00505854 File Offset: 0x00503A54
		public bool IsFixedWhenNotRide
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A24B RID: 41547
		// (get) Token: 0x0602460C RID: 149004 RVA: 0x00505894 File Offset: 0x00503A94
		public bool DisableAreaEffect
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A24C RID: 41548
		// (get) Token: 0x0602460D RID: 149005 RVA: 0x005058D4 File Offset: 0x00503AD4
		public bool DisableCollectEffect
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A24D RID: 41549
		// (get) Token: 0x0602460E RID: 149006 RVA: 0x00505914 File Offset: 0x00503B14
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

		// Token: 0x0602460F RID: 149007 RVA: 0x00505954 File Offset: 0x00503B54
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

		// Token: 0x06024610 RID: 149008 RVA: 0x005059C4 File Offset: 0x00503BC4
		public static void StartIMotorPullInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x06024611 RID: 149009 RVA: 0x005059CE File Offset: 0x00503BCE
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024612 RID: 149010 RVA: 0x005059D9 File Offset: 0x00503BD9
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x06024613 RID: 149011 RVA: 0x005059EC File Offset: 0x00503BEC
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024614 RID: 149012 RVA: 0x00505A2C File Offset: 0x00503C2C
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024615 RID: 149013 RVA: 0x00505A46 File Offset: 0x00503C46
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024616 RID: 149014 RVA: 0x00505A64 File Offset: 0x00503C64
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024617 RID: 149015 RVA: 0x00505A7D File Offset: 0x00503C7D
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024618 RID: 149016 RVA: 0x00505A88 File Offset: 0x00503C88
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x06024619 RID: 149017 RVA: 0x00505A98 File Offset: 0x00503C98
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602461A RID: 149018 RVA: 0x00505AD8 File Offset: 0x00503CD8
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602461B RID: 149019 RVA: 0x00505AF2 File Offset: 0x00503CF2
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602461C RID: 149020 RVA: 0x00505B10 File Offset: 0x00503D10
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602461D RID: 149021 RVA: 0x00505B29 File Offset: 0x00503D29
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602461E RID: 149022 RVA: 0x00505B34 File Offset: 0x00503D34
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x0602461F RID: 149023 RVA: 0x00505B44 File Offset: 0x00503D44
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024620 RID: 149024 RVA: 0x00505B84 File Offset: 0x00503D84
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024621 RID: 149025 RVA: 0x00505B9E File Offset: 0x00503D9E
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024622 RID: 149026 RVA: 0x00505BBC File Offset: 0x00503DBC
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024623 RID: 149027 RVA: 0x00505BD5 File Offset: 0x00503DD5
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024624 RID: 149028 RVA: 0x00505BE0 File Offset: 0x00503DE0
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x06024625 RID: 149029 RVA: 0x00505BF0 File Offset: 0x00503DF0
		public static void AddIsPlayPullProgress(FlatBufferBuilder builder, bool isPlayPullProgress)
		{
			builder.AddBool(5, isPlayPullProgress, false);
		}

		// Token: 0x06024626 RID: 149030 RVA: 0x00505BFB File Offset: 0x00503DFB
		public static void AddPullMoveSpeed(FlatBufferBuilder builder, float pullMoveSpeed)
		{
			builder.AddFloat(6, pullMoveSpeed, 0.0);
		}

		// Token: 0x06024627 RID: 149031 RVA: 0x00505C0E File Offset: 0x00503E0E
		public static void AddIsFixedWhenNotRide(FlatBufferBuilder builder, bool isFixedWhenNotRide)
		{
			builder.AddBool(7, isFixedWhenNotRide, false);
		}

		// Token: 0x06024628 RID: 149032 RVA: 0x00505C19 File Offset: 0x00503E19
		public static void AddDisableAreaEffect(FlatBufferBuilder builder, bool disableAreaEffect)
		{
			builder.AddBool(8, disableAreaEffect, false);
		}

		// Token: 0x06024629 RID: 149033 RVA: 0x00505C24 File Offset: 0x00503E24
		public static void AddDisableCollectEffect(FlatBufferBuilder builder, bool disableCollectEffect)
		{
			builder.AddBool(9, disableCollectEffect, false);
		}

		// Token: 0x0602462A RID: 149034 RVA: 0x00505C30 File Offset: 0x00503E30
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(10, nullMask, 0);
		}

		// Token: 0x0602462B RID: 149035 RVA: 0x00505C3C File Offset: 0x00503E3C
		public static Offset<IMotorPullInteract> EndIMotorPullInteract(FlatBufferBuilder builder)
		{
			return new Offset<IMotorPullInteract>(builder.EndTable());
		}

		// Token: 0x0602462C RID: 149036 RVA: 0x00505C4C File Offset: 0x00503E4C
		public IMotorPullInteractT UnPack()
		{
			IMotorPullInteractT motorPullInteractT = new IMotorPullInteractT();
			this.UnPackTo(motorPullInteractT);
			return motorPullInteractT;
		}

		// Token: 0x0602462D RID: 149037 RVA: 0x00505C68 File Offset: 0x00503E68
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

		// Token: 0x0602462E RID: 149038 RVA: 0x00505DF8 File Offset: 0x00503FF8
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

		// Token: 0x0400E90F RID: 59663
		private Table __p;
	}
}
