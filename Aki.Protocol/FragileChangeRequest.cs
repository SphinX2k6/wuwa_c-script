using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200062E RID: 1582
	[NetMessage(EMessageId.FragileChangeRequest)]
	public sealed class FragileChangeRequest : IMessage<FragileChangeRequest>, IMessage, IEquatable<FragileChangeRequest>, IDeepCloneable<FragileChangeRequest>, IBufferMessage
	{
		// Token: 0x06009231 RID: 37425 RVA: 0x0016237B File Offset: 0x0016057B
		[NullableContext(1)]
		public static FragileChangeRequest Create()
		{
			return new FragileChangeRequest();
		}

		// Token: 0x17001D15 RID: 7445
		// (get) Token: 0x06009232 RID: 37426 RVA: 0x00162382 File Offset: 0x00160582
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D16 RID: 7446
		// (get) Token: 0x06009233 RID: 37427 RVA: 0x00162385 File Offset: 0x00160585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FragileChangeRequest.Descriptor;
			}
		}

		// Token: 0x06009234 RID: 37428 RVA: 0x0016238C File Offset: 0x0016058C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FragileChangeRequest()
		{
		}

		// Token: 0x06009235 RID: 37429 RVA: 0x00162394 File Offset: 0x00160594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FragileChangeRequest(FragileChangeRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.flag_ = other.flag_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009236 RID: 37430 RVA: 0x001623C5 File Offset: 0x001605C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FragileChangeRequest Clone()
		{
			return new FragileChangeRequest(this);
		}

		// Token: 0x17001D17 RID: 7447
		// (get) Token: 0x06009237 RID: 37431 RVA: 0x001623CD File Offset: 0x001605CD
		// (set) Token: 0x06009238 RID: 37432 RVA: 0x001623D5 File Offset: 0x001605D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17001D18 RID: 7448
		// (get) Token: 0x06009239 RID: 37433 RVA: 0x001623DE File Offset: 0x001605DE
		// (set) Token: 0x0600923A RID: 37434 RVA: 0x001623E6 File Offset: 0x001605E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Flag
		{
			get
			{
				return this.flag_;
			}
			set
			{
				this.flag_ = value;
			}
		}

		// Token: 0x0600923B RID: 37435 RVA: 0x001623EF File Offset: 0x001605EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FragileChangeRequest);
		}

		// Token: 0x0600923C RID: 37436 RVA: 0x001623FD File Offset: 0x001605FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FragileChangeRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.Flag == other.Flag && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600923D RID: 37437 RVA: 0x0016243C File Offset: 0x0016063C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.Flag)
			{
				num ^= this.Flag.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600923E RID: 37438 RVA: 0x00162494 File Offset: 0x00160694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600923F RID: 37439 RVA: 0x001624A1 File Offset: 0x001606A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009240 RID: 37440 RVA: 0x001624AC File Offset: 0x001606AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.EntityId);
			}
			if (this.Flag)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.Flag);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009241 RID: 37441 RVA: 0x00162508 File Offset: 0x00160708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.Flag)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009242 RID: 37442 RVA: 0x00162554 File Offset: 0x00160754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FragileChangeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.Flag)
			{
				this.Flag = other.Flag;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009243 RID: 37443 RVA: 0x001625A4 File Offset: 0x001607A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009244 RID: 37444 RVA: 0x001625B0 File Offset: 0x001607B0
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
				if (num != 80U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Flag = input.ReadBool();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040046E5 RID: 18149
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046E6 RID: 18150
		public const int EntityIdFieldNumber = 10;

		// Token: 0x040046E7 RID: 18151
		private long entityId_;

		// Token: 0x040046E8 RID: 18152
		public const int FlagFieldNumber = 14;

		// Token: 0x040046E9 RID: 18153
		private bool flag_;
	}
}
