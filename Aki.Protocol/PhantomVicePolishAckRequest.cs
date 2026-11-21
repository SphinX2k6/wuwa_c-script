using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CFE RID: 3326
	[NetMessage(EMessageId.PhantomVicePolishAckRequest)]
	public sealed class PhantomVicePolishAckRequest : IMessage<PhantomVicePolishAckRequest>, IMessage, IEquatable<PhantomVicePolishAckRequest>, IDeepCloneable<PhantomVicePolishAckRequest>, IBufferMessage
	{
		// Token: 0x06011FF2 RID: 73714 RVA: 0x002A1DB1 File Offset: 0x0029FFB1
		[NullableContext(1)]
		public static PhantomVicePolishAckRequest Create()
		{
			return new PhantomVicePolishAckRequest();
		}

		// Token: 0x17003BA0 RID: 15264
		// (get) Token: 0x06011FF3 RID: 73715 RVA: 0x002A1DB8 File Offset: 0x0029FFB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BA1 RID: 15265
		// (get) Token: 0x06011FF4 RID: 73716 RVA: 0x002A1DBB File Offset: 0x0029FFBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomVicePolishAckRequest.Descriptor;
			}
		}

		// Token: 0x06011FF5 RID: 73717 RVA: 0x002A1DC2 File Offset: 0x0029FFC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomVicePolishAckRequest()
		{
		}

		// Token: 0x06011FF6 RID: 73718 RVA: 0x002A1DCA File Offset: 0x0029FFCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomVicePolishAckRequest(PhantomVicePolishAckRequest other) : this()
		{
			this.incrId_ = other.incrId_;
			this.ack_ = other.ack_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011FF7 RID: 73719 RVA: 0x002A1DFB File Offset: 0x0029FFFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomVicePolishAckRequest Clone()
		{
			return new PhantomVicePolishAckRequest(this);
		}

		// Token: 0x17003BA2 RID: 15266
		// (get) Token: 0x06011FF8 RID: 73720 RVA: 0x002A1E03 File Offset: 0x002A0003
		// (set) Token: 0x06011FF9 RID: 73721 RVA: 0x002A1E0B File Offset: 0x002A000B
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

		// Token: 0x17003BA3 RID: 15267
		// (get) Token: 0x06011FFA RID: 73722 RVA: 0x002A1E14 File Offset: 0x002A0014
		// (set) Token: 0x06011FFB RID: 73723 RVA: 0x002A1E1C File Offset: 0x002A001C
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

		// Token: 0x06011FFC RID: 73724 RVA: 0x002A1E25 File Offset: 0x002A0025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomVicePolishAckRequest);
		}

		// Token: 0x06011FFD RID: 73725 RVA: 0x002A1E33 File Offset: 0x002A0033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomVicePolishAckRequest other)
		{
			return other != null && (other == this || (this.IncrId == other.IncrId && this.Ack == other.Ack && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011FFE RID: 73726 RVA: 0x002A1E74 File Offset: 0x002A0074
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

		// Token: 0x06011FFF RID: 73727 RVA: 0x002A1ECC File Offset: 0x002A00CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012000 RID: 73728 RVA: 0x002A1ED9 File Offset: 0x002A00D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012001 RID: 73729 RVA: 0x002A1EE4 File Offset: 0x002A00E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncrId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.IncrId);
			}
			if (this.Ack)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.Ack);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012002 RID: 73730 RVA: 0x002A1F40 File Offset: 0x002A0140
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

		// Token: 0x06012003 RID: 73731 RVA: 0x002A1F8C File Offset: 0x002A018C
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

		// Token: 0x06012004 RID: 73732 RVA: 0x002A1FDC File Offset: 0x002A01DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012005 RID: 73733 RVA: 0x002A1FE8 File Offset: 0x002A01E8
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
				if (num != 32U)
				{
					if (num != 120U)
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

		// Token: 0x0400711C RID: 28956
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400711D RID: 28957
		public const int IncrIdFieldNumber = 4;

		// Token: 0x0400711E RID: 28958
		private int incrId_;

		// Token: 0x0400711F RID: 28959
		public const int AckFieldNumber = 15;

		// Token: 0x04007120 RID: 28960
		private bool ack_;
	}
}
