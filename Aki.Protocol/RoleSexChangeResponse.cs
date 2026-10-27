using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010A9 RID: 4265
	[NetMessage(EMessageId.RoleSexChangeResponse)]
	public sealed class RoleSexChangeResponse : IMessage<RoleSexChangeResponse>, IMessage, IEquatable<RoleSexChangeResponse>, IDeepCloneable<RoleSexChangeResponse>, IBufferMessage
	{
		// Token: 0x06016C67 RID: 93287 RVA: 0x0034F409 File Offset: 0x0034D609
		[NullableContext(1)]
		public static RoleSexChangeResponse Create()
		{
			return new RoleSexChangeResponse();
		}

		// Token: 0x17004C50 RID: 19536
		// (get) Token: 0x06016C68 RID: 93288 RVA: 0x0034F410 File Offset: 0x0034D610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C51 RID: 19537
		// (get) Token: 0x06016C69 RID: 93289 RVA: 0x0034F413 File Offset: 0x0034D613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSexChangeResponse.Descriptor;
			}
		}

		// Token: 0x06016C6A RID: 93290 RVA: 0x0034F41A File Offset: 0x0034D61A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSexChangeResponse()
		{
		}

		// Token: 0x06016C6B RID: 93291 RVA: 0x0034F422 File Offset: 0x0034D622
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSexChangeResponse(RoleSexChangeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.sex_ = other.sex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016C6C RID: 93292 RVA: 0x0034F453 File Offset: 0x0034D653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSexChangeResponse Clone()
		{
			return new RoleSexChangeResponse(this);
		}

		// Token: 0x17004C52 RID: 19538
		// (get) Token: 0x06016C6D RID: 93293 RVA: 0x0034F45B File Offset: 0x0034D65B
		// (set) Token: 0x06016C6E RID: 93294 RVA: 0x0034F463 File Offset: 0x0034D663
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

		// Token: 0x17004C53 RID: 19539
		// (get) Token: 0x06016C6F RID: 93295 RVA: 0x0034F46C File Offset: 0x0034D66C
		// (set) Token: 0x06016C70 RID: 93296 RVA: 0x0034F474 File Offset: 0x0034D674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Sex
		{
			get
			{
				return this.sex_;
			}
			set
			{
				this.sex_ = value;
			}
		}

		// Token: 0x06016C71 RID: 93297 RVA: 0x0034F47D File Offset: 0x0034D67D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSexChangeResponse);
		}

		// Token: 0x06016C72 RID: 93298 RVA: 0x0034F48B File Offset: 0x0034D68B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSexChangeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Sex == other.Sex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016C73 RID: 93299 RVA: 0x0034F4CC File Offset: 0x0034D6CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.Sex != 0)
			{
				num ^= this.Sex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016C74 RID: 93300 RVA: 0x0034F52A File Offset: 0x0034D72A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016C75 RID: 93301 RVA: 0x0034F537 File Offset: 0x0034D737
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016C76 RID: 93302 RVA: 0x0034F540 File Offset: 0x0034D740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.Sex != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Sex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016C77 RID: 93303 RVA: 0x0034F59C File Offset: 0x0034D79C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.Sex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Sex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016C78 RID: 93304 RVA: 0x0034F5F4 File Offset: 0x0034D7F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleSexChangeResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.Sex != 0)
			{
				this.Sex = other.Sex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016C79 RID: 93305 RVA: 0x0034F644 File Offset: 0x0034D844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016C7A RID: 93306 RVA: 0x0034F650 File Offset: 0x0034D850
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
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Sex = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040087FD RID: 34813
		private UnknownFieldSet _unknownFields;

		// Token: 0x040087FE RID: 34814
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x040087FF RID: 34815
		private ErrorCode errorCode_;

		// Token: 0x04008800 RID: 34816
		public const int SexFieldNumber = 10;

		// Token: 0x04008801 RID: 34817
		private int sex_;
	}
}
