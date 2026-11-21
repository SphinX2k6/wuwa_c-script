using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200568B RID: 22155
	public struct IElementalBoxFoundationComponent : IFlatbufferObject
	{
		// Token: 0x17009F48 RID: 40776
		// (get) Token: 0x06023713 RID: 145171 RVA: 0x004E0018 File Offset: 0x004DE218
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023714 RID: 145172 RVA: 0x004E0025 File Offset: 0x004DE225
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023715 RID: 145173 RVA: 0x004E002C File Offset: 0x004DE22C
		public static IElementalBoxFoundationComponent GetRootAsIElementalBoxFoundationComponent(ByteBuffer _bb)
		{
			return IElementalBoxFoundationComponent.GetRootAsIElementalBoxFoundationComponent(_bb, default(IElementalBoxFoundationComponent));
		}

		// Token: 0x06023716 RID: 145174 RVA: 0x004E0048 File Offset: 0x004DE248
		public static IElementalBoxFoundationComponent GetRootAsIElementalBoxFoundationComponent(ByteBuffer _bb, IElementalBoxFoundationComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023717 RID: 145175 RVA: 0x004E0065 File Offset: 0x004DE265
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023718 RID: 145176 RVA: 0x004E0074 File Offset: 0x004DE274
		public IElementalBoxFoundationComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009F49 RID: 40777
		// (get) Token: 0x06023719 RID: 145177 RVA: 0x004E0084 File Offset: 0x004DE284
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009F4A RID: 40778
		// (get) Token: 0x0602371A RID: 145178 RVA: 0x004E00C4 File Offset: 0x004DE2C4
		public EElementalType ElementalType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EElementalType.Fire;
				}
				return (EElementalType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009F4B RID: 40779
		// (get) Token: 0x0602371B RID: 145179 RVA: 0x004E0100 File Offset: 0x004DE300
		public int MaxCarryRange
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009F4C RID: 40780
		// (get) Token: 0x0602371C RID: 145180 RVA: 0x004E013C File Offset: 0x004DE33C
		public int InitialActiveElementalBoxId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009F4D RID: 40781
		// (get) Token: 0x0602371D RID: 145181 RVA: 0x004E017C File Offset: 0x004DE37C
		public int LoopTeleportMappingFoundationId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602371E RID: 145182 RVA: 0x004E01BC File Offset: 0x004DE3BC
		public IActionInfo? OnObtainNucleusActions(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009F4E RID: 40782
		// (get) Token: 0x0602371F RID: 145183 RVA: 0x004E0220 File Offset: 0x004DE420
		public int OnObtainNucleusActionsLength
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

		// Token: 0x06023720 RID: 145184 RVA: 0x004E024C File Offset: 0x004DE44C
		public IActionInfo? OnReturnNucleusActions(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009F4F RID: 40783
		// (get) Token: 0x06023721 RID: 145185 RVA: 0x004E02B0 File Offset: 0x004DE4B0
		public int OnReturnNucleusActionsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17009F50 RID: 40784
		// (get) Token: 0x06023722 RID: 145186 RVA: 0x004E02DC File Offset: 0x004DE4DC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023723 RID: 145187 RVA: 0x004E031C File Offset: 0x004DE51C
		public static Offset<IElementalBoxFoundationComponent> CreateIElementalBoxFoundationComponent(FlatBufferBuilder builder, bool Disabled = false, EElementalType ElementalType = EElementalType.Fire, int MaxCarryRange = 0, int InitialActiveElementalBoxId = 0, int LoopTeleportMappingFoundationId = 0, VectorOffset OnObtainNucleusActionsOffset = default(VectorOffset), VectorOffset OnReturnNucleusActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(8);
			IElementalBoxFoundationComponent.AddOnReturnNucleusActions(builder, OnReturnNucleusActionsOffset);
			IElementalBoxFoundationComponent.AddOnObtainNucleusActions(builder, OnObtainNucleusActionsOffset);
			IElementalBoxFoundationComponent.AddLoopTeleportMappingFoundationId(builder, LoopTeleportMappingFoundationId);
			IElementalBoxFoundationComponent.AddInitialActiveElementalBoxId(builder, InitialActiveElementalBoxId);
			IElementalBoxFoundationComponent.AddMaxCarryRange(builder, MaxCarryRange);
			IElementalBoxFoundationComponent.AddNullMask(builder, NullMask);
			IElementalBoxFoundationComponent.AddElementalType(builder, ElementalType);
			IElementalBoxFoundationComponent.AddDisabled(builder, Disabled);
			return IElementalBoxFoundationComponent.EndIElementalBoxFoundationComponent(builder);
		}

		// Token: 0x06023724 RID: 145188 RVA: 0x004E0373 File Offset: 0x004DE573
		public static void StartIElementalBoxFoundationComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06023725 RID: 145189 RVA: 0x004E037C File Offset: 0x004DE57C
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06023726 RID: 145190 RVA: 0x004E0387 File Offset: 0x004DE587
		public static void AddElementalType(FlatBufferBuilder builder, EElementalType elementalType)
		{
			builder.AddByte(1, (byte)elementalType, 0);
		}

		// Token: 0x06023727 RID: 145191 RVA: 0x004E0392 File Offset: 0x004DE592
		public static void AddMaxCarryRange(FlatBufferBuilder builder, int maxCarryRange)
		{
			builder.AddInt(2, maxCarryRange, 0);
		}

		// Token: 0x06023728 RID: 145192 RVA: 0x004E039D File Offset: 0x004DE59D
		public static void AddInitialActiveElementalBoxId(FlatBufferBuilder builder, int initialActiveElementalBoxId)
		{
			builder.AddInt(3, initialActiveElementalBoxId, 0);
		}

		// Token: 0x06023729 RID: 145193 RVA: 0x004E03A8 File Offset: 0x004DE5A8
		public static void AddLoopTeleportMappingFoundationId(FlatBufferBuilder builder, int loopTeleportMappingFoundationId)
		{
			builder.AddInt(4, loopTeleportMappingFoundationId, 0);
		}

		// Token: 0x0602372A RID: 145194 RVA: 0x004E03B3 File Offset: 0x004DE5B3
		public static void AddOnObtainNucleusActions(FlatBufferBuilder builder, VectorOffset onObtainNucleusActionsOffset)
		{
			builder.AddOffset(5, onObtainNucleusActionsOffset.Value, 0);
		}

		// Token: 0x0602372B RID: 145195 RVA: 0x004E03C4 File Offset: 0x004DE5C4
		public static VectorOffset CreateOnObtainNucleusActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602372C RID: 145196 RVA: 0x004E0404 File Offset: 0x004DE604
		public static VectorOffset CreateOnObtainNucleusActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602372D RID: 145197 RVA: 0x004E041E File Offset: 0x004DE61E
		public static VectorOffset CreateOnObtainNucleusActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602372E RID: 145198 RVA: 0x004E043C File Offset: 0x004DE63C
		public static VectorOffset CreateOnObtainNucleusActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602372F RID: 145199 RVA: 0x004E0455 File Offset: 0x004DE655
		public static void StartOnObtainNucleusActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023730 RID: 145200 RVA: 0x004E0460 File Offset: 0x004DE660
		public static void AddOnReturnNucleusActions(FlatBufferBuilder builder, VectorOffset onReturnNucleusActionsOffset)
		{
			builder.AddOffset(6, onReturnNucleusActionsOffset.Value, 0);
		}

		// Token: 0x06023731 RID: 145201 RVA: 0x004E0470 File Offset: 0x004DE670
		public static VectorOffset CreateOnReturnNucleusActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023732 RID: 145202 RVA: 0x004E04B0 File Offset: 0x004DE6B0
		public static VectorOffset CreateOnReturnNucleusActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023733 RID: 145203 RVA: 0x004E04CA File Offset: 0x004DE6CA
		public static VectorOffset CreateOnReturnNucleusActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023734 RID: 145204 RVA: 0x004E04E8 File Offset: 0x004DE6E8
		public static VectorOffset CreateOnReturnNucleusActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023735 RID: 145205 RVA: 0x004E0501 File Offset: 0x004DE701
		public static void StartOnReturnNucleusActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023736 RID: 145206 RVA: 0x004E050C File Offset: 0x004DE70C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06023737 RID: 145207 RVA: 0x004E0517 File Offset: 0x004DE717
		public static Offset<IElementalBoxFoundationComponent> EndIElementalBoxFoundationComponent(FlatBufferBuilder builder)
		{
			return new Offset<IElementalBoxFoundationComponent>(builder.EndTable());
		}

		// Token: 0x06023738 RID: 145208 RVA: 0x004E0524 File Offset: 0x004DE724
		public IElementalBoxFoundationComponentT UnPack()
		{
			IElementalBoxFoundationComponentT elementalBoxFoundationComponentT = new IElementalBoxFoundationComponentT();
			this.UnPackTo(elementalBoxFoundationComponentT);
			return elementalBoxFoundationComponentT;
		}

		// Token: 0x06023739 RID: 145209 RVA: 0x004E0540 File Offset: 0x004DE740
		public void UnPackTo(IElementalBoxFoundationComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.ElementalType = this.ElementalType;
			_o.MaxCarryRange = this.MaxCarryRange;
			_o.InitialActiveElementalBoxId = this.InitialActiveElementalBoxId;
			_o.LoopTeleportMappingFoundationId = this.LoopTeleportMappingFoundationId;
			_o.OnObtainNucleusActions = new List<IActionInfoT>();
			for (int i = 0; i < this.OnObtainNucleusActionsLength; i++)
			{
				_o.OnObtainNucleusActions.Add((this.OnObtainNucleusActions(i) != null) ? this.OnObtainNucleusActions(i).Value.UnPack() : null);
			}
			_o.OnReturnNucleusActions = new List<IActionInfoT>();
			for (int j = 0; j < this.OnReturnNucleusActionsLength; j++)
			{
				_o.OnReturnNucleusActions.Add((this.OnReturnNucleusActions(j) != null) ? this.OnReturnNucleusActions(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602373A RID: 145210 RVA: 0x004E063C File Offset: 0x004DE83C
		public static Offset<IElementalBoxFoundationComponent> Pack(FlatBufferBuilder builder, IElementalBoxFoundationComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IElementalBoxFoundationComponent>);
			}
			VectorOffset onObtainNucleusActionsOffset = default(VectorOffset);
			if (_o.OnObtainNucleusActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.OnObtainNucleusActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.OnObtainNucleusActions[i]);
				}
				onObtainNucleusActionsOffset = IElementalBoxFoundationComponent.CreateOnObtainNucleusActionsVector(builder, array);
			}
			VectorOffset onReturnNucleusActionsOffset = default(VectorOffset);
			if (_o.OnReturnNucleusActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.OnReturnNucleusActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.OnReturnNucleusActions[j]);
				}
				onReturnNucleusActionsOffset = IElementalBoxFoundationComponent.CreateOnReturnNucleusActionsVector(builder, array2);
			}
			return IElementalBoxFoundationComponent.CreateIElementalBoxFoundationComponent(builder, _o.Disabled, _o.ElementalType, _o.MaxCarryRange, _o.InitialActiveElementalBoxId, _o.LoopTeleportMappingFoundationId, onObtainNucleusActionsOffset, onReturnNucleusActionsOffset, _o.NullMask);
		}

		// Token: 0x0400ED9B RID: 60827
		private Table __p;
	}
}
