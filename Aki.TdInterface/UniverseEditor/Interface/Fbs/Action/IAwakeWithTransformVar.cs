using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006844 RID: 26692
	public struct IAwakeWithTransformVar : IFlatbufferObject
	{
		// Token: 0x1700C441 RID: 50241
		// (get) Token: 0x0602D9EB RID: 186859 RVA: 0x0063DCBE File Offset: 0x0063BEBE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D9EC RID: 186860 RVA: 0x0063DCCB File Offset: 0x0063BECB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D9ED RID: 186861 RVA: 0x0063DCD4 File Offset: 0x0063BED4
		public static IAwakeWithTransformVar GetRootAsIAwakeWithTransformVar(ByteBuffer _bb)
		{
			return IAwakeWithTransformVar.GetRootAsIAwakeWithTransformVar(_bb, default(IAwakeWithTransformVar));
		}

		// Token: 0x0602D9EE RID: 186862 RVA: 0x0063DCF0 File Offset: 0x0063BEF0
		public static IAwakeWithTransformVar GetRootAsIAwakeWithTransformVar(ByteBuffer _bb, IAwakeWithTransformVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D9EF RID: 186863 RVA: 0x0063DD0D File Offset: 0x0063BF0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D9F0 RID: 186864 RVA: 0x0063DD1C File Offset: 0x0063BF1C
		public IAwakeWithTransformVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C442 RID: 50242
		// (get) Token: 0x0602D9F1 RID: 186865 RVA: 0x0063DD2C File Offset: 0x0063BF2C
		public EAwakePosType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAwakePosType.TransformVar;
				}
				return (EAwakePosType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C443 RID: 50243
		// (get) Token: 0x0602D9F2 RID: 186866 RVA: 0x0063DD68 File Offset: 0x0063BF68
		public TVarRef TransformVarType
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

		// Token: 0x0602D9F3 RID: 186867 RVA: 0x0063DDA4 File Offset: 0x0063BFA4
		public TTable? TransformVar<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602D9F4 RID: 186868 RVA: 0x0063DDE8 File Offset: 0x0063BFE8
		public IConstVarRef TransformVarAsIConstVarRef()
		{
			return this.TransformVar<IConstVarRef>().Value;
		}

		// Token: 0x0602D9F5 RID: 186869 RVA: 0x0063DE04 File Offset: 0x0063C004
		public IGlobalVarRef TransformVarAsIGlobalVarRef()
		{
			return this.TransformVar<IGlobalVarRef>().Value;
		}

		// Token: 0x0602D9F6 RID: 186870 RVA: 0x0063DE20 File Offset: 0x0063C020
		public IOtherVarRef TransformVarAsIOtherVarRef()
		{
			return this.TransformVar<IOtherVarRef>().Value;
		}

		// Token: 0x0602D9F7 RID: 186871 RVA: 0x0063DE3C File Offset: 0x0063C03C
		public ISelfVarRef TransformVarAsISelfVarRef()
		{
			return this.TransformVar<ISelfVarRef>().Value;
		}

		// Token: 0x0602D9F8 RID: 186872 RVA: 0x0063DE58 File Offset: 0x0063C058
		public ISystemVarRef TransformVarAsISystemVarRef()
		{
			return this.TransformVar<ISystemVarRef>().Value;
		}

		// Token: 0x0602D9F9 RID: 186873 RVA: 0x0063DE73 File Offset: 0x0063C073
		public static Offset<IAwakeWithTransformVar> CreateIAwakeWithTransformVar(FlatBufferBuilder builder, EAwakePosType Type = EAwakePosType.TransformVar, TVarRef TransformVar_type = TVarRef.NONE, int TransformVarOffset = 0)
		{
			builder.StartTable(3);
			IAwakeWithTransformVar.AddTransformVar(builder, TransformVarOffset);
			IAwakeWithTransformVar.AddTransformVarType(builder, TransformVar_type);
			IAwakeWithTransformVar.AddType(builder, Type);
			return IAwakeWithTransformVar.EndIAwakeWithTransformVar(builder);
		}

		// Token: 0x0602D9FA RID: 186874 RVA: 0x0063DE97 File Offset: 0x0063C097
		public static void StartIAwakeWithTransformVar(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602D9FB RID: 186875 RVA: 0x0063DEA0 File Offset: 0x0063C0A0
		public static void AddType(FlatBufferBuilder builder, EAwakePosType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D9FC RID: 186876 RVA: 0x0063DEAB File Offset: 0x0063C0AB
		public static void AddTransformVarType(FlatBufferBuilder builder, TVarRef transformVarType)
		{
			builder.AddByte(1, (byte)transformVarType, 0);
		}

		// Token: 0x0602D9FD RID: 186877 RVA: 0x0063DEB6 File Offset: 0x0063C0B6
		public static void AddTransformVar(FlatBufferBuilder builder, int transformVarOffset)
		{
			builder.AddOffset(2, transformVarOffset, 0);
		}

		// Token: 0x0602D9FE RID: 186878 RVA: 0x0063DEC1 File Offset: 0x0063C0C1
		public static Offset<IAwakeWithTransformVar> EndIAwakeWithTransformVar(FlatBufferBuilder builder)
		{
			return new Offset<IAwakeWithTransformVar>(builder.EndTable());
		}

		// Token: 0x0602D9FF RID: 186879 RVA: 0x0063DED0 File Offset: 0x0063C0D0
		public IAwakeWithTransformVarT UnPack()
		{
			IAwakeWithTransformVarT awakeWithTransformVarT = new IAwakeWithTransformVarT();
			this.UnPackTo(awakeWithTransformVarT);
			return awakeWithTransformVarT;
		}

		// Token: 0x0602DA00 RID: 186880 RVA: 0x0063DEEC File Offset: 0x0063C0EC
		public void UnPackTo(IAwakeWithTransformVarT _o)
		{
			_o.Type = this.Type;
			_o.TransformVar = new TVarRefUnion();
			_o.TransformVar.Type = this.TransformVarType;
			switch (this.TransformVarType)
			{
			case TVarRef.IConstVarRef:
				_o.TransformVar.Value = ((this.TransformVar<IConstVarRef>() != null) ? this.TransformVar<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.TransformVar.Value = ((this.TransformVar<IGlobalVarRef>() != null) ? this.TransformVar<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.TransformVar.Value = ((this.TransformVar<IOtherVarRef>() != null) ? this.TransformVar<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.TransformVar.Value = ((this.TransformVar<ISelfVarRef>() != null) ? this.TransformVar<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.TransformVar.Value = ((this.TransformVar<ISystemVarRef>() != null) ? this.TransformVar<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0602DA01 RID: 186881 RVA: 0x0063E058 File Offset: 0x0063C258
		public static Offset<IAwakeWithTransformVar> Pack(FlatBufferBuilder builder, IAwakeWithTransformVarT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAwakeWithTransformVar>);
			}
			TVarRef transformVar_type = (_o.TransformVar == null) ? TVarRef.NONE : _o.TransformVar.Type;
			int transformVarOffset = (_o.TransformVar == null) ? 0 : TVarRefUnion.Pack(builder, _o.TransformVar);
			return IAwakeWithTransformVar.CreateIAwakeWithTransformVar(builder, _o.Type, transformVar_type, transformVarOffset);
		}

		// Token: 0x04011513 RID: 70931
		private Table __p;
	}
}
