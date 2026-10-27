using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x020016AC RID: 5804
	[NetMessage(EMessageId.AiControlSwitchRequest)]
	public sealed class AiControlSwitchRequest : IMessage<AiControlSwitchRequest>, IMessage, IEquatable<AiControlSwitchRequest>, IDeepCloneable<AiControlSwitchRequest>, IBufferMessage
	{
		// Token: 0x0601D14F RID: 119119 RVA: 0x00441809 File Offset: 0x0043FA09
		[NullableContext(1)]
		public static AiControlSwitchRequest Create()
		{
			return new AiControlSwitchRequest();
		}

		// Token: 0x170062AC RID: 25260
		// (get) Token: 0x0601D150 RID: 119120 RVA: 0x00441810 File Offset: 0x0043FA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170062AD RID: 25261
		// (get) Token: 0x0601D151 RID: 119121 RVA: 0x00441813 File Offset: 0x0043FA13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiControlSwitchRequest.Descriptor;
			}
		}

		// Token: 0x0601D152 RID: 119122 RVA: 0x0044181A File Offset: 0x0043FA1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiControlSwitchRequest()
		{
		}

		// Token: 0x0601D153 RID: 119123 RVA: 0x00441822 File Offset: 0x0043FA22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiControlSwitchRequest(AiControlSwitchRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D154 RID: 119124 RVA: 0x00441847 File Offset: 0x0043FA47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiControlSwitchRequest Clone()
		{
			return new AiControlSwitchRequest(this);
		}

		// Token: 0x170062AE RID: 25262
		// (get) Token: 0x0601D155 RID: 119125 RVA: 0x0044184F File Offset: 0x0043FA4F
		// (set) Token: 0x0601D156 RID: 119126 RVA: 0x00441857 File Offset: 0x0043FA57
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

		// Token: 0x0601D157 RID: 119127 RVA: 0x00441860 File Offset: 0x0043FA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiControlSwitchRequest);
		}

		// Token: 0x0601D158 RID: 119128 RVA: 0x0044186E File Offset: 0x0043FA6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiControlSwitchRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D159 RID: 119129 RVA: 0x0044189C File Offset: 0x0043FA9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0601D15A RID: 119130 RVA: 0x004418DB File Offset: 0x0043FADB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D15B RID: 119131 RVA: 0x004418E8 File Offset: 0x0043FAE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D15C RID: 119132 RVA: 0x004418F1 File Offset: 0x0043FAF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D15D RID: 119133 RVA: 0x00441924 File Offset: 0x0043FB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0601D15E RID: 119134 RVA: 0x00441962 File Offset: 0x0043FB62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AiControlSwitchRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D15F RID: 119135 RVA: 0x00441993 File Offset: 0x0043FB93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D160 RID: 119136 RVA: 0x0044199C File Offset: 0x0043FB9C
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
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400C434 RID: 50228
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C435 RID: 50229
		public const int EntityIdFieldNumber = 5;

		// Token: 0x0400C436 RID: 50230
		private long entityId_;
	}
}
