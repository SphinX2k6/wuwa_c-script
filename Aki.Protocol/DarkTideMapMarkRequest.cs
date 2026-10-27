using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003AA RID: 938
	[NetMessage(EMessageId.DarkTideMapMarkRequest)]
	public sealed class DarkTideMapMarkRequest : IMessage<DarkTideMapMarkRequest>, IMessage, IEquatable<DarkTideMapMarkRequest>, IDeepCloneable<DarkTideMapMarkRequest>, IBufferMessage
	{
		// Token: 0x06005C33 RID: 23603 RVA: 0x000E001D File Offset: 0x000DE21D
		[NullableContext(1)]
		public static DarkTideMapMarkRequest Create()
		{
			return new DarkTideMapMarkRequest();
		}

		// Token: 0x17001117 RID: 4375
		// (get) Token: 0x06005C34 RID: 23604 RVA: 0x000E0024 File Offset: 0x000DE224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001118 RID: 4376
		// (get) Token: 0x06005C35 RID: 23605 RVA: 0x000E0027 File Offset: 0x000DE227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DarkTideMapMarkRequest.Descriptor;
			}
		}

		// Token: 0x06005C36 RID: 23606 RVA: 0x000E002E File Offset: 0x000DE22E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideMapMarkRequest()
		{
		}

		// Token: 0x06005C37 RID: 23607 RVA: 0x000E0038 File Offset: 0x000DE238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideMapMarkRequest(DarkTideMapMarkRequest other) : this()
		{
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this.attachMarkId_ = other.attachMarkId_;
			this.isCancel_ = other.isCancel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005C38 RID: 23608 RVA: 0x000E0090 File Offset: 0x000DE290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideMapMarkRequest Clone()
		{
			return new DarkTideMapMarkRequest(this);
		}

		// Token: 0x17001119 RID: 4377
		// (get) Token: 0x06005C39 RID: 23609 RVA: 0x000E0098 File Offset: 0x000DE298
		// (set) Token: 0x06005C3A RID: 23610 RVA: 0x000E00A0 File Offset: 0x000DE2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Pos
		{
			get
			{
				return this.pos_;
			}
			set
			{
				this.pos_ = value;
			}
		}

		// Token: 0x1700111A RID: 4378
		// (get) Token: 0x06005C3B RID: 23611 RVA: 0x000E00A9 File Offset: 0x000DE2A9
		// (set) Token: 0x06005C3C RID: 23612 RVA: 0x000E00B1 File Offset: 0x000DE2B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AttachMarkId
		{
			get
			{
				return this.attachMarkId_;
			}
			set
			{
				this.attachMarkId_ = value;
			}
		}

		// Token: 0x1700111B RID: 4379
		// (get) Token: 0x06005C3D RID: 23613 RVA: 0x000E00BA File Offset: 0x000DE2BA
		// (set) Token: 0x06005C3E RID: 23614 RVA: 0x000E00C2 File Offset: 0x000DE2C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsCancel
		{
			get
			{
				return this.isCancel_;
			}
			set
			{
				this.isCancel_ = value;
			}
		}

		// Token: 0x06005C3F RID: 23615 RVA: 0x000E00CB File Offset: 0x000DE2CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DarkTideMapMarkRequest);
		}

		// Token: 0x06005C40 RID: 23616 RVA: 0x000E00DC File Offset: 0x000DE2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DarkTideMapMarkRequest other)
		{
			return other != null && (other == this || (object.Equals(this.Pos, other.Pos) && this.AttachMarkId == other.AttachMarkId && this.IsCancel == other.IsCancel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005C41 RID: 23617 RVA: 0x000E013C File Offset: 0x000DE33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.pos_ != null)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this.AttachMarkId != 0)
			{
				num ^= this.AttachMarkId.GetHashCode();
			}
			if (this.IsCancel)
			{
				num ^= this.IsCancel.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005C42 RID: 23618 RVA: 0x000E01AA File Offset: 0x000DE3AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005C43 RID: 23619 RVA: 0x000E01B7 File Offset: 0x000DE3B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005C44 RID: 23620 RVA: 0x000E01C0 File Offset: 0x000DE3C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AttachMarkId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.AttachMarkId);
			}
			if (this.IsCancel)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.IsCancel);
			}
			if (this.pos_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Pos);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005C45 RID: 23621 RVA: 0x000E0238 File Offset: 0x000DE438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.pos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Pos);
			}
			if (this.AttachMarkId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AttachMarkId);
			}
			if (this.IsCancel)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005C46 RID: 23622 RVA: 0x000E029C File Offset: 0x000DE49C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DarkTideMapMarkRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.pos_ != null)
			{
				if (this.pos_ == null)
				{
					this.Pos = new Vector();
				}
				this.Pos.MergeFrom(other.Pos);
			}
			if (other.AttachMarkId != 0)
			{
				this.AttachMarkId = other.AttachMarkId;
			}
			if (other.IsCancel)
			{
				this.IsCancel = other.IsCancel;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005C47 RID: 23623 RVA: 0x000E0318 File Offset: 0x000DE518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005C48 RID: 23624 RVA: 0x000E0324 File Offset: 0x000DE524
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
					if (num != 104U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.pos_ == null)
							{
								this.Pos = new Vector();
							}
							input.ReadMessage(this.Pos);
						}
					}
					else
					{
						this.IsCancel = input.ReadBool();
					}
				}
				else
				{
					this.AttachMarkId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003635 RID: 13877
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003636 RID: 13878
		public const int PosFieldNumber = 15;

		// Token: 0x04003637 RID: 13879
		private Vector pos_;

		// Token: 0x04003638 RID: 13880
		public const int AttachMarkIdFieldNumber = 3;

		// Token: 0x04003639 RID: 13881
		private int attachMarkId_;

		// Token: 0x0400363A RID: 13882
		public const int IsCancelFieldNumber = 13;

		// Token: 0x0400363B RID: 13883
		private bool isCancel_;
	}
}
