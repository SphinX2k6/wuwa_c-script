using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001498 RID: 5272
	[NetMessage(EMessageId.TrapDefenseGainingGroupUpdateNotify)]
	public sealed class TrapDefenseGainingGroupUpdateNotify : IMessage<TrapDefenseGainingGroupUpdateNotify>, IMessage, IEquatable<TrapDefenseGainingGroupUpdateNotify>, IDeepCloneable<TrapDefenseGainingGroupUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601BFD2 RID: 114642 RVA: 0x00410D0C File Offset: 0x0040EF0C
		[NullableContext(1)]
		public static TrapDefenseGainingGroupUpdateNotify Create()
		{
			return new TrapDefenseGainingGroupUpdateNotify();
		}

		// Token: 0x17005EC3 RID: 24259
		// (get) Token: 0x0601BFD3 RID: 114643 RVA: 0x00410D13 File Offset: 0x0040EF13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EC4 RID: 24260
		// (get) Token: 0x0601BFD4 RID: 114644 RVA: 0x00410D16 File Offset: 0x0040EF16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseGainingGroupUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601BFD5 RID: 114645 RVA: 0x00410D1D File Offset: 0x0040EF1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGainingGroupUpdateNotify()
		{
		}

		// Token: 0x0601BFD6 RID: 114646 RVA: 0x00410D28 File Offset: 0x0040EF28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGainingGroupUpdateNotify(TrapDefenseGainingGroupUpdateNotify other) : this()
		{
			this.gainingGroupInfo_ = ((other.gainingGroupInfo_ != null) ? other.gainingGroupInfo_.Clone() : null);
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BFD7 RID: 114647 RVA: 0x00410D74 File Offset: 0x0040EF74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGainingGroupUpdateNotify Clone()
		{
			return new TrapDefenseGainingGroupUpdateNotify(this);
		}

		// Token: 0x17005EC5 RID: 24261
		// (get) Token: 0x0601BFD8 RID: 114648 RVA: 0x00410D7C File Offset: 0x0040EF7C
		// (set) Token: 0x0601BFD9 RID: 114649 RVA: 0x00410D84 File Offset: 0x0040EF84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGainingInfo GainingGroupInfo
		{
			get
			{
				return this.gainingGroupInfo_;
			}
			set
			{
				this.gainingGroupInfo_ = value;
			}
		}

		// Token: 0x17005EC6 RID: 24262
		// (get) Token: 0x0601BFDA RID: 114650 RVA: 0x00410D8D File Offset: 0x0040EF8D
		// (set) Token: 0x0601BFDB RID: 114651 RVA: 0x00410D95 File Offset: 0x0040EF95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGainingUpdateReason Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x0601BFDC RID: 114652 RVA: 0x00410D9E File Offset: 0x0040EF9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseGainingGroupUpdateNotify);
		}

		// Token: 0x0601BFDD RID: 114653 RVA: 0x00410DAC File Offset: 0x0040EFAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseGainingGroupUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.GainingGroupInfo, other.GainingGroupInfo) && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BFDE RID: 114654 RVA: 0x00410DFC File Offset: 0x0040EFFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.gainingGroupInfo_ != null)
			{
				num ^= this.GainingGroupInfo.GetHashCode();
			}
			if (this.Reason != TrapDefenseGainingUpdateReason.GmaddGroup)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BFDF RID: 114655 RVA: 0x00410E57 File Offset: 0x0040F057
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BFE0 RID: 114656 RVA: 0x00410E64 File Offset: 0x0040F064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BFE1 RID: 114657 RVA: 0x00410E70 File Offset: 0x0040F070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reason != TrapDefenseGainingUpdateReason.GmaddGroup)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Reason);
			}
			if (this.gainingGroupInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.GainingGroupInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BFE2 RID: 114658 RVA: 0x00410ECC File Offset: 0x0040F0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.gainingGroupInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GainingGroupInfo);
			}
			if (this.Reason != TrapDefenseGainingUpdateReason.GmaddGroup)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BFE3 RID: 114659 RVA: 0x00410F24 File Offset: 0x0040F124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseGainingGroupUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.gainingGroupInfo_ != null)
			{
				if (this.gainingGroupInfo_ == null)
				{
					this.GainingGroupInfo = new TrapDefenseGainingInfo();
				}
				this.GainingGroupInfo.MergeFrom(other.GainingGroupInfo);
			}
			if (other.Reason != TrapDefenseGainingUpdateReason.GmaddGroup)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BFE4 RID: 114660 RVA: 0x00410F8C File Offset: 0x0040F18C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BFE5 RID: 114661 RVA: 0x00410F98 File Offset: 0x0040F198
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
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.gainingGroupInfo_ == null)
						{
							this.GainingGroupInfo = new TrapDefenseGainingInfo();
						}
						input.ReadMessage(this.GainingGroupInfo);
					}
				}
				else
				{
					this.Reason = (TrapDefenseGainingUpdateReason)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A231 RID: 41521
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A232 RID: 41522
		public const int GainingGroupInfoFieldNumber = 15;

		// Token: 0x0400A233 RID: 41523
		private TrapDefenseGainingInfo gainingGroupInfo_;

		// Token: 0x0400A234 RID: 41524
		public const int ReasonFieldNumber = 4;

		// Token: 0x0400A235 RID: 41525
		private TrapDefenseGainingUpdateReason reason_;
	}
}
