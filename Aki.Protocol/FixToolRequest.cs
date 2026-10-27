using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000591 RID: 1425
	[NetMessage(EMessageId.FixToolRequest)]
	public sealed class FixToolRequest : IMessage<FixToolRequest>, IMessage, IEquatable<FixToolRequest>, IDeepCloneable<FixToolRequest>, IBufferMessage
	{
		// Token: 0x0600840A RID: 33802 RVA: 0x0013DBC1 File Offset: 0x0013BDC1
		[NullableContext(1)]
		public static FixToolRequest Create()
		{
			return new FixToolRequest();
		}

		// Token: 0x170019B8 RID: 6584
		// (get) Token: 0x0600840B RID: 33803 RVA: 0x0013DBC8 File Offset: 0x0013BDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019B9 RID: 6585
		// (get) Token: 0x0600840C RID: 33804 RVA: 0x0013DBCB File Offset: 0x0013BDCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FixToolRequest.Descriptor;
			}
		}

		// Token: 0x0600840D RID: 33805 RVA: 0x0013DBD2 File Offset: 0x0013BDD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FixToolRequest()
		{
		}

		// Token: 0x0600840E RID: 33806 RVA: 0x0013DBDA File Offset: 0x0013BDDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FixToolRequest(FixToolRequest other) : this()
		{
			this.fixTool_ = other.fixTool_;
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600840F RID: 33807 RVA: 0x0013DC0B File Offset: 0x0013BE0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FixToolRequest Clone()
		{
			return new FixToolRequest(this);
		}

		// Token: 0x170019BA RID: 6586
		// (get) Token: 0x06008410 RID: 33808 RVA: 0x0013DC13 File Offset: 0x0013BE13
		// (set) Token: 0x06008411 RID: 33809 RVA: 0x0013DC1B File Offset: 0x0013BE1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FixTool
		{
			get
			{
				return this.fixTool_;
			}
			set
			{
				this.fixTool_ = value;
			}
		}

		// Token: 0x170019BB RID: 6587
		// (get) Token: 0x06008412 RID: 33810 RVA: 0x0013DC24 File Offset: 0x0013BE24
		// (set) Token: 0x06008413 RID: 33811 RVA: 0x0013DC2C File Offset: 0x0013BE2C
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

		// Token: 0x06008414 RID: 33812 RVA: 0x0013DC35 File Offset: 0x0013BE35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FixToolRequest);
		}

		// Token: 0x06008415 RID: 33813 RVA: 0x0013DC43 File Offset: 0x0013BE43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FixToolRequest other)
		{
			return other != null && (other == this || (this.FixTool == other.FixTool && this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008416 RID: 33814 RVA: 0x0013DC84 File Offset: 0x0013BE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FixTool != 0)
			{
				num ^= this.FixTool.GetHashCode();
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008417 RID: 33815 RVA: 0x0013DCDC File Offset: 0x0013BEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008418 RID: 33816 RVA: 0x0013DCE9 File Offset: 0x0013BEE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008419 RID: 33817 RVA: 0x0013DCF4 File Offset: 0x0013BEF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FixTool != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.FixTool);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600841A RID: 33818 RVA: 0x0013DD50 File Offset: 0x0013BF50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FixTool != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FixTool);
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600841B RID: 33819 RVA: 0x0013DDA8 File Offset: 0x0013BFA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FixToolRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FixTool != 0)
			{
				this.FixTool = other.FixTool;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600841C RID: 33820 RVA: 0x0013DDF8 File Offset: 0x0013BFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600841D RID: 33821 RVA: 0x0013DE04 File Offset: 0x0013C004
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
				if (num != 48U)
				{
					if (num != 64U)
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
					this.FixTool = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004197 RID: 16791
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004198 RID: 16792
		public const int FixToolFieldNumber = 6;

		// Token: 0x04004199 RID: 16793
		private int fixTool_;

		// Token: 0x0400419A RID: 16794
		public const int EntityIdFieldNumber = 8;

		// Token: 0x0400419B RID: 16795
		private long entityId_;
	}
}
