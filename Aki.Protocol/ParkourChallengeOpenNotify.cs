using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BAA RID: 2986
	[NetMessage(EMessageId.ParkourChallengeOpenNotify)]
	public sealed class ParkourChallengeOpenNotify : IMessage<ParkourChallengeOpenNotify>, IMessage, IEquatable<ParkourChallengeOpenNotify>, IDeepCloneable<ParkourChallengeOpenNotify>, IBufferMessage
	{
		// Token: 0x0601035A RID: 66394 RVA: 0x0025E1F9 File Offset: 0x0025C3F9
		[NullableContext(1)]
		public static ParkourChallengeOpenNotify Create()
		{
			return new ParkourChallengeOpenNotify();
		}

		// Token: 0x17003528 RID: 13608
		// (get) Token: 0x0601035B RID: 66395 RVA: 0x0025E200 File Offset: 0x0025C400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003529 RID: 13609
		// (get) Token: 0x0601035C RID: 66396 RVA: 0x0025E203 File Offset: 0x0025C403
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ParkourChallengeOpenNotify.Descriptor;
			}
		}

		// Token: 0x0601035D RID: 66397 RVA: 0x0025E20A File Offset: 0x0025C40A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeOpenNotify()
		{
		}

		// Token: 0x0601035E RID: 66398 RVA: 0x0025E212 File Offset: 0x0025C412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeOpenNotify(ParkourChallengeOpenNotify other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.isOpen_ = other.isOpen_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601035F RID: 66399 RVA: 0x0025E243 File Offset: 0x0025C443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ParkourChallengeOpenNotify Clone()
		{
			return new ParkourChallengeOpenNotify(this);
		}

		// Token: 0x1700352A RID: 13610
		// (get) Token: 0x06010360 RID: 66400 RVA: 0x0025E24B File Offset: 0x0025C44B
		// (set) Token: 0x06010361 RID: 66401 RVA: 0x0025E253 File Offset: 0x0025C453
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

		// Token: 0x1700352B RID: 13611
		// (get) Token: 0x06010362 RID: 66402 RVA: 0x0025E25C File Offset: 0x0025C45C
		// (set) Token: 0x06010363 RID: 66403 RVA: 0x0025E264 File Offset: 0x0025C464
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

		// Token: 0x06010364 RID: 66404 RVA: 0x0025E26D File Offset: 0x0025C46D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ParkourChallengeOpenNotify);
		}

		// Token: 0x06010365 RID: 66405 RVA: 0x0025E27B File Offset: 0x0025C47B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ParkourChallengeOpenNotify other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.IsOpen == other.IsOpen && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010366 RID: 66406 RVA: 0x0025E2BC File Offset: 0x0025C4BC
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

		// Token: 0x06010367 RID: 66407 RVA: 0x0025E314 File Offset: 0x0025C514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010368 RID: 66408 RVA: 0x0025E321 File Offset: 0x0025C521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010369 RID: 66409 RVA: 0x0025E32C File Offset: 0x0025C52C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ChallengeId);
			}
			if (this.IsOpen)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsOpen);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601036A RID: 66410 RVA: 0x0025E384 File Offset: 0x0025C584
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

		// Token: 0x0601036B RID: 66411 RVA: 0x0025E3D0 File Offset: 0x0025C5D0
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

		// Token: 0x0601036C RID: 66412 RVA: 0x0025E420 File Offset: 0x0025C620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601036D RID: 66413 RVA: 0x0025E42C File Offset: 0x0025C62C
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
					if (num != 88U)
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

		// Token: 0x04006798 RID: 26520
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006799 RID: 26521
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x0400679A RID: 26522
		private int challengeId_;

		// Token: 0x0400679B RID: 26523
		public const int IsOpenFieldNumber = 11;

		// Token: 0x0400679C RID: 26524
		private bool isOpen_;
	}
}
