using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001257 RID: 4695
	[NetMessage(EMessageId.SlientFirstAwardNotify)]
	public sealed class SlientFirstAwardNotify : IMessage<SlientFirstAwardNotify>, IMessage, IEquatable<SlientFirstAwardNotify>, IDeepCloneable<SlientFirstAwardNotify>, IBufferMessage
	{
		// Token: 0x06019043 RID: 102467 RVA: 0x003A3E38 File Offset: 0x003A2038
		[NullableContext(1)]
		public static SlientFirstAwardNotify Create()
		{
			return new SlientFirstAwardNotify();
		}

		// Token: 0x17005460 RID: 21600
		// (get) Token: 0x06019044 RID: 102468 RVA: 0x003A3E3F File Offset: 0x003A203F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005461 RID: 21601
		// (get) Token: 0x06019045 RID: 102469 RVA: 0x003A3E42 File Offset: 0x003A2042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SlientFirstAwardNotify.Descriptor;
			}
		}

		// Token: 0x06019046 RID: 102470 RVA: 0x003A3E49 File Offset: 0x003A2049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlientFirstAwardNotify()
		{
		}

		// Token: 0x06019047 RID: 102471 RVA: 0x003A3E51 File Offset: 0x003A2051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlientFirstAwardNotify(SlientFirstAwardNotify other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019048 RID: 102472 RVA: 0x003A3E76 File Offset: 0x003A2076
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlientFirstAwardNotify Clone()
		{
			return new SlientFirstAwardNotify(this);
		}

		// Token: 0x17005462 RID: 21602
		// (get) Token: 0x06019049 RID: 102473 RVA: 0x003A3E7E File Offset: 0x003A207E
		// (set) Token: 0x0601904A RID: 102474 RVA: 0x003A3E86 File Offset: 0x003A2086
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

		// Token: 0x0601904B RID: 102475 RVA: 0x003A3E8F File Offset: 0x003A208F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SlientFirstAwardNotify);
		}

		// Token: 0x0601904C RID: 102476 RVA: 0x003A3E9D File Offset: 0x003A209D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SlientFirstAwardNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601904D RID: 102477 RVA: 0x003A3ECC File Offset: 0x003A20CC
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

		// Token: 0x0601904E RID: 102478 RVA: 0x003A3F0B File Offset: 0x003A210B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601904F RID: 102479 RVA: 0x003A3F18 File Offset: 0x003A2118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019050 RID: 102480 RVA: 0x003A3F21 File Offset: 0x003A2121
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019051 RID: 102481 RVA: 0x003A3F54 File Offset: 0x003A2154
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

		// Token: 0x06019052 RID: 102482 RVA: 0x003A3F92 File Offset: 0x003A2192
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SlientFirstAwardNotify other)
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

		// Token: 0x06019053 RID: 102483 RVA: 0x003A3FC3 File Offset: 0x003A21C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019054 RID: 102484 RVA: 0x003A3FCC File Offset: 0x003A21CC
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
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400936F RID: 37743
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009370 RID: 37744
		public const int IdFieldNumber = 7;

		// Token: 0x04009371 RID: 37745
		private int id_;
	}
}
