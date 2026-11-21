using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000939 RID: 2361
	[NetMessage(EMessageId.LoginNotify)]
	public sealed class LoginNotify : IMessage<LoginNotify>, IMessage, IEquatable<LoginNotify>, IDeepCloneable<LoginNotify>, IBufferMessage
	{
		// Token: 0x0600D04E RID: 53326 RVA: 0x001EABA5 File Offset: 0x001E8DA5
		[NullableContext(1)]
		public static LoginNotify Create()
		{
			return new LoginNotify();
		}

		// Token: 0x17002A10 RID: 10768
		// (get) Token: 0x0600D04F RID: 53327 RVA: 0x001EABAC File Offset: 0x001E8DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A11 RID: 10769
		// (get) Token: 0x0600D050 RID: 53328 RVA: 0x001EABAF File Offset: 0x001E8DAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LoginNotify.Descriptor;
			}
		}

		// Token: 0x0600D051 RID: 53329 RVA: 0x001EABB6 File Offset: 0x001E8DB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoginNotify()
		{
		}

		// Token: 0x0600D052 RID: 53330 RVA: 0x001EABBE File Offset: 0x001E8DBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoginNotify(LoginNotify other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D053 RID: 53331 RVA: 0x001EABE3 File Offset: 0x001E8DE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoginNotify Clone()
		{
			return new LoginNotify(this);
		}

		// Token: 0x17002A12 RID: 10770
		// (get) Token: 0x0600D054 RID: 53332 RVA: 0x001EABEB File Offset: 0x001E8DEB
		// (set) Token: 0x0600D055 RID: 53333 RVA: 0x001EABF3 File Offset: 0x001E8DF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x0600D056 RID: 53334 RVA: 0x001EABFC File Offset: 0x001E8DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LoginNotify);
		}

		// Token: 0x0600D057 RID: 53335 RVA: 0x001EAC0A File Offset: 0x001E8E0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LoginNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D058 RID: 53336 RVA: 0x001EAC38 File Offset: 0x001E8E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D059 RID: 53337 RVA: 0x001EAC77 File Offset: 0x001E8E77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D05A RID: 53338 RVA: 0x001EAC84 File Offset: 0x001E8E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D05B RID: 53339 RVA: 0x001EAC8D File Offset: 0x001E8E8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D05C RID: 53340 RVA: 0x001EACC0 File Offset: 0x001E8EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D05D RID: 53341 RVA: 0x001EACFE File Offset: 0x001E8EFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LoginNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D05E RID: 53342 RVA: 0x001EAD2F File Offset: 0x001E8F2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D05F RID: 53343 RVA: 0x001EAD38 File Offset: 0x001E8F38
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005814 RID: 22548
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005815 RID: 22549
		public const int IdFieldNumber = 1;

		// Token: 0x04005816 RID: 22550
		private int id_;
	}
}
