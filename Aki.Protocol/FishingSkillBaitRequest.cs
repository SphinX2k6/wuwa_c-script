using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000584 RID: 1412
	[NetMessage(EMessageId.FishingSkillBaitRequest)]
	public sealed class FishingSkillBaitRequest : IMessage<FishingSkillBaitRequest>, IMessage, IEquatable<FishingSkillBaitRequest>, IDeepCloneable<FishingSkillBaitRequest>, IBufferMessage
	{
		// Token: 0x0600831A RID: 33562 RVA: 0x0013C115 File Offset: 0x0013A315
		[NullableContext(1)]
		public static FishingSkillBaitRequest Create()
		{
			return new FishingSkillBaitRequest();
		}

		// Token: 0x1700198E RID: 6542
		// (get) Token: 0x0600831B RID: 33563 RVA: 0x0013C11C File Offset: 0x0013A31C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700198F RID: 6543
		// (get) Token: 0x0600831C RID: 33564 RVA: 0x0013C11F File Offset: 0x0013A31F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingSkillBaitRequest.Descriptor;
			}
		}

		// Token: 0x0600831D RID: 33565 RVA: 0x0013C126 File Offset: 0x0013A326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkillBaitRequest()
		{
		}

		// Token: 0x0600831E RID: 33566 RVA: 0x0013C12E File Offset: 0x0013A32E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkillBaitRequest(FishingSkillBaitRequest other) : this()
		{
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600831F RID: 33567 RVA: 0x0013C153 File Offset: 0x0013A353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkillBaitRequest Clone()
		{
			return new FishingSkillBaitRequest(this);
		}

		// Token: 0x17001990 RID: 6544
		// (get) Token: 0x06008320 RID: 33568 RVA: 0x0013C15B File Offset: 0x0013A35B
		// (set) Token: 0x06008321 RID: 33569 RVA: 0x0013C163 File Offset: 0x0013A363
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

		// Token: 0x06008322 RID: 33570 RVA: 0x0013C16C File Offset: 0x0013A36C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingSkillBaitRequest);
		}

		// Token: 0x06008323 RID: 33571 RVA: 0x0013C17A File Offset: 0x0013A37A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingSkillBaitRequest other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008324 RID: 33572 RVA: 0x0013C1A8 File Offset: 0x0013A3A8
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

		// Token: 0x06008325 RID: 33573 RVA: 0x0013C1E7 File Offset: 0x0013A3E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008326 RID: 33574 RVA: 0x0013C1F4 File Offset: 0x0013A3F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008327 RID: 33575 RVA: 0x0013C1FD File Offset: 0x0013A3FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008328 RID: 33576 RVA: 0x0013C230 File Offset: 0x0013A430
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

		// Token: 0x06008329 RID: 33577 RVA: 0x0013C26E File Offset: 0x0013A46E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingSkillBaitRequest other)
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

		// Token: 0x0600832A RID: 33578 RVA: 0x0013C29F File Offset: 0x0013A49F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600832B RID: 33579 RVA: 0x0013C2A8 File Offset: 0x0013A4A8
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004169 RID: 16745
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400416A RID: 16746
		public const int ItemIdFieldNumber = 3;

		// Token: 0x0400416B RID: 16747
		private int itemId_;
	}
}
