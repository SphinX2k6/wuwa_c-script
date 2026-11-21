using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008E9 RID: 2281
	[NetMessage(EMessageId.LevelPlayFirstNotify)]
	public sealed class LevelPlayFirstNotify : IMessage<LevelPlayFirstNotify>, IMessage, IEquatable<LevelPlayFirstNotify>, IDeepCloneable<LevelPlayFirstNotify>, IBufferMessage
	{
		// Token: 0x0600C9F4 RID: 51700 RVA: 0x001DD375 File Offset: 0x001DB575
		[NullableContext(1)]
		public static LevelPlayFirstNotify Create()
		{
			return new LevelPlayFirstNotify();
		}

		// Token: 0x170028C1 RID: 10433
		// (get) Token: 0x0600C9F5 RID: 51701 RVA: 0x001DD37C File Offset: 0x001DB57C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028C2 RID: 10434
		// (get) Token: 0x0600C9F6 RID: 51702 RVA: 0x001DD37F File Offset: 0x001DB57F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayFirstNotify.Descriptor;
			}
		}

		// Token: 0x0600C9F7 RID: 51703 RVA: 0x001DD386 File Offset: 0x001DB586
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayFirstNotify()
		{
		}

		// Token: 0x0600C9F8 RID: 51704 RVA: 0x001DD38E File Offset: 0x001DB58E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayFirstNotify(LevelPlayFirstNotify other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C9F9 RID: 51705 RVA: 0x001DD3B3 File Offset: 0x001DB5B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayFirstNotify Clone()
		{
			return new LevelPlayFirstNotify(this);
		}

		// Token: 0x170028C3 RID: 10435
		// (get) Token: 0x0600C9FA RID: 51706 RVA: 0x001DD3BB File Offset: 0x001DB5BB
		// (set) Token: 0x0600C9FB RID: 51707 RVA: 0x001DD3C3 File Offset: 0x001DB5C3
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

		// Token: 0x0600C9FC RID: 51708 RVA: 0x001DD3CC File Offset: 0x001DB5CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayFirstNotify);
		}

		// Token: 0x0600C9FD RID: 51709 RVA: 0x001DD3DA File Offset: 0x001DB5DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayFirstNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C9FE RID: 51710 RVA: 0x001DD408 File Offset: 0x001DB608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600C9FF RID: 51711 RVA: 0x001DD447 File Offset: 0x001DB647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CA00 RID: 51712 RVA: 0x001DD454 File Offset: 0x001DB654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CA01 RID: 51713 RVA: 0x001DD45D File Offset: 0x001DB65D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CA02 RID: 51714 RVA: 0x001DD490 File Offset: 0x001DB690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600CA03 RID: 51715 RVA: 0x001DD4CE File Offset: 0x001DB6CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayFirstNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CA04 RID: 51716 RVA: 0x001DD4FF File Offset: 0x001DB6FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CA05 RID: 51717 RVA: 0x001DD508 File Offset: 0x001DB708
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005655 RID: 22101
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005656 RID: 22102
		public const int IdFieldNumber = 1;

		// Token: 0x04005657 RID: 22103
		private int id_;
	}
}
