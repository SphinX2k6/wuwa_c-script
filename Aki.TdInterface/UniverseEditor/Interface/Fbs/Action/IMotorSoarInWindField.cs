using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007279 RID: 29305
	public struct IMotorSoarInWindField : IFlatbufferObject
	{
		// Token: 0x1700D6D1 RID: 54993
		// (get) Token: 0x06033100 RID: 209152 RVA: 0x006E4419 File Offset: 0x006E2619
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033101 RID: 209153 RVA: 0x006E4426 File Offset: 0x006E2626
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033102 RID: 209154 RVA: 0x006E4430 File Offset: 0x006E2630
		public static IMotorSoarInWindField GetRootAsIMotorSoarInWindField(ByteBuffer _bb)
		{
			return IMotorSoarInWindField.GetRootAsIMotorSoarInWindField(_bb, default(IMotorSoarInWindField));
		}

		// Token: 0x06033103 RID: 209155 RVA: 0x006E444C File Offset: 0x006E264C
		public static IMotorSoarInWindField GetRootAsIMotorSoarInWindField(ByteBuffer _bb, IMotorSoarInWindField obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033104 RID: 209156 RVA: 0x006E4469 File Offset: 0x006E2669
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033105 RID: 209157 RVA: 0x006E4478 File Offset: 0x006E2678
		public IMotorSoarInWindField __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D6D2 RID: 54994
		// (get) Token: 0x06033106 RID: 209158 RVA: 0x006E4488 File Offset: 0x006E2688
		public TMotorSoarInWindFieldControlType ControlTypeType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TMotorSoarInWindFieldControlType.NONE;
				}
				return (TMotorSoarInWindFieldControlType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033107 RID: 209159 RVA: 0x006E44C4 File Offset: 0x006E26C4
		public TTable? ControlType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06033108 RID: 209160 RVA: 0x006E4508 File Offset: 0x006E2708
		public IMotorSoarInWindFieldEnterWindField ControlTypeAsIMotorSoarInWindFieldEnterWindField()
		{
			return this.ControlType<IMotorSoarInWindFieldEnterWindField>().Value;
		}

		// Token: 0x06033109 RID: 209161 RVA: 0x006E4524 File Offset: 0x006E2724
		public IMotorSoarInWindFieldExitWindField ControlTypeAsIMotorSoarInWindFieldExitWindField()
		{
			return this.ControlType<IMotorSoarInWindFieldExitWindField>().Value;
		}

		// Token: 0x0603310A RID: 209162 RVA: 0x006E453F File Offset: 0x006E273F
		public static Offset<IMotorSoarInWindField> CreateIMotorSoarInWindField(FlatBufferBuilder builder, TMotorSoarInWindFieldControlType ControlType_type = TMotorSoarInWindFieldControlType.NONE, int ControlTypeOffset = 0)
		{
			builder.StartTable(2);
			IMotorSoarInWindField.AddControlType(builder, ControlTypeOffset);
			IMotorSoarInWindField.AddControlTypeType(builder, ControlType_type);
			return IMotorSoarInWindField.EndIMotorSoarInWindField(builder);
		}

		// Token: 0x0603310B RID: 209163 RVA: 0x006E455C File Offset: 0x006E275C
		public static void StartIMotorSoarInWindField(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603310C RID: 209164 RVA: 0x006E4565 File Offset: 0x006E2765
		public static void AddControlTypeType(FlatBufferBuilder builder, TMotorSoarInWindFieldControlType controlTypeType)
		{
			builder.AddByte(0, (byte)controlTypeType, 0);
		}

		// Token: 0x0603310D RID: 209165 RVA: 0x006E4570 File Offset: 0x006E2770
		public static void AddControlType(FlatBufferBuilder builder, int controlTypeOffset)
		{
			builder.AddOffset(1, controlTypeOffset, 0);
		}

		// Token: 0x0603310E RID: 209166 RVA: 0x006E457B File Offset: 0x006E277B
		public static Offset<IMotorSoarInWindField> EndIMotorSoarInWindField(FlatBufferBuilder builder)
		{
			return new Offset<IMotorSoarInWindField>(builder.EndTable());
		}

		// Token: 0x0603310F RID: 209167 RVA: 0x006E4588 File Offset: 0x006E2788
		public IMotorSoarInWindFieldT UnPack()
		{
			IMotorSoarInWindFieldT motorSoarInWindFieldT = new IMotorSoarInWindFieldT();
			this.UnPackTo(motorSoarInWindFieldT);
			return motorSoarInWindFieldT;
		}

		// Token: 0x06033110 RID: 209168 RVA: 0x006E45A4 File Offset: 0x006E27A4
		public void UnPackTo(IMotorSoarInWindFieldT _o)
		{
			_o.ControlType = new TMotorSoarInWindFieldControlTypeUnion();
			_o.ControlType.Type = this.ControlTypeType;
			TMotorSoarInWindFieldControlType controlTypeType = this.ControlTypeType;
			if (controlTypeType == TMotorSoarInWindFieldControlType.IMotorSoarInWindFieldEnterWindField)
			{
				_o.ControlType.Value = ((this.ControlType<IMotorSoarInWindFieldEnterWindField>() != null) ? this.ControlType<IMotorSoarInWindFieldEnterWindField>().Value.UnPack() : null);
				return;
			}
			if (controlTypeType != TMotorSoarInWindFieldControlType.IMotorSoarInWindFieldExitWindField)
			{
				return;
			}
			_o.ControlType.Value = ((this.ControlType<IMotorSoarInWindFieldExitWindField>() != null) ? this.ControlType<IMotorSoarInWindFieldExitWindField>().Value.UnPack() : null);
		}

		// Token: 0x06033111 RID: 209169 RVA: 0x006E4648 File Offset: 0x006E2848
		public static Offset<IMotorSoarInWindField> Pack(FlatBufferBuilder builder, IMotorSoarInWindFieldT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorSoarInWindField>);
			}
			TMotorSoarInWindFieldControlType controlType_type = (_o.ControlType == null) ? TMotorSoarInWindFieldControlType.NONE : _o.ControlType.Type;
			int controlTypeOffset = (_o.ControlType == null) ? 0 : TMotorSoarInWindFieldControlTypeUnion.Pack(builder, _o.ControlType);
			return IMotorSoarInWindField.CreateIMotorSoarInWindField(builder, controlType_type, controlTypeOffset);
		}

		// Token: 0x040122F4 RID: 74484
		private Table __p;
	}
}
