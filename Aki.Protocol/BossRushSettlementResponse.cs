using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001E0 RID: 480
	[NetMessage(EMessageId.BossRushSettlementResponse)]
	public sealed class BossRushSettlementResponse : IMessage<BossRushSettlementResponse>, IMessage, IEquatable<BossRushSettlementResponse>, IDeepCloneable<BossRushSettlementResponse>, IBufferMessage
	{
		// Token: 0x06003623 RID: 13859 RVA: 0x0008812A File Offset: 0x0008632A
		[NullableContext(1)]
		public static BossRushSettlementResponse Create()
		{
			return new BossRushSettlementResponse();
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06003624 RID: 13860 RVA: 0x00088131 File Offset: 0x00086331
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06003625 RID: 13861 RVA: 0x00088134 File Offset: 0x00086334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushSettlementResponse.Descriptor;
			}
		}

		// Token: 0x06003626 RID: 13862 RVA: 0x0008813B File Offset: 0x0008633B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushSettlementResponse()
		{
		}

		// Token: 0x06003627 RID: 13863 RVA: 0x00088143 File Offset: 0x00086343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushSettlementResponse(BossRushSettlementResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003628 RID: 13864 RVA: 0x00088168 File Offset: 0x00086368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushSettlementResponse Clone()
		{
			return new BossRushSettlementResponse(this);
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x06003629 RID: 13865 RVA: 0x00088170 File Offset: 0x00086370
		// (set) Token: 0x0600362A RID: 13866 RVA: 0x00088178 File Offset: 0x00086378
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

		// Token: 0x0600362B RID: 13867 RVA: 0x00088181 File Offset: 0x00086381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushSettlementResponse);
		}

		// Token: 0x0600362C RID: 13868 RVA: 0x0008818F File Offset: 0x0008638F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushSettlementResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600362D RID: 13869 RVA: 0x000881C0 File Offset: 0x000863C0
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

		// Token: 0x0600362E RID: 13870 RVA: 0x00088205 File Offset: 0x00086405
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600362F RID: 13871 RVA: 0x00088212 File Offset: 0x00086412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003630 RID: 13872 RVA: 0x0008821B File Offset: 0x0008641B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003631 RID: 13873 RVA: 0x0008824C File Offset: 0x0008644C
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

		// Token: 0x06003632 RID: 13874 RVA: 0x0008828A File Offset: 0x0008648A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossRushSettlementResponse other)
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

		// Token: 0x06003633 RID: 13875 RVA: 0x000882BB File Offset: 0x000864BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003634 RID: 13876 RVA: 0x000882C4 File Offset: 0x000864C4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002A92 RID: 10898
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A93 RID: 10899
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04002A94 RID: 10900
		private ErrorCode errorCode_;
	}
}
