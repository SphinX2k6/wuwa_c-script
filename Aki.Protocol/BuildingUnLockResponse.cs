using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000210 RID: 528
	[NetMessage(EMessageId.BuildingUnLockResponse)]
	public sealed class BuildingUnLockResponse : IMessage<BuildingUnLockResponse>, IMessage, IEquatable<BuildingUnLockResponse>, IDeepCloneable<BuildingUnLockResponse>, IBufferMessage
	{
		// Token: 0x06003A19 RID: 14873 RVA: 0x00090D4D File Offset: 0x0008EF4D
		[NullableContext(1)]
		public static BuildingUnLockResponse Create()
		{
			return new BuildingUnLockResponse();
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06003A1A RID: 14874 RVA: 0x00090D54 File Offset: 0x0008EF54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06003A1B RID: 14875 RVA: 0x00090D57 File Offset: 0x0008EF57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuildingUnLockResponse.Descriptor;
			}
		}

		// Token: 0x06003A1C RID: 14876 RVA: 0x00090D5E File Offset: 0x0008EF5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuildingUnLockResponse()
		{
		}

		// Token: 0x06003A1D RID: 14877 RVA: 0x00090D66 File Offset: 0x0008EF66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuildingUnLockResponse(BuildingUnLockResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.peopleLike_ = other.peopleLike_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003A1E RID: 14878 RVA: 0x00090D97 File Offset: 0x0008EF97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuildingUnLockResponse Clone()
		{
			return new BuildingUnLockResponse(this);
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06003A1F RID: 14879 RVA: 0x00090D9F File Offset: 0x0008EF9F
		// (set) Token: 0x06003A20 RID: 14880 RVA: 0x00090DA7 File Offset: 0x0008EFA7
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

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x06003A21 RID: 14881 RVA: 0x00090DB0 File Offset: 0x0008EFB0
		// (set) Token: 0x06003A22 RID: 14882 RVA: 0x00090DB8 File Offset: 0x0008EFB8
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

		// Token: 0x06003A23 RID: 14883 RVA: 0x00090DC1 File Offset: 0x0008EFC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuildingUnLockResponse);
		}

		// Token: 0x06003A24 RID: 14884 RVA: 0x00090DCF File Offset: 0x0008EFCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuildingUnLockResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.PeopleLike == other.PeopleLike && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003A25 RID: 14885 RVA: 0x00090E10 File Offset: 0x0008F010
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

		// Token: 0x06003A26 RID: 14886 RVA: 0x00090E6E File Offset: 0x0008F06E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003A27 RID: 14887 RVA: 0x00090E7B File Offset: 0x0008F07B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003A28 RID: 14888 RVA: 0x00090E84 File Offset: 0x0008F084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.PeopleLike != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.PeopleLike);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003A29 RID: 14889 RVA: 0x00090EE0 File Offset: 0x0008F0E0
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

		// Token: 0x06003A2A RID: 14890 RVA: 0x00090F38 File Offset: 0x0008F138
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

		// Token: 0x06003A2B RID: 14891 RVA: 0x00090F88 File Offset: 0x0008F188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003A2C RID: 14892 RVA: 0x00090F94 File Offset: 0x0008F194
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
				if (num != 48U)
				{
					if (num != 88U)
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

		// Token: 0x04002BBA RID: 11194
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BBB RID: 11195
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04002BBC RID: 11196
		private ErrorCode errorCode_;

		// Token: 0x04002BBD RID: 11197
		public const int PeopleLikeFieldNumber = 11;

		// Token: 0x04002BBE RID: 11198
		private int peopleLike_;
	}
}
