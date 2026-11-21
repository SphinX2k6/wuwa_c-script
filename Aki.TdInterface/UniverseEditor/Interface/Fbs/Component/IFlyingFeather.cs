using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057F0 RID: 22512
	public struct IFlyingFeather : IFlatbufferObject
	{
		// Token: 0x1700A2DE RID: 41694
		// (get) Token: 0x0602463B RID: 149051 RVA: 0x004FFFB2 File Offset: 0x004FE1B2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602463C RID: 149052 RVA: 0x004FFFBF File Offset: 0x004FE1BF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602463D RID: 149053 RVA: 0x004FFFC8 File Offset: 0x004FE1C8
		public static IFlyingFeather GetRootAsIFlyingFeather(ByteBuffer _bb)
		{
			return IFlyingFeather.GetRootAsIFlyingFeather(_bb, default(IFlyingFeather));
		}

		// Token: 0x0602463E RID: 149054 RVA: 0x004FFFE4 File Offset: 0x004FE1E4
		public static IFlyingFeather GetRootAsIFlyingFeather(ByteBuffer _bb, IFlyingFeather obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602463F RID: 149055 RVA: 0x00500001 File Offset: 0x004FE201
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024640 RID: 149056 RVA: 0x00500010 File Offset: 0x004FE210
		public IFlyingFeather __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A2DF RID: 41695
		// (get) Token: 0x06024641 RID: 149057 RVA: 0x00500020 File Offset: 0x004FE220
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

		// Token: 0x06024642 RID: 149058 RVA: 0x0050005C File Offset: 0x004FE25C
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A2E0 RID: 41696
		// (get) Token: 0x06024643 RID: 149059 RVA: 0x005000BC File Offset: 0x004FE2BC
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

		// Token: 0x06024644 RID: 149060 RVA: 0x005000E8 File Offset: 0x004FE2E8
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A2E1 RID: 41697
		// (get) Token: 0x06024645 RID: 149061 RVA: 0x00500148 File Offset: 0x004FE348
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

		// Token: 0x06024646 RID: 149062 RVA: 0x00500174 File Offset: 0x004FE374
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A2E2 RID: 41698
		// (get) Token: 0x06024647 RID: 149063 RVA: 0x005001D8 File Offset: 0x004FE3D8
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

		// Token: 0x1700A2E3 RID: 41699
		// (get) Token: 0x06024648 RID: 149064 RVA: 0x00500204 File Offset: 0x004FE404
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

		// Token: 0x1700A2E4 RID: 41700
		// (get) Token: 0x06024649 RID: 149065 RVA: 0x00500264 File Offset: 0x004FE464
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

		// Token: 0x1700A2E5 RID: 41701
		// (get) Token: 0x0602464A RID: 149066 RVA: 0x005002A4 File Offset: 0x004FE4A4
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

		// Token: 0x0602464B RID: 149067 RVA: 0x005002E4 File Offset: 0x004FE4E4
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

		// Token: 0x0602464C RID: 149068 RVA: 0x00500333 File Offset: 0x004FE533
		public static void StartIFlyingFeather(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602464D RID: 149069 RVA: 0x0050033C File Offset: 0x004FE53C
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602464E RID: 149070 RVA: 0x00500347 File Offset: 0x004FE547
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x0602464F RID: 149071 RVA: 0x00500358 File Offset: 0x004FE558
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024650 RID: 149072 RVA: 0x00500398 File Offset: 0x004FE598
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024651 RID: 149073 RVA: 0x005003B2 File Offset: 0x004FE5B2
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024652 RID: 149074 RVA: 0x005003D0 File Offset: 0x004FE5D0
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024653 RID: 149075 RVA: 0x005003E9 File Offset: 0x004FE5E9
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024654 RID: 149076 RVA: 0x005003F4 File Offset: 0x004FE5F4
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x06024655 RID: 149077 RVA: 0x00500404 File Offset: 0x004FE604
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024656 RID: 149078 RVA: 0x00500444 File Offset: 0x004FE644
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024657 RID: 149079 RVA: 0x0050045E File Offset: 0x004FE65E
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024658 RID: 149080 RVA: 0x0050047C File Offset: 0x004FE67C
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024659 RID: 149081 RVA: 0x00500495 File Offset: 0x004FE695
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602465A RID: 149082 RVA: 0x005004A0 File Offset: 0x004FE6A0
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x0602465B RID: 149083 RVA: 0x005004B0 File Offset: 0x004FE6B0
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602465C RID: 149084 RVA: 0x005004F0 File Offset: 0x004FE6F0
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602465D RID: 149085 RVA: 0x0050050A File Offset: 0x004FE70A
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602465E RID: 149086 RVA: 0x00500528 File Offset: 0x004FE728
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602465F RID: 149087 RVA: 0x00500541 File Offset: 0x004FE741
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024660 RID: 149088 RVA: 0x0050054C File Offset: 0x004FE74C
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x06024661 RID: 149089 RVA: 0x0050055C File Offset: 0x004FE75C
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(5, entityId, 0);
		}

		// Token: 0x06024662 RID: 149090 RVA: 0x00500567 File Offset: 0x004FE767
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06024663 RID: 149091 RVA: 0x00500572 File Offset: 0x004FE772
		public static Offset<IFlyingFeather> EndIFlyingFeather(FlatBufferBuilder builder)
		{
			return new Offset<IFlyingFeather>(builder.EndTable());
		}

		// Token: 0x06024664 RID: 149092 RVA: 0x00500580 File Offset: 0x004FE780
		public IFlyingFeatherT UnPack()
		{
			IFlyingFeatherT flyingFeatherT = new IFlyingFeatherT();
			this.UnPackTo(flyingFeatherT);
			return flyingFeatherT;
		}

		// Token: 0x06024665 RID: 149093 RVA: 0x0050059C File Offset: 0x004FE79C
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

		// Token: 0x06024666 RID: 149094 RVA: 0x005006FC File Offset: 0x004FE8FC
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

		// Token: 0x0400EFF5 RID: 61429
		private Table __p;
	}
}
