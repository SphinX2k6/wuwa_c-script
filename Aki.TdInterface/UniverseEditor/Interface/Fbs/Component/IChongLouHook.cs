using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054CF RID: 21711
	public struct IChongLouHook : IFlatbufferObject
	{
		// Token: 0x17009B00 RID: 39680
		// (get) Token: 0x060223FB RID: 140283 RVA: 0x004B8868 File Offset: 0x004B6A68
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060223FC RID: 140284 RVA: 0x004B8875 File Offset: 0x004B6A75
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060223FD RID: 140285 RVA: 0x004B887C File Offset: 0x004B6A7C
		public static IChongLouHook GetRootAsIChongLouHook(ByteBuffer _bb)
		{
			return IChongLouHook.GetRootAsIChongLouHook(_bb, default(IChongLouHook));
		}

		// Token: 0x060223FE RID: 140286 RVA: 0x004B8898 File Offset: 0x004B6A98
		public static IChongLouHook GetRootAsIChongLouHook(ByteBuffer _bb, IChongLouHook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060223FF RID: 140287 RVA: 0x004B88B5 File Offset: 0x004B6AB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022400 RID: 140288 RVA: 0x004B88C4 File Offset: 0x004B6AC4
		public IChongLouHook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009B01 RID: 39681
		// (get) Token: 0x06022401 RID: 140289 RVA: 0x004B88D4 File Offset: 0x004B6AD4
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

		// Token: 0x06022402 RID: 140290 RVA: 0x004B8910 File Offset: 0x004B6B10
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009B02 RID: 39682
		// (get) Token: 0x06022403 RID: 140291 RVA: 0x004B8970 File Offset: 0x004B6B70
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

		// Token: 0x06022404 RID: 140292 RVA: 0x004B899C File Offset: 0x004B6B9C
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009B03 RID: 39683
		// (get) Token: 0x06022405 RID: 140293 RVA: 0x004B89FC File Offset: 0x004B6BFC
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

		// Token: 0x06022406 RID: 140294 RVA: 0x004B8A28 File Offset: 0x004B6C28
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009B04 RID: 39684
		// (get) Token: 0x06022407 RID: 140295 RVA: 0x004B8A8C File Offset: 0x004B6C8C
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

		// Token: 0x17009B05 RID: 39685
		// (get) Token: 0x06022408 RID: 140296 RVA: 0x004B8AB8 File Offset: 0x004B6CB8
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

		// Token: 0x17009B06 RID: 39686
		// (get) Token: 0x06022409 RID: 140297 RVA: 0x004B8B18 File Offset: 0x004B6D18
		public float HookMoveSpeed
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009B07 RID: 39687
		// (get) Token: 0x0602240A RID: 140298 RVA: 0x004B8B5C File Offset: 0x004B6D5C
		public float Acceleration
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

		// Token: 0x17009B08 RID: 39688
		// (get) Token: 0x0602240B RID: 140299 RVA: 0x004B8BA0 File Offset: 0x004B6DA0
		public float LateralMoveSpeed
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009B09 RID: 39689
		// (get) Token: 0x0602240C RID: 140300 RVA: 0x004B8BE4 File Offset: 0x004B6DE4
		public float LateralAccelerateTime
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009B0A RID: 39690
		// (get) Token: 0x0602240D RID: 140301 RVA: 0x004B8C28 File Offset: 0x004B6E28
		public float LateralDecelerateTime
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009B0B RID: 39691
		// (get) Token: 0x0602240E RID: 140302 RVA: 0x004B8C6C File Offset: 0x004B6E6C
		public float MaxLateralOffset
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009B0C RID: 39692
		// (get) Token: 0x0602240F RID: 140303 RVA: 0x004B8CB0 File Offset: 0x004B6EB0
		public float VerticalMoveSpeed
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009B0D RID: 39693
		// (get) Token: 0x06022410 RID: 140304 RVA: 0x004B8CF4 File Offset: 0x004B6EF4
		public float VerticalAccelerateTime
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009B0E RID: 39694
		// (get) Token: 0x06022411 RID: 140305 RVA: 0x004B8D38 File Offset: 0x004B6F38
		public float VerticalDecelerateTime
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009B0F RID: 39695
		// (get) Token: 0x06022412 RID: 140306 RVA: 0x004B8D7C File Offset: 0x004B6F7C
		public ushort NullMask
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetUshort(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022413 RID: 140307 RVA: 0x004B8DBC File Offset: 0x004B6FBC
		public static Offset<IChongLouHook> CreateIChongLouHook(FlatBufferBuilder builder, EHookInteractType Type = EHookInteractType.FixedPointHook, VectorOffset HookActionsOffset = default(VectorOffset), VectorOffset ExitHookActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), Offset<IClientHookActionConfig> ClientHookActionConfigOffset = default(Offset<IClientHookActionConfig>), float HookMoveSpeed = 0f, float Acceleration = 0f, float LateralMoveSpeed = 0f, float LateralAccelerateTime = 0f, float LateralDecelerateTime = 0f, float MaxLateralOffset = 0f, float VerticalMoveSpeed = 0f, float VerticalAccelerateTime = 0f, float VerticalDecelerateTime = 0f, ushort NullMask = 0)
		{
			builder.StartTable(15);
			IChongLouHook.AddVerticalDecelerateTime(builder, VerticalDecelerateTime);
			IChongLouHook.AddVerticalAccelerateTime(builder, VerticalAccelerateTime);
			IChongLouHook.AddVerticalMoveSpeed(builder, VerticalMoveSpeed);
			IChongLouHook.AddMaxLateralOffset(builder, MaxLateralOffset);
			IChongLouHook.AddLateralDecelerateTime(builder, LateralDecelerateTime);
			IChongLouHook.AddLateralAccelerateTime(builder, LateralAccelerateTime);
			IChongLouHook.AddLateralMoveSpeed(builder, LateralMoveSpeed);
			IChongLouHook.AddAcceleration(builder, Acceleration);
			IChongLouHook.AddHookMoveSpeed(builder, HookMoveSpeed);
			IChongLouHook.AddClientHookActionConfig(builder, ClientHookActionConfigOffset);
			IChongLouHook.AddFinishActions(builder, FinishActionsOffset);
			IChongLouHook.AddExitHookActions(builder, ExitHookActionsOffset);
			IChongLouHook.AddHookActions(builder, HookActionsOffset);
			IChongLouHook.AddNullMask(builder, NullMask);
			IChongLouHook.AddType(builder, Type);
			return IChongLouHook.EndIChongLouHook(builder);
		}

		// Token: 0x06022414 RID: 140308 RVA: 0x004B8E4C File Offset: 0x004B704C
		public static void StartIChongLouHook(FlatBufferBuilder builder)
		{
			builder.StartTable(15);
		}

		// Token: 0x06022415 RID: 140309 RVA: 0x004B8E56 File Offset: 0x004B7056
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022416 RID: 140310 RVA: 0x004B8E61 File Offset: 0x004B7061
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x06022417 RID: 140311 RVA: 0x004B8E74 File Offset: 0x004B7074
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022418 RID: 140312 RVA: 0x004B8EB4 File Offset: 0x004B70B4
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022419 RID: 140313 RVA: 0x004B8ECE File Offset: 0x004B70CE
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602241A RID: 140314 RVA: 0x004B8EEC File Offset: 0x004B70EC
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602241B RID: 140315 RVA: 0x004B8F05 File Offset: 0x004B7105
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602241C RID: 140316 RVA: 0x004B8F10 File Offset: 0x004B7110
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x0602241D RID: 140317 RVA: 0x004B8F20 File Offset: 0x004B7120
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602241E RID: 140318 RVA: 0x004B8F60 File Offset: 0x004B7160
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602241F RID: 140319 RVA: 0x004B8F7A File Offset: 0x004B717A
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022420 RID: 140320 RVA: 0x004B8F98 File Offset: 0x004B7198
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022421 RID: 140321 RVA: 0x004B8FB1 File Offset: 0x004B71B1
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022422 RID: 140322 RVA: 0x004B8FBC File Offset: 0x004B71BC
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x06022423 RID: 140323 RVA: 0x004B8FCC File Offset: 0x004B71CC
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022424 RID: 140324 RVA: 0x004B900C File Offset: 0x004B720C
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022425 RID: 140325 RVA: 0x004B9026 File Offset: 0x004B7226
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022426 RID: 140326 RVA: 0x004B9044 File Offset: 0x004B7244
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022427 RID: 140327 RVA: 0x004B905D File Offset: 0x004B725D
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022428 RID: 140328 RVA: 0x004B9068 File Offset: 0x004B7268
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x06022429 RID: 140329 RVA: 0x004B9078 File Offset: 0x004B7278
		public static void AddHookMoveSpeed(FlatBufferBuilder builder, float hookMoveSpeed)
		{
			builder.AddFloat(5, hookMoveSpeed, 0.0);
		}

		// Token: 0x0602242A RID: 140330 RVA: 0x004B908B File Offset: 0x004B728B
		public static void AddAcceleration(FlatBufferBuilder builder, float acceleration)
		{
			builder.AddFloat(6, acceleration, 0.0);
		}

		// Token: 0x0602242B RID: 140331 RVA: 0x004B909E File Offset: 0x004B729E
		public static void AddLateralMoveSpeed(FlatBufferBuilder builder, float lateralMoveSpeed)
		{
			builder.AddFloat(7, lateralMoveSpeed, 0.0);
		}

		// Token: 0x0602242C RID: 140332 RVA: 0x004B90B1 File Offset: 0x004B72B1
		public static void AddLateralAccelerateTime(FlatBufferBuilder builder, float lateralAccelerateTime)
		{
			builder.AddFloat(8, lateralAccelerateTime, 0.0);
		}

		// Token: 0x0602242D RID: 140333 RVA: 0x004B90C4 File Offset: 0x004B72C4
		public static void AddLateralDecelerateTime(FlatBufferBuilder builder, float lateralDecelerateTime)
		{
			builder.AddFloat(9, lateralDecelerateTime, 0.0);
		}

		// Token: 0x0602242E RID: 140334 RVA: 0x004B90D8 File Offset: 0x004B72D8
		public static void AddMaxLateralOffset(FlatBufferBuilder builder, float maxLateralOffset)
		{
			builder.AddFloat(10, maxLateralOffset, 0.0);
		}

		// Token: 0x0602242F RID: 140335 RVA: 0x004B90EC File Offset: 0x004B72EC
		public static void AddVerticalMoveSpeed(FlatBufferBuilder builder, float verticalMoveSpeed)
		{
			builder.AddFloat(11, verticalMoveSpeed, 0.0);
		}

		// Token: 0x06022430 RID: 140336 RVA: 0x004B9100 File Offset: 0x004B7300
		public static void AddVerticalAccelerateTime(FlatBufferBuilder builder, float verticalAccelerateTime)
		{
			builder.AddFloat(12, verticalAccelerateTime, 0.0);
		}

		// Token: 0x06022431 RID: 140337 RVA: 0x004B9114 File Offset: 0x004B7314
		public static void AddVerticalDecelerateTime(FlatBufferBuilder builder, float verticalDecelerateTime)
		{
			builder.AddFloat(13, verticalDecelerateTime, 0.0);
		}

		// Token: 0x06022432 RID: 140338 RVA: 0x004B9128 File Offset: 0x004B7328
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(14, nullMask, 0);
		}

		// Token: 0x06022433 RID: 140339 RVA: 0x004B9134 File Offset: 0x004B7334
		public static Offset<IChongLouHook> EndIChongLouHook(FlatBufferBuilder builder)
		{
			return new Offset<IChongLouHook>(builder.EndTable());
		}

		// Token: 0x06022434 RID: 140340 RVA: 0x004B9144 File Offset: 0x004B7344
		public IChongLouHookT UnPack()
		{
			IChongLouHookT chongLouHookT = new IChongLouHookT();
			this.UnPackTo(chongLouHookT);
			return chongLouHookT;
		}

		// Token: 0x06022435 RID: 140341 RVA: 0x004B9160 File Offset: 0x004B7360
		public void UnPackTo(IChongLouHookT _o)
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
			_o.HookMoveSpeed = this.HookMoveSpeed;
			_o.Acceleration = this.Acceleration;
			_o.LateralMoveSpeed = this.LateralMoveSpeed;
			_o.LateralAccelerateTime = this.LateralAccelerateTime;
			_o.LateralDecelerateTime = this.LateralDecelerateTime;
			_o.MaxLateralOffset = this.MaxLateralOffset;
			_o.VerticalMoveSpeed = this.VerticalMoveSpeed;
			_o.VerticalAccelerateTime = this.VerticalAccelerateTime;
			_o.VerticalDecelerateTime = this.VerticalDecelerateTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06022436 RID: 140342 RVA: 0x004B9320 File Offset: 0x004B7520
		public static Offset<IChongLouHook> Pack(FlatBufferBuilder builder, IChongLouHookT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChongLouHook>);
			}
			VectorOffset hookActionsOffset = default(VectorOffset);
			if (_o.HookActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.HookActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.HookActions[i]);
				}
				hookActionsOffset = IChongLouHook.CreateHookActionsVector(builder, array);
			}
			VectorOffset exitHookActionsOffset = default(VectorOffset);
			if (_o.ExitHookActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ExitHookActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ExitHookActions[j]);
				}
				exitHookActionsOffset = IChongLouHook.CreateExitHookActionsVector(builder, array2);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.FinishActions[k]);
				}
				finishActionsOffset = IChongLouHook.CreateFinishActionsVector(builder, array3);
			}
			Offset<IClientHookActionConfig> clientHookActionConfigOffset = (_o.ClientHookActionConfig == null) ? default(Offset<IClientHookActionConfig>) : IClientHookActionConfig.Pack(builder, _o.ClientHookActionConfig);
			return IChongLouHook.CreateIChongLouHook(builder, _o.Type, hookActionsOffset, exitHookActionsOffset, finishActionsOffset, clientHookActionConfigOffset, _o.HookMoveSpeed, _o.Acceleration, _o.LateralMoveSpeed, _o.LateralAccelerateTime, _o.LateralDecelerateTime, _o.MaxLateralOffset, _o.VerticalMoveSpeed, _o.VerticalAccelerateTime, _o.VerticalDecelerateTime, _o.NullMask);
		}

		// Token: 0x0400EA14 RID: 59924
		private Table __p;
	}
}
