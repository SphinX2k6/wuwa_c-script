using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010EB RID: 4331
	[NetMessage(EMessageId.RollBlockUpdateAvailableInputsNotify)]
	public sealed class RollBlockUpdateAvailableInputsNotify : IMessage<RollBlockUpdateAvailableInputsNotify>, IMessage, IEquatable<RollBlockUpdateAvailableInputsNotify>, IDeepCloneable<RollBlockUpdateAvailableInputsNotify>, IBufferMessage
	{
		// Token: 0x06017189 RID: 94601 RVA: 0x00359D21 File Offset: 0x00357F21
		[NullableContext(1)]
		public static RollBlockUpdateAvailableInputsNotify Create()
		{
			return new RollBlockUpdateAvailableInputsNotify();
		}

		// Token: 0x17004D59 RID: 19801
		// (get) Token: 0x0601718A RID: 94602 RVA: 0x00359D28 File Offset: 0x00357F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D5A RID: 19802
		// (get) Token: 0x0601718B RID: 94603 RVA: 0x00359D2B File Offset: 0x00357F2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockUpdateAvailableInputsNotify.Descriptor;
			}
		}

		// Token: 0x0601718C RID: 94604 RVA: 0x00359D32 File Offset: 0x00357F32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockUpdateAvailableInputsNotify()
		{
		}

		// Token: 0x0601718D RID: 94605 RVA: 0x00359D45 File Offset: 0x00357F45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockUpdateAvailableInputsNotify(RollBlockUpdateAvailableInputsNotify other) : this()
		{
			this.incId_ = other.incId_;
			this.availableInputs_ = other.availableInputs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601718E RID: 94606 RVA: 0x00359D7B File Offset: 0x00357F7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockUpdateAvailableInputsNotify Clone()
		{
			return new RollBlockUpdateAvailableInputsNotify(this);
		}

		// Token: 0x17004D5B RID: 19803
		// (get) Token: 0x0601718F RID: 94607 RVA: 0x00359D83 File Offset: 0x00357F83
		// (set) Token: 0x06017190 RID: 94608 RVA: 0x00359D8B File Offset: 0x00357F8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x17004D5C RID: 19804
		// (get) Token: 0x06017191 RID: 94609 RVA: 0x00359D94 File Offset: 0x00357F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RbInput> AvailableInputs
		{
			get
			{
				return this.availableInputs_;
			}
		}

		// Token: 0x06017192 RID: 94610 RVA: 0x00359D9C File Offset: 0x00357F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockUpdateAvailableInputsNotify);
		}

		// Token: 0x06017193 RID: 94611 RVA: 0x00359DAC File Offset: 0x00357FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockUpdateAvailableInputsNotify other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.availableInputs_.Equals(other.availableInputs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017194 RID: 94612 RVA: 0x00359DFC File Offset: 0x00357FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			num ^= this.availableInputs_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017195 RID: 94613 RVA: 0x00359E49 File Offset: 0x00358049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017196 RID: 94614 RVA: 0x00359E56 File Offset: 0x00358056
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017197 RID: 94615 RVA: 0x00359E60 File Offset: 0x00358060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.IncId);
			}
			this.availableInputs_.WriteTo(ref output, RollBlockUpdateAvailableInputsNotify._repeated_availableInputs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017198 RID: 94616 RVA: 0x00359EB0 File Offset: 0x003580B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			num += this.availableInputs_.CalculateSize(RollBlockUpdateAvailableInputsNotify._repeated_availableInputs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017199 RID: 94617 RVA: 0x00359F04 File Offset: 0x00358104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockUpdateAvailableInputsNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			this.availableInputs_.Add(other.availableInputs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601719A RID: 94618 RVA: 0x00359F51 File Offset: 0x00358151
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601719B RID: 94619 RVA: 0x00359F5C File Offset: 0x0035815C
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
				if (num != 56U)
				{
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.availableInputs_.AddEntriesFrom(ref input, RollBlockUpdateAvailableInputsNotify._repeated_availableInputs_codec);
					}
				}
				else
				{
					this.IncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008956 RID: 35158
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008957 RID: 35159
		public const int IncIdFieldNumber = 7;

		// Token: 0x04008958 RID: 35160
		private int incId_;

		// Token: 0x04008959 RID: 35161
		public const int AvailableInputsFieldNumber = 9;

		// Token: 0x0400895A RID: 35162
		private static readonly FieldCodec<RbInput> _repeated_availableInputs_codec = FieldCodec.ForMessage<RbInput>(74U, RbInput.Parser);

		// Token: 0x0400895B RID: 35163
		private readonly RepeatedField<RbInput> availableInputs_ = new RepeatedField<RbInput>();
	}
}
