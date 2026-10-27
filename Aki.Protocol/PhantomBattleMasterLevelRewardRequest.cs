using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C98 RID: 3224
	[NetMessage(EMessageId.PhantomBattleMasterLevelRewardRequest)]
	public sealed class PhantomBattleMasterLevelRewardRequest : IMessage<PhantomBattleMasterLevelRewardRequest>, IMessage, IEquatable<PhantomBattleMasterLevelRewardRequest>, IDeepCloneable<PhantomBattleMasterLevelRewardRequest>, IBufferMessage
	{
		// Token: 0x0601179A RID: 71578 RVA: 0x0028F8EF File Offset: 0x0028DAEF
		[NullableContext(1)]
		public static PhantomBattleMasterLevelRewardRequest Create()
		{
			return new PhantomBattleMasterLevelRewardRequest();
		}

		// Token: 0x170039E4 RID: 14820
		// (get) Token: 0x0601179B RID: 71579 RVA: 0x0028F8F6 File Offset: 0x0028DAF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039E5 RID: 14821
		// (get) Token: 0x0601179C RID: 71580 RVA: 0x0028F8F9 File Offset: 0x0028DAF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleMasterLevelRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601179D RID: 71581 RVA: 0x0028F900 File Offset: 0x0028DB00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleMasterLevelRewardRequest()
		{
		}

		// Token: 0x0601179E RID: 71582 RVA: 0x0028F908 File Offset: 0x0028DB08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleMasterLevelRewardRequest(PhantomBattleMasterLevelRewardRequest other) : this()
		{
			this.phantomBattleMasterLevelId_ = other.phantomBattleMasterLevelId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601179F RID: 71583 RVA: 0x0028F92D File Offset: 0x0028DB2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleMasterLevelRewardRequest Clone()
		{
			return new PhantomBattleMasterLevelRewardRequest(this);
		}

		// Token: 0x170039E6 RID: 14822
		// (get) Token: 0x060117A0 RID: 71584 RVA: 0x0028F935 File Offset: 0x0028DB35
		// (set) Token: 0x060117A1 RID: 71585 RVA: 0x0028F93D File Offset: 0x0028DB3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PhantomBattleMasterLevelId
		{
			get
			{
				return this.phantomBattleMasterLevelId_;
			}
			set
			{
				this.phantomBattleMasterLevelId_ = value;
			}
		}

		// Token: 0x060117A2 RID: 71586 RVA: 0x0028F946 File Offset: 0x0028DB46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleMasterLevelRewardRequest);
		}

		// Token: 0x060117A3 RID: 71587 RVA: 0x0028F954 File Offset: 0x0028DB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleMasterLevelRewardRequest other)
		{
			return other != null && (other == this || (this.PhantomBattleMasterLevelId == other.PhantomBattleMasterLevelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060117A4 RID: 71588 RVA: 0x0028F984 File Offset: 0x0028DB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PhantomBattleMasterLevelId != 0)
			{
				num ^= this.PhantomBattleMasterLevelId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060117A5 RID: 71589 RVA: 0x0028F9C3 File Offset: 0x0028DBC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060117A6 RID: 71590 RVA: 0x0028F9D0 File Offset: 0x0028DBD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060117A7 RID: 71591 RVA: 0x0028F9D9 File Offset: 0x0028DBD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PhantomBattleMasterLevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PhantomBattleMasterLevelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060117A8 RID: 71592 RVA: 0x0028FA0C File Offset: 0x0028DC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PhantomBattleMasterLevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PhantomBattleMasterLevelId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060117A9 RID: 71593 RVA: 0x0028FA4A File Offset: 0x0028DC4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleMasterLevelRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PhantomBattleMasterLevelId != 0)
			{
				this.PhantomBattleMasterLevelId = other.PhantomBattleMasterLevelId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060117AA RID: 71594 RVA: 0x0028FA7B File Offset: 0x0028DC7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060117AB RID: 71595 RVA: 0x0028FA84 File Offset: 0x0028DC84
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PhantomBattleMasterLevelId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006E47 RID: 28231
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E48 RID: 28232
		public const int PhantomBattleMasterLevelIdFieldNumber = 1;

		// Token: 0x04006E49 RID: 28233
		private int phantomBattleMasterLevelId_;
	}
}
