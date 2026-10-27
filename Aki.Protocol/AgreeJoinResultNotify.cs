using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000D8 RID: 216
	[NetMessage(EMessageId.AgreeJoinResultNotify)]
	public sealed class AgreeJoinResultNotify : IMessage<AgreeJoinResultNotify>, IMessage, IEquatable<AgreeJoinResultNotify>, IDeepCloneable<AgreeJoinResultNotify>, IBufferMessage
	{
		// Token: 0x06002097 RID: 8343 RVA: 0x00057BA2 File Offset: 0x00055DA2
		[NullableContext(1)]
		public static AgreeJoinResultNotify Create()
		{
			return new AgreeJoinResultNotify();
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06002098 RID: 8344 RVA: 0x00057BA9 File Offset: 0x00055DA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06002099 RID: 8345 RVA: 0x00057BAC File Offset: 0x00055DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AgreeJoinResultNotify.Descriptor;
			}
		}

		// Token: 0x0600209A RID: 8346 RVA: 0x00057BB3 File Offset: 0x00055DB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AgreeJoinResultNotify()
		{
		}

		// Token: 0x0600209B RID: 8347 RVA: 0x00057BC6 File Offset: 0x00055DC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AgreeJoinResultNotify(AgreeJoinResultNotify other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.playerName_ = other.playerName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600209C RID: 8348 RVA: 0x00057BF7 File Offset: 0x00055DF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AgreeJoinResultNotify Clone()
		{
			return new AgreeJoinResultNotify(this);
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x0600209D RID: 8349 RVA: 0x00057BFF File Offset: 0x00055DFF
		// (set) Token: 0x0600209E RID: 8350 RVA: 0x00057C07 File Offset: 0x00055E07
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

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x0600209F RID: 8351 RVA: 0x00057C10 File Offset: 0x00055E10
		// (set) Token: 0x060020A0 RID: 8352 RVA: 0x00057C18 File Offset: 0x00055E18
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

		// Token: 0x060020A1 RID: 8353 RVA: 0x00057C2B File Offset: 0x00055E2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AgreeJoinResultNotify);
		}

		// Token: 0x060020A2 RID: 8354 RVA: 0x00057C3C File Offset: 0x00055E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AgreeJoinResultNotify other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && !(this.PlayerName != other.PlayerName) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060020A3 RID: 8355 RVA: 0x00057C8C File Offset: 0x00055E8C
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

		// Token: 0x060020A4 RID: 8356 RVA: 0x00057CEC File Offset: 0x00055EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060020A5 RID: 8357 RVA: 0x00057CF9 File Offset: 0x00055EF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060020A6 RID: 8358 RVA: 0x00057D04 File Offset: 0x00055F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.PlayerName.Length != 0)
			{
				output.WriteRawTag(106);
				output.WriteString(this.PlayerName);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060020A7 RID: 8359 RVA: 0x00057D64 File Offset: 0x00055F64
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

		// Token: 0x060020A8 RID: 8360 RVA: 0x00057DC0 File Offset: 0x00055FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AgreeJoinResultNotify other)
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

		// Token: 0x060020A9 RID: 8361 RVA: 0x00057E15 File Offset: 0x00056015
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060020AA RID: 8362 RVA: 0x00057E20 File Offset: 0x00056020
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
				if (num != 96U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PlayerName = input.ReadString();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040023FF RID: 9215
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002400 RID: 9216
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04002401 RID: 9217
		private ErrorCode errorCode_;

		// Token: 0x04002402 RID: 9218
		public const int PlayerNameFieldNumber = 13;

		// Token: 0x04002403 RID: 9219
		private string playerName_ = "";
	}
}
