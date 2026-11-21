using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005FD RID: 1533
	[NetMessage(EMessageId.FlySkinWearAllRoleResponse)]
	public sealed class FlySkinWearAllRoleResponse : IMessage<FlySkinWearAllRoleResponse>, IMessage, IEquatable<FlySkinWearAllRoleResponse>, IDeepCloneable<FlySkinWearAllRoleResponse>, IBufferMessage
	{
		// Token: 0x06008E26 RID: 36390 RVA: 0x00158EA1 File Offset: 0x001570A1
		[NullableContext(1)]
		public static FlySkinWearAllRoleResponse Create()
		{
			return new FlySkinWearAllRoleResponse();
		}

		// Token: 0x17001C32 RID: 7218
		// (get) Token: 0x06008E27 RID: 36391 RVA: 0x00158EA8 File Offset: 0x001570A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C33 RID: 7219
		// (get) Token: 0x06008E28 RID: 36392 RVA: 0x00158EAB File Offset: 0x001570AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlySkinWearAllRoleResponse.Descriptor;
			}
		}

		// Token: 0x06008E29 RID: 36393 RVA: 0x00158EB2 File Offset: 0x001570B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinWearAllRoleResponse()
		{
		}

		// Token: 0x06008E2A RID: 36394 RVA: 0x00158EC5 File Offset: 0x001570C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinWearAllRoleResponse(FlySkinWearAllRoleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.skinChanges_ = other.skinChanges_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008E2B RID: 36395 RVA: 0x00158EFB File Offset: 0x001570FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinWearAllRoleResponse Clone()
		{
			return new FlySkinWearAllRoleResponse(this);
		}

		// Token: 0x17001C34 RID: 7220
		// (get) Token: 0x06008E2C RID: 36396 RVA: 0x00158F03 File Offset: 0x00157103
		// (set) Token: 0x06008E2D RID: 36397 RVA: 0x00158F0B File Offset: 0x0015710B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17001C35 RID: 7221
		// (get) Token: 0x06008E2E RID: 36398 RVA: 0x00158F14 File Offset: 0x00157114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleFlySkinChange> SkinChanges
		{
			get
			{
				return this.skinChanges_;
			}
		}

		// Token: 0x06008E2F RID: 36399 RVA: 0x00158F1C File Offset: 0x0015711C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlySkinWearAllRoleResponse);
		}

		// Token: 0x06008E30 RID: 36400 RVA: 0x00158F2C File Offset: 0x0015712C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlySkinWearAllRoleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.skinChanges_.Equals(other.skinChanges_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008E31 RID: 36401 RVA: 0x00158F7C File Offset: 0x0015717C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.skinChanges_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008E32 RID: 36402 RVA: 0x00158FCF File Offset: 0x001571CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008E33 RID: 36403 RVA: 0x00158FDC File Offset: 0x001571DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008E34 RID: 36404 RVA: 0x00158FE8 File Offset: 0x001571E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.skinChanges_.WriteTo(ref output, FlySkinWearAllRoleResponse._repeated_skinChanges_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008E35 RID: 36405 RVA: 0x00159038 File Offset: 0x00157238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.skinChanges_.CalculateSize(FlySkinWearAllRoleResponse._repeated_skinChanges_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008E36 RID: 36406 RVA: 0x0015908C File Offset: 0x0015728C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlySkinWearAllRoleResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.skinChanges_.Add(other.skinChanges_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008E37 RID: 36407 RVA: 0x001590D9 File Offset: 0x001572D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008E38 RID: 36408 RVA: 0x001590E4 File Offset: 0x001572E4
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
				if (num != 34U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.skinChanges_.AddEntriesFrom(ref input, FlySkinWearAllRoleResponse._repeated_skinChanges_codec);
				}
			}
		}

		// Token: 0x040045A0 RID: 17824
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045A1 RID: 17825
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x040045A2 RID: 17826
		private ErrorCode errorCode_;

		// Token: 0x040045A3 RID: 17827
		public const int SkinChangesFieldNumber = 4;

		// Token: 0x040045A4 RID: 17828
		private static readonly FieldCodec<RoleFlySkinChange> _repeated_skinChanges_codec = FieldCodec.ForMessage<RoleFlySkinChange>(34U, RoleFlySkinChange.Parser);

		// Token: 0x040045A5 RID: 17829
		private readonly RepeatedField<RoleFlySkinChange> skinChanges_ = new RepeatedField<RoleFlySkinChange>();
	}
}
