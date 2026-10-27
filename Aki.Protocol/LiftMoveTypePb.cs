using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200091D RID: 2333
	public sealed class LiftMoveTypePb : IMessage<LiftMoveTypePb>, IMessage, IEquatable<LiftMoveTypePb>, IDeepCloneable<LiftMoveTypePb>, IBufferMessage
	{
		// Token: 0x0600CDCE RID: 52686 RVA: 0x001E4F92 File Offset: 0x001E3192
		[NullableContext(1)]
		public static LiftMoveTypePb Create()
		{
			return new LiftMoveTypePb();
		}

		// Token: 0x1700298E RID: 10638
		// (get) Token: 0x0600CDCF RID: 52687 RVA: 0x001E4F99 File Offset: 0x001E3199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700298F RID: 10639
		// (get) Token: 0x0600CDD0 RID: 52688 RVA: 0x001E4F9C File Offset: 0x001E319C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LiftMoveTypePb.Descriptor;
			}
		}

		// Token: 0x0600CDD1 RID: 52689 RVA: 0x001E4FA3 File Offset: 0x001E31A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LiftMoveTypePb()
		{
		}

		// Token: 0x0600CDD2 RID: 52690 RVA: 0x001E4FAC File Offset: 0x001E31AC
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

		// Token: 0x0600CDD3 RID: 52691 RVA: 0x001E5030 File Offset: 0x001E3230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LiftMoveTypePb Clone()
		{
			return new LiftMoveTypePb(this);
		}

		// Token: 0x17002990 RID: 10640
		// (get) Token: 0x0600CDD4 RID: 52692 RVA: 0x001E5038 File Offset: 0x001E3238
		// (set) Token: 0x0600CDD5 RID: 52693 RVA: 0x001E5040 File Offset: 0x001E3240
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

		// Token: 0x17002991 RID: 10641
		// (get) Token: 0x0600CDD6 RID: 52694 RVA: 0x001E5049 File Offset: 0x001E3249
		// (set) Token: 0x0600CDD7 RID: 52695 RVA: 0x001E5061 File Offset: 0x001E3261
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

		// Token: 0x17002992 RID: 10642
		// (get) Token: 0x0600CDD8 RID: 52696 RVA: 0x001E5077 File Offset: 0x001E3277
		// (set) Token: 0x0600CDD9 RID: 52697 RVA: 0x001E508F File Offset: 0x001E328F
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

		// Token: 0x17002993 RID: 10643
		// (get) Token: 0x0600CDDA RID: 52698 RVA: 0x001E50A5 File Offset: 0x001E32A5
		// (set) Token: 0x0600CDDB RID: 52699 RVA: 0x001E50BD File Offset: 0x001E32BD
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

		// Token: 0x17002994 RID: 10644
		// (get) Token: 0x0600CDDC RID: 52700 RVA: 0x001E50D3 File Offset: 0x001E32D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LiftMoveTypePb.OptionOneofCase OptionCase
		{
			get
			{
				return this.optionCase_;
			}
		}

		// Token: 0x0600CDDD RID: 52701 RVA: 0x001E50DB File Offset: 0x001E32DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearOption()
		{
			this.optionCase_ = LiftMoveTypePb.OptionOneofCase.None;
			this.option_ = null;
		}

		// Token: 0x0600CDDE RID: 52702 RVA: 0x001E50EB File Offset: 0x001E32EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LiftMoveTypePb);
		}

		// Token: 0x0600CDDF RID: 52703 RVA: 0x001E50FC File Offset: 0x001E32FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LiftMoveTypePb other)
		{
			return other != null && (other == this || (this.Type == other.Type && object.Equals(this.MoveDefault, other.MoveDefault) && object.Equals(this.MoveTeleport, other.MoveTeleport) && object.Equals(this.CustomSpeed, other.CustomSpeed) && this.OptionCase == other.OptionCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CDE0 RID: 52704 RVA: 0x001E5184 File Offset: 0x001E3384
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

		// Token: 0x0600CDE1 RID: 52705 RVA: 0x001E5217 File Offset: 0x001E3417
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CDE2 RID: 52706 RVA: 0x001E5224 File Offset: 0x001E3424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CDE3 RID: 52707 RVA: 0x001E5230 File Offset: 0x001E3430
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

		// Token: 0x0600CDE4 RID: 52708 RVA: 0x001E52C4 File Offset: 0x001E34C4
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

		// Token: 0x0600CDE5 RID: 52709 RVA: 0x001E5350 File Offset: 0x001E3550
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

		// Token: 0x0600CDE6 RID: 52710 RVA: 0x001E5419 File Offset: 0x001E3619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CDE7 RID: 52711 RVA: 0x001E5424 File Offset: 0x001E3624
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

		// Token: 0x04005708 RID: 22280
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005709 RID: 22281
		public const int TypeFieldNumber = 1;

		// Token: 0x0400570A RID: 22282
		private LiftMoveType type_;

		// Token: 0x0400570B RID: 22283
		public const int MoveDefaultFieldNumber = 2;

		// Token: 0x0400570C RID: 22284
		public const int MoveTeleportFieldNumber = 3;

		// Token: 0x0400570D RID: 22285
		public const int CustomSpeedFieldNumber = 4;

		// Token: 0x0400570E RID: 22286
		private object option_;

		// Token: 0x0400570F RID: 22287
		private LiftMoveTypePb.OptionOneofCase optionCase_;

		// Token: 0x0200181D RID: 6173
		public enum OptionOneofCase
		{
			// Token: 0x0400C7DE RID: 51166
			None,
			// Token: 0x0400C7DF RID: 51167
			MoveDefault = 2,
			// Token: 0x0400C7E0 RID: 51168
			MoveTeleport,
			// Token: 0x0400C7E1 RID: 51169
			CustomSpeed
		}
	}
}
