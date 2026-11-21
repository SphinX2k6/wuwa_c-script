using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001101 RID: 4353
	[NetMessage(EMessageId.RoleTrainResponse)]
	public sealed class RoleTrainResponse : IMessage<RoleTrainResponse>, IMessage, IEquatable<RoleTrainResponse>, IDeepCloneable<RoleTrainResponse>, IBufferMessage
	{
		// Token: 0x06017452 RID: 95314 RVA: 0x00362F68 File Offset: 0x00361168
		[NullableContext(1)]
		public static RoleTrainResponse Create()
		{
			return new RoleTrainResponse();
		}

		// Token: 0x17004E2E RID: 20014
		// (get) Token: 0x06017453 RID: 95315 RVA: 0x00362F6F File Offset: 0x0036116F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E2F RID: 20015
		// (get) Token: 0x06017454 RID: 95316 RVA: 0x00362F72 File Offset: 0x00361172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTrainResponse.Descriptor;
			}
		}

		// Token: 0x06017455 RID: 95317 RVA: 0x00362F79 File Offset: 0x00361179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrainResponse()
		{
		}

		// Token: 0x06017456 RID: 95318 RVA: 0x00362F81 File Offset: 0x00361181
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrainResponse(RoleTrainResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.greatSucc_ = other.greatSucc_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017457 RID: 95319 RVA: 0x00362FB2 File Offset: 0x003611B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrainResponse Clone()
		{
			return new RoleTrainResponse(this);
		}

		// Token: 0x17004E30 RID: 20016
		// (get) Token: 0x06017458 RID: 95320 RVA: 0x00362FBA File Offset: 0x003611BA
		// (set) Token: 0x06017459 RID: 95321 RVA: 0x00362FC2 File Offset: 0x003611C2
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

		// Token: 0x17004E31 RID: 20017
		// (get) Token: 0x0601745A RID: 95322 RVA: 0x00362FCB File Offset: 0x003611CB
		// (set) Token: 0x0601745B RID: 95323 RVA: 0x00362FD3 File Offset: 0x003611D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool GreatSucc
		{
			get
			{
				return this.greatSucc_;
			}
			set
			{
				this.greatSucc_ = value;
			}
		}

		// Token: 0x0601745C RID: 95324 RVA: 0x00362FDC File Offset: 0x003611DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTrainResponse);
		}

		// Token: 0x0601745D RID: 95325 RVA: 0x00362FEA File Offset: 0x003611EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTrainResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.GreatSucc == other.GreatSucc && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601745E RID: 95326 RVA: 0x00363028 File Offset: 0x00361228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.GreatSucc)
			{
				num ^= this.GreatSucc.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601745F RID: 95327 RVA: 0x00363086 File Offset: 0x00361286
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017460 RID: 95328 RVA: 0x00363093 File Offset: 0x00361293
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017461 RID: 95329 RVA: 0x0036309C File Offset: 0x0036129C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GreatSucc)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.GreatSucc);
			}
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

		// Token: 0x06017462 RID: 95330 RVA: 0x003630F8 File Offset: 0x003612F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.GreatSucc)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017463 RID: 95331 RVA: 0x00363144 File Offset: 0x00361344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTrainResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.GreatSucc)
			{
				this.GreatSucc = other.GreatSucc;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017464 RID: 95332 RVA: 0x00363194 File Offset: 0x00361394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017465 RID: 95333 RVA: 0x003631A0 File Offset: 0x003613A0
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
				if (num != 24U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.GreatSucc = input.ReadBool();
				}
			}
		}

		// Token: 0x04008B21 RID: 35617
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B22 RID: 35618
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04008B23 RID: 35619
		private ErrorCode errorCode_;

		// Token: 0x04008B24 RID: 35620
		public const int GreatSuccFieldNumber = 3;

		// Token: 0x04008B25 RID: 35621
		private bool greatSucc_;
	}
}
