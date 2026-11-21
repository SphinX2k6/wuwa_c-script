using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AD7 RID: 23255
	public struct IMechPullHookInteract : IFlatbufferObject
	{
		// Token: 0x1700A994 RID: 43412
		// (get) Token: 0x060262A6 RID: 156326 RVA: 0x0053ACC2 File Offset: 0x00538EC2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060262A7 RID: 156327 RVA: 0x0053ACCF File Offset: 0x00538ECF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060262A8 RID: 156328 RVA: 0x0053ACD8 File Offset: 0x00538ED8
		public static IMechPullHookInteract GetRootAsIMechPullHookInteract(ByteBuffer _bb)
		{
			return IMechPullHookInteract.GetRootAsIMechPullHookInteract(_bb, default(IMechPullHookInteract));
		}

		// Token: 0x060262A9 RID: 156329 RVA: 0x0053ACF4 File Offset: 0x00538EF4
		public static IMechPullHookInteract GetRootAsIMechPullHookInteract(ByteBuffer _bb, IMechPullHookInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060262AA RID: 156330 RVA: 0x0053AD11 File Offset: 0x00538F11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060262AB RID: 156331 RVA: 0x0053AD20 File Offset: 0x00538F20
		public IMechPullHookInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A995 RID: 43413
		// (get) Token: 0x060262AC RID: 156332 RVA: 0x0053AD30 File Offset: 0x00538F30
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

		// Token: 0x060262AD RID: 156333 RVA: 0x0053AD6C File Offset: 0x00538F6C
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A996 RID: 43414
		// (get) Token: 0x060262AE RID: 156334 RVA: 0x0053ADCC File Offset: 0x00538FCC
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

		// Token: 0x060262AF RID: 156335 RVA: 0x0053ADF8 File Offset: 0x00538FF8
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A997 RID: 43415
		// (get) Token: 0x060262B0 RID: 156336 RVA: 0x0053AE58 File Offset: 0x00539058
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

		// Token: 0x060262B1 RID: 156337 RVA: 0x0053AE84 File Offset: 0x00539084
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A998 RID: 43416
		// (get) Token: 0x060262B2 RID: 156338 RVA: 0x0053AEE8 File Offset: 0x005390E8
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

		// Token: 0x1700A999 RID: 43417
		// (get) Token: 0x060262B3 RID: 156339 RVA: 0x0053AF14 File Offset: 0x00539114
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

		// Token: 0x1700A99A RID: 43418
		// (get) Token: 0x060262B4 RID: 156340 RVA: 0x0053AF74 File Offset: 0x00539174
		public bool IsPlayPullProgress
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A99B RID: 43419
		// (get) Token: 0x060262B5 RID: 156341 RVA: 0x0053AFB4 File Offset: 0x005391B4
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

		// Token: 0x1700A99C RID: 43420
		// (get) Token: 0x060262B6 RID: 156342 RVA: 0x0053AFF8 File Offset: 0x005391F8
		public bool IsFixedWhenNotMech
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A99D RID: 43421
		// (get) Token: 0x060262B7 RID: 156343 RVA: 0x0053B038 File Offset: 0x00539238
		public bool DisableAreaEffect
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A99E RID: 43422
		// (get) Token: 0x060262B8 RID: 156344 RVA: 0x0053B078 File Offset: 0x00539278
		public bool DisableCollectEffect
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A99F RID: 43423
		// (get) Token: 0x060262B9 RID: 156345 RVA: 0x0053B0B8 File Offset: 0x005392B8
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

		// Token: 0x060262BA RID: 156346 RVA: 0x0053B0F8 File Offset: 0x005392F8
		public static Offset<IMechPullHookInteract> CreateIMechPullHookInteract(FlatBufferBuilder builder, EMechHookInteractType Type = EMechHookInteractType.FixedPointHook, VectorOffset HookActionsOffset = default(VectorOffset), VectorOffset ExitHookActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), Offset<IClientHookActionConfig> ClientHookActionConfigOffset = default(Offset<IClientHookActionConfig>), bool IsPlayPullProgress = false, float PullMoveSpeed = 0f, bool IsFixedWhenNotMech = false, bool DisableAreaEffect = false, bool DisableCollectEffect = false, byte NullMask = 0)
		{
			builder.StartTable(11);
			IMechPullHookInteract.AddPullMoveSpeed(builder, PullMoveSpeed);
			IMechPullHookInteract.AddClientHookActionConfig(builder, ClientHookActionConfigOffset);
			IMechPullHookInteract.AddFinishActions(builder, FinishActionsOffset);
			IMechPullHookInteract.AddExitHookActions(builder, ExitHookActionsOffset);
			IMechPullHookInteract.AddHookActions(builder, HookActionsOffset);
			IMechPullHookInteract.AddNullMask(builder, NullMask);
			IMechPullHookInteract.AddDisableCollectEffect(builder, DisableCollectEffect);
			IMechPullHookInteract.AddDisableAreaEffect(builder, DisableAreaEffect);
			IMechPullHookInteract.AddIsFixedWhenNotMech(builder, IsFixedWhenNotMech);
			IMechPullHookInteract.AddIsPlayPullProgress(builder, IsPlayPullProgress);
			IMechPullHookInteract.AddType(builder, Type);
			return IMechPullHookInteract.EndIMechPullHookInteract(builder);
		}

		// Token: 0x060262BB RID: 156347 RVA: 0x0053B168 File Offset: 0x00539368
		public static void StartIMechPullHookInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x060262BC RID: 156348 RVA: 0x0053B172 File Offset: 0x00539372
		public static void AddType(FlatBufferBuilder builder, EMechHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060262BD RID: 156349 RVA: 0x0053B17D File Offset: 0x0053937D
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x060262BE RID: 156350 RVA: 0x0053B190 File Offset: 0x00539390
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060262BF RID: 156351 RVA: 0x0053B1D0 File Offset: 0x005393D0
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060262C0 RID: 156352 RVA: 0x0053B1EA File Offset: 0x005393EA
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060262C1 RID: 156353 RVA: 0x0053B208 File Offset: 0x00539408
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060262C2 RID: 156354 RVA: 0x0053B221 File Offset: 0x00539421
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060262C3 RID: 156355 RVA: 0x0053B22C File Offset: 0x0053942C
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x060262C4 RID: 156356 RVA: 0x0053B23C File Offset: 0x0053943C
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060262C5 RID: 156357 RVA: 0x0053B27C File Offset: 0x0053947C
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060262C6 RID: 156358 RVA: 0x0053B296 File Offset: 0x00539496
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060262C7 RID: 156359 RVA: 0x0053B2B4 File Offset: 0x005394B4
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060262C8 RID: 156360 RVA: 0x0053B2CD File Offset: 0x005394CD
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060262C9 RID: 156361 RVA: 0x0053B2D8 File Offset: 0x005394D8
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x060262CA RID: 156362 RVA: 0x0053B2E8 File Offset: 0x005394E8
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060262CB RID: 156363 RVA: 0x0053B328 File Offset: 0x00539528
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060262CC RID: 156364 RVA: 0x0053B342 File Offset: 0x00539542
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060262CD RID: 156365 RVA: 0x0053B360 File Offset: 0x00539560
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060262CE RID: 156366 RVA: 0x0053B379 File Offset: 0x00539579
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060262CF RID: 156367 RVA: 0x0053B384 File Offset: 0x00539584
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x060262D0 RID: 156368 RVA: 0x0053B394 File Offset: 0x00539594
		public static void AddIsPlayPullProgress(FlatBufferBuilder builder, bool isPlayPullProgress)
		{
			builder.AddBool(5, isPlayPullProgress, false);
		}

		// Token: 0x060262D1 RID: 156369 RVA: 0x0053B39F File Offset: 0x0053959F
		public static void AddPullMoveSpeed(FlatBufferBuilder builder, float pullMoveSpeed)
		{
			builder.AddFloat(6, pullMoveSpeed, 0.0);
		}

		// Token: 0x060262D2 RID: 156370 RVA: 0x0053B3B2 File Offset: 0x005395B2
		public static void AddIsFixedWhenNotMech(FlatBufferBuilder builder, bool isFixedWhenNotMech)
		{
			builder.AddBool(7, isFixedWhenNotMech, false);
		}

		// Token: 0x060262D3 RID: 156371 RVA: 0x0053B3BD File Offset: 0x005395BD
		public static void AddDisableAreaEffect(FlatBufferBuilder builder, bool disableAreaEffect)
		{
			builder.AddBool(8, disableAreaEffect, false);
		}

		// Token: 0x060262D4 RID: 156372 RVA: 0x0053B3C8 File Offset: 0x005395C8
		public static void AddDisableCollectEffect(FlatBufferBuilder builder, bool disableCollectEffect)
		{
			builder.AddBool(9, disableCollectEffect, false);
		}

		// Token: 0x060262D5 RID: 156373 RVA: 0x0053B3D4 File Offset: 0x005395D4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(10, nullMask, 0);
		}

		// Token: 0x060262D6 RID: 156374 RVA: 0x0053B3E0 File Offset: 0x005395E0
		public static Offset<IMechPullHookInteract> EndIMechPullHookInteract(FlatBufferBuilder builder)
		{
			return new Offset<IMechPullHookInteract>(builder.EndTable());
		}

		// Token: 0x060262D7 RID: 156375 RVA: 0x0053B3F0 File Offset: 0x005395F0
		public IMechPullHookInteractT UnPack()
		{
			IMechPullHookInteractT mechPullHookInteractT = new IMechPullHookInteractT();
			this.UnPackTo(mechPullHookInteractT);
			return mechPullHookInteractT;
		}

		// Token: 0x060262D8 RID: 156376 RVA: 0x0053B40C File Offset: 0x0053960C
		public void UnPackTo(IMechPullHookInteractT _o)
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

		// Token: 0x060262D9 RID: 156377 RVA: 0x0053B59C File Offset: 0x0053979C
		public static Offset<IMechPullHookInteract> Pack(FlatBufferBuilder builder, IMechPullHookInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechPullHookInteract>);
			}
			VectorOffset hookActionsOffset = default(VectorOffset);
			if (_o.HookActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.HookActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.HookActions[i]);
				}
				hookActionsOffset = IMechPullHookInteract.CreateHookActionsVector(builder, array);
			}
			VectorOffset exitHookActionsOffset = default(VectorOffset);
			if (_o.ExitHookActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ExitHookActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ExitHookActions[j]);
				}
				exitHookActionsOffset = IMechPullHookInteract.CreateExitHookActionsVector(builder, array2);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.FinishActions[k]);
				}
				finishActionsOffset = IMechPullHookInteract.CreateFinishActionsVector(builder, array3);
			}
			Offset<IClientHookActionConfig> clientHookActionConfigOffset = (_o.ClientHookActionConfig == null) ? default(Offset<IClientHookActionConfig>) : IClientHookActionConfig.Pack(builder, _o.ClientHookActionConfig);
			return IMechPullHookInteract.CreateIMechPullHookInteract(builder, _o.Type, hookActionsOffset, exitHookActionsOffset, finishActionsOffset, clientHookActionConfigOffset, _o.IsPlayPullProgress, _o.PullMoveSpeed, _o.IsFixedWhenNotMech, _o.DisableAreaEffect, _o.DisableCollectEffect, _o.NullMask);
		}

		// Token: 0x0400F498 RID: 62616
		private Table __p;
	}
}
