using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000383 RID: 899
	[NetMessage(EMessageId.DangoBrawlStartFightResponse)]
	public sealed class DangoBrawlStartFightResponse : IMessage<DangoBrawlStartFightResponse>, IMessage, IEquatable<DangoBrawlStartFightResponse>, IDeepCloneable<DangoBrawlStartFightResponse>, IBufferMessage
	{
		// Token: 0x0600594F RID: 22863 RVA: 0x000D9E96 File Offset: 0x000D8096
		[NullableContext(1)]
		public static DangoBrawlStartFightResponse Create()
		{
			return new DangoBrawlStartFightResponse();
		}

		// Token: 0x17001076 RID: 4214
		// (get) Token: 0x06005950 RID: 22864 RVA: 0x000D9E9D File Offset: 0x000D809D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001077 RID: 4215
		// (get) Token: 0x06005951 RID: 22865 RVA: 0x000D9EA0 File Offset: 0x000D80A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlStartFightResponse.Descriptor;
			}
		}

		// Token: 0x06005952 RID: 22866 RVA: 0x000D9EA7 File Offset: 0x000D80A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlStartFightResponse()
		{
		}

		// Token: 0x06005953 RID: 22867 RVA: 0x000D9EAF File Offset: 0x000D80AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlStartFightResponse(DangoBrawlStartFightResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005954 RID: 22868 RVA: 0x000D9ED4 File Offset: 0x000D80D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlStartFightResponse Clone()
		{
			return new DangoBrawlStartFightResponse(this);
		}

		// Token: 0x17001078 RID: 4216
		// (get) Token: 0x06005955 RID: 22869 RVA: 0x000D9EDC File Offset: 0x000D80DC
		// (set) Token: 0x06005956 RID: 22870 RVA: 0x000D9EE4 File Offset: 0x000D80E4
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

		// Token: 0x06005957 RID: 22871 RVA: 0x000D9EED File Offset: 0x000D80ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlStartFightResponse);
		}

		// Token: 0x06005958 RID: 22872 RVA: 0x000D9EFB File Offset: 0x000D80FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlStartFightResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005959 RID: 22873 RVA: 0x000D9F2C File Offset: 0x000D812C
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

		// Token: 0x0600595A RID: 22874 RVA: 0x000D9F71 File Offset: 0x000D8171
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600595B RID: 22875 RVA: 0x000D9F7E File Offset: 0x000D817E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600595C RID: 22876 RVA: 0x000D9F87 File Offset: 0x000D8187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600595D RID: 22877 RVA: 0x000D9FBC File Offset: 0x000D81BC
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

		// Token: 0x0600595E RID: 22878 RVA: 0x000D9FFA File Offset: 0x000D81FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlStartFightResponse other)
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

		// Token: 0x0600595F RID: 22879 RVA: 0x000DA02B File Offset: 0x000D822B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005960 RID: 22880 RVA: 0x000DA034 File Offset: 0x000D8234
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040035AB RID: 13739
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035AC RID: 13740
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x040035AD RID: 13741
		private ErrorCode errorCode_;
	}
}
