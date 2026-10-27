using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003BD RID: 957
	[NetMessage(EMessageId.DeconstructTrapRequest)]
	public sealed class DeconstructTrapRequest : IMessage<DeconstructTrapRequest>, IMessage, IEquatable<DeconstructTrapRequest>, IDeepCloneable<DeconstructTrapRequest>, IBufferMessage
	{
		// Token: 0x06005DB9 RID: 23993 RVA: 0x000E357B File Offset: 0x000E177B
		[NullableContext(1)]
		public static DeconstructTrapRequest Create()
		{
			return new DeconstructTrapRequest();
		}

		// Token: 0x17001169 RID: 4457
		// (get) Token: 0x06005DBA RID: 23994 RVA: 0x000E3582 File Offset: 0x000E1782
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700116A RID: 4458
		// (get) Token: 0x06005DBB RID: 23995 RVA: 0x000E3585 File Offset: 0x000E1785
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeconstructTrapRequest.Descriptor;
			}
		}

		// Token: 0x06005DBC RID: 23996 RVA: 0x000E358C File Offset: 0x000E178C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeconstructTrapRequest()
		{
		}

		// Token: 0x06005DBD RID: 23997 RVA: 0x000E3594 File Offset: 0x000E1794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeconstructTrapRequest(DeconstructTrapRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005DBE RID: 23998 RVA: 0x000E35B9 File Offset: 0x000E17B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeconstructTrapRequest Clone()
		{
			return new DeconstructTrapRequest(this);
		}

		// Token: 0x1700116B RID: 4459
		// (get) Token: 0x06005DBF RID: 23999 RVA: 0x000E35C1 File Offset: 0x000E17C1
		// (set) Token: 0x06005DC0 RID: 24000 RVA: 0x000E35C9 File Offset: 0x000E17C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x06005DC1 RID: 24001 RVA: 0x000E35D2 File Offset: 0x000E17D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeconstructTrapRequest);
		}

		// Token: 0x06005DC2 RID: 24002 RVA: 0x000E35E0 File Offset: 0x000E17E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DeconstructTrapRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005DC3 RID: 24003 RVA: 0x000E3610 File Offset: 0x000E1810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005DC4 RID: 24004 RVA: 0x000E364F File Offset: 0x000E184F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005DC5 RID: 24005 RVA: 0x000E365C File Offset: 0x000E185C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005DC6 RID: 24006 RVA: 0x000E3665 File Offset: 0x000E1865
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005DC7 RID: 24007 RVA: 0x000E3698 File Offset: 0x000E1898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005DC8 RID: 24008 RVA: 0x000E36D6 File Offset: 0x000E18D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DeconstructTrapRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005DC9 RID: 24009 RVA: 0x000E3707 File Offset: 0x000E1907
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005DCA RID: 24010 RVA: 0x000E3710 File Offset: 0x000E1910
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
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x040036A2 RID: 13986
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036A3 RID: 13987
		public const int IdFieldNumber = 8;

		// Token: 0x040036A4 RID: 13988
		private long id_;
	}
}
