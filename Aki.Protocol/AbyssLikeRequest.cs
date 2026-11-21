using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000029 RID: 41
	[NetMessage(EMessageId.AbyssLikeRequest)]
	public sealed class AbyssLikeRequest : IMessage<AbyssLikeRequest>, IMessage, IEquatable<AbyssLikeRequest>, IDeepCloneable<AbyssLikeRequest>, IBufferMessage
	{
		// Token: 0x060011F6 RID: 4598 RVA: 0x00031D2D File Offset: 0x0002FF2D
		[NullableContext(1)]
		public static AbyssLikeRequest Create()
		{
			return new AbyssLikeRequest();
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060011F7 RID: 4599 RVA: 0x00031D34 File Offset: 0x0002FF34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060011F8 RID: 4600 RVA: 0x00031D37 File Offset: 0x0002FF37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssLikeRequest.Descriptor;
			}
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x00031D3E File Offset: 0x0002FF3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssLikeRequest()
		{
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x00031D46 File Offset: 0x0002FF46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssLikeRequest(AbyssLikeRequest other) : this()
		{
			this.playerId_ = other.playerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x00031D6B File Offset: 0x0002FF6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssLikeRequest Clone()
		{
			return new AbyssLikeRequest(this);
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060011FC RID: 4604 RVA: 0x00031D73 File Offset: 0x0002FF73
		// (set) Token: 0x060011FD RID: 4605 RVA: 0x00031D7B File Offset: 0x0002FF7B
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

		// Token: 0x060011FE RID: 4606 RVA: 0x00031D84 File Offset: 0x0002FF84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssLikeRequest);
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x00031D92 File Offset: 0x0002FF92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssLikeRequest other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x00031DC0 File Offset: 0x0002FFC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x00031DFF File Offset: 0x0002FFFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x00031E0C File Offset: 0x0003000C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x00031E15 File Offset: 0x00030015
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x00031E48 File Offset: 0x00030048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x00031E86 File Offset: 0x00030086
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssLikeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x00031EB7 File Offset: 0x000300B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x00031EC0 File Offset: 0x000300C0
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04001FF7 RID: 8183
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FF8 RID: 8184
		public const int PlayerIdFieldNumber = 14;

		// Token: 0x04001FF9 RID: 8185
		private int playerId_;
	}
}
