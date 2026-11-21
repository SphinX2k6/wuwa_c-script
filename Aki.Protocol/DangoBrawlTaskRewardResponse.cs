using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000385 RID: 901
	[NetMessage(EMessageId.DangoBrawlTaskRewardResponse)]
	public sealed class DangoBrawlTaskRewardResponse : IMessage<DangoBrawlTaskRewardResponse>, IMessage, IEquatable<DangoBrawlTaskRewardResponse>, IDeepCloneable<DangoBrawlTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x06005975 RID: 22901 RVA: 0x000DA324 File Offset: 0x000D8524
		[NullableContext(1)]
		public static DangoBrawlTaskRewardResponse Create()
		{
			return new DangoBrawlTaskRewardResponse();
		}

		// Token: 0x1700107D RID: 4221
		// (get) Token: 0x06005976 RID: 22902 RVA: 0x000DA32B File Offset: 0x000D852B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700107E RID: 4222
		// (get) Token: 0x06005977 RID: 22903 RVA: 0x000DA32E File Offset: 0x000D852E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x06005978 RID: 22904 RVA: 0x000DA335 File Offset: 0x000D8535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlTaskRewardResponse()
		{
		}

		// Token: 0x06005979 RID: 22905 RVA: 0x000DA33D File Offset: 0x000D853D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlTaskRewardResponse(DangoBrawlTaskRewardResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600597A RID: 22906 RVA: 0x000DA362 File Offset: 0x000D8562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlTaskRewardResponse Clone()
		{
			return new DangoBrawlTaskRewardResponse(this);
		}

		// Token: 0x1700107F RID: 4223
		// (get) Token: 0x0600597B RID: 22907 RVA: 0x000DA36A File Offset: 0x000D856A
		// (set) Token: 0x0600597C RID: 22908 RVA: 0x000DA372 File Offset: 0x000D8572
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

		// Token: 0x0600597D RID: 22909 RVA: 0x000DA37B File Offset: 0x000D857B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlTaskRewardResponse);
		}

		// Token: 0x0600597E RID: 22910 RVA: 0x000DA389 File Offset: 0x000D8589
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600597F RID: 22911 RVA: 0x000DA3B8 File Offset: 0x000D85B8
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

		// Token: 0x06005980 RID: 22912 RVA: 0x000DA3FD File Offset: 0x000D85FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005981 RID: 22913 RVA: 0x000DA40A File Offset: 0x000D860A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005982 RID: 22914 RVA: 0x000DA413 File Offset: 0x000D8613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005983 RID: 22915 RVA: 0x000DA448 File Offset: 0x000D8648
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

		// Token: 0x06005984 RID: 22916 RVA: 0x000DA486 File Offset: 0x000D8686
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlTaskRewardResponse other)
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

		// Token: 0x06005985 RID: 22917 RVA: 0x000DA4B7 File Offset: 0x000D86B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005986 RID: 22918 RVA: 0x000DA4C0 File Offset: 0x000D86C0
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040035B4 RID: 13748
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035B5 RID: 13749
		public const int ErrCodeFieldNumber = 15;

		// Token: 0x040035B6 RID: 13750
		private ErrorCode errCode_;
	}
}
