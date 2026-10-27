using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001177 RID: 4471
	[NetMessage(EMessageId.SceneItemStateRequest)]
	public sealed class SceneItemStateRequest : IMessage<SceneItemStateRequest>, IMessage, IEquatable<SceneItemStateRequest>, IDeepCloneable<SceneItemStateRequest>, IBufferMessage
	{
		// Token: 0x06017D57 RID: 97623 RVA: 0x003763F4 File Offset: 0x003745F4
		[NullableContext(1)]
		public static SceneItemStateRequest Create()
		{
			return new SceneItemStateRequest();
		}

		// Token: 0x17005010 RID: 20496
		// (get) Token: 0x06017D58 RID: 97624 RVA: 0x003763FB File Offset: 0x003745FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005011 RID: 20497
		// (get) Token: 0x06017D59 RID: 97625 RVA: 0x003763FE File Offset: 0x003745FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemStateRequest.Descriptor;
			}
		}

		// Token: 0x06017D5A RID: 97626 RVA: 0x00376405 File Offset: 0x00374605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemStateRequest()
		{
		}

		// Token: 0x06017D5B RID: 97627 RVA: 0x0037640D File Offset: 0x0037460D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemStateRequest(SceneItemStateRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.operateType_ = other.operateType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017D5C RID: 97628 RVA: 0x0037643E File Offset: 0x0037463E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemStateRequest Clone()
		{
			return new SceneItemStateRequest(this);
		}

		// Token: 0x17005012 RID: 20498
		// (get) Token: 0x06017D5D RID: 97629 RVA: 0x00376446 File Offset: 0x00374646
		// (set) Token: 0x06017D5E RID: 97630 RVA: 0x0037644E File Offset: 0x0037464E
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

		// Token: 0x17005013 RID: 20499
		// (get) Token: 0x06017D5F RID: 97631 RVA: 0x00376457 File Offset: 0x00374657
		// (set) Token: 0x06017D60 RID: 97632 RVA: 0x0037645F File Offset: 0x0037465F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OperateType
		{
			get
			{
				return this.operateType_;
			}
			set
			{
				this.operateType_ = value;
			}
		}

		// Token: 0x06017D61 RID: 97633 RVA: 0x00376468 File Offset: 0x00374668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemStateRequest);
		}

		// Token: 0x06017D62 RID: 97634 RVA: 0x00376476 File Offset: 0x00374676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemStateRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.OperateType == other.OperateType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017D63 RID: 97635 RVA: 0x003764B4 File Offset: 0x003746B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.OperateType != 0)
			{
				num ^= this.OperateType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017D64 RID: 97636 RVA: 0x0037650C File Offset: 0x0037470C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017D65 RID: 97637 RVA: 0x00376519 File Offset: 0x00374719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017D66 RID: 97638 RVA: 0x00376524 File Offset: 0x00374724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.EntityId);
			}
			if (this.OperateType != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.OperateType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017D67 RID: 97639 RVA: 0x00376580 File Offset: 0x00374780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.OperateType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OperateType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017D68 RID: 97640 RVA: 0x003765D8 File Offset: 0x003747D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemStateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.OperateType != 0)
			{
				this.OperateType = other.OperateType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017D69 RID: 97641 RVA: 0x00376628 File Offset: 0x00374828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017D6A RID: 97642 RVA: 0x00376634 File Offset: 0x00374834
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
				if (num != 112U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.OperateType = input.ReadInt32();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04008D50 RID: 36176
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D51 RID: 36177
		public const int EntityIdFieldNumber = 14;

		// Token: 0x04008D52 RID: 36178
		private long entityId_;

		// Token: 0x04008D53 RID: 36179
		public const int OperateTypeFieldNumber = 15;

		// Token: 0x04008D54 RID: 36180
		private int operateType_;
	}
}
