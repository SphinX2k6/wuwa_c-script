using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000E5 RID: 229
	[NetMessage(EMessageId.AnimalDieRequest)]
	public sealed class AnimalDieRequest : IMessage<AnimalDieRequest>, IMessage, IEquatable<AnimalDieRequest>, IDeepCloneable<AnimalDieRequest>, IBufferMessage
	{
		// Token: 0x0600219C RID: 8604 RVA: 0x00059DB8 File Offset: 0x00057FB8
		[NullableContext(1)]
		public static AnimalDieRequest Create()
		{
			return new AnimalDieRequest();
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x0600219D RID: 8605 RVA: 0x00059DBF File Offset: 0x00057FBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x0600219E RID: 8606 RVA: 0x00059DC2 File Offset: 0x00057FC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimalDieRequest.Descriptor;
			}
		}

		// Token: 0x0600219F RID: 8607 RVA: 0x00059DC9 File Offset: 0x00057FC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDieRequest()
		{
		}

		// Token: 0x060021A0 RID: 8608 RVA: 0x00059DD4 File Offset: 0x00057FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDieRequest(AnimalDieRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060021A1 RID: 8609 RVA: 0x00059E20 File Offset: 0x00058020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDieRequest Clone()
		{
			return new AnimalDieRequest(this);
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x060021A2 RID: 8610 RVA: 0x00059E28 File Offset: 0x00058028
		// (set) Token: 0x060021A3 RID: 8611 RVA: 0x00059E30 File Offset: 0x00058030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x060021A4 RID: 8612 RVA: 0x00059E39 File Offset: 0x00058039
		// (set) Token: 0x060021A5 RID: 8613 RVA: 0x00059E41 File Offset: 0x00058041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Pos
		{
			get
			{
				return this.pos_;
			}
			set
			{
				this.pos_ = value;
			}
		}

		// Token: 0x060021A6 RID: 8614 RVA: 0x00059E4A File Offset: 0x0005804A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimalDieRequest);
		}

		// Token: 0x060021A7 RID: 8615 RVA: 0x00059E58 File Offset: 0x00058058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimalDieRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.Pos, other.Pos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060021A8 RID: 8616 RVA: 0x00059EA8 File Offset: 0x000580A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.pos_ != null)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060021A9 RID: 8617 RVA: 0x00059EFD File Offset: 0x000580FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060021AA RID: 8618 RVA: 0x00059F0A File Offset: 0x0005810A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060021AB RID: 8619 RVA: 0x00059F14 File Offset: 0x00058114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.pos_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Pos);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060021AC RID: 8620 RVA: 0x00059F70 File Offset: 0x00058170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.pos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Pos);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060021AD RID: 8621 RVA: 0x00059FC8 File Offset: 0x000581C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AnimalDieRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.pos_ != null)
			{
				if (this.pos_ == null)
				{
					this.Pos = new Vector();
				}
				this.Pos.MergeFrom(other.Pos);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060021AE RID: 8622 RVA: 0x0005A030 File Offset: 0x00058230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060021AF RID: 8623 RVA: 0x0005A03C File Offset: 0x0005823C
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
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					if (this.pos_ == null)
					{
						this.Pos = new Vector();
					}
					input.ReadMessage(this.Pos);
				}
			}
		}

		// Token: 0x04002446 RID: 9286
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002447 RID: 9287
		public const int EntityIdFieldNumber = 12;

		// Token: 0x04002448 RID: 9288
		private long entityId_;

		// Token: 0x04002449 RID: 9289
		public const int PosFieldNumber = 6;

		// Token: 0x0400244A RID: 9290
		private Vector pos_;
	}
}
