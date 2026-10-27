using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200716F RID: 29039
	public struct ISpawnEntity : IFlatbufferObject
	{
		// Token: 0x1700D7C0 RID: 55232
		// (get) Token: 0x060337C6 RID: 210886 RVA: 0x006EF954 File Offset: 0x006EDB54
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060337C7 RID: 210887 RVA: 0x006EF961 File Offset: 0x006EDB61
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060337C8 RID: 210888 RVA: 0x006EF968 File Offset: 0x006EDB68
		public static ISpawnEntity GetRootAsISpawnEntity(ByteBuffer _bb)
		{
			return ISpawnEntity.GetRootAsISpawnEntity(_bb, default(ISpawnEntity));
		}

		// Token: 0x060337C9 RID: 210889 RVA: 0x006EF984 File Offset: 0x006EDB84
		public static ISpawnEntity GetRootAsISpawnEntity(ByteBuffer _bb, ISpawnEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060337CA RID: 210890 RVA: 0x006EF9A1 File Offset: 0x006EDBA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060337CB RID: 210891 RVA: 0x006EF9B0 File Offset: 0x006EDBB0
		public ISpawnEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D7C1 RID: 55233
		// (get) Token: 0x060337CC RID: 210892 RVA: 0x006EF9C0 File Offset: 0x006EDBC0
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

		// Token: 0x1700D7C2 RID: 55234
		// (get) Token: 0x060337CD RID: 210893 RVA: 0x006EF9FC File Offset: 0x006EDBFC
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

		// Token: 0x1700D7C3 RID: 55235
		// (get) Token: 0x060337CE RID: 210894 RVA: 0x006EFA5C File Offset: 0x006EDC5C
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

		// Token: 0x060337CF RID: 210895 RVA: 0x006EFA98 File Offset: 0x006EDC98
		public TTable? Save<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060337D0 RID: 210896 RVA: 0x006EFAE0 File Offset: 0x006EDCE0
		public IConstVarRef SaveAsIConstVarRef()
		{
			return this.Save<IConstVarRef>().Value;
		}

		// Token: 0x060337D1 RID: 210897 RVA: 0x006EFAFC File Offset: 0x006EDCFC
		public IGlobalVarRef SaveAsIGlobalVarRef()
		{
			return this.Save<IGlobalVarRef>().Value;
		}

		// Token: 0x060337D2 RID: 210898 RVA: 0x006EFB18 File Offset: 0x006EDD18
		public IOtherVarRef SaveAsIOtherVarRef()
		{
			return this.Save<IOtherVarRef>().Value;
		}

		// Token: 0x060337D3 RID: 210899 RVA: 0x006EFB34 File Offset: 0x006EDD34
		public ISelfVarRef SaveAsISelfVarRef()
		{
			return this.Save<ISelfVarRef>().Value;
		}

		// Token: 0x060337D4 RID: 210900 RVA: 0x006EFB50 File Offset: 0x006EDD50
		public ISystemVarRef SaveAsISystemVarRef()
		{
			return this.Save<ISystemVarRef>().Value;
		}

		// Token: 0x060337D5 RID: 210901 RVA: 0x006EFB6B File Offset: 0x006EDD6B
		public static Offset<ISpawnEntity> CreateISpawnEntity(FlatBufferBuilder builder, int EntityDataId = 0, Offset<ITransform> TransformOffset = default(Offset<ITransform>), TVarRef Save_type = TVarRef.NONE, int SaveOffset = 0)
		{
			builder.StartTable(4);
			ISpawnEntity.AddSave(builder, SaveOffset);
			ISpawnEntity.AddTransform(builder, TransformOffset);
			ISpawnEntity.AddEntityDataId(builder, EntityDataId);
			ISpawnEntity.AddSaveType(builder, Save_type);
			return ISpawnEntity.EndISpawnEntity(builder);
		}

		// Token: 0x060337D6 RID: 210902 RVA: 0x006EFB97 File Offset: 0x006EDD97
		public static void StartISpawnEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060337D7 RID: 210903 RVA: 0x006EFBA0 File Offset: 0x006EDDA0
		public static void AddEntityDataId(FlatBufferBuilder builder, int entityDataId)
		{
			builder.AddInt(0, entityDataId, 0);
		}

		// Token: 0x060337D8 RID: 210904 RVA: 0x006EFBAB File Offset: 0x006EDDAB
		public static void AddTransform(FlatBufferBuilder builder, Offset<ITransform> transformOffset)
		{
			builder.AddOffset(1, transformOffset.Value, 0);
		}

		// Token: 0x060337D9 RID: 210905 RVA: 0x006EFBBB File Offset: 0x006EDDBB
		public static void AddSaveType(FlatBufferBuilder builder, TVarRef saveType)
		{
			builder.AddByte(2, (byte)saveType, 0);
		}

		// Token: 0x060337DA RID: 210906 RVA: 0x006EFBC6 File Offset: 0x006EDDC6
		public static void AddSave(FlatBufferBuilder builder, int saveOffset)
		{
			builder.AddOffset(3, saveOffset, 0);
		}

		// Token: 0x060337DB RID: 210907 RVA: 0x006EFBD1 File Offset: 0x006EDDD1
		public static Offset<ISpawnEntity> EndISpawnEntity(FlatBufferBuilder builder)
		{
			return new Offset<ISpawnEntity>(builder.EndTable());
		}

		// Token: 0x060337DC RID: 210908 RVA: 0x006EFBE0 File Offset: 0x006EDDE0
		public ISpawnEntityT UnPack()
		{
			ISpawnEntityT spawnEntityT = new ISpawnEntityT();
			this.UnPackTo(spawnEntityT);
			return spawnEntityT;
		}

		// Token: 0x060337DD RID: 210909 RVA: 0x006EFBFC File Offset: 0x006EDDFC
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

		// Token: 0x060337DE RID: 210910 RVA: 0x006EFD9C File Offset: 0x006EDF9C
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

		// Token: 0x04011C12 RID: 72722
		private Table __p;
	}
}
