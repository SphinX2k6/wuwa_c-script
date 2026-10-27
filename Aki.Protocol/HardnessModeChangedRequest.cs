using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200073D RID: 1853
	[NetMessage(EMessageId.HardnessModeChangedRequest)]
	public sealed class HardnessModeChangedRequest : IMessage<HardnessModeChangedRequest>, IMessage, IEquatable<HardnessModeChangedRequest>, IDeepCloneable<HardnessModeChangedRequest>, IBufferMessage
	{
		// Token: 0x0600A7F5 RID: 42997 RVA: 0x001943EC File Offset: 0x001925EC
		[NullableContext(1)]
		public static HardnessModeChangedRequest Create()
		{
			return new HardnessModeChangedRequest();
		}

		// Token: 0x170021C6 RID: 8646
		// (get) Token: 0x0600A7F6 RID: 42998 RVA: 0x001943F3 File Offset: 0x001925F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021C7 RID: 8647
		// (get) Token: 0x0600A7F7 RID: 42999 RVA: 0x001943F6 File Offset: 0x001925F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HardnessModeChangedRequest.Descriptor;
			}
		}

		// Token: 0x0600A7F8 RID: 43000 RVA: 0x001943FD File Offset: 0x001925FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HardnessModeChangedRequest()
		{
		}

		// Token: 0x0600A7F9 RID: 43001 RVA: 0x00194405 File Offset: 0x00192605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HardnessModeChangedRequest(HardnessModeChangedRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.hardnessModeId_ = other.hardnessModeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A7FA RID: 43002 RVA: 0x00194436 File Offset: 0x00192636
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HardnessModeChangedRequest Clone()
		{
			return new HardnessModeChangedRequest(this);
		}

		// Token: 0x170021C8 RID: 8648
		// (get) Token: 0x0600A7FB RID: 43003 RVA: 0x0019443E File Offset: 0x0019263E
		// (set) Token: 0x0600A7FC RID: 43004 RVA: 0x00194446 File Offset: 0x00192646
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

		// Token: 0x170021C9 RID: 8649
		// (get) Token: 0x0600A7FD RID: 43005 RVA: 0x0019444F File Offset: 0x0019264F
		// (set) Token: 0x0600A7FE RID: 43006 RVA: 0x00194457 File Offset: 0x00192657
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HardnessModeId
		{
			get
			{
				return this.hardnessModeId_;
			}
			set
			{
				this.hardnessModeId_ = value;
			}
		}

		// Token: 0x0600A7FF RID: 43007 RVA: 0x00194460 File Offset: 0x00192660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HardnessModeChangedRequest);
		}

		// Token: 0x0600A800 RID: 43008 RVA: 0x0019446E File Offset: 0x0019266E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HardnessModeChangedRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.HardnessModeId == other.HardnessModeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A801 RID: 43009 RVA: 0x001944AC File Offset: 0x001926AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.HardnessModeId != 0)
			{
				num ^= this.HardnessModeId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A802 RID: 43010 RVA: 0x00194504 File Offset: 0x00192704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A803 RID: 43011 RVA: 0x00194511 File Offset: 0x00192711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A804 RID: 43012 RVA: 0x0019451C File Offset: 0x0019271C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HardnessModeId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.HardnessModeId);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A805 RID: 43013 RVA: 0x00194578 File Offset: 0x00192778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.HardnessModeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HardnessModeId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A806 RID: 43014 RVA: 0x001945D0 File Offset: 0x001927D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HardnessModeChangedRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.HardnessModeId != 0)
			{
				this.HardnessModeId = other.HardnessModeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A807 RID: 43015 RVA: 0x00194620 File Offset: 0x00192820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A808 RID: 43016 RVA: 0x0019462C File Offset: 0x0019282C
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
					if (num != 112U)
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
					this.HardnessModeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004CB5 RID: 19637
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CB6 RID: 19638
		public const int EntityIdFieldNumber = 14;

		// Token: 0x04004CB7 RID: 19639
		private long entityId_;

		// Token: 0x04004CB8 RID: 19640
		public const int HardnessModeIdFieldNumber = 12;

		// Token: 0x04004CB9 RID: 19641
		private int hardnessModeId_;
	}
}
