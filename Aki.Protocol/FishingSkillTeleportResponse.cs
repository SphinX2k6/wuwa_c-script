using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000574 RID: 1396
	[NetMessage(EMessageId.FishingSkillTeleportResponse)]
	public sealed class FishingSkillTeleportResponse : IMessage<FishingSkillTeleportResponse>, IMessage, IEquatable<FishingSkillTeleportResponse>, IDeepCloneable<FishingSkillTeleportResponse>, IBufferMessage
	{
		// Token: 0x0600820C RID: 33292 RVA: 0x00139E86 File Offset: 0x00138086
		[NullableContext(1)]
		public static FishingSkillTeleportResponse Create()
		{
			return new FishingSkillTeleportResponse();
		}

		// Token: 0x17001950 RID: 6480
		// (get) Token: 0x0600820D RID: 33293 RVA: 0x00139E8D File Offset: 0x0013808D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001951 RID: 6481
		// (get) Token: 0x0600820E RID: 33294 RVA: 0x00139E90 File Offset: 0x00138090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingSkillTeleportResponse.Descriptor;
			}
		}

		// Token: 0x0600820F RID: 33295 RVA: 0x00139E97 File Offset: 0x00138097
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkillTeleportResponse()
		{
		}

		// Token: 0x06008210 RID: 33296 RVA: 0x00139E9F File Offset: 0x0013809F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkillTeleportResponse(FishingSkillTeleportResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008211 RID: 33297 RVA: 0x00139EC4 File Offset: 0x001380C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkillTeleportResponse Clone()
		{
			return new FishingSkillTeleportResponse(this);
		}

		// Token: 0x17001952 RID: 6482
		// (get) Token: 0x06008212 RID: 33298 RVA: 0x00139ECC File Offset: 0x001380CC
		// (set) Token: 0x06008213 RID: 33299 RVA: 0x00139ED4 File Offset: 0x001380D4
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

		// Token: 0x06008214 RID: 33300 RVA: 0x00139EDD File Offset: 0x001380DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingSkillTeleportResponse);
		}

		// Token: 0x06008215 RID: 33301 RVA: 0x00139EEB File Offset: 0x001380EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingSkillTeleportResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008216 RID: 33302 RVA: 0x00139F1C File Offset: 0x0013811C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008217 RID: 33303 RVA: 0x00139F61 File Offset: 0x00138161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008218 RID: 33304 RVA: 0x00139F6E File Offset: 0x0013816E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008219 RID: 33305 RVA: 0x00139F77 File Offset: 0x00138177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600821A RID: 33306 RVA: 0x00139FAC File Offset: 0x001381AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600821B RID: 33307 RVA: 0x00139FEA File Offset: 0x001381EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingSkillTeleportResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600821C RID: 33308 RVA: 0x0013A01B File Offset: 0x0013821B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600821D RID: 33309 RVA: 0x0013A024 File Offset: 0x00138224
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400416F RID: 16751
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004170 RID: 16752
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04004171 RID: 16753
		private ErrorCode errorCode_;
	}
}
