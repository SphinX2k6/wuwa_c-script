using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FB4 RID: 4020
	[NetMessage(EMessageId.RoguelikeTokenReceiveRequest)]
	public sealed class RoguelikeTokenReceiveRequest : IMessage<RoguelikeTokenReceiveRequest>, IMessage, IEquatable<RoguelikeTokenReceiveRequest>, IDeepCloneable<RoguelikeTokenReceiveRequest>, IBufferMessage
	{
		// Token: 0x06015855 RID: 88149 RVA: 0x003204DF File Offset: 0x0031E6DF
		[NullableContext(1)]
		public static RoguelikeTokenReceiveRequest Create()
		{
			return new RoguelikeTokenReceiveRequest();
		}

		// Token: 0x170047C8 RID: 18376
		// (get) Token: 0x06015856 RID: 88150 RVA: 0x003204E6 File Offset: 0x0031E6E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047C9 RID: 18377
		// (get) Token: 0x06015857 RID: 88151 RVA: 0x003204E9 File Offset: 0x0031E6E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeTokenReceiveRequest.Descriptor;
			}
		}

		// Token: 0x06015858 RID: 88152 RVA: 0x003204F0 File Offset: 0x0031E6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTokenReceiveRequest()
		{
		}

		// Token: 0x06015859 RID: 88153 RVA: 0x003204F8 File Offset: 0x0031E6F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTokenReceiveRequest(RoguelikeTokenReceiveRequest other) : this()
		{
			this.seasonId_ = other.seasonId_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601585A RID: 88154 RVA: 0x00320529 File Offset: 0x0031E729
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTokenReceiveRequest Clone()
		{
			return new RoguelikeTokenReceiveRequest(this);
		}

		// Token: 0x170047CA RID: 18378
		// (get) Token: 0x0601585B RID: 88155 RVA: 0x00320531 File Offset: 0x0031E731
		// (set) Token: 0x0601585C RID: 88156 RVA: 0x00320539 File Offset: 0x0031E739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SeasonId
		{
			get
			{
				return this.seasonId_;
			}
			set
			{
				this.seasonId_ = value;
			}
		}

		// Token: 0x170047CB RID: 18379
		// (get) Token: 0x0601585D RID: 88157 RVA: 0x00320542 File Offset: 0x0031E742
		// (set) Token: 0x0601585E RID: 88158 RVA: 0x0032054A File Offset: 0x0031E74A
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

		// Token: 0x0601585F RID: 88159 RVA: 0x00320553 File Offset: 0x0031E753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeTokenReceiveRequest);
		}

		// Token: 0x06015860 RID: 88160 RVA: 0x00320561 File Offset: 0x0031E761
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeTokenReceiveRequest other)
		{
			return other != null && (other == this || (this.SeasonId == other.SeasonId && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015861 RID: 88161 RVA: 0x003205A0 File Offset: 0x0031E7A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SeasonId != 0)
			{
				num ^= this.SeasonId.GetHashCode();
			}
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

		// Token: 0x06015862 RID: 88162 RVA: 0x003205F8 File Offset: 0x0031E7F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015863 RID: 88163 RVA: 0x00320605 File Offset: 0x0031E805
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015864 RID: 88164 RVA: 0x00320610 File Offset: 0x0031E810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SeasonId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SeasonId);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015865 RID: 88165 RVA: 0x0032066C File Offset: 0x0031E86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SeasonId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SeasonId);
			}
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

		// Token: 0x06015866 RID: 88166 RVA: 0x003206C4 File Offset: 0x0031E8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeTokenReceiveRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SeasonId != 0)
			{
				this.SeasonId = other.SeasonId;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015867 RID: 88167 RVA: 0x00320714 File Offset: 0x0031E914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015868 RID: 88168 RVA: 0x00320720 File Offset: 0x0031E920
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
				if (num != 24U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt32();
					}
				}
				else
				{
					this.SeasonId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040081C7 RID: 33223
		private UnknownFieldSet _unknownFields;

		// Token: 0x040081C8 RID: 33224
		public const int SeasonIdFieldNumber = 3;

		// Token: 0x040081C9 RID: 33225
		private int seasonId_;

		// Token: 0x040081CA RID: 33226
		public const int IdFieldNumber = 5;

		// Token: 0x040081CB RID: 33227
		private int id_;
	}
}
