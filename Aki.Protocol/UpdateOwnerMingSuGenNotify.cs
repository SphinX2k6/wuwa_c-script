using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001513 RID: 5395
	[NetMessage(EMessageId.UpdateOwnerMingSuGenNotify)]
	public sealed class UpdateOwnerMingSuGenNotify : IMessage<UpdateOwnerMingSuGenNotify>, IMessage, IEquatable<UpdateOwnerMingSuGenNotify>, IDeepCloneable<UpdateOwnerMingSuGenNotify>, IBufferMessage
	{
		// Token: 0x0601C960 RID: 117088 RVA: 0x004249B5 File Offset: 0x00422BB5
		[NullableContext(1)]
		public static UpdateOwnerMingSuGenNotify Create()
		{
			return new UpdateOwnerMingSuGenNotify();
		}

		// Token: 0x170060B3 RID: 24755
		// (get) Token: 0x0601C961 RID: 117089 RVA: 0x004249BC File Offset: 0x00422BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060B4 RID: 24756
		// (get) Token: 0x0601C962 RID: 117090 RVA: 0x004249BF File Offset: 0x00422BBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateOwnerMingSuGenNotify.Descriptor;
			}
		}

		// Token: 0x0601C963 RID: 117091 RVA: 0x004249C6 File Offset: 0x00422BC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateOwnerMingSuGenNotify()
		{
		}

		// Token: 0x0601C964 RID: 117092 RVA: 0x004249CE File Offset: 0x00422BCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateOwnerMingSuGenNotify(UpdateOwnerMingSuGenNotify other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C965 RID: 117093 RVA: 0x004249F3 File Offset: 0x00422BF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateOwnerMingSuGenNotify Clone()
		{
			return new UpdateOwnerMingSuGenNotify(this);
		}

		// Token: 0x170060B5 RID: 24757
		// (get) Token: 0x0601C966 RID: 117094 RVA: 0x004249FB File Offset: 0x00422BFB
		// (set) Token: 0x0601C967 RID: 117095 RVA: 0x00424A03 File Offset: 0x00422C03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
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

		// Token: 0x0601C968 RID: 117096 RVA: 0x00424A0C File Offset: 0x00422C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateOwnerMingSuGenNotify);
		}

		// Token: 0x0601C969 RID: 117097 RVA: 0x00424A1A File Offset: 0x00422C1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateOwnerMingSuGenNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C96A RID: 117098 RVA: 0x00424A48 File Offset: 0x00422C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C96B RID: 117099 RVA: 0x00424A87 File Offset: 0x00422C87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C96C RID: 117100 RVA: 0x00424A94 File Offset: 0x00422C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C96D RID: 117101 RVA: 0x00424A9D File Offset: 0x00422C9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C96E RID: 117102 RVA: 0x00424AD0 File Offset: 0x00422CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C96F RID: 117103 RVA: 0x00424B0E File Offset: 0x00422D0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateOwnerMingSuGenNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C970 RID: 117104 RVA: 0x00424B3F File Offset: 0x00422D3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C971 RID: 117105 RVA: 0x00424B48 File Offset: 0x00422D48
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
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400A4C3 RID: 42179
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A4C4 RID: 42180
		public const int IdFieldNumber = 7;

		// Token: 0x0400A4C5 RID: 42181
		private long id_;
	}
}
