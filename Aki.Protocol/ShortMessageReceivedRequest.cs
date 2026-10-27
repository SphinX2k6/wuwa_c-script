using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001207 RID: 4615
	[NetMessage(EMessageId.ShortMessageReceivedRequest)]
	public sealed class ShortMessageReceivedRequest : IMessage<ShortMessageReceivedRequest>, IMessage, IEquatable<ShortMessageReceivedRequest>, IDeepCloneable<ShortMessageReceivedRequest>, IBufferMessage
	{
		// Token: 0x0601899E RID: 100766 RVA: 0x00393FE8 File Offset: 0x003921E8
		[NullableContext(1)]
		public static ShortMessageReceivedRequest Create()
		{
			return new ShortMessageReceivedRequest();
		}

		// Token: 0x170052E4 RID: 21220
		// (get) Token: 0x0601899F RID: 100767 RVA: 0x00393FEF File Offset: 0x003921EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170052E5 RID: 21221
		// (get) Token: 0x060189A0 RID: 100768 RVA: 0x00393FF2 File Offset: 0x003921F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShortMessageReceivedRequest.Descriptor;
			}
		}

		// Token: 0x060189A1 RID: 100769 RVA: 0x00393FF9 File Offset: 0x003921F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageReceivedRequest()
		{
		}

		// Token: 0x060189A2 RID: 100770 RVA: 0x00394001 File Offset: 0x00392201
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageReceivedRequest(ShortMessageReceivedRequest other) : this()
		{
			this.configId_ = other.configId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060189A3 RID: 100771 RVA: 0x00394026 File Offset: 0x00392226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageReceivedRequest Clone()
		{
			return new ShortMessageReceivedRequest(this);
		}

		// Token: 0x170052E6 RID: 21222
		// (get) Token: 0x060189A4 RID: 100772 RVA: 0x0039402E File Offset: 0x0039222E
		// (set) Token: 0x060189A5 RID: 100773 RVA: 0x00394036 File Offset: 0x00392236
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

		// Token: 0x060189A6 RID: 100774 RVA: 0x0039403F File Offset: 0x0039223F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShortMessageReceivedRequest);
		}

		// Token: 0x060189A7 RID: 100775 RVA: 0x0039404D File Offset: 0x0039224D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShortMessageReceivedRequest other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060189A8 RID: 100776 RVA: 0x0039407C File Offset: 0x0039227C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060189A9 RID: 100777 RVA: 0x003940BB File Offset: 0x003922BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060189AA RID: 100778 RVA: 0x003940C8 File Offset: 0x003922C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060189AB RID: 100779 RVA: 0x003940D1 File Offset: 0x003922D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060189AC RID: 100780 RVA: 0x00394104 File Offset: 0x00392304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060189AD RID: 100781 RVA: 0x00394142 File Offset: 0x00392342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShortMessageReceivedRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060189AE RID: 100782 RVA: 0x00394173 File Offset: 0x00392373
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060189AF RID: 100783 RVA: 0x0039417C File Offset: 0x0039237C
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009168 RID: 37224
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009169 RID: 37225
		public const int ConfigIdFieldNumber = 3;

		// Token: 0x0400916A RID: 37226
		private int configId_;
	}
}
