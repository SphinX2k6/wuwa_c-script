using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061D6 RID: 25046
	public struct IAwakeWithTransformVar : IFlatbufferObject
	{
		// Token: 0x1700BABE RID: 47806
		// (get) Token: 0x0602B2A4 RID: 176804 RVA: 0x005F324A File Offset: 0x005F144A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B2A5 RID: 176805 RVA: 0x005F3257 File Offset: 0x005F1457
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B2A6 RID: 176806 RVA: 0x005F3260 File Offset: 0x005F1460
		public static IAwakeWithTransformVar GetRootAsIAwakeWithTransformVar(ByteBuffer _bb)
		{
			return IAwakeWithTransformVar.GetRootAsIAwakeWithTransformVar(_bb, default(IAwakeWithTransformVar));
		}

		// Token: 0x0602B2A7 RID: 176807 RVA: 0x005F327C File Offset: 0x005F147C
		public static IAwakeWithTransformVar GetRootAsIAwakeWithTransformVar(ByteBuffer _bb, IAwakeWithTransformVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B2A8 RID: 176808 RVA: 0x005F3299 File Offset: 0x005F1499
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B2A9 RID: 176809 RVA: 0x005F32A8 File Offset: 0x005F14A8
		public IAwakeWithTransformVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BABF RID: 47807
		// (get) Token: 0x0602B2AA RID: 176810 RVA: 0x005F32B8 File Offset: 0x005F14B8
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

		// Token: 0x1700BAC0 RID: 47808
		// (get) Token: 0x0602B2AB RID: 176811 RVA: 0x005F32F4 File Offset: 0x005F14F4
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

		// Token: 0x0602B2AC RID: 176812 RVA: 0x005F3330 File Offset: 0x005F1530
		public TTable? TransformVar<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602B2AD RID: 176813 RVA: 0x005F3374 File Offset: 0x005F1574
		public IConstVarRef TransformVarAsIConstVarRef()
		{
			return this.TransformVar<IConstVarRef>().Value;
		}

		// Token: 0x0602B2AE RID: 176814 RVA: 0x005F3390 File Offset: 0x005F1590
		public IGlobalVarRef TransformVarAsIGlobalVarRef()
		{
			return this.TransformVar<IGlobalVarRef>().Value;
		}

		// Token: 0x0602B2AF RID: 176815 RVA: 0x005F33AC File Offset: 0x005F15AC
		public IOtherVarRef TransformVarAsIOtherVarRef()
		{
			return this.TransformVar<IOtherVarRef>().Value;
		}

		// Token: 0x0602B2B0 RID: 176816 RVA: 0x005F33C8 File Offset: 0x005F15C8
		public ISelfVarRef TransformVarAsISelfVarRef()
		{
			return this.TransformVar<ISelfVarRef>().Value;
		}

		// Token: 0x0602B2B1 RID: 176817 RVA: 0x005F33E4 File Offset: 0x005F15E4
		public ISystemVarRef TransformVarAsISystemVarRef()
		{
			return this.TransformVar<ISystemVarRef>().Value;
		}

		// Token: 0x0602B2B2 RID: 176818 RVA: 0x005F33FF File Offset: 0x005F15FF
		public static Offset<IAwakeWithTransformVar> CreateIAwakeWithTransformVar(FlatBufferBuilder builder, EAwakePosType Type = EAwakePosType.TransformVar, TVarRef TransformVar_type = TVarRef.NONE, int TransformVarOffset = 0)
		{
			builder.StartTable(3);
			IAwakeWithTransformVar.AddTransformVar(builder, TransformVarOffset);
			IAwakeWithTransformVar.AddTransformVarType(builder, TransformVar_type);
			IAwakeWithTransformVar.AddType(builder, Type);
			return IAwakeWithTransformVar.EndIAwakeWithTransformVar(builder);
		}

		// Token: 0x0602B2B3 RID: 176819 RVA: 0x005F3423 File Offset: 0x005F1623
		public static void StartIAwakeWithTransformVar(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602B2B4 RID: 176820 RVA: 0x005F342C File Offset: 0x005F162C
		public static void AddType(FlatBufferBuilder builder, EAwakePosType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B2B5 RID: 176821 RVA: 0x005F3437 File Offset: 0x005F1637
		public static void AddTransformVarType(FlatBufferBuilder builder, TVarRef transformVarType)
		{
			builder.AddByte(1, (byte)transformVarType, 0);
		}

		// Token: 0x0602B2B6 RID: 176822 RVA: 0x005F3442 File Offset: 0x005F1642
		public static void AddTransformVar(FlatBufferBuilder builder, int transformVarOffset)
		{
			builder.AddOffset(2, transformVarOffset, 0);
		}

		// Token: 0x0602B2B7 RID: 176823 RVA: 0x005F344D File Offset: 0x005F164D
		public static Offset<IAwakeWithTransformVar> EndIAwakeWithTransformVar(FlatBufferBuilder builder)
		{
			return new Offset<IAwakeWithTransformVar>(builder.EndTable());
		}

		// Token: 0x0602B2B8 RID: 176824 RVA: 0x005F345C File Offset: 0x005F165C
		public IAwakeWithTransformVarT UnPack()
		{
			IAwakeWithTransformVarT awakeWithTransformVarT = new IAwakeWithTransformVarT();
			this.UnPackTo(awakeWithTransformVarT);
			return awakeWithTransformVarT;
		}

		// Token: 0x0602B2B9 RID: 176825 RVA: 0x005F3478 File Offset: 0x005F1678
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

		// Token: 0x0602B2BA RID: 176826 RVA: 0x005F35E4 File Offset: 0x005F17E4
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

		// Token: 0x04010701 RID: 67329
		private Table __p;
	}
}
