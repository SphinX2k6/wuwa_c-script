using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200126B RID: 4715
	[NetMessage(EMessageId.SingleInstRechallengeRequest)]
	public sealed class SingleInstRechallengeRequest : IMessage<SingleInstRechallengeRequest>, IMessage, IEquatable<SingleInstRechallengeRequest>, IDeepCloneable<SingleInstRechallengeRequest>, IBufferMessage
	{
		// Token: 0x060192C8 RID: 103112 RVA: 0x003AC0CA File Offset: 0x003AA2CA
		[NullableContext(1)]
		public static SingleInstRechallengeRequest Create()
		{
			return new SingleInstRechallengeRequest();
		}

		// Token: 0x1700551D RID: 21789
		// (get) Token: 0x060192C9 RID: 103113 RVA: 0x003AC0D1 File Offset: 0x003AA2D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700551E RID: 21790
		// (get) Token: 0x060192CA RID: 103114 RVA: 0x003AC0D4 File Offset: 0x003AA2D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SingleInstRechallengeRequest.Descriptor;
			}
		}

		// Token: 0x060192CB RID: 103115 RVA: 0x003AC0DB File Offset: 0x003AA2DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SingleInstRechallengeRequest()
		{
		}

		// Token: 0x060192CC RID: 103116 RVA: 0x003AC0E3 File Offset: 0x003AA2E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SingleInstRechallengeRequest(SingleInstRechallengeRequest other) : this()
		{
			this.rechallengeInInst_ = other.rechallengeInInst_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060192CD RID: 103117 RVA: 0x003AC108 File Offset: 0x003AA308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SingleInstRechallengeRequest Clone()
		{
			return new SingleInstRechallengeRequest(this);
		}

		// Token: 0x1700551F RID: 21791
		// (get) Token: 0x060192CE RID: 103118 RVA: 0x003AC110 File Offset: 0x003AA310
		// (set) Token: 0x060192CF RID: 103119 RVA: 0x003AC118 File Offset: 0x003AA318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool RechallengeInInst
		{
			get
			{
				return this.rechallengeInInst_;
			}
			set
			{
				this.rechallengeInInst_ = value;
			}
		}

		// Token: 0x060192D0 RID: 103120 RVA: 0x003AC121 File Offset: 0x003AA321
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SingleInstRechallengeRequest);
		}

		// Token: 0x060192D1 RID: 103121 RVA: 0x003AC12F File Offset: 0x003AA32F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SingleInstRechallengeRequest other)
		{
			return other != null && (other == this || (this.RechallengeInInst == other.RechallengeInInst && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060192D2 RID: 103122 RVA: 0x003AC160 File Offset: 0x003AA360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RechallengeInInst)
			{
				num ^= this.RechallengeInInst.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060192D3 RID: 103123 RVA: 0x003AC19F File Offset: 0x003AA39F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060192D4 RID: 103124 RVA: 0x003AC1AC File Offset: 0x003AA3AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060192D5 RID: 103125 RVA: 0x003AC1B5 File Offset: 0x003AA3B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RechallengeInInst)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.RechallengeInInst);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060192D6 RID: 103126 RVA: 0x003AC1E8 File Offset: 0x003AA3E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RechallengeInInst)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060192D7 RID: 103127 RVA: 0x003AC21A File Offset: 0x003AA41A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SingleInstRechallengeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RechallengeInInst)
			{
				this.RechallengeInInst = other.RechallengeInInst;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060192D8 RID: 103128 RVA: 0x003AC24B File Offset: 0x003AA44B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060192D9 RID: 103129 RVA: 0x003AC254 File Offset: 0x003AA454
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
					this.RechallengeInInst = input.ReadBool();
				}
			}
		}

		// Token: 0x0400950D RID: 38157
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400950E RID: 38158
		public const int RechallengeInInstFieldNumber = 15;

		// Token: 0x0400950F RID: 38159
		private bool rechallengeInInst_;
	}
}
