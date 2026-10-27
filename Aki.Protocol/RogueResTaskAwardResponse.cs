using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200100E RID: 4110
	[NetMessage(EMessageId.RogueResTaskAwardResponse)]
	public sealed class RogueResTaskAwardResponse : IMessage<RogueResTaskAwardResponse>, IMessage, IEquatable<RogueResTaskAwardResponse>, IDeepCloneable<RogueResTaskAwardResponse>, IBufferMessage
	{
		// Token: 0x06015F9F RID: 90015 RVA: 0x00331EC9 File Offset: 0x003300C9
		[NullableContext(1)]
		public static RogueResTaskAwardResponse Create()
		{
			return new RogueResTaskAwardResponse();
		}

		// Token: 0x17004974 RID: 18804
		// (get) Token: 0x06015FA0 RID: 90016 RVA: 0x00331ED0 File Offset: 0x003300D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004975 RID: 18805
		// (get) Token: 0x06015FA1 RID: 90017 RVA: 0x00331ED3 File Offset: 0x003300D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResTaskAwardResponse.Descriptor;
			}
		}

		// Token: 0x06015FA2 RID: 90018 RVA: 0x00331EDA File Offset: 0x003300DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTaskAwardResponse()
		{
		}

		// Token: 0x06015FA3 RID: 90019 RVA: 0x00331EE2 File Offset: 0x003300E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTaskAwardResponse(RogueResTaskAwardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015FA4 RID: 90020 RVA: 0x00331F07 File Offset: 0x00330107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTaskAwardResponse Clone()
		{
			return new RogueResTaskAwardResponse(this);
		}

		// Token: 0x17004976 RID: 18806
		// (get) Token: 0x06015FA5 RID: 90021 RVA: 0x00331F0F File Offset: 0x0033010F
		// (set) Token: 0x06015FA6 RID: 90022 RVA: 0x00331F17 File Offset: 0x00330117
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

		// Token: 0x06015FA7 RID: 90023 RVA: 0x00331F20 File Offset: 0x00330120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResTaskAwardResponse);
		}

		// Token: 0x06015FA8 RID: 90024 RVA: 0x00331F2E File Offset: 0x0033012E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResTaskAwardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015FA9 RID: 90025 RVA: 0x00331F5C File Offset: 0x0033015C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x06015FAA RID: 90026 RVA: 0x00331FA1 File Offset: 0x003301A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015FAB RID: 90027 RVA: 0x00331FAE File Offset: 0x003301AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015FAC RID: 90028 RVA: 0x00331FB7 File Offset: 0x003301B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015FAD RID: 90029 RVA: 0x00331FEC File Offset: 0x003301EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x06015FAE RID: 90030 RVA: 0x0033202A File Offset: 0x0033022A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResTaskAwardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015FAF RID: 90031 RVA: 0x0033205B File Offset: 0x0033025B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015FB0 RID: 90032 RVA: 0x00332064 File Offset: 0x00330264
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040083D9 RID: 33753
		private UnknownFieldSet _unknownFields;

		// Token: 0x040083DA RID: 33754
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x040083DB RID: 33755
		private ErrorCode errorCode_;
	}
}
