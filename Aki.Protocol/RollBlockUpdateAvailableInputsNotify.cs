using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001125 RID: 4389
	[NetMessage(EMessageId.RollBlockUpdateAvailableInputsNotify)]
	public sealed class RollBlockUpdateAvailableInputsNotify : IMessage<RollBlockUpdateAvailableInputsNotify>, IMessage, IEquatable<RollBlockUpdateAvailableInputsNotify>, IDeepCloneable<RollBlockUpdateAvailableInputsNotify>, IBufferMessage
	{
		// Token: 0x0601772A RID: 96042 RVA: 0x00369078 File Offset: 0x00367278
		[NullableContext(1)]
		public static RollBlockUpdateAvailableInputsNotify Create()
		{
			return new RollBlockUpdateAvailableInputsNotify();
		}

		// Token: 0x17004EC5 RID: 20165
		// (get) Token: 0x0601772B RID: 96043 RVA: 0x0036907F File Offset: 0x0036727F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004EC6 RID: 20166
		// (get) Token: 0x0601772C RID: 96044 RVA: 0x00369082 File Offset: 0x00367282
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockUpdateAvailableInputsNotify.Descriptor;
			}
		}

		// Token: 0x0601772D RID: 96045 RVA: 0x00369089 File Offset: 0x00367289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockUpdateAvailableInputsNotify()
		{
		}

		// Token: 0x0601772E RID: 96046 RVA: 0x0036909C File Offset: 0x0036729C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockUpdateAvailableInputsNotify(RollBlockUpdateAvailableInputsNotify other) : this()
		{
			this.incId_ = other.incId_;
			this.availableInputs_ = other.availableInputs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601772F RID: 96047 RVA: 0x003690D2 File Offset: 0x003672D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockUpdateAvailableInputsNotify Clone()
		{
			return new RollBlockUpdateAvailableInputsNotify(this);
		}

		// Token: 0x17004EC7 RID: 20167
		// (get) Token: 0x06017730 RID: 96048 RVA: 0x003690DA File Offset: 0x003672DA
		// (set) Token: 0x06017731 RID: 96049 RVA: 0x003690E2 File Offset: 0x003672E2
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

		// Token: 0x17004EC8 RID: 20168
		// (get) Token: 0x06017732 RID: 96050 RVA: 0x003690EB File Offset: 0x003672EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RbInput> AvailableInputs
		{
			get
			{
				return this.availableInputs_;
			}
		}

		// Token: 0x06017733 RID: 96051 RVA: 0x003690F3 File Offset: 0x003672F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockUpdateAvailableInputsNotify);
		}

		// Token: 0x06017734 RID: 96052 RVA: 0x00369104 File Offset: 0x00367304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockUpdateAvailableInputsNotify other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.availableInputs_.Equals(other.availableInputs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017735 RID: 96053 RVA: 0x00369154 File Offset: 0x00367354
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

		// Token: 0x06017736 RID: 96054 RVA: 0x003691A1 File Offset: 0x003673A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017737 RID: 96055 RVA: 0x003691AE File Offset: 0x003673AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017738 RID: 96056 RVA: 0x003691B8 File Offset: 0x003673B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.IncId);
			}
			this.availableInputs_.WriteTo(ref output, RollBlockUpdateAvailableInputsNotify._repeated_availableInputs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017739 RID: 96057 RVA: 0x00369208 File Offset: 0x00367408
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

		// Token: 0x0601773A RID: 96058 RVA: 0x0036925C File Offset: 0x0036745C
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

		// Token: 0x0601773B RID: 96059 RVA: 0x003692A9 File Offset: 0x003674A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601773C RID: 96060 RVA: 0x003692B4 File Offset: 0x003674B4
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
				if (num != 16U)
				{
					if (num != 34U)
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

		// Token: 0x04008BE9 RID: 35817
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008BEA RID: 35818
		public const int IncIdFieldNumber = 2;

		// Token: 0x04008BEB RID: 35819
		private int incId_;

		// Token: 0x04008BEC RID: 35820
		public const int AvailableInputsFieldNumber = 4;

		// Token: 0x04008BED RID: 35821
		private static readonly FieldCodec<RbInput> _repeated_availableInputs_codec = FieldCodec.ForMessage<RbInput>(34U, RbInput.Parser);

		// Token: 0x04008BEE RID: 35822
		private readonly RepeatedField<RbInput> availableInputs_ = new RepeatedField<RbInput>();
	}
}
