using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200094A RID: 2378
	[NetMessage(EMessageId.LordGymBeginRequest)]
	public sealed class LordGymBeginRequest : IMessage<LordGymBeginRequest>, IMessage, IEquatable<LordGymBeginRequest>, IDeepCloneable<LordGymBeginRequest>, IBufferMessage
	{
		// Token: 0x0600D1F5 RID: 53749 RVA: 0x001EF8A8 File Offset: 0x001EDAA8
		[NullableContext(1)]
		public static LordGymBeginRequest Create()
		{
			return new LordGymBeginRequest();
		}

		// Token: 0x17002A7F RID: 10879
		// (get) Token: 0x0600D1F6 RID: 53750 RVA: 0x001EF8AF File Offset: 0x001EDAAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A80 RID: 10880
		// (get) Token: 0x0600D1F7 RID: 53751 RVA: 0x001EF8B2 File Offset: 0x001EDAB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LordGymBeginRequest.Descriptor;
			}
		}

		// Token: 0x0600D1F8 RID: 53752 RVA: 0x001EF8B9 File Offset: 0x001EDAB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymBeginRequest()
		{
		}

		// Token: 0x0600D1F9 RID: 53753 RVA: 0x001EF8C1 File Offset: 0x001EDAC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymBeginRequest(LordGymBeginRequest other) : this()
		{
			this.loadGymId_ = other.loadGymId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D1FA RID: 53754 RVA: 0x001EF8E6 File Offset: 0x001EDAE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymBeginRequest Clone()
		{
			return new LordGymBeginRequest(this);
		}

		// Token: 0x17002A81 RID: 10881
		// (get) Token: 0x0600D1FB RID: 53755 RVA: 0x001EF8EE File Offset: 0x001EDAEE
		// (set) Token: 0x0600D1FC RID: 53756 RVA: 0x001EF8F6 File Offset: 0x001EDAF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LoadGymId
		{
			get
			{
				return this.loadGymId_;
			}
			set
			{
				this.loadGymId_ = value;
			}
		}

		// Token: 0x0600D1FD RID: 53757 RVA: 0x001EF8FF File Offset: 0x001EDAFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LordGymBeginRequest);
		}

		// Token: 0x0600D1FE RID: 53758 RVA: 0x001EF90D File Offset: 0x001EDB0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LordGymBeginRequest other)
		{
			return other != null && (other == this || (this.LoadGymId == other.LoadGymId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D1FF RID: 53759 RVA: 0x001EF93C File Offset: 0x001EDB3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LoadGymId != 0)
			{
				num ^= this.LoadGymId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D200 RID: 53760 RVA: 0x001EF97B File Offset: 0x001EDB7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D201 RID: 53761 RVA: 0x001EF988 File Offset: 0x001EDB88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D202 RID: 53762 RVA: 0x001EF991 File Offset: 0x001EDB91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LoadGymId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LoadGymId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D203 RID: 53763 RVA: 0x001EF9C4 File Offset: 0x001EDBC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LoadGymId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LoadGymId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D204 RID: 53764 RVA: 0x001EFA02 File Offset: 0x001EDC02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LordGymBeginRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LoadGymId != 0)
			{
				this.LoadGymId = other.LoadGymId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D205 RID: 53765 RVA: 0x001EFA33 File Offset: 0x001EDC33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D206 RID: 53766 RVA: 0x001EFA3C File Offset: 0x001EDC3C
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.LoadGymId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040058C8 RID: 22728
		private UnknownFieldSet _unknownFields;

		// Token: 0x040058C9 RID: 22729
		public const int LoadGymIdFieldNumber = 1;

		// Token: 0x040058CA RID: 22730
		private int loadGymId_;
	}
}
