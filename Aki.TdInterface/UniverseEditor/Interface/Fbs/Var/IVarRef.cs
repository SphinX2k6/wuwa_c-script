using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F19 RID: 16153
	public struct IVarRef : IFlatbufferObject
	{
		// Token: 0x17006D61 RID: 28001
		// (get) Token: 0x06015F07 RID: 89863 RVA: 0x003277E1 File Offset: 0x003259E1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015F08 RID: 89864 RVA: 0x003277EE File Offset: 0x003259EE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015F09 RID: 89865 RVA: 0x003277F8 File Offset: 0x003259F8
		public static IVarRef GetRootAsIVarRef(ByteBuffer _bb)
		{
			return IVarRef.GetRootAsIVarRef(_bb, default(IVarRef));
		}

		// Token: 0x06015F0A RID: 89866 RVA: 0x00327814 File Offset: 0x00325A14
		public static IVarRef GetRootAsIVarRef(ByteBuffer _bb, IVarRef obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015F0B RID: 89867 RVA: 0x00327831 File Offset: 0x00325A31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015F0C RID: 89868 RVA: 0x00327840 File Offset: 0x00325A40
		public IVarRef __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D62 RID: 28002
		// (get) Token: 0x06015F0D RID: 89869 RVA: 0x00327850 File Offset: 0x00325A50
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

		// Token: 0x17006D63 RID: 28003
		// (get) Token: 0x06015F0E RID: 89870 RVA: 0x0032788C File Offset: 0x00325A8C
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

		// Token: 0x06015F0F RID: 89871 RVA: 0x003278C8 File Offset: 0x00325AC8
		public static Offset<IVarRef> CreateIVarRef(FlatBufferBuilder builder, EVar Type = EVar.Boolean, EVarRefSource Source = EVarRefSource.Constant)
		{
			builder.StartTable(2);
			IVarRef.AddSource(builder, Source);
			IVarRef.AddType(builder, Type);
			return IVarRef.EndIVarRef(builder);
		}

		// Token: 0x06015F10 RID: 89872 RVA: 0x003278E5 File Offset: 0x00325AE5
		public static void StartIVarRef(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06015F11 RID: 89873 RVA: 0x003278EE File Offset: 0x00325AEE
		public static void AddType(FlatBufferBuilder builder, EVar type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015F12 RID: 89874 RVA: 0x003278F9 File Offset: 0x00325AF9
		public static void AddSource(FlatBufferBuilder builder, EVarRefSource source)
		{
			builder.AddByte(1, (byte)source, 0);
		}

		// Token: 0x06015F13 RID: 89875 RVA: 0x00327904 File Offset: 0x00325B04
		public static Offset<IVarRef> EndIVarRef(FlatBufferBuilder builder)
		{
			return new Offset<IVarRef>(builder.EndTable());
		}

		// Token: 0x06015F14 RID: 89876 RVA: 0x00327914 File Offset: 0x00325B14
		public IVarRefT UnPack()
		{
			IVarRefT varRefT = new IVarRefT();
			this.UnPackTo(varRefT);
			return varRefT;
		}

		// Token: 0x06015F15 RID: 89877 RVA: 0x0032792F File Offset: 0x00325B2F
		public void UnPackTo(IVarRefT _o)
		{
			_o.Type = this.Type;
			_o.Source = this.Source;
		}

		// Token: 0x06015F16 RID: 89878 RVA: 0x0032794C File Offset: 0x00325B4C
		public static Offset<IVarRef> Pack(FlatBufferBuilder builder, IVarRefT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVarRef>);
			}
			return IVarRef.CreateIVarRef(builder, _o.Type, _o.Source);
		}

		// Token: 0x0400B952 RID: 47442
		private Table __p;
	}
}
