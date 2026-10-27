using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A85 RID: 2693
	[NetMessage(EMessageId.MotorOutlookEquippedChangeNotify)]
	public sealed class MotorOutlookEquippedChangeNotify : IMessage<MotorOutlookEquippedChangeNotify>, IMessage, IEquatable<MotorOutlookEquippedChangeNotify>, IDeepCloneable<MotorOutlookEquippedChangeNotify>, IBufferMessage
	{
		// Token: 0x0600EA9F RID: 60063 RVA: 0x00223FD7 File Offset: 0x002221D7
		[NullableContext(1)]
		public static MotorOutlookEquippedChangeNotify Create()
		{
			return new MotorOutlookEquippedChangeNotify();
		}

		// Token: 0x17002F9D RID: 12189
		// (get) Token: 0x0600EAA0 RID: 60064 RVA: 0x00223FDE File Offset: 0x002221DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F9E RID: 12190
		// (get) Token: 0x0600EAA1 RID: 60065 RVA: 0x00223FE1 File Offset: 0x002221E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOutlookEquippedChangeNotify.Descriptor;
			}
		}

		// Token: 0x0600EAA2 RID: 60066 RVA: 0x00223FE8 File Offset: 0x002221E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookEquippedChangeNotify()
		{
		}

		// Token: 0x0600EAA3 RID: 60067 RVA: 0x00223FFC File Offset: 0x002221FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookEquippedChangeNotify(MotorOutlookEquippedChangeNotify other) : this()
		{
			this.motorOutlookEquipped_ = ((other.motorOutlookEquipped_ != null) ? other.motorOutlookEquipped_.Clone() : null);
			this.latestMotorSkinSuit_ = other.latestMotorSkinSuit_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EAA4 RID: 60068 RVA: 0x0022404D File Offset: 0x0022224D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookEquippedChangeNotify Clone()
		{
			return new MotorOutlookEquippedChangeNotify(this);
		}

		// Token: 0x17002F9F RID: 12191
		// (get) Token: 0x0600EAA5 RID: 60069 RVA: 0x00224055 File Offset: 0x00222255
		// (set) Token: 0x0600EAA6 RID: 60070 RVA: 0x0022405D File Offset: 0x0022225D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOutlookEquippedPb MotorOutlookEquipped
		{
			get
			{
				return this.motorOutlookEquipped_;
			}
			set
			{
				this.motorOutlookEquipped_ = value;
			}
		}

		// Token: 0x17002FA0 RID: 12192
		// (get) Token: 0x0600EAA7 RID: 60071 RVA: 0x00224066 File Offset: 0x00222266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorOutlookEquippedPb> LatestMotorSkinSuit
		{
			get
			{
				return this.latestMotorSkinSuit_;
			}
		}

		// Token: 0x0600EAA8 RID: 60072 RVA: 0x0022406E File Offset: 0x0022226E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOutlookEquippedChangeNotify);
		}

		// Token: 0x0600EAA9 RID: 60073 RVA: 0x0022407C File Offset: 0x0022227C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOutlookEquippedChangeNotify other)
		{
			return other != null && (other == this || (object.Equals(this.MotorOutlookEquipped, other.MotorOutlookEquipped) && this.latestMotorSkinSuit_.Equals(other.latestMotorSkinSuit_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EAAA RID: 60074 RVA: 0x002240D0 File Offset: 0x002222D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.motorOutlookEquipped_ != null)
			{
				num ^= this.MotorOutlookEquipped.GetHashCode();
			}
			num ^= this.latestMotorSkinSuit_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EAAB RID: 60075 RVA: 0x0022411A File Offset: 0x0022231A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EAAC RID: 60076 RVA: 0x00224127 File Offset: 0x00222327
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EAAD RID: 60077 RVA: 0x00224130 File Offset: 0x00222330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.latestMotorSkinSuit_.WriteTo(ref output, MotorOutlookEquippedChangeNotify._repeated_latestMotorSkinSuit_codec);
			if (this.motorOutlookEquipped_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.MotorOutlookEquipped);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EAAE RID: 60078 RVA: 0x00224180 File Offset: 0x00222380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.motorOutlookEquipped_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MotorOutlookEquipped);
			}
			num += this.latestMotorSkinSuit_.CalculateSize(MotorOutlookEquippedChangeNotify._repeated_latestMotorSkinSuit_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EAAF RID: 60079 RVA: 0x002241D4 File Offset: 0x002223D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorOutlookEquippedChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.motorOutlookEquipped_ != null)
			{
				if (this.motorOutlookEquipped_ == null)
				{
					this.MotorOutlookEquipped = new MotorOutlookEquippedPb();
				}
				this.MotorOutlookEquipped.MergeFrom(other.MotorOutlookEquipped);
			}
			this.latestMotorSkinSuit_.Add(other.latestMotorSkinSuit_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EAB0 RID: 60080 RVA: 0x00224239 File Offset: 0x00222439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EAB1 RID: 60081 RVA: 0x00224244 File Offset: 0x00222444
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
				if (num != 18U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.motorOutlookEquipped_ == null)
						{
							this.MotorOutlookEquipped = new MotorOutlookEquippedPb();
						}
						input.ReadMessage(this.MotorOutlookEquipped);
					}
				}
				else
				{
					this.latestMotorSkinSuit_.AddEntriesFrom(ref input, MotorOutlookEquippedChangeNotify._repeated_latestMotorSkinSuit_codec);
				}
			}
		}

		// Token: 0x04005F41 RID: 24385
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F42 RID: 24386
		public const int MotorOutlookEquippedFieldNumber = 15;

		// Token: 0x04005F43 RID: 24387
		private MotorOutlookEquippedPb motorOutlookEquipped_;

		// Token: 0x04005F44 RID: 24388
		public const int LatestMotorSkinSuitFieldNumber = 2;

		// Token: 0x04005F45 RID: 24389
		private static readonly FieldCodec<MotorOutlookEquippedPb> _repeated_latestMotorSkinSuit_codec = FieldCodec.ForMessage<MotorOutlookEquippedPb>(18U, MotorOutlookEquippedPb.Parser);

		// Token: 0x04005F46 RID: 24390
		private readonly RepeatedField<MotorOutlookEquippedPb> latestMotorSkinSuit_ = new RepeatedField<MotorOutlookEquippedPb>();
	}
}
