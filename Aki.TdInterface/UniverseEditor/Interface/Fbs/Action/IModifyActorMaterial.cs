using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AA6 RID: 27302
	public struct IModifyActorMaterial : IFlatbufferObject
	{
		// Token: 0x1700CA9D RID: 51869
		// (get) Token: 0x0602FD76 RID: 195958 RVA: 0x00682215 File Offset: 0x00680415
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FD77 RID: 195959 RVA: 0x00682222 File Offset: 0x00680422
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FD78 RID: 195960 RVA: 0x0068222C File Offset: 0x0068042C
		public static IModifyActorMaterial GetRootAsIModifyActorMaterial(ByteBuffer _bb)
		{
			return IModifyActorMaterial.GetRootAsIModifyActorMaterial(_bb, default(IModifyActorMaterial));
		}

		// Token: 0x0602FD79 RID: 195961 RVA: 0x00682248 File Offset: 0x00680448
		public static IModifyActorMaterial GetRootAsIModifyActorMaterial(ByteBuffer _bb, IModifyActorMaterial obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FD7A RID: 195962 RVA: 0x00682265 File Offset: 0x00680465
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FD7B RID: 195963 RVA: 0x00682274 File Offset: 0x00680474
		public IModifyActorMaterial __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602FD7C RID: 195964 RVA: 0x00682284 File Offset: 0x00680484
		public IActorRef? ActorRefs(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IActorRef?(default(IActorRef).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700CA9E RID: 51870
		// (get) Token: 0x0602FD7D RID: 195965 RVA: 0x006822E4 File Offset: 0x006804E4
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

		// Token: 0x1700CA9F RID: 51871
		// (get) Token: 0x0602FD7E RID: 195966 RVA: 0x00682310 File Offset: 0x00680510
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

		// Token: 0x0602FD7F RID: 195967 RVA: 0x0068234C File Offset: 0x0068054C
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602FD80 RID: 195968 RVA: 0x00682390 File Offset: 0x00680590
		public IChangeActorMaterialData ConfigAsIChangeActorMaterialData()
		{
			return this.Config<IChangeActorMaterialData>().Value;
		}

		// Token: 0x0602FD81 RID: 195969 RVA: 0x006823AC File Offset: 0x006805AC
		public IChangeActorMPC ConfigAsIChangeActorMPC()
		{
			return this.Config<IChangeActorMPC>().Value;
		}

		// Token: 0x0602FD82 RID: 195970 RVA: 0x006823C7 File Offset: 0x006805C7
		public static Offset<IModifyActorMaterial> CreateIModifyActorMaterial(FlatBufferBuilder builder, VectorOffset ActorRefsOffset = default(VectorOffset), TModifyActorMaterialType Config_type = TModifyActorMaterialType.NONE, int ConfigOffset = 0)
		{
			builder.StartTable(3);
			IModifyActorMaterial.AddConfig(builder, ConfigOffset);
			IModifyActorMaterial.AddActorRefs(builder, ActorRefsOffset);
			IModifyActorMaterial.AddConfigType(builder, Config_type);
			return IModifyActorMaterial.EndIModifyActorMaterial(builder);
		}

		// Token: 0x0602FD83 RID: 195971 RVA: 0x006823EB File Offset: 0x006805EB
		public static void StartIModifyActorMaterial(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602FD84 RID: 195972 RVA: 0x006823F4 File Offset: 0x006805F4
		public static void AddActorRefs(FlatBufferBuilder builder, VectorOffset actorRefsOffset)
		{
			builder.AddOffset(0, actorRefsOffset.Value, 0);
		}

		// Token: 0x0602FD85 RID: 195973 RVA: 0x00682404 File Offset: 0x00680604
		public static VectorOffset CreateActorRefsVector(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602FD86 RID: 195974 RVA: 0x00682444 File Offset: 0x00680644
		public static VectorOffset CreateActorRefsVectorBlock(FlatBufferBuilder builder, Offset<IActorRef>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602FD87 RID: 195975 RVA: 0x0068245E File Offset: 0x0068065E
		public static VectorOffset CreateActorRefsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorRef>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorRef>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602FD88 RID: 195976 RVA: 0x0068247C File Offset: 0x0068067C
		public static VectorOffset CreateActorRefsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorRef>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602FD89 RID: 195977 RVA: 0x00682495 File Offset: 0x00680695
		public static void StartActorRefsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602FD8A RID: 195978 RVA: 0x006824A0 File Offset: 0x006806A0
		public static void AddConfigType(FlatBufferBuilder builder, TModifyActorMaterialType configType)
		{
			builder.AddByte(1, (byte)configType, 0);
		}

		// Token: 0x0602FD8B RID: 195979 RVA: 0x006824AB File Offset: 0x006806AB
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(2, configOffset, 0);
		}

		// Token: 0x0602FD8C RID: 195980 RVA: 0x006824B6 File Offset: 0x006806B6
		public static Offset<IModifyActorMaterial> EndIModifyActorMaterial(FlatBufferBuilder builder)
		{
			return new Offset<IModifyActorMaterial>(builder.EndTable());
		}

		// Token: 0x0602FD8D RID: 195981 RVA: 0x006824C4 File Offset: 0x006806C4
		public IModifyActorMaterialT UnPack()
		{
			IModifyActorMaterialT modifyActorMaterialT = new IModifyActorMaterialT();
			this.UnPackTo(modifyActorMaterialT);
			return modifyActorMaterialT;
		}

		// Token: 0x0602FD8E RID: 195982 RVA: 0x006824E0 File Offset: 0x006806E0
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

		// Token: 0x0602FD8F RID: 195983 RVA: 0x006825DC File Offset: 0x006807DC
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

		// Token: 0x040112E2 RID: 70370
		private Table __p;
	}
}
