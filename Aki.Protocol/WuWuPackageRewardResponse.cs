using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001526 RID: 5414
	[NetMessage(EMessageId.WuWuPackageRewardResponse)]
	public sealed class WuWuPackageRewardResponse : IMessage<WuWuPackageRewardResponse>, IMessage, IEquatable<WuWuPackageRewardResponse>, IDeepCloneable<WuWuPackageRewardResponse>, IBufferMessage
	{
		// Token: 0x0601C9CB RID: 117195 RVA: 0x00421D1D File Offset: 0x0041FF1D
		[NullableContext(1)]
		public static WuWuPackageRewardResponse Create()
		{
			return new WuWuPackageRewardResponse();
		}

		// Token: 0x17006078 RID: 24696
		// (get) Token: 0x0601C9CC RID: 117196 RVA: 0x00421D24 File Offset: 0x0041FF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006079 RID: 24697
		// (get) Token: 0x0601C9CD RID: 117197 RVA: 0x00421D27 File Offset: 0x0041FF27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WuWuPackageRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601C9CE RID: 117198 RVA: 0x00421D2E File Offset: 0x0041FF2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuPackageRewardResponse()
		{
		}

		// Token: 0x0601C9CF RID: 117199 RVA: 0x00421D36 File Offset: 0x0041FF36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuPackageRewardResponse(WuWuPackageRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C9D0 RID: 117200 RVA: 0x00421D5B File Offset: 0x0041FF5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuPackageRewardResponse Clone()
		{
			return new WuWuPackageRewardResponse(this);
		}

		// Token: 0x1700607A RID: 24698
		// (get) Token: 0x0601C9D1 RID: 117201 RVA: 0x00421D63 File Offset: 0x0041FF63
		// (set) Token: 0x0601C9D2 RID: 117202 RVA: 0x00421D6B File Offset: 0x0041FF6B
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

		// Token: 0x0601C9D3 RID: 117203 RVA: 0x00421D74 File Offset: 0x0041FF74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WuWuPackageRewardResponse);
		}

		// Token: 0x0601C9D4 RID: 117204 RVA: 0x00421D82 File Offset: 0x0041FF82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WuWuPackageRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C9D5 RID: 117205 RVA: 0x00421DB0 File Offset: 0x0041FFB0
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

		// Token: 0x0601C9D6 RID: 117206 RVA: 0x00421DF5 File Offset: 0x0041FFF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C9D7 RID: 117207 RVA: 0x00421E02 File Offset: 0x00420002
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C9D8 RID: 117208 RVA: 0x00421E0B File Offset: 0x0042000B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C9D9 RID: 117209 RVA: 0x00421E40 File Offset: 0x00420040
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

		// Token: 0x0601C9DA RID: 117210 RVA: 0x00421E7E File Offset: 0x0042007E
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

		// Token: 0x0601C9DB RID: 117211 RVA: 0x00421EAF File Offset: 0x004200AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C9DC RID: 117212 RVA: 0x00421EB8 File Offset: 0x004200B8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A3A2 RID: 41890
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A3A3 RID: 41891
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x0400A3A4 RID: 41892
		private ErrorCode errorCode_;
	}
}
