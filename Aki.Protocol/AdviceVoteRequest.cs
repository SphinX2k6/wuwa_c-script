using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000D4 RID: 212
	[NetMessage(EMessageId.AdviceVoteRequest)]
	public sealed class AdviceVoteRequest : IMessage<AdviceVoteRequest>, IMessage, IEquatable<AdviceVoteRequest>, IDeepCloneable<AdviceVoteRequest>, IBufferMessage
	{
		// Token: 0x0600207F RID: 8319 RVA: 0x00057C8D File Offset: 0x00055E8D
		[NullableContext(1)]
		public static AdviceVoteRequest Create()
		{
			return new AdviceVoteRequest();
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06002080 RID: 8320 RVA: 0x00057C94 File Offset: 0x00055E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06002081 RID: 8321 RVA: 0x00057C97 File Offset: 0x00055E97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdviceVoteRequest.Descriptor;
			}
		}

		// Token: 0x06002082 RID: 8322 RVA: 0x00057C9E File Offset: 0x00055E9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceVoteRequest()
		{
		}

		// Token: 0x06002083 RID: 8323 RVA: 0x00057CA6 File Offset: 0x00055EA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceVoteRequest(AdviceVoteRequest other) : this()
		{
			this.id_ = other.id_;
			this.type_ = other.type_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002084 RID: 8324 RVA: 0x00057CD7 File Offset: 0x00055ED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceVoteRequest Clone()
		{
			return new AdviceVoteRequest(this);
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06002085 RID: 8325 RVA: 0x00057CDF File Offset: 0x00055EDF
		// (set) Token: 0x06002086 RID: 8326 RVA: 0x00057CE7 File Offset: 0x00055EE7
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

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06002087 RID: 8327 RVA: 0x00057CF0 File Offset: 0x00055EF0
		// (set) Token: 0x06002088 RID: 8328 RVA: 0x00057CF8 File Offset: 0x00055EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbAdviceVoteType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x06002089 RID: 8329 RVA: 0x00057D01 File Offset: 0x00055F01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdviceVoteRequest);
		}

		// Token: 0x0600208A RID: 8330 RVA: 0x00057D0F File Offset: 0x00055F0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdviceVoteRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Type == other.Type && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600208B RID: 8331 RVA: 0x00057D50 File Offset: 0x00055F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Type != PbAdviceVoteType.Up)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600208C RID: 8332 RVA: 0x00057DAE File Offset: 0x00055FAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600208D RID: 8333 RVA: 0x00057DBB File Offset: 0x00055FBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600208E RID: 8334 RVA: 0x00057DC4 File Offset: 0x00055FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.Id);
			}
			if (this.Type != PbAdviceVoteType.Up)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600208F RID: 8335 RVA: 0x00057E20 File Offset: 0x00056020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this.Type != PbAdviceVoteType.Up)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002090 RID: 8336 RVA: 0x00057E78 File Offset: 0x00056078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdviceVoteRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			if (other.Type != PbAdviceVoteType.Up)
			{
				this.Type = other.Type;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002091 RID: 8337 RVA: 0x00057EC8 File Offset: 0x000560C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002092 RID: 8338 RVA: 0x00057ED4 File Offset: 0x000560D4
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
				if (num != 40U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Type = (PbAdviceVoteType)input.ReadEnum();
					}
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400244B RID: 9291
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400244C RID: 9292
		public const int IdFieldNumber = 5;

		// Token: 0x0400244D RID: 9293
		private long id_;

		// Token: 0x0400244E RID: 9294
		public const int TypeFieldNumber = 8;

		// Token: 0x0400244F RID: 9295
		private PbAdviceVoteType type_;
	}
}
