using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DE7 RID: 3559
	public sealed class PrivateTag : IMessage<PrivateTag>, IMessage, IEquatable<PrivateTag>, IDeepCloneable<PrivateTag>, IBufferMessage
	{
		// Token: 0x0601325C RID: 78428 RVA: 0x002CA0C8 File Offset: 0x002C82C8
		[NullableContext(1)]
		public static PrivateTag Create()
		{
			return new PrivateTag();
		}

		// Token: 0x17003F86 RID: 16262
		// (get) Token: 0x0601325D RID: 78429 RVA: 0x002CA0CF File Offset: 0x002C82CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PrivateTag> Parser
		{
			get
			{
				return PrivateTag._parser;
			}
		}

		// Token: 0x17003F87 RID: 16263
		// (get) Token: 0x0601325E RID: 78430 RVA: 0x002CA0D6 File Offset: 0x002C82D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F88 RID: 16264
		// (get) Token: 0x0601325F RID: 78431 RVA: 0x002CA0D9 File Offset: 0x002C82D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PrivateTag.Descriptor;
			}
		}

		// Token: 0x06013260 RID: 78432 RVA: 0x002CA0E0 File Offset: 0x002C82E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateTag()
		{
		}

		// Token: 0x06013261 RID: 78433 RVA: 0x002CA0F3 File Offset: 0x002C82F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateTag(PrivateTag other) : this()
		{
			this.playerId_ = other.playerId_;
			this.tags_ = other.tags_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013262 RID: 78434 RVA: 0x002CA129 File Offset: 0x002C8329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateTag Clone()
		{
			return new PrivateTag(this);
		}

		// Token: 0x17003F89 RID: 16265
		// (get) Token: 0x06013263 RID: 78435 RVA: 0x002CA131 File Offset: 0x002C8331
		// (set) Token: 0x06013264 RID: 78436 RVA: 0x002CA139 File Offset: 0x002C8339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17003F8A RID: 16266
		// (get) Token: 0x06013265 RID: 78437 RVA: 0x002CA142 File Offset: 0x002C8342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> Tags
		{
			get
			{
				return this.tags_;
			}
		}

		// Token: 0x06013266 RID: 78438 RVA: 0x002CA14A File Offset: 0x002C834A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PrivateTag);
		}

		// Token: 0x06013267 RID: 78439 RVA: 0x002CA158 File Offset: 0x002C8358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PrivateTag other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.tags_.Equals(other.tags_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013268 RID: 78440 RVA: 0x002CA1A8 File Offset: 0x002C83A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			num ^= this.tags_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013269 RID: 78441 RVA: 0x002CA1F5 File Offset: 0x002C83F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601326A RID: 78442 RVA: 0x002CA202 File Offset: 0x002C8402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601326B RID: 78443 RVA: 0x002CA20C File Offset: 0x002C840C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerId);
			}
			this.tags_.WriteTo(ref output, PrivateTag._repeated_tags_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601326C RID: 78444 RVA: 0x002CA25C File Offset: 0x002C845C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			num += this.tags_.CalculateSize(PrivateTag._repeated_tags_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601326D RID: 78445 RVA: 0x002CA2B0 File Offset: 0x002C84B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PrivateTag other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this.tags_.Add(other.tags_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601326E RID: 78446 RVA: 0x002CA2FD File Offset: 0x002C84FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601326F RID: 78447 RVA: 0x002CA308 File Offset: 0x002C8508
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
					if (num != 250U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.tags_.AddEntriesFrom(ref input, PrivateTag._repeated_tags_codec);
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040075F9 RID: 30201
		private static readonly MessageParser<PrivateTag> _parser = new MessageParser<PrivateTag>(() => new PrivateTag());

		// Token: 0x040075FA RID: 30202
		private UnknownFieldSet _unknownFields;

		// Token: 0x040075FB RID: 30203
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x040075FC RID: 30204
		private int playerId_;

		// Token: 0x040075FD RID: 30205
		public const int TagsFieldNumber = 31;

		// Token: 0x040075FE RID: 30206
		private static readonly FieldCodec<string> _repeated_tags_codec = FieldCodec.ForString(250U);

		// Token: 0x040075FF RID: 30207
		private readonly RepeatedField<string> tags_ = new RepeatedField<string>();
	}
}
