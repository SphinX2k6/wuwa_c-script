using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D52 RID: 3410
	[NetMessage(EMessageId.PinballStartNotify)]
	public sealed class PinballStartNotify : IMessage<PinballStartNotify>, IMessage, IEquatable<PinballStartNotify>, IDeepCloneable<PinballStartNotify>, IBufferMessage
	{
		// Token: 0x060126AC RID: 75436 RVA: 0x002B08A0 File Offset: 0x002AEAA0
		[NullableContext(1)]
		public static PinballStartNotify Create()
		{
			return new PinballStartNotify();
		}

		// Token: 0x17003D0E RID: 15630
		// (get) Token: 0x060126AD RID: 75437 RVA: 0x002B08A7 File Offset: 0x002AEAA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D0F RID: 15631
		// (get) Token: 0x060126AE RID: 75438 RVA: 0x002B08AA File Offset: 0x002AEAAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballStartNotify.Descriptor;
			}
		}

		// Token: 0x060126AF RID: 75439 RVA: 0x002B08B1 File Offset: 0x002AEAB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballStartNotify()
		{
		}

		// Token: 0x060126B0 RID: 75440 RVA: 0x002B08BC File Offset: 0x002AEABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballStartNotify(PinballStartNotify other) : this()
		{
			this.realLevelId_ = other.realLevelId_;
			this.inProgressPb_ = ((other.inProgressPb_ != null) ? other.inProgressPb_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060126B1 RID: 75441 RVA: 0x002B0908 File Offset: 0x002AEB08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballStartNotify Clone()
		{
			return new PinballStartNotify(this);
		}

		// Token: 0x17003D10 RID: 15632
		// (get) Token: 0x060126B2 RID: 75442 RVA: 0x002B0910 File Offset: 0x002AEB10
		// (set) Token: 0x060126B3 RID: 75443 RVA: 0x002B0918 File Offset: 0x002AEB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RealLevelId
		{
			get
			{
				return this.realLevelId_;
			}
			set
			{
				this.realLevelId_ = value;
			}
		}

		// Token: 0x17003D11 RID: 15633
		// (get) Token: 0x060126B4 RID: 75444 RVA: 0x002B0921 File Offset: 0x002AEB21
		// (set) Token: 0x060126B5 RID: 75445 RVA: 0x002B0929 File Offset: 0x002AEB29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInProgressPb InProgressPb
		{
			get
			{
				return this.inProgressPb_;
			}
			set
			{
				this.inProgressPb_ = value;
			}
		}

		// Token: 0x060126B6 RID: 75446 RVA: 0x002B0932 File Offset: 0x002AEB32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballStartNotify);
		}

		// Token: 0x060126B7 RID: 75447 RVA: 0x002B0940 File Offset: 0x002AEB40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballStartNotify other)
		{
			return other != null && (other == this || (this.RealLevelId == other.RealLevelId && object.Equals(this.InProgressPb, other.InProgressPb) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060126B8 RID: 75448 RVA: 0x002B0990 File Offset: 0x002AEB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RealLevelId != 0)
			{
				num ^= this.RealLevelId.GetHashCode();
			}
			if (this.inProgressPb_ != null)
			{
				num ^= this.InProgressPb.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060126B9 RID: 75449 RVA: 0x002B09E5 File Offset: 0x002AEBE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060126BA RID: 75450 RVA: 0x002B09F2 File Offset: 0x002AEBF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060126BB RID: 75451 RVA: 0x002B09FC File Offset: 0x002AEBFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.inProgressPb_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.InProgressPb);
			}
			if (this.RealLevelId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.RealLevelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060126BC RID: 75452 RVA: 0x002B0A58 File Offset: 0x002AEC58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RealLevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RealLevelId);
			}
			if (this.inProgressPb_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.InProgressPb);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060126BD RID: 75453 RVA: 0x002B0AB0 File Offset: 0x002AECB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballStartNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RealLevelId != 0)
			{
				this.RealLevelId = other.RealLevelId;
			}
			if (other.inProgressPb_ != null)
			{
				if (this.inProgressPb_ == null)
				{
					this.InProgressPb = new PinballInProgressPb();
				}
				this.InProgressPb.MergeFrom(other.InProgressPb);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060126BE RID: 75454 RVA: 0x002B0B18 File Offset: 0x002AED18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060126BF RID: 75455 RVA: 0x002B0B24 File Offset: 0x002AED24
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
				if (num != 58U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RealLevelId = input.ReadInt32();
					}
				}
				else
				{
					if (this.inProgressPb_ == null)
					{
						this.InProgressPb = new PinballInProgressPb();
					}
					input.ReadMessage(this.InProgressPb);
				}
			}
		}

		// Token: 0x0400730C RID: 29452
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400730D RID: 29453
		public const int RealLevelIdFieldNumber = 13;

		// Token: 0x0400730E RID: 29454
		private int realLevelId_;

		// Token: 0x0400730F RID: 29455
		public const int InProgressPbFieldNumber = 7;

		// Token: 0x04007310 RID: 29456
		private PinballInProgressPb inProgressPb_;
	}
}
