using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071CB RID: 29131
	public struct IModifyActorMaterial : IFlatbufferObject
	{
		// Token: 0x1700D54D RID: 54605
		// (get) Token: 0x06032AB2 RID: 207538 RVA: 0x006D84D5 File Offset: 0x006D66D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032AB3 RID: 207539 RVA: 0x006D84E2 File Offset: 0x006D66E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032AB4 RID: 207540 RVA: 0x006D84EC File Offset: 0x006D66EC
		public static IModifyActorMaterial GetRootAsIModifyActorMaterial(ByteBuffer _bb)
		{
			return IModifyActorMaterial.GetRootAsIModifyActorMaterial(_bb, default(IModifyActorMaterial));
		}

		// Token: 0x06032AB5 RID: 207541 RVA: 0x006D8508 File Offset: 0x006D6708
		public static IModifyActorMaterial GetRootAsIModifyActorMaterial(ByteBuffer _bb, IModifyActorMaterial obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032AB6 RID: 207542 RVA: 0x006D8525 File Offset: 0x006D6725
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032AB7 RID: 207543 RVA: 0x006D8534 File Offset: 0x006D6734
		public IModifyActorMaterial __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06032AB8 RID: 207544 RVA: 0x006D8544 File Offset: 0x006D6744
		public IActorRef? ActorRefs(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IActorRef?(default(IActorRef).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D54E RID: 54606
		// (get) Token: 0x06032AB9 RID: 207545 RVA: 0x006D85A4 File Offset: 0x006D67A4
		public int ActorRefsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700D54F RID: 54607
		// (get) Token: 0x06032ABA RID: 207546 RVA: 0x006D85D0 File Offset: 0x006D67D0
		public TModifyActorMaterialType ConfigType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TModifyActorMaterialType.NONE;
				}
				return (TModifyActorMaterialType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032ABB RID: 207547 RVA: 0x006D860C File Offset: 0x006D680C
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06032ABC RID: 207548 RVA: 0x006D8650 File Offset: 0x006D6850
		public IChangeActorMaterialData ConfigAsIChangeActorMaterialData()
		{
			return this.Config<IChangeActorMaterialData>().Value;
		}

		// Token: 0x06032ABD RID: 207549 RVA: 0x006D866C File Offset: 0x006D686C
		public IChangeActorMPC ConfigAsIChangeActorMPC()
		{
			return this.Config<IChangeActorMPC>().Value;
		}

		// Token: 0x06032ABE RID: 207550 RVA: 0x006D8687 File Offset: 0x006D6887
		public static Offset<IModifyActorMaterial> CreateIModifyActorMaterial(FlatBufferBuilder builder, VectorOffset ActorRefsOffset = default(VectorOffset), TModifyActorMaterialType Config_type = TModifyActorMaterialType.NONE, int ConfigOffset = 0)
		{
			builder.StartTable(3);
			IModifyActorMaterial.AddConfig(builder, ConfigOffset);
			IModifyActorMaterial.AddActorRefs(builder, ActorRefsOffset);
			IModifyActorMaterial.AddConfigType(builder, Config_type);
			return IModifyActorMaterial.EndIModifyActorMaterial(builder);
		}

		// Token: 0x06032ABF RID: 207551 RVA: 0x006D86AB File Offset: 0x006D68AB
		public static void StartIModifyActorMaterial(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06032AC0 RID: 207552 RVA: 0x006D86B4 File Offset: 0x006D68B4
		public static void AddActorRefs(FlatBufferBuilder builder, VectorOffset actorRefsOffset)
		{
			builder.AddOffset(0, actorRefsOffset.Value, 0);
		}

		// Token: 0x06032AC1 RID: 207553 RVA: 0x006D86C4 File Offset: 0x006D68C4
		public static VectorOffset CreateActorRefsVector(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06032AC2 RID: 207554 RVA: 0x006D8704 File Offset: 0x006D6904
		public static VectorOffset CreateActorRefsVectorBlock(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x06032AC3 RID: 207555 RVA: 0x006D871E File Offset: 0x006D691E
		public static VectorOffset CreateActorRefsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorRef>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x06032AC4 RID: 207556 RVA: 0x006D873C File Offset: 0x006D693C
		public static VectorOffset CreateActorRefsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorRef>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06032AC5 RID: 207557 RVA: 0x006D8755 File Offset: 0x006D6955
		public static void StartActorRefsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06032AC6 RID: 207558 RVA: 0x006D8760 File Offset: 0x006D6960
		public static void AddConfigType(FlatBufferBuilder builder, TModifyActorMaterialType configType)
		{
			builder.AddByte(1, (byte)configType, 0);
		}

		// Token: 0x06032AC7 RID: 207559 RVA: 0x006D876B File Offset: 0x006D696B
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(2, configOffset, 0);
		}

		// Token: 0x06032AC8 RID: 207560 RVA: 0x006D8776 File Offset: 0x006D6976
		public static Offset<IModifyActorMaterial> EndIModifyActorMaterial(FlatBufferBuilder builder)
		{
			return new Offset<IModifyActorMaterial>(builder.EndTable());
		}

		// Token: 0x06032AC9 RID: 207561 RVA: 0x006D8784 File Offset: 0x006D6984
		public IModifyActorMaterialT UnPack()
		{
			IModifyActorMaterialT modifyActorMaterialT = new IModifyActorMaterialT();
			this.UnPackTo(modifyActorMaterialT);
			return modifyActorMaterialT;
		}

		// Token: 0x06032ACA RID: 207562 RVA: 0x006D87A0 File Offset: 0x006D69A0
		public void UnPackTo(IModifyActorMaterialT _o)
		{
			_o.ActorRefs = new List<IActorRefT>();
			for (int i = 0; i < this.ActorRefsLength; i++)
			{
				_o.ActorRefs.Add((this.ActorRefs(i) != null) ? this.ActorRefs(i).Value.UnPack() : null);
			}
			_o.Config = new TModifyActorMaterialTypeUnion();
			_o.Config.Type = this.ConfigType;
			TModifyActorMaterialType configType = this.ConfigType;
			if (configType == TModifyActorMaterialType.IChangeActorMaterialData)
			{
				_o.Config.Value = ((this.Config<IChangeActorMaterialData>() != null) ? this.Config<IChangeActorMaterialData>().Value.UnPack() : null);
				return;
			}
			if (configType != TModifyActorMaterialType.IChangeActorMPC)
			{
				return;
			}
			_o.Config.Value = ((this.Config<IChangeActorMPC>() != null) ? this.Config<IChangeActorMPC>().Value.UnPack() : null);
		}

		// Token: 0x06032ACB RID: 207563 RVA: 0x006D889C File Offset: 0x006D6A9C
		public static Offset<IModifyActorMaterial> Pack(FlatBufferBuilder builder, IModifyActorMaterialT _o)
		{
			if (_o == null)
			{
				return default(Offset<IModifyActorMaterial>);
			}
			VectorOffset actorRefsOffset = default(VectorOffset);
			if (_o.ActorRefs != null)
			{
				Offset<IActorRef>[] array = new Offset<IActorRef>[_o.ActorRefs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActorRef.Pack(builder, _o.ActorRefs[i]);
				}
				actorRefsOffset = IModifyActorMaterial.CreateActorRefsVector(builder, array);
			}
			TModifyActorMaterialType config_type = (_o.Config == null) ? TModifyActorMaterialType.NONE : _o.Config.Type;
			int configOffset = (_o.Config == null) ? 0 : TModifyActorMaterialTypeUnion.Pack(builder, _o.Config);
			return IModifyActorMaterial.CreateIModifyActorMaterial(builder, actorRefsOffset, config_type, configOffset);
		}

		// Token: 0x040121DD RID: 74205
		private Table __p;
	}
}
