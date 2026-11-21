using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200108E RID: 4238
	[NetMessage(EMessageId.RolePropResponse)]
	public sealed class RolePropResponse : IMessage<RolePropResponse>, IMessage, IEquatable<RolePropResponse>, IDeepCloneable<RolePropResponse>, IBufferMessage
	{
		// Token: 0x06016AAB RID: 92843 RVA: 0x0034C1F5 File Offset: 0x0034A3F5
		[NullableContext(1)]
		public static RolePropResponse Create()
		{
			return new RolePropResponse();
		}

		// Token: 0x17004BFB RID: 19451
		// (get) Token: 0x06016AAC RID: 92844 RVA: 0x0034C1FC File Offset: 0x0034A3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004BFC RID: 19452
		// (get) Token: 0x06016AAD RID: 92845 RVA: 0x0034C1FF File Offset: 0x0034A3FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RolePropResponse.Descriptor;
			}
		}

		// Token: 0x06016AAE RID: 92846 RVA: 0x0034C206 File Offset: 0x0034A406
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePropResponse()
		{
		}

		// Token: 0x06016AAF RID: 92847 RVA: 0x0034C219 File Offset: 0x0034A419
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePropResponse(RolePropResponse other) : this()
		{
			this.error_ = other.error_;
			this.roleProps_ = other.roleProps_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016AB0 RID: 92848 RVA: 0x0034C24F File Offset: 0x0034A44F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePropResponse Clone()
		{
			return new RolePropResponse(this);
		}

		// Token: 0x17004BFD RID: 19453
		// (get) Token: 0x06016AB1 RID: 92849 RVA: 0x0034C257 File Offset: 0x0034A457
		// (set) Token: 0x06016AB2 RID: 92850 RVA: 0x0034C25F File Offset: 0x0034A45F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Error
		{
			get
			{
				return this.error_;
			}
			set
			{
				this.error_ = value;
			}
		}

		// Token: 0x17004BFE RID: 19454
		// (get) Token: 0x06016AB3 RID: 92851 RVA: 0x0034C268 File Offset: 0x0034A468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RolePropInfo> RoleProps
		{
			get
			{
				return this.roleProps_;
			}
		}

		// Token: 0x06016AB4 RID: 92852 RVA: 0x0034C270 File Offset: 0x0034A470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RolePropResponse);
		}

		// Token: 0x06016AB5 RID: 92853 RVA: 0x0034C280 File Offset: 0x0034A480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RolePropResponse other)
		{
			return other != null && (other == this || (this.Error == other.Error && this.roleProps_.Equals(other.roleProps_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016AB6 RID: 92854 RVA: 0x0034C2D0 File Offset: 0x0034A4D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Error != ErrorCode.Success)
			{
				num ^= this.Error.GetHashCode();
			}
			num ^= this.roleProps_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016AB7 RID: 92855 RVA: 0x0034C323 File Offset: 0x0034A523
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016AB8 RID: 92856 RVA: 0x0034C330 File Offset: 0x0034A530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016AB9 RID: 92857 RVA: 0x0034C33C File Offset: 0x0034A53C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleProps_.WriteTo(ref output, RolePropResponse._repeated_roleProps_codec);
			if (this.Error != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Error);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016ABA RID: 92858 RVA: 0x0034C38C File Offset: 0x0034A58C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Error != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Error);
			}
			num += this.roleProps_.CalculateSize(RolePropResponse._repeated_roleProps_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016ABB RID: 92859 RVA: 0x0034C3E0 File Offset: 0x0034A5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RolePropResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Error != ErrorCode.Success)
			{
				this.Error = other.Error;
			}
			this.roleProps_.Add(other.roleProps_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016ABC RID: 92860 RVA: 0x0034C42D File Offset: 0x0034A62D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016ABD RID: 92861 RVA: 0x0034C438 File Offset: 0x0034A638
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
				if (num != 10U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Error = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.roleProps_.AddEntriesFrom(ref input, RolePropResponse._repeated_roleProps_codec);
				}
			}
		}

		// Token: 0x040087ED RID: 34797
		private UnknownFieldSet _unknownFields;

		// Token: 0x040087EE RID: 34798
		public const int ErrorFieldNumber = 5;

		// Token: 0x040087EF RID: 34799
		private ErrorCode error_;

		// Token: 0x040087F0 RID: 34800
		public const int RolePropsFieldNumber = 1;

		// Token: 0x040087F1 RID: 34801
		private static readonly FieldCodec<RolePropInfo> _repeated_roleProps_codec = FieldCodec.ForMessage<RolePropInfo>(10U, RolePropInfo.Parser);

		// Token: 0x040087F2 RID: 34802
		private readonly RepeatedField<RolePropInfo> roleProps_ = new RepeatedField<RolePropInfo>();
	}
}
