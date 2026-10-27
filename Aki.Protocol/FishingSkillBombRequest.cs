using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000586 RID: 1414
	[NetMessage(EMessageId.FishingSkillBombRequest)]
	public sealed class FishingSkillBombRequest : IMessage<FishingSkillBombRequest>, IMessage, IEquatable<FishingSkillBombRequest>, IDeepCloneable<FishingSkillBombRequest>, IBufferMessage
	{
		// Token: 0x0600833E RID: 33598 RVA: 0x0013C4CD File Offset: 0x0013A6CD
		[NullableContext(1)]
		public static FishingSkillBombRequest Create()
		{
			return new FishingSkillBombRequest();
		}

		// Token: 0x17001994 RID: 6548
		// (get) Token: 0x0600833F RID: 33599 RVA: 0x0013C4D4 File Offset: 0x0013A6D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001995 RID: 6549
		// (get) Token: 0x06008340 RID: 33600 RVA: 0x0013C4D7 File Offset: 0x0013A6D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingSkillBombRequest.Descriptor;
			}
		}

		// Token: 0x06008341 RID: 33601 RVA: 0x0013C4DE File Offset: 0x0013A6DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkillBombRequest()
		{
		}

		// Token: 0x06008342 RID: 33602 RVA: 0x0013C4E6 File Offset: 0x0013A6E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkillBombRequest(FishingSkillBombRequest other) : this()
		{
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008343 RID: 33603 RVA: 0x0013C50B File Offset: 0x0013A70B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkillBombRequest Clone()
		{
			return new FishingSkillBombRequest(this);
		}

		// Token: 0x17001996 RID: 6550
		// (get) Token: 0x06008344 RID: 33604 RVA: 0x0013C513 File Offset: 0x0013A713
		// (set) Token: 0x06008345 RID: 33605 RVA: 0x0013C51B File Offset: 0x0013A71B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x06008346 RID: 33606 RVA: 0x0013C524 File Offset: 0x0013A724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingSkillBombRequest);
		}

		// Token: 0x06008347 RID: 33607 RVA: 0x0013C532 File Offset: 0x0013A732
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingSkillBombRequest other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008348 RID: 33608 RVA: 0x0013C560 File Offset: 0x0013A760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008349 RID: 33609 RVA: 0x0013C59F File Offset: 0x0013A79F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600834A RID: 33610 RVA: 0x0013C5AC File Offset: 0x0013A7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600834B RID: 33611 RVA: 0x0013C5B5 File Offset: 0x0013A7B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600834C RID: 33612 RVA: 0x0013C5E8 File Offset: 0x0013A7E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600834D RID: 33613 RVA: 0x0013C626 File Offset: 0x0013A826
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingSkillBombRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600834E RID: 33614 RVA: 0x0013C657 File Offset: 0x0013A857
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600834F RID: 33615 RVA: 0x0013C660 File Offset: 0x0013A860
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400416F RID: 16751
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004170 RID: 16752
		public const int ItemIdFieldNumber = 14;

		// Token: 0x04004171 RID: 16753
		private int itemId_;
	}
}
