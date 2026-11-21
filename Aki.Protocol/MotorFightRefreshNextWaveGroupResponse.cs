using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A49 RID: 2633
	[NetMessage(EMessageId.MotorFightRefreshNextWaveGroupResponse)]
	public sealed class MotorFightRefreshNextWaveGroupResponse : IMessage<MotorFightRefreshNextWaveGroupResponse>, IMessage, IEquatable<MotorFightRefreshNextWaveGroupResponse>, IDeepCloneable<MotorFightRefreshNextWaveGroupResponse>, IBufferMessage
	{
		// Token: 0x0600E60B RID: 58891 RVA: 0x0021A0C9 File Offset: 0x002182C9
		[NullableContext(1)]
		public static MotorFightRefreshNextWaveGroupResponse Create()
		{
			return new MotorFightRefreshNextWaveGroupResponse();
		}

		// Token: 0x17002E9F RID: 11935
		// (get) Token: 0x0600E60C RID: 58892 RVA: 0x0021A0D0 File Offset: 0x002182D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002EA0 RID: 11936
		// (get) Token: 0x0600E60D RID: 58893 RVA: 0x0021A0D3 File Offset: 0x002182D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightRefreshNextWaveGroupResponse.Descriptor;
			}
		}

		// Token: 0x0600E60E RID: 58894 RVA: 0x0021A0DA File Offset: 0x002182DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshNextWaveGroupResponse()
		{
		}

		// Token: 0x0600E60F RID: 58895 RVA: 0x0021A0E2 File Offset: 0x002182E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshNextWaveGroupResponse(MotorFightRefreshNextWaveGroupResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E610 RID: 58896 RVA: 0x0021A107 File Offset: 0x00218307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRefreshNextWaveGroupResponse Clone()
		{
			return new MotorFightRefreshNextWaveGroupResponse(this);
		}

		// Token: 0x17002EA1 RID: 11937
		// (get) Token: 0x0600E611 RID: 58897 RVA: 0x0021A10F File Offset: 0x0021830F
		// (set) Token: 0x0600E612 RID: 58898 RVA: 0x0021A117 File Offset: 0x00218317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x0600E613 RID: 58899 RVA: 0x0021A120 File Offset: 0x00218320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightRefreshNextWaveGroupResponse);
		}

		// Token: 0x0600E614 RID: 58900 RVA: 0x0021A12E File Offset: 0x0021832E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightRefreshNextWaveGroupResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E615 RID: 58901 RVA: 0x0021A15C File Offset: 0x0021835C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E616 RID: 58902 RVA: 0x0021A1A1 File Offset: 0x002183A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E617 RID: 58903 RVA: 0x0021A1AE File Offset: 0x002183AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E618 RID: 58904 RVA: 0x0021A1B7 File Offset: 0x002183B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E619 RID: 58905 RVA: 0x0021A1EC File Offset: 0x002183EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E61A RID: 58906 RVA: 0x0021A22A File Offset: 0x0021842A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightRefreshNextWaveGroupResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E61B RID: 58907 RVA: 0x0021A25B File Offset: 0x0021845B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E61C RID: 58908 RVA: 0x0021A264 File Offset: 0x00218464
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
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005E39 RID: 24121
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E3A RID: 24122
		public const int ErrCodeFieldNumber = 11;

		// Token: 0x04005E3B RID: 24123
		private ErrorCode errCode_;
	}
}
