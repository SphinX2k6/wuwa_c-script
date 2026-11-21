using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000435 RID: 1077
	[NetMessage(EMessageId.EnterAreaNotify)]
	public sealed class EnterAreaNotify : IMessage<EnterAreaNotify>, IMessage, IEquatable<EnterAreaNotify>, IDeepCloneable<EnterAreaNotify>, IBufferMessage
	{
		// Token: 0x0600678B RID: 26507 RVA: 0x000F91B9 File Offset: 0x000F73B9
		[NullableContext(1)]
		public static EnterAreaNotify Create()
		{
			return new EnterAreaNotify();
		}

		// Token: 0x17001377 RID: 4983
		// (get) Token: 0x0600678C RID: 26508 RVA: 0x000F91C0 File Offset: 0x000F73C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001378 RID: 4984
		// (get) Token: 0x0600678D RID: 26509 RVA: 0x000F91C3 File Offset: 0x000F73C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterAreaNotify.Descriptor;
			}
		}

		// Token: 0x0600678E RID: 26510 RVA: 0x000F91CA File Offset: 0x000F73CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterAreaNotify()
		{
		}

		// Token: 0x0600678F RID: 26511 RVA: 0x000F91D2 File Offset: 0x000F73D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterAreaNotify(EnterAreaNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.areaId_ = other.areaId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006790 RID: 26512 RVA: 0x000F9203 File Offset: 0x000F7403
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterAreaNotify Clone()
		{
			return new EnterAreaNotify(this);
		}

		// Token: 0x17001379 RID: 4985
		// (get) Token: 0x06006791 RID: 26513 RVA: 0x000F920B File Offset: 0x000F740B
		// (set) Token: 0x06006792 RID: 26514 RVA: 0x000F9213 File Offset: 0x000F7413
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x1700137A RID: 4986
		// (get) Token: 0x06006793 RID: 26515 RVA: 0x000F921C File Offset: 0x000F741C
		// (set) Token: 0x06006794 RID: 26516 RVA: 0x000F9224 File Offset: 0x000F7424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AreaId
		{
			get
			{
				return this.areaId_;
			}
			set
			{
				this.areaId_ = value;
			}
		}

		// Token: 0x06006795 RID: 26517 RVA: 0x000F922D File Offset: 0x000F742D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterAreaNotify);
		}

		// Token: 0x06006796 RID: 26518 RVA: 0x000F923B File Offset: 0x000F743B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterAreaNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.AreaId == other.AreaId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006797 RID: 26519 RVA: 0x000F927C File Offset: 0x000F747C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.AreaId != 0)
			{
				num ^= this.AreaId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006798 RID: 26520 RVA: 0x000F92D4 File Offset: 0x000F74D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006799 RID: 26521 RVA: 0x000F92E1 File Offset: 0x000F74E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600679A RID: 26522 RVA: 0x000F92EC File Offset: 0x000F74EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.PlayerId);
			}
			if (this.AreaId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.AreaId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600679B RID: 26523 RVA: 0x000F9348 File Offset: 0x000F7548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.AreaId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AreaId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600679C RID: 26524 RVA: 0x000F93A0 File Offset: 0x000F75A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterAreaNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.AreaId != 0)
			{
				this.AreaId = other.AreaId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600679D RID: 26525 RVA: 0x000F93F0 File Offset: 0x000F75F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600679E RID: 26526 RVA: 0x000F93FC File Offset: 0x000F75FC
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
				if (num != 64U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.AreaId = input.ReadInt32();
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040039CD RID: 14797
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039CE RID: 14798
		public const int PlayerIdFieldNumber = 8;

		// Token: 0x040039CF RID: 14799
		private int playerId_;

		// Token: 0x040039D0 RID: 14800
		public const int AreaIdFieldNumber = 12;

		// Token: 0x040039D1 RID: 14801
		private int areaId_;
	}
}
