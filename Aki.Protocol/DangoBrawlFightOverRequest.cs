using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000359 RID: 857
	[NetMessage(EMessageId.DangoBrawlFightOverRequest)]
	public sealed class DangoBrawlFightOverRequest : IMessage<DangoBrawlFightOverRequest>, IMessage, IEquatable<DangoBrawlFightOverRequest>, IDeepCloneable<DangoBrawlFightOverRequest>, IBufferMessage
	{
		// Token: 0x060055A0 RID: 21920 RVA: 0x000D14D4 File Offset: 0x000CF6D4
		[NullableContext(1)]
		public static DangoBrawlFightOverRequest Create()
		{
			return new DangoBrawlFightOverRequest();
		}

		// Token: 0x17000FAE RID: 4014
		// (get) Token: 0x060055A1 RID: 21921 RVA: 0x000D14DB File Offset: 0x000CF6DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000FAF RID: 4015
		// (get) Token: 0x060055A2 RID: 21922 RVA: 0x000D14DE File Offset: 0x000CF6DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlFightOverRequest.Descriptor;
			}
		}

		// Token: 0x060055A3 RID: 21923 RVA: 0x000D14E5 File Offset: 0x000CF6E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightOverRequest()
		{
		}

		// Token: 0x060055A4 RID: 21924 RVA: 0x000D14ED File Offset: 0x000CF6ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightOverRequest(DangoBrawlFightOverRequest other) : this()
		{
			this.continueAddition_ = other.continueAddition_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060055A5 RID: 21925 RVA: 0x000D1512 File Offset: 0x000CF712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightOverRequest Clone()
		{
			return new DangoBrawlFightOverRequest(this);
		}

		// Token: 0x17000FB0 RID: 4016
		// (get) Token: 0x060055A6 RID: 21926 RVA: 0x000D151A File Offset: 0x000CF71A
		// (set) Token: 0x060055A7 RID: 21927 RVA: 0x000D1522 File Offset: 0x000CF722
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

		// Token: 0x060055A8 RID: 21928 RVA: 0x000D152B File Offset: 0x000CF72B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlFightOverRequest);
		}

		// Token: 0x060055A9 RID: 21929 RVA: 0x000D1539 File Offset: 0x000CF739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlFightOverRequest other)
		{
			return other != null && (other == this || (this.ContinueAddition == other.ContinueAddition && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060055AA RID: 21930 RVA: 0x000D1568 File Offset: 0x000CF768
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

		// Token: 0x060055AB RID: 21931 RVA: 0x000D15A7 File Offset: 0x000CF7A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060055AC RID: 21932 RVA: 0x000D15B4 File Offset: 0x000CF7B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060055AD RID: 21933 RVA: 0x000D15BD File Offset: 0x000CF7BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ContinueAddition)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.ContinueAddition);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060055AE RID: 21934 RVA: 0x000D15F0 File Offset: 0x000CF7F0
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

		// Token: 0x060055AF RID: 21935 RVA: 0x000D1622 File Offset: 0x000CF822
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

		// Token: 0x060055B0 RID: 21936 RVA: 0x000D1653 File Offset: 0x000CF853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060055B1 RID: 21937 RVA: 0x000D165C File Offset: 0x000CF85C
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ContinueAddition = input.ReadBool();
				}
			}
		}

		// Token: 0x0400343A RID: 13370
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400343B RID: 13371
		public const int ContinueAdditionFieldNumber = 11;

		// Token: 0x0400343C RID: 13372
		private bool continueAddition_;
	}
}
