using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000437 RID: 1079
	[NetMessage(EMessageId.EnterAreaResponse)]
	public sealed class EnterAreaResponse : IMessage<EnterAreaResponse>, IMessage, IEquatable<EnterAreaResponse>, IDeepCloneable<EnterAreaResponse>, IBufferMessage
	{
		// Token: 0x060067B3 RID: 26547 RVA: 0x000F96EC File Offset: 0x000F78EC
		[NullableContext(1)]
		public static EnterAreaResponse Create()
		{
			return new EnterAreaResponse();
		}

		// Token: 0x1700137F RID: 4991
		// (get) Token: 0x060067B4 RID: 26548 RVA: 0x000F96F3 File Offset: 0x000F78F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001380 RID: 4992
		// (get) Token: 0x060067B5 RID: 26549 RVA: 0x000F96F6 File Offset: 0x000F78F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterAreaResponse.Descriptor;
			}
		}

		// Token: 0x060067B6 RID: 26550 RVA: 0x000F96FD File Offset: 0x000F78FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterAreaResponse()
		{
		}

		// Token: 0x060067B7 RID: 26551 RVA: 0x000F9705 File Offset: 0x000F7905
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterAreaResponse(EnterAreaResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060067B8 RID: 26552 RVA: 0x000F9736 File Offset: 0x000F7936
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterAreaResponse Clone()
		{
			return new EnterAreaResponse(this);
		}

		// Token: 0x17001381 RID: 4993
		// (get) Token: 0x060067B9 RID: 26553 RVA: 0x000F973E File Offset: 0x000F793E
		// (set) Token: 0x060067BA RID: 26554 RVA: 0x000F9746 File Offset: 0x000F7946
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

		// Token: 0x17001382 RID: 4994
		// (get) Token: 0x060067BB RID: 26555 RVA: 0x000F974F File Offset: 0x000F794F
		// (set) Token: 0x060067BC RID: 26556 RVA: 0x000F9757 File Offset: 0x000F7957
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

		// Token: 0x060067BD RID: 26557 RVA: 0x000F9760 File Offset: 0x000F7960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterAreaResponse);
		}

		// Token: 0x060067BE RID: 26558 RVA: 0x000F976E File Offset: 0x000F796E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterAreaResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060067BF RID: 26559 RVA: 0x000F97AC File Offset: 0x000F79AC
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

		// Token: 0x060067C0 RID: 26560 RVA: 0x000F980A File Offset: 0x000F7A0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060067C1 RID: 26561 RVA: 0x000F9817 File Offset: 0x000F7A17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060067C2 RID: 26562 RVA: 0x000F9820 File Offset: 0x000F7A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Id);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060067C3 RID: 26563 RVA: 0x000F987C File Offset: 0x000F7A7C
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

		// Token: 0x060067C4 RID: 26564 RVA: 0x000F98D4 File Offset: 0x000F7AD4
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

		// Token: 0x060067C5 RID: 26565 RVA: 0x000F9924 File Offset: 0x000F7B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060067C6 RID: 26566 RVA: 0x000F9930 File Offset: 0x000F7B30
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
				if (num != 40U)
				{
					if (num != 104U)
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
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040039D7 RID: 14807
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039D8 RID: 14808
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x040039D9 RID: 14809
		private ErrorCode errorCode_;

		// Token: 0x040039DA RID: 14810
		public const int IdFieldNumber = 5;

		// Token: 0x040039DB RID: 14811
		private int id_;
	}
}
