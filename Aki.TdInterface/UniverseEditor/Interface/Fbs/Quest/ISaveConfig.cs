using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040F7 RID: 16631
	public struct ISaveConfig : IFlatbufferObject
	{
		// Token: 0x17007532 RID: 30002
		// (get) Token: 0x060183CB RID: 99275 RVA: 0x0037D2E4 File Offset: 0x0037B4E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060183CC RID: 99276 RVA: 0x0037D2F1 File Offset: 0x0037B4F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060183CD RID: 99277 RVA: 0x0037D2F8 File Offset: 0x0037B4F8
		public static ISaveConfig GetRootAsISaveConfig(ByteBuffer _bb)
		{
			return ISaveConfig.GetRootAsISaveConfig(_bb, default(ISaveConfig));
		}

		// Token: 0x060183CE RID: 99278 RVA: 0x0037D314 File Offset: 0x0037B514
		public static ISaveConfig GetRootAsISaveConfig(ByteBuffer _bb, ISaveConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060183CF RID: 99279 RVA: 0x0037D331 File Offset: 0x0037B531
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060183D0 RID: 99280 RVA: 0x0037D340 File Offset: 0x0037B540
		public ISaveConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007533 RID: 30003
		// (get) Token: 0x060183D1 RID: 99281 RVA: 0x0037D350 File Offset: 0x0037B550
		public bool IsTemp
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007534 RID: 30004
		// (get) Token: 0x060183D2 RID: 99282 RVA: 0x0037D390 File Offset: 0x0037B590
		public bool EnableRollbackWhileSwitchOnlineMode
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007535 RID: 30005
		// (get) Token: 0x060183D3 RID: 99283 RVA: 0x0037D3D0 File Offset: 0x0037B5D0
		public bool DisableRollbackWhileReconnect
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007536 RID: 30006
		// (get) Token: 0x060183D4 RID: 99284 RVA: 0x0037D410 File Offset: 0x0037B610
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

		// Token: 0x060183D5 RID: 99285 RVA: 0x0037D470 File Offset: 0x0037B670
		public IActionInfo? EnterActions(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007537 RID: 30007
		// (get) Token: 0x060183D6 RID: 99286 RVA: 0x0037D4D4 File Offset: 0x0037B6D4
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

		// Token: 0x060183D7 RID: 99287 RVA: 0x0037D500 File Offset: 0x0037B700
		public IInitConditionActions? InitConditionActions(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IInitConditionActions?(default(IInitConditionActions).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17007538 RID: 30008
		// (get) Token: 0x060183D8 RID: 99288 RVA: 0x0037D564 File Offset: 0x0037B764
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

		// Token: 0x17007539 RID: 30009
		// (get) Token: 0x060183D9 RID: 99289 RVA: 0x0037D590 File Offset: 0x0037B790
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

		// Token: 0x060183DA RID: 99290 RVA: 0x0037D5D0 File Offset: 0x0037B7D0
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

		// Token: 0x060183DB RID: 99291 RVA: 0x0037D61F File Offset: 0x0037B81F
		public static void StartISaveConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x060183DC RID: 99292 RVA: 0x0037D628 File Offset: 0x0037B828
		public static void AddIsTemp(FlatBufferBuilder builder, bool isTemp)
		{
			builder.AddBool(0, isTemp, false);
		}

		// Token: 0x060183DD RID: 99293 RVA: 0x0037D633 File Offset: 0x0037B833
		public static void AddEnableRollbackWhileSwitchOnlineMode(FlatBufferBuilder builder, bool enableRollbackWhileSwitchOnlineMode)
		{
			builder.AddBool(1, enableRollbackWhileSwitchOnlineMode, false);
		}

		// Token: 0x060183DE RID: 99294 RVA: 0x0037D63E File Offset: 0x0037B83E
		public static void AddDisableRollbackWhileReconnect(FlatBufferBuilder builder, bool disableRollbackWhileReconnect)
		{
			builder.AddBool(2, disableRollbackWhileReconnect, false);
		}

		// Token: 0x060183DF RID: 99295 RVA: 0x0037D649 File Offset: 0x0037B849
		public static void AddPosRollbackCfg(FlatBufferBuilder builder, Offset<IPosRollbackConfig> posRollbackCfgOffset)
		{
			builder.AddOffset(3, posRollbackCfgOffset.Value, 0);
		}

		// Token: 0x060183E0 RID: 99296 RVA: 0x0037D659 File Offset: 0x0037B859
		public static void AddEnterActions(FlatBufferBuilder builder, VectorOffset enterActionsOffset)
		{
			builder.AddOffset(4, enterActionsOffset.Value, 0);
		}

		// Token: 0x060183E1 RID: 99297 RVA: 0x0037D66C File Offset: 0x0037B86C
		public static VectorOffset CreateEnterActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060183E2 RID: 99298 RVA: 0x0037D6AC File Offset: 0x0037B8AC
		public static VectorOffset CreateEnterActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060183E3 RID: 99299 RVA: 0x0037D6C6 File Offset: 0x0037B8C6
		public static VectorOffset CreateEnterActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060183E4 RID: 99300 RVA: 0x0037D6E4 File Offset: 0x0037B8E4
		public static VectorOffset CreateEnterActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060183E5 RID: 99301 RVA: 0x0037D6FD File Offset: 0x0037B8FD
		public static void StartEnterActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060183E6 RID: 99302 RVA: 0x0037D708 File Offset: 0x0037B908
		public static void AddInitConditionActions(FlatBufferBuilder builder, VectorOffset initConditionActionsOffset)
		{
			builder.AddOffset(5, initConditionActionsOffset.Value, 0);
		}

		// Token: 0x060183E7 RID: 99303 RVA: 0x0037D718 File Offset: 0x0037B918
		public static VectorOffset CreateInitConditionActionsVector(FlatBufferBuilder builder, Offset<IInitConditionActions>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060183E8 RID: 99304 RVA: 0x0037D758 File Offset: 0x0037B958
		public static VectorOffset CreateInitConditionActionsVectorBlock(FlatBufferBuilder builder, Offset<IInitConditionActions>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IInitConditionActions>>(data);
			return builder.EndVector();
		}

		// Token: 0x060183E9 RID: 99305 RVA: 0x0037D772 File Offset: 0x0037B972
		public static VectorOffset CreateInitConditionActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IInitConditionActions>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IInitConditionActions>>(data);
			return builder.EndVector();
		}

		// Token: 0x060183EA RID: 99306 RVA: 0x0037D790 File Offset: 0x0037B990
		public static VectorOffset CreateInitConditionActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IInitConditionActions>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060183EB RID: 99307 RVA: 0x0037D7A9 File Offset: 0x0037B9A9
		public static void StartInitConditionActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060183EC RID: 99308 RVA: 0x0037D7B4 File Offset: 0x0037B9B4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x060183ED RID: 99309 RVA: 0x0037D7BF File Offset: 0x0037B9BF
		public static Offset<ISaveConfig> EndISaveConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISaveConfig>(builder.EndTable());
		}

		// Token: 0x060183EE RID: 99310 RVA: 0x0037D7CC File Offset: 0x0037B9CC
		public ISaveConfigT UnPack()
		{
			ISaveConfigT saveConfigT = new ISaveConfigT();
			this.UnPackTo(saveConfigT);
			return saveConfigT;
		}

		// Token: 0x060183EF RID: 99311 RVA: 0x0037D7E8 File Offset: 0x0037B9E8
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

		// Token: 0x060183F0 RID: 99312 RVA: 0x0037D904 File Offset: 0x0037BB04
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

		// Token: 0x0400BC91 RID: 48273
		private Table __p;
	}
}
