using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200087C RID: 2172
	public sealed class JumpTaskCondInfo : IMessage<JumpTaskCondInfo>, IMessage, IEquatable<JumpTaskCondInfo>, IDeepCloneable<JumpTaskCondInfo>, IBufferMessage
	{
		// Token: 0x0600C15F RID: 49503 RVA: 0x001CB541 File Offset: 0x001C9741
		[NullableContext(1)]
		public static JumpTaskCondInfo Create()
		{
			return new JumpTaskCondInfo();
		}

		// Token: 0x17002714 RID: 10004
		// (get) Token: 0x0600C160 RID: 49504 RVA: 0x001CB548 File Offset: 0x001C9748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JumpTaskCondInfo> Parser
		{
			get
			{
				return JumpTaskCondInfo._parser;
			}
		}

		// Token: 0x17002715 RID: 10005
		// (get) Token: 0x0600C161 RID: 49505 RVA: 0x001CB54F File Offset: 0x001C974F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002716 RID: 10006
		// (get) Token: 0x0600C162 RID: 49506 RVA: 0x001CB552 File Offset: 0x001C9752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JumpTaskCondInfo.Descriptor;
			}
		}

		// Token: 0x0600C163 RID: 49507 RVA: 0x001CB559 File Offset: 0x001C9759
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JumpTaskCondInfo()
		{
		}

		// Token: 0x0600C164 RID: 49508 RVA: 0x001CB56C File Offset: 0x001C976C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JumpTaskCondInfo(JumpTaskCondInfo other) : this()
		{
			this.jumpTaskId_ = other.jumpTaskId_;
			this.conditionGroupIds_ = other.conditionGroupIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C165 RID: 49509 RVA: 0x001CB5A2 File Offset: 0x001C97A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JumpTaskCondInfo Clone()
		{
			return new JumpTaskCondInfo(this);
		}

		// Token: 0x17002717 RID: 10007
		// (get) Token: 0x0600C166 RID: 49510 RVA: 0x001CB5AA File Offset: 0x001C97AA
		// (set) Token: 0x0600C167 RID: 49511 RVA: 0x001CB5B2 File Offset: 0x001C97B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int JumpTaskId
		{
			get
			{
				return this.jumpTaskId_;
			}
			set
			{
				this.jumpTaskId_ = value;
			}
		}

		// Token: 0x17002718 RID: 10008
		// (get) Token: 0x0600C168 RID: 49512 RVA: 0x001CB5BB File Offset: 0x001C97BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ConditionGroupIds
		{
			get
			{
				return this.conditionGroupIds_;
			}
		}

		// Token: 0x0600C169 RID: 49513 RVA: 0x001CB5C3 File Offset: 0x001C97C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JumpTaskCondInfo);
		}

		// Token: 0x0600C16A RID: 49514 RVA: 0x001CB5D4 File Offset: 0x001C97D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JumpTaskCondInfo other)
		{
			return other != null && (other == this || (this.JumpTaskId == other.JumpTaskId && this.conditionGroupIds_.Equals(other.conditionGroupIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C16B RID: 49515 RVA: 0x001CB624 File Offset: 0x001C9824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.JumpTaskId != 0)
			{
				num ^= this.JumpTaskId.GetHashCode();
			}
			num ^= this.conditionGroupIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C16C RID: 49516 RVA: 0x001CB671 File Offset: 0x001C9871
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C16D RID: 49517 RVA: 0x001CB67E File Offset: 0x001C987E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C16E RID: 49518 RVA: 0x001CB688 File Offset: 0x001C9888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.JumpTaskId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.JumpTaskId);
			}
			this.conditionGroupIds_.WriteTo(ref output, JumpTaskCondInfo._repeated_conditionGroupIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C16F RID: 49519 RVA: 0x001CB6D8 File Offset: 0x001C98D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.JumpTaskId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.JumpTaskId);
			}
			num += this.conditionGroupIds_.CalculateSize(JumpTaskCondInfo._repeated_conditionGroupIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C170 RID: 49520 RVA: 0x001CB72C File Offset: 0x001C992C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JumpTaskCondInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.JumpTaskId != 0)
			{
				this.JumpTaskId = other.JumpTaskId;
			}
			this.conditionGroupIds_.Add(other.conditionGroupIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C171 RID: 49521 RVA: 0x001CB779 File Offset: 0x001C9979
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C172 RID: 49522 RVA: 0x001CB784 File Offset: 0x001C9984
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
						this.conditionGroupIds_.AddEntriesFrom(ref input, JumpTaskCondInfo._repeated_conditionGroupIds_codec);
					}
				}
				else
				{
					this.JumpTaskId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040053DF RID: 21471
		private static readonly MessageParser<JumpTaskCondInfo> _parser = new MessageParser<JumpTaskCondInfo>(() => new JumpTaskCondInfo());

		// Token: 0x040053E0 RID: 21472
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053E1 RID: 21473
		public const int JumpTaskIdFieldNumber = 1;

		// Token: 0x040053E2 RID: 21474
		private int jumpTaskId_;

		// Token: 0x040053E3 RID: 21475
		public const int ConditionGroupIdsFieldNumber = 2;

		// Token: 0x040053E4 RID: 21476
		private static readonly FieldCodec<int> _repeated_conditionGroupIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040053E5 RID: 21477
		private readonly RepeatedField<int> conditionGroupIds_ = new RepeatedField<int>();
	}
}
