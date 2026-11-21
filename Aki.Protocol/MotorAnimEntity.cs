using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A0B RID: 2571
	public sealed class MotorAnimEntity : IMessage<MotorAnimEntity>, IMessage, IEquatable<MotorAnimEntity>, IDeepCloneable<MotorAnimEntity>, IBufferMessage
	{
		// Token: 0x0600E13A RID: 57658 RVA: 0x002102D6 File Offset: 0x0020E4D6
		[NullableContext(1)]
		public static MotorAnimEntity Create()
		{
			return new MotorAnimEntity();
		}

		// Token: 0x17002DA8 RID: 11688
		// (get) Token: 0x0600E13B RID: 57659 RVA: 0x002102DD File Offset: 0x0020E4DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorAnimEntity> Parser
		{
			get
			{
				return MotorAnimEntity._parser;
			}
		}

		// Token: 0x17002DA9 RID: 11689
		// (get) Token: 0x0600E13C RID: 57660 RVA: 0x002102E4 File Offset: 0x0020E4E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DAA RID: 11690
		// (get) Token: 0x0600E13D RID: 57661 RVA: 0x002102E7 File Offset: 0x0020E4E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorAnimEntity.Descriptor;
			}
		}

		// Token: 0x0600E13E RID: 57662 RVA: 0x002102EE File Offset: 0x0020E4EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorAnimEntity()
		{
		}

		// Token: 0x0600E13F RID: 57663 RVA: 0x00210301 File Offset: 0x0020E501
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorAnimEntity(MotorAnimEntity other) : this()
		{
			this.entityId_ = other.entityId_;
			this.motorAnimInfos_ = other.motorAnimInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E140 RID: 57664 RVA: 0x00210337 File Offset: 0x0020E537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorAnimEntity Clone()
		{
			return new MotorAnimEntity(this);
		}

		// Token: 0x17002DAB RID: 11691
		// (get) Token: 0x0600E141 RID: 57665 RVA: 0x0021033F File Offset: 0x0020E53F
		// (set) Token: 0x0600E142 RID: 57666 RVA: 0x00210347 File Offset: 0x0020E547
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17002DAC RID: 11692
		// (get) Token: 0x0600E143 RID: 57667 RVA: 0x00210350 File Offset: 0x0020E550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorAnimInfo> MotorAnimInfos
		{
			get
			{
				return this.motorAnimInfos_;
			}
		}

		// Token: 0x0600E144 RID: 57668 RVA: 0x00210358 File Offset: 0x0020E558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorAnimEntity);
		}

		// Token: 0x0600E145 RID: 57669 RVA: 0x00210368 File Offset: 0x0020E568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorAnimEntity other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.motorAnimInfos_.Equals(other.motorAnimInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E146 RID: 57670 RVA: 0x002103B8 File Offset: 0x0020E5B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			num ^= this.motorAnimInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E147 RID: 57671 RVA: 0x00210405 File Offset: 0x0020E605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E148 RID: 57672 RVA: 0x00210412 File Offset: 0x0020E612
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E149 RID: 57673 RVA: 0x0021041C File Offset: 0x0020E61C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			this.motorAnimInfos_.WriteTo(ref output, MotorAnimEntity._repeated_motorAnimInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E14A RID: 57674 RVA: 0x0021046C File Offset: 0x0020E66C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			num += this.motorAnimInfos_.CalculateSize(MotorAnimEntity._repeated_motorAnimInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E14B RID: 57675 RVA: 0x002104C0 File Offset: 0x0020E6C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorAnimEntity other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this.motorAnimInfos_.Add(other.motorAnimInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E14C RID: 57676 RVA: 0x0021050D File Offset: 0x0020E70D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E14D RID: 57677 RVA: 0x00210518 File Offset: 0x0020E718
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.motorAnimInfos_.AddEntriesFrom(ref input, MotorAnimEntity._repeated_motorAnimInfos_codec);
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04005CF6 RID: 23798
		private static readonly MessageParser<MotorAnimEntity> _parser = new MessageParser<MotorAnimEntity>(() => new MotorAnimEntity());

		// Token: 0x04005CF7 RID: 23799
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005CF8 RID: 23800
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04005CF9 RID: 23801
		private long entityId_;

		// Token: 0x04005CFA RID: 23802
		public const int MotorAnimInfosFieldNumber = 2;

		// Token: 0x04005CFB RID: 23803
		private static readonly FieldCodec<MotorAnimInfo> _repeated_motorAnimInfos_codec = FieldCodec.ForMessage<MotorAnimInfo>(18U, MotorAnimInfo.Parser);

		// Token: 0x04005CFC RID: 23804
		private readonly RepeatedField<MotorAnimInfo> motorAnimInfos_ = new RepeatedField<MotorAnimInfo>();
	}
}
