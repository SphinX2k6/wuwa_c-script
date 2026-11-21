using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014D0 RID: 5328
	[NetMessage(EMessageId.TrapDefenseUseItemRequest)]
	public sealed class TrapDefenseUseItemRequest : IMessage<TrapDefenseUseItemRequest>, IMessage, IEquatable<TrapDefenseUseItemRequest>, IDeepCloneable<TrapDefenseUseItemRequest>, IBufferMessage
	{
		// Token: 0x0601C42B RID: 115755 RVA: 0x00419E90 File Offset: 0x00418090
		[NullableContext(1)]
		public static TrapDefenseUseItemRequest Create()
		{
			return new TrapDefenseUseItemRequest();
		}

		// Token: 0x17005FA5 RID: 24485
		// (get) Token: 0x0601C42C RID: 115756 RVA: 0x00419E97 File Offset: 0x00418097
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FA6 RID: 24486
		// (get) Token: 0x0601C42D RID: 115757 RVA: 0x00419E9A File Offset: 0x0041809A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseUseItemRequest.Descriptor;
			}
		}

		// Token: 0x0601C42E RID: 115758 RVA: 0x00419EA1 File Offset: 0x004180A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseUseItemRequest()
		{
		}

		// Token: 0x0601C42F RID: 115759 RVA: 0x00419EA9 File Offset: 0x004180A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseUseItemRequest(TrapDefenseUseItemRequest other) : this()
		{
			this.itemConfigId_ = other.itemConfigId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C430 RID: 115760 RVA: 0x00419ECE File Offset: 0x004180CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseUseItemRequest Clone()
		{
			return new TrapDefenseUseItemRequest(this);
		}

		// Token: 0x17005FA7 RID: 24487
		// (get) Token: 0x0601C431 RID: 115761 RVA: 0x00419ED6 File Offset: 0x004180D6
		// (set) Token: 0x0601C432 RID: 115762 RVA: 0x00419EDE File Offset: 0x004180DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemConfigId
		{
			get
			{
				return this.itemConfigId_;
			}
			set
			{
				this.itemConfigId_ = value;
			}
		}

		// Token: 0x0601C433 RID: 115763 RVA: 0x00419EE7 File Offset: 0x004180E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseUseItemRequest);
		}

		// Token: 0x0601C434 RID: 115764 RVA: 0x00419EF5 File Offset: 0x004180F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseUseItemRequest other)
		{
			return other != null && (other == this || (this.ItemConfigId == other.ItemConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C435 RID: 115765 RVA: 0x00419F24 File Offset: 0x00418124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemConfigId != 0)
			{
				num ^= this.ItemConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C436 RID: 115766 RVA: 0x00419F63 File Offset: 0x00418163
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C437 RID: 115767 RVA: 0x00419F70 File Offset: 0x00418170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C438 RID: 115768 RVA: 0x00419F79 File Offset: 0x00418179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemConfigId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ItemConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C439 RID: 115769 RVA: 0x00419FAC File Offset: 0x004181AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C43A RID: 115770 RVA: 0x00419FEA File Offset: 0x004181EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseUseItemRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemConfigId != 0)
			{
				this.ItemConfigId = other.ItemConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C43B RID: 115771 RVA: 0x0041A01B File Offset: 0x0041821B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C43C RID: 115772 RVA: 0x0041A024 File Offset: 0x00418224
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ItemConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A359 RID: 41817
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A35A RID: 41818
		public const int ItemConfigIdFieldNumber = 12;

		// Token: 0x0400A35B RID: 41819
		private int itemConfigId_;
	}
}
