using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AAB RID: 15019
	public struct IParamsPreset : IFlatbufferObject
	{
		// Token: 0x170066FF RID: 26367
		// (get) Token: 0x06014682 RID: 83586 RVA: 0x002F9B14 File Offset: 0x002F7D14
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014683 RID: 83587 RVA: 0x002F9B21 File Offset: 0x002F7D21
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014684 RID: 83588 RVA: 0x002F9B28 File Offset: 0x002F7D28
		public static IParamsPreset GetRootAsIParamsPreset(ByteBuffer _bb)
		{
			return IParamsPreset.GetRootAsIParamsPreset(_bb, default(IParamsPreset));
		}

		// Token: 0x06014685 RID: 83589 RVA: 0x002F9B44 File Offset: 0x002F7D44
		public static IParamsPreset GetRootAsIParamsPreset(ByteBuffer _bb, IParamsPreset obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014686 RID: 83590 RVA: 0x002F9B61 File Offset: 0x002F7D61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014687 RID: 83591 RVA: 0x002F9B70 File Offset: 0x002F7D70
		public IParamsPreset __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006700 RID: 26368
		// (get) Token: 0x06014688 RID: 83592 RVA: 0x002F9B80 File Offset: 0x002F7D80
		public EParamsPreset Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EParamsPreset.Decal;
				}
				return (EParamsPreset)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014689 RID: 83593 RVA: 0x002F9BBC File Offset: 0x002F7DBC
		public static Offset<IParamsPreset> CreateIParamsPreset(FlatBufferBuilder builder, EParamsPreset Type = EParamsPreset.Decal)
		{
			builder.StartTable(1);
			IParamsPreset.AddType(builder, Type);
			return IParamsPreset.EndIParamsPreset(builder);
		}

		// Token: 0x0601468A RID: 83594 RVA: 0x002F9BD2 File Offset: 0x002F7DD2
		public static void StartIParamsPreset(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601468B RID: 83595 RVA: 0x002F9BDB File Offset: 0x002F7DDB
		public static void AddType(FlatBufferBuilder builder, EParamsPreset type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601468C RID: 83596 RVA: 0x002F9BE6 File Offset: 0x002F7DE6
		public static Offset<IParamsPreset> EndIParamsPreset(FlatBufferBuilder builder)
		{
			return new Offset<IParamsPreset>(builder.EndTable());
		}

		// Token: 0x0601468D RID: 83597 RVA: 0x002F9BF4 File Offset: 0x002F7DF4
		public IParamsPresetT UnPack()
		{
			IParamsPresetT paramsPresetT = new IParamsPresetT();
			this.UnPackTo(paramsPresetT);
			return paramsPresetT;
		}

		// Token: 0x0601468E RID: 83598 RVA: 0x002F9C0F File Offset: 0x002F7E0F
		public void UnPackTo(IParamsPresetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601468F RID: 83599 RVA: 0x002F9C20 File Offset: 0x002F7E20
		public static Offset<IParamsPreset> Pack(FlatBufferBuilder builder, IParamsPresetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IParamsPreset>);
			}
			return IParamsPreset.CreateIParamsPreset(builder, _o.Type);
		}

		// Token: 0x0400AF39 RID: 44857
		private Table __p;
	}
}
