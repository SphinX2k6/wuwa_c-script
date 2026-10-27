using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004013 RID: 16403
	public struct IQuestScheduleBtTreeVar : IFlatbufferObject
	{
		// Token: 0x17007346 RID: 29510
		// (get) Token: 0x06017AD6 RID: 96982 RVA: 0x0036A38F File Offset: 0x0036858F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017AD7 RID: 96983 RVA: 0x0036A39C File Offset: 0x0036859C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017AD8 RID: 96984 RVA: 0x0036A3A4 File Offset: 0x003685A4
		public static IQuestScheduleBtTreeVar GetRootAsIQuestScheduleBtTreeVar(ByteBuffer _bb)
		{
			return IQuestScheduleBtTreeVar.GetRootAsIQuestScheduleBtTreeVar(_bb, default(IQuestScheduleBtTreeVar));
		}

		// Token: 0x06017AD9 RID: 96985 RVA: 0x0036A3C0 File Offset: 0x003685C0
		public static IQuestScheduleBtTreeVar GetRootAsIQuestScheduleBtTreeVar(ByteBuffer _bb, IQuestScheduleBtTreeVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017ADA RID: 96986 RVA: 0x0036A3DD File Offset: 0x003685DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017ADB RID: 96987 RVA: 0x0036A3EC File Offset: 0x003685EC
		public IQuestScheduleBtTreeVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007347 RID: 29511
		// (get) Token: 0x06017ADC RID: 96988 RVA: 0x0036A3FC File Offset: 0x003685FC
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

		// Token: 0x17007348 RID: 29512
		// (get) Token: 0x06017ADD RID: 96989 RVA: 0x0036A438 File Offset: 0x00368638
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

		// Token: 0x06017ADE RID: 96990 RVA: 0x0036A474 File Offset: 0x00368674
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017ADF RID: 96991 RVA: 0x0036A4B8 File Offset: 0x003686B8
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x06017AE0 RID: 96992 RVA: 0x0036A4D4 File Offset: 0x003686D4
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x06017AE1 RID: 96993 RVA: 0x0036A4F0 File Offset: 0x003686F0
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x06017AE2 RID: 96994 RVA: 0x0036A50C File Offset: 0x0036870C
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x06017AE3 RID: 96995 RVA: 0x0036A528 File Offset: 0x00368728
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x17007349 RID: 29513
		// (get) Token: 0x06017AE4 RID: 96996 RVA: 0x0036A544 File Offset: 0x00368744
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

		// Token: 0x06017AE5 RID: 96997 RVA: 0x0036A5A2 File Offset: 0x003687A2
		public static Offset<IQuestScheduleBtTreeVar> CreateIQuestScheduleBtTreeVar(FlatBufferBuilder builder, EQuestScheduleType Type = EQuestScheduleType.None, TVarRef Var_type = TVarRef.NONE, int VarOffset = 0, Offset<IWordArtConfig> ShowAsWordArtOffset = default(Offset<IWordArtConfig>))
		{
			builder.StartTable(4);
			IQuestScheduleBtTreeVar.AddShowAsWordArt(builder, ShowAsWordArtOffset);
			IQuestScheduleBtTreeVar.AddVar(builder, VarOffset);
			IQuestScheduleBtTreeVar.AddVarType(builder, Var_type);
			IQuestScheduleBtTreeVar.AddType(builder, Type);
			return IQuestScheduleBtTreeVar.EndIQuestScheduleBtTreeVar(builder);
		}

		// Token: 0x06017AE6 RID: 96998 RVA: 0x0036A5CE File Offset: 0x003687CE
		public static void StartIQuestScheduleBtTreeVar(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06017AE7 RID: 96999 RVA: 0x0036A5D7 File Offset: 0x003687D7
		public static void AddType(FlatBufferBuilder builder, EQuestScheduleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017AE8 RID: 97000 RVA: 0x0036A5E2 File Offset: 0x003687E2
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x06017AE9 RID: 97001 RVA: 0x0036A5ED File Offset: 0x003687ED
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x06017AEA RID: 97002 RVA: 0x0036A5F8 File Offset: 0x003687F8
		public static void AddShowAsWordArt(FlatBufferBuilder builder, Offset<IWordArtConfig> showAsWordArtOffset)
		{
			builder.AddOffset(3, showAsWordArtOffset.Value, 0);
		}

		// Token: 0x06017AEB RID: 97003 RVA: 0x0036A608 File Offset: 0x00368808
		public static Offset<IQuestScheduleBtTreeVar> EndIQuestScheduleBtTreeVar(FlatBufferBuilder builder)
		{
			return new Offset<IQuestScheduleBtTreeVar>(builder.EndTable());
		}

		// Token: 0x06017AEC RID: 97004 RVA: 0x0036A618 File Offset: 0x00368818
		public IQuestScheduleBtTreeVarT UnPack()
		{
			IQuestScheduleBtTreeVarT questScheduleBtTreeVarT = new IQuestScheduleBtTreeVarT();
			this.UnPackTo(questScheduleBtTreeVarT);
			return questScheduleBtTreeVarT;
		}

		// Token: 0x06017AED RID: 97005 RVA: 0x0036A634 File Offset: 0x00368834
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

		// Token: 0x06017AEE RID: 97006 RVA: 0x0036A7E0 File Offset: 0x003689E0
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

		// Token: 0x0400BB30 RID: 47920
		private Table __p;
	}
}
