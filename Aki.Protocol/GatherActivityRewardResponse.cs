using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006A5 RID: 1701
	[NetMessage(EMessageId.GatherActivityRewardResponse)]
	public sealed class GatherActivityRewardResponse : IMessage<GatherActivityRewardResponse>, IMessage, IEquatable<GatherActivityRewardResponse>, IDeepCloneable<GatherActivityRewardResponse>, IBufferMessage
	{
		// Token: 0x06009C52 RID: 40018 RVA: 0x0017C711 File Offset: 0x0017A911
		[NullableContext(1)]
		public static GatherActivityRewardResponse Create()
		{
			return new GatherActivityRewardResponse();
		}

		// Token: 0x17001F66 RID: 8038
		// (get) Token: 0x06009C53 RID: 40019 RVA: 0x0017C718 File Offset: 0x0017A918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F67 RID: 8039
		// (get) Token: 0x06009C54 RID: 40020 RVA: 0x0017C71B File Offset: 0x0017A91B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GatherActivityRewardResponse.Descriptor;
			}
		}

		// Token: 0x06009C55 RID: 40021 RVA: 0x0017C722 File Offset: 0x0017A922
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherActivityRewardResponse()
		{
		}

		// Token: 0x06009C56 RID: 40022 RVA: 0x0017C72A File Offset: 0x0017A92A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherActivityRewardResponse(GatherActivityRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009C57 RID: 40023 RVA: 0x0017C74F File Offset: 0x0017A94F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherActivityRewardResponse Clone()
		{
			return new GatherActivityRewardResponse(this);
		}

		// Token: 0x17001F68 RID: 8040
		// (get) Token: 0x06009C58 RID: 40024 RVA: 0x0017C757 File Offset: 0x0017A957
		// (set) Token: 0x06009C59 RID: 40025 RVA: 0x0017C75F File Offset: 0x0017A95F
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

		// Token: 0x06009C5A RID: 40026 RVA: 0x0017C768 File Offset: 0x0017A968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GatherActivityRewardResponse);
		}

		// Token: 0x06009C5B RID: 40027 RVA: 0x0017C776 File Offset: 0x0017A976
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GatherActivityRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009C5C RID: 40028 RVA: 0x0017C7A4 File Offset: 0x0017A9A4
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

		// Token: 0x06009C5D RID: 40029 RVA: 0x0017C7E9 File Offset: 0x0017A9E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009C5E RID: 40030 RVA: 0x0017C7F6 File Offset: 0x0017A9F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009C5F RID: 40031 RVA: 0x0017C7FF File Offset: 0x0017A9FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009C60 RID: 40032 RVA: 0x0017C834 File Offset: 0x0017AA34
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

		// Token: 0x06009C61 RID: 40033 RVA: 0x0017C872 File Offset: 0x0017AA72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GatherActivityRewardResponse other)
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

		// Token: 0x06009C62 RID: 40034 RVA: 0x0017C8A3 File Offset: 0x0017AAA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009C63 RID: 40035 RVA: 0x0017C8AC File Offset: 0x0017AAAC
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040049FC RID: 18940
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049FD RID: 18941
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x040049FE RID: 18942
		private ErrorCode errorCode_;
	}
}
