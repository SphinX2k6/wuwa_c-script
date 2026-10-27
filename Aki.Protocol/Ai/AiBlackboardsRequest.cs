using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x020016A8 RID: 5800
	[NetMessage(EMessageId.AiBlackboardsRequest)]
	public sealed class AiBlackboardsRequest : IMessage<AiBlackboardsRequest>, IMessage, IEquatable<AiBlackboardsRequest>, IDeepCloneable<AiBlackboardsRequest>, IBufferMessage
	{
		// Token: 0x0601D101 RID: 119041 RVA: 0x00440EB9 File Offset: 0x0043F0B9
		[NullableContext(1)]
		public static AiBlackboardsRequest Create()
		{
			return new AiBlackboardsRequest();
		}

		// Token: 0x1700629D RID: 25245
		// (get) Token: 0x0601D102 RID: 119042 RVA: 0x00440EC0 File Offset: 0x0043F0C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700629E RID: 25246
		// (get) Token: 0x0601D103 RID: 119043 RVA: 0x00440EC3 File Offset: 0x0043F0C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiBlackboardsRequest.Descriptor;
			}
		}

		// Token: 0x0601D104 RID: 119044 RVA: 0x00440ECA File Offset: 0x0043F0CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardsRequest()
		{
		}

		// Token: 0x0601D105 RID: 119045 RVA: 0x00440EDD File Offset: 0x0043F0DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardsRequest(AiBlackboardsRequest other) : this()
		{
			this.aiBlackboards_ = other.aiBlackboards_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D106 RID: 119046 RVA: 0x00440F07 File Offset: 0x0043F107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardsRequest Clone()
		{
			return new AiBlackboardsRequest(this);
		}

		// Token: 0x1700629F RID: 25247
		// (get) Token: 0x0601D107 RID: 119047 RVA: 0x00440F0F File Offset: 0x0043F10F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BlackboardParam> AiBlackboards
		{
			get
			{
				return this.aiBlackboards_;
			}
		}

		// Token: 0x0601D108 RID: 119048 RVA: 0x00440F17 File Offset: 0x0043F117
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiBlackboardsRequest);
		}

		// Token: 0x0601D109 RID: 119049 RVA: 0x00440F25 File Offset: 0x0043F125
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiBlackboardsRequest other)
		{
			return other != null && (other == this || (this.aiBlackboards_.Equals(other.aiBlackboards_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D10A RID: 119050 RVA: 0x00440F58 File Offset: 0x0043F158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.aiBlackboards_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D10B RID: 119051 RVA: 0x00440F8C File Offset: 0x0043F18C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D10C RID: 119052 RVA: 0x00440F99 File Offset: 0x0043F199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D10D RID: 119053 RVA: 0x00440FA2 File Offset: 0x0043F1A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.aiBlackboards_.WriteTo(ref output, AiBlackboardsRequest._repeated_aiBlackboards_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D10E RID: 119054 RVA: 0x00440FCC File Offset: 0x0043F1CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.aiBlackboards_.CalculateSize(AiBlackboardsRequest._repeated_aiBlackboards_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D10F RID: 119055 RVA: 0x00441005 File Offset: 0x0043F205
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AiBlackboardsRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.aiBlackboards_.Add(other.aiBlackboards_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D110 RID: 119056 RVA: 0x00441033 File Offset: 0x0043F233
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D111 RID: 119057 RVA: 0x0044103C File Offset: 0x0043F23C
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.aiBlackboards_.AddEntriesFrom(ref input, AiBlackboardsRequest._repeated_aiBlackboards_codec);
				}
			}
		}

		// Token: 0x0400C421 RID: 50209
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C422 RID: 50210
		public const int AiBlackboardsFieldNumber = 14;

		// Token: 0x0400C423 RID: 50211
		private static readonly FieldCodec<BlackboardParam> _repeated_aiBlackboards_codec = FieldCodec.ForMessage<BlackboardParam>(114U, BlackboardParam.Parser);

		// Token: 0x0400C424 RID: 50212
		private readonly RepeatedField<BlackboardParam> aiBlackboards_ = new RepeatedField<BlackboardParam>();
	}
}
