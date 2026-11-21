using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003E0 RID: 992
	[NetMessage(EMessageId.DollGrabStopRequest)]
	public sealed class DollGrabStopRequest : IMessage<DollGrabStopRequest>, IMessage, IEquatable<DollGrabStopRequest>, IDeepCloneable<DollGrabStopRequest>, IBufferMessage
	{
		// Token: 0x060060A1 RID: 24737 RVA: 0x000E9700 File Offset: 0x000E7900
		[NullableContext(1)]
		public static DollGrabStopRequest Create()
		{
			return new DollGrabStopRequest();
		}

		// Token: 0x170011F7 RID: 4599
		// (get) Token: 0x060060A2 RID: 24738 RVA: 0x000E9707 File Offset: 0x000E7907
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011F8 RID: 4600
		// (get) Token: 0x060060A3 RID: 24739 RVA: 0x000E970A File Offset: 0x000E790A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollGrabStopRequest.Descriptor;
			}
		}

		// Token: 0x060060A4 RID: 24740 RVA: 0x000E9711 File Offset: 0x000E7911
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabStopRequest()
		{
		}

		// Token: 0x060060A5 RID: 24741 RVA: 0x000E9719 File Offset: 0x000E7919
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabStopRequest(DollGrabStopRequest other) : this()
		{
			this.entityIncId_ = other.entityIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060060A6 RID: 24742 RVA: 0x000E973E File Offset: 0x000E793E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabStopRequest Clone()
		{
			return new DollGrabStopRequest(this);
		}

		// Token: 0x170011F9 RID: 4601
		// (get) Token: 0x060060A7 RID: 24743 RVA: 0x000E9746 File Offset: 0x000E7946
		// (set) Token: 0x060060A8 RID: 24744 RVA: 0x000E974E File Offset: 0x000E794E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityIncId
		{
			get
			{
				return this.entityIncId_;
			}
			set
			{
				this.entityIncId_ = value;
			}
		}

		// Token: 0x060060A9 RID: 24745 RVA: 0x000E9757 File Offset: 0x000E7957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollGrabStopRequest);
		}

		// Token: 0x060060AA RID: 24746 RVA: 0x000E9765 File Offset: 0x000E7965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollGrabStopRequest other)
		{
			return other != null && (other == this || (this.EntityIncId == other.EntityIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060060AB RID: 24747 RVA: 0x000E9794 File Offset: 0x000E7994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityIncId != 0L)
			{
				num ^= this.EntityIncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060060AC RID: 24748 RVA: 0x000E97D3 File Offset: 0x000E79D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060060AD RID: 24749 RVA: 0x000E97E0 File Offset: 0x000E79E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060060AE RID: 24750 RVA: 0x000E97E9 File Offset: 0x000E79E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityIncId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.EntityIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060060AF RID: 24751 RVA: 0x000E981C File Offset: 0x000E7A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityIncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060060B0 RID: 24752 RVA: 0x000E985A File Offset: 0x000E7A5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DollGrabStopRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityIncId != 0L)
			{
				this.EntityIncId = other.EntityIncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060060B1 RID: 24753 RVA: 0x000E988B File Offset: 0x000E7A8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060060B2 RID: 24754 RVA: 0x000E9894 File Offset: 0x000E7A94
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityIncId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040037B6 RID: 14262
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037B7 RID: 14263
		public const int EntityIncIdFieldNumber = 12;

		// Token: 0x040037B8 RID: 14264
		private long entityIncId_;
	}
}
