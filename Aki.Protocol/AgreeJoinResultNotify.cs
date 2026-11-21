using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000D9 RID: 217
	[NetMessage(EMessageId.AgreeJoinResultNotify)]
	public sealed class AgreeJoinResultNotify : IMessage<AgreeJoinResultNotify>, IMessage, IEquatable<AgreeJoinResultNotify>, IDeepCloneable<AgreeJoinResultNotify>, IBufferMessage
	{
		// Token: 0x060020E0 RID: 8416 RVA: 0x00058856 File Offset: 0x00056A56
		[NullableContext(1)]
		public static AgreeJoinResultNotify Create()
		{
			return new AgreeJoinResultNotify();
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x060020E1 RID: 8417 RVA: 0x0005885D File Offset: 0x00056A5D
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
		// (get) Token: 0x060020E2 RID: 8418 RVA: 0x00058860 File Offset: 0x00056A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AgreeJoinResultNotify.Descriptor;
			}
		}

		// Token: 0x060020E3 RID: 8419 RVA: 0x00058867 File Offset: 0x00056A67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AgreeJoinResultNotify()
		{
		}

		// Token: 0x060020E4 RID: 8420 RVA: 0x0005887A File Offset: 0x00056A7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AgreeJoinResultNotify(AgreeJoinResultNotify other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.playerName_ = other.playerName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060020E5 RID: 8421 RVA: 0x000588AB File Offset: 0x00056AAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AgreeJoinResultNotify Clone()
		{
			return new AgreeJoinResultNotify(this);
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x060020E6 RID: 8422 RVA: 0x000588B3 File Offset: 0x00056AB3
		// (set) Token: 0x060020E7 RID: 8423 RVA: 0x000588BB File Offset: 0x00056ABB
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
		// (get) Token: 0x060020E8 RID: 8424 RVA: 0x000588C4 File Offset: 0x00056AC4
		// (set) Token: 0x060020E9 RID: 8425 RVA: 0x000588CC File Offset: 0x00056ACC
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

		// Token: 0x060020EA RID: 8426 RVA: 0x000588DF File Offset: 0x00056ADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AgreeJoinResultNotify);
		}

		// Token: 0x060020EB RID: 8427 RVA: 0x000588F0 File Offset: 0x00056AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AgreeJoinResultNotify other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && !(this.PlayerName != other.PlayerName) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060020EC RID: 8428 RVA: 0x00058940 File Offset: 0x00056B40
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

		// Token: 0x060020ED RID: 8429 RVA: 0x000589A0 File Offset: 0x00056BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060020EE RID: 8430 RVA: 0x000589AD File Offset: 0x00056BAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060020EF RID: 8431 RVA: 0x000589B8 File Offset: 0x00056BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerName.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.PlayerName);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060020F0 RID: 8432 RVA: 0x00058A18 File Offset: 0x00056C18
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

		// Token: 0x060020F1 RID: 8433 RVA: 0x00058A74 File Offset: 0x00056C74
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

		// Token: 0x060020F2 RID: 8434 RVA: 0x00058AC9 File Offset: 0x00056CC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060020F3 RID: 8435 RVA: 0x00058AD4 File Offset: 0x00056CD4
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
					if (num != 16U)
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

		// Token: 0x04002462 RID: 9314
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002463 RID: 9315
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04002464 RID: 9316
		private ErrorCode errorCode_;

		// Token: 0x04002465 RID: 9317
		public const int PlayerNameFieldNumber = 1;

		// Token: 0x04002466 RID: 9318
		private string playerName_ = "";
	}
}
