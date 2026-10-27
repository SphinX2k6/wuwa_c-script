using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005126 RID: 20774
	public struct IElementalBoxFoundationComponent : IFlatbufferObject
	{
		// Token: 0x1700975B RID: 38747
		// (get) Token: 0x060217BF RID: 137151 RVA: 0x004A608C File Offset: 0x004A428C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060217C0 RID: 137152 RVA: 0x004A6099 File Offset: 0x004A4299
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060217C1 RID: 137153 RVA: 0x004A60A0 File Offset: 0x004A42A0
		public static IElementalBoxFoundationComponent GetRootAsIElementalBoxFoundationComponent(ByteBuffer _bb)
		{
			return IElementalBoxFoundationComponent.GetRootAsIElementalBoxFoundationComponent(_bb, default(IElementalBoxFoundationComponent));
		}

		// Token: 0x060217C2 RID: 137154 RVA: 0x004A60BC File Offset: 0x004A42BC
		public static IElementalBoxFoundationComponent GetRootAsIElementalBoxFoundationComponent(ByteBuffer _bb, IElementalBoxFoundationComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060217C3 RID: 137155 RVA: 0x004A60D9 File Offset: 0x004A42D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060217C4 RID: 137156 RVA: 0x004A60E8 File Offset: 0x004A42E8
		public IElementalBoxFoundationComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700975C RID: 38748
		// (get) Token: 0x060217C5 RID: 137157 RVA: 0x004A60F8 File Offset: 0x004A42F8
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700975D RID: 38749
		// (get) Token: 0x060217C6 RID: 137158 RVA: 0x004A6138 File Offset: 0x004A4338
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

		// Token: 0x1700975E RID: 38750
		// (get) Token: 0x060217C7 RID: 137159 RVA: 0x004A6174 File Offset: 0x004A4374
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

		// Token: 0x1700975F RID: 38751
		// (get) Token: 0x060217C8 RID: 137160 RVA: 0x004A61B0 File Offset: 0x004A43B0
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

		// Token: 0x17009760 RID: 38752
		// (get) Token: 0x060217C9 RID: 137161 RVA: 0x004A61F0 File Offset: 0x004A43F0
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

		// Token: 0x060217CA RID: 137162 RVA: 0x004A6230 File Offset: 0x004A4430
		public IActionInfo? OnObtainNucleusActions(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009761 RID: 38753
		// (get) Token: 0x060217CB RID: 137163 RVA: 0x004A6294 File Offset: 0x004A4494
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

		// Token: 0x060217CC RID: 137164 RVA: 0x004A62C0 File Offset: 0x004A44C0
		public IActionInfo? OnReturnNucleusActions(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009762 RID: 38754
		// (get) Token: 0x060217CD RID: 137165 RVA: 0x004A6324 File Offset: 0x004A4524
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

		// Token: 0x17009763 RID: 38755
		// (get) Token: 0x060217CE RID: 137166 RVA: 0x004A6350 File Offset: 0x004A4550
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

		// Token: 0x060217CF RID: 137167 RVA: 0x004A6390 File Offset: 0x004A4590
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

		// Token: 0x060217D0 RID: 137168 RVA: 0x004A63E7 File Offset: 0x004A45E7
		public static void StartIElementalBoxFoundationComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x060217D1 RID: 137169 RVA: 0x004A63F0 File Offset: 0x004A45F0
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060217D2 RID: 137170 RVA: 0x004A63FB File Offset: 0x004A45FB
		public static void AddElementalType(FlatBufferBuilder builder, EElementalType elementalType)
		{
			builder.AddByte(1, (byte)elementalType, 0);
		}

		// Token: 0x060217D3 RID: 137171 RVA: 0x004A6406 File Offset: 0x004A4606
		public static void AddMaxCarryRange(FlatBufferBuilder builder, int maxCarryRange)
		{
			builder.AddInt(2, maxCarryRange, 0);
		}

		// Token: 0x060217D4 RID: 137172 RVA: 0x004A6411 File Offset: 0x004A4611
		public static void AddInitialActiveElementalBoxId(FlatBufferBuilder builder, int initialActiveElementalBoxId)
		{
			builder.AddInt(3, initialActiveElementalBoxId, 0);
		}

		// Token: 0x060217D5 RID: 137173 RVA: 0x004A641C File Offset: 0x004A461C
		public static void AddLoopTeleportMappingFoundationId(FlatBufferBuilder builder, int loopTeleportMappingFoundationId)
		{
			builder.AddInt(4, loopTeleportMappingFoundationId, 0);
		}

		// Token: 0x060217D6 RID: 137174 RVA: 0x004A6427 File Offset: 0x004A4627
		public static void AddOnObtainNucleusActions(FlatBufferBuilder builder, VectorOffset onObtainNucleusActionsOffset)
		{
			builder.AddOffset(5, onObtainNucleusActionsOffset.Value, 0);
		}

		// Token: 0x060217D7 RID: 137175 RVA: 0x004A6438 File Offset: 0x004A4638
		public static VectorOffset CreateOnObtainNucleusActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060217D8 RID: 137176 RVA: 0x004A6478 File Offset: 0x004A4678
		public static VectorOffset CreateOnObtainNucleusActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060217D9 RID: 137177 RVA: 0x004A6492 File Offset: 0x004A4692
		public static VectorOffset CreateOnObtainNucleusActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060217DA RID: 137178 RVA: 0x004A64B0 File Offset: 0x004A46B0
		public static VectorOffset CreateOnObtainNucleusActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060217DB RID: 137179 RVA: 0x004A64C9 File Offset: 0x004A46C9
		public static void StartOnObtainNucleusActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060217DC RID: 137180 RVA: 0x004A64D4 File Offset: 0x004A46D4
		public static void AddOnReturnNucleusActions(FlatBufferBuilder builder, VectorOffset onReturnNucleusActionsOffset)
		{
			builder.AddOffset(6, onReturnNucleusActionsOffset.Value, 0);
		}

		// Token: 0x060217DD RID: 137181 RVA: 0x004A64E4 File Offset: 0x004A46E4
		public static VectorOffset CreateOnReturnNucleusActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060217DE RID: 137182 RVA: 0x004A6524 File Offset: 0x004A4724
		public static VectorOffset CreateOnReturnNucleusActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060217DF RID: 137183 RVA: 0x004A653E File Offset: 0x004A473E
		public static VectorOffset CreateOnReturnNucleusActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060217E0 RID: 137184 RVA: 0x004A655C File Offset: 0x004A475C
		public static VectorOffset CreateOnReturnNucleusActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060217E1 RID: 137185 RVA: 0x004A6575 File Offset: 0x004A4775
		public static void StartOnReturnNucleusActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060217E2 RID: 137186 RVA: 0x004A6580 File Offset: 0x004A4780
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x060217E3 RID: 137187 RVA: 0x004A658B File Offset: 0x004A478B
		public static Offset<IElementalBoxFoundationComponent> EndIElementalBoxFoundationComponent(FlatBufferBuilder builder)
		{
			return new Offset<IElementalBoxFoundationComponent>(builder.EndTable());
		}

		// Token: 0x060217E4 RID: 137188 RVA: 0x004A6598 File Offset: 0x004A4798
		public IElementalBoxFoundationComponentT UnPack()
		{
			IElementalBoxFoundationComponentT elementalBoxFoundationComponentT = new IElementalBoxFoundationComponentT();
			this.UnPackTo(elementalBoxFoundationComponentT);
			return elementalBoxFoundationComponentT;
		}

		// Token: 0x060217E5 RID: 137189 RVA: 0x004A65B4 File Offset: 0x004A47B4
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

		// Token: 0x060217E6 RID: 137190 RVA: 0x004A66B0 File Offset: 0x004A48B0
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

		// Token: 0x0400E19E RID: 57758
		private Table __p;
	}
}
