using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D6C RID: 3436
	[NetMessage(EMessageId.PlayerAccessRangeRequest)]
	public sealed class PlayerAccessRangeRequest : IMessage<PlayerAccessRangeRequest>, IMessage, IEquatable<PlayerAccessRangeRequest>, IDeepCloneable<PlayerAccessRangeRequest>, IBufferMessage
	{
		// Token: 0x060128BE RID: 75966 RVA: 0x002B51AF File Offset: 0x002B33AF
		[NullableContext(1)]
		public static PlayerAccessRangeRequest Create()
		{
			return new PlayerAccessRangeRequest();
		}

		// Token: 0x17003D7B RID: 15739
		// (get) Token: 0x060128BF RID: 75967 RVA: 0x002B51B6 File Offset: 0x002B33B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D7C RID: 15740
		// (get) Token: 0x060128C0 RID: 75968 RVA: 0x002B51B9 File Offset: 0x002B33B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerAccessRangeRequest.Descriptor;
			}
		}

		// Token: 0x060128C1 RID: 75969 RVA: 0x002B51C0 File Offset: 0x002B33C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAccessRangeRequest()
		{
		}

		// Token: 0x060128C2 RID: 75970 RVA: 0x002B51C8 File Offset: 0x002B33C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAccessRangeRequest(PlayerAccessRangeRequest other) : this()
		{
			this.rangeEntityId_ = other.rangeEntityId_;
			this.accessRangeType_ = other.accessRangeType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060128C3 RID: 75971 RVA: 0x002B51F9 File Offset: 0x002B33F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAccessRangeRequest Clone()
		{
			return new PlayerAccessRangeRequest(this);
		}

		// Token: 0x17003D7D RID: 15741
		// (get) Token: 0x060128C4 RID: 75972 RVA: 0x002B5201 File Offset: 0x002B3401
		// (set) Token: 0x060128C5 RID: 75973 RVA: 0x002B5209 File Offset: 0x002B3409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long RangeEntityId
		{
			get
			{
				return this.rangeEntityId_;
			}
			set
			{
				this.rangeEntityId_ = value;
			}
		}

		// Token: 0x17003D7E RID: 15742
		// (get) Token: 0x060128C6 RID: 75974 RVA: 0x002B5212 File Offset: 0x002B3412
		// (set) Token: 0x060128C7 RID: 75975 RVA: 0x002B521A File Offset: 0x002B341A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessRangeType AccessRangeType
		{
			get
			{
				return this.accessRangeType_;
			}
			set
			{
				this.accessRangeType_ = value;
			}
		}

		// Token: 0x060128C8 RID: 75976 RVA: 0x002B5223 File Offset: 0x002B3423
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerAccessRangeRequest);
		}

		// Token: 0x060128C9 RID: 75977 RVA: 0x002B5231 File Offset: 0x002B3431
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerAccessRangeRequest other)
		{
			return other != null && (other == this || (this.RangeEntityId == other.RangeEntityId && this.AccessRangeType == other.AccessRangeType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060128CA RID: 75978 RVA: 0x002B5270 File Offset: 0x002B3470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RangeEntityId != 0L)
			{
				num ^= this.RangeEntityId.GetHashCode();
			}
			if (this.AccessRangeType != AccessRangeType.RangeEnter)
			{
				num ^= this.AccessRangeType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060128CB RID: 75979 RVA: 0x002B52CE File Offset: 0x002B34CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060128CC RID: 75980 RVA: 0x002B52DB File Offset: 0x002B34DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060128CD RID: 75981 RVA: 0x002B52E4 File Offset: 0x002B34E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RangeEntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.RangeEntityId);
			}
			if (this.AccessRangeType != AccessRangeType.RangeEnter)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.AccessRangeType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060128CE RID: 75982 RVA: 0x002B5340 File Offset: 0x002B3540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RangeEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RangeEntityId);
			}
			if (this.AccessRangeType != AccessRangeType.RangeEnter)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.AccessRangeType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060128CF RID: 75983 RVA: 0x002B5398 File Offset: 0x002B3598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerAccessRangeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RangeEntityId != 0L)
			{
				this.RangeEntityId = other.RangeEntityId;
			}
			if (other.AccessRangeType != AccessRangeType.RangeEnter)
			{
				this.AccessRangeType = other.AccessRangeType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060128D0 RID: 75984 RVA: 0x002B53E8 File Offset: 0x002B35E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060128D1 RID: 75985 RVA: 0x002B53F4 File Offset: 0x002B35F4
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
				if (num != 16U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.AccessRangeType = (AccessRangeType)input.ReadEnum();
					}
				}
				else
				{
					this.RangeEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007395 RID: 29589
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007396 RID: 29590
		public const int RangeEntityIdFieldNumber = 2;

		// Token: 0x04007397 RID: 29591
		private long rangeEntityId_;

		// Token: 0x04007398 RID: 29592
		public const int AccessRangeTypeFieldNumber = 9;

		// Token: 0x04007399 RID: 29593
		private AccessRangeType accessRangeType_;
	}
}
