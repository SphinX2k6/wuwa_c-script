using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065A9 RID: 26025
	public struct IDestroySummonedVehicle : IFlatbufferObject
	{
		// Token: 0x1700C13E RID: 49470
		// (get) Token: 0x0602D249 RID: 184905 RVA: 0x00630DDA File Offset: 0x0062EFDA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D24A RID: 184906 RVA: 0x00630DE7 File Offset: 0x0062EFE7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D24B RID: 184907 RVA: 0x00630DF0 File Offset: 0x0062EFF0
		public static IDestroySummonedVehicle GetRootAsIDestroySummonedVehicle(ByteBuffer _bb)
		{
			return IDestroySummonedVehicle.GetRootAsIDestroySummonedVehicle(_bb, default(IDestroySummonedVehicle));
		}

		// Token: 0x0602D24C RID: 184908 RVA: 0x00630E0C File Offset: 0x0062F00C
		public static IDestroySummonedVehicle GetRootAsIDestroySummonedVehicle(ByteBuffer _bb, IDestroySummonedVehicle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D24D RID: 184909 RVA: 0x00630E29 File Offset: 0x0062F029
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D24E RID: 184910 RVA: 0x00630E38 File Offset: 0x0062F038
		public IDestroySummonedVehicle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C13F RID: 49471
		// (get) Token: 0x0602D24F RID: 184911 RVA: 0x00630E48 File Offset: 0x0062F048
		public ESummonEntityType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESummonEntityType.Vehicle;
				}
				return (ESummonEntityType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C140 RID: 49472
		// (get) Token: 0x0602D250 RID: 184912 RVA: 0x00630E84 File Offset: 0x0062F084
		public string TemplateId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D251 RID: 184913 RVA: 0x00630EBB File Offset: 0x0062F0BB
		public Span<byte> GetTemplateIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602D252 RID: 184914 RVA: 0x00630ECA File Offset: 0x0062F0CA
		public byte[] GetTemplateIdArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602D253 RID: 184915 RVA: 0x00630ED8 File Offset: 0x0062F0D8
		public static Offset<IDestroySummonedVehicle> CreateIDestroySummonedVehicle(FlatBufferBuilder builder, ESummonEntityType Type = ESummonEntityType.Vehicle, StringOffset TemplateIdOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IDestroySummonedVehicle.AddTemplateId(builder, TemplateIdOffset);
			IDestroySummonedVehicle.AddType(builder, Type);
			return IDestroySummonedVehicle.EndIDestroySummonedVehicle(builder);
		}

		// Token: 0x0602D254 RID: 184916 RVA: 0x00630EF5 File Offset: 0x0062F0F5
		public static void StartIDestroySummonedVehicle(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602D255 RID: 184917 RVA: 0x00630EFE File Offset: 0x0062F0FE
		public static void AddType(FlatBufferBuilder builder, ESummonEntityType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D256 RID: 184918 RVA: 0x00630F09 File Offset: 0x0062F109
		public static void AddTemplateId(FlatBufferBuilder builder, StringOffset templateIdOffset)
		{
			builder.AddOffset(1, templateIdOffset.Value, 0);
		}

		// Token: 0x0602D257 RID: 184919 RVA: 0x00630F19 File Offset: 0x0062F119
		public static Offset<IDestroySummonedVehicle> EndIDestroySummonedVehicle(FlatBufferBuilder builder)
		{
			return new Offset<IDestroySummonedVehicle>(builder.EndTable());
		}

		// Token: 0x0602D258 RID: 184920 RVA: 0x00630F28 File Offset: 0x0062F128
		public IDestroySummonedVehicleT UnPack()
		{
			IDestroySummonedVehicleT destroySummonedVehicleT = new IDestroySummonedVehicleT();
			this.UnPackTo(destroySummonedVehicleT);
			return destroySummonedVehicleT;
		}

		// Token: 0x0602D259 RID: 184921 RVA: 0x00630F43 File Offset: 0x0062F143
		public void UnPackTo(IDestroySummonedVehicleT _o)
		{
			_o.Type = this.Type;
			_o.TemplateId = this.TemplateId;
		}

		// Token: 0x0602D25A RID: 184922 RVA: 0x00630F60 File Offset: 0x0062F160
		public static Offset<IDestroySummonedVehicle> Pack(FlatBufferBuilder builder, IDestroySummonedVehicleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDestroySummonedVehicle>);
			}
			StringOffset templateIdOffset = (_o.TemplateId == null) ? default(StringOffset) : builder.CreateString(_o.TemplateId);
			return IDestroySummonedVehicle.CreateIDestroySummonedVehicle(builder, _o.Type, templateIdOffset);
		}

		// Token: 0x04010C05 RID: 68613
		private Table __p;
	}
}
