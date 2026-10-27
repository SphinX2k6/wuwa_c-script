using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C97 RID: 3223
	[NetMessage(EMessageId.PhantomBattleMasterInfoNotify)]
	public sealed class PhantomBattleMasterInfoNotify : IMessage<PhantomBattleMasterInfoNotify>, IMessage, IEquatable<PhantomBattleMasterInfoNotify>, IDeepCloneable<PhantomBattleMasterInfoNotify>, IBufferMessage
	{
		// Token: 0x06011786 RID: 71558 RVA: 0x0028F603 File Offset: 0x0028D803
		[NullableContext(1)]
		public static PhantomBattleMasterInfoNotify Create()
		{
			return new PhantomBattleMasterInfoNotify();
		}

		// Token: 0x170039E0 RID: 14816
		// (get) Token: 0x06011787 RID: 71559 RVA: 0x0028F60A File Offset: 0x0028D80A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039E1 RID: 14817
		// (get) Token: 0x06011788 RID: 71560 RVA: 0x0028F60D File Offset: 0x0028D80D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleMasterInfoNotify.Descriptor;
			}
		}

		// Token: 0x06011789 RID: 71561 RVA: 0x0028F614 File Offset: 0x0028D814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleMasterInfoNotify()
		{
		}

		// Token: 0x0601178A RID: 71562 RVA: 0x0028F61C File Offset: 0x0028D81C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleMasterInfoNotify(PhantomBattleMasterInfoNotify other) : this()
		{
			this.phantomBattleMasterInfo_ = ((other.phantomBattleMasterInfo_ != null) ? other.phantomBattleMasterInfo_.Clone() : null);
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601178B RID: 71563 RVA: 0x0028F668 File Offset: 0x0028D868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleMasterInfoNotify Clone()
		{
			return new PhantomBattleMasterInfoNotify(this);
		}

		// Token: 0x170039E2 RID: 14818
		// (get) Token: 0x0601178C RID: 71564 RVA: 0x0028F670 File Offset: 0x0028D870
		// (set) Token: 0x0601178D RID: 71565 RVA: 0x0028F678 File Offset: 0x0028D878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleMasterInfo PhantomBattleMasterInfo
		{
			get
			{
				return this.phantomBattleMasterInfo_;
			}
			set
			{
				this.phantomBattleMasterInfo_ = value;
			}
		}

		// Token: 0x170039E3 RID: 14819
		// (get) Token: 0x0601178E RID: 71566 RVA: 0x0028F681 File Offset: 0x0028D881
		// (set) Token: 0x0601178F RID: 71567 RVA: 0x0028F689 File Offset: 0x0028D889
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

		// Token: 0x06011790 RID: 71568 RVA: 0x0028F692 File Offset: 0x0028D892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleMasterInfoNotify);
		}

		// Token: 0x06011791 RID: 71569 RVA: 0x0028F6A0 File Offset: 0x0028D8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleMasterInfoNotify other)
		{
			return other != null && (other == this || (object.Equals(this.PhantomBattleMasterInfo, other.PhantomBattleMasterInfo) && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011792 RID: 71570 RVA: 0x0028F6F0 File Offset: 0x0028D8F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.phantomBattleMasterInfo_ != null)
			{
				num ^= this.PhantomBattleMasterInfo.GetHashCode();
			}
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011793 RID: 71571 RVA: 0x0028F745 File Offset: 0x0028D945
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011794 RID: 71572 RVA: 0x0028F752 File Offset: 0x0028D952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011795 RID: 71573 RVA: 0x0028F75C File Offset: 0x0028D95C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.phantomBattleMasterInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.PhantomBattleMasterInfo);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011796 RID: 71574 RVA: 0x0028F7B8 File Offset: 0x0028D9B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.phantomBattleMasterInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleMasterInfo);
			}
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011797 RID: 71575 RVA: 0x0028F810 File Offset: 0x0028DA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleMasterInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.phantomBattleMasterInfo_ != null)
			{
				if (this.phantomBattleMasterInfo_ == null)
				{
					this.PhantomBattleMasterInfo = new PhantomBattleMasterInfo();
				}
				this.PhantomBattleMasterInfo.MergeFrom(other.PhantomBattleMasterInfo);
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011798 RID: 71576 RVA: 0x0028F878 File Offset: 0x0028DA78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011799 RID: 71577 RVA: 0x0028F884 File Offset: 0x0028DA84
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
				if (num != 66U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					if (this.phantomBattleMasterInfo_ == null)
					{
						this.PhantomBattleMasterInfo = new PhantomBattleMasterInfo();
					}
					input.ReadMessage(this.PhantomBattleMasterInfo);
				}
			}
		}

		// Token: 0x04006E42 RID: 28226
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E43 RID: 28227
		public const int PhantomBattleMasterInfoFieldNumber = 8;

		// Token: 0x04006E44 RID: 28228
		private PhantomBattleMasterInfo phantomBattleMasterInfo_;

		// Token: 0x04006E45 RID: 28229
		public const int ActivityIdFieldNumber = 11;

		// Token: 0x04006E46 RID: 28230
		private int activityId_;
	}
}
