using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003D9 RID: 985
	[NetMessage(EMessageId.DollGrabPauseEndRequest)]
	public sealed class DollGrabPauseEndRequest : IMessage<DollGrabPauseEndRequest>, IMessage, IEquatable<DollGrabPauseEndRequest>, IDeepCloneable<DollGrabPauseEndRequest>, IBufferMessage
	{
		// Token: 0x0600601F RID: 24607 RVA: 0x000E8861 File Offset: 0x000E6A61
		[NullableContext(1)]
		public static DollGrabPauseEndRequest Create()
		{
			return new DollGrabPauseEndRequest();
		}

		// Token: 0x170011E0 RID: 4576
		// (get) Token: 0x06006020 RID: 24608 RVA: 0x000E8868 File Offset: 0x000E6A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011E1 RID: 4577
		// (get) Token: 0x06006021 RID: 24609 RVA: 0x000E886B File Offset: 0x000E6A6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollGrabPauseEndRequest.Descriptor;
			}
		}

		// Token: 0x06006022 RID: 24610 RVA: 0x000E8872 File Offset: 0x000E6A72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabPauseEndRequest()
		{
		}

		// Token: 0x06006023 RID: 24611 RVA: 0x000E887A File Offset: 0x000E6A7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabPauseEndRequest(DollGrabPauseEndRequest other) : this()
		{
			this.entityIncId_ = other.entityIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006024 RID: 24612 RVA: 0x000E889F File Offset: 0x000E6A9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabPauseEndRequest Clone()
		{
			return new DollGrabPauseEndRequest(this);
		}

		// Token: 0x170011E2 RID: 4578
		// (get) Token: 0x06006025 RID: 24613 RVA: 0x000E88A7 File Offset: 0x000E6AA7
		// (set) Token: 0x06006026 RID: 24614 RVA: 0x000E88AF File Offset: 0x000E6AAF
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

		// Token: 0x06006027 RID: 24615 RVA: 0x000E88B8 File Offset: 0x000E6AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollGrabPauseEndRequest);
		}

		// Token: 0x06006028 RID: 24616 RVA: 0x000E88C6 File Offset: 0x000E6AC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollGrabPauseEndRequest other)
		{
			return other != null && (other == this || (this.EntityIncId == other.EntityIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006029 RID: 24617 RVA: 0x000E88F4 File Offset: 0x000E6AF4
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

		// Token: 0x0600602A RID: 24618 RVA: 0x000E8933 File Offset: 0x000E6B33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600602B RID: 24619 RVA: 0x000E8940 File Offset: 0x000E6B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600602C RID: 24620 RVA: 0x000E8949 File Offset: 0x000E6B49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityIncId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.EntityIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600602D RID: 24621 RVA: 0x000E897C File Offset: 0x000E6B7C
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

		// Token: 0x0600602E RID: 24622 RVA: 0x000E89BA File Offset: 0x000E6BBA
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

		// Token: 0x0600602F RID: 24623 RVA: 0x000E89EB File Offset: 0x000E6BEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006030 RID: 24624 RVA: 0x000E89F4 File Offset: 0x000E6BF4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityIncId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400379B RID: 14235
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400379C RID: 14236
		public const int EntityIncIdFieldNumber = 8;

		// Token: 0x0400379D RID: 14237
		private long entityIncId_;
	}
}
