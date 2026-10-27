using System;
using Aki.UniverseEditor.Interface.Fbs.Component;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200483B RID: 18491
	public struct IComponentFieldModification : IFlatbufferObject
	{
		// Token: 0x170084AF RID: 33967
		// (get) Token: 0x0601C957 RID: 117079 RVA: 0x0040A810 File Offset: 0x00408A10
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C958 RID: 117080 RVA: 0x0040A81D File Offset: 0x00408A1D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C959 RID: 117081 RVA: 0x0040A824 File Offset: 0x00408A24
		public static IComponentFieldModification GetRootAsIComponentFieldModification(ByteBuffer _bb)
		{
			return IComponentFieldModification.GetRootAsIComponentFieldModification(_bb, default(IComponentFieldModification));
		}

		// Token: 0x0601C95A RID: 117082 RVA: 0x0040A840 File Offset: 0x00408A40
		public static IComponentFieldModification GetRootAsIComponentFieldModification(ByteBuffer _bb, IComponentFieldModification obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C95B RID: 117083 RVA: 0x0040A85D File Offset: 0x00408A5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C95C RID: 117084 RVA: 0x0040A86C File Offset: 0x00408A6C
		public IComponentFieldModification __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170084B0 RID: 33968
		// (get) Token: 0x0601C95D RID: 117085 RVA: 0x0040A87C File Offset: 0x00408A7C
		public bool Enable
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170084B1 RID: 33969
		// (get) Token: 0x0601C95E RID: 117086 RVA: 0x0040A8BC File Offset: 0x00408ABC
		public EComponent Type
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EComponent.AirWallSpawnerComponent;
				}
				return (EComponent)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170084B2 RID: 33970
		// (get) Token: 0x0601C95F RID: 117087 RVA: 0x0040A8F8 File Offset: 0x00408AF8
		public string Field
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C960 RID: 117088 RVA: 0x0040A92F File Offset: 0x00408B2F
		public Span<byte> GetFieldBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601C961 RID: 117089 RVA: 0x0040A93E File Offset: 0x00408B3E
		public byte[] GetFieldArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x170084B3 RID: 33971
		// (get) Token: 0x0601C962 RID: 117090 RVA: 0x0040A94C File Offset: 0x00408B4C
		public string Value
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C963 RID: 117091 RVA: 0x0040A984 File Offset: 0x00408B84
		public Span<byte> GetValueBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601C964 RID: 117092 RVA: 0x0040A994 File Offset: 0x00408B94
		public byte[] GetValueArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x0601C965 RID: 117093 RVA: 0x0040A9A3 File Offset: 0x00408BA3
		public static Offset<IComponentFieldModification> CreateIComponentFieldModification(FlatBufferBuilder builder, bool Enable = false, EComponent Type = EComponent.AirWallSpawnerComponent, StringOffset FieldOffset = default(StringOffset), StringOffset ValueOffset = default(StringOffset))
		{
			builder.StartTable(4);
			IComponentFieldModification.AddValue(builder, ValueOffset);
			IComponentFieldModification.AddField(builder, FieldOffset);
			IComponentFieldModification.AddType(builder, Type);
			IComponentFieldModification.AddEnable(builder, Enable);
			return IComponentFieldModification.EndIComponentFieldModification(builder);
		}

		// Token: 0x0601C966 RID: 117094 RVA: 0x0040A9CF File Offset: 0x00408BCF
		public static void StartIComponentFieldModification(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601C967 RID: 117095 RVA: 0x0040A9D8 File Offset: 0x00408BD8
		public static void AddEnable(FlatBufferBuilder builder, bool enable)
		{
			builder.AddBool(0, enable, false);
		}

		// Token: 0x0601C968 RID: 117096 RVA: 0x0040A9E3 File Offset: 0x00408BE3
		public static void AddType(FlatBufferBuilder builder, EComponent type)
		{
			builder.AddByte(1, (byte)type, 0);
		}

		// Token: 0x0601C969 RID: 117097 RVA: 0x0040A9EE File Offset: 0x00408BEE
		public static void AddField(FlatBufferBuilder builder, StringOffset fieldOffset)
		{
			builder.AddOffset(2, fieldOffset.Value, 0);
		}

		// Token: 0x0601C96A RID: 117098 RVA: 0x0040A9FE File Offset: 0x00408BFE
		public static void AddValue(FlatBufferBuilder builder, StringOffset valueOffset)
		{
			builder.AddOffset(3, valueOffset.Value, 0);
		}

		// Token: 0x0601C96B RID: 117099 RVA: 0x0040AA0E File Offset: 0x00408C0E
		public static Offset<IComponentFieldModification> EndIComponentFieldModification(FlatBufferBuilder builder)
		{
			return new Offset<IComponentFieldModification>(builder.EndTable());
		}

		// Token: 0x0601C96C RID: 117100 RVA: 0x0040AA1C File Offset: 0x00408C1C
		public IComponentFieldModificationT UnPack()
		{
			IComponentFieldModificationT componentFieldModificationT = new IComponentFieldModificationT();
			this.UnPackTo(componentFieldModificationT);
			return componentFieldModificationT;
		}

		// Token: 0x0601C96D RID: 117101 RVA: 0x0040AA37 File Offset: 0x00408C37
		public void UnPackTo(IComponentFieldModificationT _o)
		{
			_o.Enable = this.Enable;
			_o.Type = this.Type;
			_o.Field = this.Field;
			_o.Value = this.Value;
		}

		// Token: 0x0601C96E RID: 117102 RVA: 0x0040AA6C File Offset: 0x00408C6C
		public static Offset<IComponentFieldModification> Pack(FlatBufferBuilder builder, IComponentFieldModificationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IComponentFieldModification>);
			}
			StringOffset fieldOffset = (_o.Field == null) ? default(StringOffset) : builder.CreateString(_o.Field);
			StringOffset valueOffset = (_o.Value == null) ? default(StringOffset) : builder.CreateString(_o.Value);
			return IComponentFieldModification.CreateIComponentFieldModification(builder, _o.Enable, _o.Type, fieldOffset, valueOffset);
		}

		// Token: 0x0400CD66 RID: 52582
		private Table __p;
	}
}
