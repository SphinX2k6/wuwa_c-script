using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000965 RID: 2405
	[NetMessage(EMessageId.MailDeleteNotify)]
	public sealed class MailDeleteNotify : IMessage<MailDeleteNotify>, IMessage, IEquatable<MailDeleteNotify>, IDeepCloneable<MailDeleteNotify>, IBufferMessage
	{
		// Token: 0x0600D400 RID: 54272 RVA: 0x001F3925 File Offset: 0x001F1B25
		[NullableContext(1)]
		public static MailDeleteNotify Create()
		{
			return new MailDeleteNotify();
		}

		// Token: 0x17002AE5 RID: 10981
		// (get) Token: 0x0600D401 RID: 54273 RVA: 0x001F392C File Offset: 0x001F1B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002AE6 RID: 10982
		// (get) Token: 0x0600D402 RID: 54274 RVA: 0x001F392F File Offset: 0x001F1B2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MailDeleteNotify.Descriptor;
			}
		}

		// Token: 0x0600D403 RID: 54275 RVA: 0x001F3936 File Offset: 0x001F1B36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailDeleteNotify()
		{
		}

		// Token: 0x0600D404 RID: 54276 RVA: 0x001F3949 File Offset: 0x001F1B49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailDeleteNotify(MailDeleteNotify other) : this()
		{
			this.id_ = other.id_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D405 RID: 54277 RVA: 0x001F397A File Offset: 0x001F1B7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailDeleteNotify Clone()
		{
			return new MailDeleteNotify(this);
		}

		// Token: 0x17002AE7 RID: 10983
		// (get) Token: 0x0600D406 RID: 54278 RVA: 0x001F3982 File Offset: 0x001F1B82
		// (set) Token: 0x0600D407 RID: 54279 RVA: 0x001F398A File Offset: 0x001F1B8A
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

		// Token: 0x17002AE8 RID: 10984
		// (get) Token: 0x0600D408 RID: 54280 RVA: 0x001F399D File Offset: 0x001F1B9D
		// (set) Token: 0x0600D409 RID: 54281 RVA: 0x001F39A5 File Offset: 0x001F1BA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailDeleteReason Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x0600D40A RID: 54282 RVA: 0x001F39AE File Offset: 0x001F1BAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MailDeleteNotify);
		}

		// Token: 0x0600D40B RID: 54283 RVA: 0x001F39BC File Offset: 0x001F1BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MailDeleteNotify other)
		{
			return other != null && (other == this || (!(this.Id != other.Id) && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D40C RID: 54284 RVA: 0x001F3A0C File Offset: 0x001F1C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id.Length != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Reason != MailDeleteReason.OverTime)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D40D RID: 54285 RVA: 0x001F3A6C File Offset: 0x001F1C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D40E RID: 54286 RVA: 0x001F3A79 File Offset: 0x001F1C79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D40F RID: 54287 RVA: 0x001F3A84 File Offset: 0x001F1C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reason != MailDeleteReason.OverTime)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Reason);
			}
			if (this.Id.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteString(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D410 RID: 54288 RVA: 0x001F3AE4 File Offset: 0x001F1CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Id);
			}
			if (this.Reason != MailDeleteReason.OverTime)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D411 RID: 54289 RVA: 0x001F3B40 File Offset: 0x001F1D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MailDeleteNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id.Length != 0)
			{
				this.Id = other.Id;
			}
			if (other.Reason != MailDeleteReason.OverTime)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D412 RID: 54290 RVA: 0x001F3B95 File Offset: 0x001F1D95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D413 RID: 54291 RVA: 0x001F3BA0 File Offset: 0x001F1DA0
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
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadString();
					}
				}
				else
				{
					this.Reason = (MailDeleteReason)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005949 RID: 22857
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400594A RID: 22858
		public const int IdFieldNumber = 14;

		// Token: 0x0400594B RID: 22859
		private string id_ = "";

		// Token: 0x0400594C RID: 22860
		public const int ReasonFieldNumber = 4;

		// Token: 0x0400594D RID: 22861
		private MailDeleteReason reason_;
	}
}
