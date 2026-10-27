using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001174 RID: 4468
	[NetMessage(EMessageId.SceneItemSetPosSenderRequest)]
	public sealed class SceneItemSetPosSenderRequest : IMessage<SceneItemSetPosSenderRequest>, IMessage, IEquatable<SceneItemSetPosSenderRequest>, IDeepCloneable<SceneItemSetPosSenderRequest>, IBufferMessage
	{
		// Token: 0x06017D19 RID: 97561 RVA: 0x00375B6C File Offset: 0x00373D6C
		[NullableContext(1)]
		public static SceneItemSetPosSenderRequest Create()
		{
			return new SceneItemSetPosSenderRequest();
		}

		// Token: 0x17005003 RID: 20483
		// (get) Token: 0x06017D1A RID: 97562 RVA: 0x00375B73 File Offset: 0x00373D73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005004 RID: 20484
		// (get) Token: 0x06017D1B RID: 97563 RVA: 0x00375B76 File Offset: 0x00373D76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemSetPosSenderRequest.Descriptor;
			}
		}

		// Token: 0x06017D1C RID: 97564 RVA: 0x00375B7D File Offset: 0x00373D7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSetPosSenderRequest()
		{
		}

		// Token: 0x06017D1D RID: 97565 RVA: 0x00375B85 File Offset: 0x00373D85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSetPosSenderRequest(SceneItemSetPosSenderRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.isControl_ = other.isControl_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017D1E RID: 97566 RVA: 0x00375BB6 File Offset: 0x00373DB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSetPosSenderRequest Clone()
		{
			return new SceneItemSetPosSenderRequest(this);
		}

		// Token: 0x17005005 RID: 20485
		// (get) Token: 0x06017D1F RID: 97567 RVA: 0x00375BBE File Offset: 0x00373DBE
		// (set) Token: 0x06017D20 RID: 97568 RVA: 0x00375BC6 File Offset: 0x00373DC6
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

		// Token: 0x17005006 RID: 20486
		// (get) Token: 0x06017D21 RID: 97569 RVA: 0x00375BCF File Offset: 0x00373DCF
		// (set) Token: 0x06017D22 RID: 97570 RVA: 0x00375BD7 File Offset: 0x00373DD7
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

		// Token: 0x06017D23 RID: 97571 RVA: 0x00375BE0 File Offset: 0x00373DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemSetPosSenderRequest);
		}

		// Token: 0x06017D24 RID: 97572 RVA: 0x00375BEE File Offset: 0x00373DEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemSetPosSenderRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.IsControl == other.IsControl && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017D25 RID: 97573 RVA: 0x00375C2C File Offset: 0x00373E2C
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

		// Token: 0x06017D26 RID: 97574 RVA: 0x00375C84 File Offset: 0x00373E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017D27 RID: 97575 RVA: 0x00375C91 File Offset: 0x00373E91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017D28 RID: 97576 RVA: 0x00375C9C File Offset: 0x00373E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsControl)
			{
				output.WriteRawTag(104);
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

		// Token: 0x06017D29 RID: 97577 RVA: 0x00375CF8 File Offset: 0x00373EF8
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

		// Token: 0x06017D2A RID: 97578 RVA: 0x00375D44 File Offset: 0x00373F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemSetPosSenderRequest other)
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

		// Token: 0x06017D2B RID: 97579 RVA: 0x00375D94 File Offset: 0x00373F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017D2C RID: 97580 RVA: 0x00375DA0 File Offset: 0x00373FA0
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
				if (num != 104U)
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

		// Token: 0x04008D3F RID: 36159
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D40 RID: 36160
		public const int EntityIdFieldNumber = 15;

		// Token: 0x04008D41 RID: 36161
		private long entityId_;

		// Token: 0x04008D42 RID: 36162
		public const int IsControlFieldNumber = 13;

		// Token: 0x04008D43 RID: 36163
		private bool isControl_;
	}
}
