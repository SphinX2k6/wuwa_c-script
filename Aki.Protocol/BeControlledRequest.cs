using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200018C RID: 396
	[NetMessage(EMessageId.BeControlledRequest)]
	public sealed class BeControlledRequest : IMessage<BeControlledRequest>, IMessage, IEquatable<BeControlledRequest>, IDeepCloneable<BeControlledRequest>, IBufferMessage
	{
		// Token: 0x06002F71 RID: 12145 RVA: 0x00079931 File Offset: 0x00077B31
		[NullableContext(1)]
		public static BeControlledRequest Create()
		{
			return new BeControlledRequest();
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x06002F72 RID: 12146 RVA: 0x00079938 File Offset: 0x00077B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x06002F73 RID: 12147 RVA: 0x0007993B File Offset: 0x00077B3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BeControlledRequest.Descriptor;
			}
		}

		// Token: 0x06002F74 RID: 12148 RVA: 0x00079942 File Offset: 0x00077B42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledRequest()
		{
		}

		// Token: 0x06002F75 RID: 12149 RVA: 0x0007994A File Offset: 0x00077B4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledRequest(BeControlledRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.isControl_ = other.isControl_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002F76 RID: 12150 RVA: 0x0007997B File Offset: 0x00077B7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledRequest Clone()
		{
			return new BeControlledRequest(this);
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06002F77 RID: 12151 RVA: 0x00079983 File Offset: 0x00077B83
		// (set) Token: 0x06002F78 RID: 12152 RVA: 0x0007998B File Offset: 0x00077B8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06002F79 RID: 12153 RVA: 0x00079994 File Offset: 0x00077B94
		// (set) Token: 0x06002F7A RID: 12154 RVA: 0x0007999C File Offset: 0x00077B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsControl
		{
			get
			{
				return this.isControl_;
			}
			set
			{
				this.isControl_ = value;
			}
		}

		// Token: 0x06002F7B RID: 12155 RVA: 0x000799A5 File Offset: 0x00077BA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BeControlledRequest);
		}

		// Token: 0x06002F7C RID: 12156 RVA: 0x000799B3 File Offset: 0x00077BB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BeControlledRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.IsControl == other.IsControl && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002F7D RID: 12157 RVA: 0x000799F4 File Offset: 0x00077BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.IsControl)
			{
				num ^= this.IsControl.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002F7E RID: 12158 RVA: 0x00079A4C File Offset: 0x00077C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002F7F RID: 12159 RVA: 0x00079A59 File Offset: 0x00077C59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002F80 RID: 12160 RVA: 0x00079A64 File Offset: 0x00077C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsControl)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsControl);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002F81 RID: 12161 RVA: 0x00079AC0 File Offset: 0x00077CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.IsControl)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002F82 RID: 12162 RVA: 0x00079B0C File Offset: 0x00077D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BeControlledRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.IsControl)
			{
				this.IsControl = other.IsControl;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002F83 RID: 12163 RVA: 0x00079B5C File Offset: 0x00077D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002F84 RID: 12164 RVA: 0x00079B68 File Offset: 0x00077D68
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
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.IsControl = input.ReadBool();
				}
			}
		}

		// Token: 0x040028B2 RID: 10418
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028B3 RID: 10419
		public const int EntityIdFieldNumber = 15;

		// Token: 0x040028B4 RID: 10420
		private long entityId_;

		// Token: 0x040028B5 RID: 10421
		public const int IsControlFieldNumber = 8;

		// Token: 0x040028B6 RID: 10422
		private bool isControl_;
	}
}
