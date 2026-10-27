using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000934 RID: 2356
	[NetMessage(EMessageId.LivenessTakeResponse)]
	public sealed class LivenessTakeResponse : IMessage<LivenessTakeResponse>, IMessage, IEquatable<LivenessTakeResponse>, IDeepCloneable<LivenessTakeResponse>, IBufferMessage
	{
		// Token: 0x0600CFAA RID: 53162 RVA: 0x001E9219 File Offset: 0x001E7419
		[NullableContext(1)]
		public static LivenessTakeResponse Create()
		{
			return new LivenessTakeResponse();
		}

		// Token: 0x170029F3 RID: 10739
		// (get) Token: 0x0600CFAB RID: 53163 RVA: 0x001E9220 File Offset: 0x001E7420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029F4 RID: 10740
		// (get) Token: 0x0600CFAC RID: 53164 RVA: 0x001E9223 File Offset: 0x001E7423
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LivenessTakeResponse.Descriptor;
			}
		}

		// Token: 0x0600CFAD RID: 53165 RVA: 0x001E922A File Offset: 0x001E742A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessTakeResponse()
		{
		}

		// Token: 0x0600CFAE RID: 53166 RVA: 0x001E923D File Offset: 0x001E743D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessTakeResponse(LivenessTakeResponse other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CFAF RID: 53167 RVA: 0x001E9273 File Offset: 0x001E7473
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessTakeResponse Clone()
		{
			return new LivenessTakeResponse(this);
		}

		// Token: 0x170029F5 RID: 10741
		// (get) Token: 0x0600CFB0 RID: 53168 RVA: 0x001E927B File Offset: 0x001E747B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x170029F6 RID: 10742
		// (get) Token: 0x0600CFB1 RID: 53169 RVA: 0x001E9283 File Offset: 0x001E7483
		// (set) Token: 0x0600CFB2 RID: 53170 RVA: 0x001E928B File Offset: 0x001E748B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x0600CFB3 RID: 53171 RVA: 0x001E9294 File Offset: 0x001E7494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LivenessTakeResponse);
		}

		// Token: 0x0600CFB4 RID: 53172 RVA: 0x001E92A4 File Offset: 0x001E74A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LivenessTakeResponse other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CFB5 RID: 53173 RVA: 0x001E92F4 File Offset: 0x001E74F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ids_.GetHashCode();
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CFB6 RID: 53174 RVA: 0x001E9347 File Offset: 0x001E7547
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CFB7 RID: 53175 RVA: 0x001E9354 File Offset: 0x001E7554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CFB8 RID: 53176 RVA: 0x001E9360 File Offset: 0x001E7560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.ids_.WriteTo(ref output, LivenessTakeResponse._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CFB9 RID: 53177 RVA: 0x001E93B0 File Offset: 0x001E75B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ids_.CalculateSize(LivenessTakeResponse._repeated_ids_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CFBA RID: 53178 RVA: 0x001E9404 File Offset: 0x001E7604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LivenessTakeResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.ids_.Add(other.ids_);
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CFBB RID: 53179 RVA: 0x001E9451 File Offset: 0x001E7651
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CFBC RID: 53180 RVA: 0x001E945C File Offset: 0x001E765C
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
					if (num != 32U && num != 34U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ids_.AddEntriesFrom(ref input, LivenessTakeResponse._repeated_ids_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005793 RID: 22419
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005794 RID: 22420
		public const int IdsFieldNumber = 4;

		// Token: 0x04005795 RID: 22421
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04005796 RID: 22422
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();

		// Token: 0x04005797 RID: 22423
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04005798 RID: 22424
		private ErrorCode errorCode_;
	}
}
