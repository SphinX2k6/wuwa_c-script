using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000611 RID: 1553
	[NetMessage(EMessageId.FlySkinWearAllRoleRequest)]
	public sealed class FlySkinWearAllRoleRequest : IMessage<FlySkinWearAllRoleRequest>, IMessage, IEquatable<FlySkinWearAllRoleRequest>, IDeepCloneable<FlySkinWearAllRoleRequest>, IBufferMessage
	{
		// Token: 0x06008F7C RID: 36732 RVA: 0x0015B8CD File Offset: 0x00159ACD
		[NullableContext(1)]
		public static FlySkinWearAllRoleRequest Create()
		{
			return new FlySkinWearAllRoleRequest();
		}

		// Token: 0x17001C7C RID: 7292
		// (get) Token: 0x06008F7D RID: 36733 RVA: 0x0015B8D4 File Offset: 0x00159AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C7D RID: 7293
		// (get) Token: 0x06008F7E RID: 36734 RVA: 0x0015B8D7 File Offset: 0x00159AD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlySkinWearAllRoleRequest.Descriptor;
			}
		}

		// Token: 0x06008F7F RID: 36735 RVA: 0x0015B8DE File Offset: 0x00159ADE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinWearAllRoleRequest()
		{
		}

		// Token: 0x06008F80 RID: 36736 RVA: 0x0015B8E6 File Offset: 0x00159AE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinWearAllRoleRequest(FlySkinWearAllRoleRequest other) : this()
		{
			this.skinId_ = other.skinId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008F81 RID: 36737 RVA: 0x0015B90B File Offset: 0x00159B0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinWearAllRoleRequest Clone()
		{
			return new FlySkinWearAllRoleRequest(this);
		}

		// Token: 0x17001C7E RID: 7294
		// (get) Token: 0x06008F82 RID: 36738 RVA: 0x0015B913 File Offset: 0x00159B13
		// (set) Token: 0x06008F83 RID: 36739 RVA: 0x0015B91B File Offset: 0x00159B1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkinId
		{
			get
			{
				return this.skinId_;
			}
			set
			{
				this.skinId_ = value;
			}
		}

		// Token: 0x06008F84 RID: 36740 RVA: 0x0015B924 File Offset: 0x00159B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlySkinWearAllRoleRequest);
		}

		// Token: 0x06008F85 RID: 36741 RVA: 0x0015B932 File Offset: 0x00159B32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlySkinWearAllRoleRequest other)
		{
			return other != null && (other == this || (this.SkinId == other.SkinId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008F86 RID: 36742 RVA: 0x0015B960 File Offset: 0x00159B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkinId != 0)
			{
				num ^= this.SkinId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008F87 RID: 36743 RVA: 0x0015B99F File Offset: 0x00159B9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008F88 RID: 36744 RVA: 0x0015B9AC File Offset: 0x00159BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008F89 RID: 36745 RVA: 0x0015B9B5 File Offset: 0x00159BB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkinId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.SkinId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008F8A RID: 36746 RVA: 0x0015B9E8 File Offset: 0x00159BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkinId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkinId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008F8B RID: 36747 RVA: 0x0015BA26 File Offset: 0x00159C26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlySkinWearAllRoleRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkinId != 0)
			{
				this.SkinId = other.SkinId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008F8C RID: 36748 RVA: 0x0015BA57 File Offset: 0x00159C57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008F8D RID: 36749 RVA: 0x0015BA60 File Offset: 0x00159C60
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SkinId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040045A7 RID: 17831
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045A8 RID: 17832
		public const int SkinIdFieldNumber = 5;

		// Token: 0x040045A9 RID: 17833
		private int skinId_;
	}
}
