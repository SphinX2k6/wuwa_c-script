using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011C7 RID: 4551
	[NetMessage(EMessageId.SetAlertUiVisibleRequest)]
	public sealed class SetAlertUiVisibleRequest : IMessage<SetAlertUiVisibleRequest>, IMessage, IEquatable<SetAlertUiVisibleRequest>, IDeepCloneable<SetAlertUiVisibleRequest>, IBufferMessage
	{
		// Token: 0x06018474 RID: 99444 RVA: 0x00388954 File Offset: 0x00386B54
		[NullableContext(1)]
		public static SetAlertUiVisibleRequest Create()
		{
			return new SetAlertUiVisibleRequest();
		}

		// Token: 0x170051C7 RID: 20935
		// (get) Token: 0x06018475 RID: 99445 RVA: 0x0038895B File Offset: 0x00386B5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051C8 RID: 20936
		// (get) Token: 0x06018476 RID: 99446 RVA: 0x0038895E File Offset: 0x00386B5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetAlertUiVisibleRequest.Descriptor;
			}
		}

		// Token: 0x06018477 RID: 99447 RVA: 0x00388965 File Offset: 0x00386B65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetAlertUiVisibleRequest()
		{
		}

		// Token: 0x06018478 RID: 99448 RVA: 0x0038896D File Offset: 0x00386B6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetAlertUiVisibleRequest(SetAlertUiVisibleRequest other) : this()
		{
			this.areaId_ = other.areaId_;
			this.visible_ = other.visible_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018479 RID: 99449 RVA: 0x0038899E File Offset: 0x00386B9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetAlertUiVisibleRequest Clone()
		{
			return new SetAlertUiVisibleRequest(this);
		}

		// Token: 0x170051C9 RID: 20937
		// (get) Token: 0x0601847A RID: 99450 RVA: 0x003889A6 File Offset: 0x00386BA6
		// (set) Token: 0x0601847B RID: 99451 RVA: 0x003889AE File Offset: 0x00386BAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AreaId
		{
			get
			{
				return this.areaId_;
			}
			set
			{
				this.areaId_ = value;
			}
		}

		// Token: 0x170051CA RID: 20938
		// (get) Token: 0x0601847C RID: 99452 RVA: 0x003889B7 File Offset: 0x00386BB7
		// (set) Token: 0x0601847D RID: 99453 RVA: 0x003889BF File Offset: 0x00386BBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Visible
		{
			get
			{
				return this.visible_;
			}
			set
			{
				this.visible_ = value;
			}
		}

		// Token: 0x0601847E RID: 99454 RVA: 0x003889C8 File Offset: 0x00386BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetAlertUiVisibleRequest);
		}

		// Token: 0x0601847F RID: 99455 RVA: 0x003889D6 File Offset: 0x00386BD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetAlertUiVisibleRequest other)
		{
			return other != null && (other == this || (this.AreaId == other.AreaId && this.Visible == other.Visible && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018480 RID: 99456 RVA: 0x00388A14 File Offset: 0x00386C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AreaId != 0)
			{
				num ^= this.AreaId.GetHashCode();
			}
			if (this.Visible)
			{
				num ^= this.Visible.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018481 RID: 99457 RVA: 0x00388A6C File Offset: 0x00386C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018482 RID: 99458 RVA: 0x00388A79 File Offset: 0x00386C79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018483 RID: 99459 RVA: 0x00388A84 File Offset: 0x00386C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AreaId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.AreaId);
			}
			if (this.Visible)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.Visible);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018484 RID: 99460 RVA: 0x00388AE0 File Offset: 0x00386CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AreaId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AreaId);
			}
			if (this.Visible)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018485 RID: 99461 RVA: 0x00388B2C File Offset: 0x00386D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetAlertUiVisibleRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AreaId != 0)
			{
				this.AreaId = other.AreaId;
			}
			if (other.Visible)
			{
				this.Visible = other.Visible;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018486 RID: 99462 RVA: 0x00388B7C File Offset: 0x00386D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018487 RID: 99463 RVA: 0x00388B88 File Offset: 0x00386D88
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
				if (num != 80U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Visible = input.ReadBool();
					}
				}
				else
				{
					this.AreaId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008FDB RID: 36827
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008FDC RID: 36828
		public const int AreaIdFieldNumber = 10;

		// Token: 0x04008FDD RID: 36829
		private int areaId_;

		// Token: 0x04008FDE RID: 36830
		public const int VisibleFieldNumber = 15;

		// Token: 0x04008FDF RID: 36831
		private bool visible_;
	}
}
