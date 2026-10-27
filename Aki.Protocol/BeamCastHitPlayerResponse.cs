using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000183 RID: 387
	[NetMessage(EMessageId.BeamCastHitPlayerResponse)]
	public sealed class BeamCastHitPlayerResponse : IMessage<BeamCastHitPlayerResponse>, IMessage, IEquatable<BeamCastHitPlayerResponse>, IDeepCloneable<BeamCastHitPlayerResponse>, IBufferMessage
	{
		// Token: 0x06002EBB RID: 11963 RVA: 0x00078191 File Offset: 0x00076391
		[NullableContext(1)]
		public static BeamCastHitPlayerResponse Create()
		{
			return new BeamCastHitPlayerResponse();
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x06002EBC RID: 11964 RVA: 0x00078198 File Offset: 0x00076398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06002EBD RID: 11965 RVA: 0x0007819B File Offset: 0x0007639B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BeamCastHitPlayerResponse.Descriptor;
			}
		}

		// Token: 0x06002EBE RID: 11966 RVA: 0x000781A2 File Offset: 0x000763A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeamCastHitPlayerResponse()
		{
		}

		// Token: 0x06002EBF RID: 11967 RVA: 0x000781AA File Offset: 0x000763AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeamCastHitPlayerResponse(BeamCastHitPlayerResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002EC0 RID: 11968 RVA: 0x000781CF File Offset: 0x000763CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeamCastHitPlayerResponse Clone()
		{
			return new BeamCastHitPlayerResponse(this);
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x06002EC1 RID: 11969 RVA: 0x000781D7 File Offset: 0x000763D7
		// (set) Token: 0x06002EC2 RID: 11970 RVA: 0x000781DF File Offset: 0x000763DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x06002EC3 RID: 11971 RVA: 0x000781E8 File Offset: 0x000763E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BeamCastHitPlayerResponse);
		}

		// Token: 0x06002EC4 RID: 11972 RVA: 0x000781F6 File Offset: 0x000763F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BeamCastHitPlayerResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002EC5 RID: 11973 RVA: 0x00078224 File Offset: 0x00076424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002EC6 RID: 11974 RVA: 0x00078269 File Offset: 0x00076469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002EC7 RID: 11975 RVA: 0x00078276 File Offset: 0x00076476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002EC8 RID: 11976 RVA: 0x0007827F File Offset: 0x0007647F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002EC9 RID: 11977 RVA: 0x000782B0 File Offset: 0x000764B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002ECA RID: 11978 RVA: 0x000782EE File Offset: 0x000764EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BeamCastHitPlayerResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002ECB RID: 11979 RVA: 0x0007831F File Offset: 0x0007651F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002ECC RID: 11980 RVA: 0x00078328 File Offset: 0x00076528
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
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002883 RID: 10371
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002884 RID: 10372
		public const int CodeFieldNumber = 1;

		// Token: 0x04002885 RID: 10373
		private ErrorCode code_;
	}
}
