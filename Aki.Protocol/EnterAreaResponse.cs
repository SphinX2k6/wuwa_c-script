using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200044E RID: 1102
	[NetMessage(EMessageId.EnterAreaResponse)]
	public sealed class EnterAreaResponse : IMessage<EnterAreaResponse>, IMessage, IEquatable<EnterAreaResponse>, IDeepCloneable<EnterAreaResponse>, IBufferMessage
	{
		// Token: 0x06006943 RID: 26947 RVA: 0x000FC878 File Offset: 0x000FAA78
		[NullableContext(1)]
		public static EnterAreaResponse Create()
		{
			return new EnterAreaResponse();
		}

		// Token: 0x170013D4 RID: 5076
		// (get) Token: 0x06006944 RID: 26948 RVA: 0x000FC87F File Offset: 0x000FAA7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013D5 RID: 5077
		// (get) Token: 0x06006945 RID: 26949 RVA: 0x000FC882 File Offset: 0x000FAA82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterAreaResponse.Descriptor;
			}
		}

		// Token: 0x06006946 RID: 26950 RVA: 0x000FC889 File Offset: 0x000FAA89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterAreaResponse()
		{
		}

		// Token: 0x06006947 RID: 26951 RVA: 0x000FC891 File Offset: 0x000FAA91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterAreaResponse(EnterAreaResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006948 RID: 26952 RVA: 0x000FC8C2 File Offset: 0x000FAAC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterAreaResponse Clone()
		{
			return new EnterAreaResponse(this);
		}

		// Token: 0x170013D6 RID: 5078
		// (get) Token: 0x06006949 RID: 26953 RVA: 0x000FC8CA File Offset: 0x000FAACA
		// (set) Token: 0x0600694A RID: 26954 RVA: 0x000FC8D2 File Offset: 0x000FAAD2
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

		// Token: 0x170013D7 RID: 5079
		// (get) Token: 0x0600694B RID: 26955 RVA: 0x000FC8DB File Offset: 0x000FAADB
		// (set) Token: 0x0600694C RID: 26956 RVA: 0x000FC8E3 File Offset: 0x000FAAE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x0600694D RID: 26957 RVA: 0x000FC8EC File Offset: 0x000FAAEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterAreaResponse);
		}

		// Token: 0x0600694E RID: 26958 RVA: 0x000FC8FA File Offset: 0x000FAAFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterAreaResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600694F RID: 26959 RVA: 0x000FC938 File Offset: 0x000FAB38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006950 RID: 26960 RVA: 0x000FC996 File Offset: 0x000FAB96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006951 RID: 26961 RVA: 0x000FC9A3 File Offset: 0x000FABA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006952 RID: 26962 RVA: 0x000FC9AC File Offset: 0x000FABAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006953 RID: 26963 RVA: 0x000FCA08 File Offset: 0x000FAC08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006954 RID: 26964 RVA: 0x000FCA60 File Offset: 0x000FAC60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterAreaResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006955 RID: 26965 RVA: 0x000FCAB0 File Offset: 0x000FACB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006956 RID: 26966 RVA: 0x000FCABC File Offset: 0x000FACBC
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
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040039EA RID: 14826
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039EB RID: 14827
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x040039EC RID: 14828
		private ErrorCode errorCode_;

		// Token: 0x040039ED RID: 14829
		public const int IdFieldNumber = 14;

		// Token: 0x040039EE RID: 14830
		private int id_;
	}
}
