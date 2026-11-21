using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003E9 RID: 1001
	[NetMessage(EMessageId.DragonPoolConfResponse)]
	public sealed class DragonPoolConfResponse : IMessage<DragonPoolConfResponse>, IMessage, IEquatable<DragonPoolConfResponse>, IDeepCloneable<DragonPoolConfResponse>, IBufferMessage
	{
		// Token: 0x06006151 RID: 24913 RVA: 0x000EADD5 File Offset: 0x000E8FD5
		[NullableContext(1)]
		public static DragonPoolConfResponse Create()
		{
			return new DragonPoolConfResponse();
		}

		// Token: 0x1700121A RID: 4634
		// (get) Token: 0x06006152 RID: 24914 RVA: 0x000EADDC File Offset: 0x000E8FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700121B RID: 4635
		// (get) Token: 0x06006153 RID: 24915 RVA: 0x000EADDF File Offset: 0x000E8FDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DragonPoolConfResponse.Descriptor;
			}
		}

		// Token: 0x06006154 RID: 24916 RVA: 0x000EADE6 File Offset: 0x000E8FE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DragonPoolConfResponse()
		{
		}

		// Token: 0x06006155 RID: 24917 RVA: 0x000EADF0 File Offset: 0x000E8FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DragonPoolConfResponse(DragonPoolConfResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.dragonPoolConf_ = ((other.dragonPoolConf_ != null) ? other.dragonPoolConf_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006156 RID: 24918 RVA: 0x000EAE3C File Offset: 0x000E903C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DragonPoolConfResponse Clone()
		{
			return new DragonPoolConfResponse(this);
		}

		// Token: 0x1700121C RID: 4636
		// (get) Token: 0x06006157 RID: 24919 RVA: 0x000EAE44 File Offset: 0x000E9044
		// (set) Token: 0x06006158 RID: 24920 RVA: 0x000EAE4C File Offset: 0x000E904C
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

		// Token: 0x1700121D RID: 4637
		// (get) Token: 0x06006159 RID: 24921 RVA: 0x000EAE55 File Offset: 0x000E9055
		// (set) Token: 0x0600615A RID: 24922 RVA: 0x000EAE5D File Offset: 0x000E905D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DragonPoolConf DragonPoolConf
		{
			get
			{
				return this.dragonPoolConf_;
			}
			set
			{
				this.dragonPoolConf_ = value;
			}
		}

		// Token: 0x0600615B RID: 24923 RVA: 0x000EAE66 File Offset: 0x000E9066
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DragonPoolConfResponse);
		}

		// Token: 0x0600615C RID: 24924 RVA: 0x000EAE74 File Offset: 0x000E9074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DragonPoolConfResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.DragonPoolConf, other.DragonPoolConf) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600615D RID: 24925 RVA: 0x000EAEC4 File Offset: 0x000E90C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.dragonPoolConf_ != null)
			{
				num ^= this.DragonPoolConf.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600615E RID: 24926 RVA: 0x000EAF1F File Offset: 0x000E911F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600615F RID: 24927 RVA: 0x000EAF2C File Offset: 0x000E912C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006160 RID: 24928 RVA: 0x000EAF38 File Offset: 0x000E9138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.dragonPoolConf_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.DragonPoolConf);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006161 RID: 24929 RVA: 0x000EAF94 File Offset: 0x000E9194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.dragonPoolConf_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DragonPoolConf);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006162 RID: 24930 RVA: 0x000EAFEC File Offset: 0x000E91EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DragonPoolConfResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.dragonPoolConf_ != null)
			{
				if (this.dragonPoolConf_ == null)
				{
					this.DragonPoolConf = new DragonPoolConf();
				}
				this.DragonPoolConf.MergeFrom(other.DragonPoolConf);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006163 RID: 24931 RVA: 0x000EB054 File Offset: 0x000E9254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006164 RID: 24932 RVA: 0x000EB060 File Offset: 0x000E9260
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
				if (num != 58U)
				{
					if (num != 72U)
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
					if (this.dragonPoolConf_ == null)
					{
						this.DragonPoolConf = new DragonPoolConf();
					}
					input.ReadMessage(this.DragonPoolConf);
				}
			}
		}

		// Token: 0x040037E6 RID: 14310
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037E7 RID: 14311
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x040037E8 RID: 14312
		private ErrorCode errorCode_;

		// Token: 0x040037E9 RID: 14313
		public const int DragonPoolConfFieldNumber = 7;

		// Token: 0x040037EA RID: 14314
		private DragonPoolConf dragonPoolConf_;
	}
}
