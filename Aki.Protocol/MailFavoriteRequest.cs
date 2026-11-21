using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000968 RID: 2408
	[NetMessage(EMessageId.MailFavoriteRequest)]
	public sealed class MailFavoriteRequest : IMessage<MailFavoriteRequest>, IMessage, IEquatable<MailFavoriteRequest>, IDeepCloneable<MailFavoriteRequest>, IBufferMessage
	{
		// Token: 0x0600D43A RID: 54330 RVA: 0x001F4083 File Offset: 0x001F2283
		[NullableContext(1)]
		public static MailFavoriteRequest Create()
		{
			return new MailFavoriteRequest();
		}

		// Token: 0x17002AF0 RID: 10992
		// (get) Token: 0x0600D43B RID: 54331 RVA: 0x001F408A File Offset: 0x001F228A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002AF1 RID: 10993
		// (get) Token: 0x0600D43C RID: 54332 RVA: 0x001F408D File Offset: 0x001F228D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MailFavoriteRequest.Descriptor;
			}
		}

		// Token: 0x0600D43D RID: 54333 RVA: 0x001F4094 File Offset: 0x001F2294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailFavoriteRequest()
		{
		}

		// Token: 0x0600D43E RID: 54334 RVA: 0x001F40A7 File Offset: 0x001F22A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailFavoriteRequest(MailFavoriteRequest other) : this()
		{
			this.id_ = other.id_;
			this.isFavorite_ = other.isFavorite_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D43F RID: 54335 RVA: 0x001F40D8 File Offset: 0x001F22D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailFavoriteRequest Clone()
		{
			return new MailFavoriteRequest(this);
		}

		// Token: 0x17002AF2 RID: 10994
		// (get) Token: 0x0600D440 RID: 54336 RVA: 0x001F40E0 File Offset: 0x001F22E0
		// (set) Token: 0x0600D441 RID: 54337 RVA: 0x001F40E8 File Offset: 0x001F22E8
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

		// Token: 0x17002AF3 RID: 10995
		// (get) Token: 0x0600D442 RID: 54338 RVA: 0x001F40FB File Offset: 0x001F22FB
		// (set) Token: 0x0600D443 RID: 54339 RVA: 0x001F4103 File Offset: 0x001F2303
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

		// Token: 0x0600D444 RID: 54340 RVA: 0x001F410C File Offset: 0x001F230C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MailFavoriteRequest);
		}

		// Token: 0x0600D445 RID: 54341 RVA: 0x001F411C File Offset: 0x001F231C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MailFavoriteRequest other)
		{
			return other != null && (other == this || (!(this.Id != other.Id) && this.IsFavorite == other.IsFavorite && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D446 RID: 54342 RVA: 0x001F416C File Offset: 0x001F236C
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

		// Token: 0x0600D447 RID: 54343 RVA: 0x001F41C6 File Offset: 0x001F23C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D448 RID: 54344 RVA: 0x001F41D3 File Offset: 0x001F23D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D449 RID: 54345 RVA: 0x001F41DC File Offset: 0x001F23DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteString(this.Id);
			}
			if (this.IsFavorite)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsFavorite);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D44A RID: 54346 RVA: 0x001F423C File Offset: 0x001F243C
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

		// Token: 0x0600D44B RID: 54347 RVA: 0x001F428C File Offset: 0x001F248C
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

		// Token: 0x0600D44C RID: 54348 RVA: 0x001F42E1 File Offset: 0x001F24E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D44D RID: 54349 RVA: 0x001F42EC File Offset: 0x001F24EC
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
				if (num != 58U)
				{
					if (num != 64U)
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

		// Token: 0x04005958 RID: 22872
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005959 RID: 22873
		public const int IdFieldNumber = 7;

		// Token: 0x0400595A RID: 22874
		private string id_ = "";

		// Token: 0x0400595B RID: 22875
		public const int IsFavoriteFieldNumber = 8;

		// Token: 0x0400595C RID: 22876
		private bool isFavorite_;
	}
}
