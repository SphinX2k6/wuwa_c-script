using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000917 RID: 2327
	[NetMessage(EMessageId.LifePointChallengeStartRequest)]
	public sealed class LifePointChallengeStartRequest : IMessage<LifePointChallengeStartRequest>, IMessage, IEquatable<LifePointChallengeStartRequest>, IDeepCloneable<LifePointChallengeStartRequest>, IBufferMessage
	{
		// Token: 0x0600CD62 RID: 52578 RVA: 0x001E440C File Offset: 0x001E260C
		[NullableContext(1)]
		public static LifePointChallengeStartRequest Create()
		{
			return new LifePointChallengeStartRequest();
		}

		// Token: 0x1700297C RID: 10620
		// (get) Token: 0x0600CD63 RID: 52579 RVA: 0x001E4413 File Offset: 0x001E2613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700297D RID: 10621
		// (get) Token: 0x0600CD64 RID: 52580 RVA: 0x001E4416 File Offset: 0x001E2616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LifePointChallengeStartRequest.Descriptor;
			}
		}

		// Token: 0x0600CD65 RID: 52581 RVA: 0x001E441D File Offset: 0x001E261D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifePointChallengeStartRequest()
		{
		}

		// Token: 0x0600CD66 RID: 52582 RVA: 0x001E4425 File Offset: 0x001E2625
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifePointChallengeStartRequest(LifePointChallengeStartRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CD67 RID: 52583 RVA: 0x001E444A File Offset: 0x001E264A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifePointChallengeStartRequest Clone()
		{
			return new LifePointChallengeStartRequest(this);
		}

		// Token: 0x1700297E RID: 10622
		// (get) Token: 0x0600CD68 RID: 52584 RVA: 0x001E4452 File Offset: 0x001E2652
		// (set) Token: 0x0600CD69 RID: 52585 RVA: 0x001E445A File Offset: 0x001E265A
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

		// Token: 0x0600CD6A RID: 52586 RVA: 0x001E4463 File Offset: 0x001E2663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LifePointChallengeStartRequest);
		}

		// Token: 0x0600CD6B RID: 52587 RVA: 0x001E4471 File Offset: 0x001E2671
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LifePointChallengeStartRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CD6C RID: 52588 RVA: 0x001E44A0 File Offset: 0x001E26A0
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

		// Token: 0x0600CD6D RID: 52589 RVA: 0x001E44DF File Offset: 0x001E26DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CD6E RID: 52590 RVA: 0x001E44EC File Offset: 0x001E26EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CD6F RID: 52591 RVA: 0x001E44F5 File Offset: 0x001E26F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CD70 RID: 52592 RVA: 0x001E4528 File Offset: 0x001E2728
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

		// Token: 0x0600CD71 RID: 52593 RVA: 0x001E4566 File Offset: 0x001E2766
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LifePointChallengeStartRequest other)
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

		// Token: 0x0600CD72 RID: 52594 RVA: 0x001E4597 File Offset: 0x001E2797
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CD73 RID: 52595 RVA: 0x001E45A0 File Offset: 0x001E27A0
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040056F5 RID: 22261
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056F6 RID: 22262
		public const int IdFieldNumber = 13;

		// Token: 0x040056F7 RID: 22263
		private int id_;
	}
}
