using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007938 RID: 31032
	public struct ISpawnChild : IFlatbufferObject
	{
		// Token: 0x1700E3A0 RID: 58272
		// (get) Token: 0x06036A58 RID: 223832 RVA: 0x0074FEA0 File Offset: 0x0074E0A0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036A59 RID: 223833 RVA: 0x0074FEAD File Offset: 0x0074E0AD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036A5A RID: 223834 RVA: 0x0074FEB4 File Offset: 0x0074E0B4
		public static ISpawnChild GetRootAsISpawnChild(ByteBuffer _bb)
		{
			return ISpawnChild.GetRootAsISpawnChild(_bb, default(ISpawnChild));
		}

		// Token: 0x06036A5B RID: 223835 RVA: 0x0074FED0 File Offset: 0x0074E0D0
		public static ISpawnChild GetRootAsISpawnChild(ByteBuffer _bb, ISpawnChild obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036A5C RID: 223836 RVA: 0x0074FEED File Offset: 0x0074E0ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036A5D RID: 223837 RVA: 0x0074FEFC File Offset: 0x0074E0FC
		public ISpawnChild __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E3A1 RID: 58273
		// (get) Token: 0x06036A5E RID: 223838 RVA: 0x0074FF0C File Offset: 0x0074E10C
		public string TemplateGuid
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036A5F RID: 223839 RVA: 0x0074FF43 File Offset: 0x0074E143
		public Span<byte> GetTemplateGuidBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06036A60 RID: 223840 RVA: 0x0074FF52 File Offset: 0x0074E152
		public byte[] GetTemplateGuidArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700E3A2 RID: 58274
		// (get) Token: 0x06036A61 RID: 223841 RVA: 0x0074FF60 File Offset: 0x0074E160
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

		// Token: 0x06036A62 RID: 223842 RVA: 0x0074FFBD File Offset: 0x0074E1BD
		public static Offset<ISpawnChild> CreateISpawnChild(FlatBufferBuilder builder, StringOffset TemplateGuidOffset = default(StringOffset), Offset<ITransform> TransformOffset = default(Offset<ITransform>))
		{
			builder.StartTable(2);
			ISpawnChild.AddTransform(builder, TransformOffset);
			ISpawnChild.AddTemplateGuid(builder, TemplateGuidOffset);
			return ISpawnChild.EndISpawnChild(builder);
		}

		// Token: 0x06036A63 RID: 223843 RVA: 0x0074FFDA File Offset: 0x0074E1DA
		public static void StartISpawnChild(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06036A64 RID: 223844 RVA: 0x0074FFE3 File Offset: 0x0074E1E3
		public static void AddTemplateGuid(FlatBufferBuilder builder, StringOffset templateGuidOffset)
		{
			builder.AddOffset(0, templateGuidOffset.Value, 0);
		}

		// Token: 0x06036A65 RID: 223845 RVA: 0x0074FFF3 File Offset: 0x0074E1F3
		public static void AddTransform(FlatBufferBuilder builder, Offset<ITransform> transformOffset)
		{
			builder.AddOffset(1, transformOffset.Value, 0);
		}

		// Token: 0x06036A66 RID: 223846 RVA: 0x00750003 File Offset: 0x0074E203
		public static Offset<ISpawnChild> EndISpawnChild(FlatBufferBuilder builder)
		{
			return new Offset<ISpawnChild>(builder.EndTable());
		}

		// Token: 0x06036A67 RID: 223847 RVA: 0x00750010 File Offset: 0x0074E210
		public ISpawnChildT UnPack()
		{
			ISpawnChildT spawnChildT = new ISpawnChildT();
			this.UnPackTo(spawnChildT);
			return spawnChildT;
		}

		// Token: 0x06036A68 RID: 223848 RVA: 0x0075002C File Offset: 0x0074E22C
		public void UnPackTo(ISpawnChildT _o)
		{
			_o.TemplateGuid = this.TemplateGuid;
			_o.Transform = ((this.Transform != null) ? this.Transform.Value.UnPack() : null);
		}

		// Token: 0x06036A69 RID: 223849 RVA: 0x00750074 File Offset: 0x0074E274
		public static Offset<ISpawnChild> Pack(FlatBufferBuilder builder, ISpawnChildT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpawnChild>);
			}
			StringOffset templateGuidOffset = (_o.TemplateGuid == null) ? default(StringOffset) : builder.CreateString(_o.TemplateGuid);
			Offset<ITransform> transformOffset = (_o.Transform == null) ? default(Offset<ITransform>) : ITransform.Pack(builder, _o.Transform);
			return ISpawnChild.CreateISpawnChild(builder, templateGuidOffset, transformOffset);
		}

		// Token: 0x04012BFE RID: 76798
		private Table __p;
	}
}
