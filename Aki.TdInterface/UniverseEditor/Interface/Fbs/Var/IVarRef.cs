using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B17 RID: 15127
	public struct IVarRef : IFlatbufferObject
	{
		// Token: 0x170067C6 RID: 26566
		// (get) Token: 0x06014A5D RID: 84573 RVA: 0x00301551 File Offset: 0x002FF751
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014A5E RID: 84574 RVA: 0x0030155E File Offset: 0x002FF75E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014A5F RID: 84575 RVA: 0x00301568 File Offset: 0x002FF768
		public static IVarRef GetRootAsIVarRef(ByteBuffer _bb)
		{
			return IVarRef.GetRootAsIVarRef(_bb, default(IVarRef));
		}

		// Token: 0x06014A60 RID: 84576 RVA: 0x00301584 File Offset: 0x002FF784
		public static IVarRef GetRootAsIVarRef(ByteBuffer _bb, IVarRef obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014A61 RID: 84577 RVA: 0x003015A1 File Offset: 0x002FF7A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014A62 RID: 84578 RVA: 0x003015B0 File Offset: 0x002FF7B0
		public IVarRef __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170067C7 RID: 26567
		// (get) Token: 0x06014A63 RID: 84579 RVA: 0x003015C0 File Offset: 0x002FF7C0
		public EVar Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVar.Boolean;
				}
				return (EVar)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170067C8 RID: 26568
		// (get) Token: 0x06014A64 RID: 84580 RVA: 0x003015FC File Offset: 0x002FF7FC
		public EVarRefSource Source
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EVarRefSource.Constant;
				}
				return (EVarRefSource)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014A65 RID: 84581 RVA: 0x00301638 File Offset: 0x002FF838
		public static Offset<IVarRef> CreateIVarRef(FlatBufferBuilder builder, EVar Type = EVar.Boolean, EVarRefSource Source = EVarRefSource.Constant)
		{
			builder.StartTable(2);
			IVarRef.AddSource(builder, Source);
			IVarRef.AddType(builder, Type);
			return IVarRef.EndIVarRef(builder);
		}

		// Token: 0x06014A66 RID: 84582 RVA: 0x00301655 File Offset: 0x002FF855
		public static void StartIVarRef(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06014A67 RID: 84583 RVA: 0x0030165E File Offset: 0x002FF85E
		public static void AddType(FlatBufferBuilder builder, EVar type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014A68 RID: 84584 RVA: 0x00301669 File Offset: 0x002FF869
		public static void AddSource(FlatBufferBuilder builder, EVarRefSource source)
		{
			builder.AddByte(1, (byte)source, 0);
		}

		// Token: 0x06014A69 RID: 84585 RVA: 0x00301674 File Offset: 0x002FF874
		public static Offset<IVarRef> EndIVarRef(FlatBufferBuilder builder)
		{
			return new Offset<IVarRef>(builder.EndTable());
		}

		// Token: 0x06014A6A RID: 84586 RVA: 0x00301684 File Offset: 0x002FF884
		public IVarRefT UnPack()
		{
			IVarRefT varRefT = new IVarRefT();
			this.UnPackTo(varRefT);
			return varRefT;
		}

		// Token: 0x06014A6B RID: 84587 RVA: 0x0030169F File Offset: 0x002FF89F
		public void UnPackTo(IVarRefT _o)
		{
			_o.Type = this.Type;
			_o.Source = this.Source;
		}

		// Token: 0x06014A6C RID: 84588 RVA: 0x003016BC File Offset: 0x002FF8BC
		public static Offset<IVarRef> Pack(FlatBufferBuilder builder, IVarRefT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVarRef>);
			}
			return IVarRef.CreateIVarRef(builder, _o.Type, _o.Source);
		}

		// Token: 0x0400AFE5 RID: 45029
		private Table __p;
	}
}
