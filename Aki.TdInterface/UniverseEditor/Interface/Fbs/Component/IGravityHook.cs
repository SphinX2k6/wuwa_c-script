using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058B0 RID: 22704
	public struct IGravityHook : IFlatbufferObject
	{
		// Token: 0x1700A48D RID: 42125
		// (get) Token: 0x06024D5E RID: 150878 RVA: 0x0050ED77 File Offset: 0x0050CF77
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024D5F RID: 150879 RVA: 0x0050ED84 File Offset: 0x0050CF84
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024D60 RID: 150880 RVA: 0x0050ED8C File Offset: 0x0050CF8C
		public static IGravityHook GetRootAsIGravityHook(ByteBuffer _bb)
		{
			return IGravityHook.GetRootAsIGravityHook(_bb, default(IGravityHook));
		}

		// Token: 0x06024D61 RID: 150881 RVA: 0x0050EDA8 File Offset: 0x0050CFA8
		public static IGravityHook GetRootAsIGravityHook(ByteBuffer _bb, IGravityHook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024D62 RID: 150882 RVA: 0x0050EDC5 File Offset: 0x0050CFC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024D63 RID: 150883 RVA: 0x0050EDD4 File Offset: 0x0050CFD4
		public IGravityHook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A48E RID: 42126
		// (get) Token: 0x06024D64 RID: 150884 RVA: 0x0050EDE4 File Offset: 0x0050CFE4
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

		// Token: 0x06024D65 RID: 150885 RVA: 0x0050EE20 File Offset: 0x0050D020
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A48F RID: 42127
		// (get) Token: 0x06024D66 RID: 150886 RVA: 0x0050EE80 File Offset: 0x0050D080
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

		// Token: 0x06024D67 RID: 150887 RVA: 0x0050EEAC File Offset: 0x0050D0AC
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A490 RID: 42128
		// (get) Token: 0x06024D68 RID: 150888 RVA: 0x0050EF0C File Offset: 0x0050D10C
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

		// Token: 0x06024D69 RID: 150889 RVA: 0x0050EF38 File Offset: 0x0050D138
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A491 RID: 42129
		// (get) Token: 0x06024D6A RID: 150890 RVA: 0x0050EF9C File Offset: 0x0050D19C
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

		// Token: 0x1700A492 RID: 42130
		// (get) Token: 0x06024D6B RID: 150891 RVA: 0x0050EFC8 File Offset: 0x0050D1C8
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

		// Token: 0x1700A493 RID: 42131
		// (get) Token: 0x06024D6C RID: 150892 RVA: 0x0050F028 File Offset: 0x0050D228
		public TGravityDirection GravityDirectionType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return TGravityDirection.NONE;
				}
				return (TGravityDirection)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024D6D RID: 150893 RVA: 0x0050F068 File Offset: 0x0050D268
		public TTable? GravityDirection<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06024D6E RID: 150894 RVA: 0x0050F0B0 File Offset: 0x0050D2B0
		public IGravityDirectionByEntityGravity GravityDirectionAsIGravityDirectionByEntityGravity()
		{
			return this.GravityDirection<IGravityDirectionByEntityGravity>().Value;
		}

		// Token: 0x06024D6F RID: 150895 RVA: 0x0050F0CC File Offset: 0x0050D2CC
		public IGravityDirectionSelfRotation GravityDirectionAsIGravityDirectionSelfRotation()
		{
			return this.GravityDirection<IGravityDirectionSelfRotation>().Value;
		}

		// Token: 0x06024D70 RID: 150896 RVA: 0x0050F0E8 File Offset: 0x0050D2E8
		public IGravityDirectionVectorInfo GravityDirectionAsIGravityDirectionVectorInfo()
		{
			return this.GravityDirection<IGravityDirectionVectorInfo>().Value;
		}

		// Token: 0x06024D71 RID: 150897 RVA: 0x0050F104 File Offset: 0x0050D304
		public IGravityDirectionWorldAxis GravityDirectionAsIGravityDirectionWorldAxis()
		{
			return this.GravityDirection<IGravityDirectionWorldAxis>().Value;
		}

		// Token: 0x1700A494 RID: 42132
		// (get) Token: 0x06024D72 RID: 150898 RVA: 0x0050F120 File Offset: 0x0050D320
		public int SafePointId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A495 RID: 42133
		// (get) Token: 0x06024D73 RID: 150899 RVA: 0x0050F160 File Offset: 0x0050D360
		public int CameraLookAtPointId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A496 RID: 42134
		// (get) Token: 0x06024D74 RID: 150900 RVA: 0x0050F1A0 File Offset: 0x0050D3A0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024D75 RID: 150901 RVA: 0x0050F1E0 File Offset: 0x0050D3E0
		public static Offset<IGravityHook> CreateIGravityHook(FlatBufferBuilder builder, EHookInteractType Type = EHookInteractType.FixedPointHook, VectorOffset HookActionsOffset = default(VectorOffset), VectorOffset ExitHookActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), Offset<IClientHookActionConfig> ClientHookActionConfigOffset = default(Offset<IClientHookActionConfig>), TGravityDirection GravityDirection_type = TGravityDirection.NONE, int GravityDirectionOffset = 0, int SafePointId = 0, int CameraLookAtPointId = 0, byte NullMask = 0)
		{
			builder.StartTable(10);
			IGravityHook.AddCameraLookAtPointId(builder, CameraLookAtPointId);
			IGravityHook.AddSafePointId(builder, SafePointId);
			IGravityHook.AddGravityDirection(builder, GravityDirectionOffset);
			IGravityHook.AddClientHookActionConfig(builder, ClientHookActionConfigOffset);
			IGravityHook.AddFinishActions(builder, FinishActionsOffset);
			IGravityHook.AddExitHookActions(builder, ExitHookActionsOffset);
			IGravityHook.AddHookActions(builder, HookActionsOffset);
			IGravityHook.AddNullMask(builder, NullMask);
			IGravityHook.AddGravityDirectionType(builder, GravityDirection_type);
			IGravityHook.AddType(builder, Type);
			return IGravityHook.EndIGravityHook(builder);
		}

		// Token: 0x06024D76 RID: 150902 RVA: 0x0050F248 File Offset: 0x0050D448
		public static void StartIGravityHook(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x06024D77 RID: 150903 RVA: 0x0050F252 File Offset: 0x0050D452
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024D78 RID: 150904 RVA: 0x0050F25D File Offset: 0x0050D45D
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x06024D79 RID: 150905 RVA: 0x0050F270 File Offset: 0x0050D470
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024D7A RID: 150906 RVA: 0x0050F2B0 File Offset: 0x0050D4B0
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024D7B RID: 150907 RVA: 0x0050F2CA File Offset: 0x0050D4CA
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024D7C RID: 150908 RVA: 0x0050F2E8 File Offset: 0x0050D4E8
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024D7D RID: 150909 RVA: 0x0050F301 File Offset: 0x0050D501
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024D7E RID: 150910 RVA: 0x0050F30C File Offset: 0x0050D50C
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x06024D7F RID: 150911 RVA: 0x0050F31C File Offset: 0x0050D51C
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024D80 RID: 150912 RVA: 0x0050F35C File Offset: 0x0050D55C
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024D81 RID: 150913 RVA: 0x0050F376 File Offset: 0x0050D576
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024D82 RID: 150914 RVA: 0x0050F394 File Offset: 0x0050D594
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024D83 RID: 150915 RVA: 0x0050F3AD File Offset: 0x0050D5AD
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024D84 RID: 150916 RVA: 0x0050F3B8 File Offset: 0x0050D5B8
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x06024D85 RID: 150917 RVA: 0x0050F3C8 File Offset: 0x0050D5C8
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024D86 RID: 150918 RVA: 0x0050F408 File Offset: 0x0050D608
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024D87 RID: 150919 RVA: 0x0050F422 File Offset: 0x0050D622
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024D88 RID: 150920 RVA: 0x0050F440 File Offset: 0x0050D640
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024D89 RID: 150921 RVA: 0x0050F459 File Offset: 0x0050D659
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024D8A RID: 150922 RVA: 0x0050F464 File Offset: 0x0050D664
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x06024D8B RID: 150923 RVA: 0x0050F474 File Offset: 0x0050D674
		public static void AddGravityDirectionType(FlatBufferBuilder builder, TGravityDirection gravityDirectionType)
		{
			builder.AddByte(5, (byte)gravityDirectionType, 0);
		}

		// Token: 0x06024D8C RID: 150924 RVA: 0x0050F47F File Offset: 0x0050D67F
		public static void AddGravityDirection(FlatBufferBuilder builder, int gravityDirectionOffset)
		{
			builder.AddOffset(6, gravityDirectionOffset, 0);
		}

		// Token: 0x06024D8D RID: 150925 RVA: 0x0050F48A File Offset: 0x0050D68A
		public static void AddSafePointId(FlatBufferBuilder builder, int safePointId)
		{
			builder.AddInt(7, safePointId, 0);
		}

		// Token: 0x06024D8E RID: 150926 RVA: 0x0050F495 File Offset: 0x0050D695
		public static void AddCameraLookAtPointId(FlatBufferBuilder builder, int cameraLookAtPointId)
		{
			builder.AddInt(8, cameraLookAtPointId, 0);
		}

		// Token: 0x06024D8F RID: 150927 RVA: 0x0050F4A0 File Offset: 0x0050D6A0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x06024D90 RID: 150928 RVA: 0x0050F4AC File Offset: 0x0050D6AC
		public static Offset<IGravityHook> EndIGravityHook(FlatBufferBuilder builder)
		{
			return new Offset<IGravityHook>(builder.EndTable());
		}

		// Token: 0x06024D91 RID: 150929 RVA: 0x0050F4BC File Offset: 0x0050D6BC
		public IGravityHookT UnPack()
		{
			IGravityHookT gravityHookT = new IGravityHookT();
			this.UnPackTo(gravityHookT);
			return gravityHookT;
		}

		// Token: 0x06024D92 RID: 150930 RVA: 0x0050F4D8 File Offset: 0x0050D6D8
		public void UnPackTo(IGravityHookT _o)
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
			_o.GravityDirection = new TGravityDirectionUnion();
			_o.GravityDirection.Type = this.GravityDirectionType;
			switch (this.GravityDirectionType)
			{
			case TGravityDirection.IGravityDirectionByEntityGravity:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionByEntityGravity>() != null) ? this.GravityDirection<IGravityDirectionByEntityGravity>().Value.UnPack() : null);
				break;
			case TGravityDirection.IGravityDirectionSelfRotation:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionSelfRotation>() != null) ? this.GravityDirection<IGravityDirectionSelfRotation>().Value.UnPack() : null);
				break;
			case TGravityDirection.IGravityDirectionVectorInfo:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionVectorInfo>() != null) ? this.GravityDirection<IGravityDirectionVectorInfo>().Value.UnPack() : null);
				break;
			case TGravityDirection.IGravityDirectionWorldAxis:
				_o.GravityDirection.Value = ((this.GravityDirection<IGravityDirectionWorldAxis>() != null) ? this.GravityDirection<IGravityDirectionWorldAxis>().Value.UnPack() : null);
				break;
			}
			_o.SafePointId = this.SafePointId;
			_o.CameraLookAtPointId = this.CameraLookAtPointId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06024D93 RID: 150931 RVA: 0x0050F76C File Offset: 0x0050D96C
		public static Offset<IGravityHook> Pack(FlatBufferBuilder builder, IGravityHookT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGravityHook>);
			}
			VectorOffset hookActionsOffset = default(VectorOffset);
			if (_o.HookActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.HookActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.HookActions[i]);
				}
				hookActionsOffset = IGravityHook.CreateHookActionsVector(builder, array);
			}
			VectorOffset exitHookActionsOffset = default(VectorOffset);
			if (_o.ExitHookActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ExitHookActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ExitHookActions[j]);
				}
				exitHookActionsOffset = IGravityHook.CreateExitHookActionsVector(builder, array2);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.FinishActions[k]);
				}
				finishActionsOffset = IGravityHook.CreateFinishActionsVector(builder, array3);
			}
			Offset<IClientHookActionConfig> clientHookActionConfigOffset = (_o.ClientHookActionConfig == null) ? default(Offset<IClientHookActionConfig>) : IClientHookActionConfig.Pack(builder, _o.ClientHookActionConfig);
			TGravityDirection gravityDirection_type = (_o.GravityDirection == null) ? TGravityDirection.NONE : _o.GravityDirection.Type;
			int gravityDirectionOffset = (_o.GravityDirection == null) ? 0 : TGravityDirectionUnion.Pack(builder, _o.GravityDirection);
			return IGravityHook.CreateIGravityHook(builder, _o.Type, hookActionsOffset, exitHookActionsOffset, finishActionsOffset, clientHookActionConfigOffset, gravityDirection_type, gravityDirectionOffset, _o.SafePointId, _o.CameraLookAtPointId, _o.NullMask);
		}

		// Token: 0x0400F116 RID: 61718
		private Table __p;
	}
}
