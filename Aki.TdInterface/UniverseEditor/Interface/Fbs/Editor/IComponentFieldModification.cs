using System;
using Aki.UniverseEditor.Interface.Fbs.Component;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CA3 RID: 19619
	public struct IComponentFieldModification : IFlatbufferObject
	{
		// Token: 0x17008AFA RID: 35578
		// (get) Token: 0x0601E154 RID: 123220 RVA: 0x00437160 File Offset: 0x00435360
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E155 RID: 123221 RVA: 0x0043716D File Offset: 0x0043536D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E156 RID: 123222 RVA: 0x00437174 File Offset: 0x00435374
		public static IComponentFieldModification GetRootAsIComponentFieldModification(ByteBuffer _bb)
		{
			return IComponentFieldModification.GetRootAsIComponentFieldModification(_bb, default(IComponentFieldModification));
		}

		// Token: 0x0601E157 RID: 123223 RVA: 0x00437190 File Offset: 0x00435390
		public static IComponentFieldModification GetRootAsIComponentFieldModification(ByteBuffer _bb, IComponentFieldModification obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E158 RID: 123224 RVA: 0x004371AD File Offset: 0x004353AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E159 RID: 123225 RVA: 0x004371BC File Offset: 0x004353BC
		public IComponentFieldModification __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008AFB RID: 35579
		// (get) Token: 0x0601E15A RID: 123226 RVA: 0x004371CC File Offset: 0x004353CC
		public bool Enable
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008AFC RID: 35580
		// (get) Token: 0x0601E15B RID: 123227 RVA: 0x0043720C File Offset: 0x0043540C
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

		// Token: 0x17008AFD RID: 35581
		// (get) Token: 0x0601E15C RID: 123228 RVA: 0x00437248 File Offset: 0x00435448
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

		// Token: 0x0601E15D RID: 123229 RVA: 0x0043727F File Offset: 0x0043547F
		public Span<byte> GetFieldBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601E15E RID: 123230 RVA: 0x0043728E File Offset: 0x0043548E
		public byte[] GetFieldArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17008AFE RID: 35582
		// (get) Token: 0x0601E15F RID: 123231 RVA: 0x0043729C File Offset: 0x0043549C
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

		// Token: 0x0601E160 RID: 123232 RVA: 0x004372D4 File Offset: 0x004354D4
		public Span<byte> GetValueBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601E161 RID: 123233 RVA: 0x004372E4 File Offset: 0x004354E4
		public byte[] GetValueArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x0601E162 RID: 123234 RVA: 0x004372F3 File Offset: 0x004354F3
		public static Offset<IComponentFieldModification> CreateIComponentFieldModification(FlatBufferBuilder builder, bool Enable = false, EComponent Type = EComponent.AirWallSpawnerComponent, StringOffset FieldOffset = default(StringOffset), StringOffset ValueOffset = default(StringOffset))
		{
			builder.StartTable(4);
			IComponentFieldModification.AddValue(builder, ValueOffset);
			IComponentFieldModification.AddField(builder, FieldOffset);
			IComponentFieldModification.AddType(builder, Type);
			IComponentFieldModification.AddEnable(builder, Enable);
			return IComponentFieldModification.EndIComponentFieldModification(builder);
		}

		// Token: 0x0601E163 RID: 123235 RVA: 0x0043731F File Offset: 0x0043551F
		public static void StartIComponentFieldModification(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601E164 RID: 123236 RVA: 0x00437328 File Offset: 0x00435528
		public static void AddEnable(FlatBufferBuilder builder, bool enable)
		{
			builder.AddBool(0, enable, false);
		}

		// Token: 0x0601E165 RID: 123237 RVA: 0x00437333 File Offset: 0x00435533
		public static void AddType(FlatBufferBuilder builder, EComponent type)
		{
			builder.AddByte(1, (byte)type, 0);
		}

		// Token: 0x0601E166 RID: 123238 RVA: 0x0043733E File Offset: 0x0043553E
		public static void AddField(FlatBufferBuilder builder, StringOffset fieldOffset)
		{
			builder.AddOffset(2, fieldOffset.Value, 0);
		}

		// Token: 0x0601E167 RID: 123239 RVA: 0x0043734E File Offset: 0x0043554E
		public static void AddValue(FlatBufferBuilder builder, StringOffset valueOffset)
		{
			builder.AddOffset(3, valueOffset.Value, 0);
		}

		// Token: 0x0601E168 RID: 123240 RVA: 0x0043735E File Offset: 0x0043555E
		public static Offset<IComponentFieldModification> EndIComponentFieldModification(FlatBufferBuilder builder)
		{
			return new Offset<IComponentFieldModification>(builder.EndTable());
		}

		// Token: 0x0601E169 RID: 123241 RVA: 0x0043736C File Offset: 0x0043556C
		public IComponentFieldModificationT UnPack()
		{
			IComponentFieldModificationT componentFieldModificationT = new IComponentFieldModificationT();
			this.UnPackTo(componentFieldModificationT);
			return componentFieldModificationT;
		}

		// Token: 0x0601E16A RID: 123242 RVA: 0x00437387 File Offset: 0x00435587
		public void UnPackTo(IComponentFieldModificationT _o)
		{
			_o.Enable = this.Enable;
			_o.Type = this.Type;
			_o.Field = this.Field;
			_o.Value = this.Value;
		}

		// Token: 0x0601E16B RID: 123243 RVA: 0x004373BC File Offset: 0x004355BC
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

		// Token: 0x0400D7A1 RID: 55201
		private Table __p;
	}
}
