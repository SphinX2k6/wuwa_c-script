using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A79 RID: 2681
	public sealed class MotorOnlineParkPlayerRuleInfo : IMessage<MotorOnlineParkPlayerRuleInfo>, IMessage, IEquatable<MotorOnlineParkPlayerRuleInfo>, IDeepCloneable<MotorOnlineParkPlayerRuleInfo>, IBufferMessage
	{
		// Token: 0x0600E9AD RID: 59821 RVA: 0x00221DA4 File Offset: 0x0021FFA4
		[NullableContext(1)]
		public static MotorOnlineParkPlayerRuleInfo Create()
		{
			return new MotorOnlineParkPlayerRuleInfo();
		}

		// Token: 0x17002F6A RID: 12138
		// (get) Token: 0x0600E9AE RID: 59822 RVA: 0x00221DAB File Offset: 0x0021FFAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorOnlineParkPlayerRuleInfo> Parser
		{
			get
			{
				return MotorOnlineParkPlayerRuleInfo._parser;
			}
		}

		// Token: 0x17002F6B RID: 12139
		// (get) Token: 0x0600E9AF RID: 59823 RVA: 0x00221DB2 File Offset: 0x0021FFB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F6C RID: 12140
		// (get) Token: 0x0600E9B0 RID: 59824 RVA: 0x00221DB5 File Offset: 0x0021FFB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOnlineParkPlayerRuleInfo.Descriptor;
			}
		}

		// Token: 0x0600E9B1 RID: 59825 RVA: 0x00221DBC File Offset: 0x0021FFBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOnlineParkPlayerRuleInfo()
		{
		}

		// Token: 0x0600E9B2 RID: 59826 RVA: 0x00221DCF File Offset: 0x0021FFCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOnlineParkPlayerRuleInfo(MotorOnlineParkPlayerRuleInfo other) : this()
		{
			this.playerId_ = other.playerId_;
			this.ruleIds_ = other.ruleIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E9B3 RID: 59827 RVA: 0x00221E05 File Offset: 0x00220005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOnlineParkPlayerRuleInfo Clone()
		{
			return new MotorOnlineParkPlayerRuleInfo(this);
		}

		// Token: 0x17002F6D RID: 12141
		// (get) Token: 0x0600E9B4 RID: 59828 RVA: 0x00221E0D File Offset: 0x0022000D
		// (set) Token: 0x0600E9B5 RID: 59829 RVA: 0x00221E15 File Offset: 0x00220015
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17002F6E RID: 12142
		// (get) Token: 0x0600E9B6 RID: 59830 RVA: 0x00221E1E File Offset: 0x0022001E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RuleIds
		{
			get
			{
				return this.ruleIds_;
			}
		}

		// Token: 0x0600E9B7 RID: 59831 RVA: 0x00221E26 File Offset: 0x00220026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOnlineParkPlayerRuleInfo);
		}

		// Token: 0x0600E9B8 RID: 59832 RVA: 0x00221E34 File Offset: 0x00220034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOnlineParkPlayerRuleInfo other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.ruleIds_.Equals(other.ruleIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E9B9 RID: 59833 RVA: 0x00221E84 File Offset: 0x00220084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			num ^= this.ruleIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E9BA RID: 59834 RVA: 0x00221ED1 File Offset: 0x002200D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E9BB RID: 59835 RVA: 0x00221EDE File Offset: 0x002200DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E9BC RID: 59836 RVA: 0x00221EE8 File Offset: 0x002200E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerId);
			}
			this.ruleIds_.WriteTo(ref output, MotorOnlineParkPlayerRuleInfo._repeated_ruleIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E9BD RID: 59837 RVA: 0x00221F38 File Offset: 0x00220138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			num += this.ruleIds_.CalculateSize(MotorOnlineParkPlayerRuleInfo._repeated_ruleIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E9BE RID: 59838 RVA: 0x00221F8C File Offset: 0x0022018C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorOnlineParkPlayerRuleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this.ruleIds_.Add(other.ruleIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E9BF RID: 59839 RVA: 0x00221FD9 File Offset: 0x002201D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E9C0 RID: 59840 RVA: 0x00221FE4 File Offset: 0x002201E4
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
				if (num != 8U)
				{
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ruleIds_.AddEntriesFrom(ref input, MotorOnlineParkPlayerRuleInfo._repeated_ruleIds_codec);
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005EFA RID: 24314
		private static readonly MessageParser<MotorOnlineParkPlayerRuleInfo> _parser = new MessageParser<MotorOnlineParkPlayerRuleInfo>(() => new MotorOnlineParkPlayerRuleInfo());

		// Token: 0x04005EFB RID: 24315
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005EFC RID: 24316
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04005EFD RID: 24317
		private int playerId_;

		// Token: 0x04005EFE RID: 24318
		public const int RuleIdsFieldNumber = 2;

		// Token: 0x04005EFF RID: 24319
		private static readonly FieldCodec<int> _repeated_ruleIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04005F00 RID: 24320
		private readonly RepeatedField<int> ruleIds_ = new RepeatedField<int>();
	}
}
