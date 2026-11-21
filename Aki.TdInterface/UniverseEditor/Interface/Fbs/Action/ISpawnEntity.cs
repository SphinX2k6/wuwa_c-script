using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200793B RID: 31035
	public struct ISpawnEntity : IFlatbufferObject
	{
		// Token: 0x1700E3A5 RID: 58277
		// (get) Token: 0x06036A70 RID: 223856 RVA: 0x00750160 File Offset: 0x0074E360
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036A71 RID: 223857 RVA: 0x0075016D File Offset: 0x0074E36D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036A72 RID: 223858 RVA: 0x00750174 File Offset: 0x0074E374
		public static ISpawnEntity GetRootAsISpawnEntity(ByteBuffer _bb)
		{
			return ISpawnEntity.GetRootAsISpawnEntity(_bb, default(ISpawnEntity));
		}

		// Token: 0x06036A73 RID: 223859 RVA: 0x00750190 File Offset: 0x0074E390
		public static ISpawnEntity GetRootAsISpawnEntity(ByteBuffer _bb, ISpawnEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036A74 RID: 223860 RVA: 0x007501AD File Offset: 0x0074E3AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036A75 RID: 223861 RVA: 0x007501BC File Offset: 0x0074E3BC
		public ISpawnEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E3A6 RID: 58278
		// (get) Token: 0x06036A76 RID: 223862 RVA: 0x007501CC File Offset: 0x0074E3CC
		public int EntityDataId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E3A7 RID: 58279
		// (get) Token: 0x06036A77 RID: 223863 RVA: 0x00750208 File Offset: 0x0074E408
		public ITransform? Transform
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ITransform?(default(ITransform).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E3A8 RID: 58280
		// (get) Token: 0x06036A78 RID: 223864 RVA: 0x00750268 File Offset: 0x0074E468
		public TVarRef SaveType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036A79 RID: 223865 RVA: 0x007502A4 File Offset: 0x0074E4A4
		public TTable? Save<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06036A7A RID: 223866 RVA: 0x007502EC File Offset: 0x0074E4EC
		public IConstVarRef SaveAsIConstVarRef()
		{
			return this.Save<IConstVarRef>().Value;
		}

		// Token: 0x06036A7B RID: 223867 RVA: 0x00750308 File Offset: 0x0074E508
		public IGlobalVarRef SaveAsIGlobalVarRef()
		{
			return this.Save<IGlobalVarRef>().Value;
		}

		// Token: 0x06036A7C RID: 223868 RVA: 0x00750324 File Offset: 0x0074E524
		public IOtherVarRef SaveAsIOtherVarRef()
		{
			return this.Save<IOtherVarRef>().Value;
		}

		// Token: 0x06036A7D RID: 223869 RVA: 0x00750340 File Offset: 0x0074E540
		public ISelfVarRef SaveAsISelfVarRef()
		{
			return this.Save<ISelfVarRef>().Value;
		}

		// Token: 0x06036A7E RID: 223870 RVA: 0x0075035C File Offset: 0x0074E55C
		public ISystemVarRef SaveAsISystemVarRef()
		{
			return this.Save<ISystemVarRef>().Value;
		}

		// Token: 0x06036A7F RID: 223871 RVA: 0x00750377 File Offset: 0x0074E577
		public static Offset<ISpawnEntity> CreateISpawnEntity(FlatBufferBuilder builder, int EntityDataId = 0, Offset<ITransform> TransformOffset = default(Offset<ITransform>), TVarRef Save_type = TVarRef.NONE, int SaveOffset = 0)
		{
			builder.StartTable(4);
			ISpawnEntity.AddSave(builder, SaveOffset);
			ISpawnEntity.AddTransform(builder, TransformOffset);
			ISpawnEntity.AddEntityDataId(builder, EntityDataId);
			ISpawnEntity.AddSaveType(builder, Save_type);
			return ISpawnEntity.EndISpawnEntity(builder);
		}

		// Token: 0x06036A80 RID: 223872 RVA: 0x007503A3 File Offset: 0x0074E5A3
		public static void StartISpawnEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06036A81 RID: 223873 RVA: 0x007503AC File Offset: 0x0074E5AC
		public static void AddEntityDataId(FlatBufferBuilder builder, int entityDataId)
		{
			builder.AddInt(0, entityDataId, 0);
		}

		// Token: 0x06036A82 RID: 223874 RVA: 0x007503B7 File Offset: 0x0074E5B7
		public static void AddTransform(FlatBufferBuilder builder, Offset<ITransform> transformOffset)
		{
			builder.AddOffset(1, transformOffset.Value, 0);
		}

		// Token: 0x06036A83 RID: 223875 RVA: 0x007503C7 File Offset: 0x0074E5C7
		public static void AddSaveType(FlatBufferBuilder builder, TVarRef saveType)
		{
			builder.AddByte(2, (byte)saveType, 0);
		}

		// Token: 0x06036A84 RID: 223876 RVA: 0x007503D2 File Offset: 0x0074E5D2
		public static void AddSave(FlatBufferBuilder builder, int saveOffset)
		{
			builder.AddOffset(3, saveOffset, 0);
		}

		// Token: 0x06036A85 RID: 223877 RVA: 0x007503DD File Offset: 0x0074E5DD
		public static Offset<ISpawnEntity> EndISpawnEntity(FlatBufferBuilder builder)
		{
			return new Offset<ISpawnEntity>(builder.EndTable());
		}

		// Token: 0x06036A86 RID: 223878 RVA: 0x007503EC File Offset: 0x0074E5EC
		public ISpawnEntityT UnPack()
		{
			ISpawnEntityT spawnEntityT = new ISpawnEntityT();
			this.UnPackTo(spawnEntityT);
			return spawnEntityT;
		}

		// Token: 0x06036A87 RID: 223879 RVA: 0x00750408 File Offset: 0x0074E608
		public void UnPackTo(ISpawnEntityT _o)
		{
			_o.EntityDataId = this.EntityDataId;
			_o.Transform = ((this.Transform != null) ? this.Transform.Value.UnPack() : null);
			_o.Save = new TVarRefUnion();
			_o.Save.Type = this.SaveType;
			switch (this.SaveType)
			{
			case TVarRef.IConstVarRef:
				_o.Save.Value = ((this.Save<IConstVarRef>() != null) ? this.Save<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.Save.Value = ((this.Save<IGlobalVarRef>() != null) ? this.Save<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.Save.Value = ((this.Save<IOtherVarRef>() != null) ? this.Save<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.Save.Value = ((this.Save<ISelfVarRef>() != null) ? this.Save<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.Save.Value = ((this.Save<ISystemVarRef>() != null) ? this.Save<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06036A88 RID: 223880 RVA: 0x007505A8 File Offset: 0x0074E7A8
		public static Offset<ISpawnEntity> Pack(FlatBufferBuilder builder, ISpawnEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpawnEntity>);
			}
			Offset<ITransform> transformOffset = (_o.Transform == null) ? default(Offset<ITransform>) : ITransform.Pack(builder, _o.Transform);
			TVarRef save_type = (_o.Save == null) ? TVarRef.NONE : _o.Save.Type;
			int saveOffset = (_o.Save == null) ? 0 : TVarRefUnion.Pack(builder, _o.Save);
			return ISpawnEntity.CreateISpawnEntity(builder, _o.EntityDataId, transformOffset, save_type, saveOffset);
		}

		// Token: 0x04012C01 RID: 76801
		private Table __p;
	}
}
