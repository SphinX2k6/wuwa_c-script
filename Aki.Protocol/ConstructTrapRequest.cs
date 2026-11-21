using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002E5 RID: 741
	[NetMessage(EMessageId.ConstructTrapRequest)]
	public sealed class ConstructTrapRequest : IMessage<ConstructTrapRequest>, IMessage, IEquatable<ConstructTrapRequest>, IDeepCloneable<ConstructTrapRequest>, IBufferMessage
	{
		// Token: 0x06004BB8 RID: 19384 RVA: 0x000B8E1C File Offset: 0x000B701C
		[NullableContext(1)]
		public static ConstructTrapRequest Create()
		{
			return new ConstructTrapRequest();
		}

		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x06004BB9 RID: 19385 RVA: 0x000B8E23 File Offset: 0x000B7023
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x06004BBA RID: 19386 RVA: 0x000B8E26 File Offset: 0x000B7026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConstructTrapRequest.Descriptor;
			}
		}

		// Token: 0x06004BBB RID: 19387 RVA: 0x000B8E2D File Offset: 0x000B702D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConstructTrapRequest()
		{
		}

		// Token: 0x06004BBC RID: 19388 RVA: 0x000B8E38 File Offset: 0x000B7038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConstructTrapRequest(ConstructTrapRequest other) : this()
		{
			this.configId_ = other.configId_;
			this.trapGridPlacementPbInfo_ = ((other.trapGridPlacementPbInfo_ != null) ? other.trapGridPlacementPbInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004BBD RID: 19389 RVA: 0x000B8E84 File Offset: 0x000B7084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConstructTrapRequest Clone()
		{
			return new ConstructTrapRequest(this);
		}

		// Token: 0x17000D55 RID: 3413
		// (get) Token: 0x06004BBE RID: 19390 RVA: 0x000B8E8C File Offset: 0x000B708C
		// (set) Token: 0x06004BBF RID: 19391 RVA: 0x000B8E94 File Offset: 0x000B7094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x17000D56 RID: 3414
		// (get) Token: 0x06004BC0 RID: 19392 RVA: 0x000B8E9D File Offset: 0x000B709D
		// (set) Token: 0x06004BC1 RID: 19393 RVA: 0x000B8EA5 File Offset: 0x000B70A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridPlacementPbInfo TrapGridPlacementPbInfo
		{
			get
			{
				return this.trapGridPlacementPbInfo_;
			}
			set
			{
				this.trapGridPlacementPbInfo_ = value;
			}
		}

		// Token: 0x06004BC2 RID: 19394 RVA: 0x000B8EAE File Offset: 0x000B70AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConstructTrapRequest);
		}

		// Token: 0x06004BC3 RID: 19395 RVA: 0x000B8EBC File Offset: 0x000B70BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConstructTrapRequest other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && object.Equals(this.TrapGridPlacementPbInfo, other.TrapGridPlacementPbInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004BC4 RID: 19396 RVA: 0x000B8F0C File Offset: 0x000B710C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.trapGridPlacementPbInfo_ != null)
			{
				num ^= this.TrapGridPlacementPbInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004BC5 RID: 19397 RVA: 0x000B8F61 File Offset: 0x000B7161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004BC6 RID: 19398 RVA: 0x000B8F6E File Offset: 0x000B716E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004BC7 RID: 19399 RVA: 0x000B8F78 File Offset: 0x000B7178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.trapGridPlacementPbInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.TrapGridPlacementPbInfo);
			}
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004BC8 RID: 19400 RVA: 0x000B8FD4 File Offset: 0x000B71D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.trapGridPlacementPbInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TrapGridPlacementPbInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004BC9 RID: 19401 RVA: 0x000B902C File Offset: 0x000B722C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConstructTrapRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.trapGridPlacementPbInfo_ != null)
			{
				if (this.trapGridPlacementPbInfo_ == null)
				{
					this.TrapGridPlacementPbInfo = new GridPlacementPbInfo();
				}
				this.TrapGridPlacementPbInfo.MergeFrom(other.TrapGridPlacementPbInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004BCA RID: 19402 RVA: 0x000B9094 File Offset: 0x000B7294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004BCB RID: 19403 RVA: 0x000B90A0 File Offset: 0x000B72A0
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
				if (num != 50U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ConfigId = input.ReadInt32();
					}
				}
				else
				{
					if (this.trapGridPlacementPbInfo_ == null)
					{
						this.TrapGridPlacementPbInfo = new GridPlacementPbInfo();
					}
					input.ReadMessage(this.TrapGridPlacementPbInfo);
				}
			}
		}

		// Token: 0x04003129 RID: 12585
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400312A RID: 12586
		public const int ConfigIdFieldNumber = 9;

		// Token: 0x0400312B RID: 12587
		private int configId_;

		// Token: 0x0400312C RID: 12588
		public const int TrapGridPlacementPbInfoFieldNumber = 6;

		// Token: 0x0400312D RID: 12589
		private GridPlacementPbInfo trapGridPlacementPbInfo_;
	}
}
