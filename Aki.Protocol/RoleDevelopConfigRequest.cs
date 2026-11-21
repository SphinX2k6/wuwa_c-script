using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001054 RID: 4180
	[NetMessage(EMessageId.RoleDevelopConfigRequest)]
	public sealed class RoleDevelopConfigRequest : IMessage<RoleDevelopConfigRequest>, IMessage, IEquatable<RoleDevelopConfigRequest>, IDeepCloneable<RoleDevelopConfigRequest>, IBufferMessage
	{
		// Token: 0x060165C6 RID: 91590 RVA: 0x0034069F File Offset: 0x0033E89F
		[NullableContext(1)]
		public static RoleDevelopConfigRequest Create()
		{
			return new RoleDevelopConfigRequest();
		}

		// Token: 0x17004AD5 RID: 19157
		// (get) Token: 0x060165C7 RID: 91591 RVA: 0x003406A6 File Offset: 0x0033E8A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004AD6 RID: 19158
		// (get) Token: 0x060165C8 RID: 91592 RVA: 0x003406A9 File Offset: 0x0033E8A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleDevelopConfigRequest.Descriptor;
			}
		}

		// Token: 0x060165C9 RID: 91593 RVA: 0x003406B0 File Offset: 0x0033E8B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDevelopConfigRequest()
		{
		}

		// Token: 0x060165CA RID: 91594 RVA: 0x003406B8 File Offset: 0x0033E8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDevelopConfigRequest(RoleDevelopConfigRequest other) : this()
		{
			this.version_ = other.version_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060165CB RID: 91595 RVA: 0x003406DD File Offset: 0x0033E8DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDevelopConfigRequest Clone()
		{
			return new RoleDevelopConfigRequest(this);
		}

		// Token: 0x17004AD7 RID: 19159
		// (get) Token: 0x060165CC RID: 91596 RVA: 0x003406E5 File Offset: 0x0033E8E5
		// (set) Token: 0x060165CD RID: 91597 RVA: 0x003406F6 File Offset: 0x0033E8F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Version
		{
			get
			{
				return this.version_ ?? RoleDevelopConfigRequest.VersionDefaultValue;
			}
			set
			{
				this.version_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17004AD8 RID: 19160
		// (get) Token: 0x060165CE RID: 91598 RVA: 0x00340709 File Offset: 0x0033E909
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasVersion
		{
			get
			{
				return this.version_ != null;
			}
		}

		// Token: 0x060165CF RID: 91599 RVA: 0x00340714 File Offset: 0x0033E914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearVersion()
		{
			this.version_ = null;
		}

		// Token: 0x060165D0 RID: 91600 RVA: 0x0034071D File Offset: 0x0033E91D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleDevelopConfigRequest);
		}

		// Token: 0x060165D1 RID: 91601 RVA: 0x0034072B File Offset: 0x0033E92B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleDevelopConfigRequest other)
		{
			return other != null && (other == this || (!(this.Version != other.Version) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060165D2 RID: 91602 RVA: 0x00340760 File Offset: 0x0033E960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HasVersion)
			{
				num ^= this.Version.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060165D3 RID: 91603 RVA: 0x0034079C File Offset: 0x0033E99C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060165D4 RID: 91604 RVA: 0x003407A9 File Offset: 0x0033E9A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060165D5 RID: 91605 RVA: 0x003407B2 File Offset: 0x0033E9B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasVersion)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Version);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060165D6 RID: 91606 RVA: 0x003407E4 File Offset: 0x0033E9E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HasVersion)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Version);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060165D7 RID: 91607 RVA: 0x00340822 File Offset: 0x0033EA22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleDevelopConfigRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HasVersion)
			{
				this.Version = other.Version;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060165D8 RID: 91608 RVA: 0x00340853 File Offset: 0x0033EA53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060165D9 RID: 91609 RVA: 0x0034085C File Offset: 0x0033EA5C
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Version = input.ReadString();
				}
			}
		}

		// Token: 0x04008631 RID: 34353
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008632 RID: 34354
		public const int VersionFieldNumber = 2;

		// Token: 0x04008633 RID: 34355
		private static readonly string VersionDefaultValue = "";

		// Token: 0x04008634 RID: 34356
		private string version_;
	}
}
