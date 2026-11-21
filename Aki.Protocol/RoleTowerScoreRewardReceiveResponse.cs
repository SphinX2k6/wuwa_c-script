using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010E9 RID: 4329
	[NetMessage(EMessageId.RoleTowerScoreRewardReceiveResponse)]
	public sealed class RoleTowerScoreRewardReceiveResponse : IMessage<RoleTowerScoreRewardReceiveResponse>, IMessage, IEquatable<RoleTowerScoreRewardReceiveResponse>, IDeepCloneable<RoleTowerScoreRewardReceiveResponse>, IBufferMessage
	{
		// Token: 0x06017246 RID: 94790 RVA: 0x0035DDED File Offset: 0x0035BFED
		[NullableContext(1)]
		public static RoleTowerScoreRewardReceiveResponse Create()
		{
			return new RoleTowerScoreRewardReceiveResponse();
		}

		// Token: 0x17004DB5 RID: 19893
		// (get) Token: 0x06017247 RID: 94791 RVA: 0x0035DDF4 File Offset: 0x0035BFF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004DB6 RID: 19894
		// (get) Token: 0x06017248 RID: 94792 RVA: 0x0035DDF7 File Offset: 0x0035BFF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerScoreRewardReceiveResponse.Descriptor;
			}
		}

		// Token: 0x06017249 RID: 94793 RVA: 0x0035DDFE File Offset: 0x0035BFFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerScoreRewardReceiveResponse()
		{
		}

		// Token: 0x0601724A RID: 94794 RVA: 0x0035DE06 File Offset: 0x0035C006
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerScoreRewardReceiveResponse(RoleTowerScoreRewardReceiveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601724B RID: 94795 RVA: 0x0035DE2B File Offset: 0x0035C02B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerScoreRewardReceiveResponse Clone()
		{
			return new RoleTowerScoreRewardReceiveResponse(this);
		}

		// Token: 0x17004DB7 RID: 19895
		// (get) Token: 0x0601724C RID: 94796 RVA: 0x0035DE33 File Offset: 0x0035C033
		// (set) Token: 0x0601724D RID: 94797 RVA: 0x0035DE3B File Offset: 0x0035C03B
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

		// Token: 0x0601724E RID: 94798 RVA: 0x0035DE44 File Offset: 0x0035C044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerScoreRewardReceiveResponse);
		}

		// Token: 0x0601724F RID: 94799 RVA: 0x0035DE52 File Offset: 0x0035C052
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerScoreRewardReceiveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017250 RID: 94800 RVA: 0x0035DE80 File Offset: 0x0035C080
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

		// Token: 0x06017251 RID: 94801 RVA: 0x0035DEC5 File Offset: 0x0035C0C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017252 RID: 94802 RVA: 0x0035DED2 File Offset: 0x0035C0D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017253 RID: 94803 RVA: 0x0035DEDB File Offset: 0x0035C0DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017254 RID: 94804 RVA: 0x0035DF10 File Offset: 0x0035C110
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

		// Token: 0x06017255 RID: 94805 RVA: 0x0035DF4E File Offset: 0x0035C14E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerScoreRewardReceiveResponse other)
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

		// Token: 0x06017256 RID: 94806 RVA: 0x0035DF7F File Offset: 0x0035C17F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017257 RID: 94807 RVA: 0x0035DF88 File Offset: 0x0035C188
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008A7A RID: 35450
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A7B RID: 35451
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04008A7C RID: 35452
		private ErrorCode errorCode_;
	}
}
