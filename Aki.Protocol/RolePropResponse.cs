using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200109E RID: 4254
	[NetMessage(EMessageId.RolePropResponse)]
	public sealed class RolePropResponse : IMessage<RolePropResponse>, IMessage, IEquatable<RolePropResponse>, IDeepCloneable<RolePropResponse>, IBufferMessage
	{
		// Token: 0x06016B90 RID: 93072 RVA: 0x0034D8D1 File Offset: 0x0034BAD1
		[NullableContext(1)]
		public static RolePropResponse Create()
		{
			return new RolePropResponse();
		}

		// Token: 0x17004C25 RID: 19493
		// (get) Token: 0x06016B91 RID: 93073 RVA: 0x0034D8D8 File Offset: 0x0034BAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C26 RID: 19494
		// (get) Token: 0x06016B92 RID: 93074 RVA: 0x0034D8DB File Offset: 0x0034BADB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RolePropResponse.Descriptor;
			}
		}

		// Token: 0x06016B93 RID: 93075 RVA: 0x0034D8E2 File Offset: 0x0034BAE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePropResponse()
		{
		}

		// Token: 0x06016B94 RID: 93076 RVA: 0x0034D8F5 File Offset: 0x0034BAF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePropResponse(RolePropResponse other) : this()
		{
			this.error_ = other.error_;
			this.roleProps_ = other.roleProps_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016B95 RID: 93077 RVA: 0x0034D92B File Offset: 0x0034BB2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePropResponse Clone()
		{
			return new RolePropResponse(this);
		}

		// Token: 0x17004C27 RID: 19495
		// (get) Token: 0x06016B96 RID: 93078 RVA: 0x0034D933 File Offset: 0x0034BB33
		// (set) Token: 0x06016B97 RID: 93079 RVA: 0x0034D93B File Offset: 0x0034BB3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Error
		{
			get
			{
				return this.error_;
			}
			set
			{
				this.error_ = value;
			}
		}

		// Token: 0x17004C28 RID: 19496
		// (get) Token: 0x06016B98 RID: 93080 RVA: 0x0034D944 File Offset: 0x0034BB44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RolePropInfo> RoleProps
		{
			get
			{
				return this.roleProps_;
			}
		}

		// Token: 0x06016B99 RID: 93081 RVA: 0x0034D94C File Offset: 0x0034BB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RolePropResponse);
		}

		// Token: 0x06016B9A RID: 93082 RVA: 0x0034D95C File Offset: 0x0034BB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RolePropResponse other)
		{
			return other != null && (other == this || (this.Error == other.Error && this.roleProps_.Equals(other.roleProps_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016B9B RID: 93083 RVA: 0x0034D9AC File Offset: 0x0034BBAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Error != ErrorCode.Success)
			{
				num ^= this.Error.GetHashCode();
			}
			num ^= this.roleProps_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016B9C RID: 93084 RVA: 0x0034D9FF File Offset: 0x0034BBFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016B9D RID: 93085 RVA: 0x0034DA0C File Offset: 0x0034BC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016B9E RID: 93086 RVA: 0x0034DA18 File Offset: 0x0034BC18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleProps_.WriteTo(ref output, RolePropResponse._repeated_roleProps_codec);
			if (this.Error != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.Error);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016B9F RID: 93087 RVA: 0x0034DA68 File Offset: 0x0034BC68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Error != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Error);
			}
			num += this.roleProps_.CalculateSize(RolePropResponse._repeated_roleProps_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016BA0 RID: 93088 RVA: 0x0034DABC File Offset: 0x0034BCBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RolePropResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Error != ErrorCode.Success)
			{
				this.Error = other.Error;
			}
			this.roleProps_.Add(other.roleProps_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016BA1 RID: 93089 RVA: 0x0034DB09 File Offset: 0x0034BD09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016BA2 RID: 93090 RVA: 0x0034DB14 File Offset: 0x0034BD14
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
				if (num != 18U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Error = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.roleProps_.AddEntriesFrom(ref input, RolePropResponse._repeated_roleProps_codec);
				}
			}
		}

		// Token: 0x040087C3 RID: 34755
		private UnknownFieldSet _unknownFields;

		// Token: 0x040087C4 RID: 34756
		public const int ErrorFieldNumber = 11;

		// Token: 0x040087C5 RID: 34757
		private ErrorCode error_;

		// Token: 0x040087C6 RID: 34758
		public const int RolePropsFieldNumber = 2;

		// Token: 0x040087C7 RID: 34759
		private static readonly FieldCodec<RolePropInfo> _repeated_roleProps_codec = FieldCodec.ForMessage<RolePropInfo>(18U, RolePropInfo.Parser);

		// Token: 0x040087C8 RID: 34760
		private readonly RepeatedField<RolePropInfo> roleProps_ = new RepeatedField<RolePropInfo>();
	}
}
