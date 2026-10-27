using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.CombatMessage
{
	// Token: 0x02001683 RID: 5763
	[NetMessage(EMessageId.CombatMessagePostInfoRequest)]
	public sealed class CombatMessagePostInfoRequest : IMessage<CombatMessagePostInfoRequest>, IMessage, IEquatable<CombatMessagePostInfoRequest>, IDeepCloneable<CombatMessagePostInfoRequest>, IBufferMessage
	{
		// Token: 0x0601CBCF RID: 117711 RVA: 0x00425C8E File Offset: 0x00423E8E
		[NullableContext(1)]
		public static CombatMessagePostInfoRequest Create()
		{
			return new CombatMessagePostInfoRequest();
		}

		// Token: 0x170060D8 RID: 24792
		// (get) Token: 0x0601CBD0 RID: 117712 RVA: 0x00425C95 File Offset: 0x00423E95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060D9 RID: 24793
		// (get) Token: 0x0601CBD1 RID: 117713 RVA: 0x00425C98 File Offset: 0x00423E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatMessagePostInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601CBD2 RID: 117714 RVA: 0x00425C9F File Offset: 0x00423E9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatMessagePostInfoRequest()
		{
		}

		// Token: 0x0601CBD3 RID: 117715 RVA: 0x00425CB2 File Offset: 0x00423EB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatMessagePostInfoRequest(CombatMessagePostInfoRequest other) : this()
		{
			this.postId_ = other.postId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CBD4 RID: 117716 RVA: 0x00425CD7 File Offset: 0x00423ED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatMessagePostInfoRequest Clone()
		{
			return new CombatMessagePostInfoRequest(this);
		}

		// Token: 0x170060DA RID: 24794
		// (get) Token: 0x0601CBD5 RID: 117717 RVA: 0x00425CDF File Offset: 0x00423EDF
		// (set) Token: 0x0601CBD6 RID: 117718 RVA: 0x00425CE7 File Offset: 0x00423EE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ByteString PostId
		{
			get
			{
				return this.postId_;
			}
			set
			{
				this.postId_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x0601CBD7 RID: 117719 RVA: 0x00425CFA File Offset: 0x00423EFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatMessagePostInfoRequest);
		}

		// Token: 0x0601CBD8 RID: 117720 RVA: 0x00425D08 File Offset: 0x00423F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatMessagePostInfoRequest other)
		{
			return other != null && (other == this || (!(this.PostId != other.PostId) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CBD9 RID: 117721 RVA: 0x00425D3C File Offset: 0x00423F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PostId.Length != 0)
			{
				num ^= this.PostId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CBDA RID: 117722 RVA: 0x00425D7D File Offset: 0x00423F7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CBDB RID: 117723 RVA: 0x00425D8A File Offset: 0x00423F8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CBDC RID: 117724 RVA: 0x00425D93 File Offset: 0x00423F93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PostId.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteBytes(this.PostId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CBDD RID: 117725 RVA: 0x00425DCC File Offset: 0x00423FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PostId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.PostId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CBDE RID: 117726 RVA: 0x00425E0F File Offset: 0x0042400F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombatMessagePostInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PostId.Length != 0)
			{
				this.PostId = other.PostId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CBDF RID: 117727 RVA: 0x00425E45 File Offset: 0x00424045
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CBE0 RID: 117728 RVA: 0x00425E50 File Offset: 0x00424050
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
					this.PostId = input.ReadBytes();
				}
			}
		}

		// Token: 0x0400C20B RID: 49675
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C20C RID: 49676
		public const int PostIdFieldNumber = 6;

		// Token: 0x0400C20D RID: 49677
		private ByteString postId_ = ByteString.Empty;
	}
}
