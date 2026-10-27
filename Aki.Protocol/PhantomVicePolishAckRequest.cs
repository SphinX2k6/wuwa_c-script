using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D0E RID: 3342
	[NetMessage(EMessageId.PhantomVicePolishAckRequest)]
	public sealed class PhantomVicePolishAckRequest : IMessage<PhantomVicePolishAckRequest>, IMessage, IEquatable<PhantomVicePolishAckRequest>, IDeepCloneable<PhantomVicePolishAckRequest>, IBufferMessage
	{
		// Token: 0x060120EE RID: 73966 RVA: 0x002A39D5 File Offset: 0x002A1BD5
		[NullableContext(1)]
		public static PhantomVicePolishAckRequest Create()
		{
			return new PhantomVicePolishAckRequest();
		}

		// Token: 0x17003BD5 RID: 15317
		// (get) Token: 0x060120EF RID: 73967 RVA: 0x002A39DC File Offset: 0x002A1BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BD6 RID: 15318
		// (get) Token: 0x060120F0 RID: 73968 RVA: 0x002A39DF File Offset: 0x002A1BDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomVicePolishAckRequest.Descriptor;
			}
		}

		// Token: 0x060120F1 RID: 73969 RVA: 0x002A39E6 File Offset: 0x002A1BE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomVicePolishAckRequest()
		{
		}

		// Token: 0x060120F2 RID: 73970 RVA: 0x002A39EE File Offset: 0x002A1BEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomVicePolishAckRequest(PhantomVicePolishAckRequest other) : this()
		{
			this.incrId_ = other.incrId_;
			this.ack_ = other.ack_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060120F3 RID: 73971 RVA: 0x002A3A1F File Offset: 0x002A1C1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomVicePolishAckRequest Clone()
		{
			return new PhantomVicePolishAckRequest(this);
		}

		// Token: 0x17003BD7 RID: 15319
		// (get) Token: 0x060120F4 RID: 73972 RVA: 0x002A3A27 File Offset: 0x002A1C27
		// (set) Token: 0x060120F5 RID: 73973 RVA: 0x002A3A2F File Offset: 0x002A1C2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncrId
		{
			get
			{
				return this.incrId_;
			}
			set
			{
				this.incrId_ = value;
			}
		}

		// Token: 0x17003BD8 RID: 15320
		// (get) Token: 0x060120F6 RID: 73974 RVA: 0x002A3A38 File Offset: 0x002A1C38
		// (set) Token: 0x060120F7 RID: 73975 RVA: 0x002A3A40 File Offset: 0x002A1C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Ack
		{
			get
			{
				return this.ack_;
			}
			set
			{
				this.ack_ = value;
			}
		}

		// Token: 0x060120F8 RID: 73976 RVA: 0x002A3A49 File Offset: 0x002A1C49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomVicePolishAckRequest);
		}

		// Token: 0x060120F9 RID: 73977 RVA: 0x002A3A57 File Offset: 0x002A1C57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomVicePolishAckRequest other)
		{
			return other != null && (other == this || (this.IncrId == other.IncrId && this.Ack == other.Ack && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060120FA RID: 73978 RVA: 0x002A3A98 File Offset: 0x002A1C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncrId != 0)
			{
				num ^= this.IncrId.GetHashCode();
			}
			if (this.Ack)
			{
				num ^= this.Ack.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060120FB RID: 73979 RVA: 0x002A3AF0 File Offset: 0x002A1CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060120FC RID: 73980 RVA: 0x002A3AFD File Offset: 0x002A1CFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060120FD RID: 73981 RVA: 0x002A3B08 File Offset: 0x002A1D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncrId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.IncrId);
			}
			if (this.Ack)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.Ack);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060120FE RID: 73982 RVA: 0x002A3B64 File Offset: 0x002A1D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncrId);
			}
			if (this.Ack)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060120FF RID: 73983 RVA: 0x002A3BB0 File Offset: 0x002A1DB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomVicePolishAckRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncrId != 0)
			{
				this.IncrId = other.IncrId;
			}
			if (other.Ack)
			{
				this.Ack = other.Ack;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012100 RID: 73984 RVA: 0x002A3C00 File Offset: 0x002A1E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012101 RID: 73985 RVA: 0x002A3C0C File Offset: 0x002A1E0C
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
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Ack = input.ReadBool();
					}
				}
				else
				{
					this.IncrId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007104 RID: 28932
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007105 RID: 28933
		public const int IncrIdFieldNumber = 10;

		// Token: 0x04007106 RID: 28934
		private int incrId_;

		// Token: 0x04007107 RID: 28935
		public const int AckFieldNumber = 11;

		// Token: 0x04007108 RID: 28936
		private bool ack_;
	}
}
