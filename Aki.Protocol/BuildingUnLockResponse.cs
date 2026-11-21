using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000215 RID: 533
	[NetMessage(EMessageId.BuildingUnLockResponse)]
	public sealed class BuildingUnLockResponse : IMessage<BuildingUnLockResponse>, IMessage, IEquatable<BuildingUnLockResponse>, IDeepCloneable<BuildingUnLockResponse>, IBufferMessage
	{
		// Token: 0x06003ABE RID: 15038 RVA: 0x00092961 File Offset: 0x00090B61
		[NullableContext(1)]
		public static BuildingUnLockResponse Create()
		{
			return new BuildingUnLockResponse();
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06003ABF RID: 15039 RVA: 0x00092968 File Offset: 0x00090B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06003AC0 RID: 15040 RVA: 0x0009296B File Offset: 0x00090B6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuildingUnLockResponse.Descriptor;
			}
		}

		// Token: 0x06003AC1 RID: 15041 RVA: 0x00092972 File Offset: 0x00090B72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuildingUnLockResponse()
		{
		}

		// Token: 0x06003AC2 RID: 15042 RVA: 0x0009297A File Offset: 0x00090B7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuildingUnLockResponse(BuildingUnLockResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.peopleLike_ = other.peopleLike_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003AC3 RID: 15043 RVA: 0x000929AB File Offset: 0x00090BAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuildingUnLockResponse Clone()
		{
			return new BuildingUnLockResponse(this);
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06003AC4 RID: 15044 RVA: 0x000929B3 File Offset: 0x00090BB3
		// (set) Token: 0x06003AC5 RID: 15045 RVA: 0x000929BB File Offset: 0x00090BBB
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

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06003AC6 RID: 15046 RVA: 0x000929C4 File Offset: 0x00090BC4
		// (set) Token: 0x06003AC7 RID: 15047 RVA: 0x000929CC File Offset: 0x00090BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PeopleLike
		{
			get
			{
				return this.peopleLike_;
			}
			set
			{
				this.peopleLike_ = value;
			}
		}

		// Token: 0x06003AC8 RID: 15048 RVA: 0x000929D5 File Offset: 0x00090BD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuildingUnLockResponse);
		}

		// Token: 0x06003AC9 RID: 15049 RVA: 0x000929E3 File Offset: 0x00090BE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuildingUnLockResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.PeopleLike == other.PeopleLike && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003ACA RID: 15050 RVA: 0x00092A24 File Offset: 0x00090C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.PeopleLike != 0)
			{
				num ^= this.PeopleLike.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003ACB RID: 15051 RVA: 0x00092A82 File Offset: 0x00090C82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003ACC RID: 15052 RVA: 0x00092A8F File Offset: 0x00090C8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003ACD RID: 15053 RVA: 0x00092A98 File Offset: 0x00090C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.PeopleLike != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.PeopleLike);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003ACE RID: 15054 RVA: 0x00092AF4 File Offset: 0x00090CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.PeopleLike != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PeopleLike);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003ACF RID: 15055 RVA: 0x00092B4C File Offset: 0x00090D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuildingUnLockResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.PeopleLike != 0)
			{
				this.PeopleLike = other.PeopleLike;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003AD0 RID: 15056 RVA: 0x00092B9C File Offset: 0x00090D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003AD1 RID: 15057 RVA: 0x00092BA8 File Offset: 0x00090DA8
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
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PeopleLike = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002C3C RID: 11324
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C3D RID: 11325
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04002C3E RID: 11326
		private ErrorCode errorCode_;

		// Token: 0x04002C3F RID: 11327
		public const int PeopleLikeFieldNumber = 12;

		// Token: 0x04002C40 RID: 11328
		private int peopleLike_;
	}
}
