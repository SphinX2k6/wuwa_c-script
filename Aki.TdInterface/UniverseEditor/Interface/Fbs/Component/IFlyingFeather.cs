using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005288 RID: 21128
	public struct IFlyingFeather : IFlatbufferObject
	{
		// Token: 0x17009AE0 RID: 39648
		// (get) Token: 0x060226A1 RID: 140961 RVA: 0x004C5442 File Offset: 0x004C3642
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060226A2 RID: 140962 RVA: 0x004C544F File Offset: 0x004C364F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060226A3 RID: 140963 RVA: 0x004C5458 File Offset: 0x004C3658
		public static IFlyingFeather GetRootAsIFlyingFeather(ByteBuffer _bb)
		{
			return IFlyingFeather.GetRootAsIFlyingFeather(_bb, default(IFlyingFeather));
		}

		// Token: 0x060226A4 RID: 140964 RVA: 0x004C5474 File Offset: 0x004C3674
		public static IFlyingFeather GetRootAsIFlyingFeather(ByteBuffer _bb, IFlyingFeather obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060226A5 RID: 140965 RVA: 0x004C5491 File Offset: 0x004C3691
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060226A6 RID: 140966 RVA: 0x004C54A0 File Offset: 0x004C36A0
		public IFlyingFeather __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009AE1 RID: 39649
		// (get) Token: 0x060226A7 RID: 140967 RVA: 0x004C54B0 File Offset: 0x004C36B0
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

		// Token: 0x060226A8 RID: 140968 RVA: 0x004C54EC File Offset: 0x004C36EC
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009AE2 RID: 39650
		// (get) Token: 0x060226A9 RID: 140969 RVA: 0x004C554C File Offset: 0x004C374C
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

		// Token: 0x060226AA RID: 140970 RVA: 0x004C5578 File Offset: 0x004C3778
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009AE3 RID: 39651
		// (get) Token: 0x060226AB RID: 140971 RVA: 0x004C55D8 File Offset: 0x004C37D8
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

		// Token: 0x060226AC RID: 140972 RVA: 0x004C5604 File Offset: 0x004C3804
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009AE4 RID: 39652
		// (get) Token: 0x060226AD RID: 140973 RVA: 0x004C5668 File Offset: 0x004C3868
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

		// Token: 0x17009AE5 RID: 39653
		// (get) Token: 0x060226AE RID: 140974 RVA: 0x004C5694 File Offset: 0x004C3894
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

		// Token: 0x17009AE6 RID: 39654
		// (get) Token: 0x060226AF RID: 140975 RVA: 0x004C56F4 File Offset: 0x004C38F4
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009AE7 RID: 39655
		// (get) Token: 0x060226B0 RID: 140976 RVA: 0x004C5734 File Offset: 0x004C3934
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

		// Token: 0x060226B1 RID: 140977 RVA: 0x004C5774 File Offset: 0x004C3974
		public static Offset<IFlyingFeather> CreateIFlyingFeather(FlatBufferBuilder builder, EHookInteractType Type = EHookInteractType.FixedPointHook, VectorOffset HookActionsOffset = default(VectorOffset), VectorOffset ExitHookActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), Offset<IClientHookActionConfig> ClientHookActionConfigOffset = default(Offset<IClientHookActionConfig>), int EntityId = 0, byte NullMask = 0)
		{
			builder.StartTable(7);
			IFlyingFeather.AddEntityId(builder, EntityId);
			IFlyingFeather.AddClientHookActionConfig(builder, ClientHookActionConfigOffset);
			IFlyingFeather.AddFinishActions(builder, FinishActionsOffset);
			IFlyingFeather.AddExitHookActions(builder, ExitHookActionsOffset);
			IFlyingFeather.AddHookActions(builder, HookActionsOffset);
			IFlyingFeather.AddNullMask(builder, NullMask);
			IFlyingFeather.AddType(builder, Type);
			return IFlyingFeather.EndIFlyingFeather(builder);
		}

		// Token: 0x060226B2 RID: 140978 RVA: 0x004C57C3 File Offset: 0x004C39C3
		public static void StartIFlyingFeather(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x060226B3 RID: 140979 RVA: 0x004C57CC File Offset: 0x004C39CC
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060226B4 RID: 140980 RVA: 0x004C57D7 File Offset: 0x004C39D7
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x060226B5 RID: 140981 RVA: 0x004C57E8 File Offset: 0x004C39E8
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060226B6 RID: 140982 RVA: 0x004C5828 File Offset: 0x004C3A28
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060226B7 RID: 140983 RVA: 0x004C5842 File Offset: 0x004C3A42
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060226B8 RID: 140984 RVA: 0x004C5860 File Offset: 0x004C3A60
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060226B9 RID: 140985 RVA: 0x004C5879 File Offset: 0x004C3A79
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060226BA RID: 140986 RVA: 0x004C5884 File Offset: 0x004C3A84
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x060226BB RID: 140987 RVA: 0x004C5894 File Offset: 0x004C3A94
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060226BC RID: 140988 RVA: 0x004C58D4 File Offset: 0x004C3AD4
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060226BD RID: 140989 RVA: 0x004C58EE File Offset: 0x004C3AEE
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060226BE RID: 140990 RVA: 0x004C590C File Offset: 0x004C3B0C
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060226BF RID: 140991 RVA: 0x004C5925 File Offset: 0x004C3B25
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060226C0 RID: 140992 RVA: 0x004C5930 File Offset: 0x004C3B30
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x060226C1 RID: 140993 RVA: 0x004C5940 File Offset: 0x004C3B40
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060226C2 RID: 140994 RVA: 0x004C5980 File Offset: 0x004C3B80
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060226C3 RID: 140995 RVA: 0x004C599A File Offset: 0x004C3B9A
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060226C4 RID: 140996 RVA: 0x004C59B8 File Offset: 0x004C3BB8
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060226C5 RID: 140997 RVA: 0x004C59D1 File Offset: 0x004C3BD1
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060226C6 RID: 140998 RVA: 0x004C59DC File Offset: 0x004C3BDC
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x060226C7 RID: 140999 RVA: 0x004C59EC File Offset: 0x004C3BEC
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(5, entityId, 0);
		}

		// Token: 0x060226C8 RID: 141000 RVA: 0x004C59F7 File Offset: 0x004C3BF7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x060226C9 RID: 141001 RVA: 0x004C5A02 File Offset: 0x004C3C02
		public static Offset<IFlyingFeather> EndIFlyingFeather(FlatBufferBuilder builder)
		{
			return new Offset<IFlyingFeather>(builder.EndTable());
		}

		// Token: 0x060226CA RID: 141002 RVA: 0x004C5A10 File Offset: 0x004C3C10
		public IFlyingFeatherT UnPack()
		{
			IFlyingFeatherT flyingFeatherT = new IFlyingFeatherT();
			this.UnPackTo(flyingFeatherT);
			return flyingFeatherT;
		}

		// Token: 0x060226CB RID: 141003 RVA: 0x004C5A2C File Offset: 0x004C3C2C
		public void UnPackTo(IFlyingFeatherT _o)
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
			_o.EntityId = this.EntityId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060226CC RID: 141004 RVA: 0x004C5B8C File Offset: 0x004C3D8C
		public static Offset<IFlyingFeather> Pack(FlatBufferBuilder builder, IFlyingFeatherT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlyingFeather>);
			}
			VectorOffset hookActionsOffset = default(VectorOffset);
			if (_o.HookActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.HookActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.HookActions[i]);
				}
				hookActionsOffset = IFlyingFeather.CreateHookActionsVector(builder, array);
			}
			VectorOffset exitHookActionsOffset = default(VectorOffset);
			if (_o.ExitHookActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ExitHookActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ExitHookActions[j]);
				}
				exitHookActionsOffset = IFlyingFeather.CreateExitHookActionsVector(builder, array2);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.FinishActions[k]);
				}
				finishActionsOffset = IFlyingFeather.CreateFinishActionsVector(builder, array3);
			}
			Offset<IClientHookActionConfig> clientHookActionConfigOffset = (_o.ClientHookActionConfig == null) ? default(Offset<IClientHookActionConfig>) : IClientHookActionConfig.Pack(builder, _o.ClientHookActionConfig);
			return IFlyingFeather.CreateIFlyingFeather(builder, _o.Type, hookActionsOffset, exitHookActionsOffset, finishActionsOffset, clientHookActionConfigOffset, _o.EntityId, _o.NullMask);
		}

		// Token: 0x0400E3EE RID: 58350
		private Table __p;
	}
}
