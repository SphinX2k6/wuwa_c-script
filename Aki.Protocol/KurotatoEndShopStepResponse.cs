using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000893 RID: 2195
	[NetMessage(EMessageId.KurotatoEndShopStepResponse)]
	public sealed class KurotatoEndShopStepResponse : IMessage<KurotatoEndShopStepResponse>, IMessage, IEquatable<KurotatoEndShopStepResponse>, IDeepCloneable<KurotatoEndShopStepResponse>, IBufferMessage
	{
		// Token: 0x0600C327 RID: 49959 RVA: 0x001CF1A9 File Offset: 0x001CD3A9
		[NullableContext(1)]
		public static KurotatoEndShopStepResponse Create()
		{
			return new KurotatoEndShopStepResponse();
		}

		// Token: 0x17002772 RID: 10098
		// (get) Token: 0x0600C328 RID: 49960 RVA: 0x001CF1B0 File Offset: 0x001CD3B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002773 RID: 10099
		// (get) Token: 0x0600C329 RID: 49961 RVA: 0x001CF1B3 File Offset: 0x001CD3B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoEndShopStepResponse.Descriptor;
			}
		}

		// Token: 0x0600C32A RID: 49962 RVA: 0x001CF1BA File Offset: 0x001CD3BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoEndShopStepResponse()
		{
		}

		// Token: 0x0600C32B RID: 49963 RVA: 0x001CF1C2 File Offset: 0x001CD3C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoEndShopStepResponse(KurotatoEndShopStepResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C32C RID: 49964 RVA: 0x001CF1E7 File Offset: 0x001CD3E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoEndShopStepResponse Clone()
		{
			return new KurotatoEndShopStepResponse(this);
		}

		// Token: 0x17002774 RID: 10100
		// (get) Token: 0x0600C32D RID: 49965 RVA: 0x001CF1EF File Offset: 0x001CD3EF
		// (set) Token: 0x0600C32E RID: 49966 RVA: 0x001CF1F7 File Offset: 0x001CD3F7
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

		// Token: 0x0600C32F RID: 49967 RVA: 0x001CF200 File Offset: 0x001CD400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoEndShopStepResponse);
		}

		// Token: 0x0600C330 RID: 49968 RVA: 0x001CF20E File Offset: 0x001CD40E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoEndShopStepResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C331 RID: 49969 RVA: 0x001CF23C File Offset: 0x001CD43C
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

		// Token: 0x0600C332 RID: 49970 RVA: 0x001CF281 File Offset: 0x001CD481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C333 RID: 49971 RVA: 0x001CF28E File Offset: 0x001CD48E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C334 RID: 49972 RVA: 0x001CF297 File Offset: 0x001CD497
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C335 RID: 49973 RVA: 0x001CF2CC File Offset: 0x001CD4CC
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

		// Token: 0x0600C336 RID: 49974 RVA: 0x001CF30A File Offset: 0x001CD50A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoEndShopStepResponse other)
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

		// Token: 0x0600C337 RID: 49975 RVA: 0x001CF33B File Offset: 0x001CD53B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C338 RID: 49976 RVA: 0x001CF344 File Offset: 0x001CD544
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400545F RID: 21599
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005460 RID: 21600
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04005461 RID: 21601
		private ErrorCode errorCode_;
	}
}
