using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BBA RID: 3002
	[NetMessage(EMessageId.ParkourChallengeOpenNotify)]
	public sealed class ParkourChallengeOpenNotify : IMessage<ParkourChallengeOpenNotify>, IMessage, IEquatable<ParkourChallengeOpenNotify>, IDeepCloneable<ParkourChallengeOpenNotify>, IBufferMessage
	{
		// Token: 0x0601045E RID: 66654 RVA: 0x002600AD File Offset: 0x0025E2AD
		[NullableContext(1)]
		public static ParkourChallengeOpenNotify Create()
		{
			return new ParkourChallengeOpenNotify();
		}

		// Token: 0x17003561 RID: 13665
		// (get) Token: 0x0601045F RID: 66655 RVA: 0x002600B4 File Offset: 0x0025E2B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003562 RID: 13666
		// (get) Token: 0x06010460 RID: 66656 RVA: 0x002600B7 File Offset: 0x0025E2B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ParkourChallengeOpenNotify.Descriptor;
			}
		}

		// Token: 0x06010461 RID: 66657 RVA: 0x002600BE File Offset: 0x0025E2BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeOpenNotify()
		{
		}

		// Token: 0x06010462 RID: 66658 RVA: 0x002600C6 File Offset: 0x0025E2C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeOpenNotify(ParkourChallengeOpenNotify other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.isOpen_ = other.isOpen_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010463 RID: 66659 RVA: 0x002600F7 File Offset: 0x0025E2F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeOpenNotify Clone()
		{
			return new ParkourChallengeOpenNotify(this);
		}

		// Token: 0x17003563 RID: 13667
		// (get) Token: 0x06010464 RID: 66660 RVA: 0x002600FF File Offset: 0x0025E2FF
		// (set) Token: 0x06010465 RID: 66661 RVA: 0x00260107 File Offset: 0x0025E307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChallengeId
		{
			get
			{
				return this.challengeId_;
			}
			set
			{
				this.challengeId_ = value;
			}
		}

		// Token: 0x17003564 RID: 13668
		// (get) Token: 0x06010466 RID: 66662 RVA: 0x00260110 File Offset: 0x0025E310
		// (set) Token: 0x06010467 RID: 66663 RVA: 0x00260118 File Offset: 0x0025E318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsOpen
		{
			get
			{
				return this.isOpen_;
			}
			set
			{
				this.isOpen_ = value;
			}
		}

		// Token: 0x06010468 RID: 66664 RVA: 0x00260121 File Offset: 0x0025E321
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ParkourChallengeOpenNotify);
		}

		// Token: 0x06010469 RID: 66665 RVA: 0x0026012F File Offset: 0x0025E32F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ParkourChallengeOpenNotify other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.IsOpen == other.IsOpen && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601046A RID: 66666 RVA: 0x00260170 File Offset: 0x0025E370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.IsOpen)
			{
				num ^= this.IsOpen.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601046B RID: 66667 RVA: 0x002601C8 File Offset: 0x0025E3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601046C RID: 66668 RVA: 0x002601D5 File Offset: 0x0025E3D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601046D RID: 66669 RVA: 0x002601E0 File Offset: 0x0025E3E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ChallengeId);
			}
			if (this.IsOpen)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsOpen);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601046E RID: 66670 RVA: 0x0026023C File Offset: 0x0025E43C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this.IsOpen)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601046F RID: 66671 RVA: 0x00260288 File Offset: 0x0025E488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ParkourChallengeOpenNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.IsOpen)
			{
				this.IsOpen = other.IsOpen;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010470 RID: 66672 RVA: 0x002602D8 File Offset: 0x0025E4D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010471 RID: 66673 RVA: 0x002602E4 File Offset: 0x0025E4E4
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
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsOpen = input.ReadBool();
					}
				}
				else
				{
					this.ChallengeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006788 RID: 26504
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006789 RID: 26505
		public const int ChallengeIdFieldNumber = 4;

		// Token: 0x0400678A RID: 26506
		private int challengeId_;

		// Token: 0x0400678B RID: 26507
		public const int IsOpenFieldNumber = 9;

		// Token: 0x0400678C RID: 26508
		private bool isOpen_;
	}
}
