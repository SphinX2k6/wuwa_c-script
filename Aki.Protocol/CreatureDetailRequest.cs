using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200031F RID: 799
	[NetMessage(EMessageId.CreatureDetailRequest)]
	public sealed class CreatureDetailRequest : IMessage<CreatureDetailRequest>, IMessage, IEquatable<CreatureDetailRequest>, IDeepCloneable<CreatureDetailRequest>, IBufferMessage
	{
		// Token: 0x060050B2 RID: 20658 RVA: 0x000C5044 File Offset: 0x000C3244
		[NullableContext(1)]
		public static CreatureDetailRequest Create()
		{
			return new CreatureDetailRequest();
		}

		// Token: 0x17000E78 RID: 3704
		// (get) Token: 0x060050B3 RID: 20659 RVA: 0x000C504B File Offset: 0x000C324B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E79 RID: 3705
		// (get) Token: 0x060050B4 RID: 20660 RVA: 0x000C504E File Offset: 0x000C324E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CreatureDetailRequest.Descriptor;
			}
		}

		// Token: 0x060050B5 RID: 20661 RVA: 0x000C5055 File Offset: 0x000C3255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreatureDetailRequest()
		{
		}

		// Token: 0x060050B6 RID: 20662 RVA: 0x000C505D File Offset: 0x000C325D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreatureDetailRequest(CreatureDetailRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060050B7 RID: 20663 RVA: 0x000C5082 File Offset: 0x000C3282
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CreatureDetailRequest Clone()
		{
			return new CreatureDetailRequest(this);
		}

		// Token: 0x17000E7A RID: 3706
		// (get) Token: 0x060050B8 RID: 20664 RVA: 0x000C508A File Offset: 0x000C328A
		// (set) Token: 0x060050B9 RID: 20665 RVA: 0x000C5092 File Offset: 0x000C3292
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

		// Token: 0x060050BA RID: 20666 RVA: 0x000C509B File Offset: 0x000C329B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CreatureDetailRequest);
		}

		// Token: 0x060050BB RID: 20667 RVA: 0x000C50A9 File Offset: 0x000C32A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CreatureDetailRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060050BC RID: 20668 RVA: 0x000C50D8 File Offset: 0x000C32D8
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

		// Token: 0x060050BD RID: 20669 RVA: 0x000C5117 File Offset: 0x000C3317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060050BE RID: 20670 RVA: 0x000C5124 File Offset: 0x000C3324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060050BF RID: 20671 RVA: 0x000C512D File Offset: 0x000C332D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060050C0 RID: 20672 RVA: 0x000C5160 File Offset: 0x000C3360
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

		// Token: 0x060050C1 RID: 20673 RVA: 0x000C519E File Offset: 0x000C339E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CreatureDetailRequest other)
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

		// Token: 0x060050C2 RID: 20674 RVA: 0x000C51CF File Offset: 0x000C33CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060050C3 RID: 20675 RVA: 0x000C51D8 File Offset: 0x000C33D8
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x040032C8 RID: 13000
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032C9 RID: 13001
		public const int IdFieldNumber = 10;

		// Token: 0x040032CA RID: 13002
		private long id_;
	}
}
