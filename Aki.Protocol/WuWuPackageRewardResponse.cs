using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200159C RID: 5532
	[NetMessage(EMessageId.WuWuPackageRewardResponse)]
	public sealed class WuWuPackageRewardResponse : IMessage<WuWuPackageRewardResponse>, IMessage, IEquatable<WuWuPackageRewardResponse>, IDeepCloneable<WuWuPackageRewardResponse>, IBufferMessage
	{
		// Token: 0x0601D492 RID: 119954 RVA: 0x0043D7D8 File Offset: 0x0043B9D8
		[NullableContext(1)]
		public static WuWuPackageRewardResponse Create()
		{
			return new WuWuPackageRewardResponse();
		}

		// Token: 0x17006319 RID: 25369
		// (get) Token: 0x0601D493 RID: 119955 RVA: 0x0043D7DF File Offset: 0x0043B9DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700631A RID: 25370
		// (get) Token: 0x0601D494 RID: 119956 RVA: 0x0043D7E2 File Offset: 0x0043B9E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WuWuPackageRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601D495 RID: 119957 RVA: 0x0043D7E9 File Offset: 0x0043B9E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuPackageRewardResponse()
		{
		}

		// Token: 0x0601D496 RID: 119958 RVA: 0x0043D7F1 File Offset: 0x0043B9F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuPackageRewardResponse(WuWuPackageRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D497 RID: 119959 RVA: 0x0043D816 File Offset: 0x0043BA16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuPackageRewardResponse Clone()
		{
			return new WuWuPackageRewardResponse(this);
		}

		// Token: 0x1700631B RID: 25371
		// (get) Token: 0x0601D498 RID: 119960 RVA: 0x0043D81E File Offset: 0x0043BA1E
		// (set) Token: 0x0601D499 RID: 119961 RVA: 0x0043D826 File Offset: 0x0043BA26
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

		// Token: 0x0601D49A RID: 119962 RVA: 0x0043D82F File Offset: 0x0043BA2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WuWuPackageRewardResponse);
		}

		// Token: 0x0601D49B RID: 119963 RVA: 0x0043D83D File Offset: 0x0043BA3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WuWuPackageRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D49C RID: 119964 RVA: 0x0043D86C File Offset: 0x0043BA6C
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

		// Token: 0x0601D49D RID: 119965 RVA: 0x0043D8B1 File Offset: 0x0043BAB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D49E RID: 119966 RVA: 0x0043D8BE File Offset: 0x0043BABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D49F RID: 119967 RVA: 0x0043D8C7 File Offset: 0x0043BAC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D4A0 RID: 119968 RVA: 0x0043D8FC File Offset: 0x0043BAFC
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

		// Token: 0x0601D4A1 RID: 119969 RVA: 0x0043D93A File Offset: 0x0043BB3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WuWuPackageRewardResponse other)
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

		// Token: 0x0601D4A2 RID: 119970 RVA: 0x0043D96B File Offset: 0x0043BB6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D4A3 RID: 119971 RVA: 0x0043D974 File Offset: 0x0043BB74
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A7FB RID: 43003
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A7FC RID: 43004
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x0400A7FD RID: 43005
		private ErrorCode errorCode_;
	}
}
