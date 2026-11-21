using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004454 RID: 17492
	public struct IQuestScheduleBtTreeVar : IFlatbufferObject
	{
		// Token: 0x17007948 RID: 31048
		// (get) Token: 0x0601916F RID: 102767 RVA: 0x00394183 File Offset: 0x00392383
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019170 RID: 102768 RVA: 0x00394190 File Offset: 0x00392390
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019171 RID: 102769 RVA: 0x00394198 File Offset: 0x00392398
		public static IQuestScheduleBtTreeVar GetRootAsIQuestScheduleBtTreeVar(ByteBuffer _bb)
		{
			return IQuestScheduleBtTreeVar.GetRootAsIQuestScheduleBtTreeVar(_bb, default(IQuestScheduleBtTreeVar));
		}

		// Token: 0x06019172 RID: 102770 RVA: 0x003941B4 File Offset: 0x003923B4
		public static IQuestScheduleBtTreeVar GetRootAsIQuestScheduleBtTreeVar(ByteBuffer _bb, IQuestScheduleBtTreeVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019173 RID: 102771 RVA: 0x003941D1 File Offset: 0x003923D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019174 RID: 102772 RVA: 0x003941E0 File Offset: 0x003923E0
		public IQuestScheduleBtTreeVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007949 RID: 31049
		// (get) Token: 0x06019175 RID: 102773 RVA: 0x003941F0 File Offset: 0x003923F0
		public EQuestScheduleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EQuestScheduleType.None;
				}
				return (EQuestScheduleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700794A RID: 31050
		// (get) Token: 0x06019176 RID: 102774 RVA: 0x0039422C File Offset: 0x0039242C
		public TVarRef VarType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019177 RID: 102775 RVA: 0x00394268 File Offset: 0x00392468
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06019178 RID: 102776 RVA: 0x003942AC File Offset: 0x003924AC
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x06019179 RID: 102777 RVA: 0x003942C8 File Offset: 0x003924C8
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x0601917A RID: 102778 RVA: 0x003942E4 File Offset: 0x003924E4
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x0601917B RID: 102779 RVA: 0x00394300 File Offset: 0x00392500
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x0601917C RID: 102780 RVA: 0x0039431C File Offset: 0x0039251C
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x1700794B RID: 31051
		// (get) Token: 0x0601917D RID: 102781 RVA: 0x00394338 File Offset: 0x00392538
		public IWordArtConfig? ShowAsWordArt
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IWordArtConfig?(default(IWordArtConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601917E RID: 102782 RVA: 0x00394396 File Offset: 0x00392596
		public static Offset<IQuestScheduleBtTreeVar> CreateIQuestScheduleBtTreeVar(FlatBufferBuilder builder, EQuestScheduleType Type = EQuestScheduleType.None, TVarRef Var_type = TVarRef.NONE, int VarOffset = 0, Offset<IWordArtConfig> ShowAsWordArtOffset = default(Offset<IWordArtConfig>))
		{
			builder.StartTable(4);
			IQuestScheduleBtTreeVar.AddShowAsWordArt(builder, ShowAsWordArtOffset);
			IQuestScheduleBtTreeVar.AddVar(builder, VarOffset);
			IQuestScheduleBtTreeVar.AddVarType(builder, Var_type);
			IQuestScheduleBtTreeVar.AddType(builder, Type);
			return IQuestScheduleBtTreeVar.EndIQuestScheduleBtTreeVar(builder);
		}

		// Token: 0x0601917F RID: 102783 RVA: 0x003943C2 File Offset: 0x003925C2
		public static void StartIQuestScheduleBtTreeVar(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06019180 RID: 102784 RVA: 0x003943CB File Offset: 0x003925CB
		public static void AddType(FlatBufferBuilder builder, EQuestScheduleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019181 RID: 102785 RVA: 0x003943D6 File Offset: 0x003925D6
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x06019182 RID: 102786 RVA: 0x003943E1 File Offset: 0x003925E1
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x06019183 RID: 102787 RVA: 0x003943EC File Offset: 0x003925EC
		public static void AddShowAsWordArt(FlatBufferBuilder builder, Offset<IWordArtConfig> showAsWordArtOffset)
		{
			builder.AddOffset(3, showAsWordArtOffset.Value, 0);
		}

		// Token: 0x06019184 RID: 102788 RVA: 0x003943FC File Offset: 0x003925FC
		public static Offset<IQuestScheduleBtTreeVar> EndIQuestScheduleBtTreeVar(FlatBufferBuilder builder)
		{
			return new Offset<IQuestScheduleBtTreeVar>(builder.EndTable());
		}

		// Token: 0x06019185 RID: 102789 RVA: 0x0039440C File Offset: 0x0039260C
		public IQuestScheduleBtTreeVarT UnPack()
		{
			IQuestScheduleBtTreeVarT questScheduleBtTreeVarT = new IQuestScheduleBtTreeVarT();
			this.UnPackTo(questScheduleBtTreeVarT);
			return questScheduleBtTreeVarT;
		}

		// Token: 0x06019186 RID: 102790 RVA: 0x00394428 File Offset: 0x00392628
		public void UnPackTo(IQuestScheduleBtTreeVarT _o)
		{
			_o.Type = this.Type;
			_o.Var = new TVarRefUnion();
			_o.Var.Type = this.VarType;
			switch (this.VarType)
			{
			case TVarRef.IConstVarRef:
				_o.Var.Value = ((this.Var<IConstVarRef>() != null) ? this.Var<IConstVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IGlobalVarRef:
				_o.Var.Value = ((this.Var<IGlobalVarRef>() != null) ? this.Var<IGlobalVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IOtherVarRef:
				_o.Var.Value = ((this.Var<IOtherVarRef>() != null) ? this.Var<IOtherVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISelfVarRef:
				_o.Var.Value = ((this.Var<ISelfVarRef>() != null) ? this.Var<ISelfVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISystemVarRef:
				_o.Var.Value = ((this.Var<ISystemVarRef>() != null) ? this.Var<ISystemVarRef>().Value.UnPack() : null);
				break;
			}
			_o.ShowAsWordArt = ((this.ShowAsWordArt != null) ? this.ShowAsWordArt.Value.UnPack() : null);
		}

		// Token: 0x06019187 RID: 102791 RVA: 0x003945D4 File Offset: 0x003927D4
		public static Offset<IQuestScheduleBtTreeVar> Pack(FlatBufferBuilder builder, IQuestScheduleBtTreeVarT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestScheduleBtTreeVar>);
			}
			TVarRef var_type = (_o.Var == null) ? TVarRef.NONE : _o.Var.Type;
			int varOffset = (_o.Var == null) ? 0 : TVarRefUnion.Pack(builder, _o.Var);
			Offset<IWordArtConfig> showAsWordArtOffset = (_o.ShowAsWordArt == null) ? default(Offset<IWordArtConfig>) : IWordArtConfig.Pack(builder, _o.ShowAsWordArt);
			return IQuestScheduleBtTreeVar.CreateIQuestScheduleBtTreeVar(builder, _o.Type, var_type, varOffset, showAsWordArtOffset);
		}

		// Token: 0x0400C517 RID: 50455
		private Table __p;
	}
}
