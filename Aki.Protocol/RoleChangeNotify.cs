using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200104D RID: 4173
	[NetMessage(EMessageId.RoleChangeNotify)]
	public sealed class RoleChangeNotify : IMessage<RoleChangeNotify>, IMessage, IEquatable<RoleChangeNotify>, IDeepCloneable<RoleChangeNotify>, IBufferMessage
	{
		// Token: 0x0601653B RID: 91451 RVA: 0x0033F3F0 File Offset: 0x0033D5F0
		[NullableContext(1)]
		public static RoleChangeNotify Create()
		{
			return new RoleChangeNotify();
		}

		// Token: 0x17004AB8 RID: 19128
		// (get) Token: 0x0601653C RID: 91452 RVA: 0x0033F3F7 File Offset: 0x0033D5F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004AB9 RID: 19129
		// (get) Token: 0x0601653D RID: 91453 RVA: 0x0033F3FA File Offset: 0x0033D5FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleChangeNotify.Descriptor;
			}
		}

		// Token: 0x0601653E RID: 91454 RVA: 0x0033F401 File Offset: 0x0033D601
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleChangeNotify()
		{
		}

		// Token: 0x0601653F RID: 91455 RVA: 0x0033F40C File Offset: 0x0033D60C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleChangeNotify(RoleChangeNotify other) : this()
		{
			this.sourceRoleId_ = other.sourceRoleId_;
			this.roleInfo_ = ((other.roleInfo_ != null) ? other.roleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016540 RID: 91456 RVA: 0x0033F458 File Offset: 0x0033D658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleChangeNotify Clone()
		{
			return new RoleChangeNotify(this);
		}

		// Token: 0x17004ABA RID: 19130
		// (get) Token: 0x06016541 RID: 91457 RVA: 0x0033F460 File Offset: 0x0033D660
		// (set) Token: 0x06016542 RID: 91458 RVA: 0x0033F468 File Offset: 0x0033D668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SourceRoleId
		{
			get
			{
				return this.sourceRoleId_;
			}
			set
			{
				this.sourceRoleId_ = value;
			}
		}

		// Token: 0x17004ABB RID: 19131
		// (get) Token: 0x06016543 RID: 91459 RVA: 0x0033F471 File Offset: 0x0033D671
		// (set) Token: 0x06016544 RID: 91460 RVA: 0x0033F479 File Offset: 0x0033D679
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public roleInfo RoleInfo
		{
			get
			{
				return this.roleInfo_;
			}
			set
			{
				this.roleInfo_ = value;
			}
		}

		// Token: 0x06016545 RID: 91461 RVA: 0x0033F482 File Offset: 0x0033D682
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleChangeNotify);
		}

		// Token: 0x06016546 RID: 91462 RVA: 0x0033F490 File Offset: 0x0033D690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleChangeNotify other)
		{
			return other != null && (other == this || (this.SourceRoleId == other.SourceRoleId && object.Equals(this.RoleInfo, other.RoleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016547 RID: 91463 RVA: 0x0033F4E0 File Offset: 0x0033D6E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SourceRoleId != 0)
			{
				num ^= this.SourceRoleId.GetHashCode();
			}
			if (this.roleInfo_ != null)
			{
				num ^= this.RoleInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016548 RID: 91464 RVA: 0x0033F535 File Offset: 0x0033D735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016549 RID: 91465 RVA: 0x0033F542 File Offset: 0x0033D742
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601654A RID: 91466 RVA: 0x0033F54C File Offset: 0x0033D74C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.roleInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.RoleInfo);
			}
			if (this.SourceRoleId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.SourceRoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601654B RID: 91467 RVA: 0x0033F5A8 File Offset: 0x0033D7A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SourceRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SourceRoleId);
			}
			if (this.roleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoleInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601654C RID: 91468 RVA: 0x0033F600 File Offset: 0x0033D800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SourceRoleId != 0)
			{
				this.SourceRoleId = other.SourceRoleId;
			}
			if (other.roleInfo_ != null)
			{
				if (this.roleInfo_ == null)
				{
					this.RoleInfo = new roleInfo();
				}
				this.RoleInfo.MergeFrom(other.RoleInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601654D RID: 91469 RVA: 0x0033F668 File Offset: 0x0033D868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601654E RID: 91470 RVA: 0x0033F674 File Offset: 0x0033D874
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
				if (num != 18U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SourceRoleId = input.ReadInt32();
					}
				}
				else
				{
					if (this.roleInfo_ == null)
					{
						this.RoleInfo = new roleInfo();
					}
					input.ReadMessage(this.RoleInfo);
				}
			}
		}

		// Token: 0x04008606 RID: 34310
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008607 RID: 34311
		public const int SourceRoleIdFieldNumber = 5;

		// Token: 0x04008608 RID: 34312
		private int sourceRoleId_;

		// Token: 0x04008609 RID: 34313
		public const int RoleInfoFieldNumber = 2;

		// Token: 0x0400860A RID: 34314
		private roleInfo roleInfo_;
	}
}
