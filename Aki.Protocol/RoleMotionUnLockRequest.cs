using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001091 RID: 4241
	[NetMessage(EMessageId.RoleMotionUnLockRequest)]
	public sealed class RoleMotionUnLockRequest : IMessage<RoleMotionUnLockRequest>, IMessage, IEquatable<RoleMotionUnLockRequest>, IDeepCloneable<RoleMotionUnLockRequest>, IBufferMessage
	{
		// Token: 0x06016A7E RID: 92798 RVA: 0x0034B258 File Offset: 0x00349458
		[NullableContext(1)]
		public static RoleMotionUnLockRequest Create()
		{
			return new RoleMotionUnLockRequest();
		}

		// Token: 0x17004BE6 RID: 19430
		// (get) Token: 0x06016A7F RID: 92799 RVA: 0x0034B25F File Offset: 0x0034945F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004BE7 RID: 19431
		// (get) Token: 0x06016A80 RID: 92800 RVA: 0x0034B262 File Offset: 0x00349462
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleMotionUnLockRequest.Descriptor;
			}
		}

		// Token: 0x06016A81 RID: 92801 RVA: 0x0034B269 File Offset: 0x00349469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotionUnLockRequest()
		{
		}

		// Token: 0x06016A82 RID: 92802 RVA: 0x0034B271 File Offset: 0x00349471
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotionUnLockRequest(RoleMotionUnLockRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.unLockId_ = other.unLockId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016A83 RID: 92803 RVA: 0x0034B2A2 File Offset: 0x003494A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotionUnLockRequest Clone()
		{
			return new RoleMotionUnLockRequest(this);
		}

		// Token: 0x17004BE8 RID: 19432
		// (get) Token: 0x06016A84 RID: 92804 RVA: 0x0034B2AA File Offset: 0x003494AA
		// (set) Token: 0x06016A85 RID: 92805 RVA: 0x0034B2B2 File Offset: 0x003494B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17004BE9 RID: 19433
		// (get) Token: 0x06016A86 RID: 92806 RVA: 0x0034B2BB File Offset: 0x003494BB
		// (set) Token: 0x06016A87 RID: 92807 RVA: 0x0034B2C3 File Offset: 0x003494C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UnLockId
		{
			get
			{
				return this.unLockId_;
			}
			set
			{
				this.unLockId_ = value;
			}
		}

		// Token: 0x06016A88 RID: 92808 RVA: 0x0034B2CC File Offset: 0x003494CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleMotionUnLockRequest);
		}

		// Token: 0x06016A89 RID: 92809 RVA: 0x0034B2DA File Offset: 0x003494DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleMotionUnLockRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.UnLockId == other.UnLockId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016A8A RID: 92810 RVA: 0x0034B318 File Offset: 0x00349518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.UnLockId != 0)
			{
				num ^= this.UnLockId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016A8B RID: 92811 RVA: 0x0034B370 File Offset: 0x00349570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016A8C RID: 92812 RVA: 0x0034B37D File Offset: 0x0034957D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016A8D RID: 92813 RVA: 0x0034B388 File Offset: 0x00349588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.UnLockId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.UnLockId);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016A8E RID: 92814 RVA: 0x0034B3E4 File Offset: 0x003495E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.UnLockId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UnLockId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016A8F RID: 92815 RVA: 0x0034B43C File Offset: 0x0034963C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleMotionUnLockRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.UnLockId != 0)
			{
				this.UnLockId = other.UnLockId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016A90 RID: 92816 RVA: 0x0034B48C File Offset: 0x0034968C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016A91 RID: 92817 RVA: 0x0034B498 File Offset: 0x00349698
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
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RoleId = input.ReadInt32();
					}
				}
				else
				{
					this.UnLockId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008768 RID: 34664
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008769 RID: 34665
		public const int RoleIdFieldNumber = 15;

		// Token: 0x0400876A RID: 34666
		private int roleId_;

		// Token: 0x0400876B RID: 34667
		public const int UnLockIdFieldNumber = 13;

		// Token: 0x0400876C RID: 34668
		private int unLockId_;
	}
}
