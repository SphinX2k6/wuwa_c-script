using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004538 RID: 17720
	public struct ISaveConfig : IFlatbufferObject
	{
		// Token: 0x17007B38 RID: 31544
		// (get) Token: 0x06019A6C RID: 105068 RVA: 0x003A7234 File Offset: 0x003A5434
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019A6D RID: 105069 RVA: 0x003A7241 File Offset: 0x003A5441
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019A6E RID: 105070 RVA: 0x003A7248 File Offset: 0x003A5448
		public static ISaveConfig GetRootAsISaveConfig(ByteBuffer _bb)
		{
			return ISaveConfig.GetRootAsISaveConfig(_bb, default(ISaveConfig));
		}

		// Token: 0x06019A6F RID: 105071 RVA: 0x003A7264 File Offset: 0x003A5464
		public static ISaveConfig GetRootAsISaveConfig(ByteBuffer _bb, ISaveConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019A70 RID: 105072 RVA: 0x003A7281 File Offset: 0x003A5481
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019A71 RID: 105073 RVA: 0x003A7290 File Offset: 0x003A5490
		public ISaveConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007B39 RID: 31545
		// (get) Token: 0x06019A72 RID: 105074 RVA: 0x003A72A0 File Offset: 0x003A54A0
		public bool IsTemp
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007B3A RID: 31546
		// (get) Token: 0x06019A73 RID: 105075 RVA: 0x003A72E0 File Offset: 0x003A54E0
		public bool EnableRollbackWhileSwitchOnlineMode
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007B3B RID: 31547
		// (get) Token: 0x06019A74 RID: 105076 RVA: 0x003A7320 File Offset: 0x003A5520
		public bool DisableRollbackWhileReconnect
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007B3C RID: 31548
		// (get) Token: 0x06019A75 RID: 105077 RVA: 0x003A7360 File Offset: 0x003A5560
		public IPosRollbackConfig? PosRollbackCfg
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IPosRollbackConfig?(default(IPosRollbackConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06019A76 RID: 105078 RVA: 0x003A73C0 File Offset: 0x003A55C0
		public IActionInfo? EnterActions(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007B3D RID: 31549
		// (get) Token: 0x06019A77 RID: 105079 RVA: 0x003A7424 File Offset: 0x003A5624
		public int EnterActionsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06019A78 RID: 105080 RVA: 0x003A7450 File Offset: 0x003A5650
		public IInitConditionActions? InitConditionActions(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IInitConditionActions?(default(IInitConditionActions).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007B3E RID: 31550
		// (get) Token: 0x06019A79 RID: 105081 RVA: 0x003A74B4 File Offset: 0x003A56B4
		public int InitConditionActionsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17007B3F RID: 31551
		// (get) Token: 0x06019A7A RID: 105082 RVA: 0x003A74E0 File Offset: 0x003A56E0
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

		// Token: 0x06019A7B RID: 105083 RVA: 0x003A7520 File Offset: 0x003A5720
		public static Offset<ISaveConfig> CreateISaveConfig(FlatBufferBuilder builder, bool IsTemp = false, bool EnableRollbackWhileSwitchOnlineMode = false, bool DisableRollbackWhileReconnect = false, Offset<IPosRollbackConfig> PosRollbackCfgOffset = default(Offset<IPosRollbackConfig>), VectorOffset EnterActionsOffset = default(VectorOffset), VectorOffset InitConditionActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(7);
			ISaveConfig.AddInitConditionActions(builder, InitConditionActionsOffset);
			ISaveConfig.AddEnterActions(builder, EnterActionsOffset);
			ISaveConfig.AddPosRollbackCfg(builder, PosRollbackCfgOffset);
			ISaveConfig.AddNullMask(builder, NullMask);
			ISaveConfig.AddDisableRollbackWhileReconnect(builder, DisableRollbackWhileReconnect);
			ISaveConfig.AddEnableRollbackWhileSwitchOnlineMode(builder, EnableRollbackWhileSwitchOnlineMode);
			ISaveConfig.AddIsTemp(builder, IsTemp);
			return ISaveConfig.EndISaveConfig(builder);
		}

		// Token: 0x06019A7C RID: 105084 RVA: 0x003A756F File Offset: 0x003A576F
		public static void StartISaveConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06019A7D RID: 105085 RVA: 0x003A7578 File Offset: 0x003A5778
		public static void AddIsTemp(FlatBufferBuilder builder, bool isTemp)
		{
			builder.AddBool(0, isTemp, false);
		}

		// Token: 0x06019A7E RID: 105086 RVA: 0x003A7583 File Offset: 0x003A5783
		public static void AddEnableRollbackWhileSwitchOnlineMode(FlatBufferBuilder builder, bool enableRollbackWhileSwitchOnlineMode)
		{
			builder.AddBool(1, enableRollbackWhileSwitchOnlineMode, false);
		}

		// Token: 0x06019A7F RID: 105087 RVA: 0x003A758E File Offset: 0x003A578E
		public static void AddDisableRollbackWhileReconnect(FlatBufferBuilder builder, bool disableRollbackWhileReconnect)
		{
			builder.AddBool(2, disableRollbackWhileReconnect, false);
		}

		// Token: 0x06019A80 RID: 105088 RVA: 0x003A7599 File Offset: 0x003A5799
		public static void AddPosRollbackCfg(FlatBufferBuilder builder, Offset<IPosRollbackConfig> posRollbackCfgOffset)
		{
			builder.AddOffset(3, posRollbackCfgOffset.Value, 0);
		}

		// Token: 0x06019A81 RID: 105089 RVA: 0x003A75A9 File Offset: 0x003A57A9
		public static void AddEnterActions(FlatBufferBuilder builder, VectorOffset enterActionsOffset)
		{
			builder.AddOffset(4, enterActionsOffset.Value, 0);
		}

		// Token: 0x06019A82 RID: 105090 RVA: 0x003A75BC File Offset: 0x003A57BC
		public static VectorOffset CreateEnterActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06019A83 RID: 105091 RVA: 0x003A75FC File Offset: 0x003A57FC
		public static VectorOffset CreateEnterActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019A84 RID: 105092 RVA: 0x003A7616 File Offset: 0x003A5816
		public static VectorOffset CreateEnterActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019A85 RID: 105093 RVA: 0x003A7634 File Offset: 0x003A5834
		public static VectorOffset CreateEnterActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019A86 RID: 105094 RVA: 0x003A764D File Offset: 0x003A584D
		public static void StartEnterActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019A87 RID: 105095 RVA: 0x003A7658 File Offset: 0x003A5858
		public static void AddInitConditionActions(FlatBufferBuilder builder, VectorOffset initConditionActionsOffset)
		{
			builder.AddOffset(5, initConditionActionsOffset.Value, 0);
		}

		// Token: 0x06019A88 RID: 105096 RVA: 0x003A7668 File Offset: 0x003A5868
		public static VectorOffset CreateInitConditionActionsVector(FlatBufferBuilder builder, Offset<IInitConditionActions>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06019A89 RID: 105097 RVA: 0x003A76A8 File Offset: 0x003A58A8
		public static VectorOffset CreateInitConditionActionsVectorBlock(FlatBufferBuilder builder, Offset<IInitConditionActions>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IInitConditionActions>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019A8A RID: 105098 RVA: 0x003A76C2 File Offset: 0x003A58C2
		public static VectorOffset CreateInitConditionActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IInitConditionActions>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IInitConditionActions>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019A8B RID: 105099 RVA: 0x003A76E0 File Offset: 0x003A58E0
		public static VectorOffset CreateInitConditionActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IInitConditionActions>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019A8C RID: 105100 RVA: 0x003A76F9 File Offset: 0x003A58F9
		public static void StartInitConditionActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019A8D RID: 105101 RVA: 0x003A7704 File Offset: 0x003A5904
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06019A8E RID: 105102 RVA: 0x003A770F File Offset: 0x003A590F
		public static Offset<ISaveConfig> EndISaveConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISaveConfig>(builder.EndTable());
		}

		// Token: 0x06019A8F RID: 105103 RVA: 0x003A771C File Offset: 0x003A591C
		public ISaveConfigT UnPack()
		{
			ISaveConfigT saveConfigT = new ISaveConfigT();
			this.UnPackTo(saveConfigT);
			return saveConfigT;
		}

		// Token: 0x06019A90 RID: 105104 RVA: 0x003A7738 File Offset: 0x003A5938
		public void UnPackTo(ISaveConfigT _o)
		{
			_o.IsTemp = this.IsTemp;
			_o.EnableRollbackWhileSwitchOnlineMode = this.EnableRollbackWhileSwitchOnlineMode;
			_o.DisableRollbackWhileReconnect = this.DisableRollbackWhileReconnect;
			_o.PosRollbackCfg = ((this.PosRollbackCfg != null) ? this.PosRollbackCfg.Value.UnPack() : null);
			_o.EnterActions = new List<IActionInfoT>();
			for (int i = 0; i < this.EnterActionsLength; i++)
			{
				_o.EnterActions.Add((this.EnterActions(i) != null) ? this.EnterActions(i).Value.UnPack() : null);
			}
			_o.InitConditionActions = new List<IInitConditionActionsT>();
			for (int j = 0; j < this.InitConditionActionsLength; j++)
			{
				_o.InitConditionActions.Add((this.InitConditionActions(j) != null) ? this.InitConditionActions(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06019A91 RID: 105105 RVA: 0x003A7854 File Offset: 0x003A5A54
		public static Offset<ISaveConfig> Pack(FlatBufferBuilder builder, ISaveConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISaveConfig>);
			}
			Offset<IPosRollbackConfig> posRollbackCfgOffset = (_o.PosRollbackCfg == null) ? default(Offset<IPosRollbackConfig>) : IPosRollbackConfig.Pack(builder, _o.PosRollbackCfg);
			VectorOffset enterActionsOffset = default(VectorOffset);
			if (_o.EnterActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.EnterActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.EnterActions[i]);
				}
				enterActionsOffset = ISaveConfig.CreateEnterActionsVector(builder, array);
			}
			VectorOffset initConditionActionsOffset = default(VectorOffset);
			if (_o.InitConditionActions != null)
			{
				Offset<IInitConditionActions>[] array2 = new Offset<IInitConditionActions>[_o.InitConditionActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IInitConditionActions.Pack(builder, _o.InitConditionActions[j]);
				}
				initConditionActionsOffset = ISaveConfig.CreateInitConditionActionsVector(builder, array2);
			}
			return ISaveConfig.CreateISaveConfig(builder, _o.IsTemp, _o.EnableRollbackWhileSwitchOnlineMode, _o.DisableRollbackWhileReconnect, posRollbackCfgOffset, enterActionsOffset, initConditionActionsOffset, _o.NullMask);
		}

		// Token: 0x0400C67A RID: 50810
		private Table __p;
	}
}
