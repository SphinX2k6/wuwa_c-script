using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C39 RID: 3129
	[NetMessage(EMessageId.PhantomBattleCardGroupDeleteRequest)]
	public sealed class PhantomBattleCardGroupDeleteRequest : IMessage<PhantomBattleCardGroupDeleteRequest>, IMessage, IEquatable<PhantomBattleCardGroupDeleteRequest>, IDeepCloneable<PhantomBattleCardGroupDeleteRequest>, IBufferMessage
	{
		// Token: 0x06010FE9 RID: 69609 RVA: 0x0027DA8B File Offset: 0x0027BC8B
		[NullableContext(1)]
		public static PhantomBattleCardGroupDeleteRequest Create()
		{
			return new PhantomBattleCardGroupDeleteRequest();
		}

		// Token: 0x17003828 RID: 14376
		// (get) Token: 0x06010FEA RID: 69610 RVA: 0x0027DA92 File Offset: 0x0027BC92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003829 RID: 14377
		// (get) Token: 0x06010FEB RID: 69611 RVA: 0x0027DA95 File Offset: 0x0027BC95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardGroupDeleteRequest.Descriptor;
			}
		}

		// Token: 0x06010FEC RID: 69612 RVA: 0x0027DA9C File Offset: 0x0027BC9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupDeleteRequest()
		{
		}

		// Token: 0x06010FED RID: 69613 RVA: 0x0027DAA4 File Offset: 0x0027BCA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupDeleteRequest(PhantomBattleCardGroupDeleteRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010FEE RID: 69614 RVA: 0x0027DAD5 File Offset: 0x0027BCD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupDeleteRequest Clone()
		{
			return new PhantomBattleCardGroupDeleteRequest(this);
		}

		// Token: 0x1700382A RID: 14378
		// (get) Token: 0x06010FEF RID: 69615 RVA: 0x0027DADD File Offset: 0x0027BCDD
		// (set) Token: 0x06010FF0 RID: 69616 RVA: 0x0027DAE5 File Offset: 0x0027BCE5
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

		// Token: 0x1700382B RID: 14379
		// (get) Token: 0x06010FF1 RID: 69617 RVA: 0x0027DAEE File Offset: 0x0027BCEE
		// (set) Token: 0x06010FF2 RID: 69618 RVA: 0x0027DAF6 File Offset: 0x0027BCF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x06010FF3 RID: 69619 RVA: 0x0027DAFF File Offset: 0x0027BCFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardGroupDeleteRequest);
		}

		// Token: 0x06010FF4 RID: 69620 RVA: 0x0027DB0D File Offset: 0x0027BD0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardGroupDeleteRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010FF5 RID: 69621 RVA: 0x0027DB4C File Offset: 0x0027BD4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010FF6 RID: 69622 RVA: 0x0027DBA4 File Offset: 0x0027BDA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010FF7 RID: 69623 RVA: 0x0027DBB1 File Offset: 0x0027BDB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010FF8 RID: 69624 RVA: 0x0027DBBC File Offset: 0x0027BDBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Index);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010FF9 RID: 69625 RVA: 0x0027DC18 File Offset: 0x0027BE18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010FFA RID: 69626 RVA: 0x0027DC70 File Offset: 0x0027BE70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardGroupDeleteRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010FFB RID: 69627 RVA: 0x0027DCC0 File Offset: 0x0027BEC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010FFC RID: 69628 RVA: 0x0027DCCC File Offset: 0x0027BECC
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
				if (num != 96U)
				{
					if (num != 104U)
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
					this.Index = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006C2C RID: 27692
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C2D RID: 27693
		public const int ActivityIdFieldNumber = 13;

		// Token: 0x04006C2E RID: 27694
		private int activityId_;

		// Token: 0x04006C2F RID: 27695
		public const int IndexFieldNumber = 12;

		// Token: 0x04006C30 RID: 27696
		private int index_;
	}
}
