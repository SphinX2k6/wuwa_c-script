using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B33 RID: 27443
	public struct IMotorSoarInWindField : IFlatbufferObject
	{
		// Token: 0x1700CBEC RID: 52204
		// (get) Token: 0x060302A9 RID: 197289 RVA: 0x0068BE5D File Offset: 0x0068A05D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060302AA RID: 197290 RVA: 0x0068BE6A File Offset: 0x0068A06A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060302AB RID: 197291 RVA: 0x0068BE74 File Offset: 0x0068A074
		public static IMotorSoarInWindField GetRootAsIMotorSoarInWindField(ByteBuffer _bb)
		{
			return IMotorSoarInWindField.GetRootAsIMotorSoarInWindField(_bb, default(IMotorSoarInWindField));
		}

		// Token: 0x060302AC RID: 197292 RVA: 0x0068BE90 File Offset: 0x0068A090
		public static IMotorSoarInWindField GetRootAsIMotorSoarInWindField(ByteBuffer _bb, IMotorSoarInWindField obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060302AD RID: 197293 RVA: 0x0068BEAD File Offset: 0x0068A0AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060302AE RID: 197294 RVA: 0x0068BEBC File Offset: 0x0068A0BC
		public IMotorSoarInWindField __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CBED RID: 52205
		// (get) Token: 0x060302AF RID: 197295 RVA: 0x0068BECC File Offset: 0x0068A0CC
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

		// Token: 0x060302B0 RID: 197296 RVA: 0x0068BF08 File Offset: 0x0068A108
		public TTable? ControlType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060302B1 RID: 197297 RVA: 0x0068BF4C File Offset: 0x0068A14C
		public IMotorSoarInWindFieldEnterWindField ControlTypeAsIMotorSoarInWindFieldEnterWindField()
		{
			return this.ControlType<IMotorSoarInWindFieldEnterWindField>().Value;
		}

		// Token: 0x060302B2 RID: 197298 RVA: 0x0068BF68 File Offset: 0x0068A168
		public IMotorSoarInWindFieldExitWindField ControlTypeAsIMotorSoarInWindFieldExitWindField()
		{
			return this.ControlType<IMotorSoarInWindFieldExitWindField>().Value;
		}

		// Token: 0x060302B3 RID: 197299 RVA: 0x0068BF83 File Offset: 0x0068A183
		public static Offset<IMotorSoarInWindField> CreateIMotorSoarInWindField(FlatBufferBuilder builder, TMotorSoarInWindFieldControlType ControlType_type = TMotorSoarInWindFieldControlType.NONE, int ControlTypeOffset = 0)
		{
			builder.StartTable(2);
			IMotorSoarInWindField.AddControlType(builder, ControlTypeOffset);
			IMotorSoarInWindField.AddControlTypeType(builder, ControlType_type);
			return IMotorSoarInWindField.EndIMotorSoarInWindField(builder);
		}

		// Token: 0x060302B4 RID: 197300 RVA: 0x0068BFA0 File Offset: 0x0068A1A0
		public static void StartIMotorSoarInWindField(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060302B5 RID: 197301 RVA: 0x0068BFA9 File Offset: 0x0068A1A9
		public static void AddControlTypeType(FlatBufferBuilder builder, TMotorSoarInWindFieldControlType controlTypeType)
		{
			builder.AddByte(0, (byte)controlTypeType, 0);
		}

		// Token: 0x060302B6 RID: 197302 RVA: 0x0068BFB4 File Offset: 0x0068A1B4
		public static void AddControlType(FlatBufferBuilder builder, int controlTypeOffset)
		{
			builder.AddOffset(1, controlTypeOffset, 0);
		}

		// Token: 0x060302B7 RID: 197303 RVA: 0x0068BFBF File Offset: 0x0068A1BF
		public static Offset<IMotorSoarInWindField> EndIMotorSoarInWindField(FlatBufferBuilder builder)
		{
			return new Offset<IMotorSoarInWindField>(builder.EndTable());
		}

		// Token: 0x060302B8 RID: 197304 RVA: 0x0068BFCC File Offset: 0x0068A1CC
		public IMotorSoarInWindFieldT UnPack()
		{
			IMotorSoarInWindFieldT motorSoarInWindFieldT = new IMotorSoarInWindFieldT();
			this.UnPackTo(motorSoarInWindFieldT);
			return motorSoarInWindFieldT;
		}

		// Token: 0x060302B9 RID: 197305 RVA: 0x0068BFE8 File Offset: 0x0068A1E8
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

		// Token: 0x060302BA RID: 197306 RVA: 0x0068C08C File Offset: 0x0068A28C
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

		// Token: 0x040113CB RID: 70603
		private Table __p;
	}
}
