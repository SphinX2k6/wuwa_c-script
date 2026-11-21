using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200056F RID: 1391
	[NetMessage(EMessageId.FishingSkillBaitRequest)]
	public sealed class FishingSkillBaitRequest : IMessage<FishingSkillBaitRequest>, IMessage, IEquatable<FishingSkillBaitRequest>, IDeepCloneable<FishingSkillBaitRequest>, IBufferMessage
	{
		// Token: 0x060081B2 RID: 33202 RVA: 0x00139509 File Offset: 0x00137709
		[NullableContext(1)]
		public static FishingSkillBaitRequest Create()
		{
			return new FishingSkillBaitRequest();
		}

		// Token: 0x17001941 RID: 6465
		// (get) Token: 0x060081B3 RID: 33203 RVA: 0x00139510 File Offset: 0x00137710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001942 RID: 6466
		// (get) Token: 0x060081B4 RID: 33204 RVA: 0x00139513 File Offset: 0x00137713
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingSkillBaitRequest.Descriptor;
			}
		}

		// Token: 0x060081B5 RID: 33205 RVA: 0x0013951A File Offset: 0x0013771A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkillBaitRequest()
		{
		}

		// Token: 0x060081B6 RID: 33206 RVA: 0x00139522 File Offset: 0x00137722
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkillBaitRequest(FishingSkillBaitRequest other) : this()
		{
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060081B7 RID: 33207 RVA: 0x00139547 File Offset: 0x00137747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkillBaitRequest Clone()
		{
			return new FishingSkillBaitRequest(this);
		}

		// Token: 0x17001943 RID: 6467
		// (get) Token: 0x060081B8 RID: 33208 RVA: 0x0013954F File Offset: 0x0013774F
		// (set) Token: 0x060081B9 RID: 33209 RVA: 0x00139557 File Offset: 0x00137757
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

		// Token: 0x060081BA RID: 33210 RVA: 0x00139560 File Offset: 0x00137760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingSkillBaitRequest);
		}

		// Token: 0x060081BB RID: 33211 RVA: 0x0013956E File Offset: 0x0013776E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingSkillBaitRequest other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060081BC RID: 33212 RVA: 0x0013959C File Offset: 0x0013779C
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

		// Token: 0x060081BD RID: 33213 RVA: 0x001395DB File Offset: 0x001377DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060081BE RID: 33214 RVA: 0x001395E8 File Offset: 0x001377E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060081BF RID: 33215 RVA: 0x001395F1 File Offset: 0x001377F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060081C0 RID: 33216 RVA: 0x00139624 File Offset: 0x00137824
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

		// Token: 0x060081C1 RID: 33217 RVA: 0x00139662 File Offset: 0x00137862
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

		// Token: 0x060081C2 RID: 33218 RVA: 0x00139693 File Offset: 0x00137893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060081C3 RID: 33219 RVA: 0x0013969C File Offset: 0x0013789C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400415F RID: 16735
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004160 RID: 16736
		public const int ItemIdFieldNumber = 4;

		// Token: 0x04004161 RID: 16737
		private int itemId_;
	}
}
