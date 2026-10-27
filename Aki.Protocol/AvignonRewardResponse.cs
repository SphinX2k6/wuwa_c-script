using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000130 RID: 304
	[NetMessage(EMessageId.AvignonRewardResponse)]
	public sealed class AvignonRewardResponse : IMessage<AvignonRewardResponse>, IMessage, IEquatable<AvignonRewardResponse>, IDeepCloneable<AvignonRewardResponse>, IBufferMessage
	{
		// Token: 0x06002827 RID: 10279 RVA: 0x00069D98 File Offset: 0x00067F98
		[NullableContext(1)]
		public static AvignonRewardResponse Create()
		{
			return new AvignonRewardResponse();
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06002828 RID: 10280 RVA: 0x00069D9F File Offset: 0x00067F9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06002829 RID: 10281 RVA: 0x00069DA2 File Offset: 0x00067FA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AvignonRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600282A RID: 10282 RVA: 0x00069DA9 File Offset: 0x00067FA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvignonRewardResponse()
		{
		}

		// Token: 0x0600282B RID: 10283 RVA: 0x00069DB1 File Offset: 0x00067FB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvignonRewardResponse(AvignonRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600282C RID: 10284 RVA: 0x00069DD6 File Offset: 0x00067FD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvignonRewardResponse Clone()
		{
			return new AvignonRewardResponse(this);
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x0600282D RID: 10285 RVA: 0x00069DDE File Offset: 0x00067FDE
		// (set) Token: 0x0600282E RID: 10286 RVA: 0x00069DE6 File Offset: 0x00067FE6
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

		// Token: 0x0600282F RID: 10287 RVA: 0x00069DEF File Offset: 0x00067FEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AvignonRewardResponse);
		}

		// Token: 0x06002830 RID: 10288 RVA: 0x00069DFD File Offset: 0x00067FFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AvignonRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002831 RID: 10289 RVA: 0x00069E2C File Offset: 0x0006802C
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

		// Token: 0x06002832 RID: 10290 RVA: 0x00069E71 File Offset: 0x00068071
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002833 RID: 10291 RVA: 0x00069E7E File Offset: 0x0006807E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002834 RID: 10292 RVA: 0x00069E87 File Offset: 0x00068087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002835 RID: 10293 RVA: 0x00069EBC File Offset: 0x000680BC
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

		// Token: 0x06002836 RID: 10294 RVA: 0x00069EFA File Offset: 0x000680FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AvignonRewardResponse other)
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

		// Token: 0x06002837 RID: 10295 RVA: 0x00069F2B File Offset: 0x0006812B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002838 RID: 10296 RVA: 0x00069F34 File Offset: 0x00068134
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002692 RID: 9874
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002693 RID: 9875
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04002694 RID: 9876
		private ErrorCode errorCode_;
	}
}
