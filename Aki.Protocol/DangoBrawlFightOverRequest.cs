using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000361 RID: 865
	[NetMessage(EMessageId.DangoBrawlFightOverRequest)]
	public sealed class DangoBrawlFightOverRequest : IMessage<DangoBrawlFightOverRequest>, IMessage, IEquatable<DangoBrawlFightOverRequest>, IDeepCloneable<DangoBrawlFightOverRequest>, IBufferMessage
	{
		// Token: 0x0600568D RID: 22157 RVA: 0x000D3B60 File Offset: 0x000D1D60
		[NullableContext(1)]
		public static DangoBrawlFightOverRequest Create()
		{
			return new DangoBrawlFightOverRequest();
		}

		// Token: 0x17000FDF RID: 4063
		// (get) Token: 0x0600568E RID: 22158 RVA: 0x000D3B67 File Offset: 0x000D1D67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000FE0 RID: 4064
		// (get) Token: 0x0600568F RID: 22159 RVA: 0x000D3B6A File Offset: 0x000D1D6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlFightOverRequest.Descriptor;
			}
		}

		// Token: 0x06005690 RID: 22160 RVA: 0x000D3B71 File Offset: 0x000D1D71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightOverRequest()
		{
		}

		// Token: 0x06005691 RID: 22161 RVA: 0x000D3B79 File Offset: 0x000D1D79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightOverRequest(DangoBrawlFightOverRequest other) : this()
		{
			this.continueAddition_ = other.continueAddition_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005692 RID: 22162 RVA: 0x000D3B9E File Offset: 0x000D1D9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightOverRequest Clone()
		{
			return new DangoBrawlFightOverRequest(this);
		}

		// Token: 0x17000FE1 RID: 4065
		// (get) Token: 0x06005693 RID: 22163 RVA: 0x000D3BA6 File Offset: 0x000D1DA6
		// (set) Token: 0x06005694 RID: 22164 RVA: 0x000D3BAE File Offset: 0x000D1DAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ContinueAddition
		{
			get
			{
				return this.continueAddition_;
			}
			set
			{
				this.continueAddition_ = value;
			}
		}

		// Token: 0x06005695 RID: 22165 RVA: 0x000D3BB7 File Offset: 0x000D1DB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlFightOverRequest);
		}

		// Token: 0x06005696 RID: 22166 RVA: 0x000D3BC5 File Offset: 0x000D1DC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlFightOverRequest other)
		{
			return other != null && (other == this || (this.ContinueAddition == other.ContinueAddition && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005697 RID: 22167 RVA: 0x000D3BF4 File Offset: 0x000D1DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ContinueAddition)
			{
				num ^= this.ContinueAddition.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005698 RID: 22168 RVA: 0x000D3C33 File Offset: 0x000D1E33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005699 RID: 22169 RVA: 0x000D3C40 File Offset: 0x000D1E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600569A RID: 22170 RVA: 0x000D3C49 File Offset: 0x000D1E49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ContinueAddition)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.ContinueAddition);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600569B RID: 22171 RVA: 0x000D3C7C File Offset: 0x000D1E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ContinueAddition)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600569C RID: 22172 RVA: 0x000D3CAE File Offset: 0x000D1EAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlFightOverRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ContinueAddition)
			{
				this.ContinueAddition = other.ContinueAddition;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600569D RID: 22173 RVA: 0x000D3CDF File Offset: 0x000D1EDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600569E RID: 22174 RVA: 0x000D3CE8 File Offset: 0x000D1EE8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ContinueAddition = input.ReadBool();
				}
			}
		}

		// Token: 0x040034D6 RID: 13526
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034D7 RID: 13527
		public const int ContinueAdditionFieldNumber = 5;

		// Token: 0x040034D8 RID: 13528
		private bool continueAddition_;
	}
}
