using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A1B RID: 2587
	[NetMessage(EMessageId.MotorDecalMotorIpResponse)]
	public sealed class MotorDecalMotorIpResponse : IMessage<MotorDecalMotorIpResponse>, IMessage, IEquatable<MotorDecalMotorIpResponse>, IDeepCloneable<MotorDecalMotorIpResponse>, IBufferMessage
	{
		// Token: 0x0600E26C RID: 57964 RVA: 0x00212875 File Offset: 0x00210A75
		[NullableContext(1)]
		public static MotorDecalMotorIpResponse Create()
		{
			return new MotorDecalMotorIpResponse();
		}

		// Token: 0x17002DE2 RID: 11746
		// (get) Token: 0x0600E26D RID: 57965 RVA: 0x0021287C File Offset: 0x00210A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DE3 RID: 11747
		// (get) Token: 0x0600E26E RID: 57966 RVA: 0x0021287F File Offset: 0x00210A7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorDecalMotorIpResponse.Descriptor;
			}
		}

		// Token: 0x0600E26F RID: 57967 RVA: 0x00212886 File Offset: 0x00210A86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDecalMotorIpResponse()
		{
		}

		// Token: 0x0600E270 RID: 57968 RVA: 0x0021288E File Offset: 0x00210A8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDecalMotorIpResponse(MotorDecalMotorIpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.motorIp_ = other.motorIp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E271 RID: 57969 RVA: 0x002128BF File Offset: 0x00210ABF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDecalMotorIpResponse Clone()
		{
			return new MotorDecalMotorIpResponse(this);
		}

		// Token: 0x17002DE4 RID: 11748
		// (get) Token: 0x0600E272 RID: 57970 RVA: 0x002128C7 File Offset: 0x00210AC7
		// (set) Token: 0x0600E273 RID: 57971 RVA: 0x002128CF File Offset: 0x00210ACF
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

		// Token: 0x17002DE5 RID: 11749
		// (get) Token: 0x0600E274 RID: 57972 RVA: 0x002128D8 File Offset: 0x00210AD8
		// (set) Token: 0x0600E275 RID: 57973 RVA: 0x002128E0 File Offset: 0x00210AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MotorIp
		{
			get
			{
				return this.motorIp_;
			}
			set
			{
				this.motorIp_ = value;
			}
		}

		// Token: 0x0600E276 RID: 57974 RVA: 0x002128E9 File Offset: 0x00210AE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorDecalMotorIpResponse);
		}

		// Token: 0x0600E277 RID: 57975 RVA: 0x002128F7 File Offset: 0x00210AF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorDecalMotorIpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.MotorIp == other.MotorIp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E278 RID: 57976 RVA: 0x00212938 File Offset: 0x00210B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.MotorIp != 0)
			{
				num ^= this.MotorIp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E279 RID: 57977 RVA: 0x00212996 File Offset: 0x00210B96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E27A RID: 57978 RVA: 0x002129A3 File Offset: 0x00210BA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E27B RID: 57979 RVA: 0x002129AC File Offset: 0x00210BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.MotorIp != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.MotorIp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E27C RID: 57980 RVA: 0x00212A08 File Offset: 0x00210C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.MotorIp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MotorIp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E27D RID: 57981 RVA: 0x00212A60 File Offset: 0x00210C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorDecalMotorIpResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.MotorIp != 0)
			{
				this.MotorIp = other.MotorIp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E27E RID: 57982 RVA: 0x00212AB0 File Offset: 0x00210CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E27F RID: 57983 RVA: 0x00212ABC File Offset: 0x00210CBC
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
				if (num != 112U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MotorIp = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005D3F RID: 23871
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D40 RID: 23872
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04005D41 RID: 23873
		private ErrorCode errorCode_;

		// Token: 0x04005D42 RID: 23874
		public const int MotorIpFieldNumber = 15;

		// Token: 0x04005D43 RID: 23875
		private int motorIp_;
	}
}
