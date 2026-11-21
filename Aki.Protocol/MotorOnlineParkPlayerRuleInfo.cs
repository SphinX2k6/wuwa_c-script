using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A68 RID: 2664
	public sealed class MotorOnlineParkPlayerRuleInfo : IMessage<MotorOnlineParkPlayerRuleInfo>, IMessage, IEquatable<MotorOnlineParkPlayerRuleInfo>, IDeepCloneable<MotorOnlineParkPlayerRuleInfo>, IBufferMessage
	{
		// Token: 0x0600E893 RID: 59539 RVA: 0x0021FBB0 File Offset: 0x0021DDB0
		[NullableContext(1)]
		public static MotorOnlineParkPlayerRuleInfo Create()
		{
			return new MotorOnlineParkPlayerRuleInfo();
		}

		// Token: 0x17002F2C RID: 12076
		// (get) Token: 0x0600E894 RID: 59540 RVA: 0x0021FBB7 File Offset: 0x0021DDB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorOnlineParkPlayerRuleInfo> Parser
		{
			get
			{
				return MotorOnlineParkPlayerRuleInfo._parser;
			}
		}

		// Token: 0x17002F2D RID: 12077
		// (get) Token: 0x0600E895 RID: 59541 RVA: 0x0021FBBE File Offset: 0x0021DDBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F2E RID: 12078
		// (get) Token: 0x0600E896 RID: 59542 RVA: 0x0021FBC1 File Offset: 0x0021DDC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorOnlineParkPlayerRuleInfo.Descriptor;
			}
		}

		// Token: 0x0600E897 RID: 59543 RVA: 0x0021FBC8 File Offset: 0x0021DDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOnlineParkPlayerRuleInfo()
		{
		}

		// Token: 0x0600E898 RID: 59544 RVA: 0x0021FBDB File Offset: 0x0021DDDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOnlineParkPlayerRuleInfo(MotorOnlineParkPlayerRuleInfo other) : this()
		{
			this.playerId_ = other.playerId_;
			this.ruleIds_ = other.ruleIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E899 RID: 59545 RVA: 0x0021FC11 File Offset: 0x0021DE11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorOnlineParkPlayerRuleInfo Clone()
		{
			return new MotorOnlineParkPlayerRuleInfo(this);
		}

		// Token: 0x17002F2F RID: 12079
		// (get) Token: 0x0600E89A RID: 59546 RVA: 0x0021FC19 File Offset: 0x0021DE19
		// (set) Token: 0x0600E89B RID: 59547 RVA: 0x0021FC21 File Offset: 0x0021DE21
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

		// Token: 0x17002F30 RID: 12080
		// (get) Token: 0x0600E89C RID: 59548 RVA: 0x0021FC2A File Offset: 0x0021DE2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RuleIds
		{
			get
			{
				return this.ruleIds_;
			}
		}

		// Token: 0x0600E89D RID: 59549 RVA: 0x0021FC32 File Offset: 0x0021DE32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorOnlineParkPlayerRuleInfo);
		}

		// Token: 0x0600E89E RID: 59550 RVA: 0x0021FC40 File Offset: 0x0021DE40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorOnlineParkPlayerRuleInfo other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.ruleIds_.Equals(other.ruleIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E89F RID: 59551 RVA: 0x0021FC90 File Offset: 0x0021DE90
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

		// Token: 0x0600E8A0 RID: 59552 RVA: 0x0021FCDD File Offset: 0x0021DEDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E8A1 RID: 59553 RVA: 0x0021FCEA File Offset: 0x0021DEEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E8A2 RID: 59554 RVA: 0x0021FCF4 File Offset: 0x0021DEF4
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

		// Token: 0x0600E8A3 RID: 59555 RVA: 0x0021FD44 File Offset: 0x0021DF44
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

		// Token: 0x0600E8A4 RID: 59556 RVA: 0x0021FD98 File Offset: 0x0021DF98
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

		// Token: 0x0600E8A5 RID: 59557 RVA: 0x0021FDE5 File Offset: 0x0021DFE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E8A6 RID: 59558 RVA: 0x0021FDF0 File Offset: 0x0021DFF0
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

		// Token: 0x04005F03 RID: 24323
		private static readonly MessageParser<MotorOnlineParkPlayerRuleInfo> _parser = new MessageParser<MotorOnlineParkPlayerRuleInfo>(() => new MotorOnlineParkPlayerRuleInfo());

		// Token: 0x04005F04 RID: 24324
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005F05 RID: 24325
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04005F06 RID: 24326
		private int playerId_;

		// Token: 0x04005F07 RID: 24327
		public const int RuleIdsFieldNumber = 2;

		// Token: 0x04005F08 RID: 24328
		private static readonly FieldCodec<int> _repeated_ruleIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04005F09 RID: 24329
		private readonly RepeatedField<int> ruleIds_ = new RepeatedField<int>();
	}
}
