using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000400 RID: 1024
	[NetMessage(EMessageId.DragonPoolConfResponse)]
	public sealed class DragonPoolConfResponse : IMessage<DragonPoolConfResponse>, IMessage, IEquatable<DragonPoolConfResponse>, IDeepCloneable<DragonPoolConfResponse>, IBufferMessage
	{
		// Token: 0x060062E1 RID: 25313 RVA: 0x000EDF4D File Offset: 0x000EC14D
		[NullableContext(1)]
		public static DragonPoolConfResponse Create()
		{
			return new DragonPoolConfResponse();
		}

		// Token: 0x1700126F RID: 4719
		// (get) Token: 0x060062E2 RID: 25314 RVA: 0x000EDF54 File Offset: 0x000EC154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001270 RID: 4720
		// (get) Token: 0x060062E3 RID: 25315 RVA: 0x000EDF57 File Offset: 0x000EC157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DragonPoolConfResponse.Descriptor;
			}
		}

		// Token: 0x060062E4 RID: 25316 RVA: 0x000EDF5E File Offset: 0x000EC15E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DragonPoolConfResponse()
		{
		}

		// Token: 0x060062E5 RID: 25317 RVA: 0x000EDF68 File Offset: 0x000EC168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DragonPoolConfResponse(DragonPoolConfResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.dragonPoolConf_ = ((other.dragonPoolConf_ != null) ? other.dragonPoolConf_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060062E6 RID: 25318 RVA: 0x000EDFB4 File Offset: 0x000EC1B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DragonPoolConfResponse Clone()
		{
			return new DragonPoolConfResponse(this);
		}

		// Token: 0x17001271 RID: 4721
		// (get) Token: 0x060062E7 RID: 25319 RVA: 0x000EDFBC File Offset: 0x000EC1BC
		// (set) Token: 0x060062E8 RID: 25320 RVA: 0x000EDFC4 File Offset: 0x000EC1C4
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

		// Token: 0x17001272 RID: 4722
		// (get) Token: 0x060062E9 RID: 25321 RVA: 0x000EDFCD File Offset: 0x000EC1CD
		// (set) Token: 0x060062EA RID: 25322 RVA: 0x000EDFD5 File Offset: 0x000EC1D5
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

		// Token: 0x060062EB RID: 25323 RVA: 0x000EDFDE File Offset: 0x000EC1DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DragonPoolConfResponse);
		}

		// Token: 0x060062EC RID: 25324 RVA: 0x000EDFEC File Offset: 0x000EC1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DragonPoolConfResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.DragonPoolConf, other.DragonPoolConf) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060062ED RID: 25325 RVA: 0x000EE03C File Offset: 0x000EC23C
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

		// Token: 0x060062EE RID: 25326 RVA: 0x000EE097 File Offset: 0x000EC297
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060062EF RID: 25327 RVA: 0x000EE0A4 File Offset: 0x000EC2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060062F0 RID: 25328 RVA: 0x000EE0B0 File Offset: 0x000EC2B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.dragonPoolConf_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.DragonPoolConf);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060062F1 RID: 25329 RVA: 0x000EE10C File Offset: 0x000EC30C
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

		// Token: 0x060062F2 RID: 25330 RVA: 0x000EE164 File Offset: 0x000EC364
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

		// Token: 0x060062F3 RID: 25331 RVA: 0x000EE1CC File Offset: 0x000EC3CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060062F4 RID: 25332 RVA: 0x000EE1D8 File Offset: 0x000EC3D8
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
					if (num != 32U)
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

		// Token: 0x040037F9 RID: 14329
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037FA RID: 14330
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x040037FB RID: 14331
		private ErrorCode errorCode_;

		// Token: 0x040037FC RID: 14332
		public const int DragonPoolConfFieldNumber = 2;

		// Token: 0x040037FD RID: 14333
		private DragonPoolConf dragonPoolConf_;
	}
}
