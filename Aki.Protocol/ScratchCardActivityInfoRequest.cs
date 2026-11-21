using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011D6 RID: 4566
	[NetMessage(EMessageId.ScratchCardActivityInfoRequest)]
	public sealed class ScratchCardActivityInfoRequest : IMessage<ScratchCardActivityInfoRequest>, IMessage, IEquatable<ScratchCardActivityInfoRequest>, IDeepCloneable<ScratchCardActivityInfoRequest>, IBufferMessage
	{
		// Token: 0x060185F9 RID: 99833 RVA: 0x0038C26A File Offset: 0x0038A46A
		[NullableContext(1)]
		public static ScratchCardActivityInfoRequest Create()
		{
			return new ScratchCardActivityInfoRequest();
		}

		// Token: 0x17005224 RID: 21028
		// (get) Token: 0x060185FA RID: 99834 RVA: 0x0038C271 File Offset: 0x0038A471
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005225 RID: 21029
		// (get) Token: 0x060185FB RID: 99835 RVA: 0x0038C274 File Offset: 0x0038A474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ScratchCardActivityInfoRequest.Descriptor;
			}
		}

		// Token: 0x060185FC RID: 99836 RVA: 0x0038C27B File Offset: 0x0038A47B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardActivityInfoRequest()
		{
		}

		// Token: 0x060185FD RID: 99837 RVA: 0x0038C283 File Offset: 0x0038A483
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardActivityInfoRequest(ScratchCardActivityInfoRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060185FE RID: 99838 RVA: 0x0038C2A8 File Offset: 0x0038A4A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardActivityInfoRequest Clone()
		{
			return new ScratchCardActivityInfoRequest(this);
		}

		// Token: 0x17005226 RID: 21030
		// (get) Token: 0x060185FF RID: 99839 RVA: 0x0038C2B0 File Offset: 0x0038A4B0
		// (set) Token: 0x06018600 RID: 99840 RVA: 0x0038C2B8 File Offset: 0x0038A4B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x06018601 RID: 99841 RVA: 0x0038C2C1 File Offset: 0x0038A4C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ScratchCardActivityInfoRequest);
		}

		// Token: 0x06018602 RID: 99842 RVA: 0x0038C2CF File Offset: 0x0038A4CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ScratchCardActivityInfoRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018603 RID: 99843 RVA: 0x0038C300 File Offset: 0x0038A500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018604 RID: 99844 RVA: 0x0038C33F File Offset: 0x0038A53F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018605 RID: 99845 RVA: 0x0038C34C File Offset: 0x0038A54C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018606 RID: 99846 RVA: 0x0038C355 File Offset: 0x0038A555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018607 RID: 99847 RVA: 0x0038C388 File Offset: 0x0038A588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018608 RID: 99848 RVA: 0x0038C3C6 File Offset: 0x0038A5C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ScratchCardActivityInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018609 RID: 99849 RVA: 0x0038C3F7 File Offset: 0x0038A5F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601860A RID: 99850 RVA: 0x0038C400 File Offset: 0x0038A600
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040090CE RID: 37070
		private UnknownFieldSet _unknownFields;

		// Token: 0x040090CF RID: 37071
		public const int ActivityIdFieldNumber = 6;

		// Token: 0x040090D0 RID: 37072
		private int activityId_;
	}
}
