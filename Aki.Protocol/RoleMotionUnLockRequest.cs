using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001081 RID: 4225
	[NetMessage(EMessageId.RoleMotionUnLockRequest)]
	public sealed class RoleMotionUnLockRequest : IMessage<RoleMotionUnLockRequest>, IMessage, IEquatable<RoleMotionUnLockRequest>, IDeepCloneable<RoleMotionUnLockRequest>, IBufferMessage
	{
		// Token: 0x06016999 RID: 92569 RVA: 0x00349B80 File Offset: 0x00347D80
		[NullableContext(1)]
		public static RoleMotionUnLockRequest Create()
		{
			return new RoleMotionUnLockRequest();
		}

		// Token: 0x17004BBC RID: 19388
		// (get) Token: 0x0601699A RID: 92570 RVA: 0x00349B87 File Offset: 0x00347D87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004BBD RID: 19389
		// (get) Token: 0x0601699B RID: 92571 RVA: 0x00349B8A File Offset: 0x00347D8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleMotionUnLockRequest.Descriptor;
			}
		}

		// Token: 0x0601699C RID: 92572 RVA: 0x00349B91 File Offset: 0x00347D91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotionUnLockRequest()
		{
		}

		// Token: 0x0601699D RID: 92573 RVA: 0x00349B99 File Offset: 0x00347D99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotionUnLockRequest(RoleMotionUnLockRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.unLockId_ = other.unLockId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601699E RID: 92574 RVA: 0x00349BCA File Offset: 0x00347DCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotionUnLockRequest Clone()
		{
			return new RoleMotionUnLockRequest(this);
		}

		// Token: 0x17004BBE RID: 19390
		// (get) Token: 0x0601699F RID: 92575 RVA: 0x00349BD2 File Offset: 0x00347DD2
		// (set) Token: 0x060169A0 RID: 92576 RVA: 0x00349BDA File Offset: 0x00347DDA
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

		// Token: 0x17004BBF RID: 19391
		// (get) Token: 0x060169A1 RID: 92577 RVA: 0x00349BE3 File Offset: 0x00347DE3
		// (set) Token: 0x060169A2 RID: 92578 RVA: 0x00349BEB File Offset: 0x00347DEB
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

		// Token: 0x060169A3 RID: 92579 RVA: 0x00349BF4 File Offset: 0x00347DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleMotionUnLockRequest);
		}

		// Token: 0x060169A4 RID: 92580 RVA: 0x00349C02 File Offset: 0x00347E02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleMotionUnLockRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.UnLockId == other.UnLockId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060169A5 RID: 92581 RVA: 0x00349C40 File Offset: 0x00347E40
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

		// Token: 0x060169A6 RID: 92582 RVA: 0x00349C98 File Offset: 0x00347E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060169A7 RID: 92583 RVA: 0x00349CA5 File Offset: 0x00347EA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060169A8 RID: 92584 RVA: 0x00349CB0 File Offset: 0x00347EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.UnLockId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.UnLockId);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060169A9 RID: 92585 RVA: 0x00349D08 File Offset: 0x00347F08
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

		// Token: 0x060169AA RID: 92586 RVA: 0x00349D60 File Offset: 0x00347F60
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

		// Token: 0x060169AB RID: 92587 RVA: 0x00349DB0 File Offset: 0x00347FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060169AC RID: 92588 RVA: 0x00349DBC File Offset: 0x00347FBC
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
					if (num != 72U)
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

		// Token: 0x04008792 RID: 34706
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008793 RID: 34707
		public const int RoleIdFieldNumber = 9;

		// Token: 0x04008794 RID: 34708
		private int roleId_;

		// Token: 0x04008795 RID: 34709
		public const int UnLockIdFieldNumber = 1;

		// Token: 0x04008796 RID: 34710
		private int unLockId_;
	}
}
