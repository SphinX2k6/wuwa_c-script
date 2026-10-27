using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000528 RID: 1320
	[NetMessage(EMessageId.FarmGoldPointRequest)]
	public sealed class FarmGoldPointRequest : IMessage<FarmGoldPointRequest>, IMessage, IEquatable<FarmGoldPointRequest>, IDeepCloneable<FarmGoldPointRequest>, IBufferMessage
	{
		// Token: 0x06007BCC RID: 31692 RVA: 0x0012C28D File Offset: 0x0012A48D
		[NullableContext(1)]
		public static FarmGoldPointRequest Create()
		{
			return new FarmGoldPointRequest();
		}

		// Token: 0x17001804 RID: 6148
		// (get) Token: 0x06007BCD RID: 31693 RVA: 0x0012C294 File Offset: 0x0012A494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001805 RID: 6149
		// (get) Token: 0x06007BCE RID: 31694 RVA: 0x0012C297 File Offset: 0x0012A497
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FarmGoldPointRequest.Descriptor;
			}
		}

		// Token: 0x06007BCF RID: 31695 RVA: 0x0012C29E File Offset: 0x0012A49E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldPointRequest()
		{
		}

		// Token: 0x06007BD0 RID: 31696 RVA: 0x0012C2A6 File Offset: 0x0012A4A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldPointRequest(FarmGoldPointRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007BD1 RID: 31697 RVA: 0x0012C2D7 File Offset: 0x0012A4D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldPointRequest Clone()
		{
			return new FarmGoldPointRequest(this);
		}

		// Token: 0x17001806 RID: 6150
		// (get) Token: 0x06007BD2 RID: 31698 RVA: 0x0012C2DF File Offset: 0x0012A4DF
		// (set) Token: 0x06007BD3 RID: 31699 RVA: 0x0012C2E7 File Offset: 0x0012A4E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17001807 RID: 6151
		// (get) Token: 0x06007BD4 RID: 31700 RVA: 0x0012C2F0 File Offset: 0x0012A4F0
		// (set) Token: 0x06007BD5 RID: 31701 RVA: 0x0012C2F8 File Offset: 0x0012A4F8
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

		// Token: 0x06007BD6 RID: 31702 RVA: 0x0012C301 File Offset: 0x0012A501
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FarmGoldPointRequest);
		}

		// Token: 0x06007BD7 RID: 31703 RVA: 0x0012C30F File Offset: 0x0012A50F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FarmGoldPointRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007BD8 RID: 31704 RVA: 0x0012C350 File Offset: 0x0012A550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
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

		// Token: 0x06007BD9 RID: 31705 RVA: 0x0012C3A8 File Offset: 0x0012A5A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007BDA RID: 31706 RVA: 0x0012C3B5 File Offset: 0x0012A5B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007BDB RID: 31707 RVA: 0x0012C3C0 File Offset: 0x0012A5C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007BDC RID: 31708 RVA: 0x0012C41C File Offset: 0x0012A61C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
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

		// Token: 0x06007BDD RID: 31709 RVA: 0x0012C474 File Offset: 0x0012A674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FarmGoldPointRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007BDE RID: 31710 RVA: 0x0012C4C4 File Offset: 0x0012A6C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007BDF RID: 31711 RVA: 0x0012C4D0 File Offset: 0x0012A6D0
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
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003F44 RID: 16196
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F45 RID: 16197
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x04003F46 RID: 16198
		private int activityId_;

		// Token: 0x04003F47 RID: 16199
		public const int IdFieldNumber = 10;

		// Token: 0x04003F48 RID: 16200
		private int id_;
	}
}
