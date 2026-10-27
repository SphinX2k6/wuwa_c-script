using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000979 RID: 2425
	[NetMessage(EMessageId.MailFavoriteRequest)]
	public sealed class MailFavoriteRequest : IMessage<MailFavoriteRequest>, IMessage, IEquatable<MailFavoriteRequest>, IDeepCloneable<MailFavoriteRequest>, IBufferMessage
	{
		// Token: 0x0600D554 RID: 54612 RVA: 0x001F626B File Offset: 0x001F446B
		[NullableContext(1)]
		public static MailFavoriteRequest Create()
		{
			return new MailFavoriteRequest();
		}

		// Token: 0x17002B2E RID: 11054
		// (get) Token: 0x0600D555 RID: 54613 RVA: 0x001F6272 File Offset: 0x001F4472
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B2F RID: 11055
		// (get) Token: 0x0600D556 RID: 54614 RVA: 0x001F6275 File Offset: 0x001F4475
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MailFavoriteRequest.Descriptor;
			}
		}

		// Token: 0x0600D557 RID: 54615 RVA: 0x001F627C File Offset: 0x001F447C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailFavoriteRequest()
		{
		}

		// Token: 0x0600D558 RID: 54616 RVA: 0x001F628F File Offset: 0x001F448F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailFavoriteRequest(MailFavoriteRequest other) : this()
		{
			this.id_ = other.id_;
			this.isFavorite_ = other.isFavorite_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D559 RID: 54617 RVA: 0x001F62C0 File Offset: 0x001F44C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailFavoriteRequest Clone()
		{
			return new MailFavoriteRequest(this);
		}

		// Token: 0x17002B30 RID: 11056
		// (get) Token: 0x0600D55A RID: 54618 RVA: 0x001F62C8 File Offset: 0x001F44C8
		// (set) Token: 0x0600D55B RID: 54619 RVA: 0x001F62D0 File Offset: 0x001F44D0
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

		// Token: 0x17002B31 RID: 11057
		// (get) Token: 0x0600D55C RID: 54620 RVA: 0x001F62E3 File Offset: 0x001F44E3
		// (set) Token: 0x0600D55D RID: 54621 RVA: 0x001F62EB File Offset: 0x001F44EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFavorite
		{
			get
			{
				return this.isFavorite_;
			}
			set
			{
				this.isFavorite_ = value;
			}
		}

		// Token: 0x0600D55E RID: 54622 RVA: 0x001F62F4 File Offset: 0x001F44F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MailFavoriteRequest);
		}

		// Token: 0x0600D55F RID: 54623 RVA: 0x001F6304 File Offset: 0x001F4504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MailFavoriteRequest other)
		{
			return other != null && (other == this || (!(this.Id != other.Id) && this.IsFavorite == other.IsFavorite && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D560 RID: 54624 RVA: 0x001F6354 File Offset: 0x001F4554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id.Length != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.IsFavorite)
			{
				num ^= this.IsFavorite.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D561 RID: 54625 RVA: 0x001F63AE File Offset: 0x001F45AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D562 RID: 54626 RVA: 0x001F63BB File Offset: 0x001F45BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D563 RID: 54627 RVA: 0x001F63C4 File Offset: 0x001F45C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Id);
			}
			if (this.IsFavorite)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsFavorite);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D564 RID: 54628 RVA: 0x001F6424 File Offset: 0x001F4624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Id);
			}
			if (this.IsFavorite)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D565 RID: 54629 RVA: 0x001F6474 File Offset: 0x001F4674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MailFavoriteRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id.Length != 0)
			{
				this.Id = other.Id;
			}
			if (other.IsFavorite)
			{
				this.IsFavorite = other.IsFavorite;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D566 RID: 54630 RVA: 0x001F64C9 File Offset: 0x001F46C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D567 RID: 54631 RVA: 0x001F64D4 File Offset: 0x001F46D4
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
				if (num != 18U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsFavorite = input.ReadBool();
					}
				}
				else
				{
					this.Id = input.ReadString();
				}
			}
		}

		// Token: 0x0400594F RID: 22863
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005950 RID: 22864
		public const int IdFieldNumber = 2;

		// Token: 0x04005951 RID: 22865
		private string id_ = "";

		// Token: 0x04005952 RID: 22866
		public const int IsFavoriteFieldNumber = 11;

		// Token: 0x04005953 RID: 22867
		private bool isFavorite_;
	}
}
