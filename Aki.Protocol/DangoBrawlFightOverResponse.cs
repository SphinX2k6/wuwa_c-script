using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000362 RID: 866
	[NetMessage(EMessageId.DangoBrawlFightOverResponse)]
	public sealed class DangoBrawlFightOverResponse : IMessage<DangoBrawlFightOverResponse>, IMessage, IEquatable<DangoBrawlFightOverResponse>, IDeepCloneable<DangoBrawlFightOverResponse>, IBufferMessage
	{
		// Token: 0x0600569F RID: 22175 RVA: 0x000D3D2D File Offset: 0x000D1F2D
		[NullableContext(1)]
		public static DangoBrawlFightOverResponse Create()
		{
			return new DangoBrawlFightOverResponse();
		}

		// Token: 0x17000FE2 RID: 4066
		// (get) Token: 0x060056A0 RID: 22176 RVA: 0x000D3D34 File Offset: 0x000D1F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000FE3 RID: 4067
		// (get) Token: 0x060056A1 RID: 22177 RVA: 0x000D3D37 File Offset: 0x000D1F37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlFightOverResponse.Descriptor;
			}
		}

		// Token: 0x060056A2 RID: 22178 RVA: 0x000D3D3E File Offset: 0x000D1F3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightOverResponse()
		{
		}

		// Token: 0x060056A3 RID: 22179 RVA: 0x000D3D46 File Offset: 0x000D1F46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightOverResponse(DangoBrawlFightOverResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060056A4 RID: 22180 RVA: 0x000D3D6B File Offset: 0x000D1F6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightOverResponse Clone()
		{
			return new DangoBrawlFightOverResponse(this);
		}

		// Token: 0x17000FE4 RID: 4068
		// (get) Token: 0x060056A5 RID: 22181 RVA: 0x000D3D73 File Offset: 0x000D1F73
		// (set) Token: 0x060056A6 RID: 22182 RVA: 0x000D3D7B File Offset: 0x000D1F7B
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

		// Token: 0x060056A7 RID: 22183 RVA: 0x000D3D84 File Offset: 0x000D1F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlFightOverResponse);
		}

		// Token: 0x060056A8 RID: 22184 RVA: 0x000D3D92 File Offset: 0x000D1F92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlFightOverResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060056A9 RID: 22185 RVA: 0x000D3DC0 File Offset: 0x000D1FC0
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

		// Token: 0x060056AA RID: 22186 RVA: 0x000D3E05 File Offset: 0x000D2005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060056AB RID: 22187 RVA: 0x000D3E12 File Offset: 0x000D2012
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060056AC RID: 22188 RVA: 0x000D3E1B File Offset: 0x000D201B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060056AD RID: 22189 RVA: 0x000D3E50 File Offset: 0x000D2050
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

		// Token: 0x060056AE RID: 22190 RVA: 0x000D3E8E File Offset: 0x000D208E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlFightOverResponse other)
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

		// Token: 0x060056AF RID: 22191 RVA: 0x000D3EBF File Offset: 0x000D20BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060056B0 RID: 22192 RVA: 0x000D3EC8 File Offset: 0x000D20C8
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040034D9 RID: 13529
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034DA RID: 13530
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x040034DB RID: 13531
		private ErrorCode errorCode_;
	}
}
