using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010F3 RID: 4339
	[NetMessage(EMessageId.RoleTowerStageSettleResponse)]
	public sealed class RoleTowerStageSettleResponse : IMessage<RoleTowerStageSettleResponse>, IMessage, IEquatable<RoleTowerStageSettleResponse>, IDeepCloneable<RoleTowerStageSettleResponse>, IBufferMessage
	{
		// Token: 0x06017326 RID: 95014 RVA: 0x00360176 File Offset: 0x0035E376
		[NullableContext(1)]
		public static RoleTowerStageSettleResponse Create()
		{
			return new RoleTowerStageSettleResponse();
		}

		// Token: 0x17004DEC RID: 19948
		// (get) Token: 0x06017327 RID: 95015 RVA: 0x0036017D File Offset: 0x0035E37D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004DED RID: 19949
		// (get) Token: 0x06017328 RID: 95016 RVA: 0x00360180 File Offset: 0x0035E380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerStageSettleResponse.Descriptor;
			}
		}

		// Token: 0x06017329 RID: 95017 RVA: 0x00360187 File Offset: 0x0035E387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerStageSettleResponse()
		{
		}

		// Token: 0x0601732A RID: 95018 RVA: 0x0036018F File Offset: 0x0035E38F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerStageSettleResponse(RoleTowerStageSettleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601732B RID: 95019 RVA: 0x003601B4 File Offset: 0x0035E3B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerStageSettleResponse Clone()
		{
			return new RoleTowerStageSettleResponse(this);
		}

		// Token: 0x17004DEE RID: 19950
		// (get) Token: 0x0601732C RID: 95020 RVA: 0x003601BC File Offset: 0x0035E3BC
		// (set) Token: 0x0601732D RID: 95021 RVA: 0x003601C4 File Offset: 0x0035E3C4
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

		// Token: 0x0601732E RID: 95022 RVA: 0x003601CD File Offset: 0x0035E3CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerStageSettleResponse);
		}

		// Token: 0x0601732F RID: 95023 RVA: 0x003601DB File Offset: 0x0035E3DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerStageSettleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017330 RID: 95024 RVA: 0x0036020C File Offset: 0x0035E40C
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

		// Token: 0x06017331 RID: 95025 RVA: 0x00360251 File Offset: 0x0035E451
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017332 RID: 95026 RVA: 0x0036025E File Offset: 0x0035E45E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017333 RID: 95027 RVA: 0x00360267 File Offset: 0x0035E467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017334 RID: 95028 RVA: 0x0036029C File Offset: 0x0035E49C
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

		// Token: 0x06017335 RID: 95029 RVA: 0x003602DA File Offset: 0x0035E4DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerStageSettleResponse other)
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

		// Token: 0x06017336 RID: 95030 RVA: 0x0036030B File Offset: 0x0035E50B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017337 RID: 95031 RVA: 0x00360314 File Offset: 0x0035E514
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008AD0 RID: 35536
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008AD1 RID: 35537
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04008AD2 RID: 35538
		private ErrorCode errorCode_;
	}
}
