using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200096D RID: 2413
	[NetMessage(EMessageId.MailReadRequest)]
	public sealed class MailReadRequest : IMessage<MailReadRequest>, IMessage, IEquatable<MailReadRequest>, IDeepCloneable<MailReadRequest>, IBufferMessage
	{
		// Token: 0x0600D49E RID: 54430 RVA: 0x001F4DE9 File Offset: 0x001F2FE9
		[NullableContext(1)]
		public static MailReadRequest Create()
		{
			return new MailReadRequest();
		}

		// Token: 0x17002B04 RID: 11012
		// (get) Token: 0x0600D49F RID: 54431 RVA: 0x001F4DF0 File Offset: 0x001F2FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B05 RID: 11013
		// (get) Token: 0x0600D4A0 RID: 54432 RVA: 0x001F4DF3 File Offset: 0x001F2FF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MailReadRequest.Descriptor;
			}
		}

		// Token: 0x0600D4A1 RID: 54433 RVA: 0x001F4DFA File Offset: 0x001F2FFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailReadRequest()
		{
		}

		// Token: 0x0600D4A2 RID: 54434 RVA: 0x001F4E0D File Offset: 0x001F300D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailReadRequest(MailReadRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D4A3 RID: 54435 RVA: 0x001F4E32 File Offset: 0x001F3032
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailReadRequest Clone()
		{
			return new MailReadRequest(this);
		}

		// Token: 0x17002B06 RID: 11014
		// (get) Token: 0x0600D4A4 RID: 54436 RVA: 0x001F4E3A File Offset: 0x001F303A
		// (set) Token: 0x0600D4A5 RID: 54437 RVA: 0x001F4E42 File Offset: 0x001F3042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0600D4A6 RID: 54438 RVA: 0x001F4E55 File Offset: 0x001F3055
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MailReadRequest);
		}

		// Token: 0x0600D4A7 RID: 54439 RVA: 0x001F4E63 File Offset: 0x001F3063
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MailReadRequest other)
		{
			return other != null && (other == this || (!(this.Id != other.Id) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D4A8 RID: 54440 RVA: 0x001F4E98 File Offset: 0x001F3098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id.Length != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D4A9 RID: 54441 RVA: 0x001F4ED9 File Offset: 0x001F30D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D4AA RID: 54442 RVA: 0x001F4EE6 File Offset: 0x001F30E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D4AB RID: 54443 RVA: 0x001F4EEF File Offset: 0x001F30EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D4AC RID: 54444 RVA: 0x001F4F28 File Offset: 0x001F3128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D4AD RID: 54445 RVA: 0x001F4F6B File Offset: 0x001F316B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MailReadRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id.Length != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D4AE RID: 54446 RVA: 0x001F4FA1 File Offset: 0x001F31A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D4AF RID: 54447 RVA: 0x001F4FAC File Offset: 0x001F31AC
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadString();
				}
			}
		}

		// Token: 0x04005974 RID: 22900
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005975 RID: 22901
		public const int IdFieldNumber = 6;

		// Token: 0x04005976 RID: 22902
		private string id_ = "";
	}
}
