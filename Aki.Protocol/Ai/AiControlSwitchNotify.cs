using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x020016AB RID: 5803
	[NetMessage(EMessageId.AiControlSwitchNotify)]
	public sealed class AiControlSwitchNotify : IMessage<AiControlSwitchNotify>, IMessage, IEquatable<AiControlSwitchNotify>, IDeepCloneable<AiControlSwitchNotify>, IBufferMessage
	{
		// Token: 0x0601D13D RID: 119101 RVA: 0x00441629 File Offset: 0x0043F829
		[NullableContext(1)]
		public static AiControlSwitchNotify Create()
		{
			return new AiControlSwitchNotify();
		}

		// Token: 0x170062A9 RID: 25257
		// (get) Token: 0x0601D13E RID: 119102 RVA: 0x00441630 File Offset: 0x0043F830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170062AA RID: 25258
		// (get) Token: 0x0601D13F RID: 119103 RVA: 0x00441633 File Offset: 0x0043F833
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiControlSwitchNotify.Descriptor;
			}
		}

		// Token: 0x0601D140 RID: 119104 RVA: 0x0044163A File Offset: 0x0043F83A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiControlSwitchNotify()
		{
		}

		// Token: 0x0601D141 RID: 119105 RVA: 0x0044164D File Offset: 0x0043F84D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiControlSwitchNotify(AiControlSwitchNotify other) : this()
		{
			this.aiControlSwitchInfos_ = other.aiControlSwitchInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D142 RID: 119106 RVA: 0x00441677 File Offset: 0x0043F877
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiControlSwitchNotify Clone()
		{
			return new AiControlSwitchNotify(this);
		}

		// Token: 0x170062AB RID: 25259
		// (get) Token: 0x0601D143 RID: 119107 RVA: 0x0044167F File Offset: 0x0043F87F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AiControlSwitch> AiControlSwitchInfos
		{
			get
			{
				return this.aiControlSwitchInfos_;
			}
		}

		// Token: 0x0601D144 RID: 119108 RVA: 0x00441687 File Offset: 0x0043F887
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiControlSwitchNotify);
		}

		// Token: 0x0601D145 RID: 119109 RVA: 0x00441695 File Offset: 0x0043F895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiControlSwitchNotify other)
		{
			return other != null && (other == this || (this.aiControlSwitchInfos_.Equals(other.aiControlSwitchInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D146 RID: 119110 RVA: 0x004416C8 File Offset: 0x0043F8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.aiControlSwitchInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D147 RID: 119111 RVA: 0x004416FC File Offset: 0x0043F8FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D148 RID: 119112 RVA: 0x00441709 File Offset: 0x0043F909
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D149 RID: 119113 RVA: 0x00441712 File Offset: 0x0043F912
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.aiControlSwitchInfos_.WriteTo(ref output, AiControlSwitchNotify._repeated_aiControlSwitchInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D14A RID: 119114 RVA: 0x0044173C File Offset: 0x0043F93C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.aiControlSwitchInfos_.CalculateSize(AiControlSwitchNotify._repeated_aiControlSwitchInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D14B RID: 119115 RVA: 0x00441775 File Offset: 0x0043F975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AiControlSwitchNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.aiControlSwitchInfos_.Add(other.aiControlSwitchInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D14C RID: 119116 RVA: 0x004417A3 File Offset: 0x0043F9A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D14D RID: 119117 RVA: 0x004417AC File Offset: 0x0043F9AC
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.aiControlSwitchInfos_.AddEntriesFrom(ref input, AiControlSwitchNotify._repeated_aiControlSwitchInfos_codec);
				}
			}
		}

		// Token: 0x0400C430 RID: 50224
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C431 RID: 50225
		public const int AiControlSwitchInfosFieldNumber = 12;

		// Token: 0x0400C432 RID: 50226
		private static readonly FieldCodec<AiControlSwitch> _repeated_aiControlSwitchInfos_codec = FieldCodec.ForMessage<AiControlSwitch>(98U, AiControlSwitch.Parser);

		// Token: 0x0400C433 RID: 50227
		private readonly RepeatedField<AiControlSwitch> aiControlSwitchInfos_ = new RepeatedField<AiControlSwitch>();
	}
}
