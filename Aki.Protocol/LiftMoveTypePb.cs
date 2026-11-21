using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200090C RID: 2316
	public sealed class LiftMoveTypePb : IMessage<LiftMoveTypePb>, IMessage, IEquatable<LiftMoveTypePb>, IDeepCloneable<LiftMoveTypePb>, IBufferMessage
	{
		// Token: 0x0600CCB2 RID: 52402 RVA: 0x001E2CC2 File Offset: 0x001E0EC2
		[NullableContext(1)]
		public static LiftMoveTypePb Create()
		{
			return new LiftMoveTypePb();
		}

		// Token: 0x1700294F RID: 10575
		// (get) Token: 0x0600CCB3 RID: 52403 RVA: 0x001E2CC9 File Offset: 0x001E0EC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002950 RID: 10576
		// (get) Token: 0x0600CCB4 RID: 52404 RVA: 0x001E2CCC File Offset: 0x001E0ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LiftMoveTypePb.Descriptor;
			}
		}

		// Token: 0x0600CCB5 RID: 52405 RVA: 0x001E2CD3 File Offset: 0x001E0ED3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LiftMoveTypePb()
		{
		}

		// Token: 0x0600CCB6 RID: 52406 RVA: 0x001E2CDC File Offset: 0x001E0EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LiftMoveTypePb(LiftMoveTypePb other) : this()
		{
			this.type_ = other.type_;
			switch (other.OptionCase)
			{
			case LiftMoveTypePb.OptionOneofCase.MoveDefault:
				this.MoveDefault = other.MoveDefault.Clone();
				break;
			case LiftMoveTypePb.OptionOneofCase.MoveTeleport:
				this.MoveTeleport = other.MoveTeleport.Clone();
				break;
			case LiftMoveTypePb.OptionOneofCase.CustomSpeed:
				this.CustomSpeed = other.CustomSpeed.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CCB7 RID: 52407 RVA: 0x001E2D60 File Offset: 0x001E0F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LiftMoveTypePb Clone()
		{
			return new LiftMoveTypePb(this);
		}

		// Token: 0x17002951 RID: 10577
		// (get) Token: 0x0600CCB8 RID: 52408 RVA: 0x001E2D68 File Offset: 0x001E0F68
		// (set) Token: 0x0600CCB9 RID: 52409 RVA: 0x001E2D70 File Offset: 0x001E0F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LiftMoveType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17002952 RID: 10578
		// (get) Token: 0x0600CCBA RID: 52410 RVA: 0x001E2D79 File Offset: 0x001E0F79
		// (set) Token: 0x0600CCBB RID: 52411 RVA: 0x001E2D91 File Offset: 0x001E0F91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LiftMoveTypeDefaultPb MoveDefault
		{
			get
			{
				if (this.optionCase_ != LiftMoveTypePb.OptionOneofCase.MoveDefault)
				{
					return null;
				}
				return (LiftMoveTypeDefaultPb)this.option_;
			}
			set
			{
				this.option_ = value;
				this.optionCase_ = ((value == null) ? LiftMoveTypePb.OptionOneofCase.None : LiftMoveTypePb.OptionOneofCase.MoveDefault);
			}
		}

		// Token: 0x17002953 RID: 10579
		// (get) Token: 0x0600CCBC RID: 52412 RVA: 0x001E2DA7 File Offset: 0x001E0FA7
		// (set) Token: 0x0600CCBD RID: 52413 RVA: 0x001E2DBF File Offset: 0x001E0FBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LiftMoveTypeTeleportPb MoveTeleport
		{
			get
			{
				if (this.optionCase_ != LiftMoveTypePb.OptionOneofCase.MoveTeleport)
				{
					return null;
				}
				return (LiftMoveTypeTeleportPb)this.option_;
			}
			set
			{
				this.option_ = value;
				this.optionCase_ = ((value == null) ? LiftMoveTypePb.OptionOneofCase.None : LiftMoveTypePb.OptionOneofCase.MoveTeleport);
			}
		}

		// Token: 0x17002954 RID: 10580
		// (get) Token: 0x0600CCBE RID: 52414 RVA: 0x001E2DD5 File Offset: 0x001E0FD5
		// (set) Token: 0x0600CCBF RID: 52415 RVA: 0x001E2DED File Offset: 0x001E0FED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LiftMoveTypeCustomSpeedPb CustomSpeed
		{
			get
			{
				if (this.optionCase_ != LiftMoveTypePb.OptionOneofCase.CustomSpeed)
				{
					return null;
				}
				return (LiftMoveTypeCustomSpeedPb)this.option_;
			}
			set
			{
				this.option_ = value;
				this.optionCase_ = ((value == null) ? LiftMoveTypePb.OptionOneofCase.None : LiftMoveTypePb.OptionOneofCase.CustomSpeed);
			}
		}

		// Token: 0x17002955 RID: 10581
		// (get) Token: 0x0600CCC0 RID: 52416 RVA: 0x001E2E03 File Offset: 0x001E1003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LiftMoveTypePb.OptionOneofCase OptionCase
		{
			get
			{
				return this.optionCase_;
			}
		}

		// Token: 0x0600CCC1 RID: 52417 RVA: 0x001E2E0B File Offset: 0x001E100B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearOption()
		{
			this.optionCase_ = LiftMoveTypePb.OptionOneofCase.None;
			this.option_ = null;
		}

		// Token: 0x0600CCC2 RID: 52418 RVA: 0x001E2E1B File Offset: 0x001E101B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LiftMoveTypePb);
		}

		// Token: 0x0600CCC3 RID: 52419 RVA: 0x001E2E2C File Offset: 0x001E102C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LiftMoveTypePb other)
		{
			return other != null && (other == this || (this.Type == other.Type && object.Equals(this.MoveDefault, other.MoveDefault) && object.Equals(this.MoveTeleport, other.MoveTeleport) && object.Equals(this.CustomSpeed, other.CustomSpeed) && this.OptionCase == other.OptionCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CCC4 RID: 52420 RVA: 0x001E2EB4 File Offset: 0x001E10B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != LiftMoveType.Default)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.optionCase_ == LiftMoveTypePb.OptionOneofCase.MoveDefault)
			{
				num ^= this.MoveDefault.GetHashCode();
			}
			if (this.optionCase_ == LiftMoveTypePb.OptionOneofCase.MoveTeleport)
			{
				num ^= this.MoveTeleport.GetHashCode();
			}
			if (this.optionCase_ == LiftMoveTypePb.OptionOneofCase.CustomSpeed)
			{
				num ^= this.CustomSpeed.GetHashCode();
			}
			num ^= (int)this.optionCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CCC5 RID: 52421 RVA: 0x001E2F47 File Offset: 0x001E1147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CCC6 RID: 52422 RVA: 0x001E2F54 File Offset: 0x001E1154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CCC7 RID: 52423 RVA: 0x001E2F60 File Offset: 0x001E1160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != LiftMoveType.Default)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Type);
			}
			if (this.optionCase_ == LiftMoveTypePb.OptionOneofCase.MoveDefault)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.MoveDefault);
			}
			if (this.optionCase_ == LiftMoveTypePb.OptionOneofCase.MoveTeleport)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.MoveTeleport);
			}
			if (this.optionCase_ == LiftMoveTypePb.OptionOneofCase.CustomSpeed)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.CustomSpeed);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CCC8 RID: 52424 RVA: 0x001E2FF4 File Offset: 0x001E11F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != LiftMoveType.Default)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.optionCase_ == LiftMoveTypePb.OptionOneofCase.MoveDefault)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MoveDefault);
			}
			if (this.optionCase_ == LiftMoveTypePb.OptionOneofCase.MoveTeleport)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MoveTeleport);
			}
			if (this.optionCase_ == LiftMoveTypePb.OptionOneofCase.CustomSpeed)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CustomSpeed);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CCC9 RID: 52425 RVA: 0x001E3080 File Offset: 0x001E1280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LiftMoveTypePb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != LiftMoveType.Default)
			{
				this.Type = other.Type;
			}
			switch (other.OptionCase)
			{
			case LiftMoveTypePb.OptionOneofCase.MoveDefault:
				if (this.MoveDefault == null)
				{
					this.MoveDefault = new LiftMoveTypeDefaultPb();
				}
				this.MoveDefault.MergeFrom(other.MoveDefault);
				break;
			case LiftMoveTypePb.OptionOneofCase.MoveTeleport:
				if (this.MoveTeleport == null)
				{
					this.MoveTeleport = new LiftMoveTypeTeleportPb();
				}
				this.MoveTeleport.MergeFrom(other.MoveTeleport);
				break;
			case LiftMoveTypePb.OptionOneofCase.CustomSpeed:
				if (this.CustomSpeed == null)
				{
					this.CustomSpeed = new LiftMoveTypeCustomSpeedPb();
				}
				this.CustomSpeed.MergeFrom(other.CustomSpeed);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CCCA RID: 52426 RVA: 0x001E3149 File Offset: 0x001E1349
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CCCB RID: 52427 RVA: 0x001E3154 File Offset: 0x001E1354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num <= 18U)
				{
					if (num == 8U)
					{
						this.Type = (LiftMoveType)input.ReadEnum();
						continue;
					}
					if (num == 18U)
					{
						LiftMoveTypeDefaultPb liftMoveTypeDefaultPb = new LiftMoveTypeDefaultPb();
						if (this.optionCase_ == LiftMoveTypePb.OptionOneofCase.MoveDefault)
						{
							liftMoveTypeDefaultPb.MergeFrom(this.MoveDefault);
						}
						input.ReadMessage(liftMoveTypeDefaultPb);
						this.MoveDefault = liftMoveTypeDefaultPb;
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						LiftMoveTypeTeleportPb liftMoveTypeTeleportPb = new LiftMoveTypeTeleportPb();
						if (this.optionCase_ == LiftMoveTypePb.OptionOneofCase.MoveTeleport)
						{
							liftMoveTypeTeleportPb.MergeFrom(this.MoveTeleport);
						}
						input.ReadMessage(liftMoveTypeTeleportPb);
						this.MoveTeleport = liftMoveTypeTeleportPb;
						continue;
					}
					if (num == 34U)
					{
						LiftMoveTypeCustomSpeedPb liftMoveTypeCustomSpeedPb = new LiftMoveTypeCustomSpeedPb();
						if (this.optionCase_ == LiftMoveTypePb.OptionOneofCase.CustomSpeed)
						{
							liftMoveTypeCustomSpeedPb.MergeFrom(this.CustomSpeed);
						}
						input.ReadMessage(liftMoveTypeCustomSpeedPb);
						this.CustomSpeed = liftMoveTypeCustomSpeedPb;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400570F RID: 22287
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005710 RID: 22288
		public const int TypeFieldNumber = 1;

		// Token: 0x04005711 RID: 22289
		private LiftMoveType type_;

		// Token: 0x04005712 RID: 22290
		public const int MoveDefaultFieldNumber = 2;

		// Token: 0x04005713 RID: 22291
		public const int MoveTeleportFieldNumber = 3;

		// Token: 0x04005714 RID: 22292
		public const int CustomSpeedFieldNumber = 4;

		// Token: 0x04005715 RID: 22293
		private object option_;

		// Token: 0x04005716 RID: 22294
		private LiftMoveTypePb.OptionOneofCase optionCase_;

		// Token: 0x02001895 RID: 6293
		public enum OptionOneofCase
		{
			// Token: 0x0400CD09 RID: 52489
			None,
			// Token: 0x0400CD0A RID: 52490
			MoveDefault = 2,
			// Token: 0x0400CD0B RID: 52491
			MoveTeleport,
			// Token: 0x0400CD0C RID: 52492
			CustomSpeed
		}
	}
}
