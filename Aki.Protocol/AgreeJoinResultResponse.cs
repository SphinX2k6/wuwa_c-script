using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000DA RID: 218
	[NetMessage(EMessageId.AgreeJoinResultResponse)]
	public sealed class AgreeJoinResultResponse : IMessage<AgreeJoinResultResponse>, IMessage, IEquatable<AgreeJoinResultResponse>, IDeepCloneable<AgreeJoinResultResponse>, IBufferMessage
	{
		// Token: 0x060020C1 RID: 8385 RVA: 0x000581BB File Offset: 0x000563BB
		[NullableContext(1)]
		public static AgreeJoinResultResponse Create()
		{
			return new AgreeJoinResultResponse();
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x060020C2 RID: 8386 RVA: 0x000581C2 File Offset: 0x000563C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x060020C3 RID: 8387 RVA: 0x000581C5 File Offset: 0x000563C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AgreeJoinResultResponse.Descriptor;
			}
		}

		// Token: 0x060020C4 RID: 8388 RVA: 0x000581CC File Offset: 0x000563CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AgreeJoinResultResponse()
		{
		}

		// Token: 0x060020C5 RID: 8389 RVA: 0x000581DF File Offset: 0x000563DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AgreeJoinResultResponse(AgreeJoinResultResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.playerName_ = other.playerName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060020C6 RID: 8390 RVA: 0x00058210 File Offset: 0x00056410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AgreeJoinResultResponse Clone()
		{
			return new AgreeJoinResultResponse(this);
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x060020C7 RID: 8391 RVA: 0x00058218 File Offset: 0x00056418
		// (set) Token: 0x060020C8 RID: 8392 RVA: 0x00058220 File Offset: 0x00056420
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

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x060020C9 RID: 8393 RVA: 0x00058229 File Offset: 0x00056429
		// (set) Token: 0x060020CA RID: 8394 RVA: 0x00058231 File Offset: 0x00056431
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PlayerName
		{
			get
			{
				return this.playerName_;
			}
			set
			{
				this.playerName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x060020CB RID: 8395 RVA: 0x00058244 File Offset: 0x00056444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AgreeJoinResultResponse);
		}

		// Token: 0x060020CC RID: 8396 RVA: 0x00058254 File Offset: 0x00056454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AgreeJoinResultResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && !(this.PlayerName != other.PlayerName) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060020CD RID: 8397 RVA: 0x000582A4 File Offset: 0x000564A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.PlayerName.Length != 0)
			{
				num ^= this.PlayerName.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060020CE RID: 8398 RVA: 0x00058304 File Offset: 0x00056504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060020CF RID: 8399 RVA: 0x00058311 File Offset: 0x00056511
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060020D0 RID: 8400 RVA: 0x0005831C File Offset: 0x0005651C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerName.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.PlayerName);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060020D1 RID: 8401 RVA: 0x0005837C File Offset: 0x0005657C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.PlayerName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PlayerName);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060020D2 RID: 8402 RVA: 0x000583D8 File Offset: 0x000565D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AgreeJoinResultResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.PlayerName.Length != 0)
			{
				this.PlayerName = other.PlayerName;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060020D3 RID: 8403 RVA: 0x0005842D File Offset: 0x0005662D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x00058438 File Offset: 0x00056638
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
				if (num != 74U)
				{
					if (num != 104U)
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
					this.PlayerName = input.ReadString();
				}
			}
		}

		// Token: 0x0400240B RID: 9227
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400240C RID: 9228
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x0400240D RID: 9229
		private ErrorCode errorCode_;

		// Token: 0x0400240E RID: 9230
		public const int PlayerNameFieldNumber = 9;

		// Token: 0x0400240F RID: 9231
		private string playerName_ = "";
	}
}
