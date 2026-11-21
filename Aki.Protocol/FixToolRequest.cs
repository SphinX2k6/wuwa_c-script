using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200057C RID: 1404
	[NetMessage(EMessageId.FixToolRequest)]
	public sealed class FixToolRequest : IMessage<FixToolRequest>, IMessage, IEquatable<FixToolRequest>, IDeepCloneable<FixToolRequest>, IBufferMessage
	{
		// Token: 0x060082A2 RID: 33442 RVA: 0x0013AFB5 File Offset: 0x001391B5
		[NullableContext(1)]
		public static FixToolRequest Create()
		{
			return new FixToolRequest();
		}

		// Token: 0x1700196B RID: 6507
		// (get) Token: 0x060082A3 RID: 33443 RVA: 0x0013AFBC File Offset: 0x001391BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700196C RID: 6508
		// (get) Token: 0x060082A4 RID: 33444 RVA: 0x0013AFBF File Offset: 0x001391BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FixToolRequest.Descriptor;
			}
		}

		// Token: 0x060082A5 RID: 33445 RVA: 0x0013AFC6 File Offset: 0x001391C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FixToolRequest()
		{
		}

		// Token: 0x060082A6 RID: 33446 RVA: 0x0013AFCE File Offset: 0x001391CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FixToolRequest(FixToolRequest other) : this()
		{
			this.fixTool_ = other.fixTool_;
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060082A7 RID: 33447 RVA: 0x0013AFFF File Offset: 0x001391FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FixToolRequest Clone()
		{
			return new FixToolRequest(this);
		}

		// Token: 0x1700196D RID: 6509
		// (get) Token: 0x060082A8 RID: 33448 RVA: 0x0013B007 File Offset: 0x00139207
		// (set) Token: 0x060082A9 RID: 33449 RVA: 0x0013B00F File Offset: 0x0013920F
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

		// Token: 0x1700196E RID: 6510
		// (get) Token: 0x060082AA RID: 33450 RVA: 0x0013B018 File Offset: 0x00139218
		// (set) Token: 0x060082AB RID: 33451 RVA: 0x0013B020 File Offset: 0x00139220
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

		// Token: 0x060082AC RID: 33452 RVA: 0x0013B029 File Offset: 0x00139229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FixToolRequest);
		}

		// Token: 0x060082AD RID: 33453 RVA: 0x0013B037 File Offset: 0x00139237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FixToolRequest other)
		{
			return other != null && (other == this || (this.FixTool == other.FixTool && this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060082AE RID: 33454 RVA: 0x0013B078 File Offset: 0x00139278
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

		// Token: 0x060082AF RID: 33455 RVA: 0x0013B0D0 File Offset: 0x001392D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060082B0 RID: 33456 RVA: 0x0013B0DD File Offset: 0x001392DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060082B1 RID: 33457 RVA: 0x0013B0E8 File Offset: 0x001392E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.EntityId);
			}
			if (this.FixTool != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.FixTool);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060082B2 RID: 33458 RVA: 0x0013B144 File Offset: 0x00139344
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

		// Token: 0x060082B3 RID: 33459 RVA: 0x0013B19C File Offset: 0x0013939C
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

		// Token: 0x060082B4 RID: 33460 RVA: 0x0013B1EC File Offset: 0x001393EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060082B5 RID: 33461 RVA: 0x0013B1F8 File Offset: 0x001393F8
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
						this.FixTool = input.ReadInt32();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400418D RID: 16781
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400418E RID: 16782
		public const int FixToolFieldNumber = 12;

		// Token: 0x0400418F RID: 16783
		private int fixTool_;

		// Token: 0x04004190 RID: 16784
		public const int EntityIdFieldNumber = 8;

		// Token: 0x04004191 RID: 16785
		private long entityId_;
	}
}
