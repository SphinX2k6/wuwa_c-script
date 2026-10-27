using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B27 RID: 27431
	public struct IMotorRadioOperationRestriction : IFlatbufferObject
	{
		// Token: 0x1700CBDF RID: 52191
		// (get) Token: 0x0603025D RID: 197213 RVA: 0x0068B6AC File Offset: 0x006898AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603025E RID: 197214 RVA: 0x0068B6B9 File Offset: 0x006898B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603025F RID: 197215 RVA: 0x0068B6C0 File Offset: 0x006898C0
		public static IMotorRadioOperationRestriction GetRootAsIMotorRadioOperationRestriction(ByteBuffer _bb)
		{
			return IMotorRadioOperationRestriction.GetRootAsIMotorRadioOperationRestriction(_bb, default(IMotorRadioOperationRestriction));
		}

		// Token: 0x06030260 RID: 197216 RVA: 0x0068B6DC File Offset: 0x006898DC
		public static IMotorRadioOperationRestriction GetRootAsIMotorRadioOperationRestriction(ByteBuffer _bb, IMotorRadioOperationRestriction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030261 RID: 197217 RVA: 0x0068B6F9 File Offset: 0x006898F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030262 RID: 197218 RVA: 0x0068B708 File Offset: 0x00689908
		public IMotorRadioOperationRestriction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CBE0 RID: 52192
		// (get) Token: 0x06030263 RID: 197219 RVA: 0x0068B718 File Offset: 0x00689918
		public EMotorRadioOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMotorRadioOperationType.EnableAll;
				}
				return (EMotorRadioOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030264 RID: 197220 RVA: 0x0068B754 File Offset: 0x00689954
		public static Offset<IMotorRadioOperationRestriction> CreateIMotorRadioOperationRestriction(FlatBufferBuilder builder, EMotorRadioOperationType Type = EMotorRadioOperationType.EnableAll)
		{
			builder.StartTable(1);
			IMotorRadioOperationRestriction.AddType(builder, Type);
			return IMotorRadioOperationRestriction.EndIMotorRadioOperationRestriction(builder);
		}

		// Token: 0x06030265 RID: 197221 RVA: 0x0068B76A File Offset: 0x0068996A
		public static void StartIMotorRadioOperationRestriction(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06030266 RID: 197222 RVA: 0x0068B773 File Offset: 0x00689973
		public static void AddType(FlatBufferBuilder builder, EMotorRadioOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030267 RID: 197223 RVA: 0x0068B77E File Offset: 0x0068997E
		public static Offset<IMotorRadioOperationRestriction> EndIMotorRadioOperationRestriction(FlatBufferBuilder builder)
		{
			return new Offset<IMotorRadioOperationRestriction>(builder.EndTable());
		}

		// Token: 0x06030268 RID: 197224 RVA: 0x0068B78C File Offset: 0x0068998C
		public IMotorRadioOperationRestrictionT UnPack()
		{
			IMotorRadioOperationRestrictionT motorRadioOperationRestrictionT = new IMotorRadioOperationRestrictionT();
			this.UnPackTo(motorRadioOperationRestrictionT);
			return motorRadioOperationRestrictionT;
		}

		// Token: 0x06030269 RID: 197225 RVA: 0x0068B7A7 File Offset: 0x006899A7
		public void UnPackTo(IMotorRadioOperationRestrictionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603026A RID: 197226 RVA: 0x0068B7B8 File Offset: 0x006899B8
		public static Offset<IMotorRadioOperationRestriction> Pack(FlatBufferBuilder builder, IMotorRadioOperationRestrictionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorRadioOperationRestriction>);
			}
			return IMotorRadioOperationRestriction.CreateIMotorRadioOperationRestriction(builder, _o.Type);
		}

		// Token: 0x040113BD RID: 70589
		private Table __p;
	}
}
