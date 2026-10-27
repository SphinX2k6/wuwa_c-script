using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003F0 RID: 1008
	[NetMessage(EMessageId.DollGrabPauseEndRequest)]
	public sealed class DollGrabPauseEndRequest : IMessage<DollGrabPauseEndRequest>, IMessage, IEquatable<DollGrabPauseEndRequest>, IDeepCloneable<DollGrabPauseEndRequest>, IBufferMessage
	{
		// Token: 0x060061AF RID: 25007 RVA: 0x000EB9E1 File Offset: 0x000E9BE1
		[NullableContext(1)]
		public static DollGrabPauseEndRequest Create()
		{
			return new DollGrabPauseEndRequest();
		}

		// Token: 0x17001235 RID: 4661
		// (get) Token: 0x060061B0 RID: 25008 RVA: 0x000EB9E8 File Offset: 0x000E9BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001236 RID: 4662
		// (get) Token: 0x060061B1 RID: 25009 RVA: 0x000EB9EB File Offset: 0x000E9BEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollGrabPauseEndRequest.Descriptor;
			}
		}

		// Token: 0x060061B2 RID: 25010 RVA: 0x000EB9F2 File Offset: 0x000E9BF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabPauseEndRequest()
		{
		}

		// Token: 0x060061B3 RID: 25011 RVA: 0x000EB9FA File Offset: 0x000E9BFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabPauseEndRequest(DollGrabPauseEndRequest other) : this()
		{
			this.entityIncId_ = other.entityIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060061B4 RID: 25012 RVA: 0x000EBA1F File Offset: 0x000E9C1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabPauseEndRequest Clone()
		{
			return new DollGrabPauseEndRequest(this);
		}

		// Token: 0x17001237 RID: 4663
		// (get) Token: 0x060061B5 RID: 25013 RVA: 0x000EBA27 File Offset: 0x000E9C27
		// (set) Token: 0x060061B6 RID: 25014 RVA: 0x000EBA2F File Offset: 0x000E9C2F
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

		// Token: 0x060061B7 RID: 25015 RVA: 0x000EBA38 File Offset: 0x000E9C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollGrabPauseEndRequest);
		}

		// Token: 0x060061B8 RID: 25016 RVA: 0x000EBA46 File Offset: 0x000E9C46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollGrabPauseEndRequest other)
		{
			return other != null && (other == this || (this.EntityIncId == other.EntityIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060061B9 RID: 25017 RVA: 0x000EBA74 File Offset: 0x000E9C74
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

		// Token: 0x060061BA RID: 25018 RVA: 0x000EBAB3 File Offset: 0x000E9CB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060061BB RID: 25019 RVA: 0x000EBAC0 File Offset: 0x000E9CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060061BC RID: 25020 RVA: 0x000EBAC9 File Offset: 0x000E9CC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityIncId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EntityIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060061BD RID: 25021 RVA: 0x000EBAFC File Offset: 0x000E9CFC
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

		// Token: 0x060061BE RID: 25022 RVA: 0x000EBB3A File Offset: 0x000E9D3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DollGrabPauseEndRequest other)
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

		// Token: 0x060061BF RID: 25023 RVA: 0x000EBB6B File Offset: 0x000E9D6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060061C0 RID: 25024 RVA: 0x000EBB74 File Offset: 0x000E9D74
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
					this.EntityIncId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040037AE RID: 14254
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037AF RID: 14255
		public const int EntityIncIdFieldNumber = 5;

		// Token: 0x040037B0 RID: 14256
		private long entityIncId_;
	}
}
