using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000402 RID: 1026
	[NetMessage(EMessageId.DressPlayerTitleUpdateNotify)]
	public sealed class DressPlayerTitleUpdateNotify : IMessage<DressPlayerTitleUpdateNotify>, IMessage, IEquatable<DressPlayerTitleUpdateNotify>, IDeepCloneable<DressPlayerTitleUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600630F RID: 25359 RVA: 0x000EE65C File Offset: 0x000EC85C
		[NullableContext(1)]
		public static DressPlayerTitleUpdateNotify Create()
		{
			return new DressPlayerTitleUpdateNotify();
		}

		// Token: 0x1700127A RID: 4730
		// (get) Token: 0x06006310 RID: 25360 RVA: 0x000EE663 File Offset: 0x000EC863
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700127B RID: 4731
		// (get) Token: 0x06006311 RID: 25361 RVA: 0x000EE666 File Offset: 0x000EC866
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DressPlayerTitleUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06006312 RID: 25362 RVA: 0x000EE66D File Offset: 0x000EC86D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DressPlayerTitleUpdateNotify()
		{
		}

		// Token: 0x06006313 RID: 25363 RVA: 0x000EE675 File Offset: 0x000EC875
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DressPlayerTitleUpdateNotify(DressPlayerTitleUpdateNotify other) : this()
		{
			this.playerTitleId_ = other.playerTitleId_;
			this.playerTitleExtraParam_ = other.playerTitleExtraParam_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006314 RID: 25364 RVA: 0x000EE6A6 File Offset: 0x000EC8A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DressPlayerTitleUpdateNotify Clone()
		{
			return new DressPlayerTitleUpdateNotify(this);
		}

		// Token: 0x1700127C RID: 4732
		// (get) Token: 0x06006315 RID: 25365 RVA: 0x000EE6AE File Offset: 0x000EC8AE
		// (set) Token: 0x06006316 RID: 25366 RVA: 0x000EE6B6 File Offset: 0x000EC8B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerTitleId
		{
			get
			{
				return this.playerTitleId_;
			}
			set
			{
				this.playerTitleId_ = value;
			}
		}

		// Token: 0x1700127D RID: 4733
		// (get) Token: 0x06006317 RID: 25367 RVA: 0x000EE6BF File Offset: 0x000EC8BF
		// (set) Token: 0x06006318 RID: 25368 RVA: 0x000EE6C7 File Offset: 0x000EC8C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerTitleExtraParam
		{
			get
			{
				return this.playerTitleExtraParam_;
			}
			set
			{
				this.playerTitleExtraParam_ = value;
			}
		}

		// Token: 0x06006319 RID: 25369 RVA: 0x000EE6D0 File Offset: 0x000EC8D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DressPlayerTitleUpdateNotify);
		}

		// Token: 0x0600631A RID: 25370 RVA: 0x000EE6DE File Offset: 0x000EC8DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DressPlayerTitleUpdateNotify other)
		{
			return other != null && (other == this || (this.PlayerTitleId == other.PlayerTitleId && this.PlayerTitleExtraParam == other.PlayerTitleExtraParam && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600631B RID: 25371 RVA: 0x000EE71C File Offset: 0x000EC91C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerTitleId != 0)
			{
				num ^= this.PlayerTitleId.GetHashCode();
			}
			if (this.PlayerTitleExtraParam != 0)
			{
				num ^= this.PlayerTitleExtraParam.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600631C RID: 25372 RVA: 0x000EE774 File Offset: 0x000EC974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600631D RID: 25373 RVA: 0x000EE781 File Offset: 0x000EC981
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600631E RID: 25374 RVA: 0x000EE78C File Offset: 0x000EC98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerTitleExtraParam != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PlayerTitleExtraParam);
			}
			if (this.PlayerTitleId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.PlayerTitleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600631F RID: 25375 RVA: 0x000EE7E8 File Offset: 0x000EC9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerTitleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerTitleId);
			}
			if (this.PlayerTitleExtraParam != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerTitleExtraParam);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006320 RID: 25376 RVA: 0x000EE840 File Offset: 0x000ECA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DressPlayerTitleUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerTitleId != 0)
			{
				this.PlayerTitleId = other.PlayerTitleId;
			}
			if (other.PlayerTitleExtraParam != 0)
			{
				this.PlayerTitleExtraParam = other.PlayerTitleExtraParam;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006321 RID: 25377 RVA: 0x000EE890 File Offset: 0x000ECA90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006322 RID: 25378 RVA: 0x000EE89C File Offset: 0x000ECA9C
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
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PlayerTitleId = input.ReadInt32();
					}
				}
				else
				{
					this.PlayerTitleExtraParam = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003808 RID: 14344
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003809 RID: 14345
		public const int PlayerTitleIdFieldNumber = 6;

		// Token: 0x0400380A RID: 14346
		private int playerTitleId_;

		// Token: 0x0400380B RID: 14347
		public const int PlayerTitleExtraParamFieldNumber = 2;

		// Token: 0x0400380C RID: 14348
		private int playerTitleExtraParam_;
	}
}
