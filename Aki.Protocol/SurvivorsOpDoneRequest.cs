using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012D8 RID: 4824
	[NetMessage(EMessageId.SurvivorsOpDoneRequest)]
	public sealed class SurvivorsOpDoneRequest : IMessage<SurvivorsOpDoneRequest>, IMessage, IEquatable<SurvivorsOpDoneRequest>, IDeepCloneable<SurvivorsOpDoneRequest>, IBufferMessage
	{
		// Token: 0x06019A9F RID: 105119 RVA: 0x003BB33B File Offset: 0x003B953B
		[NullableContext(1)]
		public static SurvivorsOpDoneRequest Create()
		{
			return new SurvivorsOpDoneRequest();
		}

		// Token: 0x17005696 RID: 22166
		// (get) Token: 0x06019AA0 RID: 105120 RVA: 0x003BB342 File Offset: 0x003B9542
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005697 RID: 22167
		// (get) Token: 0x06019AA1 RID: 105121 RVA: 0x003BB345 File Offset: 0x003B9545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsOpDoneRequest.Descriptor;
			}
		}

		// Token: 0x06019AA2 RID: 105122 RVA: 0x003BB34C File Offset: 0x003B954C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsOpDoneRequest()
		{
		}

		// Token: 0x06019AA3 RID: 105123 RVA: 0x003BB35F File Offset: 0x003B955F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsOpDoneRequest(SurvivorsOpDoneRequest other) : this()
		{
			this.incId_ = other.incId_;
			this.clientSelectIds_ = other.clientSelectIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019AA4 RID: 105124 RVA: 0x003BB395 File Offset: 0x003B9595
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsOpDoneRequest Clone()
		{
			return new SurvivorsOpDoneRequest(this);
		}

		// Token: 0x17005698 RID: 22168
		// (get) Token: 0x06019AA5 RID: 105125 RVA: 0x003BB39D File Offset: 0x003B959D
		// (set) Token: 0x06019AA6 RID: 105126 RVA: 0x003BB3A5 File Offset: 0x003B95A5
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

		// Token: 0x17005699 RID: 22169
		// (get) Token: 0x06019AA7 RID: 105127 RVA: 0x003BB3AE File Offset: 0x003B95AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ClientSelectIds
		{
			get
			{
				return this.clientSelectIds_;
			}
		}

		// Token: 0x06019AA8 RID: 105128 RVA: 0x003BB3B6 File Offset: 0x003B95B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsOpDoneRequest);
		}

		// Token: 0x06019AA9 RID: 105129 RVA: 0x003BB3C4 File Offset: 0x003B95C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsOpDoneRequest other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.clientSelectIds_.Equals(other.clientSelectIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019AAA RID: 105130 RVA: 0x003BB414 File Offset: 0x003B9614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			num ^= this.clientSelectIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019AAB RID: 105131 RVA: 0x003BB461 File Offset: 0x003B9661
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019AAC RID: 105132 RVA: 0x003BB46E File Offset: 0x003B966E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019AAD RID: 105133 RVA: 0x003BB478 File Offset: 0x003B9678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.clientSelectIds_.WriteTo(ref output, SurvivorsOpDoneRequest._repeated_clientSelectIds_codec);
			if (this.IncId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019AAE RID: 105134 RVA: 0x003BB4C8 File Offset: 0x003B96C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			num += this.clientSelectIds_.CalculateSize(SurvivorsOpDoneRequest._repeated_clientSelectIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019AAF RID: 105135 RVA: 0x003BB51C File Offset: 0x003B971C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsOpDoneRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			this.clientSelectIds_.Add(other.clientSelectIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019AB0 RID: 105136 RVA: 0x003BB569 File Offset: 0x003B9769
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019AB1 RID: 105137 RVA: 0x003BB574 File Offset: 0x003B9774
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
				if (num != 32U && num != 34U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IncId = input.ReadInt32();
					}
				}
				else
				{
					this.clientSelectIds_.AddEntriesFrom(ref input, SurvivorsOpDoneRequest._repeated_clientSelectIds_codec);
				}
			}
		}

		// Token: 0x04009674 RID: 38516
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009675 RID: 38517
		public const int IncIdFieldNumber = 6;

		// Token: 0x04009676 RID: 38518
		private int incId_;

		// Token: 0x04009677 RID: 38519
		public const int ClientSelectIdsFieldNumber = 4;

		// Token: 0x04009678 RID: 38520
		private static readonly FieldCodec<int> _repeated_clientSelectIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04009679 RID: 38521
		private readonly RepeatedField<int> clientSelectIds_ = new RepeatedField<int>();
	}
}
