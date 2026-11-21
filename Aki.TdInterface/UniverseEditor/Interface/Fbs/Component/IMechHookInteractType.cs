using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AD1 RID: 23249
	public struct IMechHookInteractType : IFlatbufferObject
	{
		// Token: 0x1700A985 RID: 43397
		// (get) Token: 0x0602625E RID: 156254 RVA: 0x0053A17F File Offset: 0x0053837F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602625F RID: 156255 RVA: 0x0053A18C File Offset: 0x0053838C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026260 RID: 156256 RVA: 0x0053A194 File Offset: 0x00538394
		public static IMechHookInteractType GetRootAsIMechHookInteractType(ByteBuffer _bb)
		{
			return IMechHookInteractType.GetRootAsIMechHookInteractType(_bb, default(IMechHookInteractType));
		}

		// Token: 0x06026261 RID: 156257 RVA: 0x0053A1B0 File Offset: 0x005383B0
		public static IMechHookInteractType GetRootAsIMechHookInteractType(ByteBuffer _bb, IMechHookInteractType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026262 RID: 156258 RVA: 0x0053A1CD File Offset: 0x005383CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026263 RID: 156259 RVA: 0x0053A1DC File Offset: 0x005383DC
		public IMechHookInteractType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A986 RID: 43398
		// (get) Token: 0x06026264 RID: 156260 RVA: 0x0053A1EC File Offset: 0x005383EC
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

		// Token: 0x06026265 RID: 156261 RVA: 0x0053A228 File Offset: 0x00538428
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A987 RID: 43399
		// (get) Token: 0x06026266 RID: 156262 RVA: 0x0053A288 File Offset: 0x00538488
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

		// Token: 0x06026267 RID: 156263 RVA: 0x0053A2B4 File Offset: 0x005384B4
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A988 RID: 43400
		// (get) Token: 0x06026268 RID: 156264 RVA: 0x0053A314 File Offset: 0x00538514
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

		// Token: 0x06026269 RID: 156265 RVA: 0x0053A340 File Offset: 0x00538540
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A989 RID: 43401
		// (get) Token: 0x0602626A RID: 156266 RVA: 0x0053A3A4 File Offset: 0x005385A4
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

		// Token: 0x1700A98A RID: 43402
		// (get) Token: 0x0602626B RID: 156267 RVA: 0x0053A3D0 File Offset: 0x005385D0
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

		// Token: 0x1700A98B RID: 43403
		// (get) Token: 0x0602626C RID: 156268 RVA: 0x0053A430 File Offset: 0x00538630
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

		// Token: 0x0602626D RID: 156269 RVA: 0x0053A46D File Offset: 0x0053866D
		public static Offset<IMechHookInteractType> CreateIMechHookInteractType(FlatBufferBuilder builder, EMechHookInteractType Type = EMechHookInteractType.FixedPointHook, VectorOffset HookActionsOffset = default(VectorOffset), VectorOffset ExitHookActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), Offset<IClientHookActionConfig> ClientHookActionConfigOffset = default(Offset<IClientHookActionConfig>), byte NullMask = 0)
		{
			builder.StartTable(6);
			IMechHookInteractType.AddClientHookActionConfig(builder, ClientHookActionConfigOffset);
			IMechHookInteractType.AddFinishActions(builder, FinishActionsOffset);
			IMechHookInteractType.AddExitHookActions(builder, ExitHookActionsOffset);
			IMechHookInteractType.AddHookActions(builder, HookActionsOffset);
			IMechHookInteractType.AddNullMask(builder, NullMask);
			IMechHookInteractType.AddType(builder, Type);
			return IMechHookInteractType.EndIMechHookInteractType(builder);
		}

		// Token: 0x0602626E RID: 156270 RVA: 0x0053A4A9 File Offset: 0x005386A9
		public static void StartIMechHookInteractType(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602626F RID: 156271 RVA: 0x0053A4B2 File Offset: 0x005386B2
		public static void AddType(FlatBufferBuilder builder, EMechHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026270 RID: 156272 RVA: 0x0053A4BD File Offset: 0x005386BD
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x06026271 RID: 156273 RVA: 0x0053A4D0 File Offset: 0x005386D0
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026272 RID: 156274 RVA: 0x0053A510 File Offset: 0x00538710
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026273 RID: 156275 RVA: 0x0053A52A File Offset: 0x0053872A
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026274 RID: 156276 RVA: 0x0053A548 File Offset: 0x00538748
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026275 RID: 156277 RVA: 0x0053A561 File Offset: 0x00538761
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026276 RID: 156278 RVA: 0x0053A56C File Offset: 0x0053876C
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x06026277 RID: 156279 RVA: 0x0053A57C File Offset: 0x0053877C
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026278 RID: 156280 RVA: 0x0053A5BC File Offset: 0x005387BC
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026279 RID: 156281 RVA: 0x0053A5D6 File Offset: 0x005387D6
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602627A RID: 156282 RVA: 0x0053A5F4 File Offset: 0x005387F4
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602627B RID: 156283 RVA: 0x0053A60D File Offset: 0x0053880D
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602627C RID: 156284 RVA: 0x0053A618 File Offset: 0x00538818
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x0602627D RID: 156285 RVA: 0x0053A628 File Offset: 0x00538828
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602627E RID: 156286 RVA: 0x0053A668 File Offset: 0x00538868
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602627F RID: 156287 RVA: 0x0053A682 File Offset: 0x00538882
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026280 RID: 156288 RVA: 0x0053A6A0 File Offset: 0x005388A0
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026281 RID: 156289 RVA: 0x0053A6B9 File Offset: 0x005388B9
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026282 RID: 156290 RVA: 0x0053A6C4 File Offset: 0x005388C4
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x06026283 RID: 156291 RVA: 0x0053A6D4 File Offset: 0x005388D4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06026284 RID: 156292 RVA: 0x0053A6DF File Offset: 0x005388DF
		public static Offset<IMechHookInteractType> EndIMechHookInteractType(FlatBufferBuilder builder)
		{
			return new Offset<IMechHookInteractType>(builder.EndTable());
		}

		// Token: 0x06026285 RID: 156293 RVA: 0x0053A6EC File Offset: 0x005388EC
		public IMechHookInteractTypeT UnPack()
		{
			IMechHookInteractTypeT mechHookInteractTypeT = new IMechHookInteractTypeT();
			this.UnPackTo(mechHookInteractTypeT);
			return mechHookInteractTypeT;
		}

		// Token: 0x06026286 RID: 156294 RVA: 0x0053A708 File Offset: 0x00538908
		public void UnPackTo(IMechHookInteractTypeT _o)
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

		// Token: 0x06026287 RID: 156295 RVA: 0x0053A85C File Offset: 0x00538A5C
		public static Offset<IMechHookInteractType> Pack(FlatBufferBuilder builder, IMechHookInteractTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechHookInteractType>);
			}
			VectorOffset hookActionsOffset = default(VectorOffset);
			if (_o.HookActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.HookActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.HookActions[i]);
				}
				hookActionsOffset = IMechHookInteractType.CreateHookActionsVector(builder, array);
			}
			VectorOffset exitHookActionsOffset = default(VectorOffset);
			if (_o.ExitHookActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ExitHookActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ExitHookActions[j]);
				}
				exitHookActionsOffset = IMechHookInteractType.CreateExitHookActionsVector(builder, array2);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.FinishActions[k]);
				}
				finishActionsOffset = IMechHookInteractType.CreateFinishActionsVector(builder, array3);
			}
			Offset<IClientHookActionConfig> clientHookActionConfigOffset = (_o.ClientHookActionConfig == null) ? default(Offset<IClientHookActionConfig>) : IClientHookActionConfig.Pack(builder, _o.ClientHookActionConfig);
			return IMechHookInteractType.CreateIMechHookInteractType(builder, _o.Type, hookActionsOffset, exitHookActionsOffset, finishActionsOffset, clientHookActionConfigOffset, _o.NullMask);
		}

		// Token: 0x0400F489 RID: 62601
		private Table __p;
	}
}
